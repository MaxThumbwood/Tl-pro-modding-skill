// Decompiled with JetBrains decompiler
// Type: Terraria.Collision
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria;

public class Collision
{
  public static bool stair;
  public static bool stairFall;
  public static bool honey;
  public static bool shimmer;
  public static bool sloping;
  public static bool landMine = false;
  public static bool up;
  public static bool down;
  public static float Epsilon = 2.71828175f;
  private const int bottomFluff = 40;
  private static List<Collision.TileContact> contacts = new List<Collision.TileContact>();
  private static List<Point> _cacheForConveyorBelts = new List<Point>();

  public static Vector2[] CheckLinevLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
  {
    if (a1.Equals(a2) && b1.Equals(b2))
    {
      if (!a1.Equals(b1))
        return new Vector2[0];
      return new Vector2[1]{ a1 };
    }
    if (b1.Equals(b2))
    {
      if (!Collision.PointOnLine(b1, a1, a2))
        return new Vector2[0];
      return new Vector2[1]{ b1 };
    }
    if (a1.Equals(a2))
    {
      if (!Collision.PointOnLine(a1, b1, b2))
        return new Vector2[0];
      return new Vector2[1]{ a1 };
    }
    float num1 = (float) (((double) b2.X - (double) b1.X) * ((double) a1.Y - (double) b1.Y) - ((double) b2.Y - (double) b1.Y) * ((double) a1.X - (double) b1.X));
    float num2 = (float) (((double) a2.X - (double) a1.X) * ((double) a1.Y - (double) b1.Y) - ((double) a2.Y - (double) a1.Y) * ((double) a1.X - (double) b1.X));
    float num3 = (float) (((double) b2.Y - (double) b1.Y) * ((double) a2.X - (double) a1.X) - ((double) b2.X - (double) b1.X) * ((double) a2.Y - (double) a1.Y));
    if (-(double) Collision.Epsilon >= (double) num3 || (double) num3 >= (double) Collision.Epsilon)
    {
      float num4 = num1 / num3;
      float num5 = num2 / num3;
      if (0.0 > (double) num4 || (double) num4 > 1.0 || 0.0 > (double) num5 || (double) num5 > 1.0)
        return new Vector2[0];
      return new Vector2[1]
      {
        new Vector2(a1.X + num4 * (a2.X - a1.X), a1.Y + num4 * (a2.Y - a1.Y))
      };
    }
    if ((-(double) Collision.Epsilon >= (double) num1 || (double) num1 >= (double) Collision.Epsilon) && (-(double) Collision.Epsilon >= (double) num2 || (double) num2 >= (double) Collision.Epsilon))
      return new Vector2[0];
    return a1.Equals(a2) ? Collision.OneDimensionalIntersection(b1, b2, a1, a2) : Collision.OneDimensionalIntersection(a1, a2, b1, b2);
  }

  private static double DistFromSeg(
    Vector2 p,
    Vector2 q0,
    Vector2 q1,
    double radius,
    ref float u)
  {
    double num1 = (double) q1.X - (double) q0.X;
    double num2 = (double) q1.Y - (double) q0.Y;
    double num3 = (double) q0.X - (double) p.X;
    double num4 = (double) q0.Y - (double) p.Y;
    double num5 = Math.Sqrt(num1 * num1 + num2 * num2);
    if (num5 < (double) Collision.Epsilon)
      throw new Exception("Expected line segment, not point.");
    return Math.Abs(num1 * num4 - num3 * num2) / num5;
  }

  private static bool PointOnLine(Vector2 p, Vector2 a1, Vector2 a2)
  {
    float u = 0.0f;
    return Collision.DistFromSeg(p, a1, a2, (double) Collision.Epsilon, ref u) < (double) Collision.Epsilon;
  }

  private static Vector2[] OneDimensionalIntersection(
    Vector2 a1,
    Vector2 a2,
    Vector2 b1,
    Vector2 b2)
  {
    float num1 = a2.X - a1.X;
    float num2 = a2.Y - a1.Y;
    float relativePoint1;
    float relativePoint2;
    if ((double) Math.Abs(num1) > (double) Math.Abs(num2))
    {
      relativePoint1 = (b1.X - a1.X) / num1;
      relativePoint2 = (b2.X - a1.X) / num1;
    }
    else
    {
      relativePoint1 = (b1.Y - a1.Y) / num2;
      relativePoint2 = (b2.Y - a1.Y) / num2;
    }
    List<Vector2> vector2List = new List<Vector2>();
    foreach (float overlapPoint in Collision.FindOverlapPoints(relativePoint1, relativePoint2))
    {
      float x = (float) ((double) a2.X * (double) overlapPoint + (double) a1.X * (1.0 - (double) overlapPoint));
      float y = (float) ((double) a2.Y * (double) overlapPoint + (double) a1.Y * (1.0 - (double) overlapPoint));
      vector2List.Add(new Vector2(x, y));
    }
    return vector2List.ToArray();
  }

  private static float[] FindOverlapPoints(float relativePoint1, float relativePoint2)
  {
    float val2_1 = Math.Min(relativePoint1, relativePoint2);
    float val2_2 = Math.Max(relativePoint1, relativePoint2);
    float num1 = Math.Max(0.0f, val2_1);
    float num2 = Math.Min(1f, val2_2);
    if ((double) num1 > (double) num2)
      return new float[0];
    return (double) num1 == (double) num2 ? new float[1]
    {
      num1
    } : new float[2]{ num1, num2 };
  }

  public static bool CheckAABBvAABBCollision(
    Vector2 position1,
    Vector2 dimensions1,
    Vector2 position2,
    Vector2 dimensions2)
  {
    return (double) position1.X < (double) position2.X + (double) dimensions2.X && (double) position1.Y < (double) position2.Y + (double) dimensions2.Y && (double) position1.X + (double) dimensions1.X > (double) position2.X && (double) position1.Y + (double) dimensions1.Y > (double) position2.Y;
  }

  private static int collisionOutcode(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 point)
  {
    float num1 = aabbPosition.X + aabbDimensions.X;
    float num2 = aabbPosition.Y + aabbDimensions.Y;
    int num3 = 0;
    if ((double) aabbDimensions.X <= 0.0)
      num3 |= 5;
    else if ((double) point.X < (double) aabbPosition.X)
      num3 |= 1;
    else if ((double) point.X - (double) num1 > 0.0)
      num3 |= 4;
    if ((double) aabbDimensions.Y <= 0.0)
      num3 |= 10;
    else if ((double) point.Y < (double) aabbPosition.Y)
      num3 |= 2;
    else if ((double) point.Y - (double) num2 > 0.0)
      num3 |= 8;
    return num3;
  }

  public static bool CheckAABBvLineCollision(
    Vector2 aabbPosition,
    Vector2 aabbDimensions,
    Vector2 lineStart,
    Vector2 lineEnd)
  {
    int num1;
    if ((num1 = Collision.collisionOutcode(aabbPosition, aabbDimensions, lineEnd)) == 0)
      return true;
    int num2;
    while ((num2 = Collision.collisionOutcode(aabbPosition, aabbDimensions, lineStart)) != 0)
    {
      if ((num2 & num1) != 0)
        return false;
      if ((num2 & 5) != 0)
      {
        float x = aabbPosition.X;
        if ((num2 & 4) != 0)
          x += aabbDimensions.X;
        lineStart.Y += (float) (((double) x - (double) lineStart.X) * ((double) lineEnd.Y - (double) lineStart.Y) / ((double) lineEnd.X - (double) lineStart.X));
        lineStart.X = x;
      }
      else
      {
        float y = aabbPosition.Y;
        if ((num2 & 8) != 0)
          y += aabbDimensions.Y;
        lineStart.X += (float) (((double) y - (double) lineStart.Y) * ((double) lineEnd.X - (double) lineStart.X) / ((double) lineEnd.Y - (double) lineStart.Y));
        lineStart.Y = y;
      }
    }
    return true;
  }

  public static bool CheckAABBvLineCollision2(
    Vector2 aabbPosition,
    Vector2 aabbDimensions,
    Vector2 lineStart,
    Vector2 lineEnd)
  {
    float collisionPoint = 0.0f;
    return Utils.RectangleLineCollision(aabbPosition, aabbPosition + aabbDimensions, lineStart, lineEnd) || Collision.CheckAABBvLineCollision(aabbPosition, aabbDimensions, lineStart, lineEnd, 0.0001f, ref collisionPoint);
  }

  public static bool CheckAABBvLineCollision(
    Vector2 objectPosition,
    Vector2 objectDimensions,
    Vector2 lineStart,
    Vector2 lineEnd,
    float lineWidth,
    ref float collisionPoint)
  {
    float y = lineWidth * 0.5f;
    Vector2 position2 = lineStart;
    Vector2 dimensions2 = lineEnd - lineStart;
    if ((double) dimensions2.X > 0.0)
    {
      dimensions2.X += lineWidth;
      position2.X -= y;
    }
    else
    {
      position2.X += dimensions2.X - y;
      dimensions2.X = -dimensions2.X + lineWidth;
    }
    if ((double) dimensions2.Y > 0.0)
    {
      dimensions2.Y += lineWidth;
      position2.Y -= y;
    }
    else
    {
      position2.Y += dimensions2.Y - y;
      dimensions2.Y = -dimensions2.Y + lineWidth;
    }
    if (!Collision.CheckAABBvAABBCollision(objectPosition, objectDimensions, position2, dimensions2))
      return false;
    Vector2 spinningpoint1 = objectPosition - lineStart;
    Vector2 spinningpoint2 = spinningpoint1 + objectDimensions;
    Vector2 spinningpoint3 = new Vector2(spinningpoint1.X, spinningpoint2.Y);
    Vector2 spinningpoint4 = new Vector2(spinningpoint2.X, spinningpoint1.Y);
    Vector2 vector2_1 = lineEnd - lineStart;
    float x = vector2_1.Length();
    float num1 = (float) Math.Atan2((double) vector2_1.Y, (double) vector2_1.X);
    Vector2[] vector2Array = new Vector2[4]
    {
      spinningpoint1.RotatedBy(-(double) num1),
      spinningpoint4.RotatedBy(-(double) num1),
      spinningpoint2.RotatedBy(-(double) num1),
      spinningpoint3.RotatedBy(-(double) num1)
    };
    collisionPoint = x;
    bool flag = false;
    for (int index = 0; index < vector2Array.Length; ++index)
    {
      if ((double) Math.Abs(vector2Array[index].Y) < (double) y && (double) vector2Array[index].X < (double) collisionPoint && (double) vector2Array[index].X >= 0.0)
      {
        collisionPoint = vector2Array[index].X;
        flag = true;
      }
    }
    Vector2 vector2_2 = new Vector2(0.0f, y);
    Vector2 vector2_3 = new Vector2(x, y);
    Vector2 vector2_4 = new Vector2(0.0f, -y);
    Vector2 vector2_5 = new Vector2(x, -y);
    for (int index1 = 0; index1 < vector2Array.Length; ++index1)
    {
      int index2 = (index1 + 1) % vector2Array.Length;
      Vector2 vector2_6 = vector2_3 - vector2_2;
      Vector2 vector2_7 = vector2Array[index2] - vector2Array[index1];
      float num2 = (float) ((double) vector2_6.X * (double) vector2_7.Y - (double) vector2_6.Y * (double) vector2_7.X);
      if ((double) num2 != 0.0)
      {
        Vector2 vector2_8 = vector2Array[index1] - vector2_2;
        float num3 = (float) ((double) vector2_8.X * (double) vector2_7.Y - (double) vector2_8.Y * (double) vector2_7.X) / num2;
        if ((double) num3 >= 0.0 && (double) num3 <= 1.0)
        {
          float num4 = (float) ((double) vector2_8.X * (double) vector2_6.Y - (double) vector2_8.Y * (double) vector2_6.X) / num2;
          if ((double) num4 >= 0.0 && (double) num4 <= 1.0)
          {
            flag = true;
            collisionPoint = Math.Min(collisionPoint, vector2_2.X + num3 * vector2_6.X);
          }
        }
      }
      Vector2 vector2_9 = vector2_5 - vector2_4;
      float num5 = (float) ((double) vector2_9.X * (double) vector2_7.Y - (double) vector2_9.Y * (double) vector2_7.X);
      if ((double) num5 != 0.0)
      {
        Vector2 vector2_10 = vector2Array[index1] - vector2_4;
        float num6 = (float) ((double) vector2_10.X * (double) vector2_7.Y - (double) vector2_10.Y * (double) vector2_7.X) / num5;
        if ((double) num6 >= 0.0 && (double) num6 <= 1.0)
        {
          float num7 = (float) ((double) vector2_10.X * (double) vector2_9.Y - (double) vector2_10.Y * (double) vector2_9.X) / num5;
          if ((double) num7 >= 0.0 && (double) num7 <= 1.0)
          {
            flag = true;
            collisionPoint = Math.Min(collisionPoint, vector2_4.X + num6 * vector2_9.X);
          }
        }
      }
    }
    return flag;
  }

  public static bool CanHit(Entity source, Entity target)
  {
    return Collision.CanHit(source.position, source.width, source.height, target.position, target.width, target.height);
  }

  public static bool CanHit(Entity source, NPCAimedTarget target)
  {
    return Collision.CanHit(source.position, source.width, source.height, target.Position, target.Width, target.Height);
  }

  public static bool CanHit(
    Vector2 Position1,
    int Width1,
    int Height1,
    Vector2 Position2,
    int Width2,
    int Height2)
  {
    return Collision.CanHit(Position1.ToPoint(), Width1, Height1, Position2.ToPoint(), Width2, Height2);
  }

  public static bool CanHit(
    Point Position1,
    int Width1,
    int Height1,
    Point Position2,
    int Width2,
    int Height2)
  {
    int index1 = (Position1.X + Width1 / 2) / 16 /*0x10*/;
    int index2 = (Position1.Y + Height1 / 2) / 16 /*0x10*/;
    int num1 = (Position2.X + Width2 / 2) / 16 /*0x10*/;
    int num2 = (Position2.Y + Height2 / 2) / 16 /*0x10*/;
    if (index1 <= 1)
      index1 = 1;
    if (index1 >= Main.maxTilesX)
      index1 = Main.maxTilesX - 1;
    if (num1 <= 1)
      num1 = 1;
    if (num1 >= Main.maxTilesX)
      num1 = Main.maxTilesX - 1;
    if (index2 <= 1)
      index2 = 1;
    if (index2 >= Main.maxTilesY - 40)
      index2 = Main.maxTilesY - 40;
    if (num2 <= 1)
      num2 = 1;
    if (num2 >= Main.maxTilesY - 40)
      num2 = Main.maxTilesY - 40;
    try
    {
      do
      {
        int num3 = Math.Abs(index1 - num1);
        int num4 = Math.Abs(index2 - num2);
        if (index1 == num1 && index2 == num2)
          return true;
        if (num3 > num4)
        {
          if (index1 < num1)
            ++index1;
          else
            --index1;
          if (Main.tile[index1, index2 - 1] == null || Main.tile[index1, index2 + 1] == null || !Main.tile[index1, index2 - 1].inActive() && Main.tile[index1, index2 - 1].active() && Main.tileSolid[(int) Main.tile[index1, index2 - 1].type] && !Main.tileSolidTop[(int) Main.tile[index1, index2 - 1].type] && Main.tile[index1, index2 - 1].slope() == (byte) 0 && !Main.tile[index1, index2 - 1].halfBrick() && !Main.tile[index1, index2 + 1].inActive() && Main.tile[index1, index2 + 1].active() && Main.tileSolid[(int) Main.tile[index1, index2 + 1].type] && !Main.tileSolidTop[(int) Main.tile[index1, index2 + 1].type] && Main.tile[index1, index2 + 1].slope() == (byte) 0 && !Main.tile[index1, index2 + 1].halfBrick())
            return false;
        }
        else
        {
          if (index2 < num2)
            ++index2;
          else
            --index2;
          if (Main.tile[index1 - 1, index2] == null || Main.tile[index1 + 1, index2] == null || !Main.tile[index1 - 1, index2].inActive() && Main.tile[index1 - 1, index2].active() && Main.tileSolid[(int) Main.tile[index1 - 1, index2].type] && !Main.tileSolidTop[(int) Main.tile[index1 - 1, index2].type] && Main.tile[index1 - 1, index2].slope() == (byte) 0 && !Main.tile[index1 - 1, index2].halfBrick() && !Main.tile[index1 + 1, index2].inActive() && Main.tile[index1 + 1, index2].active() && Main.tileSolid[(int) Main.tile[index1 + 1, index2].type] && !Main.tileSolidTop[(int) Main.tile[index1 + 1, index2].type] && Main.tile[index1 + 1, index2].slope() == (byte) 0 && !Main.tile[index1 + 1, index2].halfBrick())
            return false;
        }
      }
      while (Main.tile[index1, index2] != null && (Main.tile[index1, index2].inActive() || !Main.tile[index1, index2].active() || !Main.tileSolid[(int) Main.tile[index1, index2].type] || Main.tileSolidTop[(int) Main.tile[index1, index2].type]));
      return false;
    }
    catch
    {
      return false;
    }
  }

  public static bool CanHitWithCheck(Entity source, Entity target, Utils.TileActionAttempt check)
  {
    return Collision.CanHitWithCheck(source.position, source.width, source.height, target.position, target.width, target.height, check);
  }

  public static bool CanHit(Entity source, NPCAimedTarget target, Utils.TileActionAttempt check)
  {
    return Collision.CanHitWithCheck(source.position, source.width, source.height, target.Position, target.Width, target.Height, check);
  }

  public static bool CanHitWithCheck(
    Vector2 Position1,
    int Width1,
    int Height1,
    Vector2 Position2,
    int Width2,
    int Height2,
    Utils.TileActionAttempt check)
  {
    int x = (int) (((double) Position1.X + (double) (Width1 / 2)) / 16.0);
    int y = (int) (((double) Position1.Y + (double) (Height1 / 2)) / 16.0);
    int num1 = (int) (((double) Position2.X + (double) (Width2 / 2)) / 16.0);
    int num2 = (int) (((double) Position2.Y + (double) (Height2 / 2)) / 16.0);
    if (x <= 1)
      x = 1;
    if (x >= Main.maxTilesX)
      x = Main.maxTilesX - 1;
    if (num1 <= 1)
      num1 = 1;
    if (num1 >= Main.maxTilesX)
      num1 = Main.maxTilesX - 1;
    if (y <= 1)
      y = 1;
    if (y >= Main.maxTilesY - 40)
      y = Main.maxTilesY - 40;
    if (num2 <= 1)
      num2 = 1;
    if (num2 >= Main.maxTilesY - 40)
      num2 = Main.maxTilesY - 40;
    try
    {
      do
      {
        int num3 = Math.Abs(x - num1);
        int num4 = Math.Abs(y - num2);
        if (x == num1 && y == num2)
          return true;
        if (num3 > num4)
        {
          if (x < num1)
            ++x;
          else
            --x;
          if (Main.tile[x, y - 1] == null || Main.tile[x, y + 1] == null || !Main.tile[x, y - 1].inActive() && Main.tile[x, y - 1].active() && Main.tileSolid[(int) Main.tile[x, y - 1].type] && !Main.tileSolidTop[(int) Main.tile[x, y - 1].type] && Main.tile[x, y - 1].slope() == (byte) 0 && !Main.tile[x, y - 1].halfBrick() && !Main.tile[x, y + 1].inActive() && Main.tile[x, y + 1].active() && Main.tileSolid[(int) Main.tile[x, y + 1].type] && !Main.tileSolidTop[(int) Main.tile[x, y + 1].type] && Main.tile[x, y + 1].slope() == (byte) 0 && !Main.tile[x, y + 1].halfBrick())
            return false;
        }
        else
        {
          if (y < num2)
            ++y;
          else
            --y;
          if (Main.tile[x - 1, y] == null || Main.tile[x + 1, y] == null || !Main.tile[x - 1, y].inActive() && Main.tile[x - 1, y].active() && Main.tileSolid[(int) Main.tile[x - 1, y].type] && !Main.tileSolidTop[(int) Main.tile[x - 1, y].type] && Main.tile[x - 1, y].slope() == (byte) 0 && !Main.tile[x - 1, y].halfBrick() && !Main.tile[x + 1, y].inActive() && Main.tile[x + 1, y].active() && Main.tileSolid[(int) Main.tile[x + 1, y].type] && !Main.tileSolidTop[(int) Main.tile[x + 1, y].type] && Main.tile[x + 1, y].slope() == (byte) 0 && !Main.tile[x + 1, y].halfBrick())
            return false;
        }
      }
      while (Main.tile[x, y] != null && (Main.tile[x, y].inActive() || !Main.tile[x, y].active() || !Main.tileSolid[(int) Main.tile[x, y].type] || Main.tileSolidTop[(int) Main.tile[x, y].type]) && check(x, y));
      return false;
    }
    catch
    {
      return false;
    }
  }

