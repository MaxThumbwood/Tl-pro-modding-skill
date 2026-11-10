// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.BufferPool
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public static class BufferPool
{
  private const int SMALL_BUFFER_SIZE = 32 /*0x20*/;
  private const int MEDIUM_BUFFER_SIZE = 256 /*0x0100*/;
  private const int LARGE_BUFFER_SIZE = 16384 /*0x4000*/;
  private const int HUGE_BUFFER_SIZE = 65536 /*0x010000*/;
  private static object bufferLock = new object();
  private static Queue<CachedBuffer> SmallBufferQueue = new Queue<CachedBuffer>();
  private static Queue<CachedBuffer> MediumBufferQueue = new Queue<CachedBuffer>();
  private static Queue<CachedBuffer> LargeBufferQueue = new Queue<CachedBuffer>();
  private static Queue<CachedBuffer> HugeBufferQueue = new Queue<CachedBuffer>();

  public static CachedBuffer Request(int size)
  {
    lock (BufferPool.bufferLock)
    {
      if (size <= 32 /*0x20*/)
        return BufferPool.SmallBufferQueue.Count == 0 ? new CachedBuffer(new byte[32 /*0x20*/]) : BufferPool.SmallBufferQueue.Dequeue().Activate();
      if (size <= 256 /*0x0100*/)
        return BufferPool.MediumBufferQueue.Count == 0 ? new CachedBuffer(new byte[256 /*0x0100*/]) : BufferPool.MediumBufferQueue.Dequeue().Activate();
      if (size <= 16384 /*0x4000*/)
        return BufferPool.LargeBufferQueue.Count == 0 ? new CachedBuffer(new byte[16384 /*0x4000*/]) : BufferPool.LargeBufferQueue.Dequeue().Activate();
      if (size > 65536 /*0x010000*/)
        return new CachedBuffer(new byte[size]);
      return BufferPool.HugeBufferQueue.Count == 0 ? new CachedBuffer(new byte[65536 /*0x010000*/]) : BufferPool.HugeBufferQueue.Dequeue().Activate();
    }
  }

  public static CachedBuffer Request(byte[] data, int offset, int size)
  {
    CachedBuffer cachedBuffer = BufferPool.Request(size);
    Buffer.BlockCopy((Array) data, offset, (Array) cachedBuffer.Data, 0, size);
    return cachedBuffer;
  }

  public static void Recycle(CachedBuffer buffer)
  {
    int length = buffer.Length;
    lock (BufferPool.bufferLock)
    {
      if (length <= 32 /*0x20*/)
        BufferPool.SmallBufferQueue.Enqueue(buffer);
      else if (length <= 256 /*0x0100*/)
        BufferPool.MediumBufferQueue.Enqueue(buffer);
      else if (length <= 16384 /*0x4000*/)
      {
        BufferPool.LargeBufferQueue.Enqueue(buffer);
      }
      else
      {
        if (length > 65536 /*0x010000*/)
          return;
        BufferPool.HugeBufferQueue.Enqueue(buffer);
      }
    }
  }

  public static void PrintBufferSizes()
  {
    lock (BufferPool.bufferLock)
    {
      Console.WriteLine("SmallBufferQueue.Count: " + (object) BufferPool.SmallBufferQueue.Count);
      Console.WriteLine("MediumBufferQueue.Count: " + (object) BufferPool.MediumBufferQueue.Count);
      Console.WriteLine("LargeBufferQueue.Count: " + (object) BufferPool.LargeBufferQueue.Count);
      Console.WriteLine("HugeBufferQueue.Count: " + (object) BufferPool.HugeBufferQueue.Count);
      Console.WriteLine("");
    }
  }
}
