// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalDoors
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalDoors : GlobalDungeonFeature
{
  public DungeonGlobalDoors(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Doors(data);
    this.generated = true;
    return true;
  }

  public void Doors(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    ushort brickTileType = data.genVars.brickTileType;
    ushort brickWallType = data.genVars.brickWallType;
    PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[data.doorItemType];
    for (int index1 = 0; index1 < data.dungeonDoorData.Count; ++index1)
    {
      DungeonDoorData dungeonDoorData = data.dungeonDoorData[index1];
      if (WorldGen.InWorld(dungeonDoorData.Position, 30))
      {
        ushort num1 = brickTileType;
        if (dungeonDoorData.OverrideBrickTileType.HasValue)
          num1 = dungeonDoorData.OverrideBrickTileType.Value;
        ushort num2 = brickWallType;
        if (dungeonDoorData.OverrideBrickWallType.HasValue)
          num2 = dungeonDoorData.OverrideBrickWallType.Value;
        int style = 13;
        if (genRand.Next(3) == 0)
          style = (int) derivedPlacementDetail.tileStyle;
        if (dungeonDoorData.OverrideStyle.HasValue)
          style = dungeonDoorData.OverrideStyle.Value;
        int num3 = 20;
        int val1_1 = num3 + 5;
        int num4 = 10;
        if (dungeonDoorData.OverrideWidthFluff.HasValue)
          num4 = dungeonDoorData.OverrideWidthFluff.Value;
        int val1_2 = Math.Max(val1_1, Math.Min(Main.maxTilesX - val1_1, dungeonDoorData.Position.X - num4));
        int num5 = Math.Max(val1_1, Math.Min(Main.maxTilesX - val1_1, Math.Max(val1_2, dungeonDoorData.Position.X + num4 - 1)));
        int num6 = 100;
        int num7 = 0;
        for (int index2 = val1_2; index2 <= num5; ++index2)
        {
          bool flag1 = true;
          int y1 = dungeonDoorData.Position.Y;
          while (y1 > 10 && !Main.tile[index2, y1].active())
            --y1;
          if (!DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2, y1].type))
            flag1 = false;
          int num8 = y1;
          int y2 = dungeonDoorData.Position.Y;
          while (!Main.tile[index2, y2].active())
            ++y2;
          if (!DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index2, y2].type))
            flag1 = false;
          int num9 = y2;
          if (num9 - num8 >= 3)
          {
            if (!dungeonDoorData.SkipOtherDoorsCheck)
            {
              int num10 = index2 - 20;
              int num11 = index2 + 20;
              int num12 = num9 - 10;
              int num13 = num9 + 10;
              for (int index3 = num10; index3 < num11; ++index3)
              {
                for (int index4 = num12; index4 < num13; ++index4)
                {
                  if (Main.tile[index3, index4].active() && Main.tile[index3, index4].type == (ushort) 10)
                  {
                    flag1 = false;
                    break;
                  }
                }
              }
            }
            if (flag1 && !dungeonDoorData.SkipSpaceCheck)
            {
              for (int index5 = num9 - 3; index5 < num9; ++index5)
              {
                for (int index6 = index2 - 3; index6 <= index2 + 3; ++index6)
                {
                  if (Main.tile[index6, index5].active())
                  {
                    flag1 = false;
                    break;
                  }
                }
              }
            }
            if (flag1 && num9 - num8 < num3)
            {
              bool flag2 = false;
              if (dungeonDoorData.Direction == 0 && num9 - num8 < num6)
                flag2 = true;
              if (dungeonDoorData.Direction == -1 && index2 > num7)
                flag2 = true;
              if (dungeonDoorData.Direction == 1 && (index2 < num7 || num7 == 0))
                flag2 = true;
              if (flag2)
              {
                num7 = index2;
                num6 = num9 - num8;
              }
            }
          }
        }
        if (num6 < num3)
        {
          int i = num7;
          int y = dungeonDoorData.Position.Y;
          int index7 = y;
          for (; !Main.tile[i, y].active(); ++y)
            Main.tile[i, y].active(false);
          while (!Main.tile[i, index7].active())
            --index7;
          int j1 = y - 1;
          int num14 = index7 + 1;
          for (int j2 = num14; j2 < j1 - 2; ++j2)
          {
            Main.tile[i, j2].Clear(TileDataType.Slope);
            Main.tile[i, j2].active(true);
            Main.tile[i, j2].type = num1;
            if (Main.tile[i - 1, j2].active() && WorldGen.CanKillTile(i - 1, j2))
            {
              Main.tile[i - 1, j2].active(false);
              Main.tile[i - 1, j2].ClearEverything();
              Main.tile[i - 1, j2].wall = num2;
            }
            if (Main.tile[i - 2, j2].active() && WorldGen.CanKillTile(i - 2, j2))
            {
              Main.tile[i - 2, j2].active(false);
              Main.tile[i - 2, j2].ClearEverything();
              Main.tile[i - 2, j2].wall = num2;
            }
            if (Main.tile[i + 1, j2].active() && WorldGen.CanKillTile(i + 1, j2))
            {
              Main.tile[i + 1, j2].active(false);
              Main.tile[i + 1, j2].ClearEverything();
              Main.tile[i + 1, j2].wall = num2;
            }
            if (Main.tile[i + 2, j2].active() && WorldGen.CanKillTile(i + 2, j2))
            {
              Main.tile[i + 2, j2].active(false);
              Main.tile[i + 2, j2].ClearEverything();
              Main.tile[i + 2, j2].wall = num2;
            }
          }
          WorldGen.PlaceTile(i, j1, 10, true, style: style);
          int index8 = i - 1;
          int index9 = j1 - 3;
          while (!Main.tile[index8, index9].active())
            --index9;
          bool flag3 = j1 - index9 < j1 - num14 + 5 && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index8, index9].type);
          if (dungeonDoorData.AlwaysClearArea | flag3)
          {
            for (int index10 = j1 - 4 - genRand.Next(3); index10 > index9; --index10)
            {
              if (flag3)
              {
                Main.tile[index8, index10].Clear(TileDataType.Slope);
                Main.tile[index8, index10].active(true);
                Main.tile[index8, index10].type = num1;
              }
              if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[index8 - 1, index10].type == (int) num1)
              {
                Main.tile[index8 - 1, index10].active(false);
                Main.tile[index8 - 1, index10].ClearEverything();
                Main.tile[index8 - 1, index10].wall = num2;
              }
              if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[index8 - 2, index10].type == (int) num1)
              {
                Main.tile[index8 - 2, index10].active(false);
                Main.tile[index8 - 2, index10].ClearEverything();
                Main.tile[index8 - 2, index10].wall = num2;
              }
            }
          }
          int index11 = index8 + 2;
          int index12 = j1 - 3;
          while (!Main.tile[index11, index12].active())
            --index12;
          bool flag4 = j1 - index12 < j1 - num14 + 5 && DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index11, index12].type);
          if (dungeonDoorData.AlwaysClearArea | flag4)
          {
            for (int index13 = j1 - 4 - genRand.Next(3); index13 > index12; --index13)
            {
              if (flag4)
              {
                Main.tile[index11, index13].active(true);
                Main.tile[index11, index13].Clear(TileDataType.Slope);
                Main.tile[index11, index13].type = num1;
              }
              if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[index11 + 1, index13].type == (int) num1)
              {
                Main.tile[index11 + 1, index13].active(false);
                Main.tile[index11 + 1, index13].ClearEverything();
                Main.tile[index11 + 1, index13].wall = num2;
              }
              if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[index11 + 2, index13].type == (int) num1)
              {
                Main.tile[index11 + 2, index13].active(false);
                Main.tile[index11 + 2, index13].ClearEverything();
                Main.tile[index11 + 2, index13].wall = num2;
              }
            }
          }
          int index14 = j1 + 1;
          int num15 = index11 - 1;
          for (int index15 = index14 - 8; index15 < index14; ++index15)
          {
            if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[num15 + 2, index15].type == (int) num1)
            {
              Main.tile[num15 + 2, index15].active(false);
              Main.tile[num15 + 2, index15].ClearEverything();
              Main.tile[num15 + 2, index15].wall = num2;
            }
            if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[num15 + 3, index15].type == (int) num1)
            {
              Main.tile[num15 + 3, index15].active(false);
              Main.tile[num15 + 3, index15].ClearEverything();
              Main.tile[num15 + 3, index15].wall = num2;
            }
            if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[num15 - 2, index15].type == (int) num1)
            {
              Main.tile[num15 - 2, index15].active(false);
              Main.tile[num15 - 2, index15].ClearEverything();
              Main.tile[num15 - 2, index15].wall = num2;
            }
            if (dungeonDoorData.AlwaysClearArea || (int) Main.tile[num15 - 3, index15].type == (int) num1)
            {
              Main.tile[num15 - 3, index15].active(false);
              Main.tile[num15 - 3, index15].ClearEverything();
              Main.tile[num15 - 3, index15].wall = num2;
            }
          }
          Main.tile[num15 - 1, index14].active(true);
          Main.tile[num15 - 1, index14].type = num1;
          Main.tile[num15 - 1, index14].Clear(TileDataType.Slope);
          Main.tile[num15 + 1, index14].active(true);
          Main.tile[num15 + 1, index14].type = num1;
          Main.tile[num15 + 1, index14].Clear(TileDataType.Slope);
        }
      }
    }
  }
}
