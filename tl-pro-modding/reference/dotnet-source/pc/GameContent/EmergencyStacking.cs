// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.EmergencyStacking
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent;

public static class EmergencyStacking
{
  public static readonly List<EmergencyStacking.Group> PreservationOrder = new List<EmergencyStacking.Group>()
  {
    EmergencyStacking.Group.RareCurrency,
    EmergencyStacking.Group.Equipment,
    EmergencyStacking.Group.SilverCoins,
    EmergencyStacking.Group.CopperCoins,
    EmergencyStacking.Group.FallenStars,
    EmergencyStacking.Group.Default
  };
  private static readonly Point PlayerViewRectSize = new Point(2320, 1600);
  private static readonly int ItemsToStackEachTime = 20;
  private static readonly int MaxTransferDistance = 2400;
  private static readonly int OnScreenDistancePriorityPenalty = 3;
  private static EmergencyStacking.Group[] _groupLookup;
  private static readonly List<EmergencyStacking.Transfer> PendingTransfers = new List<EmergencyStacking.Transfer>(EmergencyStacking.ItemsToStackEachTime);
  private static readonly bool[] HasPendingTransfer = new bool[401];
  private static readonly EmergencyStacking.StackableItem[] stackableItemsScratch = new EmergencyStacking.StackableItem[400];
  private static readonly List<Rectangle> playerViewRectsScratch = new List<Rectangle>((int) byte.MaxValue);

  private static EmergencyStacking.Group[] GroupLookup
  {
    get
    {
      if (EmergencyStacking._groupLookup != null)
        return EmergencyStacking._groupLookup;
      int count = EmergencyStacking.PreservationOrder.Count;
      foreach (EmergencyStacking.Group group in EmergencyStacking.PreservationOrder)
        group.StackingPriority = count--;
      EmergencyStacking._groupLookup = Enumerable.Range(0, (int) ItemID.Count).Select<int, EmergencyStacking.Group>((Func<int, EmergencyStacking.Group>) (t => EmergencyStacking.PreservationOrder.First<EmergencyStacking.Group>((Func<EmergencyStacking.Group, bool>) (g => g.Contains(ContentSamples.ItemsByType[t]))))).ToArray<EmergencyStacking.Group>();
      return EmergencyStacking._groupLookup;
    }
  }

  public static bool HasPendingTransferInvolving(WorldItem item)
  {
    return EmergencyStacking.HasPendingTransfer[item.whoAmI];
  }

  public static void ClearPendingTransfersInvolving(WorldItem item)
  {
    if (!EmergencyStacking.HasPendingTransferInvolving(item))
      return;
    EmergencyStacking.HasPendingTransfer[item.whoAmI] = false;
    EmergencyStacking.PendingTransfers.RemoveAll((Predicate<EmergencyStacking.Transfer>) (t => t.src == item || t.dst == item));
  }

  public static bool EmergencyStackItemsToMakeSpace(out int freeSlot)
  {
    int limit = Math.Max(EmergencyStacking.ItemsToStackEachTime, EmergencyStacking.PendingTransfers.Count + 1);
    EmergencyStacking.PendingTransfers.Clear();
    EmergencyStacking.FindBestTransfers(EmergencyStacking.MemoStackableItems(), EmergencyStacking.PendingTransfers, limit);
    EmergencyStacking.ProcessPendingTransfers(out freeSlot);
    EmergencyStacking.RequestOwnershipReleaseForPendingTransfers();
    return freeSlot < 400;
  }

  public static void ProcessPendingTransfers()
  {
    if (EmergencyStacking.PendingTransfers.Count == 0)
      return;
    EmergencyStacking.ProcessPendingTransfers(out int _);
  }

  private static void ProcessPendingTransfers(out int freeSlot)
  {
    freeSlot = 400;
    for (int index = 0; index < EmergencyStacking.PendingTransfers.Count; ++index)
    {
      EmergencyStacking.UpdateDestinationFromPreviousTransfers(EmergencyStacking.PendingTransfers, index);
      EmergencyStacking.Transfer pendingTransfer = EmergencyStacking.PendingTransfers[index];
      EmergencyStacking.DoTransfer(pendingTransfer);
      if (pendingTransfer.src.IsAir)
        freeSlot = Math.Min(freeSlot, pendingTransfer.src.whoAmI);
    }
    if (Main.netMode != 2)
    {
      EmergencyStacking.PendingTransfers.Clear();
    }
    else
    {
      Array.Clear((Array) EmergencyStacking.HasPendingTransfer, 0, EmergencyStacking.HasPendingTransfer.Length);
      EmergencyStacking.PendingTransfers.RemoveAll((Predicate<EmergencyStacking.Transfer>) (t => t.NumToTransfer == 0));
      foreach (EmergencyStacking.Transfer pendingTransfer in EmergencyStacking.PendingTransfers)
      {
        EmergencyStacking.HasPendingTransfer[pendingTransfer.src.whoAmI] = true;
        EmergencyStacking.HasPendingTransfer[pendingTransfer.dst.whoAmI] = true;
      }
    }
  }

