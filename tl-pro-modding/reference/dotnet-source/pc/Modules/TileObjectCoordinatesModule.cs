// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TileObjectCoordinatesModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Modules;

public class TileObjectCoordinatesModule
{
  public int width;
  public int[] heights;
  public int padding;
  public Point16 paddingFix;
  public int styleWidth;
  public int styleHeight;
  public bool calculated;
  public int drawStyleOffset;
  public Rectangle[,] drawFrameOffsets;

  public TileObjectCoordinatesModule(
    TileObjectCoordinatesModule copyFrom = null,
    int[] drawHeight = null,
    Rectangle[,] drawFrameOffs = null)
  {
    if (copyFrom == null)
    {
      this.width = 0;
      this.padding = 0;
      this.paddingFix = Point16.Zero;
      this.styleWidth = 0;
      this.drawStyleOffset = 0;
      this.styleHeight = 0;
      this.calculated = false;
      this.heights = drawHeight;
      this.drawFrameOffsets = drawFrameOffs;
    }
    else
    {
      this.width = copyFrom.width;
      this.padding = copyFrom.padding;
      this.paddingFix = copyFrom.paddingFix;
      this.drawStyleOffset = copyFrom.drawStyleOffset;
      this.styleWidth = copyFrom.styleWidth;
      this.styleHeight = copyFrom.styleHeight;
      this.calculated = copyFrom.calculated;
      if (drawHeight == null)
      {
        if (copyFrom.heights == null)
        {
          this.heights = (int[]) null;
        }
        else
        {
          this.heights = new int[copyFrom.heights.Length];
          Array.Copy((Array) copyFrom.heights, (Array) this.heights, this.heights.Length);
        }
      }
      else
        this.heights = drawHeight;
      if (drawFrameOffs == null)
      {
        if (copyFrom.drawFrameOffsets == null)
        {
          this.drawFrameOffsets = (Rectangle[,]) null;
        }
        else
        {
          this.drawFrameOffsets = new Rectangle[copyFrom.drawFrameOffsets.GetLength(0), copyFrom.drawFrameOffsets.GetLength(1)];
          Array.Copy((Array) copyFrom.drawFrameOffsets, (Array) this.drawFrameOffsets, this.drawFrameOffsets.Length);
        }
      }
      else
        this.drawFrameOffsets = drawFrameOffs;
    }
  }
}
