using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class ControlsAxisTagHandler : FileAPI
{
	// Token: 0x060006F0 RID: 1776 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0xF2D02C", Offset = "0xF2D02C", VA = "0xF2D02C")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00004B00 File Offset: 0x00002D00
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0xF2D474", Offset = "0xF2D474", VA = "0xF2D474")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0xF2DBD4", Offset = "0xF2DBD4", VA = "0xF2DBD4", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0xF2DC98", Offset = "0xF2DC98", VA = "0xF2DC98")]
	public ControlsAxisTagHandler()
	{
	}

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float AxisControlSize;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool RightSideAdjustment;

	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public class ControlsAxisSnippet : TextSnippet
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xF2DD00", Offset = "0xF2DD00", VA = "0xF2DD00")]
		public ControlsAxisSnippet(GUIControllerInputButton.AxisControl axisControl)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xF2D9D8", Offset = "0xF2D9D8", VA = "0xF2D9D8")]
		public static bool Draw(GUIControllerInputButton.AxisControl axisControl, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xF2DDA0", Offset = "0xF2DDA0", VA = "0xF2DDA0", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xF2DDDC", Offset = "0xF2DDDC", VA = "0xF2DDDC", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return 0f;
		}

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly GUIControllerInputButton.AxisControl _axisControl;
	}
}
