// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalBanners
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalBanners : GlobalDungeonFeature
{
  public DungeonGlobalBanners(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Banners(data);
    this.generated = true;
    return true;
  }

  public void Banners(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = (int) (200.0 * (double) ((float) Main.maxTilesX / 4200f) * Math.Max(1.0, data.globalFeatureScalar * 0.75));
    for (int index1 = 0; index1 < num1; ++index1)
    {
      int index2 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int j = genRand.Next(data.dungeonBounds.Top, data.dungeonBounds.Bottom);
      int num2 = 1000;
      for (; !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, j].wall) || Main.tile[index2, j].active(); j = genRand.Next(data.dungeonBounds.Top, data.dungeonBounds.Bottom))
      {
        --num2;
        if (num2 > 0)
          index2 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
        else
          break;
      }
      int num3 = 1000;
      for (; !WorldGen.SolidTile(index2, j) && j > 10; --j)
      {
        --num3;
        if (num3 <= 0)
          break;
      }
      int index3 = j + 1;
      if (data.CanGenerateFeatureAt((IDungeonFeature) this, index2, index3) && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, index3].wall) && Main.tile[index2, index3 - 1].type != (ushort) 48 /*0x30*/ && !Main.tile[index2, index3].active() && !Main.tile[index2, index3 + 1].active() && !Main.tile[index2, index3 + 2].active() && !Main.tile[index2, index3 + 3].active())
      {
        bool flag = true;
        for (int index4 = index2 - 1; index4 <= index2 + 1; ++index4)
        {
          for (int index5 = index3; index5 <= index3 + 3; ++index5)
          {
            if (Main.tile[index4, index5].active() && (Main.tile[index4, index5].type == (ushort) 10 || Main.tile[index4, index5].type == (ushort) 11 || Main.tile[index4, index5].type == (ushort) 91))
              flag = false;
          }
        }
        if (flag)
        {
          ushort Type = 91;
          DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[index2, index3].wall);
          if (styleForWall == null || styleForWall.BannerItemTypes != null)
          {
            int style;
            if (styleForWall == null || styleForWall.Style == (byte) 0 || styleForWall.BannerItemTypes.Length == 0)
            {
              int num4 = 0;
              if ((int) Main.tile[index2, index3].wall == data.wallVariants[1])
                num4 = 1;
              if ((int) Main.tile[index2, index3].wall == data.wallVariants[2])
                num4 = 2;
              int index6 = num4 * 2 + genRand.Next(2);
              style = data.bannerStyles[index6];
            }
            else
            {
              PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[styleForWall.BannerItemTypes[genRand.Next(styleForWall.BannerItemTypes.Length)]];
              Type = (ushort) derivedPlacementDetail.tileType;
              style = (int) derivedPlacementDetail.tileStyle;
            }
            WorldGen.PlaceTile(index2, index3, (int) Type, true, style: style);
          }
        }
      }
    }
  }
}
