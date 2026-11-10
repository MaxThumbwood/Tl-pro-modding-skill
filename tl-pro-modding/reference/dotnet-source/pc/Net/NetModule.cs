// Decompiled with JetBrains decompiler
// Type: Terraria.Net.NetModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.Net;

public abstract class NetModule
{
  public abstract bool Deserialize(BinaryReader reader, int userId);

  protected static NetPacket CreatePacket<T>(int maxSize = 65530) where T : NetModule
  {
    return new NetPacket(NetManager.Instance.GetId<T>(), maxSize);
  }
}
