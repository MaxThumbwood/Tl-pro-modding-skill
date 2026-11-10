// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.MoonLordPortraitBackgroundProviderBestiaryInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class MoonLordPortraitBackgroundProviderBestiaryInfoElement : 
  IBestiaryInfoElement,
  IBestiaryBackgroundImagePathAndColorProvider
{
  public Asset<Texture2D> GetBackgroundImage()
  {
    return Main.Assets.Request<Texture2D>("Images/MapBG1", (AssetRequestMode) 1);
  }

  public Color? GetBackgroundColor() => new Color?(Color.Black);

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;
}
