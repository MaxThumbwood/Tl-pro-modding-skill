// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.QuickStacking
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent;

public class QuickStacking
{
  private static QuickStacking.SourceInventory netInv;
  private static Item[] inventoryItemsScratch = new Item[400];
  private static PlayerItemSlotID.SlotReference[] slotsScratch = new PlayerItemSlotID.SlotReference[400];
  private static bool[] blockedSlotsScratch = new bool[400];
  private static List<QuickStacking.DestinationHelper> destHelperListScratch = new List<QuickStacking.DestinationHelper>();
  private static QuickStacking.MatchingItemTypeDestinationList matchingItemTypeScratch = new QuickStacking.MatchingItemTypeDestinationList();
  private static List<int> _blockedChests = new List<int>();
  private static QuickStacking.DestinationHelper[] destHelperPool = new QuickStacking.DestinationHelper[100];
  private static int nextDestHelper = 0;

  private static void AddToListyArray<T>(ref T[] arr, ref int count, T elem)
  {
    if (count == arr.Length)
      Array.Resize<T>(ref arr, arr.Length * 2);
    arr[count++] = elem;
  }

  private static int GetCategory(int type) => ItemSorting.GetSortingLayerIndex(type);

  public static void QuickStackToNearbyInventories(Player player, bool smartStack = false)
  {
    QuickStacking.QuickStackToNearbyBanks(player);
    QuickStacking.QuickStackToNearbyChests(player, smartStack);
  }

  private static void QuickStackToNearbyBanks(Player player)
  {
    List<PositionedChest> banksInRangeOf = NearbyChests.GetBanksInRangeOf(player);
    foreach (PositionedChest positionedChest in banksInRangeOf)
    {
      long coinsMoved = ChestUI.MoveCoins(player.inventory, positionedChest.chest);
      Chest.VisualizeChestTransfer_CoinsBatch(player.Center, positionedChest.position, coinsMoved, Chest.ItemTransferVisualizationSettings.PlayerToChest);
    }
    QuickStacking.SourceInventory sourceInventory = QuickStacking.PackQuickStackableItems(player, false);
    QuickStacking.Transfer(sourceInventory, banksInRangeOf, out List<int> _);
    QuickStacking.RestoreToPlayer(player, sourceInventory);
  }

  public static void QuickStackToNearbyChests(Player player, bool smartStack = false)
  {
    QuickStacking.QuickStackToNearbyChests(player, QuickStacking.PackQuickStackableItems(player, true), smartStack);
  }

  internal static void QuickStackToNearbyChests(
    Player player,
    QuickStacking.SourceInventory inventory,
    bool smartStack)
  {
    if (Main.netMode == 1)
    {
      QuickStacking.SendQuickStackToNearbyChests(player, inventory, smartStack);
    }
    else
    {
      List<PositionedChest> chestsInRangeOf = NearbyChests.GetChestsInRangeOf(player.position);
      List<int> blockedChests;
      QuickStacking.Transfer(inventory, chestsInRangeOf, out blockedChests, smartStack);
      QuickStacking.IndicateBlockedChests(player, blockedChests);
      QuickStacking.RestoreToPlayer(player, inventory);
    }
  }

  internal static void IndicateBlockedChests(Player player, List<int> chests)
  {
    if (!chests.Any<int>())
      return;
    if (Main.netMode == 2)
    {
      NetMessage.SendData(85, player.whoAmI, number: player.whoAmI);
    }
    else
    {
      foreach (int chest in chests)
        Chest.IndicateBlockedChest(chest);
    }
  }

  private static void SendQuickStackToNearbyChests(
    Player player,
    QuickStacking.SourceInventory inventory,
    bool smartStack)
  {
    QuickStacking.netInv = inventory;
    for (int index = 0; index < inventory.numItems; ++index)
    {
      int slotId = inventory.slots[index].SlotId;
      player.LockNetSlot(slotId);
      NetMessage.SendData(5, number: player.whoAmI, number2: (float) slotId);
    }
    NetMessage.SendData(85, number: smartStack ? 1 : 0);
  }

  internal static void WriteNetInventorySlots(BinaryWriter writer)
  {
    writer.Write(QuickStacking.netInv.numItems);
    for (int index = 0; index < QuickStacking.netInv.numItems; ++index)
      writer.Write((short) QuickStacking.netInv.slots[index].SlotId);
  }

