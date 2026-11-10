// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PlayerGetItemLogger
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public class PlayerGetItemLogger
{
  public List<PlayerGetItemLogger.GetItemLoggerEntry> Entries = new List<PlayerGetItemLogger.GetItemLoggerEntry>();
  private bool _enabled;

  public void Clear() => this.Entries.Clear();

  public void Add(Item[] array, int slot, int itemSlotContext, int stack)
  {
    if (!this._enabled)
      return;
    this.Entries.Add(new PlayerGetItemLogger.GetItemLoggerEntry()
    {
      TargetArray = array,
      TargetSlot = slot,
      TargetItemSlotContext = itemSlotContext,
      Stack = stack
    });
  }

  public void Start()
  {
    this.Clear();
    this._enabled = true;
  }

  public void Stop() => this._enabled = false;

  public struct GetItemLoggerEntry
  {
    public Item[] TargetArray;
    public int TargetSlot;
    public int TargetItemSlotContext;
    public int Stack;
  }
}
