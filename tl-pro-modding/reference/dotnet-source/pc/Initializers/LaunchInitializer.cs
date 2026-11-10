// Decompiled with JetBrains decompiler
// Type: Terraria.Initializers.LaunchInitializer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Diagnostics;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Social;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Initializers;

public static class LaunchInitializer
{
  public static void LoadParameters(Main game)
  {
    LaunchInitializer.LoadSharedParameters(game);
    if (Main.dedServ)
      LaunchInitializer.LoadServerParameters(game);
    LaunchInitializer.LoadClientParameters(game);
  }

  private static void LoadSharedParameters(Main game)
  {
    string[] strArray1 = new string[1]{ "-loadlib" };
    string path;
    if ((path = LaunchInitializer.TryParameter(strArray1)) != null)
      game.loadLib(path);
    string[] strArray2 = new string[2]{ "-p", "-port" };
    string s;
    int result;
    if ((s = LaunchInitializer.TryParameter(strArray2)) == null || !int.TryParse(s, out result))
      return;
    Netplay.ListenPort = result;
  }

  private static void LoadClientParameters(Main game)
  {
    string[] strArray1 = new string[2]{ "-j", "-join" };
    string IP;
    if ((IP = LaunchInitializer.TryParameter(strArray1)) != null)
      game.AutoJoin(IP);
    string[] strArray2 = new string[2]
    {
      "-pass",
      "-password"
    };
    string str;
    if ((str = LaunchInitializer.TryParameter(strArray2)) != null)
    {
      Netplay.ServerPassword = Main.ConvertFromSafeArgument(str);
      game.AutoPass();
    }
    if (!LaunchInitializer.HasParameter("-host"))
      return;
    game.AutoHost();
  }

  private static void LoadServerParameters(Main game)
  {
    try
    {
      string[] strArray = new string[1]{ "-forcepriority" };
      string s;
      if ((s = LaunchInitializer.TryParameter(strArray)) != null)
      {
        Process currentProcess = Process.GetCurrentProcess();
        int result;
        if (int.TryParse(s, out result))
        {
          switch (result)
          {
            case 0:
              currentProcess.PriorityClass = ProcessPriorityClass.RealTime;
              break;
            case 1:
              currentProcess.PriorityClass = ProcessPriorityClass.High;
              break;
            case 2:
              currentProcess.PriorityClass = ProcessPriorityClass.AboveNormal;
              break;
            case 3:
              currentProcess.PriorityClass = ProcessPriorityClass.Normal;
              break;
            case 4:
              currentProcess.PriorityClass = ProcessPriorityClass.BelowNormal;
              break;
            case 5:
              currentProcess.PriorityClass = ProcessPriorityClass.Idle;
              break;
            default:
              currentProcess.PriorityClass = ProcessPriorityClass.High;
              break;
          }
        }
        else
          currentProcess.PriorityClass = ProcessPriorityClass.High;
      }
      else
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
    }
    catch
    {
    }
    string[] strArray1 = new string[2]
    {
      "-maxplayers",
      "-players"
    };
    string str1;
    if ((str1 = LaunchInitializer.TryParameter(strArray1)) != null)
    {
      int int32 = Convert.ToInt32(str1);
      if (int32 <= (int) byte.MaxValue && int32 >= 1)
        game.SetNetPlayers(int32);
    }
    string[] strArray2 = new string[2]
    {
      "-pass",
      "-password"
    };
    string str2;
    if ((str2 = LaunchInitializer.TryParameter(strArray2)) != null)
      Netplay.ServerPassword = Main.ConvertFromSafeArgument(str2);
    string[] strArray3 = new string[1]{ "-lang" };
    string s1;
    int result1;
    if ((s1 = LaunchInitializer.TryParameter(strArray3)) != null && int.TryParse(s1, out result1))
      LanguageManager.Instance.SetLanguage(result1);
    string[] strArray4 = new string[1]{ "-language" };
    string cultureName;
    if ((cultureName = LaunchInitializer.TryParameter(strArray4)) != null)
      LanguageManager.Instance.SetLanguage(cultureName);
    string[] strArray5 = new string[1]{ "-worldname" };
    string world;
    if ((world = LaunchInitializer.TryParameter(strArray5)) != null)
      game.SetWorldName(world);
    string[] strArray6 = new string[1]{ "-motd" };
    string newMOTD;
    if ((newMOTD = LaunchInitializer.TryParameter(strArray6)) != null)
      game.NewMOTD(newMOTD);
    string[] strArray7 = new string[1]{ "-banlist" };
    string str3;
    if ((str3 = LaunchInitializer.TryParameter(strArray7)) != null)
      Netplay.BanFilePath = str3;
    if (LaunchInitializer.HasParameter("-autoshutdown"))
      game.EnableAutoShutdown();
    string[] strArray8 = new string[1]{ "-hosttoken" };
    string str4;
    if ((str4 = LaunchInitializer.TryParameter(strArray8)) != null)
      Netplay.HostToken = str4;
    if (LaunchInitializer.HasParameter("-secure"))
      Netplay.SpamCheck = true;
    string[] strArray9 = new string[1]
    {
      "-worldrollbackstokeep"
    };
    string rollBacksToKeep;
    if ((rollBacksToKeep = LaunchInitializer.TryParameter(strArray9)) != null)
      game.setServerWorldRollbacks(rollBacksToKeep);
    string[] strArray10 = new string[1]{ "-autocreate" };
    string worldSize;
    if ((worldSize = LaunchInitializer.TryParameter(strArray10)) != null)
      game.autoCreate(worldSize);
    if (LaunchInitializer.HasParameter("-noupnp"))
      Netplay.UseUPNP = false;
    if (LaunchInitializer.HasParameter("-experimental"))
      Main.UseExperimentalFeatures = true;
    string[] strArray11 = new string[1]{ "-world" };
    string str5;
    if ((str5 = LaunchInitializer.TryParameter(strArray11)) != null)
    {
      if (FileUtilities.Exists(str5, false) || !Main.autoGen)
      {
        game.SetWorld(str5, false);
      }
      else
      {
        new WorldFileData(str5, false).SetAsActive();
        Main.autoGenFileLocation = str5;
      }
    }
    else if (SocialAPI.Mode == SocialMode.Steam)
    {
      string[] strArray12 = new string[1]{ "-cloudworld" };
      string str6;
      if ((str6 = LaunchInitializer.TryParameter(strArray12)) != null)
      {
        if (FileUtilities.Exists(str6, true) || !Main.autoGen)
        {
          game.SetWorld(str6, true);
        }
        else
        {
          new WorldFileData(str6, true).SetAsActive();
          Main.autoGenFileLocation = str6;
        }
      }
    }
    string[] strArray13 = new string[1]{ "-config" };
    string configPath;
    if ((configPath = LaunchInitializer.TryParameter(strArray13)) != null)
      game.LoadDedConfig(configPath);
    string[] strArray14 = new string[1]{ "-seed" };
    string str7;
    if ((str7 = LaunchInitializer.TryParameter(strArray14)) == null)
      return;
    Main.AutogenSeedName = str7;
  }

  private static bool HasParameter(params string[] keys)
  {
    for (int index = 0; index < keys.Length; ++index)
    {
      if (Program.LaunchParameters.ContainsKey(keys[index]))
        return true;
    }
    return false;
  }

  private static string TryParameter(params string[] keys)
  {
    for (int index = 0; index < keys.Length; ++index)
    {
      string str;
      if (Program.LaunchParameters.TryGetValue(keys[index], out str))
      {
        if (str == null)
          str = "";
        return str;
      }
    }
    return (string) null;
  }
}
