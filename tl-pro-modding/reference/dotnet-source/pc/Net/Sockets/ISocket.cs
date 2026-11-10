// Decompiled with JetBrains decompiler
// Type: Terraria.Net.Sockets.ISocket
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Net.Sockets;

public interface ISocket
{
  void Close();

  bool IsConnected();

  void Connect(RemoteAddress address);

  void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state = null);

  void AsyncReceive(
    byte[] data,
    int offset,
    int size,
    SocketReceiveCallback callback,
    object state = null);

  bool IsDataAvailable();

  bool StartListening(SocketConnectionAccepted callback);

  void StopListening();

  RemoteAddress GetRemoteAddress();
}
