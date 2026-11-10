using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	public class WorkshopTagOption
	{
		// Token: 0x06003E16 RID: 15894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x1E67D68", Offset = "0x1E67D68", VA = "0x1E67D68")]
		public WorkshopTagOption(string nameKey, string internalName)
		{
		}

		// Token: 0x04004891 RID: 18577
		[Token(Token = "0x4004891")]
		[FieldOffset(Offset = "0x8")]
		public readonly string NameKey;

		// Token: 0x04004892 RID: 18578
		[Token(Token = "0x4004892")]
		[FieldOffset(Offset = "0xC")]
		public readonly string InternalNameForAPIs;
	}
}
