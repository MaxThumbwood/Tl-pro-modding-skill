// Decompiled with JetBrains decompiler
// Type: Terraria.Map.MapOverlayDrawContext
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public struct MapOverlayDrawContext(
  Vector2 mapPosition,
  Vector2 mapOffset,
  Rectangle? clippingRect,
  float mapScale,
  float drawScale,
  float opacity)
{
  private readonly Vector2 _mapPosition = mapPosition;
  private readonly Vector2 _mapOffset = mapOffset;
  private readonly Rectangle? _clippingRect = clippingRect;
  private readonly float _mapScale = mapScale;
  private readonly float _drawScale = drawScale;
  private readonly float _opacity = opacity;

  public MapOverlayDrawContext.DrawResult Draw(
    Texture2D texture,
    Vector2 position,
    Alignment alignment)
  {
    return this.Draw(texture, position, new SpriteFrame((byte) 1, (byte) 1), alignment);
  }

  public MapOverlayDrawContext.DrawResult Draw(
    Texture2D texture,
    Vector2 position,
    SpriteFrame frame,
    Alignment alignment)
  {
    if ((double) this._opacity == 0.0)
      return new MapOverlayDrawContext.DrawResult(false);
    position = (position - this._mapPosition) * this._mapScale + this._mapOffset;
    if (this._clippingRect.HasValue && !this._clippingRect.Value.Contains(position.ToPoint()))
      return MapOverlayDrawContext.DrawResult.Culled;
    Rectangle sourceRectangle = frame.GetSourceRectangle(texture);
    Vector2 origin = sourceRectangle.Size() * alignment.OffsetMultiplier;
    Main.spriteBatch.Draw(texture, position, new Rectangle?(sourceRectangle), Color.White * this._opacity, 0.0f, origin, this._drawScale, SpriteEffects.None, 0.0f);
    position -= origin * this._drawScale;
    return new MapOverlayDrawContext.DrawResult(new Rectangle((int) position.X, (int) position.Y, (int) ((double) sourceRectangle.Width * (double) this._drawScale), (int) ((double) sourceRectangle.Height * (double) this._drawScale)).Contains(Main.MouseScreen.ToPoint()));
  }

  public Rectangle GetUnclampedDrawRegion(
    Texture2D texture,
    Vector2 position,
    SpriteFrame frame,
    float scale,
    Alignment alignment)
  {
    position = (position - this._mapPosition) * this._mapScale + this._mapOffset;
    Rectangle sourceRectangle = frame.GetSourceRectangle(texture);
    Vector2 vector2_1 = sourceRectangle.Size() * alignment.OffsetMultiplier;
    float num = this._drawScale * scale;
    Vector2 vector2_2 = position - vector2_1 * num;
    return new Rectangle((int) vector2_2.X, (int) vector2_2.Y, (int) ((double) sourceRectangle.Width * (double) num), (int) ((double) sourceRectangle.Height * (double) num));
  }

  public Rectangle GetClampedDrawRegion(
    Texture2D texture,
    Vector2 position,
    SpriteFrame frame,
    float scale,
    Alignment alignment,
    int screenBorderRegion)
  {
    position = (position - this._mapPosition) * this._mapScale + this._mapOffset;
    Rectangle sourceRectangle = frame.GetSourceRectangle(texture);
    Vector2 vector2_1 = sourceRectangle.Size() * alignment.OffsetMultiplier;
    float num1 = this._drawScale * scale;
    Vector2 vector2_2 = position - vector2_1 * num1;
    Rectangle clampedDrawRegion = new Rectangle((int) vector2_2.X, (int) vector2_2.Y, (int) ((double) sourceRectangle.Width * (double) num1), (int) ((double) sourceRectangle.Height * (double) num1));
    int num2 = screenBorderRegion;
    int num3 = Main.screenWidth - screenBorderRegion;
    int num4 = screenBorderRegion;
    int num5 = Main.screenHeight - screenBorderRegion;
    int num6 = (num2 + num3) / 2;
    int num7 = (num4 + num5) / 2;
    if (clampedDrawRegion.X < num2)
    {
      float num8 = (float) (clampedDrawRegion.X - num6);
      float num9 = (float) (clampedDrawRegion.Y - num7);
      int num10 = clampedDrawRegion.X - num2;
      int num11 = (int) ((double) num10 / (double) num8 * (double) num9);
      clampedDrawRegion.X -= num10;
      clampedDrawRegion.Y -= num11;
    }
    else if (clampedDrawRegion.X + clampedDrawRegion.Width > num3)
    {
      float num12 = (float) (clampedDrawRegion.X - num6);
      float num13 = (float) (clampedDrawRegion.Y - num7);
      int num14 = clampedDrawRegion.X + clampedDrawRegion.Width - num3;
      int num15 = (int) ((double) num14 / (double) num12 * (double) num13);
      clampedDrawRegion.X -= num14;
      clampedDrawRegion.Y -= num15;
    }
    if (clampedDrawRegion.Y < num4)
    {
      float num16 = (float) (clampedDrawRegion.X - num6);
      float num17 = (float) (clampedDrawRegion.Y - num7);
      int num18 = clampedDrawRegion.Y - num4;
      int num19 = (int) ((double) num18 / (double) num17 * (double) num16);
      clampedDrawRegion.X -= num19;
      clampedDrawRegion.Y -= num18;
    }
    else if (clampedDrawRegion.Y + clampedDrawRegion.Height > num5)
    {
      float num20 = (float) (clampedDrawRegion.X - num6);
      float num21 = (float) (clampedDrawRegion.Y - num7);
      int num22 = clampedDrawRegion.Y + clampedDrawRegion.Height - num5;
      int num23 = (int) ((double) num22 / (double) num21 * (double) num20);
      clampedDrawRegion.X -= num23;
      clampedDrawRegion.Y -= num22;
    }
    return clampedDrawRegion;
  }

  public MapOverlayDrawContext.DrawResult DrawClamped(
    Texture2D texture,
    Texture2D offscreenTexture,
    Vector2 position,
    Color color,
    SpriteFrame frame,
    float scaleIfNotSelected,
    float scaleIfSelected,
    float scaleIfOffscreen,
    Alignment alignment,
    int screenBorderRegion,
    out bool onScreen)
  {
    onScreen = true;
    if ((double) this._opacity == 0.0)
      return new MapOverlayDrawContext.DrawResult(false);
    position = (position - this._mapPosition) * this._mapScale + this._mapOffset;
    Rectangle sourceRectangle = frame.GetSourceRectangle(texture);
    Vector2 origin1 = sourceRectangle.Size() * alignment.OffsetMultiplier;
    Vector2 position1 = position;
    float num1 = this._drawScale * scaleIfNotSelected;
    float scale1 = this._drawScale * scaleIfOffscreen;
    Vector2 vector2 = position - origin1 * num1;
    Rectangle rectangle1 = new Rectangle((int) vector2.X, (int) vector2.Y, (int) ((double) sourceRectangle.Width * (double) num1), (int) ((double) sourceRectangle.Height * (double) num1));
    int num2 = screenBorderRegion;
    int num3 = Main.screenWidth - screenBorderRegion;
    int num4 = screenBorderRegion;
    int num5 = Main.screenHeight - screenBorderRegion;
    int num6 = (num2 + num3) / 2;
    int num7 = (num4 + num5) / 2;
    if (rectangle1.X < num2)
    {
      float num8 = (float) (rectangle1.X - num6);
      float num9 = (float) (rectangle1.Y - num7);
      int num10 = rectangle1.X - num2;
      int num11 = (int) ((double) num10 / (double) num8 * (double) num9);
      position1.X -= (float) num10;
      rectangle1.X -= num10;
      position1.Y -= (float) num11;
      rectangle1.Y -= num11;
      onScreen = false;
    }
    else if (rectangle1.X + rectangle1.Width > num3)
    {
      onScreen = false;
      float num12 = (float) (rectangle1.X - num6);
      float num13 = (float) (rectangle1.Y - num7);
      int num14 = rectangle1.X + rectangle1.Width - num3;
      int num15 = (int) ((double) num14 / (double) num12 * (double) num13);
      position1.X -= (float) num14;
      rectangle1.X -= num14;
      position1.Y -= (float) num15;
      rectangle1.Y -= num15;
    }
    if (rectangle1.Y < num4)
    {
      onScreen = false;
      float num16 = (float) (rectangle1.X - num6);
      float num17 = (float) (rectangle1.Y - num7);
      int num18 = rectangle1.Y - num4;
      int num19 = (int) ((double) num18 / (double) num17 * (double) num16);
      position1.X -= (float) num19;
      rectangle1.X -= num19;
      position1.Y -= (float) num18;
      rectangle1.Y -= num18;
    }
    else if (rectangle1.Y + rectangle1.Height > num5)
    {
      onScreen = false;
      float num20 = (float) (rectangle1.X - num6);
      float num21 = (float) (rectangle1.Y - num7);
      int num22 = rectangle1.Y + rectangle1.Height - num5;
      int num23 = (int) ((double) num22 / (double) num21 * (double) num20);
      position1.X -= (float) num23;
      rectangle1.X -= num23;
      position1.Y -= (float) num22;
      rectangle1.Y -= num22;
    }
    bool isMouseOver = rectangle1.Contains(Main.MouseScreen.ToPoint());
    float scale2 = num1;
    if (!onScreen)
    {
      scale2 = scale1;
      if (isMouseOver)
        scale2 *= scaleIfSelected;
    }
    else if (isMouseOver)
      scale2 = this._drawScale * scaleIfSelected;
    if (!onScreen && !isMouseOver)
    {
      int frameX = 2;
      int frameY = 1;
      int num24 = offscreenTexture.Width / 3;
      int num25 = offscreenTexture.Height / 3;
      Vector2 v = position - position1;
      float rotation = v.ToRotation();
      v.Normalize();
      Vector2 position2 = rectangle1.Center.ToVector2() + v * ((float) (sourceRectangle.Height / 4) * scale1);
      Rectangle rectangle2 = offscreenTexture.Frame(3, 3, frameX, frameY);
      Vector2 origin2 = new Vector2(0.0f, (float) rectangle2.Height * 0.5f);
      Main.spriteBatch.Draw(offscreenTexture, position2, new Rectangle?(rectangle2), Color.White * this._opacity, rotation, origin2, scale1, SpriteEffects.None, 0.0f);
    }
    Main.spriteBatch.Draw(texture, position1, new Rectangle?(sourceRectangle), color * this._opacity, 0.0f, origin1, scale2, SpriteEffects.None, 0.0f);
    return new MapOverlayDrawContext.DrawResult(isMouseOver);
  }

  public MapOverlayDrawContext.DrawResult Draw(
    Texture2D texture,
    Vector2 position,
    Color color,
    SpriteFrame frame,
    float scaleIfNotSelected,
    float scaleIfSelected,
    Alignment alignment)
  {
    if ((double) this._opacity == 0.0)
      return new MapOverlayDrawContext.DrawResult(false);
    position = (position - this._mapPosition) * this._mapScale + this._mapOffset;
    if (this._clippingRect.HasValue && !this._clippingRect.Value.Contains(position.ToPoint()))
      return MapOverlayDrawContext.DrawResult.Culled;
    Rectangle sourceRectangle = frame.GetSourceRectangle(texture);
    Vector2 origin = sourceRectangle.Size() * alignment.OffsetMultiplier;
    Vector2 position1 = position;
    float num1 = this._drawScale * scaleIfNotSelected;
    Vector2 vector2 = position - origin * num1;
    int num2 = new Rectangle((int) vector2.X, (int) vector2.Y, (int) ((double) sourceRectangle.Width * (double) num1), (int) ((double) sourceRectangle.Height * (double) num1)).Contains(Main.MouseScreen.ToPoint()) ? 1 : 0;
    float scale = num1;
    if (num2 != 0)
      scale = this._drawScale * scaleIfSelected;
    Main.spriteBatch.Draw(texture, position1, new Rectangle?(sourceRectangle), color * this._opacity, 0.0f, origin, scale, SpriteEffects.None, 0.0f);
    return new MapOverlayDrawContext.DrawResult(num2 != 0);
  }

  public struct DrawResult(bool isMouseOver)
  {
    public static readonly MapOverlayDrawContext.DrawResult Culled = new MapOverlayDrawContext.DrawResult(false);
    public readonly bool IsMouseOver = isMouseOver;
  }
}
