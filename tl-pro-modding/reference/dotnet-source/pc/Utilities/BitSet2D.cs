// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.BitSet2D
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace Terraria.Utilities;

public class BitSet2D
{
  private Point offset;
  private int size;
  private Bits64[] bits;

  public void Reset(Point center, int maxDist)
  {
    this.size = maxDist * 2 + 1;
    this.offset = new Point(center.X - maxDist, center.Y - maxDist);
    int newSize = this.size * this.size + 63 /*0x3F*/ >> 6;
    if (this.bits == null || this.bits.Length < newSize)
      Array.Resize<Bits64>(ref this.bits, newSize);
    Array.Clear((Array) this.bits, 0, this.bits.Length);
  }

  private int Coord(Point p)
  {
    int num = p.X - this.offset.X;
    return (p.Y - this.offset.Y) * this.size + num;
  }

  public bool InBounds(Point p)
  {
    int num1 = p.X - this.offset.X;
    int num2 = p.Y - this.offset.Y;
    return num1 >= 0 && num1 < this.size && num2 >= 0 && num2 < this.size;
  }

  public bool this[Point p]
  {
    get
    {
      int num = this.Coord(p);
      return this.bits[num >> 6][num & 63 /*0x3F*/];
    }
    set
    {
      int num = this.Coord(p);
      this.bits[num >> 6][num & 63 /*0x3F*/] = value;
    }
  }

  public bool Add(Point p)
  {
    int num = this.Coord(p);
    if (this.bits[num >> 6][num & 63 /*0x3F*/])
      return false;
    this.bits[num >> 6][num & 63 /*0x3F*/] = true;
    return true;
  }

  public bool Remove(Point p)
  {
    int num = this.Coord(p);
    if (!this.bits[num >> 6][num & 63 /*0x3F*/])
      return false;
    this.bits[num >> 6][num & 63 /*0x3F*/] = false;
    return true;
  }
}
