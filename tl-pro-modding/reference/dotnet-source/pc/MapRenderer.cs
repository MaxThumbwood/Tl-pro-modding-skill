// Decompiled with JetBrains decompiler
// Type: Terraria.MapRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Map;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria;

public class MapRenderer
{
  public static readonly int textureMaxWidth = 2000;
  public static readonly int textureMaxHeight = 1800;
  private static readonly int numTargetsX = 5;
  private static readonly int numTargetsY = 2;
  private static readonly Color[] _mapColorCacheArray = new Color[30000];
  private static RenderTarget2D mapSectionTexture;
  private static readonly RenderTarget2D[,] mapTarget = new RenderTarget2D[MapRenderer.numTargetsX, MapRenderer.numTargetsY];
  private static readonly bool[,] initMap = new bool[MapRenderer.numTargetsX, MapRenderer.numTargetsY];
  private static readonly bool[,] mapWasContentLost = new bool[MapRenderer.numTargetsX, MapRenderer.numTargetsY];
  private static readonly List<Point16>[,] changeQueues = new List<Point16>[MapRenderer.numTargetsX, MapRenderer.numTargetsY];
  private static readonly int ChangeRefreshThreshold = 2048 /*0x0800*/;

  public static bool ChangesQueued
  {
    get
    {
      List<Point16>[,] changeQueues = MapRenderer.changeQueues;
      int upperBound1 = changeQueues.GetUpperBound(0);
      int upperBound2 = changeQueues.GetUpperBound(1);
      for (int lowerBound1 = changeQueues.GetLowerBound(0); lowerBound1 <= upperBound1; ++lowerBound1)
      {
        for (int lowerBound2 = changeQueues.GetLowerBound(1); lowerBound2 <= upperBound2; ++lowerBound2)
        {
          if (changeQueues[lowerBound1, lowerBound2].Count > 0)
            return true;
        }
      }
      return false;
    }
  }

  private static GraphicsDevice GraphicsDevice => Main.instance.GraphicsDevice;

  static MapRenderer()
  {
    for (int index1 = 0; index1 < MapRenderer.numTargetsX; ++index1)
    {
      for (int index2 = 0; index2 < MapRenderer.numTargetsY; ++index2)
        MapRenderer.changeQueues[index1, index2] = new List<Point16>(MapRenderer.ChangeRefreshThreshold);
    }
  }

  private static bool checkMap(int i, int j)
  {
    if (MapRenderer.mapTarget[i, j] == null || MapRenderer.mapTarget[i, j].IsDisposed)
      MapRenderer.initMap[i, j] = false;
    if (MapRenderer.initMap[i, j])
      return true;
    try
    {
      int width = MapRenderer.textureMaxWidth;
      int height = MapRenderer.textureMaxHeight;
      if (i == MapRenderer.numTargetsX - 1)
        width = 400;
      if (j == MapRenderer.numTargetsY - 1)
        height = 600;
      MapRenderer.mapTarget[i, j] = new RenderTarget2D(MapRenderer.GraphicsDevice, width, height, false, MapRenderer.GraphicsDevice.PresentationParameters.BackBufferFormat, DepthFormat.None, 0, RenderTargetUsage.PreserveContents);
      MapRenderer.initMap[i, j] = true;
      return true;
    }
    catch
    {
      Main.mapEnabled = false;
      for (int index1 = 0; index1 < MapRenderer.numTargetsX; ++index1)
      {
        for (int index2 = 0; index2 < MapRenderer.numTargetsY; ++index2)
        {
          try
          {
            MapRenderer.initMap[index1, index2] = false;
            MapRenderer.mapTarget[index1, index2].Dispose();
          }
          catch
          {
          }
        }
      }
      return false;
    }
  }

