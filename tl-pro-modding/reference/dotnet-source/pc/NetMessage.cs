// Decompiled with JetBrains decompiler
// Type: Terraria.NetMessage
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Ionic.Zlib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using System;
using System.IO;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.GameContent.Items;
using Terraria.GameContent.Tile_Entities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net.Sockets;
using Terraria.Social;
using Terraria.Testing;

#nullable disable
namespace Terraria;

public class NetMessage
{
  public static MessageBuffer[] buffer = new MessageBuffer[257];
  private static short[] _compressChestList = new short[8000];
  private static short[] _compressSignList = new short[32000];
  private static short[] _compressEntities = new short[1000];
  private static PlayerDeathReason _currentPlayerDeathReason;
  private static NetMessage.NetSoundInfo _currentNetSoundInfo;
  private static CoinLossRevengeSystem.RevengeMarker _currentRevengeMarker;

  public static bool TrySendData(
    int msgType,
    int remoteClient = -1,
    int ignoreClient = -1,
    NetworkText text = null,
    int number = 0,
    float number2 = 0.0f,
    float number3 = 0.0f,
    float number4 = 0.0f,
    int number5 = 0,
    int number6 = 0,
    int number7 = 0)
  {
    try
    {
      NetMessage.SendData(msgType, remoteClient, ignoreClient, text, number, number2, number3, number4, number5, number6, number7);
    }
    catch (Exception ex)
    {
      return false;
    }
    return true;
  }

