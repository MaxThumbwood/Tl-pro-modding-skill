using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	public class SpriteBatchItemList_Cloud
	{
		// Token: 0x06001A5F RID: 6751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0xE3715C", Offset = "0xE3715C", VA = "0xE3715C")]
		public SpriteBatchItemList_Cloud()
		{
		}

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x8")]
		public SpriteBatchItem_Cloud First;

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0xC")]
		public SpriteBatchItem_Cloud Last;

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x10")]
		public int BatchKey;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x14")]
		public SpriteBatchItemList_Cloud NextDictionaryEntry;
	}
}
