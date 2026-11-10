// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.DesertBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class DesertBiome : MicroBiome
{
  [JsonProperty("ChanceOfEntrance")]
  public double ChanceOfEntrance = 0.3333;

  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    DesertDescription fromPlacement = DesertDescription.CreateFromPlacement(origin);
    if (!fromPlacement.IsValid)
      return false;
    DesertBiome.ExportDescriptionToEngine(fromPlacement);
    SandMound.Place(fromPlacement, progress, 0.0f, 0.1f);
    fromPlacement.UpdateSurfaceMap();
    if (!Main.tenthAnniversaryWorld && GenBase._random.NextDouble() <= this.ChanceOfEntrance && !WorldGen.SecretSeed.extraLiquid.Enabled)
    {
      switch (GenBase._random.Next(4))
      {
        case 0:
          ChambersEntrance.Place(fromPlacement, progress, 0.1f, 0.2f);
          break;
        case 1:
          AnthillEntrance.Place(fromPlacement, progress, 0.1f, 0.2f);
          break;
        case 2:
          LarvaHoleEntrance.Place(fromPlacement, progress, 0.1f, 0.2f);
          break;
        case 3:
          PitEntrance.Place(fromPlacement, progress, 0.1f, 0.2f);
          break;
      }
    }
    DesertHive.Place(fromPlacement, progress, 0.2f, 0.75f);
    DesertBiome.CleanupArea(fromPlacement.Hive, progress, 0.75f, 1f);
    Microsoft.Xna.Framework.Rectangle area = new Microsoft.Xna.Framework.Rectangle(fromPlacement.CombinedArea.X, 50, fromPlacement.CombinedArea.Width, fromPlacement.CombinedArea.Bottom - 20);
    structures.AddStructure(area, 10);
    return true;
  }

  private static void ExportDescriptionToEngine(DesertDescription description)
  {
    GenVars.UndergroundDesertLocation = description.CombinedArea;
    GenVars.UndergroundDesertLocation.Inflate(10, 10);
    GenVars.UndergroundDesertHiveLocation = description.Hive;
  }

  private static void CleanupArea(
    Microsoft.Xna.Framework.Rectangle area,
    GenerationProgress progress,
    float progressMin,
    float progressMax)
  {
    int num1 = 20 - area.Left;
    int num2 = num1 + area.Right + 20;
    for (int index1 = area.Left - 20; index1 < area.Right + 20; ++index1)
    {
      progress.Set((double) (index1 + num1) / (double) num2, (double) progressMin, (double) progressMax);
      for (int index2 = area.Top - 20; index2 < area.Bottom + 20; ++index2)
      {
        if (index1 > 0 && index1 < Main.maxTilesX - 1 && index2 > 0 && index2 < Main.maxTilesY - 1)
        {
          WorldGen.SquareWallFrame(index1, index2);
          WorldUtils.TileFrame(index1, index2, true);
        }
      }
    }
  }
}
