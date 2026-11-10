// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.TextSnippet
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.UI.Chat;

public class TextSnippet
{
  public string Text;
  public string TextOriginal;
  public Color Color = Color.White;
  public bool CheckForHover;
  public bool DeleteWhole;

  public TextSnippet(string text = "")
  {
    this.Text = text;
    this.TextOriginal = text;
  }

  public TextSnippet(string text, Color color)
  {
    this.Text = text;
    this.TextOriginal = text;
    this.Color = color;
  }

  public virtual void OnHover()
  {
  }

  public virtual void OnClick()
  {
  }

  public virtual Color GetVisibleColor() => ChatManager.WaveColor(this.Color);

  public virtual bool UniqueDraw(
    bool justCheckingSize,
    out Vector2 size,
    SpriteBatch spriteBatch,
    Vector2 position = default (Vector2),
    Color color = default (Color),
    float scale = 1f)
  {
    size = Vector2.Zero;
    return false;
  }

  public virtual TextSnippet CopyMorph(string newText)
  {
    TextSnippet textSnippet = (TextSnippet) this.MemberwiseClone();
    textSnippet.Text = newText;
    return textSnippet;
  }

  public override string ToString() => $"Text: {this.Text} | OriginalText: {this.TextOriginal}";
}
