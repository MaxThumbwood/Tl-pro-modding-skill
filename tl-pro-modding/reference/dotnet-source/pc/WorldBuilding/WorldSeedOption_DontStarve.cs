// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_DontStarve
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_DontStarve : AWorldGenerationOption
{
  protected override string KeyName => "Seed_TheConstant";

  public override string ServerConfigName => "theconstant";

  public WorldSeedOption_DontStarve()
  {
    this.SpecialSeedNames = new string[4]
    {
      "constant",
      "theconstant",
      "eye4aneye",
      "eyeforaneye"
    };
    this.SpecialSeedValues = new int[0];
  }
}
