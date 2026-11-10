using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.ID
{
	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	public class PlayerVoiceID
	{
		// Token: 0x060041CC RID: 16844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x1F76560", Offset = "0x1F76560", VA = "0x1F76560")]
		public PlayerVoiceID()
		{
		}

		// Token: 0x04007C07 RID: 31751
		[Token(Token = "0x4007C07")]
		[FieldOffset(Offset = "0x0")]
		public static int[] VariantOrder;

		// Token: 0x04007C08 RID: 31752
		[Token(Token = "0x4007C08")]
		public const int None = 0;

		// Token: 0x04007C09 RID: 31753
		[Token(Token = "0x4007C09")]
		public const int Male = 1;

		// Token: 0x04007C0A RID: 31754
		[Token(Token = "0x4007C0A")]
		public const int Female = 2;

		// Token: 0x04007C0B RID: 31755
		[Token(Token = "0x4007C0B")]
		public const int Other = 3;

		// Token: 0x04007C0C RID: 31756
		[Token(Token = "0x4007C0C")]
		public const int Count = 4;

		// Token: 0x02000708 RID: 1800
		[Token(Token = "0x2000708")]
		public static class Sets
		{
			// Token: 0x04007C0D RID: 31757
			[Token(Token = "0x4007C0D")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x04007C0E RID: 31758
			[Token(Token = "0x4007C0E")]
			[FieldOffset(Offset = "0x4")]
			public static Color[] Colors;
		}
	}
}
