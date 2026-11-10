// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Chat.ColorTagHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Globalization;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Chat;

public class ColorTagHandler : ITagHandler
{
  TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
  {
    TextSnippet textSnippet = new TextSnippet(text);
    int result;
    if (!int.TryParse(options, NumberStyles.AllowHexSpecifier, (IFormatProvider) CultureInfo.InvariantCulture, out result))
      return textSnippet;
    textSnippet.Color = new Color(result >> 16 /*0x10*/ & (int) byte.MaxValue, result >> 8 & (int) byte.MaxValue, result & (int) byte.MaxValue);
    return textSnippet;
  }
}
