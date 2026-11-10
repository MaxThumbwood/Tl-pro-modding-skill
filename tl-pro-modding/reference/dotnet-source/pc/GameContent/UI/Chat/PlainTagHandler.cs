// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Chat.PlainTagHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Chat;

public class PlainTagHandler : ITagHandler
{
  TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
  {
    return (TextSnippet) new PlainTagHandler.PlainSnippet(text);
  }

  public class PlainSnippet : TextSnippet
  {
    public PlainSnippet(string text = "")
      : base(text)
    {
    }

    public PlainSnippet(string text, Color color)
      : base(text, color)
    {
    }

    public override Color GetVisibleColor() => this.Color;
  }
}
