using System;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x020006D8 RID: 1752
	[Token(Token = "0x20006D8")]
	internal class GameModeID
	{
		// Token: 0x06004177 RID: 16759 RVA: 0x000200A0 File Offset: 0x0001E2A0
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x1F05D40", Offset = "0x1F05D40", VA = "0x1F05D40")]
		public static bool IsValid(int gameMode)
		{
			return default(bool);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x1F05D54", Offset = "0x1F05D54", VA = "0x1F05D54")]
		public GameModeID()
		{
		}

		// Token: 0x040057EF RID: 22511
		[Token(Token = "0x40057EF")]
		public const short Normal = 0;

		// Token: 0x040057F0 RID: 22512
		[Token(Token = "0x40057F0")]
		public const short Expert = 1;

		// Token: 0x040057F1 RID: 22513
		[Token(Token = "0x40057F1")]
		public const short Master = 2;

		// Token: 0x040057F2 RID: 22514
		[Token(Token = "0x40057F2")]
		public const short Creative = 3;

		// Token: 0x040057F3 RID: 22515
		[Token(Token = "0x40057F3")]
		public const short Count = 4;
	}
}
