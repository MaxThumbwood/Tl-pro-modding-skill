// Decompiled with JetBrains decompiler
// Type: Terraria.UI.UIScrollWheelEvent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI;

public class UIScrollWheelEvent : UIMouseEvent
{
  public readonly int ScrollWheelValue;

  public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
    : base(target, mousePosition)
  {
    this.ScrollWheelValue = scrollWheelValue;
  }
}
