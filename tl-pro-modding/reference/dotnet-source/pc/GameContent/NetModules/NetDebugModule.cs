// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetDebugModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.Net;
using Terraria.Testing.ChatCommands;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetDebugModule : Terraria.Net.NetModule
{
  public static NetPacket Serialize(DebugMessage message)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetDebugModule>();
    message.Serialize(packet.Writer);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int senderPlayerId)
  {
    DebugMessage message = DebugMessage.Deserialize((byte) senderPlayerId, reader);
    ChatManager.DebugCommands.Process(message);
    return true;
  }
}
