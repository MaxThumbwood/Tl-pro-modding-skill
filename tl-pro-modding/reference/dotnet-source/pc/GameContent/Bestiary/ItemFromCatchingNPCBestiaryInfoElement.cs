// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.ItemFromCatchingNPCBestiaryInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class ItemFromCatchingNPCBestiaryInfoElement : 
  IItemBestiaryInfoElement,
  IBestiaryInfoElement,
  IProvideSearchFilterString
{
  private int _itemType;

  public ItemFromCatchingNPCBestiaryInfoElement(int itemId) => this._itemType = itemId;

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
  {
    return info.UnlockState < BestiaryEntryUnlockState.CanShowDropsWithoutDropRates_3 ? (UIElement) null : (UIElement) new UIBestiaryInfoLine<string>("catch item #" + (object) this._itemType ?? "");
  }

  public string GetSearchString(ref BestiaryUICollectionInfo info)
  {
    return info.UnlockState < BestiaryEntryUnlockState.CanShowDropsWithoutDropRates_3 ? (string) null : ContentSamples.ItemsByType[this._itemType].Name;
  }
}
