// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TileDataType
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.DataStructures;

[Flags]
public enum TileDataType
{
  Tile = 1,
  TilePaint = 2,
  Wall = 4,
  WallPaint = 8,
  Liquid = 16, // 0x00000010
  Wiring = 32, // 0x00000020
  Actuator = 64, // 0x00000040
  Slope = 128, // 0x00000080
  All = Slope | Actuator | Wiring | Liquid | WallPaint | Wall | TilePaint | Tile, // 0x000000FF
}