  internal static QuickStacking.SourceInventory ReadNetInventory(Player player, BinaryReader reader)
  {
    QuickStacking.SourceInventory scratchInventory = QuickStacking.GetScratchInventory(player);
    Array.Clear((Array) scratchInventory.transferBlocked, 0, scratchInventory.transferBlocked.Length);
    scratchInventory.numItems = reader.ReadInt32();
    for (int index = 0; index < scratchInventory.numItems; ++index)
    {
      PlayerItemSlotID.SlotReference slotReference = new PlayerItemSlotID.SlotReference(player, (int) reader.ReadInt16());
      scratchInventory.slots[index] = slotReference;
      Item obj = slotReference.Item;
      scratchInventory.items[index] = obj;
    }
    return scratchInventory;
  }

  internal static void WriteBlockedChestList(BinaryWriter writer)
  {
    writer.Write(QuickStacking._blockedChests.Count);
    for (int index = 0; index < QuickStacking._blockedChests.Count; ++index)
      writer.Write((ushort) QuickStacking._blockedChests[index]);
  }

  internal static List<int> ReadBlockedChestList(BinaryReader reader)
  {
    QuickStacking._blockedChests.Clear();
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
      QuickStacking._blockedChests.Add((int) reader.ReadUInt16());
    return QuickStacking._blockedChests;
  }

  private static void RestoreToPlayer(Player player, QuickStacking.SourceInventory inventory)
  {
    for (int index = 0; index < inventory.numItems; ++index)
    {
      Item obj = inventory.items[index];
      PlayerItemSlotID.SlotReference slot = inventory.slots[index];
      bool flag = inventory.transferBlocked[index];
      if (true)
        slot.Item = obj;
      if (Main.netMode == 2)
        NetMessage.SendData(5, number: player.whoAmI, number2: (float) slot.SlotId, number3: flag ? 1f : 0.0f);
      else if (flag)
        ItemSlot.IndicateBlockedSlot(slot);
    }
  }

  private static QuickStacking.SourceInventory GetScratchInventory(Player player)
  {
    return new QuickStacking.SourceInventory()
    {
      items = QuickStacking.inventoryItemsScratch,
      numItems = 0,
      slots = QuickStacking.slotsScratch,
      transferBlocked = QuickStacking.blockedSlotsScratch,
      position = player.Center
    };
  }

  private static QuickStacking.SourceInventory PackQuickStackableItems(
    Player player,
    bool includeVoidBag)
  {
    QuickStacking.SourceInventory scratchInventory = QuickStacking.GetScratchInventory(player);
    Array.Clear((Array) scratchInventory.transferBlocked, 0, scratchInventory.transferBlocked.Length);
    QuickStacking.AddQuickStackableItems(player, ref scratchInventory, PlayerItemSlotID.Inventory0 + 10, 40);
    if (player.useVoidBag() & includeVoidBag)
      QuickStacking.AddQuickStackableItems(player, ref scratchInventory, PlayerItemSlotID.Bank4_0, player.bank4.maxItems);
    return scratchInventory;
  }

  private static void AddQuickStackableItems(
    Player player,
    ref QuickStacking.SourceInventory inventory,
    int startSlot,
    int count)
  {
    for (int index1 = 0; index1 < count; ++index1)
    {
      PlayerItemSlotID.SlotReference slotReference = new PlayerItemSlotID.SlotReference(player, startSlot + index1);
      Item obj = slotReference.Item;
      if (!obj.IsAir && !obj.favorited && !obj.IsACoin)
      {
        int index2 = inventory.numItems++;
        inventory.slots[index2] = slotReference;
        inventory.items[index2] = obj;
      }
    }
  }

  private static void Transfer(
    QuickStacking.SourceInventory source,
    List<PositionedChest> destinations,
    out List<int> blockedChests,
    bool smartStack = false)
  {
    QuickStacking.nextDestHelper = 0;
    List<QuickStacking.DestinationHelper> helperListScratch = QuickStacking.destHelperListScratch;
    helperListScratch.Clear();
    QuickStacking.MatchingItemTypeDestinationList matchingItemTypeScratch = QuickStacking.matchingItemTypeScratch;
    matchingItemTypeScratch.Reset();
    foreach (PositionedChest destination in destinations)
    {
      if (!destination.chest.IsEmpty())
      {
        QuickStacking.DestinationHelper destHelperFromPool = QuickStacking.GetDestHelperFromPool();
        destHelperFromPool.Reset(destination);
        helperListScratch.Add(destHelperFromPool);
        QuickStacking.BuildDestinationMetricsAndStackItems(source, destHelperFromPool, matchingItemTypeScratch);
      }
    }
    for (int i = 0; i < source.numItems; ++i)
    {
      Item obj = source.items[i];
      QuickStacking.DestinationHelper dest;
      if (!obj.IsAir && matchingItemTypeScratch.Lookup(obj.type, out dest))
      {
        QuickStacking.Consolidate(source, i);
        QuickStacking.InsertIntoFreeSlot(ref source.items[i], dest, source.position);
      }
    }
    if (smartStack)
    {
      for (int i = 0; i < source.numItems; ++i)
      {
        Item obj = source.items[i];
        QuickStacking.DestinationHelper dest;
        if (!obj.IsAir && !source.transferBlocked[i] && QuickStacking.TryGetBestDestinationForCategory(QuickStacking.GetCategory(obj.type), helperListScratch, out dest))
        {
          if (dest.locked)
          {
            source.transferBlocked[i] = true;
            dest.transferBlocked = true;
          }
          else
          {
            QuickStacking.Consolidate(source, i);
            QuickStacking.InsertIntoFreeSlot(ref source.items[i], dest, source.position);
          }
        }
      }
    }
    blockedChests = QuickStacking._blockedChests;
    blockedChests.Clear();
    foreach (QuickStacking.DestinationHelper destinationHelper in helperListScratch)
    {
      if (destinationHelper.transferBlocked)
        blockedChests.Add(destinationHelper.ChestIndex);
    }
  }

