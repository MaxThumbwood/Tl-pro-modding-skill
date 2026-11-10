using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class ControlsTouchTagHandler : FileAPI
{
	// Token: 0x06000712 RID: 1810 RVA: 0x00004CC8 File Offset: 0x00002EC8
	[Token(Token = "0x6000712")]
	[Address(RVA = "0xF345F0", Offset = "0xF345F0", VA = "0xF345F0")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00004CE0 File Offset: 0x00002EE0
	[Token(Token = "0x6000713")]
	[Address(RVA = "0xF34D84", Offset = "0xF34D84", VA = "0xF34D84")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000714")]
	[Address(RVA = "0xF354D8", Offset = "0xF354D8", VA = "0xF354D8", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000715")]
	[Address(RVA = "0xF3559C", Offset = "0xF3559C", VA = "0xF3559C")]
	public ControlsTouchTagHandler()
	{
	}

	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	public class ControlsTouchSnippet : TextSnippet
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1284A34", Offset = "0x1284A34", VA = "0x1284A34")]
		public ControlsTouchSnippet(int controlType, int itemId)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1284ADC", Offset = "0x1284ADC", VA = "0x1284ADC")]
		public static bool Draw(int touchControl, int itemId, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1288B9C", Offset = "0x1288B9C", VA = "0x1288B9C", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1288BF0", Offset = "0x1288BF0", VA = "0x1288BF0", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return 0f;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1288BFC", Offset = "0x1288BFC", VA = "0x1288BFC")]
		public static Vector2 GetSize(int touchControl)
		{
			return default(Vector2);
		}

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _controlType;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _itemId;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool OpenButtonFromEquipment;
	}
}
