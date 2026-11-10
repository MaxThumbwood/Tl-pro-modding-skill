// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.AEntitySource_Tile
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public abstract class AEntitySource_Tile : IEntitySource
{
  public readonly Point TileCoords;

  public AEntitySource_Tile(int tileCoordsX, int tileCoordsY)
  {
    this.TileCoords = new Point(tileCoordsX, tileCoordsY);
  }
}