  private static QuickStacking.DestinationHelper GetDestHelperFromPool()
  {
    if (QuickStacking.nextDestHelper == QuickStacking.destHelperPool.Length)
      Array.Resize<QuickStacking.DestinationHelper>(ref QuickStacking.destHelperPool, QuickStacking.destHelperPool.Length * 2);
    if (QuickStacking.destHelperPool[QuickStacking.nextDestHelper] == null)
      QuickStacking.destHelperPool[QuickStacking.nextDestHelper] = new QuickStacking.DestinationHelper();
    return QuickStacking.destHelperPool[QuickStacking.nextDestHelper++];
  }

  private static void BuildDestinationMetricsAndStackItems(
    QuickStacking.SourceInventory source,
    QuickStacking.DestinationHelper dest,
    QuickStacking.MatchingItemTypeDestinationList destinationsForItemTypes)
  {
    for (int index1 = 0; index1 < dest.itemCount; ++index1)
    {
      Item obj1 = dest.items[index1];
      if (obj1.IsAir)
      {
        dest.AddFreeSlot(index1);
      }
      else
      {
        dest.AddCategoryScore(QuickStacking.GetCategory(obj1.type));
        for (int index2 = 0; index2 < source.numItems; ++index2)
        {
          Item obj2 = source.items[index2];
          if (obj2.type == obj1.type && Item.CanStack(obj2, obj1))
          {
            int numToTransfer = Math.Min(obj1.maxStack - obj1.stack, obj2.stack);
            if (numToTransfer != 0)
            {
              if (dest.locked)
              {
                source.transferBlocked[index2] = true;
                dest.transferBlocked = true;
              }
              else
              {
                QuickStacking.FillStack(obj2, numToTransfer, dest, index1, source.position);
                if (!obj2.IsAir)
                  destinationsForItemTypes.Add(obj1.type, dest);
              }
            }
          }
        }
      }
    }
  }

  private static bool TryGetBestDestinationForCategory(
    int category,
    List<QuickStacking.DestinationHelper> destinations,
    out QuickStacking.DestinationHelper dest)
  {
    dest = (QuickStacking.DestinationHelper) null;
    int num = int.MinValue;
    foreach (QuickStacking.DestinationHelper destination in destinations)
    {
      int score;
      if (destination.HasFreeSlots && destination.TryGetCategoryScore(category, out score) && score > num)
      {
        dest = destination;
        num = score;
      }
    }
    return dest != null;
  }

  private static void FillStack(
    Item item,
    int numToTransfer,
    QuickStacking.DestinationHelper dest,
    int slotIndex,
    Vector2 srcPosition)
  {
    Item obj = dest.items[slotIndex];
    Chest.VisualizeChestTransfer(srcPosition, dest.position, item.type, Chest.ItemTransferVisualizationSettings.PlayerToChest);
    obj.stack += numToTransfer;
    item.stack -= numToTransfer;
    if (item.stack == 0)
      item.TurnToAir();
    dest.SyncSlot(slotIndex);
  }

  private static void Consolidate(QuickStacking.SourceInventory source, int i)
  {
    Item obj1 = source.items[i++];
    while (i < source.numItems)
    {
      Item obj2 = source.items[i++];
      if (Item.CanStack(obj1, obj2))
      {
        int num = Math.Min(obj1.maxStack - obj1.stack, obj2.stack);
        obj1.stack += num;
        obj2.stack -= num;
        if (obj2.stack == 0)
          obj2.TurnToAir();
      }
    }
  }

  private static void InsertIntoFreeSlot(
    ref Item item,
    QuickStacking.DestinationHelper dest,
    Vector2 srcPosition)
  {
    Chest.VisualizeChestTransfer(srcPosition, dest.position, item.type, Chest.ItemTransferVisualizationSettings.PlayerToChest);
    int slot = dest.ConsumeFreeSlot();
    Utils.Swap<Item>(ref item, ref dest.items[slot]);
    dest.SyncSlot(slot);
  }

