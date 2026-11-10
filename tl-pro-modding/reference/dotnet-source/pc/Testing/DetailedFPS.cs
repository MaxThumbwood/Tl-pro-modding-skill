// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.DetailedFPS
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Terraria.GameContent;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Testing;

public static class DetailedFPS
{
  public static readonly int FrameCount = 300;
  private static DetailedFPS.Frame[] Frames = new DetailedFPS.Frame[DetailedFPS.FrameCount];
  private static int oldest;
  private static int newest;
  private static TimeSpan LastGCPauseTime;
  private static int[] LastCollectionCount = new int[GC.MaxGeneration + 1];
  private static long LastAllocatedBytes;
  private const int PixelsPerMs = 6;
  private const int FrameWidth = 2;
  private const int BoxHeight = 100;
  private static string[] _gcGenText = new string[3]
  {
    "G0",
    "G1",
    "G2"
  };

  static DetailedFPS()
  {
    for (int index = 0; index < DetailedFPS.Frames.Length; ++index)
      DetailedFPS.Frames[index].Init();
  }

  public static void StartNextFrame()
  {
    TimeLogger.StartNextFrame();
    DetailedFPS.Frames[DetailedFPS.newest].Finish();
    ++DetailedFPS.newest;
    if (DetailedFPS.newest == DetailedFPS.Frames.Length)
      DetailedFPS.newest = 0;
    if (DetailedFPS.newest == DetailedFPS.oldest)
      ++DetailedFPS.oldest;
    if (DetailedFPS.oldest == DetailedFPS.Frames.Length)
      DetailedFPS.oldest = 0;
    DetailedFPS.Frames[DetailedFPS.newest].Start();
  }

  public static void Begin(DetailedFPS.OperationCategory category)
  {
    DetailedFPS.Frames[DetailedFPS.newest].Begin(category);
  }

  public static void End()
  {
    TimeLogger.EndDrawFrame();
    DetailedFPS.Begin(DetailedFPS.OperationCategory.Idle);
  }

  public static TimeSpan CurrentFrameTime
  {
    get
    {
      DetailedFPS.Frame frame = DetailedFPS.Frames[DetailedFPS.newest];
      return Utils.SWTicksToTimeSpan(frame.events.Last<DetailedFPS.Frame.Event>().timestamp - frame.events[0].timestamp);
    }
  }

  public static float GetCPUUtilization(int numFrames)
  {
    long[] source = new long[6];
    int num1 = 0;
    foreach (DetailedFPS.Frame enumerateFrame in DetailedFPS.EnumerateFrames())
    {
      if (num1++ != numFrames)
      {
        if (enumerateFrame.events.Count >= 2)
        {
          DetailedFPS.Frame.Event event1 = enumerateFrame.events[0];
          foreach (DetailedFPS.Frame.Event event2 in enumerateFrame.events)
          {
            source[(int) event1.category] += event2.timestamp - event1.timestamp;
            event1 = event2;
          }
        }
      }
      else
        break;
    }
    long num2 = ((IEnumerable<long>) source).Sum();
    return (float) (source[2] + source[1]) / (float) num2;
  }

  public static bool VsyncAppearsActive()
  {
    long num1 = 0;
    int num2 = 60;
    int num3 = 0;
    foreach (DetailedFPS.Frame enumerateFrame in DetailedFPS.EnumerateFrames())
    {
      if (num3++ != num2)
      {
        if (enumerateFrame.events.Count >= 2)
        {
          DetailedFPS.Frame.Event event1 = enumerateFrame.events[0];
          foreach (DetailedFPS.Frame.Event event2 in enumerateFrame.events)
          {
            if (event1.category == DetailedFPS.OperationCategory.Present)
              num1 += event2.timestamp - event1.timestamp;
            event1 = event2;
          }
        }
      }
      else
        break;
    }
    return Utils.SWTicksToTimeSpan(num1 / (long) num2).TotalSeconds >= Main.TARGET_FRAME_TIME * 0.1;
  }

