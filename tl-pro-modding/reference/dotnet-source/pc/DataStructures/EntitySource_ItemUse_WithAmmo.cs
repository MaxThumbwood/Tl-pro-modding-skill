// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.EntitySource_ItemUse_WithAmmo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class EntitySource_ItemUse_WithAmmo : EntitySource_ItemUse
{
  public readonly int AmmoItemIdUsed;

  public EntitySource_ItemUse_WithAmmo(IEntitySourceTarget entity, Item item, int ammoItemIdUsed)
    : base(entity, item)
  {
    this.AmmoItemIdUsed = ammoItemIdUsed;
  }
}
