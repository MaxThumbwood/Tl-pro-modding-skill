// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.RareSpawnBestiaryInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class RareSpawnBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
{
  public int RarityLevel { get; private set; }

  public RareSpawnBestiaryInfoElement(int rarityLevel) => this.RarityLevel = rarityLevel;

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;

  public string GetSearchString(ref BestiaryUICollectionInfo info)
  {
    return info.UnlockState == BestiaryEntryUnlockState.NotKnownAtAll_0 ? (string) null : Language.GetText("BestiaryInfo.IsRare").Value;
  }
}
