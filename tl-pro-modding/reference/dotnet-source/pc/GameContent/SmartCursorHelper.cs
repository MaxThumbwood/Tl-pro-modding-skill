// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.SmartCursorHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent;

public class SmartCursorHelper
{
  private static List<Point> _targets = new List<Point>();
  private static List<Point> _grappleTargets = new List<Point>();
  private static List<Point> _points = new List<Point>();
  private static List<Point> _endpoints = new List<Point>();
  private static List<Point> _toRemove = new List<Point>();
  private static List<Point> _targets2 = new List<Point>();
  private static Point? _lockedDesiredDirection;
  private static Point? _lockedContinuityCoords;

  public static void SmartCursorLookup(Player player)
  {
    Main.SmartCursorShowing = false;
    if (!player.controlUseItem || !Main.SmartCursorIsUsed)
    {
      SmartCursorHelper._lockedDesiredDirection = new Point?();
      SmartCursorHelper._lockedContinuityCoords = new Point?();
    }
    if (!Main.SmartCursorIsUsed)
      return;
    SmartCursorHelper.SmartCursorUsageInfo providedInfo = new SmartCursorHelper.SmartCursorUsageInfo()
    {
      player = player,
      item = player.inventory[player.selectedItem],
      mouse = Main.MouseWorld,
      position = player.position,
      Center = player.Center
    };
    double gravDir = (double) player.gravDir;
    int tileTargetX = Player.tileTargetX;
    int tileTargetY = Player.tileTargetY;
    int tileRangeX = Player.tileRangeX;
    int tileRangeY = Player.tileRangeY;
    providedInfo.screenTargetX = Utils.Clamp<int>(tileTargetX, 10, Main.maxTilesX - 10);
    providedInfo.screenTargetY = Utils.Clamp<int>(tileTargetY, 10, Main.maxTilesY - 10);
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY] == null)
      return;
    int num1 = SmartCursorHelper.IsHoveringOverAnInteractableTileThatBlocksSmartCursor(providedInfo) ? 1 : 0;
    SmartCursorHelper.TryFindingPaintInplayerInventory(providedInfo, out providedInfo.paintLookup, out providedInfo.paintCoatingLookup);
    int tileBoost = providedInfo.item.tileBoost;
    if (providedInfo.item.createWall > 0 || providedInfo.item.createTile > 0 || providedInfo.item.tileWand > 0)
      tileBoost += player.blockRange;
    TileReachCheckSettings.Simple.GetTileRegion(player, out providedInfo.reachableStartX, out providedInfo.reachableStartY, out providedInfo.reachableEndX, out providedInfo.reachableEndY, tileBoost);
    providedInfo.reachableStartX = Utils.Clamp<int>(providedInfo.reachableStartX, 10, Main.maxTilesX - 10);
    providedInfo.reachableEndX = Utils.Clamp<int>(providedInfo.reachableEndX, 10, Main.maxTilesX - 10);
    providedInfo.reachableStartY = Utils.Clamp<int>(providedInfo.reachableStartY, 10, Main.maxTilesY - 10);
    providedInfo.reachableEndY = Utils.Clamp<int>(providedInfo.reachableEndY, 10, Main.maxTilesY - 10);
    if (num1 != 0 && providedInfo.screenTargetX >= providedInfo.reachableStartX && providedInfo.screenTargetX <= providedInfo.reachableEndX && providedInfo.screenTargetY >= providedInfo.reachableStartY && providedInfo.screenTargetY <= providedInfo.reachableEndY)
      return;
    SmartCursorHelper._grappleTargets.Clear();
    int[] grappling = player.grappling;
    int grapCount = player.grapCount;
    for (int index = 0; index < grapCount; ++index)
    {
      Projectile projectile = Main.projectile[grappling[index]];
      int x = (int) projectile.Center.X / 16 /*0x10*/;
      int y = (int) projectile.Center.Y / 16 /*0x10*/;
      SmartCursorHelper._grappleTargets.Add(new Point(x, y));
    }
    int num2 = -1;
    int num3 = -1;
    if (!Player.SmartCursorSettings.SmartAxeAfterPickaxe)
      SmartCursorHelper.Step_Axe(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_ForceCursorToAnyMinableThing(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Pickaxe_MineShinies(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Pickaxe_MineSolids(player, player.position, player.Center, player.width, player.direction, providedInfo, SmartCursorHelper._grappleTargets, ref num2, ref num3);
    if (Player.SmartCursorSettings.SmartAxeAfterPickaxe)
      SmartCursorHelper.Step_Axe(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_ColoredWrenches(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_MulticolorWrench(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Hammers(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_ActuationRod(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_WireCutter(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Platforms(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_MinecartTracks(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Walls(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_PumpkinSeeds(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_GrassSeeds(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Moss(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Pigronata(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Boulders(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Torch(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_LawnMower(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_BlocksFilling(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_BlocksLines(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_PaintRoller(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_PaintBrush(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_PaintScrapper(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Acorns(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_GemCorns(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_EmptyBuckets(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_Actuators(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_AlchemySeeds(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_PlanterBox(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_ClayPots(providedInfo, ref num2, ref num3);
    SmartCursorHelper.Step_StaffOfRegrowth(providedInfo, ref num2, ref num3);
    if (num2 != -1 && num3 != -1)
    {
      Main.SmartCursorX = Player.tileTargetX = num2;
      Main.SmartCursorY = Player.tileTargetY = num3;
      Main.SmartCursorShowing = true;
    }
    SmartCursorHelper._grappleTargets.Clear();
  }

  private static void TryFindingPaintInplayerInventory(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    out int paintLookup,
    out int coatingLookup)
  {
    Item[] inventory = providedInfo.player.inventory;
    paintLookup = 0;
    coatingLookup = 0;
    if ((providedInfo.item.type == 1071 || providedInfo.item.type == 1543 || providedInfo.item.type == 1072 ? 1 : (providedInfo.item.type == 1544 ? 1 : 0)) == 0)
      return;
    Item paintOrCoating = providedInfo.player.FindPaintOrCoating();
    if (paintOrCoating == null)
      return;
    coatingLookup = (int) paintOrCoating.paintCoating;
    paintLookup = (int) paintOrCoating.paint;
  }

  private static bool IsHoveringOverAnInteractableTileThatBlocksSmartCursor(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo)
  {
    bool flag = false;
    Tile tile = Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY];
    if (tile.active())
    {
      switch (tile.type)
      {
        case 10:
        case 11:
        case 13:
        case 21:
        case 29:
        case 33:
        case 49:
        case 50:
        case 55:
        case 79:
        case 85:
        case 88:
        case 97:
        case 104:
        case 125:
        case 132:
        case 136:
        case 139:
        case 144 /*0x90*/:
        case 174:
        case 207:
        case 209:
        case 212:
        case 216:
        case 219:
        case 237:
        case 287:
        case 334:
        case 335:
        case 338:
        case 354:
        case 386:
        case 387:
        case 388:
        case 389:
        case 411:
        case 425:
        case 441:
        case 463:
        case 464:
        case 467:
        case 468:
        case 491:
        case 494:
        case 510:
        case 511 /*0x01FF*/:
        case 573:
        case 621:
        case 642:
        case 699:
        case 707:
          flag = true;
          break;
        case 314:
          if ((double) providedInfo.player.gravDir == 1.0)
          {
            flag = true;
            break;
          }
          break;
      }
      if (TileID.Sets.Torches[(int) tile.type])
        flag = true;
    }
    return flag;
  }

  private static bool AllowNormalBlockPlacementBehaviourForItemType(int itemType)
  {
    return itemType >= 0 && itemType < (int) ItemID.Count && itemType != 213 && itemType != 5295 && !ItemID.Sets.GrassSeeds[itemType] && !ItemID.Sets.Moss[itemType];
  }

  private static void Step_StaffOfRegrowth(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if ((providedInfo.item.type == 213 ? 1 : (providedInfo.item.type == 5295 ? 1 : 0)) == 0 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        bool flag1 = !Main.tile[reachableStartX - 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY - 1].active();
        bool flag2 = !Main.tile[reachableStartX - 1, reachableStartY - 1].active() || !Main.tile[reachableStartX - 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY - 1].active();
        if (tile.active() && !tile.inActive() && tile.type == (ushort) 0 && (flag1 || tile.type == (ushort) 0 & flag2))
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_GrassSeeds(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (focusedX > -1 || focusedY > -1)
      return;
    int type = providedInfo.item.type;
    if (type < 0 || type >= (int) ItemID.Count || !ItemID.Sets.GrassSeeds[type])
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        bool flag1 = !Main.tile[reachableStartX - 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY - 1].active();
        bool flag2 = !Main.tile[reachableStartX - 1, reachableStartY - 1].active() || !Main.tile[reachableStartX - 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY - 1].active();
        if (tile.active() && !tile.inActive() && (flag1 || flag2))
        {
          bool flag3;
          switch (type)
          {
            case 59:
            case 2171:
              flag3 = tile.type == (ushort) 0 || tile.type == (ushort) 59;
              break;
            case 194:
            case 195:
              flag3 = tile.type == (ushort) 59;
              break;
            case 5214:
              flag3 = tile.type == (ushort) 57;
              break;
            default:
              flag3 = tile.type == (ushort) 0;
              break;
          }
          if (flag3)
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Moss(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (focusedX > -1 || focusedY > -1)
      return;
    int type = providedInfo.item.type;
    if (type < 0 || type >= (int) ItemID.Count || !ItemID.Sets.Moss[type])
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        bool flag1 = !Main.tile[reachableStartX - 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY].active() || !Main.tile[reachableStartX, reachableStartY - 1].active();
        bool flag2 = !Main.tile[reachableStartX - 1, reachableStartY - 1].active() || !Main.tile[reachableStartX - 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY + 1].active() || !Main.tile[reachableStartX + 1, reachableStartY - 1].active();
        if (tile.active() && !tile.inActive() && (flag1 || flag2) && (tile.type == (ushort) 1 ? 1 : (tile.type == (ushort) 38 ? 1 : 0)) != 0)
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_ClayPots(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile != 78 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag = false;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].active())
      flag = true;
    if (!Collision.InTileBounds(providedInfo.screenTargetX, providedInfo.screenTargetY, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      flag = true;
    if (!flag)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile1 = Main.tile[reachableStartX, reachableStartY];
          Tile tile2 = Main.tile[reachableStartX, reachableStartY + 1];
          if ((!tile1.active() || Main.tileCut[(int) tile1.type] || TileID.Sets.BreakableWhenPlacing[(int) tile1.type]) && tile2.nactive() && !tile2.halfBrick() && tile2.slope() == (byte) 0 && Main.tileSolid[(int) tile2.type])
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        if (Collision.EmptyTile(SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y, true))
        {
          float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
          if ((double) num1 == -1.0 || (double) num2 < (double) num1)
          {
            num1 = num2;
            target = SmartCursorHelper._targets[index];
          }
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY) && (double) num1 != -1.0)
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_PlanterBox(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile != 380 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag = false;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].active() && Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].type == (ushort) 380)
      flag = true;
    if (!flag)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (tile.active() && tile.type == (ushort) 380)
          {
            if (!Main.tile[reachableStartX - 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX - 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX - 1, reachableStartY].type])
              SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
            if (!Main.tile[reachableStartX + 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX + 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX + 1, reachableStartY].type])
              SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY) && (double) num1 != -1.0)
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_AlchemySeeds(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile != 82 || focusedX != -1 || focusedY != -1)
      return;
    int placeStyle = providedInfo.item.placeStyle;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile1 = Main.tile[reachableStartX, reachableStartY];
        Tile tile2 = Main.tile[reachableStartX, reachableStartY + 1];
        int num = !tile1.active() || TileID.Sets.BreakableWhenPlacing[(int) tile1.type] || Main.tileCut[(int) tile1.type] && tile1.type != (ushort) 82 && tile1.type != (ushort) 83 ? 1 : (WorldGen.IsHarvestableHerbWithSeed((int) tile1.type, (int) tile1.frameX / 18, reachableStartY) ? 1 : 0);
        bool flag = tile2.nactive() && !tile2.halfBrick() && tile2.slope() == (byte) 0;
        if (num != 0 && flag)
        {
          switch (placeStyle)
          {
            case 0:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 2 && tile2.type != (ushort) 477 && tile2.type != (ushort) 109 && tile2.type != (ushort) 492 || tile1.liquid > (byte) 0)
                continue;
              break;
            case 1:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 60 || tile1.liquid > (byte) 0)
                continue;
              break;
            case 2:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 0 && tile2.type != (ushort) 59 || tile1.liquid > (byte) 0)
                continue;
              break;
            case 3:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 203 && tile2.type != (ushort) 199 && tile2.type != (ushort) 23 && tile2.type != (ushort) 25 || tile1.liquid > (byte) 0)
                continue;
              break;
            case 4:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 53 && tile2.type != (ushort) 116 || tile1.liquid > (byte) 0 && tile1.lava())
                continue;
              break;
            case 5:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 57 && tile2.type != (ushort) 633 || tile1.liquid > (byte) 0 && !tile1.lava())
                continue;
              break;
            case 6:
              if (tile2.type != (ushort) 78 && tile2.type != (ushort) 380 && tile2.type != (ushort) 147 && tile2.type != (ushort) 161 && tile2.type != (ushort) 163 && tile2.type != (ushort) 164 && tile2.type != (ushort) 200 || tile1.liquid > (byte) 0 && tile1.lava())
                continue;
              break;
          }
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Actuators(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 849 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if ((tile.wire() || tile.wire2() || tile.wire3() || tile.wire4()) && !tile.actuator() && tile.active())
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_EmptyBuckets(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 205 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if (tile.liquid > (byte) 0)
        {
          int num1 = (int) tile.liquidType();
          int num2 = 0;
          for (int index1 = reachableStartX - 1; index1 <= reachableStartX + 1; ++index1)
          {
            for (int index2 = reachableStartY - 1; index2 <= reachableStartY + 1; ++index2)
            {
              if ((int) Main.tile[index1, index2].liquidType() == num1)
                num2 += (int) Main.tile[index1, index2].liquid;
            }
          }
          if (num2 > 100)
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num3 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num4 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num3 == -1.0 || (double) num4 < (double) num3)
        {
          num3 = num4;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_PaintScrapper(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (!ItemID.Sets.IsPaintScraper[providedInfo.item.type] || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        bool flag = false;
        if (tile.active())
          flag = flag | tile.color() > (byte) 0 | tile.type == (ushort) 184 | tile.fullbrightBlock() | tile.invisibleBlock();
        if (tile.wall > (ushort) 0)
          flag = flag | tile.wallColor() > (byte) 0 | tile.fullbrightWall() | tile.invisibleWall();
        if (flag)
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_PaintBrush(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 1071 && providedInfo.item.type != 1543 || providedInfo.paintLookup == 0 && providedInfo.paintCoatingLookup == 0 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    int paintLookup = providedInfo.paintLookup;
    int paintCoatingLookup = providedInfo.paintCoatingLookup;
    if (paintLookup != 0 || paintCoatingLookup != 0)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (tile.active() && (0 | (paintLookup == 0 ? 0 : ((int) tile.color() != paintLookup ? 1 : 0)) | (paintCoatingLookup != 1 ? 0 : (!tile.fullbrightBlock() ? 1 : 0)) | (paintCoatingLookup != 2 ? 0 : (!tile.invisibleBlock() ? 1 : 0))) != 0)
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_PaintRoller(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 1072 && providedInfo.item.type != 1544 || providedInfo.paintLookup == 0 && providedInfo.paintCoatingLookup == 0 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    int paintLookup = providedInfo.paintLookup;
    int paintCoatingLookup = providedInfo.paintCoatingLookup;
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if (tile.wall > (ushort) 0 && (!tile.active() || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type]) && (0 | (paintLookup == 0 ? 0 : ((int) tile.wallColor() != paintLookup ? 1 : 0)) | (paintCoatingLookup != 1 ? 0 : (!tile.fullbrightWall() ? 1 : 0)) | (paintCoatingLookup != 2 ? 0 : (!tile.invisibleWall() ? 1 : 0))) != 0)
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_BlocksLines(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    int type = providedInfo.item.type;
    if (type < 0 || type >= (int) ItemID.Count || !Player.SmartCursorSettings.SmartBlocksEnabled || providedInfo.item.createTile <= -1 || !SmartCursorHelper.AllowNormalBlockPlacementBehaviourForItemType(type) || !Main.tileSolid[providedInfo.item.createTile] || Main.tileSolidTop[providedInfo.item.createTile] || Main.tileFrameImportant[providedInfo.item.createTile] || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag1 = false;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].active())
      flag1 = true;
    if (!Collision.InTileBounds(providedInfo.screenTargetX, providedInfo.screenTargetY, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      flag1 = true;
    if (!flag1)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (!tile.active() || Main.tileCut[(int) tile.type] || TileID.Sets.BreakableWhenPlacing[(int) tile.type])
          {
            bool flag2 = false;
            if (Main.tile[reachableStartX - 1, reachableStartY].active() && Main.tileSolid[(int) Main.tile[reachableStartX - 1, reachableStartY].type] && !Main.tileSolidTop[(int) Main.tile[reachableStartX - 1, reachableStartY].type])
              flag2 = true;
            if (Main.tile[reachableStartX + 1, reachableStartY].active() && Main.tileSolid[(int) Main.tile[reachableStartX + 1, reachableStartY].type] && !Main.tileSolidTop[(int) Main.tile[reachableStartX + 1, reachableStartY].type])
              flag2 = true;
            if (Main.tile[reachableStartX, reachableStartY - 1].active() && Main.tileSolid[(int) Main.tile[reachableStartX, reachableStartY - 1].type] && !Main.tileSolidTop[(int) Main.tile[reachableStartX, reachableStartY - 1].type])
              flag2 = true;
            if (Main.tile[reachableStartX, reachableStartY + 1].active() && Main.tileSolid[(int) Main.tile[reachableStartX, reachableStartY + 1].type] && !Main.tileSolidTop[(int) Main.tile[reachableStartX, reachableStartY + 1].type])
              flag2 = true;
            if (flag2)
              SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        if (Collision.EmptyTile(SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y))
        {
          float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
          if ((double) num1 == -1.0 || (double) num2 < (double) num1)
          {
            num1 = num2;
            target = SmartCursorHelper._targets[index];
          }
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY) && (double) num1 != -1.0)
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Boulders(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile <= -1 || providedInfo.item.createTile >= (int) TileID.Count || !TileID.Sets.Boulders[providedInfo.item.createTile] || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile1 = Main.tile[reachableStartX, reachableStartY + 1];
        Tile tile2 = Main.tile[reachableStartX + 1, reachableStartY + 1];
        bool flag = true;
        if (!tile2.nactive() || !tile1.nactive())
          flag = false;
        if (tile2.slope() > (byte) 0 || tile1.slope() > (byte) 0 || tile2.halfBrick() || tile1.halfBrick())
          flag = false;
        if (!Main.tileSolid[(int) tile2.type] && !Main.tileTable[(int) tile2.type] || !Main.tileSolid[(int) tile1.type] && !Main.tileTable[(int) tile1.type])
          flag = false;
        if (Main.tileNoAttach[(int) tile2.type] || Main.tileNoAttach[(int) tile1.type])
          flag = false;
        for (int index1 = reachableStartX; index1 <= reachableStartX + 1; ++index1)
        {
          for (int index2 = reachableStartY - 1; index2 <= reachableStartY; ++index2)
          {
            Tile tile3 = Main.tile[index1, index2];
            if (tile3.active() && !Main.tileCut[(int) tile3.type])
              flag = false;
          }
        }
        Rectangle rectangle = new Rectangle(reachableStartX * 16 /*0x10*/, reachableStartY * 16 /*0x10*/ - 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/);
        for (int index = 0; index < (int) byte.MaxValue; ++index)
        {
          Player player = Main.player[index];
          if (player.active && !player.dead && player.Hitbox.Intersects(rectangle))
          {
            flag = false;
            break;
          }
        }
        if (flag)
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Pigronata(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile != 454 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY && (double) reachableStartY <= Main.worldSurface - 2.0; ++reachableStartY)
      {
        bool flag = true;
        for (int index1 = reachableStartX - 2; index1 <= reachableStartX + 1; ++index1)
        {
          for (int index2 = reachableStartY - 1; index2 <= reachableStartY + 2; ++index2)
          {
            Tile testTile = Main.tile[index1, index2];
            if (index2 == reachableStartY - 1)
            {
              if (!WorldGen.SolidTile(testTile))
                flag = false;
            }
            else if (testTile.active() && (!Main.tileCut[(int) testTile.type] || testTile.type == (ushort) 454))
              flag = false;
          }
        }
        if (flag)
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_PumpkinSeeds(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile != 254 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile1 = Main.tile[reachableStartX, reachableStartY + 1];
        Tile tile2 = Main.tile[reachableStartX + 1, reachableStartY + 1];
        if ((double) reachableStartY <= Main.worldSurface - 2.0)
        {
          bool flag = true;
          if (!tile2.active() || !tile1.active())
            flag = false;
          if (tile2.slope() > (byte) 0 || tile1.slope() > (byte) 0 || tile2.halfBrick() || tile1.halfBrick())
            flag = false;
          if (tile2.type != (ushort) 2 && tile2.type != (ushort) 477 && tile2.type != (ushort) 109 && tile2.type != (ushort) 492)
            flag = false;
          if (tile1.type != (ushort) 2 && tile1.type != (ushort) 477 && tile1.type != (ushort) 109 && tile1.type != (ushort) 492)
            flag = false;
          for (int x = reachableStartX; x <= reachableStartX + 1; ++x)
          {
            for (int y = reachableStartY - 1; y <= reachableStartY; ++y)
            {
              Tile tile3 = Main.tile[x, y];
              if (tile3.active() && (tile3.type < (ushort) 0 || (int) tile3.type >= (int) TileID.Count || Main.tileSolid[(int) tile3.type] || !WorldGen.CanCutTile(x, y, TileCuttingContext.TilePlacement)))
                flag = false;
            }
          }
          if (flag)
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
        else
          break;
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Walls(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    int width = providedInfo.player.width;
    int height = providedInfo.player.height;
    if (providedInfo.item.createWall <= 0 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if (tile.wall == (ushort) 0 && (!tile.active() || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type]) && Collision.CanHitWithCheck(providedInfo.position, width, height, new Vector2((float) reachableStartX, (float) reachableStartY) * 16f, 16 /*0x10*/, 16 /*0x10*/, new Utils.TileActionAttempt(DelegateMethods.NotDoorStand)))
        {
          bool flag = false;
          if (Main.tile[reachableStartX - 1, reachableStartY].active() || Main.tile[reachableStartX - 1, reachableStartY].wall > (ushort) 0)
            flag = true;
          if (Main.tile[reachableStartX + 1, reachableStartY].active() || Main.tile[reachableStartX + 1, reachableStartY].wall > (ushort) 0)
            flag = true;
          if (Main.tile[reachableStartX, reachableStartY - 1].active() || Main.tile[reachableStartX, reachableStartY - 1].wall > (ushort) 0)
            flag = true;
          if (Main.tile[reachableStartX, reachableStartY + 1].active() || Main.tile[reachableStartX, reachableStartY + 1].wall > (ushort) 0)
            flag = true;
          if (WorldGen.IsOpenDoorAnchorFrame(reachableStartX, reachableStartY))
            flag = false;
          if (flag)
            SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_MinecartTracks(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if ((providedInfo.item.type == 2340 || providedInfo.item.type == 2739) && focusedX == -1 && focusedY == -1)
    {
      SmartCursorHelper._targets.Clear();
      Vector2 vector2 = (Main.MouseWorld - providedInfo.Center).SafeNormalize(Vector2.UnitY);
      double num1 = (double) Vector2.Dot(vector2, -Vector2.UnitY);
      bool flag1 = num1 >= 0.5;
      bool flag2 = num1 <= -0.5;
      double num2 = (double) Vector2.Dot(vector2, Vector2.UnitX);
      bool flag3 = num2 >= 0.5;
      bool flag4 = num2 <= -0.5;
      bool flag5 = flag1 & flag4;
      bool flag6 = flag1 & flag3;
      bool flag7 = flag2 & flag4;
      bool flag8 = flag2 & flag3;
      bool flag9;
      if (flag5)
        flag9 = flag4 = false;
      if (flag6)
        flag9 = flag3 = false;
      bool flag10;
      if (flag7)
        flag10 = flag4 = false;
      if (flag8)
        flag10 = flag3 = false;
      bool flag11 = false;
      if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].active() && Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].type == (ushort) 314)
        flag11 = true;
      if (!flag11)
      {
        for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
        {
          for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
          {
            Tile tile = Main.tile[reachableStartX, reachableStartY];
            if (tile.active() && tile.type == (ushort) 314)
            {
              bool flag12 = Main.tile[reachableStartX + 1, reachableStartY + 1].active() && Main.tile[reachableStartX + 1, reachableStartY + 1].type == (ushort) 314;
              bool flag13 = Main.tile[reachableStartX + 1, reachableStartY - 1].active() && Main.tile[reachableStartX + 1, reachableStartY - 1].type == (ushort) 314;
              bool flag14 = Main.tile[reachableStartX - 1, reachableStartY + 1].active() && Main.tile[reachableStartX - 1, reachableStartY + 1].type == (ushort) 314;
              bool flag15 = Main.tile[reachableStartX - 1, reachableStartY - 1].active() && Main.tile[reachableStartX - 1, reachableStartY - 1].type == (ushort) 314;
              if (flag5 && (!Main.tile[reachableStartX - 1, reachableStartY - 1].active() || Main.tileCut[(int) Main.tile[reachableStartX - 1, reachableStartY - 1].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX - 1, reachableStartY - 1].type]) && !(!flag12 & flag13) && !flag14)
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY - 1));
              if (flag4 && (!Main.tile[reachableStartX - 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX - 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX - 1, reachableStartY].type]))
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (flag7 && (!Main.tile[reachableStartX - 1, reachableStartY + 1].active() || Main.tileCut[(int) Main.tile[reachableStartX - 1, reachableStartY + 1].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX - 1, reachableStartY + 1].type]) && !(!flag13 & flag12) && !flag15)
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY + 1));
              if (flag6 && (!Main.tile[reachableStartX + 1, reachableStartY - 1].active() || Main.tileCut[(int) Main.tile[reachableStartX + 1, reachableStartY - 1].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX + 1, reachableStartY - 1].type]) && !(!flag14 & flag15) && !flag12)
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY - 1));
              if (flag3 && (!Main.tile[reachableStartX + 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX + 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX + 1, reachableStartY].type]))
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (flag8 && (!Main.tile[reachableStartX + 1, reachableStartY + 1].active() || Main.tileCut[(int) Main.tile[reachableStartX + 1, reachableStartY + 1].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX + 1, reachableStartY + 1].type]) && !(!flag15 & flag14) && !flag13)
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY + 1));
            }
          }
        }
      }
      if (SmartCursorHelper._targets.Count > 0)
      {
        float num3 = -1f;
        Point target = SmartCursorHelper._targets[0];
        for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
        {
          if ((!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y - 1].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y - 1].type != (ushort) 314) && (!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y + 1].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y + 1].type != (ushort) 314))
          {
            float num4 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
            if ((double) num3 == -1.0 || (double) num4 < (double) num3)
            {
              num3 = num4;
              target = SmartCursorHelper._targets[index];
            }
          }
        }
        if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY) && (double) num3 != -1.0)
        {
          focusedX = target.X;
          focusedY = target.Y;
        }
      }
      SmartCursorHelper._targets.Clear();
    }
    if (providedInfo.item.type != 2492 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag = false;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].active() && Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].type == (ushort) 314)
      flag = true;
    if (!flag)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (tile.active() && tile.type == (ushort) 314)
          {
            if (!Main.tile[reachableStartX - 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX - 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX - 1, reachableStartY].type])
              SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
            if (!Main.tile[reachableStartX + 1, reachableStartY].active() || Main.tileCut[(int) Main.tile[reachableStartX + 1, reachableStartY].type] || TileID.Sets.BreakableWhenPlacing[(int) Main.tile[reachableStartX + 1, reachableStartY].type])
              SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num5 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        if ((!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y - 1].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y - 1].type != (ushort) 314) && (!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y + 1].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y + 1].type != (ushort) 314))
        {
          float num6 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
          if ((double) num5 == -1.0 || (double) num6 < (double) num5)
          {
            num5 = num6;
            target = SmartCursorHelper._targets[index];
          }
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY) && (double) num5 != -1.0)
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Platforms(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.createTile < 0 || !TileID.Sets.Platforms[providedInfo.item.createTile] || focusedX != -1 || focusedY != -1 || SmartCursorHelper.IsPlatform(providedInfo.screenTargetX, providedInfo.screenTargetY))
      return;
    SmartCursorHelper._targets.Clear();
    SmartCursorHelper._points.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Point desiredDirectionFrom = SmartCursorHelper.GetDesiredDirectionFrom(providedInfo.mouse - new Point(reachableStartX, reachableStartY).ToWorldCoordinates());
        bool flag = !SmartCursorHelper.IsPlatform(reachableStartX, reachableStartY);
        if (flag && desiredDirectionFrom.Y == 0 && Main.tile[reachableStartX, reachableStartY].active() && !WorldGen.SolidTile(reachableStartX, reachableStartY) && (SmartCursorHelper.IsPlatform(reachableStartX - 1, reachableStartY) || SmartCursorHelper.IsPlatform(reachableStartX + 1, reachableStartY)))
          flag = false;
        if (!flag)
        {
          int num = desiredDirectionFrom.X == desiredDirectionFrom.Y ? 2 : (desiredDirectionFrom.X == -desiredDirectionFrom.Y ? 1 : 0);
          if ((num == 0 || (int) Main.tile[reachableStartX, reachableStartY].slope() != num) && (desiredDirectionFrom.X != 0 || !SmartCursorHelper.IsPlatform(reachableStartX - 1, reachableStartY + desiredDirectionFrom.Y) && !SmartCursorHelper.IsPlatform(reachableStartX + 1, reachableStartY + desiredDirectionFrom.Y)))
          {
            Tile tile = Main.tile[reachableStartX + desiredDirectionFrom.X, reachableStartY + desiredDirectionFrom.Y];
            if ((!tile.active() || Main.tileCut[(int) tile.type]) && SmartCursorHelper.AllowedForContinuity(reachableStartX + desiredDirectionFrom.X, reachableStartY + desiredDirectionFrom.Y, 2))
            {
              SmartCursorHelper._targets.Add(new Point(reachableStartX + desiredDirectionFrom.X, reachableStartY + desiredDirectionFrom.Y));
              SmartCursorHelper._points.Add(new Point(desiredDirectionFrom.X, desiredDirectionFrom.Y));
            }
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      float num2 = -1f;
      Point point1 = SmartCursorHelper._targets[0];
      Point point2 = SmartCursorHelper._points[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        Point target = SmartCursorHelper._targets[index];
        Point point3 = SmartCursorHelper._points[index];
        Vector2 vector2 = providedInfo.mouse - SmartCursorHelper._targets[index].ToWorldCoordinates();
        float num3 = vector2.Length();
        float num4 = Vector2.Dot(vector2, point3.ToVector2());
        if ((double) num1 == -1.0 || (double) num3 < (double) num1 || (double) num3 == (double) num1 && (double) num4 > (double) num2)
        {
          num1 = num3;
          num2 = num4;
          point1 = target;
          point2 = point3;
        }
      }
      if (Collision.InTileBounds(point1.X, point1.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = point1.X;
        focusedY = point1.Y;
        SmartCursorHelper._lockedDesiredDirection = new Point?(new Point(point2.X, point2.Y));
        SmartCursorHelper._lockedContinuityCoords = new Point?(new Point(focusedX, focusedY));
      }
    }
    SmartCursorHelper._targets.Clear();
    SmartCursorHelper._points.Clear();
  }

  public static Point? LockedDesiredDirection => SmartCursorHelper._lockedDesiredDirection;

  public static bool TileTargetDesired()
  {
    if (!SmartCursorHelper._lockedContinuityCoords.HasValue)
      return true;
    return Main.SmartCursorShowing && Player.tileTargetX == Main.SmartCursorX && Player.tileTargetY == Main.SmartCursorY;
  }

  private static bool AllowedForContinuity(int x, int y, int skipsAllowed)
  {
    if (!SmartCursorHelper._lockedContinuityCoords.HasValue)
      return true;
    Point point = SmartCursorHelper._lockedContinuityCoords.Value;
    if (x == point.X && y == point.Y)
      return true;
    if (!SmartCursorHelper._lockedDesiredDirection.HasValue)
      return false;
    for (int index = 0; index < skipsAllowed; ++index)
    {
      point.X += SmartCursorHelper._lockedDesiredDirection.Value.X;
      point.Y += SmartCursorHelper._lockedDesiredDirection.Value.Y;
      if (x == point.X && y == point.Y)
        return true;
    }
    return false;
  }

  private static Point GetDesiredDirectionFrom(Vector2 offset)
  {
    if (SmartCursorHelper._lockedDesiredDirection.HasValue)
      return SmartCursorHelper._lockedDesiredDirection.Value;
    float rotation = offset.ToRotation();
    if ((double) rotation < 0.0)
      rotation += 6.28318548f;
    float num = 0.7853982f;
    return (((float) (int) (((double) rotation + (double) num / 2.0) % 6.2831854820251465 / (double) num) * num).ToRotationVector2() * 1.5f).ToPoint();
  }

  private static bool IsPlatform(int x, int y)
  {
    return Main.tile[x, y].active() && TileID.Sets.Platforms[(int) Main.tile[x, y].type];
  }

  private static void Step_WireCutter(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 510 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if (tile.wire() || tile.wire2() || tile.wire3() || tile.wire4() || tile.actuator())
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_ActuationRod(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    bool actuationRodLock = providedInfo.player.ActuationRodLock;
    bool actuationRodLockSetting = providedInfo.player.ActuationRodLockSetting;
    if (providedInfo.item.type != 3620 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile = Main.tile[reachableStartX, reachableStartY];
        if (tile.active() && tile.actuator() && (!actuationRodLock || actuationRodLockSetting == tile.inActive()))
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Hammers(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    int width = providedInfo.player.width;
    int height = providedInfo.player.height;
    if (providedInfo.item.hammer > 0 && focusedX == -1 && focusedY == -1)
    {
      Vector2 vector2 = providedInfo.mouse - providedInfo.Center;
      int num1 = Math.Sign(vector2.X);
      int num2 = Math.Sign(vector2.Y);
      if ((double) Math.Abs(vector2.X) > (double) Math.Abs(vector2.Y) * 3.0)
      {
        num2 = 0;
        providedInfo.mouse.Y = providedInfo.Center.Y;
      }
      if ((double) Math.Abs(vector2.Y) > (double) Math.Abs(vector2.X) * 3.0)
      {
        num1 = 0;
        providedInfo.mouse.X = providedInfo.Center.X;
      }
      int num3 = (int) providedInfo.Center.X / 16 /*0x10*/;
      int num4 = (int) providedInfo.Center.Y / 16 /*0x10*/;
      SmartCursorHelper._points.Clear();
      SmartCursorHelper._endpoints.Clear();
      int num5 = 1;
      if (num2 == -1 && num1 != 0)
        num5 = -1;
      int x1 = (int) (((double) providedInfo.position.X + (double) (width / 2) + (double) ((width / 2 - 1) * num1)) / 16.0);
      int y1 = (int) (((double) providedInfo.position.Y + 0.1) / 16.0);
      if (num5 == -1)
        y1 = (int) (((double) providedInfo.position.Y + (double) height - 1.0) / 16.0);
      int num6 = width / 16 /*0x10*/ + (width % 16 /*0x10*/ == 0 ? 0 : 1);
      int num7 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
      if (num1 != 0)
      {
        for (int index = 0; index < num7; ++index)
        {
          if (Main.tile[x1, y1 + index * num5] != null)
            SmartCursorHelper._points.Add(new Point(x1, y1 + index * num5));
        }
      }
      if (num2 != 0)
      {
        for (int index = 0; index < num6; ++index)
        {
          if (Main.tile[(int) ((double) providedInfo.position.X / 16.0) + index, y1] != null)
            SmartCursorHelper._points.Add(new Point((int) ((double) providedInfo.position.X / 16.0) + index, y1));
        }
      }
      int x2 = (int) (((double) providedInfo.mouse.X + (double) ((width / 2 - 1) * num1)) / 16.0);
      int y2 = (int) (((double) providedInfo.mouse.Y + 0.1 - (double) (height / 2 + 1)) / 16.0);
      if (num5 == -1)
        y2 = (int) (((double) providedInfo.mouse.Y + (double) (height / 2) - 1.0) / 16.0);
      if ((double) providedInfo.player.gravDir == -1.0 && num2 == 0)
        ++y2;
      if (y2 < 10)
        y2 = 10;
      if (y2 > Main.maxTilesY - 10)
        y2 = Main.maxTilesY - 10;
      int num8 = width / 16 /*0x10*/ + (width % 16 /*0x10*/ == 0 ? 0 : 1);
      int num9 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
      if (num1 != 0)
      {
        for (int index = 0; index < num9; ++index)
        {
          if (Main.tile[x2, y2 + index * num5] != null)
            SmartCursorHelper._endpoints.Add(new Point(x2, y2 + index * num5));
        }
      }
      if (num2 != 0)
      {
        for (int index = 0; index < num8; ++index)
        {
          if (Main.tile[(int) (((double) providedInfo.mouse.X - (double) (width / 2)) / 16.0) + index, y2] != null)
            SmartCursorHelper._endpoints.Add(new Point((int) (((double) providedInfo.mouse.X - (double) (width / 2)) / 16.0) + index, y2));
        }
      }
      SmartCursorHelper._targets.Clear();
      while (SmartCursorHelper._points.Count > 0)
      {
        Point point1 = SmartCursorHelper._points[0];
        Point endpoint = SmartCursorHelper._endpoints[0];
        Point point2 = Collision.HitLineWall(point1.X, point1.Y, endpoint.X, endpoint.Y);
        if (point2.X == -1 || point2.Y == -1)
        {
          SmartCursorHelper._points.Remove(point1);
          SmartCursorHelper._endpoints.Remove(endpoint);
        }
        else
        {
          if (point2.X != endpoint.X || point2.Y != endpoint.Y)
            SmartCursorHelper._targets.Add(point2);
          Tile tile = Main.tile[point2.X, point2.Y];
          if (Collision.HitWallSubstep(point2.X, point2.Y))
            SmartCursorHelper._targets.Add(point2);
          SmartCursorHelper._points.Remove(point1);
          SmartCursorHelper._endpoints.Remove(endpoint);
        }
      }
      if (SmartCursorHelper._targets.Count > 0)
      {
        float num10 = -1f;
        Point point = new Point(-1, -1);
        for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
        {
          if (!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y].type != (ushort) 26)
          {
            float num11 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.Center);
            if ((double) num10 == -1.0 || (double) num11 < (double) num10)
            {
              num10 = num11;
              point = SmartCursorHelper._targets[index];
            }
          }
        }
        if (point.X != -1 && Collision.InTileBounds(point.X, point.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
        {
          providedInfo.player.poundRelease = false;
          focusedX = point.X;
          focusedY = point.Y;
        }
      }
      SmartCursorHelper._targets.Clear();
      SmartCursorHelper._points.Clear();
      SmartCursorHelper._endpoints.Clear();
    }
    if (providedInfo.item.hammer <= 0 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        if (Main.tile[reachableStartX, reachableStartY].wall > (ushort) 0 && Collision.HitWallSubstep(reachableStartX, reachableStartY))
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num12 = -1f;
      Point point = new Point(-1, -1);
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        if (!Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y].active() || Main.tile[SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y].type != (ushort) 26)
        {
          float num13 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
          if ((double) num12 == -1.0 || (double) num13 < (double) num12)
          {
            num12 = num13;
            point = SmartCursorHelper._targets[index];
          }
        }
      }
      if (point.X != -1 && Collision.InTileBounds(point.X, point.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        providedInfo.player.poundRelease = false;
        focusedX = point.X;
        focusedY = point.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_MulticolorWrench(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 3625 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    WiresUI.Settings.MultiToolMode toolMode1 = WiresUI.Settings.ToolMode;
    WiresUI.Settings.MultiToolMode multiToolMode = (WiresUI.Settings.MultiToolMode) 0;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire())
      multiToolMode |= WiresUI.Settings.MultiToolMode.Red;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire2())
      multiToolMode |= WiresUI.Settings.MultiToolMode.Blue;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire3())
      multiToolMode |= WiresUI.Settings.MultiToolMode.Green;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire4())
      multiToolMode |= WiresUI.Settings.MultiToolMode.Yellow;
    int num1 = (toolMode1 & ~WiresUI.Settings.MultiToolMode.Cutter) == multiToolMode ? 1 : 0;
    WiresUI.Settings.MultiToolMode toolMode2 = WiresUI.Settings.ToolMode;
    if (num1 == 0)
    {
      bool flag1 = (toolMode2 & WiresUI.Settings.MultiToolMode.Red) != 0;
      bool flag2 = (toolMode2 & WiresUI.Settings.MultiToolMode.Blue) != 0;
      bool flag3 = (toolMode2 & WiresUI.Settings.MultiToolMode.Green) != 0;
      bool flag4 = (toolMode2 & WiresUI.Settings.MultiToolMode.Yellow) != 0;
      bool flag5 = (toolMode2 & WiresUI.Settings.MultiToolMode.Cutter) != 0;
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (flag5)
          {
            if (tile.wire() & flag1 || tile.wire2() & flag2 || tile.wire3() & flag3 || tile.wire4() & flag4)
              SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
          }
          else if (tile.wire() & flag1 || tile.wire2() & flag2 || tile.wire3() & flag3 || tile.wire4() & flag4)
          {
            if (flag1)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (flag2)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (flag3)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (flag4)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num2 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num3 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num2 == -1.0 || (double) num3 < (double) num2)
        {
          num2 = num3;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_ColoredWrenches(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    if (providedInfo.item.type != 509 && providedInfo.item.type != 850 && providedInfo.item.type != 851 && providedInfo.item.type != 3612 || focusedX != -1 || focusedY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    int num1 = 0;
    if (providedInfo.item.type == 509)
      num1 = 1;
    if (providedInfo.item.type == 850)
      num1 = 2;
    if (providedInfo.item.type == 851)
      num1 = 3;
    if (providedInfo.item.type == 3612)
      num1 = 4;
    bool flag = false;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire() && num1 == 1)
      flag = true;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire2() && num1 == 2)
      flag = true;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire3() && num1 == 3)
      flag = true;
    if (Main.tile[providedInfo.screenTargetX, providedInfo.screenTargetY].wire4() && num1 == 4)
      flag = true;
    if (!flag)
    {
      for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
      {
        for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
        {
          Tile tile = Main.tile[reachableStartX, reachableStartY];
          if (tile.wire() && num1 == 1 || tile.wire2() && num1 == 2 || tile.wire3() && num1 == 3 || tile.wire4() && num1 == 4)
          {
            if (num1 == 1)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (num1 == 2)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire2())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (num1 == 3)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire3())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
            if (num1 == 4)
            {
              if (!Main.tile[reachableStartX - 1, reachableStartY].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX - 1, reachableStartY));
              if (!Main.tile[reachableStartX + 1, reachableStartY].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX + 1, reachableStartY));
              if (!Main.tile[reachableStartX, reachableStartY - 1].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY - 1));
              if (!Main.tile[reachableStartX, reachableStartY + 1].wire4())
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY + 1));
            }
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num2 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num3 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num2 == -1.0 || (double) num3 < (double) num2)
        {
          num2 = num3;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Acorns(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    int num1 = 9;
    int num2 = 14;
    int num3 = 20;
    if (providedInfo.item.type != 27 || focusedX != -1 || focusedY != -1 || providedInfo.reachableStartY <= 20)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile1 = Main.tile[reachableStartX, reachableStartY];
        Tile tile2 = Main.tile[reachableStartX, reachableStartY - 1];
        Tile testTile = Main.tile[reachableStartX, reachableStartY + 1];
        Tile tile3 = Main.tile[reachableStartX - 1, reachableStartY];
        Tile tile4 = Main.tile[reachableStartX + 1, reachableStartY];
        Tile tile5 = Main.tile[reachableStartX - 2, reachableStartY];
        Tile tile6 = Main.tile[reachableStartX + 2, reachableStartY];
        Tile tile7 = Main.tile[reachableStartX - 3, reachableStartY];
        Tile tile8 = Main.tile[reachableStartX + 3, reachableStartY];
        if ((!tile1.active() || Main.tileCut[(int) tile1.type] || TileID.Sets.BreakableWhenPlacing[(int) tile1.type]) && (!tile2.active() || Main.tileCut[(int) tile2.type] || TileID.Sets.BreakableWhenPlacing[(int) tile2.type]) && testTile.active() && WorldGen.SolidTile2(testTile))
        {
          bool flag1 = tile3.active() && TileID.Sets.CommonSapling[(int) tile3.type] || tile4.active() && TileID.Sets.CommonSapling[(int) tile4.type];
          bool flag2 = flag1 || tile5.active() && TileID.Sets.CommonSapling[(int) tile5.type] || tile6.active() && TileID.Sets.CommonSapling[(int) tile6.type] || tile7.active() && TileID.Sets.CommonSapling[(int) tile7.type] || tile8.active() && TileID.Sets.CommonSapling[(int) tile8.type];
          switch (testTile.type)
          {
            case 2:
            case 23:
            case 109:
            case 147:
            case 199:
            case 477:
            case 492:
            case 633:
            case 661:
            case 662:
              if (!flag2 && tile3.liquid == (byte) 0 && tile1.liquid == (byte) 0 && tile4.liquid == (byte) 0 && WorldGen.EmptyTileCheck(reachableStartX - 2, reachableStartX + 2, reachableStartY - num1 + 1, reachableStartY, 20))
              {
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
                continue;
              }
              continue;
            case 53:
            case 112 /*0x70*/:
            case 116:
            case 234:
              if (!flag1 && tile1.liquid == (byte) 0 && WorldGen.EmptyTileCheck(reachableStartX, reachableStartX, reachableStartY - num3, reachableStartY, 20))
              {
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
                continue;
              }
              continue;
            case 60:
              if (!flag2 && WorldGen.EmptyTileCheck(reachableStartX - 2, reachableStartX + 2, reachableStartY - num2 + 1, reachableStartY, 20))
              {
                SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
    }
    SmartCursorHelper._toRemove.Clear();
    for (int index1 = 0; index1 < SmartCursorHelper._targets.Count; ++index1)
    {
      bool flag = false;
      for (int index2 = -1; index2 < 2; index2 += 2)
      {
        Tile tile = Main.tile[SmartCursorHelper._targets[index1].X + index2, SmartCursorHelper._targets[index1].Y + 1];
        if (tile.active())
        {
          switch (tile.type)
          {
            case 2:
            case 23:
            case 53:
            case 60:
            case 109:
            case 112 /*0x70*/:
            case 116:
            case 147:
            case 199:
            case 234:
            case 477:
            case 492:
            case 633:
            case 661:
            case 662:
              flag = true;
              continue;
            default:
              continue;
          }
        }
      }
      if (!flag)
        SmartCursorHelper._toRemove.Add(SmartCursorHelper._targets[index1]);
    }
    for (int index = 0; index < SmartCursorHelper._toRemove.Count; ++index)
      SmartCursorHelper._targets.Remove(SmartCursorHelper._toRemove[index]);
    SmartCursorHelper._toRemove.Clear();
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num4 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num5 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num4 == -1.0 || (double) num5 < (double) num4)
        {
          num4 = num5;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_GemCorns(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int focusedX,
    ref int focusedY)
  {
    WorldGen.GrowTreeSettings profile;
    if (!WorldGen.GrowTreeSettings.Profiles.TryGetFromItemId(providedInfo.item.type, out profile) || focusedX != -1 || focusedY != -1 || providedInfo.reachableStartY <= 20)
      return;
    SmartCursorHelper._targets.Clear();
    for (int reachableStartX = providedInfo.reachableStartX; reachableStartX <= providedInfo.reachableEndX; ++reachableStartX)
    {
      for (int reachableStartY = providedInfo.reachableStartY; reachableStartY <= providedInfo.reachableEndY; ++reachableStartY)
      {
        Tile tile1 = Main.tile[reachableStartX, reachableStartY];
        Tile tile2 = Main.tile[reachableStartX, reachableStartY - 1];
        Tile testTile = Main.tile[reachableStartX, reachableStartY + 1];
        Tile tile3 = Main.tile[reachableStartX - 1, reachableStartY];
        Tile tile4 = Main.tile[reachableStartX + 1, reachableStartY];
        Tile tile5 = Main.tile[reachableStartX - 2, reachableStartY];
        Tile tile6 = Main.tile[reachableStartX + 2, reachableStartY];
        Tile tile7 = Main.tile[reachableStartX - 3, reachableStartY];
        Tile tile8 = Main.tile[reachableStartX + 3, reachableStartY];
        if (profile.GroundTest((int) testTile.type) && (!tile1.active() || Main.tileCut[(int) tile1.type] || TileID.Sets.BreakableWhenPlacing[(int) tile1.type]) && (!tile2.active() || Main.tileCut[(int) tile2.type] || TileID.Sets.BreakableWhenPlacing[(int) tile2.type]) && (!tile3.active() || !TileID.Sets.CommonSapling[(int) tile3.type]) && (!tile4.active() || !TileID.Sets.CommonSapling[(int) tile4.type]) && (!tile5.active() || !TileID.Sets.CommonSapling[(int) tile5.type]) && (!tile6.active() || !TileID.Sets.CommonSapling[(int) tile6.type]) && (!tile7.active() || !TileID.Sets.CommonSapling[(int) tile7.type]) && (!tile8.active() || !TileID.Sets.CommonSapling[(int) tile8.type]) && testTile.active() && WorldGen.SolidTile2(testTile) && tile3.liquid == (byte) 0 && tile1.liquid == (byte) 0 && tile4.liquid == (byte) 0 && WorldGen.EmptyTileCheck(reachableStartX - 2, reachableStartX + 2, reachableStartY - profile.TreeHeightMax, reachableStartY, (int) profile.SaplingTileType))
          SmartCursorHelper._targets.Add(new Point(reachableStartX, reachableStartY));
      }
    }
    SmartCursorHelper._toRemove.Clear();
    for (int index1 = 0; index1 < SmartCursorHelper._targets.Count; ++index1)
    {
      bool flag = false;
      for (int index2 = -1; index2 < 2; index2 += 2)
      {
        Tile tile = Main.tile[SmartCursorHelper._targets[index1].X + index2, SmartCursorHelper._targets[index1].Y + 1];
        if (tile.active() && profile.GroundTest((int) tile.type))
          flag = true;
      }
      if (!flag)
        SmartCursorHelper._toRemove.Add(SmartCursorHelper._targets[index1]);
    }
    for (int index = 0; index < SmartCursorHelper._toRemove.Count; ++index)
      SmartCursorHelper._targets.Remove(SmartCursorHelper._toRemove[index]);
    SmartCursorHelper._toRemove.Clear();
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_ForceCursorToAnyMinableThing(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    Vector2 mouse = providedInfo.mouse;
    Item obj = providedInfo.item;
    if (fX != -1 || fY != -1 || PlayerInput.UsingGamepad)
      return;
    Point tileCoordinates = mouse.ToTileCoordinates();
    int x = tileCoordinates.X;
    int y = tileCoordinates.Y;
    if (!Collision.InTileBounds(x, y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
      return;
    Tile tile = Main.tile[x, y];
    bool flag = tile.active() && WorldGen.CanKillTile(x, y) && (!Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type]);
    if (flag && Main.tileAxe[(int) tile.type] && obj.axe < 1)
      flag = false;
    if (flag && Main.tileHammer[(int) tile.type] && obj.hammer < 1)
      flag = false;
    if (flag && !Main.tileHammer[(int) tile.type] && !Main.tileAxe[(int) tile.type] && obj.pick < 1)
      flag = false;
    if (!flag)
      return;
    fX = x;
    fY = y;
  }

  public static void Step_Pickaxe_MineShinies(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    Item obj = providedInfo.item;
    Vector2 mouse = providedInfo.mouse;
    if (obj.pick <= 0 || fX != -1 || fY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    int num1 = obj.type == 1333 || obj.type == 523 ? 0 : (obj.type != 4384 ? 1 : 0);
    int num2 = 0;
    for (int x = reachableStartX; x <= reachableEndX; ++x)
    {
      for (int y = reachableStartY; y <= reachableEndY; ++y)
      {
        Tile tile1 = Main.tile[x, y];
        Tile tile2 = Main.tile[x - 1, y];
        Tile tile3 = Main.tile[x + 1, y];
        Tile tile4 = Main.tile[x, y + 1];
        if (tile1.active())
        {
          int num3;
          int num4 = num3 = TileID.Sets.SmartCursorPickaxePriorityOverride[(int) tile1.type];
          if (num4 > 0)
          {
            if (num2 < num4)
              num2 = num4;
            SmartCursorHelper._targets.Add(new Point(x, y));
          }
        }
      }
    }
    SmartCursorHelper._targets2.Clear();
    foreach (Point point in SmartCursorHelper._targets2)
    {
      Tile tile = Main.tile[point.X, point.Y];
      if (TileID.Sets.SmartCursorPickaxePriorityOverride[(int) tile.type] < num2)
        SmartCursorHelper._targets2.Add(point);
    }
    foreach (Point point in SmartCursorHelper._targets2)
      SmartCursorHelper._targets.Remove(point);
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num5 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num6 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, mouse);
        if ((double) num5 == -1.0 || (double) num6 < (double) num5)
        {
          num5 = num6;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
      {
        fX = target.X;
        fY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  public static void Step_Pickaxe_MineSolids(
    Player player,
    Vector2 position,
    Vector2 Center,
    int width,
    int direction,
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    List<Point> grappleTargets,
    ref int focusedX,
    ref int focusedY)
  {
    int height = player.height;
    float gravDir = player.gravDir;
    int whoAmI = player.whoAmI;
    if (providedInfo.item.pick <= 0 || focusedX != -1 || focusedY != -1)
      return;
    if (PlayerInput.UsingGamepad)
    {
      Vector2 navigatorDirections = PlayerInput.Triggers.Current.GetNavigatorDirections();
      Vector2 gamepadThumbstickLeft = PlayerInput.GamepadThumbstickLeft;
      Vector2 gamepadThumbstickRight = PlayerInput.GamepadThumbstickRight;
      Vector2 zero = Vector2.Zero;
      if (navigatorDirections == zero && (double) gamepadThumbstickLeft.Length() < 0.05000000074505806 && (double) gamepadThumbstickRight.Length() < 0.05000000074505806)
        providedInfo.mouse = Center + new Vector2((float) (direction * 1000), 0.0f);
    }
    Vector2 vector2_1 = providedInfo.mouse - Center;
    int num1 = Math.Sign(vector2_1.X);
    int num2 = Math.Sign(vector2_1.Y);
    if ((double) Math.Abs(vector2_1.X) > (double) Math.Abs(vector2_1.Y) * 3.0)
    {
      num2 = 0;
      providedInfo.mouse.Y = Center.Y;
    }
    if ((double) Math.Abs(vector2_1.Y) > (double) Math.Abs(vector2_1.X) * 3.0)
    {
      num1 = 0;
      providedInfo.mouse.X = Center.X;
    }
    int num3 = (int) Center.X / 16 /*0x10*/;
    int num4 = (int) Center.Y / 16 /*0x10*/;
    SmartCursorHelper._points.Clear();
    SmartCursorHelper._endpoints.Clear();
    int num5 = 1;
    if (num2 == -1 && num1 != 0)
      num5 = -1;
    int x1 = (int) (((double) position.X + (double) (width / 2) + (double) ((width / 2 - 1) * num1)) / 16.0);
    int y1 = (int) (((double) position.Y + 0.1) / 16.0);
    if (num5 == -1)
      y1 = (int) (((double) position.Y + (double) height - 1.0) / 16.0);
    int num6 = width / 16 /*0x10*/ + (width % 16 /*0x10*/ == 0 ? 0 : 1);
    int num7 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
    if (num1 != 0)
    {
      for (int index = 0; index < num7; ++index)
      {
        if (Main.tile[x1, y1 + index * num5] != null)
          SmartCursorHelper._points.Add(new Point(x1, y1 + index * num5));
      }
    }
    if (num2 != 0)
    {
      for (int index = 0; index < num6; ++index)
      {
        if (Main.tile[(int) ((double) position.X / 16.0) + index, y1] != null)
          SmartCursorHelper._points.Add(new Point((int) ((double) position.X / 16.0) + index, y1));
      }
    }
    int x2 = (int) (((double) providedInfo.mouse.X + (double) ((width / 2 - 1) * num1)) / 16.0);
    int y2 = (int) (((double) providedInfo.mouse.Y + 0.1 - (double) (height / 2 + 1)) / 16.0);
    if (num5 == -1)
      y2 = (int) (((double) providedInfo.mouse.Y + (double) (height / 2) - 1.0) / 16.0);
    if ((double) gravDir == -1.0 && num2 == 0)
      ++y2;
    if ((double) gravDir == 1.0 && num1 == 0)
      ++y2;
    if (y2 < 10)
      y2 = 10;
    if (y2 > Main.maxTilesY - 10)
      y2 = Main.maxTilesY - 10;
    int num8 = width / 16 /*0x10*/ + (width % 16 /*0x10*/ == 0 ? 0 : 1);
    int num9 = height / 16 /*0x10*/ + (height % 16 /*0x10*/ == 0 ? 0 : 1);
    if (WorldGen.InWorld(x2, y2, 40))
    {
      if (num1 != 0)
      {
        for (int index = 0; index < num9; ++index)
        {
          if (Main.tile[x2, y2 + index * num5] != null)
            SmartCursorHelper._endpoints.Add(new Point(x2, y2 + index * num5));
        }
      }
      if (num2 != 0)
      {
        for (int index = 0; index < num8; ++index)
        {
          if (Main.tile[(int) (((double) providedInfo.mouse.X - (double) (width / 2)) / 16.0) + index, y2] != null)
            SmartCursorHelper._endpoints.Add(new Point((int) (((double) providedInfo.mouse.X - (double) (width / 2)) / 16.0) + index, y2));
        }
      }
    }
    SmartCursorHelper._targets.Clear();
    while (SmartCursorHelper._points.Count > 0 && SmartCursorHelper._endpoints.Count > 0)
    {
      Point point = SmartCursorHelper._points[0];
      Point endpoint = SmartCursorHelper._endpoints[0];
      Point col;
      if (!Collision.HitLine(point.X, point.Y, endpoint.X, endpoint.Y, num1 * (int) gravDir, -num2 * (int) gravDir, grappleTargets, out col))
      {
        SmartCursorHelper._points.Remove(point);
        SmartCursorHelper._endpoints.Remove(endpoint);
      }
      else
      {
        if (col.X != endpoint.X || col.Y != endpoint.Y)
          SmartCursorHelper._targets.Add(col);
        Tile tile = Main.tile[col.X, col.Y];
        if (!tile.inActive() && tile.active() && Main.tileSolid[(int) tile.type] && !Main.tileSolidTop[(int) tile.type] && !grappleTargets.Contains(col))
          SmartCursorHelper._targets.Add(col);
        SmartCursorHelper._points.Remove(point);
        SmartCursorHelper._endpoints.Remove(endpoint);
      }
    }
    SmartCursorHelper._toRemove.Clear();
    for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
    {
      if (!WorldGen.CanKillTile(SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y))
        SmartCursorHelper._toRemove.Add(SmartCursorHelper._targets[index]);
    }
    for (int index = 0; index < SmartCursorHelper._toRemove.Count; ++index)
      SmartCursorHelper._targets.Remove(SmartCursorHelper._toRemove[index]);
    SmartCursorHelper._toRemove.Clear();
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num10 = -1f;
      Point target = SmartCursorHelper._targets[0];
      Vector2 vector2_2 = Center;
      if (Main.netMode == 1)
      {
        int num11 = 0;
        int num12 = 0;
        int num13 = 0;
        for (int index = 0; index < whoAmI; ++index)
        {
          Player player1 = Main.player[index];
          if (player1.active && !player1.dead && player1.HeldItem.pick > 0 && player1.itemAnimation > 0)
          {
            if ((double) player.Distance(player1.Center) <= 8.0)
              ++num11;
            if ((double) player.Distance(player1.Center) <= 80.0 && (double) Math.Abs(player1.Center.Y - Center.Y) <= 12.0)
              ++num12;
          }
        }
        for (int index = whoAmI + 1; index < (int) byte.MaxValue; ++index)
        {
          Player player2 = Main.player[index];
          if (player2.active && !player2.dead && player2.HeldItem.pick > 0 && player2.itemAnimation > 0 && (double) player.Distance(player2.Center) <= 8.0)
            ++num13;
        }
        if (num11 > 0)
        {
          if (num11 % 2 == 1)
            vector2_2.X += 12f;
          else
            vector2_2.X -= 12f;
          if (num12 % 2 == 1)
            vector2_2.Y -= 12f;
        }
        if (num13 > 0 && num11 == 0)
        {
          if (num13 % 2 == 1)
            vector2_2.X -= 12f;
          else
            vector2_2.X += 12f;
        }
      }
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num14 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, vector2_2);
        if ((double) num10 == -1.0 || (double) num14 < (double) num10)
        {
          num10 = num14;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, providedInfo.reachableStartX, providedInfo.reachableStartY, providedInfo.reachableEndX, providedInfo.reachableEndY))
      {
        focusedX = target.X;
        focusedY = target.Y;
      }
    }
    SmartCursorHelper._points.Clear();
    SmartCursorHelper._endpoints.Clear();
    SmartCursorHelper._targets.Clear();
  }

  public static void Step_Axe(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    if (providedInfo.item.axe <= 0 || fX != -1 || fY != -1)
      return;
    float num1 = -1f;
    for (int index1 = reachableStartX; index1 <= reachableEndX; ++index1)
    {
      for (int index2 = reachableStartY; index2 <= reachableEndY; ++index2)
      {
        if (Main.tile[index1, index2].active())
        {
          Tile tile = Main.tile[index1, index2];
          if (Main.tileAxe[(int) tile.type] && !TileID.Sets.IgnoreSmartCursorPriorityAxe[(int) tile.type])
          {
            int x = index1;
            int y = index2;
            int type = (int) tile.type;
            if (TileID.Sets.IsATreeTrunk[type])
            {
              if (Collision.InTileBounds(x + 1, y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
              {
                if (Main.tile[x, y].frameY >= (short) 198 && Main.tile[x, y].frameX == (short) 44)
                  ++x;
                if (Main.tile[x, y].frameX == (short) 66 && Main.tile[x, y].frameY <= (short) 44)
                  ++x;
                if (Main.tile[x, y].frameX == (short) 44 && Main.tile[x, y].frameY >= (short) 132 && Main.tile[x, y].frameY <= (short) 176 /*0xB0*/)
                  ++x;
              }
              if (Collision.InTileBounds(x - 1, y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
              {
                if (Main.tile[x, y].frameY >= (short) 198 && Main.tile[x, y].frameX == (short) 66)
                  --x;
                if (Main.tile[x, y].frameX == (short) 88 && Main.tile[x, y].frameY >= (short) 66 && Main.tile[x, y].frameY <= (short) 110)
                  --x;
                if (Main.tile[x, y].frameX == (short) 22 && Main.tile[x, y].frameY >= (short) 132 && Main.tile[x, y].frameY <= (short) 176 /*0xB0*/)
                  --x;
              }
              while (Main.tile[x, y].active() && (int) Main.tile[x, y].type == type && (int) Main.tile[x, y + 1].type == type && Collision.InTileBounds(x, y + 1, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
                ++y;
            }
            if (tile.type == (ushort) 80 /*0x50*/)
            {
              if (Collision.InTileBounds(x + 1, y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
              {
                if (Main.tile[x, y].frameX == (short) 54)
                  ++x;
                if (Main.tile[x, y].frameX == (short) 108 && Main.tile[x, y].frameY == (short) 36)
                  ++x;
              }
              if (Collision.InTileBounds(x - 1, y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
              {
                if (Main.tile[x, y].frameX == (short) 36)
                  --x;
                if (Main.tile[x, y].frameX == (short) 108 && Main.tile[x, y].frameY == (short) 18)
                  --x;
              }
              while (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 80 /*0x50*/ && Main.tile[x, y + 1].type == (ushort) 80 /*0x50*/ && Collision.InTileBounds(x, y + 1, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
                ++y;
            }
            if (tile.type == (ushort) 323 || tile.type == (ushort) 72)
            {
              while (Main.tile[x, y].active() && (Main.tile[x, y].type == (ushort) 323 && Main.tile[x, y + 1].type == (ushort) 323 || Main.tile[x, y].type == (ushort) 72 && Main.tile[x, y + 1].type == (ushort) 72) && Collision.InTileBounds(x, y + 1, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
                ++y;
            }
            float num2 = Vector2.Distance(new Vector2((float) x, (float) y) * 16f + Vector2.One * 8f, providedInfo.mouse);
            if ((double) num1 == -1.0 || (double) num2 < (double) num1)
            {
              num1 = num2;
              fX = x;
              fY = y;
            }
          }
        }
      }
    }
  }

  private static void Step_BlocksFilling(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    if (!Player.SmartCursorSettings.SmartBlocksEnabled)
      return;
    int type = providedInfo.item.type;
    if (type < 0 || type >= (int) ItemID.Count)
      return;
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    if (Player.SmartCursorSettings.SmartBlocksEnabled || providedInfo.item.createTile <= -1 || !SmartCursorHelper.AllowNormalBlockPlacementBehaviourForItemType(type) || !Main.tileSolid[providedInfo.item.createTile] || Main.tileSolidTop[providedInfo.item.createTile] || Main.tileFrameImportant[providedInfo.item.createTile] || fX != -1 || fY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag1 = false;
    if (Main.tile[screenTargetX, screenTargetY].active())
      flag1 = true;
    if (!Collision.InTileBounds(screenTargetX, screenTargetY, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
      flag1 = true;
    if (!flag1)
    {
      for (int x = reachableStartX; x <= reachableEndX; ++x)
      {
        for (int y = reachableStartY; y <= reachableEndY; ++y)
        {
          Tile tile = Main.tile[x, y];
          if (!tile.active() || Main.tileCut[(int) tile.type] || TileID.Sets.BreakableWhenPlacing[(int) tile.type])
          {
            int num = 0;
            if (Main.tile[x - 1, y].active() && Main.tileSolid[(int) Main.tile[x - 1, y].type] && !Main.tileSolidTop[(int) Main.tile[x - 1, y].type])
              ++num;
            if (Main.tile[x + 1, y].active() && Main.tileSolid[(int) Main.tile[x + 1, y].type] && !Main.tileSolidTop[(int) Main.tile[x + 1, y].type])
              ++num;
            if (Main.tile[x, y - 1].active() && Main.tileSolid[(int) Main.tile[x, y - 1].type] && !Main.tileSolidTop[(int) Main.tile[x, y - 1].type])
              ++num;
            if (Main.tile[x, y + 1].active() && Main.tileSolid[(int) Main.tile[x, y + 1].type] && !Main.tileSolidTop[(int) Main.tile[x, y + 1].type])
              ++num;
            if (num >= 2)
              SmartCursorHelper._targets.Add(new Point(x, y));
          }
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      float num2 = float.PositiveInfinity;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        if (Collision.EmptyTile(SmartCursorHelper._targets[index].X, SmartCursorHelper._targets[index].Y, true))
        {
          Vector2 vector2 = new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f - providedInfo.mouse;
          bool flag2 = false;
          float num3 = Math.Abs(vector2.X);
          float num4 = vector2.Length();
          if ((double) num3 < (double) num2)
            flag2 = true;
          if ((double) num3 == (double) num2 && ((double) num1 == -1.0 || (double) num4 < (double) num1))
            flag2 = true;
          if (flag2)
          {
            num1 = num4;
            num2 = num3;
            target = SmartCursorHelper._targets[index];
          }
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, reachableStartX, reachableStartY, reachableEndX, reachableEndY) && (double) num1 != -1.0)
      {
        fX = target.X;
        fY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static void Step_Torch(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    int type = providedInfo.item.type;
    if (type < 0 || type >= (int) ItemID.Count || !ItemID.Sets.Torches[type] || fX != -1 || fY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    bool flag1 = !ItemID.Sets.WaterTorches[type];
    for (int x = reachableStartX; x <= reachableEndX; ++x)
    {
      for (int y = reachableStartY; y <= reachableEndY; ++y)
      {
        Tile tileCache = Main.tile[x, y];
        if ((!flag1 || tileCache.liquid <= (byte) 0) && (!tileCache.active() || TileID.Sets.BreakableWhenPlacing[(int) tileCache.type] || Main.tileCut[(int) tileCache.type] && tileCache.type != (ushort) 82 && tileCache.type != (ushort) 83))
        {
          bool flag2 = false;
          for (int index1 = x - 8; index1 <= x + 8; ++index1)
          {
            for (int index2 = y - 8; index2 <= y + 8; ++index2)
            {
              if (Main.tile[index1, index2] != null)
              {
                Tile tile = Main.tile[index1, index2];
                if (TileID.Sets.Torches[(int) tile.type])
                {
                  flag2 = true;
                  break;
                }
              }
            }
            if (flag2)
              break;
          }
          if (!flag2 && SmartCursorHelper.IsValidSpotForTorch(x, y, tileCache))
            SmartCursorHelper._targets.Add(new Point(x, y));
        }
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
      {
        fX = target.X;
        fY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  private static bool IsValidSpotForTorch(int x, int y, Tile tileCache)
  {
    if (tileCache.wall > (ushort) 0)
      return true;
    if (TileID.Sets.Torches[(int) tileCache.type])
      return false;
    Tile tile1 = Main.tile[x - 1, y];
    if ((!tile1.active() || tile1.slope() != (byte) 0 && (int) tile1.slope() % 2 == 1 ? 0 : (Main.tileSolid[(int) tile1.type] && !Main.tileNoAttach[(int) tile1.type] && !Main.tileSolidTop[(int) tile1.type] && !TileID.Sets.NotReallySolid[(int) tile1.type] || TileID.Sets.IsBeam[(int) tile1.type] ? 1 : (!WorldGen.IsTreeType((int) tile1.type) || !WorldGen.IsTreeType((int) Main.tile[x - 1, y - 1].type) ? 0 : (WorldGen.IsTreeType((int) Main.tile[x - 1, y + 1].type) ? 1 : 0)))) != 0)
      return true;
    Tile tile2 = Main.tile[x + 1, y];
    if ((!tile2.active() || tile2.slope() != (byte) 0 && (int) tile2.slope() % 2 == 0 ? 0 : (Main.tileSolid[(int) tile2.type] && !Main.tileNoAttach[(int) tile2.type] && !Main.tileSolidTop[(int) tile2.type] && !TileID.Sets.NotReallySolid[(int) tile2.type] || TileID.Sets.IsBeam[(int) tile2.type] ? 1 : (!WorldGen.IsTreeType((int) tile2.type) || !WorldGen.IsTreeType((int) Main.tile[x + 1, y - 1].type) ? 0 : (WorldGen.IsTreeType((int) Main.tile[x + 1, y + 1].type) ? 1 : 0)))) != 0)
      return true;
    Tile tile3 = Main.tile[x, y + 1];
    return tile3.active() && tile3.slope() == (byte) 0 && !tile3.halfBrick() && (Main.tileSolid[(int) tile3.type] && !Main.tileSolidTop[(int) tile3.type] || TileID.Sets.Platforms[(int) tile3.type] ? (!TileID.Sets.NotReallySolid[(int) tile3.type] ? 1 : 0) : 0) != 0;
  }

  private static void Step_LawnMower(
    SmartCursorHelper.SmartCursorUsageInfo providedInfo,
    ref int fX,
    ref int fY)
  {
    int reachableStartX = providedInfo.reachableStartX;
    int reachableStartY = providedInfo.reachableStartY;
    int reachableEndX = providedInfo.reachableEndX;
    int reachableEndY = providedInfo.reachableEndY;
    int screenTargetX = providedInfo.screenTargetX;
    int screenTargetY = providedInfo.screenTargetY;
    if (providedInfo.item.type != 4049 || fX != -1 || fY != -1)
      return;
    SmartCursorHelper._targets.Clear();
    for (int x = reachableStartX; x <= reachableEndX; ++x)
    {
      for (int y = reachableStartY; y <= reachableEndY; ++y)
      {
        Tile tile = Main.tile[x, y];
        if (tile.active() && (tile.type == (ushort) 2 || tile.type == (ushort) 109))
          SmartCursorHelper._targets.Add(new Point(x, y));
      }
    }
    if (SmartCursorHelper._targets.Count > 0)
    {
      float num1 = -1f;
      Point target = SmartCursorHelper._targets[0];
      for (int index = 0; index < SmartCursorHelper._targets.Count; ++index)
      {
        float num2 = Vector2.Distance(new Vector2((float) SmartCursorHelper._targets[index].X, (float) SmartCursorHelper._targets[index].Y) * 16f + Vector2.One * 8f, providedInfo.mouse);
        if ((double) num1 == -1.0 || (double) num2 < (double) num1)
        {
          num1 = num2;
          target = SmartCursorHelper._targets[index];
        }
      }
      if (Collision.InTileBounds(target.X, target.Y, reachableStartX, reachableStartY, reachableEndX, reachableEndY))
      {
        fX = target.X;
        fY = target.Y;
      }
    }
    SmartCursorHelper._targets.Clear();
  }

  public class SmartCursorUsageInfo
  {
    public Player player;
    public Item item;
    public Vector2 mouse;
    public Vector2 position;
    public Vector2 Center;
    public int screenTargetX;
    public int screenTargetY;
    public int reachableStartX;
    public int reachableEndX;
    public int reachableStartY;
    public int reachableEndY;
    public int paintLookup;
    public int paintCoatingLookup;
  }
}
