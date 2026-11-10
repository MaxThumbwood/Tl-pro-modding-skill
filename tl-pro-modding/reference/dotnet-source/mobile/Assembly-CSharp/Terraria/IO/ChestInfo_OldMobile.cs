using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class ChestInfo_OldMobile
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x1E8ADB8", Offset = "0x1E8ADB8", VA = "0x1E8ADB8")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x1E8B798", Offset = "0x1E8B798", VA = "0x1E8B798")]
		private void FixDresserChests()
		{
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x1E8BB30", Offset = "0x1E8BB30", VA = "0x1E8BB30")]
		public ChestInfo_OldMobile()
		{
		}

		// Token: 0x0400499C RID: 18844
		[Token(Token = "0x400499C")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] bits;
	}
}
