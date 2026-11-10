// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.SecretSeedsTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.GameContent;

public static class SecretSeedsTracker
{
  private static List<string> _seedsForConfig = new List<string>();
  private static List<WorldGen.SecretSeed> _seedsForInterface = new List<WorldGen.SecretSeed>();
  private static bool _processedConfig = false;

  public static void SetstringsFromConfig(ICollection<string> seedStrings)
  {
    SecretSeedsTracker._seedsForConfig.AddRange((IEnumerable<string>) seedStrings);
  }

  public static void PrepareInterface()
  {
    if (!SecretSeedsTracker._processedConfig)
    {
      SecretSeedsTracker._processedConfig = true;
      SecretSeedsTracker._seedsForInterface.Clear();
      foreach (string seedString in SecretSeedsTracker._seedsForConfig)
      {
        WorldGen.SecretSeed seed;
        if (SecretSeedsTracker.SeedHasSecret(seedString, out seed))
          SecretSeedsTracker._seedsForInterface.Add(seed);
      }
      SecretSeedsTracker._seedsForInterface = SecretSeedsTracker._seedsForInterface.Distinct<WorldGen.SecretSeed>().ToList<WorldGen.SecretSeed>();
      SecretSeedsTracker._seedsForConfig.Clear();
      SecretSeedsTracker._seedsForConfig.AddRange(SecretSeedsTracker._seedsForInterface.Select<WorldGen.SecretSeed, string>((Func<WorldGen.SecretSeed, string>) (x => x.TextThatWasUsedToUnlock)));
    }
    SecretSeedsTracker._seedsForConfig.Sort();
    SecretSeedsTracker._seedsForInterface.Sort((Comparison<WorldGen.SecretSeed>) ((a, b) => a.TextThatWasUsedToUnlock.CompareTo(b.TextThatWasUsedToUnlock)));
  }

  private static bool SeedHasSecret(string seedString, out WorldGen.SecretSeed seed)
  {
    return WorldGen.SecretSeed.CheckInputForSecretSeed(seedString, out seed);
  }

  public static void AddSeedToTrack(string seedString)
  {
    WorldGen.SecretSeed seed;
    if (!SecretSeedsTracker.SeedHasSecret(seedString, out seed) || SecretSeedsTracker._seedsForInterface.Contains(seed))
      return;
    SecretSeedsTracker._seedsForConfig.Add(seed.TextThatWasUsedToUnlock);
    SecretSeedsTracker._seedsForInterface.Add(seed);
    Main.SaveSettings();
  }

  public static List<string> GetStringsToSave() => SecretSeedsTracker._seedsForConfig;

  public static List<WorldGen.SecretSeed> SeedsForInterface
  {
    get => SecretSeedsTracker._seedsForInterface;
  }
}
