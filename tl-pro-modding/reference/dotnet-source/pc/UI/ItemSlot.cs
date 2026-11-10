// Decompiled with JetBrains decompiler
// Type: Terraria.UI.ItemSlot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameInput;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.UI;

public class ItemSlot
{
  private static Dictionary<ItemSlot.ItemDisplayKey, ulong> _nextTickDrawAvailable = new Dictionary<ItemSlot.ItemDisplayKey, ulong>();
  public static bool DrawGoldBGForCraftingMaterial = false;
  public static bool DrawSelectionHighlightForGridSlot = false;
  public static bool ShiftForcedOn;
  private static Item[] singleSlotArray = new Item[1];
  private static bool[] canFavoriteAt = new bool[ItemSlot.Context.Count];
  private static bool[] canShareAt = new bool[ItemSlot.Context.Count];
  private static bool[] canQuickDropAt = new bool[ItemSlot.Context.Count];
  private static float[] inventoryGlowHue = new float[58];
  private static int[] inventoryGlowTime = new int[58];
  private static float[] inventoryGlowHueChest = new float[58];
  private static int[] inventoryGlowTimeChest = new int[58];
  private static ItemSlot.PulseEffect[] playerSlotPulseEffects = new ItemSlot.PulseEffect[PlayerItemSlotID.Count];
  private static int _customCurrencyForSavings = -1;
  public static bool forceClearGlowsOnChest = false;
  private static double _lastTimeForVisualEffectsThatLoadoutWasChanged;
  private static Color[,] LoadoutSlotColors = new Color[3, 3]
  {
    {
      new Color(50, 106, 64 /*0x40*/),
      new Color(46, 106, 98),
      new Color(45, 85, 105)
    },
    {
      new Color(35, 106, 126),
      new Color(50, 89, 140),
      new Color(57, 70, 128 /*0x80*/)
    },
    {
      new Color(122, 63 /*0x3F*/, 83),
      new Color(104, 46, 85),
      new Color(84, 37, 87)
    }
  };
  public static float OverdrawGlowSize = 1f;
  public static Color OverdrawGlowColorMultiplier = Color.White;
  private static int dyeSwapCounter;
  private static Item[] _dirtyHack = new Item[0];
  public static float CircularRadialOpacity;
  public static float QuicksRadialOpacity;

  static ItemSlot()
  {
    ItemSlot.canFavoriteAt[0] = true;
    ItemSlot.canFavoriteAt[1] = true;
    ItemSlot.canFavoriteAt[2] = true;
    ItemSlot.canFavoriteAt[32 /*0x20*/] = true;
    ItemSlot.canShareAt[0] = true;
    ItemSlot.canShareAt[1] = true;
    ItemSlot.canShareAt[2] = true;
    ItemSlot.canShareAt[32 /*0x20*/] = true;
    ItemSlot.canShareAt[15] = true;
    ItemSlot.canShareAt[4] = true;
    ItemSlot.canShareAt[32 /*0x20*/] = true;
    ItemSlot.canShareAt[5] = true;
    ItemSlot.canShareAt[6] = true;
    ItemSlot.canShareAt[7] = true;
    ItemSlot.canShareAt[27] = true;
    ItemSlot.canShareAt[26] = true;
    ItemSlot.canShareAt[23] = true;
    ItemSlot.canShareAt[24] = true;
    ItemSlot.canShareAt[39] = true;
    ItemSlot.canShareAt[25] = true;
    ItemSlot.canShareAt[38] = true;
    ItemSlot.canShareAt[22] = true;
    ItemSlot.canShareAt[35] = true;
    ItemSlot.canShareAt[3] = true;
    ItemSlot.canShareAt[8] = true;
    ItemSlot.canShareAt[9] = true;
    ItemSlot.canShareAt[10] = true;
    ItemSlot.canShareAt[11] = true;
    ItemSlot.canShareAt[12] = true;
    ItemSlot.canShareAt[33] = true;
    ItemSlot.canShareAt[16 /*0x10*/] = true;
    ItemSlot.canShareAt[20] = true;
    ItemSlot.canShareAt[18] = true;
    ItemSlot.canShareAt[19] = true;
    ItemSlot.canShareAt[17] = true;
    ItemSlot.canShareAt[29] = true;
    ItemSlot.canShareAt[34] = true;
    ItemSlot.canShareAt[30] = true;
    ItemSlot.canShareAt[41] = true;
    ItemSlot.canShareAt[42] = true;
    ItemSlot.canShareAt[43] = true;
    ItemSlot.canQuickDropAt[0] = true;
    ItemSlot.canQuickDropAt[1] = true;
    ItemSlot.canQuickDropAt[2] = true;
    ItemSlot.canQuickDropAt[6] = true;
    ItemSlot.canQuickDropAt[15] = true;
    ItemSlot.canQuickDropAt[4] = true;
    ItemSlot.canQuickDropAt[32 /*0x20*/] = true;
    ItemSlot.canQuickDropAt[3] = true;
  }

  public static bool ShiftInUse => Main.keyState.PressingShift() || ItemSlot.ShiftForcedOn;

  public static bool ControlInUse => Main.keyState.PressingControl();

  public static event ItemSlot.ItemTransferEvent OnItemTransferred;

  public static void AnnounceTransfer(ItemSlot.ItemTransferInfo info)
  {
    if (ItemSlot.OnItemTransferred == null)
      return;
    ItemSlot.OnItemTransferred(info);
  }

  public static void PrepareForChest(Chest chest)
  {
    int maxItems = chest.maxItems;
    if (ItemSlot.inventoryGlowTimeChest.Length < maxItems)
      Array.Resize<int>(ref ItemSlot.inventoryGlowTimeChest, maxItems);
    if (ItemSlot.inventoryGlowHueChest.Length >= maxItems)
      return;
    Array.Resize<float>(ref ItemSlot.inventoryGlowHueChest, maxItems);
  }

  public static void SetGlowForChest(Chest chest)
  {
    ItemSlot.PrepareForChest(chest);
    int maxItems = chest.maxItems;
    for (int index = 0; index < maxItems; ++index)
      ItemSlot.SetGlow(index, -1f, true);
    for (int slot = 0; slot < maxItems; ++slot)
      CoinSlot.ForceSlotState(slot, 3, chest.item[slot]);
  }

  public static void SetGlow(int index, float hue, bool chest)
  {
    if (chest)
    {
      if ((double) hue < 0.0)
      {
        ItemSlot.inventoryGlowTimeChest[index] = 0;
        ItemSlot.inventoryGlowHueChest[index] = 0.0f;
      }
      else
      {
        ItemSlot.inventoryGlowTimeChest[index] = 300;
        ItemSlot.inventoryGlowHueChest[index] = hue;
      }
    }
    else
    {
      ItemSlot.inventoryGlowTime[index] = 300;
      ItemSlot.inventoryGlowHue[index] = hue;
    }
  }

  public static void UpdateInterface()
  {
    if (!Main.playerInventory || Main.player[Main.myPlayer].talkNPC == -1)
      ItemSlot._customCurrencyForSavings = -1;
    for (int index = 0; index < ItemSlot.inventoryGlowTime.Length; ++index)
    {
      if (ItemSlot.inventoryGlowTime[index] > 0)
      {
        --ItemSlot.inventoryGlowTime[index];
        if (ItemSlot.inventoryGlowTime[index] == 0)
          ItemSlot.inventoryGlowHue[index] = 0.0f;
      }
    }
    for (int index = 0; index < ItemSlot.inventoryGlowTimeChest.Length; ++index)
    {
      if (ItemSlot.inventoryGlowTimeChest[index] > 0)
      {
        --ItemSlot.inventoryGlowTimeChest[index];
        if (ItemSlot.inventoryGlowTimeChest[index] == 0 || ItemSlot.forceClearGlowsOnChest)
          ItemSlot.inventoryGlowHueChest[index] = 0.0f;
      }
    }
    ItemSlot.forceClearGlowsOnChest = false;
    for (int index = 0; index < ItemSlot.playerSlotPulseEffects.Length; ++index)
    {
      ItemSlot.PulseEffect playerSlotPulseEffect = ItemSlot.playerSlotPulseEffects[index];
      if (playerSlotPulseEffect.itemInSlot != null && (++ItemSlot.playerSlotPulseEffects[index].time >= ItemSlot.PulseEffect.EffectDuration || playerSlotPulseEffect.slotRef.Item.IsAir))
        ItemSlot.playerSlotPulseEffects[index] = new ItemSlot.PulseEffect();
    }
  }

  public static void IndicateBlockedSlot(PlayerItemSlotID.SlotReference slot)
  {
    ItemSlot.AddPulseEffect(slot, new Color(250, 40, 40, (int) byte.MaxValue));
  }

  public static void AddPulseEffect(PlayerItemSlotID.SlotReference slot, Color color)
  {
    ItemSlot.PulseEffect pulseEffect = new ItemSlot.PulseEffect(slot, color);
    if (pulseEffect.itemInSlot.IsAir)
      return;
    ItemSlot.playerSlotPulseEffects[slot.SlotId] = pulseEffect;
  }

  public static void Handle(ref Item inv, int context = 0, bool allowInteract = true)
  {
    ItemSlot.singleSlotArray[0] = inv;
    ItemSlot.Handle(ItemSlot.singleSlotArray, context, allowInteract: allowInteract);
    inv = ItemSlot.singleSlotArray[0];
  }

  public static bool HoverOverrideClick(Item inv, int context = 0)
  {
    ItemSlot.singleSlotArray[0] = inv;
    ItemSlot.OverrideHover(ItemSlot.singleSlotArray, context);
    if (Main.cursorOverride < 0 || !Main.mouseLeftRelease || !Main.mouseLeft)
      return false;
    ItemSlot.OverrideLeftClick(ItemSlot.singleSlotArray, context);
    return true;
  }

  public static void Handle(Item[] inv, int context = 0, int slot = 0, bool allowInteract = true)
  {
    ItemSlot.OverrideHover(inv, context, slot);
    if (allowInteract)
    {
      ItemSlot.LeftClick(inv, context, slot);
      ItemSlot.RightClick(inv, context, slot);
    }
    ItemSlot.MouseHover(inv, context, slot);
  }

  public static void OverrideHover(Item[] inv, int context = 0, int slot = 0)
  {
    if (!PlayerInput.UsingGamepad)
      UILinkPointNavigator.SuggestUsage(ItemSlot.GetGamepadPointForSlot(inv, context, slot));
    if (inv[slot].IsAir)
      return;
    if (Main.keyState.IsKeyDown(Main.FavoriteKey))
    {
      if (Main.drawingPlayerChat && ItemSlot.canShareAt[context])
      {
        Main.cursorOverride = 2;
        return;
      }
      if (ItemSlot.canFavoriteAt[context])
      {
        Main.cursorOverride = 3;
        return;
      }
    }
    ItemSlot.AlternateClickAction? alternateClickAction = ItemSlot.GetAlternateClickAction(inv, context, slot);
    if (!alternateClickAction.HasValue)
      return;
    Main.cursorOverride = alternateClickAction.Value.cursorOverride;
  }

  public static ItemSlot.AlternateClickAction? GetAlternateClickAction(
    Item[] inv,
    int context,
    int slot)
  {
    Item newItem = inv[slot];
    if (newItem.IsAir || newItem.favorited)
      return new ItemSlot.AlternateClickAction?();
    bool flag = ItemSlot.Options.DisableLeftShiftTrashCan && !PlayerInput.UsingGamepad;
    if (((!ItemSlot.ControlInUse ? 0 : (!ItemSlot.Options.DisableQuickTrash ? 1 : 0)) & (flag ? 1 : 0)) != 0)
    {
      switch (context)
      {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        case 7:
        case 32 /*0x20*/:
          return ItemSlot.AlternateClickAction.GetSellOrTrash(newItem);
      }
    }
    else if (ItemSlot.ShiftInUse)
    {
      if (Main.LocalPlayer.tileEntityAnchor.IsInValidUseTileEntity())
      {
        ItemSlot.AlternateClickAction? shiftClickAction = Main.LocalPlayer.tileEntityAnchor.GetTileEntity().GetShiftClickAction(inv, context, slot);
        if (shiftClickAction.HasValue)
          return shiftClickAction;
      }
      switch (context)
      {
        case 0:
        case 1:
        case 2:
          if (Main.CreativeMenu.IsShowingResearchMenu())
          {
            if (context == 0)
              return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToChest);
            break;
          }
          if (Main.InReforgeMenu)
          {
            if (context == 0 && newItem.CanHavePrefixes())
              return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToChest);
            break;
          }
          if (Main.InGuideCraftMenu)
          {
            if (context == 0 && newItem.material)
              return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToChest);
            break;
          }
          if (Main.player[Main.myPlayer].chest != -1)
          {
            if (ChestUI.TryPlacingInChest(inv, slot, true, context))
              return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToChest);
            break;
          }
          if (!ItemSlot.Options.DisableQuickTrash && !flag)
            return ItemSlot.AlternateClickAction.GetSellOrTrash(newItem);
          break;
        case 3:
        case 4:
        case 32 /*0x20*/:
          if (Main.player[Main.myPlayer].ItemSpace(newItem).CanTakeItemToPersonalInventory)
            return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferFromChest);
          break;
        case 5:
        case 6:
        case 7:
        case 29:
          if (Main.player[Main.myPlayer].ItemSpace(inv[slot]).CanTakeItemToPersonalInventory)
            return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToBackpack);
          break;
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 16 /*0x10*/:
        case 17:
        case 18:
        case 19:
        case 20:
        case 33:
          if (Main.player[Main.myPlayer].ItemSpace(inv[slot]).CanTakeItemToPersonalInventory)
            return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.Unequip);
          break;
      }
    }
    return new ItemSlot.AlternateClickAction?();
  }

  private static bool OverrideLeftClick(Item[] inv, int context = 0, int slot = 0)
  {
    if (Main.LocalPlayer.tileEntityAnchor.IsInValidUseTileEntity() && ItemSlot.ShiftInUse && Main.LocalPlayer.tileEntityAnchor.GetTileEntity().PerformShiftClickAction(inv, context, slot))
      return true;
    Item obj1 = inv[slot];
    switch (Main.cursorOverride)
    {
      case 2:
        if (ChatManager.AddChatText(FontAssets.MouseText.Value, ItemTagHandler.GenerateTag(obj1), Vector2.One))
          SoundEngine.PlaySound(12);
        return true;
      case 3:
        if (!ItemSlot.canFavoriteAt[context])
          return false;
        obj1.favorited = !obj1.favorited;
        SoundEngine.PlaySound(12);
        return true;
      case 6:
        Item obj2 = obj1.DeepClone();
        if (!(ItemSlot.TryResearchingItem(ref obj2, true) | ItemSlot.TryResearchingItem(ref Main.LocalPlayer.trashItem)))
          SoundEngine.PlaySound(SoundID.TrashItem);
        SoundEngine.PlaySound(7);
        Main.LocalPlayer.trashItem = obj1.Clone();
        ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(Main.LocalPlayer.trashItem, context, 6));
        obj1.TurnToAir();
        if (context == 3 && Main.netMode == 1)
          NetMessage.SendData(32 /*0x20*/, number: Main.LocalPlayer.chest, number2: (float) slot);
        CoinSlot.ForceSlotState(slot, context, inv[slot]);
        return true;
      case 7:
        if (context == 29)
        {
          Item newItem = new Item();
          newItem.SetDefaults(inv[slot].type);
          newItem.stack = newItem.OnlyNeedOneInInventory() ? 1 : newItem.maxStack;
          newItem.OnCreated((ItemCreationContext) new JourneyDuplicationItemCreationContext());
          Player.GetItemLogger.Start();
          Main.LocalPlayer.GetItem(newItem, GetItemSettings.QuickTransferFromSlot);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(inv, context, slot);
          SoundEngine.PlaySound(12);
          return true;
        }
        Player.GetItemLogger.Start();
        inv[slot] = Main.LocalPlayer.GetItem(inv[slot], GetItemSettings.QuickTransferFromSlot);
        Player.GetItemLogger.Stop();
        ItemSlot.DisplayTransfer_GetItem(inv, context, slot);
        CoinSlot.ForceSlotState(slot, context, inv[slot]);
        SoundEngine.PlaySound(12);
        return true;
      case 8:
        Player.GetItemLogger.Start();
        inv[slot] = Main.LocalPlayer.GetItem(inv[slot], GetItemSettings.QuickTransferFromSlot);
        Player.GetItemLogger.Stop();
        ItemSlot.DisplayTransfer_GetItem(inv, context, slot);
        if (Main.player[Main.myPlayer].chest > -1)
          NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) slot);
        CoinSlot.ForceSlotState(slot, context, inv[slot]);
        return true;
      case 9:
        if (Main.CreativeMenu.IsShowingResearchMenu())
        {
          Main.CreativeMenu.SwapItem(ref inv[slot]);
          SoundEngine.PlaySound(7);
          Main.CreativeMenu.SacrificeItemInSacrificeSlot();
        }
        else if (Main.InReforgeMenu)
        {
          if (obj1.stack <= 1)
          {
            Utils.Swap<Item>(ref inv[slot], ref Main.reforgeItem);
            ItemSlot.DisplayTransfer_TwoWay(inv, slot, context, Main.reforgeItem, 5);
            SoundEngine.PlaySound(7);
          }
          else if (Main.reforgeItem.IsAir)
          {
            Main.reforgeItem = obj1.Clone();
            Main.reforgeItem.stack = 1;
            --obj1.stack;
            ItemSlot.DisplayTransfer_TwoWay(inv, slot, context, Main.reforgeItem, 5);
            SoundEngine.PlaySound(7);
          }
        }
        else if (Main.InGuideCraftMenu)
        {
          Utils.Swap<Item>(ref inv[slot], ref Main.guideItem);
          ItemSlot.DisplayTransfer_TwoWay(inv, slot, context, Main.guideItem, 7);
          SoundEngine.PlaySound(7);
        }
        else
          ChestUI.TryPlacingInChest(inv, slot, false, context);
        return true;
      case 10:
        Chest chest = Main.instance.shop[Main.npcShop];
        if (Main.LocalPlayer.SellItem(obj1))
        {
          chest.AddItemToShop(obj1);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(obj1, context, 15));
          obj1.TurnToAir();
          SoundEngine.PlaySound(18);
        }
        else if (obj1.value == 0)
        {
          chest.AddItemToShop(obj1);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(obj1, context, 15));
          obj1.TurnToAir();
          SoundEngine.PlaySound(7);
        }
        return true;
      default:
        return false;
    }
  }

  public static void LeftClick(Item[] inv, int context = 0, int slot = 0)
  {
    if (Main.LocalPlayerHasPendingInventoryActions())
      return;
    Player player = Main.player[Main.myPlayer];
    inv[slot].newAndShiny = false;
    bool flag1 = Main.mouseLeftRelease && Main.mouseLeft;
    if (flag1 && (ItemSlot.OverrideLeftClick(inv, context, slot) || player.itemAnimation != 0 || player.itemTime != 0))
      return;
    int num = ItemSlot.PickItemMovementAction(inv, context, slot, Main.mouseItem);
    if (num != 3 && !flag1)
      return;
    switch (num)
    {
      case 0:
        bool flag2 = false;
        if (context == 6 && Main.mouseItem.type != 0)
        {
          Item obj = Main.mouseItem.DeepClone();
          if (ItemSlot.TryResearchingItem(ref obj, true) | ItemSlot.TryResearchingItem(inv, slot))
            flag2 = true;
          inv[slot].SetDefaults(0);
        }
        Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
        if (inv[slot].stack > 0)
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 21, context, inv[slot].stack));
        else
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(Main.mouseItem, context, 21, Main.mouseItem.stack));
        if (inv[slot].stack > 0)
        {
          switch (context)
          {
            case 0:
              AchievementsHelper.NotifyItemPickup(player, inv[slot]);
              break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 16 /*0x10*/:
            case 17:
            case 25:
            case 27:
            case 33:
              AchievementsHelper.HandleOnEquip(player, inv[slot], context);
              break;
          }
        }
        if (inv[slot].type == 0 || inv[slot].stack < 1)
          inv[slot] = new Item();
        if (Item.CanStack(Main.mouseItem, inv[slot]))
        {
          Utils.Swap<bool>(ref inv[slot].favorited, ref Main.mouseItem.favorited);
          if (inv[slot].stack != inv[slot].maxStack && Main.mouseItem.stack != Main.mouseItem.maxStack)
          {
            if (Main.mouseItem.stack + inv[slot].stack <= Main.mouseItem.maxStack)
            {
              inv[slot].stack += Main.mouseItem.stack;
              Main.mouseItem.stack = 0;
              ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 21, context, inv[slot].stack));
            }
            else
            {
              int transferAmount = Main.mouseItem.maxStack - inv[slot].stack;
              inv[slot].stack += transferAmount;
              Main.mouseItem.stack -= transferAmount;
              ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 21, context, transferAmount));
            }
          }
        }
        if (Main.mouseItem.type == 0 || Main.mouseItem.stack < 1)
          Main.mouseItem = new Item();
        if (Main.mouseItem.type > 0 || inv[slot].type > 0)
        {
          if (context == 6 && Main.mouseItem.type == 0 && !flag2)
            SoundEngine.PlaySound(SoundID.TrashItem);
          SoundEngine.PlaySound(7);
        }
        if (context == 3 && Main.netMode == 1)
          NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) slot);
        CoinSlot.ForceSlotState(slot, context, inv[slot]);
        break;
      case 1:
        if (Main.mouseItem.stack == 1 && Main.mouseItem.type > 0 && inv[slot].type > 0 && inv[slot].IsNotTheSameAs(Main.mouseItem))
        {
          Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
          SoundEngine.PlaySound(7);
          if (inv[slot].stack > 0)
          {
            if (context <= 12)
            {
              if (context != 0)
              {
                if ((uint) (context - 8) > 4U)
                  goto label_65;
              }
              else
              {
                AchievementsHelper.NotifyItemPickup(player, inv[slot]);
                goto label_65;
              }
            }
            else if ((uint) (context - 16 /*0x10*/) > 1U && context != 33)
              goto label_65;
            AchievementsHelper.HandleOnEquip(player, inv[slot], context);
          }
        }
        else if (Main.mouseItem.type == 0 && inv[slot].type > 0)
        {
          Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
          if (inv[slot].type == 0 || inv[slot].stack < 1)
            inv[slot] = new Item();
          if (Main.mouseItem.type == 0 || Main.mouseItem.stack < 1)
            Main.mouseItem = new Item();
          if (Main.mouseItem.type > 0 || inv[slot].type > 0)
            SoundEngine.PlaySound(7);
        }
        else if (Main.mouseItem.type > 0 && inv[slot].type == 0)
        {
          if (Main.mouseItem.stack == 1)
          {
            Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
            if (inv[slot].type == 0 || inv[slot].stack < 1)
              inv[slot] = new Item();
            if (Main.mouseItem.type == 0 || Main.mouseItem.stack < 1)
              Main.mouseItem = new Item();
            if (Main.mouseItem.type > 0 || inv[slot].type > 0)
              SoundEngine.PlaySound(7);
          }
          else
          {
            inv[slot] = Main.mouseItem.Clone();
            --Main.mouseItem.stack;
            inv[slot].stack = 1;
            SoundEngine.PlaySound(7);
          }
          if (inv[slot].stack > 0)
          {
            if (context <= 17)
            {
              if (context != 0)
              {
                if ((uint) (context - 8) > 4U && (uint) (context - 16 /*0x10*/) > 1U)
                  goto label_65;
              }
              else
              {
                AchievementsHelper.NotifyItemPickup(player, inv[slot]);
                goto label_65;
              }
            }
            else if (context != 25 && context != 27 && context != 33)
              goto label_65;
            AchievementsHelper.HandleOnEquip(player, inv[slot], context);
          }
        }
