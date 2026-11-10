// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.GenShapeDungeonRoomSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class GenShapeDungeonRoomSettings : DungeonRoomSettings
{
  public GenShapeType ShapeType;
  public GenShape InnerShape;
  public GenShape OuterShape;
  public int BoundingRadius;

  public override int GetBoundingRadius() => this.BoundingRadius;
}
