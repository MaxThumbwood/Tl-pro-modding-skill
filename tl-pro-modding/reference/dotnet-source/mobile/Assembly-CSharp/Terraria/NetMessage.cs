using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x200047E")]
	public class NetMessage
	{
		// Token: 0x060025CF RID: 9679 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x120E1E4", Offset = "0x120E1E4", VA = "0x120E1E4")]
		public static bool TrySendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
		{
			return default(bool);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x120E488", Offset = "0x120E488", VA = "0x120E488")]
		public static void SendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
		{
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x121CAFC", Offset = "0x121CAFC", VA = "0x121CAFC")]
		public static void SendChestContentsTo(int chest, int targetPlayer)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x121C788", Offset = "0x121C788", VA = "0x121C788")]
		private static void WriteAccessoryVisibility(BinaryWriter writer, bool[] hideVisibleAccessory)
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x121C804", Offset = "0x121C804", VA = "0x121C804")]
		public static void CompressTileBlock(int xStart, int yStart, short width, short height, Stream stream)
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x1220D64", Offset = "0x1220D64", VA = "0x1220D64")]
		public static bool DoesPlayerSlotCountAsAHost(int plr)
		{
			return default(bool);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x121CCA8", Offset = "0x121CCA8", VA = "0x121CCA8")]
		public static void CompressTileBlock_Inner(BinaryWriter writer, int xStart, int yStart, int width, int height)
		{
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x1220E48", Offset = "0x1220E48", VA = "0x1220E48")]
		public static void DecompressTileBlock(Stream stream)
		{
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x1221130", Offset = "0x1221130", VA = "0x1221130")]
		public static void DecompressTileBlock_Inner(BinaryReader reader, int xStart, int yStart, int width, int height)
		{
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x1222F74", Offset = "0x1222F74", VA = "0x1222F74")]
		public static void BootPlayer(int plr, NetworkText msg)
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x1223010", Offset = "0x1223010", VA = "0x1223010")]
		public static void SendObjectPlacement(int whoAmi, int x, int y, int type, int style, int alternative, int random, int direction)
		{
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x1223124", Offset = "0x1223124", VA = "0x1223124")]
		public static void SendTemporaryAnimation(int whoAmi, int animationType, int tileType, int xCoord, int yCoord)
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x12231E4", Offset = "0x12231E4", VA = "0x12231E4")]
		public static void SendPlayerHurt(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool critical, bool pvp, int hitContext, int remoteClient = -1, int ignoreClient = -1)
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x12232FC", Offset = "0x12232FC", VA = "0x12232FC")]
		public static void SendPlayerDeath(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool pvp, int remoteClient = -1, int ignoreClient = -1)
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x12233F8", Offset = "0x12233F8", VA = "0x12233F8")]
		public static void PlayNetSound(NetMessage.NetSoundInfo info, int remoteClient = -1, int ignoreClient = -1)
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x12234C8", Offset = "0x12234C8", VA = "0x12234C8")]
		public static void SendCoinLossRevengeMarker(CoinLossRevengeSystem.RevengeMarker marker, int remoteClient = -1, int ignoreClient = -1)
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x1223574", Offset = "0x1223574", VA = "0x1223574")]
		public static void BeginDelaySendTileSquare()
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x1223670", Offset = "0x1223670", VA = "0x1223670")]
		public static void EndDelaySendTileSquare()
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x1223800", Offset = "0x1223800", VA = "0x1223800")]
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, int xSize, int ySize, TileChangeType changeType = TileChangeType.None)
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x1223A18", Offset = "0x1223A18", VA = "0x1223A18")]
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, int centeredSquareSize, TileChangeType changeType = TileChangeType.None)
		{
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x1223AB0", Offset = "0x1223AB0", VA = "0x1223AB0")]
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, TileChangeType changeType = TileChangeType.None)
		{
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x1223B3C", Offset = "0x1223B3C", VA = "0x1223B3C")]
		public static void SendTravelShop(int remoteClient)
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x1223C14", Offset = "0x1223C14", VA = "0x1223C14")]
		public static void SendAnglerQuest(int remoteClient)
		{
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x1223F30", Offset = "0x1223F30", VA = "0x1223F30")]
		public static void SendSection(int whoAmi, int sectionX, int sectionY)
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x122482C", Offset = "0x122482C", VA = "0x122482C")]
		private static void SyncChestContentsForSection(int whoAmi, int sectionX, int sectionY)
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x12245A8", Offset = "0x12245A8", VA = "0x12245A8")]
		private static void SyncNPCsForSection(int whoAmi, int sectionX, int sectionY)
		{
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x1224974", Offset = "0x1224974", VA = "0x1224974")]
		public static string GetPlayerListString(bool useReplacements = false)
		{
			return null;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x1224B64", Offset = "0x1224B64", VA = "0x1224B64")]
		public static void greetPlayer(int plr)
		{
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x1225014", Offset = "0x1225014", VA = "0x1225014")]
		public static void sendWater(int x, int y)
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x1225360", Offset = "0x1225360", VA = "0x1225360")]
		public static void SyncDisconnectedPlayer(int plr)
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x12272F4", Offset = "0x12272F4", VA = "0x12272F4")]
		public static void SyncConnectedPlayer(int plr)
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x12274DC", Offset = "0x12274DC", VA = "0x12274DC")]
		private static void SendNPCHousesAndTravelShop(int plr)
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x1226FF0", Offset = "0x1226FF0", VA = "0x1226FF0")]
		public static void EnsureLocalPlayerIsPresent()
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x12253D0", Offset = "0x12253D0", VA = "0x12253D0")]
		private static void SyncOnePlayer(int plr, int toWho, int fromWho)
		{
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F1")]
		[Address(RVA = "0x1227744", Offset = "0x1227744", VA = "0x1227744")]
		private static void SyncOnePlayer_ItemArray(int plr, int toWho, int fromWho, Item[] arr, int slot)
		{
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x1227828", Offset = "0x1227828", VA = "0x1227828")]
		public NetMessage()
		{
		}

		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MessageBuffer[] buffer;

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static byte[] writeBuffer;

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static BinaryWriter streamWriter;

		// Token: 0x040036BE RID: 14014
		[Token(Token = "0x40036BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static short[] _compressChestList;

		// Token: 0x040036BF RID: 14015
		[Token(Token = "0x40036BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static short[] _compressSignList;

		// Token: 0x040036C0 RID: 14016
		[Token(Token = "0x40036C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static short[] _compressEntities;

		// Token: 0x040036C1 RID: 14017
		[Token(Token = "0x40036C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static byte[] bytes;

		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40036C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static PlayerDeathReason _currentPlayerDeathReason;

		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40036C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static NetMessage.NetSoundInfo _currentNetSoundInfo;

		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static CoinLossRevengeSystem.RevengeMarker _currentRevengeMarker;

		// Token: 0x040036C5 RID: 14021
		[Token(Token = "0x40036C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static bool DelaySendTileSquare;

		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<NetMessage.DelayedSendTileMessage> DelayedSendTileSquareMessages;

		// Token: 0x040036C7 RID: 14023
		[Token(Token = "0x40036C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static bool PlacementFromItemUsage;

		// Token: 0x0200047F RID: 1151
		[Token(Token = "0x200047F")]
		public struct NetSoundInfo
		{
			// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025F4")]
			[Address(RVA = "0x15F4A40", Offset = "0x15F4A40", VA = "0x15F4A40")]
			public NetSoundInfo(Vector2 position, ushort soundIndex, int style = -1, float volume = -1f, float pitchOffset = -1f)
			{
			}

			// Token: 0x060025F5 RID: 9717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025F5")]
			[Address(RVA = "0x15F4A68", Offset = "0x15F4A68", VA = "0x15F4A68")]
			public void WriteSelfTo(BinaryWriter writer)
			{
			}

			// Token: 0x040036C8 RID: 14024
			[Token(Token = "0x40036C8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 position;

			// Token: 0x040036C9 RID: 14025
			[Token(Token = "0x40036C9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort soundIndex;

			// Token: 0x040036CA RID: 14026
			[Token(Token = "0x40036CA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int style;

			// Token: 0x040036CB RID: 14027
			[Token(Token = "0x40036CB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float volume;

			// Token: 0x040036CC RID: 14028
			[Token(Token = "0x40036CC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitchOffset;
		}

		// Token: 0x02000480 RID: 1152
		[Token(Token = "0x2000480")]
		public struct DelayedSendTileMessage
		{
			// Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025F6")]
			[Address(RVA = "0x15F4C34", Offset = "0x15F4C34", VA = "0x15F4C34")]
			public DelayedSendTileMessage(int who, int tx, int ty, int sx, int sy, TileChangeType type)
			{
			}

			// Token: 0x040036CD RID: 14029
			[Token(Token = "0x40036CD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int whoAmi;

			// Token: 0x040036CE RID: 14030
			[Token(Token = "0x40036CE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int tileX;

			// Token: 0x040036CF RID: 14031
			[Token(Token = "0x40036CF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int tileY;

			// Token: 0x040036D0 RID: 14032
			[Token(Token = "0x40036D0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int xSize;

			// Token: 0x040036D1 RID: 14033
			[Token(Token = "0x40036D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int ySize;

			// Token: 0x040036D2 RID: 14034
			[Token(Token = "0x40036D2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public TileChangeType changeType;
		}
	}
}