label_65:
        if ((context == 23 || context == 24 || context == 39) && Main.netMode == 1)
          NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot);
        if (context == 38 && Main.netMode == 1)
          NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 3f);
        if (context == 26 && Main.netMode == 1)
          NetMessage.SendData(124, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot);
        CoinSlot.ForceSlotState(slot, context, inv[slot]);
        break;
      case 2:
        if (Main.mouseItem.stack == 1 && Main.mouseItem.dye > (byte) 0 && inv[slot].type > 0 && inv[slot].type != Main.mouseItem.type)
        {
          Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
          SoundEngine.PlaySound(7);
          if (inv[slot].stack > 0)
          {
            if (context <= 17)
            {
              if (context != 0)
              {
                if ((uint) (context - 8) > 4U && (uint) (context - 16 /*0x10*/) > 1U)
                  goto label_104;
              }
              else
              {
                AchievementsHelper.NotifyItemPickup(player, inv[slot]);
                goto label_104;
              }
            }
            else if (context != 25 && context != 27 && context != 33)
              goto label_104;
            AchievementsHelper.HandleOnEquip(player, inv[slot], context);
          }
        }
        else if (Main.mouseItem.type == 0 && inv[slot].type > 0)
        {
          Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
          if (inv[slot].type == 0 || inv[slot].stack < 1)
            inv[slot] = new Item();
          if (Main.mouseItem.type == 0 || Main.mouseItem.stack < 1)
            Main.mouseItem = new Item();
          if (Main.mouseItem.type > 0 || inv[slot].type > 0)
            SoundEngine.PlaySound(7);
        }
        else if (Main.mouseItem.dye > (byte) 0 && inv[slot].type == 0)
        {
          if (Main.mouseItem.stack == 1)
          {
            Utils.Swap<Item>(ref inv[slot], ref Main.mouseItem);
            if (inv[slot].type == 0 || inv[slot].stack < 1)
              inv[slot] = new Item();
            if (Main.mouseItem.type == 0 || Main.mouseItem.stack < 1)
              Main.mouseItem = new Item();
            if (Main.mouseItem.type > 0 || inv[slot].type > 0)
              SoundEngine.PlaySound(7);
          }
          else
          {
            --Main.mouseItem.stack;
            inv[slot].SetDefaults(Main.mouseItem.type);
            SoundEngine.PlaySound(7);
          }
          if (inv[slot].stack > 0)
          {
            if (context <= 17)
            {
              if (context != 0)
              {
                if ((uint) (context - 8) > 4U && (uint) (context - 16 /*0x10*/) > 1U)
                  goto label_104;
              }
              else
              {
                AchievementsHelper.NotifyItemPickup(player, inv[slot]);
                goto label_104;
              }
            }
            else if (context != 25 && context != 27 && context != 33)
              goto label_104;
            AchievementsHelper.HandleOnEquip(player, inv[slot], context);
          }
        }
