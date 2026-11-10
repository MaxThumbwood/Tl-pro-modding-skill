// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.SortingSteps
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Creative;

public static class SortingSteps
{
  public abstract class ACreativeItemSortStep : 
    ICreativeItemSortStep,
    IEntrySortStep<Item>,
    IComparer<Item>
  {
    public abstract string GetDisplayNameKey();

    public abstract int Compare(Item x, Item y);
  }

  public abstract class AStepByFittingFilter : SortingSteps.ACreativeItemSortStep
  {
    public override int Compare(Item x, Item y)
    {
      int num = this.FitsFilter(x).CompareTo(this.FitsFilter(y));
      if (num == 0)
        num = 1;
      return num;
    }

    public abstract bool FitsFilter(Item item);

    public virtual int CompareWhenBothFit(Item x, Item y)
    {
      return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
  }

  public class Blocks : SortingSteps.AStepByFittingFilter
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_Blocks";

    public override bool FitsFilter(Item item)
    {
      return item.createTile >= 0 && !Main.tileFrameImportant[item.createTile];
    }
  }

  public class Walls : SortingSteps.AStepByFittingFilter
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_Walls";

    public override bool FitsFilter(Item item) => item.createWall >= 0;
  }

  public class PlacableObjects : SortingSteps.AStepByFittingFilter
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_PlacableObjects";

    public override bool FitsFilter(Item item)
    {
      return item.createTile >= 0 && Main.tileFrameImportant[item.createTile];
    }
  }

  public class ByUnlockStatus : SortingSteps.ACreativeItemSortStep
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_UnlockedFirst";

    public override int Compare(Item x, Item y)
    {
      ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
      bool flag1 = itemSacrifices.IsNewlyResearched(x.type);
      bool flag2 = itemSacrifices.IsNewlyResearched(y.type);
      if (flag1 != flag2)
        return !flag1 ? 1 : -1;
      bool flag3 = itemSacrifices.IsFullyResearched(x.type);
      bool flag4 = itemSacrifices.IsFullyResearched(y.type);
      if (flag3 == flag4)
        return 0;
      return !flag3 ? 1 : -1;
    }
  }

  public class ByCreativeSortingId : SortingSteps.ACreativeItemSortStep
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_SortingID";

    public override int Compare(Item x, Item y)
    {
      ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup groupAndOrderInGroup1 = ContentSamples.ItemCreativeSortingId[x.type];
      ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup groupAndOrderInGroup2 = ContentSamples.ItemCreativeSortingId[y.type];
      int num = groupAndOrderInGroup1.Group.CompareTo((object) groupAndOrderInGroup2.Group);
      if (num == 0)
        num = groupAndOrderInGroup1.OrderInGroup.CompareTo(groupAndOrderInGroup2.OrderInGroup);
      return num;
    }
  }

  public class Alphabetical : SortingSteps.ACreativeItemSortStep
  {
    public override string GetDisplayNameKey() => "CreativePowers.Sort_Alphabetical";

    public override int Compare(Item x, Item y) => x.Name.CompareTo(y.Name);
  }
}
