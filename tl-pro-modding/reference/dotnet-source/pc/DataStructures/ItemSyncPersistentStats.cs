// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.ItemSyncPersistentStats
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public struct ItemSyncPersistentStats
{
  private Color color;
  private int type;

  public void CopyFrom(WorldItem item)
  {
    this.type = item.type;
    this.color = item.color;
  }

  public void PasteInto(WorldItem item)
  {
    if (this.type != item.type)
      return;
    item.color = this.color;
  }
}
