// Decompiled with JetBrains decompiler
// Type: Terraria.Map.PingMapLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public class PingMapLayer : IMapLayer
{
  private const double PING_DURATION_IN_SECONDS = 15.0;
  private const double PING_FRAME_RATE = 10.0;
  private readonly SlotVector<PingMapLayer.Ping> _pings = new SlotVector<PingMapLayer.Ping>(100);

  public void Draw(ref MapOverlayDrawContext context, ref string text)
  {
    SpriteFrame frame = new SpriteFrame((byte) 1, (byte) 5);
    DateTime now = DateTime.Now;
    foreach (SlotVector<PingMapLayer.Ping>.ItemPair ping1 in (IEnumerable<SlotVector<PingMapLayer.Ping>.ItemPair>) this._pings)
    {
      PingMapLayer.Ping ping2 = ping1.Value;
      double totalSeconds = (now - ping2.Time).TotalSeconds;
      int num = (int) (totalSeconds * 10.0);
      frame.CurrentRow = (byte) ((uint) num % (uint) frame.RowCount);
      context.Draw(TextureAssets.MapPing.Value, ping2.Position, frame, Alignment.Center);
      if (totalSeconds > 15.0)
        this._pings.Remove(ping1.Id);
    }
  }

  public void Add(Vector2 position)
  {
    if (this._pings.Count == this._pings.Capacity)
      return;
    this._pings.Add(new PingMapLayer.Ping(position));
  }

  public void Clear() => this._pings.Clear();

  private struct Ping(Vector2 position)
  {
    public readonly Vector2 Position = position;
    public readonly DateTime Time = DateTime.Now;
  }
}