  private static void UpdateDestinationFromPreviousTransfers(
    List<EmergencyStacking.Transfer> transfers,
    int i)
  {
    EmergencyStacking.Transfer transfer = transfers[i];
    WorldItem dst = transfer.dst;
    for (int index = i - 1; dst.IsAir && index >= 0; --index)
    {
      if (transfers[index].src == dst)
        dst = transfers[index].dst;
    }
    if (dst == transfer.dst)
      return;
    transfer.dst = dst;
    transfers[i] = transfer;
  }

  private static EmergencyStacking.StackableItem[] MemoStackableItems()
  {
    List<Rectangle> playerViewRects = EmergencyStacking.GetPlayerViewRects();
    EmergencyStacking.StackableItem[] stackableItemsScratch = EmergencyStacking.stackableItemsScratch;
    Array.Clear((Array) stackableItemsScratch, 0, stackableItemsScratch.Length);
    for (int index = 0; index < 400; ++index)
    {
      WorldItem worldItem = Main.item[index];
      if ((worldItem.IsAir || worldItem.stack >= worldItem.maxStack || worldItem.instanced || (double) worldItem.shimmerTime != 0.0 ? 0 : (Main.timeItemSlotCannotBeReusedFor[index] == 0 ? 1 : 0)) != 0)
        stackableItemsScratch[index] = new EmergencyStacking.StackableItem()
        {
          type = worldItem.type,
          age = worldItem.timeSinceItemSpawned,
          isOnScreen = EmergencyStacking.AnyContains(playerViewRects, worldItem.Center.ToPoint()),
          item = worldItem
        };
    }
    return stackableItemsScratch;
  }

