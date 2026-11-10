// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.VertexColors
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics;

public struct VertexColors
{
  public Color TopLeftColor;
  public Color TopRightColor;
  public Color BottomLeftColor;
  public Color BottomRightColor;

  public VertexColors(Color color)
  {
    this.TopLeftColor = color;
    this.TopRightColor = color;
    this.BottomRightColor = color;
    this.BottomLeftColor = color;
  }

  public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
  {
    this.TopLeftColor = topLeft;
    this.TopRightColor = topRight;
    this.BottomLeftColor = bottomLeft;
    this.BottomRightColor = bottomRight;
  }

  public static implicit operator VertexColors(Color color) => new VertexColors(color);
}
