// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.EntitySource_OnHit_ByItemSourceID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class EntitySource_OnHit_ByItemSourceID : AEntitySource_OnHit
{
  public readonly int SourceId;

  public EntitySource_OnHit_ByItemSourceID(
    IEntitySourceTarget entityStriking,
    IEntitySourceTarget entityStruck,
    int itemSourceId)
    : base(entityStriking, entityStruck)
  {
    this.SourceId = itemSourceId;
  }
}
