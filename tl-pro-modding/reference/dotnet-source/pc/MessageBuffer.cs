// Decompiled with JetBrains decompiler
// Type: Terraria.MessageBuffer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Events;
using Terraria.GameContent.Golf;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;
using Terraria.Net.Sockets;
using Terraria.Testing;
using Terraria.UI;

#nullable disable
namespace Terraria;

public class MessageBuffer
{
  public const int readBufferMax = 131070;
  public const int writeBufferMax = 131070;
  public bool broadcast;
  public byte[] readBuffer = new byte[131070];
  public byte[] writeBuffer = new byte[131070];
  public bool writeLocked;
  public int messageLength;
  public int totalData;
  public int whoAmI;
  public int spamCount;
  public int maxSpam;
  public bool checkBytes;
  public MemoryStream readerStream;
  public MemoryStream writerStream;
  public BinaryReader reader;
  public BinaryWriter writer;
  public PacketHistory History = new PacketHistory();
  private float[] _temporaryProjectileAI = new float[Projectile.maxAI];
  private float[] _temporaryNPCAI = new float[NPC.maxAI];

  public int RemainingReadBufferLength => this.readBuffer.Length - this.totalData;

  public static event TileChangeReceivedEvent OnTileChangeReceived;

  public void Reset()
  {
    Array.Clear((Array) this.readBuffer, 0, this.readBuffer.Length);
    Array.Clear((Array) this.writeBuffer, 0, this.writeBuffer.Length);
    this.writeLocked = false;
    this.messageLength = 0;
    this.totalData = 0;
    this.spamCount = 0;
    this.broadcast = false;
    this.checkBytes = false;
    this.ResetReader();
    this.ResetWriter();
  }

  public void ResetReader()
  {
    if (this.readerStream != null)
      this.readerStream.Close();
    this.readerStream = new MemoryStream(this.readBuffer);
    this.reader = new BinaryReader((Stream) this.readerStream);
  }

  public void ResetWriter()
  {
    if (this.writerStream != null)
      this.writerStream.Close();
    this.writerStream = new MemoryStream(this.writeBuffer);
    this.writer = new BinaryWriter((Stream) this.writerStream);
  }

  private float[] ReUseTemporaryProjectileAI()
  {
    for (int index = 0; index < this._temporaryProjectileAI.Length; ++index)
      this._temporaryProjectileAI[index] = 0.0f;
    return this._temporaryProjectileAI;
  }

  private float[] ReUseTemporaryNPCAI()
  {
    for (int index = 0; index < this._temporaryNPCAI.Length; ++index)
      this._temporaryNPCAI[index] = 0.0f;
    return this._temporaryNPCAI;
  }

