// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.LockstepDebug
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

#nullable disable
namespace Terraria.Testing;

public static class LockstepDebug
{
  private static long stepCount;
  private static long lastSuccessfulStep;
  private static bool stopAtLastStep;
  private static LockstepDebug.ExpensiveStepRateState expensiveStepState;
  private static bool _init;
  private static bool isHost;
  private static string Identifier = "Terraria.LockstepDebug";
  private static int BufSize = (int) ushort.MaxValue;
  private static BinaryReader _reader;
  private static BinaryWriter _writer;
  private static readonly object _lock = new object();
  private static string _controlCode = "ģ4䕧";

  public static bool Enabled { get; private set; }

  private static void Init()
  {
    if (LockstepDebug._init)
      return;
    PipeStream pipeStream;
    try
    {
      NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(LockstepDebug.Identifier);
      pipeClientStream.Connect(1);
      pipeStream = (PipeStream) pipeClientStream;
      Trace.WriteLine("LockstepDebug connected to server.");
    }
    catch (TimeoutException ex)
    {
      Trace.WriteLine("LockstepDebug waiting for connection from client.");
      LockstepDebug.isHost = true;
      NamedPipeServerStream pipeServerStream = new NamedPipeServerStream(LockstepDebug.Identifier, PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.WriteThrough, LockstepDebug.BufSize, LockstepDebug.BufSize);
      pipeServerStream.WaitForConnection();
      pipeStream = (PipeStream) pipeServerStream;
    }
    LockstepDebug._reader = new BinaryReader((Stream) pipeStream);
    LockstepDebug._writer = new BinaryWriter((Stream) pipeStream);
    LockstepDebug.WriteStep(nameof (Init));
    if (LockstepDebug.ReadStep() != nameof (Init))
      throw new Exception("Shared memory communication failed");
    LockstepDebug._init = true;
  }

  public static void Enable()
  {
    LockstepDebug.Init();
    LockstepDebug.Enabled = true;
    bool increaseThreshold = false;
    if (LockstepDebug.lastSuccessfulStep == 0L)
      Trace.WriteLine("LockstepDebug enabled.");
    else if (LockstepDebug.stepCount == LockstepDebug.lastSuccessfulStep + 1L)
    {
      LockstepDebug.stopAtLastStep = true;
      Trace.WriteLine("LockstepDebug rerun detected. Skipping to and stopping at step " + (object) LockstepDebug.lastSuccessfulStep);
    }
    else
    {
      Trace.WriteLine($"LockstepDebug rerun detected. Skipping to step {LockstepDebug.lastSuccessfulStep}. Up to {LockstepDebug.stepCount - LockstepDebug.lastSuccessfulStep} steps to find mismatch.");
      if (LockstepDebug.expensiveStepState.stepRateIncreaseCount == 1)
        increaseThreshold = true;
    }
    LockstepDebug.WriteStep(nameof (Enable));
    if (LockstepDebug.ReadStep() != nameof (Enable))
      throw new Exception("Enable sync failed");
    LockstepDebug.stepCount = 0L;
    LockstepDebug.expensiveStepState = new LockstepDebug.ExpensiveStepRateState(increaseThreshold);
  }

  public static void ExpensiveStep<T>(Func<T> expensiveArg, params object[] args)
  {
    if (!LockstepDebug.Enabled)
      return;
    if (LockstepDebug.stepCount + 1L < LockstepDebug.lastSuccessfulStep)
      ++LockstepDebug.stepCount;
    else if (LockstepDebug.expensiveStepState.remainingSkips > 0L)
    {
      ++LockstepDebug.stepCount;
      --LockstepDebug.expensiveStepState.remainingSkips;
    }
    else
    {
      if (LockstepDebug.isHost)
        LockstepDebug.expensiveStepState.CheckAndIncreaseStepRate();
      LockstepDebug.expensiveStepState.stepTime.Start();
      LockstepDebug.Step((object) expensiveArg(), (object) string.Join(", ", args));
      LockstepDebug.expensiveStepState.stepTime.Stop();
      ++LockstepDebug.expensiveStepState.timedStepCount;
      LockstepDebug.expensiveStepState.remainingSkips = LockstepDebug.expensiveStepState.stepRate - 1L;
    }
  }

