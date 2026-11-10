// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.BiomeSquareDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class BiomeSquareDungeonRoom(DungeonRoomSettings settings) : BiomeDungeonRoom(settings)
{
  public Vector2 Position;
  public int RoomInnerSize;
  public int RoomOuterSize;
  public int WallDepth;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.BiomeRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.BiomeRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public void BiomeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom genRand = new UnifiedRandom(this.settings.RandomSeed);
    BiomeDungeonRoomSettings settings = (BiomeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2 vector2 = new Vector2((float) i, (float) j);
    int num1 = BiomeDungeonRoom.GetBiomeRoomInnerSize(settings.StyleData);
    int num2 = 8;
    int num3 = BiomeDungeonRoom.GetBiomeRoomOuterSize(settings.StyleData);
    if (this.calculated)
    {
      vector2 = this.Position;
      num1 = this.RoomInnerSize;
      num3 = this.RoomOuterSize;
      num2 = this.WallDepth;
    }
    int val1 = 20;
    int minX = Math.Max(val1 + num2, Math.Min(Main.maxTilesX - val1 - num2, (int) vector2.X - num1));
    int maxX = Math.Max(val1 + num2, Math.Min(Main.maxTilesX - val1 - num2, (int) vector2.X + num1));
    int minY = Math.Max(val1 + num2, Math.Min(Main.maxTilesY - val1 - num2, (int) vector2.Y - num1));
    int maxY = Math.Max(val1 + num2, Math.Min(Main.maxTilesY - val1 - num2, (int) vector2.Y + num1));
    int num4 = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) vector2.X - num3));
    int num5 = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) vector2.X + num3));
    int num6 = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) vector2.Y - num3));
    int num7 = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) vector2.Y + num3));
    this.InnerBounds.SetBounds(minX, minY, maxX, maxY);
    this.OuterBounds.SetBounds(num4, num6, num5, num7);
    data.dungeonBounds.UpdateBounds(num4, num6, num5, num7);
    if (generating)
    {
      Point center = this.OuterBounds.Center;
      for (int index1 = num4; index1 < num5; ++index1)
      {
        int x = index1;
        for (int index2 = num6; index2 < num7; ++index2)
        {
          bool flag1 = false;
          bool flag2 = false;
          int y = index2;
          Tile tile1 = Main.tile[x, y];
          Tile tile2 = Main.tile[x, y - 1];
          Tile tile3 = Main.tile[x, y + 1];
          Tile tile4 = Main.tile[x, y + 2];
          if (tile1.type == (ushort) 484 || tile1.type == (ushort) 485)
            tile1.active(false);
          if (this.InnerBounds.Contains(x, y))
          {
            if (tile1.liquid > (byte) 0)
            {
              if (flag2)
                tile1.liquid = (byte) 0;
              tile1.liquidType(0);
            }
            if (flag1)
              DungeonUtils.ChangeWallType(tile1, (ushort) 0, false, settings.OverridePaintWall);
            else
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
            tile1.active(false);
          }
          else
          {
            int num8 = index1 == num4 || index1 == num5 - 1 || index2 == num6 || index2 == num7 - 1 || index1 == minX - 1 || index1 == maxX || index2 == minY - 1 ? 1 : (index2 == maxY ? 1 : 0);
            if (tile1.liquid > (byte) 0)
              tile1.liquid = (byte) 0;
            DungeonUtils.ChangeTileType(tile1, brickTileType, true, settings.OverridePaintTile);
            if (num8 == 0)
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
          }
        }
      }
      this.BiomeRoom_FinishRoom(genRand, num4, num5, num6, num7);
    }
    this.RoomInnerSize = num1;
    this.RoomOuterSize = num3;
    this.WallDepth = num2;
    this.Position = vector2;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
  }
}
