// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.TeleportPylonInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent;

public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
{
  public Point16 PositionInTiles;
  public TeleportPylonType TypeOfPylon;

  public bool Equals(TeleportPylonInfo other)
  {
    return this.PositionInTiles == other.PositionInTiles && this.TypeOfPylon == other.TypeOfPylon;
  }
}
