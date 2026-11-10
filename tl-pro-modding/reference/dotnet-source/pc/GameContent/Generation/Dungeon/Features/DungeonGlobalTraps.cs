// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalTraps
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalTraps : GlobalDungeonFeature
{
  public DungeonGlobalTraps(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Traps(data);
    this.generated = true;
    return true;
  }

  public void Traps(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    float num1 = (float) Main.maxTilesX / 4200f;
    int num2 = 0;
    int num3 = 1000;
    int num4 = 0;
    int num5 = (int) (8.3999996185302734 * (double) num1 * data.globalFeatureScalar);
    Main.tileSolid[379] = false;
    while (num4 < num5)
    {
      ++num2;
      int index1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int index2 = genRand.Next((int) Main.worldSurface, data.dungeonBounds.Bottom);
      if (data.Type == DungeonType.DualDungeon)
      {
        if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, index2].wall) && data.CanGenerateFeatureAt((IDungeonFeature) this, index1, index2) && !DungeonGenerationStyles.Temple.WallIsInStyle((int) Main.tile[index1, index2].wall) && WorldGen.placeTrap(index1, index2, 0))
          num2 = num3;
      }
      else if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, index2].wall) && WorldGen.placeTrap(index1, index2, 0))
        num2 = num3;
      if (num2 > num3)
      {
        ++num4;
        num2 = 0;
      }
    }
    if (data.Type == DungeonType.DualDungeon)
    {
      int num6 = 30;
      switch (WorldGen.GetWorldSize())
      {
        case 0:
          num6 = 30 + genRand.Next(11);
          break;
        case 1:
          num6 = 50 + genRand.Next(16 /*0x10*/);
          break;
        case 2:
          num6 = 70 + genRand.Next(21);
          break;
      }
      if (WorldGen.SecretSeed.Variations.actuallyNoTrapsForRealIMeanIt)
        num6 = 0;
      if (num6 > 0)
      {
        int num7 = num6;
        for (int index = 0; index < data.dungeonHalls.Count; ++index)
        {
          DungeonHall dungeonHall = data.dungeonHalls[index];
          if (dungeonHall.generated && dungeonHall.settings.StyleData.Style == (byte) 10)
          {
            DungeonBounds bounds = dungeonHall.Bounds;
            int x2 = bounds.Left + genRand.Next(bounds.Width);
            int y2 = bounds.Top + genRand.Next(bounds.Height);
            Tile tile = Main.tile[x2, y2];
            if (!tile.active() && DungeonGenerationStyles.Temple.WallIsInStyle((int) tile.wall) && WorldGen.mayanTrap(x2, y2))
            {
              --num7;
              if (num7 <= 0)
                break;
            }
          }
        }
        if (num7 > 0)
        {
          for (int index = 0; index < data.dungeonRooms.Count; ++index)
          {
            DungeonRoom dungeonRoom = data.dungeonRooms[index];
            if (dungeonRoom.generated && dungeonRoom.settings.StyleData.Style == (byte) 10)
            {
              DungeonBounds innerBounds = dungeonRoom.InnerBounds;
              int x2 = innerBounds.Left + genRand.Next(innerBounds.Width);
              int y2 = innerBounds.Top + genRand.Next(innerBounds.Height);
              Tile tile = Main.tile[x2, y2];
              if (!tile.active() && DungeonGenerationStyles.Temple.WallIsInStyle((int) tile.wall) && WorldGen.mayanTrap(x2, y2))
              {
                --num7;
                if (num7 <= 0)
                  break;
              }
            }
          }
        }
        if (num7 > 0)
        {
          for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
          {
            DungeonGenerationStyleData dungeonGenerationStyle = data.genVars.dungeonGenerationStyles[index];
            int style = (int) dungeonGenerationStyle.Style;
            DungeonBounds progressionBound = data.outerProgressionBounds[index];
            if (style == 10)
            {
              int num8 = 1000;
              while (num7 > 0)
              {
                --num8;
                if (num8 > 0)
                {
                  int x2 = progressionBound.Left + genRand.Next(progressionBound.Width);
                  int y2 = progressionBound.Top + genRand.Next(progressionBound.Height);
                  Tile tile = Main.tile[x2, y2];
                  if (!tile.active() && dungeonGenerationStyle.WallIsInStyle((int) tile.wall) && WorldGen.mayanTrap(x2, y2))
                    --num7;
                }
                else
                  break;
              }
              break;
            }
          }
        }
      }
    }
    Main.tileSolid[379] = true;
  }
}