  public static void SendData(
    int msgType,
    int remoteClient = -1,
    int ignoreClient = -1,
    NetworkText text = null,
    int number = 0,
    float number2 = 0.0f,
    float number3 = 0.0f,
    float number4 = 0.0f,
    int number5 = 0,
    int number6 = 0,
    int number7 = 0)
  {
    if (Main.netMode == 0)
      return;
    if (msgType == 21 && ((double) Main.item[number].shimmerTime > 0.0 || Main.item[number].shimmered))
      msgType = 145;
    if (msgType == 21 && Main.item[number].type == 0)
      msgType = 151;
    int index1 = 256 /*0x0100*/;
    if (text == null)
      text = NetworkText.Empty;
    if (Main.netMode == 2 && remoteClient >= 0)
      index1 = remoteClient;
    lock (NetMessage.buffer[index1])
    {
      BinaryWriter writer = NetMessage.buffer[index1].writer;
      if (writer == null)
      {
        NetMessage.buffer[index1].ResetWriter();
        writer = NetMessage.buffer[index1].writer;
      }
      writer.BaseStream.Position = 0L;
      long position1 = writer.BaseStream.Position;
      writer.BaseStream.Position += 2L;
      writer.Write((byte) msgType);
      switch (msgType)
      {
        case 1:
          writer.Write("Terraria" + (object) 318);
          break;
        case 2:
          text.Serialize(writer);
          if (Main.dedServ)
          {
            Console.WriteLine(Language.GetTextValue("CLI.ClientWasBooted", (object) Netplay.Clients[index1].Socket.GetRemoteAddress().ToString(), (object) text));
            break;
          }
          break;
        case 3:
          writer.Write((byte) remoteClient);
          writer.Write(false);
          break;
        case 4:
          Player player1 = Main.player[number];
          writer.Write((byte) number);
          writer.Write((byte) player1.skinVariant);
          writer.Write((byte) player1.voiceVariant);
          writer.Write(player1.voicePitchOffset);
          writer.Write((byte) player1.hair);
          writer.Write(player1.name);
          writer.Write(player1.hairDye);
          NetMessage.WriteAccessoryVisibility(writer, player1.hideVisibleAccessory);
          writer.Write((byte) player1.hideMisc);
          writer.WriteRGB(player1.hairColor);
          writer.WriteRGB(player1.skinColor);
          writer.WriteRGB(player1.eyeColor);
          writer.WriteRGB(player1.shirtColor);
          writer.WriteRGB(player1.underShirtColor);
          writer.WriteRGB(player1.pantsColor);
          writer.WriteRGB(player1.shoeColor);
          BitsByte bitsByte1 = (BitsByte) (byte) 0;
          if (player1.difficulty == (byte) 1)
            bitsByte1[0] = true;
          else if (player1.difficulty == (byte) 2)
            bitsByte1[1] = true;
          else if (player1.difficulty == (byte) 3)
            bitsByte1[3] = true;
          bitsByte1[2] = player1.extraAccessory;
          writer.Write((byte) bitsByte1);
          BitsByte bitsByte2 = (BitsByte) (byte) 0;
          bitsByte2[0] = player1.UsingBiomeTorches;
          bitsByte2[1] = player1.happyFunTorchTime;
          bitsByte2[2] = player1.unlockedBiomeTorches;
          bitsByte2[3] = player1.unlockedSuperCart;
          bitsByte2[4] = player1.enabledSuperCart;
          writer.Write((byte) bitsByte2);
          BitsByte bitsByte3 = (BitsByte) (byte) 0;
          bitsByte3[0] = player1.usedAegisCrystal;
          bitsByte3[1] = player1.usedAegisFruit;
          bitsByte3[2] = player1.usedArcaneCrystal;
          bitsByte3[3] = player1.usedGalaxyPearl;
          bitsByte3[4] = player1.usedGummyWorm;
          bitsByte3[5] = player1.usedAmbrosia;
          bitsByte3[6] = player1.ateArtisanBread;
          writer.Write((byte) bitsByte3);
          break;
        case 5:
          writer.Write((byte) number);
          writer.Write((short) number2);
          Item obj1 = new PlayerItemSlotID.SlotReference(Main.player[number], (int) number2).Item;
          if (obj1.Name == "" || obj1.stack == 0 || obj1.type == 0)
            obj1.SetDefaults(0);
          int num1 = obj1.stack;
          int type = obj1.type;
          if (num1 < 0)
            num1 = 0;
          writer.Write((short) num1);
          writer.Write(obj1.prefix);
          writer.Write((short) type);
          writer.Write((byte) new BitsByte()
          {
            [0] = obj1.favorited,
            [1] = ((double) number3 != 0.0)
          });
          break;
        case 7:
          writer.Write((int) Main.time);
          BitsByte bitsByte4 = (BitsByte) (byte) 0;
          bitsByte4[0] = Main.dayTime;
          bitsByte4[1] = Main.bloodMoon;
          bitsByte4[2] = Main.eclipse;
          writer.Write((byte) bitsByte4);
          writer.Write((byte) Main.moonPhase);
          writer.Write((short) Main.maxTilesX);
          writer.Write((short) Main.maxTilesY);
          writer.Write((short) Main.spawnTileX);
          writer.Write((short) Main.spawnTileY);
          writer.Write((short) Main.worldSurface);
          writer.Write((short) Main.rockLayer);
          writer.Write(Main.ActiveWorldFileData.WorldId);
          writer.Write(Main.worldName);
          writer.Write((byte) Main.GameMode);
          writer.Write(Main.ActiveWorldFileData.UniqueId.ToByteArray());
          writer.Write(Main.ActiveWorldFileData.WorldGeneratorVersion);
          writer.Write((byte) Main.moonType);
          writer.Write((byte) WorldGen.treeBG1);
          writer.Write((byte) WorldGen.treeBG2);
          writer.Write((byte) WorldGen.treeBG3);
          writer.Write((byte) WorldGen.treeBG4);
          writer.Write((byte) WorldGen.corruptBG);
          writer.Write((byte) WorldGen.jungleBG);
          writer.Write((byte) WorldGen.snowBG);
          writer.Write((byte) WorldGen.hallowBG);
          writer.Write((byte) WorldGen.crimsonBG);
          writer.Write((byte) WorldGen.desertBG);
          writer.Write((byte) WorldGen.oceanBG);
          writer.Write((byte) WorldGen.mushroomBG);
          writer.Write((byte) WorldGen.underworldBG);
          writer.Write((byte) Main.iceBackStyle);
          writer.Write((byte) Main.jungleBackStyle);
          writer.Write((byte) Main.hellBackStyle);
          writer.Write(Main.windSpeedTarget);
          writer.Write((byte) Main.numClouds);
          for (int index2 = 0; index2 < 3; ++index2)
            writer.Write(Main.treeX[index2]);
          for (int index3 = 0; index3 < 4; ++index3)
            writer.Write((byte) Main.treeStyle[index3]);
          for (int index4 = 0; index4 < 3; ++index4)
            writer.Write(Main.caveBackX[index4]);
          for (int index5 = 0; index5 < 4; ++index5)
            writer.Write((byte) Main.caveBackStyle[index5]);
          WorldGen.TreeTops.SyncSend(writer);
          if (!Main.raining)
            Main.maxRaining = 0.0f;
          writer.Write(Main.maxRaining);
          BitsByte bitsByte5 = (BitsByte) (byte) 0;
          bitsByte5[0] = WorldGen.shadowOrbSmashed;
          bitsByte5[1] = NPC.downedBoss1;
          bitsByte5[2] = NPC.downedBoss2;
          bitsByte5[3] = NPC.downedBoss3;
          bitsByte5[4] = Main.hardMode;
          bitsByte5[5] = NPC.downedClown;
          bitsByte5[7] = NPC.downedPlantBoss;
          writer.Write((byte) bitsByte5);
          BitsByte bitsByte6 = (BitsByte) (byte) 0;
          bitsByte6[0] = NPC.downedMechBoss1;
          bitsByte6[1] = NPC.downedMechBoss2;
          bitsByte6[2] = NPC.downedMechBoss3;
          bitsByte6[3] = NPC.downedMechBossAny;
          bitsByte6[4] = (double) Main.cloudBGActive >= 1.0;
          bitsByte6[5] = WorldGen.crimson;
          bitsByte6[6] = Main.pumpkinMoon;
          bitsByte6[7] = Main.snowMoon;
          writer.Write((byte) bitsByte6);
          BitsByte bitsByte7 = (BitsByte) (byte) 0;
          bitsByte7[1] = Main.fastForwardTimeToDawn;
          bitsByte7[2] = Main.slimeRain;
          bitsByte7[3] = NPC.downedSlimeKing;
          bitsByte7[4] = NPC.downedQueenBee;
          bitsByte7[5] = NPC.downedFishron;
          bitsByte7[6] = NPC.downedMartians;
          bitsByte7[7] = NPC.downedAncientCultist;
          writer.Write((byte) bitsByte7);
          BitsByte bitsByte8 = (BitsByte) (byte) 0;
          bitsByte8[0] = NPC.downedMoonlord;
          bitsByte8[1] = NPC.downedHalloweenKing;
          bitsByte8[2] = NPC.downedHalloweenTree;
          bitsByte8[3] = NPC.downedChristmasIceQueen;
          bitsByte8[4] = NPC.downedChristmasSantank;
          bitsByte8[5] = NPC.downedChristmasTree;
          bitsByte8[6] = NPC.downedGolemBoss;
          bitsByte8[7] = BirthdayParty.PartyIsUp;
          writer.Write((byte) bitsByte8);
          BitsByte bitsByte9 = (BitsByte) (byte) 0;
          bitsByte9[0] = NPC.downedPirates;
          bitsByte9[1] = NPC.downedFrost;
          bitsByte9[2] = NPC.downedGoblins;
          bitsByte9[3] = Sandstorm.Happening;
          bitsByte9[4] = DD2Event.Ongoing;
          bitsByte9[5] = DD2Event.DownedInvasionT1;
          bitsByte9[6] = DD2Event.DownedInvasionT2;
          bitsByte9[7] = DD2Event.DownedInvasionT3;
          writer.Write((byte) bitsByte9);
          BitsByte bitsByte10 = (BitsByte) (byte) 0;
          bitsByte10[0] = NPC.combatBookWasUsed;
          bitsByte10[1] = LanternNight.LanternsUp;
          bitsByte10[2] = NPC.downedTowerSolar;
          bitsByte10[3] = NPC.downedTowerVortex;
          bitsByte10[4] = NPC.downedTowerNebula;
          bitsByte10[5] = NPC.downedTowerStardust;
          bitsByte10[6] = Main.forceHalloweenForToday;
          bitsByte10[7] = Main.forceXMasForToday;
          writer.Write((byte) bitsByte10);
          BitsByte bitsByte11 = (BitsByte) (byte) 0;
          bitsByte11[0] = NPC.boughtCat;
          bitsByte11[1] = NPC.boughtDog;
          bitsByte11[2] = NPC.boughtBunny;
          bitsByte11[3] = NPC.freeCake;
          bitsByte11[4] = Main.drunkWorld;
          bitsByte11[5] = NPC.downedEmpressOfLight;
          bitsByte11[6] = NPC.downedQueenSlime;
          bitsByte11[7] = Main.getGoodWorld;
          writer.Write((byte) bitsByte11);
          BitsByte bitsByte12 = (BitsByte) (byte) 0;
          bitsByte12[0] = Main.tenthAnniversaryWorld;
          bitsByte12[1] = Main.dontStarveWorld;
          bitsByte12[2] = NPC.downedDeerclops;
          bitsByte12[3] = Main.notTheBeesWorld;
          bitsByte12[4] = Main.remixWorld;
          bitsByte12[5] = NPC.unlockedSlimeBlueSpawn;
          bitsByte12[6] = NPC.combatBookVolumeTwoWasUsed;
          bitsByte12[7] = NPC.peddlersSatchelWasUsed;
          writer.Write((byte) bitsByte12);
          BitsByte bitsByte13 = (BitsByte) (byte) 0;
          bitsByte13[0] = NPC.unlockedSlimeGreenSpawn;
          bitsByte13[1] = NPC.unlockedSlimeOldSpawn;
          bitsByte13[2] = NPC.unlockedSlimePurpleSpawn;
          bitsByte13[3] = NPC.unlockedSlimeRainbowSpawn;
          bitsByte13[4] = NPC.unlockedSlimeRedSpawn;
          bitsByte13[5] = NPC.unlockedSlimeYellowSpawn;
          bitsByte13[6] = NPC.unlockedSlimeCopperSpawn;
          bitsByte13[7] = Main.fastForwardTimeToDusk;
          writer.Write((byte) bitsByte13);
          BitsByte bitsByte14 = (BitsByte) (byte) 0;
          bitsByte14[0] = Main.noTrapsWorld;
          bitsByte14[1] = Main.zenithWorld;
          bitsByte14[2] = NPC.unlockedTruffleSpawn;
          bitsByte14[3] = Main.vampireSeed;
          bitsByte14[4] = Main.infectedSeed;
          bitsByte14[5] = Main.teamBasedSpawnsSeed;
          bitsByte14[6] = Main.skyblockWorld;
          bitsByte14[7] = Main.dualDungeonsSeed;
          writer.Write((byte) bitsByte14);
          BitsByte bitsByte15 = (BitsByte) (byte) 0;
          bitsByte15[0] = WorldGen.Skyblock.lowTiles;
          writer.Write((byte) bitsByte15);
          writer.Write((byte) Main.sundialCooldown);
          writer.Write((byte) Main.moondialCooldown);
          writer.Write((short) WorldGen.SavedOreTiers.Copper);
          writer.Write((short) WorldGen.SavedOreTiers.Iron);
          writer.Write((short) WorldGen.SavedOreTiers.Silver);
          writer.Write((short) WorldGen.SavedOreTiers.Gold);
          writer.Write((short) WorldGen.SavedOreTiers.Cobalt);
          writer.Write((short) WorldGen.SavedOreTiers.Mythril);
          writer.Write((short) WorldGen.SavedOreTiers.Adamantite);
          writer.Write((sbyte) Main.invasionType);
          if (SocialAPI.Network != null)
            writer.Write(SocialAPI.Network.GetLobbyId());
          else
            writer.Write(0UL);
          writer.Write(Sandstorm.IntendedSeverity);
          ExtraSpawnPointManager.Write(writer, true);
          break;
        case 8:
          writer.Write(number);
          writer.Write((int) number2);
          writer.Write((byte) number3);
          break;
        case 9:
          writer.Write(number);
          text.Serialize(writer);
          BitsByte bitsByte16 = (BitsByte) (byte) number2;
          writer.Write((byte) bitsByte16);
          break;
        case 10:
          NetMessage.CompressTileBlock(number, (int) number2, (short) number3, (short) number4, writer.BaseStream);
          break;
        case 11:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          break;
        case 12:
          Player player2 = Main.player[number];
          writer.Write((byte) number);
          writer.Write((short) player2.SpawnX);
          writer.Write((short) player2.SpawnY);
          writer.Write(player2.respawnTimer);
          writer.Write((short) player2.numberOfDeathsPVE);
          writer.Write((short) player2.numberOfDeathsPVP);
          writer.Write((byte) player2.team);
          writer.Write((byte) number2);
          break;
        case 13:
          Player player3 = Main.player[number];
          writer.Write((byte) number);
          BitsByte bitsByte17 = (BitsByte) (byte) 0;
          bitsByte17[0] = player3.controlUp;
          bitsByte17[1] = player3.controlDown;
          bitsByte17[2] = player3.controlLeft;
          bitsByte17[3] = player3.controlRight;
          bitsByte17[4] = player3.controlJump;
          bitsByte17[5] = player3.controlUseItem;
          bitsByte17[6] = player3.direction == 1;
          writer.Write((byte) bitsByte17);
          BitsByte bitsByte18 = (BitsByte) (byte) 0;
          bitsByte18[0] = player3.pulley;
          bitsByte18[1] = player3.pulley && player3.pulleyDir == (byte) 2;
          bitsByte18[2] = player3.velocity != Vector2.Zero;
          bitsByte18[3] = player3.vortexStealthActive;
          bitsByte18[4] = (double) player3.gravDir == 1.0;
          bitsByte18[5] = player3.shieldRaised;
          bitsByte18[6] = player3.ghost;
          bitsByte18[7] = player3.mount.Active;
          writer.Write((byte) bitsByte18);
          BitsByte bitsByte19 = (BitsByte) (byte) 0;
          bitsByte19[0] = player3.tryKeepingHoveringUp;
          bitsByte19[1] = player3.IsVoidVaultEnabled;
          bitsByte19[2] = player3.sitting.isSitting;
          bitsByte19[3] = player3.downedDD2EventAnyDifficulty;
          bitsByte19[4] = player3.petting.isPetting;
          bitsByte19[5] = player3.petting.isPetSmall;
          bitsByte19[6] = player3.PotionOfReturnOriginalUsePosition.HasValue;
          bitsByte19[7] = player3.tryKeepingHoveringDown;
          writer.Write((byte) bitsByte19);
          BitsByte bitsByte20 = (BitsByte) (byte) 0;
          bitsByte20[0] = player3.sleeping.isSleeping;
          bitsByte20[1] = player3.autoReuseAllWeapons;
          bitsByte20[2] = player3.controlDownHold;
          bitsByte20[3] = player3.isOperatingAnotherEntity;
          bitsByte20[4] = player3.controlUseTile;
          bitsByte20[5] = player3.netCameraTarget.HasValue;
          bitsByte20[6] = player3.lastItemUseAttemptSuccess;
          writer.Write((byte) bitsByte20);
          writer.Write((byte) player3.selectedItem);
          writer.WriteVector2(player3.position);
          if (bitsByte18[2])
            writer.WriteVector2(player3.velocity);
          if (bitsByte18[7])
            writer.Write((ushort) player3.mount.Type);
          if (bitsByte19[6])
          {
            writer.WriteVector2(player3.PotionOfReturnOriginalUsePosition.Value);
            writer.WriteVector2(player3.PotionOfReturnHomePosition.Value);
          }
          if (bitsByte20[5])
            writer.WriteVector2(player3.netCameraTarget.Value);
          if (player3 == Main.LocalPlayer)
          {
            player3.lastSyncedNetCameraTarget = player3.netCameraTarget;
            break;
          }
          break;
        case 14:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          break;
        case 16 /*0x10*/:
          writer.Write((byte) number);
          writer.Write((short) Main.player[number].statLife);
          writer.Write((short) Main.player[number].statLifeMax);
          break;
        case 17:
          writer.Write((byte) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          writer.Write((byte) number5);
          break;
        case 18:
          writer.Write(Main.dayTime ? (byte) 1 : (byte) 0);
          writer.Write((int) Main.time);
          writer.Write(Main.sunModY);
          writer.Write(Main.moonModY);
          break;
        case 19:
          writer.Write((byte) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((double) number4 == 1.0 ? (byte) 1 : (byte) 0);
          break;
        case 20:
          int num2 = number;
          int num3 = (int) number2;
          int num4 = (int) number3;
          if (num4 < 0)
            num4 = 0;
          int num5 = (int) number4;
          if (num5 < 0)
            num5 = 0;
          if (num2 < num4)
            num2 = num4;
          if (num2 >= Main.maxTilesX + num4)
            num2 = Main.maxTilesX - num4 - 1;
          if (num3 < num5)
            num3 = num5;
          if (num3 >= Main.maxTilesY + num5)
            num3 = Main.maxTilesY - num5 - 1;
          writer.Write((short) num2);
          writer.Write((short) num3);
          writer.Write((byte) num4);
          writer.Write((byte) num5);
          writer.Write((byte) number5);
          for (int index6 = num2; index6 < num2 + num4; ++index6)
          {
            for (int index7 = num3; index7 < num3 + num5; ++index7)
            {
              BitsByte bitsByte21 = (BitsByte) (byte) 0;
              BitsByte bitsByte22 = (BitsByte) (byte) 0;
              BitsByte bitsByte23 = (BitsByte) (byte) 0;
              byte num6 = 0;
              byte num7 = 0;
              Tile tile = Main.tile[index6, index7];
              bitsByte21[0] = tile.active();
              bitsByte21[2] = tile.wall > (ushort) 0;
              bitsByte21[3] = tile.liquid > (byte) 0 && Main.netMode == 2;
              bitsByte21[4] = tile.wire();
              bitsByte21[5] = tile.halfBrick();
              bitsByte21[6] = tile.actuator();
              bitsByte21[7] = tile.inActive();
              bitsByte22[0] = tile.wire2();
              bitsByte22[1] = tile.wire3();
              if (tile.active() && tile.color() > (byte) 0)
              {
                bitsByte22[2] = true;
                num6 = tile.color();
              }
              if (tile.wall > (ushort) 0 && tile.wallColor() > (byte) 0)
              {
                bitsByte22[3] = true;
                num7 = tile.wallColor();
              }
              bitsByte22 = (BitsByte) (byte) ((uint) (byte) bitsByte22 + (uint) (byte) ((uint) tile.slope() << 4));
              bitsByte22[7] = tile.wire4();
              bitsByte23[0] = tile.fullbrightBlock();
              bitsByte23[1] = tile.fullbrightWall();
              bitsByte23[2] = tile.invisibleBlock();
              bitsByte23[3] = tile.invisibleWall();
              writer.Write((byte) bitsByte21);
              writer.Write((byte) bitsByte22);
              writer.Write((byte) bitsByte23);
              if (num6 > (byte) 0)
                writer.Write(num6);
              if (num7 > (byte) 0)
                writer.Write(num7);
              if (tile.active())
              {
                writer.Write(tile.type);
                if (Main.tileFrameImportant[(int) tile.type])
                {
                  writer.Write(tile.frameX);
                  writer.Write(tile.frameY);
                }
              }
              if (tile.wall > (ushort) 0)
                writer.Write(tile.wall);
              if (tile.liquid > (byte) 0 && Main.netMode == 2)
              {
                writer.Write(tile.liquid);
                writer.Write(tile.liquidType());
              }
            }
          }
          break;
        case 21:
        case 90:
        case 145:
        case 148:
          WorldItem worldItem1 = Main.item[number];
          Item inner = worldItem1.inner;
          writer.Write((short) number);
          writer.WriteVector2(worldItem1.position);
          writer.WriteVector2(worldItem1.velocity);
          writer.Write((short) inner.stack);
          writer.Write(inner.prefix);
          writer.Write((byte) number2);
          short num8 = 0;
          if (worldItem1.active && worldItem1.stack > 0)
            num8 = (short) worldItem1.type;
          writer.Write(num8);
          if (msgType == 145)
          {
            writer.Write(worldItem1.shimmered);
            writer.Write(worldItem1.shimmerTime);
          }
          if (msgType == 148)
          {
            writer.Write((byte) MathHelper.Clamp((float) worldItem1.timeLeftInWhichTheItemCannotBeTakenByEnemies, 0.0f, (float) byte.MaxValue));
            break;
          }
          break;
        case 22:
          WorldItem worldItem2 = Main.item[number];
          writer.Write((short) number);
          writer.Write((byte) worldItem2.playerIndexTheItemIsReservedFor);
          writer.WriteVector2(worldItem2.position);
          break;
        case 23:
          NPC npc1 = Main.npc[number];
          writer.Write((short) number);
          writer.WriteVector2(npc1.position);
          writer.WriteVector2(npc1.velocity);
          writer.Write((ushort) npc1.target);
          int num9 = npc1.life;
          if (!npc1.active)
            num9 = 0;
          short netId = (short) npc1.netID;
          bool[] flagArray = new bool[4];
          BitsByte bitsByte24 = (BitsByte) (byte) 0;
          bitsByte24[0] = npc1.direction > 0;
          bitsByte24[1] = npc1.directionY > 0;
          bitsByte24[2] = flagArray[0] = (double) npc1.ai[0] != 0.0;
          bitsByte24[3] = flagArray[1] = (double) npc1.ai[1] != 0.0;
          bitsByte24[4] = flagArray[2] = (double) npc1.ai[2] != 0.0;
          bitsByte24[5] = flagArray[3] = (double) npc1.ai[3] != 0.0;
          bitsByte24[6] = npc1.spriteDirection > 0;
          bitsByte24[7] = num9 == npc1.lifeMax;
          writer.Write((byte) bitsByte24);
          BitsByte bitsByte25 = (BitsByte) (byte) 0;
          bitsByte25[0] = npc1.statsAreScaledForThisManyPlayers > 1;
          bitsByte25[1] = npc1.SpawnedFromStatue;
          bitsByte25[2] = (double) npc1.difficulty != 1.0;
          bitsByte25[3] = npc1.spawnNeedsSyncing;
          bitsByte25[4] = npc1.spawnNeedsSyncing && (double) npc1.shimmerTransparency > 0.0;
          writer.Write((byte) bitsByte25);
          for (int index8 = 0; index8 < NPC.maxAI; ++index8)
          {
            if (flagArray[index8])
              writer.Write(npc1.ai[index8]);
          }
          writer.Write(netId);
          if (bitsByte25[0])
            writer.Write((byte) npc1.statsAreScaledForThisManyPlayers);
          if (bitsByte25[2])
            writer.Write(npc1.difficulty);
          if (!bitsByte24[7])
          {
            byte num10 = 1;
            if (npc1.lifeMax > (int) short.MaxValue)
              num10 = (byte) 4;
            else if (npc1.lifeMax > (int) sbyte.MaxValue)
              num10 = (byte) 2;
            writer.Write(num10);
            switch (num10)
            {
              case 2:
                writer.Write((short) num9);
                break;
              case 4:
                writer.Write(num9);
                break;
              default:
                writer.Write((sbyte) num9);
                break;
            }
          }
          if (npc1.type >= 0 && npc1.type < (int) NPCID.Count && Main.npcCatchable[npc1.type])
          {
            writer.Write((byte) npc1.releaseOwner);
            break;
          }
          break;
        case 24:
          writer.Write((short) number);
          writer.Write((byte) number2);
          break;
        case 27:
          Projectile projectile1 = Main.projectile[number];
          writer.Write((short) projectile1.identity);
          writer.WriteVector2(projectile1.position);
          writer.WriteVector2(projectile1.velocity);
          writer.Write((byte) projectile1.owner);
          writer.Write((short) projectile1.type);
          BitsByte bitsByte26 = (BitsByte) (byte) 0;
          BitsByte bitsByte27 = (BitsByte) (byte) 0;
          bitsByte26[0] = (double) projectile1.ai[0] != 0.0;
          bitsByte26[1] = (double) projectile1.ai[1] != 0.0;
          bitsByte27[0] = (double) projectile1.ai[2] != 0.0;
          if (projectile1.bannerIdToRespondTo != 0)
            bitsByte26[3] = true;
          if (projectile1.damage != 0)
            bitsByte26[4] = true;
          if ((double) projectile1.knockBack != 0.0)
            bitsByte26[5] = true;
          if (projectile1.type > 0 && projectile1.type < (int) ProjectileID.Count && ProjectileID.Sets.NeedsUUID[projectile1.type])
            bitsByte26[7] = true;
          if (projectile1.originalDamage != 0)
            bitsByte26[6] = true;
          if ((byte) bitsByte27 != (byte) 0)
            bitsByte26[2] = true;
          writer.Write((byte) bitsByte26);
          if (bitsByte26[2])
            writer.Write((byte) bitsByte27);
          if (bitsByte26[0])
            writer.Write(projectile1.ai[0]);
          if (bitsByte26[1])
            writer.Write(projectile1.ai[1]);
          if (bitsByte26[3])
            writer.Write((ushort) projectile1.bannerIdToRespondTo);
          if (bitsByte26[4])
            writer.Write((short) projectile1.damage);
          if (bitsByte26[5])
            writer.Write(projectile1.knockBack);
          if (bitsByte26[6])
            writer.Write((short) projectile1.originalDamage);
          if (bitsByte26[7])
            writer.Write((short) projectile1.projUUID);
          if (bitsByte27[0])
          {
            writer.Write(projectile1.ai[2]);
            break;
          }
          break;
        case 28:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write(number3);
          writer.Write((byte) ((double) number4 + 1.0));
          writer.Write((byte) number5);
          break;
        case 29:
          writer.Write((short) number);
          writer.Write((byte) number2);
          break;
        case 30:
          writer.Write((byte) number);
          writer.Write(Main.player[number].hostile);
          break;
        case 31 /*0x1F*/:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 32 /*0x20*/:
          Item obj2 = Main.chest[number].item[(int) (byte) number2];
          writer.Write((short) number);
          writer.Write((byte) number2);
          short num11 = (short) obj2.type;
          if (obj2.Name == null)
            num11 = (short) 0;
          writer.Write((short) obj2.stack);
          writer.Write(obj2.prefix);
          writer.Write(num11);
          break;
        case 33:
          int num12 = 0;
          int num13 = 0;
          int num14 = 0;
          string str1 = (string) null;
          if (number > -1)
          {
            num12 = Main.chest[number].x;
            num13 = Main.chest[number].y;
          }
          if ((double) number2 == 1.0)
          {
            string str2 = text.ToString();
            num14 = (int) (byte) str2.Length;
            if (num14 == 0 || num14 > 20)
              num14 = (int) byte.MaxValue;
            else
              str1 = str2;
          }
          writer.Write((short) number);
          writer.Write((short) num12);
          writer.Write((short) num13);
          writer.Write((byte) num14);
          if (str1 != null)
          {
            writer.Write(str1);
            break;
          }
          break;
        case 34:
          writer.Write((byte) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          if (Main.netMode == 2)
          {
            Netplay.GetSectionX((int) number2);
            Netplay.GetSectionY((int) number3);
            writer.Write((short) number5);
            break;
          }
          writer.Write((short) 0);
          break;
        case 35:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 36:
          Player player4 = Main.player[number];
          writer.Write((byte) number);
          writer.Write((byte) player4.zone1);
          writer.Write((byte) player4.zone2);
          writer.Write((byte) player4.zone3);
          writer.Write((byte) player4.zone4);
          writer.Write((byte) player4.zone5);
          writer.Write((byte) player4.townNPCs);
          break;
        case 38:
          writer.Write(Netplay.ServerPassword);
          break;
        case 39:
          writer.Write((short) number);
          break;
        case 40:
          writer.Write((byte) number);
          writer.Write((short) Main.player[number].talkNPC);
          break;
        case 41:
          writer.Write((byte) number);
          writer.Write(Main.player[number].itemRotation);
          writer.Write((short) Main.player[number].itemAnimation);
          break;
        case 42:
          writer.Write((byte) number);
          writer.Write((short) Main.player[number].statMana);
          writer.Write((short) Main.player[number].statManaMax);
          break;
        case 43:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 45:
        case 157:
          writer.Write((byte) number);
          writer.Write((byte) Main.player[number].team);
          break;
        case 46:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 47:
          writer.Write((short) number);
          writer.Write((short) Main.sign[number].x);
          writer.Write((short) Main.sign[number].y);
          writer.Write(Main.sign[number].text);
          writer.Write((byte) number2);
          writer.Write((byte) number3);
          break;
        case 48 /*0x30*/:
          Tile tile1 = Main.tile[number, (int) number2];
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write(tile1.liquid);
          writer.Write(tile1.liquidType());
          break;
        case 50:
          writer.Write((byte) number);
          Player player5 = Main.player[number];
          for (int index9 = 0; index9 < Player.maxBuffs; ++index9)
          {
            if (player5.buffType[index9] > 0)
              writer.Write((ushort) player5.buffType[index9]);
          }
          writer.Write((ushort) 0);
          break;
        case 51:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          break;
        case 52:
          writer.Write((byte) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          break;
        case 53:
          writer.Write((short) number);
          writer.Write((ushort) number2);
          writer.Write((short) number3);
          break;
        case 54:
          NPC npc2 = Main.npc[number];
          writer.Write((short) number);
          for (int index10 = 0; index10 < NPC.maxBuffs; ++index10)
          {
            int num15 = npc2.buffType[index10];
            int num16 = npc2.buffTime[index10];
            if (num15 > 0 && num16 > 0)
            {
              writer.Write((ushort) num15);
              writer.Write((ushort) num16);
            }
          }
          writer.Write((ushort) 0);
          break;
        case 55:
          writer.Write((byte) number);
          writer.Write((ushort) number2);
          writer.Write((int) number3);
          break;
        case 56:
          writer.Write((short) number);
          if (Main.netMode == 2)
          {
            string givenName = Main.npc[number].GivenName;
            writer.Write(givenName);
            writer.Write(Main.npc[number].townNpcVariationIndex);
            break;
          }
          break;
        case 57:
          writer.Write(WorldGen.tGood);
          writer.Write(WorldGen.tEvil);
          writer.Write(WorldGen.tBlood);
          break;
        case 58:
          writer.Write((byte) number);
          writer.Write(number2);
          break;
        case 59:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 60:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((byte) number4);
          break;
        case 61:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 62:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          break;
        case 63 /*0x3F*/:
        case 64 /*0x40*/:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((byte) number3);
          writer.Write((byte) number4);
          break;
        case 65:
          BitsByte bitsByte28 = (BitsByte) (byte) 0;
          bitsByte28[0] = (number & 1) == 1;
          bitsByte28[1] = (number & 2) == 2;
          bitsByte28[2] = number6 == 1;
          bitsByte28[3] = number7 != 0;
          writer.Write((byte) bitsByte28);
          writer.Write((short) number2);
          writer.Write(number3);
          writer.Write(number4);
          writer.Write((byte) number5);
          if (bitsByte28[3])
            writer.Write(number7);
          if (Main.netMode == 2 && number == 0 && (double) number2 != (double) ignoreClient)
          {
            ++Main.player[(int) number2].unacknowledgedTeleports;
            break;
          }
          break;
        case 66:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 68:
          writer.Write(Main.clientUUID);
          break;
        case 69:
          Netplay.GetSectionX((int) number2);
          Netplay.GetSectionY((int) number3);
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write(Main.chest[(int) (short) number].name);
          break;
        case 70:
          writer.Write((short) number);
          writer.Write((byte) number2);
          break;
        case 71:
          writer.Write(number);
          writer.Write((int) number2);
          writer.Write((short) number3);
          writer.Write((byte) number4);
          break;
        case 72:
          for (int index11 = 0; index11 < Main.TravelShopMaxSlots; ++index11)
            writer.Write((short) Main.travelShop[index11]);
          break;
        case 73:
          writer.Write((byte) number);
          break;
        case 74:
          writer.Write((byte) Main.anglerQuest);
          bool flag1 = Main.anglerWhoFinishedToday.Contains(text.ToString());
          writer.Write(flag1);
          break;
        case 76:
          writer.Write((byte) number);
          writer.Write(Main.player[number].anglerQuestsFinished);
          writer.Write(Main.player[number].golferScoreAccumulated);
          break;
        case 77:
          writer.Write((short) number);
          writer.Write((ushort) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          break;
        case 78:
          writer.Write(number);
          writer.Write((int) number2);
          writer.Write((sbyte) number3);
          writer.Write((sbyte) number4);
          break;
        case 79:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          writer.Write((byte) number5);
          writer.Write((sbyte) number6);
          writer.Write(number7 == 1);
          break;
        case 80 /*0x50*/:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 81:
          writer.Write(number2);
          writer.Write(number3);
          writer.WriteRGB(new Color()
          {
            PackedValue = (uint) number
          });
          writer.Write((int) number4);
          break;
        case 84:
          byte index12 = (byte) number;
          float stealth = Main.player[(int) index12].stealth;
          writer.Write(index12);
          writer.Write(stealth);
          break;
        case 85:
          if (Main.netMode == 1)
          {
            QuickStacking.WriteNetInventorySlots(writer);
            writer.Write((byte) number);
            break;
          }
          QuickStacking.WriteBlockedChestList(writer);
          break;
        case 86:
          writer.Write(number);
          TileEntity result1;
          bool flag2 = TileEntity.TryGet<TileEntity>(number, out result1);
          writer.Write(flag2);
          if (flag2)
          {
            TileEntity.Write(writer, result1, true);
            break;
          }
          break;
        case 87:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((byte) number3);
          break;
        case 88:
          BitsByte bitsByte29 = (BitsByte) (byte) number2;
          BitsByte bitsByte30 = (BitsByte) (byte) number3;
          writer.Write((short) number);
          writer.Write((byte) bitsByte29);
          WorldItem worldItem3 = Main.item[number];
          if (bitsByte29[0])
            writer.Write(worldItem3.color.PackedValue);
          if (bitsByte29[1])
            writer.Write((ushort) worldItem3.damage);
          if (bitsByte29[2])
            writer.Write(worldItem3.knockBack);
          if (bitsByte29[3])
            writer.Write((ushort) worldItem3.useAnimation);
          if (bitsByte29[4])
            writer.Write((ushort) worldItem3.useTime);
          if (bitsByte29[5])
            writer.Write((short) worldItem3.shoot);
          if (bitsByte29[6])
            writer.Write(worldItem3.shootSpeed);
          if (bitsByte29[7])
          {
            writer.Write((byte) bitsByte30);
            if (bitsByte30[0])
              writer.Write((ushort) worldItem3.width);
            if (bitsByte30[1])
              writer.Write((ushort) worldItem3.height);
            if (bitsByte30[2])
              writer.Write(worldItem3.scale);
            if (bitsByte30[3])
              writer.Write((short) worldItem3.ammo);
            if (bitsByte30[4])
              writer.Write((short) worldItem3.useAmmo);
            if (bitsByte30[5])
            {
              writer.Write(worldItem3.notAmmo);
              break;
            }
            break;
          }
          break;
        case 89:
          writer.Write((short) number);
          writer.Write((short) number2);
          Item obj3 = Main.player[(int) number4].inventory[(int) number3];
          writer.Write((short) obj3.type);
          writer.Write(obj3.prefix);
          writer.Write((short) number5);
          break;
        case 91:
          writer.Write(number);
          writer.Write((byte) number2);
          if ((double) number2 != (double) byte.MaxValue)
          {
            writer.Write((ushort) number3);
            writer.Write((ushort) number4);
            writer.Write((byte) number5);
            if (number5 < 0)
            {
              writer.Write((short) number6);
              break;
            }
            break;
          }
          break;
        case 92:
          writer.Write((short) number);
          writer.Write((int) number2);
          writer.Write(number3);
          writer.Write(number4);
          break;
        case 95:
          writer.Write((ushort) number);
          writer.Write((byte) number2);
          break;
        case 96 /*0x60*/:
          writer.Write((byte) number);
          Player player6 = Main.player[number];
          writer.Write((short) number4);
          writer.Write(number2);
          writer.Write(number3);
          writer.WriteVector2(player6.velocity);
          break;
        case 97:
          writer.Write((short) number);
          break;
        case 98:
          writer.Write((short) number);
          break;
        case 99:
          writer.Write((byte) number);
          writer.WriteVector2(Main.player[number].MinionRestTargetPoint);
          break;
        case 100:
          writer.Write((ushort) number);
          NPC npc3 = Main.npc[number];
          writer.Write((short) number4);
          writer.Write(number2);
          writer.Write(number3);
          writer.WriteVector2(npc3.velocity);
          break;
        case 101:
          writer.Write((ushort) NPC.ShieldStrengthTowerSolar);
          writer.Write((ushort) NPC.ShieldStrengthTowerVortex);
          writer.Write((ushort) NPC.ShieldStrengthTowerNebula);
          writer.Write((ushort) NPC.ShieldStrengthTowerStardust);
          break;
        case 102:
          writer.Write((byte) number);
          writer.Write((ushort) number2);
          writer.Write(number3);
          writer.Write(number4);
          break;
        case 103:
          writer.Write(NPC.MaxMoonLordCountdown);
          writer.Write(NPC.MoonLordCountdown);
          break;
        case 104:
          writer.Write((byte) number);
          writer.Write((short) number2);
          writer.Write((short) number3 < (short) 0 ? 0.0f : number3);
          writer.Write((byte) number4);
          writer.Write(number5);
          writer.Write((byte) number6);
          break;
        case 105:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((double) number3 == 1.0);
          break;
        case 106:
          HalfVector2 halfVector2 = new HalfVector2((float) number, number2);
          writer.Write(halfVector2.PackedValue);
          break;
        case 107:
          writer.Write((byte) number2);
          writer.Write((byte) number3);
          writer.Write((byte) number4);
          text.Serialize(writer);
          writer.Write((short) number5);
          break;
        case 108:
          writer.Write((short) number);
          writer.Write(number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          writer.Write((short) number5);
          writer.Write((short) number6);
          writer.Write((byte) number7);
          break;
        case 109:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((short) number4);
          writer.Write((byte) number5);
          break;
        case 110:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((byte) number3);
          break;
        case 112 /*0x70*/:
          writer.Write((byte) number);
          writer.Write((int) number2);
          writer.Write((int) number3);
          writer.Write((byte) number4);
          writer.Write((short) number5);
          writer.Write((byte) number6);
          break;
        case 113:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 115:
          writer.Write((byte) number);
          writer.Write((short) Main.player[number].MinionAttackTargetNPC);
          break;
        case 116:
          writer.Write(number);
          break;
        case 117:
          writer.Write((byte) number);
          NetMessage._currentPlayerDeathReason.WriteSelfTo(writer);
          writer.Write((short) number2);
          writer.Write((byte) ((double) number3 + 1.0));
          writer.Write((byte) number4);
          writer.Write((sbyte) number5);
          break;
        case 118:
          writer.Write((byte) number);
          NetMessage._currentPlayerDeathReason.WriteSelfTo(writer);
          writer.Write((short) number2);
          writer.Write((byte) ((double) number3 + 1.0));
          writer.Write((byte) number4);
          break;
        case 119:
          writer.Write(number2);
          writer.Write(number3);
          writer.WriteRGB(new Color()
          {
            PackedValue = (uint) number
          });
          text.Serialize(writer);
          break;
        case 120:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          break;
        case 121:
          int num17 = (int) number3;
          writer.Write((byte) number);
          writer.Write((int) number2);
          writer.Write((byte) num17);
          writer.Write((byte) number4);
          TEDisplayDoll result2;
          if (TileEntity.TryGet<TEDisplayDoll>((int) number2, out result2))
          {
            result2.WriteData((int) number3, (int) number4, writer);
            break;
          }
          TEDisplayDoll.WriteDummySync((int) number3, (int) number4, writer);
          break;
        case 122:
          writer.Write(number);
          writer.Write((byte) number2);
          break;
        case 123:
          writer.Write((short) number);
          writer.Write((short) number2);
          Item obj4 = Main.player[(int) number4].inventory[(int) number3];
          writer.Write((short) obj4.type);
          writer.Write(obj4.prefix);
          writer.Write((short) number5);
          break;
        case 124:
          int num18 = (int) number3;
          bool dye = (double) number4 == 1.0;
          if (dye)
            num18 += 2;
          writer.Write((byte) number);
          writer.Write((int) number2);
          writer.Write((byte) num18);
          TEHatRack result3;
          if (TileEntity.TryGet<TEHatRack>((int) number2, out result3))
          {
            result3.WriteItem((int) number3, writer, dye);
            break;
          }
          writer.Write(0);
          writer.Write((byte) 0);
          break;
        case 125:
          writer.Write((byte) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          writer.Write((byte) number4);
          break;
        case 126:
          NetMessage._currentRevengeMarker.WriteSelfTo(writer);
          break;
        case (int) sbyte.MaxValue:
          writer.Write(number);
          break;
        case 128 /*0x80*/:
          writer.Write((byte) number);
          writer.Write((ushort) number5);
          writer.Write((ushort) number6);
          writer.Write((ushort) number2);
          writer.Write((ushort) number3);
          break;
        case 130:
          writer.Write((ushort) number);
          writer.Write((ushort) number2);
          writer.Write((short) number3);
          break;
        case 131:
          writer.Write((ushort) number);
          writer.Write((byte) number2);
          if ((byte) number2 == (byte) 1)
          {
            writer.Write((int) number3);
            writer.Write((short) number4);
            break;
          }
          break;
        case 132:
          NetMessage._currentNetSoundInfo.WriteSelfTo(writer);
          break;
        case 133:
          writer.Write((short) number);
          writer.Write((short) number2);
          Item obj5 = Main.player[(int) number4].inventory[(int) number3];
          writer.Write((short) obj5.type);
          writer.Write(obj5.prefix);
          writer.Write((short) number5);
          break;
        case 134:
          writer.Write((byte) number);
          Player player7 = Main.player[number];
          writer.Write(player7.ladyBugLuckTimeLeft);
          writer.Write(player7.torchLuck);
          writer.Write(player7.luckPotion);
          writer.Write(player7.HasGardenGnomeNearby);
          writer.Write(player7.brokenMirrorBadLuck);
          writer.Write(player7.equipmentBasedLuckBonus);
          writer.Write(player7.coinLuck);
          writer.Write(player7.kiteLuckLevel);
          break;
        case 135:
          writer.Write((byte) number);
          break;
        case 136:
          for (int index13 = 0; index13 < 2; ++index13)
          {
            for (int index14 = 0; index14 < 3; ++index14)
              writer.Write((ushort) NPC.cavernMonsterType[index13, index14]);
          }
          break;
        case 137:
          writer.Write((short) number);
          writer.Write((ushort) number2);
          break;
        case 139:
          writer.Write((byte) number);
          bool flag3 = (double) number2 == 1.0;
          writer.Write(flag3);
          break;
        case 140:
          writer.Write((byte) number);
          writer.Write((int) number2);
          break;
        case 141:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          writer.Write(number3);
          writer.Write(number4);
          writer.Write(number5);
          writer.Write(number6);
          break;
        case 142:
          writer.Write((byte) number);
          Player player8 = Main.player[number];
          player8.piggyBankProjTracker.Write(writer);
          player8.voidLensChest.Write(writer);
          break;
        case 146:
          writer.Write((byte) number);
          switch (number)
          {
            case 0:
              writer.WriteVector2(new Vector2((float) (int) number2, (float) (int) number3));
              break;
            case 1:
              writer.WriteVector2(new Vector2((float) (int) number2, (float) (int) number3));
              writer.Write((int) number4);
              break;
          }
          break;
        case 147:
          writer.Write((byte) number);
          writer.Write((byte) number2);
          NetMessage.WriteAccessoryVisibility(writer, Main.player[number].hideVisibleAccessory);
          break;
        case 149:
          writer.Write((short) number);
          writer.Write((short) number2);
          Item obj6 = Main.player[(int) number4].inventory[(int) number3];
          writer.Write((short) obj6.type);
          writer.Write(obj6.prefix);
          writer.Write((short) number5);
          break;
        case 150:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 151:
          Main.item[number].playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
          writer.Write((short) number);
          break;
        case 152:
          writer.Write((byte) number);
          break;
        case 153:
          writer.Write((byte) number);
          writer.Write((short) number2);
          break;
        case 155:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 156:
          writer.Write((short) number);
          writer.Write((short) number2);
          writer.Write((short) number3);
          break;
        case 158:
          writer.Write((byte) number);
          break;
        case 159:
          writer.Write((short) number);
          writer.Write((short) number2);
          break;
        case 160 /*0xA0*/:
          WorldItem worldItem4 = Main.item[number];
          writer.Write((short) number);
          writer.WriteVector2(worldItem4.position);
          break;
        case 161:
          writer.Write(text.ToString());
          break;
      }
      int position2 = (int) writer.BaseStream.Position;
      if (position2 > (int) ushort.MaxValue)
        throw new Exception($"Maximum packet length exceeded. id: {(object) msgType} length: {(object) position2}");
      writer.BaseStream.Position = position1;
      writer.Write((ushort) position2);
      writer.BaseStream.Position = (long) position2;
      if (Main.netMode == 1)
      {
        if (Netplay.Connection.IsConnected())
          NetMessage.SendPacketToServer(NetMessage.buffer[index1].writeBuffer);
      }
      else if (remoteClient == -1)
      {
        switch (msgType)
        {
          case 13:
            for (int remoteClient1 = 0; remoteClient1 < 256 /*0x0100*/; ++remoteClient1)
            {
              if (remoteClient1 != ignoreClient && NetMessage.buffer[remoteClient1].broadcast && Netplay.Clients[remoteClient1].IsConnected())
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient1);
            }
            break;
          case 20:
            for (int remoteClient2 = 0; remoteClient2 < 256 /*0x0100*/; ++remoteClient2)
            {
              if (remoteClient2 != ignoreClient && NetMessage.buffer[remoteClient2].broadcast && Netplay.Clients[remoteClient2].IsConnected() && Netplay.Clients[remoteClient2].SectionRange((int) Math.Max(number3, number4), number, (int) number2))
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient2);
            }
            break;
          case 23:
            NPC npc4 = Main.npc[number];
            bool flag4 = npc4.boss || npc4.netAlways || npc4.townNPC || !npc4.active || npc4.life <= 0 || npc4.spawnNeedsSyncing;
            if (flag4)
            {
              npc4.spawnNeedsSyncing = false;
              npc4.netStream = 0;
              npc4.netUpdate = false;
              npc4.netUpdatePendingSpamCooldown = false;
              npc4.netUpdatePendingFullSpamCooldown = false;
              Array.Clear((Array) npc4.playerNetSyncState, 0, npc4.playerNetSyncState.Length);
            }
            for (int remoteClient3 = 0; remoteClient3 < 256 /*0x0100*/; ++remoteClient3)
            {
              if (remoteClient3 != ignoreClient && NetMessage.buffer[remoteClient3].broadcast && Netplay.Clients[remoteClient3].IsConnected())
              {
                if (!flag4)
                {
                  if (npc4.playerNetSyncState[remoteClient3].skippedSyncs < (byte) 4 && !Netplay.Clients[remoteClient3].IsSectionActive(npc4.NetSectionCoordinates))
                  {
                    ++npc4.playerNetSyncState[remoteClient3].skippedSyncs;
                    continue;
                  }
                  npc4.playerNetSyncState[remoteClient3] = new NPC.PlayerNetSyncState();
                }
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient3);
              }
            }
            break;
          case 27:
            Projectile projectile2 = Main.projectile[number];
            bool flag5 = projectile2.type == 12 || Main.projPet[projectile2.type] || projectile2.aiStyle == 11 || projectile2.netImportant;
            if (flag5)
              Array.Clear((Array) projectile2.netSyncSkippedForPlayer, 0, projectile2.netSyncSkippedForPlayer.Length);
            for (int remoteClient4 = 0; remoteClient4 < 256 /*0x0100*/; ++remoteClient4)
            {
              if (remoteClient4 != ignoreClient && NetMessage.buffer[remoteClient4].broadcast && Netplay.Clients[remoteClient4].IsConnected())
              {
                if (!flag5)
                {
                  if (!Netplay.Clients[remoteClient4].IsSectionActive(projectile2.NetSectionCoordinates))
                  {
                    projectile2.netSyncSkippedForPlayer[remoteClient4] = true;
                    continue;
                  }
                  projectile2.netSyncSkippedForPlayer[remoteClient4] = false;
                }
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient4);
              }
            }
            break;
          case 28:
            NPC npc5 = Main.npc[number];
            for (int remoteClient5 = 0; remoteClient5 < 256 /*0x0100*/; ++remoteClient5)
            {
              if (remoteClient5 != ignoreClient && NetMessage.buffer[remoteClient5].broadcast && Netplay.Clients[remoteClient5].IsConnected() && (npc5.life <= 0 ? 1 : (Netplay.Clients[remoteClient5].IsSectionActive(npc5.NetSectionCoordinates) ? 1 : 0)) != 0)
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient5);
            }
            break;
          case 34:
          case 69:
            for (int remoteClient6 = 0; remoteClient6 < 256 /*0x0100*/; ++remoteClient6)
            {
              if (remoteClient6 != ignoreClient && NetMessage.buffer[remoteClient6].broadcast && Netplay.Clients[remoteClient6].IsConnected())
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient6);
            }
            break;
          default:
            for (int remoteClient7 = 0; remoteClient7 < 256 /*0x0100*/; ++remoteClient7)
            {
              if (remoteClient7 != ignoreClient && (NetMessage.buffer[remoteClient7].broadcast || Netplay.Clients[remoteClient7].State >= 3 && msgType == 10) && Netplay.Clients[remoteClient7].IsConnected())
                NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient7);
            }
            break;
        }
      }
      else if (Netplay.Clients[remoteClient].IsConnected())
      {
        switch (msgType)
        {
          case 23:
            Main.npc[number].playerNetSyncState[remoteClient] = new NPC.PlayerNetSyncState();
            break;
          case 27:
            Main.projectile[number].netSyncSkippedForPlayer[remoteClient] = false;
            break;
        }
        NetMessage.SendPacket(NetMessage.buffer[index1].writeBuffer, remoteClient);
      }
      if (Main.verboseNetplay)
      {
        int num19 = 0;
        while (num19 < position2)
          ++num19;
        for (int index15 = 0; index15 < position2; ++index15)
        {
          int num20 = (int) NetMessage.buffer[index1].writeBuffer[index15];
        }
      }
      NetMessage.buffer[index1].writeLocked = false;
      if (msgType != 2 || Main.netMode != 2)
        return;
      Netplay.Clients[index1].PendingTermination = true;
    }
  }

