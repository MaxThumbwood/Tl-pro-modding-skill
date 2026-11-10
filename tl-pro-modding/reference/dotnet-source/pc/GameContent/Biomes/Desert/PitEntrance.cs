// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.Desert.PitEntrance
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.Desert;

public static class PitEntrance
{
  public static void Place(
    DesertDescription description,
    GenerationProgress progress,
    float progressMin,
    float progressMax)
  {
    int holeRadius = WorldGen.genRand.Next(6, 9);
    Point center = description.CombinedArea.Center;
    center.Y = (int) description.Surface[center.X];
    PitEntrance.PlaceAt(description, center, holeRadius, progress, progressMin, progressMax);
  }

  private static void PlaceAt(
    DesertDescription description,
    Point position,
    int holeRadius,
    GenerationProgress progress,
    float progressMin,
    float progressMax)
  {
    int num1 = holeRadius + 3;
    int num2 = num1 + holeRadius + 3;
    for (int index = -holeRadius - 3; index < holeRadius + 3; ++index)
    {
      progress.Set((double) (index + num1) / (double) num2, (double) progressMin, (double) progressMax);
      int j = (int) description.Surface[index + position.X];
      while (true)
      {
        int num3 = j;
        Microsoft.Xna.Framework.Rectangle rectangle = description.Hive;
        int num4 = rectangle.Top + 10;
        if (num3 <= num4)
        {
          double num5 = (double) (j - (int) description.Surface[index + position.X]);
          rectangle = description.Hive;
          int top1 = rectangle.Top;
          rectangle = description.Desert;
          int top2 = rectangle.Top;
          double num6 = (double) (top1 - top2);
          double yProgress = Utils.Clamp<double>(num5 / num6, 0.0, 1.0);
          int num7 = (int) (PitEntrance.GetHoleRadiusScaleAt(yProgress) * (double) holeRadius);
          if (Math.Abs(index) < num7)
            Main.tile[index + position.X, j].ClearEverything();
          else if (Math.Abs(index) < num7 + 3 && yProgress > 0.35)
            Main.tile[index + position.X, j].ResetToType((ushort) 397);
          double num8 = Math.Abs((double) index / (double) holeRadius);
          double num9 = num8 * num8;
          if (Math.Abs(index) < num7 + 3 && (double) (j - position.Y) > 15.0 - 3.0 * num9)
          {
            Main.tile[index + position.X, j].wall = (ushort) 187;
            WorldGen.SquareWallFrame(index + position.X, j - 1);
            WorldGen.SquareWallFrame(index + position.X, j);
          }
          ++j;
        }
        else
          break;
      }
    }
    holeRadius += 4;
    for (int index1 = -holeRadius; index1 < holeRadius; ++index1)
    {
      int num10 = holeRadius - Math.Abs(index1);
      int num11 = Math.Min(10, num10 * num10);
      for (int index2 = 0; index2 < num11; ++index2)
        Main.tile[index1 + position.X, index2 + (int) description.Surface[index1 + position.X]].ClearEverything();
    }
  }

  private static double GetHoleRadiusScaleAt(double yProgress)
  {
    return yProgress < 0.6 ? 1.0 : (1.0 - PitEntrance.SmootherStep((yProgress - 0.6) / 0.4)) * 0.5 + 0.5;
  }

  private static double SmootherStep(double delta)
  {
    delta = Utils.Clamp<double>(delta, 0.0, 1.0);
    return 1.0 - Math.Cos(delta * 3.1415927410125732) * 0.5 - 0.5;
  }
}
