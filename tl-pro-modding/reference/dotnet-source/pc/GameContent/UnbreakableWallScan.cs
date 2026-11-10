// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UnbreakableWallScan
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent;

public static class UnbreakableWallScan
{
  public static readonly int ScanDistance = 250;
  public static readonly Point[] Directions = new Point[8]
  {
    new Point(1, 0),
    new Point(1, 1),
    new Point(0, 1),
    new Point(-1, 1),
    new Point(-1, 0),
    new Point(-1, -1),
    new Point(0, -1),
    new Point(1, -1)
  };

  public static void Update(Player player)
  {
    int netMode = Main.netMode;
  }

  public static bool InsideUnbreakableWalls(Point pt)
  {
    int num = 0;
    for (int index = 0; index < UnbreakableWallScan.Directions.Length; ++index)
    {
      if (UnbreakableWallScan.LineScan(pt, UnbreakableWallScan.Directions[index]))
        num |= 1 << index;
    }
    for (int index = 0; index < UnbreakableWallScan.Directions.Length; ++index)
    {
      if ((num & 31 /*0x1F*/) == 0)
        return false;
      num = num << 1 & (int) byte.MaxValue | num >> 7;
    }
    return true;
  }

  public static bool LineScan(Point pt, Point dir)
  {
    int num = 0;
    while (num < UnbreakableWallScan.ScanDistance && WorldGen.InWorld(pt))
    {
      Tile tile = Main.tile[pt.X, pt.Y];
      if (tile == null)
        return false;
      if (tile.wall == (ushort) 350)
        return tile.wallColor() >= (byte) 16 /*0x10*/;
      ++num;
      pt.X += dir.X;
      pt.Y += dir.Y;
    }
    return false;
  }

  public class NetModule : Terraria.Net.NetModule
  {
    public override bool Deserialize(BinaryReader reader, int userId)
    {
      if (Main.netMode != 1)
        return false;
      Main.player[(int) reader.ReadByte()].insideUnbreakableWalls = reader.ReadBoolean();
      return true;
    }

    internal static void BroadcastChange(Player player)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<UnbreakableWallScan.NetModule>();
      packet.Writer.Write((byte) player.whoAmI);
      packet.Writer.Write(player.insideUnbreakableWalls);
      NetManager.Instance.Broadcast(packet);
    }
  }
}
