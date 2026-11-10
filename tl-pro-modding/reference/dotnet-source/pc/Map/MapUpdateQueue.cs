// Decompiled with JetBrains decompiler
// Type: Terraria.Map.MapUpdateQueue
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.Map;

public class MapUpdateQueue
{
  private const int MAX_QUEUED_UPDATES = 262144 /*0x040000*/;
  private static List<Microsoft.Xna.Framework.Rectangle> _areaUpdateQueue = new List<Microsoft.Xna.Framework.Rectangle>();
  private static Point16[] _updateQueue = new Point16[1024 /*0x0400*/];
  private static int _updateCount = 0;
  private static readonly object _lock = new object();

  public static void Add(Microsoft.Xna.Framework.Rectangle area)
  {
    if (Main.dedServ || WorldGen.generatingWorld || !Main.mapEnabled)
      return;
    area = WorldUtils.ClampToWorld(area);
    lock (MapUpdateQueue._lock)
    {
      MapUpdateQueue._areaUpdateQueue.Add(area);
      for (int left = area.Left; left < area.Right; ++left)
      {
        for (int top = area.Top; top < area.Bottom; ++top)
          Main.Map.QueueUpdate(left, top);
      }
    }
  }

  public static void Add(int x, int y)
  {
    if (Main.dedServ || WorldGen.generatingWorld || !Main.mapEnabled || !Main.Map.QueueUpdate(x, y))
      return;
    lock (MapUpdateQueue._lock)
    {
      if (MapUpdateQueue._updateCount == MapUpdateQueue._updateQueue.Length)
      {
        if (MapUpdateQueue._updateCount >= 262144 /*0x040000*/)
          return;
        Array.Resize<Point16>(ref MapUpdateQueue._updateQueue, MapUpdateQueue._updateCount * 2);
      }
      MapUpdateQueue._updateQueue[MapUpdateQueue._updateCount++] = new Point16(x, y);
    }
  }

  public static void Update()
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    lock (MapUpdateQueue._lock)
    {
      MapUpdateQueue.UpdateTiles();
      MapUpdateQueue.UpdateAreas();
    }
    TimeLogger.MapChanges.AddTime(fromTimestamp);
  }

  private static void UpdateAreas()
  {
    foreach (Microsoft.Xna.Framework.Rectangle areaUpdate in MapUpdateQueue._areaUpdateQueue)
    {
      for (int left = areaUpdate.Left; left < areaUpdate.Right; ++left)
      {
        for (int top = areaUpdate.Top; top < areaUpdate.Bottom; ++top)
        {
          if (Main.Map.UpdateType(left, top))
            MapRenderer.QueueChange(left, top);
        }
      }
    }
    MapUpdateQueue._areaUpdateQueue.Clear();
  }

  private static void UpdateTiles()
  {
    for (int index = 0; index < MapUpdateQueue._updateCount; ++index)
    {
      Point16 update = MapUpdateQueue._updateQueue[index];
      if (Main.Map.UpdateType((int) update.X, (int) update.Y))
        MapRenderer.QueueChange((int) update.X, (int) update.Y);
    }
    MapUpdateQueue._updateCount = 0;
  }
}
