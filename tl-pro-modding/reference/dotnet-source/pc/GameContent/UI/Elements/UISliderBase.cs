// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UISliderBase
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UISliderBase : UIElement
{
  internal const int UsageLevel_NotSelected = 0;
  internal const int UsageLevel_SelectedAndLocked = 1;
  internal const int UsageLevel_OtherElementIsLocked = 2;
  public static UIElement CurrentLockedSlider;
  public static UIElement CurrentAimedSlider;

  internal int GetUsageLevel()
  {
    int usageLevel = 0;
    if (UISliderBase.CurrentLockedSlider == this)
      usageLevel = 1;
    else if (UISliderBase.CurrentLockedSlider != null)
      usageLevel = 2;
    return usageLevel;
  }

  public static void EscapeElements()
  {
    UISliderBase.CurrentLockedSlider = (UIElement) null;
    UISliderBase.CurrentAimedSlider = (UIElement) null;
  }
}
