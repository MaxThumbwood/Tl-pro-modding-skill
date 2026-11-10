// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.TextDisplayCache
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameInput;

#nullable disable
namespace Terraria.GameContent.UI;

public class TextDisplayCache
{
  private string _originalText;
  private int _lastScreenWidth;
  private int _lastScreenHeight;
  private InputMode _lastInputMode;

  public string[] TextLines { get; private set; }

  public int AmountOfLines { get; private set; }

  public void PrepareCache(string text)
  {
    if ((0 | (Main.screenWidth != this._lastScreenWidth ? 1 : 0) | (Main.screenHeight != this._lastScreenHeight ? 1 : 0) | (this._originalText != text ? 1 : 0) | (PlayerInput.CurrentInputMode != this._lastInputMode ? 1 : 0)) == 0)
      return;
    this._lastScreenWidth = Main.screenWidth;
    this._lastScreenHeight = Main.screenHeight;
    this._originalText = text;
    this._lastInputMode = PlayerInput.CurrentInputMode;
    int lineAmount;
    this.TextLines = Utils.WordwrapString(text, FontAssets.MouseText.Value, 460, 10, out lineAmount);
    this.AmountOfLines = lineAmount;
  }
}