  private static TimeSpan GetGCPauseTime()
  {
    TimeSpan totalPauseDuration = NewRuntimeMethods.GC_GetTotalPauseDuration();
    TimeSpan gcPauseTime = totalPauseDuration - DetailedFPS.LastGCPauseTime;
    DetailedFPS.LastGCPauseTime = totalPauseDuration;
    return gcPauseTime;
  }

  private static int GetCollectionCount(int gen)
  {
    int num = GC.CollectionCount(gen);
    int collectionCount = num - DetailedFPS.LastCollectionCount[gen];
    DetailedFPS.LastCollectionCount[gen] = num;
    return collectionCount;
  }

  private static int GetAllocatedBytes()
  {
    long totalAllocatedBytes = NewRuntimeMethods.GC_GetTotalAllocatedBytes();
    long allocatedBytes = totalAllocatedBytes - DetailedFPS.LastAllocatedBytes;
    DetailedFPS.LastAllocatedBytes = totalAllocatedBytes;
    return (int) allocatedBytes;
  }

  private static IEnumerable<DetailedFPS.Frame> EnumerateFrames()
  {
    int k = DetailedFPS.newest;
    while (k != DetailedFPS.oldest)
    {
      if (--k < 0)
        k = DetailedFPS.Frames.Length - 1;
      yield return DetailedFPS.Frames[k];
    }
  }

