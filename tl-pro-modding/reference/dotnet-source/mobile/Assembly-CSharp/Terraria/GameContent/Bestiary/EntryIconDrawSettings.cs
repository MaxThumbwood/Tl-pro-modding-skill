using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF4 RID: 3060
	[Token(Token = "0x2000BF4")]
	public struct EntryIconDrawSettings
	{
		// Token: 0x04009CF5 RID: 40181
		[Token(Token = "0x4009CF5")]
		[FieldOffset(Offset = "0x0")]
		public bool IsPortrait;

		// Token: 0x04009CF6 RID: 40182
		[Token(Token = "0x4009CF6")]
		[FieldOffset(Offset = "0x1")]
		public bool IsHovered;

		// Token: 0x04009CF7 RID: 40183
		[Token(Token = "0x4009CF7")]
		[FieldOffset(Offset = "0x4")]
		public Rectangle iconbox;
	}
}
