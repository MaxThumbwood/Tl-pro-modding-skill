// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.CachedBuffer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.DataStructures;

public class CachedBuffer
{
  public readonly byte[] Data;
  public readonly BinaryWriter Writer;
  public readonly BinaryReader Reader;
  private readonly MemoryStream _memoryStream;
  private bool _isActive = true;

  public int Length => this.Data.Length;

  public bool IsActive => this._isActive;

  public CachedBuffer(byte[] data)
  {
    this.Data = data;
    this._memoryStream = new MemoryStream(data);
    this.Writer = new BinaryWriter((Stream) this._memoryStream);
    this.Reader = new BinaryReader((Stream) this._memoryStream);
  }

  internal CachedBuffer Activate()
  {
    this._isActive = true;
    this._memoryStream.Position = 0L;
    return this;
  }

  public void Recycle()
  {
    if (!this._isActive)
      return;
    this._isActive = false;
    BufferPool.Recycle(this);
  }
}
