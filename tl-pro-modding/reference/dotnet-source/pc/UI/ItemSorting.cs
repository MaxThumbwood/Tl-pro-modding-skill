// Decompiled with JetBrains decompiler
// Type: Terraria.UI.ItemSorting
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.ID;

#nullable disable
namespace Terraria.UI;

public class ItemSorting
{
  private static List<ItemSorting.ItemSortingLayer> _layerList = new List<ItemSorting.ItemSortingLayer>();
  private static Dictionary<string, List<int>> _layerWhiteLists = new Dictionary<string, List<int>>();
  private static int[] _layerIndexForItemType;
  private static int _layerCount;
  private static List<ItemSorting.DamageTypeSortingLayerEntry> _damageRankings = new List<ItemSorting.DamageTypeSortingLayerEntry>();
  private static readonly List<int> _sort_itemsToSort = new List<int>();
  private static readonly List<int> _sort_sortedItemIndexes = new List<int>();
  private static readonly List<int> _sort_counts = new List<int>();
  private static readonly List<Item> _sort_itemsCache = new List<Item>();
  private static readonly List<int> _sort_availableSortingSlots = new List<int>();
  private static ItemSorting.MemoryStamp[] _sortInventory_preStamps = new ItemSorting.MemoryStamp[0];
  private static ItemSorting.MemoryStamp[] _sortInventory_postStamps = new ItemSorting.MemoryStamp[0];
  private static readonly List<int> _fillAmmoFromInventory_acceptedAmmoTypes = new List<int>();
  private static readonly List<int> _fillAmmoFromInventory_emptyAmmoSlots = new List<int>();

  public static int LayerCount => ItemSorting._layerCount;

