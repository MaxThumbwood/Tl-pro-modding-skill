// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalBookshelves
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.GameContent.Generation.Dungeon.Entrances;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalBookshelves : GlobalDungeonFeature
{
  public DungeonGlobalBookshelves(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Bookshelves(data);
    this.generated = true;
    return true;
  }

  public void Bookshelves(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonEntrance dungeonEntrance = data.dungeonEntrance;
    int num1 = 0;
    int num2 = 1000;
    int num3 = 0;
    int num4 = -1;
    if (data.Type == DungeonType.DualDungeon)
    {
      switch (WorldGen.GetWorldSize())
      {
        case 1:
          num4 = 10;
          break;
        case 2:
          num4 = 15;
          break;
        default:
          num4 = 5;
          break;
      }
    }
    while (num3 < Main.maxTilesX / 20)
    {
      ++num1;
      int index1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int index2 = genRand.Next(data.dungeonBounds.Top, data.dungeonBounds.Bottom);
      bool flag1 = true;
      if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, index2].wall) && !Main.tile[index1, index2].active())
      {
        int num5 = 1;
        if (genRand.Next(2) == 0)
          num5 = -1;
        while (flag1 && !Main.tile[index1, index2].active())
        {
          index1 -= num5;
          if (index1 < 5 || index1 > Main.maxTilesX - 5)
            flag1 = false;
          else if (Main.tile[index1, index2].active() && !DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index1, index2].type))
            flag1 = false;
        }
        if (flag1 && Main.tile[index1, index2].active() && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index1, index2].type) && Main.tile[index1, index2 - 1].active() && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index1, index2 - 1].type) && Main.tile[index1, index2 + 1].active() && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index1, index2 + 1].type))
        {
          int index3 = index1 + num5;
          for (int index4 = index3 - 3; index4 <= index3 + 3; ++index4)
          {
            for (int index5 = index2 - 3; index5 <= index2 + 3; ++index5)
            {
              if (Main.tile[index4, index5].active() && Main.tile[index4, index5].type == (ushort) 19)
              {
                flag1 = false;
                break;
              }
            }
          }
          if (flag1 && !Main.tile[index3, index2 - 1].active() & !Main.tile[index3, index2 - 2].active() & !Main.tile[index3, index2 - 3].active())
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, index3, index2))
              continue;
            int index6 = index3;
            int num6 = index3;
            while (index6 > data.dungeonBounds.Left && index6 < data.dungeonBounds.Right && !Main.tile[index6, index2].active() && !Main.tile[index6, index2 - 1].active() && !Main.tile[index6, index2 + 1].active())
              index6 += num5;
            int num7 = Math.Abs(index3 - index6);
            bool flag2 = true;
            bool flag3 = genRand.Next(2) == 0;
            if (num7 > 5)
            {
              int num8 = -1;
              int min = 1;
              int max = 4;
              DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[index3, index2].wall);
              if (styleForWall != null)
              {
                flag2 = styleForWall.Style == (byte) 0;
                if (!flag2)
                  flag3 = false;
                num8 = styleForWall.GetPlatformStyle(genRand);
                styleForWall.GetBookshelfMinMaxSizes(min, max, out min, out max);
              }
              for (int index7 = genRand.Next(min, max); index7 > 0; --index7)
              {
                Tile tile = Main.tile[index3, index2];
                tile.active(true);
                tile.Clear(TileDataType.Slope);
                tile.type = (ushort) 19;
                int num9 = data.shelfStyles[0];
                if ((int) tile.wall == data.wallVariants[1])
                  num9 = data.shelfStyles[1];
                if ((int) tile.wall == data.wallVariants[2])
                  num9 = data.shelfStyles[2];
                if (num8 > -1)
                  num9 = num8;
                tile.frameY = (short) (18 * num9);
                WorldGen.TileFrame(index3, index2);
                if (flag3)
                {
                  short num10 = 90;
                  WorldGen.PlaceTile(index3, index2 - 1, 50, true);
                  if (genRand.Next(50) == 0 && (double) index2 > (Main.worldSurface + Main.rockLayer) / 2.0 && Main.tile[index3, index2 - 1].type == (ushort) 50)
                    Main.tile[index3, index2 - 1].frameX = num10;
                }
                index3 += num5;
              }
              num1 = 0;
              ++num3;
              if (!flag3 && genRand.Next(2) == 0)
              {
                int i = num6;
                int j = index2 - 1;
                if (flag2)
                {
                  int Type = genRand.Next(4) == 0 ? 1 : 0;
                  if (num4 > 0)
                    Type = 1;
                  switch (Type)
                  {
                    case 0:
                      Type = 13;
                      break;
                    case 1:
                      Type = 49;
                      break;
                  }
                  WorldGen.PlaceTile(i, j, Type, true);
                  if (Main.tile[i, j].type == (ushort) 13)
                    Main.tile[i, j].frameX = genRand.Next(2) != 0 ? (short) 36 : (short) 18;
                  if (Main.tile[i, j].active() && Main.tile[i, j].type == (ushort) 49)
                    --num4;
                }
                else
                {
                  ushort Type = 13;
                  WorldGen.PlaceTile(i, j, (int) Type, true);
                  if (Main.tile[i, j].type == (ushort) 13)
                    Main.tile[i, j].frameX = genRand.Next(2) != 0 ? (short) 36 : (short) 18;
                }
              }
            }
          }
        }
      }
      if (num1 > num2)
      {
        num1 = 0;
        ++num3;
      }
    }
  }
}
