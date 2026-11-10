// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIImageFramed
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIImageFramed : UIElement, IColorable
{
  private Asset<Texture2D> _texture;
  private Rectangle _frame;

  public Color Color { get; set; }

  public UIImageFramed(Asset<Texture2D> texture, Rectangle frame)
  {
    this._texture = texture;
    this._frame = frame;
    this.Width.Set((float) this._frame.Width, 0.0f);
    this.Height.Set((float) this._frame.Height, 0.0f);
    this.Color = Color.White;
  }

  public void SetImage(Asset<Texture2D> texture, Rectangle frame)
  {
    this._texture = texture;
    this._frame = frame;
    this.Width.Set((float) this._frame.Width, 0.0f);
    this.Height.Set((float) this._frame.Height, 0.0f);
  }

  public void SetFrame(Rectangle frame)
  {
    this._frame = frame;
    this.Width.Set((float) this._frame.Width, 0.0f);
    this.Height.Set((float) this._frame.Height, 0.0f);
  }

  public void SetFrame(
    int frameCountHorizontal,
    int frameCountVertical,
    int frameX,
    int frameY,
    int sizeOffsetX,
    int sizeOffsetY)
  {
    this.SetFrame(this._texture.Frame(frameCountHorizontal, frameCountVertical, frameX, frameY).OffsetSize(sizeOffsetX, sizeOffsetY));
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    CalculatedStyle dimensions = this.GetDimensions();
    spriteBatch.Draw(this._texture.Value, dimensions.Position(), new Rectangle?(this._frame), this.Color);
  }
}
