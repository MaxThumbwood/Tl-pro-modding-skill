// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.NextNatureRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class NextNatureRenderer : INatureRenderer
{
  private readonly List<NextNatureRenderer.Entry> _entries = new List<NextNatureRenderer.Entry>();

  public void DrawNature(
    Texture2D texture,
    Vector2 position,
    Rectangle sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth,
    SideFlags seams = SideFlags.None)
  {
    seams |= NextNatureRenderer.GetOriginSides(sourceRectangle, origin);
    this._entries.Add(new NextNatureRenderer.Entry()
    {
      Data = new DrawData(texture, position, new Rectangle?(sourceRectangle), color, rotation, origin, scale, effects),
      IsGlowMask = false,
      Seams = seams
    });
  }

  private static SideFlags GetOriginSides(Rectangle sourceRectangle, Vector2 origin)
  {
    float num1 = origin.X / (float) sourceRectangle.Width;
    double num2 = 1.0 - (double) num1;
    float num3 = origin.Y / (float) sourceRectangle.Height;
    float num4 = 1f - num3;
    SideFlags originSides = SideFlags.None;
    if ((double) num1 < 0.25)
      originSides |= SideFlags.Left;
    if (num2 < 0.25)
      originSides |= SideFlags.Right;
    if ((double) num3 < 0.25)
      originSides |= SideFlags.Top;
    if ((double) num4 < 0.25)
      originSides |= SideFlags.Bottom;
    return originSides;
  }

  public void DrawGlowmask(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth)
  {
    this._entries.Add(new NextNatureRenderer.Entry()
    {
      Data = new DrawData(texture, position, sourceRectangle, color, rotation, origin, scale, effects),
      IsGlowMask = true
    });
  }

  public void DrawAfterAllObjects(SpriteBatchBeginner beginner)
  {
    if (this._entries.Count == 0)
      return;
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    float num1 = 0.0f;
    if (Main.dayTime)
    {
      float time = (float) Main.time;
      float fromMax = 54000f;
      double val1 = (double) Utils.Remap(time, 1200f, 5400f, 0.0f, 1f) * (double) Utils.Remap(time, 1200f, 7200f, 1f, 0.0f) * 0.30000001192092896;
      float num2 = (float) ((double) Utils.Remap(time, fromMax - 10800f, fromMax - 4200f, 0.0f, 1f) * (double) Utils.Remap(time, fromMax - 1800f, fromMax - 600f, 1f, 0.0f) * 0.40000000596046448);
      float num3 = num2 * num2;
      float val2_1 = (float) ((double) Utils.Remap(time, 0.0f, 7200f, 0.0f, 1f) * (double) Utils.Remap(time, fromMax - 7200f, fromMax, 1f, 0.0f) * 0.0);
      double val2_2 = (double) num3;
      num1 = Math.Max(Math.Max((float) val1, (float) val2_2), val2_1);
      if (Main.eclipse)
        num1 = 0.0f;
    }
    float num4 = num1 * 0.4f;
    Vector2 celestialBodyPosition = Main.LastCelestialBodyPosition;
    float num5 = Utils.Remap(Math.Min(celestialBodyPosition.X, 1f - celestialBodyPosition.X), 0.0f, 0.010416667f, 0.0f, 1f);
    float visibility = num4 * num5;
    if (!Main.ShouldDrawSurfaceBackground() || !Main.ForegroundSunlightEffects)
      visibility = 0.0f;
    if ((double) visibility == 0.0)
      this.DrawWithoutShader(beginner, Main.spriteBatch);
    else
      this.DrawWithLitNatureShader(beginner, visibility, celestialBodyPosition);
    this._entries.Clear();
    TimeLogger.Nature.AddTime(fromTimestamp);
  }

  private void DrawWithoutShader(SpriteBatchBeginner beginner, SpriteBatch spriteBatch)
  {
    beginner.Begin(spriteBatch);
    foreach (NextNatureRenderer.Entry entry in this._entries)
      entry.Data.Draw(spriteBatch);
    spriteBatch.End();
  }

  private void DrawWithLitNatureShader(
    SpriteBatchBeginner beginner,
    float visibility,
    Vector2 sunPosition)
  {
    SpriteDrawBuffer spriteBuffer = Main.spriteBuffer;
    foreach (NextNatureRenderer.Entry entry in this._entries)
      entry.Data.Draw(spriteBuffer);
    MiscShaderData miscShaderData = GameShaders.Misc["LitNature"];
    Vector2 vector2 = Vector2.Transform(Main.ReverseGravitySupport(sunPosition * Main.ScreenSize.ToVector2()), Matrix.Invert(Main.Transform));
    Vector4 specificData = new Vector4(vector2.X, vector2.Y, visibility, 0.0f);
    miscShaderData.UseImage1((Texture) Main.HorizonHelper.SunVisibilityPixelTexture);
    miscShaderData.UseSpriteTransformMatrix(new Matrix?(beginner.transformMatrix));
    Color sunColor;
    Color moonColor;
    HorizonHelper.GetCelestialBodyColors(out sunColor, out moonColor);
    Vector3 hsl = Main.rgbToHsl(Main.dayTime ? sunColor : moonColor);
    Color color = Main.hslToRgb(hsl.X, Utils.Clamp<float>(hsl.Y * 8f, 0.0f, 1f), hsl.Z * 1f) * 0.5f;
    miscShaderData.UseColor(Color.Lerp(color, new Color((int) byte.MaxValue, 200, 0), 0.8f));
    int num = 0;
    foreach (NextNatureRenderer.Entry entry in this._entries)
    {
      specificData.W = entry.IsGlowMask ? -1f : (float) entry.Seams;
      miscShaderData.UseShaderSpecificData(specificData);
      miscShaderData.Apply(new DrawData?(entry.Data));
      spriteBuffer.DrawSingle(num++);
    }
    spriteBuffer.Unbind();
  }

  private struct Entry
  {
    public DrawData Data;
    public SideFlags Seams;
    public bool IsGlowMask;
  }
}
