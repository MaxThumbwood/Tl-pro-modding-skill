// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TileReachCheckSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace Terraria.DataStructures;

public struct TileReachCheckSettings
{
  public int TileRangeMultiplier;
  public int? TileReachLimit;
  public int? OverrideXReach;
  public int? OverrideYReach;
  public static readonly TileReachCheckSettings Simple = new TileReachCheckSettings()
  {
    TileRangeMultiplier = 1,
    TileReachLimit = new int?(20)
  };
  public static readonly TileReachCheckSettings Pylons = new TileReachCheckSettings()
  {
    OverrideXReach = new int?(60),
    OverrideYReach = new int?(60)
  };

  public void GetRanges(out int x, out int y)
  {
    x = Player.tileRangeX * this.TileRangeMultiplier;
    y = Player.tileRangeY * this.TileRangeMultiplier;
    if (this.TileReachLimit.HasValue)
    {
      if (x > this.TileReachLimit.Value)
        x = this.TileReachLimit.Value;
      if (y > this.TileReachLimit.Value)
        y = this.TileReachLimit.Value;
    }
    if (this.OverrideXReach.HasValue)
      x = this.OverrideXReach.Value;
    if (!this.OverrideYReach.HasValue)
      return;
    y = this.OverrideYReach.Value;
  }

  public void GetTileRegion(
    Player player,
    out int LX,
    out int LY,
    out int HX,
    out int HY,
    int TB = 0)
  {
    int x;
    int y;
    this.GetRanges(out x, out y);
    int num1 = x + TB;
    int num2 = y + TB;
    LX = (int) ((double) player.position.X / 16.0) - num1 + 1;
    HX = (int) Math.Ceiling(((double) player.position.X + (double) player.width) / 16.0) + num1 - 2;
    LY = (int) ((double) player.position.Y / 16.0) - num2 + 1;
    HY = (int) Math.Ceiling(((double) player.position.Y + (double) player.height) / 16.0) + num2 - 2;
  }

  public Rectangle GetTileRegion(Player player, int TB = 0)
  {
    int LX;
    int LY;
    int HX;
    int HY;
    this.GetTileRegion(player, out LX, out LY, out HX, out HY, TB);
    return new Rectangle(LX, LY, HX - LX, HY - LY);
  }

  public void GetWorldRegion(
    Player player,
    out int LX,
    out int LY,
    out int HX,
    out int HY,
    int TB = 0)
  {
    this.GetTileRegion(player, out LX, out LY, out HX, out HY, TB);
    LX *= 16 /*0x10*/;
    LY *= 16 /*0x10*/;
    HX *= 16 /*0x10*/;
    HY *= 16 /*0x10*/;
    HX += 15;
    HY += 15;
  }

  public Rectangle GetWorldRegion(Player player, int TB = 0)
  {
    int LX;
    int LY;
    int HX;
    int HY;
    this.GetWorldRegion(player, out LX, out LY, out HX, out HY, TB);
    return new Rectangle(LX, LY, HX - LX, HY - LY);
  }
}
