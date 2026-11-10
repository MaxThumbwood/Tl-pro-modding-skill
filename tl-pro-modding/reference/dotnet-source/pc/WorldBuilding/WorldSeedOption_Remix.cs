// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_Remix
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_Remix : AWorldGenerationOption
{
  protected override string KeyName => "Seed_Remix";

  public override string ServerConfigName => "remix";

  public WorldSeedOption_Remix()
  {
    this.SpecialSeedNames = new string[1]{ "dontdigup" };
    this.SpecialSeedValues = new int[0];
  }
}
