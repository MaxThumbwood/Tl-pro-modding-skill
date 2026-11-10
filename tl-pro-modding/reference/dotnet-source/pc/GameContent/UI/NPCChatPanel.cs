// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.NPCChatPanel
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Graphics;
using ReLogic.Localization.IME;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI;

public class NPCChatPanel
{
  private int textBlinkerCount;
  private int textBlinkerState;
  private List<NPCInteraction> _interactions = new List<NPCInteraction>();
  private TextDisplayCache _textDisplayCache = new TextDisplayCache();
  private int _neededInteractionLines;
  public const int AllowedInteractionsPerLine = 4;
  private int _lastHovered = -1;

  private Player LocalPlayer => Main.LocalPlayer;

  private byte mouseTextColor => Main.mouseTextColor;

  public bool allowRichText => this.LocalPlayer.talkNPC != -1;

  public bool InVirtualKeyboard
  {
    get => Main.InGameUI.CurrentState is UIVirtualKeyboard && PlayerInput.UsingGamepad;
  }

  public void Draw()
  {
    if (!this.CanHoldConversation())
    {
      this.Close();
    }
    else
    {
      this.PrepareText();
      this.PrepareInteractions();
      this.PrepareVirtualKeyboard();
      Color chatBack = new Color(200, 200, 200, 200);
      int num = ((int) this.mouseTextColor * 2 + (int) byte.MaxValue) / 3;
      Color color = new Color(num, num, num, num);
      Point point = new Point(500, 500);
      Rectangle rectangle = new Rectangle(Main.screenWidth / 2 - point.X / 2, 100, point.X, 30);
      rectangle.Height += 30 * this._textDisplayCache.AmountOfLines;
      rectangle.Height += 30 * this._neededInteractionLines + Math.Max(0, 2 * (this._neededInteractionLines - 1));
      Utils.DrawInvBG(Main.spriteBatch, rectangle);
      this.DrawText(color, rectangle);
      Vector2 npcChatTopLeft = rectangle.TopLeft();
      Main.DrawNPCPortrait(chatBack, npcChatTopLeft);
      Main.DrawNPCChatBottomRightItem(rectangle.BottomRight());
      if (!PlayerInput.IgnoreMouseInterface && rectangle.Contains(new Point(Main.mouseX, Main.mouseY)))
        this.LocalPlayer.mouseInterface = true;
      this.DrawButtons(rectangle, color);
    }
  }

  private void DrawButtons(Rectangle panelArea, Color chatColor)
  {
    UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsNew = true;
    UILinkPointNavigator.Shortcuts.NPCCHAT_ButtonsCount = this._interactions.Count;
    DynamicSpriteFont font = FontAssets.MouseText.Value;
    Vector2 vector2_1 = panelArea.BottomLeft() + new Vector2(30f, (float) (-22 * this._neededInteractionLines + Math.Max(0, 2 * (this._neededInteractionLines - 1)) - 4));
    int num1 = -1;
    int num2 = -1;
    float num3 = 0.9f;
    Rectangle rectangle = new Rectangle((int) vector2_1.X, (int) vector2_1.Y, 100, 22);
    foreach (NPCInteraction interaction in this._interactions)
    {
      ++num1;
      byte mouseTextColor = this.mouseTextColor;
      chatColor = new Color((int) mouseTextColor, (int) ((double) mouseTextColor / 1.1), (int) mouseTextColor / 2, (int) mouseTextColor);
      if (num1 % 4 == 0)
      {
        rectangle.X = (int) vector2_1.X;
        rectangle.Y = num1 / 4 * 22 + (int) vector2_1.Y;
      }
      string text = interaction.GetText();
      int coinValue = 0;
      int num4 = interaction.TryAddCoins(ref chatColor, out coinValue) ? 1 : 0;
      float num5 = 1f;
      Vector2 stringSize = ChatManager.GetStringSize(font, text, new Vector2(num3));
      if ((double) stringSize.X > 260.0)
        num5 *= 260f / stringSize.X;
      rectangle.Width = (int) ((double) stringSize.X * (double) num5);
      bool flag = rectangle.Contains(new Point(Main.mouseX, Main.mouseY));
      Vector2 vector2_2 = new Vector2(flag ? 1.2f : num3);
      Vector2 origin = new Vector2(0.0f, stringSize.Y * 0.5f);
      Color baseColor = flag ? Color.Brown : Color.Black;
      Vector2 position = new Vector2((float) rectangle.Left, (float) rectangle.Center.Y);
      if (flag)
      {
        position.X -= (float) (int) ((1.2000000476837158 - (double) num3) * (double) rectangle.Width * 0.5);
        stringSize *= 1.2f / num3;
      }
      if (flag)
        num2 = num1;
      ChatManager.DrawColorCodedStringShadow(Main.spriteBatch, font, text, position, baseColor, 0.0f, origin, vector2_2 * num5);
      ChatManager.DrawColorCodedString(Main.spriteBatch, font, text, position, chatColor, 0.0f, origin, vector2_2 * num5);
      UILinkPointNavigator.SetPosition(2500 + num1, rectangle.Center.ToVector2());
      rectangle.X += rectangle.Width + 30;
      if (interaction.ShowExcalmation)
        Utils.DrawNotificationIcon(Main.spriteBatch, position + new Vector2(stringSize.X * num5, 0.0f) + new Vector2(8f, 0.0f), 0.0f);
      if (num4 != 0)
      {
        ItemSlot.DrawMoney(Main.spriteBatch, "", (float) (rectangle.X - 45), (float) (rectangle.Y - 44), Utils.CoinsSplit((long) coinValue), true);
        rectangle.X += 106;
      }
      if (!PlayerInput.IgnoreMouseInterface & flag)
      {
        this.LocalPlayer.mouseInterface = true;
        this.LocalPlayer.releaseUseItem = false;
        num2 = num1;
        if (Main.mouseLeft && Main.mouseLeftRelease)
        {
          Main.mouseLeftRelease = false;
          interaction.Interact();
        }
      }
    }
    if (this._lastHovered != num2 && (!PlayerInput.UsingGamepad || num2 != -1))
      SoundEngine.PlaySound(12);
    this._lastHovered = num2;
  }

