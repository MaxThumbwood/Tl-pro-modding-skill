// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalEarlyDualDungeonFeatures
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalEarlyDualDungeonFeatures : GlobalDungeonFeature
{
  public DungeonGlobalEarlyDualDungeonFeatures(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.EarlyDungeonFeatures(data);
    this.generated = true;
    return true;
  }

  public void EarlyDungeonFeatures(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = 20;
    int num2 = 8;
    int num3 = 8;
    int num4 = 6;
    int num5 = 4;
    int num6 = 4;
    int num7 = 40;
    int num8 = 40;
    switch (WorldGen.GetWorldSize())
    {
      case 0:
        num1 = 20;
        num2 = 8;
        num3 = 8;
        num4 = 6;
        num5 = 4;
        num6 = 4;
        num7 = 40;
        num8 = 40;
        break;
      case 1:
        num1 = 30;
        num2 = 14;
        num3 = 12;
        num4 = 10;
        num5 = 6;
        num6 = 8;
        num7 = 60;
        num8 = 60;
        break;
      case 2:
        num1 = 40;
        num2 = 18;
        num3 = 16 /*0x10*/;
        num4 = 14;
        num5 = 8;
        num6 = 12;
        num7 = 80 /*0x50*/;
        num8 = 80 /*0x50*/;
        break;
    }
    if (WorldGen.SecretSeed.Variations.actuallyNoTrapsForRealIMeanIt)
    {
      num3 = 0;
      num4 = 0;
      num5 = 0;
    }
    for (int index1 = 0; index1 < data.genVars.dungeonGenerationStyles.Count; ++index1)
    {
      DungeonGenerationStyleData dungeonGenerationStyle = data.genVars.dungeonGenerationStyles[index1];
      byte style = dungeonGenerationStyle.Style;
      DungeonBounds progressionBound = data.outerProgressionBounds[index1];
      if (style == (byte) 4 || style == (byte) 5)
      {
        bool flag = style == (byte) 5;
        int num9 = num1;
        int num10 = 1000;
        while (num9 > 0)
        {
          --num10;
          if (num10 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int index2 = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile1 = Main.tile[x, index2];
            Tile tile2 = Main.tile[x, index2 + 1];
            for (; !tile1.active() && index2 < Main.maxTilesY - 10; tile1 = Main.tile[x, index2])
              ++index2;
            int y = index2 - 1;
            Tile tile3 = Main.tile[x, y];
            Tile tile4 = Main.tile[x, y + 1];
            if (!tile3.active() && (int) tile3.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile4.type);
              if (styleForTile != null && (int) styleForTile.Style == (flag ? 5 : 4) && (int) tile4.type != (int) styleForTile.BrickCrackedTileType && (int) tile4.type != (int) styleForTile.PitTrapTileType)
              {
                WorldGen.Place3x2(x, y, (ushort) 26, flag ? 1 : 0);
                Tile tile5 = Main.tile[x, y];
                if (tile5.active() && tile5.type == (ushort) 26)
                  --num9;
              }
            }
          }
          else
            break;
        }
      }
    }
    Dictionary<int, List<DungeonRoom>> dictionary = new Dictionary<int, List<DungeonRoom>>();
    BiomeDungeonRoom biomeDungeonRoom = (BiomeDungeonRoom) null;
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = data.dungeonRooms[index];
      byte style = dungeonRoom.settings.StyleData.Style;
      if (!dictionary.ContainsKey((int) style))
        dictionary.Add((int) style, new List<DungeonRoom>());
      dictionary[(int) style].Add(dungeonRoom);
      if (dungeonRoom is BiomeDungeonRoom && dungeonRoom.settings.StyleData.Style == (byte) 10)
        biomeDungeonRoom = (BiomeDungeonRoom) dungeonRoom;
    }
    if (dictionary.ContainsKey(4))
    {
      int num11 = num2;
      List<DungeonRoom> list = dictionary[4].ToList<DungeonRoom>();
      while (list.Count > 0 && num11 > 0)
      {
        DungeonRoom dungeonRoom = list[genRand.Next(list.Count)];
        Point center = dungeonRoom.InnerBounds.Center;
        Tile tile = Main.tile[center.X, center.Y];
        WorldGen.AddShadowOrb(center.X, center.Y, false);
        if (Main.tile[center.X, center.Y].type == (ushort) 31 /*0x1F*/)
          --num11;
        list.Remove(dungeonRoom);
      }
    }
    if (dictionary.ContainsKey(5))
    {
      int num12 = num2;
      List<DungeonRoom> list = dictionary[5].ToList<DungeonRoom>();
      while (list.Count > 0 && num12 > 0)
      {
        DungeonRoom dungeonRoom = list[genRand.Next(list.Count)];
        Point center = dungeonRoom.InnerBounds.Center;
        Tile tile = Main.tile[center.X, center.Y];
        WorldGen.AddShadowOrb(center.X, center.Y, true);
        if (Main.tile[center.X, center.Y].type == (ushort) 31 /*0x1F*/)
          --num12;
        list.Remove(dungeonRoom);
      }
    }
    if (dictionary.ContainsKey(9))
    {
      List<DungeonRoom> list = dictionary[9].ToList<DungeonRoom>();
      while (list.Count > 0)
      {
        DungeonRoom dungeonRoom = list[0];
        Point center = dungeonRoom.InnerBounds.Center;
        WorldGen.AddBeeLarva(center.X - 1, center.Y - 3);
        list.Remove(dungeonRoom);
      }
    }
    if (data.Type == DungeonType.DualDungeon)
    {
      for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
      {
        DungeonGenerationStyleData dungeonGenerationStyle = data.genVars.dungeonGenerationStyles[index];
        List<DungeonRoom> dungeonRoomList = dictionary[(int) dungeonGenerationStyle.Style];
        int num13 = num6;
        int num14;
        switch (WorldGen.GetWorldSize())
        {
          case 1:
            num14 = 4;
            break;
          case 2:
            num14 = 6;
            break;
          default:
            num14 = 2;
            break;
        }
        if (dungeonRoomList != null)
        {
          while (dungeonRoomList.Count > 0 && num13 > 0)
          {
            DungeonRoom room = dungeonRoomList[genRand.Next(dungeonRoomList.Count)];
            if (room is BiomeDungeonRoom)
            {
              dungeonRoomList.Remove(room);
            }
            else
            {
              int x = room.InnerBounds.Center.X;
              int y = room.InnerBounds.Bottom - 5;
              int num15 = room.InnerBounds.Width / 2;
              int num16 = (int) ((double) room.InnerBounds.Height * 0.75);
              bool flag = num14 > 0 || genRand.Next(8) == 0;
              DungeonGenerationStyleData styleData = room.settings.StyleData;
              DungeonPitTrap feature1 = new DungeonPitTrap((DungeonFeatureSettings) new DungeonPitTrapSettings()
              {
                Style = styleData,
                Width = num15,
                Height = num16,
                EdgeWidth = 2,
                EdgeHeight = 2,
                TopDensity = 8,
                ConnectedRoom = room,
                Flooded = flag
              }, false);
              if (!room.settings.StyleData.CanGenerateFeatureAt(data, room, (IDungeonFeature) feature1, x, y))
              {
                dungeonRoomList.Remove(room);
              }
              else
              {
                if (feature1.GenerateFeature(data, x, y))
                {
                  DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) feature1);
                  if (flag && num14 > 0)
                    --num14;
                  --num13;
                }
                else
                {
                  int num17 = Math.Max(10, (int) ((double) room.InnerBounds.Height * 0.5));
                  DungeonPitTrap feature2 = new DungeonPitTrap((DungeonFeatureSettings) new DungeonPitTrapSettings()
                  {
                    Style = styleData,
                    Width = num15,
                    Height = num17,
                    EdgeWidth = 2,
                    EdgeHeight = 2,
                    TopDensity = 8,
                    ConnectedRoom = room,
                    Flooded = flag
                  }, false);
                  if (!room.settings.StyleData.CanGenerateFeatureAt(data, room, (IDungeonFeature) feature2, x, y))
                  {
                    dungeonRoomList.Remove(room);
                    continue;
                  }
                  if (feature2.GenerateFeature(data, x, y))
                  {
                    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) feature2);
                    if (flag && num14 > 0)
                      --num14;
                    --num13;
                  }
                  else
                  {
                    int num18 = (int) ((double) (room.InnerBounds.Width / 2) * 0.75);
                    DungeonPitTrap feature3 = new DungeonPitTrap((DungeonFeatureSettings) new DungeonPitTrapSettings()
                    {
                      Style = styleData,
                      Width = num18,
                      Height = num17,
                      EdgeWidth = 2,
                      EdgeHeight = 2,
                      TopDensity = 8,
                      ConnectedRoom = room,
                      Flooded = flag
                    }, false);
                    if (!room.settings.StyleData.CanGenerateFeatureAt(data, room, (IDungeonFeature) feature3, x, y))
                    {
                      dungeonRoomList.Remove(room);
                      continue;
                    }
                    if (feature3.GenerateFeature(data, x, y))
                    {
                      DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) feature3);
                      if (flag && num14 > 0)
                        --num14;
                      --num13;
                    }
                  }
                }
                dungeonRoomList.Remove(room);
              }
            }
          }
        }
      }
    }
    if (dictionary.ContainsKey(3))
    {
      List<DungeonRoom> list = dictionary[3].ToList<DungeonRoom>();
      while (list.Count > 0 && num3 > 0)
      {
        DungeonRoom dungeonRoom = list[genRand.Next(list.Count)];
        int num19 = 20;
        while (num19 > 0 && num3 > 0)
        {
          --num19;
          int x = dungeonRoom.InnerBounds.Left + genRand.Next(dungeonRoom.InnerBounds.Width);
          int y = dungeonRoom.InnerBounds.Top + genRand.Next(dungeonRoom.InnerBounds.Height);
          if (WorldGen.InWorld(x, y, 25))
          {
            Tile tile;
            for (tile = Main.tile[x, y]; y < Main.UnderworldLayer - 10 && !tile.active(); tile = Main.tile[x, y])
              ++y;
            if (tile.active() && (int) tile.type == (int) DungeonGenerationStyles.Desert.BrickTileType)
            {
              DungeonDropTrap dungeonDropTrap = new DungeonDropTrap((DungeonFeatureSettings) new DungeonDropTrapSettings()
              {
                StyleData = DungeonGenerationStyles.Desert,
                DropTrapType = (genRand.Next(2) == 0 ? DungeonDropTrapType.Sand : DungeonDropTrapType.Lava)
              }, false);
              if (dungeonDropTrap.GenerateFeature(data, x, y))
              {
                DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) dungeonDropTrap);
                --num3;
              }
            }
          }
        }
        list.Remove(dungeonRoom);
      }
    }
    if (dictionary.ContainsKey(2))
    {
      List<DungeonRoom> list = dictionary[2].ToList<DungeonRoom>();
      while (list.Count > 0 && num4 > 0)
      {
        DungeonRoom dungeonRoom = list[genRand.Next(list.Count)];
        int num20 = 20;
        while (num20 > 0 && num4 > 0)
        {
          --num20;
          int x = dungeonRoom.InnerBounds.Left + genRand.Next(dungeonRoom.InnerBounds.Width);
          int y = dungeonRoom.InnerBounds.Top + genRand.Next(dungeonRoom.InnerBounds.Height);
          if (WorldGen.InWorld(x, y, 25))
          {
            Tile tile;
            for (tile = Main.tile[x, y]; y < Main.UnderworldLayer - 10 && !tile.active(); tile = Main.tile[x, y])
              ++y;
            if (tile.active() && (int) tile.type == (int) DungeonGenerationStyles.Snow.BrickTileType)
            {
              DungeonDropTrap dungeonDropTrap = new DungeonDropTrap((DungeonFeatureSettings) new DungeonDropTrapSettings()
              {
                StyleData = DungeonGenerationStyles.Snow,
                DropTrapType = DungeonDropTrapType.Slush
              }, false);
              if (dungeonDropTrap.GenerateFeature(data, x, y))
              {
                DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) dungeonDropTrap);
                --num4;
              }
            }
          }
        }
        list.Remove(dungeonRoom);
      }
    }
    if (dictionary.ContainsKey(1))
    {
      List<DungeonRoom> list = dictionary[1].ToList<DungeonRoom>();
      while (list.Count > 0 && num5 > 0)
      {
        DungeonRoom dungeonRoom = list[genRand.Next(list.Count)];
        int num21 = 20;
        while (num21 > 0 && num5 > 0)
        {
          --num21;
          int x = dungeonRoom.InnerBounds.Left + genRand.Next(dungeonRoom.InnerBounds.Width);
          int y = dungeonRoom.InnerBounds.Top + genRand.Next(dungeonRoom.InnerBounds.Height);
          if (WorldGen.InWorld(x, y, 25))
          {
            Tile tile;
            for (tile = Main.tile[x, y]; y < Main.UnderworldLayer - 10 && !tile.active(); tile = Main.tile[x, y])
              ++y;
            if (tile.active() && (int) tile.type == (int) DungeonGenerationStyles.Cavern.BrickTileType)
            {
              DungeonDropTrap dungeonDropTrap = new DungeonDropTrap((DungeonFeatureSettings) new DungeonDropTrapSettings()
              {
                StyleData = DungeonGenerationStyles.Cavern,
                DropTrapType = DungeonDropTrapType.Silt
              }, false);
              if (dungeonDropTrap.GenerateFeature(data, x, y))
              {
                DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) dungeonDropTrap);
                --num5;
              }
            }
          }
        }
        list.Remove(dungeonRoom);
      }
    }
    for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
    {
      DungeonGenerationStyleData dungeonGenerationStyle = data.genVars.dungeonGenerationStyles[index];
      byte style = dungeonGenerationStyle.Style;
      DungeonBounds progressionBound = data.outerProgressionBounds[index];
      if (style == (byte) 3)
      {
        int num22 = 1000;
        int num23 = num7;
        while (num23 > 0)
        {
          --num22;
          if (num22 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int y = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile = Main.tile[x, y];
            if ((int) tile.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile.type);
              if (styleForTile != null && styleForTile.Style == (byte) 3)
              {
                new DungeonTileClump((DungeonFeatureSettings) new DungeonTileClumpSettings()
                {
                  RandomSeed = genRand.Next(),
                  Strength = (double) (25 + genRand.Next(10)),
                  Steps = (25 + genRand.Next(10)),
                  TileType = (ushort) 53,
                  WallType = (ushort) 216,
                  AreaToGenerateIn = (DungeonBounds) null,
                  OnlyReplaceThisTileType = new ushort?(styleForTile.BrickTileType),
                  OnlyReplaceThisWallType = new ushort?(styleForTile.BrickWallType)
                }).GenerateFeature(data, x, y);
                --num23;
              }
            }
          }
          else
            break;
        }
        int num24 = 1000;
        int num25 = num7;
        while (num25 > 0)
        {
          --num24;
          if (num24 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int y = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile = Main.tile[x, y];
            if ((int) tile.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile.type);
              if (styleForTile != null && styleForTile.Style == (byte) 3)
              {
                new DungeonTileClump((DungeonFeatureSettings) new DungeonTileClumpSettings()
                {
                  RandomSeed = genRand.Next(),
                  Strength = (double) (25 + genRand.Next(10)),
                  Steps = (25 + genRand.Next(10)),
                  TileType = (ushort) 397,
                  WallType = (ushort) 216,
                  AreaToGenerateIn = (DungeonBounds) null,
                  OnlyReplaceThisTileType = new ushort?(styleForTile.BrickTileType),
                  OnlyReplaceThisWallType = new ushort?(styleForTile.BrickWallType)
                }).GenerateFeature(data, x, y);
                --num25;
              }
            }
          }
          else
            break;
        }
        int num26 = 1000;
        int num27 = num7 * 2;
        while (num27 > 0)
        {
          --num26;
          if (num26 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int y = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile = Main.tile[x, y];
            if ((int) tile.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile.type);
              if (styleForTile != null && styleForTile.Style == (byte) 3)
              {
                new DungeonTileClump((DungeonFeatureSettings) new DungeonTileClumpSettings()
                {
                  RandomSeed = genRand.Next(),
                  Strength = (double) (15 + genRand.Next(5)),
                  Steps = (15 + genRand.Next(5)),
                  TileType = (ushort) 404,
                  WallType = (ushort) 223,
                  AreaToGenerateIn = (DungeonBounds) null,
                  OnlyReplaceThisTileType = new ushort?(styleForTile.BrickTileType),
                  OnlyReplaceThisWallType = new ushort?(styleForTile.BrickWallType)
                }).GenerateFeature(data, x, y);
                --num27;
              }
            }
          }
          else
            break;
        }
      }
      if (style == (byte) 2)
      {
        int num28 = 1000;
        int num29 = num8;
        while (num29 > 0)
        {
          --num28;
          if (num28 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int y = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile = Main.tile[x, y];
            if ((int) tile.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile.type);
              if (styleForTile != null && styleForTile.Style == (byte) 2)
              {
                new DungeonTileClump((DungeonFeatureSettings) new DungeonTileClumpSettings()
                {
                  RandomSeed = genRand.Next(),
                  Strength = (double) (25 + genRand.Next(10)),
                  Steps = (25 + genRand.Next(10)),
                  TileType = (ushort) 147,
                  WallType = (ushort) 40,
                  AreaToGenerateIn = (DungeonBounds) null,
                  OnlyReplaceThisTileType = new ushort?(styleForTile.BrickTileType),
                  OnlyReplaceThisWallType = new ushort?(styleForTile.BrickWallType)
                }).GenerateFeature(data, x, y);
                --num29;
              }
            }
          }
          else
            break;
        }
        int num30 = 1000;
        int num31 = num8;
        while (num31 > 0)
        {
          --num30;
          if (num30 > 0)
          {
            int x = progressionBound.Left + genRand.Next(progressionBound.Width);
            int y = progressionBound.Top + genRand.Next(progressionBound.Height);
            Tile tile = Main.tile[x, y];
            if ((int) tile.wall == (int) dungeonGenerationStyle.BrickWallType)
            {
              DungeonGenerationStyleData styleForTile = DungeonGenerationStyles.GetStyleForTile(data.genVars.dungeonGenerationStyles, (int) tile.type);
              if (styleForTile != null && styleForTile.Style == (byte) 2)
              {
                new DungeonTileClump((DungeonFeatureSettings) new DungeonTileClumpSettings()
                {
                  RandomSeed = genRand.Next(),
                  Strength = (double) (25 + genRand.Next(10)),
                  Steps = (25 + genRand.Next(10)),
                  TileType = (ushort) 224 /*0xE0*/,
                  WallType = (ushort) 40,
                  AreaToGenerateIn = (DungeonBounds) null,
                  OnlyReplaceThisTileType = new ushort?(styleForTile.BrickTileType),
                  OnlyReplaceThisWallType = new ushort?(styleForTile.BrickWallType)
                }).GenerateFeature(data, x, y);
                --num31;
              }
            }
          }
          else
            break;
        }
      }
    }
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
      data.dungeonRooms[index].GenerateEarlyDungeonFeaturesInRoom(data);
    if (biomeDungeonRoom != null)
    {
      int x = biomeDungeonRoom.InnerBounds.Center.X;
      int index3 = (biomeDungeonRoom.InnerBounds.Top + biomeDungeonRoom.InnerBounds.Center.Y) / 2;
      for (Tile tile = Main.tile[x, index3]; !tile.active(); tile = Main.tile[x, index3])
        ++index3;
      for (int index4 = -1; index4 <= 1; ++index4)
      {
        int index5 = x + index4;
        int index6 = index3;
        for (Tile tile = Main.tile[index5, index6]; !tile.active(); tile = Main.tile[index5, index6])
        {
          tile.ClearTile();
          tile.active(true);
          tile.type = (ushort) 226;
          ++index6;
        }
      }
      WorldGen.AddLihzahrdAltar(x - 1, index3 - 2);
    }
    if (data.Type != DungeonType.Default)
      return;
    int num32 = (int) ((double) Main.maxTilesX * 2.0 * data.dungeonStepScalar);
    int num33;
    for (int index = 0; index < num32; index = num33 + 1)
    {
      int x = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int minValue = data.dungeonBounds.Top;
      if (minValue < Main.dungeonY + 25)
        minValue = Main.dungeonY + 25;
      if ((double) minValue < Main.worldSurface)
        minValue = (int) Main.worldSurface;
      int y = genRand.Next(minValue, data.dungeonBounds.Bottom);
      bool flag = data.makeNextPitTrapFlooded || genRand.Next(8) == 0;
      int num34 = genRand.Next(6, 10);
      if (new DungeonPitTrap((DungeonFeatureSettings) new DungeonPitTrapSettings()
      {
        Style = data.genVars.dungeonStyle,
        Width = genRand.Next(8, 19),
        Height = genRand.Next(19, 46),
        EdgeWidth = genRand.Next(6, 10),
        EdgeHeight = num34,
        TopDensity = num34,
        Flooded = flag
      }).GenerateFeature(data, x, y))
      {
        if (flag)
          data.makeNextPitTrapFlooded = false;
        num33 = index + 1500;
      }
      else
        num33 = index + 1;
    }
  }
}
