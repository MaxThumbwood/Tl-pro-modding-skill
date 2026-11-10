// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalLights
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalLights : GlobalDungeonFeature
{
  public DungeonGlobalLights(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Lights(data);
    this.generated = true;
    return true;
  }

  public void Lights(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    float num1 = (float) Main.maxTilesX / 4200f;
    int num2 = 0;
    int num3 = 1000;
    int num4 = 0;
    int num5 = (int) (28.0 * (double) num1 * data.globalFeatureScalar);
    while (num4 < num5)
    {
      ++num2;
      int index1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int index2 = genRand.Next(data.dungeonBounds.Top, data.dungeonBounds.Bottom);
      if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, index2].wall))
      {
        for (int y = index2; y > data.dungeonBounds.Top; --y)
        {
          if (Main.tile[index1, y - 1].active() && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index1, y - 1].type) && data.CanGenerateFeatureAt((IDungeonFeature) this, index1, y) && (data.dungeonEntrance.Bounds.Contains(index1, y) || DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, y].wall)))
          {
            bool flag1 = false;
            for (int index3 = index1 - 15; index3 < index1 + 15; ++index3)
            {
              for (int index4 = y - 15; index4 < y + 15; ++index4)
              {
                if (index3 > 0 && index3 < Main.maxTilesX && index4 > 0 && index4 < Main.maxTilesY && (Main.tile[index3, index4].type == (ushort) 42 || Main.tile[index3, index4].type == (ushort) 34))
                {
                  flag1 = true;
                  break;
                }
              }
            }
            if (Main.tile[index1 - 1, y].active() || Main.tile[index1 + 1, y].active() || Main.tile[index1 - 1, y + 1].active() || Main.tile[index1 + 1, y + 1].active() || Main.tile[index1, y + 2].active())
              flag1 = true;
            if (!flag1)
            {
              bool flag2 = false;
              if (!flag2 && genRand.Next(7) == 0)
              {
                bool flag3 = false;
                for (int index5 = 0; index5 < 15; ++index5)
                {
                  if (WorldGen.SolidTile(index1, y + index5))
                  {
                    flag3 = true;
                    break;
                  }
                }
                if (!flag3)
                {
                  DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[index1, y].wall);
                  if (styleForWall != null && styleForWall.ChandelierItemTypes != null)
                  {
                    int index6 = styleForWall.ChandelierItemTypes.Length == 0 || styleForWall.Style == (byte) 0 ? data.chandelierItemType : styleForWall.ChandelierItemTypes[genRand.Next(styleForWall.ChandelierItemTypes.Length)];
                    PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[index6];
                    if (derivedPlacementDetail.tileType >= 0)
                    {
                      WorldGen.PlaceChand(index1, y, (ushort) derivedPlacementDetail.tileType, (int) derivedPlacementDetail.tileStyle);
                      if (Main.tile[index1, y].type == (ushort) 34)
                      {
                        flag2 = true;
                        num2 = 0;
                        ++num4;
                        this.Lights_GenerateSwitch(index1, y);
                      }
                    }
                  }
                }
              }
              if (!flag2)
              {
                DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[index1, y].wall);
                ushort type = 42;
                if (styleForWall == null || styleForWall.LanternItemTypes != null)
                {
                  int style;
                  if (styleForWall == null || styleForWall.Style == (byte) 0 || styleForWall.LanternItemTypes.Length == 0)
                  {
                    style = data.lanternStyles[0];
                    if ((int) Main.tile[index1, y].wall == data.wallVariants[1])
                      style = data.lanternStyles[1];
                    if ((int) Main.tile[index1, y].wall == data.wallVariants[2])
                      style = data.lanternStyles[2];
                  }
                  else
                  {
                    PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[styleForWall.LanternItemTypes[genRand.Next(styleForWall.LanternItemTypes.Length)]];
                    type = (ushort) derivedPlacementDetail.tileType;
                    style = (int) derivedPlacementDetail.tileStyle;
                  }
                  WorldGen.Place1x2Top(index1, y, type, style);
                  if ((int) Main.tile[index1, y].type == (int) type)
                  {
                    num2 = 0;
                    ++num4;
                    this.Lights_GenerateSwitch(index1, y);
                    break;
                  }
                  break;
                }
              }
              else
                break;
            }
            else
              break;
          }
        }
      }
      if (num2 > num3)
      {
        ++num4;
        num2 = 0;
      }
    }
  }

  private Point Lights_GenerateSwitch(int x, int y)
  {
    Point point = Point.Zero;
    for (int index1 = 0; index1 < 1000; ++index1)
    {
      int index2 = x + WorldGen.genRand.Next(-12, 13);
      int index3 = y + WorldGen.genRand.Next(3, 21);
      if (!Main.tile[index2, index3].active() && !Main.tile[index2, index3 + 1].active() && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2 - 1, index3].type) && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2 + 1, index3].type) && Collision.CanHit(new Point(index2 * 16 /*0x10*/, index3 * 16 /*0x10*/), 16 /*0x10*/, 16 /*0x10*/, new Point(x * 16 /*0x10*/, y * 16 /*0x10*/ + 1), 16 /*0x10*/, 16 /*0x10*/))
      {
        if ((WorldGen.SolidTile(index2 - 1, index3) && Main.tile[index2 - 1, index3].type != (ushort) 10 || WorldGen.SolidTile(index2 + 1, index3) && Main.tile[index2 + 1, index3].type != (ushort) 10 || WorldGen.SolidTile(index2, index3 + 1)) && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, index3].wall) && (DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2 - 1, index3].type) || DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2 + 1, index3].type)))
        {
          WorldGen.PlaceTile(index2, index3, 136, true);
          point = new Point(index2, index3);
        }
        if (Main.tile[index2, index3].active())
        {
          while (index2 != x || index3 != y)
          {
            Main.tile[index2, index3].wire(true);
            if (index2 > x)
              --index2;
            if (index2 < x)
              ++index2;
            Main.tile[index2, index3].wire(true);
            if (index3 > y)
              --index3;
            if (index3 < y)
              ++index3;
            Main.tile[index2, index3].wire(true);
          }
          if (WorldGen.genRand.Next(3) > 0)
          {
            Main.tile[x, y].frameX = (short) 18;
            Main.tile[x, y + 1].frameX = (short) 18;
            break;
          }
          break;
        }
      }
    }
    return point;
  }
}
