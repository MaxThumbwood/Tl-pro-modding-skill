// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.SalamanderShellyDadUICollectionInfoProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class SalamanderShellyDadUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
  private string _persistentIdentifierToCheck;
  private int _killCountNeededToFullyUnlock;

  public SalamanderShellyDadUICollectionInfoProvider(string persistentId)
  {
    this._persistentIdentifierToCheck = persistentId;
    this._killCountNeededToFullyUnlock = CommonEnemyUICollectionInfoProvider.GetKillCountNeeded(persistentId);
  }

  public BestiaryUICollectionInfo GetEntryUICollectionInfo()
  {
    BestiaryEntryUnlockState unlockstatus = CommonEnemyUICollectionInfoProvider.GetUnlockStateByKillCount(Main.BestiaryTracker.Kills.GetKillCount(this._persistentIdentifierToCheck), false, this._killCountNeededToFullyUnlock);
    if (!this.IsIncludedInCurrentWorld())
      unlockstatus = this.GetLowestAvailableUnlockStateFromEntriesThatAreInWorld(unlockstatus);
    return new BestiaryUICollectionInfo()
    {
      UnlockState = unlockstatus
    };
  }

  private BestiaryEntryUnlockState GetLowestAvailableUnlockStateFromEntriesThatAreInWorld(
    BestiaryEntryUnlockState unlockstatus)
  {
    BestiaryEntryUnlockState entryUnlockState = BestiaryEntryUnlockState.CanShowDropsWithDropRates_4;
    int[,] cavernMonsterType = NPC.cavernMonsterType;
    for (int index1 = 0; index1 < cavernMonsterType.GetLength(0); ++index1)
    {
      for (int index2 = 0; index2 < cavernMonsterType.GetLength(1); ++index2)
      {
        string creditIdsByNpcNetId = ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[cavernMonsterType[index1, index2]];
        BestiaryEntryUnlockState stateByKillCount = CommonEnemyUICollectionInfoProvider.GetUnlockStateByKillCount(Main.BestiaryTracker.Kills.GetKillCount(creditIdsByNpcNetId), false, this._killCountNeededToFullyUnlock);
        if (entryUnlockState > stateByKillCount)
          entryUnlockState = stateByKillCount;
      }
    }
    unlockstatus = entryUnlockState;
    return unlockstatus;
  }

  private bool IsIncludedInCurrentWorld()
  {
    int idsByPersistentId = ContentSamples.NpcNetIdsByPersistentIds[this._persistentIdentifierToCheck];
    int[,] cavernMonsterType = NPC.cavernMonsterType;
    for (int index1 = 0; index1 < cavernMonsterType.GetLength(0); ++index1)
    {
      for (int index2 = 0; index2 < cavernMonsterType.GetLength(1); ++index2)
      {
        if (ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[cavernMonsterType[index1, index2]] == this._persistentIdentifierToCheck)
          return true;
      }
    }
    return false;
  }

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;
}
