// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.LayoutProviders.LegacyDungeonLayoutProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.LayoutProviders;

public class LegacyDungeonLayoutProvider(DungeonLayoutProviderSettings settings) : 
  DungeonLayoutProvider(settings)
{
  public override void ProvideLayout(
    DungeonData data,
    GenerationProgress progress,
    UnifiedRandom genRand,
    ref int roomDelay)
  {
    LegacyDungeonLayoutProviderSettings settings = (LegacyDungeonLayoutProviderSettings) this.settings;
    int steps = settings.Steps;
    int maxSteps = settings.MaxSteps;
    this.LegacyDungeonLayout(data, progress, genRand, this.settings.StyleData.BrickTileType, this.settings.StyleData.BrickCrackedTileType, this.settings.StyleData.BrickWallType, steps, maxSteps, ref roomDelay);
  }

  public void LegacyDungeonLayout(
    DungeonData data,
    GenerationProgress progress,
    UnifiedRandom genRand,
    ushort tileType,
    ushort crackedTileType,
    ushort wallType,
    int steps,
    int maxSteps,
    ref int roomDelay)
  {
    if (data.genVars.preGenDungeonEntranceSettings.PrecalculateEntrancePosition)
    {
      data.genVars.generatingDungeonPositionX = (int) data.genVars.dungeonEntrancePosition.X - 10 + genRand.Next(20);
      data.genVars.generatingDungeonPositionY = (int) data.genVars.dungeonEntrancePosition.Y + 30;
    }
    data.outerProgressionBounds = new DungeonBounds[1];
    data.outerProgressionBounds[0] = data.genVars.outerPotentialDungeonBounds;
    LegacyDungeonHallSettings dungeonHallSettings = new LegacyDungeonHallSettings();
    dungeonHallSettings.StyleData = data.genVars.dungeonStyle;
    dungeonHallSettings.RandomSeed = genRand.Next();
    LegacyDungeonHallSettings settings1 = dungeonHallSettings;
    LegacyDungeonRoomSettings dungeonRoomSettings = new LegacyDungeonRoomSettings();
    dungeonRoomSettings.StyleData = data.genVars.dungeonStyle;
    dungeonRoomSettings.RandomSeed = genRand.Next();
    LegacyDungeonRoomSettings settings2 = dungeonRoomSettings;
    LegacyDungeonRoomSettings settings3 = new LegacyDungeonRoomSettings();
    settings3.StyleData = data.genVars.dungeonStyle;
    settings3.StartingRoom = true;
    settings3.RandomSeed = genRand.Next();
    settings3.RoomPosition = new Point(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
    DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings3).GenerateRoom(data);
    while (steps > 0)
    {
      data.dungeonBounds.UpdateBounds(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
      --steps;
      int num = (maxSteps - steps) / maxSteps * 60;
      DungeonUtils.UpdateDungeonProgress(progress, (float) num / 100f, Language.GetTextValue("WorldGeneration.DungeonRoomsAndHalls"));
      if (roomDelay > 0)
        --roomDelay;
      if (roomDelay == 0 & genRand.Next(3) == 0)
      {
        roomDelay = 5;
        if (genRand.Next(2) == 0)
        {
          int dungeonPositionX = data.genVars.generatingDungeonPositionX;
          int dungeonPositionY = data.genVars.generatingDungeonPositionY;
          settings1.RandomSeed = genRand.Next();
          DungeonCrawler.MakeDungeon_GetHall_Legacy(settings1).GenerateHall(data, data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
          if (genRand.Next(2) == 0)
          {
            settings1.RandomSeed = genRand.Next();
            DungeonCrawler.MakeDungeon_GetHall_Legacy(settings1).GenerateHall(data, data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
          }
          settings2.RandomSeed = genRand.Next();
          settings2.RoomPosition = new Point(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
          DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings2).GenerateRoom(data);
          data.genVars.generatingDungeonPositionX = dungeonPositionX;
          data.genVars.generatingDungeonPositionY = dungeonPositionY;
        }
        else
        {
          settings2.RandomSeed = genRand.Next();
          settings2.RoomPosition = new Point(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
          DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings2).GenerateRoom(data);
        }
      }
      else
      {
        settings1.RandomSeed = genRand.Next();
        DungeonCrawler.MakeDungeon_GetHall_Legacy(settings1).GenerateHall(data, data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
      }
    }
    settings2.RandomSeed = genRand.Next();
    settings2.RoomPosition = new Point(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
    DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings2).GenerateRoom(data);
    data.outerProgressionBounds[0] = data.dungeonBounds;
  }
}
