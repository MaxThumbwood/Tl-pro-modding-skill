// Decompiled with JetBrains decompiler
// Type: Terraria.TileColorCache
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria;

public struct TileColorCache
{
  public byte Color;
  public bool FullBright;
  public bool Invisible;

  public void ApplyToBlock(Tile tile)
  {
    tile.color(this.Color);
    tile.fullbrightBlock(this.FullBright);
    tile.invisibleBlock(this.Invisible);
  }

  public void ApplyToWall(Tile tile)
  {
    tile.wallColor(this.Color);
    tile.fullbrightWall(this.FullBright);
    tile.invisibleWall(this.Invisible);
  }
}
