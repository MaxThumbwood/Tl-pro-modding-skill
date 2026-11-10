// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.ActiveSections
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace Terraria.DataStructures;

public static class ActiveSections
{
  public static readonly uint SectionInactiveTime = 60;
  private static uint[,] LastActiveTime = new uint[Main.maxTilesX / 200 + 1, Main.maxTilesY / 150 + 1];

  public static event Action<Point> SectionActivated;

  public static void CheckSection(Vector2 position, int fluff = 1)
  {
    int sectionX = Netplay.GetSectionX((int) ((double) position.X / 16.0));
    int sectionY = Netplay.GetSectionY((int) ((double) position.Y / 16.0));
    for (int x = sectionX - fluff; x < sectionX + fluff + 1; ++x)
    {
      for (int y = sectionY - fluff; y < sectionY + fluff + 1; ++y)
      {
        if (x >= 0 && x < Main.maxSectionsX && y >= 0 && y < Main.maxSectionsY)
        {
          int num = ActiveSections.IsSectionActive(new Point(x, y)) ? 1 : 0;
          ActiveSections.LastActiveTime[x, y] = Main.GameUpdateCount;
          if (num == 0)
            ActiveSections.SectionActivated(new Point(x, y));
        }
      }
    }
  }

  public static bool IsSectionActive(Point sectionCoords)
  {
    sectionCoords = sectionCoords.ClampSectionCoords();
    return ActiveSections.LastActiveTime[sectionCoords.X, sectionCoords.Y] + ActiveSections.SectionInactiveTime >= Main.GameUpdateCount;
  }

  public static int TimeTillInactive(Point sectionCoords)
  {
    sectionCoords = sectionCoords.ClampSectionCoords();
    return (int) Math.Max(0L, (long) (ActiveSections.LastActiveTime[sectionCoords.X, sectionCoords.Y] + ActiveSections.SectionInactiveTime) - (long) Main.GameUpdateCount);
  }

  public static void Reset()
  {
    Array.Clear((Array) ActiveSections.LastActiveTime, 0, ActiveSections.LastActiveTime.Length);
  }

  public static Point ClampSectionCoords(this Point point)
  {
    return new Point(Utils.Clamp<int>(point.X, 0, Main.maxSectionsX), Utils.Clamp<int>(point.Y, 0, Main.maxSectionsY));
  }
}
