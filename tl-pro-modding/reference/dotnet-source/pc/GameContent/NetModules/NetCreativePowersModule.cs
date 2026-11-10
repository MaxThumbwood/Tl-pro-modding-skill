// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetCreativePowersModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.GameContent.Creative;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetCreativePowersModule : Terraria.Net.NetModule
{
  public static NetPacket PreparePacket(ushort powerId, int specificInfoBytesInPacketCount)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetCreativePowersModule>();
    packet.Writer.Write(powerId);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    ushort id = reader.ReadUInt16();
    ICreativePower power;
    if (!CreativePowerManager.Instance.TryGetPower(id, out power))
      return false;
    power.DeserializeNetMessage(reader, userId);
    return true;
  }
}
