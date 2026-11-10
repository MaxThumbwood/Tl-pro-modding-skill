using System;
using Il2CppDummyDll;
using ReLogic.Reflection;

namespace Terraria.ID
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	public class StatusID
	{
		// Token: 0x060041F7 RID: 16887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x1F92A2C", Offset = "0x1F92A2C", VA = "0x1F92A2C")]
		public StatusID()
		{
		}

		// Token: 0x040083CD RID: 33741
		[Token(Token = "0x40083CD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Ok;

		// Token: 0x040083CE RID: 33742
		[Token(Token = "0x40083CE")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int LaterVersion;

		// Token: 0x040083CF RID: 33743
		[Token(Token = "0x40083CF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int UnknownError;

		// Token: 0x040083D0 RID: 33744
		[Token(Token = "0x40083D0")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int EmptyFile;

		// Token: 0x040083D1 RID: 33745
		[Token(Token = "0x40083D1")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int DecryptionError;

		// Token: 0x040083D2 RID: 33746
		[Token(Token = "0x40083D2")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int BadSectionPointer;

		// Token: 0x040083D3 RID: 33747
		[Token(Token = "0x40083D3")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int BadFooter;

		// Token: 0x040083D4 RID: 33748
		[Token(Token = "0x40083D4")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly IdDictionary Search;
	}
}
