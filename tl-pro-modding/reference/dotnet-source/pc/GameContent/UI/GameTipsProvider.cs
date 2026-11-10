// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.GameTipsProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameInput;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent.UI;

public class GameTipsProvider : ITipProvider
{
  private LocalizedText[] _tipsDefault;
  private LocalizedText[] _tipsGamepad;
  private LocalizedText[] _tipsKeyboard;
  private LocalizedText _lastTip;

  public GameTipsProvider()
  {
    this._tipsDefault = Language.FindAll(Lang.CreateDialogFilter("LoadingTips_Default.", false));
    this._tipsGamepad = Language.FindAll(Lang.CreateDialogFilter("LoadingTips_GamePad.", false));
    this._tipsKeyboard = Language.FindAll(Lang.CreateDialogFilter("LoadingTips_Keyboard.", false));
    this._lastTip = (LocalizedText) null;
  }

  public LocalizedText RollAvailableTip()
  {
    List<LocalizedText> localizedTextList = new List<LocalizedText>();
    localizedTextList.AddRange((IEnumerable<LocalizedText>) this._tipsDefault);
    if (PlayerInput.UsingGamepad)
      localizedTextList.AddRange((IEnumerable<LocalizedText>) this._tipsGamepad);
    else
      localizedTextList.AddRange((IEnumerable<LocalizedText>) this._tipsKeyboard);
    do
    {
      localizedTextList.Remove(this._lastTip);
      this._lastTip = localizedTextList.Count != 0 ? localizedTextList[Main.rand.Next(localizedTextList.Count)] : LocalizedText.Empty;
    }
    while (!this._lastTip.ConditionsMet);
    return this._lastTip;
  }
}
