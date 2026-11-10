// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.UIDust
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.GameContent.Events;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.UI;

public class UIDust
{
  public const int maxDust = 200;
  public Dust[] dust = new Dust[201];

  public void Clear()
  {
    for (int index = 0; index < 201; ++index)
      this.dust[index] = new Dust();
  }

  public Dust NewDustPerfect(
    Vector2 Position,
    int Type,
    Vector2? Velocity = null,
    int Alpha = 0,
    Color newColor = default (Color),
    float Scale = 1f)
  {
    Dust dust = this.NewDust(Position, 0, 0, Type, Alpha: Alpha, newColor: newColor, Scale: Scale);
    dust.position = Position;
    if (Velocity.HasValue)
      dust.velocity = Velocity.Value;
    return dust;
  }

  public Dust NewDustDirect(
    Vector2 Position,
    int Width,
    int Height,
    int Type,
    float SpeedX = 0.0f,
    float SpeedY = 0.0f,
    int Alpha = 0,
    Color newColor = default (Color),
    float Scale = 1f)
  {
    Dust dust = this.NewDust(Position, Width, Height, Type, SpeedX, SpeedY, Alpha, newColor, Scale);
    if (dust.velocity.HasNaNs())
      dust.velocity = Vector2.Zero;
    return dust;
  }

  public Dust NewDust(
    Vector2 Position,
    int Width,
    int Height,
    int Type,
    float SpeedX = 0.0f,
    float SpeedY = 0.0f,
    int Alpha = 0,
    Color newColor = default (Color),
    float Scale = 1f)
  {
    if (Type != 6 && Type != 267)
      throw new Exception();
    int index1 = 200;
    for (int index2 = 0; index2 < 200; ++index2)
    {
      Dust dust = this.dust[index2];
      if (!dust.active)
      {
        int num1 = Width;
        int num2 = Height;
        if (num1 < 5)
          num1 = 5;
        if (num2 < 5)
          num2 = 5;
        index1 = index2;
        dust.fadeIn = 0.0f;
        dust.active = true;
        dust.type = Type;
        dust.noGravity = false;
        dust.color = newColor;
        dust.alpha = Alpha;
        dust.position.X = (float) ((double) Position.X + (double) Main.rand.Next(num1 - 4) + 4.0);
        dust.position.Y = (float) ((double) Position.Y + (double) Main.rand.Next(num2 - 4) + 4.0);
        dust.velocity.X = (float) Main.rand.Next(-20, 21) * 0.1f + SpeedX;
        dust.velocity.Y = (float) Main.rand.Next(-20, 21) * 0.1f + SpeedY;
        dust.frame.X = 10 * Type;
        dust.frame.Y = 10 * Main.rand.Next(3);
        dust.shader = (ArmorShaderData) null;
        dust.customData = (object) null;
        dust.noLightEmittence = false;
        dust.fullBright = false;
        int num3 = Type;
        while (num3 >= 100)
        {
          num3 -= 100;
          dust.frame.X -= 1000;
          dust.frame.Y += 30;
        }
        dust.frame.Width = 8;
        dust.frame.Height = 8;
        dust.rotation = 0.0f;
        dust.scale = (float) (1.0 + (double) Main.rand.Next(-20, 21) * 0.0099999997764825821);
        dust.scale *= Scale;
        dust.noLight = false;
        dust.firstFrame = true;
        if (dust.type == 6)
        {
          dust.velocity.Y = (float) Main.rand.Next(-10, 6) * 0.1f;
          dust.velocity.X *= 0.3f;
          dust.scale *= 0.7f;
          break;
        }
        break;
      }
    }
    return this.dust[index1];
  }

  public Dust CloneDust(int dustIndex) => this.CloneDust(this.dust[dustIndex]);

  public Dust CloneDust(Dust rf)
  {
    Dust dust = this.NewDust(rf.position, 0, 0, rf.type);
    dust.position = rf.position;
    dust.velocity = rf.velocity;
    dust.fadeIn = rf.fadeIn;
    dust.noGravity = rf.noGravity;
    dust.scale = rf.scale;
    dust.rotation = rf.rotation;
    dust.noLight = rf.noLight;
    dust.active = rf.active;
    dust.type = rf.type;
    dust.color = rf.color;
    dust.alpha = rf.alpha;
    dust.frame = rf.frame;
    dust.shader = rf.shader;
    dust.customData = rf.customData;
    return dust;
  }

