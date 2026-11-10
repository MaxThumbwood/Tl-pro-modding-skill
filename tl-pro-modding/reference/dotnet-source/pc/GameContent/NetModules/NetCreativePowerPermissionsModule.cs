// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetCreativePowerPermissionsModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.GameContent.Creative;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetCreativePowerPermissionsModule : Terraria.Net.NetModule
{
  private const byte _setPermissionLevelId = 0;

  public static NetPacket SerializeCurrentPowerPermissionLevel(ushort powerId, int level)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetCreativePowerPermissionsModule>();
    packet.Writer.Write((byte) 0);
    packet.Writer.Write(powerId);
    packet.Writer.Write((byte) level);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    if (reader.ReadByte() == (byte) 0)
    {
      ushort id = reader.ReadUInt16();
      int num = (int) reader.ReadByte();
      ICreativePower power;
      if (Main.netMode == 2 || !CreativePowerManager.Instance.TryGetPower(id, out power))
        return false;
      power.CurrentPermissionLevel = (PowerPermissionLevel) num;
    }
    return true;
  }
}
