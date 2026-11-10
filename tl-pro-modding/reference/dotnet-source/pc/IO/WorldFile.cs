// Decompiled with JetBrains decompiler
// Type: Terraria.IO.WorldFile
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Events;
using Terraria.GameContent.Tile_Entities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Social;
using Terraria.UI;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.IO;

public class WorldFile
{
  internal static readonly object IOLock = new object();
  private static bool _reuseTempsForNextSave;
  private static double _tempTime = Main.time;
  private static bool _tempRaining;
  private static float _tempMaxRain;
  private static int _tempRainTime;
  private static bool _tempDayTime = Main.dayTime;
  private static bool _tempBloodMoon = Main.bloodMoon;
  private static bool _tempEclipse = Main.eclipse;
  private static int _tempMoonPhase = Main.moonPhase;
  private static int _tempCultistDelay = CultistRitual.delay;
  private static int _versionNumber;
  private static bool _isWorldOnCloud;
  private static bool _tempPartyGenuine;
  private static bool _tempPartyManual;
  private static int _tempPartyCooldown;
  private static readonly List<int> TempPartyCelebratingNPCs = new List<int>();
  private static bool _tempSandstormHappening;
  private static int _tempSandstormTimeLeft;
  private static float _tempSandstormSeverity;
  private static float _tempSandstormIntendedSeverity;
  private static bool _tempLanternNightGenuine;
  private static bool _tempLanternNightManual;
  private static bool _tempLanternNightNextNightIsGenuine;
  private static int _tempLanternNightCooldown;
  private static int _tempCoinRain;
  private static int _tempMeteorShowerCount;
  public static Exception LastThrownLoadException;
  private const int VersionNumberForChestRework = 294;

  public static void ReuseTempsForNextSave() => WorldFile._reuseTempsForNextSave = true;

  public static void SetOngoingToTemps()
  {
    Main.dayTime = WorldFile._tempDayTime;
    Main.time = WorldFile._tempTime;
    Main.moonPhase = WorldFile._tempMoonPhase;
    Main.bloodMoon = WorldFile._tempBloodMoon;
    Main.eclipse = WorldFile._tempEclipse;
    Main.raining = WorldFile._tempRaining;
    Main.rainTime = WorldFile._tempRainTime;
    Main.maxRaining = WorldFile._tempMaxRain;
    Main.cloudAlpha = WorldFile._tempMaxRain;
    CultistRitual.delay = WorldFile._tempCultistDelay;
    BirthdayParty.ManualParty = WorldFile._tempPartyManual;
    BirthdayParty.GenuineParty = WorldFile._tempPartyGenuine;
    BirthdayParty.PartyDaysOnCooldown = WorldFile._tempPartyCooldown;
    BirthdayParty.CelebratingNPCs.Clear();
    BirthdayParty.CelebratingNPCs.AddRange((IEnumerable<int>) WorldFile.TempPartyCelebratingNPCs);
    Sandstorm.Happening = WorldFile._tempSandstormHappening;
    Sandstorm.TimeLeft = WorldFile._tempSandstormTimeLeft;
    Sandstorm.Severity = WorldFile._tempSandstormSeverity;
    Sandstorm.IntendedSeverity = WorldFile._tempSandstormIntendedSeverity;
    LanternNight.GenuineLanterns = WorldFile._tempLanternNightGenuine;
    LanternNight.LanternNightsOnCooldown = WorldFile._tempLanternNightCooldown;
    LanternNight.ManualLanterns = WorldFile._tempLanternNightManual;
    LanternNight.NextNightIsLanternNight = WorldFile._tempLanternNightNextNightIsGenuine;
    WorldGen.meteorShowerCount = WorldFile._tempMeteorShowerCount;
    Main.coinRain = WorldFile._tempCoinRain;
  }

  public static bool IsValidWorld(string file, bool cloudSave)
  {
    return WorldFile.GetFileMetadata(file, cloudSave) != null;
  }

  public static WorldFileData GetAllMetadata(string file, bool cloudSave)
  {
    try
    {
      if (!FileUtilities.Exists(file, cloudSave))
        throw new FileNotFoundException(file);
      using (Stream input = cloudSave ? (Stream) new MemoryStream(SocialAPI.Cloud.Read(file)) : (Stream) new FileStream(file, FileMode.Open))
      {
        using (BinaryReader reader = new BinaryReader(input))
        {
          int version = reader.ReadInt32();
          if (version > 318)
            return WorldFileData.FromInvalidWorld(file, cloudSave, StatusID.LaterVersion, (Exception) new FileFormatException($"File is from a later version of Terraria. '{file}'"));
          WorldFileData allMetadata = new WorldFileData(file, cloudSave);
          if (version >= 135)
            allMetadata.Metadata = FileMetadata.Read(reader, FileType.World);
          else
            allMetadata.Metadata = FileMetadata.FromCurrentSettings(FileType.World);
          if (version >= 88)
          {
            int num = (int) reader.ReadInt16();
            input.Position = (long) reader.ReadInt32();
          }
          allMetadata.Name = reader.ReadString();
          if (version >= 179)
          {
            string seedText = version != 179 ? reader.ReadString() : reader.ReadInt32().ToString();
            allMetadata.SetSeed(seedText);
            allMetadata.WorldGeneratorVersion = reader.ReadUInt64();
          }
          else
          {
            allMetadata.SetSeedToEmpty();
            allMetadata.WorldGeneratorVersion = 0UL;
          }
          allMetadata.UniqueId = version < 181 ? Guid.Empty : new Guid(reader.ReadBytes(16 /*0x10*/));
          allMetadata.WorldId = reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadInt32();
          int y = reader.ReadInt32();
          int x = reader.ReadInt32();
          allMetadata.SetWorldSize(x, y);
          if (version >= 209)
          {
            allMetadata.GameMode = reader.ReadInt32();
            if (version >= 222)
            {
              allMetadata.DrunkWorld = reader.ReadBoolean();
              if (version >= 227)
                allMetadata.ForTheWorthy = reader.ReadBoolean();
              if (version >= 238)
                allMetadata.Anniversary = reader.ReadBoolean();
              if (version >= 239)
                allMetadata.DontStarve = reader.ReadBoolean();
              if (version >= 241)
                allMetadata.NotTheBees = reader.ReadBoolean();
              if (version >= 249)
                allMetadata.RemixWorld = reader.ReadBoolean();
              if (version >= 266)
                allMetadata.NoTrapsWorld = reader.ReadBoolean();
              if (version >= 267)
              {
                allMetadata.ZenithWorld = reader.ReadBoolean();
              }
              else
              {
                allMetadata.ZenithWorld = allMetadata.DrunkWorld && allMetadata.RemixWorld;
                if (allMetadata.ZenithWorld)
                  allMetadata.NoTrapsWorld = true;
              }
              if (version >= 302)
                allMetadata.SkyblockWorld = reader.ReadBoolean();
            }
          }
          else if (version >= 112 /*0x70*/)
            allMetadata.GameMode = !reader.ReadBoolean() ? 0 : 1;
          allMetadata.CreationTime = version < 141 ? (cloudSave ? DateTime.Now : File.GetCreationTime(file)) : DateTime.FromBinary(reader.ReadInt64());
          allMetadata.LastPlayed = version < 284 ? (cloudSave ? new DateTime() : File.GetLastWriteTimeUtc(file)) : DateTime.FromBinary(reader.ReadInt64());
          if (version >= 63 /*0x3F*/)
          {
            int num1 = (int) reader.ReadByte();
          }
          if (version >= 44)
          {
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
          }
          if (version >= 60)
          {
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
          }
          if (version >= 61)
          {
            reader.ReadInt32();
            reader.ReadInt32();
          }
          reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadDouble();
          reader.ReadDouble();
          reader.ReadDouble();
          reader.ReadBoolean();
          reader.ReadInt32();
          reader.ReadBoolean();
          int num2 = version < 70 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          reader.ReadInt32();
          reader.ReadInt32();
          allMetadata.HasCrimson = version >= 56 && reader.ReadBoolean();
          reader.ReadBoolean();
          reader.ReadBoolean();
          reader.ReadBoolean();
          int num3 = version < 66 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num4 = version < 44 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num5 = version < 44 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num6 = version < 44 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num7 = version < 44 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num8 = version < 64 /*0x40*/ ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num9 = version < 64 /*0x40*/ ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num10 = version < 118 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num11 = version < 29 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num12 = version < 29 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num13 = version < 34 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num14 = version < 29 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num15 = version < 32 /*0x20*/ ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num16 = version < 37 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          int num17 = version < 56 ? 0 : (reader.ReadBoolean() ? 1 : 0);
          reader.ReadBoolean();
          reader.ReadBoolean();
          int num18 = (int) reader.ReadByte();
          if (version >= 23)
            reader.ReadInt32();
          allMetadata.IsHardMode = version >= 23 && reader.ReadBoolean();
          if (version >= 257)
            reader.ReadBoolean();
          reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadInt32();
          reader.ReadDouble();
          if (version >= 118)
            reader.ReadDouble();
          if (version >= 113)
          {
            int num19 = (int) reader.ReadByte();
          }
          if (version >= 53)
          {
            reader.ReadBoolean();
            reader.ReadInt32();
            double num20 = (double) reader.ReadSingle();
          }
          if (version >= 54)
          {
            reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
          }
          if (version >= 55)
          {
            int num21 = (int) reader.ReadByte();
            int num22 = (int) reader.ReadByte();
            int num23 = (int) reader.ReadByte();
          }
          if (version >= 60)
          {
            int num24 = (int) reader.ReadByte();
            int num25 = (int) reader.ReadByte();
            int num26 = (int) reader.ReadByte();
            int num27 = (int) reader.ReadByte();
            int num28 = (int) reader.ReadByte();
          }
          if (version >= 60)
            reader.ReadInt32();
          if (version >= 62)
          {
            int num29 = (int) reader.ReadInt16();
          }
          if (version >= 88)
          {
            double num30 = (double) reader.ReadSingle();
          }
          if (version < 95)
            return allMetadata;
          for (int index = reader.ReadInt32(); index > 0; --index)
            reader.ReadString();
          if (version < 99)
            return allMetadata;
          reader.ReadBoolean();
          if (version < 101)
            return allMetadata;
          reader.ReadInt32();
          if (version < 104)
            return allMetadata;
          reader.ReadBoolean();
          if (version >= 129)
            reader.ReadBoolean();
          if (version >= 201)
            reader.ReadBoolean();
          if (version >= 107)
            reader.ReadInt32();
          if (version >= 108)
            reader.ReadInt32();
          if (version < 109)
            return allMetadata;
          BannerSystem.ValidateWorld(reader, version);
          if (version < 128 /*0x80*/)
            return allMetadata;
          reader.ReadBoolean();
          if (version < 131)
            return allMetadata;
          reader.ReadBoolean();
          reader.ReadBoolean();
          reader.ReadBoolean();
          allMetadata.DefeatedMoonlord = reader.ReadBoolean();
          return allMetadata;
        }
      }
    }
    catch (Exception ex)
    {
      return WorldFileData.FromInvalidWorld(file, cloudSave, StatusID.UnknownError, ex);
    }
  }

  public static WorldFileData CreateMetadata(string name, bool cloudSave, int GameMode)
  {
    WorldFileData metadata = new WorldFileData(Main.GetWorldPathFromName(name, cloudSave), cloudSave);
    if (Main.autoGenFileLocation != null && Main.autoGenFileLocation != "")
    {
      metadata = new WorldFileData(Main.autoGenFileLocation, cloudSave);
      Main.autoGenFileLocation = (string) null;
    }
    metadata.Name = name;
    metadata.GameMode = GameMode;
    metadata.CreationTime = DateTime.Now;
    metadata.Metadata = FileMetadata.FromCurrentSettings(FileType.World);
    metadata.SetFavorite(false);
    metadata.WorldGeneratorVersion = 1365799600129UL /*0x013E00000001*/;
    metadata.UniqueId = Guid.NewGuid();
    if (Main.DefaultSeed == "")
      metadata.SetSeedToRandom();
    else
      metadata.SetSeed(Main.DefaultSeed);
    return metadata;
  }

  public static void ResetTemps()
  {
    WorldFile._tempRaining = false;
    WorldFile._tempMaxRain = 0.0f;
    WorldFile._tempRainTime = 0;
    WorldFile._tempDayTime = true;
    WorldFile._tempBloodMoon = false;
    WorldFile._tempEclipse = false;
    WorldFile._tempMoonPhase = 0;
    Main.anglerWhoFinishedToday.Clear();
    Main.anglerQuestFinished = false;
  }

  public static void ClearTempTiles()
  {
    for (int i = 0; i < Main.maxTilesX; ++i)
    {
      for (int j = 0; j < Main.maxTilesY; ++j)
      {
        if (Main.tile[i, j].type == (ushort) sbyte.MaxValue || Main.tile[i, j].type == (ushort) 504)
          WorldGen.KillTile(i, j);
      }
    }
  }