  public static void DrawToMap(Microsoft.Xna.Framework.Rectangle area)
  {
    if (!Main.mapEnabled)
      return;
    area = WorldUtils.ClampToWorld(area);
    int num1 = Main.maxTilesX / MapRenderer.textureMaxWidth;
    int num2 = Main.maxTilesY / MapRenderer.textureMaxHeight;
    for (int i = 0; i <= num1; ++i)
    {
      for (int j = 0; j <= num2; ++j)
      {
        if (!MapRenderer.checkMap(i, j))
          return;
      }
    }
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    if (Main.clearMap || Main.refreshMap)
    {
      List<Point16>[,] changeQueues = MapRenderer.changeQueues;
      int upperBound1 = changeQueues.GetUpperBound(0);
      int upperBound2 = changeQueues.GetUpperBound(1);
      for (int lowerBound1 = changeQueues.GetLowerBound(0); lowerBound1 <= upperBound1; ++lowerBound1)
      {
        for (int lowerBound2 = changeQueues.GetLowerBound(1); lowerBound2 <= upperBound2; ++lowerBound2)
          changeQueues[lowerBound1, lowerBound2].Clear();
      }
    }
    if (Main.clearMap)
    {
      for (int index1 = 0; index1 <= num1; ++index1)
      {
        for (int index2 = 0; index2 <= num2; ++index2)
        {
          MapRenderer.GraphicsDevice.SetRenderTarget(MapRenderer.mapTarget[index1, index2]);
          MapRenderer.GraphicsDevice.Clear(Color.Transparent);
          MapRenderer.GraphicsDevice.SetRenderTarget((RenderTarget2D) null);
        }
      }
      Main.clearMap = false;
    }
    RenderTarget2D activeTarget = (RenderTarget2D) null;
    int updateCount = 0;
    for (int rX = 0; rX < MapRenderer.numTargetsX && updateCount < Main.maxMapUpdates; ++rX)
    {
      for (int rY = 0; rY < MapRenderer.numTargetsY && updateCount < Main.maxMapUpdates; ++rY)
      {
        Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle(rX * MapRenderer.textureMaxWidth, rY * MapRenderer.textureMaxHeight, MapRenderer.textureMaxWidth, MapRenderer.textureMaxHeight);
        MapRenderer.DrawAreaToMap(Microsoft.Xna.Framework.Rectangle.Intersect(area, rectangle), rX, rY, ref activeTarget, ref updateCount);
      }
    }
    if (activeTarget != null)
    {
      Main.spriteBatch.End();
      MapRenderer.GraphicsDevice.SetRenderTarget((RenderTarget2D) null);
    }
    Main.mapReady = true;
    Main.loadMapLastX = 0;
    Main.loadMap = false;
    Main.loadMapLock = false;
    TimeLogger.MapUpdate.AddTime(fromTimestamp);
  }

  private static void DrawAreaToMap(
    Microsoft.Xna.Framework.Rectangle area,
    int rX,
    int rY,
    ref RenderTarget2D activeTarget,
    ref int updateCount)
  {
    RenderTarget2D target = MapRenderer.mapTarget[rX, rY];
    if (target == null || target.IsContentLost)
      return;
    for (int left = area.Left; left < area.Right; ++left)
    {
      for (int top = area.Top; top < area.Bottom; ++top)
      {
        MapTile mapTile = Main.Map[left, top];
        if (mapTile.IsChanged)
        {
          if (updateCount++ >= Main.maxMapUpdates)
            return;
          if (Main.loadMap)
            Main.loadMapLastX = left;
          MapRenderer.DrawChangesToMap(rX, rY, ref activeTarget, target, left, ref top, mapTile);
        }
      }
    }
    List<Point16> changeQueue = MapRenderer.changeQueues[rX, rY];
    for (int index = 0; index < changeQueue.Count; ++index)
    {
      Point16 point16 = changeQueue[index];
      MapTile mapTile = Main.Map[(int) point16.X, (int) point16.Y];
      if (mapTile.IsChanged)
      {
        if (updateCount++ >= Main.maxMapUpdates)
        {
          changeQueue.RemoveRange(0, index);
          return;
        }
        int y = (int) point16.Y;
        MapRenderer.DrawChangesToMap(rX, rY, ref activeTarget, target, (int) point16.X, ref y, mapTile);
      }
    }
    changeQueue.Clear();
  }

