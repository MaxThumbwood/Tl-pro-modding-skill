// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalBasicChests
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon.Rooms;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalBasicChests : GlobalDungeonFeature
{
  public DungeonGlobalBasicChests(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.BasicChests(data);
    this.generated = true;
    return true;
  }

  private void BasicChests(DungeonData data)
  {
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = data.dungeonRooms[index];
      int num = 0;
      while (num < 1000 && !dungeonRoom.TryGenerateChestInRoom(data, this))
        ++num;
    }
  }
}
