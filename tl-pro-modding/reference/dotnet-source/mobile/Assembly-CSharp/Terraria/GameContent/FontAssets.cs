using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x0200097A RID: 2426
	[Token(Token = "0x200097A")]
	public static class FontAssets
	{
		// Token: 0x04009421 RID: 37921
		[Token(Token = "0x4009421")]
		[FieldOffset(Offset = "0x0")]
		public static Asset<SpriteFont> ItemStack;

		// Token: 0x04009422 RID: 37922
		[Token(Token = "0x4009422")]
		[FieldOffset(Offset = "0x4")]
		public static Asset<SpriteFont> MouseText;

		// Token: 0x04009423 RID: 37923
		[Token(Token = "0x4009423")]
		[FieldOffset(Offset = "0x8")]
		public static Asset<SpriteFont> DeathText;

		// Token: 0x04009424 RID: 37924
		[Token(Token = "0x4009424")]
		[FieldOffset(Offset = "0xC")]
		public static Asset<SpriteFont>[] CombatText;
	}
}
