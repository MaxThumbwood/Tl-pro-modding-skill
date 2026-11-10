// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FakeCursorItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent;

public static class FakeCursorItem
{
  private static int _type;
  private static int _stack;
  private static int _prefix;
  private static Item _item = new Item();

  public static Item Item
  {
    get
    {
      int stack = Main.mouseItem.IsAir ? 0 : Main.mouseItem.stack;
      if (FakeCursorItem._type != FakeCursorItem._item.type)
        FakeCursorItem._item.SetDefaults(FakeCursorItem._type);
      else
        FakeCursorItem._item.Refresh();
      if (FakeCursorItem._prefix != (int) FakeCursorItem._item.prefix)
        FakeCursorItem._item.Prefix(FakeCursorItem._prefix);
      FakeCursorItem._item.stack = FakeCursorItem._stack + stack;
      return FakeCursorItem._item;
    }
  }

  public static void Reset()
  {
    FakeCursorItem._type = 0;
    FakeCursorItem._stack = 0;
  }

  public static void Add(int itemType, int itemStack, int itemPrefix = 0)
  {
    if (itemStack == 0)
      return;
    if (FakeCursorItem._type == itemType)
      FakeCursorItem._stack += itemStack;
    else
      FakeCursorItem._stack = itemStack;
    FakeCursorItem._type = itemType;
    FakeCursorItem._prefix = itemPrefix;
  }

  public static void Add(Item item) => FakeCursorItem.Add(item.type, item.stack, (int) item.prefix);

  public static void Remove(int itemType, int itemStack)
  {
    if (itemStack == 0 || FakeCursorItem._type != itemType)
      return;
    FakeCursorItem._stack -= itemStack;
    if (FakeCursorItem._stack > 0)
      return;
    FakeCursorItem._type = 0;
  }
}
