// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.Bits64
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Utilities;

public struct Bits64
{
  private ulong v;

  public bool this[int i]
  {
    get => (this.v & (ulong) (1L << i)) > 0UL;
    set
    {
      if (value)
        this.v |= (ulong) (1L << i);
      else
        this.v &= (ulong) ~(1L << i);
    }
  }

  public bool IsEmpty => this.v == 0UL;

  public static implicit operator ulong(Bits64 b) => b.v;

  public static implicit operator Bits64(ulong v)
  {
    return new Bits64() { v = v };
  }
}
