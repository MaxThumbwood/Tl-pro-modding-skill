// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.PositionedSnippet
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI.Chat;

public struct PositionedSnippet(
  TextSnippet snippet,
  int origIndex,
  int line,
  Vector2 position,
  Vector2 size)
{
  public readonly TextSnippet Snippet = snippet;
  public readonly int OrigIndex = origIndex;
  public readonly int Line = line;
  public Vector2 Position = position;
  public Vector2 Size = size;

  public void Scale(float scale)
  {
    this.Position *= scale;
    this.Size *= scale;
  }
}
