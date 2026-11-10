// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetTextModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetTextModule : Terraria.Net.NetModule
{
  public static NetPacket SerializeClientMessage(ChatMessage message)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetTextModule>();
    message.Serialize(packet.Writer);
    return packet;
  }

  public static NetPacket SerializeServerMessage(NetworkText text, Color color)
  {
    return NetTextModule.SerializeServerMessage(text, color, byte.MaxValue);
  }

  public static NetPacket SerializeServerMessage(NetworkText text, Color color, byte authorId)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetTextModule>();
    packet.Writer.Write(authorId);
    text.Serialize(packet.Writer);
    packet.Writer.WriteRGB(color);
    return packet;
  }

  private bool DeserializeAsClient(BinaryReader reader, int senderPlayerId)
  {
    byte messageAuthor = reader.ReadByte();
    ChatHelper.DisplayMessage(NetworkText.Deserialize(reader), reader.ReadRGB(), messageAuthor);
    return true;
  }

  private bool DeserializeAsServer(BinaryReader reader, int senderPlayerId)
  {
    ChatMessage message = ChatMessage.Deserialize(reader);
    ChatManager.Commands.ProcessIncomingMessage(message, senderPlayerId);
    return true;
  }

  public override bool Deserialize(BinaryReader reader, int senderPlayerId)
  {
    return Main.dedServ ? this.DeserializeAsServer(reader, senderPlayerId) : this.DeserializeAsClient(reader, senderPlayerId);
  }
}
