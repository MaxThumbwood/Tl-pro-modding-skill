// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UITextBox
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Localization.IME;
using ReLogic.OS;
using System;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

internal class UITextBox(string text, float textScale = 1f, bool large = false) : UITextPanel<string>(text, textScale, large)
{
  private int _cursor;
  private int _frameCount;
  private int _maxLength = 20;
  public bool ShowInputTicker = true;
  public bool HideSelf;

  public void Write(string text)
  {
    this.SetText(this.Text.Insert(this._cursor, text));
    this._cursor += text.Length;
  }

  public override void SetText(string text, float textScale, bool large)
  {
    text = Utils.TrimUserString(text ?? "", this._maxLength);
    base.SetText(text, textScale, large);
    this._cursor = Math.Min(this.Text.Length, this._cursor);
  }

  public void SetTextMaxLength(int maxLength) => this._maxLength = maxLength;

  public void Backspace()
  {
    if (this._cursor == 0)
      return;
    this.SetText(Utils.TrimLastCharacter(this.Text));
  }

  public void CursorLeft()
  {
    if (this._cursor == 0)
      return;
    --this._cursor;
  }

  public void CursorRight()
  {
    if (this._cursor >= this.Text.Length)
      return;
    ++this._cursor;
  }

  protected override Vector2 TextDrawPosition
  {
    get
    {
      Vector2 textDrawPosition = base.TextDrawPosition;
      if (this.ShowInputTicker)
      {
        string compositionString = Platform.Get<IImeService>().CompositionString;
        if (!string.IsNullOrEmpty(compositionString))
          textDrawPosition.X -= this.Font.MeasureString(compositionString).X * this.TextScale * this.TextHAlign;
      }
      return textDrawPosition;
    }
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    if (this.HideSelf)
      return;
    this._cursor = this.Text.Length;
    base.DrawSelf(spriteBatch);
    if (!this.ShowInputTicker)
      return;
    Vector2 textDrawPosition = this.TextDrawPosition;
    string compositionString = Platform.Get<IImeService>().CompositionString;
    if (!string.IsNullOrEmpty(compositionString))
    {
      textDrawPosition.X += this.Font.MeasureString(compositionString).X * this.TextScale;
      this.DrawText(spriteBatch, compositionString, this.TextDrawPosition + new Vector2(this.TextSize.X, 0.0f), Main.imeCompositionStringColor);
    }
    ++this._frameCount;
    if ((this._frameCount %= 40) > 20)
      return;
    textDrawPosition.X += this.Font.MeasureString(this.Text.Substring(0, this._cursor)).X * this.TextScale;
    textDrawPosition.X += (float) (6.0 - (this.IsLarge ? 8.0 : 4.0) * (double) this.TextScale);
    if (this.IsLarge)
      textDrawPosition.Y += 2f * this.TextScale;
    this.DrawText(spriteBatch, "|", textDrawPosition, this.TextColor);
  }
}
