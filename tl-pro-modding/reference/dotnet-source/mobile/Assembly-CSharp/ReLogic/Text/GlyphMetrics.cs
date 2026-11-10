using System;
using Il2CppDummyDll;

namespace ReLogic.Text
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000DDD")]
	public struct GlyphMetrics
	{
		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06006863 RID: 26723 RVA: 0x0002F748 File Offset: 0x0002D948
		[Token(Token = "0x17000B1F")]
		public float KernedWidth
		{
			[Token(Token = "0x6006863")]
			[Address(RVA = "0xB7DD64", Offset = "0xB7DD64", VA = "0xB7DD64")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06006864 RID: 26724 RVA: 0x0002F760 File Offset: 0x0002D960
		[Token(Token = "0x17000B20")]
		public float KernedWidthOnNewLine
		{
			[Token(Token = "0x6006864")]
			[Address(RVA = "0xB7DD80", Offset = "0xB7DD80", VA = "0xB7DD80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006865")]
		[Address(RVA = "0xB7DE10", Offset = "0xB7DE10", VA = "0xB7DE10")]
		private GlyphMetrics(float leftPadding, float characterWidth, float rightPadding)
		{
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x0002F778 File Offset: 0x0002D978
		[Token(Token = "0x6006866")]
		[Address(RVA = "0xB7DE18", Offset = "0xB7DE18", VA = "0xB7DE18")]
		public static GlyphMetrics FromKerningData(float leftPadding, float characterWidth, float rightPadding)
		{
			return default(GlyphMetrics);
		}

		// Token: 0x0400A4D6 RID: 42198
		[Token(Token = "0x400A4D6")]
		[FieldOffset(Offset = "0x0")]
		public readonly float LeftPadding;

		// Token: 0x0400A4D7 RID: 42199
		[Token(Token = "0x400A4D7")]
		[FieldOffset(Offset = "0x4")]
		public readonly float CharacterWidth;

		// Token: 0x0400A4D8 RID: 42200
		[Token(Token = "0x400A4D8")]
		[FieldOffset(Offset = "0x8")]
		public readonly float RightPadding;
	}
}
