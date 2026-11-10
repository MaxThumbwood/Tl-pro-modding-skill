using System;
using Il2CppDummyDll;
using Terraria.Enums;

namespace Terraria.DataStructures
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	public struct AnchorData
	{
		// Token: 0x06004220 RID: 16928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x4EDD94", Offset = "0x4EDD94", VA = "0x4EDD94")]
		public AnchorData(AnchorType type, int count, int start)
		{
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x000202B0 File Offset: 0x0001E4B0
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x4EDD9C", Offset = "0x4EDD9C", VA = "0x4EDD9C")]
		public static bool operator ==(AnchorData data1, AnchorData data2)
		{
			return default(bool);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x000202C8 File Offset: 0x0001E4C8
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x4EDDC8", Offset = "0x4EDDC8", VA = "0x4EDDC8")]
		public static bool operator !=(AnchorData data1, AnchorData data2)
		{
			return default(bool);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x000202E0 File Offset: 0x0001E4E0
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x4EDDF0", Offset = "0x4EDDF0", VA = "0x4EDDF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x000202F8 File Offset: 0x0001E4F8
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x4EDEE0", Offset = "0x4EDEE0", VA = "0x4EDEE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040089EB RID: 35307
		[Token(Token = "0x40089EB")]
		[FieldOffset(Offset = "0x0")]
		public AnchorType type;

		// Token: 0x040089EC RID: 35308
		[Token(Token = "0x40089EC")]
		[FieldOffset(Offset = "0x4")]
		public int tileCount;

		// Token: 0x040089ED RID: 35309
		[Token(Token = "0x40089ED")]
		[FieldOffset(Offset = "0x8")]
		public int checkStart;

		// Token: 0x040089EE RID: 35310
		[Token(Token = "0x40089EE")]
		[FieldOffset(Offset = "0x0")]
		public static AnchorData Empty;
	}
}
