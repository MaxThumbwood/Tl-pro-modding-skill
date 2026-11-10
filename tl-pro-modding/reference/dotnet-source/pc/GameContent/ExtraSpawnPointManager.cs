// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ExtraSpawnPointManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.ID;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent;

public class ExtraSpawnPointManager
{
  public static Point[] extraSpawnPoints = new Point[0];
  public static ExtraSpawnSettings settings = new ExtraSpawnSettings();
  private static List<LandmassData> _listOfLandmasses = new List<LandmassData>();

  public static bool TryGetExtraSpawnPointForTeam(int team, out Point spawnPoint)
  {
    spawnPoint = Point.Zero;
    if (!Main.teamBasedSpawnsSeed || team < 0)
      return false;
    if (team >= ExtraSpawnPointManager.extraSpawnPoints.Length)
      return false;
    try
    {
      spawnPoint = ExtraSpawnPointManager.extraSpawnPoints[team];
    }
    catch (IndexOutOfRangeException ex)
    {
      return false;
    }
    return true;
  }

  public static void GenerateExtraSpawns_Setup()
  {
    if (ExtraSpawnPointManager.settings.skyblock)
    {
      ExtraSpawnPointManager._listOfLandmasses.Clear();
      for (int index = 0; index < GenVars.landmassData.Count; ++index)
      {
        LandmassData landmassData = GenVars.landmassData[index];
        if (landmassData.DataType == LandmassDataType.SkyblockIsland && landmassData.Style == 0 && (double) landmassData.Position.Distance(new Vector2((float) Main.spawnTileX, (float) Main.spawnTileY)) >= 300.0)
          ExtraSpawnPointManager._listOfLandmasses.Add(landmassData);
      }
    }
    else if (ExtraSpawnPointManager.settings.roundLandmass)
    {
      ExtraSpawnPointManager._listOfLandmasses.Clear();
      for (int index = 0; index < GenVars.landmassData.Count; ++index)
      {
        LandmassData landmassData = GenVars.landmassData[index];
        if (landmassData.DataType == LandmassDataType.RoundLandmass && (double) landmassData.Position.Distance(new Vector2((float) Main.spawnTileX, (float) Main.spawnTileY)) >= 300.0)
          ExtraSpawnPointManager._listOfLandmasses.Add(landmassData);
      }
    }
    else
    {
      if (!ExtraSpawnPointManager.settings.extraLiquid)
        return;
      ExtraSpawnPointManager._listOfLandmasses.Clear();
      for (int index = 0; index < GenVars.landmassData.Count; ++index)
      {
        LandmassData landmassData = GenVars.landmassData[index];
        if (landmassData.DataType == LandmassDataType.ExtraLiquidBubbleSquare && (double) landmassData.Position.Distance(new Vector2((float) Main.spawnTileX, (float) Main.spawnTileY)) >= 300.0)
          ExtraSpawnPointManager._listOfLandmasses.Add(landmassData);
      }
    }
  }

  public static void ResetExtraSpawns()
  {
    ExtraSpawnPointManager._listOfLandmasses.Clear();
    ExtraSpawnPointManager.extraSpawnPoints = new Point[0];
    ExtraSpawnPointManager.settings = new ExtraSpawnSettings();
  }

  public static void GenerateExtraSpawns()
  {
    ExtraSpawnPointManager.GenerateExtraSpawns_Setup();
    switch (ExtraSpawnPointManager.settings.spawnType)
    {
      case ExtraSpawnType.TeamBased:
        ExtraSpawnPointManager.extraSpawnPoints = new Point[(int) PlayerTeamID.Count];
        ExtraSpawnPointManager.extraSpawnPoints[0] = new Point(Main.spawnTileX, Main.spawnTileY);
        List<Point> spawnPoints = new List<Point>();
        for (int iteration = 1; iteration < (int) PlayerTeamID.Count; ++iteration)
          ExtraSpawnPointManager.GenerateExtraSpawns_TryFindSpawnRandomly(spawnPoints, ExtraSpawnPointManager.GenerateExtraSpawns_GetFallbackSpawn(iteration, (int) PlayerTeamID.Count));
        for (int index = 1; index < (int) PlayerTeamID.Count; ++index)
        {
          Point point = spawnPoints[WorldGen.genRand.Next(spawnPoints.Count)];
          ExtraSpawnPointManager.extraSpawnPoints[index] = point;
          spawnPoints.Remove(point);
        }
        break;
      default:
        ExtraSpawnPointManager.extraSpawnPoints = new Point[0];
        break;
    }
  }

