// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldGenerationOptions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldGenerationOptions
{
  private static List<AWorldGenerationOption> _options = new List<AWorldGenerationOption>();
  private const string _powerPermissionsLineHeader = "seed_";

  public static IEnumerable<AWorldGenerationOption> Options
  {
    get => (IEnumerable<AWorldGenerationOption>) WorldGenerationOptions._options;
  }

  public static T Get<T>() where T : AWorldGenerationOption
  {
    return WorldGenerationOptions.OptionStorage<T>.Instance;
  }

  static WorldGenerationOptions()
  {
    WorldGenerationOptions.Register<WorldSeedOption_Normal>();
    WorldGenerationOptions.Register<WorldSeedOption_NotTheBees>();
    WorldGenerationOptions.Register<WorldSeedOption_Drunk>();
    WorldGenerationOptions.Register<WorldSeedOption_Anniversary>();
    WorldGenerationOptions.Register<WorldSeedOption_DontStarve>();
    WorldGenerationOptions.Register<WorldSeedOption_ForTheWorthy>();
    WorldGenerationOptions.Register<WorldSeedOption_NoTraps>();
    WorldGenerationOptions.Register<WorldSeedOption_Remix>();
    WorldGenerationOptions.Register<WorldSeedOption_Everything>();
    WorldGenerationOptions.Register<WorldSeedOption_Skyblock>();
  }

  public static void Register<T>() where T : AWorldGenerationOption, new()
  {
    if ((object) WorldGenerationOptions.OptionStorage<T>.Instance != null)
      throw new ArgumentException(typeof (T).ToString() + " has already been registered");
    T obj = new T();
    WorldGenerationOptions.OptionStorage<T>.Instance = obj;
    WorldGenerationOptions._options.Add((AWorldGenerationOption) obj);
  }

  public static void Reset() => WorldGenerationOptions.Get<WorldSeedOption_Normal>().Enabled = true;

  public static void SelectOption(AWorldGenerationOption option)
  {
    WorldGenerationOptions.Reset();
    if (option == null)
      return;
    option.Enabled = true;
  }

  public static AWorldGenerationOption GetOptionFromSeedText(string processedSeed)
  {
    int num = WorldFileData.TranslateSeed(processedSeed);
    string str = Regex.Replace(processedSeed.ToLower(), "[^a-z0-9]+", "");
    foreach (AWorldGenerationOption option in WorldGenerationOptions.Options)
    {
      foreach (int specialSeedValue in option.SpecialSeedValues)
      {
        if (num == specialSeedValue)
          return option;
      }
      foreach (string specialSeedName in option.SpecialSeedNames)
      {
        if (str == specialSeedName)
          return option;
      }
    }
    return (AWorldGenerationOption) null;
  }

  public static void TryEnablingFlagFrom(string line)
  {
    int length = "seed_".Length;
    if (line.Length < length || !line.ToLower().StartsWith("seed_"))
      return;
    string[] strArray = line.Substring(length).Split('=');
    int result;
    if (strArray.Length != 2 || !int.TryParse(strArray[1].Trim(), out result))
      return;
    bool flag = Utils.Clamp<int>(result, 0, 1) == 1;
    string namePiece = strArray[0].Trim().ToLower();
    AWorldGenerationOption generationOption = WorldGenerationOptions._options.FirstOrDefault<AWorldGenerationOption>((Func<AWorldGenerationOption, bool>) (x => x.ServerConfigName != null && x.ServerConfigName == namePiece));
    if (generationOption == null)
      return;
    generationOption.AutoGenEnabled = flag;
  }

  private class OptionStorage<T> where T : AWorldGenerationOption
  {
    public static T Instance;
  }
}
