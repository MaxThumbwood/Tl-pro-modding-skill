// Decompiled with JetBrains decompiler
// Type: Terraria.Net.NetPacket
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.IO;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Net;

public struct NetPacket
{
  public const int HEADER_SIZE = 5;
  public readonly ushort Id;
  public readonly CachedBuffer Buffer;

  public int Length { get; private set; }

  public BinaryWriter Writer => this.Buffer.Writer;

  public BinaryReader Reader => this.Buffer.Reader;

  public NetPacket(ushort id, int size)
    : this()
  {
    this.Id = id;
    this.Length = size + 5;
    this.Buffer = this.Length <= (int) ushort.MaxValue ? BufferPool.Request(this.Length) : throw new ArgumentOutOfRangeException("Tried to create a packet with length > " + (object) ushort.MaxValue);
    this.Writer.Write((ushort) this.Length);
    this.Writer.Write((byte) 82);
    this.Writer.Write(id);
  }

  public void Recycle() => this.Buffer.Recycle();

  public void ShrinkToFit()
  {
    if (this.Length == (int) this.Writer.BaseStream.Position)
      return;
    if (this.Writer.BaseStream.Position > (long) this.Length)
      throw new IndexOutOfRangeException("Overwrite on supplied Length. Consider letting Length default to max packet size if you don't know how long it will be");
    this.Length = (int) this.Writer.BaseStream.Position;
    this.Writer.Seek(0, SeekOrigin.Begin);
    this.Writer.Write((ushort) this.Length);
    this.Writer.Seek(this.Length, SeekOrigin.Begin);
  }
}
