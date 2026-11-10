// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.WormlikeDungeonRoomSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class WormlikeDungeonRoomSettings : DungeonRoomSettings
{
  public int FirstSideIterations;
  public int SecondSideIterations;

  public override int GetBoundingRadius()
  {
    return (int) ((16.200000000000003 + (double) (this.FirstSideIterations + this.SecondSideIterations) * 0.5 * 1.4) * 0.5);
  }
}
