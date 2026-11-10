// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NearbyChests
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent;

public static class NearbyChests
{
  private static List<PositionedChest> _scratch = new List<PositionedChest>();

  public static List<PositionedChest> GetChestsInRangeOf(Vector2 position, float range = 0.0f)
  {
    if ((double) range <= 0.0)
      range = 600f;
    List<PositionedChest> scratch = NearbyChests._scratch;
    scratch.Clear();
    for (int index = 0; index < 8000; ++index)
    {
      Chest chest = Main.chest[index];
      if (chest != null)
      {
        Vector2 position1 = new Vector2((float) (chest.x * 16 /*0x10*/ + 16 /*0x10*/), (float) (chest.y * 16 /*0x10*/ + 16 /*0x10*/));
        if ((double) Vector2.Distance(position1, position) <= (double) range)
          scratch.Add(new PositionedChest(chest, position1));
      }
    }
    return scratch;
  }

  public static List<PositionedChest> GetBanksInRangeOf(Player player, float range = 0.0f)
  {
    if ((double) range <= 0.0)
      range = 600f;
    List<PositionedChest> scratch = NearbyChests._scratch;
    scratch.Clear();
    int num = (int) ((double) range / 16.0 + 2.0);
    Point tileCoordinates = player.Center.ToTileCoordinates();
    Rectangle rectangle = new Rectangle(tileCoordinates.X - num, tileCoordinates.Y - num, num * 2 + 1, num * 2 + 1);
    for (int index = 0; index < 1000; ++index)
    {
      Projectile projectile = Main.projectile[index];
      if (projectile.active)
      {
        int containerIndex = -1;
        if (projectile.TryGetContainerIndex(out containerIndex))
        {
          Vector2 vec = projectile.Hitbox.ClosestPointInRect(player.Center);
          Chest bank;
          if (rectangle.Contains(vec.ToTileCoordinates()) && NearbyChests.ContainerIndexToPlayerBank(player, containerIndex, out bank) && !NearbyChests.Contains(scratch, bank))
            scratch.Add(new PositionedChest(bank, projectile.Center));
        }
      }
    }
    for (int left = rectangle.Left; left < rectangle.Right; ++left)
    {
      for (int top = rectangle.Top; top < rectangle.Bottom; ++top)
      {
        if (WorldGen.InWorld(left, top))
        {
          int container = 0;
          switch (Main.tile[left, top].type)
          {
            case 29:
              container = -2;
              break;
            case 97:
              container = -3;
              break;
            case 463:
              container = -4;
              break;
            case 491:
              container = -5;
              break;
          }
          Chest bank;
          if (NearbyChests.ContainerIndexToPlayerBank(player, container, out bank) && !NearbyChests.Contains(scratch, bank))
            scratch.Add(new PositionedChest(bank, new Vector2((float) (left * 16 /*0x10*/ + 16 /*0x10*/), (float) (top * 16 /*0x10*/ + 16 /*0x10*/))));
        }
      }
    }
    return scratch;
  }

  private static bool Contains(this List<PositionedChest> list, Chest chest)
  {
    foreach (PositionedChest positionedChest in list)
    {
      if (positionedChest.chest == chest)
        return true;
    }
    return false;
  }

  private static bool ContainerIndexToPlayerBank(Player player, int container, out Chest bank)
  {
    bank = (Chest) null;
    switch (container)
    {
      case -5:
        bank = player.bank4;
        for (int index = 0; index < 58; ++index)
        {
          if (player.inventory[index].stack > 0 && player.inventory[index].type == 5325)
            return false;
        }
        return true;
      case -4:
        bank = player.bank3;
        return true;
      case -3:
        bank = player.bank2;
        return true;
      case -2:
        bank = player.bank;
        return true;
      default:
        return false;
    }
  }
}
