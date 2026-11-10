using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CB7 RID: 3255
	[Token(Token = "0x2000CB7")]
	public class NetLiquidModule : NetModule
	{
		// Token: 0x060060EF RID: 24815 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0xAA0D94", Offset = "0xAA0D94", VA = "0xAA0D94")]
		public static NetPacket Serialize(HashSet<int> changes)
		{
			return default(NetPacket);
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0xAA1214", Offset = "0xAA1214", VA = "0xAA1214")]
		public static NetPacket SerializeForPlayer(int playerIndex)
		{
			return default(NetPacket);
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0xAA1A04", Offset = "0xAA1A04", VA = "0xAA1A04", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0xAA1CB0", Offset = "0xAA1CB0", VA = "0xAA1CB0")]
		public static void CreateAndBroadcastByChunk(HashSet<int> dirtiedPackedTileCoords)
		{
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0xAA1F4C", Offset = "0xAA1F4C", VA = "0xAA1F4C")]
		private static void PrepareAndSendToEachPlayerSeparately()
		{
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0xAA20F8", Offset = "0xAA20F8", VA = "0xAA20F8")]
		private static void BroadcastEachChunkSeparately()
		{
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F5")]
		[Address(RVA = "0xAA1D18", Offset = "0xAA1D18", VA = "0xAA1D18")]
		private static void PrepareChunks(HashSet<int> dirtiedPackedTileCoords)
		{
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F6")]
		[Address(RVA = "0xAA2820", Offset = "0xAA2820", VA = "0xAA2820")]
		private static void BroadcastAllChanges(HashSet<int> dirtiedPackedTileCoords)
		{
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F7")]
		[Address(RVA = "0xAA2408", Offset = "0xAA2408", VA = "0xAA2408")]
		private static void DistributeChangesIntoChunks(HashSet<int> dirtiedPackedTileCoords)
		{
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F8")]
		[Address(RVA = "0xAA29B0", Offset = "0xAA29B0", VA = "0xAA29B0")]
		public NetLiquidModule()
		{
		}

		// Token: 0x04009FB3 RID: 40883
		[Token(Token = "0x4009FB3")]
		[FieldOffset(Offset = "0x0")]
		private static List<int> _changesForPlayerCache;

		// Token: 0x04009FB4 RID: 40884
		[Token(Token = "0x4009FB4")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<Point, NetLiquidModule.ChunkChanges> _changesByChunkCoords;

		// Token: 0x02000CB8 RID: 3256
		[Token(Token = "0x2000CB8")]
		private class ChunkChanges
		{
			// Token: 0x060060FA RID: 24826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060FA")]
			[Address(RVA = "0xAA2908", Offset = "0xAA2908", VA = "0xAA2908")]
			public ChunkChanges(int x, int y)
			{
			}

			// Token: 0x060060FB RID: 24827 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
			[Token(Token = "0x60060FB")]
			[Address(RVA = "0xAA194C", Offset = "0xAA194C", VA = "0xAA194C")]
			public bool BroadcastingCondition(int clientIndex)
			{
				return default(bool);
			}

			// Token: 0x04009FB5 RID: 40885
			[Token(Token = "0x4009FB5")]
			[FieldOffset(Offset = "0x8")]
			public HashSet<int> DirtiedPackedTileCoords;

			// Token: 0x04009FB6 RID: 40886
			[Token(Token = "0x4009FB6")]
			[FieldOffset(Offset = "0xC")]
			public int ChunkX;

			// Token: 0x04009FB7 RID: 40887
			[Token(Token = "0x4009FB7")]
			[FieldOffset(Offset = "0x10")]
			public int ChunkY;
		}
	}
}
