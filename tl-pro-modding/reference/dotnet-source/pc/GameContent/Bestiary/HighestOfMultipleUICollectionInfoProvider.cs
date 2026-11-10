// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.HighestOfMultipleUICollectionInfoProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class HighestOfMultipleUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
  private IBestiaryUICollectionInfoProvider[] _providers;
  private int _mainProviderIndex;

  public HighestOfMultipleUICollectionInfoProvider(
    params IBestiaryUICollectionInfoProvider[] providers)
  {
    this._providers = providers;
    this._mainProviderIndex = 0;
  }

  public BestiaryUICollectionInfo GetEntryUICollectionInfo()
  {
    BestiaryUICollectionInfo uiCollectionInfo1 = this._providers[this._mainProviderIndex].GetEntryUICollectionInfo();
    BestiaryEntryUnlockState unlockState = uiCollectionInfo1.UnlockState;
    for (int index = 0; index < this._providers.Length; ++index)
    {
      BestiaryUICollectionInfo uiCollectionInfo2 = this._providers[index].GetEntryUICollectionInfo();
      if (unlockState < uiCollectionInfo2.UnlockState)
        unlockState = uiCollectionInfo2.UnlockState;
    }
    uiCollectionInfo1.UnlockState = unlockState;
    return uiCollectionInfo1;
  }

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;
}
