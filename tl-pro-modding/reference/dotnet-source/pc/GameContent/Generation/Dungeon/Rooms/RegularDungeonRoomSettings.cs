// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.RegularDungeonRoomSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class RegularDungeonRoomSettings : DungeonRoomSettings
{
  public int OverrideInnerBoundsSize;
  public int OverrideOuterBoundsSize;

  public override int GetBoundingRadius()
  {
    return (this.OverrideInnerBoundsSize + this.OverrideOuterBoundsSize) * 142 / 100;
  }
}