  private static void SendPacketToServer(byte[] data)
  {
    NetMessage.SendPacket(data, 256 /*0x0100*/);
  }

  private static void SendPacket(byte[] data, int remoteClient)
  {
    try
    {
      ushort uint16 = BitConverter.ToUInt16(data, 0);
      byte messageId = data[2];
      ++NetMessage.buffer[remoteClient].spamCount;
      Main.ActiveNetDiagnosticsUI.CountSentMessage((int) messageId, (int) uint16);
      if (!Main.dedServ)
        Netplay.Connection.Socket.AsyncSend(data, 0, (int) uint16, new SocketSendCallback(Netplay.Connection.ClientWriteCallBack));
      else
        Netplay.Clients[remoteClient].Socket.AsyncSend(data, 0, (int) uint16, new SocketSendCallback(Netplay.Clients[remoteClient].ServerWriteCallBack));
    }
    catch
    {
      int num = Main.dedServ ? 1 : 0;
    }
  }

  public static void SendChestContentsTo(int chest, int targetPlayer)
  {
    NetMessage.TrySendData(155, targetPlayer, number: chest, number2: (float) Main.chest[chest].maxItems);
    for (int number2 = 0; number2 < Main.chest[chest].maxItems; ++number2)
      NetMessage.TrySendData(32 /*0x20*/, targetPlayer, number: chest, number2: (float) number2);
  }