  public static void Draw()
  {
    Rectangle r = new Rectangle((Main.screenWidth - DetailedFPS.Frames.Length * 2) / 2, Main.screenHeight - 100, DetailedFPS.Frames.Length * 2, 100);
    DetailedFPS.DrawFPSBox(r);
    int num1 = 0;
    long num2 = 0;
    foreach (DetailedFPS.Frame enumerateFrame in DetailedFPS.EnumerateFrames())
    {
      ++num1;
      DetailedFPS.DrawFrame(r.Right - num1 * 2, enumerateFrame);
      num2 += enumerateFrame.Allocated;
    }
    if (num2 > 0L)
    {
      long num3 = num2 / (long) num1;
      DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, FontAssets.MouseText.Value, $"Avg Alloc: {num3,5} bytes/frame", new Vector2((float) ((Main.screenWidth - DetailedFPS.Frames.Length * 2) / 2 - 240 /*0xF0*/), (float) (Main.screenHeight - 24)), Color.White);
    }
    if (!Main.keyState.PressingAlt())
      return;
    DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, FontAssets.MouseText.Value, $"Time Acc: {Main.UpdateTimeAccumulator * 1000.0,5:0.0} ms", new Vector2((float) (Main.screenWidth - 200), (float) (Main.screenHeight - 24)), Color.White);
  }

  private static void DrawFPSBox(Rectangle r)
  {
    Color white = Color.White;
    DetailedFPS.DrawRect(new Rectangle(r.Left, r.Y, 2, r.Height), white);
    DetailedFPS.DrawRect(new Rectangle(r.Right, r.Y, 2, r.Height), white);
    DetailedFPS.DrawRect(new Rectangle(r.Left, r.Y, r.Width, 1), white);
    int num = 24;
    DetailedFPS.OperationCategory category = DetailedFPS.OperationCategory.Idle;
    while (category <= DetailedFPS.OperationCategory.GC)
    {
      if (category != DetailedFPS.OperationCategory.GC || !(DetailedFPS.LastGCPauseTime == TimeSpan.Zero))
      {
        DetailedFPS.DrawRect(new Rectangle(r.Right + 8, r.Bottom - num + 8, 8, 8), DetailedFPS.GetColor(category));
        DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, FontAssets.MouseText.Value, category.ToString(), new Vector2((float) (r.Right + 20), (float) (r.Bottom - num)), Color.White);
      }
      ++category;
      num += 24;
    }
  }

  private static void DrawFrame(int x, DetailedFPS.Frame frame)
  {
    if (frame.events.Count < 2)
      return;
    int val1 = 0;
    DetailedFPS.Frame.Event event1 = frame.events[0];
    long timestamp = event1.timestamp;
    for (int index = 1; index < frame.events.Count; ++index)
    {
      DetailedFPS.Frame.Event event2 = frame.events[index];
      TimeSpan timeSpan = Utils.SWTicksToTimeSpan(event1.timestamp - timestamp);
      int num1 = (int) (timeSpan.TotalMilliseconds * 6.0);
      timeSpan = Utils.SWTicksToTimeSpan(event2.timestamp - timestamp);
      int num2 = (int) (timeSpan.TotalMilliseconds * 6.0);
      DetailedFPS.DrawRect(new Rectangle(x, Main.screenHeight - num2, 2, num2 - num1), DetailedFPS.GetColor(event1.category));
      event1 = event2;
      val1 = num2;
    }
    int num = Math.Max(val1, 100);
    for (int index1 = 0; index1 <= GC.MaxGeneration; ++index1)
    {
      for (int index2 = 0; index2 < frame.CollectionCount[index1]; ++index2)
      {
        DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, FontAssets.MouseText.Value, DetailedFPS._gcGenText[index1], new Vector2((float) (x - 10), (float) (Main.screenHeight - num - 15)), Color.White, 0.0f, Vector2.Zero, 0.75f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
        num += 10;
      }
    }
  }

  private static Color GetColor(DetailedFPS.OperationCategory category)
  {
    switch (category)
    {
      case DetailedFPS.OperationCategory.Idle:
        return Color.Gray;
      case DetailedFPS.OperationCategory.Update:
        return Color.Orange;
      case DetailedFPS.OperationCategory.Draw:
        return Color.Green;
      case DetailedFPS.OperationCategory.Present:
        return Color.Magenta;
      case DetailedFPS.OperationCategory.GC:
        return Color.Blue;
      default:
        return Color.Black;
    }
  }

  private static void DrawRect(Rectangle r, Color c)
  {
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, r, c);
  }

  public enum OperationCategory
  {
    Idle,
    Update,
    Draw,
    Present,
    GC,
    End,
    Count,
  }

  private struct Frame
  {
    public List<DetailedFPS.Frame.Event> events;
    public int[] CollectionCount;
    public long Allocated;

    public void Init()
    {
      this.events = new List<DetailedFPS.Frame.Event>(16 /*0x10*/);
      this.CollectionCount = new int[GC.MaxGeneration + 1];
    }

    public void Start()
    {
      this.events.Clear();
      this.Begin(DetailedFPS.OperationCategory.Idle);
    }

    public void Begin(DetailedFPS.OperationCategory category)
    {
      if (this.events.Count >= 1000 || this.events.Count > 0 && this.events.Last<DetailedFPS.Frame.Event>().category == category)
        return;
      long timestamp = Stopwatch.GetTimestamp();
      if (this.events.Count > 0)
      {
        DetailedFPS.Frame.Event @event = this.events.Last<DetailedFPS.Frame.Event>();
        if (@event.category == DetailedFPS.OperationCategory.Draw || @event.category == DetailedFPS.OperationCategory.Update)
          TimeLogger.TotalDrawAndUpdate.Add((int) (timestamp - @event.timestamp));
      }
      this.events.Add(new DetailedFPS.Frame.Event(category, timestamp));
      TimeSpan gcPauseTime = DetailedFPS.GetGCPauseTime();
      if (!(gcPauseTime > TimeSpan.Zero))
        return;
      long swTicks = Utils.TimeSpanToSWTicks(gcPauseTime);
      this.events.Insert(this.events.Count - 1, new DetailedFPS.Frame.Event(DetailedFPS.OperationCategory.GC, timestamp - swTicks));
      TimeLogger.GCPause.Add((int) swTicks);
    }

    public void Finish()
    {
      this.Begin(DetailedFPS.OperationCategory.End);
      for (int gen = 0; gen <= GC.MaxGeneration; ++gen)
        this.CollectionCount[gen] = DetailedFPS.GetCollectionCount(gen);
      if (Main.CollectGen0EveryFrame)
        --this.CollectionCount[0];
      this.Allocated = (long) DetailedFPS.GetAllocatedBytes();
    }

    public struct Event(DetailedFPS.OperationCategory category, long timestamp)
    {
      public DetailedFPS.OperationCategory category = category;
      public long timestamp = timestamp;
    }
  }
}
