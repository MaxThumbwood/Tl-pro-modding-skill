// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.AnchorData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Enums;

#nullable disable
namespace Terraria.DataStructures;

public struct AnchorData(AnchorType type, int count, int start)
{
  public AnchorType type = type;
  public int tileCount = count;
  public int checkStart = start;
  public static AnchorData Empty;

  public static bool operator ==(AnchorData data1, AnchorData data2)
  {
    return data1.type == data2.type && data1.tileCount == data2.tileCount && data1.checkStart == data2.checkStart;
  }

  public static bool operator !=(AnchorData data1, AnchorData data2)
  {
    return data1.type != data2.type || data1.tileCount != data2.tileCount || data1.checkStart != data2.checkStart;
  }

  public override bool Equals(object obj)
  {
    return obj is AnchorData anchorData && this.type == anchorData.type && this.tileCount == ((AnchorData) obj).tileCount && this.checkStart == ((AnchorData) obj).checkStart;
  }

  public override int GetHashCode()
  {
    return (int) (ushort) this.type << 16 /*0x10*/ | (int) (byte) this.tileCount << 8 | (int) (byte) this.checkStart;
  }
}
