// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Events.CultistRitual
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Events;

public class CultistRitual
{
  public const int delayStart = 86400;
  public const int respawnDelay = 43200;
  private const int timePerCultist = 3600;
  private const int recheckStart = 600;
  public static int delay;
  public static int recheck;

  public static void UpdateTime()
  {
    if (Main.netMode == 1)
      return;
    CultistRitual.delay -= Main.dayRate;
    if (CultistRitual.delay < 0)
      CultistRitual.delay = 0;
    CultistRitual.recheck -= Main.dayRate;
    if (CultistRitual.recheck < 0)
      CultistRitual.recheck = 0;
    if (CultistRitual.delay != 0 || CultistRitual.recheck != 0)
      return;
    CultistRitual.recheck = 600;
    if (NPC.AnyDanger())
      CultistRitual.recheck *= 6;
    else
      CultistRitual.TrySpawning(Main.dungeonX, Main.dungeonY);
  }

  public static void CultistSlain() => CultistRitual.delay -= 3600;

  public static void TabletDestroyed() => CultistRitual.delay = 43200;

  public static bool TrySpawning(int x, int y, bool force = false)
  {
    if (x < 0 || y < 0 || x >= Main.maxTilesX || y >= Main.maxTilesY || !force && (WorldGen.PlayerLOS(x - 6, y) || WorldGen.PlayerLOS(x + 6, y)) || !CultistRitual.CheckRitual(x, y, force))
      return false;
    NPC.NewNPC((IEntitySource) new EntitySource_WorldEvent(), x * 16 /*0x10*/ + 8, (y - 4) * 16 /*0x10*/ - 8, 437);
    return true;
  }

  private static bool CheckRitual(int x, int y, bool force = false)
  {
    if (!force && (CultistRitual.delay != 0 || !Main.hardMode || !NPC.downedGolemBoss || !NPC.downedBoss3) || y < 7 || WorldGen.SolidTile(Main.tile[x, y - 7]) || !force && NPC.AnyNPCs(437))
      return false;
    Vector2 Center = new Vector2((float) (x * 16 /*0x10*/ + 8), (float) (y * 16 /*0x10*/ - 64 /*0x40*/ - 8 - 27));
    Point[] pointArray = (Point[]) null;
    ref Point[] local = ref pointArray;
    return CultistRitual.CheckFloor(Center, out local);
  }

  public static bool CheckFloor(Vector2 Center, out Point[] spawnPoints)
  {
    Point[] pointArray = new Point[4];
    int num1 = 0;
    Point tileCoordinates = Center.ToTileCoordinates();
    for (int index1 = -5; index1 <= 5; index1 += 2)
    {
      if (index1 != -1 && index1 != 1)
      {
        for (int index2 = -5; index2 < 12; ++index2)
        {
          int num2 = tileCoordinates.X + index1 * 2;
          int num3 = tileCoordinates.Y + index2;
          if ((WorldGen.SolidTile(num2, num3) || TileID.Sets.Platforms[(int) Framing.GetTileSafely(num2, num3).type]) && (!Collision.SolidTiles(num2 - 1, num2 + 1, num3 - 3, num3 - 1) || !Collision.SolidTiles(num2, num2, num3 - 3, num3 - 1) && !Collision.SolidTiles(num2 + 1, num2 + 1, num3 - 3, num3 - 2) && !Collision.SolidTiles(num2 - 1, num2 - 1, num3 - 3, num3 - 2)))
          {
            pointArray[num1++] = new Point(num2, num3);
            break;
          }
        }
      }
    }
    if (num1 != 4)
    {
      spawnPoints = (Point[]) null;
      return false;
    }
    spawnPoints = pointArray;
    return true;
  }

  public static bool CheckFloor2(Vector2 Center, out Point[] spawnPoints)
  {
    Point[] pointArray = new Point[2];
    int num1 = 0;
    Point tileCoordinates = Center.ToTileCoordinates();
    for (int index1 = -3; index1 <= 3; index1 += 2)
    {
      if (index1 != -1 && index1 != 1)
      {
        for (int index2 = -5; index2 < 12; ++index2)
        {
          int num2 = tileCoordinates.X + index1 * 2;
          int num3 = tileCoordinates.Y + index2;
          if ((WorldGen.SolidTile(num2, num3) || TileID.Sets.Platforms[(int) Framing.GetTileSafely(num2, num3).type]) && (!Collision.SolidTiles(num2 - 1, num2 + 1, num3 - 3, num3 - 1) || !Collision.SolidTiles(num2, num2, num3 - 3, num3 - 1) && !Collision.SolidTiles(num2 + 1, num2 + 1, num3 - 3, num3 - 2) && !Collision.SolidTiles(num2 - 1, num2 - 1, num3 - 3, num3 - 2)))
          {
            pointArray[num1++] = new Point(num2, num3);
            break;
          }
        }
      }
    }
    if (num1 != 2)
    {
      spawnPoints = (Point[]) null;
      return false;
    }
    spawnPoints = pointArray;
    return true;
  }
}
