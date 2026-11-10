// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonShapes
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonShapes
{
  public class CircleRoom : GenShape
  {
    private int _verticalRadius;
    private int _horizontalRadius;

    public int VerticalRadius => this._verticalRadius;

    public int HorizontalRadius => this._horizontalRadius;

    public CircleRoom(int radius)
    {
      this._verticalRadius = radius;
      this._horizontalRadius = radius;
    }

    public CircleRoom(int horizontalRadius, int verticalRadius)
    {
      this._horizontalRadius = horizontalRadius;
      this._verticalRadius = verticalRadius;
    }

    public void SetRadius(int radius)
    {
      this._verticalRadius = radius;
      this._horizontalRadius = radius;
    }

    public override bool Perform(Point origin, GenAction action)
    {
      int num1 = (this._horizontalRadius + 1) * (this._horizontalRadius + 1);
      for (int y = origin.Y - this._verticalRadius; y <= origin.Y + this._verticalRadius; ++y)
      {
        double num2 = (double) this._horizontalRadius / (double) this._verticalRadius * (double) (y - origin.Y);
        int num3 = Math.Min(this._horizontalRadius, (int) Math.Sqrt((double) num1 - num2 * num2));
        for (int x = origin.X - num3; x <= origin.X + num3; ++x)
        {
          if (!this.UnitApply(action, origin, x, y) && this._quitOnFail)
            return false;
        }
      }
      return true;
    }
  }

  public class MoundRoom : GenShape
  {
    private int _halfWidth;
    private int _height;

    public MoundRoom(int halfWidth, int height)
    {
      this._halfWidth = halfWidth;
      this._height = height;
    }

    public override bool Perform(Point origin, GenAction action)
    {
      int height = this._height;
      float halfWidth = (float) this._halfWidth;
      int num1 = this._height / 2;
      for (int index1 = -this._halfWidth; index1 <= this._halfWidth; ++index1)
      {
        int num2 = Math.Min(this._height, (int) (-((double) (this._height + 1) / ((double) halfWidth * (double) halfWidth)) * ((double) index1 + (double) halfWidth) * ((double) index1 - (double) halfWidth)));
        for (int index2 = 0; index2 < num2; ++index2)
        {
          if (!this.UnitApply(action, origin, index1 + origin.X, origin.Y - index2 + num1) && this._quitOnFail)
            return false;
        }
      }
      return true;
    }
  }

  public class HourglassRoom : GenShape
  {
    private int _width;
    private int _height;
    private float _percentileAddon;

    public HourglassRoom(int width, int height, float percentileAddon)
    {
      this._width = width;
      this._height = height;
      this._percentileAddon = percentileAddon;
    }

    public override bool Perform(Point origin, GenAction action)
    {
      int num1 = this._height / 2;
      for (int index1 = -num1; index1 <= num1; ++index1)
      {
        int y = origin.Y + index1;
        int num2 = (int) ((double) this._width * (double) Math.Max(0.0f, Math.Min(1f, (float) ((double) Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, ((float) index1 + (float) num1) / (float) this._height), 1f, 1f, 0.75f, 0.65f, 0.45f, 0.4f, 0.35f, 0.35f) + (double) this._percentileAddon)))) / 2;
        for (int index2 = -num2; index2 <= num2; ++index2)
        {
          int x = origin.X + index2;
          if (!this.UnitApply(action, origin, x, y) && this._quitOnFail)
            return false;
        }
      }
      return true;
    }
  }

  public class QuadCircleRoom : GenShape
  {
    private int _radius;
    private int _distanceBetweenSpheres;

    public int Radius => this._radius;

    public QuadCircleRoom(int radius, int distanceBetweenSpheres)
    {
      this._radius = radius;
      this._distanceBetweenSpheres = distanceBetweenSpheres;
    }

    public void SetRadius(int radius) => this._radius = radius;

    public override bool Perform(Point origin, GenAction action)
    {
      int num1 = (this._radius + 1) * (this._radius + 1);
      int num2 = 3;
      for (int index = 0; index < 5; ++index)
      {
        Point point;
        switch (index)
        {
          case 1:
            point = new Vector2((float) origin.X, (float) (origin.Y + this._distanceBetweenSpheres - num2)).ToPoint();
            break;
          case 2:
            point = new Vector2((float) (origin.X - this._distanceBetweenSpheres + num2), (float) origin.Y).ToPoint();
            break;
          case 3:
            point = new Vector2((float) (origin.X + this._distanceBetweenSpheres - num2), (float) origin.Y).ToPoint();
            break;
          case 4:
            point = origin;
            break;
          default:
            point = new Vector2((float) origin.X, (float) (origin.Y - this._distanceBetweenSpheres + num2)).ToPoint();
            break;
        }
        for (int y = point.Y - this._radius; y <= point.Y + this._radius; ++y)
        {
          double num3 = (double) this._radius / (double) this._radius * (double) (y - point.Y);
          int num4 = Math.Min(this._radius, (int) Math.Sqrt((double) num1 - num3 * num3));
          for (int x = point.X - num4; x <= point.X + num4; ++x)
          {
            if (!this.UnitApply(action, origin, x, y) && this._quitOnFail)
              return false;
          }
        }
      }
      return true;
    }
  }
}
