// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.SpawnConditionBestiaryInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class SpawnConditionBestiaryInfoElement : 
  FilterProviderInfoElement,
  IBestiaryBackgroundImagePathAndColorProvider,
  IBestiaryPrioritizedElement
{
  private string _backgroundImagePath;
  private Color? _backgroundColor;

  public float OrderPriority { get; set; }

  public SpawnConditionBestiaryInfoElement(
    string nameLanguageKey,
    int filterIconFrame,
    string backgroundImagePath = null,
    Color? backgroundColor = null)
    : base(nameLanguageKey, filterIconFrame)
  {
    this._backgroundImagePath = backgroundImagePath;
    this._backgroundColor = backgroundColor;
  }

  public Asset<Texture2D> GetBackgroundImage()
  {
    return this._backgroundImagePath == null ? (Asset<Texture2D>) null : Main.Assets.Request<Texture2D>(this._backgroundImagePath, (AssetRequestMode) 1);
  }

  public Color? GetBackgroundColor() => this._backgroundColor;
}
