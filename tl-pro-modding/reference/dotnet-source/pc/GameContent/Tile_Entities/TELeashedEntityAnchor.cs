// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TELeashedEntityAnchor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public abstract class TELeashedEntityAnchor : TileEntity
{
  private LeashedEntity leashedEntity;

  public override void NetPlaceEntityAttempt(int x, int y)
  {
    NetMessage.SendData(86, number: TileEntity.Place(x, y, (int) this.type), number2: (float) x, number3: (float) y);
  }

  public override void OnRemoved() => this.DespawnLeashedEntity();

  protected static int PlaceFromPlayerPlacementHook(int x, int y, int type)
  {
    if (Main.netMode != 1)
      return TileEntity.Place(x, y, type);
    NetMessage.SendTileSquare(Main.myPlayer, x, y);
    NetMessage.SendData(87, number: x, number2: (float) y, number3: (float) type);
    return -1;
  }

  public override void OnWorldLoaded() => this.RespawnLeashedEntity();

  protected void DespawnLeashedEntity()
  {
    if (this.leashedEntity == null)
      return;
    this.leashedEntity.active = false;
  }

  protected void RespawnLeashedEntity()
  {
    this.DespawnLeashedEntity();
    this.leashedEntity = this.CreateLeashedEntity();
    LeashedEntity.AddNewEntity(this.leashedEntity, this.Position);
  }

  public abstract LeashedEntity CreateLeashedEntity();
}
