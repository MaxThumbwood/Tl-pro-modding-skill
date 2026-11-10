// Decompiled with JetBrains decompiler
// Type: Terraria.Program
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.IO;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.Social;
using Terraria.Utilities;

#nullable disable
namespace Terraria;

public static class Program
{
  public static bool IsXna = true;
  public static bool IsFna = false;
  public static bool IsMono = Type.GetType("Mono.Runtime") != (Type) null;
  public const bool IsDebug = false;
  public static Dictionary<string, string> LaunchParameters = new Dictionary<string, string>();
  public static string SavePath;
  public const string TerrariaSaveFolderPath = "Terraria";
  private static int ThingsToLoad;
  private static int ThingsLoaded;
  public static bool LoadedEverything;
  public static IntPtr JitForcedMethodCache;

  public static float LoadedPercentage
  {
    get
    {
      return Program.ThingsToLoad == 0 ? 1f : (float) Program.ThingsLoaded / (float) Program.ThingsToLoad;
    }
  }

  public static void StartForceLoad()
  {
    if (!Main.SkipAssemblyLoad)
      new Thread(new ParameterizedThreadStart(Program.ForceLoadThread))
      {
        IsBackground = true
      }.Start();
    else
      Program.LoadedEverything = true;
  }

  public static void ForceLoadThread(object threadContext)
  {
    Program.ForceLoadAssembly(Assembly.GetExecutingAssembly(), true);
    Program.LoadedEverything = true;
  }

  private static void ForceJITOnAssembly(Assembly assembly)
  {
    foreach (Type type in assembly.GetTypes())
    {
      foreach (MethodInfo methodInfo in Program.IsMono ? type.GetMethods() : type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
      {
        if (!methodInfo.IsAbstract && !methodInfo.ContainsGenericParameters && methodInfo.GetMethodBody() != null)
        {
          if (Program.IsMono)
            Program.JitForcedMethodCache = methodInfo.MethodHandle.GetFunctionPointer();
          else
            RuntimeHelpers.PrepareMethod(methodInfo.MethodHandle);
        }
      }
      ++Program.ThingsLoaded;
    }
  }

  private static void ForceStaticInitializers(Assembly assembly)
  {
    foreach (Type type in assembly.GetTypes())
    {
      if (!type.IsGenericType)
        RuntimeHelpers.RunClassConstructor(type.TypeHandle);
    }
  }

  private static void ForceLoadAssembly(Assembly assembly, bool initializeStaticMembers)
  {
    Program.ThingsToLoad = assembly.GetTypes().Length;
    Program.ForceJITOnAssembly(assembly);
    if (!initializeStaticMembers)
      return;
    Program.ForceStaticInitializers(assembly);
  }

  private static void ForceLoadAssembly(string name, bool initializeStaticMembers)
  {
    Assembly assembly = (Assembly) null;
    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
    for (int index = 0; index < assemblies.Length; ++index)
    {
      if (assemblies[index].GetName().Name.Equals(name))
      {
        assembly = assemblies[index];
        break;
      }
    }
    if (assembly == (Assembly) null)
      assembly = Assembly.Load(name);
    Program.ForceLoadAssembly(assembly, initializeStaticMembers);
  }

  private static void SetupLogging()
  {
    if (Program.LaunchParameters.ContainsKey("-logfile"))
    {
      string launchParameter = Program.LaunchParameters["-logfile"];
      ConsoleOutputMirror.ToFile(launchParameter == null || launchParameter.Trim() == "" ? Path.Combine(Program.SavePath, "Logs", $"Log_{DateTime.Now:yyyyMMddHHmmssfff}.log") : Path.Combine(launchParameter, $"Log_{DateTime.Now:yyyyMMddHHmmssfff}.log"));
    }
    CrashWatcher.Inititialize();
    CrashWatcher.DumpOnException = Program.LaunchParameters.ContainsKey("-minidump");
    CrashWatcher.LogAllExceptions = Program.LaunchParameters.ContainsKey("-logerrors");
    if (!Program.LaunchParameters.ContainsKey("-fulldump"))
      return;
    Console.WriteLine("Full Dump logs enabled.");
    CrashWatcher.EnableCrashDumps(CrashDump.Options.WithFullMemory);
  }

  private static void InitializeConsoleOutput()
  {
    if (Debugger.IsAttached)
      return;
    try
    {
      Console.OutputEncoding = Encoding.UTF8;
      if (Platform.IsWindows)
        Console.InputEncoding = Encoding.Unicode;
      else
        Console.InputEncoding = Encoding.UTF8;
    }
    catch
    {
    }
  }

  public static void LaunchGame(string[] args, bool monoArgs = false)
  {
    Thread.CurrentThread.Name = "Main Thread";
    if (monoArgs)
      args = Utils.ConvertMonoArgsToDotNet(args);
    Program.LogFNANativeLibVersions();
    Program.LaunchParameters = Utils.ParseArguements(args);
    Program.SavePath = Program.LaunchParameters.ContainsKey("-savedirectory") ? Program.LaunchParameters["-savedirectory"] : Platform.Get<IPathService>().GetStoragePath("Terraria");
    ThreadPool.SetMinThreads(8, 8);
    Program.InitializeConsoleOutput();
    Program.SetupLogging();
    Platform.Get<IWindowService>().SetQuickEditEnabled(false);
    Program.RunGame();
  }

  public static void RunGame()
  {
    LanguageManager.Instance.SetLanguage(GameCulture.DefaultCulture);
    if (Platform.IsOSX)
      Main.OnEngineLoad += (Action) (() => Main.instance.IsMouseVisible = false);
    else if (Platform.IsWindows)
      Main.OnEngineLoad += (Action) (() => Platform.Get<IMouseNotifier>()?.AddMouseHandler((Action<bool>) (connected =>
      {
        if (!connected)
          return;
        Main.instance.IsMouseVisible = true;
        Main.instance.ReHideCursor = true;
      })));
    using (Main game = new Main())
    {
      try
      {
        Lang.InitializeLegacyLocalization();
        SocialAPI.Initialize();
        LaunchInitializer.LoadParameters(game);
        Main.OnEnginePreload += new Action(Program.StartForceLoad);
        if (Main.dedServ)
          game.DedServ();
        game.Run();
      }
      catch (Exception ex)
      {
        Program.DisplayException(ex);
      }
    }
  }

  private static void LogFNANativeLibVersions()
  {
  }

  private static void DisplayException(Exception e)
  {
    try
    {
      string message = e.ToString();
      if (WorldGen.isGeneratingOrLoadingWorld)
      {
        try
        {
          message = $"Creating world - Seed: {Main.ActiveWorldFileData.SeedText} Width: {Main.maxTilesX}, Height: {Main.maxTilesY}, Evil: {WorldGen.WorldGenParam_Evil}, IsExpert: {Main.expertMode}\n{message}";
        }
        catch
        {
        }
      }
      using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
      {
        streamWriter.WriteLine((object) DateTime.Now);
        streamWriter.WriteLine(message);
        streamWriter.WriteLine("");
      }
      if (Main.dedServ)
        Console.WriteLine(Language.GetTextValue("Error.ServerCrash"), (object) DateTime.Now, (object) message);
      int num = (int) MessageBox.Show(message, "Terraria: Error", icon: MessageBoxIcon.Error);
    }
    catch
    {
    }
  }
}
