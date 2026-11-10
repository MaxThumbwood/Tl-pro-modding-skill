// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.LootSimulationItemCounter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.LootSimulation;

public class LootSimulationItemCounter
{
  private long[] _itemCountsObtained = new long[(int) ItemID.Count];
  private long[] _itemCountsObtainedExpert = new long[(int) ItemID.Count];
  private long _totalTimesAttempted;
  private long _totalTimesAttemptedExpert;

  public void AddItem(int itemId, int amount, bool expert)
  {
    if (expert)
      this._itemCountsObtainedExpert[itemId] += (long) amount;
    else
      this._itemCountsObtained[itemId] += (long) amount;
  }

  public void Exclude(params int[] itemIds)
  {
    foreach (int itemId in itemIds)
    {
      this._itemCountsObtained[itemId] = 0L;
      this._itemCountsObtainedExpert[itemId] = 0L;
    }
  }

  public void IncreaseTimesAttempted(int amount, bool expert)
  {
    if (expert)
      this._totalTimesAttemptedExpert += (long) amount;
    else
      this._totalTimesAttempted += (long) amount;
  }

  public string PrintCollectedItems(bool expert)
  {
    long[] collectionToUse = this._itemCountsObtained;
    long totalDropsAttempted = this._totalTimesAttempted;
    if (expert)
    {
      collectionToUse = this._itemCountsObtainedExpert;
      this._totalTimesAttempted = this._totalTimesAttemptedExpert;
    }
    return string.Join(",\n", ((IEnumerable<long>) collectionToUse).Select((count, itemId) => new
    {
      itemId = itemId,
      count = count
    }).Where(entry => entry.count > 0L).Select(entry => entry.itemId).Select<int, string>((Func<int, string>) (itemId => $"new ItemDropInfo(ItemID.{ItemID.Search.GetName(itemId)}, {collectionToUse[itemId]}, {totalDropsAttempted})")));
  }
}
