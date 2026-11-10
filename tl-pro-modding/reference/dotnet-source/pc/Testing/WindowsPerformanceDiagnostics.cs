// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.WindowsPerformanceDiagnostics
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.OS;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Terraria.Testing;

public class WindowsPerformanceDiagnostics
{
  private static readonly uint PDH_FMT_DOUBLE = 512 /*0x0200*/;
  private static Thread _monitorThread;
  private static object _lock = new object();
  private static WindowsPerformanceDiagnostics.Data _data;
  private static readonly float ContentionPerfDropThreshold = 0.8f;
  private static readonly int ConsecutiveContentionChecksBeforeUnpin = 20;
  private static int _unpinHintCount = 0;
  private static IntPtr queryHandle = IntPtr.Zero;
  private static IntPtr processorPerformanceHandle = IntPtr.Zero;
  private static IntPtr processorQueueLengthHandle = IntPtr.Zero;
  private static IntPtr threadProcessorTimeHandle = IntPtr.Zero;
  private static IntPtr threadProcessIdHandle = IntPtr.Zero;
  private static readonly string ProcessName = Process.GetCurrentProcess().ProcessName;
  private static readonly int PID = Process.GetCurrentProcess().Id;
  private static int ProcessCopyNumber = 0;
  private static int MonitoringCoreNumber = 0;

  public static bool Supported => Platform.IsWindows;

  [DllImport("Kernel32.dll")]
  private static extern int GetCurrentProcessorNumber();

  [DllImport("Pdh.dll", SetLastError = true)]
  private static extern int PdhOpenQuery(IntPtr dataSource, IntPtr userData, out IntPtr query);