  private static void WriteAccessoryVisibility(BinaryWriter writer, bool[] hideVisibleAccessory)
  {
    ushort num = 0;
    for (int index = 0; index < hideVisibleAccessory.Length; ++index)
    {
      if (hideVisibleAccessory[index])
        num |= (ushort) (1 << index);
    }
    writer.Write(num);
  }

  public static void CompressTileBlock(
    int xStart,
    int yStart,
    short width,
    short height,
    Stream stream)
  {
    using (DeflateStream output = new DeflateStream(stream, (CompressionMode) 0, true))
    {
      BinaryWriter writer = new BinaryWriter((Stream) output);
      writer.Write(xStart);
      writer.Write(yStart);
      writer.Write(width);
      writer.Write(height);
      NetMessage.CompressTileBlock_Inner(writer, xStart, yStart, (int) width, (int) height);
    }
  }

  public static void CompressTileBlock_Inner(
    BinaryWriter writer,
    int xStart,
    int yStart,
    int width,
    int height)
  {
    short index1 = 0;
    short num1 = 0;
    short num2 = 0;
    short num3 = 0;
    int index2 = 0;
    int index3 = 0;
    byte num4 = 0;
    byte[] buffer = new byte[16 /*0x10*/];
    Tile compTile = (Tile) null;
    for (int index4 = yStart; index4 < yStart + height; ++index4)
    {
      for (int index5 = xStart; index5 < xStart + width; ++index5)
      {
        Tile tile = Main.tile[index5, index4];
        if (tile.isTheSameAs(compTile) && TileID.Sets.AllowsSaveCompressionBatching[(int) tile.type])
        {
          ++num3;
        }
        else
        {
          if (compTile != null)
          {
            if (num3 > (short) 0)
            {
              buffer[index2] = (byte) ((uint) num3 & (uint) byte.MaxValue);
              ++index2;
              if (num3 > (short) byte.MaxValue)
              {
                num4 |= (byte) 128 /*0x80*/;
                buffer[index2] = (byte) (((int) num3 & 65280) >> 8);
                ++index2;
              }
              else
                num4 |= (byte) 64 /*0x40*/;
            }
            buffer[index3] = num4;
            writer.Write(buffer, index3, index2 - index3);
            num3 = (short) 0;
          }
          index2 = 4;
          int num5;
          byte num6 = (byte) (num5 = 0);
          byte num7 = (byte) num5;
          byte num8 = (byte) num5;
          num4 = (byte) num5;
          if (tile.active())
          {
            num4 |= (byte) 2;
            buffer[index2] = (byte) tile.type;
            ++index2;
            if (tile.type > (ushort) byte.MaxValue)
            {
              buffer[index2] = (byte) ((uint) tile.type >> 8);
              ++index2;
              num4 |= (byte) 32 /*0x20*/;
            }
            if (TileID.Sets.BasicChest[(int) tile.type] && (int) tile.frameX % 36 == 0 && (int) tile.frameY % 36 == 0)
            {
              short chest = (short) Chest.FindChest(index5, index4);
              if (chest != (short) -1)
              {
                NetMessage._compressChestList[(int) index1] = chest;
                ++index1;
              }
            }
            if (tile.type == (ushort) 88 && (int) tile.frameX % 54 == 0 && (int) tile.frameY % 36 == 0)
            {
              short chest = (short) Chest.FindChest(index5, index4);
              if (chest != (short) -1)
              {
                NetMessage._compressChestList[(int) index1] = chest;
                ++index1;
              }
            }
            if (tile.type == (ushort) 85 && (int) tile.frameX % 36 == 0 && (int) tile.frameY % 36 == 0)
            {
              short num9 = (short) Sign.ReadSign(index5, index4);
              if (num9 != (short) -1)
                NetMessage._compressSignList[(int) num1++] = num9;
            }
            if (tile.type == (ushort) 55 && (int) tile.frameX % 36 == 0 && (int) tile.frameY % 36 == 0)
            {
              short num10 = (short) Sign.ReadSign(index5, index4);
              if (num10 != (short) -1)
                NetMessage._compressSignList[(int) num1++] = num10;
            }
            if (tile.type == (ushort) 425 && (int) tile.frameX % 36 == 0 && (int) tile.frameY % 36 == 0)
            {
              short num11 = (short) Sign.ReadSign(index5, index4);
              if (num11 != (short) -1)
                NetMessage._compressSignList[(int) num1++] = num11;
            }
            if (tile.type == (ushort) 573 && (int) tile.frameX % 36 == 0 && (int) tile.frameY % 36 == 0)
            {
              short num12 = (short) Sign.ReadSign(index5, index4);
              if (num12 != (short) -1)
                NetMessage._compressSignList[(int) num1++] = num12;
            }
            if (tile.type == (ushort) 378 && (int) tile.frameX % 36 == 0 && tile.frameY == (short) 0)
            {
              int num13 = TileEntityType<TETrainingDummy>.Find(index5, index4);
              if (num13 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num13;
            }
            if (tile.type == (ushort) 395 && (int) tile.frameX % 36 == 0 && tile.frameY == (short) 0)
            {
              int num14 = TileEntityType<TEItemFrame>.Find(index5, index4);
              if (num14 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num14;
            }
            if (tile.type == (ushort) 698 && (int) tile.frameX % 18 == 0 && tile.frameY == (short) 0)
            {
              int num15 = TileEntityType<TEDeadCellsDisplayJar>.Find(index5, index4);
              if (num15 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num15;
            }
            if (tile.type == (ushort) 520 && (int) tile.frameX % 18 == 0 && tile.frameY == (short) 0)
            {
              int num16 = TileEntityType<TEFoodPlatter>.Find(index5, index4);
              if (num16 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num16;
            }
            if (tile.type == (ushort) 471 && (int) tile.frameX % 54 == 0 && tile.frameY == (short) 0)
            {
              int num17 = TileEntityType<TEWeaponsRack>.Find(index5, index4);
              if (num17 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num17;
            }
            if (tile.type == (ushort) 470 && (int) tile.frameX % 36 == 0 && tile.frameY == (short) 0)
            {
              int num18 = TileEntityType<TEDisplayDoll>.Find(index5, index4);
              if (num18 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num18;
            }
            if (tile.type == (ushort) 475 && (int) tile.frameX % 54 == 0 && tile.frameY == (short) 0)
            {
              int num19 = TileEntityType<TEHatRack>.Find(index5, index4);
              if (num19 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num19;
            }
            if (tile.type == (ushort) 597 && (int) tile.frameX % 54 == 0 && (int) tile.frameY % 72 == 0)
            {
              int num20 = TileEntityType<TETeleportationPylon>.Find(index5, index4);
              if (num20 != -1)
                NetMessage._compressEntities[(int) num2++] = (short) num20;
            }
            if (Main.tileFrameImportant[(int) tile.type])
            {
              buffer[index2] = (byte) ((uint) tile.frameX & (uint) byte.MaxValue);
              int index6 = index2 + 1;
              buffer[index6] = (byte) (((int) tile.frameX & 65280) >> 8);
              int index7 = index6 + 1;
              buffer[index7] = (byte) ((uint) tile.frameY & (uint) byte.MaxValue);
              int index8 = index7 + 1;
              buffer[index8] = (byte) (((int) tile.frameY & 65280) >> 8);
              index2 = index8 + 1;
            }
            if (tile.color() != (byte) 0)
            {
              num7 |= (byte) 8;
              buffer[index2] = tile.color();
              ++index2;
            }
          }
          if (tile.wall != (ushort) 0)
          {
            num4 |= (byte) 4;
            buffer[index2] = (byte) tile.wall;
            ++index2;
            if (tile.wallColor() != (byte) 0)
            {
              num7 |= (byte) 16 /*0x10*/;
              buffer[index2] = tile.wallColor();
              ++index2;
            }
          }
          if (tile.liquid != (byte) 0)
          {
            if (tile.shimmer())
            {
              num7 |= (byte) 128 /*0x80*/;
              num4 |= (byte) 8;
            }
            else if (tile.lava())
              num4 |= (byte) 16 /*0x10*/;
            else if (tile.honey())
              num4 |= (byte) 24;
            else
              num4 |= (byte) 8;
            buffer[index2] = tile.liquid;
            ++index2;
          }
          if (tile.wire())
            num8 |= (byte) 2;
          if (tile.wire2())
            num8 |= (byte) 4;
          if (tile.wire3())
            num8 |= (byte) 8;
          int num21 = !tile.halfBrick() ? (tile.slope() == (byte) 0 ? 0 : (int) tile.slope() + 1 << 4) : 16 /*0x10*/;
          byte num22 = (byte) ((uint) num8 | (uint) (byte) num21);
          if (tile.actuator())
            num7 |= (byte) 2;
          if (tile.inActive())
            num7 |= (byte) 4;
          if (tile.wire4())
            num7 |= (byte) 32 /*0x20*/;
          if (tile.wall > (ushort) byte.MaxValue)
          {
            buffer[index2] = (byte) ((uint) tile.wall >> 8);
            ++index2;
            num7 |= (byte) 64 /*0x40*/;
          }
          if (tile.invisibleBlock())
            num6 |= (byte) 2;
          if (tile.invisibleWall())
            num6 |= (byte) 4;
          if (tile.fullbrightBlock())
            num6 |= (byte) 8;
          if (tile.fullbrightWall())
            num6 |= (byte) 16 /*0x10*/;
          index3 = 3;
          if (num6 != (byte) 0)
          {
            num7 |= (byte) 1;
            buffer[index3] = num6;
            --index3;
          }
          if (num7 != (byte) 0)
          {
            num22 |= (byte) 1;
            buffer[index3] = num7;
            --index3;
          }
          if (num22 != (byte) 0)
          {
            num4 |= (byte) 1;
            buffer[index3] = num22;
            --index3;
          }
          compTile = tile;
        }
      }
    }
    if (num3 > (short) 0)
    {
      buffer[index2] = (byte) ((uint) num3 & (uint) byte.MaxValue);
      ++index2;
      if (num3 > (short) byte.MaxValue)
      {
        num4 |= (byte) 128 /*0x80*/;
        buffer[index2] = (byte) (((int) num3 & 65280) >> 8);
        ++index2;
      }
      else
        num4 |= (byte) 64 /*0x40*/;
    }
    buffer[index3] = num4;
    writer.Write(buffer, index3, index2 - index3);
    writer.Write(index1);
    for (int index9 = 0; index9 < (int) index1; ++index9)
    {
      Chest chest = Main.chest[(int) NetMessage._compressChestList[index9]];
      writer.Write(NetMessage._compressChestList[index9]);
      writer.Write((short) chest.x);
      writer.Write((short) chest.y);
      writer.Write(chest.name);
    }
    writer.Write(num1);
    for (int index10 = 0; index10 < (int) num1; ++index10)
    {
      Sign sign = Main.sign[(int) NetMessage._compressSignList[index10]];
      writer.Write(NetMessage._compressSignList[index10]);
      writer.Write((short) sign.x);
      writer.Write((short) sign.y);
      writer.Write(sign.text);
    }
    writer.Write(num2);
    for (int index11 = 0; index11 < (int) num2; ++index11)
      TileEntity.Write(writer, TileEntity.ByID[(int) NetMessage._compressEntities[index11]]);
  }

  public static void DecompressTileBlock(Stream stream)
  {
    using (DeflateStream input = new DeflateStream(stream, (CompressionMode) 1, true))
    {
      BinaryReader reader = new BinaryReader((Stream) input);
      NetMessage.DecompressTileBlock_Inner(reader, reader.ReadInt32(), reader.ReadInt32(), (int) reader.ReadInt16(), (int) reader.ReadInt16());
    }
  }

  public static void DecompressTileBlock_Inner(
    BinaryReader reader,
    int xStart,
    int yStart,
    int width,
    int height)
  {
    Tile tile = (Tile) null;
    int num1 = 0;
    for (int index1 = yStart; index1 < yStart + height; ++index1)
    {
      for (int index2 = xStart; index2 < xStart + width; ++index2)
      {
        if (num1 != 0)
        {
          --num1;
          if (Main.tile[index2, index1] == null)
            Main.tile[index2, index1] = new Tile(tile);
          else
            Main.tile[index2, index1].CopyFrom(tile);
        }
        else
        {
          int num2;
          byte num3 = (byte) (num2 = 0);
          byte num4 = (byte) num2;
          byte num5 = (byte) num2;
          tile = Main.tile[index2, index1];
          if (tile == null)
          {
            tile = new Tile();
            Main.tile[index2, index1] = tile;
          }
          else
            tile.ClearEverything();
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
          bool flag3 = tile.active();
          if (((int) num6 & 2) == 2)
          {
            tile.active(true);
            ushort type = tile.type;
            int index3;
            if (((int) num6 & 32 /*0x20*/) == 32 /*0x20*/)
            {
              byte num7 = reader.ReadByte();
              index3 = (int) reader.ReadByte() << 8 | (int) num7;
            }
            else
              index3 = (int) reader.ReadByte();
            tile.type = (ushort) index3;
            if (Main.tileFrameImportant[index3])
            {
              tile.frameX = reader.ReadInt16();
              tile.frameY = reader.ReadInt16();
            }
            else if (!flag3 || (int) tile.type != (int) type)
            {
              tile.frameX = (short) -1;
              tile.frameY = (short) -1;
            }
            if (((int) num4 & 8) == 8)
              tile.color(reader.ReadByte());
          }
          if (((int) num6 & 4) == 4)
          {
            tile.wall = (ushort) reader.ReadByte();
            if (((int) num4 & 16 /*0x10*/) == 16 /*0x10*/)
              tile.wallColor(reader.ReadByte());
          }
          byte num8 = (byte) (((int) num6 & 24) >> 3);
          if (num8 != (byte) 0)
          {
            tile.liquid = reader.ReadByte();
            if (((int) num4 & 128 /*0x80*/) == 128 /*0x80*/)
              tile.shimmer(true);
            else if (num8 > (byte) 1)
            {
              if (num8 == (byte) 2)
                tile.lava(true);
              else
                tile.honey(true);
            }
          }
          if (num5 > (byte) 1)
          {
            if (((int) num5 & 2) == 2)
              tile.wire(true);
            if (((int) num5 & 4) == 4)
              tile.wire2(true);
            if (((int) num5 & 8) == 8)
              tile.wire3(true);
            byte num9 = (byte) (((int) num5 & 112 /*0x70*/) >> 4);
            if (num9 != (byte) 0 && Main.tileSolid[(int) tile.type])
            {
              if (num9 == (byte) 1)
                tile.halfBrick(true);
              else
                tile.slope((byte) ((uint) num9 - 1U));
            }
          }
          if (num4 > (byte) 1)
          {
            if (((int) num4 & 2) == 2)
              tile.actuator(true);
            if (((int) num4 & 4) == 4)
              tile.inActive(true);
            if (((int) num4 & 32 /*0x20*/) == 32 /*0x20*/)
              tile.wire4(true);
            if (((int) num4 & 64 /*0x40*/) == 64 /*0x40*/)
            {
              byte num10 = reader.ReadByte();
              tile.wall = (ushort) ((uint) num10 << 8 | (uint) tile.wall);
            }
          }
          if (num3 > (byte) 1)
          {
            if (((int) num3 & 2) == 2)
              tile.invisibleBlock(true);
            if (((int) num3 & 4) == 4)
              tile.invisibleWall(true);
            if (((int) num3 & 8) == 8)
              tile.fullbrightBlock(true);
            if (((int) num3 & 16 /*0x10*/) == 16 /*0x10*/)
              tile.fullbrightWall(true);
          }
          switch ((byte) (((int) num6 & 192 /*0xC0*/) >> 6))
          {
            case 0:
              num1 = 0;
              continue;
            case 1:
              num1 = (int) reader.ReadByte();
              continue;
            default:
              num1 = (int) reader.ReadInt16();
              continue;
          }
        }
      }
    }
    short num11 = reader.ReadInt16();
    for (int index4 = 0; index4 < (int) num11; ++index4)
    {
      short index5 = reader.ReadInt16();
      short x = reader.ReadInt16();
      short y = reader.ReadInt16();
      string str = reader.ReadString();
      if (index5 >= (short) 0 && index5 < (short) 8000)
        Chest.CreateWorldChest((int) index5, (int) x, (int) y).name = str;
    }
    short num12 = reader.ReadInt16();
    for (int index6 = 0; index6 < (int) num12; ++index6)
    {
      short index7 = reader.ReadInt16();
      short num13 = reader.ReadInt16();
      short num14 = reader.ReadInt16();
      string str = reader.ReadString();
      if (index7 >= (short) 0 && index7 < (short) 32000)
      {
        if (Main.sign[(int) index7] == null)
          Main.sign[(int) index7] = new Sign();
        Main.sign[(int) index7].text = str;
        Main.sign[(int) index7].x = (int) num13;
        Main.sign[(int) index7].y = (int) num14;
      }
    }
    short num15 = reader.ReadInt16();
    for (int index = 0; index < (int) num15; ++index)
      TileEntity.Add(TileEntity.Read(reader, 318));
    MapUpdateQueue.Add(new Rectangle(xStart, yStart, width, height));
    Main.sectionManager.SetTilesLoaded(xStart, yStart, xStart + width - 1, yStart + height - 1);
  }

  public static void ReceiveBytes(byte[] bytes, int streamLength, int i = 256 /*0x0100*/)
  {
    lock (NetMessage.buffer[i])
    {
      try
      {
        Buffer.BlockCopy((Array) bytes, 0, (Array) NetMessage.buffer[i].readBuffer, NetMessage.buffer[i].totalData, streamLength);
        NetMessage.buffer[i].totalData += streamLength;
        NetMessage.buffer[i].checkBytes = true;
      }
      catch
      {
        if (Main.netMode == 1)
        {
          Main.menuMode = 15;
          Main.statusText = Language.GetTextValue("Error.BadHeaderBufferOverflow");
          Netplay.Disconnect = true;
        }
        else
          Netplay.Clients[i].PendingTermination = true;
      }
    }
  }

  public static void CheckBytes(int bufferIndex = 256 /*0x0100*/)
  {
    if (Main.dedServ && Netplay.Clients[bufferIndex].PendingTermination)
    {
      Netplay.Clients[bufferIndex].PendingTerminationApproved = true;
    }
    else
    {
      if (!Main.dedServ && !Netplay.Connection.IsConnected() && !Netplay.Connection.IsReading && !NetMessage.buffer[bufferIndex].checkBytes)
      {
        Netplay.Disconnect = true;
        Main.statusText = Language.GetTextValue("Net.LostConnection");
      }
      if (!NetMessage.buffer[bufferIndex].checkBytes)
        return;
      lock (NetMessage.buffer[bufferIndex])
      {
        NetMessage.buffer[bufferIndex].checkBytes = false;
        int startIndex = 0;
        int num = NetMessage.buffer[bufferIndex].totalData;
        try
        {
          while (num >= 2)
          {
            int uint16 = (int) BitConverter.ToUInt16(NetMessage.buffer[bufferIndex].readBuffer, startIndex);
            if (uint16 < 3)
              throw new IndexOutOfRangeException($"Invalid packet. Message size too small ({(object) uint16})");
            if (num >= uint16)
            {
              long position = NetMessage.buffer[bufferIndex].reader.BaseStream.Position;
              NetMessage.buffer[bufferIndex].GetData(startIndex + 2, uint16 - 2, out int _);
              NetMessage.buffer[bufferIndex].reader.BaseStream.Position = position + (long) uint16;
              num -= uint16;
              startIndex += uint16;
            }
            else
              break;
          }
        }
        catch (Exception ex)
        {
          if (Main.dedServ && startIndex < NetMessage.buffer.Length - 100)
            Console.WriteLine(Language.GetTextValue("Error.NetMessageError", (object) NetMessage.buffer[startIndex + 2]));
          num = 0;
          startIndex = 0;
        }
        if (num == NetMessage.buffer[bufferIndex].totalData)
          return;
        for (int index = 0; index < num; ++index)
          NetMessage.buffer[bufferIndex].readBuffer[index] = NetMessage.buffer[bufferIndex].readBuffer[index + startIndex];
        NetMessage.buffer[bufferIndex].totalData = num;
      }
    }
  }

  public static void BootPlayer(int plr, NetworkText msg) => NetMessage.SendData(2, plr, text: msg);

  public static void SendObjectPlacement(
    int whoAmi,
    int x,
    int y,
    int type,
    int style,
    int alternative,
    int random,
    int direction)
  {
    int remoteClient;
    int ignoreClient;
    if (Main.netMode == 2)
    {
      remoteClient = -1;
      ignoreClient = whoAmi;
    }
    else
    {
      remoteClient = whoAmi;
      ignoreClient = -1;
    }
    NetMessage.SendData(79, remoteClient, ignoreClient, number: x, number2: (float) y, number3: (float) type, number4: (float) style, number5: alternative, number6: random, number7: direction);
  }

  public static void SendTemporaryAnimation(
    int whoAmi,
    int animationType,
    int tileType,
    int xCoord,
    int yCoord)
  {
    if (Main.netMode != 2)
      return;
    NetMessage.SendData(77, whoAmi, number: animationType, number2: (float) tileType, number3: (float) xCoord, number4: (float) yCoord);
  }

  public static void SendPlayerHurt(
    int playerTargetIndex,
    PlayerDeathReason reason,
    int damage,
    int direction,
    bool critical,
    bool pvp,
    int hitContext,
    int remoteClient = -1,
    int ignoreClient = -1)
  {
    NetMessage._currentPlayerDeathReason = reason;
    BitsByte number4 = (BitsByte) (byte) 0;
    number4[0] = critical;
    number4[1] = pvp;
    NetMessage.SendData(117, remoteClient, ignoreClient, number: playerTargetIndex, number2: (float) damage, number3: (float) direction, number4: (float) (byte) number4, number5: hitContext);
  }

  public static void SendPlayerDeath(
    int playerTargetIndex,
    PlayerDeathReason reason,
    int damage,
    int direction,
    bool pvp,
    int remoteClient = -1,
    int ignoreClient = -1)
  {
    NetMessage._currentPlayerDeathReason = reason;
    BitsByte number4 = (BitsByte) (byte) 0;
    number4[0] = pvp;
    NetMessage.SendData(118, remoteClient, ignoreClient, number: playerTargetIndex, number2: (float) damage, number3: (float) direction, number4: (float) (byte) number4);
  }

  public static void PlayNetSound(NetMessage.NetSoundInfo info, int remoteClient = -1, int ignoreClient = -1)
  {
    NetMessage._currentNetSoundInfo = info;
    NetMessage.SendData(132, remoteClient, ignoreClient);
  }

  public static void SendCoinLossRevengeMarker(
    CoinLossRevengeSystem.RevengeMarker marker,
    int remoteClient = -1,
    int ignoreClient = -1)
  {
    NetMessage._currentRevengeMarker = marker;
    NetMessage.SendData(126, remoteClient, ignoreClient);
  }

  public static void SendTileSquare(
    int whoAmi,
    int tileX,
    int tileY,
    int xSize,
    int ySize,
    TileChangeType changeType = TileChangeType.None)
  {
    NetMessage.SendData(20, whoAmi, number: tileX, number2: (float) tileY, number3: (float) xSize, number4: (float) ySize, number5: (int) changeType);
  }

  public static void SendTileSquare(
    int whoAmi,
    int tileX,
    int tileY,
    int centeredSquareSize,
    TileChangeType changeType = TileChangeType.None)
  {
    int num = (centeredSquareSize - 1) / 2;
    NetMessage.SendTileSquare(whoAmi, tileX - num, tileY - num, centeredSquareSize, centeredSquareSize, changeType);
  }

  public static void SendTileSquare(int whoAmi, int tileX, int tileY, TileChangeType changeType = TileChangeType.None)
  {
    int num1 = 1;
    int num2 = (num1 - 1) / 2;
    NetMessage.SendTileSquare(whoAmi, tileX - num2, tileY - num2, num1, num1, changeType);
  }

  public static void SendTravelShop(int remoteClient)
  {
    if (Main.netMode != 2)
      return;
    NetMessage.SendData(72, remoteClient);
  }

  public static void SendAnglerQuest(int remoteClient)
  {
    if (Main.netMode != 2)
      return;
    if (remoteClient == -1)
    {
      for (int remoteClient1 = 0; remoteClient1 < (int) byte.MaxValue; ++remoteClient1)
      {
        if (Netplay.Clients[remoteClient1].State == 10)
          NetMessage.SendData(74, remoteClient1, text: NetworkText.FromLiteral(Main.player[remoteClient1].name), number: Main.anglerQuest);
      }
    }
    else
    {
      if (Netplay.Clients[remoteClient].State != 10)
        return;
      NetMessage.SendData(74, remoteClient, text: NetworkText.FromLiteral(Main.player[remoteClient].name), number: Main.anglerQuest);
    }
  }

  public static void ResyncTiles(Rectangle area)
  {
    for (int clientId = 0; clientId < Netplay.Clients.Length; ++clientId)
    {
      if (Netplay.Clients[clientId].IsActive)
        NetMessage.ResyncTiles(clientId, area);
    }
  }

  private static void ResyncTiles(int clientId, Rectangle area)
  {
    for (int left = area.Left; left < area.Right; left += 200)
    {
      for (int top = area.Top; top < area.Bottom; top += 150)
        NetMessage.SendData(10, clientId, number: left, number2: (float) top, number3: (float) Math.Min(area.Right - left, 200), number4: (float) Math.Min(area.Bottom - top, 150));
    }
  }

  public static void SendSection(int whoAmi, int sectionX, int sectionY)
  {
    if (Main.netMode != 2)
      return;
    try
    {
      if (sectionX < 0 || sectionY < 0 || sectionX >= Main.maxSectionsX || sectionY >= Main.maxSectionsY || Netplay.Clients[whoAmi].TileSections[sectionX, sectionY])
        return;
      Netplay.Clients[whoAmi].TileSections[sectionX, sectionY] = true;
      int number = sectionX * 200;
      int num = sectionY * 150;
      int number4 = 150;
      for (int number2 = num; number2 < num + 150; number2 += number4)
        NetMessage.SendData(10, whoAmi, number: number, number2: (float) number2, number3: 200f, number4: (float) number4);
      NetMessage.SyncNPCsForSection(whoAmi, sectionX, sectionY);
      NetMessage.SyncChestContentsForSection(whoAmi, sectionX, sectionY);
    }
    catch
    {
    }
  }

  private static void SyncChestContentsForSection(int whoAmi, int sectionX, int sectionY)
  {
    for (int chest1 = 0; chest1 < 8000; ++chest1)
    {
      Chest chest2 = Main.chest[chest1];
      if (chest2 != null)
      {
        int sectionX1 = Netplay.GetSectionX(chest2.x);
        int sectionY1 = Netplay.GetSectionY(chest2.y);
        if (sectionX == sectionX1 && sectionY == sectionY1)
          NetMessage.SendChestContentsTo(chest1, whoAmi);
      }
    }
  }

  private static void SyncNPCsForSection(int whoAmi, int sectionX, int sectionY)
  {
    for (int number = 0; number < Main.maxNPCs; ++number)
    {
      if (Main.npc[number].active && Main.npc[number].townNPC)
      {
        int sectionX1 = Netplay.GetSectionX((int) ((double) Main.npc[number].position.X / 16.0));
        int sectionY1 = Netplay.GetSectionY((int) ((double) Main.npc[number].position.Y / 16.0));
        int num = sectionX;
        if (sectionX1 == num && sectionY1 == sectionY)
          NetMessage.SendData(23, whoAmi, number: number);
      }
    }
  }

  public static void greetPlayer(int plr)
  {
    if (Main.motd == "")
      ChatHelper.SendChatMessageToClient(NetworkText.FromFormattable("{0} {1}!", (object) Lang.mp[18].ToNetworkText(), (object) Main.worldName), new Color((int) byte.MaxValue, 240 /*0xF0*/, 20), plr);
    else
      ChatHelper.SendChatMessageToClient(NetworkText.FromLiteral(Main.motd), new Color((int) byte.MaxValue, 240 /*0xF0*/, 20), plr);
    string str = "";
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].active)
        str = !(str == "") ? $"{str}, {Main.player[index].name}" : str + Main.player[index].name;
    }
    ChatHelper.SendChatMessageToClient(NetworkText.FromKey("Game.JoinGreeting", (object) str), new Color((int) byte.MaxValue, 240 /*0xF0*/, 20), plr);
  }

  public static void sendWater(int x, int y)
  {
    if (Main.netMode == 1)
    {
      NetMessage.SendData(48 /*0x30*/, number: x, number2: (float) y);
    }
    else
    {
      for (int remoteClient = 0; remoteClient < 256 /*0x0100*/; ++remoteClient)
      {
        if ((NetMessage.buffer[remoteClient].broadcast || Netplay.Clients[remoteClient].State >= 3) && Netplay.Clients[remoteClient].IsConnected())
        {
          int index1 = x / 200;
          int index2 = y / 150;
          if (Netplay.Clients[remoteClient].TileSections[index1, index2])
            NetMessage.SendData(48 /*0x30*/, remoteClient, number: x, number2: (float) y);
        }
      }
    }
  }

  public static void SyncDisconnectedPlayer(int plr)
  {
    NetMessage.SyncOnePlayer(plr, -1, plr);
    NetMessage.EnsureLocalPlayerIsPresent();
  }

  public static void SyncConnectedPlayer(int plr)
  {
    NetMessage.SyncOnePlayer(plr, -1, plr);
    for (int plr1 = 0; plr1 < (int) byte.MaxValue; ++plr1)
    {
      if (plr != plr1 && Main.player[plr1].active)
        NetMessage.SyncOnePlayer(plr1, plr, -1);
    }
    NetMessage.SendNPCHousesAndTravelShop(plr);
    NetMessage.SendAnglerQuest(plr);
    CreditsRollEvent.SendCreditsRollRemainingTimeToPlayer(plr);
    NPC.RevengeManager.SendAllMarkersToPlayer(plr);
    NetMessage.EnsureLocalPlayerIsPresent();
    DebugOptions.SyncToJoiningPlayer(plr);
  }

  private static void SendNPCHousesAndTravelShop(int plr)
  {
    bool flag1 = false;
    for (int number = 0; number < Main.maxNPCs; ++number)
    {
      NPC n = Main.npc[number];
      if (n.active)
      {
        bool flag2 = n.townNPC && NPC.TypeToDefaultHeadIndex(n.type) > 0;
        if (n.aiStyle == 7)
          flag2 = true;
        if (flag2)
        {
          if (!flag1 && n.type == 368)
            flag1 = true;
          byte householdStatus = WorldGen.TownManager.GetHouseholdStatus(n);
          NetMessage.SendData(60, plr, number: number, number2: (float) n.homeTileX, number3: (float) n.homeTileY, number4: (float) householdStatus);
        }
      }
    }
    if (!flag1)
      return;
    NetMessage.SendTravelShop(plr);
  }

  private static void EnsureLocalPlayerIsPresent()
  {
    if (!Main.autoShutdown)
      return;
    bool flag = false;
    for (int plr = 0; plr < (int) byte.MaxValue; ++plr)
    {
      if (NetMessage.DoesPlayerSlotCountAsAHost(plr))
      {
        flag = true;
        break;
      }
    }
    if (flag)
      return;
    Console.WriteLine(Language.GetTextValue("Net.ServerAutoShutdown"));
    Netplay.Disconnect = true;
  }

  public static bool DoesPlayerSlotCountAsAHost(int plr)
  {
    return Netplay.Clients[plr].State == 10 && Netplay.Clients[plr].Socket.GetRemoteAddress().IsLocalHost();
  }

  private static void SyncOnePlayer(int plr, int toWho, int fromWho)
  {
    int number2_1 = 0;
    if (Main.player[plr].active)
      number2_1 = 1;
    if (Netplay.Clients[plr].State == 10)
    {
      NetMessage.SendData(14, toWho, fromWho, number: plr, number2: (float) number2_1);
      NetMessage.SendData(4, toWho, fromWho, number: plr);
      NetMessage.SendData(13, toWho, fromWho, number: plr);
      if (Main.player[plr].statLife <= 0)
        NetMessage.SendData(135, toWho, fromWho, number: plr);
      NetMessage.SendData(16 /*0x10*/, toWho, fromWho, number: plr);
      NetMessage.SendData(30, toWho, fromWho, number: plr);
      NetMessage.SendData(45, toWho, fromWho, number: plr);
      NetMessage.SendData(42, toWho, fromWho, number: plr);
      NetMessage.SendData(50, toWho, fromWho, number: plr);
      NetMessage.SendData(80 /*0x50*/, toWho, fromWho, number: plr, number2: (float) Main.player[plr].chest);
      NetMessage.SendData(142, toWho, fromWho, number: plr);
      NetMessage.SendData(147, toWho, fromWho, number: plr, number2: (float) Main.player[plr].CurrentLoadoutIndex);
      TagEffectState.NetModule.SyncStateIfNecessary(Main.player[plr].TagEffectState, toWho, fromWho);
      for (int index = 0; index < 59; ++index)
        NetMessage.SendData(5, toWho, fromWho, number: plr, number2: (float) (PlayerItemSlotID.Inventory0 + index));
      for (int index = 0; index < Main.player[plr].armor.Length; ++index)
        NetMessage.SendData(5, toWho, fromWho, number: plr, number2: (float) (PlayerItemSlotID.Armor0 + index));
      for (int index = 0; index < Main.player[plr].dye.Length; ++index)
        NetMessage.SendData(5, toWho, fromWho, number: plr, number2: (float) (PlayerItemSlotID.Dye0 + index));
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].miscEquips, PlayerItemSlotID.Misc0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].miscDyes, PlayerItemSlotID.MiscDye0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[0].Armor, PlayerItemSlotID.Loadout1_Armor_0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[0].Dye, PlayerItemSlotID.Loadout1_Dye_0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[1].Armor, PlayerItemSlotID.Loadout2_Armor_0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[1].Dye, PlayerItemSlotID.Loadout2_Dye_0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[2].Armor, PlayerItemSlotID.Loadout3_Armor_0);
      NetMessage.SyncOnePlayer_ItemArray(plr, toWho, fromWho, Main.player[plr].Loadouts[2].Dye, PlayerItemSlotID.Loadout3_Dye_0);
      if (!Netplay.Clients[plr].IsAnnouncementCompleted)
      {
        Netplay.Clients[plr].IsAnnouncementCompleted = true;
        ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.mp[19].Key, (object) Main.player[plr].name), new Color((int) byte.MaxValue, 240 /*0xF0*/, 20), plr);
        if (Main.dedServ)
          Console.WriteLine(Lang.mp[19].Format((object) Main.player[plr].name));
      }
      for (int number = 0; number < 1000; ++number)
      {
        Projectile projectile = Main.projectile[number];
        if (projectile.active && projectile.owner == plr)
          NetMessage.SendData(27, toWho, number: number);
      }
    }
    else
    {
      int number2_2 = 0;
      NetMessage.SendData(14, ignoreClient: plr, number: plr, number2: (float) number2_2);
      if (Netplay.Clients[plr].IsAnnouncementCompleted)
      {
        Netplay.Clients[plr].IsAnnouncementCompleted = false;
        ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.mp[20].Key, (object) Netplay.Clients[plr].Name), new Color((int) byte.MaxValue, 240 /*0xF0*/, 20), plr);
        if (Main.dedServ)
          Console.WriteLine(Lang.mp[20].Format((object) Netplay.Clients[plr].Name));
        Netplay.Clients[plr].Name = "Anonymous";
      }
      Player.Hooks.PlayerDisconnect(plr);
    }
  }

  private static void SyncOnePlayer_ItemArray(
    int plr,
    int toWho,
    int fromWho,
    Item[] arr,
    int slot)
  {
    for (int index = 0; index < arr.Length; ++index)
      NetMessage.SendData(5, toWho, fromWho, number: plr, number2: (float) (slot + index));
  }

  public struct NetSoundInfo(
    Vector2 position,
    ushort soundIndex,
    int style = -1,
    float volume = -1f,
    float pitchOffset = -1f)
  {
    public Vector2 position = position;
    public ushort soundIndex = soundIndex;
    public int style = style;
    public float volume = volume;
    public float pitchOffset = pitchOffset;

    public void WriteSelfTo(BinaryWriter writer)
    {
      writer.WriteVector2(this.position);
      writer.Write(this.soundIndex);
      BitsByte bitsByte = new BitsByte(this.style != -1, (double) this.volume != -1.0, (double) this.pitchOffset != -1.0);
      writer.Write((byte) bitsByte);
      if (bitsByte[0])
        writer.Write(this.style);
      if (bitsByte[1])
        writer.Write(this.volume);
      if (!bitsByte[2])
        return;
      writer.Write(this.pitchOffset);
    }
  }
}
