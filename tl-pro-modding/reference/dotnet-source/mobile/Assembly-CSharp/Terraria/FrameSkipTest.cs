using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public class FrameSkipTest
	{
		// Token: 0x06002FAD RID: 12205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x189E560", Offset = "0x189E560", VA = "0x189E560")]
		public static void Update(GameTime gameTime)
		{
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x189E654", Offset = "0x189E654", VA = "0x189E654")]
		public static void CheckReset(GameTime gameTime)
		{
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x189E8D0", Offset = "0x189E8D0", VA = "0x189E8D0")]
		public static void UpdateServerTest()
		{
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x189E9B4", Offset = "0x189E9B4", VA = "0x189E9B4")]
		public FrameSkipTest()
		{
		}

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x0")]
		private static int LastRecordedSecondNumber;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x4")]
		private static float CallsThisSecond;

		// Token: 0x04003F44 RID: 16196
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0x8")]
		private static float DeltasThisSecond;

		// Token: 0x04003F45 RID: 16197
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0xC")]
		private static List<float> DeltaSamples;

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		private const int SamplesCount = 5;

		// Token: 0x04003F47 RID: 16199
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x10")]
		private static MultiTimer serverFramerateTest;
	}
}
