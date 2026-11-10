// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIText
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIText : UIElement
{
  private object _text = (object) "";
  private float _textScale = 1f;
  private Vector2 _textSize = Vector2.Zero;
  private bool _isLarge;
  private Color _color = Color.White;
  private Color _shadowColor = Color.Black;
  private bool _isWrapped;
  public bool DynamicallyScaleDownToWidth;
  private List<PositionedSnippet> _textLayout;
  private string _lastTextReference;

  public string Text => this._text.ToString();

  public float TextOriginX { get; set; }

  public float TextOriginY { get; set; }

  public float WrappedTextBottomPadding { get; set; }

  public bool IsWrapped
  {
    get => this._isWrapped;
    set
    {
      this._isWrapped = value;
      this.InternalSetText(this._text, this._textScale, this._isLarge);
    }
  }

  public event Action OnInternalTextChange;

  public Color TextColor
  {
    get => this._color;
    set => this._color = value;
  }

  public Color ShadowColor
  {
    get => this._shadowColor;
    set => this._shadowColor = value;
  }

  public UIText(string text, float textScale = 1f, bool large = false)
  {
    this.TextOriginX = 0.5f;
    this.TextOriginY = 0.0f;
    this.IsWrapped = false;
    this.WrappedTextBottomPadding = 20f;
    this.InternalSetText((object) text, textScale, large);
  }

  public UIText(LocalizedText text, float textScale = 1f, bool large = false)
  {
    this.TextOriginX = 0.5f;
    this.TextOriginY = 0.0f;
    this.IsWrapped = false;
    this.WrappedTextBottomPadding = 20f;
    this.InternalSetText((object) text, textScale, large);
  }

  public override void Recalculate()
  {
    this.InternalSetText(this._text, this._textScale, this._isLarge);
    base.Recalculate();
  }

  public void SetText(string text)
  {
    this.InternalSetText((object) text, this._textScale, this._isLarge);
  }

  public void SetText(LocalizedText text)
  {
    this.InternalSetText((object) text, this._textScale, this._isLarge);
  }

  public void SetText(string text, float textScale, bool large)
  {
    this.InternalSetText((object) text, textScale, large);
  }

  public void SetText(LocalizedText text, float textScale, bool large)
  {
    this.InternalSetText((object) text, textScale, large);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    base.DrawSelf(spriteBatch);
    this.VerifyTextState();
    CalculatedStyle innerDimensions = this.GetInnerDimensions();
    Vector2 position = innerDimensions.Position();
    if (this._isLarge)
      position.Y -= 10f * this._textScale;
    else
      position.Y -= 2f * this._textScale;
    List<PositionedSnippet> textLayout = this._textLayout;
    Vector2 scale1 = new Vector2(this._textScale);
    Vector2 textSize = this._textSize;
    if (this.DynamicallyScaleDownToWidth && (double) textSize.X > (double) innerDimensions.Width)
    {
      float scale2 = innerDimensions.Width / textSize.X;
      List<PositionedSnippet> positionedSnippetList = new List<PositionedSnippet>();
      for (int index = 0; index < positionedSnippetList.Count; ++index)
        positionedSnippetList[index].Scale(scale2);
      scale1 *= scale2;
      textSize *= scale2;
    }
    position.X += (innerDimensions.Width - textSize.X) * this.TextOriginX;
    position.Y += (innerDimensions.Height - textSize.Y) * this.TextOriginY;
    Color shadowColor = this._shadowColor * ((float) this._color.A / (float) byte.MaxValue);
    DynamicSpriteFont font = this._isLarge ? FontAssets.DeathText.Value : FontAssets.MouseText.Value;
    ChatManager.DrawColorCodedStringShadow(spriteBatch, font, this._textLayout, position, shadowColor, 0.0f, Vector2.Zero, scale1, 1.5f);
    ChatManager.DrawColorCodedString(spriteBatch, font, (IEnumerable<PositionedSnippet>) this._textLayout, position, 0.0f, Vector2.Zero, scale1, out int _);
  }

  private void VerifyTextState()
  {
    if ((object) this._lastTextReference == (object) this.Text)
      return;
    this.InternalSetText(this._text, this._textScale, this._isLarge);
  }

  private void InternalSetText(object text, float textScale, bool large)
  {
    this._text = text;
    this._isLarge = large;
    this._textScale = textScale;
    this._lastTextReference = this._text.ToString();
    List<TextSnippet> message = ChatManager.ParseMessage(this._lastTextReference, this._color);
    ChatManager.ConvertNormalSnippets(message);
    this._textLayout = ChatManager.LayoutSnippets(large ? FontAssets.DeathText.Value : FontAssets.MouseText.Value, (IEnumerable<TextSnippet>) message, new Vector2(this._textScale), this.IsWrapped ? this.GetInnerDimensions().Width : -1f).ToList<PositionedSnippet>();
    this._textSize = ChatManager.GetStringSize((IEnumerable<PositionedSnippet>) this._textLayout);
    if (this.IsWrapped)
      this._textSize.Y += this.WrappedTextBottomPadding * this._textScale;
    else
      this._textSize.Y = (large ? 32f : 16f) * this._textScale;
    this.MinWidth.Set(this.IsWrapped || this.DynamicallyScaleDownToWidth ? 0.0f : this._textSize.X + this.PaddingLeft + this.PaddingRight, 0.0f);
    this.MinHeight.Set(this._textSize.Y + this.PaddingTop + this.PaddingBottom, 0.0f);
    if (this.OnInternalTextChange == null)
      return;
    this.OnInternalTextChange();
  }
}
