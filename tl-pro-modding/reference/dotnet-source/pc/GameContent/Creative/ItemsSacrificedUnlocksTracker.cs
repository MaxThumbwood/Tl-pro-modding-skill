// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.ItemsSacrificedUnlocksTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.IO;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Creative;

public class ItemsSacrificedUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
  public const int POSITIVE_SACRIFICE_COUNT_CAP = 9999;
  private Dictionary<string, int> _sacrificeCountByItemPersistentId;
  private Dictionary<int, int> _sacrificesCountByItemIdCache;
  private Dictionary<int, string> _unlockedByTeammate;
  private HashSet<int> _newlyUnlocked;
  public bool AnyNewUnlocksFromTeammates;

  public int LastEditId { get; private set; }

  public void DismissNewlyUnlockedFromTeamMatesIcon() => this.AnyNewUnlocksFromTeammates = false;

  public ItemsSacrificedUnlocksTracker()
  {
    this._sacrificeCountByItemPersistentId = new Dictionary<string, int>();
    this._sacrificesCountByItemIdCache = new Dictionary<int, int>();
    this._unlockedByTeammate = new Dictionary<int, string>();
    this._newlyUnlocked = new HashSet<int>();
    this.LastEditId = 0;
  }

  public int GetSacrificeCount(int itemId)
  {
    int num;
    if (ContentSamples.CreativeResearchItemPersistentIdOverride.TryGetValue(itemId, out num))
      itemId = num;
    int sacrificeCount;
    this._sacrificesCountByItemIdCache.TryGetValue(itemId, out sacrificeCount);
    return sacrificeCount;
  }

  public void ForEachItemWithResearchProgress(Action<int> action)
  {
    foreach (KeyValuePair<int, int> keyValuePair in this._sacrificesCountByItemIdCache)
    {
      if (keyValuePair.Value > 0)
        action(keyValuePair.Key);
    }
  }

  public void CountFullyResearchedItems(out int fullyResearchedItems, out int allItems)
  {
    fullyResearchedItems = 0;
    allItems = 0;
    for (int itemId = 0; itemId < (int) ItemID.Count; ++itemId)
    {
      int amountWeHave;
      int amountNeededTotal;
      if (this.TryGetSacrificeNumbers(itemId, out amountWeHave, out amountNeededTotal))
      {
        ++allItems;
        if (amountWeHave >= amountNeededTotal)
          ++fullyResearchedItems;
      }
    }
  }

  public bool TryGetSacrificeNumbers(int itemId, out int amountWeHave, out int amountNeededTotal)
  {
    int num;
    if (ContentSamples.CreativeResearchItemPersistentIdOverride.TryGetValue(itemId, out num))
      itemId = num;
    amountWeHave = amountNeededTotal = 0;
    if (!CreativeItemSacrificesCatalog.Instance.TryGetSacrificeCountCapToUnlockInfiniteItems(itemId, out amountNeededTotal))
      return false;
    this._sacrificesCountByItemIdCache.TryGetValue(itemId, out amountWeHave);
    return true;
  }

  public bool IsFullyResearched(int itemId)
  {
    int amountWeHave;
    int amountNeededTotal;
    return this.TryGetSacrificeNumbers(itemId, out amountWeHave, out amountNeededTotal) && amountWeHave >= amountNeededTotal;
  }

  public bool IsNewlyResearched(int itemId) => this._newlyUnlocked.Contains(itemId);

  public void ClearNewlyResearchedStatus(int itemId) => this._newlyUnlocked.Remove(itemId);

  public bool TryGetTeammateUnlockCredit(int itemId, out string teammateName)
  {
    return this._unlockedByTeammate.TryGetValue(itemId, out teammateName);
  }

  public void RegisterItemSacrifice(int itemId, int amount, string teammateName = null)
  {
    int num1;
    if (ContentSamples.CreativeResearchItemPersistentIdOverride.TryGetValue(itemId, out num1))
      itemId = num1;
    string key;
    int amountNeeded;
    if (!ContentSamples.ItemPersistentIdsByNetIds.TryGetValue(itemId, out key) || !CreativeItemSacrificesCatalog.Instance.TryGetSacrificeCountCapToUnlockInfiniteItems(itemId, out amountNeeded))
      return;
    int num2;
    this._sacrificeCountByItemPersistentId.TryGetValue(key, out num2);
    if (num2 >= amountNeeded)
      return;
    int num3 = Math.Min(num2 + amount, amountNeeded);
    this._sacrificeCountByItemPersistentId[key] = num3;
    this._sacrificesCountByItemIdCache[itemId] = num3;
    this.MarkContentsDirty();
    if (num3 < amountNeeded)
      return;
    this._newlyUnlocked.Add(itemId);
    if (teammateName == null)
      return;
    this.AnyNewUnlocksFromTeammates = true;
    this._unlockedByTeammate[itemId] = teammateName;
  }

  public void SetSacrificeCountDirectly(string persistentId, int sacrificeCount)
  {
    int num = Utils.Clamp<int>(sacrificeCount, 0, 9999);
    this._sacrificeCountByItemPersistentId[persistentId] = num;
    int key;
    if (!ContentSamples.ItemNetIdsByPersistentIds.TryGetValue(persistentId, out key))
      return;
    this._sacrificesCountByItemIdCache[key] = num;
    this.MarkContentsDirty();
  }

  public void Save(BinaryWriter writer)
  {
    writer.Write(false);
    Dictionary<string, int> dictionary = new Dictionary<string, int>((IDictionary<string, int>) this._sacrificeCountByItemPersistentId);
    writer.Write(dictionary.Count);
    foreach (KeyValuePair<string, int> keyValuePair in dictionary)
    {
      writer.Write(keyValuePair.Key);
      writer.Write(keyValuePair.Value);
    }
  }

  public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    if (gameVersionSaveWasMadeOn >= 282)
      reader.ReadBoolean();
    int num1 = reader.ReadInt32();
    for (int index = 0; index < num1; ++index)
    {
      string key1 = reader.ReadString();
      int num2 = reader.ReadInt32();
      int key2;
      if (ContentSamples.ItemNetIdsByPersistentIds.TryGetValue(key1, out key2))
      {
        int num3;
        if (ContentSamples.CreativeResearchItemPersistentIdOverride.TryGetValue(key2, out num3))
          key2 = num3;
        this._sacrificesCountByItemIdCache[key2] = num2;
        string str;
        if (ContentSamples.ItemPersistentIdsByNetIds.TryGetValue(key2, out str))
          key1 = str;
      }
      this._sacrificeCountByItemPersistentId[key1] = num2;
    }
  }

  public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
    {
      reader.ReadString();
      reader.ReadInt32();
    }
  }

  public void Reset()
  {
    this._sacrificeCountByItemPersistentId.Clear();
    this._sacrificesCountByItemIdCache.Clear();
    this.AnyNewUnlocksFromTeammates = false;
    this._unlockedByTeammate.Clear();
    this._newlyUnlocked.Clear();
    this.MarkContentsDirty();
  }

  public void OnPlayerJoining(int playerIndex)
  {
  }

  public void MarkContentsDirty() => ++this.LastEditId;
}
