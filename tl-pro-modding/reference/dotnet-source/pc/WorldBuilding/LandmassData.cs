// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.LandmassData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public struct LandmassData
{
  public LandmassDataType DataType;
  public Vector2 Position;
  public int RadiusOrHalfSize;
  public int Style;

  public Vector2 Top
  {
    get => this.Position - new Vector2(0.0f, (float) this.RadiusOrHalfSize);
    set => this.Position = value + new Vector2(0.0f, (float) this.RadiusOrHalfSize);
  }
}
