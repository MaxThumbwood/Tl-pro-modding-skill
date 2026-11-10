// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Steam.CloudSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Steamworks;
using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Social.Steam;

public class CloudSocialModule : Terraria.Social.Base.CloudSocialModule
{
  private const uint WRITE_CHUNK_SIZE = 1024 /*0x0400*/;
  private object ioLock = new object();
  private byte[] writeBuffer = new byte[1024 /*0x0400*/];

  public override void Initialize()
  {
  }

  public override void Shutdown()
  {
  }

  public override IEnumerable<string> GetFiles()
  {
    lock (this.ioLock)
    {
      int fileCount = SteamRemoteStorage.GetFileCount();
      List<string> files = new List<string>(fileCount);
      for (int index = 0; index < fileCount; ++index)
      {
        int num;
        files.Add(SteamRemoteStorage.GetFileNameAndSize(index, ref num));
      }
      return (IEnumerable<string>) files;
    }
  }

  public override bool Write(string path, byte[] data, int length)
  {
    lock (this.ioLock)
    {
      UGCFileWriteStreamHandle_t writeStreamHandleT = SteamRemoteStorage.FileWriteStreamOpen(path);
      bool flag = false;
      for (uint sourceIndex = 0; (long) sourceIndex < (long) length; sourceIndex += 1024U /*0x0400*/)
      {
        int length1 = (int) Math.Min(1024L /*0x0400*/, (long) length - (long) sourceIndex);
        Array.Copy((Array) data, (long) sourceIndex, (Array) this.writeBuffer, 0L, (long) length1);
        if (!SteamRemoteStorage.FileWriteStreamWriteChunk(writeStreamHandleT, this.writeBuffer, length1))
        {
          flag = true;
          break;
        }
      }
      if (!flag)
        return SteamRemoteStorage.FileWriteStreamClose(writeStreamHandleT);
      SteamRemoteStorage.FileWriteStreamCancel(writeStreamHandleT);
      return false;
    }
  }

  public override int GetFileSize(string path)
  {
    lock (this.ioLock)
      return SteamRemoteStorage.GetFileSize(path);
  }

  public override void Read(string path, byte[] buffer, int size)
  {
    lock (this.ioLock)
      SteamRemoteStorage.FileRead(path, buffer, size);
  }

  public override bool HasFile(string path)
  {
    lock (this.ioLock)
      return SteamRemoteStorage.FileExists(path);
  }

  public override bool Delete(string path)
  {
    lock (this.ioLock)
      return SteamRemoteStorage.FileDelete(path);
  }

  public override bool Forget(string path)
  {
    lock (this.ioLock)
      return SteamRemoteStorage.FileForget(path);
  }
}