  private static List<Rectangle> GetPlayerViewRects()
  {
    List<Rectangle> viewRectsScratch = EmergencyStacking.playerViewRectsScratch;
    viewRectsScratch.Clear();
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      Player player = Main.player[index];
      if (player.active)
        viewRectsScratch.Add(Utils.CenteredRectangle(player.Center.ToPoint(), EmergencyStacking.PlayerViewRectSize));
    }
    return viewRectsScratch;
  }

  private static void FindBestTransfers(
    EmergencyStacking.StackableItem[] stackableItems,
    List<EmergencyStacking.Transfer> transfers,
    int limit)
  {
    foreach (EmergencyStacking.StackableItem stackableItem1 in stackableItems)
    {
      if (stackableItem1.type != 0)
      {
        EmergencyStacking.Transfer transfer1 = new EmergencyStacking.Transfer();
        transfer1.distanceOrder = int.MaxValue;
        EmergencyStacking.Transfer other = transfer1;
        foreach (EmergencyStacking.StackableItem stackableItem2 in stackableItems)
        {
          if (stackableItem1.type == stackableItem2.type && stackableItem1.item != stackableItem2.item && !stackableItem1.IsPreferredDestination(stackableItem2) && Item.CanStack(stackableItem1.item.inner, stackableItem2.item.inner))
          {
            int num = EmergencyStacking.DistanceBetween(stackableItem1.item, stackableItem2.item);
            if (num <= EmergencyStacking.MaxTransferDistance)
            {
              EmergencyStacking.Group group = EmergencyStacking.GroupLookup[stackableItem1.type];
              transfer1 = new EmergencyStacking.Transfer();
              transfer1.src = stackableItem1.item;
              transfer1.dst = stackableItem2.item;
              transfer1.distanceOrder = num / group.DistanceStepSize;
              transfer1.preservationOrder = group.StackingPriority;
              transfer1.distance = num;
              EmergencyStacking.Transfer transfer2 = transfer1;
              if (stackableItem1.isOnScreen)
                transfer2.distanceOrder += EmergencyStacking.OnScreenDistancePriorityPenalty;
              if (transfer2.CompareTo(other) < 0)
                other = transfer2;
            }
          }
        }
        if (other.src != null)
          EmergencyStacking.AddToOrderedList(transfers, limit, other);
      }
    }
  }

  private static void DoTransfer(EmergencyStacking.Transfer t)
  {
    WorldItem src = t.src;
    WorldItem dst = t.dst;
    if (!t.HasOwnership)
      return;
    int numToTransfer = t.NumToTransfer;
    if (numToTransfer == 0)
      return;
    src.stack -= numToTransfer;
    dst.stack += numToTransfer;
    if (src.stack <= 0)
      src.TurnToAir();
    if (dst.stack == dst.maxStack)
      EmergencyStacking.OnReachingMaxStack(dst);
    if (Main.netMode == 0)
      return;
    NetMessage.SendData(21, number: dst.whoAmI);
    NetMessage.SendData(21, number: src.whoAmI);
  }

  private static void RequestOwnershipReleaseForPendingTransfers()
  {
    if (EmergencyStacking.PendingTransfers.Count == 0)
      return;
    for (int index = 0; index < 400; ++index)
    {
      if (EmergencyStacking.HasPendingTransfer[index] && Main.item[index].playerIndexTheItemIsReservedFor != Main.myPlayer)
        Main.item[index].FindOwner();
    }
  }

  private static void AddToOrderedList(
    List<EmergencyStacking.Transfer> list,
    int limit,
    EmergencyStacking.Transfer item)
  {
    int index = 0;
    while (index < list.Count && item.CompareTo(list[index]) >= 0)
      ++index;
    if (index == limit)
      return;
    if (list.Count == limit)
      list.RemoveAt(list.Count - 1);
    list.Insert(index, item);
  }

  private static bool AnyContains(List<Rectangle> rects, Point point)
  {
    foreach (Rectangle rect in rects)
    {
      if (rect.Contains(point))
        return true;
    }
    return false;
  }

  private static int DistanceBetween(WorldItem a, WorldItem b)
  {
    Vector2 vector2 = a.position - b.position;
    return Math.Abs((int) vector2.X) + Math.Abs((int) vector2.Y);
  }

  private static void OnReachingMaxStack(WorldItem item)
  {
    switch (item.type)
    {
      case 71:
        item.SetDefaults(72);
        break;
      case 72:
        item.SetDefaults(73);
        break;
      case 73:
        item.SetDefaults(74);
        break;
    }
  }

  public class Group
  {
    public static readonly int DefaultStackDistanceStepSize = 160 /*0xA0*/;
    public int DistanceStepSize = EmergencyStacking.Group.DefaultStackDistanceStepSize;
    private List<Predicate<Item>> Conditions = new List<Predicate<Item>>();
    internal int StackingPriority;
    public static EmergencyStacking.Group FallenStars = new EmergencyStacking.Group(75)
    {
      DistanceStepSize = EmergencyStacking.Group.DefaultStackDistanceStepSize * 4
    };
    public static EmergencyStacking.Group CopperCoins = new EmergencyStacking.Group(71);
    public static EmergencyStacking.Group SilverCoins = new EmergencyStacking.Group(72);
    public static EmergencyStacking.Group Equipment = new EmergencyStacking.Group((Predicate<Item>) (item => item.OnlyNeedOneInInventory()));
    public static EmergencyStacking.Group RareCurrency = new EmergencyStacking.Group()
    {
      DistanceStepSize = (EmergencyStacking.Group.DefaultStackDistanceStepSize / 4)
    }.Add(73).Add(74).Add(3822);
    public static EmergencyStacking.Group Default = new EmergencyStacking.Group((Predicate<Item>) (item => true));

    public Group()
    {
    }

    public Group(int type) => this.Add(type);

    public Group(Predicate<Item> condition) => this.Add(condition);

    public EmergencyStacking.Group Add(Predicate<Item> condition)
    {
      this.Conditions.Add(condition);
      return this;
    }

    public EmergencyStacking.Group Add(int type)
    {
      return this.Add((Predicate<Item>) (item => item.type == type));
    }

    public bool Contains(Item item)
    {
      return this.Conditions.Any<Predicate<Item>>((Func<Predicate<Item>, bool>) (p => p(item)));
    }
  }

  private struct StackableItem
  {
    public int type;
    public int age;
    public bool isOnScreen;
    public WorldItem item;

    public bool IsPreferredDestination(EmergencyStacking.StackableItem other)
    {
      if (this.isOnScreen != other.isOnScreen)
        return this.isOnScreen;
      return this.age != other.age ? this.age < other.age : this.item.whoAmI < other.item.whoAmI;
    }
  }

  private struct Transfer : IComparable<EmergencyStacking.Transfer>
  {
    public WorldItem src;
    public WorldItem dst;
    public int distanceOrder;
    public int preservationOrder;
    public int distance;

    public int CompareTo(EmergencyStacking.Transfer other)
    {
      int num = 0;
      if (num == 0)
        num = this.distanceOrder.CompareTo(other.distanceOrder);
      if (num == 0)
        num = this.preservationOrder.CompareTo(other.preservationOrder);
      if (num == 0)
        num = this.distance.CompareTo(other.distance);
      return num;
    }

    public override string ToString()
    {
      return $"({this.distanceOrder},{this.preservationOrder},{this.distance}) {this.src} -> {this.dst}";
    }

    public bool HasOwnership
    {
      get
      {
        return this.src.playerIndexTheItemIsReservedFor == Main.myPlayer && this.dst.playerIndexTheItemIsReservedFor == Main.myPlayer;
      }
    }

    public int NumToTransfer
    {
      get
      {
        return !Item.CanStack(this.src.inner, this.dst.inner) ? 0 : Math.Min(this.src.stack, this.dst.maxStack - this.dst.stack);
      }
    }
  }
}
