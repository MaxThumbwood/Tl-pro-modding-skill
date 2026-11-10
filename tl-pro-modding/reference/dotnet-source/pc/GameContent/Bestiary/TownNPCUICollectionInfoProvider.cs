// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.TownNPCUICollectionInfoProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class TownNPCUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
  private string _persistentIdentifierToCheck;

  public TownNPCUICollectionInfoProvider(string persistentId)
  {
    this._persistentIdentifierToCheck = persistentId;
  }

  public BestiaryUICollectionInfo GetEntryUICollectionInfo()
  {
    return new BestiaryUICollectionInfo()
    {
      UnlockState = Main.BestiaryTracker.Chats.GetWasChatWith(this._persistentIdentifierToCheck) ? BestiaryEntryUnlockState.CanShowDropsWithDropRates_4 : BestiaryEntryUnlockState.NotKnownAtAll_0
    };
  }

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;
}
