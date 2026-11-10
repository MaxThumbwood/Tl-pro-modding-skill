// Decompiled with JetBrains decompiler
// Type: Terraria.Net.Sockets.TcpSocket
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.OS;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Terraria.Localization;

#nullable disable
namespace Terraria.Net.Sockets;

public class TcpSocket : ISocket
{
  private TcpClient _connection;
  private TcpListener _listener;
  private SocketConnectionAccepted _listenerCallback;
  private RemoteAddress _remoteAddress;
  private bool _isListening;
  private DebugNetworkStream _debugStream;

  private DebugNetworkStream GetStream()
  {
    return this._debugStream == null ? (this._debugStream = new DebugNetworkStream(this._connection.GetStream())) : this._debugStream;
  }

  public TcpSocket()
  {
    this._connection = new TcpClient() { NoDelay = true };
  }

  public TcpSocket(TcpClient tcpClient)
  {
    this._connection = tcpClient;
    this._connection.NoDelay = true;
    IPEndPoint remoteEndPoint = (IPEndPoint) tcpClient.Client.RemoteEndPoint;
    this._remoteAddress = (RemoteAddress) new TcpAddress(remoteEndPoint.Address, remoteEndPoint.Port);
  }

  void ISocket.Close()
  {
    this._remoteAddress = (RemoteAddress) null;
    this._connection.Close();
  }

  bool ISocket.IsConnected()
  {
    return this._connection != null && this._connection.Client != null && this._connection.Connected;
  }

  void ISocket.Connect(RemoteAddress address)
  {
    TcpAddress tcpAddress = (TcpAddress) address;
    this._connection.Connect(tcpAddress.Address, tcpAddress.Port);
    this._remoteAddress = address;
  }

  private void ReadCallback(IAsyncResult result)
  {
    try
    {
      Tuple<SocketReceiveCallback, object> asyncState = (Tuple<SocketReceiveCallback, object>) result.AsyncState;
      asyncState.Item1(asyncState.Item2, this.GetStream().EndRead(result));
    }
    catch (ObjectDisposedException ex)
    {
      ((ISocket) this).Close();
    }
  }

  private void SendCallback(IAsyncResult result)
  {
    Tuple<SocketSendCallback, object> asyncState1;
    if (Platform.IsWindows)
    {
      asyncState1 = (Tuple<SocketSendCallback, object>) result.AsyncState;
    }
    else
    {
      object[] asyncState2 = (object[]) result.AsyncState;
      LegacyNetBufferPool.ReturnBuffer((byte[]) asyncState2[1]);
      asyncState1 = (Tuple<SocketSendCallback, object>) asyncState2[0];
    }
    try
    {
      this.GetStream().EndWrite(result);
      asyncState1.Item1(asyncState1.Item2);
    }
    catch (Exception ex)
    {
      ((ISocket) this).Close();
    }
  }

  void ISocket.AsyncSend(
    byte[] data,
    int offset,
    int size,
    SocketSendCallback callback,
    object state)
  {
    if (!Platform.IsWindows)
    {
      byte[] buffer = LegacyNetBufferPool.RequestBuffer(data, offset, size);
      this.GetStream().BeginWrite(buffer, 0, size, new AsyncCallback(this.SendCallback), (object) new object[2]
      {
        (object) new Tuple<SocketSendCallback, object>(callback, state),
        (object) buffer
      });
    }
    else
      this.GetStream().BeginWrite(data, 0, size, new AsyncCallback(this.SendCallback), (object) new Tuple<SocketSendCallback, object>(callback, state));
  }

  void ISocket.AsyncReceive(
    byte[] data,
    int offset,
    int size,
    SocketReceiveCallback callback,
    object state)
  {
    this.GetStream().BeginRead(data, offset, size, new AsyncCallback(this.ReadCallback), (object) new Tuple<SocketReceiveCallback, object>(callback, state));
  }

  bool ISocket.IsDataAvailable() => this._connection.Connected && this.GetStream().DataAvailable;

  RemoteAddress ISocket.GetRemoteAddress() => this._remoteAddress;

  bool ISocket.StartListening(SocketConnectionAccepted callback)
  {
    IPAddress address = IPAddress.Any;
    string ipString;
    if (Program.LaunchParameters.TryGetValue("-ip", out ipString) && !IPAddress.TryParse(ipString, out address))
      address = IPAddress.Any;
    this._isListening = true;
    this._listenerCallback = callback;
    if (this._listener == null)
      this._listener = new TcpListener(address, Netplay.ListenPort);
    try
    {
      this._listener.Start();
    }
    catch (Exception ex)
    {
      return false;
    }
    new Thread(new ThreadStart(this.ListenLoop))
    {
      IsBackground = true,
      Name = "TCP Listen Thread"
    }.Start();
    return true;
  }

  void ISocket.StopListening() => this._isListening = false;

  private void ListenLoop()
  {
    while (this._isListening)
    {
      if (!Netplay.Disconnect)
      {
        try
        {
          ISocket client = (ISocket) new TcpSocket(this._listener.AcceptTcpClient());
          Console.WriteLine(Language.GetTextValue("Net.ClientConnecting", (object) client.GetRemoteAddress()));
          this._listenerCallback(client);
        }
        catch (Exception ex)
        {
        }
      }
      else
        break;
    }
    this._listener.Stop();
  }
}
