// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.ChatMessageContainer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.GameContent;

#nullable disable
namespace Terraria.UI.Chat;

public class ChatMessageContainer
{
  public string OriginalText;
  private bool _prepared;
  private List<TextSnippet[]> _parsedText;
  private Color _color;
  private int _widthLimitInPixels;
  private int _timeLeft;

  public void SetContents(string text, Color color, int widthLimitInPixels)
  {
    this.OriginalText = text;
    this._color = color;
    this._widthLimitInPixels = widthLimitInPixels;
    this._parsedText = new List<TextSnippet[]>();
    this._timeLeft = 600;
    this.Refresh();
  }

  public void OnWidthLimitChanged()
  {
    if (this._widthLimitInPixels != -1)
      return;
    this._prepared = false;
  }

  public void Update()
  {
    if (this._timeLeft > 0)
      --this._timeLeft;
    this.Refresh();
  }

  public TextSnippet[] GetSnippetWithInversedIndex(int snippetIndex)
  {
    return this._parsedText[this._parsedText.Count - 1 - snippetIndex];
  }

  public int LineCount => this._parsedText.Count;

  public bool CanBeShownWhenChatIsClosed => this._timeLeft > 0;

  public bool Prepared => this._prepared;

  private void Refresh()
  {
    if (this._prepared)
      return;
    this._prepared = true;
    int maxWidth = this._widthLimitInPixels;
    if (maxWidth == -1)
      maxWidth = Main.ChatLineWidthLimit;
    List<List<TextSnippet>> textSnippetListList = Utils.WordwrapStringSmart(this.OriginalText, this._color, FontAssets.MouseText.Value, (float) maxWidth, 10);
    this._parsedText.Clear();
    for (int index = 0; index < textSnippetListList.Count; ++index)
      this._parsedText.Add(textSnippetListList[index].ToArray());
  }
}
