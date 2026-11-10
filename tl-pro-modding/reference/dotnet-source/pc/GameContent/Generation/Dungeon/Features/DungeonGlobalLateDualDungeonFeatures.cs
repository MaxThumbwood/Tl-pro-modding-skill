// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalLateDualDungeonFeatures
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalLateDualDungeonFeatures : GlobalDungeonFeature
{
  public DungeonGlobalLateDualDungeonFeatures(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.LateDualDungeonFeatures(data);
    this.generated = true;
    return true;
  }

  public void LateDualDungeonFeatures(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
    {
      DungeonGenerationStyleData dungeonGenerationStyle = data.genVars.dungeonGenerationStyles[index];
      byte style = dungeonGenerationStyle.Style;
      DungeonBounds progressionBound = data.outerProgressionBounds[index];
      if ((style == (byte) 8 || style == (byte) 7) && dungeonGenerationStyle.BrickGrassTileType.HasValue)
      {
        ushort num = dungeonGenerationStyle.BrickGrassTileType.Value;
        for (int left = progressionBound.Left; left <= progressionBound.Right; ++left)
        {
          for (int top = progressionBound.Top; top <= progressionBound.Bottom; ++top)
          {
            Tile tile = Main.tile[left, top];
            if (tile.active() && tile.type == (ushort) 59 && WorldGen.TileIsExposedToAir(left, top))
              tile.type = num;
          }
        }
      }
    }
    List<BiomeDungeonRoom> biomeDungeonRoomList = new List<BiomeDungeonRoom>();
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = data.dungeonRooms[index];
      if (dungeonRoom is BiomeDungeonRoom)
        biomeDungeonRoomList.Add((BiomeDungeonRoom) dungeonRoom);
    }
    while (biomeDungeonRoomList.Count > 0)
    {
      BiomeDungeonRoom room = biomeDungeonRoomList[0];
      this.LateDualDungeonFeatures_CleanOutEntrancesOfLiquids(room);
      if (room.settings.StyleData.Style == (byte) 8)
        this.LateDualDungeonFeatures_GrowGrass((DungeonRoom) room);
      biomeDungeonRoomList.Remove(room);
    }
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
      data.dungeonRooms[index].GenerateLateDungeonFeaturesInRoom(data);
  }

  private void LateDualDungeonFeatures_CleanOutEntrancesOfLiquids(BiomeDungeonRoom room)
  {
    DungeonBounds innerBounds = room.InnerBounds;
    int num1 = innerBounds.Left - 1;
    int num2 = innerBounds.Right + 1;
    int num3 = innerBounds.Top - 1;
    int num4 = innerBounds.Bottom + 1;
    int num5 = -1;
    for (int index = 0; index < 2; ++index)
    {
      int x = index == 0 ? num1 : num2;
      for (int y = num3; y <= num4; ++y)
      {
        if (!innerBounds.Contains(x, y))
        {
          if (Main.tile[x, y].active())
          {
            if (num5 != -1)
              this.LateDualDungeonFeatures_CleanOutEntrancesOfLiquids_ActuallyClearArea(x, (num5 + y - 1) / 2);
            num5 = -1;
          }
          else if (num5 == -1)
            num5 = y;
        }
      }
    }
    int num6 = -1;
    for (int index = 0; index < 2; ++index)
    {
      int y = index == 0 ? num3 : num4;
      for (int x = num1; x <= num2; ++x)
      {
        if (!innerBounds.Contains(x, y))
        {
          if (Main.tile[x, y].active())
          {
            if (num6 != -1)
              this.LateDualDungeonFeatures_CleanOutEntrancesOfLiquids_ActuallyClearArea((num6 + x - 1) / 2, y);
            num6 = -1;
          }
          else if (num6 == -1)
            num6 = x;
        }
      }
    }
  }

  private void LateDualDungeonFeatures_CleanOutEntrancesOfLiquids_ActuallyClearArea(int x, int y)
  {
    int num = 30;
    for (int index1 = -num; index1 <= num; ++index1)
    {
      for (int index2 = -num; index2 <= num; ++index2)
      {
        Tile tile = Main.tile[x + index1, y + index2];
        if (tile.liquid > (byte) 0)
        {
          tile.liquid = (byte) 0;
          tile.liquidType(0);
        }
      }
    }
  }

  private void LateDualDungeonFeatures_GrowGrass(DungeonRoom room)
  {
    if (room == null || !room.settings.StyleData.BrickGrassTileType.HasValue)
      return;
    this.LateDualDungeonFeatures_GrowGrass(room, room.settings.StyleData.BrickTileType, room.settings.StyleData.BrickGrassTileType.Value);
  }

  private void LateDualDungeonFeatures_GrowGrass(
    DungeonRoom room,
    ushort dirtType,
    ushort grassType)
  {
    if (room == null)
      return;
    DungeonBounds outerBounds = room.OuterBounds;
    for (int left = outerBounds.Left; left <= outerBounds.Right; ++left)
    {
      for (int top = outerBounds.Top; top <= outerBounds.Bottom; ++top)
      {
        Tile tile = Main.tile[left, top];
        if (tile.active() && (int) tile.type == (int) dirtType && WorldGen.TileIsExposedToAir(left, top))
          tile.type = grassType;
      }
    }
  }
}
