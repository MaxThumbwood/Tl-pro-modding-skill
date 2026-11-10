// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonDropTrap
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonDropTrap : DungeonFeature
{
  public DungeonDropTrap(DungeonFeatureSettings settings, bool addToFeatures = true)
    : base(settings)
  {
    if (!addToFeatures)
      return;
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data, int x, int y)
  {
    this.generated = false;
    if (!this.DropTrap(data, x, y))
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
    return false;
  }

  public bool DropTrap(DungeonData data, int i, int j)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonDropTrapSettings settings = (DungeonDropTrapSettings) this.settings;
    int num1 = settings.StyleData.Style == (byte) 0 ? 1 : 0;
    ushort num2 = num1 != 0 ? data.genVars.brickTileType : settings.StyleData.BrickTileType;
    ushort num3 = num1 != 0 ? data.genVars.brickWallType : settings.StyleData.BrickWallType;
    ushort num4 = num2;
    int num5 = -1;
    int liquidType = -1;
    switch (settings.DropTrapType)
    {
      case DungeonDropTrapType.Silt:
        num5 = 123;
        break;
      case DungeonDropTrapType.Slush:
        num5 = 224 /*0xE0*/;
        num4 = (ushort) 147;
        break;
      case DungeonDropTrapType.Lava:
        liquidType = 1;
        break;
      default:
        num5 = 53;
        num4 = (ushort) 396;
        break;
    }
    int num6 = 6;
    int num7 = 4;
    int fluff = 25;
    int index1 = i;
    int y = j;
    if (!WorldGen.InWorld(index1, y, fluff))
      return false;
    while (!Main.tile[index1, y].active() && y < Main.UnderworldLayer)
      ++y;
    if (!WorldGen.InWorld(index1, y, fluff) || Main.tile[index1, y - 1].active() || !Main.tileSolid[(int) Main.tile[index1, y].type] || Main.tile[index1, y].halfBrick() || Main.tile[index1, y].topSlope() || (int) Main.tile[index1, y].type != num5 && (int) Main.tile[index1, y].type != (int) num4 && (int) Main.tile[index1, y].type != (int) num2 || (int) Main.tile[index1, y].wall != (int) num3)
      return false;
    int j1 = y - 1;
    Tile tile1 = Main.tile[index1, j1];
    int num8 = -1;
    int num9 = genRand.Next(6, 12);
    int num10 = genRand.Next(6, 14);
    for (int index2 = index1 - fluff; index2 <= index1 + fluff; ++index2)
    {
      for (int index3 = j1 - fluff; index3 < j1 + fluff; ++index3)
      {
        Tile tile2 = Main.tile[index2, index3];
        if (tile2.wire() || TileID.Sets.BasicChest[(int) tile2.type])
          return false;
      }
    }
    for (int index4 = j1; index4 > j1 - 30; --index4)
    {
      if (Main.tile[index1, index4].active())
      {
        if ((int) Main.tile[index1, index4].type != (int) num2)
          return false;
        num8 = index4;
        break;
      }
    }
    if (num8 <= -1 || j1 - num8 < num10 + num7)
      return false;
    int num11 = 0;
    int num12 = (j1 + num8) / 2;
    for (int index5 = index1 - num9; index5 <= index1 + num9; ++index5)
    {
      for (int index6 = num8 - num10; index6 <= num8; ++index6)
      {
        Tile tile3 = Main.tile[index5, index6];
        if (tile3.active() && Main.tileSolid[(int) tile3.type])
          ++num11;
      }
    }
    double num13 = (double) ((num9 * 2 + 1) * (num10 + 1)) * 0.75;
    if ((double) num11 < num13)
      return false;
    this.Bounds.SetBounds(index1 - num9 - 1, num8 - num10, index1 + num9 + 1, num8 + 20);
    this.Bounds.CalculateHitbox();
    if (!data.CanGenerateFeatureInArea((IDungeonFeature) this, this.Bounds))
      return false;
    this.Bounds = new DungeonBounds();
    for (int index7 = index1 - num9 - 1; index7 <= index1 + num9 + 1; ++index7)
    {
      for (int index8 = num8 - num10; index8 <= num8; ++index8)
      {
        bool flag = false;
        if (Main.tile[index7, index8].active() && Main.tileSolid[(int) Main.tile[index7, index8].type])
          flag = true;
        if (index8 == num8)
        {
          Main.tile[index7, index8].slope((byte) 0);
          Main.tile[index7, index8].halfBrick(false);
          if (!flag)
          {
            Main.tile[index7, index8].active(true);
            Main.tile[index7, index8].type = num2;
          }
        }
        else if (index8 == num8 - num10)
        {
          Main.tile[index7, index8].ClearTile();
          Main.tile[index7, index8].active(true);
          Main.tile[index7, index8].type = !flag || !Main.tile[index7, index8 - 1].active() || !Main.tileSolid[(int) Main.tile[index7, index8 - 1].type] ? num2 : num4;
        }
        else if (index7 == index1 - num9 - 1 || index7 == index1 + num9 + 1)
        {
          if (!flag)
          {
            Main.tile[index7, index8].ClearTile();
            Main.tile[index7, index8].active(true);
            Main.tile[index7, index8].type = num2;
          }
          else
          {
            Main.tile[index7, index8].slope((byte) 0);
            Main.tile[index7, index8].halfBrick(false);
          }
        }
        else
        {
          Main.tile[index7, index8].ClearTile();
          if (liquidType > -1)
          {
            Main.tile[index7, index8].liquid = byte.MaxValue;
            Main.tile[index7, index8].liquidType(liquidType);
          }
          else
          {
            Main.tile[index7, index8].active(true);
            Main.tile[index7, index8].type = (ushort) num5;
          }
        }
      }
    }
    for (int index9 = (int) ((double) num8 - (double) num10 * 0.6600000262260437); (double) index9 <= (double) num8 - (double) num10 * 0.33000001311302185; ++index9)
    {
      if ((double) index9 < (double) num8 - (double) num10 * 0.40000000596046448)
      {
        if (Main.tile[index1 - num9 - 2, index9].bottomSlope())
          Main.tile[index1 - num9 - 2, index9].slope((byte) 0);
      }
      else if ((double) index9 > (double) num8 - (double) num10 * 0.60000002384185791)
      {
        if (Main.tile[index1 - num9 - 2, index9].topSlope())
          Main.tile[index1 - num9 - 2, index9].slope((byte) 0);
        Main.tile[index1 - num9 - 2, index9].halfBrick(false);
      }
      else
      {
        Main.tile[index1 - num9 - 2, index9].halfBrick(false);
        Main.tile[index1 - num9 - 2, index9].slope((byte) 0);
      }
      if (!Main.tile[index1 - num9 - 2, index9].active() || !Main.tileSolid[(int) Main.tile[index1 - num9 - 2, index9].type])
      {
        Main.tile[index1 - num9 - 2, index9].active(true);
        Main.tile[index1 - num9 - 2, index9].type = num2;
      }
      if (!Main.tile[index1 + num9 + 2, index9].active() || !Main.tileSolid[(int) Main.tile[index1 + num9 + 2, index9].type])
      {
        Main.tile[index1 + num9 + 2, index9].active(true);
        Main.tile[index1 + num9 + 2, index9].type = num2;
      }
    }
    for (int index10 = num8 - num10; index10 <= num8; ++index10)
    {
      Main.tile[index1 - num9 - 2, index10].slope((byte) 0);
      Main.tile[index1 - num9 - 2, index10].halfBrick(false);
      Main.tile[index1 - num9 - 1, index10].slope((byte) 0);
      Main.tile[index1 - num9 - 1, index10].halfBrick(false);
      Main.tile[index1 - num9 + 1, index10].slope((byte) 0);
      Main.tile[index1 - num9 + 1, index10].halfBrick(false);
      Main.tile[index1 - num9 + 2, index10].slope((byte) 0);
      Main.tile[index1 - num9 + 2, index10].halfBrick(false);
    }
    for (int index11 = index1 - num9 - 1; index11 < index1 + num9 + 1; ++index11)
    {
      int index12 = j1 - num10 - 1;
      if (Main.tile[index11, index12].bottomSlope())
        Main.tile[index11, index12].slope((byte) 0);
      Main.tile[index11, index12].halfBrick(false);
    }
    WorldGen.KillTile(index1 - 2, j1);
    WorldGen.KillTile(index1 - 1, j1);
    WorldGen.KillTile(index1 + 1, j1);
    WorldGen.KillTile(index1 + 2, j1);
    WorldGen.PlaceTile(index1, j1, 135, true, style: 7);
    for (int i1 = index1 - num9; i1 <= index1 + num9; ++i1)
    {
      int num14 = j1;
      if ((double) i1 < (double) index1 - (double) num9 * 0.800000011920929 || (double) i1 > (double) index1 + (double) num9 * 0.800000011920929)
        num14 = j1 - 3;
      else if ((double) i1 < (double) index1 - (double) num9 * 0.60000002384185791 || (double) i1 > (double) index1 + (double) num9 * 0.60000002384185791)
        num14 = j1 - 2;
      else if ((double) i1 < (double) index1 - (double) num9 * 0.40000000596046448 || (double) i1 > (double) index1 + (double) num9 * 0.40000000596046448)
        num14 = j1 - 1;
      for (int j2 = num8; j2 <= j1; ++j2)
      {
        if (i1 == index1 && j2 <= j1)
          Main.tile[index1, j2].wire(true);
        if (Main.tile[i1, j2].active() && Main.tileSolid[(int) Main.tile[i1, j2].type])
        {
          if (j2 < num8 + num6 - 4)
          {
            Main.tile[i1, j2].actuator(true);
            Main.tile[i1, j2].wire(true);
          }
          else if (j2 < num14)
            WorldGen.KillTile(i1, j2);
        }
      }
    }
    int maxY = j1;
    for (int index13 = index1 - num9; index13 <= index1 + num9; ++index13)
    {
      for (int index14 = maxY; index14 < Main.UnderworldLayer; ++index14)
      {
        if (index14 >= maxY)
        {
          Tile tile4 = Main.tile[index13, index14];
          if (tile4.active() && !TileID.Sets.Platforms[(int) tile4.type] && Main.tileSolid[(int) tile4.type])
          {
            maxY = index14;
            break;
          }
        }
      }
    }
    this.Bounds.SetBounds(index1 - num9 - 1, num8 - num10, index1 + num9 + 1, maxY);
    this.Bounds.CalculateHitbox();
    return true;
  }
}
