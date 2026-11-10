// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIHeader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIHeader : UIElement
{
  private string _text;

  public string Text
  {
    get => this._text;
    set
    {
      if (!(this._text != value))
        return;
      this._text = value;
      if (!Main.dedServ)
      {
        Vector2 vector2 = FontAssets.DeathText.Value.MeasureString(this.Text);
        this.Width.Pixels = vector2.X;
        this.Height.Pixels = vector2.Y;
      }
      this.Width.Precent = 0.0f;
      this.Height.Precent = 0.0f;
      this.Recalculate();
    }
  }

  public UIHeader() => this.Text = "";

  public UIHeader(string text) => this.Text = text;

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    CalculatedStyle dimensions = this.GetDimensions();
    float num = 1.2f;
    DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X - num, dimensions.Y - num), Color.Black);
    DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X + num, dimensions.Y - num), Color.Black);
    DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X - num, dimensions.Y + num), Color.Black);
    DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X + num, dimensions.Y + num), Color.Black);
    if (WorldGen.tenthAnniversaryWorldGen && !Main.zenithWorld)
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X, dimensions.Y), Color.HotPink);
    else
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.DeathText.Value, this.Text, new Vector2(dimensions.X, dimensions.Y), Color.White);
  }
}
