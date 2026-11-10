// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.Searches
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public static class Searches
{
  public static GenSearch Chain(GenSearch search, params GenCondition[] conditions)
  {
    return search.Conditions(conditions);
  }

  public class Left : GenSearch
  {
    private int _maxDistance;

    public Left(int maxDistance) => this._maxDistance = maxDistance;

    public override Point Find(Point origin)
    {
      for (int index = 0; index < this._maxDistance; ++index)
      {
        if (this.Check(origin.X - index, origin.Y))
          return new Point(origin.X - index, origin.Y);
      }
      return GenSearch.NOT_FOUND;
    }
  }

  public class Right : GenSearch
  {
    private int _maxDistance;

    public Right(int maxDistance) => this._maxDistance = maxDistance;

    public override Point Find(Point origin)
    {
      for (int index = 0; index < this._maxDistance; ++index)
      {
        if (this.Check(origin.X + index, origin.Y))
          return new Point(origin.X + index, origin.Y);
      }
      return GenSearch.NOT_FOUND;
    }
  }

  public class Down : GenSearch
  {
    private int _maxDistance;

    public Down(int maxDistance) => this._maxDistance = maxDistance;

    public override Point Find(Point origin)
    {
      for (int index = 0; index < this._maxDistance && origin.Y + index < Main.maxTilesY; ++index)
      {
        if (this.Check(origin.X, origin.Y + index))
          return new Point(origin.X, origin.Y + index);
      }
      return GenSearch.NOT_FOUND;
    }
  }

  public class Up : GenSearch
  {
    private int _maxDistance;

    public Up(int maxDistance) => this._maxDistance = maxDistance;

    public override Point Find(Point origin)
    {
      for (int index = 0; index < this._maxDistance; ++index)
      {
        if (this.Check(origin.X, origin.Y - index))
          return new Point(origin.X, origin.Y - index);
      }
      return GenSearch.NOT_FOUND;
    }
  }

  public class Rectangle : GenSearch
  {
    private int _width;
    private int _height;

    public Rectangle(int width, int height)
    {
      this._width = width;
      this._height = height;
    }

    public override Point Find(Point origin)
    {
      for (int index1 = 0; index1 < this._width; ++index1)
      {
        for (int index2 = 0; index2 < this._height; ++index2)
        {
          if (this.Check(origin.X + index1, origin.Y + index2))
            return new Point(origin.X + index1, origin.Y + index2);
        }
      }
      return GenSearch.NOT_FOUND;
    }
  }
}
