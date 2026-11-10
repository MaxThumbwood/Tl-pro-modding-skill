// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.NextHorizonRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameContent.Skies;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class NextHorizonRenderer : IHorizonRenderer
{
  private static Asset<Texture2D>[] _sunriseTextures;
  private static Asset<Texture2D>[] _sunsetTextures;
  private static Asset<Texture2D> _sunflareGradientTexture;
  private static Asset<Texture2D> _sunflareGradientDitherTexture;
  private static Asset<Texture2D> _sunflarePointBlurryTexture;
  private static Asset<Texture2D> _sunflarePointSharpTexture;
  private static Asset<Texture2D> _bokehTexture;
  private static Asset<Texture2D> _spectraTexture;
  private static Asset<Texture2D> _sunflare1Texture;
  private static Asset<Texture2D> _sunflare2Texture;
  private List<DrawData> _drawData = new List<DrawData>(200);

  private void LoadTextures()
  {
    if (NextHorizonRenderer._sunriseTextures != null)
      return;
    NextHorizonRenderer._sunriseTextures = new Asset<Texture2D>[4]
    {
      Main.Assets.Request<Texture2D>("Images/Misc/Sunrise/Sunrise_Blue", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunrise/Sunrise_Violet", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunrise/Sunrise_Yellow", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunrise/Sunrise_Aluminum", (AssetRequestMode) 1)
    };
    NextHorizonRenderer._sunsetTextures = new Asset<Texture2D>[4]
    {
      Main.Assets.Request<Texture2D>("Images/Misc/Sunset/Sunset_Blue", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunset/Sunset_Dark", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunset/Sunset_Pink", (AssetRequestMode) 1),
      Main.Assets.Request<Texture2D>("Images/Misc/Sunset/Sunset_Red", (AssetRequestMode) 1)
    };
    NextHorizonRenderer._sunflareGradientTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/colorgradient", (AssetRequestMode) 1);
    NextHorizonRenderer._sunflareGradientDitherTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/colorgradientdither", (AssetRequestMode) 1);
    NextHorizonRenderer._sunflarePointBlurryTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/Lens/PointBlurry", (AssetRequestMode) 1);
    NextHorizonRenderer._sunflarePointSharpTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/Lens/PointSharp", (AssetRequestMode) 1);
    NextHorizonRenderer._sunflare1Texture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/flare1", (AssetRequestMode) 1);
    NextHorizonRenderer._sunflare2Texture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/flare2", (AssetRequestMode) 1);
    NextHorizonRenderer._bokehTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/Lens/Flare1", (AssetRequestMode) 1);
    NextHorizonRenderer._spectraTexture = Main.Assets.Request<Texture2D>("Images/Misc/Sunflare/Lens/Flare2", (AssetRequestMode) 1);
  }

  private static Rectangle GetGradientRect()
  {
    int num = 400;
    return new Rectangle(0, Math.Max(0, (int) ((1.0 - Utils.GetLerpValue(40.0, Main.worldSurface, (double) Main.screenPosition.Y / 16.0)) * (double) num)) - num, Main.screenWidth, Main.screenHeight + num);
  }

  public void DrawHorizon()
  {
    if (!Main.ShouldDrawSurfaceBackground())
      return;
    this.LoadTextures();
    int sunsetTextureIndex = this.GetSunriseSunsetTextureIndex();
    Asset<Texture2D> sunriseTexture = NextHorizonRenderer._sunriseTextures[sunsetTextureIndex % NextHorizonRenderer._sunriseTextures.Length];
    Asset<Texture2D> sunsetTexture = NextHorizonRenderer._sunsetTextures[sunsetTextureIndex % NextHorizonRenderer._sunsetTextures.Length];
    float sunsetVisibility;
    float sunriseVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out float _);
    SpriteBatch spriteBatch = Main.spriteBatch;
    Rectangle gradientRect = NextHorizonRenderer.GetGradientRect();
    foreach (BackgroundGradientDrawer backgroundDrawer in SunGradients.BackgroundDrawers)
      backgroundDrawer.Draw();
    if ((double) sunriseVisibility != 0.0)
      spriteBatch.Draw(sunriseTexture.Value, gradientRect, Color.White * sunriseVisibility);
    if ((double) sunsetVisibility == 0.0)
      return;
    spriteBatch.Draw(sunsetTexture.Value, gradientRect, Color.White * sunsetVisibility);
  }

  public float GetMoonStrength()
  {
    return Utils.Remap((float) Math.Abs(4 - Main.moonPhase), 0.0f, 4f, 0.0f, 1f);
  }

  public void DrawSurfaceLayer(int layerIndex)
  {
    if (!Main.ShouldDrawSurfaceBackground())
      return;
    this.LoadTextures();
    SpriteBatch spriteBatch = Main.spriteBatch;
    Rectangle gradientRect = NextHorizonRenderer.GetGradientRect();
    float sunsetVisibility;
    float sunriseVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out float _);
    int sunsetTextureIndex = this.GetSunriseSunsetTextureIndex();
    List<Color[]> sunrises = SunGradients.Sunrises;
    Color[] colorArray1 = sunrises[sunsetTextureIndex % sunrises.Count];
    List<Color[]> sunsets = SunGradients.Sunsets;
    Color[] colorArray2 = sunsets[sunsetTextureIndex % sunsets.Count];
    Color transparent = Color.Transparent;
    this.BlendColor(ref transparent, colorArray2[0], sunsetVisibility);
    this.BlendColor(ref transparent, colorArray1[0], sunriseVisibility);
    float num1 = 1f;
    switch (layerIndex)
    {
      case 0:
        num1 = 1f;
        break;
      case 1:
        num1 = 0.75f;
        break;
      case 2:
        num1 = 0.5f;
        break;
      case 3:
        num1 = 0.5f;
        break;
    }
    Asset<Texture2D> sunriseTexture = NextHorizonRenderer._sunriseTextures[sunsetTextureIndex % NextHorizonRenderer._sunriseTextures.Length];
    Asset<Texture2D> sunsetTexture = NextHorizonRenderer._sunsetTextures[sunsetTextureIndex % NextHorizonRenderer._sunsetTextures.Length];
    TileBatch tileBatch = Main.tileBatch;
    if (layerIndex != 3)
      return;
    float num2 = 0.6f;
    float num3 = 1f;
    spriteBatch.Draw(NextHorizonRenderer._sunflareGradientTexture.Value, gradientRect, new Rectangle?(), colorArray1[0] * num3 * sunriseVisibility * num2, 0.0f, Vector2.Zero, SpriteEffects.FlipHorizontally, 0.0f);
    spriteBatch.Draw(NextHorizonRenderer._sunflareGradientTexture.Value, gradientRect, new Rectangle?(), colorArray2[0] * num3 * sunsetVisibility * num2, 0.0f, Vector2.Zero, SpriteEffects.None, 0.0f);
  }

  private int GetSunriseSunsetTextureIndex() => Main.HorizonPhase;

  public void ModifyHorizonLight(ref Color color)
  {
    if (!Main.ShouldDrawSurfaceBackground())
      return;
    float sunsetVisibility;
    float sunriseVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out float _);
    int sunsetTextureIndex = this.GetSunriseSunsetTextureIndex();
    List<Color[]> sunrises = SunGradients.Sunrises;
    Color[] gradient1 = sunrises[sunsetTextureIndex % sunrises.Count];
    List<Color[]> sunsets = SunGradients.Sunsets;
    Color[] gradient2 = sunsets[sunsetTextureIndex % sunsets.Count];
    this.BlendColor(ref color, gradient2, sunsetVisibility);
    this.BlendColor(ref color, gradient1, sunriseVisibility);
  }

  public void DrawSun(Vector2 sunPosition)
  {
    float sunsetVisibility;
    float sunriseVisibility;
    float celestialVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out celestialVisibility);
    float num1 = sunsetVisibility * celestialVisibility;
    float num2 = sunriseVisibility * celestialVisibility;
    this.LoadTextures();
    Color color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
    SpriteBatch spriteBatch = Main.spriteBatch;
    spriteBatch.Draw(NextHorizonRenderer._sunflare1Texture.Value, sunPosition, new Rectangle?(), color * num1 * 0.75f, 0.0f, NextHorizonRenderer._sunflare1Texture.Size() / 2f, 3f, SpriteEffects.None, 0.0f);
    spriteBatch.Draw(NextHorizonRenderer._sunflare1Texture.Value, sunPosition, new Rectangle?(), color * num1 * 0.35f, 0.0f, NextHorizonRenderer._sunflare1Texture.Size() / 2f, 2f, SpriteEffects.None, 0.0f);
    spriteBatch.Draw(NextHorizonRenderer._sunflare2Texture.Value, sunPosition, new Rectangle?(), color * num2 * 0.7f * 0.5f, 0.0f, NextHorizonRenderer._sunflare2Texture.Size() / 2f, 2f, SpriteEffects.None, 0.0f);
    spriteBatch.Draw(NextHorizonRenderer._sunflare2Texture.Value, sunPosition, new Rectangle?(), color * num2 * 0.3f * 0.5f, 0.0f, NextHorizonRenderer._sunflare2Texture.Size() / 2f, 1.5f, SpriteEffects.None, 0.0f);
    spriteBatch.Draw(NextHorizonRenderer._sunflare2Texture.Value, sunPosition, new Rectangle?(), color * num2 * 0.2f * 0.5f, 0.0f, NextHorizonRenderer._sunflare2Texture.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
  }

  private void BlendColor(ref Color color, Color[] gradient, float opacity)
  {
    this.BlendColor(ref color, gradient[gradient.Length / 2], opacity);
  }

  private void BlendColor(ref Color color, Color colorToChoose, float opacity)
  {
    if ((double) opacity <= 0.0)
      return;
    Color color1 = new Color((int) Math.Max(color.R, colorToChoose.R), (int) Math.Max(color.G, colorToChoose.G), (int) Math.Max(color.B, colorToChoose.B), (int) Math.Max(color.A, colorToChoose.A));
    color = Color.Lerp(color, color1, opacity);
  }

  private static void GetVisibilities(
    out float sunsetVisibility,
    out float sunriseVisibility,
    out float celestialVisibility)
  {
    sunsetVisibility = 1f;
    sunriseVisibility = 1f;
    celestialVisibility = NextHorizonRenderer.GetCelestialEffectPower();
    float num1 = 1f * Main.atmo;
    float num2 = 1f - Main.cloudAlpha;
    float num3 = num1 * (num2 * num2) * (1f - Main.SmoothedMushroomLightInfluence);
    sunriseVisibility *= num3;
    sunsetVisibility *= num3;
    double time = Main.time;
    double fromMax1 = 54000.0;
    if (Main.dayTime)
    {
      float fromMin = 3600f;
      int fromMax2 = 2700;
      float fromMax3 = 10800f;
      float num4 = -10800f;
      float num5 = -3600f;
      sunriseVisibility *= Utils.Remap((float) time, 0.0f, (float) fromMax2, 0.0f, 1f) * Utils.Remap((float) time, fromMin, fromMax3, 1f, 0.0f);
      float num6 = Utils.Remap((float) time, (float) fromMax1 + num4, (float) fromMax1 + num5, 0.0f, 1f);
      float num7 = Utils.Remap((float) time, (float) fromMax1 + num5, (float) fromMax1, 1f, 0.0f);
      sunsetVisibility *= num6 * num7 * num7;
      if (Main.eclipse)
      {
        sunsetVisibility = 0.0f;
        sunriseVisibility = 0.0f;
      }
    }
    else
    {
      sunriseVisibility = 0.0f;
      sunsetVisibility = 0.0f;
    }
    if (!Main.gameMenu || !WorldGen.drunkWorldGen)
      return;
    sunsetVisibility = sunriseVisibility = 0.0f;
  }

  public void CloudsStart() => this._drawData.Clear();

  public void DrawCloud(float globalCloudAlpha, Cloud theCloud, int cloudPass, float cY)
  {
    Asset<Texture2D> tex = TextureAssets.Cloud[theCloud.type];
    Vector2 position = new Vector2(theCloud.position.X, cY) + tex.Size() / 2f;
    Color cloudColor = theCloud.cloudColor(Main.ColorOfTheSkies);
    this.OriginalColorsForCloud(theCloud, cloudPass, ref cloudColor);
    if ((double) Main.atmo < 1.0)
      cloudColor *= Main.atmo;
    this._drawData.Add(new DrawData(tex.Value, position, new Rectangle?(), cloudColor * globalCloudAlpha, theCloud.rotation, tex.Size() / 2f, theCloud.scale, theCloud.spriteDir));
  }

  private void OriginalColorsForCloud(Cloud theCloud, int cloudPass, ref Color cloudColor)
  {
    if (cloudPass != 1)
      return;
    float num1 = theCloud.scale * 0.8f;
    float num2 = (float) (((double) theCloud.scale + 1.0) / 2.0 * 0.89999997615814209);
    cloudColor.R = (byte) ((double) cloudColor.R * (double) num1);
    cloudColor.G = (byte) ((double) cloudColor.G * (double) num2);
  }

  private void BetterColorsForClouds(
    Cloud theCloud,
    int cloudPass,
    ref Vector2 cloudDrawPosition,
    ref Color cloudColor)
  {
    float num = 0.0f;
    switch (cloudPass)
    {
      case 1:
        num = 0.7f;
        break;
      case 2:
        num = 0.35f;
        break;
    }
    if (Main.keyState.IsKeyDown(Keys.LeftShift))
      num = 0.0f;
    if ((double) num <= 0.0)
      return;
    float sunsetVisibility;
    float sunriseVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out float _);
    int sunsetTextureIndex = this.GetSunriseSunsetTextureIndex();
    List<Color[]> sunrises = SunGradients.Sunrises;
    Color[] gradient1 = sunrises[sunsetTextureIndex % sunrises.Count];
    List<Color[]> sunsets = SunGradients.Sunsets;
    Color[] gradient2 = sunsets[sunsetTextureIndex % sunsets.Count];
    float normalizedScreenHeight = cloudDrawPosition.Y / (float) Main.screenHeight;
    float alpha = theCloud.Alpha;
    this.BlendColorAlongGradientBasedOnHeight(ref cloudColor, sunsetVisibility, normalizedScreenHeight, gradient2, alpha);
    this.BlendColorAlongGradientBasedOnHeight(ref cloudColor, sunriseVisibility, normalizedScreenHeight, gradient1, alpha);
  }

  private void BlendColorAlongGradientBasedOnHeight(
    ref Color color,
    float visibility,
    float normalizedScreenHeight,
    Color[] gradient,
    float opacity)
  {
    double d = (double) MathHelper.Clamp(normalizedScreenHeight * (float) gradient.Length, 0.0f, (float) (gradient.Length - 1));
    float amount = (float) (d % 1.0);
    int index = (int) Math.Floor(d);
    if ((double) amount == 0.0 || index == gradient.Length - 1)
    {
      this.BlendColor(ref color, gradient[index] * opacity, visibility);
    }
    else
    {
      Color colorToChoose = Color.Lerp(gradient[index], gradient[index + 1], amount) * opacity;
      this.BlendColor(ref color, colorToChoose, visibility);
    }
  }

  private static float GetCelestialEffectPower()
  {
    float num1 = 1800f;
    float num2 = 1800f;
    float toMax = 0.0f;
    return Main.dayTime ? Utils.Remap((float) Main.time, 0.0f, num1 * 2f, 0.0f, 1f) * Utils.Remap((float) Main.time, 54000f - num1, 54000f, 1f, toMax) : Utils.Remap((float) Main.time, 0.0f, num2 * 2f, 0.0f, 1f) * Utils.Remap((float) Main.time, 32400f - num2, 32400f, 1f, 0.0f);
  }

  public void CloudsEnd()
  {
    if (this._drawData.Count == 0)
      return;
    Main.spriteBatch.End();
    SpriteDrawBuffer spriteBuffer = Main.spriteBuffer;
    foreach (DrawData drawData in this._drawData)
      drawData.Draw(spriteBuffer);
    MiscShaderData miscShaderData = GameShaders.Misc["HorizonClouds"];
    miscShaderData.UseSpriteTransformMatrix(new Matrix?(Main.LatestSurfaceBackgroundBeginner.transformMatrix));
    Color sunColor;
    Color moonColor;
    HorizonHelper.GetCelestialBodyColors(out sunColor, out moonColor);
    Color tileColor = Main.dayTime ? sunColor : moonColor;
    AuroraSky.ModifyTileColor(ref tileColor, 1f);
    miscShaderData.UseColor(tileColor);
    Vector2 celestialBodyPosition = NextHorizonRenderer.GetCelestialBodyPosition();
    float sunsetVisibility;
    float sunriseVisibility;
    float celestialVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out celestialVisibility);
    float val1 = Math.Max(sunsetVisibility, sunriseVisibility) * celestialVisibility;
    if (!Main.dayTime)
      val1 = Math.Max(val1, celestialVisibility * 0.15f);
    float z = val1 * Utils.Clamp<float>(1f - Main.cloudBGAlpha, 0.0f, 1f);
    miscShaderData.UseShaderSpecificData(new Vector4(celestialBodyPosition.X, celestialBodyPosition.Y, z, 0.0f));
    for (int index = 0; index < this._drawData.Count; ++index)
    {
      miscShaderData.Apply(new DrawData?(this._drawData[index]));
      spriteBuffer.DrawSingle(index);
    }
    spriteBuffer.Unbind();
    Main.LatestSurfaceBackgroundBeginner.Begin(Main.spriteBatch);
  }

  private static Vector2 GetCelestialBodyPosition()
  {
    return Main.LastCelestialBodyPosition * Main.ScreenSize.ToVector2();
  }

  public void DrawLensFlare()
  {
    if (!Main.ShouldDrawSurfaceBackground() || !Main.ForegroundSunlightEffects)
      return;
    SpriteBatch spriteBatch = Main.spriteBatch;
    Vector2 celestialBodyPosition = NextHorizonRenderer.GetCelestialBodyPosition();
    Vector2 screenCenter = Main.ScreenSize.ToVector2() / 2f;
    float sunsetVisibility;
    float sunriseVisibility;
    float celestialVisibility;
    NextHorizonRenderer.GetVisibilities(out sunsetVisibility, out sunriseVisibility, out celestialVisibility);
    float intensity1 = this.AdjustIntensity(sunriseVisibility, celestialVisibility);
    float intensity2 = this.AdjustIntensity(sunsetVisibility, celestialVisibility);
    if ((double) intensity1 <= 0.01 && (double) intensity2 <= 0.01)
      return;
    Main.LatestSurfaceBackgroundBeginner.Begin(spriteBatch, SpriteSortMode.Immediate);
    EffectPass pass = Main.pixelShader.CurrentTechnique.Passes[0];
    MiscShaderData miscShaderData = GameShaders.Misc["LensFlare"];
    miscShaderData.UseImage1((Texture) Main.HorizonHelper.SunVisibilityPixelTexture);
    miscShaderData.Apply(new DrawData?());
    this.DrawSunriseFlare(spriteBatch, celestialBodyPosition, screenCenter, intensity1);
    this.DrawSunsetFlare(spriteBatch, celestialBodyPosition, screenCenter, intensity2);
    spriteBatch.End();
    pass.Apply();
  }

  private float AdjustIntensity(float temporalIntensity, float celestialVisibility)
  {
    float num1 = temporalIntensity * celestialVisibility;
    float num2 = num1 * (num1 * num1);
    int sunScorchCounter = Main.SceneMetrics.PerspectivePlayer.sunScorchCounter;
    if (sunScorchCounter > 0)
    {
      float num3 = 1f - Utils.GetLerpValue(0.0f, 300f, (float) sunScorchCounter, true);
      num2 = (float) (1.0 - (double) num3 * (double) num3) * celestialVisibility * 5f;
    }
    return num2;
  }

  private void DrawSunsetFlare(
    SpriteBatch spriteBatch,
    Vector2 sunPosition,
    Vector2 screenCenter,
    float intensity)
  {
    if ((double) intensity <= 0.0099999997764825821)
      return;
    this.LoadTextures();
    LensFlareElement lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointBlurryTexture;
    lensFlareElement.RepeatTimes = 3;
    lensFlareElement.DistanceStart = 0.33f;
    lensFlareElement.DistanceAlongIndex = 0.05f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.ScaleOverIndex = -0.04f;
    lensFlareElement.Color = new Color(43, 32 /*0x20*/, 0, 0) * 0.470588237f;
    lensFlareElement.IntensityOverIndex = -0.125f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointSharpTexture;
    lensFlareElement.RepeatTimes = 3;
    lensFlareElement.DistanceStart = 0.03f;
    lensFlareElement.DistanceAlongIndex = 0.05f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.ScaleOverIndex = 0.04f;
    lensFlareElement.Color = new Color(43, 32 /*0x20*/, 0, 0) * 0.470588237f;
    lensFlareElement.IntensityOverIndex = -0.125f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointBlurryTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.41f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, 0, 65, 0) * 0.117647059f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._bokehTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.475f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.156862751f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._bokehTexture;
    lensFlareElement.RepeatTimes = 6;
    lensFlareElement.DistanceStart = 0.225f;
    lensFlareElement.DistanceAlongIndex = 0.04f;
    lensFlareElement.ScaleStart = 0.24f;
    lensFlareElement.ScaleOverIndex = -0.04f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.0784313753f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointBlurryTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.6f;
    lensFlareElement.ScaleStart = 1f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, 157, 0, 0) * 0.156862751f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._spectraTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.65f;
    lensFlareElement.ScaleStart = 0.4f;
    lensFlareElement.Rotation = 3.14159274f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.0392156877f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
  }

  private void DrawSunriseFlare(
    SpriteBatch spriteBatch,
    Vector2 sunPosition,
    Vector2 screenCenter,
    float intensity)
  {
    if ((double) intensity <= 0.0099999997764825821)
      return;
    this.LoadTextures();
    LensFlareElement lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointSharpTexture;
    lensFlareElement.RepeatTimes = 3;
    lensFlareElement.DistanceStart = 0.33f;
    lensFlareElement.DistanceAlongIndex = 0.05f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.ScaleOverIndex = -0.04f;
    lensFlareElement.Color = new Color(0, 32 /*0x20*/, 43, 0) * 0.470588237f;
    lensFlareElement.IntensityOverIndex = -0.125f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointSharpTexture;
    lensFlareElement.RepeatTimes = 3;
    lensFlareElement.DistanceStart = 0.03f;
    lensFlareElement.DistanceAlongIndex = 0.05f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.ScaleOverIndex = 0.04f;
    lensFlareElement.Color = new Color(0, 32 /*0x20*/, 43, 0) * 0.470588237f;
    lensFlareElement.IntensityOverIndex = -0.125f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointBlurryTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.41f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.Color = new Color(65, 0, (int) byte.MaxValue, 0) * 0.117647059f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._bokehTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.525f;
    lensFlareElement.Rotation = 0.01f;
    lensFlareElement.ScaleStart = 0.3f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.156862751f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._bokehTexture;
    lensFlareElement.RepeatTimes = 6;
    lensFlareElement.DistanceStart = 0.225f;
    lensFlareElement.DistanceAlongIndex = 0.04f;
    lensFlareElement.ScaleStart = 0.24f;
    lensFlareElement.ScaleOverIndex = -0.04f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.0784313753f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._sunflarePointBlurryTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.6f;
    lensFlareElement.ScaleStart = 1f;
    lensFlareElement.Color = new Color(0, 157, (int) byte.MaxValue, 0) * 0.156862751f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
    lensFlareElement = new LensFlareElement();
    lensFlareElement.Texture = NextHorizonRenderer._spectraTexture;
    lensFlareElement.RepeatTimes = 1;
    lensFlareElement.DistanceStart = 0.65f;
    lensFlareElement.ScaleStart = 0.38f;
    lensFlareElement.Rotation = 3.14159274f;
    lensFlareElement.Color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.0392156877f;
    lensFlareElement.Draw(spriteBatch, sunPosition, screenCenter, intensity);
  }
}
