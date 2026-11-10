// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.DungeonControlLine
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using ReLogic.Utilities;
using System;
using Terraria.GameContent.Generation.Dungeon;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class DungeonControlLine
{
  public int Index;
  public DungeonControlLine Next;
  public DungeonControlLine Prev;
  public Vector2D Start;
  public Vector2D End;
  public Vector2D StartTangent;
  public Vector2D EndTangent;
  public Vector2D StartNormal;
  public Vector2D EndNormal;
  public double CrossTangent;
  public double StartRadius;
  public double EndRadius;
  public static double NormalizedDistanceSafeFromDither;
  private const double StyleTransitionDitherWidth = 0.5;
  private const int BorderWidth = 4;
  public Vector2D NormalizedLineDirection;
  public double LineLength;
  public DungeonGenerationStyleData Style;
  public int ProgressionStage;
  public bool CurveLine;

  public Vector2D Center => Vector2D.op_Division(Vector2D.op_Addition(this.End, this.Start), 2.0);

  [JsonConstructor]
  private DungeonControlLine()
  {
  }

  public DungeonControlLine(
    Vector2D start,
    Vector2D end,
    double startRadius,
    double endRadius,
    int progressionStage,
    DungeonGenerationStyleData style)
  {
    this.Start = start;
    this.End = end;
    this.StartRadius = startRadius;
    this.EndRadius = endRadius;
    this.ProgressionStage = progressionStage;
    this.Style = style;
    Vector2D v = Vector2D.op_Subtraction(this.End, this.Start);
    this.LineLength = ((Vector2D) ref v).Length();
    this.NormalizedLineDirection = v.SafeNormalize(Vector2D.UnitX);
  }

  private void CacheNormals()
  {
    this.StartNormal = new Vector2D(this.StartTangent.Y, -this.StartTangent.X);
    this.EndNormal = new Vector2D(-this.EndTangent.Y, this.EndTangent.X);
    this.CrossTangent = Vector2D.Cross(this.StartTangent, this.EndTangent);
  }

  public bool CanPaint(int x, int y, out double distance, out double normalizedLineProgress)
  {
    distance = 0.0;
    normalizedLineProgress = 0.0;
    Vector2D vector2D1;
    // ISSUE: explicit constructor call
    ((Vector2D) ref vector2D1).\u002Ector((double) x, (double) y);
    Vector2D vector2D2 = Vector2D.op_Subtraction(vector2D1, this.Start);
    double num1 = Vector2D.Dot(vector2D2, this.StartTangent);
    if (num1 < 0.0)
    {
      if (this.Prev != null)
        return false;
      normalizedLineProgress = 0.0;
      distance = ((Vector2D) ref vector2D2).Length();
      return true;
    }
    Vector2D vector2D3 = Vector2D.op_Subtraction(vector2D1, this.End);
    double num2 = Vector2D.Dot(vector2D3, this.EndTangent);
    if (num2 < 0.0)
    {
      if (this.Next != null)
        return false;
      normalizedLineProgress = 1.0;
      distance = ((Vector2D) ref vector2D3).Length();
      return true;
    }
    double num3 = Vector2D.Dot(vector2D2, this.StartNormal);
    double num4 = Vector2D.Dot(vector2D3, this.EndNormal);
    double num5 = (num1 + num2) / 2.0;
    double num6 = num1 * num1;
    double num7 = num2 * num2;
    double num8 = num6 / (num6 + num7);
    double num9 = 1.0 - num8;
    double num10 = num3 * num9 + num4 * num8 - num5 * this.CrossTangent * num8 * (1.0 - num8);
    distance = Math.Abs(num10);
    normalizedLineProgress = num8;
    return true;
  }

  public void Paint(int x, int y)
  {
    double distance;
    double normalizedLineProgress;
    if (!this.CanPaint(x, y, out distance, out normalizedLineProgress))
      return;
    double num1 = Utils.Lerp(this.StartRadius, this.EndRadius, normalizedLineProgress);
    double normalizedDistanceForPoint = distance / num1;
    if (normalizedDistanceForPoint > 1.0)
      return;
    DungeonGenerationStyleData ditheredTransition = this.GetStyleWithDitheredTransition(x, y, normalizedLineProgress);
    if (DungeonControlLine.SkipPaintForEdge(x, y, ditheredTransition, normalizedDistanceForPoint))
      return;
    Tile tile = Main.tile[x, y];
    tile.ClearEverything();
    tile.active(true);
    tile.type = ditheredTransition.BrickTileType;
    tile.wall = ditheredTransition.BrickWallType;
    if (ditheredTransition.UnbreakableWallProgressionTier <= DualDungeonUnbreakableWallTiers.EarlyGame)
      return;
    int num2 = (int) (num1 * DungeonControlLine.NormalizedDistanceSafeFromDither);
    double num3 = distance - (double) num2;
    if (num3 < -4.0 || num3 > 0.0)
      return;
    int wallProgressionTier = ditheredTransition.UnbreakableWallProgressionTier;
    if (num3 <= -2.0)
      wallProgressionTier += 16 /*0x10*/;
    tile.wall = (ushort) 350;
    tile.wallColor((byte) wallProgressionTier);
  }

  public DungeonGenerationStyleData GetStyleWithDitheredTransition(
    int x,
    int y,
    double normalizedLineProgress)
  {
    if (normalizedLineProgress < 0.25)
    {
      if (this.Prev != null && this.Prev.Style != this.Style && Utils.Remap(normalizedLineProgress, 0.0, 0.25, 0.5, 1.0) <= DitherSnakePass._bayerDither[x % 4, y % 4])
        return this.Prev.Style;
    }
    else if (normalizedLineProgress > 0.75 && this.Next != null && this.Next.Style != this.Style && Utils.Remap(normalizedLineProgress, 0.75, 1.0, 0.0, 0.5) >= DitherSnakePass._bayerDither[x % 4, y % 4])
      return this.Next.Style;
    return this.Style;
  }

  public static bool SkipPaintForEdge(
    int x,
    int y,
    DungeonGenerationStyleData style,
    double normalizedDistanceForPoint)
  {
    if (normalizedDistanceForPoint <= DungeonControlLine.NormalizedDistanceSafeFromDither)
      return false;
    double num1 = 1.0 - (normalizedDistanceForPoint - DungeonControlLine.NormalizedDistanceSafeFromDither) / (1.0 - DungeonControlLine.NormalizedDistanceSafeFromDither);
    if (!style.EdgeDither)
      return num1 < 0.25;
    if (!WorldGen.InWorld(x, y, 5))
      return false;
    Tile tile = Main.tile[x, y];
    if (tile != null && !tile.active() || num1 <= DitherSnakePass._bayerDither[x % 4, y % 4])
      return true;
    double num2 = Utils.Lerp(0.0, 0.949999988079071, 1.0 - num1);
    return (double) WorldGen.genRand.NextFloat() <= num2 || num1 <= 3.0 / 32.0 && WorldGen.genRand.Next(3) != 0 || num1 <= 0.125 && WorldGen.genRand.Next(2) == 0 || num1 <= 5.0 / 32.0 && WorldGen.genRand.Next(4) == 0;
  }

  public void Paint(Rectangle dungeonBounds)
  {
    this.CacheNormals();
    double num = Utils.Max<double>(this.StartRadius, this.EndRadius);
    Point point1 = this.Start.ToPoint();
    Point point2 = this.End.ToPoint();
    Rectangle rectangle1 = Rectangle.Union(new Rectangle(point1.X, point1.Y, 1, 1), new Rectangle(point2.X, point2.Y, 1, 1));
    rectangle1.Inflate((int) num, (int) num);
    Rectangle rectangle2 = Rectangle.Intersect(rectangle1, dungeonBounds);
    for (int left = rectangle2.Left; left <= rectangle2.Right; ++left)
    {
      for (int top = rectangle2.Top; top <= rectangle2.Bottom; ++top)
        this.Paint(left, top);
    }
  }

  public bool IsSelfIntersecting()
  {
    this.CacheNormals();
    double num1 = Vector2D.Cross(this.StartNormal, this.EndNormal);
    Vector2D vector2D = Vector2D.op_Subtraction(this.End, this.Start);
    double num2 = Vector2D.Cross(vector2D, this.EndNormal) / num1;
    double num3 = Vector2D.Cross(vector2D, this.StartNormal) / num1;
    return Math.Abs(num2) < this.StartRadius || Math.Abs(num3) < this.EndRadius;
  }

  public bool AdjustTangentsToPreventSelfIntersection()
  {
    if (!this.IsSelfIntersecting())
      return false;
    Vector2D vector2D1 = Vector2D.op_Subtraction(this.StartTangent, Vector2D.op_Division(this.EndTangent, 2.0)).SafeNormalize(new Vector2D());
    Vector2D vector2D2 = Vector2D.op_Subtraction(this.EndTangent, Vector2D.op_Division(this.StartTangent, 2.0)).SafeNormalize(new Vector2D());
    if (this.Prev != null)
    {
      this.StartTangent = vector2D1;
      this.Prev.EndTangent = Vector2D.op_UnaryNegation(this.StartTangent);
    }
    if (this.Next != null)
    {
      this.EndTangent = vector2D2;
      this.Next.StartTangent = Vector2D.op_UnaryNegation(this.EndTangent);
    }
    return true;
  }

  public bool IsInsideBorder(Point point)
  {
    double distance;
    double normalizedLineProgress;
    return this.CanPaint(point.X, point.Y, out distance, out normalizedLineProgress) && distance < Utils.Lerp(this.StartRadius, this.EndRadius, normalizedLineProgress) * DungeonControlLine.NormalizedDistanceSafeFromDither - 4.0;
  }

  public Vector2D GetPotentialRoomPosition(
    double normalizedDistanceAlong,
    double normalizedOffset,
    int roomRadius)
  {
    Vector2D vector2D = Vector2D.Lerp(this.StartNormal, this.EndNormal, normalizedDistanceAlong).SafeNormalize(new Vector2D());
    double num = Utils.Lerp(this.StartRadius, this.EndRadius, normalizedDistanceAlong) * DungeonControlLine.NormalizedDistanceSafeFromDither - 4.0 - (double) roomRadius;
    return Vector2D.op_Addition(Vector2D.Lerp(this.Start, this.End, normalizedDistanceAlong), Vector2D.op_Multiply(Vector2D.op_Multiply(vector2D, num), normalizedOffset));
  }
}
