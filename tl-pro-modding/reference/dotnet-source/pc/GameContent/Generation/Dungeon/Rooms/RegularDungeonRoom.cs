// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.RegularDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class RegularDungeonRoom(DungeonRoomSettings settings) : DungeonRoom(settings)
{
  public int _innerBoundsSize;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.RegularRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.RegularRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public void RegularRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    RegularDungeonRoomSettings settings = (RegularDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Point point = new Point(i, j);
    if (this.Processed)
      point = this.InnerBounds.Center;
    int innerBoundsSize = 6 + unifiedRandom.Next(7);
    int num = 8;
    if (settings.OverrideInnerBoundsSize > 0)
      innerBoundsSize = settings.OverrideInnerBoundsSize;
    if (settings.OverrideOuterBoundsSize > 0)
      num = settings.OverrideOuterBoundsSize;
    if (this.Processed)
      innerBoundsSize = this._innerBoundsSize;
    int totalBoundsSize = innerBoundsSize + num;
    this.InnerBounds.SetBounds(point.X, point.Y, point.X, point.Y);
    this.OuterBounds.SetBounds(point.X, point.Y, point.X, point.Y);
    this.OuterBounds.UpdateBounds(point.X - totalBoundsSize, point.Y - totalBoundsSize, point.X + totalBoundsSize, point.Y + totalBoundsSize);
    this.InnerBounds.UpdateBounds(this.OuterBounds.Left + num, this.OuterBounds.Top + num, this.OuterBounds.Right - num, this.OuterBounds.Bottom - num);
    this.GenerateDungeonSquareRoom(data, this.InnerBounds, this.OuterBounds, Vector2D.op_Implicit(point), brickTileType, brickWallType, innerBoundsSize, totalBoundsSize, generating, generating);
    this._innerBoundsSize = innerBoundsSize;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
  }
}
