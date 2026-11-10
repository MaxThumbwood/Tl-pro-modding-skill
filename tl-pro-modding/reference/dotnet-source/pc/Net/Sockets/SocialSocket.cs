// Decompiled with JetBrains decompiler
// Type: Terraria.Net.Sockets.SocialSocket
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Threading;
using Terraria.Social;

#nullable disable
namespace Terraria.Net.Sockets;

public class SocialSocket : ISocket
{
  private RemoteAddress _remoteAddress;

  public SocialSocket()
  {
  }

  public SocialSocket(RemoteAddress remoteAddress) => this._remoteAddress = remoteAddress;

  void ISocket.Close()
  {
    if (this._remoteAddress == null)
      return;
    SocialAPI.Network.Close(this._remoteAddress);
    this._remoteAddress = (RemoteAddress) null;
  }

  bool ISocket.IsConnected() => SocialAPI.Network.IsConnected(this._remoteAddress);

  void ISocket.Connect(RemoteAddress address)
  {
    this._remoteAddress = address;
    SocialAPI.Network.Connect(address);
  }

  void ISocket.AsyncSend(
    byte[] data,
    int offset,
    int size,
    SocketSendCallback callback,
    object state)
  {
    SocialAPI.Network.Send(this._remoteAddress, data, size);
    callback.BeginInvoke(state, (AsyncCallback) null, (object) null);
  }

  private void ReadCallback(
    byte[] data,
    int offset,
    int size,
    SocketReceiveCallback callback,
    object state)
  {
    int size1;
    while ((size1 = SocialAPI.Network.Receive(this._remoteAddress, data, offset, size)) == 0)
      Thread.Sleep(1);
    callback(state, size1);
  }

  void ISocket.AsyncReceive(
    byte[] data,
    int offset,
    int size,
    SocketReceiveCallback callback,
    object state)
  {
    new SocialSocket.InternalReadCallback(this.ReadCallback).BeginInvoke(data, offset, size, callback, state, (AsyncCallback) null, (object) null);
  }

  bool ISocket.IsDataAvailable() => SocialAPI.Network.IsDataAvailable(this._remoteAddress);

  RemoteAddress ISocket.GetRemoteAddress() => this._remoteAddress;

  bool ISocket.StartListening(SocketConnectionAccepted callback)
  {
    return SocialAPI.Network.StartListening(callback);
  }

  void ISocket.StopListening() => SocialAPI.Network.StopListening();

  private delegate void InternalReadCallback(
    byte[] data,
    int offset,
    int size,
    SocketReceiveCallback callback,
    object state);
}
