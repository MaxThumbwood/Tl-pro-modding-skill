// Decompiled with JetBrains decompiler
// Type: Terraria.UI.ChestUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Graphics;
using ReLogic.Localization.IME;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.UI;

public class ChestUI
{
  public const float buttonScaleMinimum = 0.75f;
  public const float buttonScaleMaximum = 1f;
  public static float[] ButtonScale = new float[ChestUI.ButtonID.Count];
  public static bool[] ButtonHovered = new bool[ChestUI.ButtonID.Count];
  public static int StartingRowForDrawing = 0;
  public static int LastHighestChestRow = 0;
  public static Rectangle LastChestDisplayRectangle;

  public static void UpdateHover(int ID, bool hovering)
  {
    if (hovering)
    {
      if (!ChestUI.ButtonHovered[ID])
        SoundEngine.PlaySound(12);
      ChestUI.ButtonHovered[ID] = true;
      ChestUI.ButtonScale[ID] += 0.05f;
      if ((double) ChestUI.ButtonScale[ID] <= 1.0)
        return;
      ChestUI.ButtonScale[ID] = 1f;
    }
    else
    {
      ChestUI.ButtonHovered[ID] = false;
      ChestUI.ButtonScale[ID] -= 0.05f;
      if ((double) ChestUI.ButtonScale[ID] >= 0.75)
        return;
      ChestUI.ButtonScale[ID] = 0.75f;
    }
  }

