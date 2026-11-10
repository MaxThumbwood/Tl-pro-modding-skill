// Decompiled with JetBrains decompiler
// Type: Terraria.Utils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Graphics;
using ReLogic.OS;
using ReLogic.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

#nullable disable
namespace Terraria;

public static class Utils
{
  public static readonly int MaxFloatInt = 16777216 /*0x01000000*/;
  public const long MaxCoins = 9999999999;
  public static Dictionary<DynamicSpriteFont, float[]> charLengths = new Dictionary<DynamicSpriteFont, float[]>();
  private static Regex _substitutionRegex = new Regex("{(\\?(?:!)?)?([a-zA-Z][\\w\\.]*)}", RegexOptions.Compiled);
  private const ulong RANDOM_MULTIPLIER = 25214903917;
  private const ulong RANDOM_ADD = 11;
  private const ulong RANDOM_MASK = 281474976710655 /*0xFFFFFFFFFFFF*/;
  private static readonly List<Point> _floodFillQueue1 = new List<Point>(2500);
  private static readonly List<Point> _floodFillQueue2 = new List<Point>(2500);
  private static readonly BitSet2D _floodFillBitset = new BitSet2D();

  public static Color ColorLerp_BlackToWhite(float percent)
  {
    return Color.Lerp(Color.Black, Color.White, percent);
  }

  public static double Lerp(double value1, double value2, double amount)
  {
    return value1 + (value2 - value1) * amount;
  }

  public static Vector2 Round(Vector2 input)
  {
    return new Vector2((float) Math.Round((double) input.X), (float) Math.Round((double) input.Y));
  }

  public static bool IsPowerOfTwo(int x) => x != 0 && (x & x - 1) == 0;

  public static float SmoothStep(float min, float max, float x)
  {
    return MathHelper.Clamp((float) (((double) x - (double) min) / ((double) max - (double) min)), 0.0f, 1f);
  }

  public static double SmoothStep(double min, double max, double x)
  {
    return Utils.Clamp<double>((x - min) / (max - min), 0.0, 1.0);
  }

  public static float UnclampedSmoothStep(float min, float max, float x)
  {
    return (float) (((double) x - (double) min) / ((double) max - (double) min));
  }

  public static double UnclampedSmoothStep(double min, double max, double x)
  {
    return (x - min) / (max - min);
  }

  public static Dictionary<string, string> ParseArguements(string[] args)
  {
    string str1 = (string) null;
    string str2 = "";
    Dictionary<string, string> arguements = new Dictionary<string, string>();
    string str3;
    for (int index = 0; index < args.Length; ++index)
    {
      if (args[index].Length != 0)
      {
        if (args[index][0] == '-' || args[index][0] == '+')
        {
          if (str1 != null)
          {
            arguements.Add(str1.ToLower(), str2);
            str3 = "";
          }
          str1 = args[index];
          str2 = "";
        }
        else
        {
          if (str2 != "")
            str2 += " ";
          str2 += args[index];
        }
      }
    }
    if (str1 != null)
    {
      arguements.Add(str1.ToLower(), str2);
      str3 = "";
    }
    return arguements;
  }

  public static void Swap<T>(ref T t1, ref T t2)
  {
    T obj = t1;
    t1 = t2;
    t2 = obj;
  }

  public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
  {
    if (value.CompareTo(max) > 0)
      return max;
    return value.CompareTo(min) < 0 ? min : value;
  }

  public static Rectangle Clamp(Rectangle r, Rectangle bounds)
  {
    return new Rectangle(Utils.Clamp<int>(r.X, bounds.Left, bounds.Right - r.Width), Utils.Clamp<int>(r.Y, bounds.Top, bounds.Bottom - r.Height), r.Width, r.Height);
  }

  public static float Turn01ToCyclic010(float value)
  {
    return (float) (1.0 - (Math.Cos((double) value * 6.2831854820251465) * 0.5 + 0.5));
  }

  public static float PingPongFrom01To010(float value)
  {
    value %= 1f;
    if ((double) value < 0.0)
      ++value;
    return (double) value >= 0.5 ? (float) (2.0 - (double) value * 2.0) : value * 2f;
  }

  public static void Shift<T>(T[] array, int n)
  {
    if (n == 0 || n >= array.Length || n <= -array.Length)
      return;
    if (n > 0)
    {
      if (n >= array.Length)
        return;
      Array.Copy((Array) array, 0, (Array) array, n, array.Length - n);
    }
    else
    {
      if (n <= -array.Length)
        return;
      Array.Copy((Array) array, -n, (Array) array, 0, array.Length + n);
    }
  }

  public static float MultiLerp(float percent, params float[] floats)
  {
    float num1 = (float) (1.0 / ((double) floats.Length - 1.0));
    float num2 = num1;
    int index;
    for (index = 0; (double) percent / (double) num2 > 1.0 && index < floats.Length - 2; ++index)
      num2 += num1;
    return MathHelper.Lerp(floats[index], floats[index + 1], (percent - num1 * (float) index) / num1);
  }

  public static Color MultiLerp(float percent, params Color[] colors)
  {
    float num1 = (float) (1.0 / ((double) colors.Length - 1.0));
    float num2 = num1;
    int index;
    for (index = 0; (double) percent / (double) num2 > 1.0 && index < colors.Length - 2; ++index)
      num2 += num1;
    return Color.Lerp(colors[index], colors[index + 1], (percent - num1 * (float) index) / num1);
  }

  public static float WrappedLerp(float value1, float value2, float percent)
  {
    float amount = percent * 2f;
    if ((double) amount > 1.0)
      amount = 2f - amount;
    return MathHelper.Lerp(value1, value2, amount);
  }

  public static float GetLerpValue(float from, float to, float t, bool clamped = false)
  {
    if (clamped)
    {
      if ((double) from < (double) to)
      {
        if ((double) t < (double) from)
          return 0.0f;
        if ((double) t > (double) to)
          return 1f;
      }
      else
      {
        if ((double) t < (double) to)
          return 1f;
        if ((double) t > (double) from)
          return 0.0f;
      }
    }
    return (float) (((double) t - (double) from) / ((double) to - (double) from));
  }

  public static float Remap(
    float fromValue,
    float fromMin,
    float fromMax,
    float toMin,
    float toMax,
    bool clamped = true)
  {
    return MathHelper.Lerp(toMin, toMax, Utils.GetLerpValue(fromMin, fromMax, fromValue, clamped));
  }

  public static double Remap(
    double fromValue,
    double fromMin,
    double fromMax,
    double toMin,
    double toMax,
    bool clamped = true)
  {
    return Utils.Lerp(toMin, toMax, Utils.GetLerpValue(fromMin, fromMax, fromValue, clamped));
  }

  public static double EaseOutBounce(double x) => Utils.BounceEaseOut(x, 4, 2.0);

  private static double BounceEaseOut(double t, int bounces, double elasticity)
  {
    double num = (double) bounces * Math.PI;
    return 1.0 - Math.Pow(1.0 - t, elasticity) * Math.Abs(Math.Sin(t * num));
  }

  public static double EaseInCirc(double x) => 1.0 - Math.Sqrt(1.0 - x * x);

  public static double EaseOutCirc(double x) => Math.Sqrt(1.0 - Math.Pow(x - 1.0, 2.0));

  public static void GetPortraitMovement(double t, out double offsetX, out double scaleX)
  {
    t %= 1.0;
    double num1 = 1.0 / 6.0;
    int num2 = (int) (t / num1);
    double x = t % num1 / num1;
    offsetX = 0.0;
    scaleX = 1.0;
    switch (num2)
    {
      case 0:
        offsetX = 0.0;
        scaleX = 1.0 - 2.0 * x;
        break;
      case 1:
        offsetX = 0.0 - 0.5 * Utils.EaseOutCirc(x);
        scaleX = -1.0;
        break;
      case 2:
        offsetX = -0.5 - 0.5 * Utils.EaseOutCirc(x);
        scaleX = -1.0;
        break;
      case 3:
        offsetX = -1.0;
        scaleX = 2.0 * x - 1.0;
        break;
      case 4:
        offsetX = 0.5 * Utils.EaseOutCirc(x) - 1.0;
        scaleX = 1.0;
        break;
      case 5:
        offsetX = 0.5 * Utils.EaseOutCirc(x) - 0.5;
        scaleX = 1.0;
        break;
    }
  }

  public static Color ShiftHue(
    Color color,
    float hueShift,
    float luminanceShift,
    float saturationBoost)
  {
    Vector3 hsl = Main.rgbToHsl(color);
    float Hue = (float) (((double) hsl.X + (double) hueShift) % 1.0);
    if ((double) Hue < 0.0)
      ++Hue;
    return Main.hslToRgb(Hue, hsl.Y + saturationBoost, Utils.Clamp<float>(hsl.Z + luminanceShift, 0.0f, 1f), color.A);
  }

  public static Color ShiftBlueToCyanTheme(Color color)
  {
    return Utils.ShiftHue(color, -0.04f, 0.04f, 0.2f);
  }

  public static void ClampWithinWorld(
    ref int minX,
    ref int minY,
    ref int maxX,
    ref int maxY,
    bool lastValuesInclusiveToIteration = false,
    int fluffX = 0,
    int fluffY = 0)
  {
    int num = lastValuesInclusiveToIteration ? 1 : 0;
    minX = Utils.Clamp<int>(minX, fluffX, Main.maxTilesX - num - fluffX);
    maxX = Utils.Clamp<int>(maxX, fluffX, Main.maxTilesX - num - fluffX);
    minY = Utils.Clamp<int>(minY, fluffY, Main.maxTilesY - num - fluffY);
    maxY = Utils.Clamp<int>(maxY, fluffY, Main.maxTilesY - num - fluffY);
  }

  public static void DrawNotificationIcon(
    SpriteBatch spritebatch,
    Rectangle hitbox,
    float rotationMultiplier = 1f,
    bool worldSpace = false)
  {
    Utils.DrawNotificationIcon(spritebatch, hitbox.BottomRight() + new Vector2(-7f, -6f), rotationMultiplier, worldSpace);
  }

  public static void DrawNotificationIcon(
    SpriteBatch spritebatch,
    Vector2 position,
    float rotationMultiplier = 1f,
    bool worldSpace = false)
  {
    Texture2D texture = Main.Assets.Request<Texture2D>("Images/UI/UI_quickicon1", (AssetRequestMode) 1).Value;
    float amount = (float) (Math.Sin(6.2831854820251465 * ((double) Main.GlobalTimeWrappedHourly % 1.0 / 1.0)) * 0.5 + 0.5);
    Color color1 = Color.White;
    float rotation = (float) (Math.Sin((double) Main.GlobalTimeWrappedHourly % 2.0 / 2.0 * 6.2831854820251465) * 6.2831854820251465 * 0.035000000149011612) * rotationMultiplier;
    if (worldSpace)
    {
      color1 = Lighting.GetColor(position.ToTileCoordinates());
      position -= Main.screenPosition;
      if ((double) Main.LocalPlayer.gravDir == -1.0)
      {
        rotation += 3.14159274f;
        position = Main.ReverseGravitySupport(position);
      }
    }
    Color color2 = color1;
    color2.A /= (byte) 2;
    Color color3 = Color.Lerp(color1, color2, amount);
    spritebatch.Draw(texture, position, new Rectangle?(), color3, rotation, new Vector2((float) (texture.Width / 2), (float) (texture.Height - 4)), 1f, SpriteEffects.None, 0.0f);
  }

  public static Vector2 ConstrainedToPointInRectangle(Rectangle bounds, Vector2 centerTestPosition)
  {
    if (bounds.Contains(centerTestPosition.ToPoint()))
      return centerTestPosition;
    Vector2 vector2_1 = new Vector2((float) bounds.Center.X, (float) bounds.Center.Y);
    Vector2 vector2_2 = vector2_1 - centerTestPosition;
    float num = Math.Min((double) vector2_2.X == 0.0 ? float.MaxValue : Math.Abs((vector2_1.X - (float) (bounds.Width / 2) - centerTestPosition.X) / vector2_2.X), (double) vector2_2.Y == 0.0 ? float.MaxValue : Math.Abs((vector2_1.Y - (float) (bounds.Height / 2) - centerTestPosition.Y) / vector2_2.Y));
    Vector2 pointInRectangle = centerTestPosition + vector2_2 * num;
    pointInRectangle.X = MathHelper.Clamp(pointInRectangle.X, (float) bounds.Left, (float) bounds.Right);
    pointInRectangle.Y = MathHelper.Clamp(pointInRectangle.Y, (float) bounds.Top, (float) bounds.Bottom);
    return pointInRectangle;
  }

