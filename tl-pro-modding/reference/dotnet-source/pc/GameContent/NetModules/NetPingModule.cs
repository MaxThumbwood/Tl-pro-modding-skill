// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetPingModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetPingModule : Terraria.Net.NetModule
{
  public static NetPacket Serialize(Vector2 position)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetPingModule>();
    packet.Writer.WriteVector2(position);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    Vector2 position = reader.ReadVector2();
    if (Main.dedServ)
      NetManager.Instance.Broadcast(NetPingModule.Serialize(position), userId);
    else
      Main.Pings.Add(position);
    return true;
  }
}
