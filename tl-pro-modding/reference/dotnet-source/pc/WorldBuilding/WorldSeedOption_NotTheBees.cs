// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_NotTheBees
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_NotTheBees : AWorldGenerationOption
{
  protected override string KeyName => "Seed_NotTheBees";

  public override string ServerConfigName => "notthebees";

  public WorldSeedOption_NotTheBees()
  {
    this.SpecialSeedNames = new string[1]{ "notthebees" };
    this.SpecialSeedValues = new int[0];
  }
}
