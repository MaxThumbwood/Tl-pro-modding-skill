// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalBiomeChests
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalBiomeChests : GlobalDungeonFeature
{
  public DungeonGlobalBiomeChests(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    if (data.Type == DungeonType.DualDungeon)
      this.BiomeChests_DualDungeons(data);
    else
      this.BiomeChests(data);
    this.generated = true;
    return true;
  }

  private void BiomeChests_DualDungeons(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    List<int> intList = new List<int>();
    intList.Add(8);
    intList.Add(WorldGen.crimson ? 5 : 4);
    intList.Add(6);
    intList.Add(2);
    intList.Add(3);
    if (WorldGen.drunkWorldGen)
      intList.Add(WorldGen.crimson ? 4 : 5);
    List<DungeonRoom>[] dungeonRoomListArray = new List<DungeonRoom>[16 /*0x10*/];
    DungeonRoom[] dungeonRoomArray = new DungeonRoom[16 /*0x10*/];
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = data.dungeonRooms[index];
      if (dungeonRoom is BiomeDungeonRoom)
      {
        dungeonRoomArray[(int) dungeonRoom.settings.StyleData.Style] = dungeonRoom;
      }
      else
      {
        if (dungeonRoomListArray[(int) dungeonRoom.settings.StyleData.Style] == null)
          dungeonRoomListArray[(int) dungeonRoom.settings.StyleData.Style] = new List<DungeonRoom>();
        dungeonRoomListArray[(int) dungeonRoom.settings.StyleData.Style].Add(dungeonRoom);
      }
    }
    for (int index1 = 0; index1 < intList.Count; ++index1)
    {
      int index2 = intList[index1];
      bool flag = false;
      DungeonRoom dungeonRoom1 = dungeonRoomArray[index2];
      if (dungeonRoom1 != null)
      {
        int num = 50;
        while (num > 0)
        {
          --num;
          if (dungeonRoom1.DualDungeons_TryGenerateBiomeChestInRoom(data, this))
          {
            flag = true;
            break;
          }
        }
      }
      if (!flag)
      {
        List<DungeonRoom> dungeonRoomList = dungeonRoomListArray[index2];
        if (dungeonRoomList != null)
        {
          int num = 30 * dungeonRoomList.Count;
          while (num > 0 && dungeonRoomList.Count > 0)
          {
            --num;
            DungeonRoom dungeonRoom2 = dungeonRoomList[genRand.Next(dungeonRoomList.Count)];
            if (dungeonRoom2.DualDungeons_TryGenerateBiomeChestInRoom(data, this))
              flag = true;
            dungeonRoomList.Remove(dungeonRoom2);
            if (flag)
              break;
          }
        }
      }
    }
  }

  private void BiomeChests(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = 5;
    if (WorldGen.drunkWorldGen)
      num1 = 6;
    int num2 = num1;
    for (int index1 = 0; index1 < num2; ++index1)
    {
      bool flag = false;
      int num3 = 1000;
      while (!flag)
      {
        --num3;
        if (num3 > 0)
        {
          int index2 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
          int index3 = genRand.Next((int) Main.worldSurface, data.dungeonBounds.Bottom);
          if ((data.dungeonEntrance == null || !data.dungeonEntrance.Bounds.Contains(index2, index3)) && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, index3].wall) && !Main.tile[index2, index3].active())
          {
            ushort chestTileType = 21;
            int mainItemInChest = 0;
            int chestStyle = 0;
            switch (index1 % num1)
            {
              case 0:
                chestStyle = 23;
                mainItemInChest = 1156;
                break;
              case 1:
                if (!WorldGen.crimson)
                {
                  chestStyle = 24;
                  mainItemInChest = 1571;
                  break;
                }
                chestStyle = 25;
                mainItemInChest = 1569;
                break;
              case 2:
                chestStyle = 26;
                mainItemInChest = 1260;
                break;
              case 3:
                chestStyle = 27;
                mainItemInChest = 1572;
                break;
              case 4:
                chestTileType = (ushort) 467;
                chestStyle = 13;
                mainItemInChest = 4607;
                break;
              case 5:
                if (WorldGen.crimson)
                {
                  chestStyle = 24;
                  mainItemInChest = 1571;
                  break;
                }
                chestStyle = 25;
                mainItemInChest = 1569;
                break;
            }
            flag = WorldGen.AddBuriedChest(index2, index3, mainItemInChest, chestStyle: chestStyle, chestTileType: chestTileType);
          }
        }
        else
          break;
      }
    }
  }
}
