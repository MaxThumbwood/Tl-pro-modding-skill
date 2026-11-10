// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_Normal
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Linq;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_Normal : AWorldGenerationOption
{
  protected override string KeyName => "Seed_Normal";

  public override string ServerConfigName => (string) null;

  public WorldSeedOption_Normal()
  {
    this.SpecialSeedNames = new string[0];
    this.SpecialSeedValues = new int[0];
    AWorldGenerationOption.OnOptionStateChanged += new Action<AWorldGenerationOption>(this.UpdateDependentState);
  }

  private void UpdateDependentState(AWorldGenerationOption changed)
  {
    this.Enabled = WorldGenerationOptions.Options.All<AWorldGenerationOption>((Func<AWorldGenerationOption, bool>) (x => x == this || !x.Enabled));
  }

  protected override void OnEnabledStateChanged()
  {
    if (!this.Enabled)
      return;
    foreach (AWorldGenerationOption option in WorldGenerationOptions.Options)
    {
      if (option != this)
        option.Enabled = false;
    }
  }
}