  public static void Step(params object[] args) => LockstepDebug.Step(string.Join(", ", args));

  public static void Step(string state)
  {
    if (!LockstepDebug.Enabled)
      return;
    if (state.Length > LockstepDebug.BufSize / 2)
      throw new ArgumentException("String too large");
    ++LockstepDebug.stepCount;
    if (LockstepDebug.stepCount < LockstepDebug.lastSuccessfulStep)
      return;
    LockstepDebug.WriteStep(state);
    string str = LockstepDebug.ReadStep();
    if (str != state)
    {
      LockstepDebug.Enabled = false;
      Trace.WriteLine($"Lockstep mismatch. Step: {LockstepDebug.stepCount}\nSent: {state}\nRecv: {str}");
      if (LockstepDebug.lastSuccessfulStep < LockstepDebug.stepCount - 1L)
      {
        Trace.WriteLine($"Expensive steps were skipped. Rerun to narrow down the mismatch. Last successful step was {LockstepDebug.stepCount - LockstepDebug.lastSuccessfulStep} steps ago");
      }
      else
      {
        if (LockstepDebug.lastSuccessfulStep == LockstepDebug.stepCount)
          Trace.WriteLine("Last successful step mismatch. The rerun was not deterministic.");
        if (Debugger.IsAttached)
          Debugger.Break();
        else
          Debugger.Launch();
      }
    }
    else
    {
      if (LockstepDebug.stepCount == LockstepDebug.lastSuccessfulStep && LockstepDebug.stopAtLastStep)
      {
        Trace.WriteLine("LockstepDebug reached the last match from the previous run. Debug from here to identify desync");
        if (Debugger.IsAttached)
          Debugger.Break();
        else
          Debugger.Launch();
      }
      LockstepDebug.lastSuccessfulStep = LockstepDebug.stepCount;
    }
  }

  private static void WriteStep(string state) => LockstepDebug._writer.Write(state);

  private static string ReadStep()
  {
    string str;
    while (true)
    {
      str = LockstepDebug._reader.ReadString();
      if (str.StartsWith(LockstepDebug._controlCode))
        LockstepDebug.HandleControlMessage(str.Substring(LockstepDebug._controlCode.Length));
      else
        break;
    }
    return str;
  }

  private static void WriteControlMessage(string s)
  {
    LockstepDebug._writer.Write(LockstepDebug._controlCode + s);
  }

  private static void HandleControlMessage(string v)
  {
    if (!v.StartsWith("StepRate: "))
      return;
    int num = int.Parse(v.Substring("StepRate: ".Length));
    Trace.WriteLine("LockstepDebug control message received. Reducing step rate to 1 in " + (object) num);
    ++LockstepDebug.expensiveStepState.stepRateIncreaseCount;
    LockstepDebug.expensiveStepState.stepRate = (long) num;
  }

  private struct ExpensiveStepRateState(bool increaseThreshold)
  {
    public long stepRate = 1;
    public long remainingSkips = 0;
    public int stepRateIncreaseCount = 0;
    public TimeSpan stepRateIncreaseThreshold = TimeSpan.FromSeconds(increaseThreshold ? 30.0 : 20.0);
    public Stopwatch stepTime = new Stopwatch();
    public long timedStepCount = 0;

    internal void CheckAndIncreaseStepRate()
    {
      if (this.stepTime.Elapsed < this.stepRateIncreaseThreshold || this.timedStepCount <= 1L)
        return;
      ++this.stepRateIncreaseCount;
      this.stepRate *= this.timedStepCount;
      this.timedStepCount = 0L;
      this.stepTime.Restart();
      Trace.WriteLine("LockstepDebug is taking too long. Reducing step rate to 1 in " + (object) this.stepRate);
      LockstepDebug.WriteControlMessage("StepRate: " + (object) this.stepRate);
    }
  }
}