  public void GetData(int start, int length, out int messageType)
  {
    if (this.whoAmI < 256 /*0x0100*/)
      Netplay.Clients[this.whoAmI].TimeOutTimer = 0;
    else
      Netplay.Connection.TimeOutTimer = 0;
    int num1 = start + 1;
    byte num2 = this.readBuffer[start];
    messageType = (int) num2;
    if ((int) num2 >= (int) MessageID.Count)
      return;
    Main.ActiveNetDiagnosticsUI.CountReadMessage((int) num2, length);
    if (Main.netMode == 1 && Netplay.Connection.StatusMax > 0)
      ++Netplay.Connection.StatusCount;
    if (Main.verboseNetplay)
    {
      int num3 = start;
      while (num3 < start + length)
        ++num3;
      for (int index = start; index < start + length; ++index)
      {
        int num4 = (int) this.readBuffer[index];
      }
    }
    if (Main.netMode == 2 && num2 != (byte) 38 && Netplay.Clients[this.whoAmI].State == -1)
    {
      NetMessage.TrySendData(2, this.whoAmI, text: Lang.mp[1].ToNetworkText());
    }
    else
    {
      if (Main.netMode == 2)
      {
        if (Netplay.Clients[this.whoAmI].State < 10 && num2 > (byte) 12 && num2 != (byte) 93 && num2 != (byte) 16 /*0x10*/ && num2 != (byte) 42 && num2 != (byte) 50 && num2 != (byte) 38 && num2 != (byte) 68 && num2 != (byte) 147 && num2 != (byte) 161)
          NetMessage.BootPlayer(this.whoAmI, Lang.mp[2].ToNetworkText());
        if (Netplay.Clients[this.whoAmI].State == 0 && num2 != (byte) 1)
          NetMessage.BootPlayer(this.whoAmI, Lang.mp[2].ToNetworkText());
      }
      if (this.reader == null)
        this.ResetReader();
      this.reader.BaseStream.Position = (long) num1;
      switch (num2)
      {
        case 1:
          if (Main.netMode != 2)
            break;
          if (Main.dedServ && Netplay.IsBanned(Netplay.Clients[this.whoAmI].Socket.GetRemoteAddress()))
          {
            NetMessage.TrySendData(2, this.whoAmI, text: Lang.mp[3].ToNetworkText());
            break;
          }
          if (Netplay.Clients[this.whoAmI].State != 0)
            break;
          if (this.reader.ReadString() == "Terraria" + (object) 318)
          {
            if (string.IsNullOrEmpty(Netplay.ServerPassword))
            {
              Netplay.Clients[this.whoAmI].State = 1;
              NetMessage.TrySendData(3, this.whoAmI);
              break;
            }
            Netplay.Clients[this.whoAmI].State = -1;
            NetMessage.TrySendData(37, this.whoAmI);
            break;
          }
          NetMessage.TrySendData(2, this.whoAmI, text: Lang.mp[4].ToNetworkText());
          break;
        case 2:
          if (Main.netMode != 1)
            break;
          Netplay.Disconnect = true;
          Main.statusText = NetworkText.Deserialize(this.reader).ToString();
          break;
        case 3:
          if (Main.netMode != 1)
            break;
          if (Netplay.Connection.State == 1)
            Netplay.Connection.State = 2;
          int index1 = (int) this.reader.ReadByte();
          bool flag1 = this.reader.ReadBoolean();
          Netplay.Connection.ServerSpecialFlags[2] = flag1;
          if (index1 != Main.myPlayer)
          {
            Main.player[index1] = Main.ActivePlayerFileData.Player;
            Main.player[Main.myPlayer] = new Player();
          }
          Main.player[index1].whoAmI = index1;
          Main.myPlayer = index1;
          Player player1 = Main.player[index1];
          NetMessage.TrySendData(4, number: index1);
          NetMessage.TrySendData(68, number: index1);
          NetMessage.TrySendData(16 /*0x10*/, number: index1);
          NetMessage.TrySendData(42, number: index1);
          NetMessage.TrySendData(50, number: index1);
          NetMessage.TrySendData(147, number: index1, number2: (float) player1.CurrentLoadoutIndex);
          for (int index2 = 0; index2 < 59; ++index2)
            NetMessage.TrySendData(5, number: index1, number2: (float) (PlayerItemSlotID.Inventory0 + index2));
          MessageBuffer.TrySendingItemArray(index1, player1.armor, PlayerItemSlotID.Armor0);
          MessageBuffer.TrySendingItemArray(index1, player1.dye, PlayerItemSlotID.Dye0);
          MessageBuffer.TrySendingItemArray(index1, player1.miscEquips, PlayerItemSlotID.Misc0);
          MessageBuffer.TrySendingItemArray(index1, player1.miscDyes, PlayerItemSlotID.MiscDye0);
          MessageBuffer.TrySendingItemArray(index1, player1.bank.item, PlayerItemSlotID.Bank1_0);
          MessageBuffer.TrySendingItemArray(index1, player1.bank2.item, PlayerItemSlotID.Bank2_0);
          NetMessage.TrySendData(5, number: index1, number2: (float) PlayerItemSlotID.TrashItem);
          MessageBuffer.TrySendingItemArray(index1, player1.bank3.item, PlayerItemSlotID.Bank3_0);
          MessageBuffer.TrySendingItemArray(index1, player1.bank4.item, PlayerItemSlotID.Bank4_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[0].Armor, PlayerItemSlotID.Loadout1_Armor_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[0].Dye, PlayerItemSlotID.Loadout1_Dye_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[1].Armor, PlayerItemSlotID.Loadout2_Armor_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[1].Dye, PlayerItemSlotID.Loadout2_Dye_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[2].Armor, PlayerItemSlotID.Loadout3_Armor_0);
          MessageBuffer.TrySendingItemArray(index1, player1.Loadouts[2].Dye, PlayerItemSlotID.Loadout3_Dye_0);
          if (!string.IsNullOrWhiteSpace(Netplay.HostToken))
            NetMessage.TrySendData(161, text: NetworkText.FromLiteral(Netplay.HostToken));
          NetMessage.TrySendData(6);
          if (Netplay.Connection.State != 2)
            break;
          Netplay.Connection.State = 3;
          break;
        case 4:
          int number1 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number1 = this.whoAmI;
          if (number1 == Main.myPlayer && !Main.ServerSideCharacter)
            break;
          Player player2 = Main.player[number1];
          player2.whoAmI = number1;
          player2.skinVariant = (int) this.reader.ReadByte();
          player2.skinVariant = (int) MathHelper.Clamp((float) player2.skinVariant, 0.0f, (float) (PlayerVariantID.Count - 1));
          player2.voiceVariant = (int) this.reader.ReadByte();
          player2.voiceVariant = Utils.Clamp<int>(player2.voiceVariant, 1, 4);
          player2.voicePitchOffset = this.reader.ReadSingle();
          if (float.IsNaN(player2.voicePitchOffset))
            player2.voicePitchOffset = 0.0f;
          player2.voicePitchOffset = Utils.Clamp<float>(player2.voicePitchOffset, -1f, 1f);
          player2.hair = (int) this.reader.ReadByte();
          if (player2.hair >= 228)
            player2.hair = 0;
          player2.name = this.reader.ReadString().Trim().Trim();
          player2.hairDye = this.reader.ReadByte();
          MessageBuffer.ReadAccessoryVisibility(this.reader, player2.hideVisibleAccessory);
          player2.hideMisc = (BitsByte) this.reader.ReadByte();
          player2.hairColor = this.reader.ReadRGB();
          player2.skinColor = this.reader.ReadRGB();
          player2.eyeColor = this.reader.ReadRGB();
          player2.shirtColor = this.reader.ReadRGB();
          player2.underShirtColor = this.reader.ReadRGB();
          player2.pantsColor = this.reader.ReadRGB();
          player2.shoeColor = this.reader.ReadRGB();
          BitsByte bitsByte1 = (BitsByte) this.reader.ReadByte();
          player2.difficulty = (byte) 0;
          if (bitsByte1[0])
            player2.difficulty = (byte) 1;
          if (bitsByte1[1])
            player2.difficulty = (byte) 2;
          if (bitsByte1[3])
            player2.difficulty = (byte) 3;
          if (player2.difficulty > (byte) 3)
            player2.difficulty = (byte) 3;
          player2.extraAccessory = bitsByte1[2];
          BitsByte bitsByte2 = (BitsByte) this.reader.ReadByte();
          player2.UsingBiomeTorches = bitsByte2[0];
          player2.happyFunTorchTime = bitsByte2[1];
          player2.unlockedBiomeTorches = bitsByte2[2];
          player2.unlockedSuperCart = bitsByte2[3];
          player2.enabledSuperCart = bitsByte2[4];
          BitsByte bitsByte3 = (BitsByte) this.reader.ReadByte();
          player2.usedAegisCrystal = bitsByte3[0];
          player2.usedAegisFruit = bitsByte3[1];
          player2.usedArcaneCrystal = bitsByte3[2];
          player2.usedGalaxyPearl = bitsByte3[3];
          player2.usedGummyWorm = bitsByte3[4];
          player2.usedAmbrosia = bitsByte3[5];
          player2.ateArtisanBread = bitsByte3[6];
          if (Main.netMode != 2)
            break;
          bool flag2 = false;
          if (Netplay.Clients[this.whoAmI].State < 10)
          {
            for (int index3 = 0; index3 < (int) byte.MaxValue; ++index3)
            {
              if (index3 != number1 && player2.name == Main.player[index3].name && Netplay.Clients[index3].IsActive)
                flag2 = true;
            }
          }
          if (flag2)
          {
            NetMessage.TrySendData(2, this.whoAmI, text: NetworkText.FromKey(Lang.mp[5].Key, (object) player2.name));
            break;
          }
          if (player2.name.Length > Player.nameLen)
          {
            NetMessage.TrySendData(2, this.whoAmI, text: NetworkText.FromKey("Net.NameTooLong"));
            break;
          }
          if (player2.name == "")
          {
            NetMessage.TrySendData(2, this.whoAmI, text: NetworkText.FromKey("Net.EmptyName"));
            break;
          }
          if (player2.difficulty == (byte) 3 && !Main.IsJourneyMode)
          {
            NetMessage.TrySendData(2, this.whoAmI, text: NetworkText.FromKey("Net.PlayerIsCreativeAndWorldIsNotCreative"));
            break;
          }
          if (player2.difficulty != (byte) 3 && Main.IsJourneyMode)
          {
            NetMessage.TrySendData(2, this.whoAmI, text: NetworkText.FromKey("Net.PlayerIsNotCreativeAndWorldIsCreative"));
            break;
          }
          Netplay.Clients[this.whoAmI].Name = player2.name;
          Netplay.Clients[this.whoAmI].Name = player2.name;
          NetMessage.TrySendData(4, ignoreClient: this.whoAmI, number: number1);
          break;
        case 5:
          int number2 = (int) this.reader.ReadByte();
          int index4 = (int) this.reader.ReadInt16();
          int num5 = (int) this.reader.ReadInt16();
          int prefixWeWant1 = (int) this.reader.ReadByte();
          int Type1 = (int) this.reader.ReadInt16();
          BitsByte bitsByte4 = (BitsByte) this.reader.ReadByte();
          bool flag3 = bitsByte4[0];
          bool flag4 = bitsByte4[1];
          if (Main.netMode == 2)
            number2 = this.whoAmI;
          if (number2 == Main.myPlayer && !Main.ServerSideCharacter && !Main.player[number2].HasLockedInventory())
            break;
          Player player3 = Main.player[number2];
          lock (player3)
          {
            PlayerItemSlotID.SlotReference slot = new PlayerItemSlotID.SlotReference(player3, index4);
            PlayerItemSlotID.SlotReference slotReference = new PlayerItemSlotID.SlotReference(Main.clientPlayer, index4);
            Item obj = new Item();
            obj.SetDefaults(Type1);
            obj.stack = num5;
            obj.Prefix(prefixWeWant1);
            obj.favorited = flag3;
            slot.Item = obj;
            if (number2 == Main.myPlayer && !Main.ServerSideCharacter)
              slotReference.Item = obj.Clone();
            if (index4 >= PlayerItemSlotID.Bank4_0 && index4 < PlayerItemSlotID.Loadout1_Armor_0)
            {
              if (Main.netMode == 1 && player3.disableVoidBag == index4 - PlayerItemSlotID.Bank4_0)
                player3.disableVoidBag = -1;
            }
            else if (index4 <= 58)
            {
              if (number2 == Main.myPlayer && index4 == 58)
                Main.mouseItem = obj.Clone();
              if (number2 == Main.myPlayer && Main.netMode == 1)
                Main.player[number2].inventoryChestStack[index4] = false;
            }
            if (((Main.netMode != 1 ? 0 : (number2 == Main.myPlayer ? 1 : 0)) & (flag4 ? 1 : 0)) != 0)
              ItemSlot.IndicateBlockedSlot(slot);
            bool[] canRelay = PlayerItemSlotID.CanRelay;
            if (Main.netMode != 2 || number2 != this.whoAmI || !canRelay.IndexInRange<bool>(index4) || !canRelay[index4])
              break;
            NetMessage.TrySendData(5, ignoreClient: this.whoAmI, number: number2, number2: (float) index4);
            break;
          }
        case 6:
          if (Main.netMode != 2)
            break;
          if (Netplay.Clients[this.whoAmI].State == 1)
            Netplay.Clients[this.whoAmI].State = 2;
          NetMessage.TrySendData(7, this.whoAmI);
          Main.SyncAnInvasion(this.whoAmI);
          break;
        case 7:
          if (Main.netMode != 1)
            break;
          Main.time = (double) this.reader.ReadInt32();
          BitsByte bitsByte5 = (BitsByte) this.reader.ReadByte();
          Main.dayTime = bitsByte5[0];
          Main.bloodMoon = bitsByte5[1];
          Main.eclipse = bitsByte5[2];
          Main.moonPhase = (int) this.reader.ReadByte();
          Main.maxTilesX = (int) this.reader.ReadInt16();
          Main.maxTilesY = (int) this.reader.ReadInt16();
          Main.spawnTileX = (int) this.reader.ReadInt16();
          Main.spawnTileY = (int) this.reader.ReadInt16();
          Main.worldSurface = (double) this.reader.ReadInt16();
          Main.rockLayer = (double) this.reader.ReadInt16();
          Main.ActiveWorldFileData.WorldId = this.reader.ReadInt32();
          Main.worldName = this.reader.ReadString();
          Main.GameMode = (int) this.reader.ReadByte();
          Main.ActiveWorldFileData.UniqueId = new Guid(this.reader.ReadBytes(16 /*0x10*/));
          Main.ActiveWorldFileData.WorldGeneratorVersion = this.reader.ReadUInt64();
          Main.moonType = (int) this.reader.ReadByte();
          WorldGen.setBG(0, (int) this.reader.ReadByte());
          WorldGen.setBG(10, (int) this.reader.ReadByte());
          WorldGen.setBG(11, (int) this.reader.ReadByte());
          WorldGen.setBG(12, (int) this.reader.ReadByte());
          WorldGen.setBG(1, (int) this.reader.ReadByte());
          WorldGen.setBG(2, (int) this.reader.ReadByte());
          WorldGen.setBG(3, (int) this.reader.ReadByte());
          WorldGen.setBG(4, (int) this.reader.ReadByte());
          WorldGen.setBG(5, (int) this.reader.ReadByte());
          WorldGen.setBG(6, (int) this.reader.ReadByte());
          WorldGen.setBG(7, (int) this.reader.ReadByte());
          WorldGen.setBG(8, (int) this.reader.ReadByte());
          WorldGen.setBG(9, (int) this.reader.ReadByte());
          Main.iceBackStyle = (int) this.reader.ReadByte();
          Main.jungleBackStyle = (int) this.reader.ReadByte();
          Main.hellBackStyle = (int) this.reader.ReadByte();
          Main.windSpeedTarget = this.reader.ReadSingle();
          Main.numClouds = (int) this.reader.ReadByte();
          for (int index5 = 0; index5 < 3; ++index5)
            Main.treeX[index5] = this.reader.ReadInt32();
          for (int index6 = 0; index6 < 4; ++index6)
            Main.treeStyle[index6] = (int) this.reader.ReadByte();
          for (int index7 = 0; index7 < 3; ++index7)
            Main.caveBackX[index7] = this.reader.ReadInt32();
          for (int index8 = 0; index8 < 4; ++index8)
            Main.caveBackStyle[index8] = (int) this.reader.ReadByte();
          WorldGen.TreeTops.SyncReceive(this.reader);
          WorldGen.BackgroundsCache.UpdateCache();
          Main.maxRaining = this.reader.ReadSingle();
          Main.raining = (double) Main.maxRaining > 0.0;
          BitsByte bitsByte6 = (BitsByte) this.reader.ReadByte();
          WorldGen.shadowOrbSmashed = bitsByte6[0];
          NPC.downedBoss1 = bitsByte6[1];
          NPC.downedBoss2 = bitsByte6[2];
          NPC.downedBoss3 = bitsByte6[3];
          Main.hardMode = bitsByte6[4];
          NPC.downedClown = bitsByte6[5];
          Main.ServerSideCharacter = bitsByte6[6];
          NPC.downedPlantBoss = bitsByte6[7];
          if (Main.ServerSideCharacter)
            Main.ActivePlayerFileData.MarkAsServerSide();
          BitsByte bitsByte7 = (BitsByte) this.reader.ReadByte();
          NPC.downedMechBoss1 = bitsByte7[0];
          NPC.downedMechBoss2 = bitsByte7[1];
          NPC.downedMechBoss3 = bitsByte7[2];
          NPC.downedMechBossAny = bitsByte7[3];
          Main.cloudBGActive = bitsByte7[4] ? 1f : 0.0f;
          WorldGen.crimson = bitsByte7[5];
          Main.pumpkinMoon = bitsByte7[6];
          Main.snowMoon = bitsByte7[7];
          BitsByte bitsByte8 = (BitsByte) this.reader.ReadByte();
          Main.fastForwardTimeToDawn = bitsByte8[1];
          Main.UpdateTimeRate();
          int num6 = bitsByte8[2] ? 1 : 0;
          NPC.downedSlimeKing = bitsByte8[3];
          NPC.downedQueenBee = bitsByte8[4];
          NPC.downedFishron = bitsByte8[5];
          NPC.downedMartians = bitsByte8[6];
          NPC.downedAncientCultist = bitsByte8[7];
          BitsByte bitsByte9 = (BitsByte) this.reader.ReadByte();
          NPC.downedMoonlord = bitsByte9[0];
          NPC.downedHalloweenKing = bitsByte9[1];
          NPC.downedHalloweenTree = bitsByte9[2];
          NPC.downedChristmasIceQueen = bitsByte9[3];
          NPC.downedChristmasSantank = bitsByte9[4];
          NPC.downedChristmasTree = bitsByte9[5];
          NPC.downedGolemBoss = bitsByte9[6];
          BirthdayParty.ManualParty = bitsByte9[7];
          BitsByte bitsByte10 = (BitsByte) this.reader.ReadByte();
          NPC.downedPirates = bitsByte10[0];
          NPC.downedFrost = bitsByte10[1];
          NPC.downedGoblins = bitsByte10[2];
          Sandstorm.Happening = bitsByte10[3];
          DD2Event.Ongoing = bitsByte10[4];
          DD2Event.DownedInvasionT1 = bitsByte10[5];
          DD2Event.DownedInvasionT2 = bitsByte10[6];
          DD2Event.DownedInvasionT3 = bitsByte10[7];
          BitsByte bitsByte11 = (BitsByte) this.reader.ReadByte();
          NPC.combatBookWasUsed = bitsByte11[0];
          LanternNight.ManualLanterns = bitsByte11[1];
          NPC.downedTowerSolar = bitsByte11[2];
          NPC.downedTowerVortex = bitsByte11[3];
          NPC.downedTowerNebula = bitsByte11[4];
          NPC.downedTowerStardust = bitsByte11[5];
          Main.forceHalloweenForToday = bitsByte11[6];
          Main.forceXMasForToday = bitsByte11[7];
          BitsByte bitsByte12 = (BitsByte) this.reader.ReadByte();
          NPC.boughtCat = bitsByte12[0];
          NPC.boughtDog = bitsByte12[1];
          NPC.boughtBunny = bitsByte12[2];
          NPC.freeCake = bitsByte12[3];
          Main.drunkWorld = bitsByte12[4];
          NPC.downedEmpressOfLight = bitsByte12[5];
          NPC.downedQueenSlime = bitsByte12[6];
          Main.getGoodWorld = bitsByte12[7];
          BitsByte bitsByte13 = (BitsByte) this.reader.ReadByte();
          Main.tenthAnniversaryWorld = bitsByte13[0];
          Main.dontStarveWorld = bitsByte13[1];
          NPC.downedDeerclops = bitsByte13[2];
          Main.notTheBeesWorld = bitsByte13[3];
          Main.remixWorld = bitsByte13[4];
          NPC.unlockedSlimeBlueSpawn = bitsByte13[5];
          NPC.combatBookVolumeTwoWasUsed = bitsByte13[6];
          NPC.peddlersSatchelWasUsed = bitsByte13[7];
          BitsByte bitsByte14 = (BitsByte) this.reader.ReadByte();
          NPC.unlockedSlimeGreenSpawn = bitsByte14[0];
          NPC.unlockedSlimeOldSpawn = bitsByte14[1];
          NPC.unlockedSlimePurpleSpawn = bitsByte14[2];
          NPC.unlockedSlimeRainbowSpawn = bitsByte14[3];
          NPC.unlockedSlimeRedSpawn = bitsByte14[4];
          NPC.unlockedSlimeYellowSpawn = bitsByte14[5];
          NPC.unlockedSlimeCopperSpawn = bitsByte14[6];
          Main.fastForwardTimeToDusk = bitsByte14[7];
          BitsByte bitsByte15 = (BitsByte) this.reader.ReadByte();
          Main.noTrapsWorld = bitsByte15[0];
          Main.zenithWorld = bitsByte15[1];
          NPC.unlockedTruffleSpawn = bitsByte15[2];
          Main.vampireSeed = bitsByte15[3];
          Main.infectedSeed = bitsByte15[4];
          Main.teamBasedSpawnsSeed = bitsByte15[5];
          Main.skyblockWorld = bitsByte15[6];
          Main.dualDungeonsSeed = bitsByte15[7];
          WorldGen.Skyblock.lowTiles = ((BitsByte) this.reader.ReadByte())[0];
          Main.sundialCooldown = (int) this.reader.ReadByte();
          Main.moondialCooldown = (int) this.reader.ReadByte();
          WorldGen.SavedOreTiers.Copper = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Iron = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Silver = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Gold = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Cobalt = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Mythril = (int) this.reader.ReadInt16();
          WorldGen.SavedOreTiers.Adamantite = (int) this.reader.ReadInt16();
          if (num6 != 0)
            Main.StartSlimeRain(false);
          else
            Main.StopSlimeRain();
          Main.invasionType = (int) this.reader.ReadSByte();
          Main.LobbyId = this.reader.ReadUInt64();
          Sandstorm.IntendedSeverity = this.reader.ReadSingle();
          ExtraSpawnPointManager.Read(this.reader, true);
          if (Netplay.Connection.State == 3)
          {
            Main.windSpeedCurrent = Main.windSpeedTarget;
            Netplay.Connection.State = 4;
          }
          Main.checkHalloween();
          Main.checkXMas();
          break;
        case 8:
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(7, this.whoAmI);
          int x1 = this.reader.ReadInt32();
          int y1 = this.reader.ReadInt32();
          int team1 = (int) this.reader.ReadByte();
          bool flag5 = true;
          if (x1 == -1 || y1 == -1)
            flag5 = false;
          else if (x1 < 10 || x1 > Main.maxTilesX - 10)
            flag5 = false;
          else if (y1 < 10 || y1 > Main.maxTilesY - 10)
            flag5 = false;
          bool flag6 = false;
          if (Main.teamBasedSpawnsSeed && team1 != 0)
            flag6 = true;
          int num7 = Netplay.GetSectionX(Main.spawnTileX) - 2;
          int num8 = Netplay.GetSectionY(Main.spawnTileY) - 1;
          int num9 = num7 + 5;
          int num10 = num8 + 3;
          if (num7 < 0)
            num7 = 0;
          if (num9 >= Main.maxSectionsX)
            num9 = Main.maxSectionsX;
          if (num8 < 0)
            num8 = 0;
          if (num10 >= Main.maxSectionsY)
            num10 = Main.maxSectionsY;
          int num11 = (num9 - num7) * (num10 - num8);
          List<Point> dontInclude = new List<Point>();
          for (int x2 = num7; x2 < num9; ++x2)
          {
            for (int y2 = num8; y2 < num10; ++y2)
              dontInclude.Add(new Point(x2, y2));
          }
          int num12 = -1;
          int num13 = -1;
          if (flag5)
          {
            x1 = Netplay.GetSectionX(x1) - 2;
            y1 = Netplay.GetSectionY(y1) - 1;
            num12 = x1 + 5;
            num13 = y1 + 3;
            if (x1 < 0)
              x1 = 0;
            if (num12 >= Main.maxSectionsX)
              num12 = Main.maxSectionsX - 1;
            if (y1 < 0)
              y1 = 0;
            if (num13 >= Main.maxSectionsY)
              num13 = Main.maxSectionsY - 1;
            for (int x3 = x1; x3 <= num12; ++x3)
            {
              for (int y3 = y1; y3 <= num13; ++y3)
              {
                if (x3 < num7 || x3 >= num9 || y3 < num8 || y3 >= num10)
                {
                  dontInclude.Add(new Point(x3, y3));
                  ++num11;
                }
              }
            }
          }
          int num14 = -1;
          int num15 = -1;
          int num16 = -1;
          int num17 = -1;
          if (flag6)
          {
            Point spawnPoint = Point.Zero;
            if (ExtraSpawnPointManager.TryGetExtraSpawnPointForTeam(team1, out spawnPoint))
            {
              int x4 = spawnPoint.X;
              int y4 = spawnPoint.Y;
              num14 = Netplay.GetSectionX(x4) - 2;
              num15 = Netplay.GetSectionY(y4) - 1;
              num16 = num14 + 5;
              num17 = num15 + 3;
              if (num14 < 0)
                num14 = 0;
              if (num16 >= Main.maxSectionsX)
                num16 = Main.maxSectionsX - 1;
              if (num15 < 0)
                num15 = 0;
              if (num17 >= Main.maxSectionsY)
                num17 = Main.maxSectionsY - 1;
              for (int x5 = num14; x5 <= num16; ++x5)
              {
                for (int y5 = num15; y5 <= num17; ++y5)
                {
                  if ((x5 < num7 || x5 >= num9 || y5 < num8 || y5 >= num10) && (x5 < x1 || x5 >= num12 || y5 < y1 || y5 >= num13))
                  {
                    dontInclude.Add(new Point(x5, y5));
                    ++num11;
                  }
                }
              }
            }
            else
              flag6 = false;
          }
          List<Point> portalSections;
          PortalHelper.SyncPortalsOnPlayerJoin(this.whoAmI, 1, dontInclude, out portalSections);
          int number3 = num11 + portalSections.Count;
          if (Netplay.Clients[this.whoAmI].State == 2)
            Netplay.Clients[this.whoAmI].State = 3;
          NetMessage.TrySendData(9, this.whoAmI, text: Lang.inter[44].ToNetworkText(), number: number3);
          Netplay.Clients[this.whoAmI].StatusText2 = Language.GetTextValue("Net.IsReceivingTileData");
          Netplay.Clients[this.whoAmI].StatusMax += number3;
          for (int sectionX = num7; sectionX < num9; ++sectionX)
          {
            for (int sectionY = num8; sectionY < num10; ++sectionY)
              NetMessage.SendSection(this.whoAmI, sectionX, sectionY);
          }
          if (flag5)
          {
            for (int sectionX = x1; sectionX <= num12; ++sectionX)
            {
              for (int sectionY = y1; sectionY <= num13; ++sectionY)
                NetMessage.SendSection(this.whoAmI, sectionX, sectionY);
            }
          }
          if (flag6)
          {
            for (int sectionX = num14; sectionX <= num16; ++sectionX)
            {
              for (int sectionY = num15; sectionY <= num17; ++sectionY)
                NetMessage.SendSection(this.whoAmI, sectionX, sectionY);
            }
          }
          for (int index9 = 0; index9 < portalSections.Count; ++index9)
            NetMessage.SendSection(this.whoAmI, portalSections[index9].X, portalSections[index9].Y);
          for (int number4 = 0; number4 < 400; ++number4)
          {
            if (Main.item[number4].active)
            {
              NetMessage.TrySendData(21, this.whoAmI, number: number4);
              NetMessage.TrySendData(22, this.whoAmI, number: number4);
            }
          }
          for (int number5 = 0; number5 < Main.maxNPCs; ++number5)
          {
            if (Main.npc[number5].active)
            {
              NetMessage.TrySendData(23, this.whoAmI, number: number5);
              NetMessage.TrySendData(54, this.whoAmI, number: number5);
            }
          }
          for (int number6 = 0; number6 < 1000; ++number6)
          {
            if (Main.projectile[number6].active && (Main.projPet[Main.projectile[number6].type] || Main.projectile[number6].netImportant))
              NetMessage.TrySendData(27, this.whoAmI, number: number6);
          }
          NetManager.Instance.SendToClient(BannerSystem.NetBannersModule.WriteFullState(), this.whoAmI);
          NetMessage.TrySendData(57, this.whoAmI);
          NetMessage.TrySendData(103);
          NetMessage.TrySendData(101, this.whoAmI);
          NetMessage.TrySendData(136, this.whoAmI);
          Main.BestiaryTracker.OnPlayerJoining(this.whoAmI);
          CreativePowerManager.Instance.SyncThingsToJoiningPlayer(this.whoAmI);
          Main.PylonSystem.OnPlayerJoining(this.whoAmI);
          NetMessage.TrySendData(49, this.whoAmI);
          break;
        case 9:
          if (Main.netMode != 1)
            break;
          Netplay.Connection.StatusMax += this.reader.ReadInt32();
          Netplay.Connection.StatusText = NetworkText.Deserialize(this.reader).ToString();
          BitsByte bitsByte16 = (BitsByte) this.reader.ReadByte();
          BitsByte serverSpecialFlags = Netplay.Connection.ServerSpecialFlags;
          serverSpecialFlags[0] = bitsByte16[0];
          serverSpecialFlags[1] = bitsByte16[1];
          Netplay.Connection.ServerSpecialFlags = serverSpecialFlags;
          break;
        case 10:
          if (Main.netMode != 1)
            break;
          NetMessage.DecompressTileBlock(this.reader.BaseStream);
          break;
        case 11:
          if (Main.netMode != 1)
            break;
          WorldGen.SectionTileFrame((int) this.reader.ReadInt16(), (int) this.reader.ReadInt16(), (int) this.reader.ReadInt16(), (int) this.reader.ReadInt16());
          break;
        case 12:
          int index10 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index10 = this.whoAmI;
          Player player4 = Main.player[index10];
          player4.SpawnX = (int) this.reader.ReadInt16();
          player4.SpawnY = (int) this.reader.ReadInt16();
          player4.respawnTimer = this.reader.ReadInt32();
          player4.numberOfDeathsPVE = (int) this.reader.ReadInt16();
          player4.numberOfDeathsPVP = (int) this.reader.ReadInt16();
          player4.team = (int) this.reader.ReadByte();
          if (player4.respawnTimer > 0)
            player4.dead = true;
          PlayerSpawnContext playerSpawnContext = (PlayerSpawnContext) this.reader.ReadByte();
          player4.Spawn(playerSpawnContext);
          if (Main.netMode != 2 || Netplay.Clients[this.whoAmI].State < 3)
            break;
          if (Netplay.Clients[this.whoAmI].State == 3)
          {
            Netplay.Clients[this.whoAmI].State = 10;
            NetMessage.buffer[this.whoAmI].broadcast = true;
            NetMessage.SyncConnectedPlayer(this.whoAmI);
            bool flag7 = NetMessage.DoesPlayerSlotCountAsAHost(this.whoAmI);
            Main.countsAsHostForGameplay[this.whoAmI] = flag7;
            if (NetMessage.DoesPlayerSlotCountAsAHost(this.whoAmI))
              NetMessage.TrySendData(139, this.whoAmI, number: this.whoAmI, number2: (float) flag7.ToInt());
            NetMessage.TrySendData(12, ignoreClient: this.whoAmI, number: this.whoAmI, number2: (float) (byte) playerSpawnContext);
            NetMessage.TrySendData(129, this.whoAmI);
            NetMessage.greetPlayer(this.whoAmI);
            if (!Main.player[index10].unlockedBiomeTorches)
              break;
            NPC npc = new NPC();
            npc.SetDefaults(664);
            Main.BestiaryTracker.Kills.RegisterKill(npc);
            break;
          }
          NetMessage.TrySendData(12, ignoreClient: this.whoAmI, number: this.whoAmI, number2: (float) (byte) playerSpawnContext);
          break;
        case 13:
          int number7 = (int) this.reader.ReadByte();
          if (number7 == Main.myPlayer && !Main.ServerSideCharacter)
            break;
          if (Main.netMode == 2)
            number7 = this.whoAmI;
          Player player5 = Main.player[number7];
          BitsByte bitsByte17 = (BitsByte) this.reader.ReadByte();
          BitsByte bitsByte18 = (BitsByte) this.reader.ReadByte();
          BitsByte bitsByte19 = (BitsByte) this.reader.ReadByte();
          BitsByte bitsByte20 = (BitsByte) this.reader.ReadByte();
          player5.controlUp = bitsByte17[0];
          player5.controlDown = bitsByte17[1];
          player5.controlLeft = bitsByte17[2];
          player5.controlRight = bitsByte17[3];
          player5.controlJump = bitsByte17[4];
          player5.controlUseItem = bitsByte17[5];
          player5.direction = bitsByte17[6] ? 1 : -1;
          if (bitsByte18[0])
          {
            player5.pulley = true;
            player5.pulleyDir = bitsByte18[1] ? (byte) 2 : (byte) 1;
          }
          else
            player5.pulley = false;
          player5.vortexStealthActive = bitsByte18[3];
          player5.gravDir = bitsByte18[4] ? 1f : -1f;
          player5.TryTogglingShield(bitsByte18[5]);
          player5.ghost = bitsByte18[6];
          player5.selectedItemState.Select((int) this.reader.ReadByte());
          Vector2 start1 = this.reader.ReadVector2();
          Vector2 vector2_1 = Vector2.Zero;
          if (bitsByte18[2])
            vector2_1 = this.reader.ReadVector2();
          if (player5.unacknowledgedTeleports > 0)
          {
            start1 = player5.position;
            vector2_1 = player5.velocity;
          }
          if (Main.netMode == 1 && player5.position != Vector2.Zero)
          {
            player5.netOffset += player5.position - start1;
            if ((double) player5.netOffset.Length() > (double) Main.multiplayerNPCSmoothingRange)
              player5.netOffset = Vector2.Zero;
            if (player5.netOffset != Vector2.Zero && DebugOptions.ShowNetOffsetDust && (double) Vector2.Distance(start1, player5.position) > 4.0)
              Dust.QuickDustLine(start1, player5.position, 20f, Color.Red);
          }
          player5.position = start1;
          player5.velocity = vector2_1;
          Vector2 position = player5.position;
          if (bitsByte18[7])
            player5.mount.SetMount((int) this.reader.ReadUInt16(), player5);
          else
            player5.mount.Dismount(player5);
          if (bitsByte19[6])
          {
            player5.PotionOfReturnOriginalUsePosition = new Vector2?(this.reader.ReadVector2());
            player5.PotionOfReturnHomePosition = new Vector2?(this.reader.ReadVector2());
          }
          else
          {
            player5.PotionOfReturnOriginalUsePosition = new Vector2?();
            player5.PotionOfReturnHomePosition = new Vector2?();
          }
          player5.tryKeepingHoveringUp = bitsByte19[0];
          player5.IsVoidVaultEnabled = bitsByte19[1];
          player5.sitting.isSitting = bitsByte19[2];
          player5.downedDD2EventAnyDifficulty = bitsByte19[3];
          player5.petting.isPetting = bitsByte19[4];
          player5.petting.isPetSmall = bitsByte19[5];
          player5.tryKeepingHoveringDown = bitsByte19[7];
          player5.sleeping.SetIsSleepingAndAdjustPlayerRotation(player5, bitsByte20[0]);
          player5.autoReuseAllWeapons = bitsByte20[1];
          player5.controlDownHold = bitsByte20[2];
          player5.isOperatingAnotherEntity = bitsByte20[3];
          player5.controlUseTile = bitsByte20[4];
          player5.netCameraTarget = bitsByte20[5] ? new Vector2?(this.reader.ReadVector2()) : new Vector2?();
          player5.lastItemUseAttemptSuccess = bitsByte20[6];
          Utils.Swap<Vector2>(ref position, ref player5.position);
          if (Main.netMode == 2 && Netplay.Clients[this.whoAmI].State == 10)
            NetMessage.TrySendData(13, ignoreClient: this.whoAmI, number: number7);
          Utils.Swap<Vector2>(ref position, ref player5.position);
          break;
        case 14:
          int playerIndex = (int) this.reader.ReadByte();
          int num18 = (int) this.reader.ReadByte();
          if (Main.netMode != 1)
            break;
          int num19 = Main.player[playerIndex].active ? 1 : 0;
          if (num18 == 1)
          {
            if (!Main.player[playerIndex].active)
              Main.player[playerIndex] = new Player();
            Main.player[playerIndex].active = true;
          }
          else
            Main.player[playerIndex].active = false;
          int num20 = Main.player[playerIndex].active ? 1 : 0;
          if (num19 == num20)
            break;
          if (Main.player[playerIndex].active)
          {
            Player.Hooks.PlayerConnect(playerIndex);
            break;
          }
          Player.Hooks.PlayerDisconnect(playerIndex);
          break;
        case 15:
          break;
        case 16 /*0x10*/:
          int number8 = (int) this.reader.ReadByte();
          if (number8 == Main.myPlayer && !Main.ServerSideCharacter)
            break;
          if (Main.netMode == 2)
            number8 = this.whoAmI;
          Player player6 = Main.player[number8];
          player6.statLife = (int) this.reader.ReadInt16();
          player6.statLifeMax = (int) this.reader.ReadInt16();
          if (player6.statLifeMax < 20)
            player6.statLifeMax = 20;
          player6.dead = player6.statLife <= 0;
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(16 /*0x10*/, ignoreClient: this.whoAmI, number: number8);
          break;
        case 17:
          byte number9 = this.reader.ReadByte();
          int index11 = (int) this.reader.ReadInt16();
          int index12 = (int) this.reader.ReadInt16();
          short index13 = this.reader.ReadInt16();
          int num21 = (int) this.reader.ReadByte();
          bool fail = index13 == (short) 1;
          if (!WorldGen.InWorld(index11, index12, 3))
            break;
          if (Main.tile[index11, index12] == null)
            Main.tile[index11, index12] = new Tile();
          if (Main.netMode == 2)
          {
            if (!fail)
            {
              if (number9 == (byte) 0 || number9 == (byte) 2 || number9 == (byte) 4)
                ++Netplay.Clients[this.whoAmI].SpamDeleteBlock;
              if (number9 == (byte) 1 || number9 == (byte) 3)
                ++Netplay.Clients[this.whoAmI].SpamAddBlock;
            }
            if (!Netplay.Clients[this.whoAmI].TileSections[Netplay.GetSectionX(index11), Netplay.GetSectionY(index12)])
              fail = true;
          }
          MapUpdateQueue.Add(index11, index12);
          if (number9 == (byte) 0)
          {
            WorldGen.KillTile(index11, index12, fail);
            if (Main.netMode == 1 && !fail)
              HitTile.ClearAllTilesAtThisLocation(index11, index12);
          }
          bool flag8 = false;
          if (number9 == (byte) 1)
          {
            bool forced = true;
            if (WorldGen.CheckTileBreakability2_ShouldTileSurvive(index11, index12))
            {
              flag8 = true;
              forced = false;
            }
            WorldGen.PlaceTile(index11, index12, (int) index13, forced: forced, style: num21);
          }
          if (number9 == (byte) 2)
            WorldGen.KillWall(index11, index12, fail);
          if (number9 == (byte) 3)
            WorldGen.PlaceWall(index11, index12, (int) index13);
          if (number9 == (byte) 4)
            WorldGen.KillTile(index11, index12, fail, noItem: true);
          if (number9 == (byte) 5)
            WorldGen.PlaceWire(index11, index12);
          if (number9 == (byte) 6)
            WorldGen.KillWire(index11, index12);
          if (number9 == (byte) 7)
            WorldGen.PoundTile(index11, index12);
          if (number9 == (byte) 8)
            WorldGen.PlaceActuator(index11, index12);
          if (number9 == (byte) 9)
            WorldGen.KillActuator(index11, index12);
          if (number9 == (byte) 10)
            WorldGen.PlaceWire2(index11, index12);
          if (number9 == (byte) 11)
            WorldGen.KillWire2(index11, index12);
          if (number9 == (byte) 12)
            WorldGen.PlaceWire3(index11, index12);
          if (number9 == (byte) 13)
            WorldGen.KillWire3(index11, index12);
          if (number9 == (byte) 14)
            WorldGen.SlopeTile(index11, index12, (int) index13);
          if (number9 == (byte) 15)
            Minecart.FrameTrack(index11, index12, true);
          if (number9 == (byte) 16 /*0x10*/)
            WorldGen.PlaceWire4(index11, index12);
          if (number9 == (byte) 17)
            WorldGen.KillWire4(index11, index12);
          if (number9 == (byte) 18)
          {
            Wiring.SetCurrentUser(this.whoAmI);
            Wiring.PokeLogicGate(index11, index12);
            Wiring.SetCurrentUser();
            break;
          }
          if (number9 == (byte) 19)
          {
            Wiring.SetCurrentUser(this.whoAmI);
            Wiring.Actuate(index11, index12);
            Wiring.SetCurrentUser();
            break;
          }
          if (number9 == (byte) 20)
          {
            if (!WorldGen.InWorld(index11, index12, 2))
              break;
            int type = (int) Main.tile[index11, index12].type;
            WorldGen.KillTile(index11, index12, fail);
            short number4 = !Main.tile[index11, index12].active() || (int) Main.tile[index11, index12].type != type ? (short) 0 : (short) 1;
            if (Main.netMode != 2)
              break;
            NetMessage.TrySendData(17, number: (int) number9, number2: (float) index11, number3: (float) index12, number4: (float) number4, number5: num21);
            break;
          }
          if (number9 == (byte) 21)
            WorldGen.ReplaceTile(index11, index12, (int) (ushort) index13, num21);
          if (number9 == (byte) 22)
            WorldGen.ReplaceWall(index11, index12, (ushort) index13);
          if (number9 == (byte) 23 && WorldGen.CanPoundTile(index11, index12))
          {
            Main.tile[index11, index12].slope((byte) index13);
            WorldGen.PoundTile(index11, index12);
          }
          if (Main.netMode != 2)
            break;
          if (flag8)
          {
            NetMessage.SendTileSquare(-1, index11, index12, 5);
            break;
          }
          if ((number9 == (byte) 1 || number9 == (byte) 21) && TileID.Sets.Falling[(int) index13] && !Main.tile[index11, index12].active())
            break;
          NetMessage.TrySendData(17, ignoreClient: this.whoAmI, number: (int) number9, number2: (float) index11, number3: (float) index12, number4: (float) index13, number5: num21);
          break;
        case 18:
          if (Main.netMode != 1)
            break;
          Main.dayTime = this.reader.ReadByte() == (byte) 1;
          Main.time = (double) this.reader.ReadInt32();
          Main.sunModY = this.reader.ReadInt16();
          Main.moonModY = this.reader.ReadInt16();
          break;
        case 19:
          byte number10 = this.reader.ReadByte();
          int num22 = (int) this.reader.ReadInt16();
          int num23 = (int) this.reader.ReadInt16();
          if (!WorldGen.InWorld(num22, num23, 3))
            break;
          int direction1 = this.reader.ReadByte() == (byte) 0 ? -1 : 1;
          switch (number10)
          {
            case 0:
              WorldGen.OpenDoor(num22, num23, direction1);
              break;
            case 1:
              WorldGen.CloseDoor(num22, num23, true);
              break;
            case 2:
              WorldGen.ShiftTrapdoor(num22, num23, direction1 == 1, 1);
              break;
            case 3:
              WorldGen.ShiftTrapdoor(num22, num23, direction1 == 1, 0);
              break;
            case 4:
              WorldGen.ShiftTallGate(num22, num23, false, true);
              break;
            case 5:
              WorldGen.ShiftTallGate(num22, num23, true, true);
              break;
          }
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(19, ignoreClient: this.whoAmI, number: (int) number10, number2: (float) num22, number3: (float) num23, number4: direction1 == 1 ? 1f : 0.0f);
          break;
        case 20:
          int num24 = (int) this.reader.ReadInt16();
          int num25 = (int) this.reader.ReadInt16();
          ushort num26 = (ushort) this.reader.ReadByte();
          ushort num27 = (ushort) this.reader.ReadByte();
          byte number5_1 = this.reader.ReadByte();
          if (!WorldGen.InWorld(num24, num25, 3))
            break;
          TileChangeType type1 = TileChangeType.None;
          if (Enum.IsDefined(typeof (TileChangeType), (object) number5_1))
            type1 = (TileChangeType) number5_1;
          if (MessageBuffer.OnTileChangeReceived != null)
            MessageBuffer.OnTileChangeReceived(num24, num25, (int) Math.Max(num26, num27), type1);
          BitsByte bitsByte21 = (BitsByte) (byte) 0;
          BitsByte bitsByte22 = (BitsByte) (byte) 0;
          BitsByte bitsByte23 = (BitsByte) (byte) 0;
          for (int index14 = num24; index14 < num24 + (int) num26; ++index14)
          {
            for (int index15 = num25; index15 < num25 + (int) num27; ++index15)
            {
              if (Main.tile[index14, index15] == null)
                Main.tile[index14, index15] = new Tile();
              Tile tile = Main.tile[index14, index15];
              bool flag9 = tile.active();
              BitsByte bitsByte24 = (BitsByte) this.reader.ReadByte();
              BitsByte bitsByte25 = (BitsByte) this.reader.ReadByte();
              BitsByte bitsByte26 = (BitsByte) this.reader.ReadByte();
              tile.active(bitsByte24[0]);
              tile.wall = bitsByte24[2] ? (ushort) 1 : (ushort) 0;
              bool flag10 = bitsByte24[3];
              if (Main.netMode != 2)
                tile.liquid = flag10 ? (byte) 1 : (byte) 0;
              tile.wire(bitsByte24[4]);
              tile.halfBrick(bitsByte24[5]);
              tile.actuator(bitsByte24[6]);
              tile.inActive(bitsByte24[7]);
              tile.wire2(bitsByte25[0]);
              tile.wire3(bitsByte25[1]);
              if (bitsByte25[2])
                tile.color(this.reader.ReadByte());
              if (bitsByte25[3])
                tile.wallColor(this.reader.ReadByte());
              if (tile.active())
              {
                int type2 = (int) tile.type;
                tile.type = this.reader.ReadUInt16();
                if (Main.tileFrameImportant[(int) tile.type])
                {
                  tile.frameX = this.reader.ReadInt16();
                  tile.frameY = this.reader.ReadInt16();
                }
                else if (!flag9 || (int) tile.type != type2)
                {
                  tile.frameX = (short) -1;
                  tile.frameY = (short) -1;
                }
                byte slope = 0;
                if (bitsByte25[4])
                  ++slope;
                if (bitsByte25[5])
                  slope += (byte) 2;
                if (bitsByte25[6])
                  slope += (byte) 4;
                tile.slope(slope);
              }
              tile.wire4(bitsByte25[7]);
              tile.fullbrightBlock(bitsByte26[0]);
              tile.fullbrightWall(bitsByte26[1]);
              tile.invisibleBlock(bitsByte26[2]);
              tile.invisibleWall(bitsByte26[3]);
              if (tile.wall > (ushort) 0)
                tile.wall = this.reader.ReadUInt16();
              if (flag10)
              {
                tile.liquid = this.reader.ReadByte();
                tile.liquidType((int) this.reader.ReadByte());
              }
            }
          }
          WorldGen.RangeFrame(num24, num25, num24 + (int) num26, num25 + (int) num27);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData((int) num2, ignoreClient: this.whoAmI, number: num24, number2: (float) num25, number3: (float) num26, number4: (float) num27, number5: (int) number5_1);
          break;
        case 21:
        case 90:
        case 145:
        case 148:
          int number11 = (int) this.reader.ReadInt16();
          Vector2 vector2_2 = this.reader.ReadVector2();
          Vector2 vector2_3 = this.reader.ReadVector2();
          int Stack = (int) this.reader.ReadInt16();
          int prefix1 = (int) this.reader.ReadByte();
          BitsByte number2_1 = (BitsByte) this.reader.ReadByte();
          bool flag11 = number2_1[0];
          bool flag12 = number2_1[1];
          int index16 = (int) this.reader.ReadInt16();
          bool flag13 = false;
          float num28 = 0.0f;
          int num29 = 0;
          if (num2 == (byte) 145)
          {
            flag13 = this.reader.ReadBoolean();
            num28 = this.reader.ReadSingle();
          }
          if (num2 == (byte) 148)
            num29 = (int) this.reader.ReadByte();
          WorldItem worldItem1 = Main.item[number11];
          if (Main.netMode == 1)
          {
            ItemSyncPersistentStats syncPersistentStats = new ItemSyncPersistentStats();
            syncPersistentStats.CopyFrom(worldItem1);
            bool flag14 = (worldItem1.newAndShiny || worldItem1.type != index16) && ItemSlot.Options.HighlightNewItems && (index16 < 0 || index16 >= (int) ItemID.Count || !ItemID.Sets.NeverAppearsAsNewInInventory[index16]);
            worldItem1.SetDefaults(index16);
            worldItem1.newAndShiny = flag14;
            worldItem1.Prefix(prefix1);
            worldItem1.stack = Stack;
            worldItem1.position = vector2_2;
            worldItem1.velocity = vector2_3;
            worldItem1.shimmered = flag13;
            worldItem1.shimmerTime = num28;
            if (num2 == (byte) 90)
            {
              worldItem1.instanced = true;
              worldItem1.playerIndexTheItemIsReservedFor = Main.myPlayer;
              worldItem1.keepTime = 600;
            }
            else if (flag12)
              worldItem1.keepTime = 100;
            worldItem1.timeLeftInWhichTheItemCannotBeTakenByEnemies = num29;
            worldItem1.wet = Collision.WetCollision(worldItem1.position, worldItem1.width, worldItem1.height);
            syncPersistentStats.PasteInto(worldItem1);
            break;
          }
          if (Main.timeItemSlotCannotBeReusedFor[number11] > 0)
            break;
          int num30 = number11 == 400 ? 1 : 0;
          if (num30 != 0)
          {
            Item obj = new Item();
            obj.SetDefaults(index16);
            number11 = Item.NewItem((IEntitySource) new EntitySource_Sync(), (int) vector2_2.X, (int) vector2_2.Y, obj.width, obj.height, obj.type, Stack, true);
            worldItem1 = Main.item[number11];
            number2_1[1] = flag12 = !flag11;
          }
          else
          {
            int num31 = worldItem1.timeSinceTheItemHasBeenReservedForSomeone;
            if (worldItem1.playerIndexTheItemIsReservedFor != this.whoAmI)
              num31 = 0;
            worldItem1.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
            worldItem1.SetDefaults(index16);
            worldItem1.playerIndexTheItemIsReservedFor = this.whoAmI;
            worldItem1.timeSinceTheItemHasBeenReservedForSomeone = num31;
          }
          worldItem1.Prefix(prefix1);
          worldItem1.stack = Stack;
          worldItem1.position = vector2_2;
          worldItem1.velocity = vector2_3;
          worldItem1.timeLeftInWhichTheItemCannotBeTakenByEnemies = num29;
          if (num2 == (byte) 145)
          {
            worldItem1.shimmered = flag13;
            worldItem1.shimmerTime = num28;
          }
          if (flag12)
          {
            worldItem1.ownIgnore = this.whoAmI;
            worldItem1.ownTime = 100;
          }
          if (num30 != 0)
          {
            NetMessage.TrySendData((int) num2, number: number11, number2: (float) (byte) number2_1);
            Main.item[number11].FindOwner();
            break;
          }
          NetMessage.TrySendData((int) num2, ignoreClient: this.whoAmI, number: number11);
          break;
        case 22:
          int index17 = (int) this.reader.ReadInt16();
          int num32 = (int) this.reader.ReadByte();
          Vector2 vector2_4 = this.reader.ReadVector2();
          WorldItem worldItem2 = Main.item[index17];
          if (Main.netMode == 2)
            break;
          worldItem2.playerIndexTheItemIsReservedFor = num32;
          worldItem2.position = vector2_4;
          if (num32 == Main.myPlayer)
          {
            worldItem2.keepTime = Math.Max(worldItem2.keepTime, 15);
            break;
          }
          worldItem2.keepTime = 0;
          break;
        case 23:
          if (Main.netMode != 1)
            break;
          int index18 = (int) this.reader.ReadInt16();
          Vector2 start2 = this.reader.ReadVector2();
          Vector2 vector2_5 = this.reader.ReadVector2();
          int num33 = (int) this.reader.ReadUInt16();
          if (num33 == (int) ushort.MaxValue)
            num33 = 0;
          BitsByte bitsByte27 = (BitsByte) this.reader.ReadByte();
          BitsByte bitsByte28 = (BitsByte) this.reader.ReadByte();
          float[] numArray1 = this.ReUseTemporaryNPCAI();
          for (int index19 = 0; index19 < NPC.maxAI; ++index19)
            numArray1[index19] = !bitsByte27[index19 + 2] ? 0.0f : this.reader.ReadSingle();
          int Type2 = (int) this.reader.ReadInt16();
          int? nullable = new int?(1);
          if (bitsByte28[0])
            nullable = new int?((int) this.reader.ReadByte());
          float num34 = 1f;
          if (bitsByte28[2])
            num34 = this.reader.ReadSingle();
          int num35 = 0;
          if (!bitsByte27[7])
          {
            switch (this.reader.ReadByte())
            {
              case 2:
                num35 = (int) this.reader.ReadInt16();
                break;
              case 4:
                num35 = this.reader.ReadInt32();
                break;
              default:
                num35 = (int) this.reader.ReadSByte();
                break;
            }
          }
          NPC npc1 = Main.npc[index18];
          bool flag15 = bitsByte28[3] || !npc1.active;
          int oldType = -1;
          if (flag15 || npc1.netID != Type2)
          {
            if (flag15)
              npc1.ResetForNewNPC();
            else
              oldType = npc1.type;
            npc1.active = true;
            npc1.SetDefaults(Type2);
          }
          if (!flag15 && (double) Vector2.DistanceSquared(npc1.position, start2) <= (double) (Main.multiplayerNPCSmoothingRange * Main.multiplayerNPCSmoothingRange))
          {
            npc1.netOffset += npc1.position - start2;
            if (npc1.netOffset != Vector2.Zero && DebugOptions.ShowNetOffsetDust && (double) Vector2.Distance(start2, npc1.position) > 4.0)
              Dust.QuickDustLine(start2, npc1.position, 20f, Color.Red);
          }
          npc1.position = start2;
          npc1.velocity = vector2_5;
          npc1.target = num33;
          npc1.direction = bitsByte27[0] ? 1 : -1;
          npc1.directionY = bitsByte27[1] ? 1 : -1;
          npc1.spriteDirection = bitsByte27[6] ? 1 : -1;
          if (bitsByte27[7])
            num35 = npc1.life = npc1.lifeMax;
          else
            npc1.life = num35;
          if (num35 <= 0)
            npc1.active = false;
          npc1.SpawnedFromStatue = bitsByte28[1];
          if (npc1.SpawnedFromStatue)
            npc1.value = 0.0f;
          if (bitsByte28[4])
            npc1.shimmerTransparency = 1f;
          for (int index20 = 0; index20 < NPC.maxAI; ++index20)
            npc1.ai[index20] = numArray1[index20];
          if (oldType > -1)
            npc1.TransformVisuals(oldType, npc1.type);
          if (Type2 == 262)
            NPC.plantBoss = index18;
          if (Type2 == 245)
            NPC.golemBoss = index18;
          if (Type2 == 668)
            NPC.deerclopsBoss = index18;
          if (npc1.type < 0 || npc1.type >= (int) NPCID.Count || !Main.npcCatchable[npc1.type])
            break;
          npc1.releaseOwner = (short) this.reader.ReadByte();
          break;
        case 24:
          int number12 = (int) this.reader.ReadInt16();
          int number2_2 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number2_2 = this.whoAmI;
          Player player7 = Main.player[number2_2];
          Main.npc[number12].StrikeNPC(player7.inventory[player7.selectedItem].damage, player7.inventory[player7.selectedItem].knockBack, player7.direction);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(24, ignoreClient: this.whoAmI, number: number12, number2: (float) number2_2);
          NetMessage.TrySendData(23, number: number12);
          break;
        case 25:
          break;
        case 26:
          break;
        case 27:
          int num36 = (int) this.reader.ReadInt16();
          Vector2 vector2_6 = this.reader.ReadVector2();
          Vector2 vector2_7 = this.reader.ReadVector2();
          int index21 = (int) this.reader.ReadByte();
          int Type3 = (int) this.reader.ReadInt16();
          BitsByte bitsByte29 = (BitsByte) this.reader.ReadByte();
          BitsByte bitsByte30 = (BitsByte) (bitsByte29[2] ? this.reader.ReadByte() : (byte) 0);
          float[] numArray2 = this.ReUseTemporaryProjectileAI();
          numArray2[0] = bitsByte29[0] ? this.reader.ReadSingle() : 0.0f;
          numArray2[1] = bitsByte29[1] ? this.reader.ReadSingle() : 0.0f;
          int num37 = bitsByte29[3] ? (int) this.reader.ReadUInt16() : 0;
          int num38 = bitsByte29[4] ? (int) this.reader.ReadInt16() : 0;
          float num39 = bitsByte29[5] ? this.reader.ReadSingle() : 0.0f;
          int num40 = bitsByte29[6] ? (int) this.reader.ReadInt16() : 0;
          int index22 = bitsByte29[7] ? (int) this.reader.ReadInt16() : -1;
          if (index22 >= 1000)
            index22 = -1;
          numArray2[2] = bitsByte30[0] ? this.reader.ReadSingle() : 0.0f;
          if (Main.netMode == 2)
          {
            if (Type3 == 949)
            {
              index21 = (int) byte.MaxValue;
            }
            else
            {
              index21 = this.whoAmI;
              if (Main.projHostile[Type3])
                break;
            }
          }
          int number13 = 1000;
          for (int index23 = 0; index23 < 1000; ++index23)
          {
            if (Main.projectile[index23].owner == index21 && Main.projectile[index23].identity == num36 && Main.projectile[index23].active)
            {
              number13 = index23;
              break;
            }
          }
          if (number13 == 1000)
          {
            for (int index24 = 0; index24 < 1000; ++index24)
            {
              if (!Main.projectile[index24].active)
              {
                number13 = index24;
                break;
              }
            }
          }
          if (number13 == 1000)
            number13 = Projectile.FindOldestProjectile();
          Projectile projectile = Main.projectile[number13];
          if (!projectile.active || projectile.type != Type3)
          {
            projectile.SetDefaults(Type3);
            if (Main.netMode == 2)
              ++Netplay.Clients[this.whoAmI].SpamProjectile;
          }
          projectile.identity = num36;
          projectile.position = vector2_6;
          projectile.velocity = vector2_7;
          projectile.type = Type3;
          projectile.damage = num38;
          projectile.bannerIdToRespondTo = num37;
          projectile.originalDamage = num40;
          projectile.knockBack = num39;
          projectile.owner = index21;
          for (int index25 = 0; index25 < Projectile.maxAI; ++index25)
            projectile.ai[index25] = numArray2[index25];
          if (index22 >= 0)
          {
            projectile.projUUID = index22;
            Main.projectileIdentity[index21, index22] = number13;
          }
          projectile.ProjectileFixDesperation();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(27, ignoreClient: this.whoAmI, number: number13);
          break;
        case 28:
          int number14 = (int) this.reader.ReadInt16();
          int num41 = (int) this.reader.ReadInt16();
          float num42 = this.reader.ReadSingle();
          int num43 = (int) this.reader.ReadByte() - 1;
          byte number5_2 = this.reader.ReadByte();
          if (Main.netMode == 2)
          {
            if (num41 < 0)
              num41 = 0;
            Main.npc[number14].PlayerInteraction(this.whoAmI);
          }
          if (num41 >= 0)
          {
            Main.npc[number14].StrikeNPC(num41, num42, num43, number5_2 == (byte) 1, fromNet: true, owner: Main.netMode == 2 ? this.whoAmI : (int) byte.MaxValue);
          }
          else
          {
            Main.npc[number14].life = 0;
            Main.npc[number14].HitEffect();
            Main.npc[number14].active = false;
          }
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(28, ignoreClient: this.whoAmI, number: number14, number2: (float) num41, number3: num42, number4: (float) num43, number5: (int) number5_2);
          if (Main.npc[number14].life <= 0)
            NetMessage.TrySendData(23, number: number14);
          if (Main.npc[number14].realLife < 0 || Main.npc[Main.npc[number14].realLife].life > 0)
            break;
          NetMessage.TrySendData(23, number: Main.npc[number14].realLife);
          break;
        case 29:
          int number15 = (int) this.reader.ReadInt16();
          int number2_3 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number2_3 = this.whoAmI;
          for (int index26 = 0; index26 < 1000; ++index26)
          {
            if (Main.projectile[index26].owner == number2_3 && Main.projectile[index26].identity == number15 && Main.projectile[index26].active)
            {
              Main.projectile[index26].Kill();
              break;
            }
          }
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(29, ignoreClient: this.whoAmI, number: number15, number2: (float) number2_3);
          break;
        case 30:
          int number16 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number16 = this.whoAmI;
          bool flag16 = this.reader.ReadBoolean();
          Main.player[number16].hostile = flag16;
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(30, ignoreClient: this.whoAmI, number: number16);
          LocalizedText localizedText1 = flag16 ? Lang.mp[11] : Lang.mp[12];
          Color color1 = Main.teamColor[Main.player[number16].team];
          ChatHelper.BroadcastChatMessage(NetworkText.FromKey(localizedText1.Key, (object) Main.player[number16].name), color1);
          break;
        case 31 /*0x1F*/:
          if (Main.netMode != 2)
            break;
          int num44 = (int) this.reader.ReadInt16();
          int num45 = (int) this.reader.ReadInt16();
          int chest1 = Chest.FindChest(num44, num45);
          if (chest1 <= -1 || Chest.UsingChest(chest1) != -1)
            break;
          NetMessage.SendChestContentsTo(chest1, this.whoAmI);
          NetMessage.TrySendData(33, this.whoAmI, number: chest1);
          Main.player[this.whoAmI].chest = chest1;
          if (Main.myPlayer == this.whoAmI)
            Main.PipsUseGrid = false;
          NetMessage.TrySendData(80 /*0x50*/, ignoreClient: this.whoAmI, number: this.whoAmI, number2: (float) chest1);
          if (Main.netMode != 2 || !WorldGen.IsChestRigged(num44, num45))
            break;
          Wiring.SetCurrentUser(this.whoAmI);
          Wiring.HitSwitch(num44, num45);
          Wiring.SetCurrentUser();
          NetMessage.TrySendData(59, ignoreClient: this.whoAmI, number: num44, number2: (float) num45);
          break;
        case 32 /*0x20*/:
          int number17 = (int) this.reader.ReadInt16();
          int number2_4 = (int) this.reader.ReadByte();
          int num46 = (int) this.reader.ReadInt16();
          int prefixWeWant2 = (int) this.reader.ReadByte();
          int Type4 = (int) this.reader.ReadInt16();
          if (number17 < 0 || number17 >= 8000 || Main.chest[number17] == null)
            break;
          if (Main.chest[number17].item[number2_4] == null)
            Main.chest[number17].item[number2_4] = new Item();
          Main.chest[number17].item[number2_4].SetDefaults(Type4);
          Main.chest[number17].item[number2_4].Prefix(prefixWeWant2);
          Main.chest[number17].item[number2_4].stack = num46;
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(32 /*0x20*/, ignoreClient: this.whoAmI, number: number17, number2: (float) number2_4);
          break;
        case 33:
          int number2_5 = (int) this.reader.ReadInt16();
          int index27 = (int) this.reader.ReadInt16();
          int index28 = (int) this.reader.ReadInt16();
          int num47 = (int) this.reader.ReadByte();
          string str1 = string.Empty;
          if (num47 != 0)
          {
            if (num47 <= 20)
              str1 = this.reader.ReadString();
            else if (num47 != (int) byte.MaxValue)
              num47 = 0;
          }
          if (Main.netMode == 1)
          {
            Player player8 = Main.player[Main.myPlayer];
            if (player8.chest == -1)
            {
              Main.playerInventory = true;
              SoundEngine.PlaySound(10);
              if (number2_5 != -1)
                ItemSlot.SetGlowForChest(Main.chest[number2_5]);
            }
            else if (player8.chest != number2_5 && number2_5 != -1)
            {
              Main.playerInventory = true;
              SoundEngine.PlaySound(12);
              Main.PipsUseGrid = false;
              ItemSlot.SetGlowForChest(Main.chest[number2_5]);
            }
            else if (player8.chest != -1 && number2_5 == -1)
            {
              SoundEngine.PlaySound(11);
              Main.PipsUseGrid = false;
            }
            player8.chest = number2_5;
            player8.chestX = index27;
            player8.chestY = index28;
            if (Main.tile[index27, index28].frameX < (short) 36 || Main.tile[index27, index28].frameX >= (short) 72)
              break;
            AchievementsHelper.HandleSpecialEvent(Main.player[Main.myPlayer], 16 /*0x10*/);
            break;
          }
          if (num47 != 0)
          {
            int chest2 = Main.player[this.whoAmI].chest;
            Chest chest3 = Main.chest[chest2];
            chest3.name = str1;
            NetMessage.TrySendData(69, ignoreClient: this.whoAmI, number: chest2, number2: (float) chest3.x, number3: (float) chest3.y);
          }
          Main.player[this.whoAmI].chest = number2_5;
          NetMessage.TrySendData(80 /*0x50*/, ignoreClient: this.whoAmI, number: this.whoAmI, number2: (float) number2_5);
          break;
        case 34:
          byte number18 = this.reader.ReadByte();
          int index29 = (int) this.reader.ReadInt16();
          int index30 = (int) this.reader.ReadInt16();
          int num48 = (int) this.reader.ReadInt16();
          int id1 = (int) this.reader.ReadInt16();
          if (Main.netMode == 2)
            id1 = 0;
          if (Main.netMode == 2)
          {
            if (number18 == (byte) 0)
            {
              int number5_3 = WorldGen.PlaceChest(index29, index30, style: num48);
              if (number5_3 == -1)
              {
                NetMessage.TrySendData(34, this.whoAmI, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_3);
                int itemDropChests = WorldGen.GetItemDrop_Chests(num48, false);
                if (itemDropChests <= 0)
                  break;
                Item.NewItem((IEntitySource) new EntitySource_TileBreak(index29, index30), index29 * 16 /*0x10*/, index30 * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, itemDropChests, noBroadcast: true);
                break;
              }
              NetMessage.TrySendData(34, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_3);
              break;
            }
            if (number18 == (byte) 1 && Main.tile[index29, index30].type == (ushort) 21)
            {
              Tile tile = Main.tile[index29, index30];
              if ((int) tile.frameX % 36 != 0)
                --index29;
              if ((int) tile.frameY % 36 != 0)
                --index30;
              int chest4 = Chest.FindChest(index29, index30);
              WorldGen.KillTile(index29, index30);
              if (tile.active())
                break;
              NetMessage.TrySendData(34, number: (int) number18, number2: (float) index29, number3: (float) index30, number5: chest4);
              break;
            }
            if (number18 == (byte) 2)
            {
              int number5_4 = WorldGen.PlaceChest(index29, index30, (ushort) 88, style: num48);
              if (number5_4 == -1)
              {
                NetMessage.TrySendData(34, this.whoAmI, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_4);
                Item.NewItem((IEntitySource) new EntitySource_TileBreak(index29, index30), index29 * 16 /*0x10*/, index30 * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, WorldGen.GetItemDrop_Dressers(num48), noBroadcast: true);
                break;
              }
              NetMessage.TrySendData(34, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_4);
              break;
            }
            if (number18 == (byte) 3 && Main.tile[index29, index30].type == (ushort) 88)
            {
              Tile tile = Main.tile[index29, index30];
              int num49 = index29 - (int) tile.frameX % 54 / 18;
              if ((int) tile.frameY % 36 != 0)
                --index30;
              int chest5 = Chest.FindChest(num49, index30);
              WorldGen.KillTile(num49, index30);
              if (tile.active())
                break;
              NetMessage.TrySendData(34, number: (int) number18, number2: (float) num49, number3: (float) index30, number5: chest5);
              break;
            }
            if (number18 == (byte) 4)
            {
              int number5_5 = WorldGen.PlaceChest(index29, index30, (ushort) 467, style: num48);
              if (number5_5 == -1)
              {
                NetMessage.TrySendData(34, this.whoAmI, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_5);
                int itemDropChests = WorldGen.GetItemDrop_Chests(num48, true);
                if (itemDropChests <= 0)
                  break;
                Item.NewItem((IEntitySource) new EntitySource_TileBreak(index29, index30), index29 * 16 /*0x10*/, index30 * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, itemDropChests, noBroadcast: true);
                break;
              }
              NetMessage.TrySendData(34, number: (int) number18, number2: (float) index29, number3: (float) index30, number4: (float) num48, number5: number5_5);
              break;
            }
            if (number18 != (byte) 5 || Main.tile[index29, index30].type != (ushort) 467)
              break;
            Tile tile1 = Main.tile[index29, index30];
            if ((int) tile1.frameX % 36 != 0)
              --index29;
            if ((int) tile1.frameY % 36 != 0)
              --index30;
            int chest6 = Chest.FindChest(index29, index30);
            WorldGen.KillTile(index29, index30);
            if (tile1.active())
              break;
            NetMessage.TrySendData(34, number: (int) number18, number2: (float) index29, number3: (float) index30, number5: chest6);
            break;
          }
          switch (number18)
          {
            case 0:
              if (id1 == -1)
              {
                WorldGen.KillTile(index29, index30);
                return;
              }
              SoundEngine.PlaySound(0, index29 * 16 /*0x10*/, index30 * 16 /*0x10*/);
              WorldGen.PlaceChestDirect(index29, index30, (ushort) 21, num48, id1);
              return;
            case 2:
              if (id1 == -1)
              {
                WorldGen.KillTile(index29, index30);
                return;
              }
              SoundEngine.PlaySound(0, index29 * 16 /*0x10*/, index30 * 16 /*0x10*/);
              WorldGen.PlaceDresserDirect(index29, index30, (ushort) 88, num48, id1);
              return;
            case 4:
              if (id1 == -1)
              {
                WorldGen.KillTile(index29, index30);
                return;
              }
              SoundEngine.PlaySound(0, index29 * 16 /*0x10*/, index30 * 16 /*0x10*/);
              WorldGen.PlaceChestDirect(index29, index30, (ushort) 467, num48, id1);
              return;
            default:
              Chest.DestroyChestDirect(index29, index30, id1);
              WorldGen.KillTile(index29, index30);
              return;
          }
        case 35:
          int number19 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number19 = this.whoAmI;
          int num50 = (int) this.reader.ReadInt16();
          if (number19 != Main.myPlayer || Main.ServerSideCharacter)
            Main.player[number19].HealEffect(num50);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(35, ignoreClient: this.whoAmI, number: number19, number2: (float) num50);
          break;
        case 36:
          int number20 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number20 = this.whoAmI;
          Player player9 = Main.player[number20];
          bool flag17 = player9.zone5[0];
          player9.zone1 = (BitsByte) this.reader.ReadByte();
          player9.zone2 = (BitsByte) this.reader.ReadByte();
          player9.zone3 = (BitsByte) this.reader.ReadByte();
          player9.zone4 = (BitsByte) this.reader.ReadByte();
          player9.zone5 = (BitsByte) this.reader.ReadByte();
          player9.townNPCs = (int) this.reader.ReadByte();
          if (Main.netMode != 2)
            break;
          if (!flag17 && player9.zone5[0])
            NPC.Spawner.SpawnFaelings(player9);
          NetMessage.TrySendData(36, ignoreClient: this.whoAmI, number: number20);
          break;
        case 37:
          if (Main.netMode != 1)
            break;
          if (Main.autoPass)
          {
            NetMessage.TrySendData(38);
            Main.autoPass = false;
            break;
          }
          Netplay.ServerPassword = "";
          Main.menuMode = 31 /*0x1F*/;
          break;
        case 38:
          if (Main.netMode != 2)
            break;
          if (this.reader.ReadString() == Netplay.ServerPassword)
          {
            Netplay.Clients[this.whoAmI].State = 1;
            NetMessage.TrySendData(3, this.whoAmI);
            break;
          }
          NetMessage.TrySendData(2, this.whoAmI, text: Lang.mp[1].ToNetworkText());
          break;
        case 39:
          int number21 = (int) this.reader.ReadInt16();
          WorldItem worldItem3 = Main.item[number21];
          if (Main.netMode == 1)
          {
            if (worldItem3.playerIndexTheItemIsReservedFor != Main.myPlayer)
              break;
            worldItem3.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
            NetMessage.TrySendData(39, number: number21);
            break;
          }
          if (worldItem3.playerIndexTheItemIsReservedFor != this.whoAmI)
            break;
          worldItem3.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
          worldItem3.FindOwner();
          if (worldItem3.playerIndexTheItemIsReservedFor != (int) byte.MaxValue)
            break;
          NetMessage.TrySendData(22, ignoreClient: this.whoAmI, number: number21);
          break;
        case 40:
          int number22 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number22 = this.whoAmI;
          int npcIndex = (int) this.reader.ReadInt16();
          Main.player[number22].SetTalkNPC(npcIndex);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(40, ignoreClient: this.whoAmI, number: number22);
          break;
        case 41:
          int number23 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number23 = this.whoAmI;
          Player player10 = Main.player[number23];
          float num51 = this.reader.ReadSingle();
          int num52 = (int) this.reader.ReadInt16();
          player10.itemRotation = num51;
          player10.itemAnimation = num52;
          player10.channel = player10.inventory[player10.selectedItem].channel;
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(41, ignoreClient: this.whoAmI, number: number23);
          break;
        case 42:
          int index31 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index31 = this.whoAmI;
          else if (Main.myPlayer == index31 && !Main.ServerSideCharacter)
            break;
          int num53 = (int) this.reader.ReadInt16();
          int num54 = (int) this.reader.ReadInt16();
          Main.player[index31].statMana = num53;
          Main.player[index31].statManaMax = num54;
          break;
        case 43:
          int number24 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number24 = this.whoAmI;
          int num55 = (int) this.reader.ReadInt16();
          if (number24 != Main.myPlayer)
            Main.player[number24].ManaEffect(num55);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(43, ignoreClient: this.whoAmI, number: number24, number2: (float) num55);
          break;
        case 44:
          break;
        case 45:
        case 157:
          int index32 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index32 = this.whoAmI;
          int team2 = (int) this.reader.ReadByte();
          Player player11 = Main.player[index32];
          int team3 = player11.team;
          player11.team = team2;
          Color color2 = Main.teamColor[team2];
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(45, ignoreClient: this.whoAmI, number: index32);
          LocalizedText localizedText2 = Lang.mp[13 + team2];
          if (team2 == 5)
            localizedText2 = Lang.mp[22];
          for (int playerId = 0; playerId < (int) byte.MaxValue; ++playerId)
          {
            if (playerId == this.whoAmI || team3 > 0 && Main.player[playerId].team == team3 || team2 > 0 && Main.player[playerId].team == team2)
              ChatHelper.SendChatMessageToClient(NetworkText.FromKey(localizedText2.Key, (object) player11.name), color2, playerId);
          }
          if (num2 != (byte) 157 || !Main.teamBasedSpawnsSeed)
            break;
          Point spawnPoint1 = Point.Zero;
          if (!ExtraSpawnPointManager.TryGetExtraSpawnPointForTeam(team2, out spawnPoint1))
            break;
          RemoteClient.CheckSection(this.whoAmI, spawnPoint1.ToWorldCoordinates());
          NetMessage.SendData(158, index32, number: index32);
          break;
        case 46:
          if (Main.netMode != 2)
            break;
          int number25 = Sign.ReadSign((int) this.reader.ReadInt16(), (int) this.reader.ReadInt16());
          if (number25 < 0)
            break;
          NetMessage.TrySendData(47, this.whoAmI, number: number25, number2: (float) this.whoAmI);
          break;
        case 47:
          int index33 = (int) this.reader.ReadInt16();
          int num56 = (int) this.reader.ReadInt16();
          int num57 = (int) this.reader.ReadInt16();
          string text1 = this.reader.ReadString();
          int number2_6 = (int) this.reader.ReadByte();
          BitsByte bitsByte31 = (BitsByte) this.reader.ReadByte();
          if (index33 < 0 || index33 >= 32000)
            break;
          string str2 = (string) null;
          if (Main.sign[index33] != null)
            str2 = Main.sign[index33].text;
          Main.sign[index33] = new Sign();
          Main.sign[index33].x = num56;
          Main.sign[index33].y = num57;
          Sign.TextSign(index33, text1);
          if (Main.netMode == 2 && str2 != text1)
          {
            number2_6 = this.whoAmI;
            NetMessage.TrySendData(47, ignoreClient: this.whoAmI, number: index33, number2: (float) number2_6);
          }
          if (Main.netMode != 1 || number2_6 != Main.myPlayer || Main.sign[index33] == null || bitsByte31[0])
            break;
          Main.LocalPlayer.OpenSign(index33);
          break;
        case 48 /*0x30*/:
          int index34 = (int) this.reader.ReadInt16();
          int index35 = (int) this.reader.ReadInt16();
          byte num58 = this.reader.ReadByte();
          byte liquidType = this.reader.ReadByte();
          if (Main.netMode == 2 && Netplay.SpamCheck)
          {
            int whoAmI = this.whoAmI;
            int num59 = (int) ((double) Main.player[whoAmI].position.X + (double) (Main.player[whoAmI].width / 2));
            int num60 = (int) ((double) Main.player[whoAmI].position.Y + (double) (Main.player[whoAmI].height / 2));
            int num61 = 10;
            int num62 = num59 - num61;
            int num63 = num59 + num61;
            int num64 = num60 - num61;
            int num65 = num60 + num61;
            if (index34 < num62 || index34 > num63 || index35 < num64 || index35 > num65)
              ++Netplay.Clients[this.whoAmI].SpamWater;
          }
          if (Main.tile[index34, index35] == null)
            Main.tile[index34, index35] = new Tile();
          lock (Main.tile[index34, index35])
          {
            Main.tile[index34, index35].liquid = num58;
            Main.tile[index34, index35].liquidType((int) liquidType);
            if (Main.netMode != 2)
              break;
            WorldGen.SquareTileFrame(index34, index35);
            if (num58 != (byte) 0)
              break;
            NetMessage.SendData(48 /*0x30*/, ignoreClient: this.whoAmI, number: index34, number2: (float) index35);
            break;
          }
        case 49:
          if (Netplay.Connection.State != 6)
            break;
          Netplay.Connection.State = 10;
          Main.player[Main.myPlayer].Spawn(PlayerSpawnContext.SpawningIntoWorld);
          break;
        case 50:
          int number26 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number26 = this.whoAmI;
          else if (number26 == Main.myPlayer && !Main.ServerSideCharacter)
            break;
          Player player12 = Main.player[number26];
          int index36 = 0;
          int num66;
          while ((num66 = (int) this.reader.ReadUInt16()) > 0)
          {
            player12.buffType[index36] = num66;
            player12.buffTime[index36] = 60;
            ++index36;
          }
          Array.Clear((Array) player12.buffType, index36, player12.buffType.Length - index36);
          Array.Clear((Array) player12.buffTime, index36, player12.buffTime.Length - index36);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(50, ignoreClient: this.whoAmI, number: number26);
          break;
        case 51:
          byte index37 = this.reader.ReadByte();
          if (Main.netMode == 2)
            index37 = (byte) this.whoAmI;
          byte number2_7 = this.reader.ReadByte();
          switch (number2_7)
          {
            case 1:
              NPC.SpawnSkeletron((int) index37);
              return;
            case 2:
              if (Main.netMode == 2)
              {
                NetMessage.TrySendData(51, ignoreClient: this.whoAmI, number: (int) index37, number2: (float) number2_7);
                return;
              }
              SoundEngine.PlaySound(SoundID.Item1, (int) Main.player[(int) index37].position.X, (int) Main.player[(int) index37].position.Y);
              return;
            case 3:
              if (Main.netMode != 2)
                return;
              Main.Sundialing();
              return;
            case 4:
              Main.npc[(int) index37].BigMimicSpawnSmoke();
              return;
            case 5:
              if (Main.netMode != 2)
                return;
              NPC npc2 = new NPC();
              npc2.SetDefaults(664);
              Main.BestiaryTracker.Kills.RegisterKill(npc2);
              return;
            case 6:
              if (Main.netMode != 2)
                return;
              Main.Moondialing();
              return;
            default:
              return;
          }
        case 52:
          int number2_8 = (int) this.reader.ReadByte();
          int num67 = (int) this.reader.ReadInt16();
          int num68 = (int) this.reader.ReadInt16();
          if (number2_8 == 1)
          {
            Chest.Unlock(num67, num68);
            if (Main.netMode == 2)
            {
              NetMessage.TrySendData(52, ignoreClient: this.whoAmI, number2: (float) number2_8, number3: (float) num67, number4: (float) num68);
              NetMessage.SendTileSquare(-1, num67, num68, 2);
            }
          }
          if (number2_8 == 2)
          {
            WorldGen.UnlockDoor(num67, num68);
            if (Main.netMode == 2)
            {
              NetMessage.TrySendData(52, ignoreClient: this.whoAmI, number2: (float) number2_8, number3: (float) num67, number4: (float) num68);
              NetMessage.SendTileSquare(-1, num67, num68, 2);
            }
          }
          if (number2_8 != 3)
            break;
          Chest.Lock(num67, num68);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(52, ignoreClient: this.whoAmI, number2: (float) number2_8, number3: (float) num67, number4: (float) num68);
          NetMessage.SendTileSquare(-1, num67, num68, 2);
          break;
        case 53:
          int number27 = (int) this.reader.ReadInt16();
          int type3 = (int) this.reader.ReadUInt16();
          int time1 = (int) this.reader.ReadInt16();
          Main.npc[number27].AddBuff(type3, time1, true);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(54, number: number27);
          break;
        case 54:
          if (Main.netMode != 1)
            break;
          int index38 = (int) this.reader.ReadInt16();
          NPC npc3 = Main.npc[index38];
          int index39 = 0;
          int num69;
          while ((num69 = (int) this.reader.ReadUInt16()) > 0)
          {
            npc3.buffType[index39] = num69;
            npc3.buffTime[index39] = (int) this.reader.ReadUInt16();
            ++index39;
          }
          Array.Clear((Array) npc3.buffType, index39, npc3.buffType.Length - index39);
          Array.Clear((Array) npc3.buffTime, index39, npc3.buffTime.Length - index39);
          break;
        case 55:
          int index40 = (int) this.reader.ReadByte();
          int index41 = (int) this.reader.ReadUInt16();
          int num70 = this.reader.ReadInt32();
          if (Main.netMode == 2 && !Main.pvpBuff[index41] || Main.netMode == 1 && index40 != Main.myPlayer)
            break;
          if (Main.netMode == 2)
          {
            NetMessage.TrySendData(55, index40, number: index40, number2: (float) index41, number3: (float) num70);
            break;
          }
          Main.player[index40].AddBuff(index41, num70, true);
          break;
        case 56:
          int number28 = (int) this.reader.ReadInt16();
          if (number28 < 0 || number28 >= Main.maxNPCs)
            break;
          if (Main.netMode == 1)
          {
            string str3 = this.reader.ReadString();
            Main.npc[number28].GivenName = str3;
            int num71 = this.reader.ReadInt32();
            Main.npc[number28].townNpcVariationIndex = num71;
            break;
          }
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(56, this.whoAmI, number: number28);
          break;
        case 57:
          if (Main.netMode != 1)
            break;
          WorldGen.tGood = this.reader.ReadByte();
          WorldGen.tEvil = this.reader.ReadByte();
          WorldGen.tBlood = this.reader.ReadByte();
          break;
        case 58:
          int index42 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index42 = this.whoAmI;
          float num72 = this.reader.ReadSingle();
          if (Main.netMode == 2)
          {
            NetMessage.TrySendData(58, ignoreClient: this.whoAmI, number: this.whoAmI, number2: num72);
            break;
          }
          Player player13 = Main.player[index42];
          int type4 = player13.inventory[player13.selectedItem].type;
          switch (type4)
          {
            case 4057:
            case 4372:
            case 4715:
              player13.PlayGuitarChord(num72);
              return;
            case 4673:
              player13.PlayDrums(num72);
              return;
            default:
              Main.musicPitch = num72;
              LegacySoundStyle type5 = SoundID.Item26;
              if (type4 == 507)
                type5 = SoundID.Item35;
              if (type4 == 1305)
                type5 = SoundID.Item47;
              SoundEngine.PlaySound(type5, player13.position);
              return;
          }
        case 59:
          int num73 = (int) this.reader.ReadInt16();
          int num74 = (int) this.reader.ReadInt16();
          Wiring.SetCurrentUser(this.whoAmI);
          Wiring.HitSwitch(num73, num74);
          Wiring.SetCurrentUser();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(59, ignoreClient: this.whoAmI, number: num73, number2: (float) num74);
          break;
        case 60:
          int n = (int) this.reader.ReadInt16();
          int x6 = (int) this.reader.ReadInt16();
          int y6 = (int) this.reader.ReadInt16();
          byte num75 = this.reader.ReadByte();
          if (n >= Main.maxNPCs)
          {
            NetMessage.BootPlayer(this.whoAmI, NetworkText.FromKey("Net.CheatingInvalid"));
            break;
          }
          NPC npc4 = Main.npc[n];
          int num76 = npc4.isLikeATownNPC ? 1 : 0;
          if (Main.netMode == 1)
          {
            npc4.homeless = num75 == (byte) 1;
            npc4.homeTileX = x6;
            npc4.homeTileY = y6;
          }
          if (num76 == 0)
            break;
          if (Main.netMode == 1)
          {
            if (num75 == (byte) 1)
            {
              WorldGen.TownManager.KickOut(npc4.type);
              break;
            }
            if (num75 != (byte) 2)
              break;
            WorldGen.TownManager.SetRoom(npc4.type, x6, y6);
            break;
          }
          if (num75 == (byte) 1)
          {
            WorldGen.kickOut(n);
            break;
          }
          WorldGen.moveRoom(x6, y6, n);
          break;
        case 61:
          int num77 = (int) this.reader.ReadInt16();
          int index43 = (int) this.reader.ReadInt16();
          if (Main.netMode != 2)
            break;
          if ((index43 < 0 || index43 >= (int) NPCID.Count ? 0 : (NPCID.Sets.MPAllowedEnemies[index43] ? 1 : 0)) != 0)
          {
            if (NPC.AnyNPCs(index43))
              break;
            NPC.SpawnOnPlayer(num77, index43);
            break;
          }
          switch (index43)
          {
            case -19:
              Main.StartSlimeRain();
              return;
            case -18:
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey("Misc.PeddlersSatchelUsed"), new Color(50, (int) byte.MaxValue, 130));
              NPC.peddlersSatchelWasUsed = true;
              NetMessage.TrySendData(7);
              return;
            case -17:
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey("Misc.CombatBookVolumeTwoUsed"), new Color(50, (int) byte.MaxValue, 130));
              NPC.combatBookVolumeTwoWasUsed = true;
              NetMessage.TrySendData(7);
              return;
            case -16:
              NPC.SpawnMechQueen(num77);
              return;
            case -15:
              NPC.UnlockOrExchangePet(ref NPC.unlockedSlimeBlueSpawn, 670, "Misc.LicenseSlimeUsed", index43);
              return;
            case -14:
              NPC.UnlockOrExchangePet(ref NPC.boughtBunny, 656, "Misc.LicenseBunnyUsed", index43);
              return;
            case -13:
              NPC.UnlockOrExchangePet(ref NPC.boughtDog, 638, "Misc.LicenseDogUsed", index43);
              return;
            case -12:
              NPC.UnlockOrExchangePet(ref NPC.boughtCat, 637, "Misc.LicenseCatUsed", index43);
              return;
            case -11:
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey("Misc.CombatBookUsed"), new Color(50, (int) byte.MaxValue, 130));
              NPC.combatBookWasUsed = true;
              NetMessage.TrySendData(7);
              return;
            case -10:
              if (Main.dayTime || Main.bloodMoon)
                return;
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[8].Key), new Color(50, (int) byte.MaxValue, 130));
              Main.bloodMoon = true;
              if (Main.GetMoonPhase() == MoonPhase.Empty)
                Main.moonPhase = 5;
              AchievementsHelper.NotifyProgressionEvent(4);
              NetMessage.TrySendData(7);
              return;
            case -8:
              if (!NPC.downedGolemBoss || !Main.hardMode || NPC.AnyDanger() || NPC.AnyoneNearCultists())
                return;
              WorldGen.StartImpendingDoom(720);
              NetMessage.TrySendData(7);
              return;
            case -7:
              Main.invasionDelay = 0;
              Main.StartInvasion(4);
              NetMessage.TrySendData(7);
              NetMessage.TrySendData(78, number2: 1f, number3: (float) (Main.invasionType + 3));
              return;
            case -6:
              if (!Main.dayTime || Main.eclipse)
                return;
              if (Main.remixWorld)
                ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[106].Key), new Color(50, (int) byte.MaxValue, 130));
              else
                ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[20].Key), new Color(50, (int) byte.MaxValue, 130));
              Main.eclipse = true;
              NetMessage.TrySendData(7);
              return;
            case -5:
              if (Main.dayTime || DD2Event.Ongoing)
                return;
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[34].Key), new Color(50, (int) byte.MaxValue, 130));
              Main.startSnowMoon();
              NetMessage.TrySendData(7);
              NetMessage.TrySendData(78, number2: 1f, number3: 1f, number4: 1f);
              return;
            case -4:
              if (Main.dayTime || DD2Event.Ongoing)
                return;
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[31 /*0x1F*/].Key), new Color(50, (int) byte.MaxValue, 130));
              Main.startPumpkinMoon();
              NetMessage.TrySendData(7);
              NetMessage.TrySendData(78, number2: 1f, number3: 2f, number4: 1f);
              return;
            default:
              if (index43 >= 0)
                return;
              int type6 = 1;
              if (index43 > (int) -InvasionID.Count)
                type6 = -index43;
              if (type6 > 0 && Main.invasionType == 0)
              {
                Main.invasionDelay = 0;
                Main.StartInvasion(type6);
              }
              NetMessage.TrySendData(7);
              NetMessage.TrySendData(78, number2: 1f, number3: (float) (Main.invasionType + 3));
              return;
          }
        case 62:
          int number29 = (int) this.reader.ReadByte();
          int number2_9 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number29 = this.whoAmI;
          if (number2_9 == 1)
            Main.player[number29].NinjaDodge();
          if (number2_9 == 2)
            Main.player[number29].ShadowDodge();
          if (number2_9 == 4)
            Main.player[number29].BrainOfConfusionDodge();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(62, ignoreClient: this.whoAmI, number: number29, number2: (float) number2_9);
          break;
        case 63 /*0x3F*/:
          int num78 = (int) this.reader.ReadInt16();
          int num79 = (int) this.reader.ReadInt16();
          byte num80 = this.reader.ReadByte();
          byte number4_1 = this.reader.ReadByte();
          if (number4_1 == (byte) 0)
            WorldGen.paintTile(num78, num79, num80);
          else
            WorldGen.paintCoatTile(num78, num79, num80);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(63 /*0x3F*/, ignoreClient: this.whoAmI, number: num78, number2: (float) num79, number3: (float) num80, number4: (float) number4_1);
          break;
        case 64 /*0x40*/:
          int num81 = (int) this.reader.ReadInt16();
          int num82 = (int) this.reader.ReadInt16();
          byte num83 = this.reader.ReadByte();
          byte number4_2 = this.reader.ReadByte();
          if (number4_2 == (byte) 0)
            WorldGen.paintWall(num81, num82, num83);
          else
            WorldGen.paintCoatWall(num81, num82, num83);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(64 /*0x40*/, ignoreClient: this.whoAmI, number: num81, number2: (float) num82, number3: (float) num83, number4: (float) number4_2);
          break;
        case 65:
          BitsByte bitsByte32 = (BitsByte) this.reader.ReadByte();
          int number2_10 = (int) this.reader.ReadInt16();
          if (Main.netMode == 2)
            number2_10 = this.whoAmI;
          Vector2 vector2_8 = this.reader.ReadVector2();
          int num84 = (int) this.reader.ReadByte();
          int num85 = 0;
          if (bitsByte32[0])
            ++num85;
          if (bitsByte32[1])
            num85 += 2;
          bool flag18 = false;
          if (bitsByte32[2])
            flag18 = true;
          int num86 = 0;
          if (bitsByte32[3])
            num86 = this.reader.ReadInt32();
          if (flag18)
            vector2_8 = Main.player[number2_10].position;
          switch (num85)
          {
            case 0:
              Main.player[number2_10].Teleport(vector2_8, num84, num86);
              if (Main.netMode == 2)
                NetMessage.TrySendData(65, ignoreClient: this.whoAmI, number2: (float) number2_10, number3: vector2_8.X, number4: vector2_8.Y, number5: num84, number6: flag18.ToInt(), number7: num86);
              if (Main.netMode != 1 || number2_10 != Main.myPlayer)
                return;
              NetMessage.TrySendData(65, number: 3, number2: (float) number2_10);
              return;
            case 1:
              Main.npc[number2_10].Teleport(vector2_8, num84, num86);
              Main.npc[number2_10].netOffset *= 0.0f;
              return;
            case 2:
              Main.player[number2_10].Teleport(vector2_8, num84, num86);
              if (Main.netMode != 2)
                return;
              RemoteClient.CheckSection(this.whoAmI, vector2_8);
              NetMessage.TrySendData(65, number2: (float) number2_10, number3: vector2_8.X, number4: vector2_8.Y, number5: num84, number6: flag18.ToInt(), number7: num86);
              int index44 = -1;
              float num87 = 9999f;
              for (int index45 = 0; index45 < (int) byte.MaxValue; ++index45)
              {
                if (Main.player[index45].active && index45 != this.whoAmI)
                {
                  Vector2 vector2_9 = Main.player[index45].position - Main.player[this.whoAmI].position;
                  if ((double) vector2_9.Length() < (double) num87)
                  {
                    num87 = vector2_9.Length();
                    index44 = index45;
                  }
                }
              }
              if (index44 < 0)
                return;
              ChatHelper.BroadcastChatMessage(NetworkText.FromKey("Game.HasTeleportedTo", (object) Main.player[this.whoAmI].name, (object) Main.player[index44].name), new Color(250, 250, 0));
              return;
            case 3:
              --Main.player[number2_10].unacknowledgedTeleports;
              return;
            default:
              return;
          }
        case 66:
          int number30 = (int) this.reader.ReadByte();
          int num88 = (int) this.reader.ReadInt16();
          if (num88 <= 0)
            break;
          Player player14 = Main.player[number30];
          player14.statLife += num88;
          if (player14.statLife > player14.statLifeMax2)
            player14.statLife = player14.statLifeMax2;
          player14.HealEffect(num88, false);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(66, ignoreClient: this.whoAmI, number: number30, number2: (float) num88);
          break;
        case 67:
          break;
        case 68:
          this.reader.ReadString();
          break;
        case 69:
          int index46 = (int) this.reader.ReadInt16();
          int num89 = (int) this.reader.ReadInt16();
          int num90 = (int) this.reader.ReadInt16();
          if (Main.netMode == 1)
          {
            if (index46 < 0 || index46 >= 8000)
              break;
            Chest worldChest = Main.chest[index46];
            if (worldChest == null)
              worldChest = Chest.CreateWorldChest(index46, num89, num90);
            else if (worldChest.x != num89 || worldChest.y != num90)
              break;
            worldChest.name = this.reader.ReadString();
            break;
          }
          if (index46 < -1 || index46 >= 8000)
            break;
          if (index46 == -1)
          {
            index46 = Chest.FindChest(num89, num90);
            if (index46 == -1)
              break;
          }
          Chest chest7 = Main.chest[index46];
          if (chest7.x != num89 || chest7.y != num90)
            break;
          NetMessage.TrySendData(69, this.whoAmI, number: index46, number2: (float) num89, number3: (float) num90);
          break;
        case 70:
          if (Main.netMode != 2)
            break;
          int i1 = (int) this.reader.ReadInt16();
          int who = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            who = this.whoAmI;
          if (i1 >= Main.maxNPCs || i1 < 0)
            break;
          NPC.CatchNPC(i1, who);
          break;
        case 71:
          if (Main.netMode != 2)
            break;
          int x7 = this.reader.ReadInt32();
          int num91 = this.reader.ReadInt32();
          int num92 = (int) this.reader.ReadInt16();
          byte num93 = this.reader.ReadByte();
          int y7 = num91;
          int Type5 = num92;
          int Style1 = (int) num93;
          int whoAmI1 = this.whoAmI;
          NPC.ReleaseNPC(x7, y7, Type5, Style1, whoAmI1);
          break;
        case 72:
          if (Main.netMode != 1)
            break;
          for (int index47 = 0; index47 < Main.TravelShopMaxSlots; ++index47)
            Main.travelShop[index47] = (int) this.reader.ReadInt16();
          break;
        case 73:
          switch (this.reader.ReadByte())
          {
            case 0:
              Main.player[this.whoAmI].TeleportationPotion();
              return;
            case 1:
              Main.player[this.whoAmI].MagicConch();
              return;
            case 2:
              Main.player[this.whoAmI].DemonConch();
              return;
            case 3:
              Main.player[this.whoAmI].Shellphone_Spawn();
              return;
            case 4:
              Main.player[this.whoAmI].PlayerNoSpaceTeleport();
              return;
            default:
              return;
          }
        case 74:
          if (Main.netMode != 1)
            break;
          Main.anglerQuest = (int) this.reader.ReadByte();
          Main.anglerQuestFinished = this.reader.ReadBoolean();
          break;
        case 75:
          if (Main.netMode != 2)
            break;
          string name = Main.player[this.whoAmI].name;
          if (Main.anglerWhoFinishedToday.Contains(name))
            break;
          Main.anglerWhoFinishedToday.Add(name);
          break;
        case 76:
          int number31 = (int) this.reader.ReadByte();
          if (number31 == Main.myPlayer && !Main.ServerSideCharacter)
            break;
          if (Main.netMode == 2)
            number31 = this.whoAmI;
          Player player15 = Main.player[number31];
          player15.anglerQuestsFinished = this.reader.ReadInt32();
          player15.golferScoreAccumulated = this.reader.ReadInt32();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(76, ignoreClient: this.whoAmI, number: number31);
          break;
        case 77:
          int type7 = (int) this.reader.ReadInt16();
          ushort num94 = this.reader.ReadUInt16();
          short num95 = this.reader.ReadInt16();
          short num96 = this.reader.ReadInt16();
          int tileType = (int) num94;
          int x8 = (int) num95;
          int y8 = (int) num96;
          Animation.NewTemporaryAnimation(type7, (ushort) tileType, x8, y8);
          break;
        case 78:
          if (Main.netMode != 1)
            break;
          Main.ReportInvasionProgress(this.reader.ReadInt32(), this.reader.ReadInt32(), (int) this.reader.ReadSByte(), (int) this.reader.ReadSByte());
          break;
        case 79:
          int x9 = (int) this.reader.ReadInt16();
          int y9 = (int) this.reader.ReadInt16();
          short type8 = this.reader.ReadInt16();
          int style = (int) this.reader.ReadInt16();
          int num97 = (int) this.reader.ReadByte();
          int random = (int) this.reader.ReadSByte();
          int direction2 = !this.reader.ReadBoolean() ? -1 : 1;
          if (Main.netMode == 2)
          {
            ++Netplay.Clients[this.whoAmI].SpamAddBlock;
            if (!WorldGen.InWorld(x9, y9, 10) || !Netplay.Clients[this.whoAmI].TileSections[Netplay.GetSectionX(x9), Netplay.GetSectionY(y9)])
              break;
          }
          WorldGen.PlaceObject(x9, y9, (int) type8, style: style, alternate: num97, random: random, direction: direction2);
          if (Main.netMode != 2)
            break;
          NetMessage.SendObjectPlacement(this.whoAmI, x9, y9, (int) type8, style, num97, random, direction2);
          break;
        case 80 /*0x50*/:
          if (Main.netMode != 1)
            break;
          int index48 = (int) this.reader.ReadByte();
          int num98 = (int) this.reader.ReadInt16();
          if (num98 < -3 || num98 >= 8000)
            break;
          Main.player[index48].chest = num98;
          break;
        case 81:
          if (Main.netMode != 1)
            break;
          int x10 = (int) this.reader.ReadSingle();
          int num99 = (int) this.reader.ReadSingle();
          Color color3 = this.reader.ReadRGB();
          int amount = this.reader.ReadInt32();
          int y10 = num99;
          CombatText.NewText(new Rectangle(x10, y10, 0, 0), color3, amount);
          break;
        case 82:
          NetManager.Instance.Read(this.reader, this.whoAmI, length);
          break;
        case 83:
          break;
        case 84:
          int number32 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number32 = this.whoAmI;
          float num100 = this.reader.ReadSingle();
          Main.player[number32].stealth = num100;
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(84, ignoreClient: this.whoAmI, number: number32);
          break;
        case 85:
          if (Main.netMode == 2 && this.whoAmI < (int) byte.MaxValue)
          {
            Player player16 = Main.player[this.whoAmI];
            QuickStacking.QuickStackToNearbyChests(player16, QuickStacking.ReadNetInventory(player16, this.reader), this.reader.ReadBoolean());
            break;
          }
          if (Main.netMode != 1)
            break;
          QuickStacking.IndicateBlockedChests(Main.LocalPlayer, QuickStacking.ReadBlockedChestList(this.reader));
          break;
        case 86:
          if (Main.netMode != 1)
            break;
          int id2 = this.reader.ReadInt32();
          if (!this.reader.ReadBoolean())
          {
            TileEntity result;
            if (!TileEntity.TryGet<TileEntity>(id2, out result))
              break;
            TileEntity.Remove(result);
            break;
          }
          TileEntity ent = TileEntity.Read(this.reader, 318, true);
          ent.ID = id2;
          TileEntity.Add(ent);
          break;
        case 87:
          if (Main.netMode != 2)
            break;
          int x11 = (int) this.reader.ReadInt16();
          int y11 = (int) this.reader.ReadInt16();
          int type9 = (int) this.reader.ReadByte();
          if (!WorldGen.InWorld(x11, y11) || TileEntity.TryGetAt<TileEntity>(x11, y11, out TileEntity _))
            break;
          TileEntity.PlaceEntityNet(x11, y11, type9);
          break;
        case 88:
          if (Main.netMode != 1)
            break;
          int index49 = (int) this.reader.ReadInt16();
          if (index49 < 0 || index49 > 400)
            break;
          Item inner = Main.item[index49].inner;
          BitsByte bitsByte33 = (BitsByte) this.reader.ReadByte();
          if (bitsByte33[0])
            inner.color.PackedValue = this.reader.ReadUInt32();
          if (bitsByte33[1])
            inner.damage = (int) this.reader.ReadUInt16();
          if (bitsByte33[2])
            inner.knockBack = this.reader.ReadSingle();
          if (bitsByte33[3])
            inner.useAnimation = (int) this.reader.ReadUInt16();
          if (bitsByte33[4])
            inner.useTime = (int) this.reader.ReadUInt16();
          if (bitsByte33[5])
            inner.shoot = (int) this.reader.ReadInt16();
          if (bitsByte33[6])
            inner.shootSpeed = this.reader.ReadSingle();
          if (!bitsByte33[7])
            break;
          BitsByte bitsByte34 = (BitsByte) this.reader.ReadByte();
          if (bitsByte34[0])
            inner.width = (int) this.reader.ReadInt16();
          if (bitsByte34[1])
            inner.height = (int) this.reader.ReadInt16();
          if (bitsByte34[2])
            inner.scale = this.reader.ReadSingle();
          if (bitsByte34[3])
            inner.ammo = (int) this.reader.ReadInt16();
          if (bitsByte34[4])
            inner.useAmmo = (int) this.reader.ReadInt16();
          if (!bitsByte34[5])
            break;
          inner.notAmmo = this.reader.ReadBoolean();
          break;
        case 89:
          if (Main.netMode != 2)
            break;
          int x12 = (int) this.reader.ReadInt16();
          int num101 = (int) this.reader.ReadInt16();
          int num102 = (int) this.reader.ReadInt16();
          int num103 = (int) this.reader.ReadByte();
          int num104 = (int) this.reader.ReadInt16();
          int y12 = num101;
          int type10 = num102;
          int prefix2 = num103;
          int stack1 = num104;
          TEItemFrame.TryPlacing(x12, y12, type10, prefix2, stack1);
          break;
        case 91:
          if (Main.netMode != 1)
            break;
          int num105 = this.reader.ReadInt32();
          int type11 = (int) this.reader.ReadByte();
          if (type11 == (int) byte.MaxValue)
          {
            if (!EmoteBubble.byID.ContainsKey(num105))
              break;
            EmoteBubble.byID.Remove(num105);
            break;
          }
          int meta = (int) this.reader.ReadUInt16();
          int time2 = (int) this.reader.ReadUInt16();
          int emotion = (int) this.reader.ReadByte();
          int num106 = 0;
          if (emotion < 0)
            num106 = (int) this.reader.ReadInt16();
          WorldUIAnchor bubbleAnchor = EmoteBubble.DeserializeNetAnchor(type11, meta);
          if (type11 == 1)
            Main.player[meta].emoteTime = 360;
          lock (EmoteBubble.byID)
          {
            if (!EmoteBubble.byID.ContainsKey(num105))
            {
              EmoteBubble.byID[num105] = new EmoteBubble(emotion, bubbleAnchor, time2);
            }
            else
            {
              EmoteBubble.byID[num105].lifeTime = time2;
              EmoteBubble.byID[num105].lifeTimeStart = time2;
              EmoteBubble.byID[num105].emote = emotion;
              EmoteBubble.byID[num105].anchor = bubbleAnchor;
            }
            EmoteBubble.byID[num105].ID = num105;
            EmoteBubble.byID[num105].metadata = num106;
            EmoteBubble.OnBubbleChange(num105);
            break;
          }
        case 92:
          int number33 = (int) this.reader.ReadInt16();
          int num107 = this.reader.ReadInt32();
          float num108 = this.reader.ReadSingle();
          float num109 = this.reader.ReadSingle();
          if (number33 < 0 || number33 > Main.maxNPCs)
            break;
          if (Main.netMode == 1)
          {
            Main.npc[number33].moneyPing(new Vector2(num108, num109));
            Main.npc[number33].extraValue = num107;
            break;
          }
          Main.npc[number33].extraValue += num107;
          NetMessage.TrySendData(92, number: number33, number2: (float) Main.npc[number33].extraValue, number3: num108, number4: num109);
          break;
        case 93:
          break;
        case 94:
          string str4 = this.reader.ReadString();
          this.reader.ReadInt32();
          int num110 = (int) this.reader.ReadSingle();
          double num111 = (double) this.reader.ReadSingle();
          if (!DebugOptions.enableDebugCommands)
            break;
          switch (str4)
          {
            case "/showdebug":
              DebugOptions.Shared_ReportCommandUsage = num110 == 1;
              return;
            case "/setserverping":
              DebugOptions.Shared_ServerPing = num110;
              DebugNetworkStream.Latency = (uint) (num110 / 2);
              return;
            default:
              return;
          }
        case 95:
          ushort number2_11 = this.reader.ReadUInt16();
          int num112 = (int) this.reader.ReadByte();
          if (Main.netMode != 2)
            break;
          for (int index50 = 0; index50 < 1000; ++index50)
          {
            if (Main.projectile[index50].owner == (int) number2_11 && Main.projectile[index50].active && Main.projectile[index50].type == 602 && (double) Main.projectile[index50].ai[1] == (double) num112)
            {
              Main.projectile[index50].Kill();
              NetMessage.TrySendData(29, number: Main.projectile[index50].identity, number2: (float) number2_11);
              break;
            }
          }
          break;
        case 96 /*0x60*/:
          int index51 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index51 = this.whoAmI;
          Player player17 = Main.player[index51];
          int num113 = (int) this.reader.ReadInt16();
          Vector2 newPos1 = this.reader.ReadVector2();
          Vector2 vector2_10 = this.reader.ReadVector2();
          player17.lastPortalColorIndex = num113 + (num113 % 2 == 0 ? 1 : -1);
          player17.Teleport(newPos1, 4, num113);
          player17.velocity = vector2_10;
          if (Main.netMode != 2)
            break;
          NetMessage.SendData(96 /*0x60*/, ignoreClient: index51, number: index51, number2: newPos1.X, number3: newPos1.Y, number4: (float) num113);
          break;
        case 97:
          if (Main.netMode != 1)
            break;
          AchievementsHelper.NotifyNPCKilledDirect(Main.player[Main.myPlayer], (int) this.reader.ReadInt16());
          break;
        case 98:
          if (Main.netMode != 1)
            break;
          AchievementsHelper.NotifyProgressionEvent((int) this.reader.ReadInt16());
          break;
        case 99:
          int number34 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number34 = this.whoAmI;
          Main.player[number34].MinionRestTargetPoint = this.reader.ReadVector2();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(99, ignoreClient: this.whoAmI, number: number34);
          break;
        case 100:
          int index52 = (int) this.reader.ReadUInt16();
          NPC npc5 = Main.npc[index52];
          int extraInfo = (int) this.reader.ReadInt16();
          Vector2 newPos2 = this.reader.ReadVector2();
          Vector2 vector2_11 = this.reader.ReadVector2();
          npc5.lastPortalColorIndex = extraInfo + (extraInfo % 2 == 0 ? 1 : -1);
          npc5.Teleport(newPos2, 4, extraInfo);
          npc5.velocity = vector2_11;
          npc5.netOffset *= 0.0f;
          break;
        case 101:
          if (Main.netMode == 2)
            break;
          NPC.ShieldStrengthTowerSolar = (int) this.reader.ReadUInt16();
          NPC.ShieldStrengthTowerVortex = (int) this.reader.ReadUInt16();
          NPC.ShieldStrengthTowerNebula = (int) this.reader.ReadUInt16();
          NPC.ShieldStrengthTowerStardust = (int) this.reader.ReadUInt16();
          if (NPC.ShieldStrengthTowerSolar < 0)
            NPC.ShieldStrengthTowerSolar = 0;
          if (NPC.ShieldStrengthTowerVortex < 0)
            NPC.ShieldStrengthTowerVortex = 0;
          if (NPC.ShieldStrengthTowerNebula < 0)
            NPC.ShieldStrengthTowerNebula = 0;
          if (NPC.ShieldStrengthTowerStardust < 0)
            NPC.ShieldStrengthTowerStardust = 0;
          if (NPC.ShieldStrengthTowerSolar > NPC.LunarShieldPowerMax)
            NPC.ShieldStrengthTowerSolar = NPC.LunarShieldPowerMax;
          if (NPC.ShieldStrengthTowerVortex > NPC.LunarShieldPowerMax)
            NPC.ShieldStrengthTowerVortex = NPC.LunarShieldPowerMax;
          if (NPC.ShieldStrengthTowerNebula > NPC.LunarShieldPowerMax)
            NPC.ShieldStrengthTowerNebula = NPC.LunarShieldPowerMax;
          if (NPC.ShieldStrengthTowerStardust <= NPC.LunarShieldPowerMax)
            break;
          NPC.ShieldStrengthTowerStardust = NPC.LunarShieldPowerMax;
          break;
        case 102:
          int index53 = (int) this.reader.ReadByte();
          ushort num114 = this.reader.ReadUInt16();
          Vector2 Other = this.reader.ReadVector2();
          if (Main.netMode == 2)
          {
            NetMessage.TrySendData(102, number: this.whoAmI, number2: (float) num114, number3: Other.X, number4: Other.Y);
            break;
          }
          Player player18 = Main.player[index53];
          for (int index54 = 0; index54 < (int) byte.MaxValue; ++index54)
          {
            Player player19 = Main.player[index54];
            if (player19.active && !player19.dead && (player18.team == 0 || player18.team == player19.team) && (double) player19.Distance(Other) < 700.0)
            {
              Vector2 vector2_12 = player18.Center - player19.Center;
              Vector2 vec = Vector2.Normalize(vector2_12);
              if (!vec.HasNaNs())
              {
                int num115 = 90;
                float radians = 0.0f;
                float num116 = 0.209439516f;
                Vector2 spinningpoint = new Vector2(0.0f, -8f);
                Vector2 vector2_13 = new Vector2(-3f);
                float num117 = 0.0f;
                float num118 = 0.005f;
                switch (num114)
                {
                  case 173:
                    num115 = 90;
                    break;
                  case 176 /*0xB0*/:
                    num115 = 88;
                    break;
                  case 179:
                    num115 = 86;
                    break;
                }
                for (int index55 = 0; (double) index55 < (double) vector2_12.Length() / 6.0; ++index55)
                {
                  Vector2 Position = player19.Center + 6f * (float) index55 * vec + spinningpoint.RotatedBy((double) radians) + vector2_13;
                  radians += num116;
                  int Type6 = num115;
                  Color newColor = new Color();
                  int index56 = Dust.NewDust(Position, 6, 6, Type6, Alpha: 100, newColor: newColor, Scale: 1.5f);
                  Main.dust[index56].noGravity = true;
                  Main.dust[index56].velocity = Vector2.Zero;
                  Main.dust[index56].fadeIn = (num117 += num118);
                  Main.dust[index56].velocity += vec * 1.5f;
                }
              }
              player19.NebulaLevelup((int) num114);
            }
          }
          break;
        case 103:
          if (Main.netMode != 1)
            break;
          NPC.MaxMoonLordCountdown = this.reader.ReadInt32();
          NPC.MoonLordCountdown = this.reader.ReadInt32();
          break;
        case 104:
          if (Main.netMode != 1 || Main.npcShop <= 0)
            break;
          Item[] objArray = Main.instance.shop[Main.npcShop].item;
          int index57 = (int) this.reader.ReadByte();
          int Type7 = (int) this.reader.ReadInt16();
          int num119 = (int) this.reader.ReadInt16();
          int prefixWeWant3 = (int) this.reader.ReadByte();
          int num120 = this.reader.ReadInt32();
          BitsByte bitsByte35 = (BitsByte) this.reader.ReadByte();
          if (index57 >= objArray.Length)
            break;
          objArray[index57] = new Item();
          objArray[index57].SetDefaults(Type7);
          objArray[index57].stack = num119;
          objArray[index57].Prefix(prefixWeWant3);
          objArray[index57].value = num120;
          objArray[index57].buyOnce = bitsByte35[0];
          break;
        case 105:
          if (Main.netMode == 1)
            break;
          int i2 = (int) this.reader.ReadInt16();
          int num121 = (int) this.reader.ReadInt16();
          bool flag19 = this.reader.ReadBoolean();
          int j = num121;
          int num122 = flag19 ? 1 : 0;
          WorldGen.ToggleGemLock(i2, j, num122 != 0);
          break;
        case 106:
          if (Main.netMode != 1)
            break;
          Utils.PoofOfSmoke(new HalfVector2()
          {
            PackedValue = this.reader.ReadUInt32()
          }.ToVector2());
          break;
        case 107:
          if (Main.netMode != 1)
            break;
          Color color4 = this.reader.ReadRGB();
          string text2 = NetworkText.Deserialize(this.reader).ToString();
          int num123 = (int) this.reader.ReadInt16();
          Color c = color4;
          int WidthLimit = num123;
          Main.NewTextMultiline(text2, c: c, WidthLimit: WidthLimit);
          break;
        case 108:
          if (Main.netMode != 1)
            break;
          int Damage = (int) this.reader.ReadInt16();
          float KnockBack = this.reader.ReadSingle();
          int x13 = (int) this.reader.ReadInt16();
          int y13 = (int) this.reader.ReadInt16();
          int angle = (int) this.reader.ReadInt16();
          int ammo = (int) this.reader.ReadInt16();
          int owner = (int) this.reader.ReadByte();
          if (owner != Main.myPlayer)
            break;
          WorldGen.ShootFromCannon(x13, y13, angle, ammo, Damage, KnockBack, owner, true);
          break;
        case 109:
          if (Main.netMode != 2)
            break;
          int x14 = (int) this.reader.ReadInt16();
          int num124 = (int) this.reader.ReadInt16();
          int x15 = (int) this.reader.ReadInt16();
          int y14 = (int) this.reader.ReadInt16();
          int num125 = (int) this.reader.ReadByte();
          int whoAmI2 = this.whoAmI;
          WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
          WiresUI.Settings.ToolMode = (WiresUI.Settings.MultiToolMode) num125;
          int y15 = num124;
          Wiring.MassWireOperation(new Point(x14, y15), new Point(x15, y14), Main.player[whoAmI2]);
          WiresUI.Settings.ToolMode = toolMode;
          break;
        case 110:
          if (Main.netMode != 1)
            break;
          int type12 = (int) this.reader.ReadInt16();
          int num126 = (int) this.reader.ReadInt16();
          int index58 = (int) this.reader.ReadByte();
          if (index58 != Main.myPlayer)
            break;
          Player player20 = Main.player[index58];
          for (int index59 = 0; index59 < num126; ++index59)
            player20.ConsumeItem(type12);
          player20.wireOperationsCooldown = 0;
          break;
        case 111:
          if (Main.netMode != 2)
            break;
          BirthdayParty.ToggleManualParty();
          break;
        case 112 /*0x70*/:
          int number35 = (int) this.reader.ReadByte();
          int num127 = this.reader.ReadInt32();
          int num128 = this.reader.ReadInt32();
          int num129 = (int) this.reader.ReadByte();
          int num130 = (int) this.reader.ReadInt16();
          bool hitTree = this.reader.ReadByte() == (byte) 1;
          switch (number35)
          {
            case 1:
              if (Main.netMode == 1)
                WorldGen.TreeGrowFX(num127, num128, num129, num130, hitTree);
              if (Main.netMode != 2)
                return;
              NetMessage.TrySendData((int) num2, number: number35, number2: (float) num127, number3: (float) num128, number4: (float) num129, number5: num130, number6: hitTree ? 1 : 0);
              return;
            case 2:
              NPC.FairyEffects(new Vector2((float) num127, (float) num128), num130);
              return;
            default:
              return;
          }
        case 113:
          int x16 = (int) this.reader.ReadInt16();
          int y16 = (int) this.reader.ReadInt16();
          if (Main.netMode != 2 || Main.snowMoon || Main.pumpkinMoon)
            break;
          if (DD2Event.WouldFailSpawningHere(x16, y16))
            DD2Event.FailureMessage(this.whoAmI);
          DD2Event.SummonCrystal(x16, y16, this.whoAmI);
          break;
        case 114:
          if (Main.netMode != 1)
            break;
          DD2Event.WipeEntities();
          break;
        case 115:
          int number36 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number36 = this.whoAmI;
          Main.player[number36].MinionAttackTargetNPC = (int) this.reader.ReadInt16();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(115, ignoreClient: this.whoAmI, number: number36);
          break;
        case 116:
          if (Main.netMode != 1)
            break;
          DD2Event.TimeLeftBetweenWaves = this.reader.ReadInt32();
          break;
        case 117:
          int playerTargetIndex1 = (int) this.reader.ReadByte();
          if (Main.netMode == 2 && this.whoAmI != playerTargetIndex1 && (!Main.player[playerTargetIndex1].hostile || !Main.player[this.whoAmI].hostile))
            break;
          PlayerDeathReason playerDeathReason1 = PlayerDeathReason.FromReader(this.reader);
          int num131 = (int) this.reader.ReadInt16();
          int num132 = (int) this.reader.ReadByte() - 1;
          BitsByte bitsByte36 = (BitsByte) this.reader.ReadByte();
          bool flag20 = bitsByte36[0];
          bool pvp1 = bitsByte36[1];
          int num133 = (int) this.reader.ReadSByte();
          Main.player[playerTargetIndex1].Hurt(playerDeathReason1, num131, num132, pvp1, true, flag20, num133);
          if (Main.netMode != 2)
            break;
          NetMessage.SendPlayerHurt(playerTargetIndex1, playerDeathReason1, num131, num132, flag20, pvp1, num133, ignoreClient: this.whoAmI);
          break;
        case 118:
          int playerTargetIndex2 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            playerTargetIndex2 = this.whoAmI;
          PlayerDeathReason playerDeathReason2 = PlayerDeathReason.FromReader(this.reader);
          int num134 = (int) this.reader.ReadInt16();
          int num135 = (int) this.reader.ReadByte() - 1;
          bool pvp2 = ((BitsByte) this.reader.ReadByte())[0];
          Main.player[playerTargetIndex2].KillMe(playerDeathReason2, (double) num134, num135, pvp2);
          if (Main.netMode != 2)
            break;
          NetMessage.SendPlayerDeath(playerTargetIndex2, playerDeathReason2, num134, num135, pvp2, ignoreClient: this.whoAmI);
          break;
        case 119:
          if (Main.netMode != 1)
            break;
          int x17 = (int) this.reader.ReadSingle();
          int num136 = (int) this.reader.ReadSingle();
          Color color5 = this.reader.ReadRGB();
          NetworkText networkText = NetworkText.Deserialize(this.reader);
          int y17 = num136;
          CombatText.NewText(new Rectangle(x17, y17, 0, 0), color5, networkText.ToString());
          break;
        case 120:
          int index60 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index60 = this.whoAmI;
          int num137 = (int) this.reader.ReadByte();
          if (num137 < 0 || num137 >= EmoteID.Count || Main.netMode != 2)
            break;
          EmoteBubble.NewBubble(num137, new WorldUIAnchor((Entity) Main.player[index60]), 360);
          EmoteBubble.CheckForNPCsToReactToEmoteBubble(num137, Main.player[index60]);
          break;
        case 121:
          int num138 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            num138 = this.whoAmI;
          int num139 = this.reader.ReadInt32();
          int num140 = (int) this.reader.ReadByte();
          int num141 = (int) this.reader.ReadByte();
          TEDisplayDoll result1;
          if (!TileEntity.TryGet<TEDisplayDoll>(num139, out result1))
          {
            TEDisplayDoll.ReadDummySync(num140, num141, this.reader);
            break;
          }
          result1.ReadData(num140, num141, this.reader);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData((int) num2, ignoreClient: num138, number: num138, number2: (float) num139, number3: (float) num140, number4: (float) num141);
          break;
        case 122:
          int num142 = this.reader.ReadInt32();
          int number2_12 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number2_12 = this.whoAmI;
          if (Main.netMode == 2)
          {
            if (num142 == -1)
            {
              Main.player[number2_12].tileEntityAnchor.Clear();
              NetMessage.TrySendData((int) num2, number: num142, number2: (float) number2_12);
              break;
            }
            TileEntity result2;
            if (!TileEntity.IsOccupied(num142, out int _) && TileEntity.TryGet<TileEntity>(num142, out result2))
            {
              Main.player[number2_12].tileEntityAnchor.Set(num142, (int) result2.Position.X, (int) result2.Position.Y);
              NetMessage.TrySendData((int) num2, number: num142, number2: (float) number2_12);
            }
          }
          if (Main.netMode != 1)
            break;
          if (num142 == -1)
          {
            Main.player[number2_12].tileEntityAnchor.Clear();
            break;
          }
          TileEntity result3;
          if (!TileEntity.TryGet<TileEntity>(num142, out result3))
            break;
          TileEntity.SetInteractionAnchor(Main.player[number2_12], (int) result3.Position.X, (int) result3.Position.Y, num142);
          break;
        case 123:
          if (Main.netMode != 2)
            break;
          int x18 = (int) this.reader.ReadInt16();
          int num143 = (int) this.reader.ReadInt16();
          int num144 = (int) this.reader.ReadInt16();
          int num145 = (int) this.reader.ReadByte();
          int num146 = (int) this.reader.ReadInt16();
          int y18 = num143;
          int type13 = num144;
          int prefix3 = num145;
          int stack2 = num146;
          TEWeaponsRack.TryPlacing(x18, y18, type13, prefix3, stack2);
          break;
        case 124:
          int num147 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            num147 = this.whoAmI;
          int num148 = this.reader.ReadInt32();
          int num149 = (int) this.reader.ReadByte();
          bool dye = false;
          if (num149 >= 2)
          {
            dye = true;
            num149 -= 2;
          }
          TEHatRack result4;
          if (!TileEntity.TryGet<TEHatRack>(num148, out result4) || num149 >= 2)
          {
            this.reader.ReadInt32();
            int num150 = (int) this.reader.ReadByte();
            break;
          }
          result4.ReadItem(num149, this.reader, dye);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData((int) num2, ignoreClient: num147, number: num147, number2: (float) num148, number3: (float) num149, number4: (float) dye.ToInt());
          break;
        case 125:
          int num151 = (int) this.reader.ReadByte();
          int num152 = (int) this.reader.ReadInt16();
          int num153 = (int) this.reader.ReadInt16();
          int num154 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            num151 = this.whoAmI;
          if (Main.netMode == 1)
            Main.player[Main.myPlayer].GetOtherPlayersPickTile(num152, num153, num154);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(125, ignoreClient: num151, number: num151, number2: (float) num152, number3: (float) num153, number4: (float) num154);
          break;
        case 126:
          if (Main.netMode != 1)
            break;
          NPC.RevengeManager.AddMarkerFromReader(this.reader);
          break;
        case 127 /*0x7F*/:
          int markerUniqueID = this.reader.ReadInt32();
          if (Main.netMode != 1)
            break;
          NPC.RevengeManager.DestroyMarker(markerUniqueID);
          break;
        case 128 /*0x80*/:
          int num155 = (int) this.reader.ReadByte();
          int num156 = (int) this.reader.ReadUInt16();
          int num157 = (int) this.reader.ReadUInt16();
          int num158 = (int) this.reader.ReadUInt16();
          int num159 = (int) this.reader.ReadUInt16();
          if (Main.netMode == 2)
          {
            NetMessage.SendData(128 /*0x80*/, ignoreClient: num155, number: num155, number2: (float) num158, number3: (float) num159, number5: num156, number6: num157);
            break;
          }
          GolfHelper.ContactListener.PutBallInCup_TextAndEffects(new Point(num156, num157), num155, num158, num159);
          break;
        case 129:
          if (Main.netMode != 1)
            break;
          if (Main.LocalPlayer.team > 0)
            NetMessage.SendData(45, number: Main.myPlayer);
          Main.FixUIScale();
          Main.TrySetPreparationState(Main.WorldPreparationState.ProcessingData);
          break;
        case 130:
          if (Main.netMode != 2)
            break;
          int num160 = (int) this.reader.ReadUInt16();
          int num161 = (int) this.reader.ReadUInt16();
          int Type8 = (int) this.reader.ReadInt16();
          if (Type8 == 682)
          {
            if (NPC.unlockedSlimeRedSpawn)
              break;
            NPC.unlockedSlimeRedSpawn = true;
            NetMessage.TrySendData(7);
          }
          int X = num160 * 16 /*0x10*/;
          int Y = num161 * 16 /*0x10*/;
          NPC npc6 = new NPC();
          npc6.SetDefaults(Type8);
          int type14 = npc6.type;
          int netId = npc6.netID;
          int number37 = NPC.NewNPC((IEntitySource) new EntitySource_FishedOut((IEntitySourceTarget) Main.player[this.whoAmI]), X, Y, Type8);
          if (netId != type14)
          {
            Main.npc[number37].SetDefaults(netId);
            NetMessage.TrySendData(23, number: number37);
          }
          if (Type8 != 682)
            break;
          WorldGen.CheckAchievement_RealEstateAndTownSlimes();
          break;
        case 131:
          if (Main.netMode != 1)
            break;
          int index61 = (int) this.reader.ReadUInt16();
          NPC npc7 = index61 >= Main.maxNPCs ? new NPC() : Main.npc[index61];
          if (this.reader.ReadByte() != (byte) 1)
            break;
          int time3 = this.reader.ReadInt32();
          int fromWho = (int) this.reader.ReadInt16();
          npc7.GetImmuneTime(fromWho, time3);
          break;
        case 132:
          if (Main.netMode != 1)
            break;
          Point point = this.reader.ReadVector2().ToPoint();
          ushort key = this.reader.ReadUInt16();
          LegacySoundStyle legacySoundStyle = SoundID.SoundByIndex[key];
          BitsByte bitsByte37 = (BitsByte) this.reader.ReadByte();
          int Style2 = !bitsByte37[0] ? legacySoundStyle.Style : this.reader.ReadInt32();
          float volumeScale = !bitsByte37[1] ? legacySoundStyle.Volume : MathHelper.Clamp(this.reader.ReadSingle(), 0.0f, 1f);
          float pitchOffset = !bitsByte37[2] ? legacySoundStyle.GetRandomPitch() : MathHelper.Clamp(this.reader.ReadSingle(), -1f, 1f);
          SoundEngine.PlaySound(legacySoundStyle.SoundId, point.X, point.Y, Style2, volumeScale, pitchOffset);
          break;
        case 133:
          if (Main.netMode != 2)
            break;
          int x19 = (int) this.reader.ReadInt16();
          int num162 = (int) this.reader.ReadInt16();
          int num163 = (int) this.reader.ReadInt16();
          int num164 = (int) this.reader.ReadByte();
          int num165 = (int) this.reader.ReadInt16();
          int y19 = num162;
          int type15 = num163;
          int prefix4 = num164;
          int stack3 = num165;
          TEFoodPlatter.TryPlacing(x19, y19, type15, prefix4, stack3);
          break;
        case 134:
          int index62 = (int) this.reader.ReadByte();
          int num166 = this.reader.ReadInt32();
          float num167 = this.reader.ReadSingle();
          byte num168 = this.reader.ReadByte();
          bool flag21 = this.reader.ReadBoolean();
          bool flag22 = this.reader.ReadBoolean();
          float num169 = this.reader.ReadSingle();
          float num170 = this.reader.ReadSingle();
          byte num171 = this.reader.ReadByte();
          if (Main.netMode == 2)
            index62 = this.whoAmI;
          Player player21 = Main.player[index62];
          player21.ladyBugLuckTimeLeft = num166;
          player21.torchLuck = num167;
          player21.luckPotion = num168;
          player21.HasGardenGnomeNearby = flag21;
          player21.brokenMirrorBadLuck = flag22;
          player21.equipmentBasedLuckBonus = num169;
          player21.coinLuck = num170;
          player21.kiteLuckLevel = num171;
          player21.RecalculateLuck();
          if (Main.netMode != 2)
            break;
          NetMessage.SendData(134, ignoreClient: index62, number: index62);
          break;
        case 135:
          int index63 = (int) this.reader.ReadByte();
          if (Main.netMode != 1)
            break;
          Main.player[index63].immuneAlpha = (int) byte.MaxValue;
          break;
        case 136:
          for (int index64 = 0; index64 < 2; ++index64)
          {
            for (int index65 = 0; index65 < 3; ++index65)
              NPC.cavernMonsterType[index64, index65] = (int) this.reader.ReadUInt16();
          }
          break;
        case 137:
          if (Main.netMode != 2)
            break;
          int index66 = (int) this.reader.ReadInt16();
          int buffTypeToRemove = (int) this.reader.ReadUInt16();
          if (index66 < 0 || index66 >= Main.maxNPCs)
            break;
          Main.npc[index66].RequestBuffRemoval(buffTypeToRemove);
          break;
        case 139:
          if (Main.netMode == 2)
            break;
          int index67 = (int) this.reader.ReadByte();
          bool flag23 = this.reader.ReadBoolean();
          Main.countsAsHostForGameplay[index67] = flag23;
          break;
        case 140:
          int num172 = (int) this.reader.ReadByte();
          int num173 = this.reader.ReadInt32();
          switch (num172)
          {
            case 0:
              if (Main.netMode != 1)
                return;
              CreditsRollEvent.SetRemainingTimeDirect(num173);
              return;
            case 1:
              if (Main.netMode != 2)
                return;
              NPC.TransformCopperSlime(num173);
              return;
            case 2:
              if (Main.netMode != 2)
                return;
              NPC.TransformElderSlime(num173);
              return;
            default:
              return;
          }
        case 141:
          LucyAxeMessage.MessageSource messageSource = (LucyAxeMessage.MessageSource) this.reader.ReadByte();
          byte num174 = this.reader.ReadByte();
          Vector2 velocity = this.reader.ReadVector2();
          int num175 = this.reader.ReadInt32();
          int num176 = this.reader.ReadInt32();
          if (Main.netMode == 2)
          {
            NetMessage.SendData(141, ignoreClient: this.whoAmI, number: (int) messageSource, number2: (float) num174, number3: velocity.X, number4: velocity.Y, number5: num175, number6: num176);
            break;
          }
          LucyAxeMessage.CreateFromNet(messageSource, num174, new Vector2((float) num175, (float) num176), velocity);
          break;
        case 142:
          int number38 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number38 = this.whoAmI;
          Player player22 = Main.player[number38];
          player22.piggyBankProjTracker.TryReading(this.reader);
          player22.voidLensChest.TryReading(this.reader);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(142, ignoreClient: this.whoAmI, number: number38);
          break;
        case 143:
          if (Main.netMode != 2)
            break;
          DD2Event.AttemptToSkipWaitTime();
          break;
        case 144 /*0x90*/:
          if (Main.netMode != 2)
            break;
          NPC.HaveDryadDoStardewAnimation();
          break;
        case 146:
          switch (this.reader.ReadByte())
          {
            case 0:
              WorldItem.ShimmerEffect(this.reader.ReadVector2());
              return;
            case 1:
              Vector2 coinPosition = this.reader.ReadVector2();
              int coinAmount = this.reader.ReadInt32();
              Main.player[Main.myPlayer].AddCoinLuck(coinPosition, coinAmount);
              return;
            default:
              return;
          }
        case 147:
          int index68 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index68 = this.whoAmI;
          int num177 = (int) this.reader.ReadByte();
          Main.player[index68].TrySwitchingLoadout(num177);
          MessageBuffer.ReadAccessoryVisibility(this.reader, Main.player[index68].hideVisibleAccessory);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData((int) num2, ignoreClient: index68, number: index68, number2: (float) num177);
          break;
        case 149:
          if (Main.netMode != 2)
            break;
          int x20 = (int) this.reader.ReadInt16();
          int num178 = (int) this.reader.ReadInt16();
          int num179 = (int) this.reader.ReadInt16();
          int num180 = (int) this.reader.ReadByte();
          int num181 = (int) this.reader.ReadInt16();
          int y20 = num178;
          int type16 = num179;
          int prefix5 = num180;
          int stack4 = num181;
          TEDeadCellsDisplayJar.TryPlacing(x20, y20, type16, prefix5, stack4);
          break;
        case 150:
          int index69 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            index69 = this.whoAmI;
          int num182 = (int) this.reader.ReadInt16();
          Player player23 = Main.player[index69];
          if (Main.netMode == 2)
          {
            if (num182 >= 0)
            {
              player23.SetOrRequestSpectating(num182);
              break;
            }
            player23.spectating = -1;
            NetMessage.SendData(150, ignoreClient: this.whoAmI, number: this.whoAmI, number2: (float) num182);
            break;
          }
          if (player23 == Main.LocalPlayer && player23.spectating < 0)
            break;
          player23.spectating = num182;
          break;
        case 151:
          int number39 = (int) this.reader.ReadInt16();
          WorldItem worldItem4 = Main.item[number39];
          if (Main.netMode == 2 && Main.timeItemSlotCannotBeReusedFor[number39] > 0 || Main.netMode == 2 && worldItem4.playerIndexTheItemIsReservedFor != this.whoAmI)
            break;
          worldItem4.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
          worldItem4.TurnToAir();
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(151, ignoreClient: this.whoAmI, number: number39);
          break;
        case 152:
          int number40 = (int) this.reader.ReadByte();
          if (Main.netMode == 2)
            number40 = this.whoAmI;
          if (Main.netMode == 2)
            NetMessage.TrySendData(152, ignoreClient: this.whoAmI, number: number40);
          if (Main.netMode != 1)
            break;
          Player player24 = Main.player[number40];
          Item obj1 = player24.inventory[player24.selectedItem];
          if (obj1.UseSound == null)
            break;
          SoundEngine.PlaySound(obj1.UseSound, player24.Center, obj1.useSoundPitch);
          break;
        case 153:
          int number41 = (int) this.reader.ReadByte();
          int num183 = (int) this.reader.ReadInt16();
          Main.npc[number41].GetHurtByDebuff(num183);
          if (Main.netMode != 2)
            break;
          NetMessage.TrySendData(153, ignoreClient: this.whoAmI, number: number41, number2: (float) num183);
          break;
        case 154:
          if (Main.netMode == 2)
          {
            NetMessage.TrySendData(154, this.whoAmI);
            break;
          }
          Terraria.Net.Ping.PingRecieved();
          break;
        case 155:
          short index70 = this.reader.ReadInt16();
          short newSize = this.reader.ReadInt16();
          if (index70 < (short) 0 || index70 >= (short) 8000)
            break;
          Main.chest[(int) index70].Resize((int) newSize);
          break;
        case 156:
          if (Main.netMode != 2)
            break;
          Point16 point16 = new Point16(this.reader.ReadInt16(), this.reader.ReadInt16());
          int itemType = (int) this.reader.ReadInt16();
          TELeashedEntityAnchorWithItem result5;
          if (!TileEntity.TryGetAt<TELeashedEntityAnchorWithItem>((int) point16.X, (int) point16.Y, out result5))
            break;
          result5.InsertItem(itemType);
          break;
        case 158:
          if (Main.netMode == 2)
            break;
          byte index71 = this.reader.ReadByte();
          Main.player[(int) index71].Spawn(PlayerSpawnContext.TeamSwap);
          break;
        case 159:
          if (Main.netMode != 2)
            break;
          NetMessage.SendSection(this.whoAmI, (int) this.reader.ReadUInt16(), (int) this.reader.ReadUInt16());
          break;
        case 160 /*0xA0*/:
          if (Main.netMode == 2)
            break;
          int index72 = (int) this.reader.ReadInt16();
          Vector2 vector2_14 = this.reader.ReadVector2();
          Main.item[index72].position = vector2_14;
          break;
        case 161:
          string str5 = this.reader.ReadString();
          Main.player[this.whoAmI].host = !string.IsNullOrWhiteSpace(Netplay.HostToken) && Netplay.HostToken == str5;
          break;
        default:
          if (Main.netMode != 2 || Netplay.Clients[this.whoAmI].State != 0)
            break;
          NetMessage.BootPlayer(this.whoAmI, Lang.mp[2].ToNetworkText());
          break;
      }
    }
  }

  private static void ReadAccessoryVisibility(BinaryReader reader, bool[] hideVisibleAccessory)
  {
    ushort num = reader.ReadUInt16();
    for (int index = 0; index < hideVisibleAccessory.Length; ++index)
      hideVisibleAccessory[index] = ((uint) num & (uint) (1 << index)) > 0U;
  }

  private static void TrySendingItemArray(int plr, Item[] array, int slotStartIndex)
  {
    for (int index = 0; index < array.Length; ++index)
      NetMessage.TrySendData(5, number: plr, number2: (float) (slotStartIndex + index));
  }
}
