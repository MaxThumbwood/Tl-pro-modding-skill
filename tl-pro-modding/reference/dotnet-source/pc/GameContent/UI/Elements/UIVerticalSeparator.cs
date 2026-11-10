// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIVerticalSeparator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIVerticalSeparator : UIElement
{
  private Asset<Texture2D> _texture;
  public Color Color;
  public int EdgeWidth;

  public UIVerticalSeparator()
  {
    this.Color = Color.White;
    this._texture = Main.Assets.Request<Texture2D>("Images/UI/OnePixel", (AssetRequestMode) 1);
    this.Width.Set((float) this._texture.Width(), 0.0f);
    this.Height.Set((float) this._texture.Height(), 0.0f);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    CalculatedStyle dimensions = this.GetDimensions();
    spriteBatch.Draw(this._texture.Value, dimensions.ToRectangle(), this.Color);
  }

  public override bool ContainsPoint(Vector2 point) => false;
}