  private static bool GenerateExtraSpawns_TryFindSpawnRandomly(
    List<Point> spawnPoints,
    Point fallbackSpawn)
  {
    int num1 = 500;
    int num2 = 60;
    int min = 60;
    bool flag = true;
    LandmassData landmassData1 = new LandmassData();
    for (int index = 0; index < num1; ++index)
    {
      int spawnX = 0;
      int spawnY = 0;
      int num3 = (int) Main.worldSurface;
      spawnX = !flag ? WorldGen.genRand.Next(Main.maxTilesX / 2, Main.maxTilesX - num2) : WorldGen.genRand.Next(num2, Main.maxTilesX / 2);
      if (!ExtraSpawnPointManager.settings.surface)
      {
        num3 = Main.UnderworldLayer - 50 - min;
        spawnY = WorldGen.genRand.Next((int) Main.worldSurface + 200 + min, num3);
      }
      if (ExtraSpawnPointManager.settings.remix)
      {
        num3 = GenVars.remixMushroomLayerHigh - min;
        spawnY = GenVars.remixSurfaceLayerLow + 50 + min;
      }
      if (ExtraSpawnPointManager.settings.skyblock)
      {
        LandmassData landmassData2 = new LandmassData();
        int num4 = 500;
        while (num4 > 0)
        {
          --num4;
          if (ExtraSpawnPointManager._listOfLandmasses.Count > 0)
          {
            landmassData2 = ExtraSpawnPointManager._listOfLandmasses[WorldGen.genRand.Next(ExtraSpawnPointManager._listOfLandmasses.Count)];
            if ((!ExtraSpawnPointManager.settings.surface || (double) landmassData2.Position.Y <= Main.worldSurface) && (!ExtraSpawnPointManager.settings.remix || (double) landmassData2.Position.Y >= (double) GenVars.remixSurfaceLayerLow && (double) landmassData2.Position.Y <= (double) GenVars.remixMushroomLayerHigh))
              break;
          }
          else
            break;
        }
        spawnX = (int) MathHelper.Clamp(landmassData2.Top.X, (float) num2, (float) (Main.maxTilesX - num2));
        spawnY = (int) MathHelper.Clamp(landmassData2.Top.Y, (float) min, (float) (Main.maxTilesY - min));
        num3 = (int) MathHelper.Clamp((float) (spawnY + landmassData2.RadiusOrHalfSize / 2), (float) min, (float) (Main.maxTilesY - min));
        landmassData1 = landmassData2;
      }
      else if (ExtraSpawnPointManager.settings.roundLandmass || ExtraSpawnPointManager.settings.extraLiquid)
      {
        LandmassData landmassData3 = new LandmassData();
        Vector2 vector2 = Vector2.Zero;
        int num5 = 500;
        while (num5 > 0)
        {
          --num5;
          if (ExtraSpawnPointManager._listOfLandmasses.Count > 0)
          {
            landmassData3 = ExtraSpawnPointManager._listOfLandmasses[WorldGen.genRand.Next(ExtraSpawnPointManager._listOfLandmasses.Count)];
            vector2 = landmassData3.Position;
            if (ExtraSpawnPointManager.settings.roundLandmass)
              vector2 = landmassData3.Top;
            if ((!ExtraSpawnPointManager.settings.surface || (double) vector2.Y <= Main.worldSurface) && (!ExtraSpawnPointManager.settings.remix || (double) vector2.Y >= (double) GenVars.remixSurfaceLayerLow && (double) vector2.Y <= (double) GenVars.remixMushroomLayerHigh) && (!ExtraSpawnPointManager.settings.roundLandmass || num5 <= 250 || landmassData3.RadiusOrHalfSize >= 40) && (!ExtraSpawnPointManager.settings.extraLiquid || num5 <= 250 || landmassData3.RadiusOrHalfSize >= 10))
              break;
          }
          else
            break;
        }
        spawnX = (int) MathHelper.Clamp(vector2.X, (float) num2, (float) (Main.maxTilesX - num2));
        spawnY = (int) MathHelper.Clamp(vector2.Y, (float) min, (float) (Main.maxTilesY - min));
        num3 = (int) MathHelper.Clamp((float) (spawnY + landmassData3.RadiusOrHalfSize / 2), (float) min, (float) (Main.maxTilesY - min));
        landmassData1 = landmassData3;
      }
      flag = !flag;
      if (ExtraSpawnPointManager.GenerateExtraSpawns_TryFindSpawnAt(spawnPoints, ref spawnX, ref spawnY, num3))
      {
        spawnPoints.Add(new Point(spawnX, spawnY));
        if (!landmassData1.Equals((object) new LandmassData()))
          ExtraSpawnPointManager._listOfLandmasses.Remove(landmassData1);
        return true;
      }
    }
    spawnPoints.Add(fallbackSpawn);
    return false;
  }

