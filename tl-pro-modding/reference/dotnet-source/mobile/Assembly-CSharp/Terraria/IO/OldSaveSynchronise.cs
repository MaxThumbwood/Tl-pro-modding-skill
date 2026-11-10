using System;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class OldSaveSynchronise
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		private static string OldSaveRoot
		{
			[Token(Token = "0x6003FF1")]
			[Address(RVA = "0x1E8F280", Offset = "0x1E8F280", VA = "0x1E8F280")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x1E8F54C", Offset = "0x1E8F54C", VA = "0x1E8F54C")]
		public static void CopyOldSaves()
		{
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x1E90114", Offset = "0x1E90114", VA = "0x1E90114")]
		public OldSaveSynchronise()
		{
		}

		// Token: 0x04004B4F RID: 19279
		[Token(Token = "0x4004B4F")]
		[FieldOffset(Offset = "0x0")]
		private static string _oldSaveRoot;
	}
}
