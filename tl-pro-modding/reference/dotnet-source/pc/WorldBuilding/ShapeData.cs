// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.ShapeData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.WorldBuilding;

public class ShapeData
{
  private HashSet<Point16> _points;

  public int Count => this._points.Count;

  public ShapeData() => this._points = new HashSet<Point16>();

  public ShapeData(ShapeData original)
  {
    this._points = new HashSet<Point16>((IEnumerable<Point16>) original._points);
  }

  public void Add(int x, int y)
  {
    Point16 point16 = new Point16(x, y);
    if (this._points.Contains(point16))
      return;
    this._points.Add(point16);
  }

  public void AddBounds(int minX, int minY, int maxX, int maxY)
  {
    for (int x = minX; x <= maxX; ++x)
    {
      for (int y = minY; y <= maxY; ++y)
        this.Add(x, y);
    }
  }

  public void Remove(int x, int y)
  {
    Point16 point16 = new Point16(x, y);
    if (!this._points.Contains(point16))
      return;
    this._points.Remove(point16);
  }

  public void RemoveBounds(int minX, int minY, int maxX, int maxY)
  {
    for (int x = minX; x <= maxX; ++x)
    {
      for (int y = minY; y <= maxY; ++y)
        this.Remove(x, y);
    }
  }

  public HashSet<Point16> GetData() => this._points;

  public void Clear() => this._points.Clear();

  public bool Contains(int x, int y) => this._points.Contains(new Point16(x, y));

  public void Add(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
  {
    foreach (Point16 point16 in shapeData.GetData())
      this.Add(remoteOrigin.X - localOrigin.X + (int) point16.X, remoteOrigin.Y - localOrigin.Y + (int) point16.Y);
  }

  public void Subtract(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
  {
    foreach (Point16 point16 in shapeData.GetData())
      this.Remove(remoteOrigin.X - localOrigin.X + (int) point16.X, remoteOrigin.Y - localOrigin.Y + (int) point16.Y);
  }

  public static Microsoft.Xna.Framework.Rectangle GetBounds(Point origin, params ShapeData[] shapes)
  {
    int val1_1 = (int) shapes[0]._points.First<Point16>().X;
    int val1_2 = val1_1;
    int val1_3 = (int) shapes[0]._points.First<Point16>().Y;
    int val1_4 = val1_3;
    for (int index = 0; index < shapes.Length; ++index)
    {
      foreach (Point16 point in shapes[index]._points)
      {
        val1_1 = Math.Max(val1_1, (int) point.X);
        val1_2 = Math.Min(val1_2, (int) point.X);
        val1_3 = Math.Max(val1_3, (int) point.Y);
        val1_4 = Math.Min(val1_4, (int) point.Y);
      }
    }
    return new Microsoft.Xna.Framework.Rectangle(val1_2 + origin.X, val1_4 + origin.Y, val1_1 - val1_2, val1_3 - val1_4);
  }
}
