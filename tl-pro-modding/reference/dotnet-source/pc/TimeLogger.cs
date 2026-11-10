// Decompiled with JetBrains decompiler
// Type: Terraria.TimeLogger
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.Testing;

#nullable disable
namespace Terraria;

public static class TimeLogger
{
  public static readonly int FrameCount = DetailedFPS.FrameCount;
  private static StreamWriter logWriter;
  private static StringBuilder logBuilder;
  private static int framesToLog = -1;
  private static int currentFrame;
  private static bool startLoggingNextFrame;
  private static bool endLoggingThisFrame;
  private static bool currentlyLogging;
  private static string[] DataSeriesHeaders = new string[2];
  private static int activeDataSeries = 0;
  private static List<TimeLogger.TimeLogData> entries = new List<TimeLogger.TimeLogData>();
  public static TimeLogger.TimeLogData TotalDrawAndUpdate = TimeLogger.NewEntry("Total Draw+Update", new TimeSpan?(TimeSpan.FromSeconds(Main.TARGET_FRAME_TIME)));
  public static TimeLogger.TimeLogData DrawSolidTiles = TimeLogger.NewEntry("Draw Solid Tiles");
  public static TimeLogger.TimeLogData FlushSolidTiles = TimeLogger.NewEntry("Flush Solid Tiles");
  public static TimeLogger.TimeLogData SolidDrawCalls = TimeLogger.NewCounterEntry("Solid Draw Calls", 200);
  public static TimeLogger.TimeLogData DrawNonSolidTiles = TimeLogger.NewEntry("Draw Non-Solid Tiles");
  public static TimeLogger.TimeLogData FlushNonSolidTiles = TimeLogger.NewEntry("Flush Non-Solid Tiles");
  public static TimeLogger.TimeLogData NonSolidDrawCalls = TimeLogger.NewCounterEntry("Non-Solid Draw Calls", 200);
  public static TimeLogger.TimeLogData DrawBlackTiles = TimeLogger.NewEntry("Draw Black Tiles");
  public static TimeLogger.TimeLogData DrawWallTiles = TimeLogger.NewEntry("Draw Wall Tiles");
  public static TimeLogger.TimeLogData FlushWallTiles = TimeLogger.NewEntry("Flush Wall Tiles");
  public static TimeLogger.TimeLogData WallDrawCalls = TimeLogger.NewCounterEntry("Wall Draw Calls", 200);
  public static TimeLogger.TimeLogData DrawWaterTiles = TimeLogger.NewEntry("Draw Liquid Tiles");
  public static TimeLogger.TimeLogData LiquidDrawCalls = TimeLogger.NewCounterEntry("Liquid Draw Calls", 200);
  public static TimeLogger.TimeLogData DrawBackgroundWaterTiles = TimeLogger.NewEntry("Draw Bg Liquid Tiles");
  public static TimeLogger.TimeLogData LiquidBackgroundDrawCalls = TimeLogger.NewCounterEntry("Bg Liquid Draw Calls", 200);
  public static TimeLogger.TimeLogData DrawUndergroundBackground = TimeLogger.NewEntry("Draw Underground Bg");
  public static TimeLogger.TimeLogData DrawOldUndergroundBackground = TimeLogger.NewEntry("Draw Old Underground Bg");
  public static TimeLogger.TimeLogData DrawWireTiles = TimeLogger.NewEntry("Draw Wire Tiles");
  public static TimeLogger.TimeLogData ClothingRacks = TimeLogger.NewEntry("Hat Racks & Display Dolls");
  public static TimeLogger.TimeLogData TileExtras = TimeLogger.NewEntry("Tile Extras");
  public static TimeLogger.TimeLogData Nature = TimeLogger.NewEntry("Nature Renderer");
  public static TimeLogger.TimeLogData RenderSolidTiles = TimeLogger.NewEntry("Render Solid Tiles", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData RenderNonSolidTiles = TimeLogger.NewEntry("Render Non-Solid Tiles", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData RenderBlacksAndWalls = TimeLogger.NewEntry("Render Black Tiles & Walls", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData RenderUndergroundBackground = TimeLogger.NewEntry("Render Underground Bg", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData RenderBackgroundLiquid = TimeLogger.NewEntry("Render Bg Water Tiles", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData RenderLiquid = TimeLogger.NewEntry("Render Water Tiles", new TimeSpan?(TimeSpan.FromMilliseconds(3.0)));
  public static TimeLogger.TimeLogData[] TotalDrawByRenderCount;
  public static TimeLogger.TimeLogData TotalDrawRenderNow = TimeLogger.NewEntry("Total Draw, Render Now", new TimeSpan?(TimeSpan.FromMilliseconds(16.0)));
  public static TimeLogger.TimeLogData TotalDraw = TimeLogger.NewEntry("Total Draw", new TimeSpan?(TimeSpan.FromMilliseconds(16.0)));
  public static TimeLogger.TimeLogData Lighting = TimeLogger.NewEntry(nameof (Lighting));
  public static TimeLogger.TimeLogData LightingInit = TimeLogger.NewEntry("Lighting Init");
  public static TimeLogger.TimeLogData[] LightingByPass;
  public static TimeLogger.TimeLogData FindPaintedTiles = TimeLogger.NewEntry("Find Painted Tiles");
  public static TimeLogger.TimeLogData PrepareRequests = TimeLogger.NewEntry("Prep Render Target Content");
  public static TimeLogger.TimeLogData FindingWaterfalls = TimeLogger.NewEntry("Find Waterfalls");
  public static TimeLogger.TimeLogData MapChanges = TimeLogger.NewEntry("Queued Map Updates");
  public static TimeLogger.TimeLogData MapSectionUpdate = TimeLogger.NewEntry("Map Section Update");
  public static TimeLogger.TimeLogData MapUpdate = TimeLogger.NewEntry("Map Update");
  public static TimeLogger.TimeLogData SectionFraming = TimeLogger.NewEntry("Section Framing");
  public static TimeLogger.TimeLogData SectionRefresh = TimeLogger.NewEntry("Section Refresh");
  public static TimeLogger.TimeLogData SkyBackground = TimeLogger.NewEntry("Sky Background");
  public static TimeLogger.TimeLogData SunMoonStars = TimeLogger.NewEntry("Sun, Moon & Stars");
  public static TimeLogger.TimeLogData SurfaceBackground = TimeLogger.NewEntry("Surface Background");
  public static TimeLogger.TimeLogData Map = TimeLogger.NewEntry(nameof (Map));
  public static TimeLogger.TimeLogData PlayerChat = TimeLogger.NewEntry("Player Chat");
  public static TimeLogger.TimeLogData Waterfalls = TimeLogger.NewEntry(nameof (Waterfalls));
  public static TimeLogger.TimeLogData NPCs = TimeLogger.NewEntry("NPC");
  public static TimeLogger.TimeLogData Projectiles = TimeLogger.NewEntry(nameof (Projectiles));
  public static TimeLogger.TimeLogData Players = TimeLogger.NewEntry(nameof (Players));
  public static TimeLogger.TimeLogData Items = TimeLogger.NewEntry(nameof (Items));
  public static TimeLogger.TimeLogData Rain = TimeLogger.NewEntry(nameof (Rain));
  public static TimeLogger.TimeLogData Gore = TimeLogger.NewEntry(nameof (Gore));
  public static TimeLogger.TimeLogData Dust = TimeLogger.NewEntry(nameof (Dust));
  public static TimeLogger.TimeLogData Particles = TimeLogger.NewEntry(nameof (Particles));
  public static TimeLogger.TimeLogData LeashedEntities = TimeLogger.NewEntry("Leashed Entities");
  public static TimeLogger.TimeLogData Interface = TimeLogger.NewEntry(nameof (Interface));
  public static TimeLogger.TimeLogData DrawFPSGraph = TimeLogger.NewEntry("Draw FPS Graph");
  public static TimeLogger.TimeLogData DrawTimeLogger = TimeLogger.NewEntry("Draw Render Timings");
  public static TimeLogger.TimeLogData Overlays = TimeLogger.NewEntry(nameof (Overlays));
  public static TimeLogger.TimeLogData FiltersAndPostDraw = TimeLogger.NewEntry("Filters & PostDraw");
  public static TimeLogger.TimeLogData SunVisibility = TimeLogger.NewEntry("Sun Visibility");
  public static TimeLogger.TimeLogData MenuDrawTime = TimeLogger.NewEntry("Menu");
  public static TimeLogger.TimeLogData SplashDrawTime = TimeLogger.NewEntry("Splash");
  public static TimeLogger.TimeLogData DrawFullscreenMap = TimeLogger.NewEntry("Full Screen Map");
  public static TimeLogger.TimeLogData GCPause = TimeLogger.NewEntry("GC Pause", new TimeSpan?(TimeSpan.FromMilliseconds(1.0)));
  private static Queue<Action> _onNextFrame = new Queue<Action>();
  public static int ABTestMode = TimeLogger.ABTestFlag ? 1 : 0;
  public static bool ABTestFlag;
  public static readonly string ABTestName = "Also Baseline";
  private static int TableWidth;
  private static int ColumnSpacing = 220;
  private static int DrawnEntryNumber = 0;
  private static Queue<TimeLogger.TimeLogData> _entriesToDraw = new Queue<TimeLogger.TimeLogData>();
  private static TimeLogger.FormatPool _PinnedCPUFormat = new TimeLogger.FormatPool("Pinned to CPU #{0}", 64.0);
  private static TimeLogger.FormatPool _AssignedCPUFormat = new TimeLogger.FormatPool("Assigned CPU #{0}", 64.0);
  private static TimeLogger.FormatPool _procThrottleFormat = new TimeLogger.FormatPool("CPU Throttle/Boost {0:0}%", 200.0);
  private static TimeLogger.FormatPool _expectedCPUFormat = new TimeLogger.FormatPool("Expected CPU Usage {0:0}%", 200.0);
  private static TimeLogger.FormatPool _terrariaCPUFormat = new TimeLogger.FormatPool("Terraria CPU Usage {0:0}%", 200.0);
  private static TimeLogger.FormatPool _pendingCPUFormat = new TimeLogger.FormatPool("#Threads pending CPU {0}", 100.0);
  private static TimeLogger.FormatPool _percentFormat = new TimeLogger.FormatPool("{0,3:00}%", 100.0);
  private static TimeLogger.FormatPool _msFormat = new TimeLogger.FormatPool("{0,5:F2}", 20.0, -10.0, 0.0099999997764825821);
  private static TimeLogger.FormatPool _intFormat = new TimeLogger.FormatPool("{0,5}", 5000.0);

  private static TimeLogger.TimeLogData NewEntry(string name, TimeSpan? budget = null)
  {
    TimeLogger.TimeLogData timeLogData = new TimeLogger.TimeLogData()
    {
      name = name,
      format = new Func<int, string>(TimeLogger.FormatTicks),
      budget = (int) Utils.TimeSpanToSWTicks(budget ?? TimeSpan.FromMilliseconds(2.0))
    };
    TimeLogger.entries.Add(timeLogData);
    return timeLogData;
  }

  private static TimeLogger.TimeLogData NewCounterEntry(string name, int budget)
  {
    TimeLogger.TimeLogData timeLogData = new TimeLogger.TimeLogData()
    {
      name = name,
      format = (Func<int, string>) (i => TimeLogger._intFormat.Format((double) i)),
      budget = budget
    };
    TimeLogger.entries.Add(timeLogData);
    return timeLogData;
  }

  static TimeLogger()
  {
    TimeLogger.TotalDrawByRenderCount = new TimeLogger.TimeLogData[9];
    for (int index = 0; index < TimeLogger.TotalDrawByRenderCount.Length; ++index)
      TimeLogger.TotalDrawByRenderCount[index] = TimeLogger.NewEntry($"Total Draw (Render #{(object) index})", new TimeSpan?(TimeSpan.FromMilliseconds(15.0)));
    TimeLogger.LightingByPass = new TimeLogger.TimeLogData[4];
    for (int index = 0; index < TimeLogger.LightingByPass.Length; ++index)
      TimeLogger.LightingByPass[index] = TimeLogger.NewEntry("Lighting Pass #" + (object) index, new TimeSpan?(TimeSpan.FromMilliseconds(1.0)));
  }

  public static void Reset()
  {
    TimeLogger.OnNextFrame((Action) (() =>
    {
      foreach (TimeLogger.TimeLogData entry in TimeLogger.entries)
        entry.Reset();
    }));
  }

  public static void ToggleLogging()
  {
    if (TimeLogger.currentlyLogging)
    {
      TimeLogger.endLoggingThisFrame = true;
      TimeLogger.startLoggingNextFrame = false;
    }
    else
    {
      TimeLogger.startLoggingNextFrame = true;
      TimeLogger.endLoggingThisFrame = false;
      Main.NewText("Detailed logging started", (byte) 250, (byte) 250, (byte) 0);
    }
  }

  public static void OnNextFrame(Action action) => TimeLogger._onNextFrame.Enqueue(action);

  public static void StartNextFrame()
  {
    while (TimeLogger._onNextFrame.Count > 0)
      TimeLogger._onNextFrame.Dequeue()();
    TimeLogger.ABTest();
    foreach (TimeLogger.TimeLogData entry in TimeLogger.entries)
      entry.StartNextFrame();
    if (TimeLogger.startLoggingNextFrame)
    {
      TimeLogger.startLoggingNextFrame = false;
      DateTime now = DateTime.Now;
      string path = $"{Main.SavePath}{Path.DirectorySeparatorChar.ToString()}TerrariaDrawLog.7z";
      try
      {
        TimeLogger.logWriter = new StreamWriter((Stream) new GZipStream((Stream) new FileStream(path, FileMode.Create), CompressionMode.Compress));
        TimeLogger.logBuilder = new StringBuilder(5000);
        TimeLogger.framesToLog = 600;
        TimeLogger.currentFrame = 1;
        TimeLogger.currentlyLogging = true;
      }
      catch
      {
        Main.NewText("Detailed logging could not be started.", (byte) 250, (byte) 250, (byte) 0);
      }
    }
    if (!TimeLogger.currentlyLogging)
      return;
    TimeLogger.logBuilder.AppendLine($"Start of Frame #{TimeLogger.currentFrame}");
  }

  public static void EndDrawFrame()
  {
    if (TimeLogger.currentFrame > TimeLogger.framesToLog)
      return;
    TimeLogger.logBuilder.AppendLine($"End of Frame #{TimeLogger.currentFrame}");
    TimeLogger.logBuilder.AppendLine();
    if (TimeLogger.endLoggingThisFrame)
    {
      TimeLogger.endLoggingThisFrame = false;
      TimeLogger.logBuilder.AppendLine("Logging ended early");
      TimeLogger.currentFrame = TimeLogger.framesToLog;
    }
    if (TimeLogger.logBuilder.Length > 4000)
    {
      TimeLogger.logWriter.Write(TimeLogger.logBuilder.ToString());
      TimeLogger.logBuilder.Clear();
    }
    ++TimeLogger.currentFrame;
    if (TimeLogger.currentFrame <= TimeLogger.framesToLog)
      return;
    Main.NewText("Detailed logging ended.", (byte) 250, (byte) 250, (byte) 0);
    TimeLogger.logWriter.Write(TimeLogger.logBuilder.ToString());
    TimeLogger.logBuilder.Clear();
    TimeLogger.logBuilder = (StringBuilder) null;
    TimeLogger.logWriter.Flush();
    TimeLogger.logWriter.Close();
    TimeLogger.logWriter = (StreamWriter) null;
    TimeLogger.framesToLog = -1;
    TimeLogger.currentFrame = 0;
    TimeLogger.currentlyLogging = false;
  }

  private static void LogAdd(string logText, int ticks, bool newMax)
  {
    if (TimeLogger.currentFrame == 0)
      return;
    TimeLogger.logBuilder.AppendLine($"    {logText} : {Utils.SWTicksToTimeSpan((long) ticks).TotalMilliseconds:F4}ms {(newMax ? (object) " - New Maximum" : (object) string.Empty)}");
  }

  public static TimeLogger.StartTimestamp Start()
  {
    return new TimeLogger.StartTimestamp()
    {
      ticks = Stopwatch.GetTimestamp()
    };
  }

  public static void ABTest()
  {
    if (Main.renderCount == 0 && TimeLogger.ABTestMode == 2)
      TimeLogger.ABTestFlag = !TimeLogger.ABTestFlag;
    if (TimeLogger.ABTestFlag)
    {
      TimeLogger.DataSeriesHeaders[0] = "Baseline";
      TimeLogger.DataSeriesHeaders[1] = TimeLogger.ABTestName;
    }
    TimeLogger.activeDataSeries = TimeLogger.ABTestFlag ? 1 : 0;
  }

  public static void DrawException(Exception e)
  {
    if (!TimeLogger.currentlyLogging)
      return;
    TimeLogger.logBuilder.AppendLine(e.ToString());
  }

  public static void Draw()
  {
    TimeLogger.DrawTimes();
    TimeLogger.DrawExtras();
  }

  private static void DrawTimes()
  {
    TimeLogger.DrawnEntryNumber = 0;
    foreach (TimeLogger.TimeLogData entry in TimeLogger.entries)
      entry.pendingDisplay = entry.ShouldDrawByDefault;
    int y1 = 100;
    TimeLogger.TableWidth = TimeLogger.DataSeriesHeaders[1] != null ? 900 : 440;
    Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(0, y1, TimeLogger.TableWidth, 800), new Color(60, 60, 60, 80 /*0x50*/));
    TimeLogger.DrawString("Render Time (ms) F7 to hide", new Vector2(80f, (float) (y1 - 16 /*0x10*/)), Color.White);
    TimeLogger.DrawString("Median", new Vector2(273f, (float) y1), Color.White);
    TimeLogger.DrawString("P90", new Vector2(325f, (float) y1), Color.White);
    TimeLogger.DrawString("Max", new Vector2(365f, (float) y1), Color.White);
    TimeLogger.DrawString("Freq", new Vector2(400f, (float) y1), Color.White);
    if (TimeLogger.DataSeriesHeaders[1] != null)
    {
      TimeLogger.DrawString(TimeLogger.DataSeriesHeaders[0], new Vector2(280f, (float) (y1 - 16 /*0x10*/)), TimeLogger.activeDataSeries == 0 ? Color.LightGreen : Color.White);
      TimeLogger.DrawString(TimeLogger.DataSeriesHeaders[1], new Vector2((float) (280 + TimeLogger.ColumnSpacing), (float) (y1 - 16 /*0x10*/)), TimeLogger.activeDataSeries == 1 ? Color.LightGreen : Color.White);
      TimeLogger.DrawString("Delta", new Vector2((float) (320 + 2 * TimeLogger.ColumnSpacing), (float) (y1 - 16 /*0x10*/)), Color.White);
      TimeLogger.DrawString("Median", new Vector2((float) (273 + TimeLogger.ColumnSpacing), (float) y1), Color.White);
      TimeLogger.DrawString("P90", new Vector2((float) (325 + TimeLogger.ColumnSpacing), (float) y1), Color.White);
      TimeLogger.DrawString("Max", new Vector2((float) (365 + TimeLogger.ColumnSpacing), (float) y1), Color.White);
      TimeLogger.DrawString("Freq", new Vector2((float) (400 + TimeLogger.ColumnSpacing), (float) y1), Color.White);
      TimeLogger.DrawString("Median", new Vector2((float) (250 + 2 * TimeLogger.ColumnSpacing), (float) y1), Color.White);
      TimeLogger.DrawString("P90", new Vector2((float) (360 + 2 * TimeLogger.ColumnSpacing), (float) y1), Color.White);
    }
    int y2 = y1 + 16 /*0x10*/;
    TimeLogger.DrawEntry(TimeLogger.TotalDrawAndUpdate, ref y2, -1);
    TimeLogger.DrawEntry(TimeLogger.TotalDraw, ref y2, -1);
    if (!Main.drawToScreen)
    {
      TimeLogger.DrawEntry(TimeLogger.TotalDrawByRenderCount[0], ref y2);
      TimeLogger.DrawEntry(TimeLogger.TotalDrawByRenderCount[1], ref y2);
      TimeLogger.DrawEntry(TimeLogger.RenderLiquid, ref y2, 1);
      TimeLogger.DrawEntry(TimeLogger.LiquidDrawCalls, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.TotalDrawByRenderCount[2], ref y2);
      if (TimeLogger.RenderUndergroundBackground.pendingDisplay)
      {
        TimeLogger.DrawEntry(TimeLogger.RenderUndergroundBackground, ref y2, 1);
        TimeLogger.DrawEntry(TimeLogger.DrawUndergroundBackground, ref y2, 2);
      }
      TimeLogger.DrawEntry(TimeLogger.RenderBackgroundLiquid, ref y2, 1);
      TimeLogger.DrawEntry(TimeLogger.LiquidBackgroundDrawCalls, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.TotalDrawByRenderCount[3], ref y2);
      TimeLogger.DrawEntry(TimeLogger.RenderBlacksAndWalls, ref y2, 1);
      TimeLogger.DrawEntry(TimeLogger.DrawBlackTiles, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.DrawWallTiles, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.FlushWallTiles, ref y2, 3);
      TimeLogger.DrawEntry(TimeLogger.WallDrawCalls, ref y2, 4);
      TimeLogger.DrawEntry(TimeLogger.RenderSolidTiles, ref y2, 1);
      TimeLogger.DrawEntry(TimeLogger.FlushSolidTiles, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.SolidDrawCalls, ref y2, 3);
      TimeLogger.DrawEntry(TimeLogger.RenderNonSolidTiles, ref y2, 1);
      TimeLogger.DrawEntry(TimeLogger.FlushNonSolidTiles, ref y2, 2);
      TimeLogger.DrawEntry(TimeLogger.NonSolidDrawCalls, ref y2, 3);
      TimeLogger.DrawWaterTiles.pendingDisplay = false;
      TimeLogger.DrawBackgroundWaterTiles.pendingDisplay = false;
      TimeLogger.DrawSolidTiles.pendingDisplay = false;
      TimeLogger.DrawNonSolidTiles.pendingDisplay = false;
    }
    foreach (TimeLogger.TimeLogData e in TimeLogger.TotalDrawByRenderCount)
    {
      if (e.pendingDisplay)
        TimeLogger.DrawEntry(e, ref y2);
    }
    if (TimeLogger.TotalDrawRenderNow.pendingDisplay)
      TimeLogger.DrawEntry(TimeLogger.TotalDrawRenderNow, ref y2);
    y2 += 12;
    TimeLogger.DrawEntry(TimeLogger.Lighting, ref y2);
    if (TimeLogger.LightingInit.pendingDisplay)
      TimeLogger.DrawEntry(TimeLogger.LightingInit, ref y2, 1);
    foreach (TimeLogger.TimeLogData e in TimeLogger.LightingByPass)
    {
      if (e.pendingDisplay)
        TimeLogger.DrawEntry(e, ref y2, 1);
    }
    y2 += 12;
    foreach (TimeLogger.TimeLogData entry in TimeLogger.entries)
    {
      if (entry.pendingDisplay)
        TimeLogger.DrawEntry(entry, ref y2);
    }
  }

  private static void DrawExtras()
  {
    if (Platform.IsWindows)
    {
      WindowsPerformanceDiagnostics.Data data = WindowsPerformanceDiagnostics.GetData();
      int x = Main.screenWidth - 180;
      int num1 = Main.screenHeight - 100;
      int num2;
      TimeLogger.DrawString((data.PinnedToProcessor ? TimeLogger._PinnedCPUFormat : TimeLogger._AssignedCPUFormat).Format((double) data.CurrentProcessor), new Vector2((float) x, (float) (num2 = num1 + 12)), Color.White);
      int num3;
      TimeLogger.DrawString(TimeLogger._procThrottleFormat.Format(data.ProcessorThrottlePercent), new Vector2((float) x, (float) (num3 = num2 + 12)), Color.White);
      int num4;
      TimeLogger.DrawString(TimeLogger._expectedCPUFormat.Format(data.ExpectedCPUPercent), new Vector2((float) x, (float) (num4 = num3 + 12)), Color.White);
      if (data.PinnedToProcessor)
        TimeLogger.DrawString(TimeLogger._terrariaCPUFormat.Format(data.MainThreadCPUPercent), new Vector2((float) x, (float) (num4 += 12)), Color.White);
      TimeLogger.FormatPool pendingCpuFormat = TimeLogger._pendingCPUFormat;
      long? contentionQueueLength = data.ContentionQueueLength;
      double? nullable = contentionQueueLength.HasValue ? new double?((double) contentionQueueLength.GetValueOrDefault()) : new double?();
      int num5;
      TimeLogger.DrawString(pendingCpuFormat.Format(nullable), new Vector2((float) x, (float) (num5 = num4 + 12)), Color.White);
      int num6 = num5 + 2;
      if (data.RecommendUnpinning)
      {
        int num7;
        TimeLogger.DrawString("Core pinning may be", new Vector2((float) x, (float) (num7 = num6 + 11)), Color.Orange);
        int num8;
        TimeLogger.DrawString("reducing performance", new Vector2((float) x, (float) (num8 = num7 + 12)), Color.Orange);
      }
    }
    if (!PlayerInput.UsingGamepad)
      return;
    for (int index = 0; index < 2; ++index)
    {
      string text = "";
      int x = Main.screenWidth - 220;
      int y = Main.screenHeight - 140 + index * 12;
      if (index == 0)
        text = $"Thumbstick (L): {PlayerInput.GamepadThumbstickLeft.X,7:P2} ,{PlayerInput.GamepadThumbstickLeft.Y,7:P2}";
      if (index == 1)
        text = $"Thumbstick (R): {PlayerInput.GamepadThumbstickRight.X,7:P2} ,{PlayerInput.GamepadThumbstickRight.Y,7:P2}";
      TimeLogger.DrawString(text, new Vector2((float) x, (float) y), Color.White);
    }
  }

  private static void DrawEntry(TimeLogger.TimeLogData e, ref int y, int indent = 0)
  {
    e.pendingDisplay = false;
    if (TimeLogger.DrawnEntryNumber++ % 2 == 1)
      Main.spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(0, y, TimeLogger.TableWidth, 12), new Color(0, 0, 0, 80 /*0x50*/));
    int x1 = 0;
    TimeLogger.DrawString(e.name, new Vector2((float) (x1 + 20 + indent * 12), (float) y), TimeLogger.PerformanceColor((long) e.data[0].median, (long) e.budget));
    TimeLogger.DrawEntryData(x1, y, e.data[0], e.format, e.budget);
    int x2 = x1 + TimeLogger.ColumnSpacing;
    TimeLogger.DrawEntryData(x2, y, e.data[1], e.format, e.budget);
    TimeLogger.DrawDelta(x2 + TimeLogger.ColumnSpacing, y, e.data[0], e.data[1], e.format, e.budget);
    y += 12;
  }

  private static void DrawEntryData(
    int x,
    int y,
    TimeLogger.DataSeries data,
    Func<int, string> format,
    int budget)
  {
    if (!data.HasData)
      return;
    TimeLogger.DrawValue(data.previous, new Vector2((float) (x + 240 /*0xF0*/), (float) y), format, budget);
    TimeLogger.DrawValue(data.median, new Vector2((float) (x + 280), (float) y), format, budget);
    TimeLogger.DrawValue(data.p90, new Vector2((float) (x + 320), (float) y), format, budget);
    TimeLogger.DrawValue(data.max, new Vector2((float) (x + 360), (float) y), format, budget);
    if ((double) data.frequency >= 1.0)
      return;
    TimeLogger.DrawString(TimeLogger._percentFormat.Format((double) data.frequency * 100.0), new Vector2((float) (x + 400), (float) y), Color.White);
  }

  private static void DrawDelta(
    int x,
    int y,
    TimeLogger.DataSeries data0,
    TimeLogger.DataSeries data1,
    Func<int, string> format,
    int budget)
  {
    if (!data0.HasData || !data1.HasData)
      return;
    TimeLogger.DrawDelta(data0.median, data1.median, new Vector2((float) (x + 240 /*0xF0*/), (float) y), format, budget);
    TimeLogger.DrawDelta(data0.p90, data1.p90, new Vector2((float) (x + 340), (float) y), format, budget);
  }

  private static string FormatTicks(int ticks)
  {
    TimeSpan timeSpan = Utils.SWTicksToTimeSpan((long) ticks);
    string str = TimeLogger._msFormat.Format(timeSpan.TotalMilliseconds);
    if (str.Length > 5)
      str = str.Substring(0, 5);
    return str;
  }

  private static void DrawValue(int value, Vector2 pos, Func<int, string> format, int budget)
  {
    TimeLogger.DrawString(format(value), pos, TimeLogger.PerformanceColor((long) value, (long) budget));
  }

  private static void DrawDelta(
    int value0,
    int value1,
    Vector2 pos,
    Func<int, string> format,
    int budget)
  {
    int num1 = value1 - value0;
    int num2 = (int) Math.Round((double) value1 * 100.0 / (double) value0 - 100.0);
    if (value0 == 0 || Math.Abs(num2) <= 1 || Math.Abs(num1 * 100) <= budget)
      return;
    Color color = num2 < 0 ? Color.Lerp(Color.White, new Color(0, 200, 0), (float) -num2 / 100f) : Color.Lerp(Color.White, new Color(200, 0, 0), (float) num2 / 100f);
    TimeLogger.DrawString(format(num1), pos, color);
    pos.X += 40f;
    TimeLogger.DrawString(TimeLogger._percentFormat.Format((double) num2), pos, color);
  }

  private static void DrawString(string text, Vector2 pos, Color color)
  {
    Utils.DrawBorderString(Main.spriteBatch, text, pos, color, 0.75f);
  }

  private static Color PerformanceColor(long value, long budget)
  {
    Color white = Color.White;
    Color color1 = new Color((int) byte.MaxValue, (int) byte.MaxValue, 170);
    Color color2 = new Color((int) byte.MaxValue, 160 /*0xA0*/, 50);
    Color color3 = new Color((int) byte.MaxValue, 50, 50);
    Color color4 = new Color(200, 0, 0);
    float num = (float) value / (float) budget;
    if ((double) num <= 0.33)
      return Color.Lerp(white, color1, num / 0.33f);
    if ((double) num <= 0.67)
      return Color.Lerp(color1, color2, (float) (((double) num - 0.33000001311302185) / 0.34000000357627869));
    return (double) num <= 1.0 ? Color.Lerp(color2, color3, (float) (((double) num - 0.67000001668930054) / 0.32999998331069946)) : Color.Lerp(color3, color4, Utils.Clamp<float>(num - 1f, 0.0f, 1f));
  }

  public class DataSeries
  {
    private int[] values = new int[TimeLogger.FrameCount];
    private bool[] used = new bool[TimeLogger.FrameCount];
    private int next;
    private int count;
    private int usedCount;
    public int previous;
    public int median;
    public int p90;
    public int max;
    private static int[] _sort = new int[TimeLogger.FrameCount];

    public bool HasData => this.usedCount > 0;

    public float frequency => this.count <= 0 ? 0.0f : (float) this.usedCount / (float) this.count;

    public void Add(int value, out bool newMax)
    {
      this.values[this.next] += value;
      this.used[this.next] = true;
      newMax = this.values[this.next] > this.max;
    }

    public void StartNextFrame()
    {
      if (this.used[this.next])
        this.previous = this.values[this.next];
      if (this.count < this.values.Length)
        ++this.count;
      this.next = (this.next + 1) % this.values.Length;
      this.usedCount = 0;
      for (int index = 0; index < this.count; ++index)
      {
        if (this.used[index])
          TimeLogger.DataSeries._sort[this.usedCount++] = this.values[index];
      }
      if (this.usedCount > 0)
      {
        Array.Sort<int>(TimeLogger.DataSeries._sort, 0, this.usedCount);
        this.median = TimeLogger.DataSeries.Quantile(TimeLogger.DataSeries._sort, this.usedCount, 0.5f);
        this.p90 = TimeLogger.DataSeries.Quantile(TimeLogger.DataSeries._sort, this.usedCount, 0.9f);
        this.max = TimeLogger.DataSeries.Quantile(TimeLogger.DataSeries._sort, this.usedCount, 1f);
      }
      else
        this.previous = this.median = this.p90 = this.max = 0;
      this.values[this.next] = 0;
      this.used[this.next] = false;
    }

    public void Reset()
    {
      this.next = this.count = this.usedCount = 0;
      this.previous = this.median = this.p90 = this.max = 0;
    }

    private static int Quantile(int[] sorted, int len, float quantile)
    {
      quantile *= (float) (len - 1);
      return (int) MathHelper.Lerp((float) sorted[(int) Math.Floor((double) quantile)], (float) sorted[(int) Math.Ceiling((double) quantile)], quantile % 1f);
    }
  }

  public class TimeLogData
  {
    public string name;
    public Func<int, string> format;
    public int budget;
    public bool pendingDisplay;
    public TimeLogger.DataSeries[] data = new TimeLogger.DataSeries[2]
    {
      new TimeLogger.DataSeries(),
      new TimeLogger.DataSeries()
    };

    public bool ShouldDrawByDefault
    {
      get
      {
        foreach (TimeLogger.DataSeries dataSeries in this.data)
        {
          if (dataSeries.HasData && (double) dataSeries.p90 >= (double) this.budget * 0.05000000074505806)
            return true;
        }
        return false;
      }
    }

    public void AddTime(TimeLogger.StartTimestamp fromTimestamp)
    {
      this.Add(fromTimestamp.ElapsedTicks);
    }

    public void Add(int value)
    {
      bool newMax;
      this.data[TimeLogger.activeDataSeries].Add(value, out newMax);
      TimeLogger.LogAdd(this.name, value, newMax);
    }

    public void Reset()
    {
      foreach (TimeLogger.DataSeries dataSeries in this.data)
        dataSeries.Reset();
    }

    public void StartNextFrame() => this.data[TimeLogger.activeDataSeries].StartNextFrame();
  }

  public struct StartTimestamp
  {
    public long ticks;

    public int ElapsedTicks => (int) (Stopwatch.GetTimestamp() - this.ticks);

    public TimeSpan Elapsed => Utils.SWTicksToTimeSpan((long) this.ElapsedTicks);
  }

  private class FormatPool
  {
    private readonly string _format;
    private readonly double _minValue;
    private readonly double _rounding;
    private readonly string[] _strings;
    private string _nullString;

    public FormatPool(string format, double maxValue, double minValue = 0.0, double rounding = 1.0)
    {
      this._format = format;
      this._minValue = minValue;
      this._rounding = rounding;
      this._strings = new string[(int) ((maxValue - minValue) / rounding) + 1];
      this._nullString = string.Format(this._format, (object) null);
    }

    public string Format(double value)
    {
      int index = (int) Math.Round((value - this._minValue) / this._rounding);
      if (index < 0 || index >= this._strings.Length)
        return string.Format(this._format, (object) value);
      string str = this._strings[index];
      if (str == null)
        this._strings[index] = str = string.Format(this._format, (object) value);
      return str;
    }

    public string Format(double? value)
    {
      return value.HasValue ? this.Format(value.Value) : this._nullString;
    }
  }
}
