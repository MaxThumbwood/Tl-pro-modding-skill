using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	public struct Liquid
	{
		// Token: 0x060030A0 RID: 12448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x18D5AA0", Offset = "0x18D5AA0", VA = "0x18D5AA0")]
		public static void NetSendLiquid(int x, int y)
		{
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x18D5C68", Offset = "0x18D5C68", VA = "0x18D5C68")]
		public static void tilesIgnoreWater(bool ignoreSolids)
		{
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x18D5D28", Offset = "0x18D5D28", VA = "0x18D5D28")]
		public static void worldGenTilesIgnoreWater(bool ignoreSolids)
		{
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x18D5E30", Offset = "0x18D5E30", VA = "0x18D5E30")]
		public static void ReInit()
		{
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x18D5F48", Offset = "0x18D5F48", VA = "0x18D5F48")]
		public static void QuickWater(int verbose = 0, int minY = -1, int maxY = -1)
		{
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x18D77AC", Offset = "0x18D77AC", VA = "0x18D77AC")]
		public static void AttemptToMoveFluids(int x, int y, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x18D7200", Offset = "0x18D7200", VA = "0x18D7200")]
		private static void UpdateProgressDisplay(int verbose, int minY, int maxY, int y)
		{
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x18D80C0", Offset = "0x18D80C0", VA = "0x18D80C0")]
		public void Update(ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x18DB6F0", Offset = "0x18DB6F0", VA = "0x18DB6F0")]
		public static void StartPanic()
		{
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x18DB8EC", Offset = "0x18DB8EC", VA = "0x18DB8EC")]
		public static void UpdateLiquid()
		{
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x18DB460", Offset = "0x18DB460", VA = "0x18DB460")]
		public static void AddWater(int x, int y)
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00017670 File Offset: 0x00015870
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x18DC87C", Offset = "0x18DC87C", VA = "0x18DC87C")]
		private static bool UndergroundDesertCheck(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x18DC9C0", Offset = "0x18DC9C0", VA = "0x18DC9C0")]
		private static void LiquidOverwriteStrip(int x, int y, int liquidType, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x18DCBF0", Offset = "0x18DCBF0", VA = "0x18DCBF0")]
		private static void CreateLiquidMergeTile(int x, int y, int thisLiquidType, int liquidMergeType, int liquidMergeTileType, bool createMergeTilesDuringGen, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x18DD004", Offset = "0x18DD004", VA = "0x18DD004")]
		public static void LiquidCheck(int x, int y, int thisLiquidType, ref TileData.TileDataPointers tileData, bool createMergeTilesDuringGen = false)
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x18DDA70", Offset = "0x18DDA70", VA = "0x18DDA70")]
		public static void GetLiquidMergeTypes(int thisLiquidType, out int liquidMergeTileType, out int liquidMergeType, bool waterNearby, bool lavaNearby, bool honeyNearby, bool shimmerNearby)
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x18D7430", Offset = "0x18D7430", VA = "0x18D7430")]
		public static void LavaCheck(int x, int y, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x18D769C", Offset = "0x18D769C", VA = "0x18D769C")]
		public static void HoneyCheck(int x, int y, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x18D7724", Offset = "0x18D7724", VA = "0x18D7724")]
		public static void ShimmerCheck(int x, int y, ref TileData.TileDataPointers tileData)
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x18DBF9C", Offset = "0x18DBF9C", VA = "0x18DBF9C")]
		public static void DelWater(int l)
		{
		}

		// Token: 0x0400410B RID: 16651
		[Token(Token = "0x400410B")]
		public const int maxLiquidBuffer = 50000;

		// Token: 0x0400410C RID: 16652
		[Token(Token = "0x400410C")]
		public const int maxLiquid = 25000;

		// Token: 0x0400410D RID: 16653
		[Token(Token = "0x400410D")]
		[FieldOffset(Offset = "0x0")]
		public static int skipCount;

		// Token: 0x0400410E RID: 16654
		[Token(Token = "0x400410E")]
		[FieldOffset(Offset = "0x4")]
		public static int stuckCount;

		// Token: 0x0400410F RID: 16655
		[Token(Token = "0x400410F")]
		[FieldOffset(Offset = "0x8")]
		public static int stuckAmount;

		// Token: 0x04004110 RID: 16656
		[Token(Token = "0x4004110")]
		[FieldOffset(Offset = "0xC")]
		public static int cycles;

		// Token: 0x04004111 RID: 16657
		[Token(Token = "0x4004111")]
		[FieldOffset(Offset = "0x10")]
		public static int curMaxLiquid;

		// Token: 0x04004112 RID: 16658
		[Token(Token = "0x4004112")]
		[FieldOffset(Offset = "0x14")]
		public static int numLiquid;

		// Token: 0x04004113 RID: 16659
		[Token(Token = "0x4004113")]
		[FieldOffset(Offset = "0x18")]
		public static bool stuck;

		// Token: 0x04004114 RID: 16660
		[Token(Token = "0x4004114")]
		[FieldOffset(Offset = "0x19")]
		public static bool quickFall;

		// Token: 0x04004115 RID: 16661
		[Token(Token = "0x4004115")]
		[FieldOffset(Offset = "0x1A")]
		public static bool quickSettle;

		// Token: 0x04004116 RID: 16662
		[Token(Token = "0x4004116")]
		[FieldOffset(Offset = "0x1C")]
		private static int wetCounter;

		// Token: 0x04004117 RID: 16663
		[Token(Token = "0x4004117")]
		[FieldOffset(Offset = "0x20")]
		public static int panicCounter;

		// Token: 0x04004118 RID: 16664
		[Token(Token = "0x4004118")]
		[FieldOffset(Offset = "0x24")]
		public static bool panicMode;

		// Token: 0x04004119 RID: 16665
		[Token(Token = "0x4004119")]
		[FieldOffset(Offset = "0x28")]
		public static int panicY;

		// Token: 0x0400411A RID: 16666
		[Token(Token = "0x400411A")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400411B RID: 16667
		[Token(Token = "0x400411B")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x0400411C RID: 16668
		[Token(Token = "0x400411C")]
		[FieldOffset(Offset = "0x8")]
		public int kill;

		// Token: 0x0400411D RID: 16669
		[Token(Token = "0x400411D")]
		[FieldOffset(Offset = "0xC")]
		public int delay;

		// Token: 0x0400411E RID: 16670
		[Token(Token = "0x400411E")]
		[FieldOffset(Offset = "0x2C")]
		private static HashSet<int> _netChangeSet;

		// Token: 0x0400411F RID: 16671
		[Token(Token = "0x400411F")]
		[FieldOffset(Offset = "0x30")]
		private static HashSet<int> _swapNetChangeSet;
	}
}