  private static bool GenerateExtraSpawns_TryFindSpawnAt(
    List<Point> spawnPoints,
    ref int spawnX,
    ref int spawnY,
    int maxY)
  {
    spawnY = ExtraSpawnPointManager.GenerateExtraSpawns_IterateDownToFloor(spawnX, spawnY, maxY);
    int num1 = 50;
    if (ExtraSpawnPointManager.settings.skyblock)
      num1 = 15;
    if (ExtraSpawnPointManager.settings.extraLiquid)
      num1 = 30;
    bool canSpawn = false;
    int teleportStartX = Math.Max(0, spawnX - num1);
    int teleportRangeX = num1;
    int teleportStartY = Math.Max(0, spawnY - num1);
    int teleportRangeY = num1;
    int[] spawnTeamBasedSpawns = WorldGen.GetTilesToAvoidForSpawn_TeamBasedSpawns();
    int num2 = 50;
    int num3 = 100;
    Func<Tile, int, int, bool> func = (Func<Tile, int, int, bool>) ((tile, x, y) =>
    {
      Point point = new Point(x, y);
      int num4 = 250;
      if (ExtraSpawnPointManager.settings.extraLiquid && tile.type == (ushort) 379 || ExtraSpawnPointManager.settings.skyblock && tile.type != (ushort) 0)
        return false;
      if (ExtraSpawnPointManager.settings.remix)
      {
        if (WorldGen.GetWorldSize() == 0)
          num4 = 150;
        if (y < GenVars.remixSurfaceLayerLow || y > GenVars.remixMushroomLayerHigh)
          return false;
      }
      if (ExtraSpawnPointManager.settings.roundLandmass && WorldGen.GetWorldSize() == 0)
        num4 = 150;
      for (int index = 0; index < spawnPoints.Count; ++index)
      {
        Point spawnPoint = spawnPoints[index];
        int num5 = Math.Abs(spawnPoint.X - point.X);
        int num6 = Math.Abs(spawnPoint.Y - point.Y);
        if (num5 < num4 && num6 < num4)
          return false;
      }
      return true;
    });
    Vector2 vector2 = Utils.CheckForGoodTeleportationSpot(ref canSpawn, teleportStartX, teleportRangeX, teleportStartY, teleportRangeY, new Utils.RandomTeleportationAttemptSettings()
    {
      teleporteeSize = new Vector2(20f, 42f),
      teleporteeVelocity = Vector2.Zero,
      teleporteeGravityDirection = 1f,
      avoidLava = true,
      avoidAnyLiquid = true,
      avoidHurtTiles = true,
      avoidWalls = true,
      mostlySolidFloor = true,
      strictRange = true,
      maximumFallDistanceFromOrignalPoint = num3,
      attemptsBeforeGivingUp = 250,
      tilesToAvoid = spawnTeamBasedSpawns,
      tilesToAvoidRange = num2,
      specializedConditions = func
    });
    if (!canSpawn)
      return false;
    spawnX = (int) ((double) vector2.X / 16.0);
    spawnY = (int) ((double) vector2.Y / 16.0);
    return true;
  }

