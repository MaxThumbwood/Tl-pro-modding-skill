// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.ITagHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI.Chat;

public interface ITagHandler
{
  TextSnippet Parse(string text, Color baseColor = default (Color), string options = null);
}
