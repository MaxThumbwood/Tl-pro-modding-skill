// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.MinionSpawnFromInventoryItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class MinionSpawnFromInventoryItem : MinionSpawnInfo
{
  public int ItemType;
  public int ItemPrefix;

  public MinionSpawnFromInventoryItem(Item item)
  {
    this.ItemType = item.type;
    this.ItemPrefix = (int) item.prefix;
  }

  protected virtual bool ItemMatches(Item item)
  {
    return item.type == this.ItemType && (int) item.prefix == this.ItemPrefix;
  }

  public override void TryRespawn(Player player)
  {
    Item matchingItem = this.FindMatchingItem(player);
    if (matchingItem == null)
      return;
    if (matchingItem.buffType > 0)
    {
      int time = matchingItem.buffTime;
      if (time == 0)
        time = 3600;
      player.AddBuff(matchingItem.buffType, time);
    }
    player.SilentlyShootItem(matchingItem);
  }

  protected Item FindMatchingItem(Player player)
  {
    Item[] inventory = player.inventory;
    for (int index = 0; index < 50; ++index)
    {
      Item matchingItem = inventory[index];
      if (this.ItemMatches(matchingItem))
        return matchingItem;
    }
    return (Item) null;
  }
}
