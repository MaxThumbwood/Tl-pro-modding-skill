// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.DitherSnake
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.Generation.Dungeon;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class DitherSnake : List<DungeonControlLine>
{
  private static readonly Vector2D[] CircleTestPoints = Enumerable.Range(0, 12).Select<int, Vector2D>((Func<int, Vector2D>) (i => Vector2D.UnitX.RotatedBy(2.0 * Math.PI * (double) i / 12.0, new Vector2D()))).ToArray<Vector2D>();
  private static readonly double ExtraBuffer = 1.0 / Math.Cos(Math.PI / 6.0);

  public new void Add(DungeonControlLine line)
  {
    if (this.Count > 0)
    {
      DungeonControlLine dungeonControlLine = this.Last<DungeonControlLine>();
      dungeonControlLine.Next = line;
      line.Prev = dungeonControlLine;
    }
    line.Index = this.Count;
    base.Add(line);
  }

  public DungeonControlLine GetClosestLineTo(Vector2D pos)
  {
    DungeonControlLine closestLineTo = (DungeonControlLine) null;
    double num1 = double.MaxValue;
    foreach (DungeonControlLine dungeonControlLine in (List<DungeonControlLine>) this)
    {
      double num2 = dungeonControlLine.Center.Distance(pos);
      if (num2 < num1)
      {
        closestLineTo = dungeonControlLine;
        num1 = num2;
      }
    }
    return closestLineTo;
  }

  public DungeonControlLine GetLineContaining(
    Vector2D pos,
    DungeonControlLine initialGuess = null,
    int depth = 0)
  {
    if (initialGuess == null)
      initialGuess = this.GetClosestLineTo(pos);
    if (depth == 3)
      return (DungeonControlLine) null;
    if (Vector2D.Dot(Vector2D.op_Subtraction(pos, initialGuess.Start), initialGuess.StartTangent) < 0.0 && initialGuess.Prev != null)
      return this.GetLineContaining(pos, initialGuess.Prev, depth + 1);
    return Vector2D.Dot(Vector2D.op_Subtraction(pos, initialGuess.End), initialGuess.EndTangent) < 0.0 && initialGuess.Next != null ? this.GetLineContaining(pos, initialGuess.Next, depth + 1) : initialGuess;
  }

  public double GetPositionAlongSnake(Vector2D pos)
  {
    DungeonControlLine lineContaining = this.GetLineContaining(pos);
    double normalizedLineProgress;
    if (!lineContaining.CanPaint((int) pos.X, (int) pos.Y, out double _, out normalizedLineProgress))
      normalizedLineProgress = 0.5;
    return (double) lineContaining.Index + normalizedLineProgress;
  }

  public bool IsCircleInsideBorderWithStyle(
    DungeonGenerationStyleData style,
    Vector2D center,
    int radius)
  {
    DungeonControlLine closestLineTo = this.GetClosestLineTo(center);
    return closestLineTo.Style == style && this.IsCircleInsideBorderWithMatchingStyle(closestLineTo, center, radius);
  }

  public bool IsCircleInsideBorderWithMatchingStyle(
    DungeonControlLine nearbyLine,
    Vector2D center,
    int radius)
  {
    double num = (double) radius * DitherSnake.ExtraBuffer;
    foreach (Vector2D circleTestPoint in DitherSnake.CircleTestPoints)
    {
      Vector2D vector2D = Vector2D.op_Addition(center, Vector2D.op_Multiply(circleTestPoint, num));
      DungeonControlLine lineContaining = this.GetLineContaining(vector2D, nearbyLine);
      if (lineContaining == null || lineContaining.Style != nearbyLine.Style || !lineContaining.IsInsideBorder(vector2D.ToPoint()))
        return false;
    }
    return true;
  }

  public Vector2D GetRoomPositionInsideBorder(
    DungeonControlLine line,
    double normalizedDistanceAlong,
    double normalizedDistanceFrom,
    int roomRadius,
    out SnakeOrientation orientation)
  {
    orientation = SnakeOrientation.Unknown;
    Vector2D Target1 = Vector2D.Lerp(line.Start, line.End, normalizedDistanceAlong);
    Vector2D potentialRoomPosition1 = line.GetPotentialRoomPosition(normalizedDistanceAlong, 0.0, roomRadius);
    Vector2D potentialRoomPosition2 = line.GetPotentialRoomPosition(normalizedDistanceAlong, 1.0, roomRadius);
    Vector2D Target2 = potentialRoomPosition1.Y < potentialRoomPosition2.Y ? potentialRoomPosition1 : potentialRoomPosition2;
    Vector2D Target3 = potentialRoomPosition1.Y > potentialRoomPosition2.Y ? potentialRoomPosition1 : potentialRoomPosition2;
    for (int index = 0; index < 4; ++index)
    {
      Vector2D potentialRoomPosition3 = line.GetPotentialRoomPosition(normalizedDistanceAlong, normalizedDistanceFrom, roomRadius);
      if (this.IsCircleInsideBorderWithMatchingStyle(line, potentialRoomPosition3, roomRadius))
      {
        double num1 = potentialRoomPosition3.Distance(Target1);
        double num2 = potentialRoomPosition3.Distance(Target2);
        double num3 = potentialRoomPosition3.Distance(Target3);
        orientation = num1 >= num2 || num1 >= num3 ? (num2 >= num3 ? SnakeOrientation.Bottom : SnakeOrientation.Top) : SnakeOrientation.Center;
        return potentialRoomPosition3;
      }
      normalizedDistanceFrom *= 0.8;
    }
    orientation = SnakeOrientation.Center;
    return line.Center;
  }

  public void SetTangents()
  {
    DungeonControlLine dungeonControlLine = this[0];
    dungeonControlLine.StartTangent = dungeonControlLine.NormalizedLineDirection;
    DungeonControlLine next;
    for (; dungeonControlLine.Next != null; dungeonControlLine = next)
    {
      next = dungeonControlLine.Next;
      Vector2D vector2D = Vector2D.op_Addition(dungeonControlLine.NormalizedLineDirection, next.NormalizedLineDirection).SafeNormalize(new Vector2D());
      next.StartTangent = vector2D;
      dungeonControlLine.EndTangent = Vector2D.op_UnaryNegation(vector2D);
    }
    dungeonControlLine.EndTangent = Vector2D.op_UnaryNegation(dungeonControlLine.NormalizedLineDirection);
  }

  public void AdjustTangentsToPreventSelfIntersection()
  {
    for (int index = 0; index < 100; ++index)
    {
      bool flag = false;
      foreach (DungeonControlLine dungeonControlLine in (List<DungeonControlLine>) this)
      {
        if (dungeonControlLine.AdjustTangentsToPreventSelfIntersection())
          flag = true;
      }
      if (!flag)
        break;
    }
  }

  public bool IsLineInsideBorder(Vector2D from, Vector2D to, int halfWidth)
  {
    Vector2D vector2D = Vector2D.op_Multiply(Vector2D.op_Subtraction(to, from).SafeNormalize(Vector2D.UnitX).RotatedBy(Math.PI / 2.0, new Vector2D()), (double) halfWidth);
    return this.IsLineInsideBorder(Vector2D.op_Addition(from, vector2D), Vector2D.op_Addition(to, vector2D)) && this.IsLineInsideBorder(Vector2D.op_Subtraction(from, vector2D), Vector2D.op_Subtraction(to, vector2D));
  }

  public bool IsLineInsideBorder(Vector2D from, Vector2D to)
  {
    DungeonControlLine line = this.GetClosestLineTo(from);
    return Utils.PlotLine(from.ToPoint(), to.ToPoint(), (Utils.TileActionAttempt) ((x, y) =>
    {
      line = this.GetLineContaining(new Vector2D((double) x, (double) y), line);
      return line != null && line.IsInsideBorder(new Point(x, y));
    }));
  }
}
