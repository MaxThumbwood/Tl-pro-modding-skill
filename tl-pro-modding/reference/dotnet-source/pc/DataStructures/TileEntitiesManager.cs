// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TileEntitiesManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameContent.Tile_Entities;

#nullable disable
namespace Terraria.DataStructures;

public class TileEntitiesManager
{
  private int _nextEntityID;
  private Dictionary<int, TileEntity> _types = new Dictionary<int, TileEntity>();

  private int AssignNewID() => this._nextEntityID++;

  private bool InvalidEntityID(int id) => id < 0 || id >= this._nextEntityID;

  public void RegisterAll()
  {
    this.Register((TileEntity) new TETrainingDummy());
    this.Register((TileEntity) new TEItemFrame());
    this.Register((TileEntity) new TELogicSensor());
    this.Register((TileEntity) new TEDisplayDoll());
    this.Register((TileEntity) new TEWeaponsRack());
    this.Register((TileEntity) new TEHatRack());
    this.Register((TileEntity) new TEFoodPlatter());
    this.Register((TileEntity) new TETeleportationPylon());
    this.Register((TileEntity) new TEDeadCellsDisplayJar());
    this.Register((TileEntity) new TEKiteAnchor());
    this.Register((TileEntity) new TECritterAnchor());
  }

  public void Register(TileEntity entity)
  {
    int num = this.AssignNewID();
    this._types[num] = entity;
    entity.RegisterTileEntityID(num);
  }

  public bool CheckValidTile(int id, int x, int y)
  {
    return !this.InvalidEntityID(id) && this._types[id].IsTileValidForEntity(x, y);
  }

  public void NetPlaceEntity(int id, int x, int y)
  {
    if (this.InvalidEntityID(id) || !this._types[id].IsTileValidForEntity(x, y))
      return;
    this._types[id].NetPlaceEntityAttempt(x, y);
  }

  public TileEntity GenerateInstance(int id)
  {
    return this.InvalidEntityID(id) ? (TileEntity) null : this._types[id].GenerateInstance();
  }
}
