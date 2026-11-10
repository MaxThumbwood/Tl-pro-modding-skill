// Decompiled with JetBrains decompiler
// Type: Terraria.UI.CalculatedStyle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI;

public struct CalculatedStyle(float x, float y, float width, float height)
{
  public float X = x;
  public float Y = y;
  public float Width = width;
  public float Height = height;

  public Rectangle ToRectangle()
  {
    return new Rectangle((int) this.X, (int) this.Y, (int) this.Width, (int) this.Height);
  }

  public Vector2 Position() => new Vector2(this.X, this.Y);

  public Vector2 Center() => new Vector2(this.X + this.Width * 0.5f, this.Y + this.Height * 0.5f);
}
