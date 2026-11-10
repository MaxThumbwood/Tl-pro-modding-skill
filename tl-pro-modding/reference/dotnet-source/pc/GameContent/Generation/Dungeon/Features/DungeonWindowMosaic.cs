// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonWindowMosaic
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonWindowMosaic(DungeonFeatureSettings settings) : DungeonWindow(settings)
{
  public override bool GenerateFeature(DungeonData data, int x, int y)
  {
    this.generated = false;
    DungeonGenerationStyleData style = ((DungeonWindowSettings) this.settings).Style;
    if (!this.Window(data, x, y, style, true))
      return false;
    this.generated = true;
    return true;
  }

  public bool Window(
    DungeonData data,
    int placeX,
    int placeY,
    DungeonGenerationStyleData style,
    bool generating = false)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonWindowMosaicSettings settings = (DungeonWindowMosaicSettings) this.settings;
    int overrideGlassPaint = settings.OverrideGlassPaint;
    ushort glassWallType = settings.Closed ? style.WindowClosedGlassWallType : style.WindowGlassWallType;
    ushort windowEdgeWallType = style.WindowEdgeWallType;
    if (settings.OverrideGlassType > 0)
      glassWallType = (ushort) settings.OverrideGlassType;
    this.Bounds.SetBounds(placeX, placeY, placeX + 1, placeY + 1);
    switch (settings.MosaicType)
    {
      case WindowType.SkeletronMosaic:
        this.Window_Skeletron(placeX, placeY, glassWallType, windowEdgeWallType, overrideGlassPaint > 0 ? (byte) overrideGlassPaint : (byte) 0);
        break;
      case WindowType.MoonLordMosaic:
        this.Window_MoonLord(placeX, placeY, glassWallType, windowEdgeWallType, overrideGlassPaint > 0 ? (byte) overrideGlassPaint : (byte) 0);
        break;
    }
    this.Bounds.CalculateHitbox();
    return true;
  }

  public void Window_Skeletron(
    int placeX,
    int placeY,
    ushort glassWallType,
    ushort edgeWallType,
    byte paint = 0)
  {
    Point point1 = new Point(placeX, placeY);
    int width1 = 17;
    int num1 = width1 / 2;
    int height1 = 15;
    int num2 = height1 / 2;
    int width2 = 11;
    int num3 = width2 / 2;
    int height2 = 7;
    int num4 = height2 / 2;
    for (int x = 0; x < width1; ++x)
    {
      int index1 = point1.X + x - num1;
      for (int y = 0; y < height1; ++y)
      {
        if (this.Skeletron_ValidSkullSpot(x, y, width1, height1))
        {
          int index2 = point1.Y + y - num2;
          Tile tile = Main.tile[index1, index2];
          tile.wall = glassWallType;
          if (paint != (byte) 0)
            tile.wallColor(paint);
          if (!this.Skeletron_ValidSkullSpot(x - 1, y, width1, height1))
            Main.tile[index1 - 1, index2].wall = edgeWallType;
          if (!this.Skeletron_ValidSkullSpot(x + 1, y, width1, height1))
            Main.tile[index1 + 1, index2].wall = edgeWallType;
          if (!this.Skeletron_ValidSkullSpot(x, y - 1, width1, height1))
            Main.tile[index1, index2 - 1].wall = edgeWallType;
          if (y < height1 - 1 && !this.Skeletron_ValidSkullSpot(x, y + 1, width1, height1))
            Main.tile[index1, index2 + 1].wall = edgeWallType;
        }
      }
    }
    for (int x = 0; x < width2; ++x)
    {
      int index3 = point1.X + x - num3;
      for (int y = 0; y < height2; ++y)
      {
        int index4 = point1.Y + y + num2 + num4 - 2;
        Tile tile = Main.tile[index3, index4];
        if (this.Skeletron_ValidJawSpot(tile, (int) glassWallType, x, y, width2, height2))
        {
          tile.wall = glassWallType;
          if (paint != (byte) 0)
            tile.wallColor(paint);
          if (!this.Skeletron_ValidJawSpot(Main.tile[index3 - 1, index4], (int) glassWallType, x - 1, y, width2, height2))
            Main.tile[index3 - 1, index4].wall = edgeWallType;
          if (!this.Skeletron_ValidJawSpot(Main.tile[index3 + 1, index4], (int) glassWallType, x + 1, y, width2, height2))
            Main.tile[index3 + 1, index4].wall = edgeWallType;
          if (!this.Skeletron_ValidJawSpot(Main.tile[index3, index4 - 1], (int) glassWallType, x, y - 1, width2, height2))
            Main.tile[index3, index4 - 1].wall = edgeWallType;
          if (!this.Skeletron_ValidJawSpot(Main.tile[index3, index4 + 1], (int) glassWallType, x, y + 1, width2, height2))
            Main.tile[index3, index4 + 1].wall = edgeWallType;
        }
      }
    }
    Point point2 = new Point(point1.X - num1, point1.Y + num2 - 2);
    for (int index5 = 0; index5 < width1; ++index5)
    {
      int index6 = point2.X + index5;
      if (index5 >= 2 && index5 <= 5)
      {
        int num5 = index5 - 2;
        for (int index7 = 0; index7 < 6; ++index7)
        {
          if ((num5 != 3 || index7 > 1) && (num5 != 2 || index7 != 0) && (num5 != 1 || index7 != 5) && (num5 != 0 || index7 < 4))
          {
            Tile tile = Main.tile[index6, point1.Y + index7 - 1];
            tile.wall = edgeWallType;
            tile.wallColor((byte) 0);
          }
        }
      }
      if (index5 >= 11 && index5 <= 14)
      {
        int num6 = index5 - 11;
        for (int index8 = 0; index8 < 6; ++index8)
        {
          if ((num6 != 0 || index8 > 1) && (num6 != 1 || index8 != 0) && (num6 != 2 || index8 != 5) && (num6 != 3 || index8 < 4))
          {
            Tile tile = Main.tile[index6, point1.Y + index8 - 1];
            tile.wall = edgeWallType;
            tile.wallColor((byte) 0);
          }
        }
      }
      if (index5 >= 7 && index5 <= 9)
      {
        int num7 = index5 - 7;
        for (int index9 = 0; index9 < 4; ++index9)
        {
          if ((num7 != 0 && num7 != 2 || index9 != 0) && (num7 != 1 || index9 != 3))
          {
            Tile tile = Main.tile[index6, point1.Y + index9 + 3];
            tile.wall = edgeWallType;
            tile.wallColor((byte) 0);
          }
        }
      }
      int index10 = point2.Y + 1;
      switch (index5)
      {
        case 2:
        case 3:
          ++index10;
          break;
        case 4:
        case 5:
        case 6:
          index10 += 2;
          break;
        case 7:
        case 8:
        case 9:
          index10 += 3;
          break;
        case 10:
        case 11:
        case 12:
          index10 += 2;
          break;
        case 13:
        case 14:
          ++index10;
          break;
      }
      Tile tile1 = Main.tile[index6, index10];
      tile1.wall = edgeWallType;
      tile1.wallColor((byte) 0);
      if (index5 == 0 || index5 == width1 - 1)
      {
        Tile tile2 = Main.tile[index6, index10 - 1];
        Tile tile3 = Main.tile[index6, index10 + 1];
        tile2.wall = tile3.wall = edgeWallType;
        tile2.wallColor((byte) 0);
        tile3.wallColor((byte) 0);
      }
      if (index5 == 4 || index5 == 6 || index5 == 8 || index5 == 10 || index5 == 12)
      {
        for (int index11 = 0; index11 < 4; ++index11)
        {
          Tile tile4 = Main.tile[index6, index10 + index11];
          tile4.wall = edgeWallType;
          tile4.wallColor((byte) 0);
        }
      }
      if (index5 >= 5 && index5 <= 11)
      {
        int index12 = point2.Y + 7;
        if (index5 >= 7 && index5 <= 9)
          ++index12;
        Tile tile5 = Main.tile[index6, index12];
        tile5.wall = edgeWallType;
        tile5.wallColor((byte) 0);
      }
    }
  }

  private bool Skeletron_ValidSkullSpot(int x, int y, int width, int height)
  {
    return x >= 0 && y >= 0 && x < width && y < height && (y != 0 || x > 5 && x < width - 6) && (y != 1 || x > 3 && x < width - 4) && (y != 2 || x > 1 && x < width - 2) && (y != 3 || x != 0 && x < width - 1) && (x != 0 || y < height - 2) && (x > 1 || y != height - 1) && (x != width - 1 || y < height - 2) && (x < width - 2 || y != height - 1);
  }

  private bool Skeletron_ValidJawSpot(
    Tile tile,
    int glassWallType,
    int x,
    int y,
    int width,
    int height)
  {
    return (int) tile.wall == glassWallType || x >= 0 && y >= 0 && x < width && y < height && (y != height - 1 || x > 2 && x < width - 3) && (y != height - 2 || x > 1 && x < width - 2) && (y != height - 3 || x != 0 && x != width - 1);
  }

  public void Window_MoonLord(
    int placeX,
    int placeY,
    ushort glassWallType,
    ushort edgeWallType,
    byte paint = 0)
  {
    int width1 = 8;
    int height1 = width1 - 1;
    int width2 = 7;
    int height2 = width2 - 1;
    int width3 = 7;
    int height3 = width3 + 1;
    int num = 9;
    Point point = new Point(placeX, placeY);
    for (int index = 0; index < 2; ++index)
    {
      bool leftEye = index == 0;
      for (int x1 = 0; x1 < width1; ++x1)
      {
        for (int y1 = 0; y1 < height1; ++y1)
        {
          if (this.MoonLord_ValidSideEyeSpot(x1, y1, leftEye, width1, height1))
          {
            int x2 = point.X + x1 + (leftEye ? -num - 1 : num - width1 + 2);
            int y2 = point.Y + y1 + height1 - 2;
            this.Bounds.UpdateBounds(x2, y2);
            Main.tile[x2, y2].wall = glassWallType;
            if (paint != (byte) 0)
              Main.tile[x2, y2].wallColor(paint);
            if (!this.MoonLord_ValidSideEyeSpot(x1 - 1, y1, leftEye, width1, height1))
            {
              this.Bounds.UpdateBounds(x2 - 1, y2);
              Main.tile[x2 - 1, y2].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x1 + 1, y1, leftEye, width1, height1))
            {
              this.Bounds.UpdateBounds(x2 + 1, y2);
              Main.tile[x2 + 1, y2].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x1, y1 - 1, leftEye, width1, height1))
            {
              this.Bounds.UpdateBounds(x2, y2 - 1);
              Main.tile[x2, y2 - 1].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x1, y1 + 1, leftEye, width1, height1))
            {
              this.Bounds.UpdateBounds(x2, y2 + 1);
              Main.tile[x2, y2 + 1].wall = edgeWallType;
            }
          }
        }
      }
      for (int x3 = 0; x3 < width2; ++x3)
      {
        for (int y3 = 0; y3 < height2; ++y3)
        {
          if (this.MoonLord_ValidSideEyeSpot(x3, y3, leftEye, width2, height2))
          {
            int x4 = point.X + x3 + (leftEye ? -num + 1 : num - width2);
            int y4 = point.Y + y3 - height2 + 2;
            this.Bounds.UpdateBounds(x4 - 1, y4);
            Main.tile[x4, y4].wall = glassWallType;
            if (paint != (byte) 0)
              Main.tile[x4, y4].wallColor(paint);
            if (!this.MoonLord_ValidSideEyeSpot(x3 - 1, y3, leftEye, width2, height2))
            {
              this.Bounds.UpdateBounds(x4 - 1, y4);
              Main.tile[x4 - 1, y4].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x3 + 1, y3, leftEye, width2, height2))
            {
              this.Bounds.UpdateBounds(x4 + 1, y4);
              Main.tile[x4 + 1, y4].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x3, y3 - 1, leftEye, width2, height2))
            {
              this.Bounds.UpdateBounds(x4, y4 - 1);
              Main.tile[x4, y4 - 1].wall = edgeWallType;
            }
            if (!this.MoonLord_ValidSideEyeSpot(x3, y3 + 1, leftEye, width2, height2))
            {
              this.Bounds.UpdateBounds(x4, y4 + 1);
              Main.tile[x4, y4 + 1].wall = edgeWallType;
            }
          }
        }
      }
    }
    for (int x5 = 0; x5 < width3; ++x5)
    {
      for (int y5 = 0; y5 < height3; ++y5)
      {
        if (this.MoonLord_ValidMidEyeSpot(x5, y5, width3, height3))
        {
          int x6 = point.X + x5 - width3 / 2;
          int y6 = point.Y + y5 - height2 - height3;
          this.Bounds.UpdateBounds(x6, y6);
          Main.tile[x6, y6].wall = glassWallType;
          if (paint != (byte) 0)
            Main.tile[x6, y6].wallColor(paint);
          if (!this.MoonLord_ValidMidEyeSpot(x5 - 1, y5, width3, height3))
          {
            this.Bounds.UpdateBounds(x6 - 1, y6);
            Main.tile[x6 - 1, y6].wall = edgeWallType;
          }
          if (!this.MoonLord_ValidMidEyeSpot(x5 + 1, y5, width3, height3))
          {
            this.Bounds.UpdateBounds(x6 + 1, y6);
            Main.tile[x6 + 1, y6].wall = edgeWallType;
          }
          if (!this.MoonLord_ValidMidEyeSpot(x5, y5 - 1, width3, height3))
          {
            this.Bounds.UpdateBounds(x6, y6 - 1);
            Main.tile[x6, y6 - 1].wall = edgeWallType;
          }
          if (!this.MoonLord_ValidMidEyeSpot(x5, y5 + 1, width3, height3))
          {
            this.Bounds.UpdateBounds(x6, y6 + 1);
            Main.tile[x6, y6 + 1].wall = edgeWallType;
          }
        }
      }
    }
  }

  private bool MoonLord_ValidSideEyeSpot(int x, int y, bool leftEye, int width, int height)
  {
    return x >= 0 && y >= 0 && x < width && y < height && (!leftEye || (x > 1 || y != height - 1) && (x != width - 1 || y > 1)) && (!leftEye || (x != 0 || y < height - 2) && (x < width - 2 || y != 0)) && (leftEye || (x > 1 || y != 0) && (x < width - 2 || y != height - 1)) && (leftEye || (x != 0 || y > 1) && (x != width - 1 || y < height - 2));
  }

  private bool MoonLord_ValidMidEyeSpot(int x, int y, int width, int height)
  {
    return x >= 0 && y >= 0 && x < width && y < height && (y != 1 || x != 0 && x != width - 1) && (y != height - 2 || x != 0 && x != width - 1) && (y != 0 || (x < 0 || x > 1) && (x < width - 2 || x > width - 1)) && (y != height - 1 || (x < 0 || x > 1) && (x < width - 2 || x > width - 1));
  }
}