  public static bool CanHitLine(
    Vector2 Position1,
    int Width1,
    int Height1,
    Vector2 Position2,
    int Width2,
    int Height2)
  {
    int index1 = (int) (((double) Position1.X + (double) (Width1 / 2)) / 16.0);
    int index2 = (int) (((double) Position1.Y + (double) (Height1 / 2)) / 16.0);
    int num1 = (int) (((double) Position2.X + (double) (Width2 / 2)) / 16.0);
    int num2 = (int) (((double) Position2.Y + (double) (Height2 / 2)) / 16.0);
    if (index1 <= 1)
      index1 = 1;
    if (index1 >= Main.maxTilesX)
      index1 = Main.maxTilesX - 1;
    if (num1 <= 1)
      num1 = 1;
    if (num1 >= Main.maxTilesX)
      num1 = Main.maxTilesX - 1;
    if (index2 <= 1)
      index2 = 1;
    if (index2 >= Main.maxTilesY - 40)
      index2 = Main.maxTilesY - 40;
    if (num2 <= 1)
      num2 = 1;
    if (num2 >= Main.maxTilesY - 40)
      num2 = Main.maxTilesY - 40;
    float num3 = (float) Math.Abs(index1 - num1);
    float num4 = (float) Math.Abs(index2 - num2);
    if ((double) num3 == 0.0 && (double) num4 == 0.0)
      return true;
    float num5 = 1f;
    float num6 = 1f;
    if ((double) num3 == 0.0 || (double) num4 == 0.0)
    {
      if ((double) num3 == 0.0)
        num5 = 0.0f;
      if ((double) num4 == 0.0)
        num6 = 0.0f;
    }
    else if ((double) num3 > (double) num4)
      num5 = num3 / num4;
    else
      num6 = num4 / num3;
    float num7 = 0.0f;
    float num8 = 0.0f;
    int num9 = 1;
    if (index2 < num2)
      num9 = 2;
    int num10 = (int) num3;
    int num11 = (int) num4;
    int num12 = Math.Sign(num1 - index1);
    int num13 = Math.Sign(num2 - index2);
    bool flag1 = false;
    bool flag2 = false;
    try
    {
      do
      {
        switch (num9)
        {
          case 1:
            float num14 = num8 + num6;
            int num15 = (int) num14;
            num8 = num14 - (float) num15;
            for (int index3 = 0; index3 < num15; ++index3)
            {
              if (Main.tile[index1 - 1, index2] == null || Main.tile[index1, index2] == null || Main.tile[index1 + 1, index2] == null)
                return false;
              Tile tile1 = Main.tile[index1 - 1, index2];
              Tile tile2 = Main.tile[index1 + 1, index2];
              Tile tile3 = Main.tile[index1, index2];
              if (!tile1.inActive() && tile1.active() && Main.tileSolid[(int) tile1.type] && !Main.tileSolidTop[(int) tile1.type] || !tile2.inActive() && tile2.active() && Main.tileSolid[(int) tile2.type] && !Main.tileSolidTop[(int) tile2.type] || !tile3.inActive() && tile3.active() && Main.tileSolid[(int) tile3.type] && !Main.tileSolidTop[(int) tile3.type])
                return false;
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              index2 += num13;
              --num11;
              if (num10 == 0 && num11 == 0 && num15 == 1)
                flag2 = true;
            }
            if (num10 != 0)
            {
              num9 = 2;
              break;
            }
            break;
          case 2:
            float num16 = num7 + num5;
            int num17 = (int) num16;
            num7 = num16 - (float) num17;
            for (int index4 = 0; index4 < num17; ++index4)
            {
              if (Main.tile[index1, index2 - 1] == null || Main.tile[index1, index2] == null || Main.tile[index1, index2 + 1] == null)
                return false;
              Tile tile4 = Main.tile[index1, index2 - 1];
              Tile tile5 = Main.tile[index1, index2 + 1];
              Tile tile6 = Main.tile[index1, index2];
              if (!tile4.inActive() && tile4.active() && Main.tileSolid[(int) tile4.type] && !Main.tileSolidTop[(int) tile4.type] || !tile5.inActive() && tile5.active() && Main.tileSolid[(int) tile5.type] && !Main.tileSolidTop[(int) tile5.type] || !tile6.inActive() && tile6.active() && Main.tileSolid[(int) tile6.type] && !Main.tileSolidTop[(int) tile6.type])
                return false;
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              index1 += num12;
              --num10;
              if (num10 == 0 && num11 == 0 && num17 == 1)
                flag2 = true;
            }
            if (num11 != 0)
            {
              num9 = 1;
              break;
            }
            break;
        }
        if (Main.tile[index1, index2] == null)
          return false;
        Tile tile = Main.tile[index1, index2];
        if (!tile.inActive() && tile.active() && Main.tileSolid[(int) tile.type] && !Main.tileSolidTop[(int) tile.type])
          return false;
      }
      while (!(flag1 | flag2));
      return true;
    }
    catch
    {
      return false;
    }
  }

  public static bool HitLine(
    int x1,
    int y1,
    int x2,
    int y2,
    int ignoreX,
    int ignoreY,
    List<Point> ignoreTargets,
    out Point col)
  {
    int num1 = x1;
    int num2 = y1;
    int num3 = x2;
    int num4 = y2;
    int x = Utils.Clamp<int>(num1, 1, Main.maxTilesX - 1);
    int num5 = Utils.Clamp<int>(num3, 1, Main.maxTilesX - 1);
    int y = Utils.Clamp<int>(num2, 1, Main.maxTilesY - 40);
    int num6 = Utils.Clamp<int>(num4, 1, Main.maxTilesY - 40);
    float num7 = (float) Math.Abs(x - num5);
    float num8 = (float) Math.Abs(y - num6);
    if ((double) num7 == 0.0 && (double) num8 == 0.0)
    {
      col = new Point(x, y);
      return true;
    }
    float num9 = 1f;
    float num10 = 1f;
    if ((double) num7 == 0.0 || (double) num8 == 0.0)
    {
      if ((double) num7 == 0.0)
        num9 = 0.0f;
      if ((double) num8 == 0.0)
        num10 = 0.0f;
    }
    else if ((double) num7 > (double) num8)
      num9 = num7 / num8;
    else
      num10 = num8 / num7;
    float num11 = 0.0f;
    float num12 = 0.0f;
    int num13 = 1;
    if (y < num6)
      num13 = 2;
    int num14 = (int) num7;
    int num15 = (int) num8;
    int num16 = Math.Sign(num5 - x);
    int num17 = Math.Sign(num6 - y);
    bool flag1 = false;
    bool flag2 = false;
    try
    {
      do
      {
        switch (num13)
        {
          case 1:
            float num18 = num12 + num10;
            int num19 = (int) num18;
            num12 = num18 - (float) num19;
            for (int index = 0; index < num19; ++index)
            {
              if (Main.tile[x - 1, y] == null)
              {
                col = new Point(x - 1, y);
                return false;
              }
              if (Main.tile[x + 1, y] == null)
              {
                col = new Point(x + 1, y);
                return false;
              }
              Tile tile1 = Main.tile[x - 1, y];
              Tile tile2 = Main.tile[x + 1, y];
              Tile tile3 = Main.tile[x, y];
              if (!ignoreTargets.Contains(new Point(x, y)) && !ignoreTargets.Contains(new Point(x - 1, y)) && !ignoreTargets.Contains(new Point(x + 1, y)))
              {
                if (ignoreX != -1 && num16 < 0 && !tile1.inActive() && tile1.active() && Main.tileSolid[(int) tile1.type] && !Main.tileSolidTop[(int) tile1.type])
                {
                  col = new Point(x - 1, y);
                  return true;
                }
                if (ignoreX != 1 && num16 > 0 && !tile2.inActive() && tile2.active() && Main.tileSolid[(int) tile2.type] && !Main.tileSolidTop[(int) tile2.type])
                {
                  col = new Point(x + 1, y);
                  return true;
                }
                if (!tile3.inActive() && tile3.active() && Main.tileSolid[(int) tile3.type] && !Main.tileSolidTop[(int) tile3.type])
                {
                  col = new Point(x, y);
                  return true;
                }
              }
              if (num14 == 0 && num15 == 0)
              {
                flag1 = true;
                break;
              }
              y += num17;
              --num15;
              if (num14 == 0 && num15 == 0 && num19 == 1)
                flag2 = true;
            }
            if (num14 != 0)
            {
              num13 = 2;
              break;
            }
            break;
          case 2:
            float num20 = num11 + num9;
            int num21 = (int) num20;
            num11 = num20 - (float) num21;
            for (int index = 0; index < num21; ++index)
            {
              if (Main.tile[x, y - 1] == null)
              {
                col = new Point(x, y - 1);
                return false;
              }
              if (Main.tile[x, y + 1] == null)
              {
                col = new Point(x, y + 1);
                return false;
              }
              Tile tile4 = Main.tile[x, y - 1];
              Tile tile5 = Main.tile[x, y + 1];
              Tile tile6 = Main.tile[x, y];
              if (!ignoreTargets.Contains(new Point(x, y)) && !ignoreTargets.Contains(new Point(x, y - 1)) && !ignoreTargets.Contains(new Point(x, y + 1)))
              {
                if (ignoreY != -1 && num17 < 0 && !tile4.inActive() && tile4.active() && Main.tileSolid[(int) tile4.type] && !Main.tileSolidTop[(int) tile4.type])
                {
                  col = new Point(x, y - 1);
                  return true;
                }
                if (ignoreY != 1 && num17 > 0 && !tile5.inActive() && tile5.active() && Main.tileSolid[(int) tile5.type] && !Main.tileSolidTop[(int) tile5.type])
                {
                  col = new Point(x, y + 1);
                  return true;
                }
                if (!tile6.inActive() && tile6.active() && Main.tileSolid[(int) tile6.type] && !Main.tileSolidTop[(int) tile6.type])
                {
                  col = new Point(x, y);
                  return true;
                }
              }
              if (num14 == 0 && num15 == 0)
              {
                flag1 = true;
                break;
              }
              x += num16;
              --num14;
              if (num14 == 0 && num15 == 0 && num21 == 1)
                flag2 = true;
            }
            if (num15 != 0)
            {
              num13 = 1;
              break;
            }
            break;
        }
        if (Main.tile[x, y] == null)
        {
          col = new Point(x, y);
          return false;
        }
        Tile tile = Main.tile[x, y];
        if (!ignoreTargets.Contains(new Point(x, y)) && !tile.inActive() && tile.active() && Main.tileSolid[(int) tile.type] && !Main.tileSolidTop[(int) tile.type])
        {
          col = new Point(x, y);
          return true;
        }
      }
      while (!(flag1 | flag2));
      col = new Point(x, y);
      return true;
    }
    catch
    {
      col = new Point(x1, y1);
      return false;
    }
  }

  public static bool AnyWallOfTypeOnLine(int x1, int y1, int x2, int y2, ushort wallId)
  {
    int x = x1;
    int y = y1;
    int num1 = x2;
    int num2 = y2;
    if (x <= 1)
      x = 1;
    if (x >= Main.maxTilesX)
      x = Main.maxTilesX - 1;
    if (num1 <= 1)
      num1 = 1;
    if (num1 >= Main.maxTilesX)
      num1 = Main.maxTilesX - 1;
    if (y <= 1)
      y = 1;
    if (y >= Main.maxTilesY - 40)
      y = Main.maxTilesY - 40;
    if (num2 <= 1)
      num2 = 1;
    if (num2 >= Main.maxTilesY - 40)
      num2 = Main.maxTilesY - 40;
    float num3 = (float) Math.Abs(x - num1);
    float num4 = (float) Math.Abs(y - num2);
    if ((double) num3 == 0.0 && (double) num4 == 0.0)
      return false;
    float num5 = 1f;
    float num6 = 1f;
    if ((double) num3 == 0.0 || (double) num4 == 0.0)
    {
      if ((double) num3 == 0.0)
        num5 = 0.0f;
      if ((double) num4 == 0.0)
        num6 = 0.0f;
    }
    else if ((double) num3 > (double) num4)
      num5 = num3 / num4;
    else
      num6 = num4 / num3;
    float num7 = 0.0f;
    float num8 = 0.0f;
    int num9 = 1;
    if (y < num2)
      num9 = 2;
    int num10 = (int) num3;
    int num11 = (int) num4;
    int num12 = Math.Sign(num1 - x);
    int num13 = Math.Sign(num2 - y);
    bool flag1 = false;
    bool flag2 = false;
    try
    {
      do
      {
        switch (num9)
        {
          case 1:
            float num14 = num8 + num6;
            int num15 = (int) num14;
            num8 = num14 - (float) num15;
            for (int index = 0; index < num15; ++index)
            {
              Tile tile = Main.tile[x, y];
              if (Collision.HitSpecificWallSubstep(x, y, wallId))
                return true;
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              y += num13;
              --num11;
              if (num10 == 0 && num11 == 0 && num15 == 1)
                flag2 = true;
            }
            if (num10 != 0)
            {
              num9 = 2;
              break;
            }
            break;
          case 2:
            float num16 = num7 + num5;
            int num17 = (int) num16;
            num7 = num16 - (float) num17;
            for (int index = 0; index < num17; ++index)
            {
              Tile tile = Main.tile[x, y];
              if (Collision.HitSpecificWallSubstep(x, y, wallId))
                return true;
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              x += num12;
              --num10;
              if (num10 == 0 && num11 == 0 && num17 == 1)
                flag2 = true;
            }
            if (num11 != 0)
            {
              num9 = 1;
              break;
            }
            break;
        }
        if (Main.tile[x, y] == null)
          return false;
        Tile tile1 = Main.tile[x, y];
        if (Collision.HitSpecificWallSubstep(x, y, wallId))
          return true;
      }
      while (!(flag1 | flag2));
      return false;
    }
    catch
    {
      return false;
    }
  }

  public static bool HitSpecificWallSubstep(int x, int y, ushort wallId)
  {
    return (int) Main.tile[x, y].wall == (int) wallId;
  }

  public static Point HitLineWall(int x1, int y1, int x2, int y2)
  {
    int x = x1;
    int y = y1;
    int num1 = x2;
    int num2 = y2;
    if (x <= 1)
      x = 1;
    if (x >= Main.maxTilesX)
      x = Main.maxTilesX - 1;
    if (num1 <= 1)
      num1 = 1;
    if (num1 >= Main.maxTilesX)
      num1 = Main.maxTilesX - 1;
    if (y <= 1)
      y = 1;
    if (y >= Main.maxTilesY - 40)
      y = Main.maxTilesY - 40;
    if (num2 <= 1)
      num2 = 1;
    if (num2 >= Main.maxTilesY - 40)
      num2 = Main.maxTilesY - 40;
    float num3 = (float) Math.Abs(x - num1);
    float num4 = (float) Math.Abs(y - num2);
    if ((double) num3 == 0.0 && (double) num4 == 0.0)
      return new Point(x, y);
    float num5 = 1f;
    float num6 = 1f;
    if ((double) num3 == 0.0 || (double) num4 == 0.0)
    {
      if ((double) num3 == 0.0)
        num5 = 0.0f;
      if ((double) num4 == 0.0)
        num6 = 0.0f;
    }
    else if ((double) num3 > (double) num4)
      num5 = num3 / num4;
    else
      num6 = num4 / num3;
    float num7 = 0.0f;
    float num8 = 0.0f;
    int num9 = 1;
    if (y < num2)
      num9 = 2;
    int num10 = (int) num3;
    int num11 = (int) num4;
    int num12 = Math.Sign(num1 - x);
    int num13 = Math.Sign(num2 - y);
    bool flag1 = false;
    bool flag2 = false;
    try
    {
      do
      {
        switch (num9)
        {
          case 1:
            float num14 = num8 + num6;
            int num15 = (int) num14;
            num8 = num14 - (float) num15;
            for (int index = 0; index < num15; ++index)
            {
              Tile tile = Main.tile[x, y];
              if (Collision.HitWallSubstep(x, y))
                return new Point(x, y);
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              y += num13;
              --num11;
              if (num10 == 0 && num11 == 0 && num15 == 1)
                flag2 = true;
            }
            if (num10 != 0)
            {
              num9 = 2;
              break;
            }
            break;
          case 2:
            float num16 = num7 + num5;
            int num17 = (int) num16;
            num7 = num16 - (float) num17;
            for (int index = 0; index < num17; ++index)
            {
              Tile tile = Main.tile[x, y];
              if (Collision.HitWallSubstep(x, y))
                return new Point(x, y);
              if (num10 == 0 && num11 == 0)
              {
                flag1 = true;
                break;
              }
              x += num12;
              --num10;
              if (num10 == 0 && num11 == 0 && num17 == 1)
                flag2 = true;
            }
            if (num11 != 0)
            {
              num9 = 1;
              break;
            }
            break;
        }
        if (Main.tile[x, y] == null)
          return new Point(-1, -1);
        Tile tile1 = Main.tile[x, y];
        if (Collision.HitWallSubstep(x, y))
          return new Point(x, y);
      }
      while (!(flag1 | flag2));
      return new Point(x, y);
    }
    catch
    {
      return new Point(-1, -1);
    }
  }

