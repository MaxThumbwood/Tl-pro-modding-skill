// Decompiled with JetBrains decompiler
// Type: Terraria.Net.Sockets.DebugNetworkStream
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;

#nullable disable
namespace Terraria.Net.Sockets;

public class DebugNetworkStream
{
  public static uint Latency;
  private readonly NetworkStream _stream;
  private Queue<DebugNetworkStream.Packet> _outgoingQueue = new Queue<DebugNetworkStream.Packet>();
  private Queue<DebugNetworkStream.Packet> _incomingQueue = new Queue<DebugNetworkStream.Packet>();
  private Exception _writeException;
  private Exception _readException;
  private DebugNetworkStream.ReadMode _readMode;
  private bool _closed;
  private long _startTicks = Stopwatch.GetTimestamp();
  private BinaryWriter _logWriter;
  private ArraySegment<byte> _beginReadBuf;

  public DebugNetworkStream(NetworkStream stream) => this._stream = stream;

  public bool DataAvailable
  {
    get
    {
      lock (this._incomingQueue)
      {
        if (this._incomingQueue.Count > 0)
          return this._incomingQueue.Peek().IsReady();
        return this._readMode == DebugNetworkStream.ReadMode.None && this._stream.DataAvailable;
      }
    }
  }

  public void BeginWrite(
    byte[] buffer,
    int offset,
    int count,
    AsyncCallback callback,
    object state)
  {
    if (this._closed)
      throw new ObjectDisposedException("NetworkStream");
    if (this._writeException != null)
      throw this._writeException;
    lock (this._outgoingQueue)
    {
      if (DebugNetworkStream.Latency == 0U && this._outgoingQueue.Count == 0)
      {
        this._stream.BeginWrite(buffer, offset, count, callback, state);
      }
      else
      {
        this._outgoingQueue.Enqueue(DebugNetworkStream.Packet.CopyOfSlice(buffer, offset, count));
        callback((IAsyncResult) new DebugNetworkStream.CompletedAsyncResult()
        {
          AsyncState = state
        });
      }
    }
  }

  public void EndWrite(IAsyncResult result)
  {
    if (result is DebugNetworkStream.CompletedAsyncResult)
      return;
    this._stream.EndWrite(result);
  }

  public void BeginRead(
    byte[] buffer,
    int offset,
    int count,
    AsyncCallback callback,
    object state)
  {
    if (this._closed)
      throw new ObjectDisposedException("NetworkStream");
    if (this._readException != null)
      throw this._readException;
    this._beginReadBuf = new ArraySegment<byte>(buffer, offset, count);
    lock (this._incomingQueue)
    {
      while (this._readMode == DebugNetworkStream.ReadMode.Buffered && this._incomingQueue.Count == 0)
      {
        Monitor.Exit((object) this._incomingQueue);
        Thread.Sleep(1);
        Monitor.Enter((object) this._incomingQueue);
        if (this._readException != null)
          throw this._readException;
      }
      if (this._readMode == DebugNetworkStream.ReadMode.None && this._incomingQueue.Count == 0)
      {
        this._readMode = DebugNetworkStream.ReadMode.Direct;
        this._stream.BeginRead(buffer, offset, count, callback, state);
      }
      else
      {
        int num = 0;
        while (count > 0 && this._incomingQueue.Count > 0 && this._incomingQueue.Peek().IsReady())
        {
          DebugNetworkStream.Packet packet = this._incomingQueue.Peek();
          if (packet.Data.Count != 0)
          {
            int length = Math.Min(packet.Data.Count, count);
            Array.Copy((Array) packet.Data.Array, packet.Data.Offset, (Array) buffer, offset, length);
            offset += length;
            count -= length;
            num += length;
            if (length == packet.Data.Count)
              this._incomingQueue.Dequeue();
            else
              packet.Data = new ArraySegment<byte>(packet.Data.Array, packet.Data.Offset + length, packet.Data.Count - length);
          }
          else
            break;
        }
        callback((IAsyncResult) new DebugNetworkStream.CompletedAsyncResult()
        {
          AsyncState = state,
          Read = num
        });
      }
    }
  }

