// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonPillar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonPillar : DungeonFeature
{
  public DungeonPillar(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data, int x, int y)
  {
    this.generated = false;
    DungeonGenerationStyleData style = ((DungeonPillarSettings) this.settings).Style;
    if (!this.Pillar(data, x, y, style.BrickTileType, style.BrickWallType, true))
      return false;
    this.generated = true;
    return true;
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return true;
  }

  public bool Pillar(
    DungeonData data,
    int i,
    int j,
    ushort tileType,
    ushort wallType,
    bool generating = false)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonPillarSettings settings = (DungeonPillarSettings) this.settings;
    int width = settings.Width;
    int height = settings.Height;
    bool crowningOnTop = settings.CrowningOnTop;
    bool crowningOnBottom = settings.CrowningOnBottom;
    bool crowningStopsAtPillar = settings.CrowningStopsAtPillar;
    int num1 = 3;
    int num2 = 0;
    this.Bounds.SetBounds(i, j, i, j);
    int num3 = width / 2;
    for (int index = 0; index < width; ++index)
    {
      int num4 = i + index - width / 2;
      int topY = j;
      int bottomY = j;
      DungeonPillar.GenerateTileStrip(settings, true, out topY, out bottomY, num4, j, height, (int) tileType, (int) wallType, false, false);
      this.Bounds.UpdateBounds(num4, topY, num4, bottomY);
      if (crowningOnTop)
      {
        int pillarHeight = crowningStopsAtPillar ? num1 + 1 : 0;
        if (index == 0)
          DungeonPillar.GenerateTileStrip(settings, true, out num2, out num2, num4 - 1, topY + num1, pillarHeight, (int) tileType, (int) wallType, false, true);
        else if (index == width - 1)
          DungeonPillar.GenerateTileStrip(settings, true, out num2, out num2, num4 + 1, topY + num1, pillarHeight, (int) tileType, (int) wallType, false, true);
      }
      if (crowningOnBottom)
      {
        int pillarHeight = crowningStopsAtPillar ? num1 + 1 : 0;
        if (index == 0)
          DungeonPillar.GenerateTileStrip(settings, false, out num2, out num2, num4 - 1, bottomY - num1, pillarHeight, (int) tileType, (int) wallType, true, false);
        else if (index == width - 1)
          DungeonPillar.GenerateTileStrip(settings, false, out num2, out num2, num4 + 1, bottomY - num1, pillarHeight, (int) tileType, (int) wallType, true, false);
      }
    }
    this.Bounds.CalculateHitbox();
    return true;
  }

  public static void GenerateTileStrip(
    DungeonPillarSettings pillarSettings,
    bool upwards,
    out int topY,
    out int bottomY,
    int placeX,
    int placeY,
    int pillarHeight,
    int tileType,
    int wallType,
    bool smoothTop,
    bool smoothBottom)
  {
    PillarType pillarType = pillarSettings.PillarType;
    ushort num1 = pillarType == PillarType.Wall ? (ushort) wallType : (ushort) tileType;
    bool flag1 = pillarType == PillarType.Wall;
    int num2 = flag1 ? pillarSettings.OverridePaintWall : pillarSettings.OverridePaintTile;
    bool flag2 = pillarType == PillarType.BlockActuatedSolidTop || pillarType == PillarType.BlockActuatedSolidTopAndBottom;
    bool flag3 = pillarType == PillarType.BlockActuatedSolidBottom || pillarType == PillarType.BlockActuatedSolidTopAndBottom;
    bool flag4 = pillarType == PillarType.BlockActuated || pillarType == PillarType.BlockActuatedSolidTop || pillarType == PillarType.BlockActuatedSolidBottom || pillarType == PillarType.BlockActuatedSolidTopAndBottom;
    int num3 = pillarHeight;
    if (num3 == 0)
    {
      int num4 = 0;
      if (upwards)
      {
        while (num4 > -100 && WorldGen.InWorld(placeX, placeY + num4, 10) && !Main.tile[placeX, placeY + num4].active())
          --num4;
        num3 = -num4;
      }
      else
      {
        while (num4 < 100 && WorldGen.InWorld(placeX, placeY + num4, 10) && !Main.tile[placeX, placeY + num4].active())
          ++num4;
        num3 = num4;
        placeY += num3 - 1;
      }
    }
    topY = placeY;
    bottomY = placeY;
    if (num3 == 0)
      return;
    int num5 = -num3 + 1;
    int num6 = 0;
    if (upwards)
    {
      for (int index = num5; index <= num6; ++index)
      {
        int y = placeY + index;
        if (y <= 10)
          break;
        Tile tile = Main.tile[placeX, y];
        if (!pillarSettings.AlwaysPlaceEntirePillar && tile.active())
          break;
        if (flag1)
        {
          tile.wall = num1;
          if (num2 >= 0)
            tile.wallColor((byte) num2);
        }
        else
        {
          tile.ClearTile();
          tile.active(true);
          tile.type = num1;
          if (num2 >= 0)
            tile.color((byte) num2);
          if (index == num5 & smoothTop || index == num6 & smoothBottom)
            Tile.SmoothSlope(placeX, y, false);
          if ((!flag2 || index >= num5 + 2) && (!flag3 || index <= num6 - 2) && flag4)
            tile.inActive(true);
        }
        if (y < topY)
          topY = y;
        if (y > bottomY)
          bottomY = y;
      }
    }
    else
    {
      for (int index = num6; index >= num5; --index)
      {
        int y = placeY + index;
        if (y >= Main.maxTilesY - 10)
          break;
        Tile tile = Main.tile[placeX, y];
        if (!pillarSettings.AlwaysPlaceEntirePillar && tile.active())
          break;
        if (flag1)
        {
          tile.wall = num1;
          if (num2 >= 0)
            tile.wallColor((byte) num2);
        }
        else
        {
          tile.ClearTile();
          tile.active(true);
          tile.type = num1;
          if (num2 >= 0)
            tile.color((byte) num2);
          if (index == num5 & smoothTop || index == num6 & smoothBottom)
            Tile.SmoothSlope(placeX, y, false);
          if ((!flag2 || index >= num5 + 2) && (!flag3 || index <= num6 - 2) && flag4)
            tile.inActive(true);
        }
        if (y < topY)
          topY = y;
        if (y > bottomY)
          bottomY = y;
      }
    }
  }
}
