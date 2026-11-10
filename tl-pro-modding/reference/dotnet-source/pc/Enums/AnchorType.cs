// Decompiled with JetBrains decompiler
// Type: Terraria.Enums.AnchorType
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Enums;

[Flags]
public enum AnchorType
{
  None = 0,
  SolidTile = 1,
  SolidWithTop = 2,
  Table = 4,
  SolidSide = 8,
  Tree = 16, // 0x00000010
  AlternateTile = 32, // 0x00000020
  EmptyTile = 64, // 0x00000040
  SolidBottom = 128, // 0x00000080
  Platform = 256, // 0x00000100
  PlanterBox = 512, // 0x00000200
  PlatformNonHammered = 1024, // 0x00000400
  AllFlatHeight = 2048, // 0x00000800
}