  public int EndRead(IAsyncResult result)
  {
    if (result is DebugNetworkStream.CompletedAsyncResult)
      return ((DebugNetworkStream.CompletedAsyncResult) result).Read;
    this._readMode = DebugNetworkStream.ReadMode.None;
    return this._stream.EndRead(result);
  }

  public void Close()
  {
    this._closed = true;
    try
    {
      if (this._logWriter == null)
        return;
      lock (this._logWriter)
        this._logWriter.Close();
    }
    catch (Exception ex)
    {
    }
  }

  private void Run()
  {
    byte[] buffer = (byte[]) null;
    while (!this._closed)
    {
      lock (this._outgoingQueue)
      {
        while (this._writeException == null)
        {
          if (this._outgoingQueue.Count > 0)
          {
            if (this._outgoingQueue.Peek().IsReady())
              this.BeginBufferedWrite(this._outgoingQueue.Dequeue());
            else
              break;
          }
          else
            break;
        }
      }
      lock (this._incomingQueue)
      {
        if (this._readMode == DebugNetworkStream.ReadMode.None)
        {
          if (DebugNetworkStream.Latency > 0U)
          {
            this._readMode = DebugNetworkStream.ReadMode.Buffered;
            if (buffer == null)
              buffer = new byte[65536 /*0x010000*/];
            this.BeginBufferedRead(buffer);
          }
        }
      }
      Thread.Sleep(1);
    }
  }

  private void BeginBufferedWrite(DebugNetworkStream.Packet packet)
  {
    try
    {
      this._stream.BeginWrite(packet.Data.Array, packet.Data.Offset, packet.Data.Count, new AsyncCallback(this.BufferedWriteCallback), (object) null);
    }
    catch (Exception ex)
    {
      this._writeException = ex;
    }
  }

  private void BufferedWriteCallback(IAsyncResult result)
  {
    try
    {
      this._stream.EndWrite(result);
    }
    catch (Exception ex)
    {
      this._writeException = ex;
    }
  }

  private void BeginBufferedRead(byte[] buffer)
  {
    try
    {
      this._stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(this.BufferedReadCallback), (object) buffer);
    }
    catch (Exception ex)
    {
      this._readException = ex;
    }
  }

  private void BufferedReadCallback(IAsyncResult result)
  {
    int count;
    try
    {
      count = this._stream.EndRead(result);
    }
    catch (Exception ex)
    {
      this._readException = ex;
      return;
    }
    lock (this._incomingQueue)
    {
      byte[] asyncState = (byte[]) result.AsyncState;
      this._incomingQueue.Enqueue(DebugNetworkStream.Packet.CopyOfSlice(asyncState, 0, count));
      if (count == 0)
        return;
      if (DebugNetworkStream.Latency == 0U)
        this._readMode = DebugNetworkStream.ReadMode.None;
      else
        this.BeginBufferedRead(asyncState);
    }
  }

  private class Packet
  {
    public DateTime BaseTimestamp;
    public ArraySegment<byte> Data;

    public bool IsReady()
    {
      return this.BaseTimestamp + TimeSpan.FromMilliseconds((double) DebugNetworkStream.Latency) <= DateTime.Now;
    }

    public static DebugNetworkStream.Packet CopyOfSlice(byte[] buffer, int offset, int count)
    {
      byte[] numArray = new byte[count];
      Array.Copy((Array) buffer, offset, (Array) numArray, 0, count);
      return new DebugNetworkStream.Packet()
      {
        BaseTimestamp = DateTime.Now,
        Data = new ArraySegment<byte>(numArray)
      };
    }
  }

  private class CompletedAsyncResult : IAsyncResult
  {
    public object AsyncState { get; set; }

    public int Read { get; set; }

    public bool IsCompleted => true;

    public bool CompletedSynchronously => true;

    public WaitHandle AsyncWaitHandle => throw new NotImplementedException();
  }

  private enum ReadMode
  {
    None,
    Direct,
    Buffered,
  }
}
