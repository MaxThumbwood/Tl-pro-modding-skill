// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIImageButton
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIImageButton : UIElement
{
  private Asset<Texture2D> _texture;
  protected float _visibilityActive = 1f;
  protected float _visibilityInactive = 0.4f;
  private Asset<Texture2D> _borderTexture;
  private Rectangle? _frame;
  private Rectangle? _borderFrame;
  public Color Color = Color.White;
  public Color BorderColor = Color.White;

  public UIImageButton(Asset<Texture2D> texture, Rectangle? frame = null)
  {
    this._texture = texture;
    this._frame = frame;
    this.Width.Set(frame.HasValue ? (float) frame.Value.Width : (float) this._texture.Width(), 0.0f);
    this.Height.Set(frame.HasValue ? (float) frame.Value.Height : (float) this._texture.Height(), 0.0f);
  }

  public void SetHoverImage(Asset<Texture2D> texture, Rectangle? frame = null)
  {
    this._borderTexture = texture;
    this._borderFrame = frame;
  }

  public void SetImage(Asset<Texture2D> texture, Rectangle? frame = null)
  {
    this._texture = texture;
    this.Width.Set(this._frame.HasValue ? (float) this._frame.Value.Width : (float) this._texture.Width(), 0.0f);
    this.Height.Set(this._frame.HasValue ? (float) this._frame.Value.Height : (float) this._texture.Height(), 0.0f);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    CalculatedStyle dimensions = this.GetDimensions();
    spriteBatch.Draw(this._texture.Value, dimensions.Position(), this._frame, this.Color * (this.IsMouseHovering ? this._visibilityActive : this._visibilityInactive));
    if (this._borderTexture == null || !this.IsMouseHovering)
      return;
    spriteBatch.Draw(this._borderTexture.Value, dimensions.Position(), this._borderFrame, this.BorderColor);
  }

  public override void MouseOver(UIMouseEvent evt)
  {
    base.MouseOver(evt);
    SoundEngine.PlaySound(12);
  }

  public override void MouseOut(UIMouseEvent evt) => base.MouseOut(evt);

  public void SetVisibility(float whenActive, float whenInactive)
  {
    this._visibilityActive = MathHelper.Clamp(whenActive, 0.0f, 1f);
    this._visibilityInactive = MathHelper.Clamp(whenInactive, 0.0f, 1f);
  }
}
