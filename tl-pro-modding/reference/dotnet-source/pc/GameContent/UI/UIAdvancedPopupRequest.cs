// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.UIAdvancedPopupRequest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.UI;

public struct UIAdvancedPopupRequest
{
  public UIPopupTextContext Context;
  public UIPopupTextAlignment Alignment;
  public string Text;
  public Color Color;
  public int DurationInFrames;
  public Vector2 Position;
  public Vector2 Velocity;
}
