using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	internal sealed class FontPage
	{
		// Token: 0x06006904 RID: 26884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006904")]
		[Address(RVA = "0xB84730", Offset = "0xB84730", VA = "0xB84730")]
		public FontPage(Texture2D texture, List<Rectangle> glyphs, List<Rectangle> padding, List<char> characters, List<Vector3> kerning)
		{
		}

		// Token: 0x0400A6CF RID: 42703
		[Token(Token = "0x400A6CF")]
		[FieldOffset(Offset = "0x8")]
		public readonly Texture2D Texture;

		// Token: 0x0400A6D0 RID: 42704
		[Token(Token = "0x400A6D0")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<Rectangle> Glyphs;

		// Token: 0x0400A6D1 RID: 42705
		[Token(Token = "0x400A6D1")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<Rectangle> Padding;

		// Token: 0x0400A6D2 RID: 42706
		[Token(Token = "0x400A6D2")]
		[FieldOffset(Offset = "0x14")]
		public readonly List<char> Characters;

		// Token: 0x0400A6D3 RID: 42707
		[Token(Token = "0x400A6D3")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<Vector3> Kerning;
	}
}