  [DllImport("Pdh.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern int PdhAddCounter(
    IntPtr query,
    string counterPath,
    IntPtr userData,
    out IntPtr counter);

  [DllImport("Pdh.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern int PdhRemoveCounter(IntPtr counter);

  [DllImport("Pdh.dll", SetLastError = true)]
  private static extern int PdhCollectQueryData(IntPtr query);

  [DllImport("Pdh.dll", SetLastError = true)]
  private static extern int PdhGetFormattedCounterValue(
    IntPtr counter,
    uint format,
    out uint type,
    out WindowsPerformanceDiagnostics.PDH_FMT_COUNTERVALUE value);

  [DllImport("Pdh.dll", SetLastError = true)]
  private static extern int PdhCloseQuery(IntPtr query);

  [DllImport("kernel32.dll")]
  private static extern IntPtr GetCurrentThread();

  [DllImport("kernel32.dll")]
  private static extern bool SetThreadAffinityMask(IntPtr hThread, IntPtr dwThreadAffinityMask);

  [DllImport("kernel32.dll")]
  private static extern uint SetThreadIdealProcessor(IntPtr hThread, uint dwIdealProcessor);

  public static WindowsPerformanceDiagnostics.Data GetData()
  {
    lock (WindowsPerformanceDiagnostics._lock)
    {
      if (WindowsPerformanceDiagnostics._monitorThread == null)
      {
        WindowsPerformanceDiagnostics._data.PinnedToProcessor = true;
        WindowsPerformanceDiagnostics._data.CurrentProcessor = WindowsPerformanceDiagnostics.GetCurrentProcessorNumber();
        WindowsPerformanceDiagnostics._monitorThread = new Thread(new ThreadStart(WindowsPerformanceDiagnostics.MonitorPerformanceCounters))
        {
          IsBackground = true,
          Name = "Perf Counter Monitoring"
        };
        WindowsPerformanceDiagnostics._monitorThread.Start();
      }
      else
      {
        int currentProcessorNumber = WindowsPerformanceDiagnostics.GetCurrentProcessorNumber();
        if (WindowsPerformanceDiagnostics._data.CurrentProcessor != currentProcessorNumber)
          WindowsPerformanceDiagnostics._data.PinnedToProcessor = false;
        WindowsPerformanceDiagnostics._data.CurrentProcessor = currentProcessorNumber;
      }
      WindowsPerformanceDiagnostics._data.ExpectedCPUPercent = (double) DetailedFPS.GetCPUUtilization(60) * 100.0;
      return WindowsPerformanceDiagnostics._data;
    }
  }

  private static bool ShouldRecommendUnpinning()
  {
    if (Environment.ProcessorCount < 4)
      return false;
    int num1;
    if (WindowsPerformanceDiagnostics._data.PinnedToProcessor && WindowsPerformanceDiagnostics._data.CurrentProcessor == 0)
    {
      long? contentionQueueLength = WindowsPerformanceDiagnostics._data.ContentionQueueLength;
      long num2 = 0;
      if (contentionQueueLength.GetValueOrDefault() > num2 & contentionQueueLength.HasValue)
      {
        double? threadCpuPercent = WindowsPerformanceDiagnostics._data.MainThreadCPUPercent;
        double num3 = WindowsPerformanceDiagnostics._data.ExpectedCPUPercent * (double) WindowsPerformanceDiagnostics.ContentionPerfDropThreshold;
        num1 = threadCpuPercent.GetValueOrDefault() < num3 & threadCpuPercent.HasValue ? 1 : 0;
        goto label_6;
      }
    }
    num1 = 0;
label_6:
    if (num1 != 0)
      ++WindowsPerformanceDiagnostics._unpinHintCount;
    else
      WindowsPerformanceDiagnostics._unpinHintCount = 0;
    return WindowsPerformanceDiagnostics._unpinHintCount >= WindowsPerformanceDiagnostics.ConsecutiveContentionChecksBeforeUnpin;
  }

  public static void UnpinFromCore0()
  {
    int allProcMask = (1 << Environment.ProcessorCount) - 1;
    Process.GetCurrentProcess().ProcessorAffinity = (IntPtr) (allProcMask ^ 1);
    Task.Factory.StartNew((Action) (() =>
    {
      Thread.Sleep(100);
      Process.GetCurrentProcess().ProcessorAffinity = (IntPtr) allProcMask;
    }));
  }

  private static string GetMainThreadCounterIdentifier()
  {
    return $"\\Thread({WindowsPerformanceDiagnostics.ProcessName}/0{(WindowsPerformanceDiagnostics.ProcessCopyNumber == 0 ? (object) "" : (object) ("#" + (object) WindowsPerformanceDiagnostics.ProcessCopyNumber))})";
  }

  private static bool AddCounter(string name, ref IntPtr handle)
  {
    if (handle != IntPtr.Zero)
      WindowsPerformanceDiagnostics.PdhRemoveCounter(handle);
    return WindowsPerformanceDiagnostics.PdhAddCounter(WindowsPerformanceDiagnostics.queryHandle, name, IntPtr.Zero, out handle) != 0;
  }

  private static bool ReadCounter(IntPtr handle, out double value)
  {
    WindowsPerformanceDiagnostics.PDH_FMT_COUNTERVALUE pdhFmtCountervalue;
    if (WindowsPerformanceDiagnostics.PdhGetFormattedCounterValue(handle, WindowsPerformanceDiagnostics.PDH_FMT_DOUBLE, out uint _, out pdhFmtCountervalue) == 0)
    {
      value = pdhFmtCountervalue.doubleValue;
      return true;
    }
    value = 0.0;
    return false;
  }

  private static void ReadCounter(IntPtr handle, out double? value)
  {
    double num;
    if (handle != IntPtr.Zero && WindowsPerformanceDiagnostics.ReadCounter(handle, out num))
      value = new double?(num);
    else
      value = new double?();
  }

  private static void MonitorPerformanceCounters()
  {
    if (WindowsPerformanceDiagnostics.PdhOpenQuery(IntPtr.Zero, IntPtr.Zero, out WindowsPerformanceDiagnostics.queryHandle) != 0)
      return;
    WindowsPerformanceDiagnostics.AddCounter("\\System\\Processor Queue Length", ref WindowsPerformanceDiagnostics.processorQueueLengthHandle);
    WindowsPerformanceDiagnostics.RecreateCoreCounters();
    WindowsPerformanceDiagnostics.RecreateThreadCounters();
    while (true)
    {
      int num1 = WindowsPerformanceDiagnostics._data.PinnedToProcessor ? WindowsPerformanceDiagnostics._data.CurrentProcessor : -1;
      if (num1 != WindowsPerformanceDiagnostics.MonitoringCoreNumber)
      {
        WindowsPerformanceDiagnostics.MonitoringCoreNumber = num1;
        WindowsPerformanceDiagnostics.RecreateCoreCounters();
      }
      Thread.Sleep(250);
      WindowsPerformanceDiagnostics.PdhCollectQueryData(WindowsPerformanceDiagnostics.queryHandle);
      double? nullable1;
      WindowsPerformanceDiagnostics.ReadCounter(WindowsPerformanceDiagnostics.processorPerformanceHandle, out nullable1);
      double? nullable2;
      WindowsPerformanceDiagnostics.ReadCounter(WindowsPerformanceDiagnostics.processorQueueLengthHandle, out nullable2);
      double num2;
      if (!WindowsPerformanceDiagnostics.ReadCounter(WindowsPerformanceDiagnostics.threadProcessIdHandle, out num2))
      {
        WindowsPerformanceDiagnostics.ProcessCopyNumber = 0;
        WindowsPerformanceDiagnostics.RecreateThreadCounters();
      }
      else if (num2 != (double) WindowsPerformanceDiagnostics.PID)
      {
        ++WindowsPerformanceDiagnostics.ProcessCopyNumber;
        WindowsPerformanceDiagnostics.RecreateThreadCounters();
      }
      else
      {
        double? newValue;
        WindowsPerformanceDiagnostics.ReadCounter(WindowsPerformanceDiagnostics.threadProcessorTimeHandle, out newValue);
        lock (WindowsPerformanceDiagnostics._lock)
        {
          WindowsPerformanceDiagnostics._data.ProcessorThrottlePercent = nullable1;
          WindowsPerformanceDiagnostics._data.ContentionQueueLength = nullable2.HasValue ? new long?((long) nullable2.Value) : new long?();
          WindowsPerformanceDiagnostics.LowPassUpdate(ref WindowsPerformanceDiagnostics._data.MainThreadCPUPercent, newValue, 0.25f);
          WindowsPerformanceDiagnostics._data.RecommendUnpinning = WindowsPerformanceDiagnostics.ShouldRecommendUnpinning();
        }
      }
    }
  }

  private static void LowPassUpdate(ref double? filtered, double? newValue, float rate)
  {
    if (!filtered.HasValue || !newValue.HasValue)
    {
      filtered = newValue;
    }
    else
    {
      ref double? local = ref filtered;
      double? nullable1 = filtered;
      double num1 = 1.0 - (double) rate;
      double? nullable2 = nullable1.HasValue ? new double?(nullable1.GetValueOrDefault() * num1) : new double?();
      nullable1 = newValue;
      double num2 = (double) rate;
      double? nullable3 = nullable1.HasValue ? new double?(nullable1.GetValueOrDefault() * num2) : new double?();
      double? nullable4;
      if (!(nullable2.HasValue & nullable3.HasValue))
      {
        nullable1 = new double?();
        nullable4 = nullable1;
      }
      else
        nullable4 = new double?(nullable2.GetValueOrDefault() + nullable3.GetValueOrDefault());
      local = nullable4;
    }
  }

  private static void RecreateCoreCounters()
  {
    WindowsPerformanceDiagnostics.AddCounter($"\\Processor Information(0,{(WindowsPerformanceDiagnostics.MonitoringCoreNumber < 0 ? "_Total" : WindowsPerformanceDiagnostics.MonitoringCoreNumber.ToString())})\\% Processor Performance", ref WindowsPerformanceDiagnostics.processorPerformanceHandle);
  }

  private static void RecreateThreadCounters()
  {
    WindowsPerformanceDiagnostics.AddCounter(WindowsPerformanceDiagnostics.GetMainThreadCounterIdentifier() + "\\% Processor Time", ref WindowsPerformanceDiagnostics.threadProcessorTimeHandle);
    WindowsPerformanceDiagnostics.AddCounter(WindowsPerformanceDiagnostics.GetMainThreadCounterIdentifier() + "\\ID Process", ref WindowsPerformanceDiagnostics.threadProcessIdHandle);
  }

  public struct Data
  {
    public double? ProcessorThrottlePercent;
    public double? MainThreadCPUPercent;
    public double ExpectedCPUPercent;
    public long? ContentionQueueLength;
    public int CurrentProcessor;
    public bool PinnedToProcessor;
    public bool RecommendUnpinning;
  }

  private struct PDH_FMT_COUNTERVALUE
  {
    public int CStatus;
    public double doubleValue;
  }
}
