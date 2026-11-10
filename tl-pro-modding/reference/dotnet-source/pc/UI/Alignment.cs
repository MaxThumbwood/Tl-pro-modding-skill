// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Alignment
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI;

public struct Alignment
{
  public static readonly Alignment TopLeft = new Alignment(0.0f, 0.0f);
  public static readonly Alignment Top = new Alignment(0.5f, 0.0f);
  public static readonly Alignment TopRight = new Alignment(1f, 0.0f);
  public static readonly Alignment Left = new Alignment(0.0f, 0.5f);
  public static readonly Alignment Center = new Alignment(0.5f, 0.5f);
  public static readonly Alignment Right = new Alignment(1f, 0.5f);
  public static readonly Alignment BottomLeft = new Alignment(0.0f, 1f);
  public static readonly Alignment Bottom = new Alignment(0.5f, 1f);
  public static readonly Alignment BottomRight = new Alignment(1f, 1f);
  public readonly float VerticalOffsetMultiplier;
  public readonly float HorizontalOffsetMultiplier;

  public Vector2 OffsetMultiplier
  {
    get => new Vector2(this.HorizontalOffsetMultiplier, this.VerticalOffsetMultiplier);
  }

  private Alignment(float horizontal, float vertical)
  {
    this.HorizontalOffsetMultiplier = horizontal;
    this.VerticalOffsetMultiplier = vertical;
  }
}