  private class DestinationHelper
  {
    private PositionedChest _chest;
    public Item[] items;
    public int itemCount;
    public bool locked;
    public bool transferBlocked;
    private int[] freeSlots = new int[200];
    private int freeSlotStart;
    private int freeSlotCount;
    private int[] categoryScores = new int[ItemSorting.LayerCount];

    public Vector2 position => this._chest.position;

    public void Reset(PositionedChest inventory)
    {
      this._chest = inventory;
      this.items = inventory.chest.item;
      this.itemCount = inventory.chest.maxItems;
      this.locked = inventory.chest.IsLockedOrInUse();
      this.transferBlocked = false;
      if (this.freeSlots.Length < this.itemCount)
        Array.Resize<int>(ref this.freeSlots, this.itemCount);
      Array.Clear((Array) this.freeSlots, 0, this.freeSlots.Length);
      this.freeSlotStart = 0;
      this.freeSlotCount = 0;
      Array.Clear((Array) this.categoryScores, 0, this.categoryScores.Length);
    }

    public int ChestIndex => this._chest.chest.index;

    public bool IsEmpty => this.freeSlotCount == this.itemCount;

    public bool HasFreeSlots => this.freeSlotStart < this.freeSlotCount;

    public void AddCategoryScore(int category) => ++this.categoryScores[category];

    public void AddFreeSlot(int i)
    {
      QuickStacking.AddToListyArray<int>(ref this.freeSlots, ref this.freeSlotCount, i);
    }

    public bool TryGetCategoryScore(int category, out int score)
    {
      score = this.categoryScores[category];
      return score != 0;
    }

    public int ConsumeFreeSlot() => this.freeSlots[this.freeSlotStart++];

    public void SyncSlot(int slot)
    {
      if (this._chest.chest.index < 0)
        return;
      NetMessage.SendData(32 /*0x20*/, number: this._chest.chest.index, number2: (float) slot);
    }
  }

  private class MatchingItemTypeDestinationList
  {
    private QuickStacking.MatchingItemTypeDestinationList.LinkedEntry[] entries = new QuickStacking.MatchingItemTypeDestinationList.LinkedEntry[1000];
    private int numEntries;
    private int[] firstEntryForType = new int[(int) ItemID.Count];

    public MatchingItemTypeDestinationList() => this.Reset();

    public void Reset()
    {
      Array.Clear((Array) this.firstEntryForType, 0, this.firstEntryForType.Length);
      Array.Clear((Array) this.entries, 0, this.entries.Length);
      this.numEntries = 1;
    }

    private int Tail(int type)
    {
      int next = this.firstEntryForType[type];
      if (next == 0)
        return 0;
      while (this.entries[next].next != 0)
        next = this.entries[next].next;
      return next;
    }

    internal void Add(int type, QuickStacking.DestinationHelper value)
    {
      int index = this.Tail(type);
      if (index == 0)
      {
        this.firstEntryForType[type] = this.AddEntry(value);
      }
      else
      {
        if (this.entries[index].value == value)
          return;
        this.entries[index].next = this.AddEntry(value);
      }
    }

    private int AddEntry(QuickStacking.DestinationHelper value)
    {
      if (this.numEntries == this.entries.Length)
        Array.Resize<QuickStacking.MatchingItemTypeDestinationList.LinkedEntry>(ref this.entries, this.entries.Length * 2);
      int numEntries = this.numEntries;
      QuickStacking.AddToListyArray<QuickStacking.MatchingItemTypeDestinationList.LinkedEntry>(ref this.entries, ref this.numEntries, new QuickStacking.MatchingItemTypeDestinationList.LinkedEntry()
      {
        value = value
      });
      return numEntries;
    }

    public bool Lookup(int type, out QuickStacking.DestinationHelper value)
    {
      value = (QuickStacking.DestinationHelper) null;
      int next = this.firstEntryForType[type];
      while (next > 0)
      {
        QuickStacking.MatchingItemTypeDestinationList.LinkedEntry entry = this.entries[next];
        value = entry.value;
        if (value.HasFreeSlots)
          return true;
        next = entry.next;
        this.firstEntryForType[type] = next;
      }
      return false;
    }

    private struct LinkedEntry
    {
      public QuickStacking.DestinationHelper value;
      public int next;
    }
  }

  internal struct SourceInventory
  {
    public Item[] items;
    public int numItems;
    public PlayerItemSlotID.SlotReference[] slots;
    public bool[] transferBlocked;
    public Vector2 position;
  }
}
