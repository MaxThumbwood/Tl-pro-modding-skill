// Decompiled with JetBrains decompiler
// Type: Terraria.RemoteServer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.IO;
using Terraria.Net.Sockets;

#nullable disable
namespace Terraria;

public class RemoteServer
{
  public ISocket Socket = (ISocket) new TcpSocket();
  public bool IsActive;
  public int State;
  public int TimeOutTimer;
  public bool PendingTermination;
  public bool IsReading;
  public byte[] ReadBuffer;
  public string StatusText;
  public int StatusCount;
  public int StatusMax;
  public BitsByte ServerSpecialFlags;

  public bool HideStatusTextPercent => this.ServerSpecialFlags[0];

  public bool StatusTextHasShadows => this.ServerSpecialFlags[1];

  public bool ServerWantsToRunCheckBytesInClientLoopThread => this.ServerSpecialFlags[2];

  public void ResetSpecialFlags() => this.ServerSpecialFlags = (BitsByte) (byte) 0;

  public bool ReadBufferFull
  {
    get => NetMessage.buffer[256 /*0x0100*/].RemainingReadBufferLength < this.ReadBuffer.Length;
  }

  public bool IsConnected() => !this.PendingTermination && this.Socket.IsConnected();

  public void ClientWriteCallBack(object state) => --NetMessage.buffer[256 /*0x0100*/].spamCount;

  public void ClientReadCallBack(object state, int streamLength)
  {
    try
    {
      if (!Netplay.Disconnect)
      {
        if (streamLength == 0)
          this.PendingTermination = true;
        else if (Main.ignoreErrors)
        {
          try
          {
            NetMessage.ReceiveBytes(this.ReadBuffer, streamLength);
          }
          catch
          {
          }
        }
        else
          NetMessage.ReceiveBytes(this.ReadBuffer, streamLength);
      }
      this.IsReading = false;
    }
    catch (Exception ex)
    {
      try
      {
        using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
        {
          streamWriter.WriteLine((object) DateTime.Now);
          streamWriter.WriteLine((object) ex);
          streamWriter.WriteLine("");
        }
      }
      catch
      {
      }
      Netplay.Disconnect = true;
    }
  }
}