  private static Point GenerateExtraSpawns_GetFallbackSpawn(int iteration, int iterationMax)
  {
    float worldSpawnIfNeeded = ExtraSpawnPointManager.GenerateExtraSpawns_WorldPercentileAvoidWorldSpawnIfNeeded((float) iteration / (float) iterationMax);
    int num = (int) ((double) Main.maxTilesX * (double) worldSpawnIfNeeded);
    int spawnY = 0;
    double worldSurface1 = Main.worldSurface;
    if (!ExtraSpawnPointManager.settings.surface)
    {
      spawnY = (int) ((double) Main.maxTilesY * 0.5);
      int underworldLayer = Main.UnderworldLayer;
    }
    if (ExtraSpawnPointManager.settings.roundLandmass)
    {
      if (ExtraSpawnPointManager.settings.surface)
      {
        spawnY = 0;
        double worldSurface2 = Main.worldSurface;
      }
      else
      {
        spawnY = (int) Main.worldSurface + 100;
        int underworldLayer = Main.UnderworldLayer;
      }
    }
    if (ExtraSpawnPointManager.settings.remix)
    {
      spawnY = (int) MathHelper.Lerp((float) GenVars.remixSurfaceLayerLow, (float) GenVars.remixMushroomLayerHigh, 0.5f);
      int mushroomLayerHigh = GenVars.remixMushroomLayerHigh;
    }
    return new Point(num, ExtraSpawnPointManager.GenerateExtraSpawns_IterateDownToFloor(num, spawnY, (int) Main.worldSurface));
  }

  private static float GenerateExtraSpawns_WorldPercentileAvoidWorldSpawnIfNeeded(
    float currentPercentile)
  {
    if (!ExtraSpawnPointManager.settings.surface && !ExtraSpawnPointManager.settings.remix)
      return currentPercentile;
    float num = 0.1f;
    return (double) currentPercentile < 0.5 ? Utils.Remap(currentPercentile, 0.0f, 0.5f, 0.0f, 0.5f - num) : Utils.Remap(currentPercentile, 0.5f, 1f, 0.5f + num, 1f);
  }

  private static int GenerateExtraSpawns_IterateDownToFloor(int spawnX, int spawnY, int maxY)
  {
    if (spawnY > Main.maxTilesY - 5)
      spawnY = Main.maxTilesY - 5;
    else if (spawnY < 5)
      spawnY = 5;
    if (maxY <= spawnY)
      return spawnY;
    bool extraLiquid = ExtraSpawnPointManager.settings.extraLiquid;
    for (int iterateDownToFloor = spawnY; iterateDownToFloor < maxY && iterateDownToFloor < Main.maxTilesY; ++iterateDownToFloor)
    {
      Tile tile = Main.tile[spawnX, iterateDownToFloor];
      if (tile.active() && (extraLiquid || tile.liquid <= (byte) 0) && (tile.type < (ushort) 0 || Main.tileSolid[(int) tile.type]))
        return iterateDownToFloor;
    }
    return spawnY;
  }

  public static void PrepareExtraSpawns()
  {
    ExtraSpawnPointManager.GenerateExtraSpawns_Setup();
    for (int index = 1; index < ExtraSpawnPointManager.extraSpawnPoints.Length; ++index)
    {
      Point extraSpawnPoint = ExtraSpawnPointManager.extraSpawnPoints[index];
      if ((double) extraSpawnPoint.Y >= Main.worldSurface && extraSpawnPoint.Y < Main.UnderworldLayer)
        WorldGen.PlaceTorchesAroundSpawn(extraSpawnPoint.X, extraSpawnPoint.Y);
    }
  }

  public static void Clear()
  {
    ExtraSpawnPointManager.extraSpawnPoints = new Point[0];
    ExtraSpawnPointManager.settings = new ExtraSpawnSettings();
    ExtraSpawnPointManager._listOfLandmasses.Clear();
  }

  public static void Read(BinaryReader reader, bool networking = false)
  {
    byte length = reader.ReadByte();
    ExtraSpawnPointManager.extraSpawnPoints = new Point[(int) length];
    for (int index = 0; index < (int) length; ++index)
    {
      int x = (int) reader.ReadInt16();
      int y = (int) reader.ReadInt16();
      ExtraSpawnPointManager.extraSpawnPoints[index] = new Point(x, y);
    }
  }

  public static void Write(BinaryWriter writer, bool networking = false)
  {
    writer.Write((byte) ExtraSpawnPointManager.extraSpawnPoints.Length);
    for (int index = 0; index < ExtraSpawnPointManager.extraSpawnPoints.Length; ++index)
    {
      writer.Write((short) ExtraSpawnPointManager.extraSpawnPoints[index].X);
      writer.Write((short) ExtraSpawnPointManager.extraSpawnPoints[index].Y);
    }
  }
}
