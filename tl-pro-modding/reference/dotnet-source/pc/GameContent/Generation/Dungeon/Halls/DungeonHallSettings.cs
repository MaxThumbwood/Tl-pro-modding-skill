// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.DungeonHallSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public abstract class DungeonHallSettings
{
  public DungeonHallType HallType;
  public int RandomSeed;
  public DungeonGenerationStyleData StyleData;
  public int OverridePaintTile = -1;
  public int OverridePaintWall = -1;
  public double CrackedBrickChance = 0.166;
  public bool PlaceOverProtectedBricks;
  public double ZigzagChance = 0.66;
  public bool ForceStyleForDoorsAndPlatforms;
  public bool CarveOnly;
}
