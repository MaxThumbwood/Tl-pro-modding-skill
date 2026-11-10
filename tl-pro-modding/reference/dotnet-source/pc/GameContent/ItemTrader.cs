// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemTrader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent;

public class ItemTrader
{
  public static ItemTrader ChlorophyteExtractinator = ItemTrader.CreateChlorophyteExtractinator();
  private List<ItemTrader.TradeOption> _options = new List<ItemTrader.TradeOption>();

  public void AddOption_Interchangable(int itemType1, int itemType2)
  {
    this.AddOption_OneWay(itemType1, 1, itemType2, 1);
    this.AddOption_OneWay(itemType2, 1, itemType1, 1);
  }

  public void AddOption_CyclicLoop(params int[] typesInOrder)
  {
    for (int index = 0; index < typesInOrder.Length - 1; ++index)
      this.AddOption_OneWay(typesInOrder[index], 1, typesInOrder[index + 1], 1);
    this.AddOption_OneWay(typesInOrder[typesInOrder.Length - 1], 1, typesInOrder[0], 1);
  }

  public void AddOption_FromAny(int givingItemType, params int[] takingItemTypes)
  {
    for (int index = 0; index < takingItemTypes.Length; ++index)
      this.AddOption_OneWay(takingItemTypes[index], 1, givingItemType, 1);
  }

  public void AddOption_OneWay(
    int takingItemType,
    int takingItemStack,
    int givingItemType,
    int givingItemStack)
  {
    this._options.Add(new ItemTrader.TradeOption()
    {
      TakingItemType = takingItemType,
      TakingItemStack = takingItemStack,
      GivingItemType = givingItemType,
      GivingItemStack = givingItemStack
    });
  }

  public bool TryGetTradeOption(Item item, out ItemTrader.TradeOption option)
  {
    option = (ItemTrader.TradeOption) null;
    int type = item.type;
    int stack = item.stack;
    for (int index = 0; index < this._options.Count; ++index)
    {
      ItemTrader.TradeOption option1 = this._options[index];
      if (option1.WillTradeFor(type, stack))
      {
        option = option1;
        return true;
      }
    }
    return false;
  }

  public static ItemTrader CreateChlorophyteExtractinator()
  {
    ItemTrader chlorophyteExtractinator = new ItemTrader();
    chlorophyteExtractinator.AddOption_Interchangable(12, 699);
    chlorophyteExtractinator.AddOption_Interchangable(11, 700);
    chlorophyteExtractinator.AddOption_Interchangable(14, 701);
    chlorophyteExtractinator.AddOption_Interchangable(13, 702);
    chlorophyteExtractinator.AddOption_Interchangable(56, 880);
    chlorophyteExtractinator.AddOption_Interchangable(364, 1104);
    chlorophyteExtractinator.AddOption_Interchangable(365, 1105);
    chlorophyteExtractinator.AddOption_Interchangable(366, 1106);
    chlorophyteExtractinator.AddOption_CyclicLoop(134, 137, 139);
    chlorophyteExtractinator.AddOption_Interchangable(20, 703);
    chlorophyteExtractinator.AddOption_Interchangable(22, 704);
    chlorophyteExtractinator.AddOption_Interchangable(21, 705);
    chlorophyteExtractinator.AddOption_Interchangable(19, 706);
    chlorophyteExtractinator.AddOption_Interchangable(57, 1257);
    chlorophyteExtractinator.AddOption_Interchangable(381, 1184);
    chlorophyteExtractinator.AddOption_Interchangable(382, 1191);
    chlorophyteExtractinator.AddOption_Interchangable(391, 1198);
    chlorophyteExtractinator.AddOption_Interchangable(86, 1329);
    chlorophyteExtractinator.AddOption_FromAny(3, 61, 836, 409);
    chlorophyteExtractinator.AddOption_FromAny(169, 370, 1246, 408);
    chlorophyteExtractinator.AddOption_FromAny(664, 833, 835, 834);
    chlorophyteExtractinator.AddOption_FromAny(3271, 3276, 3277, 3339);
    chlorophyteExtractinator.AddOption_FromAny(3272, 3274, 3275, 3338);
    return chlorophyteExtractinator;
  }

  public class TradeOption
  {
    public int TakingItemType;
    public int TakingItemStack;
    public int GivingItemType;
    public int GivingItemStack;

    public bool WillTradeFor(int offeredItemType, int offeredItemStack)
    {
      return offeredItemType == this.TakingItemType && offeredItemStack >= this.TakingItemStack;
    }
  }
}
