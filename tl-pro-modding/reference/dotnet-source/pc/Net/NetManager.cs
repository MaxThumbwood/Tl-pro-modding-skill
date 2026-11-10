// Decompiled with JetBrains decompiler
// Type: Terraria.Net.NetManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using System.IO;
using Terraria.Net.Sockets;

#nullable disable
namespace Terraria.Net;

public class NetManager
{
  public static readonly NetManager Instance = new NetManager();
  private Dictionary<ushort, NetModule> _modules = new Dictionary<ushort, NetModule>();
  private ushort _moduleCount;

  private NetManager()
  {
  }

  public void Register<T>() where T : NetModule, new()
  {
    T obj = new T();
    NetManager.PacketTypeStorage<T>.Id = this._moduleCount;
    NetManager.PacketTypeStorage<T>.Module = obj;
    this._modules[this._moduleCount] = (NetModule) obj;
    ++this._moduleCount;
  }

  public NetModule GetModule<T>() where T : NetModule
  {
    return (NetModule) NetManager.PacketTypeStorage<T>.Module;
  }

  public ushort GetId<T>() where T : NetModule => NetManager.PacketTypeStorage<T>.Id;

  public void Read(BinaryReader reader, int userId, int readLength)
  {
    this.Read(reader, userId, readLength, true);
  }

  private void Read(BinaryReader reader, int userId, int readLength, bool addToDiagnostics)
  {
    ushort num = reader.ReadUInt16();
    if (this._modules.ContainsKey(num))
      this._modules[num].Deserialize(reader, userId);
    if (!addToDiagnostics)
      return;
    Main.ActiveNetDiagnosticsUI.CountReadModuleMessage((int) num, readLength);
  }

  public void Broadcast(NetPacket packet, int ignoreClient = -1)
  {
    for (int index = 0; index < 256 /*0x0100*/; ++index)
    {
      if (index != ignoreClient && Netplay.Clients[index].IsConnected())
        this.SendData(Netplay.Clients[index].Socket, packet);
    }
    packet.Recycle();
  }

  public void Broadcast(
    NetPacket packet,
    NetManager.BroadcastCondition conditionToBroadcast,
    int ignoreClient = -1)
  {
    for (int clientIndex = 0; clientIndex < 256 /*0x0100*/; ++clientIndex)
    {
      if (clientIndex != ignoreClient && Netplay.Clients[clientIndex].IsConnected() && conditionToBroadcast(clientIndex))
        this.SendData(Netplay.Clients[clientIndex].Socket, packet);
    }
    packet.Recycle();
  }

  private void SendToSelf(NetPacket packet)
  {
    packet.Reader.BaseStream.Position = 3L;
    this.Read(packet.Reader, Main.myPlayer, packet.Length, false);
    packet.Recycle();
  }

  public void BroadcastOrLoopback(NetPacket packet)
  {
    if (Main.netMode == 2)
      this.Broadcast(packet);
    else if (Main.netMode == 0)
      this.SendToSelf(packet);
    else
      packet.Recycle();
  }

  public void SendToServerOrLoopback(NetPacket packet)
  {
    if (Main.netMode == 1)
      this.SendToServer(packet);
    else if (Main.netMode == 0)
      this.SendToSelf(packet);
    else
      packet.Recycle();
  }

  public void SendToServerOrBroadcast(NetPacket packet)
  {
    if (Main.netMode == 1)
      this.SendToServer(packet);
    else if (Main.netMode == 2)
      this.Broadcast(packet);
    else
      packet.Recycle();
  }

  public void SendToServer(NetPacket packet)
  {
    this.SendData(Netplay.Connection.Socket, packet);
    packet.Recycle();
  }

  public void SendToClient(NetPacket packet, int playerId)
  {
    this.SendData(Netplay.Clients[playerId].Socket, packet);
    packet.Recycle();
  }

  public void SendToClientOrLoopback(NetPacket packet, int playerId)
  {
    if (Main.netMode == 0 && playerId == Main.myPlayer)
      this.SendToSelf(packet);
    else
      this.SendToClient(packet, playerId);
  }

  private void SendData(ISocket socket, NetPacket packet)
  {
    if (Main.netMode == 0)
      return;
    packet.ShrinkToFit();
    try
    {
      Main.ActiveNetDiagnosticsUI.CountSentModuleMessage((int) packet.Id, packet.Length);
      socket.AsyncSend(packet.Buffer.Data, 0, packet.Length, new SocketSendCallback(NetManager.EmptyCallback));
    }
    catch
    {
    }
  }

  private static void EmptyCallback(object state)
  {
  }

  private class PacketTypeStorage<T> where T : NetModule
  {
    public static ushort Id;
    public static T Module;
  }

  public delegate bool BroadcastCondition(int clientIndex);
}
