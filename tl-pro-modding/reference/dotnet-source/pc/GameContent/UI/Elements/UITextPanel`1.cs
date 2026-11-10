// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UITextPanel`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UITextPanel<T> : UIPanel
{
  protected T _text;
  protected float _textScale = 1f;
  protected Vector2 _textSize = Vector2.Zero;
  protected bool _isLarge;
  protected Color _color = Color.White;
  protected bool _drawPanel = true;
  public float TextHAlign = 0.5f;
  public bool HideContents;
  private string _asterisks;

  public bool IsLarge => this._isLarge;

  public bool DrawPanel
  {
    get => this._drawPanel;
    set => this._drawPanel = value;
  }

  public float TextScale
  {
    get => this._textScale;
    set => this._textScale = value;
  }

  public Vector2 TextSize => this._textSize;

  public string Text => (object) this._text != null ? this._text.ToString() : "";

  public Color TextColor
  {
    get => this._color;
    set => this._color = value;
  }

  protected DynamicSpriteFont Font
  {
    get => !this._isLarge ? FontAssets.MouseText.Value : FontAssets.DeathText.Value;
  }

  public UITextPanel(T text, float textScale = 1f, bool large = false)
  {
    this.SetText(text, textScale, large);
  }

  public override void Recalculate()
  {
    this.SetText(this._text, this._textScale, this._isLarge);
    base.Recalculate();
  }

  public void SetText(T text) => this.SetText(text, this._textScale, this._isLarge);

  public virtual void SetText(T text, float textScale, bool large)
  {
    this._text = text;
    this._textScale = textScale;
    this._isLarge = large;
    this._textSize = new Vector2(this.Font.MeasureString(text.ToString()).X, large ? 32f : 16f) * textScale;
    this.MinWidth.Set(this._textSize.X + this.PaddingLeft + this.PaddingRight, 0.0f);
    this.MinHeight.Set(this._textSize.Y + this.PaddingTop + this.PaddingBottom, 0.0f);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    if (this._drawPanel)
      base.DrawSelf(spriteBatch);
    this.DrawText(spriteBatch);
  }

  protected virtual Vector2 TextDrawPosition
  {
    get
    {
      CalculatedStyle innerDimensions = this.GetInnerDimensions();
      Vector2 textDrawPosition = innerDimensions.Position();
      textDrawPosition.X += (innerDimensions.Width - this._textSize.X) * this.TextHAlign;
      if (this._isLarge)
        textDrawPosition.Y -= 10f * this._textScale * this._textScale;
      else
        textDrawPosition.Y -= 2f * this._textScale;
      return textDrawPosition;
    }
  }

  protected void DrawText(SpriteBatch spriteBatch)
  {
    string text = this.Text;
    if (this.HideContents)
    {
      if (this._asterisks == null || this._asterisks.Length != text.Length)
        this._asterisks = new string('*', text.Length);
      text = this._asterisks;
    }
    this.DrawText(spriteBatch, text, this.TextDrawPosition, this._color);
  }

  protected void DrawText(SpriteBatch spriteBatch, string text, Vector2 position, Color color)
  {
    if (this._isLarge)
      Utils.DrawBorderStringBig(spriteBatch, text, position, color, this._textScale);
    else
      Utils.DrawBorderString(spriteBatch, text, position, color, this._textScale);
  }
}
