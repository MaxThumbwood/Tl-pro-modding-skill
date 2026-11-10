// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ContentRejectionFromSize
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Content;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class ContentRejectionFromSize : IRejectionReason
{
  private int _neededWidth;
  private int _neededHeight;
  private int _actualWidth;
  private int _actualHeight;

  public ContentRejectionFromSize(
    int neededWidth,
    int neededHeight,
    int actualWidth,
    int actualHeight)
  {
    this._neededWidth = neededWidth;
    this._neededHeight = neededHeight;
    this._actualWidth = actualWidth;
    this._actualHeight = actualHeight;
  }

  public string GetReason()
  {
    return Language.GetTextValueWith("AssetRejections.BadSize", (object) new
    {
      NeededWidth = this._neededWidth,
      NeededHeight = this._neededHeight,
      ActualWidth = this._actualWidth,
      ActualHeight = this._actualHeight
    });
  }
}
