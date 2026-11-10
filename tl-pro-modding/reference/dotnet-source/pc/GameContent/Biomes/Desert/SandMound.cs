// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.Desert.SandMound
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.Desert;

public static class SandMound
{
  public static void Place(
    DesertDescription description,
    GenerationProgress progress,
    float progressMin,
    float progressMax)
  {
    Microsoft.Xna.Framework.Rectangle desert1 = description.Desert with
    {
      Height = Math.Min(description.Desert.Height, description.Hive.Height / 2)
    };
    Microsoft.Xna.Framework.Rectangle desert2 = description.Desert with
    {
      Y = desert1.Bottom,
      Height = Math.Max(0, description.Desert.Bottom - desert1.Bottom)
    };
    SurfaceMap surface = description.Surface;
    int num1 = 0;
    int num2 = 0;
    progress.Set((double) progressMin);
    int num3 = desert1.Width + 5;
    for (int index1 = -5; index1 < num3; ++index1)
    {
      double num4 = Utils.Clamp<double>(Math.Abs((double) (index1 + 5) / (double) (desert1.Width + 10)) * 2.0 - 1.0, -1.0, 1.0);
      progress.Set((double) (index1 + 5) / (double) (num3 + 5), (double) progressMin, (double) progressMax);
      if (index1 % 3 == 0)
        num1 = Utils.Clamp<int>(num1 + WorldGen.genRand.Next(-1, 2), -10, 10);
      num2 = Utils.Clamp<int>(num2 + WorldGen.genRand.Next(-1, 2), -10, 10);
      double num5 = Math.Sqrt(1.0 - num4 * num4 * num4 * num4);
      int num6 = desert1.Bottom - (int) (num5 * (double) desert1.Height) + num1;
      if (Math.Abs(num4) < 1.0)
      {
        double num7 = Utils.UnclampedSmoothStep(0.5, 0.8, Math.Abs(num4));
        double num8 = num7 * num7 * num7;
        int num9 = Math.Min(10 + (int) ((double) desert1.Top - num8 * 20.0) + num2, num6);
        for (int index2 = (int) surface[index1 + desert1.X] - 1; index2 < num9; ++index2)
        {
          int index3 = index1 + desert1.X;
          int index4 = index2;
          Main.tile[index3, index4].active(false);
          Main.tile[index3, index4].wall = (ushort) 0;
        }
      }
      SandMound.PlaceSandColumn(index1 + desert1.X, num6, desert2.Bottom - num6);
    }
  }

  private static void PlaceSandColumn(int startX, int startY, int height)
  {
    for (int index = startY + height - 1; index >= startY; --index)
    {
      int i = startX;
      int j = index;
      Tile tile1 = Main.tile[i, j];
      if (!WorldGen.remixWorldGen && (!WorldGen.SecretSeed.surfaceIsDesert.Enabled || !WorldGen.SecretSeed.noSurface.Enabled))
        tile1.liquid = (byte) 0;
      Tile tile2 = Main.tile[i, j + 1];
      Tile tile3 = Main.tile[i, j + 2];
      tile1.type = (ushort) 53;
      tile1.slope((byte) 0);
      tile1.halfBrick(false);
      tile1.active(true);
      if (index < startY)
        tile1.active(false);
      WorldGen.SquareWallFrame(i, j);
    }
  }
}
