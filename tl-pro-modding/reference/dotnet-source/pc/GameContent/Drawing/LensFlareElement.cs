// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.LensFlareElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;

#nullable disable
namespace Terraria.GameContent.Drawing;

public struct LensFlareElement
{
  public Asset<Texture2D> Texture;
  public int RepeatTimes;
  public float ScaleStart;
  public float ScaleOverIndex;
  public float DistanceStart;
  public float DistanceAlongIndex;
  public Color Color;
  public float IntensityOverIndex;
  public float Rotation;

  public void Draw(
    SpriteBatch spriteBatch,
    Vector2 sunPosition,
    Vector2 screenCenterPosition,
    float intensity)
  {
    if ((double) intensity == 0.0)
      return;
    Player localPlayer = Main.LocalPlayer;
    int advancedShadowsCount = localPlayer.availableAdvancedShadowsCount;
    Vector2 v = localPlayer.GetAdvancedShadow(0).Position - localPlayer.GetAdvancedShadow(Math.Min(4, advancedShadowsCount - 1)).Position;
    float num1 = Vector2.Dot(v.SafeNormalize(Vector2.UnitX), (sunPosition - screenCenterPosition).SafeNormalize(-Vector2.UnitY)) * v.Length();
    for (int index = 0; index < this.RepeatTimes; ++index)
    {
      float scale = this.ScaleStart + this.ScaleOverIndex * (float) index;
      Color color = this.Color * (float) (1.0 + (double) this.IntensityOverIndex * (double) index) * intensity;
      float num2 = (this.DistanceStart + this.DistanceAlongIndex * (float) index + num1 * -0.0002f) % 1f;
      Vector2 position = Vector2.Lerp(sunPosition, screenCenterPosition, num2 * 2f);
      float rotation = (screenCenterPosition - sunPosition).ToRotation() + this.Rotation;
      if ((double) this.Rotation == 0.0)
        rotation += Main.screenPosition.Y * (1f / 1000f);
      spriteBatch.Draw(this.Texture.Value, position, new Rectangle?(), color, rotation, this.Texture.Size() / 2f, scale, SpriteEffects.None, 0.0f);
    }
  }
}
