// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalSpikes
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalSpikes : GlobalDungeonFeature
{
  public DungeonGlobalSpikes(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Spikes(data);
    this.generated = true;
    return true;
  }

  public void Spikes(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int wallVariant = data.wallVariants[0];
    float num1 = (float) Main.maxTilesX / 4200f;
    int num2 = 0;
    int num3 = 1000;
    int num4 = 0;
    double num5 = Math.Max(1.0, data.globalFeatureScalar * 0.25);
    int num6 = (int) (42.0 * (double) num1 * num5);
    if (WorldGen.getGoodWorldGen)
      num6 *= 3;
    while (num4 < num6)
    {
      ++num2;
      int x1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int y = genRand.Next((int) Main.worldSurface + 25, data.dungeonBounds.Bottom);
      if (WorldGen.drunkWorldGen || WorldGen.SecretSeed.noSurface.Enabled)
        y = genRand.Next(data.genVars.generatingDungeonPositionY + 25, data.dungeonBounds.Bottom);
      int num7 = x1;
      ushort num8 = 48 /*0x30*/;
      bool flag1 = true;
      bool flag2 = (int) Main.tile[x1, y].wall == wallVariant;
      if (data.Type == DungeonType.DualDungeon)
      {
        flag2 = DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x1, y].wall);
        if (Main.tile[x1, y].wall == (ushort) 87)
        {
          num8 = (ushort) 232;
          flag1 = false;
        }
      }
      if (flag2 && !Main.tile[x1, y].active())
      {
        int num9 = 1;
        if (genRand.Next(2) == 0)
          num9 = -1;
        while (!Main.tile[x1, y].active())
          y += num9;
        if (Main.tile[x1 - 1, y].active() && Main.tile[x1 + 1, y].active() && this.Spikes_CanSupportSpike(x1 - 1, y) && !Main.tile[x1 - 1, y - num9].active() && !Main.tile[x1 + 1, y - num9].active())
        {
          ++num4;
          int num10 = genRand.Next(5, 13);
          while (Main.tile[x1 - 1, y].active() && this.Spikes_CanSupportSpike(x1 - 1, y) && Main.tile[x1, y + num9].active() && Main.tile[x1, y].active() && !Main.tile[x1, y - num9].active() && num10 > 0)
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, x1, y) || !data.CanGenerateFeatureAt((IDungeonFeature) this, x1, y - num9))
            {
              --x1;
              num10 = 0;
            }
            else
            {
              Main.tile[x1, y].type = num8;
              if (!Main.tile[x1 - 1, y - num9].active() && !Main.tile[x1 + 1, y - num9].active())
              {
                Main.tile[x1, y - num9].Clear(TileDataType.Slope);
                Main.tile[x1, y - num9].type = num8;
                Main.tile[x1, y - num9].active(true);
                if (flag1)
                {
                  Main.tile[x1, y - num9 * 2].Clear(TileDataType.Slope);
                  Main.tile[x1, y - num9 * 2].type = num8;
                  Main.tile[x1, y - num9 * 2].active(true);
                }
              }
              --x1;
              --num10;
            }
          }
          int num11 = genRand.Next(5, 13);
          int x2 = num7 + 1;
          while (Main.tile[x2 + 1, y].active() && this.Spikes_CanSupportSpike(x2 + 1, y) && Main.tile[x2, y + num9].active() && Main.tile[x2, y].active() && !Main.tile[x2, y - num9].active() && num11 > 0)
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, x2, y) || !data.CanGenerateFeatureAt((IDungeonFeature) this, x2, y - num9))
            {
              ++x2;
              num11 = 0;
            }
            else
            {
              Main.tile[x2, y].type = num8;
              if (!Main.tile[x2 - 1, y - num9].active() && !Main.tile[x2 + 1, y - num9].active())
              {
                Main.tile[x2, y - num9].Clear(TileDataType.Slope);
                Main.tile[x2, y - num9].type = num8;
                Main.tile[x2, y - num9].active(true);
                if (flag1)
                {
                  Main.tile[x2, y - num9 * 2].Clear(TileDataType.Slope);
                  Main.tile[x2, y - num9 * 2].type = num8;
                  Main.tile[x2, y - num9 * 2].active(true);
                }
              }
              ++x2;
              --num11;
            }
          }
        }
      }
      if (num2 > num3)
      {
        num2 = 0;
        ++num4;
      }
    }
    int num12 = 0;
    int num13 = 1000;
    int num14 = 0;
    while (num14 < num6)
    {
      ++num12;
      int x = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int y1 = genRand.Next((int) Main.worldSurface + 25, data.dungeonBounds.Bottom);
      if (WorldGen.SecretSeed.noSurface.Enabled)
        y1 = genRand.Next(data.genVars.generatingDungeonPositionY + 25, data.dungeonBounds.Bottom);
      int num15 = y1;
      ushort num16 = 48 /*0x30*/;
      bool flag3 = true;
      bool flag4 = (int) Main.tile[x, y1].wall == wallVariant;
      if (data.Type == DungeonType.DualDungeon)
      {
        flag4 = DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, y1].wall);
        if (Main.tile[x, y1].wall == (ushort) 87)
        {
          num16 = (ushort) 232;
          flag3 = false;
        }
      }
      if (flag4 && !Main.tile[x, y1].active())
      {
        int num17 = 1;
        if (genRand.Next(2) == 0)
          num17 = -1;
        while (x > 5 && x < Main.maxTilesX - 5 && !Main.tile[x, y1].active())
          x += num17;
        if (Main.tile[x, y1 - 1].active() && Main.tile[x, y1 + 1].active() && this.Spikes_CanSupportSpike(x, y1 - 1) && !Main.tile[x - num17, y1 - 1].active() && !Main.tile[x - num17, y1 + 1].active())
        {
          ++num14;
          int num18 = genRand.Next(5, 13);
          while (Main.tile[x, y1 - 1].active() && this.Spikes_CanSupportSpike(x, y1 - 1) && Main.tile[x + num17, y1].active() && Main.tile[x, y1].active() && !Main.tile[x - num17, y1].active() && num18 > 0)
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, x, y1) || !data.CanGenerateFeatureAt((IDungeonFeature) this, x - num17, y1))
            {
              --y1;
              num18 = 0;
            }
            else
            {
              Main.tile[x, y1].type = num16;
              if (!Main.tile[x - num17, y1 - 1].active() && !Main.tile[x - num17, y1 + 1].active())
              {
                Main.tile[x - num17, y1].type = num16;
                Main.tile[x - num17, y1].active(true);
                Main.tile[x - num17, y1].Clear(TileDataType.Slope);
                if (flag3)
                {
                  Main.tile[x - num17 * 2, y1].type = num16;
                  Main.tile[x - num17 * 2, y1].active(true);
                  Main.tile[x - num17 * 2, y1].Clear(TileDataType.Slope);
                }
              }
              --y1;
              --num18;
            }
          }
          int num19 = genRand.Next(5, 13);
          int y2 = num15 + 1;
          while (Main.tile[x, y2 + 1].active() && this.Spikes_CanSupportSpike(x, y2 + 1) && Main.tile[x + num17, y2].active() && Main.tile[x, y2].active() && !Main.tile[x - num17, y2].active() && num19 > 0)
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, x, y2) || !data.CanGenerateFeatureAt((IDungeonFeature) this, x - num17, y2))
            {
              ++y2;
              num19 = 0;
            }
            else
            {
              Main.tile[x, y2].type = num16;
              if (!Main.tile[x - num17, y2 - 1].active() && !Main.tile[x - num17, y2 + 1].active())
              {
                Main.tile[x - num17, y2].type = num16;
                Main.tile[x - num17, y2].active(true);
                Main.tile[x - num17, y2].Clear(TileDataType.Slope);
                if (flag3)
                {
                  Main.tile[x - num17 * 2, y2].type = num16;
                  Main.tile[x - num17 * 2, y2].active(true);
                  Main.tile[x - num17 * 2, y2].Clear(TileDataType.Slope);
                }
              }
              ++y2;
              --num19;
            }
          }
        }
      }
      if (num12 > num13)
      {
        num12 = 0;
        ++num14;
      }
    }
  }

  private bool Spikes_CanSupportSpike(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    return tile.active() && (tile.type < (ushort) 0 || !Main.tileFrameImportant[(int) tile.type] && !Main.tileCut[(int) tile.type]) && !DungeonUtils.IsConsideredCrackedDungeonTile((int) tile.type);
  }
}
