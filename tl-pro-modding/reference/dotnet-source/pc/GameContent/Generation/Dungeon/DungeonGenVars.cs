// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonGenVars
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System.Collections.Generic;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Entrances;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonGenVars
{
  public int dungeonSide;
  public int dungeonLocation;
  public DungeonColor dungeonColor;
  public ushort brickTileType = 41;
  public ushort brickWallType = 7;
  public ushort brickCrackedTileType = 481;
  public ushort windowGlassWallType = 91;
  public ushort windowClosedGlassWallType = 149;
  public ushort windowEdgeWallType = 8;
  public int[] windowPlatformItemTypes;
  public int generatingDungeonPositionX;
  public int generatingDungeonPositionY;
  public int generatingDungeonTopX;
  public int dungeonLootStyle;
  public DungeonBounds outerPotentialDungeonBounds = new DungeonBounds();
  public DungeonBounds innerPotentialDungeonBounds = new DungeonBounds();
  public DungeonGenerationStyleData dungeonStyle;
  public List<DungeonGenerationStyleData> dungeonGenerationStyles = new List<DungeonGenerationStyleData>();
  public DitherSnake dungeonDitherSnake = new DitherSnake();
  public bool[] isCrackedBrick;
  public bool[] isPitTrapTile;
  public bool[] isDungeonTile;
  public bool[] isDungeonWall;
  public bool[] isDungeonWallGlass;
  public bool GeneratingDungeon;
  public PreGenDungeonEntranceSettings preGenDungeonEntranceSettings;
  public Vector2D dungeonEntrancePosition;
  public bool desertChestLootState;
}