  public static bool HitWallSubstep(int x, int y)
  {
    if (Main.tile[x, y].wall == (ushort) 0)
      return false;
    bool flag1 = false;
    if (Main.wallHouse[(int) Main.tile[x, y].wall])
      flag1 = true;
    if (!flag1)
    {
      for (int index1 = -1; index1 < 2; ++index1)
      {
        for (int index2 = -1; index2 < 2; ++index2)
        {
          if ((index1 != 0 || index2 != 0) && Main.tile[x + index1, y + index2].wall == (ushort) 0)
            flag1 = true;
        }
      }
    }
    if (Main.tile[x, y].active() & flag1)
    {
      bool flag2 = true;
      for (int index3 = -1; index3 < 2; ++index3)
      {
        for (int index4 = -1; index4 < 2; ++index4)
        {
          if (index3 != 0 || index4 != 0)
          {
            Tile tile = Main.tile[x + index3, y + index4];
            if (!tile.active() || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type])
              flag2 = false;
          }
        }
      }
      if (flag2)
        flag1 = false;
    }
    return flag1;
  }

  public static bool EmptyTile(int i, int j, bool ignoreTiles = false)
  {
    Rectangle rectangle = new Rectangle(i * 16 /*0x10*/, j * 16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/);
    if (Main.tile[i, j].active() && !ignoreTiles)
      return false;
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].active && !Main.player[index].dead && !Main.player[index].ghost && rectangle.Intersects(new Rectangle((int) Main.player[index].position.X, (int) Main.player[index].position.Y, Main.player[index].width, Main.player[index].height)))
        return false;
    }
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      if (Main.npc[index].active && rectangle.Intersects(new Rectangle((int) Main.npc[index].position.X, (int) Main.npc[index].position.Y, Main.npc[index].width, Main.npc[index].height)))
        return false;
    }
    return true;
  }

  public static bool DrownCollision(
    Vector2 Position,
    int Width,
    int Height,
    float gravDir = -1f,
    bool includeSlopes = false)
  {
    Vector2 vector2_1 = new Vector2(Position.X + (float) (Width / 2), Position.Y + (float) (Height / 2));
    int num1 = 10;
    int num2 = 12;
    if (num1 > Width)
      num1 = Width;
    if (num2 > Height)
      num2 = Height;
    vector2_1 = new Vector2(vector2_1.X - (float) (num1 / 2), Position.Y - 2f);
    if ((double) gravDir == -1.0)
      vector2_1.Y += (float) (Height / 2 - 6);
    int num3 = (int) ((double) Position.X / 16.0) - 1;
    int num4 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num5 = (int) ((double) Position.Y / 16.0) - 1;
    int num6 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num7 = Utils.Clamp<int>(num3, 0, max);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesX - 1);
    int num9 = Utils.Clamp<int>(num5, 0, Main.maxTilesY - 40);
    int num10 = Utils.Clamp<int>(num6, 0, Main.maxTilesY - 40);
    int num11 = (double) gravDir == 1.0 ? num9 : num10 - 1;
    for (int index1 = num7; index1 < num8; ++index1)
    {
      for (int index2 = num9; index2 < num10; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.liquid > (byte) 0 && !tile.lava() && !tile.shimmer() && (index2 != num11 || !tile.active() || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type] || includeSlopes && tile.blockType() != 0))
        {
          Vector2 vector2_2;
          vector2_2.X = (float) (index1 * 16 /*0x10*/);
          vector2_2.Y = (float) (index2 * 16 /*0x10*/);
          int num12 = 16 /*0x10*/;
          float num13 = (float) (256 /*0x0100*/ - (int) Main.tile[index1, index2].liquid) / 32f;
          vector2_2.Y += num13 * 2f;
          int num14 = num12 - (int) ((double) num13 * 2.0);
          if ((double) vector2_1.X + (double) num1 > (double) vector2_2.X && (double) vector2_1.X < (double) vector2_2.X + 16.0 && (double) vector2_1.Y + (double) num2 > (double) vector2_2.Y && (double) vector2_1.Y < (double) vector2_2.Y + (double) num14)
            return true;
        }
      }
    }
    return false;
  }

  public static bool IsWorldPointSolid(Vector2 pos, bool treatPlatformsAsNonSolid = false)
  {
    Point tileCoordinates = pos.ToTileCoordinates();
    if (!WorldGen.InWorld(tileCoordinates.X, tileCoordinates.Y, 1))
      return false;
    Tile tile = Main.tile[tileCoordinates.X, tileCoordinates.Y];
    if (tile == null || !tile.active() || tile.inActive() || !Main.tileSolid[(int) tile.type] || treatPlatformsAsNonSolid && tile.type > (ushort) 0 && (int) tile.type <= (int) TileID.Count && (TileID.Sets.Platforms[(int) tile.type] || tile.type == (ushort) 380))
      return false;
    int num1 = tile.blockType();
    switch (num1)
    {
      case 0:
        return (double) pos.X >= (double) (tileCoordinates.X * 16 /*0x10*/) && (double) pos.X <= (double) (tileCoordinates.X * 16 /*0x10*/ + 16 /*0x10*/) && (double) pos.Y >= (double) (tileCoordinates.Y * 16 /*0x10*/) && (double) pos.Y <= (double) (tileCoordinates.Y * 16 /*0x10*/ + 16 /*0x10*/);
      case 1:
        return (double) pos.X >= (double) (tileCoordinates.X * 16 /*0x10*/) && (double) pos.X <= (double) (tileCoordinates.X * 16 /*0x10*/ + 16 /*0x10*/) && (double) pos.Y >= (double) (tileCoordinates.Y * 16 /*0x10*/ + 8) && (double) pos.Y <= (double) (tileCoordinates.Y * 16 /*0x10*/ + 16 /*0x10*/);
      case 2:
      case 3:
      case 4:
      case 5:
        if ((double) pos.X < (double) (tileCoordinates.X * 16 /*0x10*/) && (double) pos.X > (double) (tileCoordinates.X * 16 /*0x10*/ + 16 /*0x10*/) && (double) pos.Y < (double) (tileCoordinates.Y * 16 /*0x10*/) && (double) pos.Y > (double) (tileCoordinates.Y * 16 /*0x10*/ + 16 /*0x10*/))
          return false;
        float num2 = pos.X % 16f;
        float num3 = pos.Y % 16f;
        switch (num1)
        {
          case 2:
            return (double) num3 >= (double) num2;
          case 3:
            return (double) num2 + (double) num3 >= 16.0;
          case 4:
            return (double) num2 + (double) num3 <= 16.0;
          case 5:
            return (double) num3 <= (double) num2;
        }
        break;
    }
    return false;
  }

  public static bool GetWaterLine(Point pt, out float waterLineHeight)
  {
    return Collision.GetWaterLine(pt.X, pt.Y, out waterLineHeight);
  }

  public static bool GetWaterLine(int X, int Y, out float waterLineHeight)
  {
    waterLineHeight = 0.0f;
    if (!WorldGen.InWorld(X, Y, 10))
      return false;
    if (Main.tile[X, Y - 2] == null)
      Main.tile[X, Y - 2] = new Tile();
    if (Main.tile[X, Y - 1] == null)
      Main.tile[X, Y - 1] = new Tile();
    if (Main.tile[X, Y] == null)
      Main.tile[X, Y] = new Tile();
    if (Main.tile[X, Y + 1] == null)
      Main.tile[X, Y + 1] = new Tile();
    if (Main.tile[X, Y - 2].liquid > (byte) 0)
      return false;
    if (Main.tile[X, Y - 1].liquid > (byte) 0)
    {
      waterLineHeight = (float) (Y * 16 /*0x10*/);
      waterLineHeight -= (float) ((int) Main.tile[X, Y - 1].liquid / 16 /*0x10*/);
      return true;
    }
    if (Main.tile[X, Y].liquid > (byte) 0)
    {
      waterLineHeight = (float) ((Y + 1) * 16 /*0x10*/);
      waterLineHeight -= (float) ((int) Main.tile[X, Y].liquid / 16 /*0x10*/);
      return true;
    }
    if (Main.tile[X, Y + 1].liquid <= (byte) 0)
      return false;
    waterLineHeight = (float) ((Y + 2) * 16 /*0x10*/);
    waterLineHeight -= (float) ((int) Main.tile[X, Y + 1].liquid / 16 /*0x10*/);
    return true;
  }

  public static bool GetWaterLineIterate(Point pt, out float waterLineHeight)
  {
    return Collision.GetWaterLineIterate(pt.X, pt.Y, out waterLineHeight);
  }

  public static bool GetWaterLineIterate(int X, int Y, out float waterLineHeight)
  {
    waterLineHeight = 0.0f;
    while (Y > 0 && Framing.GetTileSafely(X, Y).liquid > (byte) 0)
      --Y;
    ++Y;
    if (Main.tile[X, Y] == null)
      Main.tile[X, Y] = new Tile();
    if (Main.tile[X, Y].liquid <= (byte) 0)
      return false;
    waterLineHeight = (float) (Y * 16 /*0x10*/);
    waterLineHeight -= (float) ((int) Main.tile[X, Y - 1].liquid / 16 /*0x10*/);
    return true;
  }

  public static bool WetCollision(Vector2 Position, int Width, int Height)
  {
    Collision.honey = false;
    Collision.shimmer = false;
    Vector2 vector2_1 = new Vector2(Position.X + (float) (Width / 2), Position.Y + (float) (Height / 2));
    int num1 = 10;
    int num2 = Height / 2;
    if (num1 > Width)
      num1 = Width;
    if (num2 > Height)
      num2 = Height;
    vector2_1 = new Vector2(vector2_1.X - (float) (num1 / 2), vector2_1.Y - (float) (num2 / 2));
    int num3 = (int) ((double) Position.X / 16.0) - 1;
    int num4 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num5 = (int) ((double) Position.Y / 16.0) - 1;
    int num6 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num7 = Utils.Clamp<int>(num3, 0, max);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesX - 1);
    int num9 = Utils.Clamp<int>(num5, 0, Main.maxTilesY - 40);
    int num10 = Utils.Clamp<int>(num6, 0, Main.maxTilesY - 40);
    Vector2 vector2_2;
    for (int index1 = num7; index1 < num8; ++index1)
    {
      for (int index2 = num9; index2 < num10; ++index2)
      {
        if (Main.tile[index1, index2] != null)
        {
          if (Main.tile[index1, index2].liquid > (byte) 0)
          {
            vector2_2.X = (float) (index1 * 16 /*0x10*/);
            vector2_2.Y = (float) (index2 * 16 /*0x10*/);
            int num11 = 16 /*0x10*/;
            float num12 = (float) (256 /*0x0100*/ - (int) Main.tile[index1, index2].liquid) / 32f;
            vector2_2.Y += num12 * 2f;
            int num13 = num11 - (int) ((double) num12 * 2.0);
            if ((double) vector2_1.X + (double) num1 > (double) vector2_2.X && (double) vector2_1.X < (double) vector2_2.X + 16.0 && (double) vector2_1.Y + (double) num2 > (double) vector2_2.Y && (double) vector2_1.Y < (double) vector2_2.Y + (double) num13)
            {
              if (Main.tile[index1, index2].honey())
                Collision.honey = true;
              if (Main.tile[index1, index2].shimmer())
                Collision.shimmer = true;
              return true;
            }
          }
          else if (Main.tile[index1, index2].active() && Main.tile[index1, index2].slope() != (byte) 0 && index2 > 0 && Main.tile[index1, index2 - 1] != null && Main.tile[index1, index2 - 1].liquid > (byte) 0)
          {
            vector2_2.X = (float) (index1 * 16 /*0x10*/);
            vector2_2.Y = (float) (index2 * 16 /*0x10*/);
            int num14 = 16 /*0x10*/;
            if ((double) vector2_1.X + (double) num1 > (double) vector2_2.X && (double) vector2_1.X < (double) vector2_2.X + 16.0 && (double) vector2_1.Y + (double) num2 > (double) vector2_2.Y && (double) vector2_1.Y < (double) vector2_2.Y + (double) num14)
            {
              if (Main.tile[index1, index2 - 1].honey())
                Collision.honey = true;
              else if (Main.tile[index1, index2 - 1].shimmer())
                Collision.shimmer = true;
              return true;
            }
          }
        }
      }
    }
    return false;
  }

  public static bool LavaCollision(Vector2 Position, int Width, int Height)
  {
    int num1 = Height;
    int num2 = (int) ((double) Position.X / 16.0) - 1;
    int num3 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num4 = (int) ((double) Position.Y / 16.0) - 1;
    int num5 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num6 = Utils.Clamp<int>(num2, 0, max);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesX - 1);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    int num9 = Utils.Clamp<int>(num5, 0, Main.maxTilesY - 40);
    for (int index1 = num6; index1 < num7; ++index1)
    {
      for (int index2 = num8; index2 < num9; ++index2)
      {
        if (Main.tile[index1, index2] != null && Main.tile[index1, index2].liquid > (byte) 0 && Main.tile[index1, index2].lava())
        {
          Vector2 vector2;
          vector2.X = (float) (index1 * 16 /*0x10*/);
          vector2.Y = (float) (index2 * 16 /*0x10*/);
          int num10 = 16 /*0x10*/;
          float num11 = (float) (256 /*0x0100*/ - (int) Main.tile[index1, index2].liquid) / 32f;
          vector2.Y += num11 * 2f;
          int num12 = num10 - (int) ((double) num11 * 2.0);
          if ((double) Position.X + (double) Width > (double) vector2.X && (double) Position.X < (double) vector2.X + 16.0 && (double) Position.Y + (double) num1 > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + (double) num12)
            return true;
        }
      }
    }
    return false;
  }

  public static Vector4 WalkDownSlope(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    float gravity = 0.0f)
  {
    if ((double) Velocity.Y != (double) gravity)
      return new Vector4(Position, Velocity.X, Velocity.Y);
    Vector2 vector2_1 = Position;
    int num1 = (int) ((double) vector2_1.X / 16.0);
    int num2 = (int) (((double) vector2_1.X + (double) Width) / 16.0);
    int num3 = (int) (((double) Position.Y + (double) Height + 4.0) / 16.0);
    int num4 = Utils.Clamp<int>(num1, 0, Main.maxTilesX - 1);
    int num5 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num6 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 2 - 40);
    float num7 = (float) ((num6 + 3) * 16 /*0x10*/);
    int index1 = -1;
    int index2 = -1;
    int num8 = 1;
    if ((double) Velocity.X < 0.0)
      num8 = 2;
    for (int index3 = num4; index3 <= num5; ++index3)
    {
      for (int index4 = num6; index4 <= num6 + 1; ++index4)
      {
        if (Main.tile[index3, index4] == null)
          Main.tile[index3, index4] = new Tile();
        if (Main.tile[index3, index4].nactive() && (Main.tileSolid[(int) Main.tile[index3, index4].type] || Main.tileSolidTop[(int) Main.tile[index3, index4].type]))
        {
          int num9 = index4 * 16 /*0x10*/;
          if (Main.tile[index3, index4].halfBrick())
            num9 += 8;
          if (new Rectangle(index3 * 16 /*0x10*/, index4 * 16 /*0x10*/ - 17, 16 /*0x10*/, 16 /*0x10*/).Intersects(new Rectangle((int) Position.X, (int) Position.Y, Width, Height)) && (double) num9 <= (double) num7)
          {
            if ((double) num7 == (double) num9)
            {
              if (Main.tile[index3, index4].slope() != (byte) 0)
              {
                if (index1 != -1 && index2 != -1 && Main.tile[index1, index2] != null && Main.tile[index1, index2].slope() != (byte) 0)
                {
                  if ((int) Main.tile[index3, index4].slope() == num8)
                  {
                    num7 = (float) num9;
                    index1 = index3;
                    index2 = index4;
                  }
                }
                else
                {
                  num7 = (float) num9;
                  index1 = index3;
                  index2 = index4;
                }
              }
            }
            else
            {
              num7 = (float) num9;
              index1 = index3;
              index2 = index4;
            }
          }
        }
      }
    }
    int index5 = index1;
    int index6 = index2;
    if (index1 != -1 && index2 != -1 && Main.tile[index5, index6] != null && Main.tile[index5, index6].slope() > (byte) 0)
    {
      int num10 = (int) Main.tile[index5, index6].slope();
      Vector2 vector2_2;
      vector2_2.X = (float) (index5 * 16 /*0x10*/);
      vector2_2.Y = (float) (index6 * 16 /*0x10*/);
      switch (num10)
      {
        case 1:
          float num11 = Position.X - vector2_2.X;
          if ((double) Position.Y + (double) Height >= (double) vector2_2.Y + (double) num11 && (double) Velocity.X > 0.0)
          {
            Velocity.Y += Math.Abs(Velocity.X);
            break;
          }
          break;
        case 2:
          float num12 = (float) ((double) vector2_2.X + 16.0 - ((double) Position.X + (double) Width));
          if ((double) Position.Y + (double) Height >= (double) vector2_2.Y + (double) num12 && (double) Velocity.X < 0.0)
          {
            Velocity.Y += Math.Abs(Velocity.X);
            break;
          }
          break;
      }
    }
    return new Vector4(Position, Velocity.X, Velocity.Y);
  }

  public static Vector4 SlopeCollision(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    float gravity = 0.0f,
    bool fall = false,
    bool ignoreAetheriumPlatforms = false)
  {
    Collision.stair = false;
    Collision.stairFall = false;
    BitsByte bitsByte = (BitsByte) (byte) 0;
    float y1 = Position.Y;
    float y2 = Position.Y;
    Collision.sloping = false;
    Vector2 vector2_1 = Position;
    Vector2 vector2_2 = Position;
    Vector2 vector2_3 = Velocity;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num5 = Utils.Clamp<int>(num1, 0, max);
    int num6 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    for (int index1 = num5; index1 < num6; ++index1)
    {
      for (int index2 = num7; index2 < num8; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.active() && !tile.inActive())
        {
          bool flag1 = Main.tileSolid[(int) tile.type];
          if (Main.tileSolidTop[(int) tile.type] && tile.frameY == (short) 0)
            flag1 = true;
          if (ignoreAetheriumPlatforms && tile.type == (ushort) 19 && (int) tile.frameY / 18 == 50)
            flag1 = false;
          if (flag1)
          {
            Vector2 vector2_4;
            vector2_4.X = (float) (index1 * 16 /*0x10*/);
            vector2_4.Y = (float) (index2 * 16 /*0x10*/);
            int num9 = 16 /*0x10*/;
            if (Main.tile[index1, index2].halfBrick())
            {
              vector2_4.Y += 8f;
              num9 -= 8;
            }
            if ((double) Position.X + (double) Width > (double) vector2_4.X && (double) Position.X < (double) vector2_4.X + 16.0 && (double) Position.Y + (double) Height > (double) vector2_4.Y && (double) Position.Y < (double) vector2_4.Y + (double) num9)
            {
              bool flag2 = true;
              if (TileID.Sets.Platforms[(int) Main.tile[index1, index2].type])
              {
                if ((double) Velocity.Y < 0.0)
                  flag2 = false;
                if ((double) Position.Y + (double) Height < (double) (index2 * 16 /*0x10*/) || (double) Position.Y + (double) Height - (1.0 + (double) Math.Abs(Velocity.X)) > (double) (index2 * 16 /*0x10*/ + 16 /*0x10*/))
                  flag2 = false;
                if ((Main.tile[index1, index2].slope() == (byte) 1 && (double) Velocity.X >= 0.0 || Main.tile[index1, index2].slope() == (byte) 2 && (double) Velocity.X <= 0.0) && ((double) Position.Y + (double) Height) / 16.0 - 1.0 == (double) index2)
                  flag2 = false;
              }
              if (flag2)
              {
                bool flag3 = false;
                if (fall && TileID.Sets.Platforms[(int) Main.tile[index1, index2].type])
                  flag3 = true;
                int key = (int) Main.tile[index1, index2].slope();
                vector2_4.X = (float) (index1 * 16 /*0x10*/);
                vector2_4.Y = (float) (index2 * 16 /*0x10*/);
                if ((double) Position.X + (double) Width > (double) vector2_4.X && (double) Position.X < (double) vector2_4.X + 16.0 && (double) Position.Y + (double) Height > (double) vector2_4.Y && (double) Position.Y < (double) vector2_4.Y + 16.0)
                {
                  float num10 = 0.0f;
                  if (key == 3 || key == 4)
                  {
                    if (key == 3)
                      num10 = Position.X - vector2_4.X;
                    if (key == 4)
                      num10 = (float) ((double) vector2_4.X + 16.0 - ((double) Position.X + (double) Width));
                    if ((double) num10 >= 0.0)
                    {
                      if ((double) Position.Y <= (double) vector2_4.Y + 16.0 - (double) num10)
                      {
                        float num11 = vector2_4.Y + 16f - vector2_1.Y - num10;
                        if ((double) Position.Y + (double) num11 > (double) y2)
                        {
                          vector2_2.Y = Position.Y + num11;
                          y2 = vector2_2.Y;
                          if ((double) vector2_3.Y < 0.010099999606609344)
                            vector2_3.Y = 0.0101f;
                          bitsByte[key] = true;
                        }
                      }
                    }
                    else if ((double) Position.Y > (double) vector2_4.Y)
                    {
                      float num12 = vector2_4.Y + 16f;
                      if ((double) vector2_2.Y < (double) num12)
                      {
                        vector2_2.Y = num12;
                        if ((double) vector2_3.Y < 0.010099999606609344)
                          vector2_3.Y = 0.0101f;
                      }
                    }
                  }
                  if (key == 1 || key == 2)
                  {
                    if (key == 1)
                      num10 = Position.X - vector2_4.X;
                    if (key == 2)
                      num10 = (float) ((double) vector2_4.X + 16.0 - ((double) Position.X + (double) Width));
                    if ((double) num10 >= 0.0)
                    {
                      if ((double) Position.Y + (double) Height >= (double) vector2_4.Y + (double) num10)
                      {
                        float num13 = vector2_4.Y - (vector2_1.Y + (float) Height) + num10;
                        if ((double) Position.Y + (double) num13 < (double) y1)
                        {
                          if (flag3)
                          {
                            Collision.stairFall = true;
                          }
                          else
                          {
                            Collision.stair = TileID.Sets.Platforms[(int) Main.tile[index1, index2].type];
                            vector2_2.Y = Position.Y + num13;
                            y1 = vector2_2.Y;
                            if ((double) vector2_3.Y > 0.0)
                              vector2_3.Y = 0.0f;
                            bitsByte[key] = true;
                          }
                        }
                      }
                    }
                    else if (TileID.Sets.Platforms[(int) Main.tile[index1, index2].type] && (double) Position.Y + (double) Height - 4.0 - (double) Math.Abs(Velocity.X) > (double) vector2_4.Y)
                    {
                      if (flag3)
                        Collision.stairFall = true;
                    }
                    else
                    {
                      float num14 = vector2_4.Y - (float) Height;
                      if ((double) vector2_2.Y > (double) num14)
                      {
                        if (flag3)
                        {
                          Collision.stairFall = true;
                        }
                        else
                        {
                          Collision.stair = TileID.Sets.Platforms[(int) Main.tile[index1, index2].type];
                          vector2_2.Y = num14;
                          if ((double) vector2_3.Y > 0.0)
                            vector2_3.Y = 0.0f;
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
    Vector2 Position1 = Position;
    Vector2 vector2_5 = vector2_2 - Position;
    Vector2 Velocity1 = vector2_5;
    int Width1 = Width;
    int Height1 = Height;
    Vector2 vector2_6 = Collision.TileCollision(Position1, Velocity1, Width1, Height1);
    if ((double) vector2_6.Y > (double) vector2_5.Y)
    {
      float num15 = vector2_5.Y - vector2_6.Y;
      vector2_2.Y = Position.Y + vector2_6.Y;
      if (bitsByte[1])
        vector2_2.X = Position.X - num15;
      if (bitsByte[2])
        vector2_2.X = Position.X + num15;
      vector2_3.X = 0.0f;
      vector2_3.Y = 0.0f;
      Collision.up = false;
    }
    else if ((double) vector2_6.Y < (double) vector2_5.Y)
    {
      float num16 = vector2_6.Y - vector2_5.Y;
      vector2_2.Y = Position.Y + vector2_6.Y;
      if (bitsByte[3])
        vector2_2.X = Position.X - num16;
      if (bitsByte[4])
        vector2_2.X = Position.X + num16;
      vector2_3.X = 0.0f;
      vector2_3.Y = 0.0f;
    }
    return new Vector4(vector2_2, vector2_3.X, vector2_3.Y);
  }

  public static Vector2 noSlopeCollision(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false)
  {
    Collision.up = false;
    Collision.down = false;
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Velocity;
    Vector2 vector2_3 = Position + Velocity;
    Vector2 vector2_4 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int num5 = -1;
    int num6 = -1;
    int num7 = -1;
    int num8 = -1;
    int max = Main.maxTilesX - 1;
    int num9 = Utils.Clamp<int>(num1, 0, max);
    int num10 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num11 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num12 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    float num13 = (float) ((num12 + 3) * 16 /*0x10*/);
    for (int index1 = num9; index1 < num10; ++index1)
    {
      for (int index2 = num11; index2 < num12; ++index2)
      {
        if (Main.tile[index1, index2] != null && Main.tile[index1, index2].active() && (Main.tileSolid[(int) Main.tile[index1, index2].type] || Main.tileSolidTop[(int) Main.tile[index1, index2].type] && Main.tile[index1, index2].frameY == (short) 0))
        {
          Vector2 vector2_5;
          vector2_5.X = (float) (index1 * 16 /*0x10*/);
          vector2_5.Y = (float) (index2 * 16 /*0x10*/);
          int num14 = 16 /*0x10*/;
          if (Main.tile[index1, index2].halfBrick())
          {
            vector2_5.Y += 8f;
            num14 -= 8;
          }
          if ((double) vector2_3.X + (double) Width > (double) vector2_5.X && (double) vector2_3.X < (double) vector2_5.X + 16.0 && (double) vector2_3.Y + (double) Height > (double) vector2_5.Y && (double) vector2_3.Y < (double) vector2_5.Y + (double) num14)
          {
            if ((double) vector2_4.Y + (double) Height <= (double) vector2_5.Y)
            {
              Collision.down = true;
              if ((!(Main.tileSolidTop[(int) Main.tile[index1, index2].type] & fallThrough) || !((double) Velocity.Y <= 1.0 | fall2)) && (double) num13 > (double) vector2_5.Y)
              {
                num7 = index1;
                num8 = index2;
                if (num14 < 16 /*0x10*/)
                  ++num8;
                if (num7 != num5)
                {
                  vector2_1.Y = vector2_5.Y - (vector2_4.Y + (float) Height);
                  num13 = vector2_5.Y;
                }
              }
            }
            else if ((double) vector2_4.X + (double) Width <= (double) vector2_5.X && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X - (vector2_4.X + (float) Width);
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.X >= (double) vector2_5.X + 16.0 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X + 16f - vector2_4.X;
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.Y >= (double) vector2_5.Y + (double) num14 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              Collision.up = true;
              num7 = index1;
              num8 = index2;
              vector2_1.Y = (float) ((double) vector2_5.Y + (double) num14 - (double) vector2_4.Y + 0.0099999997764825821);
              if (num8 == num6)
                vector2_1.X = vector2_2.X;
            }
          }
        }
      }
    }
    return vector2_1;
  }

  public static void BuildTileContacts(
    Vector2 Position,
    int Width,
    int Height,
    List<Collision.TileContact> contactTiles)
  {
    Position.X = (float) (int) Position.X;
    Position.Y = (float) (int) Position.Y;
    contactTiles.Clear();
    int num1 = (int) (((double) Position.X - 1.0) / 16.0) - 1;
    int num2 = (int) (((double) Position.X + 1.0 + (double) Width) / 16.0) + 1;
    int num3 = (int) (((double) Position.Y - 1.0) / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + 3.0 + (double) Height) / 16.0) + 1;
    int max = Main.maxTilesX - 1;
    int num5 = Utils.Clamp<int>(num1, 0, max);
    int num6 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    for (int x = num5; x < num6; ++x)
    {
      for (int y = num7; y < num8; ++y)
      {
        Tile tile = Main.tile[x, y];
        if (tile != null && tile.active() && !tile.inActive())
        {
          ushort type = tile.type;
          bool flag = Main.tileSolid[(int) type];
          if (Main.tileSolidTop[(int) type] && tile.frameY == (short) 0)
            flag = true;
          if (flag)
          {
            Vector2 vector2;
            vector2.X = (float) (x * 16 /*0x10*/);
            vector2.Y = (float) (y * 16 /*0x10*/);
            int num9 = 16 /*0x10*/;
            if (tile.halfBrick())
            {
              vector2.Y += 8f;
              num9 -= 8;
            }
            byte slope = tile.slope();
            if ((double) Math.Abs(Position.X - (vector2.X + 16f)) < 0.10000000149011612 && (double) Position.Y + (double) Height > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + (double) num9 && slope != (byte) 3 && slope != (byte) 1)
            {
              float overlap = Math.Max((float) ((double) Math.Min(Position.Y + (float) Height, vector2.Y + (float) num9) - (double) Math.Max(Position.Y, vector2.Y) + 0.5), 1f);
              contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Left, x, y, (int) type, (int) slope, (int) overlap));
            }
            if ((double) Math.Abs(Position.X + (float) Width - vector2.X) < 0.10000000149011612 && (double) Position.Y + (double) Height > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + (double) num9 && slope != (byte) 4 && slope != (byte) 2)
            {
              float overlap = Math.Max((float) ((double) Math.Min(Position.Y + (float) Height, vector2.Y + (float) num9) - (double) Math.Max(Position.Y, vector2.Y) + 0.5), 1f);
              contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Right, x, y, (int) type, (int) slope, (int) overlap));
            }
            if ((double) Position.Y + 3.0 + (double) Height > (double) vector2.Y && (double) Position.Y - 1.0 < (double) vector2.Y + (double) num9)
            {
              if ((double) Position.X + (double) Width > (double) vector2.X && (double) Position.X < (double) vector2.X + 16.0)
              {
                float overlap = Math.Max((float) ((double) Math.Min(Position.X + (float) Width, vector2.X + 16f) - (double) Math.Max(Position.X, vector2.X) + 0.5), 1f);
                switch (slope)
                {
                  case 0:
                    if ((double) Math.Abs(Position.Y - (vector2.Y + (float) num9)) < 0.10000000149011612)
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Top, x, y, (int) type, (int) slope, (int) overlap));
                    if ((double) Math.Abs(Position.Y + (float) Height - vector2.Y) < 0.10000000149011612)
                    {
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Bottom, x, y, (int) type, (int) slope, (int) overlap));
                      continue;
                    }
                    continue;
                  case 1:
                    if ((double) Math.Abs(Position.Y - (vector2.Y + (float) num9)) < 0.10000000149011612)
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Top, x, y, (int) type, (int) slope, (int) overlap));
                    float num10 = Math.Max(Position.X - vector2.X, 0.0f);
                    float num11 = Position.Y + (float) Height;
                    if ((double) num11 - (double) vector2.Y > -0.10000000149011612 && (double) num11 - ((double) vector2.Y + (double) num10) < 0.10000000149011612)
                    {
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Bottom, x, y, (int) type, (int) slope, (int) overlap));
                      continue;
                    }
                    continue;
                  case 2:
                    if ((double) Math.Abs(Position.Y - (vector2.Y + (float) num9)) < 0.10000000149011612)
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Top, x, y, (int) type, (int) slope, (int) overlap));
                    float num12 = Math.Max((float) ((double) vector2.X + 16.0 - ((double) Position.X + (double) Width)), 0.0f);
                    float num13 = Position.Y + (float) Height;
                    if ((double) num13 - (double) vector2.Y > -0.10000000149011612 && (double) num13 - ((double) vector2.Y + (double) num12) < 0.10000000149011612)
                    {
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Bottom, x, y, (int) type, (int) slope, (int) overlap));
                      continue;
                    }
                    continue;
                  case 3:
                    float num14 = Math.Max(Position.X - vector2.X, 0.0f);
                    if ((double) Math.Abs(Position.Y - (vector2.Y + (float) num9 - num14)) < 0.10000000149011612)
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Top, x, y, (int) type, (int) slope, (int) overlap));
                    if ((double) Math.Abs(Position.Y + (float) Height - vector2.Y) < 0.10000000149011612)
                    {
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Bottom, x, y, (int) type, (int) slope, (int) overlap));
                      continue;
                    }
                    continue;
                  case 4:
                    float num15 = Math.Max((float) ((double) vector2.X + 16.0 - ((double) Position.X + (double) Width)), 0.0f);
                    if ((double) Math.Abs(Position.Y - (vector2.Y + (float) num9 - num15)) < 0.10000000149011612)
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Top, x, y, (int) type, (int) slope, (int) overlap));
                    if ((double) Math.Abs(Position.Y + (float) Height - vector2.Y) < 0.10000000149011612)
                    {
                      contactTiles.Add(new Collision.TileContact(Collision.TileContactSide.Bottom, x, y, (int) type, (int) slope, (int) overlap));
                      continue;
                    }
                    continue;
                  default:
                    continue;
                }
              }
              else if ((double) Position.X + 3.0 + (double) Width > (double) vector2.X && (double) Position.X - 3.0 < (double) vector2.X + 16.0 && (double) Position.Y < (double) vector2.Y)
              {
                Collision.TileContactSide side = (double) vector2.X < (double) Position.X ? Collision.TileContactSide.BottomLeft : Collision.TileContactSide.BottomRight;
                switch (slope)
                {
                  case 0:
                  case 3:
                  case 4:
                    contactTiles.Add(new Collision.TileContact(side, x, y, (int) type, (int) slope, 0));
                    continue;
                  case 1:
                    if (side == Collision.TileContactSide.BottomRight)
                    {
                      contactTiles.Add(new Collision.TileContact(side, x, y, (int) type, (int) slope, 0));
                      continue;
                    }
                    continue;
                  case 2:
                    if (side == Collision.TileContactSide.BottomLeft)
                    {
                      contactTiles.Add(new Collision.TileContact(side, x, y, (int) type, (int) slope, 0));
                      continue;
                    }
                    continue;
                  default:
                    continue;
                }
              }
            }
          }
        }
      }
    }
  }

  public static Vector2 TileCollision(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    int gravDir = 1,
    bool ignoreDoors = false,
    bool ignoreAetheriumPlatforms = false,
    bool hoik = true)
  {
    Collision.up = false;
    Collision.down = false;
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Velocity;
    Vector2 vector2_3 = Position + Velocity;
    Vector2 vector2_4 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int num5 = -1;
    int num6 = -1;
    int num7 = -1;
    int num8 = -1;
    int max = Main.maxTilesX - 1;
    int num9 = Utils.Clamp<int>(num1, 0, max);
    int num10 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num11 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num12 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    float num13 = (float) ((num12 + 3) * 16 /*0x10*/);
    for (int index1 = num9; index1 < num10; ++index1)
    {
      for (int index2 = num11; index2 < num12; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.active() && !tile.inActive())
        {
          bool flag1 = Main.tileSolid[(int) tile.type];
          if (Main.tileSolidTop[(int) tile.type] && tile.frameY == (short) 0)
            flag1 = true;
          if (ignoreDoors && TileID.Sets.ForAdvancedCollision.ClosedDoors[(int) tile.type])
            flag1 = false;
          if (ignoreAetheriumPlatforms && tile.type == (ushort) 19 && (int) tile.frameY / 18 == 50)
            flag1 = false;
          if (flag1)
          {
            Vector2 vector2_5;
            vector2_5.X = (float) (index1 * 16 /*0x10*/);
            vector2_5.Y = (float) (index2 * 16 /*0x10*/);
            int num14 = 16 /*0x10*/;
            if (Main.tile[index1, index2].halfBrick())
            {
              vector2_5.Y += 8f;
              num14 -= 8;
            }
            if ((double) vector2_3.X + (double) Width > (double) vector2_5.X && (double) vector2_3.X < (double) vector2_5.X + 16.0 && (double) vector2_3.Y + (double) Height > (double) vector2_5.Y && (double) vector2_3.Y < (double) vector2_5.Y + (double) num14)
            {
              bool flag2 = false;
              bool flag3 = false;
              if (Main.tile[index1, index2].slope() > (byte) 2)
              {
                if (Main.tile[index1, index2].slope() == (byte) 3 && (double) vector2_4.Y + (double) Math.Abs(Velocity.X) >= (double) vector2_5.Y && (double) vector2_4.X >= (double) vector2_5.X)
                  flag3 = true;
                if (Main.tile[index1, index2].slope() == (byte) 4 && (double) vector2_4.Y + (double) Math.Abs(Velocity.X) >= (double) vector2_5.Y && (double) vector2_4.X + (double) Width <= (double) vector2_5.X + 16.0)
                  flag3 = true;
              }
              else if (Main.tile[index1, index2].slope() > (byte) 0)
              {
                flag2 = true;
                if (Main.tile[index1, index2].slope() == (byte) 1 && (double) vector2_4.Y + (double) Height - (double) Math.Abs(Velocity.X) <= (double) vector2_5.Y + (double) num14 && (double) vector2_4.X >= (double) vector2_5.X)
                  flag3 = true;
                if (Main.tile[index1, index2].slope() == (byte) 2 && (double) vector2_4.Y + (double) Height - (double) Math.Abs(Velocity.X) <= (double) vector2_5.Y + (double) num14 && (double) vector2_4.X + (double) Width <= (double) vector2_5.X + 16.0)
                  flag3 = true;
              }
              if (!flag3)
              {
                if ((double) vector2_4.Y + (double) Height <= (double) vector2_5.Y)
                {
                  Collision.down = true;
                  if ((!(Main.tileSolidTop[(int) Main.tile[index1, index2].type] & fallThrough) || !((double) Velocity.Y <= 1.0 | fall2)) && (double) num13 > (double) vector2_5.Y)
                  {
                    num7 = index1;
                    num8 = index2;
                    if (num14 < 16 /*0x10*/)
                      ++num8;
                    if (num7 != num5 && !flag2)
                    {
                      vector2_1.Y = (float) ((double) vector2_5.Y - ((double) vector2_4.Y + (double) Height) + (gravDir == -1 ? -0.0099999997764825821 : 0.0));
                      num13 = vector2_5.Y;
                    }
                  }
                }
                else if ((double) vector2_4.X + (double) Width <= (double) vector2_5.X && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
                {
                  if (index1 >= 1 && Main.tile[index1 - 1, index2] == null)
                    Main.tile[index1 - 1, index2] = new Tile();
                  if (!hoik || index1 < 1 || Main.tile[index1 - 1, index2].slope() != (byte) 2 && Main.tile[index1 - 1, index2].slope() != (byte) 4)
                  {
                    num5 = index1;
                    num6 = index2;
                    if (num6 != num8)
                      vector2_1.X = vector2_5.X - (vector2_4.X + (float) Width);
                    if (num7 == num5)
                      vector2_1.Y = vector2_2.Y;
                  }
                }
                else if ((double) vector2_4.X >= (double) vector2_5.X + 16.0 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
                {
                  if (Main.tile[index1 + 1, index2] == null)
                    Main.tile[index1 + 1, index2] = new Tile();
                  if (!hoik || Main.tile[index1 + 1, index2].slope() != (byte) 1 && Main.tile[index1 + 1, index2].slope() != (byte) 3)
                  {
                    num5 = index1;
                    num6 = index2;
                    if (num6 != num8)
                      vector2_1.X = vector2_5.X + 16f - vector2_4.X;
                    if (num7 == num5)
                      vector2_1.Y = vector2_2.Y;
                  }
                }
                else if ((double) vector2_4.Y >= (double) vector2_5.Y + (double) num14 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
                {
                  Collision.up = true;
                  num7 = index1;
                  num8 = index2;
                  vector2_1.Y = (float) ((double) vector2_5.Y + (double) num14 - (double) vector2_4.Y + (gravDir == 1 ? 0.0099999997764825821 : 0.0));
                  if (num8 == num6)
                    vector2_1.X = vector2_2.X;
                }
              }
            }
          }
        }
      }
    }
    return vector2_1;
  }

  public static float TileCollisionInStepsOf16(
    Vector2 Position,
    Vector2 normalizedDirection,
    float amount,
    int Width,
    int Height)
  {
    float val1 = 16f;
    Vector2 vector2_1 = new Vector2(Position.X + 1f, Position.Y);
    int Width1 = Width - 1;
    for (float num1 = 0.0f; (double) num1 < (double) amount; num1 += val1)
    {
      Vector2 vector2_2 = normalizedDirection * num1;
      Vector2 Position1 = Position + vector2_2;
      Vector2 Position2 = vector2_1 + vector2_2;
      float num2 = Math.Min(val1, amount - num1);
      Vector2 Velocity = normalizedDirection * num2;
      Vector4 vec1 = Collision.SlopeCollision(Position2, Velocity, Width1, Height);
      if (vec1.XY() != Position2 || vec1.ZW() != Velocity)
      {
        float num3 = (vec1.XY() - Position2).Length();
        return num1 - num3;
      }
      Vector4 vec2 = Collision.SlopeCollision(Position2 + Velocity, Velocity, Width1, Height);
      if (vec2.XY() != Position2 + Velocity || vec2.ZW() != Velocity)
      {
        float num4 = (vec2.XY() - Position2 - Velocity).Length();
        return num1 + num2 - num4;
      }
      Vector2 vector2_3 = Collision.TileCollision(Position1, Velocity, Width, Height);
      if (vector2_3 != Velocity)
        return num1 + vector2_3.Length();
    }
    return amount;
  }

  public static bool TryChangingSizeFromBottomCenter(
    Rectangle hitbox,
    int targetWidth,
    int targetHeight,
    out Rectangle changedHitbox)
  {
    changedHitbox = hitbox;
    int num1 = targetHeight - hitbox.Height;
    if (num1 > 0)
    {
      int num2 = (int) Collision.TileCollisionInStepsOf16(changedHitbox.TopLeft(), Vector2.UnitY, (float) num1, changedHitbox.Width, changedHitbox.Height);
      int val2 = (int) Collision.TileCollisionInStepsOf16(changedHitbox.TopLeft(), -Vector2.UnitY, (float) num1, changedHitbox.Width, changedHitbox.Height);
      if (val2 + num2 < num1)
        return false;
      int num3 = Math.Min(num1, val2);
      int num4 = 0;
      int val1_1 = num1 - num3 - num4;
      int num5 = num3 + Math.Min(val1_1, val2 - num3);
      int val1_2 = num1 - num5 - num4;
      int num6 = num4 + Math.Min(val1_2, num2 - num4);
      changedHitbox.Offset(0, -num5);
      changedHitbox.Height += num5 + num6;
    }
    else
    {
      changedHitbox.Offset(0, -num1);
      changedHitbox.Height = targetHeight;
    }
    int amount = targetWidth - hitbox.Width;
    if (amount > 0)
    {
      int val2 = (int) Collision.TileCollisionInStepsOf16(changedHitbox.TopLeft(), Vector2.UnitX, (float) amount, changedHitbox.Width, changedHitbox.Height);
      int val1_3 = (int) Collision.TileCollisionInStepsOf16(changedHitbox.TopLeft(), -Vector2.UnitX, (float) amount, changedHitbox.Width, changedHitbox.Height);
      if (val1_3 + val2 < amount)
        return false;
      int num7;
      int num8 = num7 = Math.Min(amount / 2, Math.Min(val1_3, val2));
      int val1_4 = amount - num7 - num8;
      int num9 = num7 + Math.Min(val1_4, val1_3 - num7);
      int val1_5 = amount - num9 - num8;
      int num10 = num8 + Math.Min(val1_5, val2 - num8);
      changedHitbox.Offset(-num9, 0);
      changedHitbox.Width += num9 + num10;
    }
    else
    {
      changedHitbox.Offset(amount / 2, 0);
      changedHitbox.Width = targetWidth;
    }
    return true;
  }

  public static bool IsClearSpotTest(
    Vector2 position,
    float testMagnitude,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    int gravDir = 1,
    bool checkCardinals = true,
    bool checkSlopes = false)
  {
    if (checkCardinals)
    {
      Vector2 Velocity1 = Vector2.UnitX * testMagnitude;
      if (Collision.TileCollision(position - Velocity1, Velocity1, Width, Height, fallThrough, fall2, gravDir) != Velocity1)
        return false;
      Vector2 Velocity2 = -Vector2.UnitX * testMagnitude;
      if (Collision.TileCollision(position - Velocity2, Velocity2, Width, Height, fallThrough, fall2, gravDir) != Velocity2)
        return false;
      Vector2 Velocity3 = Vector2.UnitY * testMagnitude;
      if (Collision.TileCollision(position - Velocity3, Velocity3, Width, Height, fallThrough, fall2, gravDir) != Velocity3)
        return false;
      Vector2 Velocity4 = -Vector2.UnitY * testMagnitude;
      if (Collision.TileCollision(position - Velocity4, Velocity4, Width, Height, fallThrough, fall2, gravDir) != Velocity4)
        return false;
    }
    if (checkSlopes)
    {
      Vector2 Velocity5 = Vector2.UnitX * testMagnitude;
      Vector4 vector4 = new Vector4(position, testMagnitude, 0.0f);
      if (Collision.SlopeCollision(position, Velocity5, Width, Height, (float) gravDir, fallThrough) != vector4)
        return false;
      Vector2 Velocity6 = -Vector2.UnitX * testMagnitude;
      vector4 = new Vector4(position, -testMagnitude, 0.0f);
      if (Collision.SlopeCollision(position, Velocity6, Width, Height, (float) gravDir, fallThrough) != vector4)
        return false;
      Vector2 Velocity7 = Vector2.UnitY * testMagnitude;
      vector4 = new Vector4(position, 0.0f, testMagnitude);
      if (Collision.SlopeCollision(position, Velocity7, Width, Height, (float) gravDir, fallThrough) != vector4)
        return false;
      Vector2 Velocity8 = -Vector2.UnitY * testMagnitude;
      vector4 = new Vector4(position, 0.0f, -testMagnitude);
      if (Collision.SlopeCollision(position, Velocity8, Width, Height, (float) gravDir, fallThrough) != vector4)
        return false;
    }
    return true;
  }

  public static List<Point> FindCollisionTile(
    int Direction,
    Vector2 position,
    float testMagnitude,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    int gravDir = 1,
    bool checkCardinals = true,
    bool checkSlopes = false)
  {
    List<Point> collisionTile = new List<Point>();
    Vector2 vector2_1;
    Vector2 vector2_2;
    switch (Direction)
    {
      case 0:
        vector2_1 = Vector2.UnitX * testMagnitude;
        break;
      case 1:
        vector2_1 = -Vector2.UnitX * testMagnitude;
        break;
      case 2:
        vector2_2 = Vector2.UnitY * testMagnitude;
        goto label_19;
      case 3:
        vector2_2 = -Vector2.UnitY * testMagnitude;
        goto label_19;
      default:
label_33:
        return collisionTile;
    }
    Vector2 Velocity1 = vector2_1;
    Vector4 vec1 = new Vector4(position, Velocity1.X, Velocity1.Y);
    int x = (int) ((double) position.X + (Direction == 0 ? (double) Width : 0.0)) / 16 /*0x10*/;
    float Height1 = Math.Min((float) (16.0 - (double) position.Y % 16.0), (float) Height);
    float num1 = Height1;
    if (checkCardinals && Collision.TileCollision(position - Velocity1, Velocity1, Width, (int) Height1, fallThrough, fall2, gravDir) != Velocity1)
      collisionTile.Add(new Point(x, (int) position.Y / 16 /*0x10*/));
    else if (checkSlopes && Collision.SlopeCollision(position, Velocity1, Width, (int) Height1, (float) gravDir, fallThrough).XZW() != vec1.XZW())
      collisionTile.Add(new Point(x, (int) position.Y / 16 /*0x10*/));
    for (; (double) num1 + 16.0 <= (double) (Height - 16 /*0x10*/); num1 += 16f)
    {
      if (checkCardinals && Collision.TileCollision(position - Velocity1 + Vector2.UnitY * num1, Velocity1, Width, 16 /*0x10*/, fallThrough, fall2, gravDir) != Velocity1)
        collisionTile.Add(new Point(x, (int) ((double) position.Y + (double) num1) / 16 /*0x10*/));
      else if (checkSlopes && Collision.SlopeCollision(position + Vector2.UnitY * num1, Velocity1, Width, 16 /*0x10*/, (float) gravDir, fallThrough).XZW() != vec1.XZW())
        collisionTile.Add(new Point(x, (int) ((double) position.Y + (double) num1) / 16 /*0x10*/));
    }
    int Height2 = Height - (int) num1;
    if (checkCardinals && Collision.TileCollision(position - Velocity1 + Vector2.UnitY * num1, Velocity1, Width, Height2, fallThrough, fall2, gravDir) != Velocity1)
    {
      collisionTile.Add(new Point(x, (int) ((double) position.Y + (double) num1) / 16 /*0x10*/));
      goto label_33;
    }
    if (checkSlopes && Collision.SlopeCollision(position + Vector2.UnitY * num1, Velocity1, Width, Height2, (float) gravDir, fallThrough).XZW() != vec1.XZW())
    {
      collisionTile.Add(new Point(x, (int) ((double) position.Y + (double) num1) / 16 /*0x10*/));
      goto label_33;
    }
    goto label_33;
label_19:
    Vector2 Velocity2 = vector2_2;
    Vector4 vec2 = new Vector4(position, Velocity2.X, Velocity2.Y);
    int y = (int) ((double) position.Y + (Direction == 2 ? (double) Height : 0.0)) / 16 /*0x10*/;
    float Width1 = Math.Min((float) (16.0 - (double) position.X % 16.0), (float) Width);
    float num2 = Width1;
    if (checkCardinals && Collision.TileCollision(position - Velocity2, Velocity2, (int) Width1, Height, fallThrough, fall2, gravDir) != Velocity2)
      collisionTile.Add(new Point((int) position.X / 16 /*0x10*/, y));
    else if (checkSlopes && Collision.SlopeCollision(position, Velocity2, (int) Width1, Height, (float) gravDir, fallThrough).YZW() != vec2.YZW())
      collisionTile.Add(new Point((int) position.X / 16 /*0x10*/, y));
    for (; (double) num2 + 16.0 <= (double) (Width - 16 /*0x10*/); num2 += 16f)
    {
      if (checkCardinals && Collision.TileCollision(position - Velocity2 + Vector2.UnitX * num2, Velocity2, 16 /*0x10*/, Height, fallThrough, fall2, gravDir) != Velocity2)
        collisionTile.Add(new Point((int) ((double) position.X + (double) num2) / 16 /*0x10*/, y));
      else if (checkSlopes && Collision.SlopeCollision(position + Vector2.UnitX * num2, Velocity2, 16 /*0x10*/, Height, (float) gravDir, fallThrough).YZW() != vec2.YZW())
        collisionTile.Add(new Point((int) ((double) position.X + (double) num2) / 16 /*0x10*/, y));
    }
    int Width2 = Width - (int) num2;
    if (checkCardinals && Collision.TileCollision(position - Velocity2 + Vector2.UnitX * num2, Velocity2, Width2, Height, fallThrough, fall2, gravDir) != Velocity2)
    {
      collisionTile.Add(new Point((int) ((double) position.X + (double) num2) / 16 /*0x10*/, y));
      goto label_33;
    }
    if (checkSlopes && Collision.SlopeCollision(position + Vector2.UnitX * num2, Velocity2, Width2, Height, (float) gravDir, fallThrough).YZW() != vec2.YZW())
    {
      collisionTile.Add(new Point((int) ((double) position.X + (double) num2) / 16 /*0x10*/, y));
      goto label_33;
    }
    goto label_33;
  }

  public static bool FindCollisionDirection(
    out int Direction,
    Vector2 position,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    int gravDir = 1)
  {
    Vector2 Velocity1 = Vector2.UnitX * 16f;
    if (Collision.TileCollision(position - Velocity1, Velocity1, Width, Height, fallThrough, fall2, gravDir) != Velocity1)
    {
      Direction = 0;
      return true;
    }
    Vector2 Velocity2 = -Vector2.UnitX * 16f;
    if (Collision.TileCollision(position - Velocity2, Velocity2, Width, Height, fallThrough, fall2, gravDir) != Velocity2)
    {
      Direction = 1;
      return true;
    }
    Vector2 Velocity3 = Vector2.UnitY * 16f;
    if (Collision.TileCollision(position - Velocity3, Velocity3, Width, Height, fallThrough, fall2, gravDir) != Velocity3)
    {
      Direction = 2;
      return true;
    }
    Vector2 Velocity4 = -Vector2.UnitY * 16f;
    if (Collision.TileCollision(position - Velocity4, Velocity4, Width, Height, fallThrough, fall2, gravDir) != Velocity4)
    {
      Direction = 3;
      return true;
    }
    Direction = -1;
    return false;
  }

  public static bool SolidCollision(Vector2 Position, int Width, int Height)
  {
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num5 = Utils.Clamp<int>(num1, 0, max);
    int num6 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    for (int index1 = num5; index1 < num6; ++index1)
    {
      for (int index2 = num7; index2 < num8; ++index2)
      {
        if (Main.tile[index1, index2] != null && !Main.tile[index1, index2].inActive() && Main.tile[index1, index2].active() && Main.tileSolid[(int) Main.tile[index1, index2].type] && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
        {
          Vector2 vector2;
          vector2.X = (float) (index1 * 16 /*0x10*/);
          vector2.Y = (float) (index2 * 16 /*0x10*/);
          int num9 = 16 /*0x10*/;
          if (Main.tile[index1, index2].halfBrick())
          {
            vector2.Y += 8f;
            num9 -= 8;
          }
          if ((double) Position.X + (double) Width > (double) vector2.X && (double) Position.X < (double) vector2.X + 16.0 && (double) Position.Y + (double) Height > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + (double) num9)
            return true;
        }
      }
    }
    return false;
  }

  public static bool SolidCollision(
    Vector2 Position,
    int Width,
    int Height,
    bool acceptTopSurfaces)
  {
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num5 = Utils.Clamp<int>(num1, 0, max);
    int num6 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    for (int index1 = num5; index1 < num6; ++index1)
    {
      for (int index2 = num7; index2 < num8; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.active() && !tile.inActive())
        {
          bool flag = Main.tileSolid[(int) tile.type] && !Main.tileSolidTop[(int) tile.type];
          if (acceptTopSurfaces)
          {
            if (TileID.Sets.Platforms[(int) tile.type])
              flag |= WorldGen.PlatformProperTopFrame(tile.frameX);
            else
              flag = ((flag ? 1 : 0) | (!Main.tileSolidTop[(int) tile.type] ? 0 : (tile.frameY == (short) 0 ? 1 : 0))) != 0;
          }
          if (flag)
          {
            Vector2 vector2;
            vector2.X = (float) (index1 * 16 /*0x10*/);
            vector2.Y = (float) (index2 * 16 /*0x10*/);
            int num9 = 16 /*0x10*/;
            if (tile.halfBrick())
            {
              vector2.Y += 8f;
              num9 -= 8;
            }
            if ((double) Position.X + (double) Width > (double) vector2.X && (double) Position.X < (double) vector2.X + 16.0 && (double) Position.Y + (double) Height > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + (double) num9)
              return true;
          }
        }
      }
    }
    return false;
  }

  public static Vector2 WaterCollision(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    bool lavaWalk = true)
  {
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Position + Velocity;
    Vector2 vector2_3 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int max = Main.maxTilesX - 1;
    int num5 = Utils.Clamp<int>(num1, 0, max);
    int num6 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num7 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    for (int index1 = num5; index1 < num6; ++index1)
    {
      for (int index2 = num7; index2 < num8; ++index2)
      {
        if (Main.tile[index1, index2] != null && Main.tile[index1, index2].liquid > (byte) 0 && Main.tile[index1, index2 - 1].liquid == (byte) 0 && (!Main.tile[index1, index2].lava() || lavaWalk))
        {
          int num9 = (int) Main.tile[index1, index2].liquid / 32 /*0x20*/ * 2 + 2;
          Vector2 vector2_4;
          vector2_4.X = (float) (index1 * 16 /*0x10*/);
          vector2_4.Y = (float) (index2 * 16 /*0x10*/ + 16 /*0x10*/ - num9);
          if ((double) vector2_2.X + (double) Width > (double) vector2_4.X && (double) vector2_2.X < (double) vector2_4.X + 16.0 && (double) vector2_2.Y + (double) Height > (double) vector2_4.Y && (double) vector2_2.Y < (double) vector2_4.Y + (double) num9 && (double) vector2_3.Y + (double) Height <= (double) vector2_4.Y && !fallThrough)
            vector2_1.Y = vector2_4.Y - (vector2_3.Y + (float) Height);
        }
      }
    }
    return vector2_1;
  }

  public static Vector2 AnyCollisionWithSpecificTiles(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool[] tilesWeCanCollideWithByType,
    bool evenActuated = false)
  {
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Velocity;
    Vector2 vector2_3 = Position + Velocity;
    Vector2 vector2_4 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int num5 = -1;
    int num6 = -1;
    int num7 = -1;
    int num8 = -1;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int index1 = num1; index1 < num2; ++index1)
    {
      for (int index2 = num3; index2 < num4; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.active() && (evenActuated || !tile.inActive()) && tilesWeCanCollideWithByType[(int) tile.type])
        {
          Vector2 vector2_5;
          vector2_5.X = (float) (index1 * 16 /*0x10*/);
          vector2_5.Y = (float) (index2 * 16 /*0x10*/);
          int num9 = 16 /*0x10*/;
          if (tile.halfBrick())
          {
            vector2_5.Y += 8f;
            num9 -= 8;
          }
          if ((double) vector2_3.X + (double) Width > (double) vector2_5.X && (double) vector2_3.X < (double) vector2_5.X + 16.0 && (double) vector2_3.Y + (double) Height > (double) vector2_5.Y && (double) vector2_3.Y < (double) vector2_5.Y + (double) num9)
          {
            if ((double) vector2_4.Y + (double) Height <= (double) vector2_5.Y)
            {
              num7 = index1;
              num8 = index2;
              if (num7 != num5)
                vector2_1.Y = vector2_5.Y - (vector2_4.Y + (float) Height);
            }
            else if ((double) vector2_4.X + (double) Width <= (double) vector2_5.X && !Main.tileSolidTop[(int) tile.type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X - (vector2_4.X + (float) Width);
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.X >= (double) vector2_5.X + 16.0 && !Main.tileSolidTop[(int) tile.type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X + 16f - vector2_4.X;
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.Y >= (double) vector2_5.Y + (double) num9 && !Main.tileSolidTop[(int) tile.type])
            {
              num7 = index1;
              num8 = index2;
              vector2_1.Y = (float) ((double) vector2_5.Y + (double) num9 - (double) vector2_4.Y + 0.0099999997764825821);
              if (num8 == num6)
                vector2_1.X = vector2_2.X + 0.01f;
            }
          }
        }
      }
    }
    return vector2_1;
  }

  public static Vector2 AnyCollision(
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool evenActuated = false)
  {
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Velocity;
    Vector2 vector2_3 = Position + Velocity;
    Vector2 vector2_4 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int num5 = -1;
    int num6 = -1;
    int num7 = -1;
    int num8 = -1;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int index1 = num1; index1 < num2; ++index1)
    {
      for (int index2 = num3; index2 < num4; ++index2)
      {
        if (Main.tile[index1, index2] != null && Main.tile[index1, index2].active() && (evenActuated || !Main.tile[index1, index2].inActive()))
        {
          Vector2 vector2_5;
          vector2_5.X = (float) (index1 * 16 /*0x10*/);
          vector2_5.Y = (float) (index2 * 16 /*0x10*/);
          int num9 = 16 /*0x10*/;
          if (Main.tile[index1, index2].halfBrick())
          {
            vector2_5.Y += 8f;
            num9 -= 8;
          }
          if ((double) vector2_3.X + (double) Width > (double) vector2_5.X && (double) vector2_3.X < (double) vector2_5.X + 16.0 && (double) vector2_3.Y + (double) Height > (double) vector2_5.Y && (double) vector2_3.Y < (double) vector2_5.Y + (double) num9)
          {
            if ((double) vector2_4.Y + (double) Height <= (double) vector2_5.Y)
            {
              num7 = index1;
              num8 = index2;
              if (num7 != num5)
                vector2_1.Y = vector2_5.Y - (vector2_4.Y + (float) Height);
            }
            else if ((double) vector2_4.X + (double) Width <= (double) vector2_5.X && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X - (vector2_4.X + (float) Width);
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.X >= (double) vector2_5.X + 16.0 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              num5 = index1;
              num6 = index2;
              if (num6 != num8)
                vector2_1.X = vector2_5.X + 16f - vector2_4.X;
              if (num7 == num5)
                vector2_1.Y = vector2_2.Y;
            }
            else if ((double) vector2_4.Y >= (double) vector2_5.Y + (double) num9 && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
            {
              num7 = index1;
              num8 = index2;
              vector2_1.Y = (float) ((double) vector2_5.Y + (double) num9 - (double) vector2_4.Y + 0.0099999997764825821);
              if (num8 == num6)
                vector2_1.X = vector2_2.X + 0.01f;
            }
          }
        }
      }
    }
    return vector2_1;
  }

  public static void HitTilesInACircle(Vector2 Position, Vector2 Velocity, int Width, int Height)
  {
    Vector2 vector2_1 = Position + Velocity;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int i = num1; i < num2; ++i)
    {
      for (int j = num3; j < num4; ++j)
      {
        if (Main.tile[i, j] != null && !Main.tile[i, j].inActive() && Main.tile[i, j].active() && (Main.tileSolid[(int) Main.tile[i, j].type] || Main.tileSolidTop[(int) Main.tile[i, j].type] && Main.tile[i, j].frameY == (short) 0))
        {
          Vector2 vector2_2;
          vector2_2.X = (float) (i * 16 /*0x10*/);
          vector2_2.Y = (float) (j * 16 /*0x10*/);
          int num5 = 16 /*0x10*/;
          if (Main.tile[i, j].halfBrick())
          {
            vector2_2.Y += 8f;
            num5 -= 8;
          }
          if ((double) vector2_1.X + (double) Width >= (double) vector2_2.X && (double) vector2_1.X <= (double) vector2_2.X + 16.0 && (double) vector2_1.Y + (double) Height >= (double) vector2_2.Y && (double) vector2_1.Y <= (double) vector2_2.Y + (double) num5 && (double) (new Vector2(vector2_1.X + (float) (Width / 2), vector2_1.Y + (float) (Height / 2)) - new Vector2(vector2_2.X + 8f, vector2_2.Y + 8f)).Length() < (double) ((Width + Height) / 4))
            WorldGen.KillTile(i, j, true, true);
        }
      }
    }
  }

  public static void HitTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
  {
    Vector2 vector2_1 = Position + Velocity;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int i = num1; i < num2; ++i)
    {
      for (int j = num3; j < num4; ++j)
      {
        if (Main.tile[i, j] != null && !Main.tile[i, j].inActive() && Main.tile[i, j].active() && (Main.tileSolid[(int) Main.tile[i, j].type] || Main.tileSolidTop[(int) Main.tile[i, j].type] && Main.tile[i, j].frameY == (short) 0))
        {
          Vector2 vector2_2;
          vector2_2.X = (float) (i * 16 /*0x10*/);
          vector2_2.Y = (float) (j * 16 /*0x10*/);
          int num5 = 16 /*0x10*/;
          if (Main.tile[i, j].halfBrick())
          {
            vector2_2.Y += 8f;
            num5 -= 8;
          }
          if ((double) vector2_1.X + (double) Width >= (double) vector2_2.X && (double) vector2_1.X <= (double) vector2_2.X + 16.0 && (double) vector2_1.Y + (double) Height >= (double) vector2_2.Y && (double) vector2_1.Y <= (double) vector2_2.Y + (double) num5)
            WorldGen.KillTile(i, j, true, true);
        }
      }
    }
  }

  public static bool AnyHurtingTiles(Vector2 Position, int Width, int Height)
  {
    return Collision.HurtTiles(Position, Width, Height, (Player) null).type >= 0;
  }

  public static Collision.HurtTile HurtTiles(
    Vector2 Position,
    int Width,
    int Height,
    Player player)
  {
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int i = num1; i < num2; ++i)
    {
      for (int j = num3; j < num4; ++j)
      {
        Tile tile = Main.tile[i, j];
        if (tile != null && !tile.inActive() && tile.active())
        {
          Vector2 vector2;
          vector2.X = (float) (i * 16 /*0x10*/);
          vector2.Y = (float) (j * 16 /*0x10*/);
          int num5 = 16 /*0x10*/;
          if (tile.halfBrick())
          {
            vector2.Y += 8f;
            num5 -= 8;
          }
          int num6 = 0;
          if (TileID.Sets.Suffocate[(int) tile.type])
            num6 = 2;
          if ((double) Position.X + (double) Width - (double) num6 >= (double) vector2.X && (double) Position.X + (double) num6 <= (double) vector2.X + 16.0 && (double) Position.Y + (double) Height - (double) num6 >= (double) vector2.Y - 0.5 && (double) Position.Y + (double) num6 <= (double) vector2.Y + (double) num5 + 0.5 && Collision.CanTileHurt(tile.type, i, j, player))
          {
            if (tile.slope() > (byte) 0)
            {
              if (num6 <= 0)
              {
                int num7 = 0;
                if (tile.rightSlope() && (double) Position.X > (double) vector2.X)
                  ++num7;
                if (tile.leftSlope() && (double) Position.X + (double) Width < (double) vector2.X + 16.0)
                  ++num7;
                if (tile.bottomSlope() && (double) Position.Y > (double) vector2.Y)
                  ++num7;
                if (tile.topSlope() && (double) Position.Y + (double) Height < (double) vector2.Y + (double) num5)
                  ++num7;
                if (num7 == 2)
                  continue;
              }
              else
                continue;
            }
            return new Collision.HurtTile()
            {
              type = (int) tile.type,
              x = i,
              y = j
            };
          }
        }
      }
    }
    return new Collision.HurtTile() { type = -1 };
  }

  public static bool CanTileHurt(ushort type, int i, int j, Player player)
  {
    return (type != (ushort) 230 || Main.getGoodWorld) && (type != (ushort) 80 /*0x50*/ || Main.dontStarveWorld) && (TileID.Sets.TouchDamageBleeding[(int) type] || TileID.Sets.Suffocate[(int) type] || TileID.Sets.TouchDamageImmediate[(int) type] > 0 || TileID.Sets.TouchDamageHot[(int) type] && (player == null || !player.fireWalk));
  }

  public static bool SwitchTiles(
    Entity entity,
    Vector2 Position,
    int Width,
    int Height,
    Vector2 oldPosition,
    int objType)
  {
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    for (int index1 = num1; index1 < num2; ++index1)
    {
      for (int index2 = num3; index2 < num4; ++index2)
      {
        if (Main.tile[index1, index2] != null)
        {
          int type = (int) Main.tile[index1, index2].type;
          if (Main.tile[index1, index2].active() && (type == 135 || type == 210 || type == 443 || type == 442))
          {
            Vector2 vector2;
            vector2.X = (float) (index1 * 16 /*0x10*/);
            vector2.Y = (float) (index2 * 16 /*0x10*/ + 12);
            bool flag1 = false;
            if (type == 442)
            {
              if (objType == 4)
              {
                float r1StartX = 0.0f;
                float r1StartY = 0.0f;
                float r1Width = 0.0f;
                float r1Height = 0.0f;
                switch ((int) Main.tile[index1, index2].frameX / 22)
                {
                  case 0:
                    r1StartX = (float) (index1 * 16 /*0x10*/);
                    r1StartY = (float) (index2 * 16 /*0x10*/ + 16 /*0x10*/ - 10);
                    r1Width = 16f;
                    r1Height = 10f;
                    break;
                  case 1:
                    r1StartX = (float) (index1 * 16 /*0x10*/);
                    r1StartY = (float) (index2 * 16 /*0x10*/);
                    r1Width = 16f;
                    r1Height = 10f;
                    break;
                  case 2:
                    r1StartX = (float) (index1 * 16 /*0x10*/);
                    r1StartY = (float) (index2 * 16 /*0x10*/);
                    r1Width = 10f;
                    r1Height = 16f;
                    break;
                  case 3:
                    r1StartX = (float) (index1 * 16 /*0x10*/ + 16 /*0x10*/ - 10);
                    r1StartY = (float) (index2 * 16 /*0x10*/);
                    r1Width = 10f;
                    r1Height = 16f;
                    break;
                }
                if (Utils.FloatIntersect(r1StartX, r1StartY, r1Width, r1Height, Position.X, Position.Y, (float) Width, (float) Height) && !Utils.FloatIntersect(r1StartX, r1StartY, r1Width, r1Height, oldPosition.X, oldPosition.Y, (float) Width, (float) Height))
                {
                  Wiring.HitSwitch(index1, index2);
                  NetMessage.SendData(59, number: index1, number2: (float) index2);
                  return true;
                }
              }
              flag1 = true;
            }
            if (!flag1 && (double) Position.X + (double) Width > (double) vector2.X && (double) Position.X < (double) vector2.X + 16.0 && (double) Position.Y + (double) Height > (double) vector2.Y && (double) Position.Y < (double) vector2.Y + 4.01 && ((double) oldPosition.X + (double) Width <= (double) vector2.X || (double) oldPosition.X >= (double) vector2.X + 16.0 || (double) oldPosition.Y + (double) Height <= (double) vector2.Y || (double) oldPosition.Y >= (double) vector2.Y + 16.01))
            {
              switch (type)
              {
                case 210:
                  Wiring.HitSwitch(index1, index2);
                  NetMessage.SendData(59, number: index1, number2: (float) index2);
                  continue;
                case 443:
                  if (objType == 1 || objType == 5)
                  {
                    Wiring.HitSwitch(index1, index2);
                    NetMessage.SendData(59, number: index1, number2: (float) index2);
                    continue;
                  }
                  continue;
                default:
                  int num5 = (int) Main.tile[index1, index2].frameY / 18;
                  bool flag2 = true;
                  if ((num5 == 4 || num5 == 2 || num5 == 3 || num5 == 6 || num5 == 7) && objType != 5)
                    flag2 = false;
                  if (num5 == 5 && (objType == 1 || objType == 4 || objType == 5))
                    flag2 = false;
                  if (flag2)
                  {
                    if (Main.netMode == 1 && objType == 5)
                      NetMessage.SendData(13, number: Main.myPlayer);
                    Wiring.HitSwitch(index1, index2);
                    NetMessage.SendData(59, number: index1, number2: (float) index2);
                    if (num5 == 7)
                    {
                      WorldGen.KillTile(index1, index2);
                      if (Main.netMode == 1)
                        NetMessage.SendData(17, number2: (float) index1, number3: (float) index2);
                    }
                    return true;
                  }
                  continue;
              }
            }
          }
        }
      }
    }
    return false;
  }

  public static Vector2 StickyTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
  {
    Vector2 vector2_1 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    if (num1 < 0)
      num1 = 0;
    if (num2 > Main.maxTilesX)
      num2 = Main.maxTilesX;
    if (num3 < 0)
      num3 = 0;
    if (num4 > Main.maxTilesY - 40)
      num4 = Main.maxTilesY - 40;
    Vector2 vector2_2;
    for (int x = num1; x < num2; ++x)
    {
      for (int y = num3; y < num4; ++y)
      {
        if (Main.tile[x, y] != null && Main.tile[x, y].active() && !Main.tile[x, y].inActive())
        {
          if (Main.tile[x, y].type == (ushort) 51)
          {
            int num5 = 0;
            vector2_2.X = (float) (x * 16 /*0x10*/);
            vector2_2.Y = (float) (y * 16 /*0x10*/);
            if ((double) vector2_1.X + (double) Width > (double) vector2_2.X - (double) num5 && (double) vector2_1.X < (double) vector2_2.X + 16.0 + (double) num5 && (double) vector2_1.Y + (double) Height > (double) vector2_2.Y && (double) vector2_1.Y < (double) vector2_2.Y + 16.01)
            {
              if (Main.tile[x, y].type == (ushort) 51 && (double) Math.Abs(Velocity.X) + (double) Math.Abs(Velocity.Y) > 0.7 && Main.rand.Next(30) == 0)
                Dust.NewDust(new Vector2((float) (x * 16 /*0x10*/), (float) (y * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 30);
              return new Vector2((float) x, (float) y);
            }
          }
          else if (Main.tile[x, y].type == (ushort) 229 && Main.tile[x, y].slope() == (byte) 0)
          {
            int num6 = 1;
            vector2_2.X = (float) (x * 16 /*0x10*/);
            vector2_2.Y = (float) (y * 16 /*0x10*/);
            float num7 = 16.01f;
            if (Main.tile[x, y].halfBrick())
            {
              vector2_2.Y += 8f;
              num7 -= 8f;
            }
            if ((double) vector2_1.X + (double) Width > (double) vector2_2.X - (double) num6 && (double) vector2_1.X < (double) vector2_2.X + 16.0 + (double) num6 && (double) vector2_1.Y + (double) Height > (double) vector2_2.Y && (double) vector2_1.Y < (double) vector2_2.Y + (double) num7)
            {
              if (Main.tile[x, y].type == (ushort) 51 && (double) Math.Abs(Velocity.X) + (double) Math.Abs(Velocity.Y) > 0.7 && Main.rand.Next(30) == 0)
                Dust.NewDust(new Vector2((float) (x * 16 /*0x10*/), (float) (y * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 30);
              return new Vector2((float) x, (float) y);
            }
          }
        }
      }
    }
    return new Vector2(-1f, -1f);
  }

  public static bool SolidTilesVersatile(int startX, int endX, int startY, int endY)
  {
    if (startX > endX)
      Utils.Swap<int>(ref startX, ref endX);
    if (startY > endY)
      Utils.Swap<int>(ref startY, ref endY);
    return Collision.SolidTiles(startX, endX, startY, endY);
  }

  public static bool SolidTiles(Vector2 position, int width, int height)
  {
    return Collision.SolidTiles((int) ((double) position.X / 16.0), (int) (((double) position.X + (double) width) / 16.0), (int) ((double) position.Y / 16.0), (int) (((double) position.Y + (double) height) / 16.0));
  }

  public static bool SolidTiles(int startX, int endX, int startY, int endY)
  {
    if (startX < 0 || endX >= Main.maxTilesX || startY < 0 || endY >= Main.maxTilesY - 40)
      return true;
    for (int index1 = startX; index1 < endX + 1; ++index1)
    {
      for (int index2 = startY; index2 < endY + 1; ++index2)
      {
        if (Main.tile[index1, index2] == null)
          return false;
        if (Main.tile[index1, index2].active() && !Main.tile[index1, index2].inActive() && Main.tileSolid[(int) Main.tile[index1, index2].type] && !Main.tileSolidTop[(int) Main.tile[index1, index2].type])
          return true;
      }
    }
    return false;
  }

  public static bool SolidTiles(Vector2 position, int width, int height, bool allowTopSurfaces)
  {
    return Collision.SolidTiles((int) ((double) position.X / 16.0), (int) (((double) position.X + (double) width) / 16.0), (int) ((double) position.Y / 16.0), (int) (((double) position.Y + (double) height) / 16.0), allowTopSurfaces);
  }

  public static bool SolidTiles(
    int startX,
    int endX,
    int startY,
    int endY,
    bool allowTopSurfaces)
  {
    if (startX < 0 || endX >= Main.maxTilesX || startY < 0 || endY >= Main.maxTilesY - 40)
      return true;
    for (int index1 = startX; index1 < endX + 1; ++index1)
    {
      for (int index2 = startY; index2 < endY + 1; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile == null)
          return false;
        if (tile.active() && !Main.tile[index1, index2].inActive())
        {
          ushort type = tile.type;
          bool flag = Main.tileSolid[(int) type] && !Main.tileSolidTop[(int) type];
          if (allowTopSurfaces)
            flag = ((flag ? 1 : 0) | (!Main.tileSolidTop[(int) type] ? 0 : (tile.frameY == (short) 0 ? 1 : 0))) != 0;
          if (flag)
            return true;
        }
      }
    }
    return false;
  }

  public static bool SolidFullTiles(Vector2 pos, Vector2 size)
  {
    int val1_1 = (int) ((double) pos.X / 16.0);
    int val1_2 = (int) ((double) pos.Y / 16.0);
    int val1_3 = (int) Math.Ceiling(((double) pos.X + (double) size.X) / 16.0);
    int val1_4 = (int) Math.Ceiling(((double) pos.Y + (double) size.Y) / 16.0);
    int num1 = Math.Max(val1_1, 0);
    int num2 = Math.Max(val1_2, 0);
    int num3 = Math.Min(val1_3, Main.maxTilesX - 1);
    int num4 = Math.Min(val1_4, Main.maxTilesY - 1);
    for (int index1 = num1; index1 < num3; ++index1)
    {
      for (int index2 = num2; index2 < num4; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.nactive() && tile.blockType() == 0 && Main.tileSolid[(int) tile.type] && !Main.tileSolidTop[(int) tile.type])
          return true;
      }
    }
    return false;
  }

  public static void StepDown(
    ref Vector2 position,
    ref Vector2 velocity,
    int width,
    int height,
    ref float stepSpeed,
    ref float gfxOffY,
    int gravDir = 1,
    bool waterWalk = false)
  {
    Vector2 vector2 = position;
    vector2.X += velocity.X;
    vector2.Y = (float) Math.Floor(((double) vector2.Y + (double) height) / 16.0) * 16f - (float) height;
    bool flag = false;
    int num1 = (int) ((double) vector2.X / 16.0);
    int num2 = (int) (((double) vector2.X + (double) width) / 16.0);
    int num3 = (int) (((double) vector2.Y + (double) height + 4.0) / 16.0);
    int num4 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
    float num5 = (float) ((num3 + num4) * 16 /*0x10*/);
    float num6 = (float) ((double) Main.bottomWorld / 16.0 - 42.0);
    for (int x = num1; x <= num2; ++x)
    {
      for (int y = num3; y <= num3 + 1; ++y)
      {
        if (WorldGen.InWorld(x, y, 1))
        {
          if (Main.tile[x, y] == null)
            Main.tile[x, y] = new Tile();
          if (Main.tile[x, y - 1] == null)
            Main.tile[x, y - 1] = new Tile();
          if (waterWalk && Main.tile[x, y].liquid > (byte) 0 && Main.tile[x, y - 1].liquid == (byte) 0)
          {
            int num7 = (int) Main.tile[x, y].liquid / 32 /*0x20*/ * 2 + 2;
            int num8 = y * 16 /*0x10*/ + 16 /*0x10*/ - num7;
            if (new Rectangle(x * 16 /*0x10*/, y * 16 /*0x10*/ - 17, 16 /*0x10*/, 16 /*0x10*/).Intersects(new Rectangle((int) position.X, (int) position.Y, width, height)) && (double) num8 < (double) num5)
              num5 = (float) num8;
          }
          if ((double) y >= (double) num6 || Main.tile[x, y].nactive() && (Main.tileSolid[(int) Main.tile[x, y].type] || Main.tileSolidTop[(int) Main.tile[x, y].type]))
          {
            int num9 = y * 16 /*0x10*/;
            if (Main.tile[x, y].halfBrick())
              num9 += 8;
            if (Utils.FloatIntersect((float) (x * 16 /*0x10*/), (float) (y * 16 /*0x10*/ - 17), 16f, 16f, position.X, position.Y, (float) width, (float) height) && (double) num9 < (double) num5)
              num5 = (float) num9;
          }
        }
      }
    }
    float num10 = num5 - (position.Y + (float) height);
    if ((double) num10 <= 7.0 || (double) num10 >= 17.0 || flag)
      return;
    stepSpeed = 1.5f;
    if ((double) num10 > 9.0)
      stepSpeed = 2.5f;
    gfxOffY += position.Y + (float) height - num5;
    position.Y = num5 - (float) height;
  }

  public static void StepUp(
    ref Vector2 position,
    ref Vector2 velocity,
    int width,
    int height,
    ref float stepSpeed,
    ref float gfxOffY,
    int gravDir = 1,
    bool holdsMatching = false,
    int specialChecksMode = 0)
  {
    int num1 = 0;
    if ((double) velocity.X < 0.0)
      num1 = -1;
    if ((double) velocity.X > 0.0)
      num1 = 1;
    Vector2 vector2 = position;
    vector2.X += velocity.X;
    int x = (int) (((double) vector2.X + (double) (width / 2) + (double) ((width / 2 + 1) * num1)) / 16.0);
    int y = (int) (((double) vector2.Y + 0.1) / 16.0);
    if (gravDir == 1)
      y = (int) (((double) vector2.Y + (double) height - 1.0) / 16.0);
    int num2 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
    if (!WorldGen.InWorld(x, y, 1) || y >= Main.maxTilesY - 40)
      return;
    bool flag1 = true;
    bool flag2 = true;
    if (Main.tile[x, y] == null)
      return;
    for (int index = 1; index < num2 + 2; ++index)
    {
      if (!WorldGen.InWorld(x, y - index * gravDir) || Main.tile[x, y - index * gravDir] == null)
        return;
    }
    if (!WorldGen.InWorld(x - num1, y - num2 * gravDir) || Main.tile[x - num1, y - num2 * gravDir] == null)
      return;
    for (int index = 2; index < num2 + 1; ++index)
    {
      if (!WorldGen.InWorld(x, y - index * gravDir) || Main.tile[x, y - index * gravDir] == null)
        return;
      Tile tile = Main.tile[x, y - index * gravDir];
      flag1 = flag1 && (!tile.nactive() || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type]);
    }
    Tile tile1 = Main.tile[x - num1, y - num2 * gravDir];
    bool flag3 = flag2 && (!tile1.nactive() || !Main.tileSolid[(int) tile1.type] || Main.tileSolidTop[(int) tile1.type]);
    bool flag4 = true;
    bool flag5 = true;
    bool flag6 = true;
    bool flag7;
    Tile tile2;
    bool flag8;
    if (gravDir == 1)
    {
      if (Main.tile[x, y - gravDir] == null || Main.tile[x, y - (num2 + 1) * gravDir] == null)
        return;
      Tile tile3 = Main.tile[x, y - gravDir];
      Tile tile4 = Main.tile[x, y - (num2 + 1) * gravDir];
      flag7 = flag4 && (!tile3.nactive() || !Main.tileSolid[(int) tile3.type] || Main.tileSolidTop[(int) tile3.type] || tile3.slope() == (byte) 1 && (double) position.X + (double) (width / 2) > (double) (x * 16 /*0x10*/) || tile3.slope() == (byte) 2 && (double) position.X + (double) (width / 2) < (double) (x * 16 /*0x10*/ + 16 /*0x10*/) || tile3.halfBrick() && (!tile4.nactive() || !Main.tileSolid[(int) tile4.type] || Main.tileSolidTop[(int) tile4.type]));
      Tile tile5 = Main.tile[x, y];
      tile2 = Main.tile[x, y - 1];
      if (specialChecksMode == 1)
        flag6 = !TileID.Sets.IgnoredByNpcStepUp[(int) tile5.type];
      flag8 = ((!flag5 ? (false ? 1 : 0) : (!tile5.nactive() || tile5.topSlope() && (tile5.slope() != (byte) 1 || (double) position.X + (double) (width / 2) >= (double) (x * 16 /*0x10*/)) && (tile5.slope() != (byte) 2 || (double) position.X + (double) (width / 2) <= (double) (x * 16 /*0x10*/ + 16 /*0x10*/)) || tile5.topSlope() && (double) position.Y + (double) height <= (double) (y * 16 /*0x10*/) || (!Main.tileSolid[(int) tile5.type] || Main.tileSolidTop[(int) tile5.type]) && ((!holdsMatching || (!Main.tileSolidTop[(int) tile5.type] || tile5.frameY != (short) 0) && !TileID.Sets.Platforms[(int) tile5.type] && tile5.type != (ushort) 380 ? 0 : (!Main.tileSolid[(int) tile2.type] ? 1 : (!tile2.nactive() ? 1 : 0))) & (flag6 ? 1 : 0)) == 0 ? (!tile2.halfBrick() ? (false ? 1 : 0) : (tile2.nactive() ? 1 : 0)) : (true ? 1 : 0))) & (!Main.tileSolidTop[(int) tile5.type] ? 1 : (!Main.tileSolidTop[(int) tile2.type] ? 1 : 0))) != 0;
    }
    else
    {
      Tile tile6 = Main.tile[x, y - gravDir];
      Tile tile7 = Main.tile[x, y - (num2 + 1) * gravDir];
      flag7 = flag4 && (!tile6.nactive() || !Main.tileSolid[(int) tile6.type] || Main.tileSolidTop[(int) tile6.type] || tile6.slope() != (byte) 0 || tile6.halfBrick() && (!tile7.nactive() || !Main.tileSolid[(int) tile7.type] || Main.tileSolidTop[(int) tile7.type]));
      Tile tile8 = Main.tile[x, y];
      tile2 = Main.tile[x, y + 1];
      flag8 = flag5 && (tile8.nactive() && (Main.tileSolid[(int) tile8.type] && !Main.tileSolidTop[(int) tile8.type] || holdsMatching && Main.tileSolidTop[(int) tile8.type] && tile8.frameY == (short) 0 && (!Main.tileSolid[(int) tile2.type] || !tile2.nactive())) || tile2.halfBrick() && tile2.nactive());
    }
    if ((double) (x * 16 /*0x10*/) >= (double) vector2.X + (double) width || (double) (x * 16 /*0x10*/ + 16 /*0x10*/) <= (double) vector2.X)
      return;
    if (gravDir == 1)
    {
      if (!(flag8 & flag7 & flag1 & flag3))
        return;
      float num3 = (float) (y * 16 /*0x10*/);
      if (Main.tile[x, y - 1].halfBrick())
        num3 -= 8f;
      else if (Main.tile[x, y].halfBrick())
        num3 += 8f;
      if ((double) num3 >= (double) vector2.Y + (double) height)
        return;
      float num4 = vector2.Y + (float) height - num3;
      if ((double) num4 > 16.1)
        return;
      gfxOffY += position.Y + (float) height - num3;
      position.Y = num3 - (float) height;
      if ((double) num4 < 9.0)
        stepSpeed = 1f;
      else
        stepSpeed = 2f;
    }
    else
    {
      if (!(flag8 & flag7 & flag1 & flag3) || Main.tile[x, y].bottomSlope() || TileID.Sets.Platforms[(int) tile2.type])
        return;
      float num5 = (float) (y * 16 /*0x10*/ + 16 /*0x10*/);
      if ((double) num5 <= (double) vector2.Y)
        return;
      float num6 = num5 - vector2.Y;
      if ((double) num6 > 16.1)
        return;
      gfxOffY -= num5 - position.Y;
      position.Y = num5;
      velocity.Y = 0.0f;
      if ((double) num6 < 9.0)
        stepSpeed = 1f;
      else
        stepSpeed = 2f;
    }
  }

  public static bool InTileBounds(int x, int y, int lx, int ly, int hx, int hy)
  {
    return x >= lx && x <= hx && y >= ly && y <= hy;
  }

  public static float GetTileRotation(Vector2 position)
  {
    float num1 = position.Y % 16f;
    int index1 = (int) ((double) position.X / 16.0);
    int index2 = (int) ((double) position.Y / 16.0);
    Tile tile = Main.tile[index1, index2];
    bool flag = false;
    for (int index3 = 2; index3 >= 0; --index3)
    {
      if (tile.active())
      {
        if (Main.tileSolid[(int) tile.type])
        {
          int num2 = tile.blockType();
          if (tile.type == (ushort) 19)
          {
            int num3 = (int) tile.frameX / 18;
            if ((num3 >= 0 && num3 <= 7 || num3 >= 12 && num3 <= 16 /*0x10*/) && (double) num1 == 0.0 | flag)
              return 0.0f;
            switch (num3)
            {
              case 8:
              case 19:
              case 21:
              case 23:
                return -0.7853982f;
              case 10:
              case 20:
              case 22:
              case 24:
                return 0.7853982f;
              case 25:
              case 26:
                if (flag)
                  return 0.0f;
                if (num2 == 2)
                  return 0.7853982f;
                if (num2 == 3)
                  return -0.7853982f;
                break;
            }
          }
          else
          {
            if (num2 == 1)
              return 0.0f;
            if (num2 == 2)
              return 0.7853982f;
            return num2 == 3 ? -0.7853982f : 0.0f;
          }
        }
        else if (((!Main.tileSolidTop[(int) tile.type] ? 0 : (tile.frameY == (short) 0 ? 1 : 0)) & (flag ? 1 : 0)) != 0)
          return 0.0f;
      }
      ++index2;
      tile = Main.tile[index1, index2];
      flag = true;
    }
    return 0.0f;
  }

  public static void GetEntityEdgeTiles(
    List<Point> p,
    Entity entity,
    bool left = true,
    bool right = true,
    bool up = true,
    bool down = true)
  {
    int x1 = (int) entity.position.X;
    int y1 = (int) entity.position.Y;
    int num1 = x1 % 16 /*0x10*/;
    int num2 = y1 % 16 /*0x10*/;
    int x2 = (int) entity.Right.X;
    int y2 = (int) entity.Bottom.Y;
    if (x1 % 16 /*0x10*/ == 0)
      --x1;
    if (y1 % 16 /*0x10*/ == 0)
      --y1;
    if (x2 % 16 /*0x10*/ == 0)
      ++x2;
    if (y2 % 16 /*0x10*/ == 0)
      ++y2;
    int num3 = x2 / 16 /*0x10*/ - x1 / 16 /*0x10*/;
    int num4 = y2 / 16 /*0x10*/ - y1 / 16 /*0x10*/;
    int x3 = x1 / 16 /*0x10*/;
    int y3 = y1 / 16 /*0x10*/;
    for (int x4 = x3; x4 <= x3 + num3; ++x4)
    {
      if (up)
        p.Add(new Point(x4, y3));
      if (down)
        p.Add(new Point(x4, y3 + num4));
    }
    for (int y4 = y3; y4 < y3 + num4; ++y4)
    {
      if (left)
        p.Add(new Point(x3, y4));
      if (right)
        p.Add(new Point(x3 + num3, y4));
    }
  }

  public static bool ApplyConveyorBeltMovementToVelocity(WorldItem item, ref Vector2 velocity)
  {
    bool velocity1 = false;
    Collision.BuildTileContacts(item.position, item.width, item.height, Collision.contacts);
    if (Collision.contacts.Count > 0)
    {
      int index1 = -1;
      int index2 = -1;
      bool flag1 = false;
      Collision.TileContactSide tileContactSide1 = Collision.TileContactSide.Top;
      Collision.TileContactSide tileContactSide2 = Collision.TileContactSide.Top;
      Vector2 zero = Vector2.Zero;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      for (int index3 = 0; index3 < Collision.contacts.Count; ++index3)
      {
        int num1 = TileID.Sets.ConveyorDirection[Collision.contacts[index3].Type];
        switch (Collision.contacts[index3].Side)
        {
          case Collision.TileContactSide.Left:
            zero.Y += (float) (num1 * Collision.contacts[index3].Overlap);
            flag2 |= num1 != 0;
            break;
          case Collision.TileContactSide.Right:
            zero.Y += (float) (-num1 * Collision.contacts[index3].Overlap);
            flag2 |= num1 != 0;
            break;
          case Collision.TileContactSide.Top:
            zero.X += (float) (-num1 * Collision.contacts[index3].Overlap);
            flag3 = num1 != 0;
            break;
          case Collision.TileContactSide.Bottom:
            flag4 = true;
            zero.X += (float) (num1 * Collision.contacts[index3].Overlap);
            flag3 = num1 != 0;
            if (Collision.contacts[index3].Slope == 1)
            {
              if ((double) (Collision.contacts[index3].X * 16 /*0x10*/) < (double) item.position.X)
              {
                Tile tile = Main.tile[Collision.contacts[index3].X, Collision.contacts[index3].Y - 1];
                if (tile != null && tile.active() && tile.slope() == (byte) 3)
                {
                  index2 = index3;
                  break;
                }
                break;
              }
              break;
            }
            if (Collision.contacts[index3].Slope == 2 && (double) (Collision.contacts[index3].X * 16 /*0x10*/ + 16 /*0x10*/) > (double) item.Right.X)
            {
              Tile tile = Main.tile[Collision.contacts[index3].X, Collision.contacts[index3].Y - 1];
              if (tile != null && tile.active() && tile.slope() == (byte) 4)
              {
                index1 = index3;
                break;
              }
              break;
            }
            break;
          case Collision.TileContactSide.BottomLeft:
            if (num1 == -1)
            {
              int x = Collision.contacts[index3].X;
              int y = Collision.contacts[index3].Y;
              Tile tile = Main.tile[x, y - 1];
              byte num2 = tile.slope();
              if (!tile.active() || num2 == (byte) 1 && TileID.Sets.ConveyorDirection[(int) tile.type] == -1)
              {
                tileContactSide1 = Collision.TileContactSide.BottomLeft;
                flag1 = Main.tile[x, y].halfBrick();
              }
            }
            if (num1 == 1)
            {
              tileContactSide2 = Collision.TileContactSide.BottomLeft;
              break;
            }
            break;
          case Collision.TileContactSide.BottomRight:
            if (num1 == 1)
            {
              int x = Collision.contacts[index3].X;
              int y = Collision.contacts[index3].Y;
              Tile tile = Main.tile[x, y - 1];
              byte num3 = tile.slope();
              if (!tile.active() || num3 == (byte) 2 && TileID.Sets.ConveyorDirection[(int) tile.type] == 1)
              {
                tileContactSide1 = Collision.TileContactSide.BottomRight;
                flag1 = Main.tile[x, y].halfBrick();
              }
            }
            if (num1 == -1)
            {
              tileContactSide2 = Collision.TileContactSide.BottomRight;
              break;
            }
            break;
        }
      }
      if ((double) zero.X < 0.0)
        zero.X = (double) zero.X >= -8.0 ? ((double) zero.X >= -4.0 ? -0.75f : -1.25f) : -2.5f;
      else if ((double) zero.X > 0.0)
        zero.X = (double) zero.X <= 8.0 ? ((double) zero.X <= 4.0 ? 0.75f : 1.25f) : 2.5f;
      if ((double) zero.Y < 0.0)
        zero.Y = (double) zero.Y >= 8.0 ? -1.25f : -2.5f;
      else if ((double) zero.Y > 0.0)
        zero.Y = (double) zero.Y <= 8.0 ? 1.25f : 2.5f;
      else if (flag2 && (double) velocity.Y <= 1.0)
        velocity.Y = 0.0f;
      if ((double) zero.Y == 0.0)
      {
        if ((double) velocity.Y < 0.10999999940395355 && tileContactSide1 != Collision.TileContactSide.Top && !flag4)
        {
          if (tileContactSide1 == Collision.TileContactSide.BottomLeft)
          {
            velocity1 = true;
            Vector2 bottom = item.Bottom;
            int num = ((int) bottom.Y + 8) / 16 /*0x10*/ * 16 /*0x10*/;
            if (flag1)
              num += 8;
            bottom.Y = (float) num;
            item.Bottom = bottom;
            velocity.Y = 0.0f;
            velocity.X = -1.25f;
            zero.X = -2.5f;
          }
          if (tileContactSide1 == Collision.TileContactSide.BottomRight)
          {
            velocity1 = true;
            Vector2 bottom = item.Bottom;
            int num = ((int) bottom.Y + 8) / 16 /*0x10*/ * 16 /*0x10*/;
            if (flag1)
              num += 8;
            bottom.Y = (float) num;
            item.Bottom = bottom;
            velocity.Y = 0.0f;
            velocity.X = 1.25f;
            zero.X = 2.5f;
          }
        }
        else if ((double) velocity.Y < 0.3 && !flag4)
        {
          switch (tileContactSide2)
          {
            case Collision.TileContactSide.BottomLeft:
              if ((double) velocity.X >= -0.75 && (double) velocity.X <= 2.5 && !flag2)
              {
                velocity1 = true;
                Vector2 right = item.Right;
                int num = ((int) right.X + 8) / 16 /*0x10*/ * 16 /*0x10*/;
                right.X = (float) num;
                item.Right = right;
                velocity.X = 0.0f;
                velocity.Y = 0.75f;
                zero.Y = 2.5f;
                break;
              }
              break;
            case Collision.TileContactSide.BottomRight:
              if ((double) velocity.X <= 0.75 && (double) velocity.X >= -2.5 && !flag2)
              {
                velocity1 = true;
                int num = ((int) item.position.X + 8) / 16 /*0x10*/ * 16 /*0x10*/;
                item.position.X = (float) num;
                velocity.X = 0.0f;
                velocity.Y = 0.75f;
                zero.Y = 2.5f;
                break;
              }
              break;
          }
        }
      }
      velocity1 |= flag3 | flag2;
      if ((double) zero.Y < 0.0)
        velocity.Y = Math.Max(velocity.Y + (float) ((double) zero.Y * 6.0 / 60.0), zero.Y);
      else if ((double) zero.Y > 0.0)
        velocity.Y = Math.Min(velocity.Y + (float) ((double) zero.Y * 6.0 / 60.0), zero.Y);
      if ((double) zero.X < 0.0 && (double) velocity.X > (double) zero.X)
        velocity.X = Math.Max(velocity.X + (float) ((double) zero.X * 6.0 / 60.0), zero.X);
      if ((double) zero.X > 0.0 && (double) velocity.X < (double) zero.X)
        velocity.X = Math.Min(velocity.X + (float) ((double) zero.X * 6.0 / 60.0), zero.X);
      if (index1 != -1 && (double) velocity.X > 0.0)
      {
        int num = Collision.contacts[index1].X * 16 /*0x10*/ + Math.Max(16 /*0x10*/ - item.height / 2, 0);
        Vector2 right = item.Right;
        if ((double) right.X + (double) velocity.X > (double) num)
        {
          if ((double) right.X >= (double) num)
          {
            right.X = (float) num;
            velocity.X = 0.0f;
            item.Right = right;
          }
          else
            velocity.X = (float) num - right.X;
        }
      }
      if (index2 != -1 && (double) velocity.X < 0.0)
      {
        int num = Collision.contacts[index2].X * 16 /*0x10*/ + Math.Min(item.height / 2, 16 /*0x10*/);
        Vector2 position = item.position;
        if ((double) position.X + (double) velocity.X < (double) num)
        {
          if ((double) position.X <= (double) num)
          {
            position.X = (float) num;
            velocity.X = 0.0f;
            item.position = position;
          }
          else
            velocity.X = (float) num - position.X;
        }
      }
    }
    return velocity1;
  }

  public static void StepConveyorBelt(Entity entity, float gravDir, bool artificialRising = false)
  {
    Player player = (Player) null;
    if (entity is Player)
    {
      player = (Player) entity;
      if ((double) Math.Abs(player.gfxOffY) > 2.0 || player.grapCount > 0 || player.pulley)
        return;
      entity.height -= 5;
      entity.position.Y += 5f;
    }
    int num1 = 0;
    int num2 = 0;
    bool flag = false;
    int num3 = (int) entity.position.Y + entity.height;
    entity.Hitbox.Inflate(2, 2);
    Vector2 topLeft = entity.TopLeft;
    Vector2 topRight = entity.TopRight;
    Vector2 bottomLeft = entity.BottomLeft;
    Vector2 bottomRight = entity.BottomRight;
    List<Point> forConveyorBelts = Collision._cacheForConveyorBelts;
    forConveyorBelts.Clear();
    Collision.GetEntityEdgeTiles(forConveyorBelts, entity, false, false);
    Vector2 vector2_1 = new Vector2(0.0001f);
    for (int index = 0; index < forConveyorBelts.Count; ++index)
    {
      Point point = forConveyorBelts[index];
      if (WorldGen.InWorld(point.X, point.Y) && (player == null || !player.onTrack || point.Y >= num3))
      {
        Tile tile = Main.tile[point.X, point.Y];
        if (tile != null && tile.active() && tile.nactive())
        {
          int num4 = TileID.Sets.ConveyorDirection[(int) tile.type];
          if (num4 != 0)
          {
            Vector2 lineStart1;
            Vector2 lineStart2;
            lineStart1.X = lineStart2.X = (float) (point.X * 16 /*0x10*/);
            Vector2 lineEnd1;
            Vector2 lineEnd2;
            lineEnd1.X = lineEnd2.X = (float) (point.X * 16 /*0x10*/ + 16 /*0x10*/);
            switch (tile.slope())
            {
              case 1:
                lineStart2.Y = (float) (point.Y * 16 /*0x10*/);
                lineEnd2.Y = lineEnd1.Y = lineStart1.Y = (float) (point.Y * 16 /*0x10*/ + 16 /*0x10*/);
                break;
              case 2:
                lineEnd2.Y = (float) (point.Y * 16 /*0x10*/);
                lineStart2.Y = lineEnd1.Y = lineStart1.Y = (float) (point.Y * 16 /*0x10*/ + 16 /*0x10*/);
                break;
              case 3:
                lineEnd1.Y = lineStart2.Y = lineEnd2.Y = (float) (point.Y * 16 /*0x10*/);
                lineStart1.Y = (float) (point.Y * 16 /*0x10*/ + 16 /*0x10*/);
                break;
              case 4:
                lineStart1.Y = lineStart2.Y = lineEnd2.Y = (float) (point.Y * 16 /*0x10*/);
                lineEnd1.Y = (float) (point.Y * 16 /*0x10*/ + 16 /*0x10*/);
                break;
              default:
                lineStart2.Y = !tile.halfBrick() ? (lineEnd2.Y = (float) (point.Y * 16 /*0x10*/)) : (lineEnd2.Y = (float) (point.Y * 16 /*0x10*/ + 8));
                lineStart1.Y = lineEnd1.Y = (float) (point.Y * 16 /*0x10*/ + 16 /*0x10*/);
                break;
            }
            int num5 = 0;
            if (!TileID.Sets.Platforms[(int) tile.type] && Collision.CheckAABBvLineCollision2(entity.position - vector2_1, entity.Size + vector2_1 * 2f, lineStart1, lineEnd1))
              --num5;
            if (Collision.CheckAABBvLineCollision2(entity.position - vector2_1, entity.Size + vector2_1 * 2f, lineStart2, lineEnd2))
              ++num5;
            if (num5 != 0)
            {
              flag = true;
              num1 += num4 * num5 * (int) gravDir;
              if (tile.leftSlope())
                num2 += (int) gravDir * -num4;
              if (tile.rightSlope())
                num2 -= (int) gravDir * -num4;
            }
          }
        }
      }
    }
    if (entity is Player)
    {
      entity.height += 5;
      entity.position.Y -= 5f;
    }
    if (!flag)
      return;
    if (artificialRising)
      num2 = -1;
    if (!(num1 != 0 | artificialRising))
      return;
    int x = Math.Sign(num1);
    int y = Math.Sign(num2);
    Vector2 Velocity = Vector2.Normalize(new Vector2((float) x * gravDir, (float) y)) * 2.5f;
    Vector2 vector2_2 = Collision.TileCollision(entity.position, Velocity, entity.width, entity.height, gravDir: (int) gravDir);
    entity.position += vector2_2;
    if (!artificialRising)
    {
      Velocity = new Vector2(0.0f, 2.5f * gravDir);
      Vector2 vector2_3 = Collision.TileCollision(entity.position, Velocity, entity.width, entity.height, gravDir: (int) gravDir);
      entity.position += vector2_3;
    }
    if (!artificialRising)
      return;
    Velocity = new Vector2((float) x, (float) y);
    Vector2 vector2_4 = Collision.TileCollision(entity.position - Velocity, Velocity, entity.width, entity.height, gravDir: (int) gravDir);
    entity.position += vector2_4;
  }

  public static bool TryFindingConveyorBeltRising(Entity entity, float gravDir)
  {
    if (!(entity is WorldItem))
      return false;
    Point tileCoordinates1 = (entity.BottomLeft + new Vector2(-0.5f, -0.01f)).ToTileCoordinates();
    float num1 = 0.0f;
    if (WorldGen.InWorld(tileCoordinates1))
    {
      Tile tile = Main.tile[tileCoordinates1.X, tileCoordinates1.Y];
      if (tile != null && tile.active() && tile.nactive() && tile.slope() == (byte) 0)
      {
        int num2 = TileID.Sets.ConveyorDirection[(int) tile.type];
        num1 += (float) num2 * gravDir;
      }
    }
    Point tileCoordinates2 = (entity.BottomRight + new Vector2(0.5f, -0.01f)).ToTileCoordinates();
    if (WorldGen.InWorld(tileCoordinates2))
    {
      Tile tile = Main.tile[tileCoordinates2.X, tileCoordinates2.Y];
      if (tile != null && tile.active() && tile.nactive() && tile.slope() == (byte) 0)
      {
        int num3 = TileID.Sets.ConveyorDirection[(int) tile.type];
        num1 += (float) ((double) num3 * (double) gravDir * -1.0);
      }
    }
    return (double) num1 < 0.0;
  }

  public static List<Point> GetTilesIn(Vector2 TopLeft, Vector2 BottomRight)
  {
    List<Point> tilesIn = new List<Point>();
    Point tileCoordinates1 = TopLeft.ToTileCoordinates();
    Point tileCoordinates2 = BottomRight.ToTileCoordinates();
    int num1 = Utils.Clamp<int>(tileCoordinates1.X, 0, Main.maxTilesX - 1);
    int num2 = Utils.Clamp<int>(tileCoordinates1.Y, 0, Main.maxTilesY - 40);
    int num3 = Utils.Clamp<int>(tileCoordinates2.X, 0, Main.maxTilesX - 1);
    int num4 = Utils.Clamp<int>(tileCoordinates2.Y, 0, Main.maxTilesY - 40);
    for (int x = num1; x <= num3; ++x)
    {
      for (int y = num2; y <= num4; ++y)
      {
        if (Main.tile[x, y] != null)
          tilesIn.Add(new Point(x, y));
      }
    }
    return tilesIn;
  }

  public static void ExpandVertically(
    int startX,
    int startY,
    out int topY,
    out int bottomY,
    int maxExpandUp = 100,
    int maxExpandDown = 100)
  {
    topY = startY;
    bottomY = startY;
    if (!WorldGen.InWorld(startX, startY, 10))
      return;
    for (int index = 0; index < maxExpandUp && topY > 0 && topY >= 10 && Main.tile[startX, topY] != null && !WorldGen.SolidTile3(startX, topY); ++index)
      --topY;
    for (int index = 0; index < maxExpandDown && bottomY < Main.maxTilesY - 10 && bottomY <= Main.maxTilesY - 10 && Main.tile[startX, bottomY] != null && !WorldGen.SolidTile3(startX, bottomY); ++index)
      ++bottomY;
  }

  public static Vector2 AdvancedTileCollision(
    bool[] forcedIgnoredTiles,
    Vector2 Position,
    Vector2 Velocity,
    int Width,
    int Height,
    bool fallThrough = false,
    bool fall2 = false,
    int gravDir = 1)
  {
    Collision.up = false;
    Collision.down = false;
    Vector2 vector2_1 = Velocity;
    Vector2 vector2_2 = Velocity;
    Vector2 vector2_3 = Position + Velocity;
    Vector2 vector2_4 = Position;
    int num1 = (int) ((double) Position.X / 16.0) - 1;
    int num2 = (int) (((double) Position.X + (double) Width) / 16.0) + 2;
    int num3 = (int) ((double) Position.Y / 16.0) - 1;
    int num4 = (int) (((double) Position.Y + (double) Height) / 16.0) + 2;
    int num5 = -1;
    int num6 = -1;
    int num7 = -1;
    int num8 = -1;
    int max = Main.maxTilesX - 1;
    int num9 = Utils.Clamp<int>(num1, 0, max);
    int num10 = Utils.Clamp<int>(num2, 0, Main.maxTilesX - 1);
    int num11 = Utils.Clamp<int>(num3, 0, Main.maxTilesY - 40);
    int num12 = Utils.Clamp<int>(num4, 0, Main.maxTilesY - 40);
    float num13 = (float) ((num12 + 3) * 16 /*0x10*/);
    for (int index1 = num9; index1 < num10; ++index1)
    {
      for (int index2 = num11; index2 < num12; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile != null && tile.active() && !tile.inActive() && !forcedIgnoredTiles[(int) tile.type] && (Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type] && tile.frameY == (short) 0))
        {
          Vector2 vector2_5;
          vector2_5.X = (float) (index1 * 16 /*0x10*/);
          vector2_5.Y = (float) (index2 * 16 /*0x10*/);
          int num14 = 16 /*0x10*/;
          if (tile.halfBrick())
          {
            vector2_5.Y += 8f;
            num14 -= 8;
          }
          if ((double) vector2_3.X + (double) Width > (double) vector2_5.X && (double) vector2_3.X < (double) vector2_5.X + 16.0 && (double) vector2_3.Y + (double) Height > (double) vector2_5.Y && (double) vector2_3.Y < (double) vector2_5.Y + (double) num14)
          {
            bool flag1 = false;
            bool flag2 = false;
            if (tile.slope() > (byte) 2)
            {
              if (tile.slope() == (byte) 3 && (double) vector2_4.Y + (double) Math.Abs(Velocity.X) >= (double) vector2_5.Y && (double) vector2_4.X >= (double) vector2_5.X)
                flag2 = true;
              if (tile.slope() == (byte) 4 && (double) vector2_4.Y + (double) Math.Abs(Velocity.X) >= (double) vector2_5.Y && (double) vector2_4.X + (double) Width <= (double) vector2_5.X + 16.0)
                flag2 = true;
            }
            else if (tile.slope() > (byte) 0)
            {
              flag1 = true;
              if (tile.slope() == (byte) 1 && (double) vector2_4.Y + (double) Height - (double) Math.Abs(Velocity.X) <= (double) vector2_5.Y + (double) num14 && (double) vector2_4.X >= (double) vector2_5.X)
                flag2 = true;
              if (tile.slope() == (byte) 2 && (double) vector2_4.Y + (double) Height - (double) Math.Abs(Velocity.X) <= (double) vector2_5.Y + (double) num14 && (double) vector2_4.X + (double) Width <= (double) vector2_5.X + 16.0)
                flag2 = true;
            }
            if (!flag2)
            {
              if ((double) vector2_4.Y + (double) Height <= (double) vector2_5.Y)
              {
                Collision.down = true;
                if ((!(Main.tileSolidTop[(int) tile.type] & fallThrough) || !((double) Velocity.Y <= 1.0 | fall2)) && (double) num13 > (double) vector2_5.Y)
                {
                  num7 = index1;
                  num8 = index2;
                  if (num14 < 16 /*0x10*/)
                    ++num8;
                  if (num7 != num5 && !flag1)
                  {
                    vector2_1.Y = (float) ((double) vector2_5.Y - ((double) vector2_4.Y + (double) Height) + (gravDir == -1 ? -0.0099999997764825821 : 0.0));
                    num13 = vector2_5.Y;
                  }
                }
              }
              else if ((double) vector2_4.X + (double) Width <= (double) vector2_5.X && !Main.tileSolidTop[(int) tile.type])
              {
                if (Main.tile[index1 - 1, index2] == null)
                  Main.tile[index1 - 1, index2] = new Tile();
                if (Main.tile[index1 - 1, index2].slope() != (byte) 2 && Main.tile[index1 - 1, index2].slope() != (byte) 4)
                {
                  num5 = index1;
                  num6 = index2;
                  if (num6 != num8)
                    vector2_1.X = vector2_5.X - (vector2_4.X + (float) Width);
                  if (num7 == num5)
                    vector2_1.Y = vector2_2.Y;
                }
              }
              else if ((double) vector2_4.X >= (double) vector2_5.X + 16.0 && !Main.tileSolidTop[(int) tile.type])
              {
                if (Main.tile[index1 + 1, index2] == null)
                  Main.tile[index1 + 1, index2] = new Tile();
                if (Main.tile[index1 + 1, index2].slope() != (byte) 1 && Main.tile[index1 + 1, index2].slope() != (byte) 3)
                {
                  num5 = index1;
                  num6 = index2;
                  if (num6 != num8)
                    vector2_1.X = vector2_5.X + 16f - vector2_4.X;
                  if (num7 == num5)
                    vector2_1.Y = vector2_2.Y;
                }
              }
              else if ((double) vector2_4.Y >= (double) vector2_5.Y + (double) num14 && !Main.tileSolidTop[(int) tile.type])
              {
                Collision.up = true;
                num7 = index1;
                num8 = index2;
                vector2_1.Y = (float) ((double) vector2_5.Y + (double) num14 - (double) vector2_4.Y + (gravDir == 1 ? 0.0099999997764825821 : 0.0));
                if (num8 == num6)
                  vector2_1.X = vector2_2.X;
              }
            }
          }
        }
      }
    }
    return vector2_1;
  }

  public static void LaserScan(
    Vector2 samplingPoint,
    Vector2 directionUnit,
    float samplingWidth,
    float maxDistance,
    float[] samples)
  {
    for (int index = 0; index < samples.Length; ++index)
    {
      float num1 = (float) index / (float) (samples.Length - 1);
      Vector2 vector2_1 = samplingPoint;
      Vector2 spinningpoint = directionUnit;
      Vector2 vector2_2 = new Vector2();
      Vector2 center = vector2_2;
      Vector2 vector2_3 = spinningpoint.RotatedBy(1.5707963705062866, center) * (num1 - 0.5f) * samplingWidth;
      Vector2 vector2_4 = vector2_1 + vector2_3;
      int x1 = (int) vector2_4.X / 16 /*0x10*/;
      int y1 = (int) vector2_4.Y / 16 /*0x10*/;
      Vector2 vector2_5 = vector2_4 + directionUnit * maxDistance;
      int x2 = (int) vector2_5.X / 16 /*0x10*/;
      int y2 = (int) vector2_5.Y / 16 /*0x10*/;
      Point col;
      float num2;
      if (!Collision.HitLine(x1, y1, x2, y2, 0, 0, new List<Point>(), out col))
      {
        vector2_2 = new Vector2((float) Math.Abs(x1 - col.X), (float) Math.Abs(y1 - col.Y));
        num2 = vector2_2.Length() * 16f;
      }
      else if (col.X == x2 && col.Y == y2)
      {
        num2 = maxDistance;
      }
      else
      {
        vector2_2 = new Vector2((float) Math.Abs(x1 - col.X), (float) Math.Abs(y1 - col.Y));
        num2 = vector2_2.Length() * 16f;
      }
      samples[index] = num2;
    }
  }

  public static void AimingLaserScan(
    Vector2 startPoint,
    Vector2 endPoint,
    float samplingWidth,
    int samplesToTake,
    out Vector2 vectorTowardsTarget,
    out float[] samples)
  {
    samples = new float[samplesToTake];
    vectorTowardsTarget = endPoint - startPoint;
    Collision.LaserScan(startPoint, vectorTowardsTarget.SafeNormalize(Vector2.Zero), samplingWidth, vectorTowardsTarget.Length(), samples);
  }

  public enum TileContactSide
  {
    Left,
    Right,
    Top,
    Bottom,
    BottomLeft,
    BottomRight,
  }

  public struct TileContact(
    Collision.TileContactSide side,
    int x,
    int y,
    int type,
    int slope,
    int overlap)
  {
    public Collision.TileContactSide Side = side;
    public int Overlap = overlap;
    public int X = x;
    public int Y = y;
    public int Slope = slope;
    public int Type = type;
  }

  public struct HurtTile
  {
    public int type;
    public int x;
    public int y;
  }
}
