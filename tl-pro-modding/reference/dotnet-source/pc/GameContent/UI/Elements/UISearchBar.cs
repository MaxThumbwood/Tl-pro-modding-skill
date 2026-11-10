// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UISearchBar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UISearchBar : UIElement
{
  private readonly LocalizedText _textToShowWhenEmpty;
  private UITextBox _text;
  private string actualContents;
  private float _textScale;
  private int _maxInputLength;

  public event Action<string> OnContentsChanged;

  public event Action OnStartTakingInput;

  public event Action OnEndTakingInput;

  public event Action OnNeedingVirtualKeyboard;

  public bool HasContents => !string.IsNullOrWhiteSpace(this.actualContents);

  public bool IsWritingText { get; private set; }

  public int MaxInputLength
  {
    get => this._maxInputLength;
    set
    {
      this._maxInputLength = value;
      this._text.SetTextMaxLength(this._maxInputLength);
    }
  }

  public UISearchBar(LocalizedText emptyContentText, float scale)
  {
    this._textToShowWhenEmpty = emptyContentText;
    this._textScale = scale;
    UITextBox uiTextBox = new UITextBox("", scale);
    uiTextBox.HAlign = 0.0f;
    uiTextBox.VAlign = 0.5f;
    uiTextBox.BackgroundColor = Color.Transparent;
    uiTextBox.BorderColor = Color.Transparent;
    uiTextBox.Width = new StyleDimension(0.0f, 1f);
    uiTextBox.Height = new StyleDimension(0.0f, 1f);
    uiTextBox.TextHAlign = 0.0f;
    uiTextBox.ShowInputTicker = false;
    this._text = uiTextBox;
    this.MaxInputLength = 50;
    this.Append((UIElement) this._text);
  }

  public void SetContents(string contents, bool forced = false)
  {
    if (this.actualContents == contents && !forced)
      return;
    this.actualContents = contents;
    if (string.IsNullOrEmpty(this.actualContents))
    {
      this._text.TextColor = Color.Gray;
      this._text.SetText(this._textToShowWhenEmpty.Value, this._textScale, false);
    }
    else
    {
      this._text.TextColor = Color.White;
      this._text.SetText(this.actualContents);
      this.actualContents = this._text.Text;
    }
    this.TrimDisplayIfOverElementDimensions(0);
    if (this.OnContentsChanged == null)
      return;
    this.OnContentsChanged(contents);
  }

  public void TrimDisplayIfOverElementDimensions(int padding)
  {
    CalculatedStyle dimensions1 = this.GetDimensions();
    if ((double) dimensions1.Width == 0.0 && (double) dimensions1.Height == 0.0)
      return;
    Point point1 = new Point((int) dimensions1.X, (int) dimensions1.Y);
    Point point2 = new Point(point1.X + (int) dimensions1.Width, point1.Y + (int) dimensions1.Height);
    Rectangle rectangle1 = new Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
    CalculatedStyle dimensions2 = this._text.GetDimensions();
    Point point3 = new Point((int) dimensions2.X, (int) dimensions2.Y);
    Point point4 = new Point(point3.X + (int) this._text.MinWidth.Pixels, point3.Y + (int) this._text.MinHeight.Pixels);
    Rectangle rectangle2 = new Rectangle(point3.X, point3.Y, point4.X - point3.X, point4.Y - point3.Y);
    while (rectangle2.Right > rectangle1.Right - padding && this._text.Text.Length > 0)
    {
      this._text.SetText(Utils.TrimLastCharacter(this._text.Text));
      this.RecalculateChildren();
      CalculatedStyle dimensions3 = this._text.GetDimensions();
      point3 = new Point((int) dimensions3.X, (int) dimensions3.Y);
      point4 = new Point(point3.X + (int) this._text.MinWidth.Pixels, point3.Y + (int) this._text.MinHeight.Pixels);
      rectangle2 = new Rectangle(point3.X, point3.Y, point4.X - point3.X, point4.Y - point3.Y);
      this.actualContents = this._text.Text;
    }
  }

  public override void MouseOver(UIMouseEvent evt)
  {
    base.MouseOver(evt);
    SoundEngine.PlaySound(12);
  }

  public override void Update(GameTime gameTime)
  {
    if (this.IsWritingText)
    {
      if (this.NeedsVirtualkeyboard())
      {
        if (this.OnNeedingVirtualKeyboard == null)
          return;
        this.OnNeedingVirtualKeyboard();
        return;
      }
      PlayerInput.WritingText = true;
      Main.CurrentInputTextTakerOverride = (object) this;
    }
    base.Update(gameTime);
  }

  private bool NeedsVirtualkeyboard() => PlayerInput.SettingsForUI.ShowGamepadHints;

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    base.DrawSelf(spriteBatch);
    if (!this.IsWritingText)
      return;
    PlayerInput.WritingText = true;
    Main.instance.HandleIME();
    Rectangle rectangle = this._text.GetDimensions().ToRectangle();
    Vector2 position = new Vector2((float) rectangle.Left, (float) (rectangle.Bottom + 32 /*0x20*/));
    Main.instance.SetIMEPanelAnchor(position, 0.0f);
    string inputText = Main.GetInputText(this.actualContents);
    if (Main.inputTextEnter)
      this.ToggleTakingText();
    else if (Main.inputTextEscape)
    {
      Main.inputTextEscape = false;
      this.ToggleTakingText();
    }
    this.SetContents(inputText);
  }

  public void ToggleTakingText()
  {
    this.IsWritingText = !this.IsWritingText;
    this._text.ShowInputTicker = this.IsWritingText;
    Main.clrInput();
    if (this.IsWritingText)
    {
      if (this.OnStartTakingInput == null)
        return;
      this.OnStartTakingInput();
    }
    else
    {
      if (this.OnEndTakingInput != null)
        this.OnEndTakingInput();
      PlayerInput.WritingText = false;
      Main.instance.HandleIME();
    }
  }

  public override void OnDeactivate()
  {
    if (!this.IsWritingText)
      return;
    this.ToggleTakingText();
  }
}
