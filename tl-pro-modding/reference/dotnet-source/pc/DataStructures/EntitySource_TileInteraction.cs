// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.EntitySource_TileInteraction
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class EntitySource_TileInteraction : AEntitySource_Tile
{
  public readonly IEntitySourceTarget Entity;

  public EntitySource_TileInteraction(IEntitySourceTarget entity, int tileCoordsX, int tileCoordsY)
    : base(tileCoordsX, tileCoordsY)
  {
    this.Entity = entity;
  }
}
