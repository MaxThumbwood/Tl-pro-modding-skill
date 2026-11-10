using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	public sealed class SpriteFont
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public SpriteFont.Glyph[] Glyphs
		{
			[Token(Token = "0x6001CA9")]
			[Address(RVA = "0xE8C7A0", Offset = "0xE8C7A0", VA = "0xE8C7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0xE8C7A8", Offset = "0xE8C7A8", VA = "0xE8C7A8")]
		public SpriteFont()
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0xE8C814", Offset = "0xE8C814", VA = "0xE8C814")]
		public SpriteFont(Texture2D[] textures, SpriteFont.Glyph[] glyphs, int lineSpacing, float spacing, char? defaultCharacter)
		{
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public Texture2D[] Textures
		{
			[Token(Token = "0x6001CAC")]
			[Address(RVA = "0xE8CB18", Offset = "0xE8CB18", VA = "0xE8CB18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0xE8CB20", Offset = "0xE8CB20", VA = "0xE8CB20")]
		public Dictionary<char, SpriteFont.Glyph> GetGlyphs()
		{
			return null;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0000D620 File Offset: 0x0000B820
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000363")]
		public char? DefaultCharacter
		{
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0xE8CD24", Offset = "0xE8CD24", VA = "0xE8CD24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CAF")]
			[Address(RVA = "0xE8CA68", Offset = "0xE8CA68", VA = "0xE8CA68")]
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0000D638 File Offset: 0x0000B838
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000364")]
		public int LineSpacing
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0xE8CD2C", Offset = "0xE8CD2C", VA = "0xE8CD2C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0xE8CD34", Offset = "0xE8CD34", VA = "0xE8CD34")]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0000D650 File Offset: 0x0000B850
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000365")]
		public float Spacing
		{
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0xE8CD3C", Offset = "0xE8CD3C", VA = "0xE8CD3C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001CB3")]
			[Address(RVA = "0xE8CD44", Offset = "0xE8CD44", VA = "0xE8CD44")]
			set
			{
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0xE8CD4C", Offset = "0xE8CD4C", VA = "0xE8CD4C")]
		public Vector2 MeasureString(string text)
		{
			return default(Vector2);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0xE8D318", Offset = "0xE8D318", VA = "0xE8D318")]
		public int GetMaxCharacterIndex(string text, int startIndex, int endIndex, float scale, float maxWidth)
		{
			return 0;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0xE8D8B8", Offset = "0xE8D8B8", VA = "0xE8D8B8")]
		public Vector2 MeasureString(ref SpriteFont.CharacterSource text, int startIndex, int endIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0xE8D948", Offset = "0xE8D948", VA = "0xE8D948")]
		public Vector2 MeasureString(string text, int startIndex, int endIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0xE8D998", Offset = "0xE8D998", VA = "0xE8D998")]
		public Vector2 MeasureString(StringBuilder text, int startIndex, int endIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0xE8DA10", Offset = "0xE8DA10", VA = "0xE8DA10")]
		public Vector2 MeasureString(StringBuilder text)
		{
			return default(Vector2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0xE8D384", Offset = "0xE8D384", VA = "0xE8D384")]
		internal void MeasureMaxString(ref SpriteFont.CharacterSource text, out int lastCharacter, float maxWidth, float scale)
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0xE8CDE0", Offset = "0xE8CDE0", VA = "0xE8CDE0")]
		internal void MeasureString(ref SpriteFont.CharacterSource text, out Vector2 size)
		{
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0xE8DAC4", Offset = "0xE8DAC4", VA = "0xE8DAC4")]
		internal bool TryGetGlyphIndex(char c, out int index)
		{
			return default(bool);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0xE8DAE4", Offset = "0xE8DAE4", VA = "0xE8DAE4")]
		public bool HasCharacter(char c)
		{
			return default(bool);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0xE8DAB4", Offset = "0xE8DAB4", VA = "0xE8DAB4")]
		internal int GetGlyphIndexOrDefault(char c)
		{
			return 0;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0xE8DB00", Offset = "0xE8DB00", VA = "0xE8DB00")]
		public string CreateWrappedText(string text, float maxWidth)
		{
			return null;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0xE8DB54", Offset = "0xE8DB54", VA = "0xE8DB54")]
		public string CreateWrappedText(string text, float maxWidth, CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0xE8DC40", Offset = "0xE8DC40", VA = "0xE8DC40")]
		public SpriteFont.Glyph GetCharacterMetrics(char character)
		{
			return default(SpriteFont.Glyph);
		}

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x8")]
		private readonly SpriteFont.Glyph[] _glyphs;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0xC")]
		private ushort[] _glyphIndexTable;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x10")]
		private char? _defaultCharacter;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x14")]
		private int _defaultGlyphIndex;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x18")]
		private readonly Texture2D[] _textures;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x1C")]
		private int <LineSpacing>k__BackingField;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x20")]
		private float <Spacing>k__BackingField;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 tagSize;

		// Token: 0x0200040E RID: 1038
		[Token(Token = "0x200040E")]
		internal static class Errors
		{
			// Token: 0x04003055 RID: 12373
			[Token(Token = "0x4003055")]
			public const string TextContainsUnresolvableCharacters = "Text contains characters that cannot be resolved by this SpriteFont.";

			// Token: 0x04003056 RID: 12374
			[Token(Token = "0x4003056")]
			public const string UnresolvableCharacter = "Character cannot be resolved by this SpriteFont.";
		}

		// Token: 0x0200040F RID: 1039
		[Token(Token = "0x200040F")]
		private class CharComparer : FileAPI
		{
			// Token: 0x06001CC2 RID: 7362 RVA: 0x0000D758 File Offset: 0x0000B958
			[Token(Token = "0x6001CC2")]
			[Address(RVA = "0xE8DCA8", Offset = "0xE8DCA8", VA = "0xE8DCA8", Slot = "4")]
			public bool Equals(char x, char y)
			{
				return default(bool);
			}

			// Token: 0x06001CC3 RID: 7363 RVA: 0x0000D770 File Offset: 0x0000B970
			[Token(Token = "0x6001CC3")]
			[Address(RVA = "0xE8DCB8", Offset = "0xE8DCB8", VA = "0xE8DCB8", Slot = "5")]
			public int GetHashCode(char b)
			{
				return 0;
			}

			// Token: 0x06001CC4 RID: 7364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0xE8DCC0", Offset = "0xE8DCC0", VA = "0xE8DCC0")]
			public CharComparer()
			{
			}

			// Token: 0x04003057 RID: 12375
			[Token(Token = "0x4003057")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpriteFont.CharComparer Default;
		}

		// Token: 0x02000410 RID: 1040
		[Token(Token = "0x2000410")]
		public struct CharacterSource
		{
			// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0xE8CDAC", Offset = "0xE8CDAC", VA = "0xE8CDAC")]
			public CharacterSource(string s)
			{
			}

			// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0xE8D36C", Offset = "0xE8D36C", VA = "0xE8D36C")]
			public CharacterSource(string s, int startIndex, int endIndex)
			{
			}

			// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CC8")]
			[Address(RVA = "0xE8D91C", Offset = "0xE8D91C", VA = "0xE8D91C")]
			public CharacterSource(ref SpriteFont.CharacterSource s, int startIndex, int endIndex)
			{
			}

			// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0xE8DA7C", Offset = "0xE8DA7C", VA = "0xE8DA7C")]
			public CharacterSource(StringBuilder builder)
			{
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CCA")]
			[Address(RVA = "0xE8D9F0", Offset = "0xE8D9F0", VA = "0xE8D9F0")]
			public CharacterSource(StringBuilder builder, int startIndex, int endIndex)
			{
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x0000D788 File Offset: 0x0000B988
			[Token(Token = "0x17000366")]
			public char Item
			{
				[Token(Token = "0x6001CCB")]
				[Address(RVA = "0xE8DD3C", Offset = "0xE8DD3C", VA = "0xE8DD3C")]
				[MethodImpl(256)]
				get
				{
					return '\0';
				}
			}

			// Token: 0x04003058 RID: 12376
			[Token(Token = "0x4003058")]
			[FieldOffset(Offset = "0x0")]
			private readonly string _string;

			// Token: 0x04003059 RID: 12377
			[Token(Token = "0x4003059")]
			[FieldOffset(Offset = "0x4")]
			private readonly int _stringOffset;

			// Token: 0x0400305A RID: 12378
			[Token(Token = "0x400305A")]
			[FieldOffset(Offset = "0x8")]
			private readonly StringBuilder _builder;

			// Token: 0x0400305B RID: 12379
			[Token(Token = "0x400305B")]
			[FieldOffset(Offset = "0xC")]
			public readonly int Length;
		}

		// Token: 0x02000411 RID: 1041
		[Token(Token = "0x2000411")]
		public struct Glyph
		{
			// Token: 0x06001CCC RID: 7372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001CCC")]
			[Address(RVA = "0xE8DD90", Offset = "0xE8DD90", VA = "0xE8DD90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400305C RID: 12380
			[Token(Token = "0x400305C")]
			[FieldOffset(Offset = "0x0")]
			public char Character;

			// Token: 0x0400305D RID: 12381
			[Token(Token = "0x400305D")]
			[FieldOffset(Offset = "0x4")]
			public Rectangle BoundsInTexture;

			// Token: 0x0400305E RID: 12382
			[Token(Token = "0x400305E")]
			[FieldOffset(Offset = "0x14")]
			public Rectangle Cropping;

			// Token: 0x0400305F RID: 12383
			[Token(Token = "0x400305F")]
			[FieldOffset(Offset = "0x24")]
			public float LeftSideBearing;

			// Token: 0x04003060 RID: 12384
			[Token(Token = "0x4003060")]
			[FieldOffset(Offset = "0x28")]
			public float RightSideBearing;

			// Token: 0x04003061 RID: 12385
			[Token(Token = "0x4003061")]
			[FieldOffset(Offset = "0x2C")]
			public float Width;

			// Token: 0x04003062 RID: 12386
			[Token(Token = "0x4003062")]
			[FieldOffset(Offset = "0x30")]
			public float WidthIncludingBearings;

			// Token: 0x04003063 RID: 12387
			[Token(Token = "0x4003063")]
			[FieldOffset(Offset = "0x34")]
			public byte TexureIndex;

			// Token: 0x04003064 RID: 12388
			[Token(Token = "0x4003064")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpriteFont.Glyph Empty;
		}

		// Token: 0x02000412 RID: 1042
		[Token(Token = "0x2000412")]
		private struct CharacterRegion
		{
			// Token: 0x06001CCE RID: 7374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CCE")]
			[Address(RVA = "0xE8E1D8", Offset = "0xE8E1D8", VA = "0xE8E1D8")]
			public CharacterRegion(char start, int startIndex)
			{
			}

			// Token: 0x04003065 RID: 12389
			[Token(Token = "0x4003065")]
			[FieldOffset(Offset = "0x0")]
			public char Start;

			// Token: 0x04003066 RID: 12390
			[Token(Token = "0x4003066")]
			[FieldOffset(Offset = "0x2")]
			public char End;

			// Token: 0x04003067 RID: 12391
			[Token(Token = "0x4003067")]
			[FieldOffset(Offset = "0x4")]
			public int StartIndex;
		}
	}
}
