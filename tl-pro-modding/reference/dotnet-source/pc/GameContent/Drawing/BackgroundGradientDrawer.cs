// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.BackgroundGradientDrawer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class BackgroundGradientDrawer
{
  private Color _color;
  private GetBackgroundDrawWeightMethod _weightGetter;
  private BackgroundArrayGetterMethod _textureGetter;
  private int[] _textureIndexesToCheck;
  private static Asset<Texture2D> _sunflareGradientDitherTexture;

  public BackgroundGradientDrawer(
    Color gradientColor,
    GetBackgroundDrawWeightMethod weightGetter,
    BackgroundArrayGetterMethod textureGetter,
    params int[] textureIndexesToCheck)
  {
    this._color = gradientColor;
    this._weightGetter = weightGetter;
    this._textureGetter = textureGetter;
    this._textureIndexesToCheck = textureIndexesToCheck;
  }

  public void Draw()
  {
    if (!Main.BackgroundEnabled)
      return;
    float num = this._weightGetter();
    if ((double) num <= 0.0 || !this.ShouldDrawForTextures() || !Main.ShouldDrawSurfaceBackground())
      return;
    if (BackgroundGradientDrawer._sunflareGradientDitherTexture == null)
      BackgroundGradientDrawer._sunflareGradientDitherTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/colorgradientdither", (AssetRequestMode) 1);
    SpriteBatch spriteBatch = Main.spriteBatch;
    Color color1 = new Color(this._color.ToVector3() * Main.ColorOfSurfaceBackgroundsBase.ToVector3());
    Texture2D texture = BackgroundGradientDrawer._sunflareGradientDitherTexture.Value;
    Rectangle gradientRect = BackgroundGradientDrawer.GetGradientRect();
    Rectangle? sourceRectangle = new Rectangle?();
    Color color2 = color1 * num;
    Vector2 zero = Vector2.Zero;
    spriteBatch.Draw(texture, gradientRect, sourceRectangle, color2, 0.0f, zero, SpriteEffects.None, 0.0f);
  }

  private static Rectangle GetGradientRect()
  {
    int num = 400;
    return new Rectangle(0, Math.Max(0, (int) ((Main.worldSurface * 16.0 - (double) Main.screenPosition.Y - 2400.0) * 0.10000000149011612)) - num, Main.screenWidth, Main.screenHeight + num);
  }

  private bool ShouldDrawForTextures()
  {
    IEnumerable<int> ints = this._textureGetter();
    foreach (int num1 in this._textureIndexesToCheck)
    {
      foreach (int num2 in ints)
      {
        if (num1 == num2)
          return true;
      }
    }
    return false;
  }
}
