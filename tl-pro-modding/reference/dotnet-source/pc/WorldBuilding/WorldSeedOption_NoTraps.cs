// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_NoTraps
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_NoTraps : AWorldGenerationOption
{
  protected override string KeyName => "Seed_NoTraps";

  public override string ServerConfigName => "notraps";

  public WorldSeedOption_NoTraps()
  {
    this.SpecialSeedNames = new string[1]{ "notraps" };
    this.SpecialSeedValues = new int[0];
  }
}
