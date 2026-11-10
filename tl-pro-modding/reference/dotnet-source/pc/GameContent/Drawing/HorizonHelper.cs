// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.HorizonHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class HorizonHelper
{
  public static bool DebugSunVisibility = false;
  private readonly int SampleAreaSize = 128 /*0x80*/;
  private readonly int SmallTextureSize = 64 /*0x40*/;
  private RenderTarget2D _tinyTarget;
  private RenderTarget2D _pixelTarget;
  private BlendState _horizonBlendState = new BlendState()
  {
    AlphaSourceBlend = Blend.Zero,
    AlphaDestinationBlend = Blend.InverseSourceAlpha,
    ColorSourceBlend = Blend.Zero,
    ColorDestinationBlend = Blend.InverseSourceAlpha
  };
  private static Color[] MoonColors = new Color[9]
  {
    new Color(230, 235, (int) byte.MaxValue),
    new Color(250, 235, 160 /*0xA0*/),
    new Color(230, (int) byte.MaxValue, 230),
    new Color(160 /*0xA0*/, 240 /*0xF0*/, (int) byte.MaxValue),
    new Color(180, (int) byte.MaxValue, (int) byte.MaxValue),
    new Color(230, (int) byte.MaxValue, 230),
    new Color((int) byte.MaxValue, 180, (int) byte.MaxValue),
    new Color((int) byte.MaxValue, 200, 180),
    new Color(225, 180, (int) byte.MaxValue)
  };

  public Texture2D SunVisibilityPixelTexture => (Texture2D) this._pixelTarget;

  public void UpdateSunVisibility(RenderTarget2D bigTarget)
  {
    if (!Main.ForegroundSunlightEffects)
      return;
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    GraphicsDevice graphicsDevice = Main.instance.GraphicsDevice;
    if (this._tinyTarget == null || this._tinyTarget.IsContentLost)
      this._tinyTarget = new RenderTarget2D(graphicsDevice, this.SmallTextureSize, this.SmallTextureSize, true, SurfaceFormat.Alpha8, DepthFormat.None);
    if (this._pixelTarget == null || this._pixelTarget.IsContentLost)
      this._pixelTarget = new RenderTarget2D(graphicsDevice, 1, 1, false, SurfaceFormat.Alpha8, DepthFormat.None);
    Rectangle sunSampleRect = Utils.CenteredRectangle(Main.ReverseGravitySupport(Main.LastCelestialBodyPosition * Main.ScreenSize.ToVector2()), new Vector2((float) this.SampleAreaSize) * Main.BackgroundViewMatrix.RenderZoom);
    if (HorizonHelper.DebugSunVisibility)
      this.Test_DrawSmallTarget(bigTarget, sunSampleRect);
    graphicsDevice.SetRenderTarget(this._tinyTarget);
    graphicsDevice.Clear(Color.Transparent);
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullCounterClockwise);
    Main.spriteBatch.Draw((Texture2D) bigTarget, this._tinyTarget.Bounds, new Rectangle?(sunSampleRect), Color.White);
    Main.spriteBatch.End();
    graphicsDevice.SetRenderTarget(this._pixelTarget);
    graphicsDevice.Clear(Color.White);
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, this._horizonBlendState, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullCounterClockwise);
    Main.spriteBatch.Draw((Texture2D) this._tinyTarget, this._pixelTarget.Bounds, Color.White);
    Main.spriteBatch.End();
    graphicsDevice.SetRenderTarget((RenderTarget2D) null);
    TimeLogger.SunVisibility.AddTime(fromTimestamp);
  }

  private void Test_DrawSmallTarget(RenderTarget2D bigTarget, Rectangle sunSampleRect)
  {
    GraphicsDevice graphicsDevice = Main.instance.GraphicsDevice;
    graphicsDevice.SetRenderTarget(bigTarget);
    SpriteBatch spriteBatch = Main.spriteBatch;
    BlendState blendState = new BlendState();
    blendState.ColorDestinationBlend = Blend.Zero;
    blendState.ColorSourceBlend = Blend.SourceAlpha;
    blendState.AlphaDestinationBlend = Blend.Zero;
    blendState.AlphaSourceBlend = Blend.SourceAlpha;
    SamplerState pointClamp = SamplerState.PointClamp;
    DepthStencilState depthStencilState = DepthStencilState.Default;
    RasterizerState counterClockwise = RasterizerState.CullCounterClockwise;
    spriteBatch.Begin(SpriteSortMode.Immediate, blendState, pointClamp, depthStencilState, counterClockwise);
    Main.spriteBatch.Draw((Texture2D) this._tinyTarget, new Rectangle(0, 0, sunSampleRect.Width, sunSampleRect.Height), Color.White);
    Main.spriteBatch.End();
    Main.spriteBatch.Begin();
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(sunSampleRect.Left, sunSampleRect.Top, 1, sunSampleRect.Height), Color.Red);
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(sunSampleRect.Right, sunSampleRect.Top, 1, sunSampleRect.Height), Color.Red);
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(sunSampleRect.Left, sunSampleRect.Top, sunSampleRect.Width, 1), Color.Red);
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(sunSampleRect.Left, sunSampleRect.Bottom, sunSampleRect.Width, 1), Color.Red);
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(sunSampleRect.Width, 0, 1, sunSampleRect.Height), Color.Red);
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(0, sunSampleRect.Height, sunSampleRect.Width, 1), Color.Red);
    byte[] data = new byte[1];
    this._pixelTarget.GetData<byte>(data);
    float num = (float) data[0] / (float) byte.MaxValue;
    Utils.DrawBorderString(Main.spriteBatch, $"{num:F3}", new Vector2(10f, (float) (sunSampleRect.Height + 20)), Color.White);
    Main.spriteBatch.End();
    graphicsDevice.SetRenderTarget((RenderTarget2D) null);
  }

  public static void GetCelestialBodyColors(out Color sunColor, out Color moonColor)
  {
    sunColor = new Color((int) byte.MaxValue, 246, 204);
    moonColor = HorizonHelper.GetMoonColor() * HorizonHelper.GetMoonStrength();
  }

  private static Color GetMoonColor()
  {
    Color color = new Color(230, 235, (int) byte.MaxValue);
    int index = Main.moonType;
    if (!TextureAssets.Moon.IndexInRange<Asset<Texture2D>>(index))
      index = Utils.Clamp<int>(index, 0, 8);
    Color moonColor = HorizonHelper.MoonColors[index];
    if (Main.pumpkinMoon)
      moonColor = new Color((int) byte.MaxValue, 225, 180);
    if (Main.snowMoon)
      moonColor = new Color(220, 220, (int) byte.MaxValue);
    if (WorldGen.drunkWorldGen)
      moonColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    return moonColor;
  }

  public static float GetMoonStrength()
  {
    return Utils.Remap((float) Math.Abs(4 - Main.moonPhase), 0.0f, 4f, 0.0f, 1f);
  }
}
