// Decompiled with JetBrains decompiler
// Type: Terraria.ID.PlayerItemSlotID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.ID;

public static class PlayerItemSlotID
{
  public static readonly int Inventory0;
  public static readonly int InventoryMouseItem;
  public static readonly int Armor0;
  public static readonly int Dye0;
  public static readonly int Misc0;
  public static readonly int MiscDye0;
  public static readonly int Bank1_0;
  public static readonly int Bank2_0;
  public static readonly int TrashItem;
  public static readonly int Bank3_0;
  public static readonly int Bank4_0;
  public static readonly int Loadout1_Armor_0;
  public static readonly int Loadout1_Dye_0;
  public static readonly int Loadout2_Armor_0;
  public static readonly int Loadout2_Dye_0;
  public static readonly int Loadout3_Armor_0;
  public static readonly int Loadout3_Dye_0;
  public static readonly int Count;
  public static bool[] CanRelay = new bool[0];
  private static int _nextSlotId;

  static PlayerItemSlotID()
  {
    PlayerItemSlotID.Inventory0 = PlayerItemSlotID.AllocateSlots(58, true);
    PlayerItemSlotID.InventoryMouseItem = PlayerItemSlotID.AllocateSlots(1, true);
    PlayerItemSlotID.Armor0 = PlayerItemSlotID.AllocateSlots(20, true);
    PlayerItemSlotID.Dye0 = PlayerItemSlotID.AllocateSlots(10, true);
    PlayerItemSlotID.Misc0 = PlayerItemSlotID.AllocateSlots(5, true);
    PlayerItemSlotID.MiscDye0 = PlayerItemSlotID.AllocateSlots(5, true);
    PlayerItemSlotID.Bank1_0 = PlayerItemSlotID.AllocateSlots(200, false);
    PlayerItemSlotID.Bank2_0 = PlayerItemSlotID.AllocateSlots(200, false);
    PlayerItemSlotID.TrashItem = PlayerItemSlotID.AllocateSlots(1, false);
    PlayerItemSlotID.Bank3_0 = PlayerItemSlotID.AllocateSlots(200, false);
    PlayerItemSlotID.Bank4_0 = PlayerItemSlotID.AllocateSlots(200, true);
    PlayerItemSlotID.Loadout1_Armor_0 = PlayerItemSlotID.AllocateSlots(20, true);
    PlayerItemSlotID.Loadout1_Dye_0 = PlayerItemSlotID.AllocateSlots(10, true);
    PlayerItemSlotID.Loadout2_Armor_0 = PlayerItemSlotID.AllocateSlots(20, true);
    PlayerItemSlotID.Loadout2_Dye_0 = PlayerItemSlotID.AllocateSlots(10, true);
    PlayerItemSlotID.Loadout3_Armor_0 = PlayerItemSlotID.AllocateSlots(20, true);
    PlayerItemSlotID.Loadout3_Dye_0 = PlayerItemSlotID.AllocateSlots(10, true);
    PlayerItemSlotID.Count = PlayerItemSlotID._nextSlotId;
  }

  private static int AllocateSlots(int amount, bool canNetRelay)
  {
    int nextSlotId = PlayerItemSlotID._nextSlotId;
    PlayerItemSlotID._nextSlotId += amount;
    int length = PlayerItemSlotID.CanRelay.Length;
    Array.Resize<bool>(ref PlayerItemSlotID.CanRelay, length + amount);
    for (int index = length; index < PlayerItemSlotID._nextSlotId; ++index)
      PlayerItemSlotID.CanRelay[index] = canNetRelay;
    return nextSlotId;
  }

  public struct SlotReference(Player player, int slot)
  {
    public readonly Player Player = player;
    public readonly int SlotId = slot;

    public Item Item
    {
      get
      {
        if (this.SlotId == PlayerItemSlotID.TrashItem)
          return this.Player.trashItem;
        Item[] arr;
        int slot;
        if (!this.TryGetArraySlot(out arr, out slot))
          throw new IndexOutOfRangeException("SlotId: " + (object) this.SlotId);
        return arr[slot];
      }
      set
      {
        if (this.SlotId == PlayerItemSlotID.TrashItem)
        {
          this.Player.trashItem = value;
        }
        else
        {
          Item[] arr;
          int slot;
          if (!this.TryGetArraySlot(out arr, out slot))
            throw new IndexOutOfRangeException("SlotId: " + (object) this.SlotId);
          arr[slot] = value;
        }
      }
    }

    private bool TryGetArraySlot(out Item[] arr, out int slot)
    {
      if (this.SlotId >= PlayerItemSlotID.Loadout3_Dye_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout3_Dye_0;
        arr = this.Player.Loadouts[2].Dye;
      }
      else if (this.SlotId >= PlayerItemSlotID.Loadout3_Armor_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout3_Armor_0;
        arr = this.Player.Loadouts[2].Armor;
      }
      else if (this.SlotId >= PlayerItemSlotID.Loadout2_Dye_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout2_Dye_0;
        arr = this.Player.Loadouts[1].Dye;
      }
      else if (this.SlotId >= PlayerItemSlotID.Loadout2_Armor_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout2_Armor_0;
        arr = this.Player.Loadouts[1].Armor;
      }
      else if (this.SlotId >= PlayerItemSlotID.Loadout1_Dye_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout1_Dye_0;
        arr = this.Player.Loadouts[0].Dye;
      }
      else if (this.SlotId >= PlayerItemSlotID.Loadout1_Armor_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Loadout1_Armor_0;
        arr = this.Player.Loadouts[0].Armor;
      }
      else if (this.SlotId >= PlayerItemSlotID.Bank4_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Bank4_0;
        arr = this.Player.bank4.item;
      }
      else if (this.SlotId >= PlayerItemSlotID.Bank3_0)
      {
        slot = this.SlotId - PlayerItemSlotID.Bank3_0;
        arr = this.Player.bank3.item;
      }
      else
      {
        if (this.SlotId >= PlayerItemSlotID.TrashItem)
        {
          slot = 0;
          arr = (Item[]) null;
          return false;
        }
        if (this.SlotId >= PlayerItemSlotID.Bank2_0)
        {
          slot = this.SlotId - PlayerItemSlotID.Bank2_0;
          arr = this.Player.bank2.item;
        }
        else if (this.SlotId >= PlayerItemSlotID.Bank1_0)
        {
          slot = this.SlotId - PlayerItemSlotID.Bank1_0;
          arr = this.Player.bank.item;
        }
        else if (this.SlotId >= PlayerItemSlotID.MiscDye0)
        {
          slot = this.SlotId - PlayerItemSlotID.MiscDye0;
          arr = this.Player.miscDyes;
        }
        else if (this.SlotId >= PlayerItemSlotID.Misc0)
        {
          slot = this.SlotId - PlayerItemSlotID.Misc0;
          arr = this.Player.miscEquips;
        }
        else if (this.SlotId >= PlayerItemSlotID.Dye0)
        {
          slot = this.SlotId - PlayerItemSlotID.Dye0;
          arr = this.Player.dye;
        }
        else if (this.SlotId >= PlayerItemSlotID.Armor0)
        {
          slot = this.SlotId - PlayerItemSlotID.Armor0;
          arr = this.Player.armor;
        }
        else
        {
          slot = this.SlotId - PlayerItemSlotID.Inventory0;
          arr = this.Player.inventory;
        }
      }
      return true;
    }
  }
}
