using System;
using System.Globalization;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Text
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x2000DE1")]
	public class WrappedTextBuilder
	{
		// Token: 0x0600686B RID: 26731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686B")]
		[Address(RVA = "0xB7DE4C", Offset = "0xB7DE4C", VA = "0xB7DE4C")]
		public WrappedTextBuilder(SpriteFont font, float maxWidth, CultureInfo culture)
		{
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686C")]
		[Address(RVA = "0xB7DF1C", Offset = "0xB7DF1C", VA = "0xB7DF1C")]
		public void CommitWorkingLine()
		{
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686D")]
		[Address(RVA = "0xB7DFB4", Offset = "0xB7DFB4", VA = "0xB7DFB4")]
		private void Append(WrappedTextBuilder.NonBreakingText textToken)
		{
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686E")]
		[Address(RVA = "0xB7E3D0", Offset = "0xB7E3D0", VA = "0xB7E3D0")]
		public void Append(string text)
		{
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686F")]
		[Address(RVA = "0xB7E9A8", Offset = "0xB7E9A8", VA = "0xB7E9A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400A4D9 RID: 42201
		[Token(Token = "0x400A4D9")]
		[FieldOffset(Offset = "0x8")]
		private readonly SpriteFont _font;

		// Token: 0x0400A4DA RID: 42202
		[Token(Token = "0x400A4DA")]
		[FieldOffset(Offset = "0xC")]
		private readonly CultureInfo _culture;

		// Token: 0x0400A4DB RID: 42203
		[Token(Token = "0x400A4DB")]
		[FieldOffset(Offset = "0x10")]
		private readonly float _maxWidth;

		// Token: 0x0400A4DC RID: 42204
		[Token(Token = "0x400A4DC")]
		[FieldOffset(Offset = "0x14")]
		private readonly StringBuilder _completedText;

		// Token: 0x0400A4DD RID: 42205
		[Token(Token = "0x400A4DD")]
		[FieldOffset(Offset = "0x18")]
		private readonly StringBuilder _workingLine;

		// Token: 0x0400A4DE RID: 42206
		[Token(Token = "0x400A4DE")]
		[FieldOffset(Offset = "0x1C")]
		private float _workingLineWidth;

		// Token: 0x02000DE2 RID: 3554
		[Token(Token = "0x2000DE2")]
		private struct NonBreakingText
		{
			// Token: 0x06006870 RID: 26736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006870")]
			[Address(RVA = "0xB7E83C", Offset = "0xB7E83C", VA = "0xB7E83C")]
			public NonBreakingText(SpriteFont font, string text)
			{
			}

			// Token: 0x06006871 RID: 26737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006871")]
			[Address(RVA = "0xB7E188", Offset = "0xB7E188", VA = "0xB7E188")]
			public string GetAsWrappedText(float maxWidth)
			{
				return null;
			}

			// Token: 0x0400A4DF RID: 42207
			[Token(Token = "0x400A4DF")]
			[FieldOffset(Offset = "0x0")]
			public readonly string Text;

			// Token: 0x0400A4E0 RID: 42208
			[Token(Token = "0x400A4E0")]
			[FieldOffset(Offset = "0x4")]
			public readonly float Width;

			// Token: 0x0400A4E1 RID: 42209
			[Token(Token = "0x400A4E1")]
			[FieldOffset(Offset = "0x8")]
			public readonly float WidthOnNewLine;

			// Token: 0x0400A4E2 RID: 42210
			[Token(Token = "0x400A4E2")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool IsWhitespace;

			// Token: 0x0400A4E3 RID: 42211
			[Token(Token = "0x400A4E3")]
			[FieldOffset(Offset = "0x10")]
			private readonly SpriteFont _font;
		}
	}
}
