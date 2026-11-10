// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TECritterAnchor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;
using Terraria.GameContent.LeashedEntities;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TECritterAnchor : TELeashedEntityAnchorWithItem
{
  private static byte _myEntityID;
  public static LeashedCritter[] CritterPrototypes = NPCID.Sets.Factory.CreateCustomSet<LeashedCritter>((LeashedCritter) WalkerLeashedCritter.Prototype);

  public TECritterAnchor() => this.type = TECritterAnchor._myEntityID;

  public override void RegisterTileEntityID(int assignedID)
  {
    this.type = TECritterAnchor._myEntityID = (byte) assignedID;
  }

  public override bool IsTileValidForEntity(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    return tile.active() && tile.type == (ushort) 724;
  }

  public override TileEntity GenerateInstance() => (TileEntity) new TECritterAnchor();

  public static void Kill(int x, int y) => TileEntity.Kill(x, y, (int) TECritterAnchor._myEntityID);

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type,
    int style,
    int direction,
    int alternate)
  {
    return TELeashedEntityAnchorWithItem.PlaceFromPlayerPlacementHook(x, y, (int) TECritterAnchor._myEntityID);
  }

  public override bool FitsItem(int itemType)
  {
    return ContentSamples.ItemsByType[itemType].makeNPC > (short) 0;
  }

  public override LeashedEntity CreateLeashedEntity()
  {
    if (this.itemType <= 0)
      return (LeashedEntity) null;
    LeashedCritter leashedEntity = (LeashedCritter) TECritterAnchor.GetLeashedCritterPrototype(this.itemType).NewInstance();
    leashedEntity.SetDefaults(this.itemType);
    return (LeashedEntity) leashedEntity;
  }

  static TECritterAnchor()
  {
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) FlyerLeashedCritter.Prototype, 444, 653, 661);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) NormalButterflyLeashedCritter.Prototype, 356);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) EmpressButterflyLeashedCritter.Prototype, 661);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) HellButterflyLeashedCritter.Prototype, 653);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) FireflyLeashedCritter.Prototype, 355, 358, 654);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) ShimmerFlyLeashedCritter.Prototype, 677);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) DragonflyLeashedCritter.Prototype, 595, 596, 601, 597, 598, 599, 600);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) CrawlingFlyLeashedCritter.Prototype, 604, 605, 669);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) FairyLeashedCritter.Prototype, 585, 584, 583);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) CrawlerLeashedCritter.Prototype, 357, 448, 484, 485, 486, 487, 606, 616, 617);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) SnailLeashedCritter.Prototype, 359, 360, 655);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) RunnerLeashedCritter.Prototype, 300, 447, 610);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) BirdLeashedCritter.Prototype, 74, 297, 298, 442, 611, 671, 672, 673, 675, 674);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) WaterfowlLeashedCritter.Prototype, 362, 364, 602, 608);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) FishLeashedCritter.Prototype, 55, 592, 607, 626, 627, 688);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) JumperLeashedCritter.Prototype, 377, 446);
    TECritterAnchor.SetPrototypeCollection((LeashedCritter) WaterStriderLeashedCritter.Prototype, 612, 613);
  }

  public static void SetPrototypeCollection(LeashedCritter instance, params int[] targetIds)
  {
    foreach (int targetId in targetIds)
      TECritterAnchor.CritterPrototypes[targetId] = instance;
  }

  public static LeashedCritter GetLeashedCritterPrototype(int itemType)
  {
    return TECritterAnchor.CritterPrototypes[(int) ContentSamples.ItemsByType[itemType].makeNPC];
  }
}
