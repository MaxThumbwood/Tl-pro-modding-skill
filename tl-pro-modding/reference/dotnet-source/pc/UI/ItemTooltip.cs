// Decompiled with JetBrains decompiler
// Type: Terraria.UI.ItemTooltip
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Localization;

#nullable disable
namespace Terraria.UI;

public class ItemTooltip
{
  public static readonly ItemTooltip None = new ItemTooltip();
  private static ulong _globalValidatorKey = 1;
  private static readonly ulong _neverUpdateHack = ulong.MaxValue;
  private string[] _tooltipLines;
  private ulong _validatorKey;
  private readonly LocalizedText _text;
  private string _processedText;

  public int Lines
  {
    get
    {
      this.ValidateTooltip();
      return this._tooltipLines == null ? 0 : this._tooltipLines.Length;
    }
  }

  private ItemTooltip()
  {
  }

  private ItemTooltip(string key) => this._text = Language.GetText(key);

  public static ItemTooltip FromLanguageKey(string key) => new ItemTooltip(key);

  public string GetLine(int line)
  {
    this.ValidateTooltip();
    return this._tooltipLines[line];
  }

  private ItemTooltip(string[] hardcodedLines)
  {
    this._validatorKey = ItemTooltip._neverUpdateHack;
    this._tooltipLines = hardcodedLines;
    this._processedText = string.Join("\n", hardcodedLines);
  }

  public static ItemTooltip FromHardcodedText(params string[] text) => new ItemTooltip(text);

  private void ValidateTooltip()
  {
    if ((long) this._validatorKey == (long) ItemTooltip._neverUpdateHack || (long) this._validatorKey == (long) ItemTooltip._globalValidatorKey)
      return;
    this._validatorKey = ItemTooltip._globalValidatorKey;
    if (this._text == null || !this._text.HasValue)
    {
      this._tooltipLines = (string[]) null;
      this._processedText = string.Empty;
    }
    else
    {
      string str = this._text.Value;
      this._tooltipLines = str.Split('\n');
      this._processedText = str;
    }
  }

  public static void InvalidateTooltips()
  {
    ++ItemTooltip._globalValidatorKey;
    if (ItemTooltip._globalValidatorKey != ulong.MaxValue)
      return;
    ItemTooltip._globalValidatorKey = 0UL;
  }
}
