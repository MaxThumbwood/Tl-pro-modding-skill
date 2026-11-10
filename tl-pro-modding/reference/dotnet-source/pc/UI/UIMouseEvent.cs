// Decompiled with JetBrains decompiler
// Type: Terraria.UI.UIMouseEvent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI;

public class UIMouseEvent : UIEvent
{
  public readonly Vector2 MousePosition;

  public UIMouseEvent(UIElement target, Vector2 mousePosition)
    : base(target)
  {
    this.MousePosition = mousePosition;
  }
}
