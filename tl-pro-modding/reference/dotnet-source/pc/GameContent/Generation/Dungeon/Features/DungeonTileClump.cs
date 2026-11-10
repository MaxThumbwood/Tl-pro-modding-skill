// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonTileClump
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonTileClump : DungeonFeature
{
  public DungeonTileClump(DungeonFeatureSettings settings, bool addToFeatures = false)
    : base(settings)
  {
    if (!addToFeatures)
      return;
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data, int x, int y)
  {
    this.generated = false;
    DungeonTileClumpSettings settings = (DungeonTileClumpSettings) this.settings;
    if (!this.TileClump(data, x, y, settings.Strength, settings.Steps, (int) settings.TileType, (int) settings.WallType, true))
      return false;
    this.generated = true;
    return true;
  }

  public bool TileClump(
    DungeonData data,
    int i,
    int j,
    double strength,
    int steps,
    int tileType = -1,
    int wallType = -1,
    bool generating = false)
  {
    DungeonTileClumpSettings settings = (DungeonTileClumpSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings.RandomSeed);
    ushort? replaceThisTileType = settings.OnlyReplaceThisTileType;
    ushort? replaceThisWallType = settings.OnlyReplaceThisWallType;
    double num1 = strength;
    double num2 = (double) steps;
    Vector2D vector2D1;
    vector2D1.X = (double) i;
    vector2D1.Y = (double) j;
    Vector2D vector2D2;
    vector2D2.X = (double) unifiedRandom.Next(-10, 11) * 0.1;
    vector2D2.Y = (double) unifiedRandom.Next(-10, 11) * 0.1;
    this.Bounds.SetBounds(i, j, i, j);
    while (num1 > 0.0 && num2 > 0.0)
    {
      if (vector2D1.Y < 0.0 && num2 > 0.0 && tileType == 59)
        num2 = 0.0;
      num1 = strength * (num2 / (double) steps);
      --num2;
      int minX = Math.Max(0, Math.Min(Main.maxTilesX, (int) (vector2D1.X - num1 * 0.5)));
      int minY = Math.Max(0, Math.Min(Main.maxTilesX, (int) (vector2D1.X + num1 * 0.5)));
      int maxX = Math.Max(0, Math.Min(Main.maxTilesY, (int) (vector2D1.Y - num1 * 0.5)));
      int maxY = Math.Max(0, Math.Min(Main.maxTilesY, (int) (vector2D1.Y + num1 * 0.5)));
      this.Bounds.UpdateBounds(minX, minY, maxX, maxY);
      if (generating)
      {
        for (int x = minX; x < minY; ++x)
        {
          for (int y = maxX; y < maxY; ++y)
          {
            if (Math.Abs((double) x - vector2D1.X) + Math.Abs((double) y - vector2D1.Y) < strength * 0.5 * (1.0 + (double) unifiedRandom.Next(-10, 11) * 0.015) && (settings.AreaToGenerateIn == null || settings.AreaToGenerateIn.Contains(x, y)))
            {
              Tile tile = Main.tile[x, y];
              if (!tile.active() || !tile.actuator() && !tile.anyWire())
              {
                if (tileType != -1 && tile.active())
                {
                  if (!replaceThisTileType.HasValue || (int) tile.type == (int) replaceThisTileType.Value)
                  {
                    Main.tile[x, y].type = (ushort) tileType;
                    WorldGen.paintTile(x, y, (byte) 0, paintEffects: false);
                  }
                  else
                    continue;
                }
                if (wallType != -1 && (!replaceThisWallType.HasValue || (int) tile.wall == (int) replaceThisWallType.Value))
                {
                  Main.tile[x, y].wall = (ushort) wallType;
                  WorldGen.paintWall(x, y, (byte) 0, paintEffects: false);
                }
              }
            }
          }
        }
      }
      vector2D1 = Vector2D.op_Addition(vector2D1, vector2D2);
      vector2D2.X += (double) unifiedRandom.Next(-10, 11) * 0.05000000074505806;
      if (vector2D2.X > 1.0)
        vector2D2.X = 1.0;
      if (vector2D2.X < -1.0)
        vector2D2.X = -1.0;
    }
    this.Bounds.CalculateHitbox();
    return true;
  }
}
