// Decompiled with JetBrains decompiler
// Type: Terraria.GetItemSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria;

public struct GetItemSettings(
  bool LongText = false,
  bool NoText = false,
  bool CanGoIntoVoidVault = false,
  bool NoSound = false,
  Action<Item> StepAfterHandlingSlotNormally = null,
  bool NoCoinMerge = false)
{
  public static GetItemSettings GiftRecieved = new GetItemSettings(true);
  public static GetItemSettings LootAllFromBank = new GetItemSettings();
  public static GetItemSettings LootAllFromChest = new GetItemSettings(CanGoIntoVoidVault: true);
  public static GetItemSettings PickupItemFromWorld = new GetItemSettings(CanGoIntoVoidVault: true);
  public static GetItemSettings QuickTransferFromSlot = new GetItemSettings(NoText: true);
  public static GetItemSettings ReturnItemFromSlot = new GetItemSettings(NoText: true);
  public static GetItemSettings ReturnItemShowAsNew = new GetItemSettings(NoText: true, StepAfterHandlingSlotNormally: new Action<Item>(GetItemSettings.MakeNewAndShiny));
  public static GetItemSettings ItemCreatedFromItemUsage = new GetItemSettings();
  public static GetItemSettings RefundConsumedItem = new GetItemSettings(NoText: true, CanGoIntoVoidVault: true, NoSound: true);
  public static GetItemSettings ReturnItemShowAsNewNoCoinMerge = new GetItemSettings(NoText: true, StepAfterHandlingSlotNormally: new Action<Item>(GetItemSettings.MakeNewAndShiny), NoCoinMerge: true);
  public readonly bool LongText = LongText;
  public readonly bool NoText = NoText;
  public readonly bool CanGoIntoVoidVault = CanGoIntoVoidVault;
  public readonly bool NoSound = NoSound;
  public readonly bool NoCoinMerge = NoCoinMerge;
  public readonly Action<Item> StepAfterHandlingSlotNormally = StepAfterHandlingSlotNormally;

  public void HandlePostAction(Item item)
  {
    if (this.StepAfterHandlingSlotNormally == null)
      return;
    this.StepAfterHandlingSlotNormally(item);
  }

  private static void MakeNewAndShiny(Item item) => item.newAndShiny = true;
}
