// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.DungeonRoomSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public abstract class DungeonRoomSettings
{
  public DungeonControlLine ControlLine;
  public Point RoomPosition;
  public DungeonRoomType RoomType;
  public int RandomSeed;
  public DungeonGenerationStyleData StyleData;
  public int ProgressionStage;
  public bool StartingRoom;
  public int OverridePaintTile = -1;
  public int OverridePaintWall = -1;
  public bool ForceStyleForDoorsAndPlatforms;
  public bool OnCurvedLine;
  public SnakeOrientation Orientation;
  public DungeonUtils.GetHallwayConnectionPoint HallwayConnectionPointOverride;
  public int? HallwayPointAdjuster;

  public abstract int GetBoundingRadius();
}
