// Decompiled with JetBrains decompiler
// Type: Terraria.FrameSkipTest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System.Collections.Generic;
using System.Threading;

#nullable disable
namespace Terraria;

public class FrameSkipTest
{
  private static int LastRecordedSecondNumber;
  private static float CallsThisSecond;
  private static float DeltasThisSecond;
  private static List<float> DeltaSamples = new List<float>();
  private const int SamplesCount = 5;
  private static MultiTimer serverFramerateTest = new MultiTimer(60);

  public static void Update(GameTime gameTime)
  {
    Thread.Sleep((int) MathHelper.Clamp((float) ((1.0 / 60.0 - gameTime.ElapsedGameTime.TotalSeconds) * 1000.0 + 1.0), 0.0f, 1000f));
  }

  public static void CheckReset(GameTime gameTime)
  {
    if (FrameSkipTest.LastRecordedSecondNumber == gameTime.TotalGameTime.Seconds)
      return;
    FrameSkipTest.DeltaSamples.Add(FrameSkipTest.DeltasThisSecond / FrameSkipTest.CallsThisSecond);
    if (FrameSkipTest.DeltaSamples.Count > 5)
      FrameSkipTest.DeltaSamples.RemoveAt(0);
    FrameSkipTest.CallsThisSecond = 0.0f;
    FrameSkipTest.DeltasThisSecond = 0.0f;
    FrameSkipTest.LastRecordedSecondNumber = gameTime.TotalGameTime.Seconds;
  }

  public static void UpdateServerTest()
  {
    FrameSkipTest.serverFramerateTest.Record("frame time");
    FrameSkipTest.serverFramerateTest.StopAndPrint();
    FrameSkipTest.serverFramerateTest.Start();
  }
}
