// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement : 
  IPreferenceProviderElement,
  IBestiaryInfoElement
{
  private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCorrupt;
  private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCrimson;

  public BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement(
    IBestiaryBackgroundImagePathAndColorProvider preferredProviderCorrupt,
    IBestiaryBackgroundImagePathAndColorProvider preferredProviderCrimson)
  {
    this._preferredProviderCorrupt = preferredProviderCorrupt;
    this._preferredProviderCrimson = preferredProviderCrimson;
  }

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;

  public bool Matches(
    IBestiaryBackgroundImagePathAndColorProvider provider)
  {
    return Main.ActiveWorldFileData == null || !WorldGen.crimson ? provider == this._preferredProviderCorrupt : provider == this._preferredProviderCrimson;
  }

  public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
  {
    return Main.ActiveWorldFileData == null || !WorldGen.crimson ? this._preferredProviderCorrupt : this._preferredProviderCrimson;
  }
}
