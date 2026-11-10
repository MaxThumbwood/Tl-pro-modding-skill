using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	public class RandomStyleInfo_OldMobile
	{
		// Token: 0x06003FFB RID: 16379 RVA: 0x0001F710 File Offset: 0x0001D910
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x1EB5F7C", Offset = "0x1EB5F7C", VA = "0x1EB5F7C")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x1EB60DC", Offset = "0x1EB60DC", VA = "0x1EB60DC")]
		public RandomStyleInfo_OldMobile()
		{
		}

		// Token: 0x04004B69 RID: 19305
		[Token(Token = "0x4004B69")]
		[FieldOffset(Offset = "0x8")]
		public byte[] style;

		// Token: 0x04004B6A RID: 19306
		[Token(Token = "0x4004B6A")]
		[FieldOffset(Offset = "0xC")]
		public ushort[] X;
	}
}
