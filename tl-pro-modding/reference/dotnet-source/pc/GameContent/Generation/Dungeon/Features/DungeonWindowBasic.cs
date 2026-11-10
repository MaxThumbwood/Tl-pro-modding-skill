// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonWindowBasic
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonWindowBasic(DungeonFeatureSettings settings) : DungeonWindow(settings)
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
    DungeonWindowBasicSettings settings = (DungeonWindowBasicSettings) this.settings;
    int width = settings.Width;
    int height = settings.Height;
    int overrideGlassPaint = settings.OverrideGlassPaint;
    ushort num1 = settings.Closed ? style.WindowClosedGlassWallType : style.WindowGlassWallType;
    ushort windowEdgeWallType = style.WindowEdgeWallType;
    int num2 = style.GetWindowPlatformStyle(genRand);
    if (settings.OverrideGlassType > 0)
      num1 = (ushort) settings.OverrideGlassType;
    if (settings.OverridePlatformStyle > -1)
      num2 = settings.OverridePlatformStyle;
    this.Bounds.SetBounds(placeX, placeY, placeX, placeY);
    for (int x = 0; x < width; ++x)
    {
      int index = placeX + x - width / 2;
      for (int y1 = 0; y1 < height; ++y1)
      {
        if (this.Window_ValidWindowSpot(x, y1, width, height))
        {
          int y2 = placeY + y1 - height / 2;
          if (x == width / 2 || y1 == height / 2)
          {
            Main.tile[index, y2].wall = windowEdgeWallType;
          }
          else
          {
            Main.tile[index, y2].wall = num1;
            if (overrideGlassPaint >= 0)
              Main.tile[index, y2].wallColor((byte) overrideGlassPaint);
          }
          this.Bounds.UpdateBounds(index, y2);
          if (!this.Window_ValidWindowSpot(x - 1, y1, width, height))
          {
            Main.tile[index - 1, y2].wall = windowEdgeWallType;
            this.Bounds.UpdateBounds(index - 1, y2);
          }
          if (!this.Window_ValidWindowSpot(x + 1, y1, width, height))
          {
            Main.tile[index + 1, y2].wall = windowEdgeWallType;
            this.Bounds.UpdateBounds(index + 1, y2);
          }
          if (!this.Window_ValidWindowSpot(x, y1 - 1, width, height))
          {
            Main.tile[index, y2 - 1].wall = windowEdgeWallType;
            this.Bounds.UpdateBounds(index, y2 - 1);
          }
          if (!this.Window_ValidWindowSpot(x, y1 + 1, width, height))
          {
            Main.tile[index, y2 + 1].wall = windowEdgeWallType;
            this.Bounds.UpdateBounds(index, y2 + 1);
            if (num2 > -1)
            {
              Main.tile[index, y2 + 1].active(true);
              Main.tile[index, y2 + 1].type = (ushort) 19;
              Main.tile[index, y2 + 1].Clear(TileDataType.Slope);
              Main.tile[index, y2 + 1].frameY = (short) (num2 * 18);
              WorldGen.TileFrame(index, y2 + 1);
            }
          }
        }
      }
    }
    this.Bounds.CalculateHitbox();
    return true;
  }

  private bool Window_ValidWindowSpot(int x, int y, int width, int height)
  {
    return x >= 0 && y >= 0 && x < width && y < height && (y != 0 || x != 0 && x != width - 1);
  }
}
