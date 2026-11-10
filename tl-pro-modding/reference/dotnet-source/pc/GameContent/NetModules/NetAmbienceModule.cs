// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetAmbienceModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.IO;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Effects;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetAmbienceModule : Terraria.Net.NetModule
{
  public static NetPacket SerializeSkyEntitySpawn(Player player, SkyEntityType type)
  {
    int num = Main.rand.Next();
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetAmbienceModule>();
    packet.Writer.Write((byte) player.whoAmI);
    packet.Writer.Write(num);
    packet.Writer.Write((byte) type);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    if (Main.dedServ)
      return false;
    byte playerId = reader.ReadByte();
    int seed = reader.ReadInt32();
    SkyEntityType type = (SkyEntityType) reader.ReadByte();
    if (Main.remixWorld)
      return true;
    Main.QueueMainThreadAction((Action) (() => ((AmbientSky) SkyManager.Instance["Ambience"]).Spawn(Main.player[(int) playerId], type, seed)));
    return true;
  }
}
