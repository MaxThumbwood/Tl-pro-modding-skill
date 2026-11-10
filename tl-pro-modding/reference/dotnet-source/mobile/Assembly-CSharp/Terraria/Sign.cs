using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	public class Sign
	{
		// Token: 0x0600329D RID: 12957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x1A0A1DC", Offset = "0x1A0A1DC", VA = "0x1A0A1DC")]
		public static void KillSign(int x, int y)
		{
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000187C8 File Offset: 0x000169C8
		[Token(Token = "0x600329E")]
		[Address(RVA = "0x1A0A340", Offset = "0x1A0A340", VA = "0x1A0A340")]
		public static int ReadSign(int i, int j, bool CreateIfMissing = true)
		{
			return 0;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329F")]
		[Address(RVA = "0x1A0AAC0", Offset = "0x1A0AAC0", VA = "0x1A0AAC0")]
		public static void TextSign(int i, string text)
		{
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x1A0AFD4", Offset = "0x1A0AFD4", VA = "0x1A0AFD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x1A0AAB8", Offset = "0x1A0AAB8", VA = "0x1A0AAB8")]
		public Sign()
		{
		}

		// Token: 0x040042E8 RID: 17128
		[Token(Token = "0x40042E8")]
		public const int maxSigns = 32000;

		// Token: 0x040042E9 RID: 17129
		[Token(Token = "0x40042E9")]
		[FieldOffset(Offset = "0x8")]
		public int x;

		// Token: 0x040042EA RID: 17130
		[Token(Token = "0x40042EA")]
		[FieldOffset(Offset = "0xC")]
		public int y;

		// Token: 0x040042EB RID: 17131
		[Token(Token = "0x40042EB")]
		[FieldOffset(Offset = "0x10")]
		public string text;
	}
}
