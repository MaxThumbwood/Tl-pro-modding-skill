// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemShopSellbackHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent;

public class ItemShopSellbackHelper
{
  private List<ItemShopSellbackHelper.ItemMemo> _memos = new List<ItemShopSellbackHelper.ItemMemo>();

  public void Add(Item item)
  {
    ItemShopSellbackHelper.ItemMemo itemMemo = this._memos.Find((Predicate<ItemShopSellbackHelper.ItemMemo>) (x => x.Matches(item)));
    if (itemMemo != null)
      itemMemo.stack += item.stack;
    else
      this._memos.Add(new ItemShopSellbackHelper.ItemMemo(item));
  }

  public void Clear() => this._memos.Clear();

  public int GetAmount(Item item)
  {
    ItemShopSellbackHelper.ItemMemo itemMemo = this._memos.Find((Predicate<ItemShopSellbackHelper.ItemMemo>) (x => x.Matches(item)));
    return itemMemo != null ? itemMemo.stack : 0;
  }

  public int Remove(Item item)
  {
    ItemShopSellbackHelper.ItemMemo itemMemo = this._memos.Find((Predicate<ItemShopSellbackHelper.ItemMemo>) (x => x.Matches(item)));
    if (itemMemo == null)
      return 0;
    int stack = itemMemo.stack;
    itemMemo.stack -= item.stack;
    if (itemMemo.stack > 0)
      return stack - itemMemo.stack;
    this._memos.Remove(itemMemo);
    return stack;
  }

  private class ItemMemo
  {
    public readonly int type;
    public readonly int prefix;
    public int stack;

    public ItemMemo(Item item)
    {
      this.type = item.type;
      this.prefix = (int) item.prefix;
      this.stack = item.stack;
    }

    public bool Matches(Item item)
    {
      return item.IsConsideredSameItemAsType(this.type) && (int) item.prefix == this.prefix;
    }
  }
}