label_104:
        if (context == 25 && Main.netMode == 1)
          NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 1f);
        if (context == 27 && Main.netMode == 1)
        {
          NetMessage.SendData(124, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 1f);
          break;
        }
        break;
      case 3:
        ItemSlot.HandleShopSlot(inv, slot, false, true);
        break;
      case 4:
        Chest chest = Main.instance.shop[Main.npcShop];
        if (player.SellItem(Main.mouseItem))
        {
          chest.AddItemToShop(Main.mouseItem);
          Main.mouseItem.SetDefaults(0);
          SoundEngine.PlaySound(18);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 21, 15));
        }
        else if (Main.mouseItem.value == 0)
        {
          chest.AddItemToShop(Main.mouseItem);
          Main.mouseItem.SetDefaults(0);
          SoundEngine.PlaySound(7);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 21, 15));
        }
        Main.stackSplit = 9999;
        break;
      default:
        if (num == 5 && Main.mouseItem.IsAir)
        {
          SoundEngine.PlaySound(7);
          Main.mouseItem.SetDefaults(inv[slot].type);
          Main.mouseItem.stack = Main.mouseItem.OnlyNeedOneInInventory() ? 1 : Main.mouseItem.maxStack;
          Main.mouseItem.OnCreated((ItemCreationContext) new JourneyDuplicationItemCreationContext());
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], 29, 21));
          break;
        }
        break;
    }
    if ((uint) context <= 2U || context == 5 || context == 32 /*0x20*/)
      return;
    inv[slot].favorited = false;
  }

  private static bool TryResearchingItem(
    Item[] inv,
    int slot,
    bool onlySacrificeIfItWouldFinishResearch = false)
  {
    return ItemSlot.TryResearchingItem(ref inv[slot], onlySacrificeIfItWouldFinishResearch);
  }

  private static bool TryResearchingItem(ref Item item, bool onlySacrificeIfItWouldFinishResearch = false)
  {
    if (!Main.IsJourneyMode || item == null || item.IsAir)
      return false;
    switch (Main.CreativeMenu.SacrificeItem(ref item, out int _, false, onlySacrificeIfItWouldFinishResearch))
    {
      case CreativeUI.ItemSacrificeResult.CannotSacrifice:
        return false;
      case CreativeUI.ItemSacrificeResult.SacrificedAndDone:
        SoundEngine.PlaySound(64 /*0x40*/);
        break;
      default:
        SoundEngine.PlaySound(63 /*0x3F*/);
        break;
    }
    return true;
  }

  public static bool ShouldHighlightSlotForMouseItem(int context, int slot, Item checkItem)
  {
    bool flag = false;
    if (!checkItem.IsAir)
    {
      switch (context)
      {
        case 8:
          flag = !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 10, 3)) && Main.LocalPlayer.armor[slot].type != checkItem.type && !checkItem.vanity && (checkItem.headSlot > -1 && slot == 0 || checkItem.bodySlot > -1 && slot == 1 || checkItem.legSlot > -1 && slot == 2);
          break;
        case 9:
          flag = !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 0, 3)) && Main.LocalPlayer.armor[slot].type != checkItem.type && checkItem.vanity && (checkItem.headSlot > -1 && slot == 10 || checkItem.vanity && checkItem.bodySlot > -1 && slot == 11 || checkItem.vanity && checkItem.legSlot > -1 && slot == 12);
          break;
        case 10:
          flag = Main.LocalPlayer.armor[slot].type != checkItem.type && !checkItem.vanity && checkItem.accessory && Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) && ItemSlot.CanEquipAccessoryInSlot(checkItem, slot);
          break;
        case 11:
          flag = Main.LocalPlayer.armor[slot].type != checkItem.type && checkItem.vanity && checkItem.accessory && Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) && ItemSlot.CanEquipAccessoryInVanitySlot(checkItem, slot);
          break;
        case 12:
          flag = Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) && checkItem.dye > (byte) 0;
          break;
        case 16 /*0x10*/:
          flag = checkItem.mountType == -1 && Main.projHook[checkItem.shoot];
          break;
        case 17:
          flag = checkItem.mountType != -1 && !MountID.Sets.Cart[checkItem.mountType];
          break;
        case 18:
          flag = checkItem.mountType != -1 && MountID.Sets.Cart[checkItem.mountType];
          break;
        case 19:
          flag = checkItem.buffType > 0 && Main.vanityPet[checkItem.buffType] && !Main.lightPet[checkItem.buffType];
          break;
        case 20:
          flag = checkItem.buffType > 0 && Main.lightPet[checkItem.buffType];
          break;
        case 23:
          flag = checkItem.headSlot > -1 && slot == 0 || checkItem.bodySlot > -1 && slot == 1 || checkItem.legSlot > -1 && slot == 2;
          break;
        case 24:
          TEDisplayDoll tileEntity = Main.LocalPlayer.tileEntityAnchor.GetTileEntity() as TEDisplayDoll;
          flag = checkItem.accessory && ItemSlot.CanEquipAccessoryInSlot(checkItem, new ArraySegment<Item>(tileEntity.Equipment, 3, 5), slot);
          break;
        case 25:
        case 27:
        case 33:
          flag = checkItem.dye > (byte) 0;
          break;
        case 26:
          flag = checkItem.headSlot > -1;
          break;
        case 38:
          flag = TEDisplayDoll.AcceptedInWeaponSlot(checkItem);
          break;
        case 39:
          flag = checkItem.mountType != -1;
          break;
      }
    }
    return flag;
  }

  public static void GetDimSlotForMouseItem(
    int context,
    int slot,
    Item checkItem,
    out float itemFade)
  {
    bool flag = false;
    itemFade = 1f;
    if (!checkItem.IsAir)
    {
      switch (context)
      {
        case 8:
          flag = !ItemID.Sets.DualEquipArmor[checkItem.type] && ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 10, 3)) || (checkItem.headSlot <= -1 || slot != 0) && (checkItem.bodySlot <= -1 || slot != 1) && (checkItem.legSlot <= -1 || slot != 2);
          break;
        case 9:
          flag = !ItemID.Sets.DualEquipArmor[checkItem.type] && ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 0, 3)) || (checkItem.headSlot <= -1 || slot != 10) && (checkItem.bodySlot <= -1 || slot != 11) && (checkItem.legSlot <= -1 || slot != 12);
          break;
        case 10:
          flag = !checkItem.accessory || !Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) || !ItemSlot.CanEquipAccessoryInSlot(checkItem, slot);
          break;
        case 11:
          flag = !checkItem.accessory || !Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) || !ItemSlot.CanEquipAccessoryInVanitySlot(checkItem, slot);
          break;
        case 12:
          flag = !Main.LocalPlayer.IsItemSlotUnlockedAndUsable(slot) || checkItem.dye <= (byte) 0;
          break;
        case 16 /*0x10*/:
          flag = checkItem.mountType != -1 || !Main.projHook[checkItem.shoot];
          break;
        case 17:
          flag = checkItem.mountType == -1 || MountID.Sets.Cart[checkItem.mountType];
          break;
        case 18:
          flag = checkItem.mountType == -1 || !MountID.Sets.Cart[checkItem.mountType];
          break;
        case 19:
          flag = checkItem.buffType <= 0 || !Main.vanityPet[checkItem.buffType] || Main.lightPet[checkItem.buffType];
          break;
        case 20:
          flag = checkItem.buffType <= 0 || !Main.lightPet[checkItem.buffType];
          break;
        case 23:
          flag = (checkItem.headSlot <= -1 || slot != 0) && (checkItem.bodySlot <= -1 || slot != 1) && (checkItem.legSlot <= -1 || slot != 2);
          break;
        case 24:
          TEDisplayDoll tileEntity = Main.LocalPlayer.tileEntityAnchor.GetTileEntity() as TEDisplayDoll;
          flag = !checkItem.accessory || !ItemSlot.CanEquipAccessoryInSlot(checkItem, new ArraySegment<Item>(tileEntity.Equipment, 3, 5), slot);
          break;
        case 25:
        case 27:
        case 33:
          flag = checkItem.dye <= (byte) 0;
          break;
        case 26:
          flag = checkItem.headSlot <= -1;
          break;
        case 38:
          flag = !TEDisplayDoll.AcceptedInWeaponSlot(checkItem);
          break;
        case 39:
          flag = checkItem.mountType == -1 || MountID.Sets.Cart[checkItem.mountType];
          break;
      }
    }
    if (!flag)
      return;
    itemFade = 0.5f;
  }

  public static bool CanEquipAccessoryInSlot(Item checkItem, int slot)
  {
    return checkItem.accessory && ItemSlot.CanEquipAccessoryInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 3, 7), slot) && !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 13, 7));
  }

  public static bool CanEquipAccessoryInVanitySlot(Item checkItem, int slot)
  {
    return checkItem.accessory && ItemSlot.CanEquipAccessoryInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 13, 7), slot) && !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 3, 7));
  }

  public static int PickItemMovementAction(Item[] inv, int context, int slot, Item checkItem)
  {
    Player player = Main.player[Main.myPlayer];
    int num = -1;
    switch (context)
    {
      case 0:
        num = 0;
        break;
      case 1:
        if (checkItem.type == 0 || checkItem.type == 71 || checkItem.type == 72 || checkItem.type == 73 || checkItem.type == 74)
        {
          num = 0;
          break;
        }
        break;
      case 2:
        if (checkItem.FitsAmmoSlot())
        {
          num = 0;
          break;
        }
        break;
      case 3:
        num = 0;
        break;
      default:
        if (context == 4 || context == 32 /*0x20*/)
        {
          Item[] container = Main.LocalPlayer.GetCurrentContainer().item;
          if (!ChestUI.IsBlockedFromTransferIntoChest(checkItem, container))
          {
            num = 0;
            break;
          }
          break;
        }
        switch (context)
        {
          case 5:
            if (checkItem.CanHavePrefixes() || checkItem.type == 0)
            {
              num = 1;
              break;
            }
            break;
          case 6:
            num = 0;
            break;
          case 7:
            if (checkItem.material || checkItem.type == 0)
            {
              num = 0;
              break;
            }
            break;
          case 8:
            if ((ItemID.Sets.DualEquipArmor[checkItem.type] || !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 10, 3))) && Main.LocalPlayer.armor[slot].type != checkItem.type && (checkItem.type == 0 || checkItem.headSlot > -1 && slot == 0 || checkItem.bodySlot > -1 && slot == 1 || checkItem.legSlot > -1 && slot == 2))
            {
              num = 1;
              break;
            }
            break;
          case 9:
            if ((ItemID.Sets.DualEquipArmor[checkItem.type] || !ItemSlot.HasSameItemInSlot(checkItem, new ArraySegment<Item>(Main.LocalPlayer.armor, 0, 3))) && Main.LocalPlayer.armor[slot].type != checkItem.type && (checkItem.type == 0 || checkItem.headSlot > -1 && slot == 10 || checkItem.bodySlot > -1 && slot == 11 || checkItem.legSlot > -1 && slot == 12))
            {
              num = 1;
              break;
            }
            break;
          case 10:
            if (checkItem.type == 0 || ItemSlot.CanEquipAccessoryInSlot(checkItem, slot))
            {
              num = 1;
              break;
            }
            break;
          case 11:
            if (checkItem.type == 0 || ItemSlot.CanEquipAccessoryInVanitySlot(checkItem, slot))
            {
              num = 1;
              break;
            }
            break;
          case 23:
            if (checkItem.type == 0 || checkItem.headSlot > 0 && slot == 0 || checkItem.bodySlot > 0 && slot == 1 || checkItem.legSlot > 0 && slot == 2)
            {
              num = 1;
              break;
            }
            break;
          case 24:
            if (checkItem.type == 0 || checkItem.accessory && ItemSlot.CanEquipAccessoryInSlot(checkItem, new ArraySegment<Item>(inv, 3, 5), slot))
            {
              num = 1;
              break;
            }
            break;
          case 26:
            if (checkItem.type == 0 || checkItem.headSlot > 0)
            {
              num = 1;
              break;
            }
            break;
          default:
            if (context == 12 || context == 25 || context == 27 || context == 33)
            {
              num = 2;
              break;
            }
            switch (context)
            {
              case 15:
                if (checkItem.type == 0 && inv[slot].type > 0)
                {
                  num = 3;
                  break;
                }
                if (checkItem.type == inv[slot].type && checkItem.type > 0 && checkItem.stack < checkItem.maxStack && inv[slot].stack > 0)
                {
                  num = 3;
                  break;
                }
                if (inv[slot].type == 0 && checkItem.type > 0 && (checkItem.type < 71 || checkItem.type > 74))
                {
                  num = 4;
                  break;
                }
                break;
              case 16 /*0x10*/:
                if (checkItem.type == 0 || Main.projHook[checkItem.shoot])
                {
                  num = 1;
                  break;
                }
                break;
              case 17:
                if (checkItem.type == 0 || checkItem.mountType != -1 && !MountID.Sets.Cart[checkItem.mountType])
                {
                  num = 1;
                  break;
                }
                break;
              case 18:
                if (checkItem.type == 0 || checkItem.mountType != -1 && MountID.Sets.Cart[checkItem.mountType])
                {
                  num = 1;
                  break;
                }
                break;
              case 19:
                if (checkItem.type == 0 || checkItem.buffType > 0 && Main.vanityPet[checkItem.buffType] && !Main.lightPet[checkItem.buffType])
                {
                  num = 1;
                  break;
                }
                break;
              case 20:
                if (checkItem.type == 0 || checkItem.buffType > 0 && Main.lightPet[checkItem.buffType])
                {
                  num = 1;
                  break;
                }
                break;
              case 38:
                if (checkItem.type == 0 || TEDisplayDoll.AcceptedInWeaponSlot(checkItem))
                {
                  num = 1;
                  break;
                }
                break;
              case 39:
                if (checkItem.type == 0 || checkItem.mountType != -1)
                {
                  num = 1;
                  break;
                }
                break;
              default:
                if (context == 29 && checkItem.type == 0 && inv[slot].type > 0)
                {
                  num = 5;
                  break;
                }
                break;
            }
            break;
        }
        break;
    }
    if (context == 30)
      num = 0;
    return num;
  }

  public static void RightClick(Item[] inv, int context = 0, int slot = 0)
  {
    if (Main.LocalPlayerHasPendingInventoryActions())
      return;
    Player player = Main.player[Main.myPlayer];
    inv[slot].newAndShiny = false;
    if (player.itemAnimation > 0)
      return;
    if (context == 15)
    {
      ItemSlot.HandleShopSlot(inv, slot, true, false);
    }
    else
    {
      if (!Main.mouseRight || context == 6 || context == 34)
        return;
      if (Main.mouseItem.IsAir || !Item.CanStack(inv[slot], Main.mouseItem))
      {
        if (!PlayerInput.UsingGamepadUI && context == 0 && ItemID.Sets.OpenableBag[inv[slot].type])
        {
          if (!Main.mouseRightRelease)
            return;
          ItemSlot.TryOpenContainer(inv, context, slot, player);
          return;
        }
        if (context == 9 || context == 11)
        {
          if (!Main.mouseRightRelease)
            return;
          ItemSlot.SwapVanityEquip(inv, context, slot, player);
          return;
        }
        if ((context == 0 || context == 4 || context == 32 /*0x20*/ || context == 3) && inv[slot].stack == 1 && !PlayerInput.UsingGamepadUI && (inv[slot].CanBeEquipped() || inv[slot].dye > (byte) 0 || ItemID.Sets.HasItemSwap[inv[slot].type]))
        {
          if (Main.mouseRightRelease && context == 0)
            ItemSlot.TryItemSwap(inv[slot]);
          if (!Main.mouseRightRelease)
            return;
          ItemSlot.SwapEquip(inv, context, slot);
          return;
        }
      }
      if (Main.stackSplit > 1 || inv[slot].IsAir)
        return;
      int num = Main.superFastStack + 1;
      for (int index = 0; index < num; ++index)
      {
        if (Item.CanStack(Main.mouseItem, inv[slot]) && Main.mouseItem.stack < Main.mouseItem.maxStack || Main.mouseItem.type == 0)
        {
          ItemSlot.PickupItemIntoMouse(inv, context, slot, player);
          SoundEngine.PlaySound(12);
          ItemSlot.RefreshStackSplitCooldown();
        }
      }
    }
  }

  public static void PickupItemIntoMouse(Item[] inv, int context, int slot, Player player)
  {
    if (Main.mouseItem.type == 0)
    {
      Main.mouseItem = inv[slot].Clone();
      if (context == 29)
      {
        Main.mouseItem.SetDefaults(Main.mouseItem.type);
        Main.mouseItem.OnCreated((ItemCreationContext) new JourneyDuplicationItemCreationContext());
      }
      Main.mouseItem.stack = 0;
      Main.mouseItem.favorited = inv[slot].favorited && inv[slot].stack == 1;
      ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(inv[slot], context, 21));
    }
    ++Main.mouseItem.stack;
    if (context != 29)
      --inv[slot].stack;
    if (inv[slot].stack <= 0)
      inv[slot] = new Item();
    CoinSlot.ForceSlotState(slot, context, inv[slot]);
    if (context == 3 && Main.netMode == 1)
      NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) slot);
    if ((context == 23 || context == 24 || context == 39) && Main.netMode == 1)
      NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot);
    if (context == 25 && Main.netMode == 1)
      NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 1f);
    if (context == 38 && Main.netMode == 1)
      NetMessage.SendData(121, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 3f);
    if (context == 26 && Main.netMode == 1)
      NetMessage.SendData(124, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot);
    if (context != 27 || Main.netMode != 1)
      return;
    NetMessage.SendData(124, number: Main.myPlayer, number2: (float) player.tileEntityAnchor.interactEntityID, number3: (float) slot, number4: 1f);
  }

  public static void RefreshStackSplitCooldown()
  {
    if (Main.stackSplit == 0)
      Main.stackSplit = 30;
    else
      Main.stackSplit = Main.stackDelay;
  }

  private static void TryOpenContainer(Item[] inv, int context, int slot, Player player)
  {
    Item obj = inv[slot];
    Player.GetItemLogger.Start();
    int num = ItemSlot.TryOpenContainer_GrantItems(obj, player) ? 1 : 0;
    Player.GetItemLogger.Stop();
    ItemSlot.DisplayTransfer_GetItem(inv, context, slot);
    if (num == 0)
      return;
    --obj.stack;
    if (obj.stack == 0)
      obj.SetDefaults(0);
    SoundEngine.PlaySound(7);
    Main.stackSplit = 30;
    Main.mouseRightRelease = false;
  }

  private static bool TryOpenContainer_GrantItems(Item item, Player player)
  {
    if (ItemID.Sets.BossBag[item.type])
      player.OpenBossBag(item.type);
    else if (ItemID.Sets.IsFishingCrate[item.type])
      player.OpenFishingCrate(item.type);
    else if (item.type == 3093)
      player.OpenHerbBag(3093);
    else if (item.type == 4345)
      player.OpenCanofWorms(item.type);
    else if (item.type == 4410)
      player.OpenOyster(item.type);
    else if (item.type == 1774)
      player.OpenGoodieBag(1774);
    else if (item.type == 6142)
      player.OpenChilletEgg(6142);
    else if (item.type == 3085)
    {
      if (!player.ConsumeItem(327, includeVoidBag: true))
        return false;
      player.OpenLockBox(3085);
    }
    else if (item.type == 4879)
    {
      if (!player.HasItemInInventoryOrOpenVoidBag(329))
        return false;
      player.OpenShadowLockbox(4879);
    }
    else if (item.type == 1869)
    {
      player.OpenPresent(1869);
    }
    else
    {
      if (item.type != 599 && item.type != 600 && item.type != 601)
        return false;
      player.OpenLegacyPresent(item.type);
    }
    return true;
  }

  private static void SwapVanityEquip(Item[] inv, int context, int slot, Player player)
  {
    if (Main.npcShop > 0)
      return;
    Item newAcc = inv[slot - 10];
    if (inv[slot].IsAir && newAcc.IsAir || context == 11 && (!inv[slot].IsAir && !ItemSlot.CanEquipAccessoryInSlot(inv[slot], new ArraySegment<Item>(Main.LocalPlayer.armor, 3, 7), slot - 10) || !newAcc.IsAir && !ItemSlot.CanEquipAccessoryInSlot(newAcc, new ArraySegment<Item>(Main.LocalPlayer.armor, 13, 7), slot)))
      return;
    Utils.Swap<Item>(ref inv[slot], ref inv[slot - 10]);
    SoundEngine.PlaySound(7);
    if (inv[slot].stack <= 0)
      return;
    switch (context)
    {
      case 0:
        AchievementsHelper.NotifyItemPickup(player, inv[slot]);
        break;
      case 8:
      case 9:
      case 10:
      case 11:
      case 12:
      case 16 /*0x10*/:
      case 17:
      case 33:
        AchievementsHelper.HandleOnEquip(player, inv[slot], context);
        break;
    }
  }

  private static void TryItemSwap(Item item)
  {
    int type = item.type;
    switch (type)
    {
      case 2611:
      case 5526:
        item.ChangeItemType(item.type == 2611 ? 5526 : 2611);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 4131:
      case 5325:
        item.ChangeItemType(item.type == 5325 ? 4131 : 5325);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 4346:
      case 5391:
        item.ChangeItemType(item.type == 4346 ? 5391 : 4346);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 4767:
      case 5453:
        item.ChangeItemType(item.type == 4767 ? 5453 : 4767);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5059:
      case 5060:
        item.ChangeItemType(item.type == 5059 ? 5060 : 5059);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5309:
      case 5454:
        item.ChangeItemType(item.type == 5309 ? 5454 : 5309);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5323:
      case 5455:
        item.ChangeItemType(item.type == 5323 ? 5455 : 5323);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5324:
        item.ChangeItemType(5329);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5329:
        item.ChangeItemType(5330);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5330:
        item.ChangeItemType(5324);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5358:
        item.ChangeItemType(5360);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5359:
        item.ChangeItemType(5358);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5360:
        item.ChangeItemType(5361);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5361:
        item.ChangeItemType(5359);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
      case 5437:
        item.ChangeItemType(5358);
        ItemSlot.AfterItemSwap(type, item.type);
        break;
    }
  }

  private static void AfterItemSwap(int oldType, int newType)
  {
    if (newType == 5324 || newType == 5329 || newType == 5330 || newType == 4346 || newType == 5391 || newType == 5358 || newType == 5361 || newType == 5360 || newType == 5359 || newType == 2611 || newType == 5526)
      SoundEngine.PlaySound(22);
    else
      SoundEngine.PlaySound(7);
    Main.stackSplit = 30;
    Main.mouseRightRelease = false;
  }

  public static void HandleItemPickupAction<TItemInfo>(
    ItemSlot.ItemPickupAction<TItemInfo> action,
    TItemInfo entry,
    int slotItemType,
    int slotItemStack,
    ref int stackLimiter)
  {
    if (!Main.mouseItem.IsAir && slotItemType != Main.mouseItem.type)
      return;
    bool flag = stackLimiter == -1;
    if (Main.stackSplit > 1 | flag)
      return;
    if (stackLimiter == 0)
      stackLimiter = slotItemStack;
    int stackToGet = Math.Min(Main.superFastStack + 1, stackLimiter);
    stackLimiter -= stackToGet;
    if (stackLimiter == 0)
      stackLimiter = -1;
    action(entry, stackToGet);
    ItemSlot.RefreshStackSplitCooldown();
  }

  private static void HandleShopSlot(
    Item[] inv,
    int slot,
    bool rightClickIsValid,
    bool leftClickIsValid)
  {
    if (Main.cursorOverride == 2)
      return;
    Chest chest = Main.instance.shop[Main.npcShop];
    bool flag = Main.mouseRight & rightClickIsValid || Main.mouseLeft & leftClickIsValid;
    if (!(Main.stackSplit <= 1 & flag) || inv[slot].type <= 0 || !Item.CanStack(Main.mouseItem, inv[slot]) && Main.mouseItem.type != 0)
      return;
    int num = Main.superFastStack + 1;
    if (ItemSlot.CanBulkBuy(inv[slot]))
      num *= ItemSlot.GetBulkBuyAmount(inv[slot]);
    Player localPlayer = Main.LocalPlayer;
    for (int index = 0; index < num; ++index)
    {
      if (Main.mouseItem.stack < Main.mouseItem.maxStack || Main.mouseItem.type == 0)
      {
        long calcForBuying;
        localPlayer.GetItemExpectedPrice(inv[slot], out long _, out calcForBuying);
        if (localPlayer.BuyItem(calcForBuying, inv[slot].shopSpecialCurrency) && inv[slot].stack > 0)
        {
          if (index == 0)
          {
            if (inv[slot].value > 0)
              SoundEngine.PlaySound(18);
            else
              SoundEngine.PlaySound(7);
          }
          if (Main.mouseItem.type == 0)
          {
            Main.mouseItem.SetDefaults(inv[slot].type);
            if (inv[slot].prefix != (byte) 0)
              Main.mouseItem.Prefix((int) inv[slot].prefix);
            Main.mouseItem.stack = 0;
          }
          if (!inv[slot].buyOnce && inv[slot].shopSpecialCurrency == -1)
            Main.shopSellbackHelper.Add(inv[slot]);
          ++Main.mouseItem.stack;
          ItemSlot.RefreshStackSplitCooldown();
          if (inv[slot].buyOnce && --inv[slot].stack <= 0)
            inv[slot].SetDefaults(0);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(Main.mouseItem, 15, 21));
        }
      }
    }
  }

  public static void Draw(
    SpriteBatch spriteBatch,
    ref Item inv,
    int context,
    Vector2 position,
    Color lightColor = default (Color))
  {
    ItemSlot.singleSlotArray[0] = inv;
    ItemSlot.Draw(spriteBatch, ItemSlot.singleSlotArray, context, 0, position, lightColor);
    inv = ItemSlot.singleSlotArray[0];
  }

  public static void Draw(
    SpriteBatch spriteBatch,
    Item[] inv,
    int context,
    int slot,
    Vector2 position,
    Color lightColor = default (Color))
  {
    Player player = Main.player[Main.myPlayer];
    Item obj = inv[slot];
    float inventoryScale = Main.inventoryScale;
    Color color1 = Color.White;
    if (lightColor != Color.Transparent)
      color1 = lightColor;
    bool flag1 = false;
    switch (context)
    {
      case 13:
        if (slot == player.selectedItem && !player.selectedItemState.HasActiveOverride)
        {
          flag1 = true;
          break;
        }
        break;
      case 36:
        flag1 = true;
        context = 13;
        break;
    }
    bool flag2 = false;
    int num1 = 0;
    int gamepadPointForSlot = ItemSlot.GetGamepadPointForSlot(inv, context, slot);
    if (PlayerInput.UsingGamepadUI)
    {
      flag2 = UILinkPointNavigator.CurrentPoint == gamepadPointForSlot;
      if (PlayerInput.SettingsForUI.PreventHighlightsForGamepad)
        flag2 = false;
      if (context == 0)
      {
        num1 = player.DpadRadial.GetDrawMode(slot);
        if (num1 > 0 && !PlayerInput.CurrentProfile.UsingDpadHotbar())
          num1 = 0;
      }
    }
    Texture2D texture2D1 = TextureAssets.InventoryBack.Value;
    Color firstColor = Main.inventoryBack;
    bool flag3 = false;
    bool highlightThingsForMouse = PlayerInput.SettingsForUI.HighlightThingsForMouse;
    if (obj.type > 0 && obj.stack > 0 && obj.favorited && context != 13 && context != 21 && context != 37 && context != 22 && context != 14 && context != 35)
    {
      texture2D1 = TextureAssets.InventoryBack10.Value;
      if (context == 32 /*0x20*/)
        texture2D1 = TextureAssets.InventoryBack19.Value;
    }
    else if (obj.type > 0 && obj.stack > 0 && ItemSlot.Options.HighlightNewItems && obj.newAndShiny && context != 13 && context != 21 && context != 37 && context != 14 && context != 22 && context != 35)
    {
      texture2D1 = TextureAssets.InventoryBack15.Value;
      float num2 = (float) ((double) ((float) Main.mouseTextColor / (float) byte.MaxValue) * 0.20000000298023224 + 0.800000011920929);
      firstColor = firstColor.MultiplyRGBA(new Color(num2, num2, num2));
    }
    else if (!highlightThingsForMouse && obj.type > 0 && obj.stack > 0 && num1 != 0 && context != 13 && context != 21 && context != 37 && context != 22 && context != 35)
    {
      texture2D1 = TextureAssets.InventoryBack15.Value;
      float num3 = (float) ((double) ((float) Main.mouseTextColor / (float) byte.MaxValue) * 0.20000000298023224 + 0.800000011920929);
      firstColor = num1 != 1 ? firstColor.MultiplyRGBA(new Color(num3 / 2f, num3, num3 / 2f)) : firstColor.MultiplyRGBA(new Color(num3, num3 / 2f, num3 / 2f));
    }
    else if (context == 0 && slot < 10)
      texture2D1 = TextureAssets.InventoryBack9.Value;
    else if (context == 28)
    {
      texture2D1 = TextureAssets.InventoryBack7.Value;
      firstColor = Color.White;
    }
    else if (context == 16 /*0x10*/ || context == 17 || context == 19 || context == 18 || context == 20 || context == 17)
      texture2D1 = TextureAssets.InventoryBack3.Value;
    else if (context == 10 || context == 8)
    {
      texture2D1 = TextureAssets.InventoryBack13.Value;
      firstColor = ItemSlot.GetColorByLoadout(slot, context);
    }
    else if (context == 24 || context == 23 || context == 39 || context == 38 || context == 26)
      texture2D1 = TextureAssets.InventoryBack8.Value;
    else if (context == 11 || context == 9)
    {
      texture2D1 = TextureAssets.InventoryBack13.Value;
      firstColor = ItemSlot.GetColorByLoadout(slot, context);
    }
    else if (context == 25 || context == 27 || context == 33)
    {
      texture2D1 = TextureAssets.InventoryBack12.Value;
    }
    else
    {
      switch (context)
      {
        case 3:
          texture2D1 = TextureAssets.InventoryBack5.Value;
          break;
        case 12:
          texture2D1 = TextureAssets.InventoryBack13.Value;
          firstColor = ItemSlot.GetColorByLoadout(slot, context);
          break;
        default:
          if (context == 4 || context == 32 /*0x20*/)
          {
            texture2D1 = TextureAssets.InventoryBack2.Value;
            break;
          }
          if (context == 7 || context == 5)
          {
            texture2D1 = TextureAssets.InventoryBack4.Value;
            break;
          }
          switch (context)
          {
            case 6:
              texture2D1 = TextureAssets.InventoryBack7.Value;
              break;
            case 13:
              byte num4 = 200;
              if (slot == Main.LocalPlayer.selectedItemState.Hotbar)
              {
                texture2D1 = TextureAssets.InventoryBack20.Value;
                num4 = byte.MaxValue;
              }
              if (flag1)
              {
                texture2D1 = TextureAssets.InventoryBack14.Value;
                num4 = byte.MaxValue;
              }
              firstColor = new Color((int) num4, (int) num4, (int) num4, (int) num4);
              break;
            default:
              if (context == 14 || context == 21 || context == 37)
              {
                flag3 = true;
                break;
              }
              switch (context)
              {
                case 15:
                  texture2D1 = TextureAssets.InventoryBack6.Value;
                  break;
                case 29:
                  firstColor = new Color(53, 69, (int) sbyte.MaxValue, (int) byte.MaxValue);
                  texture2D1 = TextureAssets.InventoryBack18.Value;
                  break;
                case 30:
                  flag3 = !flag2;
                  break;
                case 34:
                  firstColor = new Color(25, 44, 65, 180) * 0.9f;
                  texture2D1 = TextureAssets.InventoryBack18.Value;
                  break;
                default:
                  Color color2;
                  if (context == 22 || context == 42 || context == 43)
                  {
                    texture2D1 = TextureAssets.InventoryBack4.Value;
                    if (context == 42 || context == 43)
                    {
                      color2 = new Color(20, 40, 60, 180) * 0.9f;
                      firstColor = Utils.ShiftBlueToCyanTheme(new Color(16 /*0x10*/, 36, 56, 180) * 0.9f);
                      texture2D1 = TextureAssets.InventoryBack18.Value;
                      if (slot == 0)
                        texture2D1 = TextureAssets.InventoryBack18.Value;
                    }
                    if (ItemSlot.DrawGoldBGForCraftingMaterial)
                    {
                      ItemSlot.DrawGoldBGForCraftingMaterial = false;
                      texture2D1 = TextureAssets.InventoryBack14.Value;
                      float t = (float) firstColor.A / (float) byte.MaxValue;
                      firstColor = Color.White * ((double) t >= 0.699999988079071 ? 1f : Utils.GetLerpValue(0.0f, 0.7f, t, true));
                      break;
                    }
                    break;
                  }
                  switch (context)
                  {
                    case 35:
                      texture2D1 = TextureAssets.InventoryBack2.Value;
                      if (ItemSlot.DrawGoldBGForCraftingMaterial)
                      {
                        ItemSlot.DrawGoldBGForCraftingMaterial = false;
                        texture2D1 = TextureAssets.InventoryBack14.Value;
                        float t = (float) firstColor.A / (float) byte.MaxValue;
                        firstColor = Color.White * ((double) t >= 0.699999988079071 ? 1f : Utils.GetLerpValue(0.0f, 0.7f, t, true));
                        break;
                      }
                      break;
                    case 41:
                      color2 = new Color(20, 40, 60, 180) * 0.9f;
                      firstColor = Utils.ShiftBlueToCyanTheme(new Color(16 /*0x10*/, 36, 56, 180) * 0.9f);
                      texture2D1 = TextureAssets.InventoryBack18.Value;
                      break;
                  }
                  break;
              }
              break;
          }
          break;
      }
    }
    if ((context == 0 || context == 2) && ItemSlot.inventoryGlowTime[slot] > 0 && !inv[slot].favorited && !inv[slot].IsAir)
    {
      float num5 = Main.invAlpha / (float) byte.MaxValue;
      Color color3 = new Color(63 /*0x3F*/, 65, 151, (int) byte.MaxValue) * num5;
      Color color4 = Main.hslToRgb(ItemSlot.inventoryGlowHue[slot], 1f, 0.5f) * num5;
      float num6 = (float) ItemSlot.inventoryGlowTime[slot] / 300f;
      float num7 = num6 * num6;
      Color color5 = color4;
      double amount = (double) num7 / 2.0;
      firstColor = Color.Lerp(color3, color5, (float) amount);
      texture2D1 = TextureAssets.InventoryBack13.Value;
    }
    if ((context == 4 || context == 32 /*0x20*/ || context == 3) && ItemSlot.inventoryGlowTimeChest[slot] > 0 && !inv[slot].favorited && !inv[slot].IsAir)
    {
      float num8 = Main.invAlpha / (float) byte.MaxValue;
      Color color6 = new Color(130, 62, 102, (int) byte.MaxValue) * num8;
      if (context == 3)
        color6 = new Color(104, 52, 52, (int) byte.MaxValue) * num8;
      Color color7 = Main.hslToRgb(ItemSlot.inventoryGlowHueChest[slot], 1f, 0.5f) * num8;
      float num9 = (float) ItemSlot.inventoryGlowTimeChest[slot] / 300f;
      float num10 = num9 * num9;
      firstColor = Color.Lerp(color6, color7, num10 / 2f);
      texture2D1 = TextureAssets.InventoryBack13.Value;
    }
    if (flag2)
    {
      texture2D1 = TextureAssets.InventoryBack14.Value;
      firstColor = Color.White;
      if (obj.favorited)
        texture2D1 = TextureAssets.InventoryBack17.Value;
      if (context == 34)
        firstColor = Color.Gray;
    }
    if (context == 41 || context == 43 || context == 42)
      firstColor = firstColor.MultiplyRGBA(lightColor);
    if (context == 28 && Main.MouseScreen.Between(position, position + texture2D1.Size() * inventoryScale) && !player.mouseInterface)
    {
      texture2D1 = TextureAssets.InventoryBack14.Value;
      firstColor = Color.White;
    }
    CoinSlot.CoinDrawState drawState;
    CoinSlot.UpdateDrawState(slot, context, obj, out drawState);
    float itemFade = 1f;
    ItemSlot.GetDimSlotForMouseItem(context, slot, Main.mouseItem, out itemFade);
    Color color8 = firstColor * itemFade;
    if (!flag3)
    {
      spriteBatch.Draw(texture2D1, position, new Rectangle?(), color8, 0.0f, new Vector2(), inventoryScale, SpriteEffects.None, 0.0f);
      if (context == 32 /*0x20*/ || context == 0 || context == 2 || context == 1)
      {
        int index = context == 32 /*0x20*/ ? slot + PlayerItemSlotID.Bank4_0 : slot;
        ItemSlot.PulseEffect playerSlotPulseEffect = ItemSlot.playerSlotPulseEffects[index];
        if (playerSlotPulseEffect.IsActive)
        {
          float effectDuration = (float) ItemSlot.PulseEffect.EffectDuration;
          float num11 = 0.5f;
          float num12 = 3.14159274f;
          float num13 = (float) playerSlotPulseEffect.time / effectDuration;
          Color color9 = playerSlotPulseEffect.color * (float) (0.5 + 0.2 * -Math.Cos((double) num13 * Math.PI * 2.0 * (double) num11 + (double) num12)) * (float) (1.0 - (double) num13 * (double) num13 * (double) num13 * (double) num13);
          spriteBatch.Draw(TextureAssets.InventoryBack21.Value, position, new Rectangle?(), color9, 0.0f, new Vector2(), inventoryScale, SpriteEffects.None, 0.0f);
        }
      }
      if (context == 41 && ItemSlot.DrawSelectionHighlightForGridSlot)
        spriteBatch.Draw(TextureAssets.InventoryBack24.Value, position, new Rectangle?(), Main.inventoryBack, 0.0f, new Vector2(), inventoryScale, SpriteEffects.None, 0.0f);
    }
    if (ItemSlot.ShouldHighlightSlotForMouseItem(context, slot, Main.mouseItem))
    {
      Color color10 = color8;
      if (texture2D1 == TextureAssets.InventoryBack3.Value)
        color10 = new Color(50, 106, 46, (int) color8.A);
      else if (texture2D1 == TextureAssets.InventoryBack8.Value)
        color10 = new Color(46, 106, 98, (int) color8.A);
      else if (texture2D1 == TextureAssets.InventoryBack12.Value)
        color10 = new Color(45, 85, 105, (int) color8.A);
      else if (texture2D1 == TextureAssets.InventoryBack13.Value)
      {
        ItemSlot.TryGetSlotColor(Main.LocalPlayer.CurrentLoadoutIndex, context, out color10);
        color10.A = color8.A;
      }
      color10 *= 2f;
      spriteBatch.Draw(TextureAssets.InventoryBack22.Value, position, new Rectangle?(), color10, 0.0f, new Vector2(), inventoryScale, SpriteEffects.None, 0.0f);
    }
    int num14 = -1;
    switch (context)
    {
      case 7:
        num14 = 18;
        break;
      case 8:
      case 23:
        if (slot == 0)
          num14 = 0;
        if (slot == 1)
          num14 = 6;
        if (slot == 2)
        {
          num14 = 12;
          break;
        }
        break;
      case 9:
        if (slot == 10)
          num14 = 3;
        if (slot == 11)
          num14 = 9;
        if (slot == 12)
        {
          num14 = 15;
          break;
        }
        break;
      case 10:
      case 24:
        num14 = 11;
        break;
      case 11:
        num14 = 2;
        break;
      case 12:
      case 25:
      case 27:
      case 33:
        num14 = 1;
        break;
      case 16 /*0x10*/:
        num14 = 4;
        break;
      case 17:
      case 39:
        num14 = 13;
        break;
      case 18:
        num14 = 7;
        break;
      case 19:
        num14 = 10;
        break;
      case 20:
        num14 = 17;
        break;
      case 26:
        num14 = 0;
        break;
    }
    if ((obj.type <= 0 || obj.stack <= 0) && num14 != -1)
    {
      float num15 = 0.35f;
      Texture2D texture2D2 = TextureAssets.Extra[54].Value;
      Rectangle r = texture2D2.Frame(3, 7, num14 % 3, num14 / 3);
      r.Width -= 2;
      r.Height -= 2;
      spriteBatch.Draw(texture2D2, position + texture2D1.Size() / 2f * inventoryScale, new Rectangle?(r), Color.White * (num15 * itemFade), 0.0f, r.Size() / 2f, inventoryScale, SpriteEffects.None, 0.0f);
    }
    Vector2 vector2_1 = texture2D1.Size() * inventoryScale;
    bool flag4 = obj.type > 0 && obj.stack > 0 || drawState.fadeItem > 0;
    if (flag4)
    {
      ItemSlot.ItemDisplayKey key = new ItemSlot.ItemDisplayKey()
      {
        Context = context,
        Slot = slot
      };
      ulong num16;
      if (ItemSlot._nextTickDrawAvailable.TryGetValue(key, out num16) && num16 > Main.EverLastingTicker)
        flag4 = false;
    }
    if (flag4)
    {
      float scale = obj.IsACoin || drawState.fadeItem > 0 ? CoinSlot.DrawItemCoin(spriteBatch, position + vector2_1 / 2f - new Vector2(0.0f, drawState.coinYOffset * inventoryScale), drawState.fadeItem > 0 ? drawState.fadeItem : obj.type, drawState.coinAnimFrame, inventoryScale, 32f, color1, itemFade * drawState.fadeScale) : ItemSlot.DrawItemIcon(obj, context, spriteBatch, position + vector2_1 / 2f, inventoryScale, 32f, color1, itemFade);
      if (Main.DoGlowingMouseItemDraw)
      {
        float glow = CraftingEffects.GetGlow(obj);
        float num17 = glow;
        float fromValue1 = num17 * num17;
        bool flag5 = true;
        if (!Main.FlashyEffectsInterface)
          flag5 = false;
        if ((double) glow > 0.0 & flag5)
        {
          float num18 = Utils.Remap(fromValue1, 1f, 0.0f, 1f, 2f);
          float fromValue2 = Utils.Remap((float) Main.stackCounter, 0.0f, 8f, 0.0f, 1f);
          if (Main.superFastStack > 0)
            fromValue2 = 1f;
          double num19 = (double) Utils.Remap(fromValue2, 0.0f, 1f, 1f, 0.5f);
          float saturation = fromValue1 * Utils.Remap(glow, 1f, 0.95f, 0.5f, 1f);
          MiscShaderData miscShaderData = GameShaders.Misc["MouseItem"];
          miscShaderData.UseSaturation(saturation);
          miscShaderData.UseColor(Main.OurFavoriteColor);
          miscShaderData.Apply(new DrawData?());
          scale = obj.IsACoin || drawState.fadeItem > 0 ? CoinSlot.DrawItemCoin(spriteBatch, position + vector2_1 / 2f - new Vector2(0.0f, drawState.coinYOffset * inventoryScale), drawState.fadeItem > 0 ? drawState.fadeItem : obj.type, drawState.coinAnimFrame, inventoryScale * num18, 32f, color1, itemFade * drawState.fadeScale) : ItemSlot.DrawItemIcon(obj, context, spriteBatch, position + vector2_1 / 2f, inventoryScale * num18, 32f, color1, itemFade);
          Main.pixelShader.CurrentTechnique.Passes[0].Apply();
        }
      }
      if (obj.type == 5324 || obj.type == 5329 || obj.type == 5330)
      {
        Vector2 vector2_2 = new Vector2(2f, -6f) * inventoryScale;
        switch (obj.type)
        {
          case 5324:
            Texture2D texture2D3 = TextureAssets.Extra[257].Value;
            Rectangle r1 = texture2D3.Frame(3, frameX: 2);
            spriteBatch.Draw(texture2D3, position + vector2_2 + new Vector2(40f, 40f) * inventoryScale, new Rectangle?(r1), color1 * itemFade, 0.0f, r1.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
            break;
          case 5329:
            Texture2D texture2D4 = TextureAssets.Extra[257].Value;
            Rectangle r2 = texture2D4.Frame(3, frameX: 1);
            spriteBatch.Draw(texture2D4, position + vector2_2 + new Vector2(40f, 40f) * inventoryScale, new Rectangle?(r2), color1 * itemFade, 0.0f, r2.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
            break;
          case 5330:
            Texture2D texture2D5 = TextureAssets.Extra[257].Value;
            Rectangle r3 = texture2D5.Frame(3);
            spriteBatch.Draw(texture2D5, position + vector2_2 + new Vector2(40f, 40f) * inventoryScale, new Rectangle?(r3), color1 * itemFade, 0.0f, r3.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
            break;
        }
      }
      int num20 = -1;
      if (context == 13)
      {
        if (obj.DD2Summon)
        {
          for (int index = 0; index < 58; ++index)
          {
            if (inv[index].type == 3822)
              num20 += inv[index].stack;
          }
          if (num20 >= 0)
            ++num20;
        }
        if (obj.useAmmo > 0)
        {
          int useAmmo = obj.useAmmo;
          num20 = 0;
          for (int index = 0; index < 58; ++index)
          {
            if (inv[index].ammo == useAmmo)
              num20 += inv[index].stack;
          }
        }
        if (obj.fishingPole > 0)
        {
          num20 = 0;
          for (int index = 0; index < 58; ++index)
          {
            if (inv[index].bait > 0)
              num20 += inv[index].stack;
          }
        }
        if (obj.tileWand > 0)
        {
          int tileWand = obj.tileWand;
          num20 = 0;
          for (int index = 0; index < 58; ++index)
          {
            if (inv[index].type == tileWand)
              num20 += inv[index].stack;
          }
        }
        int amount;
        if (player.TryGetFlexibleWandAvailableUsageCount(obj, out amount))
          num20 = amount;
        else if (obj.GetFlexibleTileWand() != null && obj.GetFlexibleTileWand().ShowsHoverAmmoIcon)
          num20 = 0;
        switch (obj.type)
        {
          case 1071:
          case 1072:
          case 1543:
          case 1544:
            Item paintOrCoating = player.FindPaintOrCoating();
            if (paintOrCoating != null)
            {
              num20 = paintOrCoating.stack;
              break;
            }
            break;
        }
        if (obj.type == 509 || obj.type == 851 || obj.type == 850 || obj.type == 3612 || obj.type == 3625 || obj.type == 3611)
        {
          num20 = 0;
          for (int index = 0; index < 58; ++index)
          {
            if (inv[index].type == 530)
              num20 += inv[index].stack;
          }
        }
      }
      if (num20 != -1)
        ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, num20.ToString(), position + new Vector2(8f, 30f) * inventoryScale, color1, 0.0f, Vector2.Zero, new Vector2(inventoryScale * 0.8f), spread: inventoryScale);
      if (context != 37 && (obj.stack > 1 || (double) drawState.stackTextDrawFadeOverload > 0.0) && num20 == -1)
      {
        Vector2 vector2_3 = new Vector2(10f, (float) (26 + FontAssets.ItemStack.Value.LineSpacing));
        float spread = inventoryScale * drawState.stackTextScale;
        if (context == 43)
        {
          vector2_3 += new Vector2(-5f, 7f);
          spread *= 1.2f;
        }
        float num21 = (double) drawState.stackTextDrawFadeOverload > 0.0 ? drawState.stackTextDrawFadeOverload : 1f;
        ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, obj.stack.ToString(), position + vector2_3 * inventoryScale, color1 * num21, 0.0f, new Vector2(0.0f, (float) FontAssets.ItemStack.Value.LineSpacing), new Vector2(spread), spread: spread);
      }
      if (context == 13)
      {
        string text = string.Concat((object) (slot + 1));
        if (text == "10")
          text = "0";
        ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, text, position + new Vector2(8f, 4f) * inventoryScale, color1, 0.0f, Vector2.Zero, new Vector2(inventoryScale), spread: inventoryScale);
      }
      if (context == 13 && obj.potion)
      {
        Vector2 position1 = position + texture2D1.Size() * inventoryScale / 2f - TextureAssets.Cd.Value.Size() * inventoryScale / 2f;
        Color color11 = obj.GetAlpha(color1) * ((float) player.potionDelay / (float) player.potionDelayTime);
        spriteBatch.Draw(TextureAssets.Cd.Value, position1, new Rectangle?(), color11, 0.0f, new Vector2(), scale, SpriteEffects.None, 0.0f);
      }
      if (context == 34)
      {
        Vector2 position2 = position + texture2D1.Size() * inventoryScale / 2f - TextureAssets.Cd.Value.Size() * inventoryScale / 2f;
        Color color12 = obj.GetAlpha(color1) * 0.5f;
        spriteBatch.Draw(TextureAssets.Cd.Value, position2, new Rectangle?(), color12, 0.0f, new Vector2(), scale, SpriteEffects.None, 0.0f);
      }
      if ((context == 10 || context == 18) && obj.expertOnly && !Main.expertMode)
      {
        Vector2 position3 = position + texture2D1.Size() * inventoryScale / 2f - TextureAssets.Cd.Value.Size() * inventoryScale / 2f;
        Color white = Color.White;
        spriteBatch.Draw(TextureAssets.Cd.Value, position3, new Rectangle?(), white * itemFade, 0.0f, new Vector2(), scale, SpriteEffects.None, 0.0f);
      }
    }
    else if (context == 6)
    {
      Texture2D texture2D6 = TextureAssets.Trash.Value;
      Vector2 position4 = position + texture2D1.Size() * inventoryScale / 2f - texture2D6.Size() * inventoryScale / 2f;
      spriteBatch.Draw(texture2D6, position4, new Rectangle?(), new Color(100, 100, 100, 100), 0.0f, new Vector2(), inventoryScale, SpriteEffects.None, 0.0f);
    }
    if (context == 0 && slot < 10)
    {
      float num22 = inventoryScale;
      string text = string.Concat((object) (slot + 1));
      if (text == "10")
        text = "0";
      Color baseColor = Main.inventoryBack;
      int num23 = 0;
      if (Main.player[Main.myPlayer].selectedItem == slot)
      {
        baseColor = Color.White with { A = (byte) 200 };
        num23 -= 2;
        float num24 = num22 * 1.4f;
      }
      ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, text, position + new Vector2(6f, (float) (4 + num23)) * inventoryScale, baseColor, 0.0f, Vector2.Zero, new Vector2(inventoryScale), spread: inventoryScale);
    }
    if (gamepadPointForSlot == -1)
      return;
    UILinkPointNavigator.SetPosition(gamepadPointForSlot, position + vector2_1 * 0.75f);
  }

  public static Color GetColorByLoadout(int slot, int context)
  {
    Color color1 = Color.White;
    Color color2;
    if (ItemSlot.TryGetSlotColor(Main.LocalPlayer.CurrentLoadoutIndex, context, out color2))
      color1 = color2;
    Color color3 = new Color(color1.ToVector4() * Main.inventoryBack.ToVector4());
    float num = Utils.Remap((float) (Main.timeForVisualEffects - ItemSlot._lastTimeForVisualEffectsThatLoadoutWasChanged), 0.0f, 30f, 0.5f, 0.0f);
    if (!Main.FlashyEffectsInterface)
      num = 0.0f;
    Color white = Color.White;
    double amount = (double) num * (double) num * (double) num;
    return Color.Lerp(color3, white, (float) amount);
  }

  public static void RecordLoadoutChange()
  {
    ItemSlot._lastTimeForVisualEffectsThatLoadoutWasChanged = Main.timeForVisualEffects;
  }

  public static bool TryGetSlotColor(int loadoutIndex, int context, out Color color)
  {
    color = new Color();
    if (loadoutIndex < 0 || loadoutIndex >= 3)
      return false;
    int index = -1;
    switch (context)
    {
      case 8:
      case 10:
        index = 0;
        break;
      case 9:
      case 11:
        index = 1;
        break;
      case 12:
        index = 2;
        break;
    }
    if (index == -1)
      return false;
    color = ItemSlot.LoadoutSlotColors[loadoutIndex, index];
    return true;
  }

  public static float ShiftHueByLoadout(float hue, int loadoutIndex)
  {
    return (float) (((double) hue + (double) loadoutIndex / 8.0) % 1.0);
  }

  public static Color GetLoadoutColor(int loadoutIndex)
  {
    return Main.hslToRgb(ItemSlot.ShiftHueByLoadout(0.41f, loadoutIndex), 0.7f, 0.5f);
  }

  public static float DrawItemIcon(
    Item item,
    int context,
    SpriteBatch spriteBatch,
    Vector2 screenPositionForItemCenter,
    float scale,
    float sizeLimit,
    Color environmentColor,
    float itemFade = 1f,
    bool flip = false)
  {
    Color secondColor1 = Color.White;
    Color secondColor2 = Color.White;
    int type = item.type;
    Main.instance.LoadItem(type);
    Texture2D texture2D1 = TextureAssets.Item[type].Value;
    Rectangle frame = texture2D1.Frame();
    DrawAnimation itemAnimation = Main.itemAnimations[type];
    if (itemAnimation != null)
    {
      int frameCounterOverride = -1;
      if (type == 5644 && context != 31 /*0x1F*/ && !Main.LocalPlayer.AnyoneToSpectate())
        frameCounterOverride = 0;
      frame = itemAnimation.GetFrame(texture2D1, frameCounterOverride);
    }
    float num = 1f;
    if (context == 37)
    {
      secondColor1 = ItemSlot.OverdrawGlowColorMultiplier;
      secondColor2 = ItemSlot.OverdrawGlowColorMultiplier;
      environmentColor = Color.White;
      num = ItemSlot.OverdrawGlowSize;
    }
    Color itemLight;
    float finalDrawScale;
    ItemSlot.DrawItem_GetColorAndScale(item, scale, ref environmentColor, sizeLimit, ref frame, out itemLight, out finalDrawScale);
    SpriteEffects effects = SpriteEffects.None;
    if (flip)
      effects = SpriteEffects.FlipHorizontally;
    Vector2 origin = frame.Size() / 2f;
    Color color1 = item.GetAlpha(itemLight).MultiplyRGBA(secondColor1);
    spriteBatch.Draw(texture2D1, screenPositionForItemCenter, new Rectangle?(frame), color1 * itemFade, 0.0f, origin, finalDrawScale * num, effects, 0.0f);
    if (item.color != Color.Transparent)
    {
      Color newColor = environmentColor;
      if (context == 13)
        newColor.A = byte.MaxValue;
      spriteBatch.Draw(texture2D1, screenPositionForItemCenter, new Rectangle?(frame), item.GetColor(newColor).MultiplyRGBA(secondColor2) * itemFade, 0.0f, origin, finalDrawScale * num, effects, 0.0f);
    }
    if (item.glowMask != (short) -1 && item.type != 3779 && item.type != 46 && item.type != 5462)
    {
      Rectangle r = frame;
      Color color2 = Color.White;
      switch (item.type)
      {
        case 3858:
          color2 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 63 /*0x3F*/) * 0.75f;
          r = TextureAssets.GlowMask[233].Value.Frame(verticalFrames: 3, frameY: Main.LocalPlayer.miscCounter % 15 / 5);
          r.Height -= 2;
          break;
        case 5146:
          color2 = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
          break;
        case 5462:
          color2 = new Color((int) byte.MaxValue, 140, 0, 5);
          break;
        case 5669:
          float amount = Utils.WrappedLerp(0.5f, 1f, (float) (Main.LocalPlayer.miscCounter % 100) / 100f);
          color2 = Color.Lerp(color2, new Color(180, 85, 30), amount) with
          {
            A = (byte) item.alpha
          };
          break;
        case 5670:
        case 5671:
          color2 = Item.GetPhaseColor(item.shoot);
          break;
      }
      if (item.type == 5670 || item.type == 5671)
      {
        spriteBatch.Draw(TextureAssets.GlowMask[(int) item.glowMask].Value, screenPositionForItemCenter, new Rectangle?(r), color2 * itemFade, 0.0f, r.Size() / 2f, finalDrawScale * num, effects, 0.0f);
        color2 = Item.GetPhaseColor(item.shoot, true);
      }
      spriteBatch.Draw(TextureAssets.GlowMask[(int) item.glowMask].Value, screenPositionForItemCenter, new Rectangle?(r), color2 * itemFade, 0.0f, r.Size() / 2f, finalDrawScale * num, effects, 0.0f);
    }
    if (ItemID.Sets.TrapSigned[item.type])
    {
      Vector2 vector2_1 = new Vector2(1f, -1f);
      Vector2 vector2_2 = frame.Size() * 0.45f * vector2_1 * finalDrawScale * num;
      spriteBatch.Draw(TextureAssets.Wire.Value, screenPositionForItemCenter + vector2_2, new Rectangle?(new Rectangle(4, 58, 8, 8)), environmentColor * itemFade, 0.0f, new Vector2(4f), finalDrawScale * num, SpriteEffects.None, 0.0f);
    }
    if (ItemID.Sets.DrawUnsafeIndicator[item.type])
    {
      Vector2 vector2_3 = new Vector2(1f, -1f);
      Vector2 vector2_4 = (frame.Size() * 0.45f + new Vector2(-4f, -4f)) * vector2_3 * finalDrawScale * num;
      Texture2D texture2D2 = TextureAssets.Extra[258].Value;
      Rectangle r = texture2D2.Frame();
      spriteBatch.Draw(texture2D2, screenPositionForItemCenter + vector2_4, new Rectangle?(r), environmentColor * itemFade, 0.0f, r.Size() / 2f, finalDrawScale * num, SpriteEffects.None, 0.0f);
    }
    return finalDrawScale;
  }

  public static void DrawItem_GetColorAndScale(
    Item item,
    float scale,
    ref Color currentWhite,
    float sizeLimit,
    ref Rectangle frame,
    out Color itemLight,
    out float finalDrawScale)
  {
    itemLight = currentWhite;
    float scale1 = 1f;
    ItemSlot.GetItemLight(ref itemLight, ref scale1, item);
    float num = 1f;
    if ((double) frame.Width > (double) sizeLimit || (double) frame.Height > (double) sizeLimit)
      num = frame.Width <= frame.Height ? sizeLimit / (float) frame.Height : sizeLimit / (float) frame.Width;
    if (item.type == 5669 && (double) sizeLimit == 20.0)
      num = 0.5f;
    finalDrawScale = scale * num * scale1;
  }

  private static int GetGamepadPointForSlot(Item[] inv, int context, int slot)
  {
    Player localPlayer = Main.LocalPlayer;
    int gamepadPointForSlot = -1;
    switch (context)
    {
      case 0:
      case 1:
      case 2:
        gamepadPointForSlot = slot;
        break;
      case 3:
      case 4:
      case 32 /*0x20*/:
        gamepadPointForSlot = 400 + slot - ChestUI.StartingRowForDrawing * 10;
        break;
      case 5:
        gamepadPointForSlot = 303;
        break;
      case 6:
        gamepadPointForSlot = 300;
        break;
      case 7:
        gamepadPointForSlot = NewCraftingUI.Visible ? 20020 : 1500;
        break;
      case 8:
      case 9:
      case 10:
      case 11:
        int num1 = slot;
        if (num1 % 10 == 9 && !localPlayer.CanDemonHeartAccessoryBeShown())
          --num1;
        gamepadPointForSlot = 100 + num1;
        break;
      case 12:
        if (inv == localPlayer.dye)
        {
          int num2 = slot;
          if (num2 % 10 == 9 && !localPlayer.CanDemonHeartAccessoryBeShown())
            --num2;
          gamepadPointForSlot = 120 + num2;
          break;
        }
        break;
      case 15:
        gamepadPointForSlot = 2700 + slot;
        break;
      case 16 /*0x10*/:
        gamepadPointForSlot = 184;
        break;
      case 17:
        gamepadPointForSlot = 183;
        break;
      case 18:
        gamepadPointForSlot = 182;
        break;
      case 19:
        gamepadPointForSlot = 180;
        break;
      case 20:
        gamepadPointForSlot = 181;
        break;
      case 22:
        if (UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig != -1)
          gamepadPointForSlot = 22000 + UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig;
        if (UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall != -1)
        {
          gamepadPointForSlot = 1500 + UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall + 1;
          break;
        }
        break;
      case 23:
      case 24:
      case 39:
        gamepadPointForSlot = 5100 + slot;
        break;
      case 25:
        gamepadPointForSlot = 5109 + slot;
        break;
      case 26:
        gamepadPointForSlot = 5000 + slot;
        break;
      case 27:
        gamepadPointForSlot = 5002 + slot;
        break;
      case 29:
      case 34:
      case 41:
        gamepadPointForSlot = 3000 + slot;
        if (UILinkPointNavigator.Shortcuts.ItemSlotShouldHighlightAsSelected)
        {
          gamepadPointForSlot = UILinkPointNavigator.CurrentPoint;
          break;
        }
        break;
      case 30:
        gamepadPointForSlot = 15000 + slot;
        break;
      case 33:
        if (inv == localPlayer.miscDyes)
        {
          gamepadPointForSlot = 185 + slot;
          break;
        }
        break;
      case 35:
        if (UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall != -1)
          gamepadPointForSlot = 12000;
        if (UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig != -1)
        {
          gamepadPointForSlot = 11100;
          break;
        }
        break;
      case 38:
        gamepadPointForSlot = 5118;
        break;
      case 42:
        gamepadPointForSlot = 20000;
        break;
      case 43:
        gamepadPointForSlot = 20001 + UILinkPointNavigator.Shortcuts.NewCraftingUI_MaterialIndex;
        break;
    }
    return gamepadPointForSlot;
  }

  public static void MouseHover(int context = 0) => ItemSlot.MouseHover(Main.HoverItem, context);

  public static void MouseHover(Item item, int context = 0)
  {
    ItemSlot.singleSlotArray[0] = item;
    ItemSlot.MouseHover(ItemSlot.singleSlotArray, context);
  }

  public static int GetBulkBuyAmount(Item item)
  {
    int val1 = 10;
    return !item.buyOnce ? val1 : Math.Min(val1, item.stack);
  }

  public static bool CanBulkBuy(Item item)
  {
    return (item.isAShopItem ? 1 : (item.buyOnce ? 1 : 0)) != 0 && ItemSlot.ShiftInUse;
  }

  public static int GetBulkCraftAmount(Item item)
  {
    int val1 = item.maxStack / item.stack;
    if (val1 < 1)
      val1 = 1;
    return Math.Min(val1, 10);
  }

  public static int EstimateDisplayStack(Item item)
  {
    int num = item.buyOnce ? 1 : item.stack;
    if (ItemSlot.CanBulkBuy(item))
    {
      int bulkBuyAmount = ItemSlot.GetBulkBuyAmount(item);
      return num * bulkBuyAmount;
    }
    return Main.TryingToBulkCraft() && (item.tooltipContext == 22 && item.tooltipSlot == 0 || item.tooltipContext == 42 || item.tooltipContext == 41) ? ItemSlot.GetBulkCraftAmount(item) * item.stack : num;
  }

  public static void MouseHover(Item[] inv, int context = 0, int slot = 0)
  {
    if (context == 6 && Main.hoverItemName == null)
      Main.hoverItemName = Lang.inter[3].Value;
    if (!inv[slot].IsAir)
    {
      ItemSlot._customCurrencyForSavings = inv[slot].shopSpecialCurrency;
      Main.hoverItemName = inv[slot].Name;
      if (inv[slot].stack > 1)
        Main.hoverItemName = $"{Main.hoverItemName} ({(object) inv[slot].stack})";
      Main.HoverItem = inv[slot].Clone();
      Main.HoverItem.tooltipContext = context;
      Main.HoverItem.tooltipSlot = inv[slot].tooltipSlot;
      switch (context)
      {
        case 8:
          Main.HoverItem.wornArmor = true;
          break;
        case 9:
        case 11:
          Main.HoverItem.social = true;
          break;
        case 15:
          Main.HoverItem.buy = true;
          break;
      }
    }
    else
    {
      if (context == 10 || context == 11 || context == 24)
        Main.hoverItemName = Lang.inter[9].Value;
      if (context == 11)
        Main.hoverItemName = $"{Lang.inter[11].Value} {Main.hoverItemName}";
      if (context == 8 || context == 9 || context == 23 || context == 26)
      {
        if (slot == 0 || slot == 10 || context == 26)
          Main.hoverItemName = Lang.inter[12].Value;
        else if (slot == 1 || slot == 11)
          Main.hoverItemName = Lang.inter[13].Value;
        else if (slot == 2 || slot == 12)
          Main.hoverItemName = Lang.inter[14].Value;
        else if (slot >= 10)
          Main.hoverItemName = $"{Lang.inter[11].Value} {Main.hoverItemName}";
      }
      if (context == 12 || context == 25 || context == 27 || context == 33)
        Main.hoverItemName = Lang.inter[57].Value;
      if (context == 16 /*0x10*/)
        Main.hoverItemName = Lang.inter[90].Value;
      if (context == 17 || context == 39)
        Main.hoverItemName = Lang.inter[91].Value;
      if (context == 19)
        Main.hoverItemName = Lang.inter[92].Value;
      if (context == 18)
        Main.hoverItemName = Lang.inter[93].Value;
      if (context == 20)
        Main.hoverItemName = Lang.inter[94].Value;
      if (context != 38)
        return;
      Main.hoverItemName = Language.GetTextValue("UI.DisplayDollWeapon");
    }
  }

  public static void ResetInventoryStateCounters() => ItemSlot.dyeSwapCounter = 0;

  public static void SwapEquip(ref Item inv, int context = 0)
  {
    ItemSlot.singleSlotArray[0] = inv;
    ItemSlot.SwapEquip(ItemSlot.singleSlotArray, context, 0);
    inv = ItemSlot.singleSlotArray[0];
  }

  public static bool CanSwapEquip(Item item)
  {
    return !item.IsAir && (item.dye > (byte) 0 || Main.projHook[item.shoot] || item.mountType != -1 || item.buffType > 0 && (Main.lightPet[item.buffType] || Main.vanityPet[item.buffType]) || item.headSlot != -1 || item.bodySlot != -1 || item.legSlot != -1 || item.accessory);
  }

  public static void SwapEquip(Item[] inv, int context, int slot)
  {
    Player player = Main.player[Main.myPlayer];
    if (inv[slot].IsAir)
      return;
    if (inv[slot].dye > (byte) 0)
    {
      bool success;
      int targetSlot;
      inv[slot] = ItemSlot.DyeSwap(inv[slot], out success, out targetSlot);
      if (success)
      {
        Main.EquipPageSelected = 0;
        AchievementsHelper.HandleOnEquip(player, inv[slot], 12);
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.dye, 12, targetSlot);
      }
    }
    else if (Main.projHook[inv[slot].shoot])
    {
      bool success;
      inv[slot] = ItemSlot.EquipSwap(inv[slot], player.miscEquips, 4, out success);
      if (success)
      {
        Main.EquipPageSelected = 2;
        AchievementsHelper.HandleOnEquip(player, player.miscEquips[4], 16 /*0x10*/);
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.miscEquips, 16 /*0x10*/, 4);
      }
    }
    else if (inv[slot].mountType != -1 && !MountID.Sets.Cart[inv[slot].mountType])
    {
      bool success;
      inv[slot] = ItemSlot.EquipSwap(inv[slot], player.miscEquips, 3, out success);
      if (success)
      {
        Main.EquipPageSelected = 2;
        AchievementsHelper.HandleOnEquip(player, inv[slot], 17);
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.miscEquips, 17, 3);
      }
    }
    else if (inv[slot].mountType != -1 && MountID.Sets.Cart[inv[slot].mountType])
    {
      bool success;
      inv[slot] = ItemSlot.EquipSwap(inv[slot], player.miscEquips, 2, out success);
      if (success)
      {
        Main.EquipPageSelected = 2;
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.miscEquips, 18, 2);
      }
    }
    else if (inv[slot].buffType > 0 && Main.lightPet[inv[slot].buffType])
    {
      bool success;
      inv[slot] = ItemSlot.EquipSwap(inv[slot], player.miscEquips, 1, out success);
      if (success)
      {
        Main.EquipPageSelected = 2;
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.miscEquips, 20, 1);
      }
    }
    else if (inv[slot].buffType > 0 && Main.vanityPet[inv[slot].buffType])
    {
      bool success;
      inv[slot] = ItemSlot.EquipSwap(inv[slot], player.miscEquips, 0, out success);
      if (success)
      {
        Main.EquipPageSelected = 2;
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.miscEquips, 19, 0);
      }
    }
    else
    {
      int num = inv[slot].accessory ? 10 : (inv[slot].vanity ? 9 : 8);
      bool success;
      int targetSlot;
      inv[slot] = ItemSlot.ArmorSwap(inv[slot], out success, out targetSlot);
      if (success)
      {
        Main.EquipPageSelected = 0;
        Item obj = player.armor[targetSlot];
        AchievementsHelper.HandleOnEquip(player, obj, num);
        ItemSlot.DisplayTransfer_TwoWay(inv, context, slot, player.armor, num, targetSlot);
      }
    }
    if (context != 3 || Main.netMode != 1)
      return;
    NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) slot);
  }

  public static void DisplayTransfer_GetItem(Item[] arrayFrom, int fromContext, int fromSlot)
  {
    Vector2 position1 = UILinkPointNavigator.GetPosition(ItemSlot.GetGamepadPointForSlot(arrayFrom, fromContext, fromSlot));
    foreach (PlayerGetItemLogger.GetItemLoggerEntry entry in Player.GetItemLogger.Entries)
    {
      Vector2 position2 = UILinkPointNavigator.GetPosition(ItemSlot.GetGamepadPointForSlot(entry.TargetArray, entry.TargetItemSlotContext, entry.TargetSlot));
      int timeToAnimate = ItemSlot.GetTimeToAnimate(position1, position2);
      Item target = entry.TargetArray[entry.TargetSlot];
      if (ItemSlot.TryDisplayTransfer(ref position1, ref position2, target, entry.Stack, timeToAnimate) & target.stack == entry.Stack)
        ItemSlot.AddCooldown(entry.TargetItemSlotContext, entry.TargetSlot, timeToAnimate);
    }
  }

  private static int GetTimeToAnimate(Vector2 startPosition, Vector2 endPosition)
  {
    int num = (int) Vector2.Distance(startPosition, endPosition) / 20;
    if (num > 15)
      num = 15;
    return 15 + num;
  }

  public static void DisplayTransfer_OneWay(
    Item[] arrayFrom,
    int fromContext,
    int fromSlot,
    Item[] arrayTo,
    int toContext,
    int toSlot,
    int stackSize = 1)
  {
    int gamepadPointForSlot1 = ItemSlot.GetGamepadPointForSlot(arrayFrom, fromContext, fromSlot);
    int gamepadPointForSlot2 = ItemSlot.GetGamepadPointForSlot(arrayTo, toContext, toSlot);
    Vector2 position1 = UILinkPointNavigator.GetPosition(gamepadPointForSlot1);
    Vector2 position2 = UILinkPointNavigator.GetPosition(gamepadPointForSlot2);
    int timeToAnimate = ItemSlot.GetTimeToAnimate(position1, position2);
    if (!(ItemSlot.TryDisplayTransfer(ref position1, ref position2, arrayTo[toSlot], stackSize, timeToAnimate) & arrayTo[toSlot].stack == stackSize))
      return;
    ItemSlot.AddCooldown(toContext, toSlot, timeToAnimate);
  }

  public static void DisplayTransfer_TwoWay(
    Item[] arrayFrom,
    int fromContext,
    int fromSlot,
    Item toItem,
    int toContext)
  {
    int gamepadPointForSlot1 = ItemSlot.GetGamepadPointForSlot(arrayFrom, fromContext, fromSlot);
    int gamepadPointForSlot2 = ItemSlot.GetGamepadPointForSlot(ItemSlot._dirtyHack, toContext, 0);
    Vector2 position1 = UILinkPointNavigator.GetPosition(gamepadPointForSlot1);
    Vector2 position2 = UILinkPointNavigator.GetPosition(gamepadPointForSlot2);
    int timeToAnimate = ItemSlot.GetTimeToAnimate(position1, position2);
    if (ItemSlot.TryDisplayTransfer(ref position1, ref position2, toItem, toItem.stack, timeToAnimate))
      ItemSlot.AddCooldown(toContext, 0, timeToAnimate);
    if (!ItemSlot.TryDisplayTransfer(ref position2, ref position1, arrayFrom[fromSlot], arrayFrom[fromSlot].stack, timeToAnimate))
      return;
    ItemSlot.AddCooldown(fromContext, fromSlot, timeToAnimate);
  }

  public static void DisplayTransfer_TwoWay(
    Item[] arrayFrom,
    int fromContext,
    int fromSlot,
    Item[] arrayTo,
    int toContext,
    int toSlot)
  {
    int gamepadPointForSlot1 = ItemSlot.GetGamepadPointForSlot(arrayFrom, fromContext, fromSlot);
    int gamepadPointForSlot2 = ItemSlot.GetGamepadPointForSlot(arrayTo, toContext, toSlot);
    Vector2 position1 = UILinkPointNavigator.GetPosition(gamepadPointForSlot1);
    Vector2 position2 = UILinkPointNavigator.GetPosition(gamepadPointForSlot2);
    int timeToAnimate = ItemSlot.GetTimeToAnimate(position1, position2);
    if (ItemSlot.TryDisplayTransfer(ref position1, ref position2, arrayTo[toSlot], arrayTo[toSlot].stack, timeToAnimate))
      ItemSlot.AddCooldown(toContext, toSlot, timeToAnimate);
    if (!ItemSlot.TryDisplayTransfer(ref position2, ref position1, arrayFrom[fromSlot], arrayFrom[fromSlot].stack, timeToAnimate))
      return;
    ItemSlot.AddCooldown(fromContext, fromSlot, timeToAnimate);
  }

  private static void AddCooldown(int context, int slot, int time)
  {
    ItemSlot._nextTickDrawAvailable[new ItemSlot.ItemDisplayKey()
    {
      Slot = slot,
      Context = context
    }] = (ulong) ((long) Main.EverLastingTicker + (long) time);
  }

  private static bool TryDisplayTransfer(
    ref Vector2 pointPositionFrom,
    ref Vector2 pointPositionTo,
    Item toItem,
    int stackSize,
    int animationTime)
  {
    return false;
  }

  public static bool CanEquipBothAccessories(Item acc1, Item acc2)
  {
    return acc1.type != acc2.type && (acc1.wingSlot <= (sbyte) 0 || acc2.wingSlot <= (sbyte) 0);
  }

  public static bool HasIncompatibleAccessory(
    Item newAcc,
    ArraySegment<Item> accessories,
    out int collisionSlot)
  {
    for (int index = 0; index < accessories.Count; ++index)
    {
      if (!ItemSlot.CanEquipBothAccessories(accessories.Array[index + accessories.Offset], newAcc))
      {
        collisionSlot = index + accessories.Offset;
        return true;
      }
    }
    collisionSlot = -1;
    return false;
  }

  public static bool HasSameItemInSlot(Item newItem, ArraySegment<Item> items)
  {
    if (newItem.IsAir)
      return false;
    for (int index = 0; index < items.Count; ++index)
    {
      if (items.Array[index + items.Offset].type == newItem.type)
        return true;
    }
    return false;
  }

  public static bool CanEquipAccessoryInSlot(Item newAcc, ArraySegment<Item> accessories, int slot)
  {
    int collisionSlot;
    return !ItemSlot.HasIncompatibleAccessory(newAcc, accessories, out collisionSlot) || slot == collisionSlot;
  }

  private static Item DyeSwap(Item item, out bool success, out int targetSlot)
  {
    targetSlot = -1;
    success = false;
    if (item.dye <= (byte) 0)
      return item;
    Player player = Main.player[Main.myPlayer];
    while (!player.IsItemSlotUnlockedAndUsable(ItemSlot.dyeSwapCounter))
      ItemSlot.dyeSwapCounter = (ItemSlot.dyeSwapCounter + 1) % 10;
    for (int slot = 0; slot < 10; ++slot)
    {
      if (player.IsItemSlotUnlockedAndUsable(slot) && player.dye[slot].IsAir)
      {
        ItemSlot.dyeSwapCounter = slot;
        break;
      }
    }
    SoundEngine.PlaySound(7);
    Utils.Swap<Item>(ref item, ref player.dye[ItemSlot.dyeSwapCounter]);
    targetSlot = ItemSlot.dyeSwapCounter;
    ItemSlot.dyeSwapCounter = (ItemSlot.dyeSwapCounter + 1) % 10;
    success = true;
    return item;
  }

  private static Item ArmorSwap(Item item, out bool success, out int targetSlot)
  {
    targetSlot = -1;
    success = false;
    if (item.stack < 1 || item.headSlot == -1 && item.bodySlot == -1 && item.legSlot == -1 && !item.accessory)
      return item;
    Player player = Main.player[Main.myPlayer];
    int num = item.vanity ? 10 : 0;
    if (item.headSlot != -1 || item.bodySlot != -1 || item.legSlot != -1)
    {
      if (ItemSlot.HasSameItemInSlot(item, new ArraySegment<Item>(Main.LocalPlayer.armor, 0, 3)) || ItemSlot.HasSameItemInSlot(item, new ArraySegment<Item>(Main.LocalPlayer.armor, 10, 3)))
        return item;
    }
    else if (item.accessory && (item.vanity ? (ItemSlot.HasSameItemInSlot(item, new ArraySegment<Item>(player.armor, 3, 7)) ? 1 : 0) : (ItemSlot.HasSameItemInSlot(item, new ArraySegment<Item>(player.armor, 13, 7)) ? 1 : 0)) != 0)
      return item;
    if (item.headSlot != -1)
      targetSlot = num;
    else if (item.bodySlot != -1)
      targetSlot = num + 1;
    else if (item.legSlot != -1)
      targetSlot = num + 2;
    else if (item.accessory)
    {
      ArraySegment<Item> accessories = new ArraySegment<Item>(player.armor, 3 + num, 7);
      if (ItemSlot.HasIncompatibleAccessory(item, accessories, out targetSlot))
      {
        if (!player.IsItemSlotUnlockedAndUsable(targetSlot))
          return item;
      }
      else
      {
        targetSlot = accessories.Offset;
        for (int index = 0; index < accessories.Count; ++index)
        {
          int slot = index + accessories.Offset;
          if (player.IsItemSlotUnlockedAndUsable(slot) && accessories.Array[slot].IsAir)
          {
            targetSlot = slot;
            break;
          }
        }
      }
    }
    if (targetSlot == -1)
      return item;
    item.favorited = false;
    SoundEngine.PlaySound(7);
    Utils.Swap<Item>(ref item, ref player.armor[targetSlot]);
    success = true;
    return item;
  }

  private static Item EquipSwap(Item item, Item[] inv, int slot, out bool success)
  {
    success = false;
    Player player = Main.player[Main.myPlayer];
    item.favorited = false;
    Item obj = inv[slot].Clone();
    inv[slot] = item.Clone();
    SoundEngine.PlaySound(7);
    success = true;
    return obj;
  }

  public static void DrawMoney(
    SpriteBatch sb,
    string text,
    float shopx,
    float shopy,
    int[] coinsArray,
    bool horizontal = false,
    bool fromSavings = false)
  {
    Utils.DrawBorderStringFourWay(sb, FontAssets.MouseText.Value, text, shopx, shopy + 40f, Color.White * ((float) Main.mouseTextColor / (float) byte.MaxValue), Color.Black, Vector2.Zero);
    CoinSlot.CoinDrawState drawState = new CoinSlot.CoinDrawState();
    drawState.coinAnimFrame = 0;
    drawState.coinYOffset = 0.0f;
    drawState.stackTextScale = 1f;
    if (horizontal)
    {
      for (int slot = 0; slot < 4; ++slot)
      {
        Main.instance.LoadItem(74 - slot);
        if (slot == 0)
        {
          int coins = coinsArray[3 - slot];
        }
        int count = coinsArray[3 - slot];
        if (count > 999)
          count = 999;
        if (fromSavings)
          CoinSlot.UpdateSavings(slot, count, out drawState);
        Vector2 vector2 = new Vector2((float) ((double) shopx + (double) ChatManager.GetStringSize(FontAssets.MouseText.Value, text, Vector2.One).X + (double) (24 * slot) + 45.0), shopy + 50f);
        double num = (double) CoinSlot.DrawItemCoin(sb, vector2 + new Vector2(0.0f, -drawState.coinYOffset), 74 - slot, drawState.coinAnimFrame, 1f, 1024f, Color.White);
        Utils.DrawBorderStringFourWay(sb, FontAssets.ItemStack.Value, count.ToString(), vector2.X - 11f, vector2.Y + (float) FontAssets.ItemStack.Value.LineSpacing * 0.75f, Color.White, Color.Black, new Vector2(0.0f, (float) FontAssets.ItemStack.Value.LineSpacing), 0.75f * drawState.stackTextScale);
      }
    }
    else
    {
      for (int slot = 0; slot < 4; ++slot)
      {
        Main.instance.LoadItem(74 - slot);
        int num1 = slot != 0 || coinsArray[3 - slot] <= 99 ? 0 : -6;
        int count = coinsArray[3 - slot];
        if (count > 999)
          count = 999;
        if (fromSavings)
          CoinSlot.UpdateSavings(slot, count, out drawState);
        double num2 = (double) CoinSlot.DrawItemCoin(sb, new Vector2(shopx + 11f + (float) (24 * slot), shopy + 75f - drawState.coinYOffset), 74 - slot, drawState.coinAnimFrame, 1f, 1024f, Color.White);
        Utils.DrawBorderStringFourWay(sb, FontAssets.ItemStack.Value, count.ToString(), shopx + (float) (24 * slot) + (float) num1, (float) ((double) shopy + 75.0 + (double) FontAssets.ItemStack.Value.LineSpacing * 0.75), Color.White, Color.Black, new Vector2(0.0f, (float) FontAssets.ItemStack.Value.LineSpacing), 0.75f * drawState.stackTextScale);
      }
    }
  }

  public static void DrawSavings(SpriteBatch sb, float shopx, float shopy, bool horizontal = false)
  {
    Player player = Main.player[Main.myPlayer];
    if (ItemSlot._customCurrencyForSavings != -1)
    {
      CustomCurrencyManager.DrawSavings(sb, ItemSlot._customCurrencyForSavings, shopx, shopy, horizontal);
    }
    else
    {
      bool overFlowing;
      long num1 = Utils.CoinsCount(out overFlowing, player.bank.item);
      long num2 = Utils.CoinsCount(out overFlowing, player.bank2.item);
      long num3 = Utils.CoinsCount(out overFlowing, player.bank3.item);
      long num4 = Utils.CoinsCount(out overFlowing, player.bank4.item);
      long count = Utils.CoinsCombineStacks(out overFlowing, num1, num2, num3, num4);
      if (count <= 0L)
        return;
      Texture2D itemTexture1;
      Rectangle itemFrame1;
      Main.GetItemDrawFrame(4076, out itemTexture1, out itemFrame1);
      Texture2D itemTexture2;
      Rectangle itemFrame2;
      Main.GetItemDrawFrame(3813, out itemTexture2, out itemFrame2);
      Texture2D itemTexture3;
      Main.GetItemDrawFrame(346, out itemTexture3, out Rectangle _);
      Texture2D itemTexture4;
      Main.GetItemDrawFrame(87, out itemTexture4, out Rectangle _);
      if (num4 > 0L)
        sb.Draw(itemTexture1, Utils.CenteredRectangle(new Vector2(shopx + 70f, shopy + 45f), itemFrame1.Size() * 0.65f), new Rectangle?(), Color.White);
      if (num3 > 0L)
        sb.Draw(itemTexture2, Utils.CenteredRectangle(new Vector2(shopx + 92f, shopy + 45f), itemFrame2.Size() * 0.65f), new Rectangle?(), Color.White);
      if (num2 > 0L)
        sb.Draw(itemTexture3, Utils.CenteredRectangle(new Vector2(shopx + 80f, shopy + 50f), itemTexture3.Size() * 0.65f), new Rectangle?(), Color.White);
      if (num1 > 0L)
        sb.Draw(itemTexture4, Utils.CenteredRectangle(new Vector2(shopx + 70f, shopy + 60f), itemTexture4.Size() * 0.65f), new Rectangle?(), Color.White);
      ItemSlot.DrawMoney(sb, Lang.inter[66].Value, shopx, shopy, Utils.CoinsSplit(count), horizontal, true);
    }
  }

  public static void GetItemLight(
    ref Color currentColor,
    Item item,
    bool outInTheWorld = false,
    float lightScalar = 1f)
  {
    float scale = 1f;
    ItemSlot.GetItemLight(ref currentColor, ref scale, item, outInTheWorld, lightScalar);
  }

  public static void GetItemLight(
    ref Color currentColor,
    int type,
    bool outInTheWorld = false,
    float lightScalar = 1f)
  {
    float scale = 1f;
    ItemSlot.GetItemLight(ref currentColor, ref scale, type, outInTheWorld, lightScalar);
  }

  public static void GetItemLight(
    ref Color currentColor,
    ref float scale,
    Item item,
    bool outInTheWorld = false,
    float lightScalar = 1f)
  {
    ItemSlot.GetItemLight(ref currentColor, ref scale, item.type, outInTheWorld, lightScalar);
  }

  public static Color GetItemLight(
    ref Color currentColor,
    ref float scale,
    int type,
    bool outInTheWorld = false,
    float lightScalar = 1f)
  {
    if (type < 0 || type > (int) ItemID.Count)
      return currentColor;
    if (type == 662 || type == 663 || type == 5444 || type == 5450 || type == 5643)
    {
      currentColor.R = (byte) Main.DiscoR;
      currentColor.G = (byte) Main.DiscoG;
      currentColor.B = (byte) Main.DiscoB;
      currentColor.A = byte.MaxValue;
      currentColor *= lightScalar;
    }
    if (type == 5128)
    {
      currentColor.R = (byte) Main.DiscoR;
      currentColor.G = (byte) Main.DiscoG;
      currentColor.B = (byte) Main.DiscoB;
      currentColor.A = byte.MaxValue;
      currentColor *= lightScalar;
    }
    else if (ItemID.Sets.ItemIconPulse[type])
    {
      scale = Main.essScale;
      currentColor.R = (byte) ((double) currentColor.R * (double) scale);
      currentColor.G = (byte) ((double) currentColor.G * (double) scale);
      currentColor.B = (byte) ((double) currentColor.B * (double) scale);
      currentColor.A = (byte) ((double) currentColor.A * (double) scale);
      currentColor *= lightScalar;
    }
    else if (type == 58 || type == 184 || type == 4143)
    {
      scale = (float) ((double) Main.essScale * 0.25 + 0.75);
      currentColor.R = (byte) ((double) currentColor.R * (double) scale);
      currentColor.G = (byte) ((double) currentColor.G * (double) scale);
      currentColor.B = (byte) ((double) currentColor.B * (double) scale);
      currentColor.A = (byte) ((double) currentColor.A * (double) scale);
      currentColor *= lightScalar;
    }
    return currentColor;
  }

  public static void DrawRadialCircular(
    SpriteBatch sb,
    Vector2 position,
    Player.SelectionRadial radial,
    Item[] items)
  {
    ItemSlot.CircularRadialOpacity = MathHelper.Clamp(ItemSlot.CircularRadialOpacity + (!PlayerInput.UsingGamepad || !PlayerInput.Triggers.Current.RadialHotbar ? -0.15f : 0.25f), 0.0f, 1f);
    if ((double) ItemSlot.CircularRadialOpacity == 0.0)
      return;
    Texture2D texture2D1 = TextureAssets.HotbarRadial[2].Value;
    float num1 = ItemSlot.CircularRadialOpacity * 0.9f;
    float num2 = ItemSlot.CircularRadialOpacity * 1f;
    float num3 = (float) Main.mouseTextColor / (float) byte.MaxValue;
    Color color = Color.White * ((float) (1.0 - (1.0 - (double) num3) * (1.0 - (double) num3)) * 0.785f) * num1;
    Texture2D texture2D2 = TextureAssets.HotbarRadial[1].Value;
    float num4 = 6.28318548f / (float) radial.RadialCount;
    float num5 = -1.57079637f;
    for (int index = 0; index < radial.RadialCount; ++index)
    {
      int binding = radial.Bindings[index];
      Vector2 vector2 = new Vector2(150f, 0.0f).RotatedBy((double) num5 + (double) num4 * (double) index) * num2;
      float num6 = 0.85f;
      if (radial.SelectedBinding == index)
        num6 = 1.7f;
      sb.Draw(texture2D2, position + vector2, new Rectangle?(), color * num6, 0.0f, texture2D2.Size() / 2f, num2 * num6, SpriteEffects.None, 0.0f);
      if (binding != -1)
      {
        double inventoryScale = (double) Main.inventoryScale;
        Main.inventoryScale = num2 * num6;
        ItemSlot.Draw(sb, items, 14, binding, position + vector2 + new Vector2(-26f * num2 * num6), Color.White);
        Main.inventoryScale = (float) inventoryScale;
      }
    }
  }

  public static void DrawRadialQuicks(SpriteBatch sb, Vector2 position)
  {
    ItemSlot.QuicksRadialOpacity = MathHelper.Clamp(ItemSlot.QuicksRadialOpacity + (!PlayerInput.UsingGamepad || !PlayerInput.Triggers.Current.RadialQuickbar ? -0.15f : 0.25f), 0.0f, 1f);
    if ((double) ItemSlot.QuicksRadialOpacity == 0.0)
      return;
    Player player = Main.player[Main.myPlayer];
    Texture2D texture2D = TextureAssets.HotbarRadial[2].Value;
    Texture2D texture = TextureAssets.QuicksIcon.Value;
    float num1 = ItemSlot.QuicksRadialOpacity * 0.9f;
    float num2 = ItemSlot.QuicksRadialOpacity * 1f;
    float num3 = (float) Main.mouseTextColor / (float) byte.MaxValue;
    Color color = Color.White * ((float) (1.0 - (1.0 - (double) num3) * (1.0 - (double) num3)) * 0.785f) * num1;
    float num4 = 6.28318548f / (float) player.QuicksRadial.RadialCount;
    float num5 = -1.57079637f;
    Item obj1 = player.QuickHeal_GetItemToUse();
    Item obj2 = player.QuickMana_GetItemToUse();
    Item obj3 = (Item) null;
    Item obj4 = (Item) null;
    if (obj1 == null)
    {
      obj1 = new Item();
      obj1.SetDefaults(28);
    }
    if (obj2 == null)
    {
      obj2 = new Item();
      obj2.SetDefaults(110);
    }
    if (obj3 == null)
    {
      obj3 = new Item();
      obj3.SetDefaults(292);
    }
    if (obj4 == null)
    {
      obj4 = new Item();
      obj4.SetDefaults(2428);
    }
    for (int index = 0; index < player.QuicksRadial.RadialCount; ++index)
    {
      Item inv = obj4;
      if (index == 1)
        inv = obj1;
      if (index == 2)
        inv = obj3;
      if (index == 3)
        inv = obj2;
      int binding = player.QuicksRadial.Bindings[index];
      Vector2 vector2 = new Vector2(120f, 0.0f).RotatedBy((double) num5 + (double) num4 * (double) index) * num2;
      float num6 = 0.85f;
      if (player.QuicksRadial.SelectedBinding == index)
        num6 = 1.7f;
      sb.Draw(texture2D, position + vector2, new Rectangle?(), color * num6, 0.0f, texture2D.Size() / 2f, (float) ((double) num2 * (double) num6 * 1.2999999523162842), SpriteEffects.None, 0.0f);
      double inventoryScale = (double) Main.inventoryScale;
      Main.inventoryScale = num2 * num6;
      ItemSlot.Draw(sb, ref inv, 14, position + vector2 + new Vector2(-26f * num2 * num6), Color.White);
      Main.inventoryScale = (float) inventoryScale;
      sb.Draw(texture, position + vector2 + new Vector2(34f, 20f) * 0.85f * num2 * num6, new Rectangle?(), color * num6, 0.0f, texture2D.Size() / 2f, (float) ((double) num2 * (double) num6 * 1.2999999523162842), SpriteEffects.None, 0.0f);
    }
  }

  public static void DrawRadialDpad(SpriteBatch sb, Vector2 position)
  {
    if (!PlayerInput.UsingGamepad || !PlayerInput.CurrentProfile.UsingDpadHotbar())
      return;
    Player player = Main.player[Main.myPlayer];
    if (player.chest != -1)
      return;
    Texture2D texture2D = TextureAssets.HotbarRadial[0].Value;
    float num = (float) Main.mouseTextColor / (float) byte.MaxValue;
    Color color = Color.White * ((float) (1.0 - (1.0 - (double) num) * (1.0 - (double) num)) * 0.785f);
    sb.Draw(texture2D, position, new Rectangle?(), color, 0.0f, texture2D.Size() / 2f, Main.inventoryScale, SpriteEffects.None, 0.0f);
    for (int index = 0; index < 4; ++index)
    {
      int binding = player.DpadRadial.Bindings[index];
      if (binding != -1)
        ItemSlot.Draw(sb, player.inventory, 14, binding, position + new Vector2((float) (texture2D.Width / 3), 0.0f).RotatedBy(1.5707963705062866 * (double) index - 1.5707963705062866) + new Vector2(-26f * Main.inventoryScale), Color.White);
    }
  }

  public static string GetGamepadInstructions(int context = 0)
  {
    return ItemSlot.GetGamepadInstructions(ItemSlot.singleSlotArray, context);
  }

  public static string GetGamepadInstructions(ref Item inv, int context = 0)
  {
    ItemSlot.singleSlotArray[0] = inv;
    string gamepadInstructions = ItemSlot.GetGamepadInstructions(ItemSlot.singleSlotArray, context);
    inv = ItemSlot.singleSlotArray[0];
    return gamepadInstructions;
  }

  public static bool CanExecuteCommand() => PlayerInput.AllowExecutionOfGamepadInstructions;

  public static string GetGamepadInstructions(Item[] inv, int context = 0, int slot = 0)
  {
    Player player = Main.player[Main.myPlayer];
    string s = "";
    if (inv == null || inv[slot] == null || Main.mouseItem == null)
      return s;
    if (context == 0 || context == 1 || context == 2)
    {
      if (inv[slot].type > 0 && inv[slot].stack > 0)
      {
        string str;
        if (Main.mouseItem.type > 0)
        {
          str = s + PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          if (inv[slot].type == Main.mouseItem.type && Main.mouseItem.stack < inv[slot].maxStack && inv[slot].maxStack > 1)
            str += PlayerInput.BuildCommand(Lang.misc[55].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
        }
        else
        {
          if (context == 0 && player.chest == -1 && PlayerInput.AllowExecutionOfGamepadInstructions)
            player.DpadRadial.ChangeBinding(slot);
          str = s + PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          if (inv[slot].maxStack > 1)
            str += PlayerInput.BuildCommand(Lang.misc[55].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
        }
        if (ItemID.Sets.OpenableBag[inv[slot].type])
        {
          str += PlayerInput.BuildCommand(Language.GetTextValue("UI.ActionOpen"), PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            ItemSlot.TryOpenContainer(inv, context, slot, player);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        else if (ItemID.Sets.HasItemSwap[inv[slot].type])
        {
          str += PlayerInput.BuildCommand(Language.GetTextValue("UI.ActionChangeType"), PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            ItemSlot.TryItemSwap(inv[slot]);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        else if (inv[slot].stack == 1 && inv[slot].CanBeEquipped())
        {
          str += PlayerInput.BuildCommand(Lang.misc[67].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            ItemSlot.SwapEquip(inv, context, slot);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        s = str + PlayerInput.BuildCommand(Lang.misc[83].Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartCursor"]);
        if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartCursor)
        {
          inv[slot].favorited = !inv[slot].favorited;
          PlayerInput.LockGamepadButtons("SmartCursor");
          PlayerInput.SettingsForUI.TryRevertingToMouseMode();
        }
      }
      else if (Main.mouseItem.type > 0)
        s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
    }
    if (context == 3 || context == 4 || context == 32 /*0x20*/)
    {
      if (inv[slot].type > 0 && inv[slot].stack > 0)
      {
        if (Main.mouseItem.type > 0)
        {
          s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          if (inv[slot].type == Main.mouseItem.type && Main.mouseItem.stack < inv[slot].maxStack && inv[slot].maxStack > 1)
            s += PlayerInput.BuildCommand(Lang.misc[55].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
        }
        else
        {
          s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          if (inv[slot].maxStack > 1)
            s += PlayerInput.BuildCommand(Lang.misc[55].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
        }
        if (inv[slot].stack == 1 && inv[slot].CanBeEquipped())
        {
          s += PlayerInput.BuildCommand(Lang.misc[67].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            ItemSlot.SwapEquip(inv, context, slot);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        if (context == 32 /*0x20*/)
        {
          s += PlayerInput.BuildCommand(Lang.misc[83].Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartCursor"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartCursor)
          {
            inv[slot].favorited = !inv[slot].favorited;
            PlayerInput.LockGamepadButtons("SmartCursor");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
      }
      else if (Main.mouseItem.type > 0)
        s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
    }
    if (context == 15)
    {
      if (inv[slot].type > 0 && inv[slot].stack > 0)
      {
        if (Main.mouseItem.type > 0)
        {
          if (inv[slot].type == Main.mouseItem.type && Main.mouseItem.stack < inv[slot].maxStack && inv[slot].maxStack > 1)
            s += PlayerInput.BuildCommand(Lang.misc[91].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
        }
        else
          s += PlayerInput.BuildCommand(Lang.misc[90].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"], PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
      }
      else if (Main.mouseItem.type > 0)
        s += PlayerInput.BuildCommand(Lang.misc[92].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
    }
    if (context == 8 || context == 9 || context == 10 || context == 11 || context == 16 /*0x10*/ || context == 17 || context == 19 || context == 20)
    {
      if (inv[slot].type > 0 && inv[slot].stack > 0)
      {
        if (Main.mouseItem.type > 0)
        {
          if (Main.mouseItem.stack == 1 && Main.mouseItem.CanBeEquipped())
            s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        }
        else
          s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        if (context == 10)
        {
          bool flag = player.hideVisibleAccessory[slot];
          s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            player.hideVisibleAccessory[slot] = !player.hideVisibleAccessory[slot];
            SoundEngine.PlaySound(12);
            if (Main.netMode == 1)
              NetMessage.SendData(4, number: Main.myPlayer);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        if ((context == 16 /*0x10*/ || context == 17 || context == 18 || context == 19 || context == 20) && slot < 2)
        {
          bool flag = player.hideMisc[slot];
          s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            if (slot == 0)
              player.TogglePet();
            if (slot == 1)
              player.ToggleLight();
            SoundEngine.PlaySound(12);
            if (Main.netMode == 1)
              NetMessage.SendData(4, number: Main.myPlayer);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
      }
      else
      {
        if (Main.mouseItem.type > 0 && Main.mouseItem.CanBeEquipped())
          s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        if (context == 10)
        {
          bool flag = player.hideVisibleAccessory[slot];
          s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            player.hideVisibleAccessory[slot] = !player.hideVisibleAccessory[slot];
            SoundEngine.PlaySound(12);
            if (Main.netMode == 1)
              NetMessage.SendData(4, number: Main.myPlayer);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
        if ((context == 16 /*0x10*/ || context == 17 || context == 18 || context == 19 || context == 20) && slot < 2)
        {
          bool flag = player.hideMisc[slot];
          s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
          if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
          {
            if (slot == 0)
              player.TogglePet();
            if (slot == 1)
              player.ToggleLight();
            Main.mouseLeftRelease = false;
            SoundEngine.PlaySound(12);
            if (Main.netMode == 1)
              NetMessage.SendData(4, number: Main.myPlayer);
            PlayerInput.LockGamepadButtons("Grapple");
            PlayerInput.SettingsForUI.TryRevertingToMouseMode();
          }
        }
      }
    }
    if (context == 12 || context == 25 || context == 27 || context == 33)
    {
      if (inv[slot].type > 0 && inv[slot].stack > 0)
      {
        if (Main.mouseItem.type > 0)
        {
          if (Main.mouseItem.dye > (byte) 0)
            s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        }
        else
          s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        if (context == 12 || context == 25 || context == 27 || context == 33)
        {
          int num = -1;
          if (inv == player.dye)
            num = slot;
          if (inv == player.miscDyes)
            num = 10 + slot;
          if (num != -1)
          {
            if (num < 10)
            {
              bool flag = player.hideVisibleAccessory[slot];
              s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
              if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
              {
                player.hideVisibleAccessory[slot] = !player.hideVisibleAccessory[slot];
                SoundEngine.PlaySound(12);
                if (Main.netMode == 1)
                  NetMessage.SendData(4, number: Main.myPlayer);
                PlayerInput.LockGamepadButtons("Grapple");
                PlayerInput.SettingsForUI.TryRevertingToMouseMode();
              }
            }
            else
            {
              bool flag = player.hideMisc[slot];
              s += PlayerInput.BuildCommand(Lang.misc[flag ? 77 : 78].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
              if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
              {
                player.hideMisc[slot] = !player.hideMisc[slot];
                SoundEngine.PlaySound(12);
                if (Main.netMode == 1)
                  NetMessage.SendData(4, number: Main.myPlayer);
                PlayerInput.LockGamepadButtons("Grapple");
                PlayerInput.SettingsForUI.TryRevertingToMouseMode();
              }
            }
          }
        }
      }
      else if (Main.mouseItem.type > 0 && Main.mouseItem.dye > (byte) 0)
        s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
      return s;
    }
    switch (context)
    {
      case 6:
        if (inv[slot].type > 0 && inv[slot].stack > 0)
        {
          if (Main.mouseItem.type > 0)
            s += PlayerInput.BuildCommand(Lang.misc[74].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          else
            s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        }
        else if (Main.mouseItem.type > 0)
          s += PlayerInput.BuildCommand(Lang.misc[74].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        return s;
      case 18:
        if (inv[slot].type > 0 && inv[slot].stack > 0)
        {
          if (Main.mouseItem.type > 0)
          {
            if (Main.mouseItem.dye > (byte) 0)
              s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          }
          else
            s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        }
        else if (Main.mouseItem.type > 0 && Main.mouseItem.dye > (byte) 0)
          s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        bool enabledSuperCart = player.enabledSuperCart;
        string gamepadInstructions = s + PlayerInput.BuildCommand(Language.GetTextValue(!enabledSuperCart ? "UI.EnableSuperCart" : "UI.DisableSuperCart"), PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
        if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
        {
          player.enabledSuperCart = !player.enabledSuperCart;
          SoundEngine.PlaySound(12);
          if (Main.netMode == 1)
            NetMessage.SendData(4, number: Main.myPlayer);
          PlayerInput.LockGamepadButtons("Grapple");
          PlayerInput.SettingsForUI.TryRevertingToMouseMode();
        }
        return gamepadInstructions;
      default:
        if (context == 5 || context == 7)
        {
          bool flag = false;
          if (context == 5)
            flag = Main.mouseItem.CanHavePrefixes() || Main.mouseItem.type == 0;
          if (context == 7)
            flag = Main.mouseItem.material;
          if (inv[slot].type > 0 && inv[slot].stack > 0)
          {
            if (Main.mouseItem.type > 0)
            {
              if (flag)
                s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
            }
            else
              s += PlayerInput.BuildCommand(Lang.misc[54].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
          }
          else if (Main.mouseItem.type > 0 & flag)
            s += PlayerInput.BuildCommand(Lang.misc[65].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        }
        if (!Main.mouseItem.IsAir)
        {
          if (ItemSlot.canQuickDropAt[context])
          {
            s += PlayerInput.BuildCommand(Lang.inter[121].Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartSelect"]);
            if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartSelect)
            {
              player.DropSelectedItem();
              PlayerInput.LockGamepadButtons("SmartSelect");
              PlayerInput.SettingsForUI.TryRevertingToMouseMode();
            }
          }
          else if (player.ItemSpace(Main.mouseItem).CanTakeItemToPersonalInventory)
          {
            s += PlayerInput.BuildCommand(Lang.misc[76].Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartSelect"]);
            if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartSelect)
            {
              Main.mouseItem = player.GetItem(Main.mouseItem, GetItemSettings.ReturnItemShowAsNew);
              PlayerInput.LockGamepadButtons("SmartSelect");
              PlayerInput.SettingsForUI.TryRevertingToMouseMode();
            }
          }
        }
        else
        {
          switch (context)
          {
            case 22:
            case 41:
            case 42:
            case 43:
              bool flag1 = Player.Settings.CraftingGridControl == Player.Settings.CraftingGridMode.Classic;
              s += PlayerInput.BuildCommand(Language.GetTextValue(CraftingUI.CraftingWindowTextKey), PlayerInput.ProfileGamepadUI.KeyStatus["SmartCursor"]);
              if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartCursor)
              {
                if (flag1)
                {
                  NewCraftingUI.Close(true, true);
                  if (UILinkPointNavigator.CurrentPage == 10)
                    UILinkPointNavigator.ChangePage(9);
                  else
                    UILinkPointNavigator.ChangePage(10);
                }
                else
                  NewCraftingUI.ToggleInInventory();
              }
              if (!Main.InGuideCraftMenu && Main.bannerUI.AnyAvailableBanners && context == 22)
              {
                s += PlayerInput.BuildCommand(Language.GetTextValue("UI.CyclePipsToBanners"), PlayerInput.ProfileGamepadUI.KeyStatus["SmartSelect"]);
                if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartSelect)
                {
                  Main.TryChangePipsPage(Main.PipPage.Banners);
                  UILinkPointNavigator.ChangePage(22);
                  PlayerInput.LockGamepadButtons("SmartSelect");
                  break;
                }
                break;
              }
              break;
            case 35:
              string str1 = s + PlayerInput.BuildCommand(Language.GetTextValue("GameUI.BannersWindow"), PlayerInput.ProfileGamepadUI.KeyStatus["SmartCursor"]);
              if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartCursor)
              {
                if (UILinkPointNavigator.CurrentPage == 23)
                  UILinkPointNavigator.ChangePage(22);
                else
                  UILinkPointNavigator.ChangePage(23);
              }
              s = str1 + PlayerInput.BuildCommand(Language.GetTextValue("UI.CyclePipsToCrafting"), PlayerInput.ProfileGamepadUI.KeyStatus["SmartSelect"]);
              if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartSelect)
              {
                Main.TryChangePipsPage(Main.PipPage.Recipes);
                UILinkPointNavigator.ChangePage(9);
                PlayerInput.LockGamepadButtons("SmartSelect");
                break;
              }
              break;
            default:
              ItemSlot.ShiftForcedOn = true;
              ItemSlot.AlternateClickAction? alternateClickAction = ItemSlot.GetAlternateClickAction(inv, context, slot);
              if (alternateClickAction.HasValue)
              {
                s += PlayerInput.BuildCommand(alternateClickAction.Value.gamepadHintText.Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartSelect"]);
                if (ItemSlot.CanDoSimulatedClickAction() && ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.SmartSelect)
                {
                  int num = Main.mouseLeft ? 1 : 0;
                  int cursorOverride = Main.cursorOverride;
                  Main.mouseLeft = true;
                  Main.cursorOverride = alternateClickAction.Value.cursorOverride;
                  ItemSlot.LeftClick(inv, context, slot);
                  Main.cursorOverride = cursorOverride;
                  Main.mouseLeft = num != 0;
                  PlayerInput.LockGamepadButtons("SmartSelect");
                  PlayerInput.SettingsForUI.TryRevertingToMouseMode();
                }
              }
              ItemSlot.ShiftForcedOn = false;
              break;
          }
        }
        if (!ItemSlot.TryEnteringFastUseMode(inv, context, slot, player, ref s))
          ItemSlot.TryEnteringBuildingMode(inv, context, slot, player, ref s);
        return s;
    }
  }

  private static bool CanDoSimulatedClickAction()
  {
    return !PlayerInput.SteamDeckIsUsed || UILinkPointNavigator.InUse;
  }

  private static bool TryEnteringFastUseMode(
    Item[] inv,
    int context,
    int slot,
    Player player,
    ref string s)
  {
    int num = 0;
    if (Main.mouseItem.CanBeQuickUsed)
      num = 1;
    if (num == 0 && Main.mouseItem.stack <= 0 && context == 0 && inv[slot].CanBeQuickUsed)
      num = 2;
    if (num <= 0)
      return false;
    s += PlayerInput.BuildCommand(Language.GetTextValue("UI.QuickUseItem"), PlayerInput.ProfileGamepadUI.KeyStatus["QuickMount"]);
    if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.QuickMount)
    {
      switch (num)
      {
        case 1:
          PlayerInput.TryEnteringFastUseModeForMouseItem();
          break;
        case 2:
          PlayerInput.TryEnteringFastUseModeForInventorySlot(slot);
          break;
      }
    }
    return true;
  }

  private static bool TryEnteringBuildingMode(
    Item[] inv,
    int context,
    int slot,
    Player player,
    ref string s)
  {
    int num = 0;
    if (ItemSlot.IsABuildingItem(Main.mouseItem))
      num = 1;
    if (num == 0 && Main.mouseItem.stack <= 0 && context == 0 && ItemSlot.IsABuildingItem(inv[slot]))
      num = 2;
    if (num > 0)
    {
      Item mouseItem = Main.mouseItem;
      if (num == 1)
        mouseItem = Main.mouseItem;
      if (num == 2)
        mouseItem = inv[slot];
      if (num != 1 || player.ItemSpace(mouseItem).CanTakeItemToPersonalInventory)
      {
        if (mouseItem.damage > 0 && mouseItem.ammo == 0)
          s += PlayerInput.BuildCommand(Lang.misc[60].Value, PlayerInput.ProfileGamepadUI.KeyStatus["QuickMount"]);
        else if (mouseItem.createTile >= 0 || mouseItem.createWall > 0)
          s += PlayerInput.BuildCommand(Lang.misc[61].Value, PlayerInput.ProfileGamepadUI.KeyStatus["QuickMount"]);
        else
          s += PlayerInput.BuildCommand(Lang.misc[63 /*0x3F*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["QuickMount"]);
        if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.QuickMount)
          PlayerInput.EnterBuildingMode();
        return true;
      }
    }
    return false;
  }

  public static string GetQuickCraftGamepadInstructions(Recipe recipe)
  {
    Player localPlayer = Main.LocalPlayer;
    if (!Main.mouseItem.IsAir || !localPlayer.ItemSpace(recipe.createItem).CanTakeItemToPersonalInventory || localPlayer.HasLockedInventory())
      return (string) null;
    if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.Current.Grapple && (Main.stackSplit <= 1 || PlayerInput.Triggers.JustPressed.Grapple))
    {
      if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
        UILinksInitializer.SomeVarsForUILinkers.SequencedCraftingCurrent = Main.recipe[Main.availableRecipe[Main.focusRecipe]];
      ItemSlot.RefreshStackSplitCooldown();
      Main.quickCraftStackSplit = true;
      if (UILinksInitializer.SomeVarsForUILinkers.SequencedCraftingCurrent == Main.recipe[Main.availableRecipe[Main.focusRecipe]])
        CraftingRequests.CraftItem(recipe, quickCraft: true);
    }
    return PlayerInput.BuildCommand(Lang.misc[71].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
  }

  public static string GetCraftSlotGamepadInstructions()
  {
    if (Main.InGuideCraftMenu)
      return "";
    string gamepadInstructions1 = "";
    Player localPlayer = Main.LocalPlayer;
    Recipe recipe = Main.recipe[Main.availableRecipe[Main.focusRecipe]];
    string gamepadInstructions2 = ItemSlot.GetQuickCraftGamepadInstructions(recipe);
    if (gamepadInstructions2 == null && Main.mouseItem.stack == 1 && Main.mouseItem.CanBeEquipped())
    {
      gamepadInstructions1 += PlayerInput.BuildCommand(Lang.misc[67].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
      if (ItemSlot.CanExecuteCommand() && PlayerInput.Triggers.JustPressed.Grapple)
      {
        ItemSlot.SwapEquip(ref Main.mouseItem);
        if (Main.player[Main.myPlayer].ItemSpace(Main.mouseItem).CanTakeItemToPersonalInventory)
          Main.mouseItem = localPlayer.GetItem(Main.mouseItem, GetItemSettings.QuickTransferFromSlot);
        PlayerInput.LockGamepadButtons("Grapple");
        PlayerInput.SettingsForUI.TryRevertingToMouseMode();
      }
    }
    if (Main.mouseItem.IsAir || Main.mouseItem.CanHavePrefixes() && Item.CanStack(Main.mouseItem, recipe.createItem) && Main.mouseItem.stack + recipe.createItem.stack <= Main.mouseItem.maxStack)
      gamepadInstructions1 += PlayerInput.BuildCommand(Lang.misc[72].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"], PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
    if (gamepadInstructions2 != null)
      gamepadInstructions1 += gamepadInstructions2;
    return gamepadInstructions1;
  }

  public static bool IsABuildingItem(Item item)
  {
    return item.type > 0 && item.stack > 0 && item.useStyle != 0 && item.useTime > 0;
  }

  public static void SelectEquipPage(Item item)
  {
    Main.EquipPage = -1;
    if (item.IsAir)
      return;
    if (Main.projHook[item.shoot])
      Main.EquipPage = 2;
    else if (item.mountType != -1)
      Main.EquipPage = 2;
    else if (item.buffType > 0 && Main.vanityPet[item.buffType])
      Main.EquipPage = 2;
    else if (item.buffType > 0 && Main.lightPet[item.buffType])
      Main.EquipPage = 2;
    else if (item.dye > (byte) 0 && Main.EquipPageSelected == 1)
    {
      Main.EquipPage = 0;
    }
    else
    {
      if (item.legSlot == -1 && item.headSlot == -1 && item.bodySlot == -1 && !item.accessory)
        return;
      Main.EquipPage = 0;
    }
  }

  public class Options
  {
    public static bool DisableLeftShiftTrashCan = true;
    public static bool DisableQuickTrash = false;
    public static bool HighlightNewItems = true;
  }

  public class Context
  {
    public const int InventoryItem = 0;
    public const int InventoryCoin = 1;
    public const int InventoryAmmo = 2;
    public const int ChestItem = 3;
    public const int BankItem = 4;
    public const int PrefixItem = 5;
    public const int TrashItem = 6;
    public const int GuideItem = 7;
    public const int EquipArmor = 8;
    public const int EquipArmorVanity = 9;
    public const int EquipAccessory = 10;
    public const int EquipAccessoryVanity = 11;
    public const int EquipDye = 12;
    public const int HotbarItem = 13;
    public const int ChatItem = 14;
    public const int ShopItem = 15;
    public const int EquipGrapple = 16 /*0x10*/;
    public const int EquipMount = 17;
    public const int EquipMinecart = 18;
    public const int EquipPet = 19;
    public const int EquipLight = 20;
    public const int MouseItem = 21;
    public const int CraftingMaterial = 22;
    public const int DisplayDollArmor = 23;
    public const int DisplayDollAccessory = 24;
    public const int DisplayDollDye = 25;
    public const int HatRackHat = 26;
    public const int HatRackDye = 27;
    public const int GoldDebug = 28;
    public const int CreativeInfinite = 29;
    public const int CreativeSacrifice = 30;
    public const int InWorld = 31 /*0x1F*/;
    public const int VoidItem = 32 /*0x20*/;
    public const int EquipMiscDye = 33;
    public const int CreativeInfiniteLocked = 34;
    public const int BannerClaiming = 35;
    public const int HotbarItemSmartSelected = 36;
    public const int OverdrawGlow = 37;
    public const int DisplayDollWeapon = 38;
    public const int DisplayDollMount = 39;
    public const int InWorldDisplay = 40;
    public const int NewCraftingUIRecipe = 41;
    public const int NewCraftingUICraftSlot = 42;
    public const int NewCraftingUIMaterial = 43;
    public static readonly int Count = 44;
  }

  public struct ItemDisplayKey
  {
    public int Context;
    public int Slot;

    public bool Equals(ItemSlot.ItemDisplayKey other)
    {
      return this.Context == other.Context && this.Slot == other.Slot;
    }

    public override bool Equals(object obj)
    {
      return obj is ItemSlot.ItemDisplayKey other && this.Equals(other);
    }

    public override int GetHashCode() => this.Context * 397 ^ this.Slot;

    public static bool operator ==(ItemSlot.ItemDisplayKey left, ItemSlot.ItemDisplayKey right)
    {
      return left.Equals(right);
    }

    public static bool operator !=(ItemSlot.ItemDisplayKey left, ItemSlot.ItemDisplayKey right)
    {
      return !left.Equals(right);
    }
  }

  public struct AlternateClickAction(int cursorOverride, LocalizedText gamepadHintText)
  {
    public readonly int cursorOverride = cursorOverride;
    public readonly LocalizedText gamepadHintText = gamepadHintText;
    public static ItemSlot.AlternateClickAction Trash = new ItemSlot.AlternateClickAction(6, Lang.misc[74]);
    public static ItemSlot.AlternateClickAction TransferToBackpack = new ItemSlot.AlternateClickAction(7, Lang.misc[76]);
    public static ItemSlot.AlternateClickAction Unequip = new ItemSlot.AlternateClickAction(7, Lang.misc[68]);
    public static ItemSlot.AlternateClickAction TransferFromChest = new ItemSlot.AlternateClickAction(8, Lang.misc[76]);
    public static ItemSlot.AlternateClickAction TransferToChest = new ItemSlot.AlternateClickAction(9, Lang.misc[76]);
    public static ItemSlot.AlternateClickAction Sell = new ItemSlot.AlternateClickAction(10, Lang.misc[75]);

    public static ItemSlot.AlternateClickAction? GetSellOrTrash(Item item)
    {
      if (Main.npcShop <= 0)
        return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.Trash);
      return item.type >= 71 && item.type <= 74 ? new ItemSlot.AlternateClickAction?() : new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.Sell);
    }
  }

  public struct ItemTransferInfo
  {
    public int ItemType;
    public int TransferAmount;
    public int FromContenxt;
    public int ToContext;

    public ItemTransferInfo(Item itemAfter, int fromContext, int toContext, int transferAmount = 0)
    {
      this.ItemType = itemAfter.type;
      this.TransferAmount = itemAfter.stack;
      if (transferAmount != 0)
        this.TransferAmount = transferAmount;
      this.FromContenxt = fromContext;
      this.ToContext = toContext;
    }
  }

  public delegate void ItemTransferEvent(ItemSlot.ItemTransferInfo info);

  public struct PulseEffect
  {
    public static readonly int EffectDuration = 40;
    public static readonly int NumPulses = 2;
    public readonly Color color;
    public readonly PlayerItemSlotID.SlotReference slotRef;
    public readonly Item itemInSlot;
    public int time;

    public PulseEffect(PlayerItemSlotID.SlotReference slotRef, Color color)
    {
      this.color = color;
      this.slotRef = slotRef;
      this.itemInSlot = slotRef.Item;
      this.time = 0;
    }

    public bool IsActive => this.itemInSlot != null;
  }

  public delegate void ItemPickupAction<TItemInfo>(TItemInfo info, int stackToGet);
}