  private void PrepareInteractions()
  {
    this._interactions.Clear();
    foreach (NPCInteraction npcInteraction in NPCInteractions.All)
    {
      if (npcInteraction.Condition())
        this._interactions.Add(npcInteraction);
    }
    this._neededInteractionLines = (int) Math.Ceiling((double) this._interactions.Count / 4.0);
  }

  private void PrepareVirtualKeyboard()
  {
    int num = 120 + this._textDisplayCache.AmountOfLines * 30 + 30 - 235;
    UIVirtualKeyboard.ShouldHideText = !PlayerInput.SettingsForUI.ShowGamepadHints;
    if (!PlayerInput.UsingGamepad)
      num = 9999;
    UIVirtualKeyboard.OffsetDown = num;
  }

  private void PrepareText()
  {
    string npcChatText = Main.npcChatText;
    this.OverrideChatTextWithShenanigans(ref npcChatText);
    this._textDisplayCache.PrepareCache(npcChatText);
  }

  private void OverrideChatTextWithShenanigans(ref string chatTextToShow)
  {
    int num1 = this.LocalPlayer.talkNPC == -1 ? 0 : (Main.CanDryadPlayStardewAnimation(this.LocalPlayer, Main.npc[this.LocalPlayer.talkNPC]) ? 1 : 0);
    int num2 = 24;
    if (this.LocalPlayer.talkNPC != -1 && (double) Main.npc[this.LocalPlayer.talkNPC].ai[0] == (double) num2 && NPC.RerollDryadText == 2)
      NPC.RerollDryadText = 1;
    if (num1 != 0 && NPC.RerollDryadText == 1 && (double) Main.npc[this.LocalPlayer.talkNPC].ai[0] != (double) num2 && this.LocalPlayer.talkNPC != -1 && Main.npc[this.LocalPlayer.talkNPC].active && Main.npc[this.LocalPlayer.talkNPC].type == 20)
    {
      NPC.RerollDryadText = 0;
      chatTextToShow = Main.npcChatText = Main.npc[this.LocalPlayer.talkNPC].GetChat();
      NPC.PreventJojaColaDialog = true;
    }
    if (num1 == 0 || NPC.PreventJojaColaDialog)
      return;
    chatTextToShow = Language.GetTextValue("StardewTalk.PlayerHasColaAndIsHoldingIt");
  }

  private void DrawText(Color textColor, Rectangle textArea)
  {
    Vector2 vector2 = textArea.TopLeft() + new Vector2(20f, 20f);
    DynamicSpriteFont font = FontAssets.MouseText.Value;
    string[] textLines = this._textDisplayCache.TextLines;
    int amountOfLines = this._textDisplayCache.AmountOfLines;
    for (int index = 0; index < amountOfLines; ++index)
    {
      string text = textLines[index];
      if (text != null)
      {
        if (this.allowRichText)
          ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, font, text, vector2 + new Vector2(0.0f, (float) (index * 30)), textColor, 0.0f, Vector2.Zero, Vector2.One);
        else
          Utils.DrawBorderStringFourWay(Main.spriteBatch, font, text, vector2.X, vector2.Y + (float) (index * 30), textColor, Color.Black, Vector2.Zero);
      }
    }
    if ((!Main.editSign ? 0 : (textLines[amountOfLines - 1] != null ? 1 : 0)) == 0)
      return;
    Vector2 position = vector2 + new Vector2(0.0f, (float) ((amountOfLines - 1) * 30));
    position.X += font.MeasureString(textLines[amountOfLines - 1]).X;
    string compositionString = Platform.Get<IImeService>().CompositionString;
    if (compositionString != null && compositionString.Length > 0)
    {
      float x = font.MeasureString(compositionString).X;
      if ((double) x + (double) position.X - (double) vector2.X > 460.0)
        position = vector2 + new Vector2(0.0f, (float) (amountOfLines * 30));
      ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, font, compositionString, position, Main.imeCompositionStringColor, 0.0f, Vector2.Zero, Vector2.One);
      Main.instance.SetIMEPanelAnchor(position + new Vector2(0.0f, 54f), 0.0f);
      position.X += x;
    }
    if (++this.textBlinkerCount >= 20)
    {
      this.textBlinkerState = this.textBlinkerState == 0 ? 1 : 0;
      this.textBlinkerCount = 0;
    }
    if (this.textBlinkerState != 1)
      return;
    ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, font, "|", position, textColor, 0.0f, Vector2.Zero, Vector2.One);
  }

  public void Close()
  {
    this._lastHovered = -1;
    this.ClearNPCChatText();
  }

  private void ClearNPCChatText() => Main.npcChatText = "";

  public bool CanHoldConversation() => this.LocalPlayer.talkNPC >= 0 || this.LocalPlayer.sign != -1;
}
