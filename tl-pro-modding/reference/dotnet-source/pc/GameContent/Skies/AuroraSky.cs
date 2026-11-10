// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Skies.AuroraSky
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Skies;

public class AuroraSky : CustomSky
{
  private UnifiedRandom _random = new UnifiedRandom();
  private bool _isActive;
  private bool _isLeaving;
  private float _opacity;
  private VertexStrip vertexStrip = new VertexStrip();
  private Color _lastSkyColor;

  public override void OnLoad()
  {
  }

  public override void Update(GameTime gameTime)
  {
    if (FocusHelper.PauseSkies)
      return;
    if (this._isLeaving)
    {
      this._opacity -= (float) (gameTime.ElapsedGameTime.TotalSeconds * 0.5);
      if ((double) this._opacity >= 0.0)
        return;
      this._isActive = false;
      this._opacity = 0.0f;
    }
    else
    {
      this._opacity += (float) (gameTime.ElapsedGameTime.TotalSeconds * 0.30000001192092896);
      if ((double) this._opacity <= 1.0)
        return;
      this._opacity = 1f;
    }
  }

  public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
  {
    if ((double) maxDepth != 3.4028234663852886E+38)
      return;
    AuroraSky.DrawAuroraSky(this.vertexStrip, this._opacity, ref this._lastSkyColor);
  }

