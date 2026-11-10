// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.ChatLine
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.UI.Chat;

public class ChatLine
{
  public Color color = Color.White;
  public int showTime;
  public string originalText = "";
  public TextSnippet[] parsedText = new TextSnippet[0];
  private int? parsingPixelLimit;
  private bool needsParsing;

  public void UpdateTimeLeft()
  {
    if (this.showTime > 0)
      --this.showTime;
    if (!this.needsParsing)
      return;
    this.needsParsing = false;
  }

  public void Copy(ChatLine other)
  {
    this.needsParsing = other.needsParsing;
    this.parsingPixelLimit = other.parsingPixelLimit;
    this.originalText = other.originalText;
    this.parsedText = other.parsedText;
    this.showTime = other.showTime;
    this.color = other.color;
  }

  public void FlagAsNeedsReprocessing() => this.needsParsing = true;
}
