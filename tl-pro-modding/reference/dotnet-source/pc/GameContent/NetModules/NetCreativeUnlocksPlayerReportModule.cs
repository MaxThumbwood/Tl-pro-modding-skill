// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetCreativeUnlocksPlayerReportModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetCreativeUnlocksPlayerReportModule : Terraria.Net.NetModule
{
  public static NetPacket SerializeSacrificeRequest(int userId, int itemId, int amount)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetCreativeUnlocksPlayerReportModule>();
    packet.Writer.Write((byte) userId);
    packet.Writer.Write((ushort) itemId);
    packet.Writer.Write((ushort) amount);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    int index = (int) reader.ReadByte();
    int itemId = (int) reader.ReadUInt16();
    int amount = (int) reader.ReadUInt16();
    if (Main.dedServ)
    {
      int num = userId;
      NetManager.Instance.Broadcast(NetCreativeUnlocksPlayerReportModule.SerializeSacrificeRequest(num, itemId, amount), num);
      return true;
    }
    Player player = Main.player[index];
    if (Main.LocalPlayer.team > 0 && Main.LocalPlayer.team == player.team)
      Main.LocalPlayerCreativeTracker.ItemSacrifices.RegisterItemSacrifice(itemId, amount, player.name);
    return true;
  }
}
