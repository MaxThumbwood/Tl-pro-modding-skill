using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B09 RID: 2825
	[Token(Token = "0x2000B09")]
	public class ShapeBranch : GenShape
	{
		// Token: 0x0600581A RID: 22554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x8609F8", Offset = "0x8609F8", VA = "0x8609F8")]
		public ShapeBranch()
		{
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581B")]
		[Address(RVA = "0x860A40", Offset = "0x860A40", VA = "0x860A40")]
		public ShapeBranch(Point offset)
		{
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581C")]
		[Address(RVA = "0x860A68", Offset = "0x860A68", VA = "0x860A68")]
		public ShapeBranch(double angle, double distance)
		{
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x00028F20 File Offset: 0x00027120
		[Token(Token = "0x600581D")]
		[Address(RVA = "0x860B6C", Offset = "0x860B6C", VA = "0x860B6C")]
		private bool PerformSegment(Point origin, GenAction action, Point start, Point end, int size)
		{
			return default(bool);
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00028F38 File Offset: 0x00027138
		[Token(Token = "0x600581E")]
		[Address(RVA = "0x860DE8", Offset = "0x860DE8", VA = "0x860DE8", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600581F")]
		[Address(RVA = "0x861498", Offset = "0x861498", VA = "0x861498")]
		public ShapeBranch OutputEndpoints(List<Point> endpoints)
		{
			return null;
		}

		// Token: 0x04009972 RID: 39282
		[Token(Token = "0x4009972")]
		[FieldOffset(Offset = "0x10")]
		private Point _offset;

		// Token: 0x04009973 RID: 39283
		[Token(Token = "0x4009973")]
		[FieldOffset(Offset = "0x18")]
		private List<Point> _endPoints;

		// Token: 0x02000B0A RID: 2826
		[Token(Token = "0x2000B0A")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06005820 RID: 22560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005820")]
			[Address(RVA = "0x860DE0", Offset = "0x860DE0", VA = "0x860DE0")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06005821 RID: 22561 RVA: 0x00028F50 File Offset: 0x00027150
			[Token(Token = "0x6005821")]
			[Address(RVA = "0x8614A0", Offset = "0x8614A0", VA = "0x8614A0")]
			internal bool <PerformSegment>b__0(int tileX, int tileY)
			{
				return default(bool);
			}

			// Token: 0x04009974 RID: 39284
			[Token(Token = "0x4009974")]
			[FieldOffset(Offset = "0x8")]
			public ShapeBranch <>4__this;

			// Token: 0x04009975 RID: 39285
			[Token(Token = "0x4009975")]
			[FieldOffset(Offset = "0xC")]
			public GenAction action;

			// Token: 0x04009976 RID: 39286
			[Token(Token = "0x4009976")]
			[FieldOffset(Offset = "0x10")]
			public Point origin;

			// Token: 0x04009977 RID: 39287
			[Token(Token = "0x4009977")]
			[FieldOffset(Offset = "0x18")]
			public Utils.TileActionAttempt <>9__0;
		}
	}
}
