// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonTileClumpSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonTileClumpSettings : DungeonFeatureSettings
{
  public int RandomSeed;
  public double Strength;
  public int Steps;
  public ushort TileType;
  public ushort WallType;
  public DungeonBounds AreaToGenerateIn;
  public ushort? OnlyReplaceThisTileType;
  public ushort? OnlyReplaceThisWallType;
}
