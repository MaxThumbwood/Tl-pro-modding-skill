// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TELeashedEntityAnchorWithItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public abstract class TELeashedEntityAnchorWithItem : TELeashedEntityAnchor
{
  protected int itemType;

  public override void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
    writer.Write((short) this.itemType);
  }

  public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
    this.itemType = (int) reader.ReadInt16();
  }

  public void DropItemForTileBreak()
  {
    if (this.itemType <= 0)
      return;
    if (Main.netMode != 1)
      Item.NewItem((IEntitySource) new EntitySource_TileBreak((int) this.Position.X, (int) this.Position.Y), (int) this.Position.X * 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/, this.itemType);
    this.itemType = 0;
  }

  public void InsertItem(int itemType)
  {
    this.itemType = itemType;
    this.RespawnLeashedEntity();
  }

  public override void OnWorldLoaded()
  {
    if (!this.FitsItem(this.itemType))
      this.itemType = 0;
    base.OnWorldLoaded();
  }

  public abstract bool FitsItem(int itemType);

  protected new static int PlaceFromPlayerPlacementHook(int x, int y, int type)
  {
    int key = TELeashedEntityAnchor.PlaceFromPlayerPlacementHook(x, y, type);
    Item heldItem = Main.LocalPlayer.HeldItem;
    int type1 = heldItem.type;
    if (!heldItem.consumable && --heldItem.stack <= 0)
      heldItem.TurnToAir();
    if (Main.netMode == 1)
      NetMessage.SendData(156, number: x, number2: (float) y, number3: (float) type1);
    else
      ((TELeashedEntityAnchorWithItem) TileEntity.ByID[key]).InsertItem(type1);
    return key;
  }
}
