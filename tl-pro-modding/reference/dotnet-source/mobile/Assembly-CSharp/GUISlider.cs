using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000128 RID: 296
[Token(Token = "0x2000128")]
public static class GUISlider
{
	// Token: 0x06000787 RID: 1927 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x167E9B0", Offset = "0x167E9B0", VA = "0x167E9B0")]
	public static Rectangle GetRegion(Slider_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x167EBCC", Offset = "0x167EBCC", VA = "0x167EBCC")]
	public static void DrawSaturationSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x167F11C", Offset = "0x167F11C", VA = "0x167F11C")]
	public static void DrawLightnessSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x167F66C", Offset = "0x167F66C", VA = "0x167F66C")]
	public static void DrawVoiceSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x167FD94", Offset = "0x167FD94", VA = "0x167FD94")]
	public static bool DrawSaturation(Slider_Layout layout, bool disablePick, ref float value, GUISlider.DragState dragState, bool forceOver = false)
	{
		return default(bool);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x168276C", Offset = "0x168276C", VA = "0x168276C")]
	public static bool DrawLightness(Slider_Layout layout, bool disablePick, ref float value, GUISlider.DragState dragState, bool forceOver = false)
	{
		return default(bool);
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000050E8 File Offset: 0x000032E8
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x168283C", Offset = "0x168283C", VA = "0x168283C")]
	public static bool DrawVoice(Slider_Layout layout, bool disablePick, ref float value, GUISlider.DragState dragState, bool forceOver = false)
	{
		return default(bool);
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x168290C", Offset = "0x168290C", VA = "0x168290C")]
	public static bool IsCursorOver(Vector2 cursorPosition, Slider_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x1682B6C", Offset = "0x1682B6C", VA = "0x1682B6C")]
	public static float QuantiseValue(float input, int stepCount)
	{
		return 0f;
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00005130 File Offset: 0x00003330
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x1682BB8", Offset = "0x1682BB8", VA = "0x1682BB8")]
	public static float CalculateValue(int input, int minValue, int maxValue)
	{
		return 0f;
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x1682BF8", Offset = "0x1682BF8", VA = "0x1682BF8")]
	public static int ScaleValue(float input, int minValue, int maxValue)
	{
		return 0;
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x167FF40", Offset = "0x167FF40", VA = "0x167FF40")]
	public static bool Draw(Slider_Layout layout, bool disablePick, ref float value, GUISlider.DragState dragState, [Optional] GUISlider.DrawBackingHandler backingHandler, bool forceOver = false, int minValue = -1, int maxValue = -1, bool ignoreStartPoint = false)
	{
		return default(bool);
	}

	// Token: 0x02000129 RID: 297
	// (Invoke) Token: 0x06000794 RID: 1940
	[Token(Token = "0x2000129")]
	public delegate void DrawBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver);

	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public class DragState
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1682D74", Offset = "0x1682D74", VA = "0x1682D74")]
		public DragState()
		{
		}

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool wasDragging;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float dragDir;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float dragStart;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float dragTime;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 dragStartPoint;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dragScreenScale;
	}
}
