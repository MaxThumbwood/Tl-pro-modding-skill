// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.BestiaryPortraitBackgroundProviderPreferenceInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : 
  IPreferenceProviderElement,
  IBestiaryInfoElement
{
  private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;

  public BestiaryPortraitBackgroundProviderPreferenceInfoElement(
    IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
  {
    this._preferredProvider = preferredProvider;
  }

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;

  public bool Matches(
    IBestiaryBackgroundImagePathAndColorProvider provider)
  {
    return provider == this._preferredProvider;
  }

  public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
  {
    return this._preferredProvider;
  }
}
