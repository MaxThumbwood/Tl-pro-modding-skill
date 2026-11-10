using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	public class TestHighFPSIssues
	{
		// Token: 0x06002FB2 RID: 12210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x189EAB8", Offset = "0x189EAB8", VA = "0x189EAB8")]
		public static void TapUpdate(GameTime gt)
		{
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x189EC78", Offset = "0x189EC78", VA = "0x189EC78")]
		public static void TapUpdateEnd(GameTime gt)
		{
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x189EDE8", Offset = "0x189EDE8", VA = "0x189EDE8")]
		public static void TapDraw(GameTime gt)
		{
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x189EFA8", Offset = "0x189EFA8", VA = "0x189EFA8")]
		public static void Update(GameTime gt)
		{
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x189F75C", Offset = "0x189F75C", VA = "0x189F75C")]
		public TestHighFPSIssues()
		{
		}

		// Token: 0x04003F48 RID: 16200
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x0")]
		private static List<double> _tapUpdates;

		// Token: 0x04003F49 RID: 16201
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0x4")]
		private static List<double> _tapUpdateEnds;

		// Token: 0x04003F4A RID: 16202
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x8")]
		private static List<double> _tapDraws;

		// Token: 0x04003F4B RID: 16203
		[Token(Token = "0x4003F4B")]
		[FieldOffset(Offset = "0xC")]
		private static int conU;

		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x10")]
		private static int conUH;

		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x14")]
		private static int conD;

		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		[FieldOffset(Offset = "0x18")]
		private static int conDH;

		// Token: 0x04003F4F RID: 16207
		[Token(Token = "0x4003F4F")]
		[FieldOffset(Offset = "0x1C")]
		private static int race;
	}
}