  public void QuickBox(
    Vector2 topLeft,
    Vector2 bottomRight,
    int divisions,
    Color color,
    Action<Dust> manipulator)
  {
    float num1 = (float) (divisions + 2);
    for (float num2 = 0.0f; (double) num2 <= (double) (divisions + 2); ++num2)
    {
      Dust dust1 = this.QuickDust(new Vector2(MathHelper.Lerp(topLeft.X, bottomRight.X, num2 / num1), topLeft.Y), color);
      if (manipulator != null)
        manipulator(dust1);
      Dust dust2 = this.QuickDust(new Vector2(MathHelper.Lerp(topLeft.X, bottomRight.X, num2 / num1), bottomRight.Y), color);
      if (manipulator != null)
        manipulator(dust2);
      Dust dust3 = this.QuickDust(new Vector2(topLeft.X, MathHelper.Lerp(topLeft.Y, bottomRight.Y, num2 / num1)), color);
      if (manipulator != null)
        manipulator(dust3);
      Dust dust4 = this.QuickDust(new Vector2(bottomRight.X, MathHelper.Lerp(topLeft.Y, bottomRight.Y, num2 / num1)), color);
      if (manipulator != null)
        manipulator(dust4);
    }
  }

  public void QuickCircle(
    Vector2 center,
    float radius,
    int divisions,
    Color color,
    Action<Dust> manipulator)
  {
    float num1 = 1f / Math.Max(1f, (float) divisions);
    for (float num2 = 0.0f; (double) num2 < 1.0; num2 += num1)
    {
      float radians = num2 * 6.28318548f;
      Dust dust = this.QuickDust(center + new Vector2(radius, 0.0f).RotatedBy((double) radians, Vector2.Zero), color);
      if (manipulator != null)
        manipulator(dust);
    }
  }

  public Dust QuickDust(Vector2 pos, Color color)
  {
    Dust dust = this.NewDust(pos, 0, 0, 267);
    dust.position = pos;
    dust.velocity = Vector2.Zero;
    dust.fadeIn = 1f;
    dust.noLight = true;
    dust.noGravity = true;
    dust.color = color;
    return dust;
  }

  public Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
  {
    Dust dust = this.QuickDust(pos, color);
    dust.fadeIn = 0.0f;
    dust.scale = 0.35f;
    if (floorPositionValues)
      dust.position = dust.position.Floor();
    return dust;
  }

  public void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
  {
    this.QuickDust(start, color).scale = 0.3f;
    this.QuickDust(end, color).scale = 0.3f;
    float num = 1f / splits;
    for (float amount = 0.0f; (double) amount < 1.0; amount += num)
      this.QuickDust(Vector2.Lerp(start, end, amount), color).scale = 0.3f;
  }

  public void UpdateDust()
  {
    Sandstorm.ShowSandstormVisuals();
    for (int index = 0; index < 200; ++index)
    {
      Dust dust = this.dust[index];
      if (dust.active)
      {
        if ((double) dust.scale > 10.0)
          dust.active = false;
        dust.position += dust.velocity;
        if (dust.type == 6)
        {
          if (!dust.noGravity)
            dust.velocity.Y += 0.05f;
        }
        else if (dust.type == 267)
        {
          if ((double) dust.velocity.X < 0.0)
            --dust.rotation;
          else
            ++dust.rotation;
          dust.velocity.Y *= 0.98f;
          dust.velocity.X *= 0.98f;
          dust.scale += 0.02f;
        }
        dust.velocity.X *= 0.99f;
        dust.rotation += dust.velocity.X * 0.5f;
        if ((double) dust.fadeIn > 0.0 && (double) dust.fadeIn < 100.0)
        {
          dust.scale += 0.03f;
          if ((double) dust.scale > (double) dust.fadeIn)
            dust.fadeIn = 0.0f;
        }
        else
          dust.scale -= 0.01f;
        if (dust.noGravity)
        {
          dust.velocity *= 0.92f;
          if ((double) dust.fadeIn == 0.0)
            dust.scale -= 0.04f;
        }
        float num = 0.1f;
        if ((double) dust.scale < (double) num)
          dust.active = false;
      }
    }
  }

  internal void DrawDust()
  {
    SpriteBatch spriteBatch = Main.spriteBatch;
    for (int index = 0; index < 200; ++index)
    {
      Dust dust = this.dust[index];
      if (dust.active)
      {
        float visualScale = dust.GetVisualScale();
        Color newColor = Lighting.GetColor((int) ((double) dust.position.X + 4.0) / 16 /*0x10*/, (int) ((double) dust.position.Y + 4.0) / 16 /*0x10*/);
        if (dust.type == 6)
          newColor = Color.White;
        Color alpha = dust.GetAlpha(newColor);
        spriteBatch.Draw(TextureAssets.Dust.Value, dust.position, new Rectangle?(dust.frame), alpha, dust.GetVisualRotation(), new Vector2(4f, 4f), visualScale, SpriteEffects.None, 0.0f);
        if (dust.color.PackedValue != 0U)
        {
          Color color = dust.GetColor(alpha);
          if (color.PackedValue != 0U)
            spriteBatch.Draw(TextureAssets.Dust.Value, dust.position, new Rectangle?(dust.frame), color, dust.GetVisualRotation(), new Vector2(4f, 4f), visualScale, SpriteEffects.None, 0.0f);
        }
        if (alpha == Color.Black)
          dust.active = false;
      }
    }
  }
}