  private static bool CheckForGoodTeleportationSpot_CheckNoInvalidTiles(
    int tpx,
    int tpy,
    Utils.RandomTeleportationAttemptSettings settings)
  {
    if (settings.tilesToAvoidRange > 0 && settings.tilesToAvoid != null)
    {
      int tilesToAvoidRange = settings.tilesToAvoidRange;
      for (int index1 = -tilesToAvoidRange; index1 <= tilesToAvoidRange; ++index1)
      {
        for (int index2 = -tilesToAvoidRange; index2 <= tilesToAvoidRange; ++index2)
        {
          int x = tpx + index1;
          int y = tpy + index2;
          if (WorldGen.InWorld(x, y, 2))
          {
            Tile tile = Main.tile[x, y];
            if (tile != null && tile.active())
            {
              ushort type = tile.type;
              for (int index3 = 0; index3 < settings.tilesToAvoid.Length; ++index3)
              {
                if ((int) type == settings.tilesToAvoid[index3])
                  return false;
              }
            }
          }
        }
      }
    }
    return true;
  }

  public static Vector2 CheckForGoodTeleportationSpot(
    ref bool canSpawn,
    int teleportStartX,
    int teleportRangeX,
    int teleportStartY,
    int teleportRangeY,
    Utils.RandomTeleportationAttemptSettings settings)
  {
    int x1 = (int) settings.teleporteeSize.X;
    int y1 = (int) settings.teleporteeSize.Y;
    Vector2 teleporteeVelocity = settings.teleporteeVelocity;
    float gravityDirection = settings.teleporteeGravityDirection;
    Rectangle rectangle = new Rectangle(teleportStartX, teleportStartY, teleportRangeX, teleportRangeY);
    int num1 = 0;
    int x2 = 0;
    int y2 = 0;
    int Width = x1;
    Vector2 Position = new Vector2((float) x2, (float) y2) * 16f + new Vector2((float) (-Width / 2 + 8), (float) -y1);
    while (!canSpawn && num1 < settings.attemptsBeforeGivingUp)
    {
      ++num1;
      int num2 = teleportStartX + Main.rand.Next(teleportRangeX);
      int num3 = teleportStartY + Main.rand.Next(teleportRangeY);
      int min = 5;
      int index1 = (int) MathHelper.Clamp((float) num2, (float) min, (float) (Main.maxTilesX - min));
      int index2 = (int) MathHelper.Clamp((float) num3, (float) min, (float) (Main.maxTilesY - min));
      if (!settings.strictRange || rectangle.Contains(new Point(index1, index2)))
      {
        Position = new Vector2((float) index1, (float) index2) * 16f + new Vector2((float) (-Width / 2 + 8), (float) -y1);
        if (!Collision.SolidCollision(Position, Width, y1))
        {
          if (Main.tile[index1, index2] == null)
            Main.tile[index1, index2] = new Tile();
          Tile tile1 = Main.tile[index1, index2];
          if ((!settings.avoidWalls || tile1.wall <= (ushort) 0) && (tile1.wall != (ushort) 87 || (double) index2 <= Main.worldSurface || NPC.downedPlantBoss) && (!Main.wallDungeon[(int) tile1.wall] || (double) index2 <= Main.worldSurface || NPC.downedBoss3) && Utils.CheckForGoodTeleportationSpot_CheckNoInvalidTiles(index1, index2, settings))
          {
            bool flag1 = false;
            int num4 = 0;
            while (num4 < settings.maximumFallDistanceFromOrignalPoint)
            {
              if (settings.strictRange && !rectangle.Contains(new Point(index1, index2 + num4)))
              {
                flag1 = true;
                break;
              }
              if (Main.tile[index1, index2 + num4] == null)
                Main.tile[index1, index2 + num4] = new Tile();
              Tile tile2 = Main.tile[index1, index2 + num4];
              Position = new Vector2((float) index1, (float) (index2 + num4)) * 16f + new Vector2((float) (-Width / 2 + 8), (float) -y1);
              Collision.SlopeCollision(Position, teleporteeVelocity, Width, y1, gravityDirection);
              if (!Collision.SolidCollision(Position, Width, y1 + 1, settings.allowSolidTopFloor))
                ++num4;
              else if (!tile2.active() || tile2.inActive() || !Main.tileSolid[(int) tile2.type])
                ++num4;
              else
                break;
            }
            if (!flag1)
            {
              int num5 = (int) Position.X / 16 /*0x10*/;
              int num6 = (int) Position.Y / 16 /*0x10*/;
              if (Utils.CheckForGoodTeleportationSpot_CheckNoInvalidTiles(num5, num6, settings))
              {
                int i = (int) ((double) Position.X + (double) Width * 0.5) / 16 /*0x10*/;
                int j = (int) ((double) Position.Y + (double) y1) / 16 /*0x10*/;
                Tile tileSafely1 = Framing.GetTileSafely(num5, num6);
                Tile tileSafely2 = Framing.GetTileSafely(i, j);
                if ((settings.specializedConditions == null || settings.specializedConditions(tileSafely2, i, j)) && (!settings.avoidAnyLiquid || tileSafely2.liquid <= (byte) 0))
                {
                  if (settings.mostlySolidFloor)
                  {
                    Tile tileSafely3 = Framing.GetTileSafely(i - 1, j);
                    Tile tileSafely4 = Framing.GetTileSafely(i + 1, j);
                    bool flag2;
                    bool flag3;
                    if (settings.allowSolidTopFloor)
                    {
                      flag2 = !tileSafely3.inActive() && WorldGen.SolidTileAllowBottomSlope(i - 1, j);
                      flag3 = !tileSafely4.inActive() && WorldGen.SolidTileAllowBottomSlope(i + 1, j);
                    }
                    else
                    {
                      flag2 = tileSafely3.active() && !tileSafely3.inActive() && Main.tileSolid[(int) tileSafely3.type] && !Main.tileSolidTop[(int) tileSafely3.type];
                      flag3 = tileSafely4.active() && !tileSafely4.inActive() && Main.tileSolid[(int) tileSafely4.type] && !Main.tileSolidTop[(int) tileSafely4.type];
                    }
                    if (!flag2 && !flag3)
                      continue;
                  }
                  if ((!settings.avoidWalls || tileSafely1.wall <= (ushort) 0) && (!settings.avoidAnyLiquid || !Collision.WetCollision(Position, Width, y1)) && (!settings.avoidLava || !Collision.LavaCollision(Position, Width, y1)) && (!settings.avoidHurtTiles || !Collision.AnyHurtingTiles(Position, Width, y1)) && !Collision.SolidCollision(Position, Width, y1, settings.allowSolidTopFloor) && num4 < settings.maximumFallDistanceFromOrignalPoint - 1)
                  {
                    Vector2 Velocity1 = Vector2.UnitX * 16f;
                    if (!(Collision.TileCollision(Position - Velocity1, Velocity1, x1, y1, gravDir: (int) gravityDirection) != Velocity1))
                    {
                      Vector2 Velocity2 = -Vector2.UnitX * 16f;
                      if (!(Collision.TileCollision(Position - Velocity2, Velocity2, x1, y1, gravDir: (int) gravityDirection) != Velocity2))
                      {
                        Vector2 Velocity3 = Vector2.UnitY * 16f;
                        if (!(Collision.TileCollision(Position - Velocity3, Velocity3, x1, y1, gravDir: (int) gravityDirection) != Velocity3))
                        {
                          Vector2 Velocity4 = -Vector2.UnitY * 16f;
                          if (!(Collision.TileCollision(Position - Velocity4, Velocity4, x1, y1, gravDir: (int) gravityDirection) != Velocity4) && (!Main.dualDungeonsSeed || !UnbreakableWallScan.InsideUnbreakableWalls(new Point(num5, num6))))
                          {
                            canSpawn = true;
                            int num7 = index2 + num4;
                            break;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
    return Position;
  }

  public static Utils.ChaseResults GetChaseResults(
    Vector2 chaserPosition,
    float chaserSpeed,
    Vector2 runnerPosition,
    Vector2 runnerVelocity)
  {
    Utils.ChaseResults chaseResults = new Utils.ChaseResults();
    if (chaserPosition == runnerPosition)
      return new Utils.ChaseResults()
      {
        InterceptionHappens = true,
        InterceptionPosition = chaserPosition,
        InterceptionTime = 0.0f,
        ChaserVelocity = Vector2.Zero
      };
    if ((double) chaserSpeed <= 0.0)
      return new Utils.ChaseResults();
    Vector2 vector2 = chaserPosition - runnerPosition;
    float num1 = vector2.Length();
    float num2 = runnerVelocity.Length();
    if ((double) num2 == 0.0)
    {
      chaseResults.InterceptionTime = num1 / chaserSpeed;
      chaseResults.InterceptionPosition = runnerPosition;
    }
    else
    {
      double a = (double) chaserSpeed * (double) chaserSpeed - (double) num2 * (double) num2;
      float num3 = 2f * Vector2.Dot(vector2, runnerVelocity);
      float num4 = -num1 * num1;
      double b = (double) num3;
      double c = (double) num4;
      float val1;
      ref float local1 = ref val1;
      float val2;
      ref float local2 = ref val2;
      if (!Utils.SolveQuadratic((float) a, (float) b, (float) c, out local1, out local2))
        return new Utils.ChaseResults();
      if ((double) val1 < 0.0 && (double) val2 < 0.0)
        return new Utils.ChaseResults();
      chaseResults.InterceptionTime = (double) val1 <= 0.0 || (double) val2 <= 0.0 ? Math.Max(val1, val2) : Math.Min(val1, val2);
      chaseResults.InterceptionPosition = runnerPosition + runnerVelocity * chaseResults.InterceptionTime;
    }
    chaseResults.ChaserVelocity = (chaseResults.InterceptionPosition - chaserPosition) / chaseResults.InterceptionTime;
    chaseResults.InterceptionHappens = true;
    return chaseResults;
  }

  public static float GetJumpForce(float jumpHeight, float atGravity)
  {
    float num = atGravity;
    return (float) Math.Sqrt((double) jumpHeight / (double) num * 2.0) * num;
  }

  public static float GetJumpTimeToApex(float jumpHeight, float atGravity)
  {
    float num = atGravity;
    return (float) Math.Sqrt((double) jumpHeight / (double) num * 2.0);
  }

  public static Vector2 FactorAcceleration(
    Vector2 currentVelocity,
    float timeToInterception,
    Vector2 descendOfProjectile,
    int framesOfLenience)
  {
    Vector2 vector2_1 = currentVelocity;
    float num = Math.Max(0.0f, timeToInterception - (float) framesOfLenience);
    Vector2 vector2_2 = descendOfProjectile * (num * num) / 2f / timeToInterception;
    return vector2_1 - vector2_2;
  }

  public static bool SolveQuadratic(
    float a,
    float b,
    float c,
    out float result1,
    out float result2)
  {
    float d = (float) ((double) b * (double) b - 4.0 * (double) a * (double) c);
    result1 = 0.0f;
    result2 = 0.0f;
    if ((double) d > 0.0)
    {
      result1 = (float) ((-(double) b + Math.Sqrt((double) d)) / (2.0 * (double) a));
      result2 = (float) ((-(double) b - Math.Sqrt((double) d)) / (2.0 * (double) a));
      return true;
    }
    if ((double) d < 0.0)
      return false;
    result1 = result2 = (float) ((-(double) b + Math.Sqrt((double) d)) / (2.0 * (double) a));
    return true;
  }

  public static double GetLerpValue(double from, double to, double t, bool clamped = false)
  {
    if (clamped)
    {
      if (from < to)
      {
        if (t < from)
          return 0.0;
        if (t > to)
          return 1.0;
      }
      else
      {
        if (t < to)
          return 1.0;
        if (t > from)
          return 0.0;
      }
    }
    return (t - from) / (to - from);
  }

  public static float GetDayTimeAs24FloatStartingFromMidnight()
  {
    return Main.dayTime ? (float) (4.5 + Main.time / 54000.0 * 15.0) : (float) (19.5 + Main.time / 32400.0 * 9.0);
  }

  public static Vector2 GetDayTimeAsDirectionIn24HClock()
  {
    return Utils.GetDayTimeAsDirectionIn24HClock(Utils.GetDayTimeAs24FloatStartingFromMidnight());
  }

  public static Vector2 GetDayTimeAsDirectionIn24HClock(float timeFrom0To24)
  {
    return new Vector2(0.0f, -1f).RotatedBy((double) timeFrom0To24 / 24.0 * 6.2831854820251465);
  }

  public static string[] ConvertMonoArgsToDotNet(string[] brokenArgs)
  {
    ArrayList arrayList = new ArrayList();
    string str = "";
    for (int index = 0; index < brokenArgs.Length; ++index)
    {
      if (brokenArgs[index].StartsWith("-"))
      {
        if (str != "")
        {
          arrayList.Add((object) str);
          str = "";
        }
        else
          arrayList.Add((object) "");
        arrayList.Add((object) brokenArgs[index]);
      }
      else
      {
        if (str != "")
          str += " ";
        str += brokenArgs[index];
      }
    }
    arrayList.Add((object) str);
    string[] dotNet = new string[arrayList.Count];
    arrayList.CopyTo((Array) dotNet);
    return dotNet;
  }

  public static T Max<T>(params T[] args) where T : IComparable
  {
    T obj = args[0];
    for (int index = 1; index < args.Length; ++index)
    {
      if (obj.CompareTo((object) args[index]) < 0)
        obj = args[index];
    }
    return obj;
  }

  public static float LineRectangleDistance(Rectangle rect, Vector2 lineStart, Vector2 lineEnd)
  {
    Vector2 vector2_1 = rect.TopLeft();
    Vector2 vector2_2 = rect.TopRight();
    Vector2 vector2_3 = rect.BottomLeft();
    Vector2 vector2_4 = rect.BottomRight();
    return lineStart.Between(vector2_1, vector2_4) || lineEnd.Between(vector2_1, vector2_4) ? 0.0f : MathHelper.Min(vector2_1.Distance(vector2_1.ClosestPointOnLine(lineStart, lineEnd)), MathHelper.Min(vector2_2.Distance(vector2_2.ClosestPointOnLine(lineStart, lineEnd)), MathHelper.Min(vector2_3.Distance(vector2_3.ClosestPointOnLine(lineStart, lineEnd)), vector2_4.Distance(vector2_4.ClosestPointOnLine(lineStart, lineEnd)))));
  }

  public static List<List<TextSnippet>> WordwrapStringSmart(
    string text,
    Color c,
    DynamicSpriteFont font,
    float maxWidth = -1f,
    int maxLines = -1)
  {
    List<List<TextSnippet>> textSnippetListList = new List<List<TextSnippet>>();
    List<TextSnippet> textSnippetList = new List<TextSnippet>();
    textSnippetListList.Add(textSnippetList);
    foreach (PositionedSnippet layoutSnippet in ChatManager.LayoutSnippets(font, (IEnumerable<TextSnippet>) ChatManager.ParseMessage(text, c), Vector2.One, maxWidth))
    {
      while (layoutSnippet.Line >= textSnippetListList.Count)
      {
        if (textSnippetListList.Count == maxLines)
          return textSnippetListList;
        textSnippetListList.Add(textSnippetList = new List<TextSnippet>());
      }
      textSnippetList.Add(layoutSnippet.Snippet);
    }
    return textSnippetListList;
  }

  public static string[] WordwrapString(
    string text,
    DynamicSpriteFont font,
    int maxWidth,
    int maxLines,
    out int lineAmount)
  {
    string[] sourceArray = font.CreateWrappedText(text, (float) maxWidth, Language.ActiveCulture.CultureInfo).Split('\n');
    lineAmount = Math.Min(sourceArray.Length, maxLines);
    string[] destinationArray = new string[maxLines];
    Array.Copy((Array) sourceArray, (Array) destinationArray, lineAmount);
    return destinationArray;
  }

  public static string[] WordwrapStringLegacy(
    string text,
    DynamicSpriteFont font,
    int maxWidth,
    int maxLines,
    out int lineAmount)
  {
    string[] strArray = new string[maxLines];
    int index1 = 0;
    List<string> stringList1 = new List<string>((IEnumerable<string>) text.Split('\n'));
    List<string> stringList2 = new List<string>((IEnumerable<string>) stringList1[0].Split(' '));
    for (int index2 = 1; index2 < stringList1.Count && index2 < maxLines; ++index2)
    {
      stringList2.Add("\n");
      stringList2.AddRange((IEnumerable<string>) stringList1[index2].Split(' '));
    }
    bool flag = true;
    while (stringList2.Count > 0)
    {
      string str1 = stringList2[0];
      string str2 = " ";
      if (stringList2.Count == 1)
        str2 = "";
      if (str1 == "\n")
      {
        // ISSUE: explicit reference operation
        ^ref strArray[index1++] += str1;
        flag = true;
        if (index1 < maxLines)
          stringList2.RemoveAt(0);
        else
          break;
      }
      else if (flag)
      {
        if ((double) font.MeasureString(str1).X > (double) maxWidth)
        {
          char ch = str1[0];
          string str3 = ch.ToString() ?? "";
          int num = 1;
          while (true)
          {
            DynamicSpriteFont dynamicSpriteFont = font;
            string str4 = str3;
            ch = str1[num];
            string str5 = ch.ToString();
            string str6 = $"{str4}{str5}-";
            if ((double) dynamicSpriteFont.MeasureString(str6).X <= (double) maxWidth)
            {
              string str7 = str3;
              ch = str1[num++];
              string str8 = ch.ToString();
              str3 = str7 + str8;
            }
            else
              break;
          }
          string str9 = str3 + "-";
          strArray[index1++] = str9 + " ";
          if (index1 < maxLines)
          {
            stringList2.RemoveAt(0);
            stringList2.Insert(0, str1.Substring(num));
          }
          else
            break;
        }
        else
        {
          ref string local = ref strArray[index1];
          local = local + str1 + str2;
          flag = false;
          stringList2.RemoveAt(0);
        }
      }
      else if ((double) font.MeasureString(strArray[index1] + str1).X > (double) maxWidth)
      {
        ++index1;
        if (index1 < maxLines)
          flag = true;
        else
          break;
      }
      else
      {
        ref string local = ref strArray[index1];
        local = local + str1 + str2;
        flag = false;
        stringList2.RemoveAt(0);
      }
    }
    lineAmount = Math.Min(index1 + 1, maxLines);
    return strArray;
  }

  public static Rectangle CenteredRectangle(Vector2 center, Vector2 size)
  {
    return new Rectangle((int) ((double) center.X - (double) size.X / 2.0), (int) ((double) center.Y - (double) size.Y / 2.0), (int) size.X, (int) size.Y);
  }

  public static Rectangle CenteredRectangle(Point center, Point size)
  {
    return new Rectangle(center.X - size.X / 2, center.Y - size.Y / 2, size.X, size.Y);
  }

  public static Rectangle Including(this Rectangle rect, Point point)
  {
    int x = Math.Min(rect.Left, point.X);
    int num1 = Math.Max(rect.Right, point.X);
    int y = Math.Min(rect.Top, point.Y);
    int num2 = Math.Max(rect.Bottom, point.Y);
    return new Rectangle(x, y, num1 - x, num2 - y);
  }

  public static Vector2 Vector2FromElipse(Vector2 angleVector, Vector2 elipseSizes)
  {
    if (elipseSizes == Vector2.Zero || angleVector == Vector2.Zero)
      return Vector2.Zero;
    angleVector.Normalize();
    Vector2 vector2 = Vector2.One / Vector2.Normalize(elipseSizes);
    angleVector *= vector2;
    angleVector.Normalize();
    return angleVector * elipseSizes / 2f;
  }

  public static bool FloatIntersect(
    float r1StartX,
    float r1StartY,
    float r1Width,
    float r1Height,
    float r2StartX,
    float r2StartY,
    float r2Width,
    float r2Height)
  {
    return (double) r1StartX <= (double) r2StartX + (double) r2Width && (double) r1StartY <= (double) r2StartY + (double) r2Height && (double) r1StartX + (double) r1Width >= (double) r2StartX && (double) r1StartY + (double) r1Height >= (double) r2StartY;
  }

  public static bool DoubleIntersect(
    double r1StartX,
    double r1StartY,
    double r1Width,
    double r1Height,
    double r2StartX,
    double r2StartY,
    double r2Width,
    double r2Height)
  {
    return r1StartX <= r2StartX + r2Width && r1StartY <= r2StartY + r2Height && r1StartX + r1Width >= r2StartX && r1StartY + r1Height >= r2StartY;
  }

  public static bool LineSegmentsIntersect(
    Vector2D start1,
    Vector2D end1,
    Vector2D start2,
    Vector2D end2)
  {
    Vector2D vector2D1 = Vector2D.op_Subtraction(end1, start1);
    Vector2D vector2D2 = Vector2D.op_Subtraction(end2, start2);
    double num1 = Vector2D.Cross(vector2D1, vector2D2);
    if (num1 == 0.0)
      return false;
    Vector2D vector2D3 = Vector2D.op_Subtraction(start2, start1);
    double num2 = Vector2D.Cross(vector2D3, vector2D1) / num1;
    double num3 = Vector2D.Cross(vector2D3, vector2D1) / num1;
    double num4 = Vector2D.Cross(vector2D3, vector2D1) / num1;
    return 0.0 <= num3 && num3 <= 1.0 && 0.0 <= num4 && num4 <= 1.0;
  }

  public static long CoinsCount(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
  {
    List<int> intList = new List<int>((IEnumerable<int>) ignoreSlots);
    long num = 0;
    for (int index = 0; index < inv.Length; ++index)
    {
      if (!intList.Contains(index))
      {
        switch (inv[index].type)
        {
          case 71:
            num += (long) inv[index].stack;
            continue;
          case 72:
            num += (long) inv[index].stack * 100L;
            continue;
          case 73:
            num += (long) inv[index].stack * 10000L;
            continue;
          case 74:
            num += (long) inv[index].stack * 1000000L;
            continue;
          default:
            continue;
        }
      }
    }
    overFlowing = false;
    return num;
  }

  public static int[] CoinsSplit(long count)
  {
    int[] numArray = new int[4];
    long num1 = 0;
    long num2 = 1000000;
    for (int index = 3; index >= 0; --index)
    {
      numArray[index] = (int) ((count - num1) / num2);
      num1 += (long) numArray[index] * num2;
      num2 /= 100L;
    }
    return numArray;
  }

  public static long CoinsCombineStacks(out bool overFlowing, params long[] coinCounts)
  {
    long num = 0;
    foreach (long coinCount in coinCounts)
    {
      num += coinCount;
      if (num >= 9999999999L)
      {
        overFlowing = true;
        return 9999999999;
      }
    }
    overFlowing = false;
    return num;
  }

  public static void PoofOfSmoke(Vector2 position)
  {
    int num = Main.rand.Next(3, 7);
    for (int index1 = 0; index1 < num; ++index1)
    {
      int index2 = Gore.NewGore(position, (Main.rand.NextFloat() * 6.28318548f).ToRotationVector2() * new Vector2(2f, 0.7f) * 0.7f, Main.rand.Next(11, 14));
      Main.gore[index2].scale = 0.7f;
      Main.gore[index2].velocity *= 0.5f;
    }
    for (int index = 0; index < 10; ++index)
    {
      Dust dust = Main.dust[Dust.NewDust(position, 14, 14, 16 /*0x10*/, Alpha: 100, Scale: 1.5f)];
      dust.position += new Vector2(5f);
      dust.velocity = (Main.rand.NextFloat() * 6.28318548f).ToRotationVector2() * new Vector2(2f, 0.7f) * 0.7f * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat());
    }
  }

  public static Vector2 ToScreenPosition(this Vector2 worldPosition)
  {
    return Vector2.Transform(worldPosition - Main.screenPosition, Main.GameViewMatrix.TransformationMatrix) / Main.UIScale;
  }

  public static Vector2 ScreenToWorldPosition(this Vector2 screenPosition)
  {
    return Vector2.Transform(screenPosition * Main.UIScale, Matrix.Invert(Main.GameViewMatrix.TransformationMatrix)) + Main.screenPosition;
  }

  public static string PrettifyPercentDisplay(float percent, string originalFormat)
  {
    return percent.ToString(originalFormat, (IFormatProvider) CultureInfo.InvariantCulture).TrimEnd('0', '%', ' ').TrimEnd('.', ' ').TrimStart('0', ' ') + "%";
  }

  public static void TrimTextIfNeeded(
    ref string text,
    DynamicSpriteFont font,
    float scale,
    float maxWidth)
  {
    bool flag = false;
    for (Vector2 vector2 = font.MeasureString(text) * scale; (double) vector2.X > (double) maxWidth; vector2 = font.MeasureString(text) * scale)
    {
      text = Utils.TrimLastCharacter(text);
      flag = true;
    }
    if (!flag)
      return;
    text = Utils.TrimLastCharacter(text) + "…";
  }

  public static string FormatWith(string original, object obj)
  {
    string input = original;
    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
    return Utils._substitutionRegex.Replace(input, (MatchEvaluator) (match =>
    {
      if (match.Groups[1].Length != 0)
        return "";
      PropertyDescriptor propertyDescriptor = properties.Find(match.Groups[2].ToString(), false);
      return propertyDescriptor == null ? "" : (propertyDescriptor.GetValue(obj) ?? (object) "").ToString();
    }));
  }

  public static bool TryCreatingDirectory(string folderPath)
  {
    if (Directory.Exists(folderPath))
      return true;
    try
    {
      Directory.CreateDirectory(folderPath);
      return true;
    }
    catch (Exception ex)
    {
      string folderPath1 = folderPath;
      FancyErrorPrinter.ShowDirectoryCreationFailError(ex, folderPath1);
      return false;
    }
  }

  public static void OpenFolder(string folderPath)
  {
    if (!Utils.TryCreatingDirectory(folderPath))
      return;
    if (Platform.IsLinux)
      Process.Start(new ProcessStartInfo(folderPath)
      {
        FileName = "open-folder",
        Arguments = folderPath,
        UseShellExecute = true,
        CreateNoWindow = true
      });
    else
      Process.Start(folderPath);
  }

  public static TimeSpan SWTicksToTimeSpan(long swTicks)
  {
    return new TimeSpan((long) ((double) swTicks * 10000000.0 / (double) Stopwatch.Frequency));
  }

  public static long TimeSpanToSWTicks(TimeSpan timeSpan)
  {
    return timeSpan.Ticks * Stopwatch.Frequency / 10000000L;
  }

  public static byte[] ToByteArray(this string str)
  {
    byte[] dst = new byte[str.Length * 2];
    Buffer.BlockCopy((Array) str.ToCharArray(), 0, (Array) dst, 0, dst.Length);
    return dst;
  }

  public static float NextFloat(this UnifiedRandom r) => (float) r.NextDouble();

  public static float NextFloatDirection(this UnifiedRandom r)
  {
    return (float) (r.NextDouble() * 2.0 - 1.0);
  }

  public static float NextFloat(this UnifiedRandom random, FloatRange range)
  {
    return random.NextFloat() * (range.Maximum - range.Minimum) + range.Minimum;
  }

  public static T NextFromList<T>(this UnifiedRandom random, params T[] objs)
  {
    return objs[random.Next(objs.Length)];
  }

  public static bool JustBecameTrue(bool state, ref bool releasedStateHolder)
  {
    bool flag = false;
    if (state)
    {
      if (releasedStateHolder)
        flag = true;
      releasedStateHolder = false;
    }
    else
      releasedStateHolder = true;
    return flag;
  }

  public static T NextFromCollection<T>(this UnifiedRandom random, List<T> objs)
  {
    return objs[random.Next(objs.Count)];
  }

  public static int Next(this UnifiedRandom random, IntRange range)
  {
    return random.Next(range.Minimum, range.Maximum + 1);
  }

  public static Point NextFromRectangle(this UnifiedRandom r, Rectangle rect)
  {
    return new Point(r.Next(rect.Left, rect.Right), r.Next(rect.Top, rect.Bottom));
  }

  public static Vector2 NextVector2Square(this UnifiedRandom r, float min, float max)
  {
    return new Vector2((max - min) * (float) r.NextDouble() + min, (max - min) * (float) r.NextDouble() + min);
  }

  public static Vector2 NextVector2FromRectangle(this UnifiedRandom r, Rectangle rect)
  {
    return new Vector2((float) rect.X + r.NextFloat() * (float) rect.Width, (float) rect.Y + r.NextFloat() * (float) rect.Height);
  }

  public static Vector2 NextVector2Unit(
    this UnifiedRandom r,
    float startRotation = 0.0f,
    float rotationRange = 6.28318548f)
  {
    return (startRotation + rotationRange * r.NextFloat()).ToRotationVector2();
  }

  public static Vector2 NextVector2Circular(
    this UnifiedRandom r,
    float circleHalfWidth,
    float circleHalfHeight)
  {
    return r.NextVector2Unit() * new Vector2(circleHalfWidth, circleHalfHeight) * r.NextFloat();
  }

  public static Vector2 NextVector2CircularEdge(
    this UnifiedRandom r,
    float circleHalfWidth,
    float circleHalfHeight)
  {
    return r.NextVector2Unit() * new Vector2(circleHalfWidth, circleHalfHeight);
  }

  public static Vector2D NextVector2DSquare(this UnifiedRandom r, double min, double max)
  {
    return new Vector2D((max - min) * r.NextDouble() + min, (max - min) * r.NextDouble() + min);
  }

  public static Vector2D NextVector2DFromRectangle(this UnifiedRandom r, Rectangle rect)
  {
    return new Vector2D((double) rect.X + r.NextDouble() * (double) rect.Width, (double) rect.Y + r.NextDouble() * (double) rect.Height);
  }

  public static Vector2D NextVector2DUnit(
    this UnifiedRandom r,
    double startRotation = 0.0,
    double rotationRange = 6.2831854820251465)
  {
    return (startRotation + rotationRange * r.NextDouble()).ToRotationVector2D();
  }

  public static Vector2D NextVector2DCircular(
    this UnifiedRandom r,
    double circleHalfWidth,
    double circleHalfHeight)
  {
    return Vector2D.op_Multiply(Vector2D.op_Multiply(r.NextVector2DUnit(), new Vector2D(circleHalfWidth, circleHalfHeight)), r.NextDouble());
  }

  public static Vector2D NextVector2DCircularEdge(
    this UnifiedRandom r,
    double circleHalfWidth,
    double circleHalfHeight)
  {
    return Vector2D.op_Multiply(r.NextVector2DUnit(), new Vector2D(circleHalfWidth, circleHalfHeight));
  }

  public static int Width(this Asset<Texture2D> asset) => !asset.IsLoaded ? 0 : asset.Value.Width;

  public static int Height(this Asset<Texture2D> asset) => !asset.IsLoaded ? 0 : asset.Value.Height;

  public static Rectangle Frame(
    this Asset<Texture2D> tex,
    int horizontalFrames = 1,
    int verticalFrames = 1,
    int frameX = 0,
    int frameY = 0,
    int sizeOffsetX = 0,
    int sizeOffsetY = 0)
  {
    return !tex.IsLoaded ? Rectangle.Empty : tex.Value.Frame(horizontalFrames, verticalFrames, frameX, frameY, sizeOffsetX, sizeOffsetY);
  }

  public static Rectangle OffsetSize(this Rectangle rect, int xSize, int ySize)
  {
    rect.Width += xSize;
    rect.Height += ySize;
    return rect;
  }

  public static Vector2 Size(this Asset<Texture2D> tex)
  {
    return !tex.IsLoaded ? Vector2.Zero : tex.Value.Size();
  }

  public static Rectangle Frame(
    this Texture2D tex,
    int horizontalFrames = 1,
    int verticalFrames = 1,
    int frameX = 0,
    int frameY = 0,
    int sizeOffsetX = 0,
    int sizeOffsetY = 0)
  {
    int num1 = tex.Width / horizontalFrames;
    int num2 = tex.Height / verticalFrames;
    return new Rectangle(num1 * frameX, num2 * frameY, num1 + sizeOffsetX, num2 + sizeOffsetY);
  }

  public static Vector2 OriginFlip(this Rectangle rect, Vector2 origin, SpriteEffects effects)
  {
    if ((effects & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
      origin.X = (float) rect.Width - origin.X;
    if ((effects & SpriteEffects.FlipVertically) != SpriteEffects.None)
      origin.Y = (float) rect.Height - origin.Y;
    return origin;
  }

  public static Vector2 Size(this Texture2D tex)
  {
    return new Vector2((float) tex.Width, (float) tex.Height);
  }

  public static void WriteRGB(this BinaryWriter bb, Color c)
  {
    bb.Write(c.R);
    bb.Write(c.G);
    bb.Write(c.B);
  }

  public static void WriteVector2(this BinaryWriter bb, Vector2 v)
  {
    bb.Write(v.X);
    bb.Write(v.Y);
  }

  public static void WritePackedVector2(this BinaryWriter bb, Vector2 v)
  {
    HalfVector2 halfVector2 = new HalfVector2(v.X, v.Y);
    bb.Write(halfVector2.PackedValue);
  }

  public static Color ReadRGB(this BinaryReader bb)
  {
    return new Color((int) bb.ReadByte(), (int) bb.ReadByte(), (int) bb.ReadByte());
  }

  public static Vector2 ReadVector2(this BinaryReader bb)
  {
    return new Vector2(bb.ReadSingle(), bb.ReadSingle());
  }

  public static Vector2 ReadPackedVector2(this BinaryReader bb)
  {
    return new HalfVector2()
    {
      PackedValue = bb.ReadUInt32()
    }.ToVector2();
  }

  public static void Write7BitEncodedInt(this BinaryWriter writer, int value)
  {
    uint num;
    for (num = (uint) value; num > (uint) sbyte.MaxValue; num >>= 7)
      writer.Write((byte) (num | 4294967168U));
    writer.Write((byte) num);
  }

  public static int Read7BitEncodedInt(this BinaryReader reader)
  {
    uint num1 = 0;
    for (int index = 0; index < 28; index += 7)
    {
      byte num2 = reader.ReadByte();
      num1 |= (uint) (((int) num2 & (int) sbyte.MaxValue) << index);
      if (num2 <= (byte) 127 /*0x7F*/)
        return (int) num1;
    }
    byte num3 = reader.ReadByte();
    if (num3 > (byte) 15)
      throw new FormatException("Bad 7bit encoded int");
    return (int) (num1 | (uint) num3 << 28);
  }

  public static Vector2 Left(this Rectangle r)
  {
    return new Vector2((float) r.X, (float) (r.Y + r.Height / 2));
  }

  public static Vector2 Right(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width), (float) (r.Y + r.Height / 2));
  }

  public static Vector2 Top(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width / 2), (float) r.Y);
  }

  public static Vector2 Bottom(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width / 2), (float) (r.Y + r.Height));
  }

  public static Vector2 TopLeft(this Rectangle r) => new Vector2((float) r.X, (float) r.Y);

  public static Vector2 TopRight(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width), (float) r.Y);
  }

  public static Vector2 BottomLeft(this Rectangle r)
  {
    return new Vector2((float) r.X, (float) (r.Y + r.Height));
  }

  public static Vector2 BottomRight(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width), (float) (r.Y + r.Height));
  }

  public static Vector2D TopLeftDouble(this Rectangle r)
  {
    return new Vector2D((double) r.X, (double) r.Y);
  }

  public static Vector2D TopRightDouble(this Rectangle r)
  {
    return new Vector2D((double) (r.X + r.Width), (double) r.Y);
  }

  public static Vector2D BottomLeftDouble(this Rectangle r)
  {
    return new Vector2D((double) r.X, (double) (r.Y + r.Height));
  }

  public static Vector2D BottomRightDouble(this Rectangle r)
  {
    return new Vector2D((double) (r.X + r.Width), (double) (r.Y + r.Height));
  }

  public static Vector2 Center(this Rectangle r)
  {
    return new Vector2((float) (r.X + r.Width / 2), (float) (r.Y + r.Height / 2));
  }

  public static Vector2 Size(this Rectangle r) => new Vector2((float) r.Width, (float) r.Height);

  public static float Distance(this Rectangle r, Vector2 point)
  {
    if (Utils.FloatIntersect((float) r.Left, (float) r.Top, (float) r.Width, (float) r.Height, point.X, point.Y, 0.0f, 0.0f))
      return 0.0f;
    return (double) point.X >= (double) r.Left && (double) point.X <= (double) r.Right ? ((double) point.Y < (double) r.Top ? (float) r.Top - point.Y : point.Y - (float) r.Bottom) : ((double) point.Y >= (double) r.Top && (double) point.Y <= (double) r.Bottom ? ((double) point.X < (double) r.Left ? (float) r.Left - point.X : point.X - (float) r.Right) : ((double) point.X < (double) r.Left ? ((double) point.Y < (double) r.Top ? Vector2.Distance(point, r.TopLeft()) : Vector2.Distance(point, r.BottomLeft())) : ((double) point.Y < (double) r.Top ? Vector2.Distance(point, r.TopRight()) : Vector2.Distance(point, r.BottomRight()))));
  }

  public static double Distance(this Rectangle r, Vector2D point)
  {
    if (Utils.DoubleIntersect((double) r.Left, (double) r.Top, (double) r.Width, (double) r.Height, point.X, point.Y, 0.0, 0.0))
      return 0.0;
    return point.X >= (double) r.Left && point.X <= (double) r.Right ? (point.Y < (double) r.Top ? (double) r.Top - point.Y : point.Y - (double) r.Bottom) : (point.Y >= (double) r.Top && point.Y <= (double) r.Bottom ? (point.X < (double) r.Left ? (double) r.Left - point.X : point.X - (double) r.Right) : (point.X < (double) r.Left ? (point.Y < (double) r.Top ? Vector2D.Distance(point, r.TopLeftDouble()) : Vector2D.Distance(point, r.BottomLeftDouble())) : (point.Y < (double) r.Top ? Vector2D.Distance(point, r.TopRightDouble()) : Vector2D.Distance(point, r.BottomRightDouble()))));
  }

  public static Vector2 ClosestPointInRect(this Rectangle r, Vector2 point)
  {
    Vector2 vector2 = point;
    if ((double) vector2.X < (double) r.Left)
      vector2.X = (float) r.Left;
    if ((double) vector2.X > (double) r.Right)
      vector2.X = (float) r.Right;
    if ((double) vector2.Y < (double) r.Top)
      vector2.Y = (float) r.Top;
    if ((double) vector2.Y > (double) r.Bottom)
      vector2.Y = (float) r.Bottom;
    return vector2;
  }

  public static Rectangle Modified(this Rectangle r, int x, int y, int w, int h)
  {
    return new Rectangle(r.X + x, r.Y + y, r.Width + w, r.Height + h);
  }

  public static bool IntersectsConeFastInaccurate(
    this Rectangle targetRect,
    Vector2 coneCenter,
    float coneLength,
    float coneRotation,
    float maximumAngle)
  {
    Vector2 point = coneCenter + coneRotation.ToRotationVector2() * coneLength;
    Vector2 spinningpoint = targetRect.ClosestPointInRect(point) - coneCenter;
    float rotation = spinningpoint.RotatedBy(-(double) coneRotation).ToRotation();
    return (double) rotation >= -(double) maximumAngle && (double) rotation <= (double) maximumAngle && (double) spinningpoint.Length() < (double) coneLength;
  }

  public static bool IntersectsConeSlowMoreAccurate(
    this Rectangle targetRect,
    Vector2 coneCenter,
    float coneLength,
    float coneRotation,
    float maximumAngle)
  {
    Vector2 point = coneCenter + coneRotation.ToRotationVector2() * coneLength;
    return Utils.DoesFitInCone(targetRect.ClosestPointInRect(point), coneCenter, coneLength, coneRotation, maximumAngle) || Utils.DoesFitInCone(targetRect.TopLeft(), coneCenter, coneLength, coneRotation, maximumAngle) || Utils.DoesFitInCone(targetRect.TopRight(), coneCenter, coneLength, coneRotation, maximumAngle) || Utils.DoesFitInCone(targetRect.BottomLeft(), coneCenter, coneLength, coneRotation, maximumAngle) || Utils.DoesFitInCone(targetRect.BottomRight(), coneCenter, coneLength, coneRotation, maximumAngle);
  }

  public static bool DoesFitInCone(
    Vector2 point,
    Vector2 coneCenter,
    float coneLength,
    float coneRotation,
    float maximumAngle)
  {
    Vector2 spinningpoint = point - coneCenter;
    float rotation = spinningpoint.RotatedBy(-(double) coneRotation).ToRotation();
    return (double) rotation >= -(double) maximumAngle && (double) rotation <= (double) maximumAngle && (double) spinningpoint.Length() < (double) coneLength;
  }

  public static float ToRotation(this Vector2 v) => (float) Math.Atan2((double) v.Y, (double) v.X);

  public static double ToRotation(this Vector2D v) => Math.Atan2(v.Y, v.X);

  public static Vector2 ToRotationVector2(this float f)
  {
    return new Vector2((float) Math.Cos((double) f), (float) Math.Sin((double) f));
  }

  public static Vector2D ToRotationVector2D(this double f)
  {
    return new Vector2D(Math.Cos(f), Math.Sin(f));
  }

  public static Vector2 RotatedBy(this Vector2 spinningpoint, double radians, Vector2 center = default (Vector2))
  {
    float num1 = (float) Math.Cos(radians);
    float num2 = (float) Math.Sin(radians);
    Vector2 vector2_1 = spinningpoint - center;
    Vector2 vector2_2 = center;
    vector2_2.X += (float) ((double) vector2_1.X * (double) num1 - (double) vector2_1.Y * (double) num2);
    vector2_2.Y += (float) ((double) vector2_1.X * (double) num2 + (double) vector2_1.Y * (double) num1);
    return vector2_2;
  }

  public static Vector2D RotatedBy(this Vector2D spinningpoint, double radians, Vector2D center = default (Vector2D))
  {
    double num1 = Math.Cos(radians);
    double num2 = Math.Sin(radians);
    Vector2D vector2D1 = Vector2D.op_Subtraction(spinningpoint, center);
    Vector2D vector2D2 = center;
    vector2D2.X += vector2D1.X * num1 - vector2D1.Y * num2;
    vector2D2.Y += vector2D1.X * num2 + vector2D1.Y * num1;
    return vector2D2;
  }

  public static Vector2 RotatedByRandom(this Vector2 spinninpoint, double maxRadians)
  {
    return spinninpoint.RotatedBy(Main.rand.NextDouble() * maxRadians - Main.rand.NextDouble() * maxRadians);
  }

  public static Vector2 Floor(this Vector2 vec)
  {
    vec.X = (float) (int) vec.X;
    vec.Y = (float) (int) vec.Y;
    return vec;
  }

  public static bool HasNaNs(this Vector2 vec) => float.IsNaN(vec.X) || float.IsNaN(vec.Y);

  public static bool Between(this Vector2 vec, Vector2 minimum, Vector2 maximum)
  {
    return (double) vec.X >= (double) minimum.X && (double) vec.X <= (double) maximum.X && (double) vec.Y >= (double) minimum.Y && (double) vec.Y <= (double) maximum.Y;
  }

  public static Vector2 ScaledBy(this Vector2 vec, Vector2 other) => Vector2.Multiply(vec, other);

  public static Vector2 ScaledBy(this Vector2 vec, float scaleX, float scaleY)
  {
    return Vector2.Multiply(vec, new Vector2(scaleX, scaleY));
  }

  public static Vector2 ToVector2(this Point p) => new Vector2((float) p.X, (float) p.Y);

  public static Vector2 ToVector2(this Point16 p) => new Vector2((float) p.X, (float) p.Y);

  public static Vector3 ToVector3(this Vector2 v) => new Vector3(v.X, v.Y, 0.0f);

  public static Vector2D ToVector2D(this Point p) => new Vector2D((double) p.X, (double) p.Y);

  public static Vector2D ToVector2D(this Point16 p) => new Vector2D((double) p.X, (double) p.Y);

  public static Vector2 ToWorldCoordinates(this Point p, float autoAddX = 8f, float autoAddY = 8f)
  {
    return p.ToVector2() * 16f + new Vector2(autoAddX, autoAddY);
  }

  public static Vector2 ToWorldCoordinates(this Point16 p, float autoAddX = 8f, float autoAddY = 8f)
  {
    return p.ToVector2() * 16f + new Vector2(autoAddX, autoAddY);
  }

  public static Vector2 MoveTowards(
    this Vector2 currentPosition,
    Vector2 targetPosition,
    float maxAmountAllowedToMove)
  {
    Vector2 v = targetPosition - currentPosition;
    return (double) v.Length() < (double) maxAmountAllowedToMove ? targetPosition : currentPosition + v.SafeNormalize(Vector2.Zero) * maxAmountAllowedToMove;
  }

  public static float MoveTowards(float original, float target, float amount)
  {
    if ((double) original == (double) target)
      return target;
    int num1 = Math.Sign(target - original);
    float num2 = original + amount * (float) num1;
    return Math.Sign(target - num2) != num1 ? target : num2;
  }

  public static Point16 ToTileCoordinates16(this Vector2 vec)
  {
    return new Point16((int) vec.X >> 4, (int) vec.Y >> 4);
  }

  public static Point16 ToTileCoordinates16(this Vector2D vec)
  {
    return new Point16((int) vec.X >> 4, (int) vec.Y >> 4);
  }

  public static Point ToTileCoordinates(this Vector2 vec)
  {
    return new Point((int) vec.X >> 4, (int) vec.Y >> 4);
  }

  public static Point ToTileCoordinates(this Vector2D vec)
  {
    return new Point((int) vec.X >> 4, (int) vec.Y >> 4);
  }

  public static Point ToPoint(this Vector2 v) => new Point((int) v.X, (int) v.Y);

  public static Point ToPoint(this Vector2D v) => new Point((int) v.X, (int) v.Y);

  public static Vector2 ToVector2(this Vector2D v) => new Vector2((float) v.X, (float) v.Y);

  public static Vector2D ToVector2D(this Vector2 v) => new Vector2D((double) v.X, (double) v.Y);

  public static Vector2 SafeNormalize(this Vector2 v, Vector2 defaultValue)
  {
    return v == Vector2.Zero || v.HasNaNs() ? defaultValue : Vector2.Normalize(v);
  }

  public static Vector2D SafeNormalize(this Vector2D v, Vector2D defaultValue)
  {
    return Vector2D.op_Equality(v, Vector2D.Zero) ? defaultValue : Vector2D.Normalize(v);
  }

  public static Point ClampedInWorld(this Point p, int fluff = 0)
  {
    return new Point(Utils.Clamp<int>(p.X, fluff, Main.maxTilesX - fluff - 1), Utils.Clamp<int>(p.Y, fluff, Main.maxTilesX - fluff - 1));
  }

  public static Vector2 ClosestPointOnLine(this Vector2 P, Vector2 A, Vector2 B)
  {
    Vector2 vector2_1 = P - A;
    Vector2 vector2_2 = B - A;
    float num1 = vector2_2.LengthSquared();
    Vector2 vector2_3 = vector2_2;
    float num2 = Vector2.Dot(vector2_1, vector2_3) / num1;
    if ((double) num2 < 0.0)
      return A;
    return (double) num2 > 1.0 ? B : A + vector2_2 * num2;
  }

  public static Vector2D ClosestPointOnLine(this Vector2D P, Vector2D A, Vector2D B)
  {
    Vector2D vector2D1 = Vector2D.op_Subtraction(P, A);
    Vector2D vector2D2 = Vector2D.op_Subtraction(B, A);
    double num1 = ((Vector2D) ref vector2D2).LengthSquared();
    Vector2D vector2D3 = vector2D2;
    double num2 = Vector2D.Dot(vector2D1, vector2D3) / num1;
    if (num2 < 0.0)
      return A;
    return num2 > 1.0 ? B : Vector2D.op_Addition(A, Vector2D.op_Multiply(vector2D2, num2));
  }

  public static bool RectangleLineCollision(
    Vector2 rectTopLeft,
    Vector2 rectBottomRight,
    Vector2 lineStart,
    Vector2 lineEnd)
  {
    if (lineStart.Between(rectTopLeft, rectBottomRight) || lineEnd.Between(rectTopLeft, rectBottomRight))
      return true;
    Vector2 P = new Vector2(rectBottomRight.X, rectTopLeft.Y);
    Vector2 vector2 = new Vector2(rectTopLeft.X, rectBottomRight.Y);
    Vector2[] vector2Array = new Vector2[4]
    {
      rectTopLeft.ClosestPointOnLine(lineStart, lineEnd),
      P.ClosestPointOnLine(lineStart, lineEnd),
      vector2.ClosestPointOnLine(lineStart, lineEnd),
      rectBottomRight.ClosestPointOnLine(lineStart, lineEnd)
    };
    for (int index = 0; index < vector2Array.Length; ++index)
    {
      if (vector2Array[0].Between(rectTopLeft, vector2))
        return true;
    }
    return false;
  }

  public static Vector2 RotateRandom(this Vector2 spinninpoint, double maxRadians)
  {
    return spinninpoint.RotatedBy(Main.rand.NextDouble() * maxRadians - Main.rand.NextDouble() * maxRadians);
  }

  public static float AngleTo(this Vector2 Origin, Vector2 Target)
  {
    return (float) Math.Atan2((double) Target.Y - (double) Origin.Y, (double) Target.X - (double) Origin.X);
  }

  public static float AngleFrom(this Vector2 Origin, Vector2 Target)
  {
    return (float) Math.Atan2((double) Origin.Y - (double) Target.Y, (double) Origin.X - (double) Target.X);
  }

  public static Vector2 rotateTowards(
    Vector2 currentPosition,
    Vector2 currentVelocity,
    Vector2 targetPosition,
    float maxChange)
  {
    float num = currentVelocity.Length();
    float targetAngle = currentPosition.AngleTo(targetPosition);
    return currentVelocity.ToRotation().AngleTowards(targetAngle, maxChange).ToRotationVector2() * num;
  }

  public static float Distance(this Vector2 Origin, Vector2 Target)
  {
    return Vector2.Distance(Origin, Target);
  }

  public static double Distance(this Vector2D Origin, Vector2D Target)
  {
    return Vector2D.Distance(Origin, Target);
  }

  public static float DistanceSQ(this Vector2 Origin, Vector2 Target)
  {
    return Vector2.DistanceSquared(Origin, Target);
  }

  public static Vector2 DirectionTo(this Vector2 Origin, Vector2 Target)
  {
    return Vector2.Normalize(Target - Origin);
  }

  public static Vector2 DirectionFrom(this Vector2 Origin, Vector2 Target)
  {
    return Vector2.Normalize(Origin - Target);
  }

  public static bool WithinRange(this Vector2 Origin, Vector2 Target, float MaxRange)
  {
    return (double) Vector2.DistanceSquared(Origin, Target) <= (double) MaxRange * (double) MaxRange;
  }

  public static Vector2 XY(this Vector4 vec) => new Vector2(vec.X, vec.Y);

  public static Vector2 ZW(this Vector4 vec) => new Vector2(vec.Z, vec.W);

  public static Vector3 XZW(this Vector4 vec) => new Vector3(vec.X, vec.Z, vec.W);

  public static Vector3 YZW(this Vector4 vec) => new Vector3(vec.Y, vec.Z, vec.W);

  public static Color MultiplyRGB(this Color firstColor, Color secondColor)
  {
    return new Color((int) (byte) ((double) ((int) firstColor.R * (int) secondColor.R) / (double) byte.MaxValue), (int) (byte) ((double) ((int) firstColor.G * (int) secondColor.G) / (double) byte.MaxValue), (int) (byte) ((double) ((int) firstColor.B * (int) secondColor.B) / (double) byte.MaxValue));
  }

  public static Color MultiplyRGBA(this Color firstColor, Color secondColor)
  {
    return new Color((int) (byte) ((double) ((int) firstColor.R * (int) secondColor.R) / (double) byte.MaxValue), (int) (byte) ((double) ((int) firstColor.G * (int) secondColor.G) / (double) byte.MaxValue), (int) (byte) ((double) ((int) firstColor.B * (int) secondColor.B) / (double) byte.MaxValue), (int) (byte) ((double) ((int) firstColor.A * (int) secondColor.A) / (double) byte.MaxValue));
  }

  public static string Hex3(this Color color)
  {
    byte num = color.R;
    string str1 = num.ToString("X2");
    num = color.G;
    string str2 = num.ToString("X2");
    num = color.B;
    string str3 = num.ToString("X2");
    return (str1 + str2 + str3).ToLower();
  }

  public static string Hex4(this Color color)
  {
    byte num = color.R;
    string str1 = num.ToString("X2");
    num = color.G;
    string str2 = num.ToString("X2");
    num = color.B;
    string str3 = num.ToString("X2");
    num = color.A;
    string str4 = num.ToString("X2");
    return (str1 + str2 + str3 + str4).ToLower();
  }

  public static int ToDirectionInt(this bool value) => !value ? -1 : 1;

  public static int ToInt(this bool value) => !value ? 0 : 1;

  public static int ModulusPositive(this int myInteger, int modulusNumber)
  {
    return (myInteger % modulusNumber + modulusNumber) % modulusNumber;
  }

  public static float AngleLerp(this float curAngle, float targetAngle, float amount)
  {
    float angle;
    if ((double) targetAngle < (double) curAngle)
    {
      float num = targetAngle + 6.28318548f;
      angle = (double) num - (double) curAngle > (double) curAngle - (double) targetAngle ? MathHelper.Lerp(curAngle, targetAngle, amount) : MathHelper.Lerp(curAngle, num, amount);
    }
    else
    {
      if ((double) targetAngle <= (double) curAngle)
        return curAngle;
      float num = targetAngle - 6.28318548f;
      angle = (double) targetAngle - (double) curAngle > (double) curAngle - (double) num ? MathHelper.Lerp(curAngle, num, amount) : MathHelper.Lerp(curAngle, targetAngle, amount);
    }
    return MathHelper.WrapAngle(angle);
  }

  public static float AngleTowards(this float curAngle, float targetAngle, float maxChange)
  {
    curAngle = MathHelper.WrapAngle(curAngle);
    targetAngle = MathHelper.WrapAngle(targetAngle);
    if ((double) curAngle < (double) targetAngle)
    {
      if ((double) targetAngle - (double) curAngle > 3.1415927410125732)
        curAngle += 6.28318548f;
    }
    else if ((double) curAngle - (double) targetAngle > 3.1415927410125732)
      curAngle -= 6.28318548f;
    curAngle += MathHelper.Clamp(targetAngle - curAngle, -maxChange, maxChange);
    return MathHelper.WrapAngle(curAngle);
  }

  public static float RotateUntil(this float curAngle, float targetAngle, float changePerTick)
  {
    curAngle = MathHelper.WrapAngle(curAngle);
    targetAngle = MathHelper.WrapAngle(targetAngle);
    if ((double) curAngle < (double) targetAngle)
    {
      if ((double) targetAngle - (double) curAngle > 3.1415927410125732)
        curAngle += 6.28318548f;
    }
    else if ((double) curAngle - (double) targetAngle > 3.1415927410125732)
      curAngle -= 6.28318548f;
    curAngle += changePerTick;
    curAngle = MathHelper.WrapAngle(curAngle);
    if ((double) curAngle > (double) targetAngle)
      curAngle = targetAngle;
    return curAngle;
  }

  public static bool deepCompare(this int[] firstArray, int[] secondArray)
  {
    if (firstArray == null && secondArray == null)
      return true;
    if (firstArray == null || secondArray == null || firstArray.Length != secondArray.Length)
      return false;
    for (int index = 0; index < firstArray.Length; ++index)
    {
      if (firstArray[index] != secondArray[index])
        return false;
    }
    return true;
  }

  public static bool deepCompare(this Rectangle[,] firstArray, Rectangle[,] secondArray)
  {
    if (firstArray == null && secondArray == null)
      return true;
    if (firstArray == null || secondArray == null || firstArray.Length != secondArray.Length || firstArray.GetLength(0) != secondArray.GetLength(0) || firstArray.GetLength(1) != secondArray.GetLength(1))
      return false;
    for (int index1 = 0; index1 < firstArray.GetLength(0); ++index1)
    {
      for (int index2 = 0; index2 < firstArray.GetLength(1); ++index2)
      {
        if (firstArray[index1, index2] != secondArray[index1, index2])
          return false;
      }
    }
    return true;
  }

  public static List<int> GetTrueIndexes(this bool[] array)
  {
    List<int> trueIndexes = new List<int>();
    for (int index = 0; index < array.Length; ++index)
    {
      if (array[index])
        trueIndexes.Add(index);
    }
    return trueIndexes;
  }

  public static List<int> GetTrueIndexes(params bool[][] arrays)
  {
    List<int> source = new List<int>();
    foreach (bool[] array in arrays)
      source.AddRange((IEnumerable<int>) array.GetTrueIndexes());
    return source.Distinct<int>().ToList<int>();
  }

  public static int Count<T>(this T[] arr, T value)
  {
    int num = 0;
    foreach (T x in arr)
    {
      if (EqualityComparer<T>.Default.Equals(x, value))
        ++num;
    }
    return num;
  }

  public static bool PressingShift(this KeyboardState kb)
  {
    return kb.IsKeyDown(Keys.LeftShift) || kb.IsKeyDown(Keys.RightShift);
  }

  public static bool PressingControl(this KeyboardState kb)
  {
    return kb.IsKeyDown(Keys.LeftControl) || kb.IsKeyDown(Keys.RightControl);
  }

  public static bool PressingAlt(this KeyboardState kb)
  {
    return kb.IsKeyDown(Keys.LeftAlt) || kb.IsKeyDown(Keys.RightAlt);
  }

  public static R[] MapArray<T, R>(T[] array, Func<T, R> mapper)
  {
    R[] rArray = new R[array.Length];
    for (int index = 0; index < array.Length; ++index)
      rArray[index] = mapper(array[index]);
    return rArray;
  }

  public static bool PlotLine(Point16 p0, Point16 p1, Utils.TileActionAttempt plot, bool jump = true)
  {
    return Utils.PlotLine((int) p0.X, (int) p0.Y, (int) p1.X, (int) p1.Y, plot, jump);
  }

  public static bool PlotLine(Point p0, Point p1, Utils.TileActionAttempt plot, bool jump = true)
  {
    return Utils.PlotLine(p0.X, p0.Y, p1.X, p1.Y, plot, jump);
  }

  private static bool PlotLine(
    int x0,
    int y0,
    int x1,
    int y1,
    Utils.TileActionAttempt plot,
    bool jump = true)
  {
    if (x0 == x1 && y0 == y1)
      return plot(x0, y0);
    bool flag = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
    if (flag)
    {
      Utils.Swap<int>(ref x0, ref y0);
      Utils.Swap<int>(ref x1, ref y1);
    }
    int num1 = Math.Abs(x1 - x0);
    int num2 = Math.Abs(y1 - y0);
    int num3 = num1 / 2;
    int num4 = y0;
    int num5 = x0 < x1 ? 1 : -1;
    int num6 = y0 < y1 ? 1 : -1;
    for (int index = x0; index != x1; index += num5)
    {
      if (flag)
      {
        if (!plot(num4, index))
          return false;
      }
      else if (!plot(index, num4))
        return false;
      num3 -= num2;
      if (num3 < 0)
      {
        num4 += num6;
        if (!jump)
        {
          if (flag)
          {
            if (!plot(num4, index))
              return false;
          }
          else if (!plot(index, num4))
            return false;
        }
        num3 += num1;
      }
    }
    return true;
  }

  public static int RandomNext(ref ulong seed, int bits)
  {
    seed = Utils.RandomNextSeed(seed);
    return (int) (seed >> 48 /*0x30*/ - bits);
  }

  public static ulong RandomNextSeed(ulong seed)
  {
    return (ulong) ((long) seed * 25214903917L + 11L & 281474976710655L /*0xFFFFFFFFFFFF*/);
  }

  public static float RandomFloat(ref ulong seed)
  {
    return (float) Utils.RandomNext(ref seed, 24) / 16777216f;
  }

  public static int RandomInt(ref ulong seed, int max)
  {
    if ((max & -max) == max)
      return (int) ((long) max * (long) Utils.RandomNext(ref seed, 31 /*0x1F*/) >> 31 /*0x1F*/);
    int num1;
    int num2;
    do
    {
      num1 = Utils.RandomNext(ref seed, 31 /*0x1F*/);
      num2 = num1 % max;
    }
    while (num1 - num2 + (max - 1) < 0);
    return num2;
  }

  public static int RandomInt(ref ulong seed, int min, int max)
  {
    return Utils.RandomInt(ref seed, max - min) + min;
  }

  public static bool PlotTileLine(
    Vector2 start,
    Vector2 end,
    float width,
    Utils.TileActionAttempt plot)
  {
    return Utils.PlotTileLine(start.ToVector2D(), end.ToVector2D(), (double) width, plot);
  }

  public static bool PlotTileLine(
    Vector2D start,
    Vector2D end,
    double width,
    Utils.TileActionAttempt plot)
  {
    double num = width / 2.0;
    Vector2D vector2D1 = Vector2D.op_Subtraction(end, start);
    Vector2D vector2D2 = Vector2D.op_Division(vector2D1, ((Vector2D) ref vector2D1).Length());
    Vector2D vector2D3 = Vector2D.op_Multiply(new Vector2D(-vector2D2.Y, vector2D2.X), num);
    Point tileCoordinates1 = Vector2D.op_Subtraction(start, vector2D3).ToTileCoordinates();
    Point tileCoordinates2 = Vector2D.op_Addition(start, vector2D3).ToTileCoordinates();
    Point tileCoordinates3 = start.ToTileCoordinates();
    Point tileCoordinates4 = end.ToTileCoordinates();
    Point lineMinOffset = new Point(tileCoordinates1.X - tileCoordinates3.X, tileCoordinates1.Y - tileCoordinates3.Y);
    Point lineMaxOffset = new Point(tileCoordinates2.X - tileCoordinates3.X, tileCoordinates2.Y - tileCoordinates3.Y);
    return Utils.PlotLine(tileCoordinates3.X, tileCoordinates3.Y, tileCoordinates4.X, tileCoordinates4.Y, (Utils.TileActionAttempt) ((x, y) => Utils.PlotLine(x + lineMinOffset.X, y + lineMinOffset.Y, x + lineMaxOffset.X, y + lineMaxOffset.Y, plot, false)));
  }

  public static bool PlotTileTale(
    Vector2D start,
    Vector2D end,
    double width,
    Utils.TileActionAttempt plot)
  {
    double halfWidth = width / 2.0;
    Vector2D vector2D1 = Vector2D.op_Subtraction(end, start);
    Vector2D vector2D2 = Vector2D.op_Division(vector2D1, ((Vector2D) ref vector2D1).Length());
    Vector2D perpOffset = new Vector2D(-vector2D2.Y, vector2D2.X);
    Point pointStart = start.ToTileCoordinates();
    Point tileCoordinates1 = end.ToTileCoordinates();
    int length = 0;
    Utils.PlotLine(pointStart.X, pointStart.Y, tileCoordinates1.X, tileCoordinates1.Y, (Utils.TileActionAttempt) ((_param1, _param2) =>
    {
      ++length;
      return true;
    }));
    length--;
    int curLength = 0;
    return Utils.PlotLine(pointStart.X, pointStart.Y, tileCoordinates1.X, tileCoordinates1.Y, (Utils.TileActionAttempt) ((x, y) =>
    {
      double num = 1.0 - (double) curLength / (double) length;
      ++curLength;
      Point tileCoordinates2 = Vector2D.op_Subtraction(start, Vector2D.op_Multiply(Vector2D.op_Multiply(perpOffset, halfWidth), num)).ToTileCoordinates();
      Point tileCoordinates3 = Vector2D.op_Addition(start, Vector2D.op_Multiply(Vector2D.op_Multiply(perpOffset, halfWidth), num)).ToTileCoordinates();
      Point point1 = new Point(tileCoordinates2.X - pointStart.X, tileCoordinates2.Y - pointStart.Y);
      Point point2 = new Point(tileCoordinates3.X - pointStart.X, tileCoordinates3.Y - pointStart.Y);
      return Utils.PlotLine(x + point1.X, y + point1.Y, x + point2.X, y + point2.Y, plot, false);
    }));
  }

  public static void FloodFillTile(Point point, float maxDist, Utils.TileActionAttempt plot)
  {
    if (!WorldGen.InWorld(point))
      return;
    List<Point> floodFillQueue1 = Utils._floodFillQueue1;
    List<Point> floodFillQueue2 = Utils._floodFillQueue2;
    BitSet2D floodFillBitset = Utils._floodFillBitset;
    floodFillBitset.Reset(point, (int) Math.Ceiling((double) maxDist) + 1);
    floodFillQueue2.Add(point);
    floodFillBitset.Add(point);
    while (floodFillQueue2.Count > 0)
    {
      Utils.Swap<List<Point>>(ref floodFillQueue1, ref floodFillQueue2);
      floodFillQueue2.Clear();
      foreach (Point point1 in floodFillQueue1)
      {
        if (plot(point1.X, point1.Y))
        {
          Point p = new Point(point1.X - 1, point1.Y);
          if (WorldGen.InWorld(p) && floodFillBitset.Add(p))
            floodFillQueue2.Add(p);
          p = new Point(point1.X + 1, point1.Y);
          if (WorldGen.InWorld(p) && floodFillBitset.Add(p))
            floodFillQueue2.Add(p);
          p = new Point(point1.X, point1.Y - 1);
          if (WorldGen.InWorld(p) && floodFillBitset.Add(p))
            floodFillQueue2.Add(p);
          p = new Point(point1.X, point1.Y + 1);
          if (WorldGen.InWorld(p) && floodFillBitset.Add(p))
            floodFillQueue2.Add(p);
        }
      }
    }
  }

  public static int RandomConsecutive(double random, int odds)
  {
    return (int) Math.Log(1.0 - random, 1.0 / (double) odds);
  }

  public static Vector2 RandomVector2(UnifiedRandom random, float min, float max)
  {
    return new Vector2((max - min) * (float) random.NextDouble() + min, (max - min) * (float) random.NextDouble() + min);
  }

  public static Vector2D RandomVector2D(UnifiedRandom random, double min, double max)
  {
    return new Vector2D((max - min) * random.NextDouble() + min, (max - min) * random.NextDouble() + min);
  }

  public static bool IndexInRange<T>(this T[] t, int index) => index >= 0 && index < t.Length;

  public static bool IndexInRange<T>(this List<T> t, int index) => index >= 0 && index < t.Count;

  public static T SelectRandom<T>(UnifiedRandom random, params T[] choices)
  {
    return choices[random.Next(choices.Length)];
  }

  public static void DrawBorderStringFourWay(
    SpriteBatch sb,
    DynamicSpriteFont font,
    string text,
    float x,
    float y,
    Color textColor,
    Color borderColor,
    Vector2 origin,
    float scale = 1f)
  {
    Color color = borderColor;
    Vector2 zero = Vector2.Zero;
    for (int index = 0; index < 5; ++index)
    {
      switch (index)
      {
        case 0:
          zero.X = x - 2f;
          zero.Y = y;
          break;
        case 1:
          zero.X = x + 2f;
          zero.Y = y;
          break;
        case 2:
          zero.X = x;
          zero.Y = y - 2f;
          break;
        case 3:
          zero.X = x;
          zero.Y = y + 2f;
          break;
        default:
          zero.X = x;
          zero.Y = y;
          color = textColor;
          break;
      }
      DynamicSpriteFontExtensionMethods.DrawString(sb, font, text, zero, color, 0.0f, origin, scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    }
  }

  public static Vector2 DrawBorderString(
    SpriteBatch sb,
    string text,
    Vector2 pos,
    Color color,
    float scale = 1f,
    float anchorx = 0.0f,
    float anchory = 0.0f,
    int maxCharactersDisplayed = -1)
  {
    if (maxCharactersDisplayed != -1)
      text = Utils.TrimUserString(text, maxCharactersDisplayed);
    DynamicSpriteFont font = FontAssets.MouseText.Value;
    Vector2 vector2 = font.MeasureString(text);
    ChatManager.DrawColorCodedStringWithShadow(sb, font, text, pos, color, 0.0f, new Vector2(anchorx, anchory) * vector2, new Vector2(scale), spread: 1.5f);
    return vector2 * scale;
  }

  public static Vector2 DrawBorderStringBig(
    SpriteBatch spriteBatch,
    string text,
    Vector2 pos,
    Color color,
    float scale = 1f,
    float anchorx = 0.0f,
    float anchory = 0.0f,
    int maxCharactersDisplayed = -1)
  {
    if (maxCharactersDisplayed != -1 && text.Length > maxCharactersDisplayed)
      text.Substring(0, maxCharactersDisplayed);
    DynamicSpriteFont dynamicSpriteFont = FontAssets.DeathText.Value;
    for (int x = -1; x < 2; ++x)
    {
      for (int y = -1; y < 2; ++y)
        DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, dynamicSpriteFont, text, pos + new Vector2((float) x, (float) y), Color.Black, 0.0f, new Vector2(anchorx, anchory) * dynamicSpriteFont.MeasureString(text), scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    }
    DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, dynamicSpriteFont, text, pos, color, 0.0f, new Vector2(anchorx, anchory) * dynamicSpriteFont.MeasureString(text), scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    return dynamicSpriteFont.MeasureString(text) * scale;
  }

  public static void DrawInvBG(SpriteBatch sb, Rectangle R, Color c = default (Color))
  {
    Utils.DrawInvBG(sb, R.X, R.Y, R.Width, R.Height, c);
  }

  public static void DrawInvBG(SpriteBatch sb, float x, float y, float w, float h, Color c = default (Color))
  {
    Utils.DrawInvBG(sb, (int) x, (int) y, (int) w, (int) h, c);
  }

  public static void DrawInvBG(SpriteBatch sb, int x, int y, int w, int h, Color c = default (Color))
  {
    if (c == new Color())
      c = new Color(63 /*0x3F*/, 65, 151, (int) byte.MaxValue) * 0.785f;
    Texture2D texture = TextureAssets.InventoryBack13.Value;
    if (w < 20)
      w = 20;
    if (h < 20)
      h = 20;
    sb.Draw(texture, new Rectangle(x, y, 10, 10), new Rectangle?(new Rectangle(0, 0, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + 10, y, w - 20, 10), new Rectangle?(new Rectangle(10, 0, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + w - 10, y, 10, 10), new Rectangle?(new Rectangle(texture.Width - 10, 0, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x, y + 10, 10, h - 20), new Rectangle?(new Rectangle(0, 10, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + 10, y + 10, w - 20, h - 20), new Rectangle?(new Rectangle(10, 10, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + w - 10, y + 10, 10, h - 20), new Rectangle?(new Rectangle(texture.Width - 10, 10, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x, y + h - 10, 10, 10), new Rectangle?(new Rectangle(0, texture.Height - 10, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + 10, y + h - 10, w - 20, 10), new Rectangle?(new Rectangle(10, texture.Height - 10, 10, 10)), c);
    sb.Draw(texture, new Rectangle(x + w - 10, y + h - 10, 10, 10), new Rectangle?(new Rectangle(texture.Width - 10, texture.Height - 10, 10, 10)), c);
  }

  public static string ReadEmbeddedResource(string path)
  {
    using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
    {
      using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        return streamReader.ReadToEnd();
    }
  }

  public static void DrawSplicedPanel(
    SpriteBatch sb,
    Texture2D texture,
    int x,
    int y,
    int w,
    int h,
    int leftEnd,
    int rightEnd,
    int topEnd,
    int bottomEnd,
    Color c)
  {
    if (w < leftEnd + rightEnd)
      w = leftEnd + rightEnd;
    if (h < topEnd + bottomEnd)
      h = topEnd + bottomEnd;
    sb.Draw(texture, new Rectangle(x, y, leftEnd, topEnd), new Rectangle?(new Rectangle(0, 0, leftEnd, topEnd)), c);
    sb.Draw(texture, new Rectangle(x + leftEnd, y, w - leftEnd - rightEnd, topEnd), new Rectangle?(new Rectangle(leftEnd, 0, texture.Width - leftEnd - rightEnd, topEnd)), c);
    sb.Draw(texture, new Rectangle(x + w - rightEnd, y, topEnd, rightEnd), new Rectangle?(new Rectangle(texture.Width - rightEnd, 0, rightEnd, topEnd)), c);
    sb.Draw(texture, new Rectangle(x, y + topEnd, leftEnd, h - topEnd - bottomEnd), new Rectangle?(new Rectangle(0, topEnd, leftEnd, texture.Height - topEnd - bottomEnd)), c);
    sb.Draw(texture, new Rectangle(x + leftEnd, y + topEnd, w - leftEnd - rightEnd, h - topEnd - bottomEnd), new Rectangle?(new Rectangle(leftEnd, topEnd, texture.Width - leftEnd - rightEnd, texture.Height - topEnd - bottomEnd)), c);
    sb.Draw(texture, new Rectangle(x + w - rightEnd, y + topEnd, rightEnd, h - topEnd - bottomEnd), new Rectangle?(new Rectangle(texture.Width - rightEnd, topEnd, rightEnd, texture.Height - topEnd - bottomEnd)), c);
    sb.Draw(texture, new Rectangle(x, y + h - bottomEnd, leftEnd, bottomEnd), new Rectangle?(new Rectangle(0, texture.Height - bottomEnd, leftEnd, bottomEnd)), c);
    sb.Draw(texture, new Rectangle(x + leftEnd, y + h - bottomEnd, w - leftEnd - rightEnd, bottomEnd), new Rectangle?(new Rectangle(leftEnd, texture.Height - bottomEnd, texture.Width - leftEnd - rightEnd, bottomEnd)), c);
    sb.Draw(texture, new Rectangle(x + w - rightEnd, y + h - bottomEnd, rightEnd, bottomEnd), new Rectangle?(new Rectangle(texture.Width - rightEnd, texture.Height - bottomEnd, rightEnd, bottomEnd)), c);
  }

  public static void DrawSettingsPanel(
    SpriteBatch spriteBatch,
    Vector2 position,
    float width,
    Color color)
  {
    Utils.DrawPanel(TextureAssets.SettingsPanel.Value, 2, 0, spriteBatch, position, width, color);
  }

  public static void DrawSettings2Panel(
    SpriteBatch spriteBatch,
    Vector2 position,
    float width,
    Color color)
  {
    Utils.DrawPanel(TextureAssets.SettingsPanel.Value, 2, 0, spriteBatch, position, width, color);
  }

  public static void DrawPanel(
    Texture2D texture,
    int edgeWidth,
    int edgeShove,
    SpriteBatch spriteBatch,
    Vector2 position,
    float width,
    Color color)
  {
    spriteBatch.Draw(texture, position, new Rectangle?(new Rectangle(0, 0, edgeWidth, texture.Height)), color);
    spriteBatch.Draw(texture, new Vector2(position.X + (float) edgeWidth, position.Y), new Rectangle?(new Rectangle(edgeWidth + edgeShove, 0, texture.Width - (edgeWidth + edgeShove) * 2, texture.Height)), color, 0.0f, Vector2.Zero, new Vector2((width - (float) (edgeWidth * 2)) / (float) (texture.Width - (edgeWidth + edgeShove) * 2), 1f), SpriteEffects.None, 0.0f);
    spriteBatch.Draw(texture, new Vector2(position.X + width - (float) edgeWidth, position.Y), new Rectangle?(new Rectangle(texture.Width - edgeWidth, 0, edgeWidth, texture.Height)), color);
  }

  public static void DrawRectangle(
    SpriteBatch sb,
    Vector2 start,
    Vector2 end,
    Color colorStart,
    Color colorEnd,
    float width)
  {
    Utils.DrawLine(sb, start, new Vector2(start.X, end.Y), colorStart, colorEnd, width);
    Utils.DrawLine(sb, start, new Vector2(end.X, start.Y), colorStart, colorEnd, width);
    Utils.DrawLine(sb, end, new Vector2(start.X, end.Y), colorStart, colorEnd, width);
    Utils.DrawLine(sb, end, new Vector2(end.X, start.Y), colorStart, colorEnd, width);
  }

  public static void DrawLaser(
    SpriteBatch sb,
    Texture2D tex,
    Vector2 start,
    Vector2 end,
    Vector2 scale,
    Utils.LaserLineFraming framing)
  {
    Vector2 vector2_1 = start;
    Vector2 vector2_2 = Vector2.Normalize(end - start);
    float distanceLeft1 = (end - start).Length();
    float rotation = vector2_2.ToRotation() - 1.57079637f;
    if (vector2_2.HasNaNs())
      return;
    float distanceCovered;
    Rectangle frame;
    Vector2 origin;
    Color color;
    framing(0, vector2_1, distanceLeft1, new Rectangle(), out distanceCovered, out frame, out origin, out color);
    sb.Draw(tex, vector2_1, new Rectangle?(frame), color, rotation, frame.Size() / 2f, scale, SpriteEffects.None, 0.0f);
    float distanceLeft2 = distanceLeft1 - distanceCovered * scale.Y;
    Vector2 vector2_3 = vector2_1 + vector2_2 * ((float) frame.Height - origin.Y) * scale.Y;
    if ((double) distanceLeft2 > 0.0)
    {
      float num = 0.0f;
      while ((double) num + 1.0 < (double) distanceLeft2)
      {
        framing(1, vector2_3, distanceLeft2 - num, frame, out distanceCovered, out frame, out origin, out color);
        if ((double) distanceLeft2 - (double) num < (double) frame.Height)
        {
          distanceCovered *= (distanceLeft2 - num) / (float) frame.Height;
          frame.Height = (int) ((double) distanceLeft2 - (double) num);
        }
        sb.Draw(tex, vector2_3, new Rectangle?(frame), color, rotation, origin, scale, SpriteEffects.None, 0.0f);
        num += distanceCovered * scale.Y;
        vector2_3 += vector2_2 * distanceCovered * scale.Y;
      }
    }
    framing(2, vector2_3, distanceLeft2, new Rectangle(), out distanceCovered, out frame, out origin, out color);
    sb.Draw(tex, vector2_3, new Rectangle?(frame), color, rotation, origin, scale, SpriteEffects.None, 0.0f);
  }

  public static void DrawLine(SpriteBatch spriteBatch, Point start, Point end, Color color)
  {
    Utils.DrawLine(spriteBatch, new Vector2((float) (start.X << 4), (float) (start.Y << 4)), new Vector2((float) (end.X << 4), (float) (end.Y << 4)), color);
  }

  public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
  {
    float num1 = Vector2.Distance(start, end);
    Vector2 v = (end - start) / num1;
    Vector2 vector2 = start;
    Vector2 screenPosition = Main.screenPosition;
    float rotation = v.ToRotation();
    for (float num2 = 0.0f; (double) num2 <= (double) num1; num2 += 4f)
    {
      float num3 = num2 / num1;
      spriteBatch.Draw(TextureAssets.BlackTile.Value, vector2 - screenPosition, new Rectangle?(), new Color(new Vector4(num3, num3, num3, 1f) * color.ToVector4()), rotation, Vector2.Zero, 0.25f, SpriteEffects.None, 0.0f);
      vector2 = start + num2 * v;
    }
  }

  public static void DrawLine(
    SpriteBatch spriteBatch,
    Vector2 start,
    Vector2 end,
    Color colorStart,
    Color colorEnd,
    float width)
  {
    float val2 = Vector2.Distance(start, end);
    float rotation = (end - start).ToRotation();
    int num = Math.Min(5, (int) val2);
    for (int index = 0; index < num; ++index)
      spriteBatch.Draw(TextureAssets.BlackTile.Value, Vector2.Lerp(start, end, (float) index / (float) num) - Main.screenPosition, new Rectangle?(), Color.Lerp(colorStart, colorEnd, ((float) index + 0.5f) / (float) num), rotation, Vector2.Zero, new Vector2((float) ((double) val2 / (double) num / 16.0), width / 16f), SpriteEffects.None, 0.0f);
  }

  public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Rectangle rect, Color color)
  {
    Utils.DrawRectForTilesInWorld(spriteBatch, new Point(rect.X, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height), color);
  }

  public static void DrawRectForTilesInWorld(
    SpriteBatch spriteBatch,
    Point start,
    Point end,
    Color color)
  {
    Utils.DrawRect(spriteBatch, new Vector2((float) (start.X << 4), (float) (start.Y << 4)), new Vector2((float) ((end.X << 4) - 4), (float) ((end.Y << 4) - 4)), color);
  }

  public static void DrawRect(SpriteBatch spriteBatch, Rectangle rect, Color color)
  {
    Utils.DrawRect(spriteBatch, new Vector2((float) rect.X, (float) rect.Y), new Vector2((float) (rect.X + rect.Width), (float) (rect.Y + rect.Height)), color);
  }

  public static void DrawRect(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
  {
    Utils.DrawLine(spriteBatch, start, new Vector2(start.X, end.Y), color);
    Utils.DrawLine(spriteBatch, start, new Vector2(end.X, start.Y), color);
    Utils.DrawLine(spriteBatch, end, new Vector2(start.X, end.Y), color);
    Utils.DrawLine(spriteBatch, end, new Vector2(end.X, start.Y), color);
  }

  public static void DrawRect(
    SpriteBatch spriteBatch,
    Vector2 topLeft,
    Vector2 topRight,
    Vector2 bottomRight,
    Vector2 bottomLeft,
    Color color)
  {
    Utils.DrawLine(spriteBatch, topLeft, topRight, color);
    Utils.DrawLine(spriteBatch, topRight, bottomRight, color);
    Utils.DrawLine(spriteBatch, bottomRight, bottomLeft, color);
    Utils.DrawLine(spriteBatch, bottomLeft, topLeft, color);
  }

  public static void DrawSelectedCraftingBarIndicator(
    SpriteBatch spriteBatch,
    int craftX,
    int craftY)
  {
    int num1 = 16 /*0x10*/;
    Color favoriteColor = Main.OurFavoriteColor;
    float num2 = 16f;
    for (float num3 = num2; (double) num3 > 0.0; --num3)
    {
      float num4 = (float) (1.0 - (double) num3 / (double) num2);
      spriteBatch.Draw(TextureAssets.BlackTile.Value, new Rectangle(craftX - 16 /*0x10*/, craftY + num1 + (int) num3 * -1, 32 /*0x20*/, 2), favoriteColor * (num4 * 0.6f));
    }
    spriteBatch.Draw(TextureAssets.BlackTile.Value, new Rectangle(craftX - 16 /*0x10*/, craftY + num1, 32 /*0x20*/, 4), favoriteColor);
  }

  public static void DrawCursorSingle(
    SpriteBatch sb,
    Color color,
    float rot = float.NaN,
    float scale = 1f,
    Vector2 manualPosition = default (Vector2),
    int cursorSlot = 0,
    int specialMode = 0)
  {
    bool flag1 = false;
    bool flag2 = true;
    bool flag3 = true;
    Vector2 origin = Vector2.Zero;
    Vector2 vector2_1 = new Vector2((float) Main.mouseX, (float) Main.mouseY);
    if (manualPosition != Vector2.Zero)
      vector2_1 = manualPosition;
    if (float.IsNaN(rot))
    {
      rot = 0.0f;
    }
    else
    {
      flag1 = true;
      rot -= 2.3561945f;
    }
    if (cursorSlot == 4 || cursorSlot == 5)
    {
      flag2 = false;
      origin = new Vector2(8f);
      if (flag1 && specialMode == 0)
      {
        float num1 = rot;
        if ((double) num1 < 0.0)
          num1 += 6.28318548f;
        for (float num2 = 0.0f; (double) num2 < 4.0; ++num2)
        {
          if ((double) Math.Abs(num1 - 1.57079637f * num2) <= 0.78539818525314331)
          {
            rot = 1.57079637f * num2;
            break;
          }
        }
      }
    }
    Vector2 vector2_2 = Vector2.One;
    if (Main.ThickMouse && cursorSlot == 0 || cursorSlot == 1)
      vector2_2 = Main.DrawThickCursor(cursorSlot == 1);
    if (flag2)
      sb.Draw(TextureAssets.Cursors[cursorSlot].Value, vector2_1 + vector2_2 + Vector2.One, new Rectangle?(), color.MultiplyRGB(new Color(0.2f, 0.2f, 0.2f, 0.5f)), rot, origin, scale * 1.1f, SpriteEffects.None, 0.0f);
    if (!flag3)
      return;
    sb.Draw(TextureAssets.Cursors[cursorSlot].Value, vector2_1 + vector2_2, new Rectangle?(), color, rot, origin, scale, SpriteEffects.None, 0.0f);
  }

  public static bool TryOperateInLock(object _lock, Action action)
  {
    if (!Monitor.TryEnter(_lock))
      return false;
    try
    {
      action();
      return true;
    }
    finally
    {
      Monitor.Exit(_lock);
    }
  }

  public static bool ParseCommandPrefix(string text, string prefix, out string remainder)
  {
    remainder = "";
    if (!text.StartsWith(prefix, true, CultureInfo.InvariantCulture))
      return false;
    if (text.Length == prefix.Length)
      return true;
    if (text[prefix.Length] != ' ')
      return false;
    remainder = text.Substring(prefix.Length + 1);
    return true;
  }

  public static string TrimUserString(string s, int length)
  {
    if (s.Length <= length)
      return s;
    if (length > 0 && char.IsHighSurrogate(s[length - 1]))
      --length;
    return s.Substring(0, length);
  }

  public static string TrimLastCharacter(string s) => Utils.TrimUserString(s, s.Length - 1);

  public delegate bool TileActionAttempt(int x, int y);

  public delegate void LaserLineFraming(
    int stage,
    Vector2 currentPosition,
    float distanceLeft,
    Rectangle lastFrame,
    out float distanceCovered,
    out Rectangle frame,
    out Vector2 origin,
    out Color color);

  public delegate Color ColorLerpMethod(float percent);

  public class RandomTeleportationAttemptSettings
  {
    public Vector2 teleporteeSize;
    public Vector2 teleporteeVelocity;
    public float teleporteeGravityDirection;
    public bool mostlySolidFloor;
    public bool avoidLava;
    public bool avoidAnyLiquid;
    public bool avoidHurtTiles;
    public bool avoidWalls;
    public int attemptsBeforeGivingUp;
    public int maximumFallDistanceFromOrignalPoint;
    public bool strictRange;
    public int[] tilesToAvoid;
    public int tilesToAvoidRange;
    public bool allowSolidTopFloor;
    public Func<Tile, int, int, bool> specializedConditions;
  }

  public struct ChaseResults
  {
    public bool InterceptionHappens;
    public Vector2 InterceptionPosition;
    public float InterceptionTime;
    public Vector2 ChaserVelocity;
  }
}
