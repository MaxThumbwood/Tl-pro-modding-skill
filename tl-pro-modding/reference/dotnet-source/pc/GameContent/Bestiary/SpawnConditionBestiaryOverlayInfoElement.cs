// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.SpawnConditionBestiaryOverlayInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class SpawnConditionBestiaryOverlayInfoElement : 
  FilterProviderInfoElement,
  IBestiaryBackgroundOverlayAndColorProvider,
  IBestiaryPrioritizedElement
{
  private string _overlayImagePath;
  private Color? _overlayColor;

  public float DisplayPriority { get; set; }

  public float OrderPriority { get; set; }

  public SpawnConditionBestiaryOverlayInfoElement(
    string nameLanguageKey,
    int filterIconFrame,
    string overlayImagePath = null,
    Color? overlayColor = null)
    : base(nameLanguageKey, filterIconFrame)
  {
    this._overlayImagePath = overlayImagePath;
    this._overlayColor = overlayColor;
  }

  public Asset<Texture2D> GetBackgroundOverlayImage()
  {
    return this._overlayImagePath == null ? (Asset<Texture2D>) null : Main.Assets.Request<Texture2D>(this._overlayImagePath, (AssetRequestMode) 1);
  }

  public Color? GetBackgroundOverlayColor() => this._overlayColor;
}
