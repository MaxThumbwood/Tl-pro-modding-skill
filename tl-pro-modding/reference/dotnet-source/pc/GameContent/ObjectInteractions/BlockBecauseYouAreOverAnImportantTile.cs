// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.BlockBecauseYouAreOverAnImportantTile
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public class BlockBecauseYouAreOverAnImportantTile : ISmartInteractBlockReasonProvider
{
  public bool ShouldBlockSmartInteract(SmartInteractScanSettings settings)
  {
    int tileTargetX = Player.tileTargetX;
    int tileTargetY = Player.tileTargetY;
    if (!WorldGen.InWorld(tileTargetX, tileTargetY, 10))
      return true;
    Tile tile = Main.tile[tileTargetX, tileTargetY];
    if (tile == null)
      return true;
    if (tile.active())
    {
      switch (tile.type)
      {
        case 33:
        case 334:
        case 395:
        case 410:
        case 455:
        case 471:
        case 480:
        case 509:
        case 520:
        case 657:
        case 658:
        case 698:
        case 720:
        case 721:
        case 725:
        case 733:
          return true;
        default:
          if (TileID.Sets.Torches[(int) tile.type])
            return true;
          break;
      }
    }
    return false;
  }
}
