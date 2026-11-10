// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UISortableElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UISortableElement : UIElement
{
  public int OrderIndex;

  public UISortableElement(int index) => this.OrderIndex = index;

  public override int CompareTo(object obj)
  {
    return obj is UISortableElement uiSortableElement ? this.OrderIndex.CompareTo(uiSortableElement.OrderIndex) : base.CompareTo(obj);
  }
}
