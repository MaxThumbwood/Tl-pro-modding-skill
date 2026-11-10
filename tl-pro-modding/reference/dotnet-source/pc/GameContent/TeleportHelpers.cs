// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.TeleportHelpers
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent;

public class TeleportHelpers
{
  public static bool FindClosestTeleportSpotNoSpace(Player player, out Vector2 resultPosition)
  {
    bool teleportSpotNoSpace = false;
    resultPosition = player.position;
    player.velocity = Vector2.Zero;
    Vector2 vector2 = new Vector2((float) player.width * 0.5f, (float) player.height);
    Vector2 bottom = player.Bottom;
    Point tileCoordinates = bottom.ToTileCoordinates();
    int num1 = tileCoordinates.X - 25;
    int num2 = tileCoordinates.X + 25;
    int num3 = tileCoordinates.Y - 25;
    int num4 = tileCoordinates.Y + 25;
    int num5 = Utils.Clamp<int>(num1, 40, Main.maxTilesX - 40);
    int num6 = Utils.Clamp<int>(num2, 40, Main.maxTilesX - 40);
    int num7 = Utils.Clamp<int>(num3, 40, Main.maxTilesY - 40);
    int num8 = Utils.Clamp<int>(num4, 40, Main.maxTilesY - 40);
    float num9 = float.MaxValue;
    for (int x = num5; x < num6; ++x)
    {
      for (int y = num7; y < num8; ++y)
      {
        Vector2 Position = new Vector2((float) (x * 16 /*0x10*/ + 8), (float) (y * 16 /*0x10*/ + 15)) - vector2;
        Tile tile1 = Main.tile[x, y];
        Tile tile2 = Main.tile[x, y + 1];
        bool flag1 = WorldGen.SolidOrSlopedTile(tile1) || tile1.liquid > (byte) 0;
        bool flag2 = WorldGen.SolidOrSlopedTile(tile2) && tile2.liquid == (byte) 0;
        if (((TeleportHelpers.TileIsDangerous(x, y) ? 0 : (!flag1 ? 1 : 0)) & (flag2 ? 1 : 0)) != 0 && !Collision.LavaCollision(Position, player.width, player.height) && !Collision.AnyHurtingTiles(Position, player.width, player.height) && !Collision.SolidCollision(Position, player.width, player.height))
        {
          float num10 = (Position - bottom).Length();
          if ((double) num10 < (double) num9)
          {
            resultPosition = Position;
            num9 = num10;
            teleportSpotNoSpace = true;
          }
        }
      }
    }
    return teleportSpotNoSpace;
  }

  public static bool RequestMagicConchTeleportPosition(
    Player player,
    int crawlOffsetX,
    int startX,
    out Point landingPoint)
  {
    landingPoint = new Point();
    Point point = new Point(startX, 50);
    int num1 = 1;
    int num2 = -1;
    int num3 = 1;
    int num4 = 0;
    int num5 = 5000;
    Vector2 vector2 = new Vector2((float) player.width * 0.5f, (float) player.height);
    int num6 = 40;
    bool flag1 = WorldGen.SolidOrSlopedTile(Main.tile[point.X, point.Y]);
    int num7 = 0;
    int num8 = 400;
    while (num4 < num5 && num7 < num8)
    {
      ++num4;
      Tile tile1 = Main.tile[point.X, point.Y];
      Tile tile2 = Main.tile[point.X, point.Y + num3];
      bool flag2 = WorldGen.SolidOrSlopedTile(tile1) || tile1.liquid > (byte) 0;
      bool flag3 = WorldGen.SolidOrSlopedTile(tile2) || tile2.liquid > (byte) 0;
      if (TeleportHelpers.IsInSolidTilesExtended(new Vector2((float) (point.X * 16 /*0x10*/ + 8), (float) (point.Y * 16 /*0x10*/ + 15)) - vector2, player.velocity, player.width, player.height, (int) player.gravDir))
      {
        if (flag1)
          point.Y += num1;
        else
          point.Y += num2;
      }
      else if (flag2)
      {
        if (flag1)
          point.Y += num1;
        else
          point.Y += num2;
      }
      else
      {
        flag1 = false;
        if (!TeleportHelpers.IsInSolidTilesExtended(new Vector2((float) (point.X * 16 /*0x10*/ + 8), (float) (point.Y * 16 /*0x10*/ + 15 + 16 /*0x10*/)) - vector2, player.velocity, player.width, player.height, (int) player.gravDir) && !flag3 && (double) point.Y < Main.worldSurface)
          point.Y += num1;
        else if (tile2.liquid > (byte) 0)
        {
          point.X += crawlOffsetX;
          ++num7;
        }
        else if (TeleportHelpers.TileIsDangerous(point.X, point.Y))
        {
          point.X += crawlOffsetX;
          ++num7;
        }
        else if (TeleportHelpers.TileIsDangerous(point.X, point.Y + num3))
        {
          point.X += crawlOffsetX;
          ++num7;
        }
        else if (point.Y < num6)
          point.Y += num1;
        else
          break;
      }
    }
    if (num4 == num5 || num7 >= num8 || !WorldGen.InWorld(point.X, point.Y, 40))
      return false;
    bool flag4 = false;
    for (int index1 = 0; index1 < 10; ++index1)
    {
      int index2 = point.Y + index1;
      Tile tile = Main.tile[point.X, index2];
      if (WorldGen.SolidOrSlopedTile(tile) || tile.liquid > (byte) 0)
      {
        flag4 = true;
        break;
      }
    }
    if (!flag4)
      return false;
    landingPoint = point;
    return true;
  }

  private static bool TileIsDangerous(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    return tile.liquid > (byte) 0 && tile.lava() || tile.wall == (ushort) 87 && (double) y > Main.worldSurface && !NPC.downedPlantBoss || Main.wallDungeon[(int) tile.wall] && (double) y > Main.worldSurface && !NPC.downedBoss3;
  }

  private static bool IsInSolidTilesExtended(
    Vector2 testPosition,
    Vector2 playerVelocity,
    int width,
    int height,
    int gravDir)
  {
    if (Collision.LavaCollision(testPosition, width, height) || Collision.AnyHurtingTiles(testPosition, width, height) || Collision.SolidCollision(testPosition, width, height))
      return true;
    Vector2 Velocity1 = Vector2.UnitX * 16f;
    if (Collision.TileCollision(testPosition - Velocity1, Velocity1, width, height, true, true, gravDir) != Velocity1)
      return true;
    Vector2 Velocity2 = -Vector2.UnitX * 16f;
    if (Collision.TileCollision(testPosition - Velocity2, Velocity2, width, height, true, true, gravDir) != Velocity2)
      return true;
    Vector2 Velocity3 = Vector2.UnitY * 16f;
    if (Collision.TileCollision(testPosition - Velocity3, Velocity3, width, height, true, true, gravDir) != Velocity3)
      return true;
    Vector2 Velocity4 = -Vector2.UnitY * 16f;
    return Collision.TileCollision(testPosition - Velocity4, Velocity4, width, height, true, true, gravDir) != Velocity4;
  }
}
