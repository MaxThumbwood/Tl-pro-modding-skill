using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	public class SpriteBatchItemList
	{
		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0xE8C798", Offset = "0xE8C798", VA = "0xE8C798")]
		public SpriteBatchItemList()
		{
		}

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x8")]
		public SpriteBatchItem First;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0xC")]
		public SpriteBatchItem Last;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x10")]
		public int BatchKey;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x14")]
		public SpriteBatchItemList NextDictionaryEntry;
	}
}
