// Decompiled with JetBrains decompiler
// Type: Terraria.Net.Ping
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Diagnostics;
using Terraria.Net.Sockets;
using Terraria.Testing;

#nullable disable
namespace Terraria.Net;

public class Ping
{
  private static Stopwatch _stopwatch = new Stopwatch();
  private static bool _waitingForResponse;

  public static int CurrentPing { get; private set; }

  public static void Reset()
  {
    Ping.CurrentPing = 0;
    Ping._stopwatch.Restart();
    Ping._waitingForResponse = false;
  }

  public static void Update()
  {
    if (Ping._waitingForResponse)
    {
      Ping.CurrentPing = Math.Max(Ping.CurrentPing, (int) Ping._stopwatch.ElapsedMilliseconds);
    }
    else
    {
      if (Ping._stopwatch.ElapsedMilliseconds < 250L)
        return;
      NetMessage.SendData(154);
      Ping._waitingForResponse = true;
      Ping._stopwatch.Restart();
    }
  }

  internal static void PingRecieved()
  {
    Ping.CurrentPing = (int) Ping._stopwatch.ElapsedMilliseconds;
    Ping._waitingForResponse = false;
    if (DebugOptions.Shared_ServerPing <= 0)
      return;
    int num = (DebugOptions.Shared_ServerPing - Ping.CurrentPing) / 2 / 5;
    DebugNetworkStream.Latency = (uint) Utils.Clamp<long>((long) DebugNetworkStream.Latency + (long) num, 0L, 5000L);
  }
}
