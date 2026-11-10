// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.EntitySource_Buff
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class EntitySource_Buff : IEntitySource
{
  public readonly IEntitySourceTarget Entity;
  public readonly int BuffId;
  public readonly int BuffIndex;

  public EntitySource_Buff(IEntitySourceTarget entity, int buffId, int buffIndex)
  {
    this.Entity = entity;
    this.BuffId = buffId;
    this.BuffIndex = buffIndex;
  }
}
