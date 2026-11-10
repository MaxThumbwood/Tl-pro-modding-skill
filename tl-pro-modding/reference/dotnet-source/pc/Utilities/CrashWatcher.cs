// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.CrashWatcher
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading;

#nullable disable
namespace Terraria.Utilities;

public static class CrashWatcher
{
  public static bool LogAllExceptions { get; set; }

  public static bool DumpOnException { get; set; }

  public static bool DumpOnCrash { get; private set; }

  public static CrashDump.Options CrashDumpOptions { get; private set; }

  private static string DumpPath => Path.Combine(Main.SavePath, "Dumps");

  public static void Inititialize()
  {
    Console.WriteLine("Error Logging Enabled.");
    AppDomain.CurrentDomain.FirstChanceException += (EventHandler<FirstChanceExceptionEventArgs>) ((sender, exceptionArgs) =>
    {
      if (Main.IsFullScreenThatWouldBeStuckOnCrashMessage() || !CrashWatcher.LogAllExceptions)
        return;
      Console.Write("================\r\n" + $"{DateTime.Now}: First-Chance Exception\r\nThread: {Thread.CurrentThread.ManagedThreadId} [{Thread.CurrentThread.Name}]\r\nCulture: {Thread.CurrentThread.CurrentCulture.Name}\r\nException: {CrashWatcher.PrintException(exceptionArgs.Exception)}\r\n" + "================\r\n\r\n");
    });
    AppDomain.CurrentDomain.UnhandledException += (UnhandledExceptionEventHandler) ((sender, exceptionArgs) =>
    {
      if (Main.IsFullScreenThatWouldBeStuckOnCrashMessage())
        return;
      Console.Write("================\r\n" + $"{DateTime.Now}: Unhandled Exception\r\nThread: {Thread.CurrentThread.ManagedThreadId} [{Thread.CurrentThread.Name}]\r\nCulture: {Thread.CurrentThread.CurrentCulture.Name}\r\nException: {CrashWatcher.PrintException((Exception) exceptionArgs.ExceptionObject)}\r\n" + "================\r\n");
      if (!CrashWatcher.DumpOnCrash)
        return;
      CrashDump.WriteException(CrashWatcher.CrashDumpOptions, CrashWatcher.DumpPath);
    });
  }

  private static string PrintException(Exception ex)
  {
    string str = ex.ToString();
    try
    {
      int num = (int) typeof (Exception).GetProperty("HResult", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetGetMethod(true).Invoke((object) ex, (object[]) null);
      if (num != 0)
        str = $"{str}\nHResult: {(object) num}";
    }
    catch
    {
    }
    if (ex is ReflectionTypeLoadException)
    {
      foreach (Exception loaderException in ((ReflectionTypeLoadException) ex).LoaderExceptions)
        str = $"{str}\n+--> {CrashWatcher.PrintException(loaderException)}";
    }
    return str;
  }

  public static void EnableCrashDumps(CrashDump.Options options)
  {
    CrashWatcher.DumpOnCrash = true;
    CrashWatcher.CrashDumpOptions = options;
  }

  public static void DisableCrashDumps() => CrashWatcher.DumpOnCrash = false;

  [Conditional("DEBUG")]
  private static void HookDebugExceptionDialog()
  {
  }
}