  public static void LoadWorld()
  {
    if (Main.rand == null)
      Main.rand = new UnifiedRandom((int) DateTime.Now.Ticks);
    Main.lockMenuBGChange = true;
    WorldFile._isWorldOnCloud = Main.ActiveWorldFileData.IsCloudSave;
    Main.checkXMas();
    Main.checkHalloween();
    if (WorldFile._isWorldOnCloud && SocialAPI.Cloud == null)
    {
      WorldFile.LastThrownLoadException = new Exception("Cloud inaccessible");
      WorldGen.loadFailed = true;
    }
    else
    {
      if (!FileUtilities.Exists(Main.worldPathName, WorldFile._isWorldOnCloud) && Main.autoGen)
      {
        if (!WorldFile._isWorldOnCloud)
        {
          for (int index = Main.worldPathName.Length - 1; index >= 0; --index)
          {
            if (Main.worldPathName.Substring(index, 1) == (Path.DirectorySeparatorChar.ToString() ?? ""))
            {
              Utils.TryCreatingDirectory(Main.worldPathName.Substring(0, index));
              break;
            }
          }
        }
        Main.ActiveWorldFileData = WorldFile.CreateMetadata(Main.worldName == "" ? "World" : Main.worldName, WorldFile._isWorldOnCloud, Main.GameMode);
        string str1 = (Main.AutogenSeedName ?? "").Trim();
        string seedTextIncludingSecrets;
        if (WorldFileData.TryApplyingCopiedSeed(str1, true, out string _, out seedTextIncludingSecrets, out List<string> _))
        {
          Main.ActiveWorldFileData.SetSeed(seedTextIncludingSecrets);
        }
        else
        {
          string str2 = Utils.TrimUserString(str1, WorldFileData.MAX_USER_SEED_TEXT_LENGTH);
          AWorldGenerationOption optionFromSeedText = WorldGenerationOptions.GetOptionFromSeedText(str2);
          WorldGenerationOptions.SelectOption(optionFromSeedText);
          foreach (AWorldGenerationOption option in WorldGenerationOptions.Options)
          {
            if (option.AutoGenEnabled)
              option.Enabled = true;
          }
          if (optionFromSeedText != null || string.IsNullOrWhiteSpace(str2))
            Main.ActiveWorldFileData.SetSeedToRandomWithCurrentEvents();
          else
            Main.ActiveWorldFileData.SetSeed(str2);
        }
        if (WorldGen.GenerateWorld(Main.AutogenProgress))
          WorldFile.SaveWorld(Main.ActiveWorldFileData.IsCloudSave, true);
      }
      try
      {
        using (MemoryStream input = new MemoryStream(FileUtilities.ReadAllBytes(Main.worldPathName, WorldFile._isWorldOnCloud)))
        {
          using (BinaryReader binaryReader = new BinaryReader((Stream) input))
          {
            try
            {
              WorldGen.loadFailed = false;
              int num1 = binaryReader.ReadInt32();
              WorldFile._versionNumber = num1;
              int num2 = num1 > 0 ? (num1 <= 318 ? (num1 > 87 ? WorldFile.LoadWorld_Version2(binaryReader) : WorldFile.LoadWorld_Version1_Old_BeforeRelease88(binaryReader)) : StatusID.LaterVersion) : StatusID.UnknownError;
              if (num1 < 141)
                Main.ActiveWorldFileData.CreationTime = WorldFile._isWorldOnCloud ? DateTime.Now : File.GetCreationTime(Main.worldPathName);
              binaryReader.Close();
              input.Close();
              if (num2 != StatusID.Ok)
                throw new Exception("LoadWorld failed with status: " + StatusID.Search.GetName(num2));
              WorldFile.CheckSavedOreTiers();
              WorldFile.ConvertOldTileEntities();
              WorldFile.ClearTempTiles();
              WorldGen.isGeneratingOrLoadingWorld = true;
              GenVars.waterLine = Main.maxTilesY;
              Liquid.QuickWater(2);
              WorldGen.WaterCheck();
              int num3 = 0;
              Liquid.quickSettle = true;
              int num4 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
              float num5 = 0.0f;
              while (Liquid.numLiquid > 0 && num3 < 100000)
              {
                ++num3;
                float num6 = (float) (num4 - (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer)) / (float) num4;
                if (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer > num4)
                  num4 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
                if ((double) num6 > (double) num5)
                  num5 = num6;
                else
                  num6 = num5;
                Main.statusText = $"{Lang.gen[27].Value} {(object) (int) ((double) num6 * 100.0 / 2.0 + 50.0)}%";
                Liquid.UpdateLiquid();
              }
              Liquid.quickSettle = false;
              Main.weatherCounter = WorldGen.genRand.Next(3600, 18000);
              Cloud.resetClouds();
              WorldGen.WaterCheck();
              WorldGen.isGeneratingOrLoadingWorld = false;
              NPC.setFireFlyChance();
              WorldGen.Skyblock.ScanTiles();
              if (Main.slimeRainTime > 0.0)
                Main.StartSlimeRain(false);
              NPC.SetWorldSpecificMonstersByWorldID();
            }
            catch (Exception ex)
            {
              WorldFile.LastThrownLoadException = ex;
              WorldGen.loadFailed = true;
              try
              {
                binaryReader.Close();
                input.Close();
              }
              catch
              {
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        WorldFile.LastThrownLoadException = ex;
        WorldGen.loadFailed = true;
      }
    }
  }

  public static void CheckSavedOreTiers()
  {
    if (WorldGen.SavedOreTiers.Copper != -1 && WorldGen.SavedOreTiers.Iron != -1 && WorldGen.SavedOreTiers.Silver != -1 && WorldGen.SavedOreTiers.Gold != -1)
      return;
    int[] numArray = WorldGen.CountTileTypesInWorld(7, 166, 6, 167, 9, 168, 8, 169);
    for (int index = 0; index < numArray.Length; index += 2)
    {
      int num1 = numArray[index];
      int num2 = numArray[index + 1];
      switch (index)
      {
        case 0:
          WorldGen.SavedOreTiers.Copper = num1 <= num2 ? 166 : 7;
          break;
        case 2:
          WorldGen.SavedOreTiers.Iron = num1 <= num2 ? 167 : 6;
          break;
        case 4:
          WorldGen.SavedOreTiers.Silver = num1 <= num2 ? 168 : 9;
          break;
        case 6:
          WorldGen.SavedOreTiers.Gold = num1 <= num2 ? 169 : 8;
          break;
      }
    }
  }

  public static void SaveWorld()
  {
    try
    {
      WorldFile.SaveWorld(WorldFile._isWorldOnCloud);
    }
    catch (Exception ex)
    {
      string worldPath = Main.WorldPath;
      FancyErrorPrinter.ShowFileSavingFailError(ex, worldPath);
      throw;
    }
  }

  public static void SaveWorld(bool useCloudSaving, bool resetTime = false)
  {
    if (useCloudSaving && SocialAPI.Cloud == null)
      return;
    if (Main.worldName == "")
      Main.worldName = "World";
    while (WorldGen.TransformingWorld)
      Main.statusText = Lang.gen[48 /*0x30*/].Value;
    if (!Monitor.TryEnter(WorldFile.IOLock))
      return;
    try
    {
      FileUtilities.ProtectedInvoke((Action) (() => WorldFile.InternalSaveWorld(useCloudSaving, resetTime)));
    }
    finally
    {
      Monitor.Exit(WorldFile.IOLock);
    }
  }

  private static void InternalSaveWorld(bool useCloudSaving, bool resetTime)
  {
    Utils.TryCreatingDirectory(Main.WorldPath);
    if (WorldFile._reuseTempsForNextSave)
      WorldFile._reuseTempsForNextSave = false;
    else
      WorldFile.SetTempToOngoing();
    if (resetTime)
      WorldFile.ResetTempsToDayTime();
    if (Main.worldPathName == null)
      return;
    new Stopwatch().Start();
    byte[] array;
    int length;
    using (MemoryStream output = new MemoryStream(7000000))
    {
      using (BinaryWriter writer = new BinaryWriter((Stream) output))
        WorldFile.SaveWorld_Version2(writer);
      array = output.ToArray();
      length = array.Length;
    }
    byte[] data = (byte[]) null;
    if (FileUtilities.Exists(Main.worldPathName, useCloudSaving))
      data = FileUtilities.ReadAllBytes(Main.worldPathName, useCloudSaving);
    FileUtilities.Write(Main.worldPathName, array, length, useCloudSaving);
    byte[] buffer = FileUtilities.ReadAllBytes(Main.worldPathName, useCloudSaving);
    string str = (string) null;
    using (MemoryStream input = new MemoryStream(buffer, 0, length, false))
    {
      using (BinaryReader fileIO = new BinaryReader((Stream) input))
      {
        if (!Main.validateSaves || WorldFile.ValidateWorld(fileIO))
        {
          if (data != null)
          {
            str = Main.worldPathName + ".bak";
            Main.statusText = Lang.gen[50].Value;
          }
          WorldFile.DoRollingBackups(str);
        }
        else
          str = Main.worldPathName;
      }
    }
    if (str == null || data == null)
      return;
    FileUtilities.WriteAllBytes(str, data, useCloudSaving);
  }

  private static void DoRollingBackups(string backupWorldWritePath)
  {
    if (Main.WorldRollingBackupsCountToKeep <= 1)
      return;
    int num1 = Main.WorldRollingBackupsCountToKeep;
    if (num1 > 9)
      num1 = 9;
    int num2 = 1;
    for (int index = 1; index < num1; ++index)
    {
      string path = backupWorldWritePath + (object) index;
      if (index == 1)
        path = backupWorldWritePath;
      if (FileUtilities.Exists(path, false))
        num2 = index + 1;
      else
        break;
    }
    for (int index = num2 - 1; index > 0; --index)
    {
      string str = backupWorldWritePath + (object) index;
      if (index == 1)
        str = backupWorldWritePath;
      string destination = backupWorldWritePath + (object) (index + 1);
      if (FileUtilities.Exists(str, false))
        FileUtilities.Move(str, destination, false);
    }
  }

  private static void ResetTempsToDayTime()
  {
    WorldFile._tempDayTime = true;
    WorldFile._tempTime = 13500.0;
    WorldFile._tempMoonPhase = 0;
    WorldFile._tempBloodMoon = false;
    WorldFile._tempEclipse = false;
    WorldFile._tempCultistDelay = 86400;
    if (WorldGen.SecretSeed.graveyardBloodmoonStart.Enabled)
    {
      WorldFile._tempDayTime = false;
      WorldFile._tempBloodMoon = true;
      WorldFile._tempTime = 1.0;
    }
    WorldFile._tempPartyManual = false;
    WorldFile._tempPartyGenuine = false;
    if (Main.tenthAnniversaryWorld && !Main.skyblockWorld)
      WorldFile._tempPartyGenuine = true;
    WorldFile._tempPartyCooldown = 0;
    WorldFile.TempPartyCelebratingNPCs.Clear();
    WorldFile._tempSandstormHappening = false;
    WorldFile._tempSandstormTimeLeft = 0;
    WorldFile._tempSandstormSeverity = 0.0f;
    WorldFile._tempSandstormIntendedSeverity = 0.0f;
    WorldFile._tempLanternNightCooldown = 0;
    WorldFile._tempLanternNightGenuine = false;
    WorldFile._tempLanternNightManual = false;
    WorldFile._tempLanternNightNextNightIsGenuine = false;
    WorldFile._tempMeteorShowerCount = 0;
    WorldFile._tempCoinRain = 0;
  }

  public static void SetTempToOngoing()
  {
    WorldFile._tempDayTime = Main.dayTime;
    WorldFile._tempTime = Main.time;
    WorldFile._tempMoonPhase = Main.moonPhase;
    WorldFile._tempBloodMoon = Main.bloodMoon;
    WorldFile._tempEclipse = Main.eclipse;
    WorldFile._tempCultistDelay = CultistRitual.delay;
    WorldFile._tempPartyManual = BirthdayParty.ManualParty;
    WorldFile._tempPartyGenuine = BirthdayParty.GenuineParty;
    WorldFile._tempPartyCooldown = BirthdayParty.PartyDaysOnCooldown;
    WorldFile.TempPartyCelebratingNPCs.Clear();
    WorldFile.TempPartyCelebratingNPCs.AddRange((IEnumerable<int>) BirthdayParty.CelebratingNPCs);
    WorldFile._tempSandstormHappening = Sandstorm.Happening;
    WorldFile._tempSandstormTimeLeft = Sandstorm.TimeLeft;
    WorldFile._tempSandstormSeverity = Sandstorm.Severity;
    WorldFile._tempSandstormIntendedSeverity = Sandstorm.IntendedSeverity;
    WorldFile._tempRaining = Main.raining;
    WorldFile._tempRainTime = Main.rainTime;
    WorldFile._tempMaxRain = Main.maxRaining;
    WorldFile._tempLanternNightCooldown = LanternNight.LanternNightsOnCooldown;
    WorldFile._tempLanternNightGenuine = LanternNight.GenuineLanterns;
    WorldFile._tempLanternNightManual = LanternNight.ManualLanterns;
    WorldFile._tempLanternNightNextNightIsGenuine = LanternNight.NextNightIsLanternNight;
    WorldFile._tempMeteorShowerCount = WorldGen.meteorShowerCount;
    WorldFile._tempCoinRain = Main.coinRain;
  }

  private static void ConvertOldTileEntities()
  {
    List<Point> pointList1 = new List<Point>();
    List<Point> pointList2 = new List<Point>();
    for (int x = 0; x < Main.maxTilesX; ++x)
    {
      for (int y = 0; y < Main.maxTilesY; ++y)
      {
        Tile tile = Main.tile[x, y];
        if ((tile.type == (ushort) 128 /*0x80*/ || tile.type == (ushort) 269) && tile.frameY == (short) 0 && ((int) tile.frameX % 100 == 0 || (int) tile.frameX % 100 == 36))
          pointList1.Add(new Point(x, y));
        if (tile.type == (ushort) 334 && tile.frameY == (short) 0 && (int) tile.frameX % 54 == 0)
          pointList2.Add(new Point(x, y));
        if (tile.type == (ushort) 49 && (tile.frameX == (short) -1 || tile.frameY == (short) -1))
        {
          tile.frameX = (short) 0;
          tile.frameY = (short) 0;
        }
      }
    }
    foreach (Point point in pointList1)
    {
      if (WorldGen.InWorld(point.X, point.Y, 5))
      {
        int frameX1 = (int) Main.tile[point.X, point.Y].frameX;
        int frameX2 = (int) Main.tile[point.X, point.Y + 1].frameX;
        int frameX3 = (int) Main.tile[point.X, point.Y + 2].frameX;
        for (int index1 = 0; index1 < 2; ++index1)
        {
          for (int index2 = 0; index2 < 3; ++index2)
          {
            Tile tile = Main.tile[point.X + index1, point.Y + index2];
            tile.frameX %= (short) 100;
            if (tile.type == (ushort) 269)
              tile.frameX += (short) 72;
            tile.type = (ushort) 470;
          }
        }
        int id = TileEntityType<TEDisplayDoll>.Place(point.X, point.Y);
        if (id != -1)
        {
          TEDisplayDoll result;
          TileEntity.TryGet<TEDisplayDoll>(id, out result);
          result.SetInventoryFromMannequin(frameX1, frameX2, frameX3);
        }
      }
    }
    foreach (Point point in pointList2)
    {
      if (WorldGen.InWorld(point.X, point.Y, 5))
      {
        bool flag1 = Main.tile[point.X, point.Y].frameX >= (short) 54;
        int frameX4 = (int) Main.tile[point.X, point.Y + 1].frameX;
        int frameX5 = (int) Main.tile[point.X + 1, point.Y + 1].frameX;
        bool flag2 = frameX4 >= 5000;
        int type = frameX4 % 5000 - 100;
        int prefix = frameX5 - (frameX5 >= 25000 ? 25000 : 10000);
        for (int index3 = 0; index3 < 3; ++index3)
        {
          for (int index4 = 0; index4 < 3; ++index4)
          {
            Tile tile = Main.tile[point.X + index3, point.Y + index4];
            tile.type = (ushort) 471;
            tile.frameX = (short) ((flag1 ? 54 : 0) + index3 * 18);
            tile.frameY = (short) (index4 * 18);
          }
        }
        if (TileEntityType<TEWeaponsRack>.Place(point.X, point.Y) != -1 & flag2)
          TEWeaponsRack.TryPlacing(point.X, point.Y, type, prefix, 1);
      }
    }
  }

  public static void SaveWorld_Version2(BinaryWriter writer)
  {
    int[] pointers = new int[11]
    {
      WorldFile.SaveFileFormatHeader(writer),
      WorldFile.SaveWorldHeader(writer),
      WorldFile.SaveWorldTiles(writer),
      WorldFile.SaveChests(writer),
      WorldFile.SaveSigns(writer),
      WorldFile.SaveNPCs(writer),
      WorldFile.SaveTileEntities(writer),
      WorldFile.SaveWeightedPressurePlates(writer),
      WorldFile.SaveTownManager(writer),
      WorldFile.SaveBestiary(writer),
      WorldFile.SaveCreativePowers(writer)
    };
    WorldFile.SaveFooter(writer);
    WorldFile.SaveHeaderPointers(writer, pointers);
  }

  public static int SaveFileFormatHeader(BinaryWriter writer)
  {
    ushort count = TileID.Count;
    short num1 = 11;
    writer.Write(318);
    Main.WorldFileMetadata.IncrementAndWrite(writer);
    writer.Write(num1);
    for (int index = 0; index < (int) num1; ++index)
      writer.Write(0);
    writer.Write(count);
    byte num2 = 0;
    byte num3 = 1;
    for (int index = 0; index < (int) count; ++index)
    {
      if (Main.tileFrameImportant[index])
        num2 |= num3;
      if (num3 == (byte) 128 /*0x80*/)
      {
        writer.Write(num2);
        num2 = (byte) 0;
        num3 = (byte) 1;
      }
      else
        num3 <<= 1;
    }
    if (num3 != (byte) 1)
      writer.Write(num2);
    return (int) writer.BaseStream.Position;
  }

  public static int SaveHeaderPointers(BinaryWriter writer, int[] pointers)
  {
    writer.BaseStream.Position = 0L;
    writer.Write(318);
    writer.BaseStream.Position += 20L;
    writer.Write((short) pointers.Length);
    for (int index = 0; index < pointers.Length; ++index)
      writer.Write(pointers[index]);
    return (int) writer.BaseStream.Position;
  }

  public static int SaveWorldHeader(BinaryWriter writer)
  {
    writer.Write(Main.worldName);
    writer.Write(Main.ActiveWorldFileData.SeedText);
    writer.Write(Main.ActiveWorldFileData.WorldGeneratorVersion);
    writer.Write(Main.ActiveWorldFileData.UniqueId.ToByteArray());
    writer.Write(Main.ActiveWorldFileData.WorldId);
    writer.Write((int) Main.leftWorld);
    writer.Write((int) Main.rightWorld);
    writer.Write((int) Main.topWorld);
    writer.Write((int) Main.bottomWorld);
    writer.Write(Main.maxTilesY);
    writer.Write(Main.maxTilesX);
    writer.Write(Main.GameMode);
    writer.Write(Main.drunkWorld);
    writer.Write(Main.getGoodWorld);
    writer.Write(Main.tenthAnniversaryWorld);
    writer.Write(Main.dontStarveWorld);
    writer.Write(Main.notTheBeesWorld);
    writer.Write(Main.remixWorld);
    writer.Write(Main.noTrapsWorld);
    writer.Write(Main.zenithWorld);
    writer.Write(Main.skyblockWorld);
    writer.Write(Main.ActiveWorldFileData.CreationTime.ToBinary());
    writer.Write(DateTime.UtcNow.ToBinary());
    writer.Write((byte) Main.moonType);
    writer.Write(Main.treeX[0]);
    writer.Write(Main.treeX[1]);
    writer.Write(Main.treeX[2]);
    writer.Write(Main.treeStyle[0]);
    writer.Write(Main.treeStyle[1]);
    writer.Write(Main.treeStyle[2]);
    writer.Write(Main.treeStyle[3]);
    writer.Write(Main.caveBackX[0]);
    writer.Write(Main.caveBackX[1]);
    writer.Write(Main.caveBackX[2]);
    writer.Write(Main.caveBackStyle[0]);
    writer.Write(Main.caveBackStyle[1]);
    writer.Write(Main.caveBackStyle[2]);
    writer.Write(Main.caveBackStyle[3]);
    writer.Write(Main.iceBackStyle);
    writer.Write(Main.jungleBackStyle);
    writer.Write(Main.hellBackStyle);
    writer.Write(Main.spawnTileX);
    writer.Write(Main.spawnTileY);
    writer.Write(Main.worldSurface);
    writer.Write(Main.rockLayer);
    writer.Write(WorldFile._tempTime);
    writer.Write(WorldFile._tempDayTime);
    writer.Write(WorldFile._tempMoonPhase);
    writer.Write(WorldFile._tempBloodMoon);
    writer.Write(WorldFile._tempEclipse);
    writer.Write(Main.dungeonX);
    writer.Write(Main.dungeonY);
    writer.Write(WorldGen.crimson);
    writer.Write(NPC.downedBoss1);
    writer.Write(NPC.downedBoss2);
    writer.Write(NPC.downedBoss3);
    writer.Write(NPC.downedQueenBee);
    writer.Write(NPC.downedMechBoss1);
    writer.Write(NPC.downedMechBoss2);
    writer.Write(NPC.downedMechBoss3);
    writer.Write(NPC.downedMechBossAny);
    writer.Write(NPC.downedPlantBoss);
    writer.Write(NPC.downedGolemBoss);
    writer.Write(NPC.downedSlimeKing);
    writer.Write(NPC.savedGoblin);
    writer.Write(NPC.savedWizard);
    writer.Write(NPC.savedMech);
    writer.Write(NPC.downedGoblins);
    writer.Write(NPC.downedClown);
    writer.Write(NPC.downedFrost);
    writer.Write(NPC.downedPirates);
    writer.Write(WorldGen.shadowOrbSmashed);
    writer.Write(WorldGen.spawnMeteor);
    writer.Write((byte) WorldGen.shadowOrbCount);
    writer.Write(WorldGen.altarCount);
    writer.Write(Main.hardMode);
    writer.Write(Main.afterPartyOfDoom);
    writer.Write(Main.invasionDelay);
    writer.Write(Main.invasionSize);
    writer.Write(Main.invasionType);
    writer.Write(Main.invasionX);
    writer.Write(Main.slimeRainTime);
    writer.Write((byte) Main.sundialCooldown);
    writer.Write(WorldFile._tempRaining);
    writer.Write(WorldFile._tempRainTime);
    writer.Write(WorldFile._tempMaxRain);
    writer.Write(WorldGen.SavedOreTiers.Cobalt);
    writer.Write(WorldGen.SavedOreTiers.Mythril);
    writer.Write(WorldGen.SavedOreTiers.Adamantite);
    writer.Write((byte) WorldGen.treeBG1);
    writer.Write((byte) WorldGen.corruptBG);
    writer.Write((byte) WorldGen.jungleBG);
    writer.Write((byte) WorldGen.snowBG);
    writer.Write((byte) WorldGen.hallowBG);
    writer.Write((byte) WorldGen.crimsonBG);
    writer.Write((byte) WorldGen.desertBG);
    writer.Write((byte) WorldGen.oceanBG);
    writer.Write((int) Main.cloudBGActive);
    writer.Write((short) Main.numClouds);
    writer.Write(Main.windSpeedTarget);
    writer.Write(Main.anglerWhoFinishedToday.Count);
    for (int index = 0; index < Main.anglerWhoFinishedToday.Count; ++index)
      writer.Write(Main.anglerWhoFinishedToday[index]);
    writer.Write(NPC.savedAngler);
    writer.Write(Main.anglerQuest);
    writer.Write(NPC.savedStylist);
    writer.Write(NPC.savedTaxCollector);
    writer.Write(NPC.savedGolfer);
    writer.Write(Main.invasionSizeStart);
    writer.Write(WorldFile._tempCultistDelay);
    BannerSystem.Save(writer);
    writer.Write(Main.fastForwardTimeToDawn);
    writer.Write(NPC.downedFishron);
    writer.Write(NPC.downedMartians);
    writer.Write(NPC.downedAncientCultist);
    writer.Write(NPC.downedMoonlord);
    writer.Write(NPC.downedHalloweenKing);
    writer.Write(NPC.downedHalloweenTree);
    writer.Write(NPC.downedChristmasIceQueen);
    writer.Write(NPC.downedChristmasSantank);
    writer.Write(NPC.downedChristmasTree);
    writer.Write(NPC.downedTowerSolar);
    writer.Write(NPC.downedTowerVortex);
    writer.Write(NPC.downedTowerNebula);
    writer.Write(NPC.downedTowerStardust);
    writer.Write(NPC.TowerActiveSolar);
    writer.Write(NPC.TowerActiveVortex);
    writer.Write(NPC.TowerActiveNebula);
    writer.Write(NPC.TowerActiveStardust);
    writer.Write(NPC.LunarApocalypseIsUp);
    writer.Write(WorldFile._tempPartyManual);
    writer.Write(WorldFile._tempPartyGenuine);
    writer.Write(WorldFile._tempPartyCooldown);
    writer.Write(WorldFile.TempPartyCelebratingNPCs.Count);
    for (int index = 0; index < WorldFile.TempPartyCelebratingNPCs.Count; ++index)
      writer.Write(WorldFile.TempPartyCelebratingNPCs[index]);
    writer.Write(WorldFile._tempSandstormHappening);
    writer.Write(WorldFile._tempSandstormTimeLeft);
    writer.Write(WorldFile._tempSandstormSeverity);
    writer.Write(WorldFile._tempSandstormIntendedSeverity);
    writer.Write(NPC.savedBartender);
    DD2Event.Save(writer);
    writer.Write((byte) WorldGen.mushroomBG);
    writer.Write((byte) WorldGen.underworldBG);
    writer.Write((byte) WorldGen.treeBG2);
    writer.Write((byte) WorldGen.treeBG3);
    writer.Write((byte) WorldGen.treeBG4);
    writer.Write(NPC.combatBookWasUsed);
    writer.Write(WorldFile._tempLanternNightCooldown);
    writer.Write(WorldFile._tempLanternNightGenuine);
    writer.Write(WorldFile._tempLanternNightManual);
    writer.Write(WorldFile._tempLanternNightNextNightIsGenuine);
    WorldGen.TreeTops.Save(writer);
    writer.Write(Main.forceHalloweenForToday);
    writer.Write(Main.forceXMasForToday);
    writer.Write(WorldGen.SavedOreTiers.Copper);
    writer.Write(WorldGen.SavedOreTiers.Iron);
    writer.Write(WorldGen.SavedOreTiers.Silver);
    writer.Write(WorldGen.SavedOreTiers.Gold);
    writer.Write(NPC.boughtCat);
    writer.Write(NPC.boughtDog);
    writer.Write(NPC.boughtBunny);
    writer.Write(NPC.downedEmpressOfLight);
    writer.Write(NPC.downedQueenSlime);
    writer.Write(NPC.downedDeerclops);
    writer.Write(NPC.unlockedSlimeBlueSpawn);
    writer.Write(NPC.unlockedMerchantSpawn);
    writer.Write(NPC.unlockedDemolitionistSpawn);
    writer.Write(NPC.unlockedPartyGirlSpawn);
    writer.Write(NPC.unlockedDyeTraderSpawn);
    writer.Write(NPC.unlockedTruffleSpawn);
    writer.Write(NPC.unlockedArmsDealerSpawn);
    writer.Write(NPC.unlockedNurseSpawn);
    writer.Write(NPC.unlockedPrincessSpawn);
    writer.Write(NPC.combatBookVolumeTwoWasUsed);
    writer.Write(NPC.peddlersSatchelWasUsed);
    writer.Write(NPC.unlockedSlimeGreenSpawn);
    writer.Write(NPC.unlockedSlimeOldSpawn);
    writer.Write(NPC.unlockedSlimePurpleSpawn);
    writer.Write(NPC.unlockedSlimeRainbowSpawn);
    writer.Write(NPC.unlockedSlimeRedSpawn);
    writer.Write(NPC.unlockedSlimeYellowSpawn);
    writer.Write(NPC.unlockedSlimeCopperSpawn);
    writer.Write(Main.fastForwardTimeToDusk);
    writer.Write((byte) Main.moondialCooldown);
    writer.Write(Main.forceHalloweenForever);
    writer.Write(Main.forceXMasForever);
    writer.Write(Main.vampireSeed);
    writer.Write(Main.infectedSeed);
    writer.Write(WorldFile._tempMeteorShowerCount);
    writer.Write(WorldFile._tempCoinRain);
    writer.Write(Main.teamBasedSpawnsSeed);
    ExtraSpawnPointManager.Write(writer);
    writer.Write(Main.dualDungeonsSeed);
    writer.Write(WorldGen.Manifest.Serialize());
    return (int) writer.BaseStream.Position;
  }

  public static int SaveWorldTiles(BinaryWriter writer)
  {
    byte[] buffer = new byte[16 /*0x10*/];
    for (int index1 = 0; index1 < Main.maxTilesX; ++index1)
    {
      float num1 = (float) index1 / (float) Main.maxTilesX;
      Main.statusText = $"{Lang.gen[49].Value} {(object) (int) ((double) num1 * 100.0 + 1.0)}%";
      int num2;
      for (int index2 = 0; index2 < Main.maxTilesY; index2 = num2 + 1)
      {
        Tile tile = Main.tile[index1, index2];
        int index3 = 4;
        int num3;
        byte num4 = (byte) (num3 = 0);
        byte num5 = (byte) num3;
        byte num6 = (byte) num3;
        byte num7 = (byte) num3;
        bool flag = false;
        if (tile.active())
          flag = true;
        if (flag)
        {
          num7 |= (byte) 2;
          buffer[index3] = (byte) tile.type;
          ++index3;
          if (tile.type > (ushort) byte.MaxValue)
          {
            buffer[index3] = (byte) ((uint) tile.type >> 8);
            ++index3;
            num7 |= (byte) 32 /*0x20*/;
          }
          if (Main.tileFrameImportant[(int) tile.type])
          {
            buffer[index3] = (byte) ((uint) tile.frameX & (uint) byte.MaxValue);
            int index4 = index3 + 1;
            buffer[index4] = (byte) (((int) tile.frameX & 65280) >> 8);
            int index5 = index4 + 1;
            buffer[index5] = (byte) ((uint) tile.frameY & (uint) byte.MaxValue);
            int index6 = index5 + 1;
            buffer[index6] = (byte) (((int) tile.frameY & 65280) >> 8);
            index3 = index6 + 1;
          }
          if (tile.color() != (byte) 0)
          {
            num5 |= (byte) 8;
            buffer[index3] = tile.color();
            ++index3;
          }
        }
        if (tile.wall != (ushort) 0)
        {
          num7 |= (byte) 4;
          buffer[index3] = (byte) tile.wall;
          ++index3;
          if (tile.wallColor() != (byte) 0)
          {
            num5 |= (byte) 16 /*0x10*/;
            buffer[index3] = tile.wallColor();
            ++index3;
          }
        }
        if (tile.liquid != (byte) 0)
        {
          if (tile.shimmer())
          {
            num5 |= (byte) 128 /*0x80*/;
            num7 |= (byte) 8;
          }
          else if (tile.lava())
            num7 |= (byte) 16 /*0x10*/;
          else if (tile.honey())
            num7 |= (byte) 24;
          else
            num7 |= (byte) 8;
          buffer[index3] = tile.liquid;
          ++index3;
        }
        if (tile.wire())
          num6 |= (byte) 2;
        if (tile.wire2())
          num6 |= (byte) 4;
        if (tile.wire3())
          num6 |= (byte) 8;
        int num8 = !tile.halfBrick() ? (tile.slope() == (byte) 0 ? 0 : (int) tile.slope() + 1 << 4) : 16 /*0x10*/;
        byte num9 = (byte) ((uint) num6 | (uint) (byte) num8);
        if (tile.actuator())
          num5 |= (byte) 2;
        if (tile.inActive())
          num5 |= (byte) 4;
        if (tile.wire4())
          num5 |= (byte) 32 /*0x20*/;
        if (tile.wall > (ushort) byte.MaxValue)
        {
          buffer[index3] = (byte) ((uint) tile.wall >> 8);
          ++index3;
          num5 |= (byte) 64 /*0x40*/;
        }
        if (tile.invisibleBlock())
          num4 |= (byte) 2;
        if (tile.invisibleWall())
          num4 |= (byte) 4;
        if (tile.fullbrightBlock())
          num4 |= (byte) 8;
        if (tile.fullbrightWall())
          num4 |= (byte) 16 /*0x10*/;
        int index7 = 3;
        if (num4 != (byte) 0)
        {
          num5 |= (byte) 1;
          buffer[index7] = num4;
          --index7;
        }
        if (num5 != (byte) 0)
        {
          num9 |= (byte) 1;
          buffer[index7] = num5;
          --index7;
        }
        if (num9 != (byte) 0)
        {
          num7 |= (byte) 1;
          buffer[index7] = num9;
          --index7;
        }
        short num10 = 0;
        int index8 = index2 + 1;
        for (int index9 = Main.maxTilesY - index2 - 1; index9 > 0 && tile.isTheSameAs(Main.tile[index1, index8]) && TileID.Sets.AllowsSaveCompressionBatching[(int) tile.type]; ++index8)
        {
          ++num10;
          --index9;
        }
        num2 = index2 + (int) num10;
        if (num10 > (short) 0)
        {
          buffer[index3] = (byte) ((uint) num10 & (uint) byte.MaxValue);
          ++index3;
          if (num10 > (short) byte.MaxValue)
          {
            num7 |= (byte) 128 /*0x80*/;
            buffer[index3] = (byte) (((int) num10 & 65280) >> 8);
            ++index3;
          }
          else
            num7 |= (byte) 64 /*0x40*/;
        }
        buffer[index7] = num7;
        writer.Write(buffer, index7, index3 - index7);
      }
    }
    return (int) writer.BaseStream.Position;
  }

  public static int SaveChests(BinaryWriter writer)
  {
    short num = 0;
    for (int chestIndex = 0; chestIndex < 8000; ++chestIndex)
    {
      Chest chest = Main.chest[chestIndex];
      if (chest != null)
      {
        bool flag = false;
        for (int x = chest.x; x <= chest.x + 1; ++x)
        {
          for (int y = chest.y; y <= chest.y + 1; ++y)
          {
            if (x < 0 || y < 0 || x >= Main.maxTilesX || y >= Main.maxTilesY)
            {
              flag = true;
              break;
            }
            Tile tile = Main.tile[x, y];
            if (!tile.active() || !Main.tileContainer[(int) tile.type])
            {
              flag = true;
              break;
            }
          }
        }
        if (flag)
          Chest.RemoveChest(chestIndex);
        else
          ++num;
      }
    }
    writer.Write(num);
    for (int index1 = 0; index1 < 8000; ++index1)
    {
      Chest chest = Main.chest[index1];
      if (chest != null)
      {
        writer.Write(chest.x);
        writer.Write(chest.y);
        writer.Write(chest.name);
        writer.Write(chest.maxItems);
        for (int index2 = 0; index2 < chest.maxItems; ++index2)
        {
          Item obj = chest.item[index2];
          if (obj == null || ItemID.Sets.ItemsThatShouldNotBeInInventory[obj.type])
          {
            writer.Write((short) 0);
          }
          else
          {
            if (obj.stack < 0)
              obj.stack = 1;
            writer.Write((short) obj.stack);
            if (obj.stack > 0)
            {
              writer.Write(obj.type);
              writer.Write(obj.prefix);
            }
          }
        }
      }
    }
    return (int) writer.BaseStream.Position;
  }

  public static int SaveSigns(BinaryWriter writer)
  {
    short num = 0;
    for (int index = 0; index < 32000; ++index)
    {
      Sign sign = Main.sign[index];
      if (sign != null && sign.text != null)
        ++num;
    }
    writer.Write(num);
    for (int index = 0; index < 32000; ++index)
    {
      Sign sign = Main.sign[index];
      if (sign != null && sign.text != null)
      {
        writer.Write(sign.text);
        writer.Write(sign.x);
        writer.Write(sign.y);
      }
    }
    return (int) writer.BaseStream.Position;
  }

  public static int SaveNPCs(BinaryWriter writer)
  {
    bool[] arr = (bool[]) NPC.ShimmeredTownNPCs.Clone();
    writer.Write(arr.Count<bool>(true));
    for (int index = 0; index < arr.Length; ++index)
    {
      if (arr[index])
        writer.Write(index);
    }
    for (int index = 0; index < Main.npc.Length; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && npc.townNPC && npc.type != 368)
      {
        writer.Write(npc.active);
        writer.Write(npc.netID);
        writer.Write(npc.GivenName);
        writer.Write(npc.position.X);
        writer.Write(npc.position.Y);
        writer.Write(npc.homeless);
        writer.Write(npc.homeTileX);
        writer.Write(npc.homeTileY);
        BitsByte bitsByte = (BitsByte) (byte) 0;
        bitsByte[0] = npc.townNPC;
        writer.Write((byte) bitsByte);
        if (bitsByte[0])
          writer.Write(npc.townNpcVariationIndex);
        writer.Write(npc.homelessDespawn);
      }
    }
    writer.Write(false);
    for (int index = 0; index < Main.npc.Length; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && NPCID.Sets.SavesAndLoads[npc.type])
      {
        writer.Write(npc.active);
        writer.Write(npc.netID);
        writer.WriteVector2(npc.position);
      }
    }
    writer.Write(false);
    return (int) writer.BaseStream.Position;
  }

  public static int SaveFooter(BinaryWriter writer)
  {
    writer.Write(true);
    writer.Write(Main.worldName);
    writer.Write(Main.ActiveWorldFileData.WorldId);
    return (int) writer.BaseStream.Position;
  }

  public static int LoadWorld_Version2(BinaryReader reader)
  {
    reader.BaseStream.Position = 0L;
    bool[] importance;
    int[] positions;
    if (!WorldFile.LoadFileFormatHeader(reader, out importance, out positions) || reader.BaseStream.Position != (long) positions[0])
      return StatusID.BadSectionPointer;
    WorldFile.LoadHeader(reader);
    if (reader.BaseStream.Position != (long) positions[1])
      return StatusID.BadSectionPointer;
    WorldFile.LoadWorldTiles(reader, importance);
    if (reader.BaseStream.Position != (long) positions[2])
      return StatusID.BadSectionPointer;
    WorldFile.LoadChests(reader);
    if (reader.BaseStream.Position != (long) positions[3])
      return StatusID.BadSectionPointer;
    WorldFile.LoadSigns(reader);
    if (reader.BaseStream.Position != (long) positions[4])
      return StatusID.BadSectionPointer;
    WorldFile.LoadNPCs(reader);
    if (reader.BaseStream.Position != (long) positions[5])
      return StatusID.BadSectionPointer;
    if (WorldFile._versionNumber >= 116)
    {
      if (WorldFile._versionNumber < 122)
      {
        WorldFile.LoadDummies(reader);
        if (reader.BaseStream.Position != (long) positions[6])
          return StatusID.BadSectionPointer;
      }
      else
      {
        WorldFile.LoadTileEntities(reader);
        if (reader.BaseStream.Position != (long) positions[6])
          return StatusID.BadSectionPointer;
      }
    }
    if (WorldFile._versionNumber >= 170)
    {
      WorldFile.LoadWeightedPressurePlates(reader);
      if (reader.BaseStream.Position != (long) positions[7])
        return StatusID.BadSectionPointer;
    }
    if (WorldFile._versionNumber >= 189)
    {
      WorldFile.LoadTownManager(reader);
      if (reader.BaseStream.Position != (long) positions[8])
        return StatusID.BadSectionPointer;
    }
    if (WorldFile._versionNumber >= 210)
    {
      WorldFile.LoadBestiary(reader, WorldFile._versionNumber);
      if (reader.BaseStream.Position != (long) positions[9])
        return StatusID.BadSectionPointer;
    }
    else
      WorldFile.LoadBestiaryForVersionsBefore210();
    if (WorldFile._versionNumber >= 220)
    {
      WorldFile.LoadCreativePowers(reader, WorldFile._versionNumber);
      if (reader.BaseStream.Position != (long) positions[10])
        return StatusID.BadSectionPointer;
    }
    WorldFile.LoadWorld_LastMinuteFixes();
    return WorldFile.LoadFooter(reader);
  }

  private static void LoadWorld_LastMinuteFixes()
  {
    if (WorldFile._versionNumber < 258)
      WorldFile.ConvertIlluminantPaintToNewField();
    WorldFile.FixAgainstExploits();
  }

  private static void FixAgainstExploits()
  {
    for (int index = 0; index < 8000; ++index)
      Main.chest[index]?.FixLoadedData();
    foreach (TileEntity tileEntity in TileEntity.ByID.Values)
    {
      if (tileEntity is IFixLoadedData fixLoadedData)
        fixLoadedData.FixLoadedData();
    }
    for (int index = 0; index < Main.npc.Length; ++index)
    {
      NPC n = Main.npc[index];
      if (n.active && n.townNPC && n.type != 368 && n.type != 37 && !n.homeless)
      {
        bool flag = WorldGen.StartRoomCheck(n.homeTileX, n.homeTileY - 1, (IRoomCheckFeedback) NoRoomCheckFeedback.WithoutText);
        if (!flag)
        {
          Point roomPosition;
          if (WorldGen.TownManager.HasRoom(n.type, out roomPosition))
          {
            n.homeTileX = roomPosition.X;
            n.homeTileY = roomPosition.Y;
            flag = WorldGen.StartRoomCheck(n.homeTileX, n.homeTileY - 1, (IRoomCheckFeedback) NoRoomCheckFeedback.WithoutText);
          }
          if (!flag)
          {
            WorldGen.TownManager.KickOut(n);
            n.homeless = true;
          }
        }
      }
    }
  }

  public static bool LoadFileFormatHeader(
    BinaryReader reader,
    out bool[] importance,
    out int[] positions)
  {
    importance = (bool[]) null;
    positions = (int[]) null;
    if ((WorldFile._versionNumber = reader.ReadInt32()) >= 135)
    {
      try
      {
        Main.WorldFileMetadata = FileMetadata.Read(reader, FileType.World);
      }
      catch (FormatException ex)
      {
        Console.WriteLine(Language.GetTextValue("Error.UnableToLoadWorld"));
        Console.WriteLine((object) ex);
        return false;
      }
    }
    else
      Main.WorldFileMetadata = FileMetadata.FromCurrentSettings(FileType.World);
    short length1 = reader.ReadInt16();
    positions = new int[(int) length1];
    for (int index = 0; index < (int) length1; ++index)
      positions[index] = reader.ReadInt32();
    ushort length2 = reader.ReadUInt16();
    importance = new bool[(int) length2];
    byte num1 = 0;
    byte num2 = 128 /*0x80*/;
    for (int index = 0; index < (int) length2; ++index)
    {
      if (num2 == (byte) 128 /*0x80*/)
      {
        num1 = reader.ReadByte();
        num2 = (byte) 1;
      }
      else
        num2 <<= 1;
      if (((int) num1 & (int) num2) == (int) num2)
        importance[index] = true;
    }
    return true;
  }

  public static void LoadHeader(BinaryReader reader)
  {
    int versionNumber = WorldFile._versionNumber;
    Main.worldName = reader.ReadString();
    if (versionNumber >= 179)
    {
      string seedText = versionNumber != 179 ? reader.ReadString() : reader.ReadInt32().ToString();
      Main.ActiveWorldFileData.SetSeed(seedText);
      Main.ActiveWorldFileData.WorldGeneratorVersion = reader.ReadUInt64();
    }
    Main.ActiveWorldFileData.UniqueId = versionNumber < 181 ? Guid.NewGuid() : new Guid(reader.ReadBytes(16 /*0x10*/));
    Main.ActiveWorldFileData.WorldId = reader.ReadInt32();
    Main.leftWorld = (float) reader.ReadInt32();
    Main.rightWorld = (float) reader.ReadInt32();
    Main.topWorld = (float) reader.ReadInt32();
    Main.bottomWorld = (float) reader.ReadInt32();
    Main.maxTilesY = reader.ReadInt32();
    Main.maxTilesX = reader.ReadInt32();
    WorldGen.clearWorld();
    if (versionNumber >= 209)
    {
      Main.GameMode = reader.ReadInt32();
      if (versionNumber >= 222)
        Main.drunkWorld = reader.ReadBoolean();
      if (versionNumber >= 227)
        Main.getGoodWorld = reader.ReadBoolean();
      if (versionNumber >= 238)
        Main.tenthAnniversaryWorld = reader.ReadBoolean();
      if (versionNumber >= 239)
        Main.dontStarveWorld = reader.ReadBoolean();
      if (versionNumber >= 241)
        Main.notTheBeesWorld = reader.ReadBoolean();
      if (versionNumber >= 249)
        Main.remixWorld = reader.ReadBoolean();
      if (versionNumber >= 266)
        Main.noTrapsWorld = reader.ReadBoolean();
      Main.zenithWorld = versionNumber < 267 ? Main.remixWorld && Main.drunkWorld : reader.ReadBoolean();
      if (versionNumber >= 302)
        Main.skyblockWorld = reader.ReadBoolean();
    }
    else
    {
      Main.GameMode = versionNumber < 112 /*0x70*/ ? 0 : (reader.ReadBoolean() ? 1 : 0);
      if (versionNumber == 208 /*0xD0*/ && reader.ReadBoolean())
        Main.GameMode = 2;
    }
    if (versionNumber >= 141)
      Main.ActiveWorldFileData.CreationTime = DateTime.FromBinary(reader.ReadInt64());
    if (versionNumber >= 284)
      Main.ActiveWorldFileData.LastPlayed = DateTime.FromBinary(reader.ReadInt64());
    Main.moonType = (int) reader.ReadByte();
    Main.treeX[0] = reader.ReadInt32();
    Main.treeX[1] = reader.ReadInt32();
    Main.treeX[2] = reader.ReadInt32();
    Main.treeStyle[0] = reader.ReadInt32();
    Main.treeStyle[1] = reader.ReadInt32();
    Main.treeStyle[2] = reader.ReadInt32();
    Main.treeStyle[3] = reader.ReadInt32();
    Main.caveBackX[0] = reader.ReadInt32();
    Main.caveBackX[1] = reader.ReadInt32();
    Main.caveBackX[2] = reader.ReadInt32();
    Main.caveBackStyle[0] = reader.ReadInt32();
    Main.caveBackStyle[1] = reader.ReadInt32();
    Main.caveBackStyle[2] = reader.ReadInt32();
    Main.caveBackStyle[3] = reader.ReadInt32();
    Main.iceBackStyle = reader.ReadInt32();
    Main.jungleBackStyle = reader.ReadInt32();
    Main.hellBackStyle = reader.ReadInt32();
    Main.spawnTileX = reader.ReadInt32();
    Main.spawnTileY = reader.ReadInt32();
    Main.worldSurface = reader.ReadDouble();
    Main.rockLayer = reader.ReadDouble();
    WorldFile._tempTime = reader.ReadDouble();
    WorldFile._tempDayTime = reader.ReadBoolean();
    WorldFile._tempMoonPhase = reader.ReadInt32();
    WorldFile._tempBloodMoon = reader.ReadBoolean();
    WorldFile._tempEclipse = reader.ReadBoolean();
    Main.eclipse = WorldFile._tempEclipse;
    Main.dungeonX = reader.ReadInt32();
    Main.dungeonY = reader.ReadInt32();
    WorldGen.crimson = reader.ReadBoolean();
    NPC.downedBoss1 = reader.ReadBoolean();
    NPC.downedBoss2 = reader.ReadBoolean();
    NPC.downedBoss3 = reader.ReadBoolean();
    NPC.downedQueenBee = reader.ReadBoolean();
    NPC.downedMechBoss1 = reader.ReadBoolean();
    NPC.downedMechBoss2 = reader.ReadBoolean();
    NPC.downedMechBoss3 = reader.ReadBoolean();
    NPC.downedMechBossAny = reader.ReadBoolean();
    NPC.downedPlantBoss = reader.ReadBoolean();
    NPC.downedGolemBoss = reader.ReadBoolean();
    if (versionNumber >= 118)
      NPC.downedSlimeKing = reader.ReadBoolean();
    NPC.savedGoblin = reader.ReadBoolean();
    NPC.savedWizard = reader.ReadBoolean();
    NPC.savedMech = reader.ReadBoolean();
    NPC.downedGoblins = reader.ReadBoolean();
    NPC.downedClown = reader.ReadBoolean();
    NPC.downedFrost = reader.ReadBoolean();
    NPC.downedPirates = reader.ReadBoolean();
    WorldGen.shadowOrbSmashed = reader.ReadBoolean();
    WorldGen.spawnMeteor = reader.ReadBoolean();
    WorldGen.shadowOrbCount = (int) reader.ReadByte();
    WorldGen.altarCount = reader.ReadInt32();
    Main.hardMode = reader.ReadBoolean();
    Main.afterPartyOfDoom = versionNumber >= 257 && reader.ReadBoolean();
    Main.invasionDelay = reader.ReadInt32();
    Main.invasionSize = reader.ReadInt32();
    Main.invasionType = reader.ReadInt32();
    Main.invasionX = reader.ReadDouble();
    if (versionNumber >= 118)
      Main.slimeRainTime = reader.ReadDouble();
    if (versionNumber >= 113)
      Main.sundialCooldown = (int) reader.ReadByte();
    WorldFile._tempRaining = reader.ReadBoolean();
    WorldFile._tempRainTime = reader.ReadInt32();
    WorldFile._tempMaxRain = reader.ReadSingle();
    WorldFile.FixEndlessRainWorlds();
    WorldGen.SavedOreTiers.Cobalt = reader.ReadInt32();
    WorldGen.SavedOreTiers.Mythril = reader.ReadInt32();
    WorldGen.SavedOreTiers.Adamantite = reader.ReadInt32();
    WorldGen.setBG(0, (int) reader.ReadByte());
    WorldGen.setBG(1, (int) reader.ReadByte());
    WorldGen.setBG(2, (int) reader.ReadByte());
    WorldGen.setBG(3, (int) reader.ReadByte());
    WorldGen.setBG(4, (int) reader.ReadByte());
    WorldGen.setBG(5, (int) reader.ReadByte());
    WorldGen.setBG(6, (int) reader.ReadByte());
    WorldGen.setBG(7, (int) reader.ReadByte());
    Main.cloudBGActive = (float) reader.ReadInt32();
    Main.cloudBGAlpha = (double) Main.cloudBGActive < 1.0 ? 0.0f : 1f;
    Main.cloudBGActive = (float) -WorldGen.genRand.Next(8640, 86400);
    Main.numClouds = (int) reader.ReadInt16();
    Main.windSpeedTarget = reader.ReadSingle();
    Main.windSpeedCurrent = Main.windSpeedTarget;
    if (versionNumber < 95)
      return;
    Main.anglerWhoFinishedToday.Clear();
    for (int index = reader.ReadInt32(); index > 0; --index)
      Main.anglerWhoFinishedToday.Add(reader.ReadString());
    if (versionNumber < 99)
      return;
    NPC.savedAngler = reader.ReadBoolean();
    if (versionNumber < 101)
      return;
    Main.anglerQuest = reader.ReadInt32();
    if (versionNumber < 104)
      return;
    NPC.savedStylist = reader.ReadBoolean();
    if (versionNumber >= 129)
      NPC.savedTaxCollector = reader.ReadBoolean();
    if (versionNumber >= 201)
      NPC.savedGolfer = reader.ReadBoolean();
    if (versionNumber < 107)
    {
      if (Main.invasionType > 0 && Main.invasionSize > 0)
        Main.FakeLoadInvasionStart();
    }
    else
      Main.invasionSizeStart = reader.ReadInt32();
    WorldFile._tempCultistDelay = versionNumber >= 108 ? reader.ReadInt32() : 86400;
    if (versionNumber < 109)
      return;
    BannerSystem.Load(reader, versionNumber);
    if (versionNumber < 128 /*0x80*/)
      return;
    Main.fastForwardTimeToDawn = reader.ReadBoolean();
    if (versionNumber < 131)
      return;
    NPC.downedFishron = reader.ReadBoolean();
    NPC.downedMartians = reader.ReadBoolean();
    NPC.downedAncientCultist = reader.ReadBoolean();
    NPC.downedMoonlord = reader.ReadBoolean();
    NPC.downedHalloweenKing = reader.ReadBoolean();
    NPC.downedHalloweenTree = reader.ReadBoolean();
    NPC.downedChristmasIceQueen = reader.ReadBoolean();
    NPC.downedChristmasSantank = reader.ReadBoolean();
    NPC.downedChristmasTree = reader.ReadBoolean();
    if (versionNumber < 140)
      return;
    NPC.downedTowerSolar = reader.ReadBoolean();
    NPC.downedTowerVortex = reader.ReadBoolean();
    NPC.downedTowerNebula = reader.ReadBoolean();
    NPC.downedTowerStardust = reader.ReadBoolean();
    NPC.TowerActiveSolar = reader.ReadBoolean();
    NPC.TowerActiveVortex = reader.ReadBoolean();
    NPC.TowerActiveNebula = reader.ReadBoolean();
    NPC.TowerActiveStardust = reader.ReadBoolean();
    NPC.LunarApocalypseIsUp = reader.ReadBoolean();
    if (NPC.TowerActiveSolar)
      NPC.ShieldStrengthTowerSolar = NPC.ShieldStrengthTowerMax;
    if (NPC.TowerActiveVortex)
      NPC.ShieldStrengthTowerVortex = NPC.ShieldStrengthTowerMax;
    if (NPC.TowerActiveNebula)
      NPC.ShieldStrengthTowerNebula = NPC.ShieldStrengthTowerMax;
    if (NPC.TowerActiveStardust)
      NPC.ShieldStrengthTowerStardust = NPC.ShieldStrengthTowerMax;
    if (versionNumber < 170)
    {
      WorldFile._tempPartyManual = false;
      WorldFile._tempPartyGenuine = false;
      WorldFile._tempPartyCooldown = 0;
      WorldFile.TempPartyCelebratingNPCs.Clear();
    }
    else
    {
      WorldFile._tempPartyManual = reader.ReadBoolean();
      WorldFile._tempPartyGenuine = reader.ReadBoolean();
      WorldFile._tempPartyCooldown = reader.ReadInt32();
      int num = reader.ReadInt32();
      WorldFile.TempPartyCelebratingNPCs.Clear();
      for (int index = 0; index < num; ++index)
        WorldFile.TempPartyCelebratingNPCs.Add(reader.ReadInt32());
    }
    if (versionNumber < 174)
    {
      WorldFile._tempSandstormHappening = false;
      WorldFile._tempSandstormTimeLeft = 0;
      WorldFile._tempSandstormSeverity = 0.0f;
      WorldFile._tempSandstormIntendedSeverity = 0.0f;
    }
    else
    {
      WorldFile._tempSandstormHappening = reader.ReadBoolean();
      WorldFile._tempSandstormTimeLeft = reader.ReadInt32();
      WorldFile._tempSandstormSeverity = reader.ReadSingle();
      WorldFile._tempSandstormIntendedSeverity = reader.ReadSingle();
    }
    DD2Event.Load(reader, versionNumber);
    if (versionNumber > 194)
      WorldGen.setBG(8, (int) reader.ReadByte());
    else
      WorldGen.setBG(8, 0);
    if (versionNumber >= 215)
      WorldGen.setBG(9, (int) reader.ReadByte());
    else
      WorldGen.setBG(9, 0);
    if (versionNumber > 195)
    {
      WorldGen.setBG(10, (int) reader.ReadByte());
      WorldGen.setBG(11, (int) reader.ReadByte());
      WorldGen.setBG(12, (int) reader.ReadByte());
    }
    else
    {
      WorldGen.setBG(10, WorldGen.treeBG1);
      WorldGen.setBG(11, WorldGen.treeBG1);
      WorldGen.setBG(12, WorldGen.treeBG1);
    }
    if (versionNumber >= 204)
      NPC.combatBookWasUsed = reader.ReadBoolean();
    if (versionNumber < 207)
    {
      WorldFile._tempLanternNightCooldown = 0;
      WorldFile._tempLanternNightGenuine = false;
      WorldFile._tempLanternNightManual = false;
      WorldFile._tempLanternNightNextNightIsGenuine = false;
    }
    else
    {
      WorldFile._tempLanternNightCooldown = reader.ReadInt32();
      WorldFile._tempLanternNightGenuine = reader.ReadBoolean();
      WorldFile._tempLanternNightManual = reader.ReadBoolean();
      WorldFile._tempLanternNightNextNightIsGenuine = reader.ReadBoolean();
    }
    WorldGen.TreeTops.Load(reader, versionNumber);
    if (versionNumber >= 212)
    {
      Main.forceHalloweenForToday = reader.ReadBoolean();
      Main.forceXMasForToday = reader.ReadBoolean();
    }
    else
    {
      Main.forceHalloweenForToday = false;
      Main.forceXMasForToday = false;
    }
    if (versionNumber >= 216)
    {
      WorldGen.SavedOreTiers.Copper = reader.ReadInt32();
      WorldGen.SavedOreTiers.Iron = reader.ReadInt32();
      WorldGen.SavedOreTiers.Silver = reader.ReadInt32();
      WorldGen.SavedOreTiers.Gold = reader.ReadInt32();
    }
    else
    {
      WorldGen.SavedOreTiers.Copper = -1;
      WorldGen.SavedOreTiers.Iron = -1;
      WorldGen.SavedOreTiers.Silver = -1;
      WorldGen.SavedOreTiers.Gold = -1;
    }
    if (versionNumber >= 217)
    {
      NPC.boughtCat = reader.ReadBoolean();
      NPC.boughtDog = reader.ReadBoolean();
      NPC.boughtBunny = reader.ReadBoolean();
    }
    else
    {
      NPC.boughtCat = false;
      NPC.boughtDog = false;
      NPC.boughtBunny = false;
    }
    if (versionNumber >= 223)
    {
      NPC.downedEmpressOfLight = reader.ReadBoolean();
      NPC.downedQueenSlime = reader.ReadBoolean();
    }
    else
    {
      NPC.downedEmpressOfLight = false;
      NPC.downedQueenSlime = false;
    }
    NPC.downedDeerclops = versionNumber >= 240 /*0xF0*/ && reader.ReadBoolean();
    NPC.unlockedSlimeBlueSpawn = versionNumber >= 250 && reader.ReadBoolean();
    if (versionNumber >= 251)
    {
      NPC.unlockedMerchantSpawn = reader.ReadBoolean();
      NPC.unlockedDemolitionistSpawn = reader.ReadBoolean();
      NPC.unlockedPartyGirlSpawn = reader.ReadBoolean();
      NPC.unlockedDyeTraderSpawn = reader.ReadBoolean();
      NPC.unlockedTruffleSpawn = reader.ReadBoolean();
      NPC.unlockedArmsDealerSpawn = reader.ReadBoolean();
      NPC.unlockedNurseSpawn = reader.ReadBoolean();
      NPC.unlockedPrincessSpawn = reader.ReadBoolean();
    }
    else
    {
      NPC.unlockedMerchantSpawn = false;
      NPC.unlockedDemolitionistSpawn = false;
      NPC.unlockedPartyGirlSpawn = false;
      NPC.unlockedDyeTraderSpawn = false;
      NPC.unlockedTruffleSpawn = false;
      NPC.unlockedArmsDealerSpawn = false;
      NPC.unlockedNurseSpawn = false;
      NPC.unlockedPrincessSpawn = false;
    }
    NPC.combatBookVolumeTwoWasUsed = versionNumber >= 259 && reader.ReadBoolean();
    NPC.peddlersSatchelWasUsed = versionNumber >= 260 && reader.ReadBoolean();
    if (versionNumber >= 261)
    {
      NPC.unlockedSlimeGreenSpawn = reader.ReadBoolean();
      NPC.unlockedSlimeOldSpawn = reader.ReadBoolean();
      NPC.unlockedSlimePurpleSpawn = reader.ReadBoolean();
      NPC.unlockedSlimeRainbowSpawn = reader.ReadBoolean();
      NPC.unlockedSlimeRedSpawn = reader.ReadBoolean();
      NPC.unlockedSlimeYellowSpawn = reader.ReadBoolean();
      NPC.unlockedSlimeCopperSpawn = reader.ReadBoolean();
    }
    else
    {
      NPC.unlockedSlimeGreenSpawn = false;
      NPC.unlockedSlimeOldSpawn = false;
      NPC.unlockedSlimePurpleSpawn = false;
      NPC.unlockedSlimeRainbowSpawn = false;
      NPC.unlockedSlimeRedSpawn = false;
      NPC.unlockedSlimeYellowSpawn = false;
      NPC.unlockedSlimeCopperSpawn = false;
    }
    if (versionNumber >= 264)
    {
      Main.fastForwardTimeToDusk = reader.ReadBoolean();
      Main.moondialCooldown = (int) reader.ReadByte();
    }
    else
    {
      Main.fastForwardTimeToDusk = false;
      Main.moondialCooldown = 0;
    }
    if (versionNumber >= 287)
    {
      Main.forceHalloweenForever = reader.ReadBoolean();
      Main.forceXMasForever = reader.ReadBoolean();
    }
    else
    {
      Main.forceHalloweenForever = false;
      Main.forceXMasForever = false;
    }
    Main.vampireSeed = versionNumber >= 288 && reader.ReadBoolean();
    Main.infectedSeed = versionNumber >= 296 && reader.ReadBoolean();
    if (versionNumber >= 291)
    {
      WorldFile._tempMeteorShowerCount = reader.ReadInt32();
      WorldFile._tempCoinRain = reader.ReadInt32();
    }
    else
    {
      WorldFile._tempMeteorShowerCount = 0;
      WorldFile._tempCoinRain = 0;
    }
    if (versionNumber >= 297)
    {
      Main.teamBasedSpawnsSeed = reader.ReadBoolean();
      ExtraSpawnPointManager.Read(reader);
    }
    else
    {
      Main.teamBasedSpawnsSeed = false;
      ExtraSpawnPointManager.Clear();
    }
    Main.dualDungeonsSeed = versionNumber >= 304 && reader.ReadBoolean();
    Main.UpdateTimeRate();
    if (versionNumber >= 299 && versionNumber < 313)
    {
      int num1 = (int) reader.ReadUInt32();
    }
    WorldGen.Manifest = WorldManifest.Deserialize(versionNumber < 299 ? "" : reader.ReadString());
  }

  public static void LoadWorldTiles(BinaryReader reader, bool[] importance)
  {
    for (int index1 = 0; index1 < Main.maxTilesX; ++index1)
    {
      float num1 = (float) index1 / (float) Main.maxTilesX;
      Main.statusText = $"{Lang.gen[51].Value} {(object) (int) ((double) num1 * 100.0 + 1.0)}%";
      for (int index2 = 0; index2 < Main.maxTilesY; ++index2)
      {
        int index3 = -1;
        int num2;
        byte num3 = (byte) (num2 = 0);
        byte num4 = (byte) num2;
        byte num5 = (byte) num2;
        Tile from = Main.tile[index1, index2];
        byte num6 = reader.ReadByte();
        bool flag1 = false;
        if (((int) num6 & 1) == 1)
        {
          flag1 = true;
          num5 = reader.ReadByte();
        }
        bool flag2 = false;
        if (flag1 && ((int) num5 & 1) == 1)
        {
          flag2 = true;
          num4 = reader.ReadByte();
        }
        if (flag2 && ((int) num4 & 1) == 1)
          num3 = reader.ReadByte();
        if (((int) num6 & 2) == 2)
        {
          from.active(true);
          if (((int) num6 & 32 /*0x20*/) == 32 /*0x20*/)
          {
            byte num7 = reader.ReadByte();
            index3 = (int) reader.ReadByte() << 8 | (int) num7;
          }
          else
            index3 = (int) reader.ReadByte();
          from.type = (ushort) index3;
          if (importance[index3])
          {
            from.frameX = reader.ReadInt16();
            from.frameY = reader.ReadInt16();
            if (from.type == (ushort) 144 /*0x90*/)
              from.frameY = (short) 0;
          }
          else
          {
            from.frameX = (short) -1;
            from.frameY = (short) -1;
          }
          if (((int) num4 & 8) == 8)
            from.color(reader.ReadByte());
        }
        if (((int) num6 & 4) == 4)
        {
          from.wall = (ushort) reader.ReadByte();
          if ((int) from.wall >= (int) WallID.Count)
            from.wall = (ushort) 0;
          if (((int) num4 & 16 /*0x10*/) == 16 /*0x10*/)
            from.wallColor(reader.ReadByte());
        }
        byte num8 = (byte) (((int) num6 & 24) >> 3);
        if (num8 != (byte) 0)
        {
          from.liquid = reader.ReadByte();
          if (((int) num4 & 128 /*0x80*/) == 128 /*0x80*/)
            from.shimmer(true);
          else if (num8 > (byte) 1)
          {
            if (num8 == (byte) 2)
              from.lava(true);
            else
              from.honey(true);
          }
        }
        if (num5 > (byte) 1)
        {
          if (((int) num5 & 2) == 2)
            from.wire(true);
          if (((int) num5 & 4) == 4)
            from.wire2(true);
          if (((int) num5 & 8) == 8)
            from.wire3(true);
          byte num9 = (byte) (((int) num5 & 112 /*0x70*/) >> 4);
          if (num9 != (byte) 0 && TileID.Sets.SaveSlopes[(int) from.type])
          {
            if (num9 == (byte) 1)
              from.halfBrick(true);
            else
              from.slope((byte) ((uint) num9 - 1U));
          }
        }
        if (num4 > (byte) 1)
        {
          if (((int) num4 & 2) == 2)
            from.actuator(true);
          if (((int) num4 & 4) == 4)
            from.inActive(true);
          if (((int) num4 & 32 /*0x20*/) == 32 /*0x20*/)
            from.wire4(true);
          if (((int) num4 & 64 /*0x40*/) == 64 /*0x40*/)
          {
            byte num10 = reader.ReadByte();
            from.wall = (ushort) ((uint) num10 << 8 | (uint) from.wall);
            if ((int) from.wall >= (int) WallID.Count)
              from.wall = (ushort) 0;
          }
        }
        if (num3 > (byte) 1)
        {
          if (((int) num3 & 2) == 2)
            from.invisibleBlock(true);
          if (((int) num3 & 4) == 4)
            from.invisibleWall(true);
          if (((int) num3 & 8) == 8)
            from.fullbrightBlock(true);
          if (((int) num3 & 16 /*0x10*/) == 16 /*0x10*/)
            from.fullbrightWall(true);
        }
        int num11;
        switch ((byte) (((int) num6 & 192 /*0xC0*/) >> 6))
        {
          case 0:
            num11 = 0;
            break;
          case 1:
            num11 = (int) reader.ReadByte();
            break;
          default:
            num11 = (int) reader.ReadInt16();
            break;
        }
        if (index3 != -1)
        {
          if ((double) index2 <= Main.worldSurface)
          {
            if ((double) (index2 + num11) <= Main.worldSurface)
            {
              WorldGen.tileCounts[index3] += (num11 + 1) * 5;
            }
            else
            {
              int num12 = (int) (Main.worldSurface - (double) index2 + 1.0);
              int num13 = num11 + 1 - num12;
              WorldGen.tileCounts[index3] += num12 * 5 + num13;
            }
          }
          else
            WorldGen.tileCounts[index3] += num11 + 1;
        }
        for (; num11 > 0; --num11)
        {
          ++index2;
          Main.tile[index1, index2].CopyFrom(from);
        }
      }
    }
    WorldGen.AddUpAlignmentCounts(true);
    if (WorldFile._versionNumber >= 105)
      return;
    WorldGen.FixHearts();
  }

  public static void LoadChests(BinaryReader reader)
  {
    int num1 = (int) reader.ReadInt16();
    int num2 = 0;
    if (WorldFile._versionNumber < 294)
      num2 = (int) reader.ReadInt16();
    int num3;
    for (num3 = 0; num3 < num1; ++num3)
    {
      int x = reader.ReadInt32();
      int y = reader.ReadInt32();
      Chest worldChest = Chest.CreateWorldChest(num3, x, y);
      worldChest.name = reader.ReadString();
      if (WorldFile._versionNumber >= 294)
      {
        int newSize = reader.ReadInt32();
        worldChest.Resize(newSize);
        num2 = newSize;
      }
      int num4;
      int num5;
      if (num2 < worldChest.maxItems)
      {
        num4 = num2;
        num5 = 0;
      }
      else
      {
        num4 = worldChest.maxItems;
        num5 = num2 - worldChest.maxItems;
      }
      for (int index = 0; index < num4; ++index)
      {
        short num6 = reader.ReadInt16();
        Item obj = new Item();
        if (num6 > (short) 0)
        {
          obj.netDefaults(reader.ReadInt32());
          obj.stack = (int) num6;
          obj.Prefix((int) reader.ReadByte());
        }
        else if (num6 < (short) 0)
        {
          obj.netDefaults(reader.ReadInt32());
          obj.Prefix((int) reader.ReadByte());
          obj.stack = 1;
        }
        worldChest.item[index] = obj;
      }
      for (int index = 0; index < num5; ++index)
      {
        if (reader.ReadInt16() > (short) 0)
        {
          reader.ReadInt32();
          int num7 = (int) reader.ReadByte();
        }
      }
    }
    List<Point16> point16List = new List<Point16>();
    for (int chestIndex = 0; chestIndex < num3; ++chestIndex)
    {
      if (Main.chest[chestIndex] != null)
      {
        Point16 point16 = new Point16(Main.chest[chestIndex].x, Main.chest[chestIndex].y);
        if (point16List.Contains(point16))
          Chest.RemoveChest(chestIndex);
        else
          point16List.Add(point16);
      }
    }
    for (; num3 < 8000; ++num3)
      Chest.RemoveChest(num3);
    if (WorldFile._versionNumber >= 115)
      return;
    WorldFile.FixDresserChests();
  }

  private static void ConvertIlluminantPaintToNewField()
  {
    for (int index1 = 0; index1 < Main.maxTilesX; ++index1)
    {
      for (int index2 = 0; index2 < Main.maxTilesY; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile.active() && tile.color() == (byte) 31 /*0x1F*/)
        {
          tile.color((byte) 0);
          tile.fullbrightBlock(true);
        }
        if (tile.wallColor() == (byte) 31 /*0x1F*/)
        {
          tile.wallColor((byte) 0);
          tile.fullbrightWall(true);
        }
      }
    }
  }

  public static void LoadSigns(BinaryReader reader)
  {
    short num = reader.ReadInt16();
    int index1;
    for (index1 = 0; index1 < (int) num; ++index1)
    {
      string str = reader.ReadString();
      int index2 = reader.ReadInt32();
      int index3 = reader.ReadInt32();
      Tile tile = Main.tile[index2, index3];
      Sign sign;
      if (tile.active() && Main.tileSign[(int) tile.type])
      {
        sign = new Sign();
        sign.text = str;
        sign.x = index2;
        sign.y = index3;
      }
      else
        sign = (Sign) null;
      Main.sign[index1] = sign;
    }
    List<Point16> point16List = new List<Point16>();
    for (int index4 = 0; index4 < 32000; ++index4)
    {
      if (Main.sign[index4] != null)
      {
        Point16 point16 = new Point16(Main.sign[index4].x, Main.sign[index4].y);
        if (point16List.Contains(point16))
          Main.sign[index4] = (Sign) null;
        else
          point16List.Add(point16);
      }
    }
    for (; index1 < 32000; ++index1)
      Main.sign[index1] = (Sign) null;
  }

  public static void LoadDummies(BinaryReader reader)
  {
    int num1 = reader.ReadInt32();
    for (int index = 0; index < num1; ++index)
    {
      int num2 = (int) reader.ReadInt16();
      int num3 = (int) reader.ReadInt16();
    }
  }

  public static void LoadNPCs(BinaryReader reader)
  {
    if (WorldFile._versionNumber >= 268)
    {
      int num = reader.ReadInt32();
      while (num-- > 0)
        NPC.ShimmeredTownNPCs[reader.ReadInt32()] = true;
    }
    int index = 0;
    for (bool flag = reader.ReadBoolean(); flag; flag = reader.ReadBoolean())
    {
      NPC npc = Main.npc[index];
      if (WorldFile._versionNumber >= 190)
        npc.SetDefaults(reader.ReadInt32());
      else
        npc.SetDefaults(NPCID.FromLegacyName(reader.ReadString()));
      npc.GivenName = reader.ReadString();
      npc.position.X = reader.ReadSingle();
      npc.position.Y = reader.ReadSingle();
      npc.homeless = reader.ReadBoolean();
      npc.homeTileX = reader.ReadInt32();
      npc.homeTileY = reader.ReadInt32();
      if (WorldFile._versionNumber >= 213 && ((BitsByte) reader.ReadByte())[0])
        npc.townNpcVariationIndex = reader.ReadInt32();
      if (WorldFile._versionNumber >= 315)
        npc.homelessDespawn = reader.ReadBoolean();
      ++index;
    }
    if (WorldFile._versionNumber >= 140)
    {
      for (bool flag = reader.ReadBoolean(); flag; flag = reader.ReadBoolean())
      {
        NPC npc = Main.npc[index];
        if (WorldFile._versionNumber >= 190)
          npc.SetDefaults(reader.ReadInt32());
        else
          npc.SetDefaults(NPCID.FromLegacyName(reader.ReadString()));
        npc.position = reader.ReadVector2();
        ++index;
      }
    }
    if (WorldFile._versionNumber >= 251)
      return;
    NPC.unlockedMerchantSpawn = NPC.AnyNPCs(17);
    NPC.unlockedDemolitionistSpawn = NPC.AnyNPCs(38);
    NPC.unlockedPartyGirlSpawn = NPC.AnyNPCs(208 /*0xD0*/);
    NPC.unlockedDyeTraderSpawn = NPC.AnyNPCs(207);
    NPC.unlockedTruffleSpawn = NPC.AnyNPCs(160 /*0xA0*/);
    NPC.unlockedArmsDealerSpawn = NPC.AnyNPCs(19);
    NPC.unlockedNurseSpawn = NPC.AnyNPCs(18);
    NPC.unlockedPrincessSpawn = NPC.AnyNPCs(663);
  }

  public static void ValidateLoadNPCs(BinaryReader fileIO)
  {
    int num1 = fileIO.ReadInt32();
    while (num1-- > 0)
      fileIO.ReadInt32();
    for (bool flag = fileIO.ReadBoolean(); flag; flag = fileIO.ReadBoolean())
    {
      fileIO.ReadInt32();
      fileIO.ReadString();
      double num2 = (double) fileIO.ReadSingle();
      double num3 = (double) fileIO.ReadSingle();
      fileIO.ReadBoolean();
      fileIO.ReadInt32();
      fileIO.ReadInt32();
      if (((BitsByte) fileIO.ReadByte())[0])
        fileIO.ReadInt32();
      fileIO.ReadBoolean();
    }
    for (bool flag = fileIO.ReadBoolean(); flag; flag = fileIO.ReadBoolean())
    {
      fileIO.ReadInt32();
      double num4 = (double) fileIO.ReadSingle();
      double num5 = (double) fileIO.ReadSingle();
    }
  }

  public static int LoadFooter(BinaryReader reader)
  {
    return !reader.ReadBoolean() || reader.ReadString() != Main.worldName || reader.ReadInt32() != Main.ActiveWorldFileData.WorldId ? StatusID.BadFooter : StatusID.Ok;
  }

  public static bool ValidateWorld(BinaryReader fileIO)
  {
    new Stopwatch().Start();
    try
    {
      Stream baseStream = fileIO.BaseStream;
      int num1 = fileIO.ReadInt32();
      if (num1 == 0 || num1 > 318)
        return false;
      baseStream.Position = 0L;
      bool[] importance;
      int[] positions;
      if (!WorldFile.LoadFileFormatHeader(fileIO, out importance, out positions))
        return false;
      string str1 = fileIO.ReadString();
      if (num1 >= 179)
      {
        if (num1 == 179)
          fileIO.ReadInt32();
        else
          fileIO.ReadString();
        long num2 = (long) fileIO.ReadUInt64();
      }
      if (num1 >= 181)
        fileIO.ReadBytes(16 /*0x10*/);
      int num3 = fileIO.ReadInt32();
      fileIO.ReadInt32();
      fileIO.ReadInt32();
      fileIO.ReadInt32();
      fileIO.ReadInt32();
      int num4 = fileIO.ReadInt32();
      int num5 = fileIO.ReadInt32();
      baseStream.Position = (long) positions[1];
      for (int index1 = 0; index1 < num5; ++index1)
      {
        float num6 = (float) index1 / (float) Main.maxTilesX;
        Main.statusText = $"{Lang.gen[73].Value} {(object) (int) ((double) num6 * 100.0 + 1.0)}%";
        int num7;
        for (int index2 = 0; index2 < num4; index2 = index2 + num7 + 1)
        {
          byte num8;
          byte num9 = num8 = (byte) 0;
          byte num10 = fileIO.ReadByte();
          bool flag1 = false;
          if (((int) num10 & 1) == 1)
          {
            flag1 = true;
            num9 = fileIO.ReadByte();
          }
          bool flag2 = false;
          if (flag1 && ((int) num9 & 1) == 1)
          {
            flag2 = true;
            num8 = fileIO.ReadByte();
          }
          if (flag2 && ((int) num8 & 1) == 1)
          {
            int num11 = (int) fileIO.ReadByte();
          }
          if (((int) num10 & 2) == 2)
          {
            int index3;
            if (((int) num10 & 32 /*0x20*/) == 32 /*0x20*/)
            {
              byte num12 = fileIO.ReadByte();
              index3 = (int) fileIO.ReadByte() << 8 | (int) num12;
            }
            else
              index3 = (int) fileIO.ReadByte();
            if (importance[index3])
            {
              int num13 = (int) fileIO.ReadInt16();
              int num14 = (int) fileIO.ReadInt16();
            }
            if (((int) num8 & 8) == 8)
            {
              int num15 = (int) fileIO.ReadByte();
            }
          }
          if (((int) num10 & 4) == 4)
          {
            int num16 = (int) fileIO.ReadByte();
            if (((int) num8 & 16 /*0x10*/) == 16 /*0x10*/)
            {
              int num17 = (int) fileIO.ReadByte();
            }
          }
          if (((int) num10 & 24) >> 3 != 0)
          {
            int num18 = (int) fileIO.ReadByte();
          }
          if (((int) num8 & 64 /*0x40*/) == 64 /*0x40*/)
          {
            int num19 = (int) fileIO.ReadByte();
          }
          switch ((byte) (((int) num10 & 192 /*0xC0*/) >> 6))
          {
            case 0:
              num7 = 0;
              break;
            case 1:
              num7 = (int) fileIO.ReadByte();
              break;
            default:
              num7 = (int) fileIO.ReadInt16();
              break;
          }
        }
      }
      if (baseStream.Position != (long) positions[2])
        return false;
      int num20 = (int) fileIO.ReadInt16();
      int num21 = 0;
      if (num1 < 294)
        num21 = (int) fileIO.ReadInt16();
      for (int index4 = 0; index4 < num20; ++index4)
      {
        fileIO.ReadInt32();
        fileIO.ReadInt32();
        fileIO.ReadString();
        if (num1 >= 294)
          num21 = fileIO.ReadInt32();
        for (int index5 = 0; index5 < num21; ++index5)
        {
          if (fileIO.ReadInt16() > (short) 0)
          {
            fileIO.ReadInt32();
            int num22 = (int) fileIO.ReadByte();
          }
        }
      }
      if (baseStream.Position != (long) positions[3])
        return false;
      int num23 = (int) fileIO.ReadInt16();
      for (int index = 0; index < num23; ++index)
      {
        fileIO.ReadString();
        fileIO.ReadInt32();
        fileIO.ReadInt32();
      }
      if (baseStream.Position != (long) positions[4])
        return false;
      WorldFile.ValidateLoadNPCs(fileIO);
      if (baseStream.Position != (long) positions[5])
        return false;
      if (WorldFile._versionNumber >= 116 && WorldFile._versionNumber <= 121)
      {
        int num24 = fileIO.ReadInt32();
        for (int index = 0; index < num24; ++index)
        {
          int num25 = (int) fileIO.ReadInt16();
          int num26 = (int) fileIO.ReadInt16();
        }
        if (baseStream.Position != (long) positions[6])
          return false;
      }
      if (WorldFile._versionNumber >= 122)
      {
        int num27 = fileIO.ReadInt32();
        for (int index = 0; index < num27; ++index)
          TileEntity.Read(fileIO, WorldFile._versionNumber);
      }
      if (WorldFile._versionNumber >= 170)
      {
        int num28 = fileIO.ReadInt32();
        for (int index = 0; index < num28; ++index)
          fileIO.ReadInt64();
      }
      if (WorldFile._versionNumber >= 189)
      {
        int num29 = fileIO.ReadInt32();
        fileIO.ReadBytes(12 * num29);
      }
      if (WorldFile._versionNumber >= 210)
        Main.BestiaryTracker.ValidateWorld(fileIO, WorldFile._versionNumber);
      if (WorldFile._versionNumber >= 220)
        CreativePowerManager.Instance.ValidateWorld(fileIO, WorldFile._versionNumber);
      int num30 = fileIO.ReadBoolean() ? 1 : 0;
      string str2 = fileIO.ReadString();
      int num31 = fileIO.ReadInt32();
      bool flag = false;
      if (num30 != 0 && (str2 == str1 || num31 == num3))
        flag = true;
      return flag;
    }
    catch (Exception ex)
    {
      using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
      {
        streamWriter.WriteLine((object) DateTime.Now);
        streamWriter.WriteLine((object) ex);
        streamWriter.WriteLine("");
      }
      return false;
    }
  }

  public static FileMetadata GetFileMetadata(string file, bool cloudSave)
  {
    if (file == null)
      return (FileMetadata) null;
    try
    {
      byte[] buffer = (byte[]) null;
      int num = !cloudSave ? 0 : (SocialAPI.Cloud != null ? 1 : 0);
      if (num != 0)
      {
        int length = 24;
        buffer = new byte[length];
        SocialAPI.Cloud.Read(file, buffer, length);
      }
      using (Stream input = num != 0 ? (Stream) new MemoryStream(buffer) : (Stream) new FileStream(file, FileMode.Open))
      {
        using (BinaryReader reader = new BinaryReader(input))
          return reader.ReadInt32() >= 135 ? FileMetadata.Read(reader, FileType.World) : FileMetadata.FromCurrentSettings(FileType.World);
      }
    }
    catch
    {
    }
    return (FileMetadata) null;
  }

  private static void FixDresserChests()
  {
    for (int X = 0; X < Main.maxTilesX; ++X)
    {
      for (int Y = 0; Y < Main.maxTilesY; ++Y)
      {
        Tile tile = Main.tile[X, Y];
        if (tile.active() && tile.type == (ushort) 88 && (int) tile.frameX % 54 == 0 && (int) tile.frameY % 36 == 0)
          Chest.CreateChest(X, Y);
      }
    }
  }

  private static void FixEndlessRainWorlds()
  {
    if (WorldFile._versionNumber > 317 || WorldFile._tempRainTime < 5184000)
      return;
    foreach (string secretSeedCode in Main.ActiveWorldFileData.GetSecretSeedCodes())
    {
      if (WorldGen.SecretSeed.rainsForAYear.Check(secretSeedCode))
        return;
    }
    WorldFile._tempRaining = false;
    WorldFile._tempRainTime = 0;
    WorldFile._tempMaxRain = 0.0f;
  }

  public static int SaveTileEntities(BinaryWriter writer)
  {
    lock (TileEntity.EntityCreationLock)
    {
      writer.Write(TileEntity.ByID.Count);
      foreach (KeyValuePair<int, TileEntity> keyValuePair in TileEntity.ByID)
        TileEntity.Write(writer, keyValuePair.Value);
    }
    return (int) writer.BaseStream.Position;
  }

  public static void LoadTileEntities(BinaryReader reader)
  {
    TileEntity.Clear();
    int num1 = reader.ReadInt32();
    int num2 = 0;
    for (int index = 0; index < num1; ++index)
    {
      TileEntity ent = TileEntity.Read(reader, WorldFile._versionNumber);
      ent.ID = num2++;
      TileEntity result;
      if (TileEntity.TryGetAt<TileEntity>((int) ent.Position.X, (int) ent.Position.Y, out result))
        TileEntity.Remove(result);
      TileEntity.Add(ent);
    }
    TileEntity.TileEntitiesNextID = num1;
    List<TileEntity> tileEntityList = new List<TileEntity>();
    foreach (KeyValuePair<Point16, TileEntity> keyValuePair in TileEntity.ByPosition)
    {
      if (!WorldGen.InWorld((int) keyValuePair.Value.Position.X, (int) keyValuePair.Value.Position.Y, 1))
        tileEntityList.Add(keyValuePair.Value);
      else if (!TileEntity.manager.CheckValidTile((int) keyValuePair.Value.type, (int) keyValuePair.Value.Position.X, (int) keyValuePair.Value.Position.Y))
        tileEntityList.Add(keyValuePair.Value);
    }
    try
    {
      foreach (TileEntity entity in tileEntityList)
        TileEntity.Remove(entity);
    }
    catch
    {
    }
    foreach (TileEntity tileEntity in TileEntity.ByID.Values)
      tileEntity.OnWorldLoaded();
  }

  public static int SaveWeightedPressurePlates(BinaryWriter writer)
  {
    lock (PressurePlateHelper.EntityCreationLock)
    {
      writer.Write(PressurePlateHelper.PressurePlatesPressed.Count);
      foreach (KeyValuePair<Point, bool[]> keyValuePair in PressurePlateHelper.PressurePlatesPressed)
      {
        writer.Write(keyValuePair.Key.X);
        writer.Write(keyValuePair.Key.Y);
      }
    }
    return (int) writer.BaseStream.Position;
  }

  public static void LoadWeightedPressurePlates(BinaryReader reader)
  {
    PressurePlateHelper.Reset();
    PressurePlateHelper.NeedsFirstUpdate = true;
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
    {
      Point key = new Point(reader.ReadInt32(), reader.ReadInt32());
      PressurePlateHelper.PressurePlatesPressed.Add(key, new bool[(int) byte.MaxValue]);
    }
  }

  public static int SaveTownManager(BinaryWriter writer)
  {
    WorldGen.TownManager.Save(writer);
    return (int) writer.BaseStream.Position;
  }

  public static void LoadTownManager(BinaryReader reader) => WorldGen.TownManager.Load(reader);

  public static int SaveBestiary(BinaryWriter writer)
  {
    Main.BestiaryTracker.Save(writer);
    return (int) writer.BaseStream.Position;
  }

  public static void LoadBestiary(BinaryReader reader, int loadVersionNumber)
  {
    Main.BestiaryTracker.Load(reader, loadVersionNumber);
  }

  private static void LoadBestiaryForVersionsBefore210()
  {
    Main.BestiaryTracker.FillBasedOnVersionBefore210();
  }

  public static int SaveCreativePowers(BinaryWriter writer)
  {
    CreativePowerManager.Instance.SaveToWorld(writer);
    return (int) writer.BaseStream.Position;
  }

  public static void LoadCreativePowers(BinaryReader reader, int loadVersionNumber)
  {
    CreativePowerManager.Instance.LoadFromWorld(reader, loadVersionNumber);
  }

  private static int LoadWorld_Version1_Old_BeforeRelease88(BinaryReader fileIO)
  {
    Main.WorldFileMetadata = FileMetadata.FromCurrentSettings(FileType.World);
    int versionNumber = WorldFile._versionNumber;
    if (versionNumber > 318)
      return StatusID.LaterVersion;
    Main.worldName = fileIO.ReadString();
    Main.ActiveWorldFileData.WorldId = fileIO.ReadInt32();
    Main.leftWorld = (float) fileIO.ReadInt32();
    Main.rightWorld = (float) fileIO.ReadInt32();
    Main.topWorld = (float) fileIO.ReadInt32();
    Main.bottomWorld = (float) fileIO.ReadInt32();
    Main.maxTilesY = fileIO.ReadInt32();
    Main.maxTilesX = fileIO.ReadInt32();
    Main.GameMode = versionNumber < 112 /*0x70*/ ? 0 : (fileIO.ReadBoolean() ? 1 : 0);
    if (versionNumber >= 63 /*0x3F*/)
      Main.moonType = (int) fileIO.ReadByte();
    else
      WorldGen.RandomizeMoonState(WorldGen.genRand);
    WorldGen.clearWorld();
    if (versionNumber >= 44)
    {
      Main.treeX[0] = fileIO.ReadInt32();
      Main.treeX[1] = fileIO.ReadInt32();
      Main.treeX[2] = fileIO.ReadInt32();
      Main.treeStyle[0] = fileIO.ReadInt32();
      Main.treeStyle[1] = fileIO.ReadInt32();
      Main.treeStyle[2] = fileIO.ReadInt32();
      Main.treeStyle[3] = fileIO.ReadInt32();
    }
    if (versionNumber >= 60)
    {
      Main.caveBackX[0] = fileIO.ReadInt32();
      Main.caveBackX[1] = fileIO.ReadInt32();
      Main.caveBackX[2] = fileIO.ReadInt32();
      Main.caveBackStyle[0] = fileIO.ReadInt32();
      Main.caveBackStyle[1] = fileIO.ReadInt32();
      Main.caveBackStyle[2] = fileIO.ReadInt32();
      Main.caveBackStyle[3] = fileIO.ReadInt32();
      Main.iceBackStyle = fileIO.ReadInt32();
      if (versionNumber >= 61)
      {
        Main.jungleBackStyle = fileIO.ReadInt32();
        Main.hellBackStyle = fileIO.ReadInt32();
      }
    }
    else
      WorldGen.RandomizeCaveBackgrounds();
    Main.spawnTileX = fileIO.ReadInt32();
    Main.spawnTileY = fileIO.ReadInt32();
    Main.worldSurface = fileIO.ReadDouble();
    Main.rockLayer = fileIO.ReadDouble();
    WorldFile._tempTime = fileIO.ReadDouble();
    WorldFile._tempDayTime = fileIO.ReadBoolean();
    WorldFile._tempMoonPhase = fileIO.ReadInt32();
    WorldFile._tempBloodMoon = fileIO.ReadBoolean();
    if (versionNumber >= 70)
    {
      WorldFile._tempEclipse = fileIO.ReadBoolean();
      Main.eclipse = WorldFile._tempEclipse;
    }
    Main.dungeonX = fileIO.ReadInt32();
    Main.dungeonY = fileIO.ReadInt32();
    WorldGen.crimson = versionNumber >= 56 && fileIO.ReadBoolean();
    NPC.downedBoss1 = fileIO.ReadBoolean();
    NPC.downedBoss2 = fileIO.ReadBoolean();
    NPC.downedBoss3 = fileIO.ReadBoolean();
    if (versionNumber >= 66)
      NPC.downedQueenBee = fileIO.ReadBoolean();
    if (versionNumber >= 44)
    {
      NPC.downedMechBoss1 = fileIO.ReadBoolean();
      NPC.downedMechBoss2 = fileIO.ReadBoolean();
      NPC.downedMechBoss3 = fileIO.ReadBoolean();
      NPC.downedMechBossAny = fileIO.ReadBoolean();
    }
    if (versionNumber >= 64 /*0x40*/)
    {
      NPC.downedPlantBoss = fileIO.ReadBoolean();
      NPC.downedGolemBoss = fileIO.ReadBoolean();
    }
    if (versionNumber >= 29)
    {
      NPC.savedGoblin = fileIO.ReadBoolean();
      NPC.savedWizard = fileIO.ReadBoolean();
      if (versionNumber >= 34)
      {
        NPC.savedMech = fileIO.ReadBoolean();
        if (versionNumber >= 80 /*0x50*/)
          NPC.savedStylist = fileIO.ReadBoolean();
      }
      if (versionNumber >= 129)
        NPC.savedTaxCollector = fileIO.ReadBoolean();
      if (versionNumber >= 201)
        NPC.savedGolfer = fileIO.ReadBoolean();
      NPC.downedGoblins = fileIO.ReadBoolean();
    }
    if (versionNumber >= 32 /*0x20*/)
      NPC.downedClown = fileIO.ReadBoolean();
    if (versionNumber >= 37)
      NPC.downedFrost = fileIO.ReadBoolean();
    if (versionNumber >= 56)
      NPC.downedPirates = fileIO.ReadBoolean();
    WorldGen.shadowOrbSmashed = fileIO.ReadBoolean();
    WorldGen.spawnMeteor = fileIO.ReadBoolean();
    WorldGen.shadowOrbCount = (int) fileIO.ReadByte();
    if (versionNumber >= 23)
    {
      WorldGen.altarCount = fileIO.ReadInt32();
      Main.hardMode = fileIO.ReadBoolean();
    }
    Main.invasionDelay = fileIO.ReadInt32();
    Main.invasionSize = fileIO.ReadInt32();
    Main.invasionType = fileIO.ReadInt32();
    Main.invasionX = fileIO.ReadDouble();
    if (versionNumber >= 113)
      Main.sundialCooldown = (int) fileIO.ReadByte();
    if (versionNumber >= 53)
    {
      WorldFile._tempRaining = fileIO.ReadBoolean();
      WorldFile._tempRainTime = fileIO.ReadInt32();
      WorldFile._tempMaxRain = fileIO.ReadSingle();
    }
    if (versionNumber >= 54)
    {
      WorldGen.SavedOreTiers.Cobalt = fileIO.ReadInt32();
      WorldGen.SavedOreTiers.Mythril = fileIO.ReadInt32();
      WorldGen.SavedOreTiers.Adamantite = fileIO.ReadInt32();
    }
    else if (versionNumber >= 23 && WorldGen.altarCount == 0)
    {
      WorldGen.SavedOreTiers.Cobalt = -1;
      WorldGen.SavedOreTiers.Mythril = -1;
      WorldGen.SavedOreTiers.Adamantite = -1;
    }
    else
    {
      WorldGen.SavedOreTiers.Cobalt = 107;
      WorldGen.SavedOreTiers.Mythril = 108;
      WorldGen.SavedOreTiers.Adamantite = 111;
    }
    int style1 = 0;
    int style2 = 0;
    int style3 = 0;
    int style4 = 0;
    int style5 = 0;
    int style6 = 0;
    int style7 = 0;
    int style8 = 0;
    int style9 = 0;
    int style10 = 0;
    if (versionNumber >= 55)
    {
      style1 = (int) fileIO.ReadByte();
      style2 = (int) fileIO.ReadByte();
      style3 = (int) fileIO.ReadByte();
    }
    if (versionNumber >= 60)
    {
      style4 = (int) fileIO.ReadByte();
      style5 = (int) fileIO.ReadByte();
      style6 = (int) fileIO.ReadByte();
      style7 = (int) fileIO.ReadByte();
      style8 = (int) fileIO.ReadByte();
    }
    WorldGen.setBG(0, style1);
    WorldGen.setBG(1, style2);
    WorldGen.setBG(2, style3);
    WorldGen.setBG(3, style4);
    WorldGen.setBG(4, style5);
    WorldGen.setBG(5, style6);
    WorldGen.setBG(6, style7);
    WorldGen.setBG(7, style8);
    WorldGen.setBG(8, style9);
    WorldGen.setBG(9, style10);
    WorldGen.setBG(10, style1);
    WorldGen.setBG(11, style1);
    WorldGen.setBG(12, style1);
    if (versionNumber >= 60)
    {
      Main.cloudBGActive = (float) fileIO.ReadInt32();
      Main.cloudBGAlpha = (double) Main.cloudBGActive < 1.0 ? 0.0f : 1f;
    }
    else
      Main.cloudBGActive = (float) -WorldGen.genRand.Next(8640, 86400);
    if (versionNumber >= 62)
    {
      Main.numClouds = (int) fileIO.ReadInt16();
      Main.windSpeedTarget = fileIO.ReadSingle();
      Main.windSpeedCurrent = Main.windSpeedTarget;
    }
    else
      WorldGen.RandomizeWeather();
    for (int index1 = 0; index1 < Main.maxTilesX; ++index1)
    {
      float num1 = (float) index1 / (float) Main.maxTilesX;
      Main.statusText = $"{Lang.gen[51].Value} {(object) (int) ((double) num1 * 100.0 + 1.0)}%";
      for (int index2 = 0; index2 < Main.maxTilesY; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        int index3 = -1;
        tile.active(fileIO.ReadBoolean());
        if (tile.active())
        {
          index3 = versionNumber <= 77 ? (int) fileIO.ReadByte() : (int) fileIO.ReadUInt16();
          tile.type = (ushort) index3;
          if (tile.type == (ushort) sbyte.MaxValue || tile.type == (ushort) 504)
            tile.active(false);
          if (versionNumber < 72 && (tile.type == (ushort) 35 || tile.type == (ushort) 36 || tile.type == (ushort) 170 || tile.type == (ushort) 171 || tile.type == (ushort) 172))
          {
            tile.frameX = fileIO.ReadInt16();
            tile.frameY = fileIO.ReadInt16();
          }
          else if (Main.tileFrameImportant[index3])
          {
            if (versionNumber < 28 && index3 == 4)
            {
              tile.frameX = (short) 0;
              tile.frameY = (short) 0;
            }
            else if (versionNumber < 40 && tile.type == (ushort) 19)
            {
              tile.frameX = (short) 0;
              tile.frameY = (short) 0;
            }
            else if (versionNumber < 195 && tile.type == (ushort) 49)
            {
              tile.frameX = (short) 0;
              tile.frameY = (short) 0;
            }
            else
            {
              tile.frameX = fileIO.ReadInt16();
              tile.frameY = fileIO.ReadInt16();
              if (tile.type == (ushort) 144 /*0x90*/)
                tile.frameY = (short) 0;
            }
          }
          else
          {
            tile.frameX = (short) -1;
            tile.frameY = (short) -1;
          }
          if (versionNumber >= 48 /*0x30*/ && fileIO.ReadBoolean())
            tile.color(fileIO.ReadByte());
        }
        if (versionNumber <= 25)
          fileIO.ReadBoolean();
        if (fileIO.ReadBoolean())
        {
          tile.wall = (ushort) fileIO.ReadByte();
          if ((int) tile.wall >= (int) WallID.Count)
            tile.wall = (ushort) 0;
          if (versionNumber >= 48 /*0x30*/ && fileIO.ReadBoolean())
            tile.wallColor(fileIO.ReadByte());
        }
        if (fileIO.ReadBoolean())
        {
          tile.liquid = fileIO.ReadByte();
          tile.lava(fileIO.ReadBoolean());
          if (versionNumber >= 51)
            tile.honey(fileIO.ReadBoolean());
        }
        if (versionNumber >= 33)
          tile.wire(fileIO.ReadBoolean());
        if (versionNumber >= 43)
        {
          tile.wire2(fileIO.ReadBoolean());
          tile.wire3(fileIO.ReadBoolean());
        }
        if (versionNumber >= 41)
        {
          tile.halfBrick(fileIO.ReadBoolean());
          if (!TileID.Sets.SaveSlopes[(int) tile.type])
            tile.halfBrick(false);
          if (versionNumber >= 49)
          {
            tile.slope(fileIO.ReadByte());
            if (!TileID.Sets.SaveSlopes[(int) tile.type])
              tile.slope((byte) 0);
          }
        }
        if (versionNumber >= 42)
        {
          tile.actuator(fileIO.ReadBoolean());
          tile.inActive(fileIO.ReadBoolean());
        }
        int num2 = 0;
        if (versionNumber >= 25)
          num2 = (int) fileIO.ReadInt16();
        if (index3 != -1)
        {
          if ((double) index2 <= Main.worldSurface)
          {
            if ((double) (index2 + num2) <= Main.worldSurface)
            {
              WorldGen.tileCounts[index3] += (num2 + 1) * 5;
            }
            else
            {
              int num3 = (int) (Main.worldSurface - (double) index2 + 1.0);
              int num4 = num2 + 1 - num3;
              WorldGen.tileCounts[index3] += num3 * 5 + num4;
            }
          }
          else
            WorldGen.tileCounts[index3] += num2 + 1;
        }
        if (num2 > 0)
        {
          for (int index4 = index2 + 1; index4 < index2 + num2 + 1; ++index4)
            Main.tile[index1, index4].CopyFrom(Main.tile[index1, index2]);
          index2 += num2;
        }
      }
    }
    WorldGen.AddUpAlignmentCounts(true);
    if (versionNumber < 67)
      WorldGen.FixSunflowers();
    if (versionNumber < 72)
      WorldGen.FixChands();
    int num5 = 40;
    if (versionNumber < 58)
      num5 = 20;
    int num6 = 1000;
    for (int index5 = 0; index5 < num6; ++index5)
    {
      if (fileIO.ReadBoolean())
      {
        int x = fileIO.ReadInt32();
        int y = fileIO.ReadInt32();
        Chest worldChest = Chest.CreateWorldChest(index5, x, y);
        if (versionNumber >= 85)
          worldChest.name = Utils.TrimUserString(fileIO.ReadString(), 20);
        for (int index6 = 0; index6 < 40; ++index6)
        {
          if (index6 < num5)
          {
            int num7 = versionNumber < 59 ? (int) fileIO.ReadByte() : (int) fileIO.ReadInt16();
            if (num7 > 0)
            {
              if (versionNumber >= 38)
              {
                worldChest.item[index6].netDefaults(fileIO.ReadInt32());
              }
              else
              {
                short Type = ItemID.FromLegacyName(fileIO.ReadString(), versionNumber);
                worldChest.item[index6].SetDefaults((int) Type);
              }
              worldChest.item[index6].stack = num7;
              if (versionNumber >= 36)
                worldChest.item[index6].Prefix((int) fileIO.ReadByte());
            }
          }
        }
      }
    }
    for (int index7 = 0; index7 < 1000; ++index7)
    {
      if (fileIO.ReadBoolean())
      {
        string str = fileIO.ReadString();
        int index8 = fileIO.ReadInt32();
        int index9 = fileIO.ReadInt32();
        if (Main.tile[index8, index9].active() && (Main.tile[index8, index9].type == (ushort) 55 || Main.tile[index8, index9].type == (ushort) 85))
        {
          Main.sign[index7] = new Sign();
          Main.sign[index7].x = index8;
          Main.sign[index7].y = index9;
          Main.sign[index7].text = str;
        }
      }
    }
    bool flag = fileIO.ReadBoolean();
    int index = 0;
    while (flag)
    {
      if (versionNumber >= 190)
        Main.npc[index].SetDefaults(fileIO.ReadInt32());
      else
        Main.npc[index].SetDefaults(NPCID.FromLegacyName(fileIO.ReadString()));
      if (versionNumber >= 83)
        Main.npc[index].GivenName = fileIO.ReadString();
      Main.npc[index].position.X = fileIO.ReadSingle();
      Main.npc[index].position.Y = fileIO.ReadSingle();
      Main.npc[index].homeless = fileIO.ReadBoolean();
      Main.npc[index].homeTileX = fileIO.ReadInt32();
      Main.npc[index].homeTileY = fileIO.ReadInt32();
      flag = fileIO.ReadBoolean();
      ++index;
    }
    if (versionNumber >= 31 /*0x1F*/ && versionNumber <= 83)
    {
      NPC.setNPCName(fileIO.ReadString(), 17, true);
      NPC.setNPCName(fileIO.ReadString(), 18, true);
      NPC.setNPCName(fileIO.ReadString(), 19, true);
      NPC.setNPCName(fileIO.ReadString(), 20, true);
      NPC.setNPCName(fileIO.ReadString(), 22, true);
      NPC.setNPCName(fileIO.ReadString(), 54, true);
      NPC.setNPCName(fileIO.ReadString(), 38, true);
      NPC.setNPCName(fileIO.ReadString(), 107, true);
      NPC.setNPCName(fileIO.ReadString(), 108, true);
      if (versionNumber >= 35)
      {
        NPC.setNPCName(fileIO.ReadString(), 124, true);
        if (versionNumber >= 65)
        {
          NPC.setNPCName(fileIO.ReadString(), 160 /*0xA0*/, true);
          NPC.setNPCName(fileIO.ReadString(), 178, true);
          NPC.setNPCName(fileIO.ReadString(), 207, true);
          NPC.setNPCName(fileIO.ReadString(), 208 /*0xD0*/, true);
          NPC.setNPCName(fileIO.ReadString(), 209, true);
          NPC.setNPCName(fileIO.ReadString(), 227, true);
          NPC.setNPCName(fileIO.ReadString(), 228, true);
          NPC.setNPCName(fileIO.ReadString(), 229, true);
          if (versionNumber >= 79)
            NPC.setNPCName(fileIO.ReadString(), 353, true);
        }
      }
    }
    if (Main.invasionType > 0 && Main.invasionSize > 0)
      Main.FakeLoadInvasionStart();
    if (versionNumber < 7)
      return StatusID.Ok;
    int num8 = fileIO.ReadBoolean() ? 1 : 0;
    string str1 = fileIO.ReadString();
    int num9 = fileIO.ReadInt32();
    return num8 != 0 && (str1 == Main.worldName || num9 == Main.worldID) ? StatusID.Ok : StatusID.UnknownError;
  }

  public static class TilePacker
  {
    public const int Header1_1 = 1;
    public const int Header1_2 = 2;
    public const int Header1_4 = 4;
    public const int Header1_8 = 8;
    public const int Header1_10 = 16 /*0x10*/;
    public const int Header1_18 = 24;
    public const int Header1_20 = 32 /*0x20*/;
    public const int Header1_40 = 64 /*0x40*/;
    public const int Header1_80 = 128 /*0x80*/;
    public const int Header1_C0 = 192 /*0xC0*/;
    public const int Header2_1 = 1;
    public const int Header2_2 = 2;
    public const int Header2_4 = 4;
    public const int Header2_8 = 8;
    public const int Header2_10 = 16 /*0x10*/;
    public const int Header2_20 = 32 /*0x20*/;
    public const int Header2_40 = 64 /*0x40*/;
    public const int Header2_70 = 112 /*0x70*/;
    public const int Header2_80 = 128 /*0x80*/;
    public const int Header3_1 = 1;
    public const int Header3_2 = 2;
    public const int Header3_4 = 4;
    public const int Header3_8 = 8;
    public const int Header3_10 = 16 /*0x10*/;
    public const int Header3_20 = 32 /*0x20*/;
    public const int Header3_40 = 64 /*0x40*/;
    public const int Header3_80 = 128 /*0x80*/;
    public const int Header4_1 = 1;
    public const int Header4_2 = 2;
    public const int Header4_4 = 4;
    public const int Header4_8 = 8;
    public const int Header4_10 = 16 /*0x10*/;
    public const int Header4_20 = 32 /*0x20*/;
    public const int Header4_40 = 64 /*0x40*/;
    public const int Header4_80 = 128 /*0x80*/;
  }
}