  private static void DrawChangesToMap(
    int rX,
    int rY,
    ref RenderTarget2D activeTarget,
    RenderTarget2D target,
    int i,
    ref int j,
    MapTile mapTile)
  {
    Main.Map.ConsumeUpdate(i, j);
    if (target != activeTarget)
    {
      if (activeTarget != null)
        Main.spriteBatch.End();
      activeTarget = target;
      MapRenderer.GraphicsDevice.SetRenderTarget(target);
      Main.spriteBatch.Begin();
    }
    int x1 = i - rX * MapRenderer.textureMaxWidth;
    int y1 = j - rY * MapRenderer.textureMaxHeight;
    Color mapTileXnaColor = MapHelper.GetMapTileXnaColor(mapTile);
    int height = 1;
    int width = 1;
    int y2 = j + 1;
    MapTile other1;
    while ((other1 = Main.Map[i, y2]).IsChanged && mapTile.Equals(other1) && y2 / MapRenderer.textureMaxHeight == rY)
    {
      Main.Map.ConsumeUpdate(i, y2);
      ++height;
      ++y2;
      ++j;
    }
    if (height == 1)
    {
      MapTile other2;
      for (int x2 = i + 1; (other2 = Main.Map[x2, j]).IsChanged && mapTile.Equals(other2) && x2 / MapRenderer.textureMaxWidth == rX; ++x2)
      {
        Main.Map.ConsumeUpdate(x2, j);
        ++width;
      }
    }
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Vector2((float) x1, (float) y1), new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, width, height)), mapTileXnaColor, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
  }

  public static void QueueChange(int x, int y)
  {
    if (Main.refreshMap)
      return;
    int index1 = x / MapRenderer.textureMaxWidth;
    int index2 = y / MapRenderer.textureMaxHeight;
    List<Point16> changeQueue = MapRenderer.changeQueues[index1, index2];
    if (changeQueue.Count >= MapRenderer.ChangeRefreshThreshold)
      Main.refreshMap = true;
    else
      changeQueue.Add(new Point16(x, y));
  }

  public static void DrawToMap_Section(int secX, int secY)
  {
    if (MapRenderer.mapSectionTexture == null)
      MapRenderer.mapSectionTexture = new RenderTarget2D(MapRenderer.GraphicsDevice, 200, 150);
    Stopwatch stopwatch = Stopwatch.StartNew();
    Color[] mapColorCacheArray = MapRenderer._mapColorCacheArray;
    int num1 = secX * 200;
    int num2 = num1 + 200;
    int num3 = secY * 150;
    int num4 = num3 + 150;
    int i = num1 / MapRenderer.textureMaxWidth;
    int j = num3 / MapRenderer.textureMaxHeight;
    int x1 = num1 % MapRenderer.textureMaxWidth;
    int y1 = num3 % MapRenderer.textureMaxHeight;
    if (!MapRenderer.checkMap(i, j))
      return;
    int index = 0;
    Color transparent = Color.Transparent;
    for (int y2 = num3; y2 < num4; ++y2)
    {
      for (int x2 = num1; x2 < num2; ++x2)
      {
        MapTile tile = Main.Map[x2, y2];
        mapColorCacheArray[index] = MapHelper.GetMapTileXnaColor(tile);
        ++index;
      }
    }
    try
    {
      MapRenderer.GraphicsDevice.SetRenderTarget(MapRenderer.mapTarget[i, j]);
    }
    catch (ObjectDisposedException ex)
    {
      MapRenderer.initMap[i, j] = false;
      return;
    }
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
    double totalMilliseconds1 = stopwatch.Elapsed.TotalMilliseconds;
    MapRenderer.mapSectionTexture.SetData<Color>(mapColorCacheArray, 0, mapColorCacheArray.Length);
    double totalMilliseconds2 = stopwatch.Elapsed.TotalMilliseconds;
    TimeSpan elapsed = stopwatch.Elapsed;
    totalMilliseconds1 = elapsed.TotalMilliseconds;
    Main.spriteBatch.Draw((Texture2D) MapRenderer.mapSectionTexture, new Vector2((float) x1, (float) y1), Color.White);
    Main.spriteBatch.End();
    MapRenderer.GraphicsDevice.SetRenderTarget((RenderTarget2D) null);
    elapsed = stopwatch.Elapsed;
    double totalMilliseconds3 = elapsed.TotalMilliseconds;
    stopwatch.Stop();
  }

  public static void CheckMapTargets()
  {
    for (int index1 = 0; index1 < MapRenderer.numTargetsX; ++index1)
    {
      for (int index2 = 0; index2 < MapRenderer.numTargetsY; ++index2)
      {
        if (MapRenderer.mapTarget[index1, index2] != null)
        {
          if (MapRenderer.mapTarget[index1, index2].IsContentLost && !MapRenderer.mapWasContentLost[index1, index2])
          {
            MapRenderer.mapWasContentLost[index1, index2] = true;
            Main.refreshMap = true;
            Main.clearMap = true;
          }
          else if (!MapRenderer.mapTarget[index1, index2].IsContentLost && MapRenderer.mapWasContentLost[index1, index2])
            MapRenderer.mapWasContentLost[index1, index2] = false;
        }
      }
    }
  }

  public static void DrawMap(
    float X,
    float Y,
    float minSizeX,
    float maxSizeX,
    float minSizeY,
    float maxSizeY,
    float xOff,
    float yOff,
    float scale,
    byte alpha)
  {
    int num1 = Main.maxTilesX / MapRenderer.textureMaxWidth;
    int num2 = Main.maxTilesY / MapRenderer.textureMaxHeight;
    float num3 = (float) MapRenderer.textureMaxWidth * scale;
    float num4 = (float) MapRenderer.textureMaxHeight * scale;
    float num5 = X;
    float num6 = 0.0f;
    for (int index1 = 0; index1 <= 4; ++index1)
    {
      if ((double) ((index1 + 1) * MapRenderer.textureMaxWidth) > (double) minSizeX && (double) (index1 * MapRenderer.textureMaxWidth) < (double) minSizeX + (double) maxSizeX)
      {
        for (int index2 = 0; index2 <= num2; ++index2)
        {
          if ((double) ((index2 + 1) * MapRenderer.textureMaxHeight) > (double) minSizeY && (double) (index2 * MapRenderer.textureMaxHeight) < (double) minSizeY + (double) maxSizeY)
          {
            float num7 = X + (float) (int) ((double) index1 * (double) num3);
            float num8 = Y + (float) (int) ((double) index2 * (double) num4);
            float num9 = (float) (index1 * MapRenderer.textureMaxWidth);
            float num10 = (float) (index2 * MapRenderer.textureMaxHeight);
            float x = 0.0f;
            float y = 0.0f;
            float num11;
            if ((double) num9 < (double) minSizeX)
            {
              x = minSizeX - num9;
              num11 = X;
            }
            else
              num11 = num7 - minSizeX * scale;
            float num12;
            if ((double) num10 < (double) minSizeY)
            {
              y = minSizeY - num10;
              num12 = Y;
            }
            else
              num12 = num8 - minSizeY * scale;
            float num13 = num5;
            float textureMaxWidth = (float) MapRenderer.textureMaxWidth;
            float textureMaxHeight = (float) MapRenderer.textureMaxHeight;
            float num14 = (float) ((index1 + 1) * MapRenderer.textureMaxWidth);
            float num15 = (float) ((index2 + 1) * MapRenderer.textureMaxHeight);
            if ((double) num14 >= (double) maxSizeX)
              textureMaxWidth -= num14 - maxSizeX;
            if ((double) num15 >= (double) maxSizeY)
              textureMaxHeight -= num15 - maxSizeY;
            if ((double) textureMaxWidth > (double) x)
            {
              Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle((int) x, (int) y, (int) textureMaxWidth - (int) x, (int) textureMaxHeight - (int) y);
              Main.spriteBatch.Draw((Texture2D) MapRenderer.mapTarget[index1, index2], new Vector2(num13 + xOff, num12 + yOff), new Microsoft.Xna.Framework.Rectangle?(rectangle), new Color((int) alpha, (int) alpha, (int) alpha, (int) alpha), 0.0f, new Vector2(), scale, SpriteEffects.None, 0.0f);
            }
            num6 = (float) ((int) textureMaxWidth - (int) x) * scale;
          }
          if (index2 == num2)
            num5 += num6;
        }
      }
    }
  }
}
