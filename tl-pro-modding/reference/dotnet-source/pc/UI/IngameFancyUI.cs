// Decompiled with JetBrains decompiler
// Type: Terraria.UI.IngameFancyUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.UI;

public class IngameFancyUI
{
  private static bool CoverForOneUIFrame;

  public static void CoverNextFrame() => IngameFancyUI.CoverForOneUIFrame = true;

  public static bool CanCover()
  {
    if (IngameFancyUI.CoverForOneUIFrame)
    {
      IngameFancyUI.CoverForOneUIFrame = false;
      return true;
    }
    return Main.inFancyUI;
  }

  public static void OpenAchievements()
  {
    if (Main.gameMenu)
      Main.MenuUI.SetState((UIState) Main.AchievementsMenu);
    else
      IngameFancyUI.OpenUIState((UIState) Main.AchievementsMenu);
  }

  public static void OpenAchievementsAndGoto(Achievement achievement)
  {
    IngameFancyUI.OpenAchievements();
    Main.AchievementsMenu.GotoAchievement(achievement);
  }

  private static void ClearChat()
  {
    Main.ClosePlayerChat();
    Main.chatText = "";
  }

  public static void OpenKeybinds() => IngameFancyUI.OpenUIState((UIState) Main.ManageControlsMenu);

  public static void OpenUIState(UIState uiState) => IngameFancyUI.OpenUIState(uiState, true);

  public static void OpenUIState(UIState uiState, bool closeIngameWindows = true)
  {
    IngameFancyUI.CoverNextFrame();
    IngameFancyUI.ClearChat();
    if (!Main.inFancyUI & closeIngameWindows)
      IngameUIWindows.CloseAll(true);
    Main.inFancyUI = true;
    Main.InGameUI.SetState(uiState);
  }

  public static bool CanShowVirtualKeyboard(int context) => UIVirtualKeyboard.CanDisplay(context);

  public static void OpenVirtualKeyboard(int keyboardContext)
  {
    IngameFancyUI.CoverNextFrame();
    IngameFancyUI.ClearChat();
    SoundEngine.PlaySound(12);
    string labelText = "";
    switch (keyboardContext)
    {
      case 1:
        Main.editSign = true;
        labelText = Language.GetTextValue("UI.EnterMessage");
        break;
      case 2:
        labelText = Language.GetTextValue("UI.EnterNewName");
        Player player = Main.player[Main.myPlayer];
        Main.npcChatText = Main.chest[player.chest].name;
        Tile tile = Main.tile[player.chestX, player.chestY];
        if (tile.type == (ushort) 21)
          Main.defaultChestName = Lang.chestType[(int) tile.frameX / 36].Value;
        else if (tile.type == (ushort) 467 && (int) tile.frameX / 36 == 4)
          Main.defaultChestName = Lang.GetItemNameValue(3988);
        else if (tile.type == (ushort) 467)
          Main.defaultChestName = Lang.chestType2[(int) tile.frameX / 36].Value;
        else if (tile.type == (ushort) 88)
          Main.defaultChestName = Lang.dresserType[(int) tile.frameX / 54].Value;
        if (Main.npcChatText == "")
          Main.npcChatText = Main.defaultChestName;
        Main.editChest = true;
        break;
    }
    Main.clrInput();
    if (!IngameFancyUI.CanShowVirtualKeyboard(keyboardContext))
      return;
    Main.inFancyUI = true;
    switch (keyboardContext)
    {
      case 1:
        Main.InGameUI.SetState((UIState) new UIVirtualKeyboard(labelText, Main.npcChatText, (UIVirtualKeyboard.KeyboardSubmitEvent) (s =>
        {
          Main.SubmitSignText();
          IngameFancyUI.Close(true);
        }), (Action) (() =>
        {
          Main.InputTextSignCancel();
          IngameFancyUI.Close(true);
        }), keyboardContext, maxLength: 1200));
        break;
      case 2:
        Main.InGameUI.SetState((UIState) new UIVirtualKeyboard(labelText, Main.npcChatText, (UIVirtualKeyboard.KeyboardSubmitEvent) (s =>
        {
          ChestUI.RenameChestSubmit(Main.player[Main.myPlayer]);
          IngameFancyUI.Close(true);
        }), (Action) (() =>
        {
          ChestUI.RenameChestCancel();
          IngameFancyUI.Close(true);
        }), keyboardContext));
        break;
    }
    UILinkPointNavigator.GoToDefaultPage(1);
  }

  public static void Close(bool quiet = false)
  {
    Main.inFancyUI = false;
    if (!quiet)
      SoundEngine.PlaySound(11);
    bool flag = false;
    if (!Main.gameMenu)
    {
      if (Main.InGameUI.CurrentState is UIVirtualKeyboard)
        flag = UIVirtualKeyboard.KeyboardContext == 2;
      else if (!(Main.InGameUI.CurrentState is UIEmotesMenu))
        flag = true;
    }
    if (flag)
      Main.playerInventory = true;
    Main.LocalPlayer.releaseInventory = false;
    Main.InGameUI.SetState((UIState) null);
    UILinkPointNavigator.Shortcuts.FANCYUI_SPECIAL_INSTRUCTIONS = 0;
  }

  public static bool Draw(SpriteBatch spriteBatch, GameTime gameTime)
  {
    bool flag = false;
    if (Main.InGameUI.CurrentState is UIVirtualKeyboard && UIVirtualKeyboard.KeyboardContext > 0)
    {
      if (!Main.inFancyUI)
        Main.InGameUI.SetState((UIState) null);
      if (Main.screenWidth >= 1705 || !PlayerInput.UsingGamepad)
        flag = true;
    }
    if (!Main.gameMenu)
    {
      Main.mouseText = false;
      if (Main.InGameUI != null && Main.InGameUI.IsElementUnderMouse())
        Main.player[Main.myPlayer].mouseInterface = true;
      Main.instance.GUIBarsDraw();
      if (Main.InGameUI.CurrentState is UIVirtualKeyboard && UIVirtualKeyboard.KeyboardContext > 0)
        Main.instance.GUIChatDraw();
      if (!Main.inFancyUI)
        Main.InGameUI.SetState((UIState) null);
      Main.instance.DrawMouseOver();
      Main.spriteBatch.End();
      Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.SamplerStateForCursor, DepthStencilState.None, RasterizerState.CullCounterClockwise, (Effect) null, Main.UIScaleMatrix);
      Main.DrawCursor(Main.DrawThickCursor());
    }
    return flag;
  }

  public static void MouseOver()
  {
    if (!Main.inFancyUI || !Main.InGameUI.IsElementUnderMouse())
      return;
    Main.mouseText = true;
  }
}