  public static void SetupWhiteLists()
  {
    ItemSorting._layerWhiteLists.Clear();
    List<ItemSorting.ItemSortingLayer> itemSortingLayerList = new List<ItemSorting.ItemSortingLayer>();
    List<Item> objList = new List<Item>();
    List<int> intList1 = new List<int>();
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsMelee);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsRanged);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsMagic);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsMinions);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsAssorted);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.WeaponsAmmo);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsPicksaws);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsHamaxes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsPickaxes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsAxes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsHammers);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsTerraforming);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsFishing);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsGolf);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsInstruments);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsKeys);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsKites);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsAmmoLeftovers);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ToolsMisc);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ArmorCombat);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ArmorVanity);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.ArmorAccessories);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.EquipGrapple);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.EquipMount);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.EquipCart);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.EquipLightPet);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.EquipVanityPet);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsDyes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsHairDyes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsLife);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsJustTheMushroom);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsMana);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsElixirs);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsBuffs);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.PotionsFood);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscValuables);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscPainting);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscWiring);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscMaterials);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscJustTheGlowingMushroom);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscRopes);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscHerbsAndSeeds);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscAcorns);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscGems);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscBossBags);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscCritters);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.MiscExtractinator);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.LastMaterials);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.LastTilesImportant);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.LastTilesCommon);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.LastNotTrash);
    itemSortingLayerList.Add(ItemSorting.ItemSortingLayers.LastTrash);
    for (int type = -48; type < (int) ItemID.Count; ++type)
    {
      Item obj = new Item();
      obj.netDefaults(type);
      objList.Add(obj);
      intList1.Add(type + 48 /*0x30*/);
    }
    Item[] array = objList.ToArray();
    ItemSorting._layerCount = itemSortingLayerList.Count;
    ItemSorting._layerIndexForItemType = new int[(int) ItemID.Count];
    for (int index1 = 0; index1 < itemSortingLayerList.Count; ++index1)
    {
      ItemSorting.ItemSortingLayer itemSortingLayer = itemSortingLayerList[index1];
      List<int> intList2 = itemSortingLayer.SortingMethod(itemSortingLayer, array, intList1);
      List<int> intList3 = new List<int>();
      for (int index2 = 0; index2 < intList2.Count; ++index2)
      {
        Item obj = array[intList2[index2]];
        intList3.Add(obj.type);
        ItemSorting._layerIndexForItemType[obj.type] = index1;
      }
      ItemSorting._layerWhiteLists.Add(itemSortingLayer.Name, intList3);
    }
  }

  private static void AddSortingPrioritiesBasedOnPlayerDamage(
    List<ItemSorting.ItemSortingLayer> list)
  {
    Player player = Main.player[Main.myPlayer];
    ItemSorting._damageRankings.Clear();
    ItemSorting._damageRankings.Add(new ItemSorting.DamageTypeSortingLayerEntry(player.meleeDamage, ItemSorting.ItemSortingLayers.WeaponsMelee, 0));
    ItemSorting._damageRankings.Add(new ItemSorting.DamageTypeSortingLayerEntry(player.rangedDamage, ItemSorting.ItemSortingLayers.WeaponsRanged, 1));
    ItemSorting._damageRankings.Add(new ItemSorting.DamageTypeSortingLayerEntry(player.magicDamage, ItemSorting.ItemSortingLayers.WeaponsMagic, 2));
    ItemSorting._damageRankings.Add(new ItemSorting.DamageTypeSortingLayerEntry(player.minionDamage, ItemSorting.ItemSortingLayers.WeaponsMinions, 3));
    ItemSorting._damageRankings.Sort(new Comparison<ItemSorting.DamageTypeSortingLayerEntry>(ItemSorting.Descending));
    foreach (ItemSorting.DamageTypeSortingLayerEntry damageRanking in ItemSorting._damageRankings)
      list.Add(damageRanking.Layer);
  }

  private static int Descending(
    ItemSorting.DamageTypeSortingLayerEntry x,
    ItemSorting.DamageTypeSortingLayerEntry y)
  {
    int num = y.Multiplier.CompareTo(x.Multiplier);
    if (num == 0)
      num = x.Index.CompareTo(y.Index);
    return num;
  }

  private static void SetupSortingPriorities()
  {
    Player player = Main.player[Main.myPlayer];
    ItemSorting._layerList.Clear();
    ItemSorting.AddSortingPrioritiesBasedOnPlayerDamage(ItemSorting._layerList);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.WeaponsAssorted);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.WeaponsAmmo);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsPicksaws);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsHamaxes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsPickaxes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsAxes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsHammers);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsTerraforming);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsFishing);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsGolf);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsInstruments);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsKeys);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsKites);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsAmmoLeftovers);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ToolsMisc);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ArmorCombat);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ArmorVanity);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.ArmorAccessories);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.EquipGrapple);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.EquipMount);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.EquipCart);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.EquipLightPet);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.EquipVanityPet);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsDyes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsHairDyes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsLife);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsJustTheMushroom);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsMana);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsElixirs);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsBuffs);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.PotionsFood);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscValuables);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscPainting);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscWiring);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscMaterials);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscJustTheGlowingMushroom);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscRopes);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscHerbsAndSeeds);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscAcorns);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscGems);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscBossBags);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscCritters);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.MiscExtractinator);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.LastMaterials);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.LastTilesImportant);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.LastTilesCommon);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.LastNotTrash);
    ItemSorting._layerList.Add(ItemSorting.ItemSortingLayers.LastTrash);
  }

  private static void Sort(bool withFeedback, Item[] inv, params int[] ignoreSlots)
  {
    ItemSorting.SetupSortingPriorities();
    ItemSorting._sort_itemsToSort.Clear();
    ItemSorting._sort_sortedItemIndexes.Clear();
    ItemSorting._sort_counts.Clear();
    ItemSorting._sort_itemsCache.Clear();
    ItemSorting._sort_availableSortingSlots.Clear();
    for (int index = 0; index < inv.Length; ++index)
    {
      if (!((IEnumerable<int>) ignoreSlots).Contains<int>(index))
      {
        Item obj = inv[index];
        if (obj != null && obj.stack != 0 && obj.type != 0 && !obj.favorited)
          ItemSorting._sort_itemsToSort.Add(index);
      }
    }
    for (int index1 = 0; index1 < ItemSorting._sort_itemsToSort.Count; ++index1)
    {
      Item obj1 = inv[ItemSorting._sort_itemsToSort[index1]];
      if (obj1.stack < obj1.maxStack)
      {
        int num1 = obj1.maxStack - obj1.stack;
        for (int index2 = index1; index2 < ItemSorting._sort_itemsToSort.Count; ++index2)
        {
          if (index1 != index2)
          {
            Item obj2 = inv[ItemSorting._sort_itemsToSort[index2]];
            if (Item.CanStack(obj1, obj2) && obj2.stack != obj2.maxStack)
            {
              int num2 = obj2.stack;
              if (num1 < num2)
                num2 = num1;
              obj1.stack += num2;
              obj2.stack -= num2;
              num1 -= num2;
              if (obj2.stack == 0)
              {
                inv[ItemSorting._sort_itemsToSort[index2]] = new Item();
                ItemSorting._sort_itemsToSort.Remove(ItemSorting._sort_itemsToSort[index2]);
                --index1;
                int num3 = index2 - 1;
                break;
              }
              if (num1 == 0)
                break;
            }
          }
        }
      }
    }
    ItemSorting._sort_availableSortingSlots.AddRange((IEnumerable<int>) ItemSorting._sort_itemsToSort);
    for (int index = 0; index < inv.Length; ++index)
    {
      if (!((IEnumerable<int>) ignoreSlots).Contains<int>(index) && !ItemSorting._sort_availableSortingSlots.Contains(index))
      {
        Item obj = inv[index];
        if (obj == null || obj.stack == 0 || obj.type == 0)
          ItemSorting._sort_availableSortingSlots.Add(index);
      }
    }
    ItemSorting._sort_availableSortingSlots.Sort();
    foreach (ItemSorting.ItemSortingLayer layer in ItemSorting._layerList)
    {
      List<int> collection = layer.SortingMethod(layer, inv, ItemSorting._sort_itemsToSort);
      if (collection.Count > 0)
        ItemSorting._sort_counts.Add(collection.Count);
      ItemSorting._sort_sortedItemIndexes.AddRange((IEnumerable<int>) collection);
    }
    ItemSorting._sort_sortedItemIndexes.AddRange((IEnumerable<int>) ItemSorting._sort_itemsToSort);
    foreach (int sortSortedItemIndex in ItemSorting._sort_sortedItemIndexes)
    {
      ItemSorting._sort_itemsCache.Add(inv[sortSortedItemIndex]);
      inv[sortSortedItemIndex] = new Item();
    }
    float num = 1f / (float) ItemSorting._sort_counts.Count;
    float hue = num / 2f;
    for (int index = 0; index < ItemSorting._sort_itemsCache.Count; ++index)
    {
      int availableSortingSlot = ItemSorting._sort_availableSortingSlots[0];
      if (withFeedback)
        ItemSlot.SetGlow(availableSortingSlot, hue, Main.player[Main.myPlayer].chest != -1);
      --ItemSorting._sort_counts[0];
      if (ItemSorting._sort_counts[0] == 0)
      {
        ItemSorting._sort_counts.RemoveAt(0);
        hue += num;
      }
      inv[availableSortingSlot] = ItemSorting._sort_itemsCache[index];
      ItemSorting._sort_availableSortingSlots.Remove(availableSortingSlot);
    }
  }

  public static string GetSortingLayer(int itemType)
  {
    foreach (KeyValuePair<string, List<int>> layerWhiteList in ItemSorting._layerWhiteLists)
    {
      if (layerWhiteList.Value.Contains(itemType))
        return layerWhiteList.Key;
    }
    return (string) null;
  }

  public static int GetSortingLayerIndex(int itemType)
  {
    return ItemSorting._layerIndexForItemType[itemType];
  }

  public static void SortInventory()
  {
    if (Main.LocalPlayer.HasLockedInventory())
      return;
    if (!Main.LocalPlayer.HasItem(905))
      ItemSorting.SortCoins();
    ItemSorting.SortAmmo();
    ItemSorting.Sort(true, Main.player[Main.myPlayer].inventory, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 50, 51, 52, 53, 54, 55, 56, 57, 58);
  }

  public static void SortChest()
  {
    int chest = Main.player[Main.myPlayer].chest;
    if (chest == -1)
      return;
    Item[] objArray1 = Main.player[Main.myPlayer].bank.item;
    if (chest == -3)
    {
      Item[] objArray2 = Main.player[Main.myPlayer].bank2.item;
    }
    if (chest == -4)
    {
      Item[] objArray3 = Main.player[Main.myPlayer].bank3.item;
    }
    if (chest == -5)
    {
      Item[] objArray4 = Main.player[Main.myPlayer].bank4.item;
    }
    if (chest > -1)
    {
      Item[] objArray5 = Main.chest[chest].item;
    }
    ItemSorting.SortInventory(Main.LocalPlayer.GetCurrentContainer(), true, true);
  }

  public static void SortInventory(Chest chest, bool withSync, bool withFeedback)
  {
    Item[] inv = chest.item;
    Array.Resize<ItemSorting.MemoryStamp>(ref ItemSorting._sortInventory_preStamps, chest.maxItems);
    Array.Resize<ItemSorting.MemoryStamp>(ref ItemSorting._sortInventory_postStamps, chest.maxItems);
    for (int index = 0; index < chest.maxItems; ++index)
      ItemSorting._sortInventory_preStamps[index] = new ItemSorting.MemoryStamp(inv[index]);
    ItemSorting.Sort(withFeedback, inv);
    for (int index = 0; index < chest.maxItems; ++index)
      ItemSorting._sortInventory_postStamps[index] = new ItemSorting.MemoryStamp(inv[index]);
    if (!withSync || Main.netMode != 1 || Main.player[Main.myPlayer].chest <= -1)
      return;
    for (int number2 = 0; number2 < chest.maxItems; ++number2)
    {
      if (ItemSorting._sortInventory_postStamps[number2] != ItemSorting._sortInventory_preStamps[number2])
        NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
    }
  }

  public static void SortAmmo()
  {
    ItemSorting.ClearAmmoSlotSpaces();
    ItemSorting.FillAmmoFromInventory();
  }

  public static void FillAmmoFromInventory()
  {
    ItemSorting._fillAmmoFromInventory_acceptedAmmoTypes.Clear();
    ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Clear();
    Item[] inventory = Main.player[Main.myPlayer].inventory;
    for (int index = 54; index < 58; ++index)
    {
      ItemSlot.SetGlow(index, 0.31f, false);
      Item obj = inventory[index];
      if (obj.IsAir)
        ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Add(index);
      else if (obj.ammo != AmmoID.None)
      {
        if (!ItemSorting._fillAmmoFromInventory_acceptedAmmoTypes.Contains(obj.type))
          ItemSorting._fillAmmoFromInventory_acceptedAmmoTypes.Add(obj.type);
        ItemSorting.RefillItemStack(inventory, inventory[index], 0, 50);
      }
    }
    if (ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Count < 1)
      return;
    for (int index = 0; index < 50; ++index)
    {
      Item obj = inventory[index];
      if (obj.stack >= 1 && obj.CanFillEmptyAmmoSlot() && ItemSorting._fillAmmoFromInventory_acceptedAmmoTypes.Contains(obj.type) && !obj.favorited)
      {
        int inventoryEmptyAmmoSlot = ItemSorting._fillAmmoFromInventory_emptyAmmoSlots[0];
        ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Remove(inventoryEmptyAmmoSlot);
        Utils.Swap<Item>(ref inventory[index], ref inventory[inventoryEmptyAmmoSlot]);
        ItemSorting.RefillItemStack(inventory, inventory[inventoryEmptyAmmoSlot], 0, 50);
        if (ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Count == 0)
          break;
      }
    }
    if (ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Count < 1)
      return;
    for (int index = 0; index < 50; ++index)
    {
      Item obj = inventory[index];
      if (obj.stack >= 1 && obj.CanFillEmptyAmmoSlot() && obj.FitsAmmoSlot() && !obj.favorited)
      {
        int inventoryEmptyAmmoSlot = ItemSorting._fillAmmoFromInventory_emptyAmmoSlots[0];
        ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Remove(inventoryEmptyAmmoSlot);
        Utils.Swap<Item>(ref inventory[index], ref inventory[inventoryEmptyAmmoSlot]);
        ItemSorting.RefillItemStack(inventory, inventory[inventoryEmptyAmmoSlot], 0, 50);
        if (ItemSorting._fillAmmoFromInventory_emptyAmmoSlots.Count == 0)
          break;
      }
    }
  }

  public static void ClearAmmoSlotSpaces()
  {
    Item[] inventory = Main.player[Main.myPlayer].inventory;
    for (int index = 54; index < 58; ++index)
    {
      Item itemToRefill = inventory[index];
      if (!itemToRefill.IsAir && itemToRefill.ammo != AmmoID.None && itemToRefill.stack < itemToRefill.maxStack)
      {
        int loopStartIndex = itemToRefill.favorited ? 54 : index + 1;
        ItemSorting.RefillItemStack(inventory, itemToRefill, loopStartIndex, 58);
      }
    }
    for (int slot = 54; slot < 58; ++slot)
    {
      if (inventory[slot].type > 0 && !inventory[slot].favorited)
        ItemSorting.TrySlidingUp(inventory, slot, 54);
    }
  }

  private static void SortCoins()
  {
    Item[] inventory = Main.LocalPlayer.inventory;
    bool overFlowing;
    long count = Utils.CoinsCount(out overFlowing, inventory, 58);
    int commonMaxStack = Item.CommonMaxStack;
    if (overFlowing)
      return;
    int[] numArray = Utils.CoinsSplit(count);
    int num1 = 0;
    for (int index = 0; index < 3; ++index)
    {
      int num2 = numArray[index];
      while (num2 > 0)
      {
        num2 -= 99;
        ++num1;
      }
    }
    int num3 = numArray[3];
    while (num3 > commonMaxStack)
    {
      num3 -= commonMaxStack;
      ++num1;
    }
    int num4 = 0;
    for (int index = 0; index < 58; ++index)
    {
      if (inventory[index].type >= 71 && inventory[index].type <= 74 && inventory[index].stack > 0)
        ++num4;
    }
    if (num4 < num1)
      return;
    for (int index = 0; index < 58; ++index)
    {
      if (inventory[index].type >= 71 && inventory[index].type <= 74 && inventory[index].stack > 0)
        inventory[index].TurnToAir();
    }
    int num5 = 100;
    do
    {
      int index1 = -1;
      for (int index2 = 3; index2 >= 0; --index2)
      {
        if (numArray[index2] > 0)
        {
          index1 = index2;
          break;
        }
      }
      if (index1 != -1)
      {
        int num6 = numArray[index1];
        if (index1 == 3 && num6 > commonMaxStack)
          num6 = commonMaxStack;
        bool flag = false;
        if (!flag)
        {
          for (int index3 = 50; index3 < 54; ++index3)
          {
            if (inventory[index3].IsAir)
            {
              inventory[index3].SetDefaults(71 + index1);
              inventory[index3].stack = num6;
              numArray[index1] -= num6;
              flag = true;
              break;
            }
          }
        }
        if (!flag)
        {
          for (int index4 = 0; index4 < 50; ++index4)
          {
            if (inventory[index4].IsAir)
            {
              inventory[index4].SetDefaults(71 + index1);
              inventory[index4].stack = num6;
              numArray[index1] -= num6;
              break;
            }
          }
        }
        --num5;
      }
      else
        goto label_17;
    }
    while (num5 > 0);
    goto label_45;
label_17:
    return;
label_45:
    for (int index = 3; index >= 0; --index)
    {
      if (numArray[index] > 0)
        Main.LocalPlayer.QuickSpawnItem(Main.LocalPlayer.GetItemSource_InventoryOverflow(), 71 + index, numArray[index]);
    }
  }

  private static void RefillItemStack(
    Item[] inv,
    Item itemToRefill,
    int loopStartIndex,
    int loopEndIndex)
  {
    int num1 = itemToRefill.maxStack - itemToRefill.stack;
    if (num1 <= 0)
      return;
    for (int index = loopStartIndex; index < loopEndIndex; ++index)
    {
      Item obj = inv[index];
      if (obj.stack >= 1 && obj.type == itemToRefill.type && !obj.favorited)
      {
        int num2 = obj.stack;
        if (num2 > num1)
          num2 = num1;
        num1 -= num2;
        itemToRefill.stack += num2;
        obj.stack -= num2;
        if (obj.stack <= 0)
          obj.TurnToAir();
        if (num1 <= 0)
          break;
      }
    }
  }

  private static void TrySlidingUp(Item[] inv, int slot, int minimumIndex)
  {
    for (int index = minimumIndex; index < slot; ++index)
    {
      if (inv[index].IsAir)
      {
        Utils.Swap<Item>(ref inv[index], ref inv[slot]);
        break;
      }
    }
  }

  private class ItemSortingLayer
  {
    public readonly string Name;
    public readonly Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

    public ItemSortingLayer(
      string name,
      Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> method)
    {
      this.Name = name;
      this.SortingMethod = method;
    }

    public void Validate(ref List<int> indexesSortable, Item[] inv)
    {
      List<int> list;
      if (!ItemSorting._layerWhiteLists.TryGetValue(this.Name, out list))
        return;
      indexesSortable = indexesSortable.Where<int>((Func<int, bool>) (i => list.Contains(inv[i].type))).ToList<int>();
    }

    public override string ToString() => this.Name;
  }

  private class ItemSortingLayers
  {
    public static ItemSorting.ItemSortingLayer WeaponsMelee = new ItemSorting.ItemSortingLayer("Weapons - Melee", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].damage > 0 && !inv[i].consumable && inv[i].ammo == 0 && inv[i].melee && inv[i].pick < 1 && inv[i].hammer < 1 && inv[i].axe < 1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer WeaponsRanged = new ItemSorting.ItemSortingLayer("Weapons - Ranged", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i =>
      {
        if (inv[i].damage > 0 && !inv[i].consumable && inv[i].ammo == 0 && inv[i].ranged)
          return true;
        return inv[i].type >= 0 && ItemID.Sets.SortingPriorityWeaponsRanged[inv[i].type] > -1;
      })).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemSorting.ItemSortingLayers.CompareWithPrioritySet(ItemID.Sets.SortingPriorityWeaponsRanged, inv[x].type, inv[y].type);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer WeaponsMagic = new ItemSorting.ItemSortingLayer("Weapons - Magic", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].damage > 0 && !inv[i].consumable && inv[i].ammo == 0 && inv[i].magic)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer WeaponsMinions = new ItemSorting.ItemSortingLayer("Weapons - Minions", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].damage > 0 && !inv[i].consumable && inv[i].summon)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer WeaponsAssorted = new ItemSorting.ItemSortingLayer("Weapons - Assorted", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].damage > 0 && inv[i].ammo == 0 && inv[i].pick == 0 && inv[i].axe == 0 && inv[i].hammer == 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer WeaponsAmmo = new ItemSorting.ItemSortingLayer("Weapons - Ammo", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].ammo > 0 && inv[i].damage > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsPicksaws = new ItemSorting.ItemSortingLayer("Tools - Picksaws", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].pick > 0 && inv[i].axe > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[x].pick.CompareTo(inv[y].pick)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsHamaxes = new ItemSorting.ItemSortingLayer("Tools - Hamaxes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].hammer > 0 && inv[i].axe > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[x].axe.CompareTo(inv[y].axe)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsPickaxes = new ItemSorting.ItemSortingLayer("Tools - Pickaxes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].pick > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[x].pick.CompareTo(inv[y].pick)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsAxes = new ItemSorting.ItemSortingLayer("Tools - Axes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].axe > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[x].axe.CompareTo(inv[y].axe)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsHammers = new ItemSorting.ItemSortingLayer("Tools - Hammers", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].hammer > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[x].hammer.CompareTo(inv[y].hammer)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsTerraforming = new ItemSorting.ItemSortingLayer("Tools - Terraforming", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityTerraforming[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityTerraforming[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityTerraforming[inv[y].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsFishing = new ItemSorting.ItemSortingLayer("Tools - Fishing", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i =>
      {
        if (inv[i].fishingPole > 0 || inv[i].bait > 0 || inv[i].questItem)
          return true;
        if (inv[i].type <= 0)
          return false;
        return ItemID.Sets.IsFishingCrate[inv[i].type] || ItemID.Sets.IsBasicFish[inv[i].type] || ItemID.Sets.SortingPriorityToolsFishing[inv[i].type] > -1;
      })).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemSorting.ItemSortingLayers.CompareWithPrioritySet(ItemID.Sets.SortingPriorityToolsFishing, inv[x].type, inv[y].type);
        if (num == 0)
          num = inv[y].fishingPole.CompareTo(inv[x].fishingPole);
        if (num == 0)
          num = inv[y].bait.CompareTo(inv[x].bait);
        if (num == 0)
          num = inv[y].questItem.CompareTo(inv[x].questItem);
        if (num == 0 && inv[y].type >= 0 && inv[x].type >= 0)
        {
          if (num == 0)
            num = ItemID.Sets.IsFishingCrate[inv[y].type].CompareTo(ItemID.Sets.IsFishingCrate[inv[x].type]);
          if (num == 0)
            num = ItemID.Sets.IsBasicFish[inv[y].type].CompareTo(ItemID.Sets.IsBasicFish[inv[x].type]);
        }
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsGolf = new ItemSorting.ItemSortingLayer("Tools - Golf", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityToolsGolf[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityToolsGolf[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityToolsGolf[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsInstruments = new ItemSorting.ItemSortingLayer("Tools - Instruments", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityToolsInstruments[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityToolsInstruments[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityToolsInstruments[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsKeys = new ItemSorting.ItemSortingLayer("Tools - Keys", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityToolsKeys[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityToolsKeys[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityToolsKeys[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsKites = new ItemSorting.ItemSortingLayer("Tools - Kites", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityToolsKites[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityToolsKites[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityToolsKites[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsAmmoLeftovers = new ItemSorting.ItemSortingLayer("Weapons - Ammo Leftovers", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].ammo > 0 && inv[i].type >= 0 && inv[i].type < (int) ItemID.Count && !ItemID.Sets.IsFood[inv[i].type] && ItemID.Sets.SortingPriorityMiscAcorns[inv[i].type] == -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDamage.CompareTo(inv[x].OriginalDamage);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ToolsMisc = new ItemSorting.ItemSortingLayer("Tools - Misc", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityToolsMisc[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityToolsMisc[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityToolsMisc[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ArmorCombat = new ItemSorting.ItemSortingLayer("Armor - Combat", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => (inv[i].bodySlot >= 0 || inv[i].headSlot >= 0 || inv[i].legSlot >= 0) && !inv[i].vanity)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDefense.CompareTo(inv[x].OriginalDefense);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ArmorVanity = new ItemSorting.ItemSortingLayer("Armor - Vanity", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => (inv[i].bodySlot >= 0 || inv[i].headSlot >= 0 || inv[i].legSlot >= 0) && inv[i].vanity)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer ArmorAccessories = new ItemSorting.ItemSortingLayer("Armor - Accessories", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].accessory)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[x].vanity.CompareTo(inv[y].vanity);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].OriginalDefense.CompareTo(inv[x].OriginalDefense);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer EquipGrapple = new ItemSorting.ItemSortingLayer("Equip - Grapple", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => Main.projHook[inv[i].shoot])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer EquipMount = new ItemSorting.ItemSortingLayer("Equip - Mount", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].mountType != -1 && !MountID.Sets.Cart[inv[i].mountType])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer EquipCart = new ItemSorting.ItemSortingLayer("Equip - Cart", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].mountType != -1 && MountID.Sets.Cart[inv[i].mountType])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer EquipLightPet = new ItemSorting.ItemSortingLayer("Equip - Light Pet", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].buffType > 0 && Main.lightPet[inv[i].buffType])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer EquipVanityPet = new ItemSorting.ItemSortingLayer("Equip - Vanity Pet", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].buffType > 0 && Main.vanityPet[inv[i].buffType])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsLife = new ItemSorting.ItemSortingLayer("Potions - Life", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].consumable && inv[i].healLife > 0 && inv[i].healMana < 1 && inv[i].type != 5)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].healLife.CompareTo(inv[x].healLife);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsJustTheMushroom = new ItemSorting.ItemSortingLayer("Potions - Just The Mushroom", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type == 5)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[y].stack.CompareTo(inv[x].stack)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsMana = new ItemSorting.ItemSortingLayer("Potions - Mana", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].consumable && inv[i].healLife < 1 && inv[i].healMana > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].healMana.CompareTo(inv[x].healMana);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsElixirs = new ItemSorting.ItemSortingLayer("Potions - Elixirs", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].consumable && inv[i].healLife > 0 && inv[i].healMana > 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].healLife.CompareTo(inv[x].healLife);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsBuffs = new ItemSorting.ItemSortingLayer("Potions - Buffs", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i =>
      {
        if (inv[i].consumable && inv[i].buffType > 0 && inv[i].type >= 0 && inv[i].type < (int) ItemID.Count && !ItemID.Sets.IsFood[inv[i].type])
          return true;
        return inv[i].type >= 0 && ItemID.Sets.SortingPriorityPotionsBuffs[inv[i].type] > -1;
      })).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemSorting.ItemSortingLayers.CompareWithPrioritySet(ItemID.Sets.SortingPriorityPotionsBuffs, inv[x].type, inv[y].type);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsFood = new ItemSorting.ItemSortingLayer("Potions - Food", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].consumable && inv[i].buffType > 0 && inv[i].type >= 0 && inv[i].type < (int) ItemID.Count && ItemID.Sets.IsFood[inv[i].type])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].buffType < 0 || inv[y].buffType >= BuffID.Count ? 0 : BuffID.Sets.SortingPriorityFoodBuffs[inv[y].buffType].CompareTo(BuffID.Sets.SortingPriorityFoodBuffs[inv[x].buffType]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[x].type.CompareTo(inv[y].type);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsDyes = new ItemSorting.ItemSortingLayer("Potions - Dyes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i =>
      {
        if (inv[i].dye > (byte) 0)
          return true;
        return inv[i].type >= 0 && ItemID.Sets.SortingPriorityPotionsDyeMaterial[inv[i].type] > -1;
      })).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].dye.CompareTo(inv[x].dye);
        if (num == 0)
          num = ItemSorting.ItemSortingLayers.CompareWithPrioritySet(ItemID.Sets.SortingPriorityPotionsDyeMaterial, inv[x].type, inv[y].type);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer PotionsHairDyes = new ItemSorting.ItemSortingLayer("Potions - Hair Dyes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].hairDye >= (short) 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].hairDye.CompareTo(inv[x].hairDye);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscValuables = new ItemSorting.ItemSortingLayer("Misc - Importants", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMiscImportants[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMiscImportants[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityMiscImportants[inv[y].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscWiring = new ItemSorting.ItemSortingLayer("Misc - Wiring", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityWiring[inv[i].type] > -1 || inv[i].mech)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityWiring[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityWiring[inv[x].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].type.CompareTo(inv[x].type);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscMaterials = new ItemSorting.ItemSortingLayer("Misc - Materials", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMaterials[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMaterials[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityMaterials[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscJustTheGlowingMushroom = new ItemSorting.ItemSortingLayer("Misc - Just The Glowing Mushroom", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type == 183)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) => inv[y].stack.CompareTo(inv[x].stack)));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscExtractinator = new ItemSorting.ItemSortingLayer("Misc - Extractinator", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityExtractibles[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityExtractibles[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityExtractibles[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscPainting = new ItemSorting.ItemSortingLayer("Misc - Painting", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityPainting[inv[i].type] > -1 || inv[i].paint > (byte) 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityPainting[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityPainting[inv[x].type]);
        if (num == 0)
          num = inv[x].paint.CompareTo(inv[y].paint);
        if (num == 0)
          num = inv[x].paintCoating.CompareTo(inv[y].paintCoating);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscRopes = new ItemSorting.ItemSortingLayer("Misc - Ropes", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityRopes[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityRopes[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityRopes[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscHerbsAndSeeds = new ItemSorting.ItemSortingLayer("Misc - Herbs And Seeds", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMiscHerbsAndSeeds[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMiscHerbsAndSeeds[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityMiscHerbsAndSeeds[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscGems = new ItemSorting.ItemSortingLayer("Misc - Gems", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMiscGems[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMiscGems[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityMiscGems[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscAcorns = new ItemSorting.ItemSortingLayer("Misc - Acorns", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMiscAcorns[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMiscAcorns[inv[y].type].CompareTo(ItemID.Sets.SortingPriorityMiscAcorns[inv[x].type]);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscBossBags = new ItemSorting.ItemSortingLayer("Misc - Boss Bags", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].type > 0 && ItemID.Sets.SortingPriorityMiscBossBags[inv[i].type] > -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = ItemID.Sets.SortingPriorityMiscBossBags[inv[x].type].CompareTo(ItemID.Sets.SortingPriorityMiscBossBags[inv[y].type]);
        if (num == 0)
          num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer MiscCritters = new ItemSorting.ItemSortingLayer("Misc - Critters", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].makeNPC > (short) 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[x].makeNPC.CompareTo(inv[y].makeNPC);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer LastMaterials = new ItemSorting.ItemSortingLayer("Last - Materials", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].createTile < 0 && inv[i].createWall < 1 && inv[i].rare != -1)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = inv[y].value.CompareTo(inv[x].value);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer LastTilesImportant = new ItemSorting.ItemSortingLayer("Last - Tiles (Frame Important)", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].createTile >= 0 && Main.tileFrameImportant[inv[i].createTile])).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = string.Compare(inv[x].Name, inv[y].Name, StringComparison.OrdinalIgnoreCase);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer LastTilesCommon = new ItemSorting.ItemSortingLayer("Last - Tiles (Common), Walls", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].createWall > 0 || inv[i].createTile >= 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = string.Compare(inv[x].Name, inv[y].Name, StringComparison.OrdinalIgnoreCase);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer LastNotTrash = new ItemSorting.ItemSortingLayer("Last - Not Trash", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> list = itemsToSort.Where<int>((Func<int, bool>) (i => inv[i].OriginalRarity >= 0)).ToList<int>();
      layer.Validate(ref list, inv);
      foreach (int num in list)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(list, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].OriginalRarity.CompareTo(inv[x].OriginalRarity);
        if (num == 0)
          num = string.Compare(inv[x].Name, inv[y].Name, StringComparison.OrdinalIgnoreCase);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return list;
    }));
    public static ItemSorting.ItemSortingLayer LastTrash = new ItemSorting.ItemSortingLayer("Last - Trash", (Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>>) ((layer, inv, itemsToSort) =>
    {
      List<int> indexesSortable = new List<int>((IEnumerable<int>) itemsToSort);
      layer.Validate(ref indexesSortable, inv);
      foreach (int num in indexesSortable)
        itemsToSort.Remove(num);
      ItemSorting.ItemSortingLayers.SortIndicesStable(indexesSortable, (Comparison<int>) ((x, y) =>
      {
        int num = inv[y].value.CompareTo(inv[x].value);
        if (num == 0)
          num = inv[y].stack.CompareTo(inv[x].stack);
        return num;
      }));
      return indexesSortable;
    }));

    private static void SortIndicesStable(List<int> list, Comparison<int> comparison)
    {
      list.Sort((Comparison<int>) ((x, y) =>
      {
        int num = comparison(x, y);
        if (num == 0)
          num = x.CompareTo(y);
        return num;
      }));
    }

    public static int CompareWithPrioritySet(int[] prioritySet, int typeOne, int typeTwo)
    {
      if (typeOne < 0 || typeTwo < 0)
        return 0;
      if (prioritySet[typeOne] >= 0 && prioritySet[typeTwo] < 0)
        return -1;
      if (prioritySet[typeOne] < 0 && prioritySet[typeTwo] >= 0)
        return 1;
      return prioritySet[typeOne] < 0 && prioritySet[typeTwo] < 0 ? 0 : prioritySet[typeOne].CompareTo(prioritySet[typeTwo]);
    }
  }

  private struct DamageTypeSortingLayerEntry(
    float multiplier,
    ItemSorting.ItemSortingLayer layer,
    int index)
  {
    public float Multiplier = multiplier;
    public ItemSorting.ItemSortingLayer Layer = layer;
    public int Index = index;
  }

  private struct MemoryStamp
  {
    public int ItemType;
    public int Stack;
    public int Prefix;

    public MemoryStamp(int itemType, int stack, int prefix)
    {
      this.ItemType = itemType;
      this.Stack = stack;
      this.Prefix = prefix;
    }

    public MemoryStamp(Item item)
    {
      this.ItemType = item.type;
      this.Stack = item.stack;
      this.Prefix = (int) item.prefix;
    }

    public override bool Equals(object obj)
    {
      return obj != null && obj is ItemSorting.MemoryStamp other && this.Equals(other);
    }

    public bool Equals(ItemSorting.MemoryStamp other)
    {
      return this.ItemType == other.ItemType && this.Stack == other.Stack && this.Prefix == other.Prefix;
    }

    public override int GetHashCode() => (this.ItemType * 397 ^ this.Stack) * 397 ^ this.Prefix;

    public static bool operator ==(ItemSorting.MemoryStamp left, ItemSorting.MemoryStamp right)
    {
      return left.Equals(right);
    }

    public static bool operator !=(ItemSorting.MemoryStamp left, ItemSorting.MemoryStamp right)
    {
      return !left.Equals(right);
    }
  }
}
