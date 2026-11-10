// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonPillarSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonPillarSettings : DungeonFeatureSettings
{
  public DungeonGenerationStyleData Style;
  public PillarType PillarType;
  public int Width;
  public int Height;
  public bool Wall;
  public int OverridePaintTile = -1;
  public int OverridePaintWall = -1;
  public bool CrowningOnTop;
  public bool CrowningOnBottom;
  public bool CrowningStopsAtPillar;
  public bool AlwaysPlaceEntirePillar = true;
}
