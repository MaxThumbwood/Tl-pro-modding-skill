// Decompiled with JetBrains decompiler
// Type: Terraria.Initializers.UILinksInitializer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.Initializers;

public class UILinksInitializer
{
  private static List<string> RightStickGlyphBinding = new List<string>()
  {
    "RightStickAxis"
  };

  public static bool NothingMoreImportantThanNPCChat()
  {
    return !Main.hairWindow && Main.npcShop == 0 && Main.player[Main.myPlayer].chest == -1;
  }

  public static float HandleSliderHorizontalInput(
    float currentValue,
    float min,
    float max,
    float deadZone = 0.2f,
    float sensitivity = 0.5f)
  {
    float x = PlayerInput.GamepadThumbstickLeft.X;
    float num = (double) x < -(double) deadZone || (double) x > (double) deadZone ? MathHelper.Lerp(0.0f, sensitivity / 60f, (float) (((double) Math.Abs(x) - (double) deadZone) / (1.0 - (double) deadZone))) * (float) Math.Sign(x) : 0.0f;
    return MathHelper.Clamp((float) (((double) currentValue - (double) min) / ((double) max - (double) min)) + num, 0.0f, 1f) * (max - min) + min;
  }

  public static float HandleSliderVerticalInput(
    float currentValue,
    float min,
    float max,
    float deadZone = 0.2f,
    float sensitivity = 0.5f)
  {
    float num1 = -PlayerInput.GamepadThumbstickLeft.Y;
    float num2 = (double) num1 < -(double) deadZone || (double) num1 > (double) deadZone ? MathHelper.Lerp(0.0f, sensitivity / 60f, (float) (((double) Math.Abs(num1) - (double) deadZone) / (1.0 - (double) deadZone))) * (float) Math.Sign(num1) : 0.0f;
    return MathHelper.Clamp((float) (((double) currentValue - (double) min) / ((double) max - (double) min)) + num2, 0.0f, 1f) * (max - min) + min;
  }

  public static bool CanExecuteInputCommand() => PlayerInput.AllowExecutionOfGamepadInstructions;

  public static int MainfocusRecipe
  {
    get => Main.focusRecipe;
    set => Main.focusRecipe = value;
  }

  public static int MainFocusBanner
  {
    get => Main.focusRecipe;
    set => Main.focusRecipe = value;
  }

  public static int MainnumAvailableRecipes
  {
    get => Main.numAvailableRecipes;
    set => Main.numAvailableRecipes = value;
  }

  public static int MainnumAvailableRecipes2
  {
    get => Main.numAvailableRecipes;
    set => Main.numAvailableRecipes = value;
  }

