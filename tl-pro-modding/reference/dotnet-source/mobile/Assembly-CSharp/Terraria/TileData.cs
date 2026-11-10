using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	public class TileData
	{
		// Token: 0x06003330 RID: 13104 RVA: 0x00018D80 File Offset: 0x00016F80
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x1A14C44", Offset = "0x1A14C44", VA = "0x1A14C44")]
		public Tile Safe(int x, int y)
		{
			return default(Tile);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x1A14C50", Offset = "0x1A14C50", VA = "0x1A14C50")]
		public bool ConfirmWidthHeight(int width, int height)
		{
			return default(bool);
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x00018DB0 File Offset: 0x00016FB0
		[Token(Token = "0x170006EE")]
		public Tile Item
		{
			[Token(Token = "0x6003332")]
			[Address(RVA = "0x1A0AA20", Offset = "0x1A0AA20", VA = "0x1A0AA20")]
			get
			{
				return default(Tile);
			}
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x1A14C74", Offset = "0x1A14C74", VA = "0x1A14C74")]
		public static long CalculateWorldTileSize(int x, int y)
		{
			return 0L;
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00018DE0 File Offset: 0x00016FE0
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x1A14D10", Offset = "0x1A14D10", VA = "0x1A14D10")]
		public static long CalculateStorageSize(int size)
		{
			return 0L;
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x1A14D4C", Offset = "0x1A14D4C", VA = "0x1A14D4C")]
		public void Allocate(int x, int y)
		{
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x1A0F5F0", Offset = "0x1A0F5F0", VA = "0x1A0F5F0")]
		public static void ClearEverything(int tileIndex)
		{
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x1A0F710", Offset = "0x1A0F710", VA = "0x1A0F710")]
		public static void SetEverything(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x1A0E8F8", Offset = "0x1A0E8F8", VA = "0x1A0E8F8")]
		public static void ReregisterTile(int tileIndex)
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[Token(Token = "0x6003339")]
		[Address(RVA = "0x1A0E830", Offset = "0x1A0E830", VA = "0x1A0E830")]
		public static bool HasBeenLoaded(int tileIndex)
		{
			return default(bool);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00018E10 File Offset: 0x00017010
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x1A155D0", Offset = "0x1A155D0", VA = "0x1A155D0")]
		public static ushort GetType(int tileIndex)
		{
			return 0;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333B")]
		[Address(RVA = "0x1A0E9C0", Offset = "0x1A0E9C0", VA = "0x1A0E9C0")]
		public static void SetType(int tileIndex, ushort newType)
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00018E28 File Offset: 0x00017028
		[Token(Token = "0x600333C")]
		[Address(RVA = "0x1A155FC", Offset = "0x1A155FC", VA = "0x1A155FC")]
		public static short GetSHeader(int tileIndex)
		{
			return 0;
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333D")]
		[Address(RVA = "0x1A0EC38", Offset = "0x1A0EC38", VA = "0x1A0EC38")]
		public static void SetSHeader(int tileIndex, short sHeader)
		{
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x600333E")]
		[Address(RVA = "0x1A1563C", Offset = "0x1A1563C", VA = "0x1A1563C")]
		public static short GetFrameX(int tileIndex)
		{
			return 0;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333F")]
		[Address(RVA = "0x1A0F0BC", Offset = "0x1A0F0BC", VA = "0x1A0F0BC")]
		public static void SetFrameXY(int tileIndex, short frameX, short frameY)
		{
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003340")]
		[Address(RVA = "0x1A0F000", Offset = "0x1A0F000", VA = "0x1A0F000")]
		public static void SetFrameX(int tileIndex, short frameX)
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00018E58 File Offset: 0x00017058
		[Token(Token = "0x6003341")]
		[Address(RVA = "0x1A15668", Offset = "0x1A15668", VA = "0x1A15668")]
		public static short GetFrameY(int tileIndex)
		{
			return 0;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003342")]
		[Address(RVA = "0x1A0F24C", Offset = "0x1A0F24C", VA = "0x1A0F24C")]
		public static void SetFrameY(int tileIndex, short frameY)
		{
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00018E70 File Offset: 0x00017070
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x1A15694", Offset = "0x1A15694", VA = "0x1A15694")]
		public static ushort GetSearchUID(int tileIndex)
		{
			return 0;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x1A156BC", Offset = "0x1A156BC", VA = "0x1A156BC")]
		public static void SetSearchUID(int tileIndex, ushort value)
		{
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00018E88 File Offset: 0x00017088
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x1A11DCC", Offset = "0x1A11DCC", VA = "0x1A11DCC")]
		public static bool GetCheckingLiquid(int tileIndex)
		{
			return default(bool);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x1A11E38", Offset = "0x1A11E38", VA = "0x1A11E38")]
		public static void SetCheckingLiquid(int tileIndex, bool checkingLiquid)
		{
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00018EA0 File Offset: 0x000170A0
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x1A11E9C", Offset = "0x1A11E9C", VA = "0x1A11E9C")]
		public static bool GetSkipLiquid(int tileIndex)
		{
			return default(bool);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003348")]
		[Address(RVA = "0x1A11F00", Offset = "0x1A11F00", VA = "0x1A11F00")]
		public static void SetSkipLiquid(int tileIndex, bool skipLiquid)
		{
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x00018EB8 File Offset: 0x000170B8
		[Token(Token = "0x6003349")]
		[Address(RVA = "0x1A11F64", Offset = "0x1A11F64", VA = "0x1A11F64")]
		public static bool GetTileFramed(int tileIndex)
		{
			return default(bool);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x1A11FE0", Offset = "0x1A11FE0", VA = "0x1A11FE0")]
		public static void SetTileFramed(int tileIndex, bool framed)
		{
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00018ED0 File Offset: 0x000170D0
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x1A156EC", Offset = "0x1A156EC", VA = "0x1A156EC")]
		public static ushort GetWall(int tileIndex)
		{
			return 0;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x1A15710", Offset = "0x1A15710", VA = "0x1A15710")]
		public static void SetWall(int tileIndex, ushort wall)
		{
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00018EE8 File Offset: 0x000170E8
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x1A15734", Offset = "0x1A15734", VA = "0x1A15734")]
		public static byte GetLiquid(int tileIndex)
		{
			return 0;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x1A15754", Offset = "0x1A15754", VA = "0x1A15754")]
		public static void SetLiquid(int tileIndex, byte liquid)
		{
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00018F00 File Offset: 0x00017100
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x1A15774", Offset = "0x1A15774", VA = "0x1A15774")]
		public static byte GetBHeader(int tileIndex)
		{
			return 0;
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x1A0ED50", Offset = "0x1A0ED50", VA = "0x1A0ED50")]
		public static void SetBHeader(int tileIndex, byte bHeader)
		{
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00018F18 File Offset: 0x00017118
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x1A1579C", Offset = "0x1A1579C", VA = "0x1A1579C")]
		public static byte GetBHeader2(int tileIndex)
		{
			return 0;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003352")]
		[Address(RVA = "0x1A0EE34", Offset = "0x1A0EE34", VA = "0x1A0EE34")]
		public static void SetBHeader2(int tileIndex, byte bHeader2)
		{
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x1A157C4", Offset = "0x1A157C4", VA = "0x1A157C4")]
		public static void SetBHeaderAnd3(int tileIndex, byte bHeader, byte bHeader3)
		{
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003354")]
		[Address(RVA = "0x1A15870", Offset = "0x1A15870", VA = "0x1A15870")]
		public static void SetBHeader2And3(int tileIndex, byte bHeader2, byte bHeader3)
		{
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003355")]
		[Address(RVA = "0x1A1591C", Offset = "0x1A1591C", VA = "0x1A1591C")]
		public static void CopyTileBasic(int tileIndex, int srcTile)
		{
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003356")]
		[Address(RVA = "0x1A0F8CC", Offset = "0x1A0F8CC", VA = "0x1A0F8CC")]
		public static void CopyTile(int tileIndex, int srcTile)
		{
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x6003357")]
		[Address(RVA = "0x1A15958", Offset = "0x1A15958", VA = "0x1A15958")]
		public static byte GetBHeader3(int tileIndex)
		{
			return 0;
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003358")]
		[Address(RVA = "0x1A0EF18", Offset = "0x1A0EF18", VA = "0x1A0EF18")]
		public static void SetBHeader3(int tileIndex, byte bHeader3)
		{
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x00018F48 File Offset: 0x00017148
		[Token(Token = "0x6003359")]
		[Address(RVA = "0x1A15980", Offset = "0x1A15980", VA = "0x1A15980")]
		private static uint GetFreeListEntry()
		{
			return 0U;
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335A")]
		[Address(RVA = "0x1A15A0C", Offset = "0x1A15A0C", VA = "0x1A15A0C")]
		private static void AddFreeEntry(uint tileDefinition)
		{
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x1A15A98", Offset = "0x1A15A98", VA = "0x1A15A98")]
		public static void CleanTileDefinitions()
		{
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00018F60 File Offset: 0x00017160
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x1A1514C", Offset = "0x1A1514C", VA = "0x1A1514C")]
		public static uint GetTileDefinition(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3)
		{
			return 0U;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x1A1546C", Offset = "0x1A1546C", VA = "0x1A1546C")]
		public static void ReleaseTileDefinition(uint tileDefinition)
		{
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335E")]
		[Address(RVA = "0x1A16090", Offset = "0x1A16090", VA = "0x1A16090")]
		public TileData()
		{
		}

		// Token: 0x0400430D RID: 17165
		[Token(Token = "0x400430D")]
		[FieldOffset(Offset = "0x0")]
		public static long NPCState;

		// Token: 0x0400430E RID: 17166
		[Token(Token = "0x400430E")]
		[FieldOffset(Offset = "0x8")]
		private int _width;

		// Token: 0x0400430F RID: 17167
		[Token(Token = "0x400430F")]
		[FieldOffset(Offset = "0xC")]
		private int _height;

		// Token: 0x04004310 RID: 17168
		[Token(Token = "0x4004310")]
		private const int TileBufferSize = 200000;

		// Token: 0x04004311 RID: 17169
		[Token(Token = "0x4004311")]
		private const uint TileBufferNoEntry = 4294967295U;

		// Token: 0x04004312 RID: 17170
		[Token(Token = "0x4004312")]
		private const int TileListTypeCount = 4096;

		// Token: 0x04004313 RID: 17171
		[Token(Token = "0x4004313")]
		[FieldOffset(Offset = "0x10")]
		private int bufferSize;

		// Token: 0x04004314 RID: 17172
		[Token(Token = "0x4004314")]
		[FieldOffset(Offset = "0x14")]
		private unsafe byte* memorybuffer;

		// Token: 0x04004315 RID: 17173
		[Token(Token = "0x4004315")]
		[FieldOffset(Offset = "0x18")]
		private long actualBufferSize;

		// Token: 0x04004316 RID: 17174
		[Token(Token = "0x4004316")]
		[FieldOffset(Offset = "0x8")]
		public static TileData.TileDataPointers Data;

		// Token: 0x04004317 RID: 17175
		[Token(Token = "0x4004317")]
		[FieldOffset(Offset = "0x3C")]
		public unsafe static uint* TileLookup;

		// Token: 0x04004318 RID: 17176
		[Token(Token = "0x4004318")]
		[FieldOffset(Offset = "0x40")]
		public unsafe static int* TileReferenceCount;

		// Token: 0x04004319 RID: 17177
		[Token(Token = "0x4004319")]
		[FieldOffset(Offset = "0x44")]
		private static uint FreeTiles;

		// Token: 0x0400431A RID: 17178
		[Token(Token = "0x400431A")]
		[FieldOffset(Offset = "0x48")]
		public unsafe static ushort* TileSeachUID;

		// Token: 0x0400431B RID: 17179
		[Token(Token = "0x400431B")]
		[FieldOffset(Offset = "0x4C")]
		private static int TotalTileCount;

		// Token: 0x0400431C RID: 17180
		[Token(Token = "0x400431C")]
		[FieldOffset(Offset = "0x50")]
		private unsafe static uint* TileLists;

		// Token: 0x0400431D RID: 17181
		[Token(Token = "0x400431D")]
		[FieldOffset(Offset = "0x54")]
		private unsafe static uint* TileListNext;

		// Token: 0x0400431E RID: 17182
		[Token(Token = "0x400431E")]
		[FieldOffset(Offset = "0x58")]
		private unsafe static uint* TileListPrevious;

		// Token: 0x0400431F RID: 17183
		[Token(Token = "0x400431F")]
		[FieldOffset(Offset = "0x5C")]
		public unsafe static ushort* TileType;

		// Token: 0x04004320 RID: 17184
		[Token(Token = "0x4004320")]
		[FieldOffset(Offset = "0x60")]
		public unsafe static short* TileSHeader;

		// Token: 0x04004321 RID: 17185
		[Token(Token = "0x4004321")]
		[FieldOffset(Offset = "0x64")]
		public unsafe static short* TileFrameX;

		// Token: 0x04004322 RID: 17186
		[Token(Token = "0x4004322")]
		[FieldOffset(Offset = "0x68")]
		public unsafe static short* TileFrameY;

		// Token: 0x04004323 RID: 17187
		[Token(Token = "0x4004323")]
		[FieldOffset(Offset = "0x6C")]
		public unsafe static ushort* TileWall;

		// Token: 0x04004324 RID: 17188
		[Token(Token = "0x4004324")]
		[FieldOffset(Offset = "0x70")]
		public unsafe static byte* TileLiquid;

		// Token: 0x04004325 RID: 17189
		[Token(Token = "0x4004325")]
		[FieldOffset(Offset = "0x74")]
		public unsafe static byte* TileBHeader;

		// Token: 0x04004326 RID: 17190
		[Token(Token = "0x4004326")]
		[FieldOffset(Offset = "0x78")]
		public unsafe static byte* TileBHeader2;

		// Token: 0x04004327 RID: 17191
		[Token(Token = "0x4004327")]
		[FieldOffset(Offset = "0x7C")]
		public unsafe static byte* TileBHeader3;

		// Token: 0x02000504 RID: 1284
		[Token(Token = "0x2000504")]
		public struct TileDataPointers
		{
			// Token: 0x06003360 RID: 13152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003360")]
			[Address(RVA = "0x1A160F4", Offset = "0x1A160F4", VA = "0x1A160F4")]
			[MethodImpl(256)]
			public void SetLiquidType(int tileIndex, int liquidType)
			{
			}

			// Token: 0x06003361 RID: 13153 RVA: 0x00018F78 File Offset: 0x00017178
			[Token(Token = "0x6003361")]
			[Address(RVA = "0x1A1619C", Offset = "0x1A1619C", VA = "0x1A1619C")]
			[MethodImpl(256)]
			public int GetLiquidType(int tileIndex)
			{
				return 0;
			}

			// Token: 0x06003362 RID: 13154 RVA: 0x00018F90 File Offset: 0x00017190
			[Token(Token = "0x6003362")]
			[Address(RVA = "0x1A16214", Offset = "0x1A16214", VA = "0x1A16214")]
			[MethodImpl(256)]
			public bool activePal(uint tilePalIndex)
			{
				return default(bool);
			}

			// Token: 0x06003363 RID: 13155 RVA: 0x00018FA8 File Offset: 0x000171A8
			[Token(Token = "0x6003363")]
			[Address(RVA = "0x1A16224", Offset = "0x1A16224", VA = "0x1A16224")]
			[MethodImpl(256)]
			public bool invisibleBlockPal(uint tilePalIndex)
			{
				return default(bool);
			}

			// Token: 0x06003364 RID: 13156 RVA: 0x00018FC0 File Offset: 0x000171C0
			[Token(Token = "0x6003364")]
			[Address(RVA = "0x1A16294", Offset = "0x1A16294", VA = "0x1A16294")]
			[MethodImpl(256)]
			public byte slopePal(uint tilePalIndex)
			{
				return 0;
			}

			// Token: 0x06003365 RID: 13157 RVA: 0x00018FD8 File Offset: 0x000171D8
			[Token(Token = "0x6003365")]
			[Address(RVA = "0x1A162A8", Offset = "0x1A162A8", VA = "0x1A162A8")]
			[MethodImpl(256)]
			public bool halfBrickPal(uint tilePalIndex)
			{
				return default(bool);
			}

			// Token: 0x06003366 RID: 13158 RVA: 0x00018FF0 File Offset: 0x000171F0
			[Token(Token = "0x6003366")]
			[Address(RVA = "0x1A162BC", Offset = "0x1A162BC", VA = "0x1A162BC")]
			[MethodImpl(256)]
			public byte frameNumberPal(uint tilePalIndex)
			{
				return 0;
			}

			// Token: 0x06003367 RID: 13159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003367")]
			[Address(RVA = "0x1A162CC", Offset = "0x1A162CC", VA = "0x1A162CC")]
			[MethodImpl(256)]
			public void setFrameNumber(int tileIndex, byte frameNumber)
			{
			}

			// Token: 0x06003368 RID: 13160 RVA: 0x00019008 File Offset: 0x00017208
			[Token(Token = "0x6003368")]
			[Address(RVA = "0x1A16358", Offset = "0x1A16358", VA = "0x1A16358")]
			[MethodImpl(256)]
			public int TileIndex(int x, int y)
			{
				return 0;
			}

			// Token: 0x06003369 RID: 13161 RVA: 0x00019020 File Offset: 0x00017220
			[Token(Token = "0x6003369")]
			[Address(RVA = "0x1A16364", Offset = "0x1A16364", VA = "0x1A16364")]
			[MethodImpl(256)]
			public uint TilePalIndex(int tileIndex)
			{
				return 0U;
			}

			// Token: 0x04004328 RID: 17192
			[Token(Token = "0x4004328")]
			[FieldOffset(Offset = "0x0")]
			public int maxX;

			// Token: 0x04004329 RID: 17193
			[Token(Token = "0x4004329")]
			[FieldOffset(Offset = "0x4")]
			public int maxY;

			// Token: 0x0400432A RID: 17194
			[Token(Token = "0x400432A")]
			[FieldOffset(Offset = "0x8")]
			public unsafe ushort* searchUID;

			// Token: 0x0400432B RID: 17195
			[Token(Token = "0x400432B")]
			[FieldOffset(Offset = "0xC")]
			public unsafe ushort* wall;

			// Token: 0x0400432C RID: 17196
			[Token(Token = "0x400432C")]
			[FieldOffset(Offset = "0x10")]
			public unsafe byte* liquid;

			// Token: 0x0400432D RID: 17197
			[Token(Token = "0x400432D")]
			[FieldOffset(Offset = "0x14")]
			public unsafe uint* palette;

			// Token: 0x0400432E RID: 17198
			[Token(Token = "0x400432E")]
			[FieldOffset(Offset = "0x18")]
			public unsafe ushort* type;

			// Token: 0x0400432F RID: 17199
			[Token(Token = "0x400432F")]
			[FieldOffset(Offset = "0x1C")]
			public unsafe short* sHeader;

			// Token: 0x04004330 RID: 17200
			[Token(Token = "0x4004330")]
			[FieldOffset(Offset = "0x20")]
			public unsafe short* frameX;

			// Token: 0x04004331 RID: 17201
			[Token(Token = "0x4004331")]
			[FieldOffset(Offset = "0x24")]
			public unsafe short* frameY;

			// Token: 0x04004332 RID: 17202
			[Token(Token = "0x4004332")]
			[FieldOffset(Offset = "0x28")]
			public unsafe byte* bHeader;

			// Token: 0x04004333 RID: 17203
			[Token(Token = "0x4004333")]
			[FieldOffset(Offset = "0x2C")]
			public unsafe byte* bHeader2;

			// Token: 0x04004334 RID: 17204
			[Token(Token = "0x4004334")]
			[FieldOffset(Offset = "0x30")]
			public unsafe byte* bHeader3;
		}
	}
}
