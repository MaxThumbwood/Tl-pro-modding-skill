// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NetModules.NetParticlesModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.GameContent.Drawing;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.NetModules;

public class NetParticlesModule : Terraria.Net.NetModule
{
  public static NetPacket Serialize(
    ParticleOrchestraType particleType,
    ParticleOrchestraSettings settings)
  {
    NetPacket packet = Terraria.Net.NetModule.CreatePacket<NetParticlesModule>(22);
    packet.Writer.Write((byte) particleType);
    settings.Serialize(packet.Writer);
    return packet;
  }

  public override bool Deserialize(BinaryReader reader, int userId)
  {
    ParticleOrchestraType particleOrchestraType = (ParticleOrchestraType) reader.ReadByte();
    ParticleOrchestraSettings settings = new ParticleOrchestraSettings();
    settings.DeserializeFrom(reader);
    if (Main.netMode == 2)
      NetManager.Instance.Broadcast(NetParticlesModule.Serialize(particleOrchestraType, settings), userId);
    else
      ParticleOrchestrator.SpawnParticlesDirect(particleOrchestraType, settings);
    return true;
  }
}
