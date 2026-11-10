using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DA5 RID: 3493
	[Token(Token = "0x2000DA5")]
	public class ColorTagHandler : FileAPI
	{
		// Token: 0x06006708 RID: 26376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006708")]
		[Address(RVA = "0xB6A1C8", Offset = "0xB6A1C8", VA = "0xB6A1C8", Slot = "4")]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			return null;
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		[Token(Token = "0x6006709")]
		[Address(RVA = "0xB6A2E4", Offset = "0xB6A2E4", VA = "0xB6A2E4")]
		private static int HexCharToNibble(char val)
		{
			return 0;
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		[Token(Token = "0x600670A")]
		[Address(RVA = "0xB6A320", Offset = "0xB6A320", VA = "0xB6A320")]
		private static int HexCharsToByte(ref SpriteFont.CharacterSource text, int offset)
		{
			return 0;
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
		[Token(Token = "0x600670B")]
		[Address(RVA = "0xB6A434", Offset = "0xB6A434", VA = "0xB6A434")]
		public static bool ParseInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Color newColor, ref Color defaultColor)
		{
			return default(bool);
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600670C")]
		[Address(RVA = "0xB6A90C", Offset = "0xB6A90C", VA = "0xB6A90C")]
		public ColorTagHandler()
		{
		}

		// Token: 0x0400A420 RID: 42016
		[Token(Token = "0x400A420")]
		[FieldOffset(Offset = "0x0")]
		public static bool Shadow;
	}
}
