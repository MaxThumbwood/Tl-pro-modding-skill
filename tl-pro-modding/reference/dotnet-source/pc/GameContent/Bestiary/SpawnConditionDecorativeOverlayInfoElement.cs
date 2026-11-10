// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.SpawnConditionDecorativeOverlayInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class SpawnConditionDecorativeOverlayInfoElement : 
  IBestiaryInfoElement,
  IBestiaryBackgroundOverlayAndColorProvider
{
  private string _overlayImagePath;
  private Color? _overlayColor;

  public float DisplayPriority { get; set; }

  public SpawnConditionDecorativeOverlayInfoElement(string overlayImagePath = null, Color? overlayColor = null)
  {
    this._overlayImagePath = overlayImagePath;
    this._overlayColor = overlayColor;
  }

  public Asset<Texture2D> GetBackgroundOverlayImage()
  {
    return this._overlayImagePath == null ? (Asset<Texture2D>) null : Main.Assets.Request<Texture2D>(this._overlayImagePath, (AssetRequestMode) 1);
  }

  public Color? GetBackgroundOverlayColor() => this._overlayColor;

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;
}