  private static void DrawAuroraSky(
    VertexStrip vertexStrip,
    float skyOpacity,
    ref Color lastSkyColor)
  {
    MiscShaderData miscShaderData = GameShaders.Misc["Aurora"];
    float fromMax = Main.dayTime ? 54000f : 32400f;
    float time = (float) Main.time;
    skyOpacity *= Utils.Remap(time, 0.0f, 180f, 0.0f, 1f) * Utils.Remap(time, fromMax - 180f, fromMax, 1f, 0.0f);
    if ((double) skyOpacity <= 0.0099999997764825821 || Main.dayTime)
      return;
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    int num1 = 1;
    float num2 = 1f;
    float num3 = 1f;
    bool flag5 = false;
    float Saturation = 1f;
    switch (Main.GetMoonPhase())
    {
      case MoonPhase.Full:
        flag1 = true;
        num1 = 3;
        break;
      case MoonPhase.ThreeQuartersAtLeft:
        num1 = 2;
        flag5 = true;
        break;
      case MoonPhase.HalfAtLeft:
        flag2 = true;
        flag3 = true;
        num1 = 3;
        flag4 = true;
        num3 *= 0.5f;
        break;
      case MoonPhase.QuarterAtLeft:
        return;
      case MoonPhase.Empty:
        flag2 = true;
        num1 = 3;
        break;
      case MoonPhase.QuarterAtRight:
        num1 = 2;
        flag5 = true;
        Saturation = 0.5f;
        break;
      case MoonPhase.HalfAtRight:
        return;
      case MoonPhase.ThreeQuartersAtRight:
        flag2 = true;
        flag3 = true;
        num1 = 3;
        flag4 = true;
        num3 *= 0.5f;
        Saturation = 0.5f;
        break;
    }
    PlayerInput.SetZoom_Background();
    Main.spriteBatch.End();
    Vector2 vector2 = new Vector2(1920f, 1080f);
    float scale = (float) Main.ScreenSize.X / vector2.X;
    miscShaderData.UseSpriteTransformMatrix(new Matrix?(Main.LatestSurfaceBackgroundBeginner.transformMatrix * Matrix.CreateScale(scale)));
    Vector2 celestialBodyPosition = Main.LastCelestialBodyPosition;
    celestialBodyPosition.Y *= (float) ((double) vector2.X / (double) vector2.Y / ((double) Main.ScreenSize.X / (double) Main.ScreenSize.Y));
    float num4 = Main.GlobalTimeWrappedHourly / 60f;
    for (int index1 = 0; index1 < num1; ++index1)
    {
      vertexStrip.Reset();
      int num5 = 140;
      float num6 = 2.5f;
      float num7 = 0.0f;
      float Luminosity = 1f;
      Vector4 specificData = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
      if (index1 == 0)
        specificData.Y = 0.0f;
      if (index1 == 1)
        specificData.Y = 0.7f;
      if (index1 == 2)
        specificData.Y = 0.8f;
      if (flag4)
      {
        Luminosity = 1f;
        specificData.X = 0.3f;
      }
      if (flag2)
      {
        num6 = 1f;
        num7 += 0.33f;
        if (index1 != 0)
          specificData.Y = (float) (0.40000000596046448 + (double) index1 * 0.20000000298023224);
        if (!flag3)
          specificData.Z = 0.2f;
      }
      if (flag1 && index1 != 0)
        specificData.Y = 0.4f;
      if (flag5 && index1 == 0)
        specificData.Y = 0.3f;
      if (flag5 && index1 == 1)
        specificData.Y = 0.5f;
      if (flag1 && index1 == 0)
        specificData.Y = 0.5f;
      if (flag2 && index1 == 0)
        specificData.Y = 0.7f;
      miscShaderData.UseShaderSpecificData(specificData);
      for (int index2 = num5; index2 >= 0; --index2)
      {
        float num8 = (float) index2 / (float) num5;
        float num9 = num8;
        if (flag5 && index1 == 1)
          num8 = Utils.Remap(num8, 0.0f, 1f, 50f / (float) num5, 90f / (float) num5);
        float amount = num8;
        if (!flag1)
          amount = 1f - num8;
        float y = MathHelper.Lerp(0.4f, 0.1f, num8);
        float num10 = 0.4f + num4;
        float num11 = 3f;
        float x = (float) (0.5 + Math.Cos((double) num8 * Math.PI * (double) num11 + (double) num10) * 0.40000000596046448 * (double) MathHelper.Lerp(1f, 0.3f, amount));
        float num12 = Utils.Remap(Math.Abs((float) Math.Sin((double) num8 * Math.PI * (double) num11 + (double) num10)), 0.0f, 0.98f, 0.0f, 1f);
        float num13 = MathHelper.Lerp(0.2f, 0.05f, amount) * num2;
        float num14 = (float) (0.5 - 0.5 * Math.Cos((double) num8 * 6.2831854820251465));
        float num15 = num4;
        float num16;
        float num17;
        float num18;
        if (flag5)
        {
          float num19 = num4 * 0.16f;
          if (index1 == 1)
          {
            double num20 = (double) Utils.Remap(num8, 0.0f, 1f, 50f / (float) num5, 90f / (float) num5);
          }
          y += (float) ((1.0 - (double) num8) * 0.05000000074505806);
          num13 += 0.05f;
          if (index1 == 1)
          {
            float num21 = (float) (0.5 + Math.Cos((double) num19 * 6.2831854820251465 * 0.15000000596046448 + (double) num8 * 60.0) * 0.029999999329447746);
            num16 = (float) (0.5 + Math.Cos((double) (num8 + num19) * Math.PI * 2.0) * 1.3999999761581421 * (double) MathHelper.Lerp(1f, 0.3f, num8)) + (float) Math.Sin((double) num19 * 6.2831854820251465) * MathHelper.Lerp(0.4f, 0.13f, num8);
            num17 = num21 - (float) Math.Cos((double) num19 * 6.2831854820251465 * 3.0 + (double) num8 * 5.0) * 0.06f;
            num18 = num13 + 0.15f;
            x = num9 * 1.1f;
            num12 = (float) (1.0 - Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866) * 0.34999999403953552 - 0.34999999403953552);
            y = (float) (Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866) * 0.012500000186264515 + 0.550000011920929);
            num13 = (float) (0.15999999642372131 * (double) num2 + 0.05000000074505806 + Math.Sin((double) num9 * 6.2831854820251465 * 2.0) * 0.02500000037252903) + 0.2f;
          }
          if (index1 == 0)
          {
            float num22 = Utils.Remap(num8, 0.0f, 0.3f, 0.0f, 1f);
            num14 *= num22 * num22 * num22;
            num13 = num13 - 0.1f + 0.8f * num8 * num8;
          }
        }
        if (flag1 && index1 == 0)
        {
          float num23 = num4 * 0.16f;
          float num24 = (float) (0.5 + Math.Cos((double) num23 * 6.2831854820251465 * 0.15000000596046448 + (double) num8 * 60.0) * 0.029999999329447746);
          num16 = (float) (0.5 + Math.Cos((double) (num8 + num23) * Math.PI * 2.0) * 1.3999999761581421 * (double) MathHelper.Lerp(1f, 0.3f, num8)) + (float) Math.Sin((double) num23 * 6.2831854820251465) * MathHelper.Lerp(0.4f, 0.13f, num8);
          num18 = num13 + (float) (Math.Sin((double) num23 * 6.2831854820251465) + 1.0) * MathHelper.Lerp(0.24f, 0.15f, num8) * num2;
          num17 = num24 - (float) Math.Cos((double) num23 * 6.2831854820251465 * 3.0 + (double) num8 * 5.0) * 0.06f;
          x = num9 * 1.1f;
          y = (float) (Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866 + (double) num4 * 2.0 + 3.1415927410125732) * 0.02500000037252903 + 0.550000011920929);
          num13 = (float) (0.15999999642372131 * (double) num2 + 0.05000000074505806 + Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + (double) num4 * 2.0) * 0.019999999552965164);
          num12 = (float) (1.0 - Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866) * 0.34999999403953552 - 0.34999999403953552);
        }
        if (flag2)
        {
          float num25 = num4 * 0.16f;
          float num26;
          if (index1 == 0)
          {
            float num27 = (float) (0.5 + Math.Cos((double) num25 * 6.2831854820251465 * 0.15000000596046448 + (double) num8 * 60.0) * 0.029999999329447746);
            num16 = (float) (0.5 + Math.Cos((double) (num8 + num25) * Math.PI * 2.0) * 1.3999999761581421 * (double) MathHelper.Lerp(1f, 0.3f, num8)) + (float) Math.Sin((double) num25 * 6.2831854820251465) * MathHelper.Lerp(0.4f, 0.13f, num8);
            num17 = num27 - (float) Math.Cos((double) num25 * 6.2831854820251465 * 3.0 + (double) num8 * 5.0) * 0.06f;
            num18 = num13 + 0.15f;
            x = num9 * 1.1f;
            num12 = (float) (1.0 - Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866) * 0.34999999403953552 - 0.34999999403953552);
            y = (float) (Math.Sin((double) num9 * 6.2831854820251465 * 2.0 + 1.5707963705062866) * 0.02500000037252903 + 0.550000011920929);
            num13 = (float) (0.15999999642372131 * (double) num2 + 0.05000000074505806 + Math.Sin((double) num9 * 6.2831854820251465 * 2.0) * 0.05000000074505806);
          }
          else if (index1 == 1 || index1 == 2)
          {
            float num28 = MathHelper.Lerp(0.3f, 0.3f, num8);
            Math.Sin((double) num4 * 6.2831854820251465);
            double num29 = Math.Cos((double) num4 * 6.2831854820251465);
            if (index1 == 1)
              num13 += 0.5f * num8;
            y = num28 - (float) Math.Cos((double) num8 * 6.2831854820251465 + (double) num4 * 2.0) * 0.07f;
            num26 = Utils.Remap(Math.Abs((float) num29), 0.0f, 0.98f, 0.0f, 1f);
            num12 = 1f;
            x = num8;
            num15 += 0.35f;
            if (!flag3)
              num15 -= 0.35f;
            num14 *= 0.55f;
            if (index1 == 2)
            {
              Math.Sin((double) num4 * 6.2831854820251465);
              Math.Cos((double) num4 * 6.2831854820251465);
              y = y - (float) (Math.Cos((double) num4 * 6.2831854820251465 * 0.34999999403953552 + (double) num8 * 13.729999542236328) * 0.039999999105930328 * (1.0 - (double) num8) + 0.039999999105930328) - 0.03f;
            }
          }
          else
          {
            switch (index1)
            {
              case 1:
                float num30 = MathHelper.Lerp(0.4f, 0.1f, num8);
                Math.Sin((double) num4 * 6.2831854820251465);
                double num31 = Math.Cos((double) num4 * 6.2831854820251465);
                y = num30 - (float) Math.Cos((double) num8 * 6.2831854820251465 + (double) num4 * 2.0) * 0.07f;
                num26 = Utils.Remap(Math.Abs((float) num31), 0.0f, 0.98f, 0.0f, 1f);
                num12 = 1f;
                x = num8;
                num15 += 0.35f;
                num14 *= 0.55f;
                break;
              case 2:
                float num32 = MathHelper.Lerp(0.1f, 0.4f, num8);
                Math.Sin((double) num4 * 6.2831854820251465);
                double num33 = Math.Cos((double) num4 * 6.2831854820251465);
                y = num32 - (float) (Math.Cos((double) num4 * 6.2831854820251465 * 0.34999999403953552) * 0.15000000596046448 * (1.0 - (double) num8));
                num15 += 0.35f;
                num26 = Utils.Remap(Math.Abs((float) num33), 0.0f, 0.98f, 0.0f, 1f);
                num12 = 1f;
                x = num8;
                break;
            }
          }
        }
        if (flag3)
        {
          num15 = num4 + (float) index1 * 0.05f;
          num6 = 0.5f;
          num7 = 0.02f;
        }
        if (flag2 && !flag3)
        {
          Luminosity = 1f;
          num7 = 0.45f;
        }
        if (flag1 && index1 != 0)
        {
          float num34 = Math.Max(num14 * 2f, num8);
          if ((double) num34 > 1.0)
            num34 = 1f;
          x = MathHelper.Lerp(x, celestialBodyPosition.X, num8);
          y = MathHelper.Lerp(y + 0.05f, celestialBodyPosition.Y + 0.025f, num8);
          num14 = num34 * 0.5f;
        }
        Vector2 v1 = vector2 * new Vector2(x, y);
        Vector2 v2 = vector2 * new Vector2(x, y - num13);
        if (!flag1)
        {
          float num35 = Main.GlobalTimeWrappedHourly * 0.1f;
          v1 += ((float) (((double) num35 + 0.30000001192092896) * 6.2831854820251465)).ToRotationVector2() * 2f;
          v2 += ((float) (((double) num35 * 0.800000011920929 + 0.67000001668930054) * 6.2831854820251465)).ToRotationVector2() * 2f;
          v2.Y += (float) (Math.Sin(((double) num35 + (double) num8) * 6.2831854820251465 * 3.0) * 15.0 - 15.0);
          v1.Y += (float) Math.Sin(((double) num35 + (double) num8) * 6.2831854820251465 * 0.5) * 1f;
          v2.Y += (float) Math.Sin(((double) num35 + (double) num8) * 6.2831854820251465 * 0.5) * 1f;
          v1.X += (float) Math.Sin(((double) num35 + (double) num8) * 6.2831854820251465 * 1.0) * 3f;
          v2.X += (float) Math.Sin(((double) num35 + (double) num8) * 6.2831854820251465 * 0.75) * 3f;
        }
        Color rgb1 = Main.hslToRgb((num15 + (float) (Math.Cos((double) num8 * 6.2831854820251465 * (double) num6) * 0.1)) % 1f, Saturation, 0.5f);
        Color rgb2 = Main.hslToRgb((num15 + (float) (Math.Cos((double) num8 * 6.2831854820251465 * (double) num6) * 0.1) + num7) % 1f, Saturation, Luminosity);
        if (index1 == 0 && index2 == 19)
          lastSkyColor = rgb1;
        float num36 = num12 * skyOpacity * num14 * num3;
        if (flag1)
        {
          float fromValue = (vector2 * new Vector2(x, y - num13 * 0.25f)).Distance(vector2 * celestialBodyPosition);
          num36 *= Utils.Remap(fromValue, 29f, 60f, 0.0f, 1f);
          float num37 = 505f;
          float num38 = 1f - num8;
          float num39 = num38 * (num38 * num38);
          if (index1 == 1)
          {
            v1.X -= num37 * num39;
            v2.X -= num37 * num39;
            num36 -= (float) ((double) num8 * (double) num8 * 0.36000001430511475);
          }
          if (index1 == 2)
          {
            v1.X += num37 * num39;
            v2.X += num37 * num39;
            num36 -= (float) ((double) num8 * (double) num8 * 0.36000001430511475);
          }
        }
        vertexStrip.AddVertexPair(v1, v2, num8, rgb1 * num36, rgb2 * num36);
      }
      miscShaderData.Apply(new DrawData?());
      vertexStrip.PrepareIndices(true);
      vertexStrip.DrawTrail();
    }
    Main.LatestSurfaceBackgroundBeginner.Begin(Main.spriteBatch);
  }

  public static void ModifyTileColor(ref Color tileColor, float intensity)
  {
    if (!(SkyManager.Instance["Aurora"] is AuroraSky auroraSky))
      return;
    float opacity = auroraSky._opacity;
    if ((double) opacity <= 0.0 || Main.GetMoonPhase() == MoonPhase.QuarterAtLeft)
      return;
    Color lastSkyColor = auroraSky._lastSkyColor with
    {
      A = byte.MaxValue
    };
    tileColor = Color.Lerp(tileColor, lastSkyColor, opacity * intensity);
  }

  public override void Activate(Vector2 position, params object[] args)
  {
    this._isActive = true;
    this._isLeaving = false;
  }

  public override void Deactivate(params object[] args) => this._isLeaving = true;

  public override void Reset()
  {
    this._opacity = 0.0f;
    this._isActive = false;
  }

  public override bool IsActive() => this._isActive;

  private delegate void ScriptMethodSignature(
    VertexStrip vertexStrip,
    float skyOpacity,
    ref Color lastSkyColor);
}
