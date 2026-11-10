// Decompiled with JetBrains decompiler
// Type: Terraria.Net.TcpAddress
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Net;

#nullable disable
namespace Terraria.Net;

public class TcpAddress : RemoteAddress
{
  public IPAddress Address;
  public int Port;

  public TcpAddress(IPAddress address, int port)
  {
    this.Type = AddressType.Tcp;
    this.Address = address;
    this.Port = port;
  }

  public override string GetIdentifier() => this.Address.ToString();

  public override bool IsLocalHost() => this.Address.Equals((object) IPAddress.Loopback);

  public override string ToString() => new IPEndPoint(this.Address, this.Port).ToString();

  public override string GetFriendlyName() => this.ToString();
}
