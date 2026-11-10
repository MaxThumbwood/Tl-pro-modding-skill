using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DA6 RID: 3494
	[Token(Token = "0x2000DA6")]
	public class GlyphTagHandler : FileAPI
	{
		// Token: 0x0600670D RID: 26381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670D")]
		[Address(RVA = "0xB6A914", Offset = "0xB6A914", VA = "0xB6A914", Slot = "4")]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			return null;
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670E")]
		[Address(RVA = "0xB6AB88", Offset = "0xB6AB88", VA = "0xB6AB88")]
		public static string GenerateTag(int index)
		{
			return null;
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670F")]
		[Address(RVA = "0xB6AC38", Offset = "0xB6AC38", VA = "0xB6AC38")]
		public static string GenerateTag(string keyname)
		{
			return null;
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006710")]
		[Address(RVA = "0xB6ADB4", Offset = "0xB6ADB4", VA = "0xB6ADB4")]
		public GlyphTagHandler()
		{
		}

		// Token: 0x0400A421 RID: 42017
		[Token(Token = "0x400A421")]
		private const int GlyphsPerLine = 25;

		// Token: 0x0400A422 RID: 42018
		[Token(Token = "0x400A422")]
		private const int MaxGlyphs = 26;

		// Token: 0x0400A423 RID: 42019
		[Token(Token = "0x400A423")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float GlyphsScale;

		// Token: 0x0400A424 RID: 42020
		[Token(Token = "0x400A424")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Dictionary<string, int> GlyphIndexes;

		// Token: 0x02000DA7 RID: 3495
		[Token(Token = "0x2000DA7")]
		private class GlyphSnippet : TextSnippet
		{
			// Token: 0x06006712 RID: 26386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006712")]
			[Address(RVA = "0xB6AAE8", Offset = "0xB6AAE8", VA = "0xB6AAE8")]
			public GlyphSnippet(int index)
			{
			}

			// Token: 0x06006713 RID: 26387 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
			[Token(Token = "0x6006713")]
			[Address(RVA = "0xB6B5D0", Offset = "0xB6B5D0", VA = "0xB6B5D0", Slot = "8")]
			public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
			{
				return default(bool);
			}

			// Token: 0x06006714 RID: 26388 RVA: 0x0002E800 File Offset: 0x0002CA00
			[Token(Token = "0x6006714")]
			[Address(RVA = "0xB6B9D0", Offset = "0xB6B9D0", VA = "0xB6B9D0", Slot = "10")]
			public override float GetStringLength(SpriteFont font)
			{
				return 0f;
			}

			// Token: 0x0400A425 RID: 42021
			[Token(Token = "0x400A425")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _glyphIndex;
		}
	}
}
