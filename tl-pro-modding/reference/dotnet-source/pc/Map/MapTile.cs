// Decompiled with JetBrains decompiler
// Type: Terraria.Map.MapTile
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Map;

public struct MapTile
{
  public ushort Type;
  public byte Light;
  private byte _extraData;

  public bool IsChanged
  {
    get => ((uint) this._extraData & 128U /*0x80*/) > 0U;
    set
    {
      if (value)
        this._extraData |= (byte) 128 /*0x80*/;
      else
        this._extraData &= (byte) 127 /*0x7F*/;
    }
  }

  public bool UpdateQueued
  {
    get => ((uint) this._extraData & 64U /*0x40*/) > 0U;
    set
    {
      if (value)
        this._extraData |= (byte) 64 /*0x40*/;
      else
        this._extraData &= (byte) 191;
    }
  }

  public byte Color
  {
    get => (byte) ((uint) this._extraData & 31U /*0x1F*/);
    set => this._extraData = (byte) ((int) this._extraData & -32 | (int) value & 31 /*0x1F*/);
  }

  private MapTile(ushort type, byte light, byte extraData)
  {
    this.Type = type;
    this.Light = light;
    this._extraData = extraData;
  }

  public bool Equals(MapTile other)
  {
    return (int) this.Light == (int) other.Light && (int) this.Type == (int) other.Type && (int) this.Color == (int) other.Color;
  }

  public bool EqualsWithoutLight(MapTile other)
  {
    return (int) this.Type == (int) other.Type && (int) this.Color == (int) other.Color;
  }

  public void Clear()
  {
    this.Type = (ushort) 0;
    this.Light = (byte) 0;
    this._extraData = (byte) 0;
  }

  public MapTile WithLight(byte light)
  {
    return new MapTile(this.Type, light, (byte) ((uint) this._extraData | 128U /*0x80*/));
  }

  public static MapTile Create(ushort type, byte light, byte color)
  {
    return new MapTile(type, light, (byte) ((uint) color | 128U /*0x80*/));
  }
}
