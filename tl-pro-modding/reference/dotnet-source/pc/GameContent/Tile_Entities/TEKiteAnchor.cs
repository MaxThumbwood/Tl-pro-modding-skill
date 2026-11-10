// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TEKiteAnchor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;
using Terraria.GameContent.LeashedEntities;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TEKiteAnchor : TELeashedEntityAnchorWithItem
{
  private static byte _myEntityID;

  public TEKiteAnchor() => this.type = TEKiteAnchor._myEntityID;

  public override void RegisterTileEntityID(int assignedID)
  {
    this.type = TEKiteAnchor._myEntityID = (byte) assignedID;
  }

  public override bool IsTileValidForEntity(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    return tile.active() && tile.type == (ushort) 723;
  }

  public override TileEntity GenerateInstance() => (TileEntity) new TEKiteAnchor();

  public static void Kill(int x, int y) => TileEntity.Kill(x, y, (int) TEKiteAnchor._myEntityID);

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type,
    int style,
    int direction,
    int alternate)
  {
    return TELeashedEntityAnchorWithItem.PlaceFromPlayerPlacementHook(x, y, (int) TEKiteAnchor._myEntityID);
  }

  public override bool FitsItem(int itemType) => ItemID.Sets.IsAKite[itemType];

  public override LeashedEntity CreateLeashedEntity()
  {
    if (this.itemType <= 0)
      return (LeashedEntity) null;
    LeashedKite leashedEntity = (LeashedKite) LeashedKite.Prototype.NewInstance();
    leashedEntity.SetDefaults(ContentSamples.ItemsByType[this.itemType].shoot);
    return (LeashedEntity) leashedEntity;
  }

  public static void DebugPlace(int x, int y, int itemType)
  {
    int key = TileEntity.Place(x, y, (int) TEKiteAnchor._myEntityID);
    ((TELeashedEntityAnchorWithItem) TileEntity.ByID[key]).InsertItem(itemType);
    NetMessage.SendData(156, number: x, number2: (float) y, number3: (float) itemType);
  }
}
