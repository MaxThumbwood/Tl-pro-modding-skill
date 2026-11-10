using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	public class TileDrawSorter
	{
		// Token: 0x06004491 RID: 17553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004491")]
		[Address(RVA = "0x55A63C", Offset = "0x55A63C", VA = "0x55A63C")]
		public TileDrawSorter()
		{
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004492")]
		[Address(RVA = "0x55A784", Offset = "0x55A784", VA = "0x55A784")]
		public void reset()
		{
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004493")]
		[Address(RVA = "0x55A790", Offset = "0x55A790", VA = "0x55A790")]
		public void Cache(int x, int y, int type)
		{
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004494")]
		[Address(RVA = "0x55A8A0", Offset = "0x55A8A0", VA = "0x55A8A0")]
		private void IncreaseArraySize()
		{
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004495")]
		[Address(RVA = "0x55A900", Offset = "0x55A900", VA = "0x55A900")]
		public void Sort()
		{
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x00020D00 File Offset: 0x0001EF00
		[Token(Token = "0x6004496")]
		[Address(RVA = "0x55A96C", Offset = "0x55A96C", VA = "0x55A96C")]
		public int GetAmountToDraw()
		{
			return 0;
		}

		// Token: 0x04008C3E RID: 35902
		[Token(Token = "0x4008C3E")]
		[FieldOffset(Offset = "0x8")]
		public TileDrawSorter.TileTexPoint[] tilesToDraw;

		// Token: 0x04008C3F RID: 35903
		[Token(Token = "0x4008C3F")]
		[FieldOffset(Offset = "0xC")]
		private int _holderLength;

		// Token: 0x04008C40 RID: 35904
		[Token(Token = "0x4008C40")]
		[FieldOffset(Offset = "0x10")]
		private int _currentCacheIndex;

		// Token: 0x04008C41 RID: 35905
		[Token(Token = "0x4008C41")]
		[FieldOffset(Offset = "0x14")]
		private TileDrawSorter.CustomComparer _tileComparer;

		// Token: 0x020007C8 RID: 1992
		[Token(Token = "0x20007C8")]
		public struct TileTexPoint
		{
			// Token: 0x06004497 RID: 17559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004497")]
			[Address(RVA = "0x55A974", Offset = "0x55A974", VA = "0x55A974", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008C42 RID: 35906
			[Token(Token = "0x4008C42")]
			[FieldOffset(Offset = "0x0")]
			public int X;

			// Token: 0x04008C43 RID: 35907
			[Token(Token = "0x4008C43")]
			[FieldOffset(Offset = "0x4")]
			public int Y;

			// Token: 0x04008C44 RID: 35908
			[Token(Token = "0x4008C44")]
			[FieldOffset(Offset = "0x8")]
			public int TileType;
		}

		// Token: 0x020007C9 RID: 1993
		[Token(Token = "0x20007C9")]
		public class CustomComparer : Comparer<TileDrawSorter.TileTexPoint>
		{
			// Token: 0x06004498 RID: 17560 RVA: 0x00020D18 File Offset: 0x0001EF18
			[Token(Token = "0x6004498")]
			[Address(RVA = "0x55AA40", Offset = "0x55AA40", VA = "0x55AA40", Slot = "6")]
			public override int Compare(TileDrawSorter.TileTexPoint x, TileDrawSorter.TileTexPoint y)
			{
				return 0;
			}

			// Token: 0x06004499 RID: 17561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004499")]
			[Address(RVA = "0x55A730", Offset = "0x55A730", VA = "0x55A730")]
			public CustomComparer()
			{
			}
		}
	}
}
