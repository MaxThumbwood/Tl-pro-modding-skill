using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009EE RID: 2542
	[Token(Token = "0x20009EE")]
	public class ContentRejectionFromSize : FileAPI
	{
		// Token: 0x060052BC RID: 21180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x7E3A50", Offset = "0x7E3A50", VA = "0x7E3A50")]
		public ContentRejectionFromSize(int neededWidth, int neededHeight, int actualWidth, int actualHeight)
		{
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x7E3B40", Offset = "0x7E3B40", VA = "0x7E3B40", Slot = "4")]
		public string GetReason()
		{
			return null;
		}

		// Token: 0x040096F9 RID: 38649
		[Token(Token = "0x40096F9")]
		[FieldOffset(Offset = "0x8")]
		private int _neededWidth;

		// Token: 0x040096FA RID: 38650
		[Token(Token = "0x40096FA")]
		[FieldOffset(Offset = "0xC")]
		private int _neededHeight;

		// Token: 0x040096FB RID: 38651
		[Token(Token = "0x40096FB")]
		[FieldOffset(Offset = "0x10")]
		private int _actualWidth;

		// Token: 0x040096FC RID: 38652
		[Token(Token = "0x40096FC")]
		[FieldOffset(Offset = "0x14")]
		private int _actualHeight;
	}
}
