using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	public class TextSnippet
	{
		// Token: 0x06004B27 RID: 19239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x64CC4C", Offset = "0x64CC4C", VA = "0x64CC4C")]
		public TextSnippet(string text = "")
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x64CCD8", Offset = "0x64CCD8", VA = "0x64CCD8")]
		public TextSnippet(string text, Color color, float scale = 1f)
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x64CF1C", Offset = "0x64CF1C", VA = "0x64CF1C", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x64CF20", Offset = "0x64CF20", VA = "0x64CF20", Slot = "5")]
		public virtual void OnHover()
		{
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x64CF24", Offset = "0x64CF24", VA = "0x64CF24", Slot = "6")]
		public virtual void OnClick()
		{
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00023B38 File Offset: 0x00021D38
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x64CF28", Offset = "0x64CF28", VA = "0x64CF28", Slot = "7")]
		public virtual Color GetVisibleColor()
		{
			return default(Color);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x00023B50 File Offset: 0x00021D50
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x64D010", Offset = "0x64D010", VA = "0x64D010", Slot = "8")]
		public virtual bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x64D0CC", Offset = "0x64D0CC", VA = "0x64D0CC", Slot = "9")]
		public virtual TextSnippet CopyMorph(string newText)
		{
			return null;
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00023B68 File Offset: 0x00021D68
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x64D160", Offset = "0x64D160", VA = "0x64D160", Slot = "10")]
		public virtual float GetStringLength(SpriteFont font)
		{
			return 0f;
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x64D1AC", Offset = "0x64D1AC", VA = "0x64D1AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04009045 RID: 36933
		[Token(Token = "0x4009045")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		// Token: 0x04009046 RID: 36934
		[Token(Token = "0x4009046")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string TextOriginal;

		// Token: 0x04009047 RID: 36935
		[Token(Token = "0x4009047")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color Color;

		// Token: 0x04009048 RID: 36936
		[Token(Token = "0x4009048")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Scale;

		// Token: 0x04009049 RID: 36937
		[Token(Token = "0x4009049")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool CheckForHover;

		// Token: 0x0400904A RID: 36938
		[Token(Token = "0x400904A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool DeleteWhole;

		// Token: 0x0400904B RID: 36939
		[Token(Token = "0x400904B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool UseRawColor;
	}
}