  public static void Draw(SpriteBatch spritebatch)
  {
    if (Main.player[Main.myPlayer].chest != -1 && !Main.PipsUseGrid && !NewCraftingUI.Visible)
    {
      Main.inventoryScale = 0.755f;
      if (Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, 73f, (float) Main.instance.invBottom, 560f * Main.inventoryScale, 224f * Main.inventoryScale))
        Main.player[Main.myPlayer].mouseInterface = true;
      ChestUI.DrawName(spritebatch);
      ChestUI.DrawButtons(spritebatch);
      ChestUI.DrawSlots(spritebatch);
    }
    else
    {
      for (int index = 0; index < ChestUI.ButtonID.Count; ++index)
      {
        ChestUI.ButtonScale[index] = 0.75f;
        ChestUI.ButtonHovered[index] = false;
      }
    }
  }

  private static void DrawName(SpriteBatch spritebatch)
  {
    Player player = Main.player[Main.myPlayer];
    string text = string.Empty;
    if (Main.editChest)
      text = Main.npcChatText;
    else if (player.chest > -1 && Main.chest[player.chest] != null)
    {
      Chest chest = Main.chest[player.chest];
      if (chest.name != "")
      {
        text = chest.name;
      }
      else
      {
        Tile tile = Main.tile[player.chestX, player.chestY];
        if (tile.type == (ushort) 21)
          text = Lang.chestType[(int) tile.frameX / 36].Value;
        else if (tile.type == (ushort) 467 && (int) tile.frameX / 36 == 4)
          text = Lang.GetItemNameValue(3988);
        else if (tile.type == (ushort) 467)
          text = Lang.chestType2[(int) tile.frameX / 36].Value;
        else if (tile.type == (ushort) 88)
          text = Lang.dresserType[(int) tile.frameX / 54].Value;
      }
    }
    else if (player.chest == -2)
      text = Lang.inter[32 /*0x20*/].Value;
    else if (player.chest == -3)
      text = Lang.inter[33].Value;
    else if (player.chest == -4)
      text = Lang.GetItemNameValue(3813);
    else if (player.chest == -5)
      text = Lang.GetItemNameValue(4076);
    Color color = new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor);
    Color baseColor = (Color.White * (float) (1.0 - ((double) byte.MaxValue - (double) Main.mouseTextColor) / (double) byte.MaxValue * 0.5)) with
    {
      A = byte.MaxValue
    };
    DynamicSpriteFont font = FontAssets.MouseText.Value;
    Vector2 position = new Vector2(504f, (float) Main.instance.invBottom);
    ChatManager.DrawColorCodedStringWithShadow(spritebatch, font, text, position, baseColor, 0.0f, Vector2.Zero, Vector2.One, spread: 1.5f);
    if (!Main.editChest)
      return;
    position.X += font.MeasureString(text).X;
    Main.instance.SetIMEPanelAnchor(position + new Vector2(0.0f, 56f), 0.0f);
    string compositionString = Platform.Get<IImeService>().CompositionString;
    if (compositionString != null && compositionString.Length > 0)
    {
      ChatManager.DrawColorCodedStringWithShadow(spritebatch, font, compositionString, position, Main.imeCompositionStringColor, 0.0f, Vector2.Zero, Vector2.One, spread: 1.5f);
      position.X += font.MeasureString(compositionString).X;
    }
    if (++Main.instance.textBlinkerCount >= 20)
    {
      Main.instance.textBlinkerState = Main.instance.textBlinkerState == 0 ? 1 : 0;
      Main.instance.textBlinkerCount = 0;
    }
    if (Main.instance.textBlinkerState != 1)
      return;
    ChatManager.DrawColorCodedStringWithShadow(spritebatch, font, "|", position, baseColor, 0.0f, Vector2.Zero, Vector2.One, spread: 1.5f);
  }

  private static void DrawButtons(SpriteBatch spritebatch)
  {
    for (int ID = 0; ID < ChestUI.ButtonID.Count; ++ID)
      ChestUI.DrawButton(spritebatch, ID, 506, Main.instance.invBottom + 40);
  }

  private static void DrawButton(SpriteBatch spriteBatch, int ID, int X, int Y)
  {
    Player player = Main.player[Main.myPlayer];
    if (ID == 5 && player.chest < -1 || ID == 6 && !Main.editChest)
    {
      ChestUI.UpdateHover(ID, false);
    }
    else
    {
      Y += ID * 26;
      float num1 = ChestUI.ButtonScale[ID];
      string text = "";
      switch (ID)
      {
        case 0:
          text = Lang.inter[29].Value;
          break;
        case 1:
          text = Lang.inter[30].Value;
          break;
        case 2:
          text = Lang.inter[31 /*0x1F*/].Value;
          break;
        case 3:
          text = Lang.inter[82].Value;
          break;
        case 4:
          text = Lang.inter[122].Value;
          break;
        case 5:
          text = Lang.inter[Main.editChest ? 47 : 61].Value;
          break;
        case 6:
          text = Lang.inter[63 /*0x3F*/].Value;
          break;
      }
      Vector2 vector2_1 = FontAssets.MouseText.Value.MeasureString(text);
      Color color = new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor) * num1;
      Color baseColor = (Color.White * 0.97f * (float) (1.0 - ((double) byte.MaxValue - (double) Main.mouseTextColor) / (double) byte.MaxValue * 0.5)) with
      {
        A = byte.MaxValue
      };
      int num2 = (int) ((double) vector2_1.X * (double) num1 / 2.0);
      X += num2;
      bool flag = Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, (float) (X - num2), (float) (Y - 12), vector2_1.X * num1, 24f);
      if (ChestUI.ButtonHovered[ID])
        flag = Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, (float) (X - num2 - 10), (float) (Y - 12), (float) ((double) vector2_1.X * (double) num1 + 16.0), 24f);
      if (flag)
        baseColor = Main.OurFavoriteColor;
      ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, text, new Vector2((float) X, (float) Y), baseColor, 0.0f, vector2_1 / 2f, new Vector2(num1), spread: 1.5f);
      Vector2 vector2_2 = vector2_1 * num1;
      switch (ID)
      {
        case 0:
          UILinkPointNavigator.SetPosition(500, new Vector2((float) X - (float) ((double) vector2_2.X * (double) num1 / 2.0 * 0.800000011920929), (float) Y));
          break;
        case 1:
          UILinkPointNavigator.SetPosition(501, new Vector2((float) X - (float) ((double) vector2_2.X * (double) num1 / 2.0 * 0.800000011920929), (float) Y));
          break;
        case 2:
          UILinkPointNavigator.SetPosition(502, new Vector2((float) X - (float) ((double) vector2_2.X * (double) num1 / 2.0 * 0.800000011920929), (float) Y));
          break;
        case 3:
          UILinkPointNavigator.SetPosition(503, new Vector2((float) X - (float) ((double) vector2_2.X * (double) num1 / 2.0 * 0.800000011920929), (float) Y));
          break;
        case 4:
          UILinkPointNavigator.SetPosition(505, new Vector2((float) X - (float) ((double) vector2_2.X * (double) num1 / 2.0 * 0.800000011920929), (float) Y));
          break;
        case 5:
          UILinkPointNavigator.SetPosition(504, new Vector2((float) X, (float) Y));
          break;
        case 6:
          UILinkPointNavigator.SetPosition(504, new Vector2((float) X, (float) Y));
          break;
      }
      if (!flag)
      {
        ChestUI.UpdateHover(ID, false);
      }
      else
      {
        ChestUI.UpdateHover(ID, true);
        if (PlayerInput.IgnoreMouseInterface)
          return;
        player.mouseInterface = true;
        if (!Main.mouseLeft || !Main.mouseLeftRelease)
          return;
        switch (ID)
        {
          case 0:
            ChestUI.LootAll();
            break;
          case 1:
            ChestUI.DepositAll();
            break;
          case 2:
            ChestUI.QuickStack();
            break;
          case 3:
            ChestUI.Restock();
            break;
          case 4:
            ItemSorting.SortChest();
            break;
          case 5:
            ChestUI.RenameChest();
            break;
          case 6:
            ChestUI.RenameChestCancel();
            break;
        }
      }
    }
  }

  public static void Scroll(int mouseWheel)
  {
    int startingRowForDrawing1 = ChestUI.StartingRowForDrawing;
    if (mouseWheel > 0)
      --ChestUI.StartingRowForDrawing;
    else
      ++ChestUI.StartingRowForDrawing;
    ChestUI.StartingRowForDrawing = Utils.Clamp<int>(ChestUI.StartingRowForDrawing, 0, ChestUI.LastHighestChestRow);
    int startingRowForDrawing2 = ChestUI.StartingRowForDrawing;
    if (startingRowForDrawing1 == startingRowForDrawing2)
      return;
    SoundEngine.PlaySound(12);
  }

  private static void DrawSlots(SpriteBatch spriteBatch)
  {
    int num1 = 10;
    int num2 = 4;
    Player player = Main.player[Main.myPlayer];
    int context = 0;
    Chest chest = (Chest) null;
    if (player.chest > -1)
    {
      context = 3;
      chest = Main.chest[player.chest];
    }
    if (player.chest == -2)
    {
      context = 4;
      chest = player.bank;
    }
    if (player.chest == -3)
    {
      context = 4;
      chest = player.bank2;
    }
    if (player.chest == -4)
    {
      context = 4;
      chest = player.bank3;
    }
    if (player.chest == -5)
    {
      context = 32 /*0x20*/;
      chest = player.bank4;
    }
    Item[] inv = chest.item;
    int maxItems = chest.maxItems;
    Main.inventoryScale = 0.755f;
    Rectangle rectangle = new Rectangle(73, Main.instance.invBottom, (int) ((double) (num1 * 56) * (double) Main.inventoryScale), (int) ((double) (num2 * 56) * (double) Main.inventoryScale));
    ChestUI.LastChestDisplayRectangle = rectangle;
    if (rectangle.Contains(Main.mouseX, Main.mouseY) && !PlayerInput.IgnoreMouseInterface)
      player.mouseInterface = true;
    int max = (int) Math.Max(0.0, Math.Ceiling((double) maxItems / (double) num1) - 4.0);
    ChestUI.StartingRowForDrawing = Utils.Clamp<int>(ChestUI.StartingRowForDrawing, 0, max);
    ChestUI.LastHighestChestRow = max;
    ItemSlot.PrepareForChest(chest);
    for (int index1 = 0; index1 < num1; ++index1)
    {
      for (int index2 = 0; index2 < num2; ++index2)
      {
        int slot = index1 + index2 * num1 + ChestUI.StartingRowForDrawing * num1;
        if (slot < inv.Length)
        {
          int num3 = (int) (73.0 + (double) (index1 * 56) * (double) Main.inventoryScale);
          int num4 = (int) ((double) Main.instance.invBottom + (double) (index2 * 56) * (double) Main.inventoryScale);
          Color color = new Color(100, 100, 100, 100);
          if (Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, (float) num3, (float) num4, (float) TextureAssets.InventoryBack.Width() * Main.inventoryScale, (float) TextureAssets.InventoryBack.Height() * Main.inventoryScale) && !PlayerInput.IgnoreMouseInterface)
          {
            player.mouseInterface = true;
            ItemSlot.Handle(inv, context, slot);
          }
          ItemSlot.Draw(spriteBatch, inv, context, slot, new Vector2((float) num3, (float) num4));
        }
      }
    }
  }

  public static void LootAll()
  {
    Player player = Main.player[Main.myPlayer];
    GetItemSettings settings = player.chest > -1 ? GetItemSettings.LootAllFromChest : GetItemSettings.LootAllFromBank;
    if (player.chest > -1)
    {
      Chest chest = Main.chest[player.chest];
      for (int index = 0; index < chest.maxItems; ++index)
      {
        if (chest.item[index].type > 0)
        {
          Player.GetItemLogger.Start();
          chest.item[index] = player.GetItem(chest.item[index], settings);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(chest.item, 3, index);
          if (Main.netMode == 1)
            NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) index);
        }
      }
    }
    else if (player.chest == -3)
    {
      for (int fromSlot = 0; fromSlot < player.bank2.maxItems; ++fromSlot)
      {
        if (player.bank2.item[fromSlot].type > 0)
        {
          Player.GetItemLogger.Start();
          player.bank2.item[fromSlot] = player.GetItem(player.bank2.item[fromSlot], settings);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(player.bank2.item, 4, fromSlot);
        }
      }
    }
    else if (player.chest == -4)
    {
      for (int fromSlot = 0; fromSlot < player.bank3.maxItems; ++fromSlot)
      {
        if (player.bank3.item[fromSlot].type > 0)
        {
          Player.GetItemLogger.Start();
          player.bank3.item[fromSlot] = player.GetItem(player.bank3.item[fromSlot], settings);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(player.bank3.item, 4, fromSlot);
        }
      }
    }
    else if (player.chest == -5)
    {
      for (int fromSlot = 0; fromSlot < player.bank4.maxItems; ++fromSlot)
      {
        if (player.bank4.item[fromSlot].type > 0 && !player.bank4.item[fromSlot].favorited)
        {
          Player.GetItemLogger.Start();
          player.bank4.item[fromSlot] = player.GetItem(player.bank4.item[fromSlot], settings);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(player.bank4.item, 32 /*0x20*/, fromSlot);
        }
      }
    }
    else
    {
      for (int fromSlot = 0; fromSlot < player.bank.maxItems; ++fromSlot)
      {
        if (player.bank.item[fromSlot].type > 0)
        {
          Player.GetItemLogger.Start();
          player.bank.item[fromSlot] = player.GetItem(player.bank.item[fromSlot], settings);
          Player.GetItemLogger.Stop();
          ItemSlot.DisplayTransfer_GetItem(player.bank.item, 4, fromSlot);
        }
      }
    }
  }

  private static void DepositAll_IntoWorldChest(
    Player player,
    Chest chest,
    int playerInventorySlot)
  {
    for (int number2 = 0; number2 < chest.maxItems; ++number2)
    {
      if (chest.item[number2].stack < chest.item[number2].maxStack && Item.CanStack(player.inventory[playerInventorySlot], chest.item[number2]))
      {
        int num = player.inventory[playerInventorySlot].stack;
        if (player.inventory[playerInventorySlot].stack + chest.item[number2].stack > chest.item[number2].maxStack)
          num = chest.item[number2].maxStack - chest.item[number2].stack;
        player.inventory[playerInventorySlot].stack -= num;
        chest.item[number2].stack += num;
        SoundEngine.PlaySound(7);
        if (player.inventory[playerInventorySlot].stack <= 0)
        {
          player.inventory[playerInventorySlot].SetDefaults(0);
          if (Main.netMode != 1)
            break;
          NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) number2);
          break;
        }
        if (chest.item[number2].type == 0)
        {
          chest.item[number2] = player.inventory[playerInventorySlot].Clone();
          player.inventory[playerInventorySlot].SetDefaults(0);
        }
        if (Main.netMode == 1)
          NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) number2);
      }
    }
  }

  private static void DepositAll_IntoLocalChest(Player player, Chest chest, int p)
  {
    for (int index = 0; index < chest.maxItems; ++index)
    {
      if (chest.item[index].stack < chest.item[index].maxStack && Item.CanStack(player.inventory[p], chest.item[index]))
      {
        int num = player.inventory[p].stack;
        if (player.inventory[p].stack + chest.item[index].stack > chest.item[index].maxStack)
          num = chest.item[index].maxStack - chest.item[index].stack;
        player.inventory[p].stack -= num;
        chest.item[index].stack += num;
        SoundEngine.PlaySound(7);
        if (player.inventory[p].stack <= 0)
        {
          player.inventory[p].SetDefaults(0);
          break;
        }
        if (chest.item[index].type == 0)
        {
          chest.item[index] = player.inventory[p].Clone();
          player.inventory[p].SetDefaults(0);
        }
      }
    }
  }

  public static void DepositAll()
  {
    Player player = Main.player[Main.myPlayer];
    if (player.chest > -1)
      ChestUI.MoveCoins(player.inventory, Main.chest[player.chest]);
    else if (player.chest == -3)
      ChestUI.MoveCoins(player.inventory, player.bank2);
    else if (player.chest == -4)
      ChestUI.MoveCoins(player.inventory, player.bank3);
    else if (player.chest == -5)
      ChestUI.MoveCoins(player.inventory, player.bank4);
    else
      ChestUI.MoveCoins(player.inventory, player.bank);
    for (int index1 = 49; index1 >= 10; --index1)
    {
      if (player.inventory[index1].stack > 0 && player.inventory[index1].type > 0 && !player.inventory[index1].favorited)
      {
        if (player.inventory[index1].maxStack > 1)
        {
          Chest currentContainer = player.GetCurrentContainer();
          if (player.chest > -1)
            ChestUI.DepositAll_IntoWorldChest(player, currentContainer, index1);
          else
            ChestUI.DepositAll_IntoLocalChest(player, currentContainer, index1);
        }
        if (player.inventory[index1].stack > 0)
        {
          if (player.chest > -1)
          {
            for (int index2 = 0; index2 < Main.chest[player.chest].maxItems; ++index2)
            {
              if (Main.chest[player.chest].item[index2].stack == 0)
              {
                SoundEngine.PlaySound(7);
                Main.chest[player.chest].item[index2] = player.inventory[index1].Clone();
                player.inventory[index1].SetDefaults(0);
                ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, index1, Main.chest[player.chest].item, 3, index2, Main.chest[player.chest].item[index2].stack);
                if (Main.netMode == 1)
                {
                  NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) index2);
                  break;
                }
                break;
              }
            }
          }
          else if (player.chest == -3)
          {
            for (int toSlot = 0; toSlot < player.bank2.maxItems; ++toSlot)
            {
              if (player.bank2.item[toSlot].stack == 0)
              {
                SoundEngine.PlaySound(7);
                player.bank2.item[toSlot] = player.inventory[index1].Clone();
                player.inventory[index1].SetDefaults(0);
                ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, index1, player.bank2.item, 4, toSlot, player.bank2.item[toSlot].stack);
                break;
              }
            }
          }
          else if (player.chest == -4)
          {
            for (int toSlot = 0; toSlot < player.bank3.maxItems; ++toSlot)
            {
              if (player.bank3.item[toSlot].stack == 0)
              {
                SoundEngine.PlaySound(7);
                player.bank3.item[toSlot] = player.inventory[index1].Clone();
                player.inventory[index1].SetDefaults(0);
                ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, index1, player.bank3.item, 4, toSlot, player.bank3.item[toSlot].stack);
                break;
              }
            }
          }
          else if (player.chest == -5)
          {
            for (int toSlot = 0; toSlot < player.bank4.maxItems; ++toSlot)
            {
              if (player.bank4.item[toSlot].stack == 0)
              {
                SoundEngine.PlaySound(7);
                player.bank4.item[toSlot] = player.inventory[index1].Clone();
                player.inventory[index1].SetDefaults(0);
                ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, index1, player.bank4.item, 32 /*0x20*/, toSlot, player.bank4.item[toSlot].stack);
                break;
              }
            }
          }
          else
          {
            for (int toSlot = 0; toSlot < player.bank.maxItems; ++toSlot)
            {
              if (player.bank.item[toSlot].stack == 0)
              {
                SoundEngine.PlaySound(7);
                player.bank.item[toSlot] = player.inventory[index1].Clone();
                player.inventory[index1].SetDefaults(0);
                ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, index1, player.bank.item, 4, toSlot, player.bank.item[toSlot].stack);
                break;
              }
            }
          }
        }
      }
    }
  }

  public static void QuickStack(bool voidStack = false)
  {
    Player player = Main.player[Main.myPlayer];
    Item[] inventory = player.inventory;
    if (voidStack)
      inventory = player.bank4.item;
    Vector2 center = player.Center;
    if (!voidStack && player.chest == -5)
      ChestUI.MoveCoins(inventory, player.bank4);
    else if (player.chest == -4)
      ChestUI.MoveCoins(inventory, player.bank3);
    else if (player.chest == -3)
      ChestUI.MoveCoins(inventory, player.bank2);
    else if (player.chest == -2)
      ChestUI.MoveCoins(inventory, player.bank);
    Chest currentContainer = player.GetCurrentContainer();
    Item[] arrayTo = currentContainer.item;
    int toContext = 3;
    if (voidStack || player.chest == -5)
      toContext = 32 /*0x20*/;
    else if (player.chest < -1)
      toContext = 4;
    List<int> intList1 = new List<int>();
    List<int> intList2 = new List<int>();
    List<int> intList3 = new List<int>();
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    List<int> intList4 = new List<int>();
    bool[] flagArray = new bool[arrayTo.Length];
    for (int index = 0; index < currentContainer.maxItems; ++index)
    {
      if (arrayTo[index].type > 0 && arrayTo[index].stack > 0 && (arrayTo[index].type < 71 || arrayTo[index].type > 74))
      {
        intList2.Add(index);
        intList1.Add(arrayTo[index].type);
      }
      if (arrayTo[index].type == 0 || arrayTo[index].stack <= 0)
        intList3.Add(index);
    }
    int num1 = 50;
    int num2 = 10;
    if (player.chest <= -2)
      num1 += 4;
    if (voidStack)
    {
      num2 = 0;
      num1 = player.bank4.maxItems;
    }
    for (int key = num2; key < num1; ++key)
    {
      if (intList1.Contains(inventory[key].type) && !inventory[key].favorited)
        dictionary.Add(key, inventory[key].type);
    }
    for (int index1 = 0; index1 < intList2.Count; ++index1)
    {
      int index2 = intList2[index1];
      foreach (KeyValuePair<int, int> keyValuePair in dictionary)
      {
        if (Item.CanStack(inventory[keyValuePair.Key], arrayTo[index2]))
        {
          int num3 = inventory[keyValuePair.Key].stack;
          int num4 = arrayTo[index2].maxStack - arrayTo[index2].stack;
          if (num4 != 0)
          {
            if (num3 > num4)
              num3 = num4;
            SoundEngine.PlaySound(7);
            arrayTo[index2].stack += num3;
            inventory[keyValuePair.Key].stack -= num3;
            if (inventory[keyValuePair.Key].stack == 0)
              inventory[keyValuePair.Key].SetDefaults(0);
            flagArray[index2] = true;
          }
          else
            break;
        }
      }
    }
    foreach (KeyValuePair<int, int> keyValuePair in dictionary)
    {
      if (inventory[keyValuePair.Key].stack == 0)
        intList4.Add(keyValuePair.Key);
    }
    foreach (int key in intList4)
      dictionary.Remove(key);
    for (int index = 0; index < intList3.Count; ++index)
    {
      int toSlot = intList3[index];
      bool flag = true;
      foreach (KeyValuePair<int, int> keyValuePair in dictionary)
      {
        if (inventory[keyValuePair.Key].stack != 0 && (flag || Item.CanStack(inventory[keyValuePair.Key], arrayTo[toSlot])))
        {
          SoundEngine.PlaySound(7);
          if (flag)
          {
            arrayTo[toSlot] = inventory[keyValuePair.Key];
            inventory[keyValuePair.Key] = new Item();
            ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, keyValuePair.Key, arrayTo, toContext, toSlot);
          }
          else
          {
            int num5 = inventory[keyValuePair.Key].stack;
            int num6 = arrayTo[toSlot].maxStack - arrayTo[toSlot].stack;
            if (num6 != 0)
            {
              if (num5 > num6)
                num5 = num6;
              arrayTo[toSlot].stack += num5;
              inventory[keyValuePair.Key].stack -= num5;
              if (inventory[keyValuePair.Key].stack == 0)
                inventory[keyValuePair.Key] = new Item();
              ItemSlot.DisplayTransfer_OneWay(player.inventory, 0, keyValuePair.Key, arrayTo, toContext, toSlot);
            }
            else
              break;
          }
          flagArray[toSlot] = true;
          flag = false;
        }
      }
    }
    if (Main.netMode == 1 && player.chest >= 0)
    {
      for (int number2 = 0; number2 < flagArray.Length; ++number2)
        NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) number2);
    }
    intList1.Clear();
    intList2.Clear();
    intList3.Clear();
    dictionary.Clear();
    intList4.Clear();
  }

  public static void RenameChest()
  {
    Player player = Main.player[Main.myPlayer];
    if (!Main.editChest)
      IngameFancyUI.OpenVirtualKeyboard(2);
    else
      ChestUI.RenameChestSubmit(player);
  }

  public static void RenameChestSubmit(Player player)
  {
    SoundEngine.PlaySound(12);
    Main.editChest = false;
    int chest = player.chest;
    if (chest < 0)
      return;
    if (Main.npcChatText == Main.defaultChestName)
      Main.npcChatText = "";
    if (!(Main.chest[chest].name != Main.npcChatText))
      return;
    Main.chest[chest].name = Main.npcChatText;
    if (Main.netMode != 1)
      return;
    player.editedChestName = true;
  }

  public static void RenameChestCancel()
  {
    SoundEngine.PlaySound(12);
    Main.editChest = false;
    Main.npcChatText = string.Empty;
    Main.blockKey = Keys.Escape.ToString();
  }

  public static void Restock()
  {
    Player player = Main.player[Main.myPlayer];
    Item[] inventory = player.inventory;
    Item[] objArray = player.bank.item;
    if (player.chest > -1)
      objArray = Main.chest[player.chest].item;
    else if (player.chest == -2)
      objArray = player.bank.item;
    else if (player.chest == -3)
      objArray = player.bank2.item;
    else if (player.chest == -4)
      objArray = player.bank3.item;
    else if (player.chest == -5)
      objArray = player.bank4.item;
    HashSet<int> intSet = new HashSet<int>();
    List<int> intList1 = new List<int>();
    List<int> intList2 = new List<int>();
    for (int index = 57; index >= 0; --index)
    {
      Item obj = inventory[index];
      if ((index < 50 || index >= 54) && (obj.type < 71 || obj.type > 74))
      {
        if (obj.stack == 0 || obj.type == 0 || obj.type == 0)
          intList2.Add(index);
        else if (obj.maxStack > 1 && (!obj.favorited || !obj.OnlyNeedOneInInventory()))
        {
          intSet.Add(obj.type);
          if (obj.stack < obj.maxStack)
            intList1.Add(index);
        }
      }
    }
    bool flag1 = false;
    for (int number2 = 0; number2 < objArray.Length; ++number2)
    {
      if (objArray[number2].stack >= 1 && objArray[number2].prefix == (byte) 0 && intSet.Contains(objArray[number2].type))
      {
        bool flag2 = false;
        for (int index = 0; index < intList1.Count; ++index)
        {
          int slot = intList1[index];
          int context = 0;
          if (slot >= 50)
            context = 2;
          if (Item.CanStack(inventory[slot], objArray[number2]) && ItemSlot.PickItemMovementAction(inventory, context, slot, objArray[number2]) != -1)
          {
            int num = objArray[number2].stack;
            if (inventory[slot].maxStack - inventory[slot].stack < num)
              num = inventory[slot].maxStack - inventory[slot].stack;
            inventory[slot].stack += num;
            objArray[number2].stack -= num;
            flag1 = true;
            if (inventory[slot].stack == inventory[slot].maxStack)
            {
              if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
                NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
              intList1.RemoveAt(index);
              --index;
            }
            if (objArray[number2].stack == 0)
            {
              objArray[number2] = new Item();
              flag2 = true;
              if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
              {
                NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
                break;
              }
              break;
            }
          }
        }
        if (!flag2 && intList2.Count > 0 && objArray[number2].ammo != 0)
        {
          for (int index = 0; index < intList2.Count; ++index)
          {
            int context = 0;
            if (intList2[index] >= 50)
              context = 2;
            if (ItemSlot.PickItemMovementAction(inventory, context, intList2[index], objArray[number2]) != -1)
            {
              Utils.Swap<Item>(ref inventory[intList2[index]], ref objArray[number2]);
              if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
                NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
              intList1.Add(intList2[index]);
              intList2.RemoveAt(index);
              flag1 = true;
              break;
            }
          }
        }
      }
    }
    if (!flag1)
      return;
    SoundEngine.PlaySound(7);
  }

  public static long MoveCoins(Item[] pInv, Chest chest)
  {
    return ChestUI.MoveCoins(pInv, chest.item, chest.maxItems);
  }

  public static long MoveCoins(Item[] pInv, Item[] cInv, int chestMaxItems)
  {
    bool flag1 = false;
    int[] numArray1 = new int[4];
    List<int> intList1 = new List<int>();
    List<int> intList2 = new List<int>();
    bool flag2 = false;
    int[] numArray2 = new int[chestMaxItems];
    bool overFlowing1;
    long num1 = Utils.CoinsCount(out overFlowing1, pInv);
    for (int index = 0; index < cInv.Length; ++index)
    {
      numArray2[index] = -1;
      if (cInv[index].stack < 1 || cInv[index].type < 1)
      {
        intList2.Add(index);
        cInv[index] = new Item();
      }
      if (cInv[index] != null && cInv[index].stack > 0)
      {
        int num2 = 0;
        if (cInv[index].type == 71)
          num2 = 1;
        if (cInv[index].type == 72)
          num2 = 2;
        if (cInv[index].type == 73)
          num2 = 3;
        if (cInv[index].type == 74)
          num2 = 4;
        numArray2[index] = num2 - 1;
        if (num2 > 0)
        {
          numArray1[num2 - 1] += cInv[index].stack;
          intList2.Add(index);
          cInv[index] = new Item();
          flag2 = true;
        }
      }
    }
    if (!flag2)
      return 0;
    for (int index = 0; index < pInv.Length; ++index)
    {
      if (index != 58 && pInv[index] != null && pInv[index].stack > 0 && !pInv[index].favorited)
      {
        int num3 = 0;
        if (pInv[index].type == 71)
          num3 = 1;
        if (pInv[index].type == 72)
          num3 = 2;
        if (pInv[index].type == 73)
          num3 = 3;
        if (pInv[index].type == 74)
          num3 = 4;
        if (num3 > 0)
        {
          flag1 = true;
          numArray1[num3 - 1] += pInv[index].stack;
          intList1.Add(index);
          pInv[index] = new Item();
        }
      }
    }
    for (int index = 0; index < 3; ++index)
    {
      while (numArray1[index] >= 100)
      {
        numArray1[index] -= 100;
        ++numArray1[index + 1];
      }
    }
    for (int index1 = 0; index1 < chestMaxItems; ++index1)
    {
      if (numArray2[index1] >= 0 && cInv[index1].type == 0)
      {
        int number2 = index1;
        int index2 = numArray2[index1];
        if (numArray1[index2] > 0)
        {
          cInv[number2].SetDefaults(71 + index2);
          cInv[number2].stack = numArray1[index2];
          if (cInv[number2].stack > cInv[number2].maxStack)
            cInv[number2].stack = cInv[number2].maxStack;
          numArray1[index2] -= cInv[number2].stack;
          numArray2[index1] = -1;
        }
        if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
          NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
        intList2.Remove(number2);
      }
    }
    for (int index3 = 0; index3 < chestMaxItems; ++index3)
    {
      if (numArray2[index3] >= 0 && cInv[index3].type == 0)
      {
        int number2 = index3;
        int index4 = 3;
        while (index4 >= 0)
        {
          if (numArray1[index4] > 0)
          {
            cInv[number2].SetDefaults(71 + index4);
            cInv[number2].stack = numArray1[index4];
            if (cInv[number2].stack > cInv[number2].maxStack)
              cInv[number2].stack = cInv[number2].maxStack;
            numArray1[index4] -= cInv[number2].stack;
            numArray2[index3] = -1;
            break;
          }
          if (numArray1[index4] == 0)
            --index4;
        }
        if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
          NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) number2);
        intList2.Remove(number2);
      }
    }
    while (intList2.Count > 0)
    {
      int index5 = intList2[0];
      int index6 = 3;
      while (index6 >= 0)
      {
        if (numArray1[index6] > 0)
        {
          cInv[index5].SetDefaults(71 + index6);
          cInv[index5].stack = numArray1[index6];
          if (cInv[index5].stack > cInv[index5].maxStack)
            cInv[index5].stack = cInv[index5].maxStack;
          numArray1[index6] -= cInv[index5].stack;
          break;
        }
        if (numArray1[index6] == 0)
          --index6;
      }
      if (Main.netMode == 1 && Main.player[Main.myPlayer].chest > -1)
        NetMessage.SendData(32 /*0x20*/, number: Main.player[Main.myPlayer].chest, number2: (float) intList2[0]);
      intList2.RemoveAt(0);
    }
    int index7 = 3;
    while (index7 >= 0 && intList1.Count > 0)
    {
      int index8 = intList1[0];
      if (numArray1[index7] > 0)
      {
        pInv[index8].SetDefaults(71 + index7);
        pInv[index8].stack = numArray1[index7];
        if (pInv[index8].stack > pInv[index8].maxStack)
          pInv[index8].stack = pInv[index8].maxStack;
        numArray1[index7] -= pInv[index8].stack;
        flag1 = false;
        intList1.RemoveAt(0);
      }
      if (numArray1[index7] == 0)
        --index7;
    }
    if (flag1)
      SoundEngine.PlaySound(7);
    bool overFlowing2;
    long num4 = Utils.CoinsCount(out overFlowing2, pInv);
    return overFlowing1 | overFlowing2 ? 0L : num1 - num4;
  }

  public static bool TryPlacingInChest(Item[] inv, int slot, bool justCheck, int itemSlotContext)
  {
    Item obj = inv[slot];
    bool flag1 = Main.LocalPlayer.chest > -1 && Main.netMode == 1;
    Chest currentContainer = Main.LocalPlayer.GetCurrentContainer();
    Item[] objArray = currentContainer.item;
    if (ChestUI.IsBlockedFromTransferIntoChest(obj, objArray))
      return false;
    Player player = Main.player[Main.myPlayer];
    bool flag2 = false;
    if (obj.maxStack > 1)
    {
      for (int number2 = 0; number2 < currentContainer.maxItems; ++number2)
      {
        if (objArray[number2].stack < objArray[number2].maxStack && Item.CanStack(obj, objArray[number2]))
        {
          int num = obj.stack;
          if (obj.stack + objArray[number2].stack > objArray[number2].maxStack)
            num = objArray[number2].maxStack - objArray[number2].stack;
          if (justCheck)
          {
            flag2 = flag2 || num > 0;
            break;
          }
          obj.stack -= num;
          objArray[number2].stack += num;
          SoundEngine.PlaySound(7);
          if (obj.stack <= 0)
          {
            obj.SetDefaults(0);
            if (flag1)
            {
              NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) number2);
              break;
            }
            break;
          }
          if (objArray[number2].type == 0)
          {
            objArray[number2] = obj.Clone();
            obj.SetDefaults(0);
          }
          if (flag1)
            NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) number2);
        }
      }
    }
    if (obj.stack > 0)
    {
      int toContext = 3;
      for (int index = 0; index < currentContainer.maxItems; ++index)
      {
        if (objArray[index].stack == 0)
        {
          if (justCheck)
          {
            flag2 = true;
            break;
          }
          SoundEngine.PlaySound(7);
          objArray[index] = obj.Clone();
          obj.SetDefaults(0);
          ItemSlot.AnnounceTransfer(new ItemSlot.ItemTransferInfo(objArray[index], itemSlotContext, toContext));
          ItemSlot.DisplayTransfer_OneWay(inv, itemSlotContext, slot, objArray, toContext, index, objArray[index].stack);
          if (flag1)
          {
            NetMessage.SendData(32 /*0x20*/, number: player.chest, number2: (float) index);
            break;
          }
          break;
        }
      }
    }
    return flag2;
  }

  public static bool IsBlockedFromTransferIntoChest(Item item, Item[] container)
  {
    return item.type == 3213 && item.favorited && container == Main.LocalPlayer.bank.item || (item.type == 4131 || item.type == 5325) && item.favorited && container == Main.LocalPlayer.bank4.item;
  }

  public class ButtonID
  {
    public const int LootAll = 0;
    public const int DepositAll = 1;
    public const int QuickStack = 2;
    public const int Restock = 3;
    public const int Sort = 4;
    public const int RenameChest = 5;
    public const int RenameChestCancel = 6;
    public static readonly int Count = 7;
  }
}
