// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.NewMultiplayerClosePlayersOverlay
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI;

public class NewMultiplayerClosePlayersOverlay : IMultiplayerClosePlayersOverlay
{
  private List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache> _playerOnScreenCache = new List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache>();
  private List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache> _playerOffScreenCache = new List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache>();

  public void Draw()
  {
    int namePlateDistance = Main.teamNamePlateDistance;
    if (namePlateDistance <= 0)
      return;
    this._playerOnScreenCache.Clear();
    this._playerOffScreenCache.Clear();
    SpriteBatch spriteBatch = Main.spriteBatch;
    int num1 = namePlateDistance * 8;
    Player[] player1 = Main.player;
    int player2 = Main.myPlayer;
    byte mouseTextColor = Main.mouseTextColor;
    Color[] teamColor = Main.teamColor;
    Vector2 screenPosition = Main.screenPosition;
    Player player3 = player1[player2];
    float num2 = (float) mouseTextColor / (float) byte.MaxValue;
    if (Main.netMode == 0)
      return;
    DynamicSpriteFont font = FontAssets.MouseText.Value;
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (index != player2)
      {
        Player player4 = player1[index];
        bool drawScryingOrb = player4.spectating == player2;
        if (player4.active && (!player4.dead || drawScryingOrb || player4.ghost) && player4.team == player3.team)
        {
          if (player4.team == 0 && !drawScryingOrb)
            return;
          string name = player4.name;
          Vector2 namePlatePos;
          bool offScreen;
          Vector2 measurement;
          NewMultiplayerClosePlayersOverlay.GetDistance(font, player4, name, out namePlatePos, out offScreen, out measurement);
          Color color = new Color((int) (byte) ((double) teamColor[player4.team].R * (double) num2), (int) (byte) ((double) teamColor[player4.team].G * (double) num2), (int) (byte) ((double) teamColor[player4.team].B * (double) num2), (int) mouseTextColor);
          if (offScreen)
          {
            float num3 = player4.Distance(player3.Center);
            if ((double) num3 <= (double) num1)
            {
              namePlatePos.Y += 40f;
              float num4 = 20f;
              float num5 = -27f - (float) (((double) measurement.X - 85.0) / 2.0);
              string textValue = Language.GetTextValue("GameUI.PlayerDistance", (object) (int) ((double) num3 / 16.0 * 2.0));
              Vector2 npDistPos = font.MeasureString(textValue) with
              {
                X = namePlatePos.X - num5
              };
              npDistPos.Y = (float) ((double) namePlatePos.Y + (double) measurement.Y / 2.0 - (double) npDistPos.Y / 2.0) - num4;
              this._playerOffScreenCache.Add(new NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache(name, namePlatePos, color, npDistPos, textValue, player4, measurement, drawScryingOrb));
            }
          }
          else
            this._playerOnScreenCache.Add(new NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache(name, namePlatePos, color));
        }
      }
    }
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
    for (int index = 0; index < this._playerOnScreenCache.Count; ++index)
      this._playerOnScreenCache[index].DrawPlayerName_WhenPlayerIsOnScreen(spriteBatch);
    NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache playerOffScreenCache;
    for (int index = 0; index < this._playerOffScreenCache.Count; ++index)
    {
      playerOffScreenCache = this._playerOffScreenCache[index];
      playerOffScreenCache.DrawPlayerName(spriteBatch);
    }
    for (int index = 0; index < this._playerOffScreenCache.Count; ++index)
    {
      playerOffScreenCache = this._playerOffScreenCache[index];
      playerOffScreenCache.DrawPlayerDistance(spriteBatch);
    }
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
    for (int index = 0; index < this._playerOffScreenCache.Count; ++index)
    {
      playerOffScreenCache = this._playerOffScreenCache[index];
      playerOffScreenCache.DrawLifeBar();
    }
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Immediate, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
    for (int index = 0; index < this._playerOffScreenCache.Count; ++index)
    {
      playerOffScreenCache = this._playerOffScreenCache[index];
      playerOffScreenCache.DrawPlayerHead();
    }
  }

  private static void GetDistance(
    DynamicSpriteFont font,
    Player player,
    string nameToShow,
    out Vector2 namePlatePos,
    out bool offScreen,
    out Vector2 measurement)
  {
    measurement = font.MeasureString(nameToShow);
    namePlatePos = Main.GetChatDrawPosition(player);
    namePlatePos.Y -= measurement.Y / 2f;
    if (player.chatOverhead.timeLeft > 0 || player.emoteTime > 0)
      namePlatePos.Y -= measurement.Y;
    Vector2 vector2_1 = Main.ScreenSize.ToVector2() / Main.UIScale;
    Vector2 vector2_2 = vector2_1 / 2f;
    Vector2 vector2_3 = Vector2.Max(new Vector2(100f), vector2_1 / 2f - new Vector2(80f, 50f));
    Vector2 vector2_4 = namePlatePos - vector2_2;
    float num = (vector2_4 / vector2_3).Length();
    if ((double) num > 1.0)
    {
      offScreen = true;
      namePlatePos = vector2_2 + vector2_4 / num;
    }
    else
      offScreen = false;
    namePlatePos -= measurement / 2f;
  }

  private struct PlayerOnScreenCache(string name, Vector2 pos, Color color)
  {
    private string _name = name;
    private Vector2 _pos = pos;
    private Color _color = color;

    public void DrawPlayerName_WhenPlayerIsOnScreen(SpriteBatch spriteBatch)
    {
      this._pos = this._pos.Floor();
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this._name, new Vector2(this._pos.X - 2f, this._pos.Y), Color.Black, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this._name, new Vector2(this._pos.X + 2f, this._pos.Y), Color.Black, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this._name, new Vector2(this._pos.X, this._pos.Y - 2f), Color.Black, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this._name, new Vector2(this._pos.X, this._pos.Y + 2f), Color.Black, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this._name, this._pos, this._color, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    }
  }

  private struct PlayerOffScreenCache(
    string name,
    Vector2 pos,
    Color color,
    Vector2 npDistPos,
    string npDist,
    Player thePlayer,
    Vector2 theMeasurement,
    bool drawScryingOrb)
  {
    private Player player = thePlayer;
    private string nameToShow = name;
    private Vector2 namePlatePos = pos.Floor();
    private Color namePlateColor = color;
    private Vector2 distanceDrawPosition = npDistPos.Floor();
    private string distanceString = npDist;
    private Vector2 measurement = theMeasurement;
    private bool drawScryingOrb = drawScryingOrb;

    public void DrawPlayerName(SpriteBatch spriteBatch)
    {
      ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, this.nameToShow, this.namePlatePos + new Vector2(0.0f, -40f), this.namePlateColor, 0.0f, Vector2.Zero, Vector2.One);
    }

    public void DrawPlayerHead()
    {
      float num1 = 20f;
      float num2 = -27f - (float) (((double) this.measurement.X - 85.0) / 2.0);
      Color headBordersColor = Main.GetPlayerHeadBordersColor(this.player);
      Vector2 vec = new Vector2(this.namePlatePos.X, this.namePlatePos.Y - num1);
      vec.X -= 22f + num2;
      vec.Y += 8f;
      Vector2 position = vec.Floor();
      Main.MapPlayerRenderer.DrawPlayerHead(Main.Camera, this.player, position, scale: 0.8f, borderColor: headBordersColor);
      if (!this.drawScryingOrb)
        return;
      Texture2D itemTexture;
      Rectangle itemFrame;
      Main.GetItemDrawFrame(5644, out itemTexture, out itemFrame);
      Main.spriteBatch.Draw(itemTexture, position + new Vector2(-26f, 4f), new Rectangle?(itemFrame), Color.White, 0.0f, itemFrame.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
    }

    public void DrawLifeBar()
    {
      Vector2 vector2 = Main.screenPosition + this.distanceDrawPosition + new Vector2(26f, 20f);
      if (this.player.statLife == this.player.statLifeMax2)
        return;
      Main.instance.DrawHealthBar(vector2.X, vector2.Y, this.player.statLife, this.player.statLifeMax2, 1f, 1.25f, true);
    }

    public void DrawPlayerDistance(SpriteBatch spriteBatch)
    {
      float num = 0.85f;
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this.distanceString, new Vector2(this.distanceDrawPosition.X - 2f, this.distanceDrawPosition.Y), Color.Black, 0.0f, new Vector2(), num, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this.distanceString, new Vector2(this.distanceDrawPosition.X + 2f, this.distanceDrawPosition.Y), Color.Black, 0.0f, new Vector2(), num, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this.distanceString, new Vector2(this.distanceDrawPosition.X, this.distanceDrawPosition.Y - 2f), Color.Black, 0.0f, new Vector2(), num, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this.distanceString, new Vector2(this.distanceDrawPosition.X, this.distanceDrawPosition.Y + 2f), Color.Black, 0.0f, new Vector2(), num, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, this.distanceString, this.distanceDrawPosition, this.namePlateColor, 0.0f, new Vector2(), num, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    }
  }
}
