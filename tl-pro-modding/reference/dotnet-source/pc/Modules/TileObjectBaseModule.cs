// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TileObjectBaseModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.Enums;

#nullable disable
namespace Terraria.Modules;

public class TileObjectBaseModule
{
  public int width;
  public int height;
  public Point16 origin;
  public TileObjectDirection direction;
  public int randomRange;
  public bool flattenAnchors;
  public int[] specificRandomStyles;

  public TileObjectBaseModule(TileObjectBaseModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.width = 1;
      this.height = 1;
      this.origin = Point16.Zero;
      this.direction = TileObjectDirection.None;
      this.randomRange = 0;
      this.flattenAnchors = false;
      this.specificRandomStyles = (int[]) null;
    }
    else
    {
      this.width = copyFrom.width;
      this.height = copyFrom.height;
      this.origin = copyFrom.origin;
      this.direction = copyFrom.direction;
      this.randomRange = copyFrom.randomRange;
      this.flattenAnchors = copyFrom.flattenAnchors;
      this.specificRandomStyles = (int[]) null;
      if (copyFrom.specificRandomStyles == null)
        return;
      this.specificRandomStyles = new int[copyFrom.specificRandomStyles.Length];
      copyFrom.specificRandomStyles.CopyTo((Array) this.specificRandomStyles, 0);
    }
  }
}
