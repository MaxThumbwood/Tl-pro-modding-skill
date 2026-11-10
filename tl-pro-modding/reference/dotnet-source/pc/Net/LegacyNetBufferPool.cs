// Decompiled with JetBrains decompiler
// Type: Terraria.Net.LegacyNetBufferPool
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Net;

public class LegacyNetBufferPool
{
  private const int SMALL_BUFFER_SIZE = 256 /*0x0100*/;
  private const int MEDIUM_BUFFER_SIZE = 1024 /*0x0400*/;
  private const int LARGE_BUFFER_SIZE = 16384 /*0x4000*/;
  private static object bufferLock = new object();
  private static Queue<byte[]> _smallBufferQueue = new Queue<byte[]>();
  private static Queue<byte[]> _mediumBufferQueue = new Queue<byte[]>();
  private static Queue<byte[]> _largeBufferQueue = new Queue<byte[]>();
  private static int _smallBufferCount;
  private static int _mediumBufferCount;
  private static int _largeBufferCount;
  private static int _customBufferCount;

  public static byte[] RequestBuffer(int size)
  {
    lock (LegacyNetBufferPool.bufferLock)
    {
      if (size <= 256 /*0x0100*/)
      {
        if (LegacyNetBufferPool._smallBufferQueue.Count != 0)
          return LegacyNetBufferPool._smallBufferQueue.Dequeue();
        ++LegacyNetBufferPool._smallBufferCount;
        return new byte[256 /*0x0100*/];
      }
      if (size <= 1024 /*0x0400*/)
      {
        if (LegacyNetBufferPool._mediumBufferQueue.Count != 0)
          return LegacyNetBufferPool._mediumBufferQueue.Dequeue();
        ++LegacyNetBufferPool._mediumBufferCount;
        return new byte[1024 /*0x0400*/];
      }
      if (size <= 16384 /*0x4000*/)
      {
        if (LegacyNetBufferPool._largeBufferQueue.Count != 0)
          return LegacyNetBufferPool._largeBufferQueue.Dequeue();
        ++LegacyNetBufferPool._largeBufferCount;
        return new byte[16384 /*0x4000*/];
      }
      ++LegacyNetBufferPool._customBufferCount;
      return new byte[size];
    }
  }

  public static byte[] RequestBuffer(byte[] data, int offset, int size)
  {
    byte[] dst = LegacyNetBufferPool.RequestBuffer(size);
    Buffer.BlockCopy((Array) data, offset, (Array) dst, 0, size);
    return dst;
  }

  public static void ReturnBuffer(byte[] buffer)
  {
    int length = buffer.Length;
    lock (LegacyNetBufferPool.bufferLock)
    {
      if (length <= 256 /*0x0100*/)
        LegacyNetBufferPool._smallBufferQueue.Enqueue(buffer);
      else if (length <= 1024 /*0x0400*/)
      {
        LegacyNetBufferPool._mediumBufferQueue.Enqueue(buffer);
      }
      else
      {
        if (length > 16384 /*0x4000*/)
          return;
        LegacyNetBufferPool._largeBufferQueue.Enqueue(buffer);
      }
    }
  }

  public static void DisplayBufferSizes()
  {
    lock (LegacyNetBufferPool.bufferLock)
    {
      Main.NewText($"Small Buffers:  {(object) LegacyNetBufferPool._smallBufferQueue.Count} queued of {(object) LegacyNetBufferPool._smallBufferCount}");
      Main.NewText($"Medium Buffers: {(object) LegacyNetBufferPool._mediumBufferQueue.Count} queued of {(object) LegacyNetBufferPool._mediumBufferCount}");
      Main.NewText($"Large Buffers:  {(object) LegacyNetBufferPool._largeBufferQueue.Count} queued of {(object) LegacyNetBufferPool._largeBufferCount}");
      Main.NewText("Custom Buffers: 0 queued of " + (object) LegacyNetBufferPool._customBufferCount);
    }
  }

  public static void PrintBufferSizes()
  {
    lock (LegacyNetBufferPool.bufferLock)
    {
      Console.WriteLine($"Small Buffers:  {(object) LegacyNetBufferPool._smallBufferQueue.Count} queued of {(object) LegacyNetBufferPool._smallBufferCount}");
      Console.WriteLine($"Medium Buffers: {(object) LegacyNetBufferPool._mediumBufferQueue.Count} queued of {(object) LegacyNetBufferPool._mediumBufferCount}");
      Console.WriteLine($"Large Buffers:  {(object) LegacyNetBufferPool._largeBufferQueue.Count} queued of {(object) LegacyNetBufferPool._largeBufferCount}");
      Console.WriteLine("Custom Buffers: 0 queued of " + (object) LegacyNetBufferPool._customBufferCount);
      Console.WriteLine("");
    }
  }
}
