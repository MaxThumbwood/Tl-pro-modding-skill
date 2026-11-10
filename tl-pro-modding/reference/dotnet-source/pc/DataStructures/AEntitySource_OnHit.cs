// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.AEntitySource_OnHit
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public abstract class AEntitySource_OnHit : IEntitySource
{
  public readonly IEntitySourceTarget EntityStriking;
  public readonly IEntitySourceTarget EntityStruck;

  public AEntitySource_OnHit(IEntitySourceTarget entityStriking, IEntitySourceTarget entityStruck)
  {
    this.EntityStriking = entityStriking;
    this.EntityStruck = entityStruck;
  }
}