  public static void Load()
  {
    Func<string> func1 = (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]));
    UILinkPage page1 = new UILinkPage();
    page1.UpdateEvent += (Action) (() => PlayerInput.GamepadAllowScrolling = true);
    for (int index = 0; index < 20; ++index)
      page1.LinkMap.Add(2000 + index, new UILinkPoint(2000 + index, true, -3, -4, -1, -2));
    page1.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]) + PlayerInput.BuildCommand(Lang.misc[82].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]));
    page1.UpdateEvent += (Action) (() =>
    {
      bool flag = PlayerInput.Triggers.JustPressed.Inventory;
      if (Main.inputTextEscape)
      {
        Main.inputTextEscape = false;
        flag = true;
      }
      if (UILinksInitializer.CanExecuteInputCommand() & flag)
        UILinksInitializer.FancyExit();
      UILinkPointNavigator.Shortcuts.BackButtonInUse = flag;
      UILinksInitializer.HandleOptionsSpecials();
    });
    page1.IsValidEvent += (Func<bool>) (() => Main.gameMenu && !Main.MenuUI.IsVisible);
    page1.CanEnterEvent += (Func<bool>) (() => Main.gameMenu && !Main.MenuUI.IsVisible);
    UILinkPointNavigator.RegisterPage(page1, 1000);
    UILinkPage cp1 = new UILinkPage();
    cp1.LinkMap.Add(2500, new UILinkPoint(2500, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2501, new UILinkPoint(2501, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2502, new UILinkPoint(2502, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2503, new UILinkPoint(2503, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2504, new UILinkPoint(2504, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2505, new UILinkPoint(2505, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2506, new UILinkPoint(2506, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2507, new UILinkPoint(2507, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2508, new UILinkPoint(2508, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2509, new UILinkPoint(2509, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2510, new UILinkPoint(2510, true, -3, -4, -1, -2));
    cp1.LinkMap.Add(2511, new UILinkPoint(2511, true, -3, -4, -1, -2));
    cp1.UpdateEvent += (Action) (() =>
    {
      if (UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsNew)
      {
        for (int index = 0; index < UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsCount; ++index)
        {
          cp1.LinkMap[2500 + index].Up = index - 4 < 0 ? -1 : 2500 + index - 4;
          cp1.LinkMap[2500 + index].Down = index + 4 >= UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsCount ? -2 : 2500 + index + 4;
          cp1.LinkMap[2500 + index].Left = index > 0 ? 2500 + index - 1 : -3;
          cp1.LinkMap[2500 + index].Right = index < UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsCount - 1 ? 2500 + index + 1 : -4;
        }
      }
      else
      {
        cp1.LinkMap[2501].Right = UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsRight ? 2502 : -4;
        if (cp1.LinkMap[2501].Right == -4 && UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsRight2)
          cp1.LinkMap[2501].Right = 2503;
        cp1.LinkMap[2502].Right = UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsRight2 ? 2503 : -4;
        cp1.LinkMap[2503].Left = UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsRight ? 2502 : 2501;
      }
    });
    cp1.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]) + PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]));
    cp1.IsValidEvent += (Func<bool>) (() => (Main.player[Main.myPlayer].talkNPC != -1 || Main.player[Main.myPlayer].sign != -1) && UILinksInitializer.NothingMoreImportantThanNPCChat());
    cp1.CanEnterEvent += (Func<bool>) (() => (Main.player[Main.myPlayer].talkNPC != -1 || Main.player[Main.myPlayer].sign != -1) && UILinksInitializer.NothingMoreImportantThanNPCChat());
    cp1.EnterEvent += (Action) (() => Main.player[Main.myPlayer].releaseInventory = false);
    cp1.LeaveEvent += (Action) (() =>
    {
      Main.npcChatRelease = false;
      Main.player[Main.myPlayer].LockGamepadTileInteractions();
    });
    UILinkPointNavigator.RegisterPage(cp1, 1003);
    UILinkPage cp2 = new UILinkPage();
    cp2.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func2 = (Func<string>) (() =>
    {
      int currentPoint = UILinkPointNavigator.CurrentPoint;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].inventory, slot: currentPoint);
    });
    Func<string> func3 = (Func<string>) (() => ItemSlot.GetGamepadInstructions(ref Main.player[Main.myPlayer].trashItem, 6));
    for (int index = 0; index <= 49; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, index - 1, index + 1, index - 10, index + 10);
      uiLinkPoint.OnSpecialInteracts += func2;
      int num = index;
      if (num < 10)
        uiLinkPoint.Up = -1;
      if (num >= 40)
        uiLinkPoint.Down = -2;
      if (num % 10 == 9)
        uiLinkPoint.Right = -4;
      if (num % 10 == 0)
        uiLinkPoint.Left = -3;
      cp2.LinkMap.Add(index, uiLinkPoint);
    }
    cp2.LinkMap[9].Right = 0;
    cp2.LinkMap[19].Right = 50;
    cp2.LinkMap[29].Right = 51;
    cp2.LinkMap[39].Right = 52;
    cp2.LinkMap[49].Right = 53;
    cp2.LinkMap[0].Left = 9;
    cp2.LinkMap[10].Left = 54;
    cp2.LinkMap[20].Left = 55;
    cp2.LinkMap[30].Left = 56;
    cp2.LinkMap[40].Left = 57;
    cp2.LinkMap.Add(300, new UILinkPoint(300, true, 309, 310, 49, -2));
    cp2.LinkMap.Add(309, new UILinkPoint(309, true, 310, 300, 302, 54));
    cp2.LinkMap.Add(310, new UILinkPoint(310, true, 300, 309, 301, 50));
    cp2.LinkMap.Add(301, new UILinkPoint(301, true, 300, 302, 53, 310));
    cp2.LinkMap.Add(302, new UILinkPoint(302, true, 301, 300, 57, 309));
    cp2.LinkMap.Add(311, new UILinkPoint(311, true, -3, -4, 40, -2));
    cp2.LinkMap[301].OnSpecialInteracts += func1;
    cp2.LinkMap[302].OnSpecialInteracts += func1;
    cp2.LinkMap[309].OnSpecialInteracts += func1;
    cp2.LinkMap[310].OnSpecialInteracts += func1;
    cp2.LinkMap[300].OnSpecialInteracts += func3;
    cp2.UpdateEvent += (Action) (() =>
    {
      bool inReforgeMenu = Main.InReforgeMenu;
      bool flag1 = Main.LocalPlayer.chest != -1;
      bool flag2 = Main.npcShop != 0;
      TileEntity tileEntity = Main.LocalPlayer.tileEntityAnchor.GetTileEntity();
      bool flag3 = tileEntity is TEHatRack;
      bool flag4 = tileEntity is TEDisplayDoll;
      if (NewCraftingUI.Visible)
        flag1 = false;
      for (int key = 40; key <= 49; ++key)
      {
        if (inReforgeMenu)
          cp2.LinkMap[key].Down = key < 45 ? 303 : 304;
        else if (flag1)
          cp2.LinkMap[key].Down = 400 + key - 40;
        else if (flag2)
          cp2.LinkMap[key].Down = 2700 + key - 40;
        else if (key == 40 && Main.IsJourneyMode && !Main.CreativeMenu.Blocked)
          cp2.LinkMap[key].Down = 311;
        else if (!NewCraftingUI.Visible)
          cp2.LinkMap[key].Down = -2;
      }
      if (flag4)
      {
        for (int key = 41; key <= 48 /*0x30*/; ++key)
          cp2.LinkMap[key].Down = 5100 + (int) Math.Round((double) ((key - 40) * 10) / 9.0) - 1;
        cp2.LinkMap[40].Down = 5118;
      }
      if (flag3)
      {
        for (int key = 44; key <= 45; ++key)
          cp2.LinkMap[key].Down = 5000 + key - 44;
      }
      if (NewCraftingUI.Visible && Main.LocalPlayer.chest != -1)
      {
        cp2.LinkMap[49].Down = 300;
        cp2.LinkMap[300].Up = 49;
        cp2.LinkMap[300].Right = 310;
        cp2.LinkMap[310].Up = 53;
        cp2.LinkMap[309].Up = 57;
      }
      else if (flag1)
      {
        cp2.LinkMap[300].Up = 439;
        cp2.LinkMap[300].Right = 310;
        cp2.LinkMap[300].Left = 309;
        cp2.LinkMap[310].Up = Main.LocalPlayer.chest < -1 ? 505 : 504;
        cp2.LinkMap[309].Up = Main.LocalPlayer.chest < -1 ? 505 : 504;
      }
      else if (flag2)
      {
        cp2.LinkMap[300].Up = 2739;
        cp2.LinkMap[300].Right = 310;
        cp2.LinkMap[300].Left = 309;
        cp2.LinkMap[310].Up = 53;
        cp2.LinkMap[309].Up = 57;
      }
      else
      {
        cp2.LinkMap[49].Down = 300;
        cp2.LinkMap[300].Up = 49;
        cp2.LinkMap[300].Right = 301;
        if (!NewCraftingUI.Visible)
          cp2.LinkMap[300].Left = 302;
        cp2.LinkMap[309].Up = 302;
        cp2.LinkMap[310].Up = 301;
      }
      if (!NewCraftingUI.Visible)
      {
        cp2.LinkMap[311].Right = -1;
        cp2.LinkMap[311].Down = -1;
        cp2.LinkMap[300].Down = -1;
      }
      cp2.LinkMap[0].Left = 9;
      cp2.LinkMap[10].Left = 54;
      cp2.LinkMap[20].Left = 55;
      cp2.LinkMap[30].Left = 56;
      cp2.LinkMap[40].Left = 57;
      if (UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 0)
        cp2.LinkMap[0].Left = 6000;
      if (UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 2)
        cp2.LinkMap[10].Left = 6002;
      if (UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 4)
        cp2.LinkMap[20].Left = 6004;
      if (UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 6)
        cp2.LinkMap[30].Left = 6006;
      if (UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 8)
        cp2.LinkMap[40].Left = 6008;
      cp2.PageOnLeft = 9;
      if (Main.InPipBanner)
        cp2.PageOnLeft = 22;
      if (Main.CreativeMenu.Enabled)
        cp2.PageOnLeft = 1005;
      if (NewCraftingUI.Visible)
        cp2.PageOnLeft = 24;
      if (Main.InReforgeMenu)
        cp2.PageOnLeft = 5;
      if (flag4)
        cp2.PageOnLeft = 20;
      if (!flag3)
        return;
      cp2.PageOnLeft = 21;
    });
    cp2.IsValidEvent += (Func<bool>) (() => Main.playerInventory);
    cp2.PageOnLeft = 9;
    cp2.PageOnRight = 2;
    UILinkPointNavigator.RegisterPage(cp2, 0);
    UILinkPage cp3 = new UILinkPage();
    cp3.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func4 = (Func<string>) (() =>
    {
      int currentPoint = UILinkPointNavigator.CurrentPoint;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].inventory, 1, currentPoint);
    });
    for (int index = 50; index <= 53; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, -3, -4, index - 1, index + 1);
      uiLinkPoint.OnSpecialInteracts += func4;
      cp3.LinkMap.Add(index, uiLinkPoint);
    }
    cp3.LinkMap[50].Left = 19;
    cp3.LinkMap[51].Left = 29;
    cp3.LinkMap[52].Left = 39;
    cp3.LinkMap[53].Left = 49;
    cp3.LinkMap[50].Right = 54;
    cp3.LinkMap[51].Right = 55;
    cp3.LinkMap[52].Right = 56;
    cp3.LinkMap[53].Right = 57;
    cp3.LinkMap[50].Up = 310;
    cp3.UpdateEvent += (Action) (() =>
    {
      if (Main.npcShop != 0)
        cp3.LinkMap[53].Down = 310;
      else if (Main.player[Main.myPlayer].chest != -1)
        cp3.LinkMap[53].Down = NewCraftingUI.Visible ? 310 : 500;
      else
        cp3.LinkMap[53].Down = 301;
    });
    cp3.IsValidEvent += (Func<bool>) (() => Main.playerInventory);
    cp3.PageOnLeft = 0;
    cp3.PageOnRight = 2;
    UILinkPointNavigator.RegisterPage(cp3, 1);
    UILinkPage cp4 = new UILinkPage();
    cp4.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func5 = (Func<string>) (() =>
    {
      int currentPoint = UILinkPointNavigator.CurrentPoint;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].inventory, 2, currentPoint);
    });
    for (int index = 54; index <= 57; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, -3, -4, index - 1, index + 1);
      uiLinkPoint.OnSpecialInteracts += func5;
      cp4.LinkMap.Add(index, uiLinkPoint);
    }
    cp4.LinkMap[54].Left = 50;
    cp4.LinkMap[55].Left = 51;
    cp4.LinkMap[56].Left = 52;
    cp4.LinkMap[57].Left = 53;
    cp4.LinkMap[54].Right = 10;
    cp4.LinkMap[55].Right = 20;
    cp4.LinkMap[56].Right = 30;
    cp4.LinkMap[57].Right = 40;
    cp4.LinkMap[54].Up = 309;
    cp4.UpdateEvent += (Action) (() =>
    {
      if (Main.npcShop != 0)
        cp4.LinkMap[57].Down = 309;
      else if (Main.player[Main.myPlayer].chest != -1)
        cp4.LinkMap[57].Down = NewCraftingUI.Visible ? 310 : 500;
      else
        cp4.LinkMap[57].Down = 302;
    });
    cp4.PageOnLeft = 0;
    cp4.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp4, 2);
    UILinkPage cp5 = new UILinkPage();
    cp5.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func6 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 100;
      if (slot % 10 == 8 && !Main.LocalPlayer.CanDemonHeartAccessoryBeShown())
        ++slot;
      bool flag = slot >= 10;
      return ItemSlot.GetGamepadInstructions(Main.LocalPlayer.armor, slot % 10 < 3 ? (flag ? 9 : 8) : (flag ? 11 : 10), slot);
    });
    Func<string> func7 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 120;
      if (slot % 10 == 8 && !Main.LocalPlayer.CanDemonHeartAccessoryBeShown())
        ++slot;
      return ItemSlot.GetGamepadInstructions(Main.LocalPlayer.dye, 12, slot);
    });
    for (int index = 100; index <= 119; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, index + 10, index - 10, index - 1, index + 1);
      uiLinkPoint.OnSpecialInteracts += func6;
      int num = index - 100;
      if (num == 0)
        uiLinkPoint.Up = 305;
      if (num == 10)
        uiLinkPoint.Up = 306;
      if (num == 9 || num == 19)
        uiLinkPoint.Down = -2;
      if (num >= 10)
        uiLinkPoint.Left = 120 + num % 10;
      else
        uiLinkPoint.Right = num < 3 ? 312 + num : -4;
      cp5.LinkMap.Add(index, uiLinkPoint);
    }
    for (int index = 120; index <= 129; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, -3, index - 10, index - 1, index + 1);
      uiLinkPoint.OnSpecialInteracts += func7;
      int num = index - 120;
      if (num == 0)
        uiLinkPoint.Up = 307;
      if (num == 9)
      {
        uiLinkPoint.Down = 308;
        uiLinkPoint.Left = 1557;
      }
      if (num == 8)
        uiLinkPoint.Left = 1570;
      cp5.LinkMap.Add(index, uiLinkPoint);
    }
    for (int index = 312; index <= 314; ++index)
    {
      int num = index - 312;
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, 100 + num, -4, index - 1, index + 1);
      if (num == 0)
        uiLinkPoint.Up = -1;
      if (num == 2)
        uiLinkPoint.Down = -2;
      uiLinkPoint.OnSpecialInteracts += func1;
      cp5.LinkMap.Add(index, uiLinkPoint);
    }
    cp5.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.EquipPage == 0);
    cp5.UpdateEvent += (Action) (() =>
    {
      int num1 = 107;
      int accessorySlotsToShow = Main.player[Main.myPlayer].GetAmountOfExtraAccessorySlotsToShow();
      for (int index = 0; index < accessorySlotsToShow; ++index)
      {
        cp5.LinkMap[num1 + index].Down = num1 + index + 1;
        cp5.LinkMap[num1 - 100 + 120 + index].Down = num1 - 100 + 120 + index + 1;
        cp5.LinkMap[num1 + 10 + index].Down = num1 + 10 + index + 1;
      }
      cp5.LinkMap[num1 + accessorySlotsToShow].Down = 308;
      cp5.LinkMap[num1 + 10 + accessorySlotsToShow].Down = 308;
      cp5.LinkMap[num1 - 100 + 120 + accessorySlotsToShow].Down = 308;
      for (int key = 120; key <= 129; ++key)
      {
        UILinkPoint link = cp5.LinkMap[key];
        int num2 = key - 120;
        link.Left = -3;
        if (num2 == 0)
          link.Left = Main.ShouldPVPDraw ? 1550 : -3;
        if (num2 == 1)
          link.Left = Main.ShouldTeamSelectDraw ? 1552 : -3;
        if (num2 == 2)
          link.Left = Main.ShouldTeamSelectDraw ? 1556 : -3;
        if (num2 == 3)
          link.Left = UILinkPointNavigator.Shortcuts.INFOACCCOUNT >= 1 ? 1558 : -3;
        if (num2 == 4)
          link.Left = UILinkPointNavigator.Shortcuts.INFOACCCOUNT >= 5 ? 1562 : -3;
        if (num2 == 5)
          link.Left = UILinkPointNavigator.Shortcuts.INFOACCCOUNT >= 9 ? 1566 : -3;
      }
      cp5.LinkMap[num1 - 100 + 120 + accessorySlotsToShow].Left = 1557;
      cp5.LinkMap[num1 - 100 + 120 + accessorySlotsToShow - 1].Left = 1570;
    });
    cp5.PageOnLeft = 8;
    cp5.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp5, 3);
    UILinkPage cp6 = new UILinkPage();
    cp6.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func8 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 400;
      int context = 4;
      Item[] inv = Main.player[Main.myPlayer].bank.item;
      switch (Main.player[Main.myPlayer].chest)
      {
        case -5:
          inv = Main.player[Main.myPlayer].bank4.item;
          context = 32 /*0x20*/;
          goto case -2;
        case -4:
          inv = Main.player[Main.myPlayer].bank3.item;
          goto case -2;
        case -3:
          inv = Main.player[Main.myPlayer].bank2.item;
          goto case -2;
        case -2:
          return ItemSlot.GetGamepadInstructions(inv, context, slot);
        case -1:
          return "";
        default:
          inv = Main.chest[Main.player[Main.myPlayer].chest].item;
          context = 3;
          goto case -2;
      }
    });
    for (int index = 400; index <= 439; ++index)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(index, true, index - 1, index + 1, index - 10, index + 10);
      uiLinkPoint.OnSpecialInteracts += func8;
      int num = index - 400;
      if (num < 10)
        uiLinkPoint.Up = 40 + num;
      if (num >= 30)
        uiLinkPoint.Down = -2;
      if (num % 10 == 9)
        uiLinkPoint.Right = -4;
      if (num % 10 == 0)
        uiLinkPoint.Left = -3;
      cp6.LinkMap.Add(index, uiLinkPoint);
    }
    cp6.LinkMap.Add(500, new UILinkPoint(500, true, 409, -4, 53, 501));
    cp6.LinkMap.Add(501, new UILinkPoint(501, true, 419, -4, 500, 502));
    cp6.LinkMap.Add(502, new UILinkPoint(502, true, 429, -4, 501, 503));
    cp6.LinkMap.Add(503, new UILinkPoint(503, true, 439, -4, 502, 505));
    cp6.LinkMap.Add(505, new UILinkPoint(505, true, 439, -4, 503, 504));
    cp6.LinkMap.Add(504, new UILinkPoint(504, true, 439, -4, 505, 310));
    cp6.LinkMap[500].OnSpecialInteracts += func1;
    cp6.LinkMap[501].OnSpecialInteracts += func1;
    cp6.LinkMap[502].OnSpecialInteracts += func1;
    cp6.LinkMap[503].OnSpecialInteracts += func1;
    cp6.LinkMap[504].OnSpecialInteracts += func1;
    cp6.LinkMap[505].OnSpecialInteracts += func1;
    cp6.LinkMap[409].Right = 500;
    cp6.LinkMap[419].Right = 501;
    cp6.LinkMap[429].Right = 502;
    cp6.LinkMap[439].Right = 503;
    cp6.LinkMap[439].Down = 300;
    cp6.PageOnLeft = 0;
    cp6.PageOnRight = 0;
    cp6.DefaultPoint = 400;
    cp6.UpdateEvent += (Action) (() =>
    {
      if (Main.LocalPlayer.chest < -1)
        cp6.LinkMap[505].Down = 310;
      else
        cp6.LinkMap[505].Down = 504;
    });
    UILinkPointNavigator.RegisterPage(cp6, 4, false);
    cp6.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.player[Main.myPlayer].chest != -1 && !NewCraftingUI.Visible);
    UILinkPage page2 = new UILinkPage();
    page2.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func9 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 5100;
      return !(Main.LocalPlayer.tileEntityAnchor.GetTileEntity() is TEDisplayDoll tileEntity2) ? "" : tileEntity2.GetItemGamepadInstructions(slot);
    });
    int num3;
    for (num3 = 5100; num3 < 5118; ++num3)
    {
      UILinkPoint uiLinkPoint = new UILinkPoint(num3, true, num3 - 1, num3 + 1, num3 - 9, num3 + 9);
      uiLinkPoint.OnSpecialInteracts += func9;
      int num4 = num3 - 5100;
      if (num4 < 9)
        uiLinkPoint.Up = 40 + (int) Math.Round((double) (num4 + 1) * 0.9);
      if (num4 >= 9)
        uiLinkPoint.Down = -2;
      if (num4 % 9 == 8)
        uiLinkPoint.Right = -4;
      if (num4 % 9 == 0)
        uiLinkPoint.Left = -3;
      page2.LinkMap.Add(num3, uiLinkPoint);
    }
    UILinkPoint uiLinkPoint1 = new UILinkPoint(num3, true, -3, 5100, 40, -2);
    uiLinkPoint1.OnSpecialInteracts += func9;
    page2.LinkMap.Add(num3, uiLinkPoint1);
    page2.LinkMap[5100].Left = num3;
    page2.PageOnLeft = 0;
    page2.PageOnRight = 0;
    page2.DefaultPoint = 5100;
    UILinkPointNavigator.RegisterPage(page2, 20, false);
    page2.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.LocalPlayer.tileEntityAnchor.GetTileEntity() is TEDisplayDoll);
    UILinkPage page3 = new UILinkPage();
    page3.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func10 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 5000;
      return !(Main.LocalPlayer.tileEntityAnchor.GetTileEntity() is TEHatRack tileEntity4) ? "" : tileEntity4.GetItemGamepadInstructions(slot);
    });
    for (int index = 5000; index <= 5003; ++index)
    {
      UILinkPoint uiLinkPoint2 = new UILinkPoint(index, true, index - 1, index + 1, index - 2, index + 2);
      uiLinkPoint2.OnSpecialInteracts += func10;
      int num5 = index - 5000;
      if (num5 < 2)
        uiLinkPoint2.Up = 44 + num5;
      if (num5 >= 2)
        uiLinkPoint2.Down = -2;
      if (num5 % 2 == 1)
        uiLinkPoint2.Right = -4;
      if (num5 % 2 == 0)
        uiLinkPoint2.Left = -3;
      page3.LinkMap.Add(index, uiLinkPoint2);
    }
    page3.PageOnLeft = 0;
    page3.PageOnRight = 0;
    page3.DefaultPoint = 5000;
    UILinkPointNavigator.RegisterPage(page3, 21, false);
    page3.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.LocalPlayer.tileEntityAnchor.GetTileEntity() is TEHatRack);
    UILinkPage page4 = new UILinkPage();
    page4.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func11 = (Func<string>) (() =>
    {
      if (Main.npcShop == 0)
        return "";
      int slot = UILinkPointNavigator.CurrentPoint - 2700;
      return ItemSlot.GetGamepadInstructions(Main.instance.shop[Main.npcShop].item, 15, slot);
    });
    for (int index = 2700; index <= 2739; ++index)
    {
      UILinkPoint uiLinkPoint3 = new UILinkPoint(index, true, index - 1, index + 1, index - 10, index + 10);
      uiLinkPoint3.OnSpecialInteracts += func11;
      int num6 = index - 2700;
      if (num6 < 10)
        uiLinkPoint3.Up = 40 + num6;
      if (num6 >= 30)
        uiLinkPoint3.Down = -2;
      if (num6 % 10 == 9)
        uiLinkPoint3.Right = -4;
      if (num6 % 10 == 0)
        uiLinkPoint3.Left = -3;
      page4.LinkMap.Add(index, uiLinkPoint3);
    }
    page4.LinkMap[2739].Down = 300;
    page4.PageOnLeft = 0;
    page4.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(page4, 13);
    page4.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.npcShop != 0);
    UILinkPage cp7 = new UILinkPage();
    cp7.LinkMap.Add(303, new UILinkPoint(303, true, 304, 304, 40, -2));
    cp7.LinkMap.Add(304, new UILinkPoint(304, true, 303, 303, 40, -2));
    cp7.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func12 = (Func<string>) (() => ItemSlot.GetGamepadInstructions(ref Main.reforgeItem, 5));
    cp7.LinkMap[303].OnSpecialInteracts += func12;
    cp7.LinkMap[304].OnSpecialInteracts += (Func<string>) (() => Lang.misc[53].Value);
    cp7.UpdateEvent += (Action) (() =>
    {
      if (Main.reforgeItem.type > 0)
      {
        cp7.LinkMap[303].Left = cp7.LinkMap[303].Right = 304;
      }
      else
      {
        if (UILinkPointNavigator.OverridePoint == -1 && cp7.CurrentPoint == 304)
          UILinkPointNavigator.ChangePoint(303);
        cp7.LinkMap[303].Left = -3;
        cp7.LinkMap[303].Right = -4;
      }
    });
    cp7.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.InReforgeMenu);
    cp7.PageOnLeft = 0;
    cp7.PageOnRight = 0;
    cp7.EnterEvent += (Action) (() => PlayerInput.LockGamepadButtons("MouseLeft"));
    UILinkPointNavigator.RegisterPage(cp7, 5);
    UILinkPage cp8 = new UILinkPage();
    cp8.OnSpecialInteracts += (Func<string>) (() =>
    {
      string str = PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]);
      if (PlayerInput.ControllerHousingCursorActive)
      {
        bool flag5 = UILinkPointNavigator.CurrentPoint == 600;
        bool flag6 = UILinkPointNavigator.Shortcuts.NPCS_HoveredBanner >= 0;
        if (flag6)
        {
          string fullName = Main.npc[UILinkPointNavigator.Shortcuts.NPCS_HoveredBanner].FullName;
          str += PlayerInput.BuildCommand(Language.GetTextValue("UI.HousingEvict", (object) fullName), PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
        }
        else if (flag5)
          str += PlayerInput.BuildCommand(Lang.misc[70].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
        else if (UILinkPointNavigator.Shortcuts.NPCS_SelectedNPC >= 0)
        {
          string fullName = Main.npc[UILinkPointNavigator.Shortcuts.NPCS_SelectedNPC].FullName;
          str += PlayerInput.BuildCommand(Language.GetTextValue("UI.HousingAssign", (object) fullName), PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
        }
        if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.Grapple)
        {
          Point tileCoordinates = PlayerInput.HousingWorldPosition.ToTileCoordinates();
          if (flag6)
          {
            WorldGen.kickOut(UILinkPointNavigator.Shortcuts.NPCS_HoveredBanner);
            SoundEngine.PlaySound(12);
          }
          else if (flag5)
            Main.instance.PerformHousingCheck(tileCoordinates.X, tileCoordinates.Y);
          else if (UILinkPointNavigator.Shortcuts.NPCS_SelectedNPC >= 0)
            Main.instance.TryMovingNPC(tileCoordinates.X, tileCoordinates.Y, UILinkPointNavigator.Shortcuts.NPCS_SelectedNPC);
          PlayerInput.LockGamepadButtons("Grapple");
          PlayerInput.SettingsForUI.TryRevertingToMouseMode();
        }
        str += PlayerInput.BuildCommand(Language.GetTextValue("UI.HousingAim"), UILinksInitializer.RightStickGlyphBinding);
      }
      return str;
    });
    for (int index = 600; index <= 650; ++index)
    {
      UILinkPoint uiLinkPoint4 = new UILinkPoint(index, true, index + 10, index - 10, index - 1, index + 1);
      cp8.LinkMap.Add(index, uiLinkPoint4);
    }
    cp8.UpdateEvent += (Action) (() =>
    {
      int num7 = UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn;
      if (num7 == 0)
        num7 = 100;
      for (int index = 0; index < 50; ++index)
      {
        cp8.LinkMap[600 + index].Up = index % num7 == 0 ? -1 : 600 + index - 1;
        if (cp8.LinkMap[600 + index].Up == -1)
          cp8.LinkMap[600 + index].Up = index < num7 * 2 ? (index < num7 ? 305 : 306) : 307;
        cp8.LinkMap[600 + index].Down = (index + 1) % num7 == 0 || index == UILinkPointNavigator.Shortcuts.NPCS_IconsTotal - 1 ? 308 : 600 + index + 1;
        cp8.LinkMap[600 + index].Left = index < UILinkPointNavigator.Shortcuts.NPCS_IconsTotal - num7 ? 600 + index + num7 : -3;
        cp8.LinkMap[600 + index].Right = index < num7 ? -4 : 600 + index - num7;
      }
    });
    cp8.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.EquipPage == 1);
    cp8.PageOnLeft = 8;
    cp8.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp8, 6);
    UILinkPage cp9 = new UILinkPage();
    cp9.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func13 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 180;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscEquips, 20, slot);
    });
    Func<string> func14 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 180;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscEquips, 19, slot);
    });
    Func<string> func15 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 180;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscEquips, 18, slot);
    });
    Func<string> func16 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 180;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscEquips, 17, slot);
    });
    Func<string> func17 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 180;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscEquips, 16 /*0x10*/, slot);
    });
    Func<string> func18 = (Func<string>) (() =>
    {
      int slot = UILinkPointNavigator.CurrentPoint - 185;
      return ItemSlot.GetGamepadInstructions(Main.player[Main.myPlayer].miscDyes, 33, slot);
    });
    for (int index = 180; index <= 184; ++index)
    {
      UILinkPoint uiLinkPoint5 = new UILinkPoint(index, true, 185 + index - 180, -4, index - 1, index + 1);
      int num8 = index - 180;
      if (num8 == 0)
        uiLinkPoint5.Up = 305;
      if (num8 == 4)
        uiLinkPoint5.Down = 308;
      cp9.LinkMap.Add(index, uiLinkPoint5);
      switch (index)
      {
        case 180:
          uiLinkPoint5.OnSpecialInteracts += func14;
          break;
        case 181:
          uiLinkPoint5.OnSpecialInteracts += func13;
          break;
        case 182:
          uiLinkPoint5.OnSpecialInteracts += func15;
          break;
        case 183:
          uiLinkPoint5.OnSpecialInteracts += func16;
          break;
        case 184:
          uiLinkPoint5.OnSpecialInteracts += func17;
          break;
      }
    }
    for (int index = 185; index <= 189; ++index)
    {
      UILinkPoint uiLinkPoint6 = new UILinkPoint(index, true, -3, index - 5, index - 1, index + 1);
      uiLinkPoint6.OnSpecialInteracts += func18;
      int num9 = index - 185;
      if (num9 == 0)
        uiLinkPoint6.Up = 306;
      if (num9 == 4)
        uiLinkPoint6.Down = 308;
      cp9.LinkMap.Add(index, uiLinkPoint6);
    }
    cp9.UpdateEvent += (Action) (() =>
    {
      cp9.LinkMap[184].Down = UILinkPointNavigator.Shortcuts.BUFFS_DRAWN > 0 ? 9000 : 308;
      cp9.LinkMap[189].Down = UILinkPointNavigator.Shortcuts.BUFFS_DRAWN > 0 ? 9000 : 308;
    });
    cp9.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.EquipPage == 2);
    cp9.PageOnLeft = 8;
    cp9.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp9, 7);
    UILinkPage cp10 = new UILinkPage();
    cp10.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp10.LinkMap.Add(305, new UILinkPoint(305, true, 306, -4, 308, -2));
    cp10.LinkMap.Add(306, new UILinkPoint(306, true, 307, 305, 308, -2));
    cp10.LinkMap.Add(307, new UILinkPoint(307, true, -3, 306, 308, -2));
    cp10.LinkMap.Add(308, new UILinkPoint(308, true, -3, -4, -1, 305));
    cp10.LinkMap[305].OnSpecialInteracts += func1;
    cp10.LinkMap[306].OnSpecialInteracts += func1;
    cp10.LinkMap[307].OnSpecialInteracts += func1;
    cp10.LinkMap[308].OnSpecialInteracts += func1;
    cp10.UpdateEvent += (Action) (() =>
    {
      switch (Main.EquipPage)
      {
        case 0:
          cp10.LinkMap[305].Down = 100;
          cp10.LinkMap[306].Down = 110;
          cp10.LinkMap[307].Down = 120;
          cp10.LinkMap[308].Up = 108 + Main.player[Main.myPlayer].GetAmountOfExtraAccessorySlotsToShow() - 1;
          break;
        case 1:
          cp10.LinkMap[305].Down = 600;
          cp10.LinkMap[306].Down = UILinkPointNavigator.Shortcuts.NPCS_IconsTotal > UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn ? 600 + UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn : 600;
          cp10.LinkMap[307].Down = UILinkPointNavigator.Shortcuts.NPCS_IconsTotal > UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn * 2 ? 600 + UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn * 2 : cp10.LinkMap[306].Down;
          int num10 = UILinkPointNavigator.Shortcuts.NPCS_IconsPerColumn;
          if (num10 == 0)
            num10 = 100;
          if (num10 == 100)
            num10 = UILinkPointNavigator.Shortcuts.NPCS_IconsTotal;
          cp10.LinkMap[308].Up = 600 + num10 - 1;
          break;
        case 2:
          cp10.LinkMap[305].Down = 180;
          cp10.LinkMap[306].Down = 185;
          cp10.LinkMap[307].Down = -2;
          cp10.LinkMap[308].Up = UILinkPointNavigator.Shortcuts.BUFFS_DRAWN > 0 ? 9000 : 184;
          break;
      }
      cp10.PageOnRight = UILinksInitializer.GetCornerWrapPageIdFromRightToLeft();
    });
    cp10.IsValidEvent += (Func<bool>) (() => Main.playerInventory);
    cp10.PageOnLeft = 0;
    cp10.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(cp10, 8);
    UILinkPage cp11 = new UILinkPage();
    cp11.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp11.OnSpecialInteractsLate += (Func<string>) (() => ItemSlot.GetGamepadInstructions(Main.InPipBanner ? 35 : 22));
    for (int index = 1500; index < 1550; ++index)
    {
      UILinkPoint uiLinkPoint7 = new UILinkPoint(index, true, index, index, -1, -2);
      cp11.LinkMap.Add(index, uiLinkPoint7);
    }
    cp11.LinkMap.Add(11001, new UILinkPoint(11001, true, 1501, 11002, -1, 11003));
    cp11.LinkMap.Add(11002, new UILinkPoint(11002, true, 11001, -4, -1, 11003));
    cp11.LinkMap.Add(11003, new UILinkPoint(11003, true, 1501, -4, 11001, 1502));
    cp11.LinkMap[1500].OnSpecialInteracts += (Func<string>) (() => ItemSlot.GetGamepadInstructions(ref Main.guideItem, 7));
    cp11.LinkMap[11001].OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Language.GetTextValue("UI.ToggleClassicGrid"), PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]));
    cp11.UpdateEvent += (Action) (() =>
    {
      cp11.PageOnLeft = Player.Settings.CraftingGridControl == Player.Settings.CraftingGridMode.Classic ? 10 : 8;
      int num11 = UILinkPointNavigator.Shortcuts.CRAFT_CurrentIngredientsCount;
      int num12 = num11;
      if (UILinksInitializer.MainnumAvailableRecipes > 0)
        num12 += 2;
      if (num11 < num12)
        num11 = num12;
      if (UILinkPointNavigator.OverridePoint == -1)
      {
        if (cp11.CurrentPoint == 11003)
        {
          if (Main.InGuideCraftMenu)
            UILinkPointNavigator.ChangePoint(1501);
        }
        else if (cp11.CurrentPoint != 11001)
        {
          if (cp11.CurrentPoint == 11002)
          {
            if (!Main.bannerUI.AnyAvailableBanners || Main.InGuideCraftMenu)
              UILinkPointNavigator.ChangePoint(11001);
          }
          else if (cp11.CurrentPoint == 1500)
          {
            if (!Main.InGuideCraftMenu)
              UILinkPointNavigator.ChangePoint(1501);
          }
          else if (cp11.CurrentPoint > 1500 + num11)
            UILinkPointNavigator.ChangePoint(1500);
        }
      }
      bool flag = Main.LocalPlayer.chest < 0;
      for (int index = 1; index < num11; ++index)
      {
        cp11.LinkMap[1500 + index].Left = 1500 + index - 1;
        cp11.LinkMap[1500 + index].Right = index == num11 - 2 ? -4 : 1500 + index + 1;
        if (index >= 2)
        {
          cp11.LinkMap[1500 + index].Up = Main.InGuideCraftMenu ? 1500 : (flag ? 11003 : -1);
          cp11.LinkMap[1500 + index].Down = flag ? -1 : (index < 3 || !Main.bannerUI.AnyAvailableBanners ? 11001 : 11002);
        }
      }
      cp11.LinkMap[1501].Left = -3;
      if (num11 > 0)
        cp11.LinkMap[1500 + num11 - 1].Right = -4;
      cp11.LinkMap[1500].Down = num11 >= 2 ? 1502 : -2;
      cp11.LinkMap[1500].Left = num11 >= 1 ? 1501 : -3;
      cp11.LinkMap[1500].Up = 11001;
      cp11.LinkMap[11001].Left = Main.InPipCrafting ? 1501 : 12000;
      cp11.LinkMap[11001].Down = !Main.InPipCrafting ? -1 : (Main.InGuideCraftMenu ? 1500 : 11003);
      cp11.LinkMap[11001].Right = !Main.bannerUI.AnyAvailableBanners || Main.InGuideCraftMenu ? -1 : 11002;
      cp11.LinkMap[11001].Up = flag ? -1 : 1502;
      cp11.LinkMap[11002].Down = !Main.InPipCrafting ? -1 : 11003;
      cp11.LinkMap[11002].Up = flag ? -1 : (num11 >= 5 ? 1503 : 1502);
      cp11.LinkMap[11003].Down = flag ? 1502 : -1;
    });
    cp11.LinkMap[1501].OnSpecialInteracts += (Func<string>) (() => ItemSlot.GetCraftSlotGamepadInstructions());
    cp11.ReachEndEvent += (Action<int, int>) ((current, next) =>
    {
      switch (current)
      {
        case 1500:
          break;
        case 1501:
          switch (next)
          {
            case -2:
              if (UILinksInitializer.MainfocusRecipe >= UILinksInitializer.MainnumAvailableRecipes - 1)
                return;
              ++UILinksInitializer.MainfocusRecipe;
              return;
            case -1:
              if (UILinksInitializer.MainfocusRecipe <= 0)
                return;
              --UILinksInitializer.MainfocusRecipe;
              return;
            default:
              return;
          }
        default:
          switch (next)
          {
            case -2:
              if (UILinksInitializer.MainfocusRecipe >= UILinksInitializer.MainnumAvailableRecipes - 1)
                return;
              UILinkPointNavigator.ChangePoint(1501);
              ++UILinksInitializer.MainfocusRecipe;
              return;
            case -1:
              if (UILinksInitializer.MainfocusRecipe <= 0)
                return;
              UILinkPointNavigator.ChangePoint(1501);
              --UILinksInitializer.MainfocusRecipe;
              return;
            default:
              return;
          }
      }
    });
    cp11.EnterEvent += (Action) (() =>
    {
      Main.PipsUseGrid = false;
      PlayerInput.LockGamepadButtons("MouseLeft");
    });
    cp11.CanEnterEvent += (Func<bool>) (() =>
    {
      if (!Main.playerInventory)
        return false;
      return UILinksInitializer.MainnumAvailableRecipes > 0 || Main.InGuideCraftMenu;
    });
    cp11.IsValidEvent += (Func<bool>) (() =>
    {
      if (!Main.playerInventory)
        return false;
      return UILinksInitializer.MainnumAvailableRecipes > 0 || Main.InGuideCraftMenu;
    });
    cp11.PageOnLeft = 8;
    cp11.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(cp11, 9);
    UILinkPage cp12 = new UILinkPage();
    cp12.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp12.OnSpecialInteractsLate += (Func<string>) (() => ItemSlot.GetGamepadInstructions(Main.InPipBanner ? 35 : 22));
    for (int index = 22000; index < 30000; ++index)
    {
      UILinkPoint uiLinkPoint8 = new UILinkPoint(index, true, index, index, index, index);
      int IHateLambda = index;
      uiLinkPoint8.OnSpecialInteracts += (Func<string>) (() =>
      {
        string str = PlayerInput.BuildCommand(Lang.misc[73].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
        if (UILinksInitializer.TryQuickCrafting(22000, IHateLambda))
          str += PlayerInput.BuildCommand(Lang.misc[71].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Grapple"]);
        return str;
      });
      cp12.LinkMap.Add(index, uiLinkPoint8);
    }
    cp12.UpdateEvent += (Action) (() =>
    {
      int num13 = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerRow;
      int craftIconsPerColumn = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerColumn;
      if (num13 == 0)
        num13 = 100;
      int num14 = num13 * craftIconsPerColumn;
      if (num14 > 8000)
        num14 = 8000;
      if (num14 > UILinksInitializer.MainnumAvailableRecipes)
        num14 = UILinksInitializer.MainnumAvailableRecipes;
      for (int index = 0; index < num14; ++index)
      {
        cp12.LinkMap[22000 + index].Left = index % num13 == 0 ? -3 : 22000 + index - 1;
        cp12.LinkMap[22000 + index].Right = (index + 1) % num13 == 0 || index == UILinksInitializer.MainnumAvailableRecipes - 1 ? -4 : 22000 + index + 1;
        cp12.LinkMap[22000 + index].Down = index < num14 - num13 ? 22000 + index + num13 : -2;
        cp12.LinkMap[22000 + index].Up = index < num13 ? -1 : 22000 + index - num13;
      }
      cp12.PageOnLeft = UILinksInitializer.GetCornerWrapPageIdFromLeftToRight();
    });
    cp12.ReachEndEvent += (Action<int, int>) ((current, next) =>
    {
      int craftIconsPerRow = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerRow;
      switch (next)
      {
        case -2:
          Main.recStart += craftIconsPerRow;
          SoundEngine.PlaySound(12);
          if (Main.recStart <= UILinksInitializer.MainnumAvailableRecipes - craftIconsPerRow)
            break;
          Main.recStart = UILinksInitializer.MainnumAvailableRecipes - craftIconsPerRow;
          break;
        case -1:
          Main.recStart -= craftIconsPerRow;
          if (Main.recStart >= 0)
            break;
          Main.recStart = 0;
          break;
      }
    });
    cp12.EnterEvent += (Action) (() => Main.PipsUseGrid = true);
    cp12.LeaveEvent += (Action) (() => Main.PipsUseGrid = false);
    cp12.CanEnterEvent += (Func<bool>) (() => Main.playerInventory && UILinksInitializer.MainnumAvailableRecipes > 0);
    cp12.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.PipsUseGrid && UILinksInitializer.MainnumAvailableRecipes > 0);
    cp12.PageOnLeft = 0;
    cp12.PageOnRight = 9;
    UILinkPointNavigator.RegisterPage(cp12, 10);
    UILinkPage cp13 = new UILinkPage();
    cp13.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    for (int index = 2605; index < 2620; ++index)
    {
      UILinkPoint uiLinkPoint9 = new UILinkPoint(index, true, index, index, index, index);
      uiLinkPoint9.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[73].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]));
      cp13.LinkMap.Add(index, uiLinkPoint9);
    }
    cp13.UpdateEvent += (Action) (() =>
    {
      int num15 = 5;
      int num16 = 3;
      int num17 = num15 * num16;
      int count = Main.Hairstyles.AvailableHairstyles.Count;
      for (int index = 0; index < num17; ++index)
      {
        cp13.LinkMap[2605 + index].Left = index % num15 == 0 ? -3 : 2605 + index - 1;
        cp13.LinkMap[2605 + index].Right = (index + 1) % num15 == 0 || index == count - 1 ? -4 : 2605 + index + 1;
        cp13.LinkMap[2605 + index].Down = index < num17 - num15 ? 2605 + index + num15 : -2;
        cp13.LinkMap[2605 + index].Up = index < num15 ? -1 : 2605 + index - num15;
      }
    });
    cp13.ReachEndEvent += (Action<int, int>) ((current, next) =>
    {
      int num18 = 5;
      if (next == -1)
      {
        Main.hairStart -= num18;
        SoundEngine.PlaySound(12);
      }
      else
      {
        if (next != -2)
          return;
        Main.hairStart += num18;
        SoundEngine.PlaySound(12);
      }
    });
    cp13.CanEnterEvent += (Func<bool>) (() => Main.hairWindow);
    cp13.IsValidEvent += (Func<bool>) (() => Main.hairWindow);
    cp13.PageOnLeft = 12;
    cp13.PageOnRight = 12;
    UILinkPointNavigator.RegisterPage(cp13, 11);
    UILinkPage page5 = new UILinkPage();
    page5.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    page5.LinkMap.Add(2600, new UILinkPoint(2600, true, -3, -4, -1, 2601));
    page5.LinkMap.Add(2601, new UILinkPoint(2601, true, -3, -4, 2600, 2602));
    page5.LinkMap.Add(2602, new UILinkPoint(2602, true, -3, -4, 2601, 2603));
    page5.LinkMap.Add(2603, new UILinkPoint(2603, true, -3, 2604, 2602, -2));
    page5.LinkMap.Add(2604, new UILinkPoint(2604, true, 2603, -4, 2602, -2));
    page5.UpdateEvent += (Action) (() =>
    {
      Vector3 hsl = Main.rgbToHsl(Main.selColor);
      float interfaceDeadzoneX = PlayerInput.CurrentProfile.InterfaceDeadzoneX;
      float x = PlayerInput.GamepadThumbstickLeft.X;
      float num19 = (double) x < -(double) interfaceDeadzoneX || (double) x > (double) interfaceDeadzoneX ? MathHelper.Lerp(0.0f, 0.008333334f, (float) (((double) Math.Abs(x) - (double) interfaceDeadzoneX) / (1.0 - (double) interfaceDeadzoneX))) * (float) Math.Sign(x) : 0.0f;
      int currentPoint = UILinkPointNavigator.CurrentPoint;
      if (currentPoint == 2600)
        Main.hBar = MathHelper.Clamp(Main.hBar + num19, 0.0f, 1f);
      if (currentPoint == 2601)
        Main.sBar = MathHelper.Clamp(Main.sBar + num19, 0.0f, 1f);
      if (currentPoint == 2602)
        Main.lBar = MathHelper.Clamp(Main.lBar + num19, 0.15f, 1f);
      Vector3 zero = Vector3.Zero;
      Vector3 one = Vector3.One;
      Vector3.Clamp(hsl, zero, one);
      if ((double) num19 == 0.0)
        return;
      if (Main.hairWindow)
        Main.player[Main.myPlayer].hairColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
      SoundEngine.PlaySound(12);
    });
    page5.CanEnterEvent += (Func<bool>) (() => Main.hairWindow);
    page5.IsValidEvent += (Func<bool>) (() => Main.hairWindow);
    page5.PageOnLeft = 11;
    page5.PageOnRight = 11;
    UILinkPointNavigator.RegisterPage(page5, 12);
    UILinkPage cp14 = new UILinkPage();
    for (int index = 0; index < 30; ++index)
    {
      cp14.LinkMap.Add(2900 + index, new UILinkPoint(2900 + index, true, -3, -4, -1, -2));
      cp14.LinkMap[2900 + index].OnSpecialInteracts += func1;
    }
    cp14.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp14.TravelEvent += (Action) (() =>
    {
      if (UILinkPointNavigator.CurrentPage != cp14.ID)
        return;
      int num20 = cp14.CurrentPoint - 2900;
      if (num20 >= 5)
        return;
      IngameOptions.category = num20;
    });
    cp14.UpdateEvent += (Action) (() =>
    {
      int num21 = UILinkPointNavigator.Shortcuts.INGAMEOPTIONS_BUTTONS_LEFT;
      if (num21 == 0)
        num21 = 5;
      if (UILinkPointNavigator.OverridePoint == -1 && cp14.CurrentPoint < 2930 && cp14.CurrentPoint > 2900 + num21 - 1)
        UILinkPointNavigator.ChangePoint(2900);
      for (int key = 2900; key < 2900 + num21; ++key)
      {
        cp14.LinkMap[key].Up = key - 1;
        cp14.LinkMap[key].Down = key + 1;
      }
      cp14.LinkMap[2900].Up = 2900 + num21 - 1;
      cp14.LinkMap[2900 + num21 - 1].Down = 2900;
      int num22 = cp14.CurrentPoint - 2900;
      if (num22 < 4 && UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.MouseLeft)
      {
        IngameOptions.category = num22;
        UILinkPointNavigator.ChangePage(1002);
      }
      int num23 = (SocialAPI.Network == null ? 0 : (SocialAPI.Network.CanInvite() ? 1 : 0)) != 0 ? 1 : 0;
      if (num22 != 4 + num23 || !UILinksInitializer.CanExecuteInputCommand() || !PlayerInput.Triggers.JustPressed.MouseLeft)
        return;
      UILinkPointNavigator.ChangePage(1004);
    });
    cp14.EnterEvent += (Action) (() => cp14.CurrentPoint = 2900 + IngameOptions.category);
    cp14.PageOnLeft = cp14.PageOnRight = 1002;
    cp14.IsValidEvent += (Func<bool>) (() => Main.ingameOptionsWindow && !Main.InGameUI.IsVisible);
    cp14.CanEnterEvent += (Func<bool>) (() => Main.ingameOptionsWindow && !Main.InGameUI.IsVisible);
    UILinkPointNavigator.RegisterPage(cp14, 1001);
    UILinkPage cp15 = new UILinkPage();
    for (int index = 0; index < 30; ++index)
    {
      cp15.LinkMap.Add(2930 + index, new UILinkPoint(2930 + index, true, -3, -4, -1, -2));
      cp15.LinkMap[2930 + index].OnSpecialInteracts += func1;
    }
    cp15.EnterEvent += (Action) (() => Main.mouseLeftRelease = false);
    cp15.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp15.UpdateEvent += (Action) (() =>
    {
      int num24 = UILinkPointNavigator.Shortcuts.INGAMEOPTIONS_BUTTONS_RIGHT;
      if (num24 == 0)
        num24 = 5;
      if (UILinkPointNavigator.OverridePoint == -1 && cp15.CurrentPoint >= 2930 && cp15.CurrentPoint > 2930 + num24 - 1)
        UILinkPointNavigator.ChangePoint(2930);
      for (int key = 2930; key < 2930 + num24; ++key)
      {
        cp15.LinkMap[key].Up = key - 1;
        cp15.LinkMap[key].Down = key + 1;
      }
      cp15.LinkMap[2930].Up = -1;
      cp15.LinkMap[2930 + num24 - 1].Down = -2;
      UILinksInitializer.HandleOptionsSpecials();
    });
    cp15.PageOnLeft = cp15.PageOnRight = 1001;
    cp15.IsValidEvent += (Func<bool>) (() => Main.ingameOptionsWindow);
    cp15.CanEnterEvent += (Func<bool>) (() => Main.ingameOptionsWindow);
    UILinkPointNavigator.RegisterPage(cp15, 1002);
    UILinkPage cp16 = new UILinkPage();
    cp16.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    for (int index = 1550; index < 1558; ++index)
    {
      UILinkPoint uiLinkPoint10 = new UILinkPoint(index, true, -3, -4, -1, -2);
      switch (index - 1550)
      {
        case 1:
        case 3:
        case 5:
          uiLinkPoint10.Up = uiLinkPoint10.ID - 2;
          uiLinkPoint10.Down = uiLinkPoint10.ID + 2;
          uiLinkPoint10.Right = uiLinkPoint10.ID + 1;
          break;
        case 2:
        case 4:
        case 6:
          uiLinkPoint10.Up = uiLinkPoint10.ID - 2;
          uiLinkPoint10.Down = uiLinkPoint10.ID + 2;
          uiLinkPoint10.Left = uiLinkPoint10.ID - 1;
          break;
      }
      cp16.LinkMap.Add(index, uiLinkPoint10);
    }
    cp16.LinkMap[1550].Down = 1551;
    cp16.LinkMap[1550].Right = 120;
    cp16.LinkMap[1550].Up = 307;
    cp16.LinkMap[1552].Right = 121;
    cp16.LinkMap[1554].Right = 121;
    cp16.LinkMap[1555].Down = 1570;
    cp16.LinkMap[1556].Down = 1570;
    cp16.LinkMap[1556].Right = 122;
    cp16.LinkMap[1557].Up = 1570;
    cp16.LinkMap[1557].Down = 308;
    cp16.LinkMap[1557].Right = (int) sbyte.MaxValue;
    cp16.LinkMap.Add(1570, new UILinkPoint(1570, true, -3, -4, -1, -2));
    cp16.LinkMap[1570].Up = 1555;
    cp16.LinkMap[1570].Down = 1557;
    cp16.LinkMap[1570].Right = 126;
    for (int index = 0; index < 7; ++index)
      cp16.LinkMap[1550 + index].OnSpecialInteracts += func1;
    cp16.UpdateEvent += (Action) (() =>
    {
      cp16.LinkMap[1551].Up = Main.ShouldPVPDraw ? 1550 : -1;
      cp16.LinkMap[1552].Up = Main.ShouldPVPDraw ? 1550 : -1;
      cp16.LinkMap[1570].Up = Main.ShouldTeamSelectDraw ? 1555 : -1;
      int infoacccount = UILinkPointNavigator.Shortcuts.INFOACCCOUNT;
      if (infoacccount > 0)
        cp16.LinkMap[1570].Up = 1558 + (infoacccount - 1) / 2 * 2;
      if (!Main.ShouldTeamSelectDraw)
        return;
      if (infoacccount >= 1)
      {
        cp16.LinkMap[1555].Down = 1558;
        cp16.LinkMap[1556].Down = 1558;
      }
      else
      {
        cp16.LinkMap[1555].Down = 1570;
        cp16.LinkMap[1556].Down = 1570;
      }
      if (infoacccount >= 2)
        cp16.LinkMap[1556].Down = 1559;
      else
        cp16.LinkMap[1556].Down = 1570;
    });
    cp16.IsValidEvent += (Func<bool>) (() => Main.playerInventory);
    cp16.PageOnLeft = 8;
    cp16.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp16, 16 /*0x10*/);
    UILinkPage cp17 = new UILinkPage();
    cp17.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    for (int index = 1558; index < 1570; ++index)
    {
      UILinkPoint uiLinkPoint11 = new UILinkPoint(index, true, -3, -4, -1, -2);
      uiLinkPoint11.OnSpecialInteracts += func1;
      switch (index - 1558)
      {
        case 1:
        case 3:
        case 5:
          uiLinkPoint11.Up = uiLinkPoint11.ID - 2;
          uiLinkPoint11.Down = uiLinkPoint11.ID + 2;
          uiLinkPoint11.Right = uiLinkPoint11.ID + 1;
          break;
        case 2:
        case 4:
        case 6:
          uiLinkPoint11.Up = uiLinkPoint11.ID - 2;
          uiLinkPoint11.Down = uiLinkPoint11.ID + 2;
          uiLinkPoint11.Left = uiLinkPoint11.ID - 1;
          break;
      }
      cp17.LinkMap.Add(index, uiLinkPoint11);
    }
    cp17.UpdateEvent += (Action) (() =>
    {
      int infoacccount = UILinkPointNavigator.Shortcuts.INFOACCCOUNT;
      if (UILinkPointNavigator.OverridePoint == -1 && cp17.CurrentPoint - 1558 >= infoacccount)
        UILinkPointNavigator.ChangePoint(1558 + infoacccount - 1);
      for (int index = 0; index < infoacccount; ++index)
      {
        bool flag = index % 2 == 0;
        int key = index + 1558;
        cp17.LinkMap[key].Down = index < infoacccount - 2 ? key + 2 : 1570;
        cp17.LinkMap[key].Up = index > 1 ? key - 2 : (Main.ShouldTeamSelectDraw ? (flag ? 1555 : 1556) : -1);
        cp17.LinkMap[key].Right = !flag || index + 1 >= infoacccount ? 123 + index / 4 : key + 1;
        cp17.LinkMap[key].Left = flag ? -3 : key - 1;
      }
    });
    cp17.IsValidEvent += (Func<bool>) (() => Main.playerInventory && UILinkPointNavigator.Shortcuts.INFOACCCOUNT > 0);
    cp17.PageOnLeft = 8;
    cp17.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp17, 17);
    UILinkPage cp18 = new UILinkPage();
    cp18.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    for (int index = 6000; index < 6012; ++index)
    {
      UILinkPoint uiLinkPoint12 = new UILinkPoint(index, true, -3, -4, -1, -2);
      switch (index - 6000)
      {
        case 0:
          uiLinkPoint12.Right = 0;
          break;
        case 1:
        case 2:
          uiLinkPoint12.Right = 10;
          break;
        case 3:
        case 4:
          uiLinkPoint12.Right = 20;
          break;
        case 5:
        case 6:
          uiLinkPoint12.Right = 30;
          break;
        default:
          uiLinkPoint12.Right = 40;
          break;
      }
      cp18.LinkMap.Add(index, uiLinkPoint12);
    }
    cp18.UpdateEvent += (Action) (() =>
    {
      int builderacccount = UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT;
      if (UILinkPointNavigator.OverridePoint == -1 && cp18.CurrentPoint - 6000 >= builderacccount)
        UILinkPointNavigator.ChangePoint(6000 + builderacccount - 1);
      for (int index = 0; index < builderacccount; ++index)
      {
        int num25 = index % 2;
        int key = index + 6000;
        cp18.LinkMap[key].Down = index < builderacccount - 1 ? key + 1 : -2;
        cp18.LinkMap[key].Up = index > 0 ? key - 1 : -1;
      }
    });
    cp18.IsValidEvent += (Func<bool>) (() => Main.playerInventory && UILinkPointNavigator.Shortcuts.BUILDERACCCOUNT > 0);
    cp18.PageOnLeft = 8;
    cp18.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp18, 18);
    UILinkPage page6 = new UILinkPage();
    page6.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    page6.LinkMap.Add(2806, new UILinkPoint(2806, true, 2805, 2807, -1, 2808));
    page6.LinkMap.Add(2807, new UILinkPoint(2807, true, 2806, 2810, -1, 2809));
    page6.LinkMap.Add(2808, new UILinkPoint(2808, true, 2813, 2809, 2806, -2));
    page6.LinkMap.Add(2809, new UILinkPoint(2809, true, 2808, 2811, 2807, -2));
    page6.LinkMap.Add(2810, new UILinkPoint(2810, true, 2807, -4, -1, 2811));
    page6.LinkMap.Add(2811, new UILinkPoint(2811, true, 2809, -4, 2810, -2));
    page6.LinkMap.Add(2805, new UILinkPoint(2805, true, -3, 2806, -1, 2813));
    page6.LinkMap.Add(2813, new UILinkPoint(2813, true, -3, 2808, 2805, -2));
    page6.LinkMap[2806].OnSpecialInteracts += func1;
    page6.LinkMap[2807].OnSpecialInteracts += func1;
    page6.LinkMap[2808].OnSpecialInteracts += func1;
    page6.LinkMap[2809].OnSpecialInteracts += func1;
    page6.LinkMap[2805].OnSpecialInteracts += func1;
    page6.LinkMap[2813].OnSpecialInteracts += func1;
    page6.CanEnterEvent += (Func<bool>) (() => Main.clothesWindow);
    page6.IsValidEvent += (Func<bool>) (() => Main.clothesWindow);
    page6.EnterEvent += (Action) (() => Main.player[Main.myPlayer].releaseInventory = false);
    page6.LeaveEvent += (Action) (() => Main.player[Main.myPlayer].LockGamepadTileInteractions());
    page6.PageOnLeft = 15;
    page6.PageOnRight = 15;
    UILinkPointNavigator.RegisterPage(page6, 14);
    UILinkPage page7 = new UILinkPage();
    page7.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    page7.LinkMap.Add(2800, new UILinkPoint(2800, true, -3, -4, -1, 2801));
    page7.LinkMap.Add(2801, new UILinkPoint(2801, true, -3, -4, 2800, 2802));
    page7.LinkMap.Add(2802, new UILinkPoint(2802, true, -3, -4, 2801, 2812));
    page7.LinkMap.Add(2812, new UILinkPoint(2812, true, -3, -4, 2802, 2803));
    page7.LinkMap.Add(2803, new UILinkPoint(2803, true, -3, 2804, 2812, -2));
    page7.LinkMap.Add(2804, new UILinkPoint(2804, true, 2803, -4, 2812, -2));
    page7.LinkMap[2800].OnSpecialInteracts += func1;
    page7.LinkMap[2801].OnSpecialInteracts += func1;
    page7.LinkMap[2802].OnSpecialInteracts += func1;
    page7.LinkMap[2812].OnSpecialInteracts += func1;
    page7.LinkMap[2803].OnSpecialInteracts += func1;
    page7.LinkMap[2804].OnSpecialInteracts += func1;
    page7.UpdateEvent += (Action) (() =>
    {
      Vector3 hsl = Main.rgbToHsl(Main.selColor);
      float interfaceDeadzoneX = PlayerInput.CurrentProfile.InterfaceDeadzoneX;
      float x = PlayerInput.GamepadThumbstickLeft.X;
      float num26 = (double) x < -(double) interfaceDeadzoneX || (double) x > (double) interfaceDeadzoneX ? MathHelper.Lerp(0.0f, 0.008333334f, (float) (((double) Math.Abs(x) - (double) interfaceDeadzoneX) / (1.0 - (double) interfaceDeadzoneX))) * (float) Math.Sign(x) : 0.0f;
      int currentPoint = UILinkPointNavigator.CurrentPoint;
      if (currentPoint == 2800)
        Main.hBar = MathHelper.Clamp(Main.hBar + num26, 0.0f, 1f);
      if (currentPoint == 2801)
        Main.sBar = MathHelper.Clamp(Main.sBar + num26, 0.0f, 1f);
      if (currentPoint == 2802)
        Main.lBar = MathHelper.Clamp(Main.lBar + num26, 0.15f, 1f);
      if (currentPoint == 2812)
        Main.player[Main.myPlayer].voicePitchOffset = MathHelper.Clamp(Main.player[Main.myPlayer].voicePitchOffset + num26, -1f, 1f);
      Vector3 zero = Vector3.Zero;
      Vector3 one = Vector3.One;
      Vector3.Clamp(hsl, zero, one);
      if ((double) num26 != 0.0)
      {
        if (Main.clothesWindow)
        {
          Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
          switch (Main.selClothes)
          {
            case 0:
              Main.player[Main.myPlayer].shirtColor = Main.selColor;
              break;
            case 1:
              Main.player[Main.myPlayer].underShirtColor = Main.selColor;
              break;
            case 2:
              Main.player[Main.myPlayer].pantsColor = Main.selColor;
              break;
            case 3:
              Main.player[Main.myPlayer].shoeColor = Main.selColor;
              break;
          }
        }
        if (currentPoint != 2812)
          SoundEngine.PlaySound(12);
      }
      if (currentPoint != 2812)
        return;
      bool flag = (double) num26 != 0.0;
      if (Main.WasDraggingPlayerAudio && !flag)
        Main.player[Main.myPlayer].PlayHurtSound();
      Main.WasDraggingPlayerAudio = flag;
    });
    page7.CanEnterEvent += (Func<bool>) (() => Main.clothesWindow);
    page7.IsValidEvent += (Func<bool>) (() => Main.clothesWindow);
    page7.EnterEvent += (Action) (() =>
    {
      Main.player[Main.myPlayer].releaseInventory = false;
      Main.WasDraggingPlayerAudio = false;
    });
    page7.LeaveEvent += (Action) (() => Main.player[Main.myPlayer].LockGamepadTileInteractions());
    page7.PageOnLeft = 14;
    page7.PageOnRight = 14;
    UILinkPointNavigator.RegisterPage(page7, 15);
    UILinkPage cp19 = new UILinkPage();
    cp19.UpdateEvent += (Action) (() => PlayerInput.GamepadAllowScrolling = true);
    for (int index = 3000; index <= 4999; ++index)
      cp19.LinkMap.Add(index, new UILinkPoint(index, true, -3, -4, -1, -2));
    cp19.OnSpecialInteracts += (Func<string>) (() => Main.InGameUI.CurrentState is UIBestiaryTest ? PlayerInput.BuildCommand(Lang.misc[82].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Language.GetText("UI.SwitchPage").Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]) + PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]) + UILinksInitializer.FancyUISpecialInstructions() : PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]) + PlayerInput.BuildCommand(Lang.misc[82].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + UILinksInitializer.FancyUISpecialInstructions());
    cp19.UpdateEvent += (Action) (() =>
    {
      if (!UILinksInitializer.CanExecuteInputCommand() || !PlayerInput.Triggers.JustPressed.Inventory)
        return;
      UILinksInitializer.FancyExit();
    });
    cp19.EnterEvent += (Action) (() => cp19.CurrentPoint = 3002);
    cp19.CanEnterEvent += (Func<bool>) (() => Main.MenuUI.IsVisible || Main.InGameUI.IsVisible);
    cp19.IsValidEvent += (Func<bool>) (() => Main.MenuUI.IsVisible || Main.InGameUI.IsVisible);
    cp19.OnPageMoveAttempt += new Action<int>(UILinksInitializer.OnFancyUIPageMoveAttempt);
    UILinkPointNavigator.RegisterPage(cp19, 1004);
    UILinkPage cp20 = new UILinkPage();
    cp20.UpdateEvent += (Action) (() => PlayerInput.GamepadAllowScrolling = true);
    for (int index = 10000; index <= 11000; ++index)
      cp20.LinkMap.Add(index, new UILinkPoint(index, true, -3, -4, -1, -2));
    for (int index = 15000; index <= 15000; ++index)
      cp20.LinkMap.Add(index, new UILinkPoint(index, true, -3, -4, -1, -2));
    cp20.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]) + PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]) + UILinksInitializer.FancyUISpecialInstructions());
    cp20.UpdateEvent += (Action) (() =>
    {
      if (!UILinksInitializer.CanExecuteInputCommand() || !PlayerInput.Triggers.JustPressed.Inventory)
        return;
      UILinksInitializer.FancyExit();
    });
    cp20.EnterEvent += (Action) (() => cp20.CurrentPoint = 10000);
    cp20.CanEnterEvent += new Func<bool>(UILinksInitializer.CanEnterCreativeMenu);
    cp20.IsValidEvent += new Func<bool>(UILinksInitializer.CanEnterCreativeMenu);
    cp20.OnPageMoveAttempt += new Action<int>(UILinksInitializer.OnFancyUIPageMoveAttempt);
    cp20.PageOnLeft = 8;
    cp20.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(cp20, 1005);
    UILinkPage page8 = new UILinkPage();
    for (int index = 20000; index < 21000; ++index)
      page8.LinkMap.Add(index, new UILinkPoint(index, true, -3, -4, -1, -2));
    page8.CanEnterEvent += (Func<bool>) (() => NewCraftingUI.Visible);
    page8.IsValidEvent += (Func<bool>) (() => NewCraftingUI.Visible);
    page8.OnPageMoveAttempt += new Action<int>(UILinksInitializer.OnFancyUIPageMoveAttempt);
    page8.PageOnLeft = 8;
    page8.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(page8, 24);
    UILinkPage cp21 = new UILinkPage();
    cp21.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    Func<string> func19 = (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[94].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]));
    for (int index = 9000; index <= 9050; ++index)
    {
      UILinkPoint uiLinkPoint13 = new UILinkPoint(index, true, index + 10, index - 10, index - 1, index + 1);
      cp21.LinkMap.Add(index, uiLinkPoint13);
      uiLinkPoint13.OnSpecialInteracts += func19;
    }
    cp21.UpdateEvent += (Action) (() =>
    {
      int num27 = UILinkPointNavigator.Shortcuts.BUFFS_PER_COLUMN;
      if (num27 == 0)
        num27 = 100;
      for (int index = 0; index < 50; ++index)
      {
        cp21.LinkMap[9000 + index].Up = index % num27 == 0 ? -1 : 9000 + index - 1;
        if (cp21.LinkMap[9000 + index].Up == -1)
          cp21.LinkMap[9000 + index].Up = index < num27 ? 189 : 184;
        cp21.LinkMap[9000 + index].Down = (index + 1) % num27 == 0 || index == UILinkPointNavigator.Shortcuts.BUFFS_DRAWN - 1 ? 308 : 9000 + index + 1;
        cp21.LinkMap[9000 + index].Left = index < UILinkPointNavigator.Shortcuts.BUFFS_DRAWN - num27 ? 9000 + index + num27 : -3;
        cp21.LinkMap[9000 + index].Right = index < num27 ? -4 : 9000 + index - num27;
      }
    });
    cp21.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.EquipPage == 2 && UILinkPointNavigator.Shortcuts.BUFFS_DRAWN > 0);
    cp21.PageOnLeft = 8;
    cp21.PageOnRight = 8;
    UILinkPointNavigator.RegisterPage(cp21, 19);
    UILinkPage page9 = new UILinkPage();
    page9.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    page9.OnSpecialInteractsLate += (Func<string>) (() => ItemSlot.GetGamepadInstructions(35));
    page9.LinkMap.Add(12000, new UILinkPoint(12000, true, -3, 11001, -1, -2));
    page9.LinkMap[12000].OnSpecialInteracts += (Func<string>) (() =>
    {
      string str = "";
      if (Main.mouseItem.stack <= 0 || Main.mouseItem.type == Main.bannerUI.FocusedItemType && Main.mouseItem.stack < Main.mouseItem.maxStack)
        str += PlayerInput.BuildCommand(Language.GetTextValue("UI.GamepadClaimBanner"), PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"], PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
      return str;
    });
    page9.ReachEndEvent += (Action<int, int>) ((current, next) =>
    {
      bool flag = next == -1;
      int yOffset = (next == -2).ToInt() - flag.ToInt();
      Main.bannerUI.NavigatePipsList(yOffset);
    });
    page9.EnterEvent += (Action) (() =>
    {
      Main.PipsUseGrid = false;
      PlayerInput.LockGamepadButtons("MouseLeft");
    });
    page9.CanEnterEvent += (Func<bool>) (() => Main.playerInventory && Main.bannerUI.AnyAvailableBanners);
    page9.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.bannerUI.AnyAvailableBanners);
    page9.PageOnLeft = 23;
    page9.PageOnRight = 0;
    UILinkPointNavigator.RegisterPage(page9, 22);
    UILinkPage cp22 = new UILinkPage();
    cp22.OnSpecialInteracts += (Func<string>) (() => PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]) + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]));
    cp22.OnSpecialInteractsLate += (Func<string>) (() => ItemSlot.GetGamepadInstructions(35));
    UILinkPoint uiLinkPoint14 = new UILinkPoint(11100, true, -3, -4, -1, -2);
    cp22.LinkMap.Add(11100, uiLinkPoint14);
    cp22.UpdateEvent += (Action) (() =>
    {
      int craftIconsPerRow = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerRow;
      int craftIconsPerColumn = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerColumn;
      cp22.PageOnLeft = UILinksInitializer.GetCornerWrapPageIdFromLeftToRight();
    });
    cp22.ReachEndEvent += (Action<int, int>) ((current, next) =>
    {
      bool flag7 = next == -3;
      int xOffset = (next == -4).ToInt() - flag7.ToInt();
      bool flag8 = next == -1;
      int yOffset = (next == -2).ToInt() - flag8.ToInt();
      Main.bannerUI.NavigatePipsGrid(xOffset, yOffset);
    });
    cp22.EnterEvent += (Action) (() =>
    {
      Main.PipsUseGrid = true;
      Main.bannerUI.ResetGridSelection();
    });
    cp22.LeaveEvent += (Action) (() => Main.PipsUseGrid = false);
    cp22.CanEnterEvent += (Func<bool>) (() => Main.playerInventory && Main.bannerUI.AnyAvailableBanners);
    cp22.IsValidEvent += (Func<bool>) (() => Main.playerInventory && Main.PipsUseGrid && Main.bannerUI.AnyAvailableBanners);
    cp22.PageOnLeft = 0;
    cp22.PageOnRight = 22;
    UILinkPointNavigator.RegisterPage(cp22, 23);
    UILinkPage page10 = UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage];
    page10.CurrentPoint = page10.DefaultPoint;
    page10.Enter();
  }

  private static bool TryQuickCrafting(int startPoint, int pointOffset)
  {
    Player player = Main.player[Main.myPlayer];
    int num = Main.recStart + pointOffset;
    if (num >= UILinksInitializer.MainnumAvailableRecipes)
      return false;
    bool flag = false;
    int index = num - startPoint;
    Recipe recipe = Main.recipe[Main.availableRecipe[index]];
    if (Main.mouseItem.type == 0 && recipe.createItem.maxStack > 1 && player.ItemSpace(recipe.createItem).CanTakeItemToPersonalInventory && !player.HasLockedInventory())
    {
      flag = true;
      if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.Grapple)
        UILinksInitializer.SomeVarsForUILinkers.SequencedCraftingCurrent = recipe;
      if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.Current.Grapple && Main.stackSplit <= 1)
      {
        ItemSlot.RefreshStackSplitCooldown();
        if (UILinksInitializer.SomeVarsForUILinkers.SequencedCraftingCurrent == recipe)
          CraftingRequests.CraftItem(recipe, quickCraft: true);
      }
    }
    return flag;
  }

  private static bool CanEnterCreativeMenu()
  {
    return Main.LocalPlayer.chest == -1 && Main.LocalPlayer.talkNPC == -1 && Main.playerInventory && Main.CreativeMenu.Enabled;
  }

  private static int GetCornerWrapPageIdFromLeftToRight() => 8;

  private static int GetCornerWrapPageIdFromRightToLeft()
  {
    if (Main.CreativeMenu.Enabled)
      return 1005;
    if (NewCraftingUI.Visible)
      return 24;
    if (Main.InPipBanner)
      return 23;
    switch (Main.LocalPlayer.tileEntityAnchor.GetTileEntity())
    {
      case TEDisplayDoll _:
        return 20;
      case TEHatRack _:
        return 21;
      default:
        return 9;
    }
  }

  private static void OnFancyUIPageMoveAttempt(int direction)
  {
    if (Main.MenuUI.CurrentState is UICharacterCreation currentState1)
      currentState1.TryMovingCategory(direction);
    if (!(UserInterface.ActiveInstance.CurrentState is UIBestiaryTest currentState2))
      return;
    currentState2.TryMovingPages(direction);
  }

  public static void FancyExit()
  {
    switch (UILinkPointNavigator.Shortcuts.BackButtonCommand)
    {
      case 1:
        SoundEngine.PlaySound(11);
        Main.menuMode = 0;
        break;
      case 2:
        SoundEngine.PlaySound(11);
        Main.menuMode = Main.menuMultiplayer ? 12 : 1;
        break;
      case 3:
        Main.menuMode = 0;
        IngameFancyUI.Close();
        break;
      case 4:
        SoundEngine.PlaySound(11);
        Main.menuMode = 11;
        break;
      case 5:
        SoundEngine.PlaySound(11);
        Main.menuMode = 11;
        break;
      case 6:
        Main.LocalPlayer.releaseInventory = false;
        UIVirtualKeyboard.Cancel();
        break;
      case 7:
        if (!(Main.MenuUI.CurrentState is IHaveBackButtonCommand currentState))
          break;
        currentState.HandleBackButtonUsage();
        break;
    }
  }

  public static string FancyUISpecialInstructions()
  {
    string str1 = "";
    if (UILinkPointNavigator.Shortcuts.FANCYUI_SPECIAL_INSTRUCTIONS == 1)
    {
      if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.HotbarMinus)
      {
        UIVirtualKeyboard.CycleSymbols();
        PlayerInput.LockGamepadButtons("HotbarMinus");
        PlayerInput.SettingsForUI.TryRevertingToMouseMode();
      }
      string str2 = str1 + PlayerInput.BuildCommand(Lang.menu[235].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"]);
      if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.MouseRight)
      {
        UIVirtualKeyboard.BackSpace();
        PlayerInput.LockGamepadButtons("MouseRight");
        PlayerInput.SettingsForUI.TryRevertingToMouseMode();
      }
      string str3 = str2 + PlayerInput.BuildCommand(Lang.menu[236].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseRight"]);
      if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.SmartCursor)
      {
        UIVirtualKeyboard.Write(" ");
        PlayerInput.LockGamepadButtons("SmartCursor");
        PlayerInput.SettingsForUI.TryRevertingToMouseMode();
      }
      str1 = str3 + PlayerInput.BuildCommand(Lang.menu[238].Value, PlayerInput.ProfileGamepadUI.KeyStatus["SmartCursor"]);
      if (UIVirtualKeyboard.CanSubmit)
      {
        if (UILinksInitializer.CanExecuteInputCommand() && PlayerInput.Triggers.JustPressed.HotbarPlus)
        {
          UIVirtualKeyboard.Submit();
          PlayerInput.LockGamepadButtons("HotbarPlus");
          PlayerInput.SettingsForUI.TryRevertingToMouseMode();
        }
        str1 += PlayerInput.BuildCommand(Lang.menu[237].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]);
      }
    }
    return str1;
  }

  public static void HandleOptionsSpecials()
  {
    switch (UILinkPointNavigator.Shortcuts.OPTIONS_BUTTON_SPECIALFEATURE)
    {
      case 1:
        Main.bgScroll = (int) UILinksInitializer.HandleSliderHorizontalInput((float) Main.bgScroll, 0.0f, 100f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 1f);
        Main.caveParallax = (float) (1.0 - (double) Main.bgScroll / 500.0);
        break;
      case 2:
        Main.musicVolume = UILinksInitializer.HandleSliderHorizontalInput(Main.musicVolume, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
        break;
      case 3:
        Main.soundVolume = UILinksInitializer.HandleSliderHorizontalInput(Main.soundVolume, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
        break;
      case 4:
        Main.ambientVolume = UILinksInitializer.HandleSliderHorizontalInput(Main.ambientVolume, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
        break;
      case 5:
        double hBar = (double) Main.hBar;
        float num1 = Main.hBar = UILinksInitializer.HandleSliderHorizontalInput((float) hBar, 0.0f, 1f);
        if (hBar == (double) num1)
          break;
        switch (Main.menuMode)
        {
          case 17:
            Main.player[Main.myPlayer].hairColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 18:
            Main.player[Main.myPlayer].eyeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 19:
            Main.player[Main.myPlayer].skinColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 21:
            Main.player[Main.myPlayer].shirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 22:
            Main.player[Main.myPlayer].underShirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 23:
            Main.player[Main.myPlayer].pantsColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 24:
            Main.player[Main.myPlayer].shoeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 25:
            Main.mouseColorSlider.Hue = num1;
            break;
          case 252:
            Main.mouseBorderColorSlider.Hue = num1;
            break;
        }
        SoundEngine.PlaySound(12);
        break;
      case 6:
        double sBar = (double) Main.sBar;
        float num2 = Main.sBar = UILinksInitializer.HandleSliderHorizontalInput((float) sBar, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX);
        if (sBar == (double) num2)
          break;
        switch (Main.menuMode)
        {
          case 17:
            Main.player[Main.myPlayer].hairColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 18:
            Main.player[Main.myPlayer].eyeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 19:
            Main.player[Main.myPlayer].skinColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 21:
            Main.player[Main.myPlayer].shirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 22:
            Main.player[Main.myPlayer].underShirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 23:
            Main.player[Main.myPlayer].pantsColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 24:
            Main.player[Main.myPlayer].shoeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 25:
            Main.mouseColorSlider.Saturation = num2;
            break;
          case 252:
            Main.mouseBorderColorSlider.Saturation = num2;
            break;
        }
        SoundEngine.PlaySound(12);
        break;
      case 7:
        double lBar1 = (double) Main.lBar;
        float min = 0.15f;
        if (Main.menuMode == 252)
          min = 0.0f;
        Main.lBar = UILinksInitializer.HandleSliderHorizontalInput((float) lBar1, min, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX);
        float lBar2 = Main.lBar;
        if (lBar1 == (double) lBar2)
          break;
        switch (Main.menuMode)
        {
          case 17:
            Main.player[Main.myPlayer].hairColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 18:
            Main.player[Main.myPlayer].eyeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 19:
            Main.player[Main.myPlayer].skinColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 21:
            Main.player[Main.myPlayer].shirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 22:
            Main.player[Main.myPlayer].underShirtColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 23:
            Main.player[Main.myPlayer].pantsColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 24:
            Main.player[Main.myPlayer].shoeColor = Main.selColor = Main.hslToRgb(Main.hBar, Main.sBar, Main.lBar);
            break;
          case 25:
            Main.mouseColorSlider.Luminance = lBar2;
            break;
          case 252:
            Main.mouseBorderColorSlider.Luminance = lBar2;
            break;
        }
        SoundEngine.PlaySound(12);
        break;
      case 8:
        double aBar = (double) Main.aBar;
        float num3 = Main.aBar = UILinksInitializer.HandleSliderHorizontalInput((float) aBar, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX);
        if (aBar == (double) num3)
          break;
        if (Main.menuMode == 252)
          Main.mouseBorderColorSlider.Alpha = num3;
        SoundEngine.PlaySound(12);
        break;
      case 9:
        bool left = PlayerInput.Triggers.Current.Left;
        bool right = PlayerInput.Triggers.Current.Right;
        if (PlayerInput.Triggers.JustPressed.Left || PlayerInput.Triggers.JustPressed.Right)
          UILinksInitializer.SomeVarsForUILinkers.HairMoveCD = 0;
        else if (UILinksInitializer.SomeVarsForUILinkers.HairMoveCD > 0)
          --UILinksInitializer.SomeVarsForUILinkers.HairMoveCD;
        if (UILinksInitializer.SomeVarsForUILinkers.HairMoveCD == 0 && left | right)
        {
          if (left)
            --Main.PendingPlayer.hair;
          if (right)
            ++Main.PendingPlayer.hair;
          UILinksInitializer.SomeVarsForUILinkers.HairMoveCD = 12;
        }
        int num4 = 51;
        if (Main.PendingPlayer.hair >= num4)
          Main.PendingPlayer.hair = 0;
        if (Main.PendingPlayer.hair >= 0)
          break;
        Main.PendingPlayer.hair = num4 - 1;
        break;
      case 10:
        Main.GameZoomTarget = UILinksInitializer.HandleSliderHorizontalInput(Main.GameZoomTarget, 1f, 2f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
        break;
      case 11:
        Main.UIScale = UILinksInitializer.HandleSliderHorizontalInput(Main.UIScaleWanted, 0.5f, 2f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
        Main.temporaryGUIScaleSlider = Main.UIScaleWanted;
        break;
      case 12:
        Main.MapScale = UILinksInitializer.HandleSliderHorizontalInput(Main.MapScale, 0.5f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.7f);
        break;
    }
  }

  public class SomeVarsForUILinkers
  {
    public static Recipe SequencedCraftingCurrent;
    public static int HairMoveCD;
  }
}
