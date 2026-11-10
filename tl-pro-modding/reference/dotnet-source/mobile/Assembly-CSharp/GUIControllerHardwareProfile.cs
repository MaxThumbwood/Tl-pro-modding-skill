using System;
using System.Collections.Generic;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class GUIControllerHardwareProfile
{
	// Token: 0x060004B7 RID: 1207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xE56E08", Offset = "0xE56E08", VA = "0xE56E08")]
	public static void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xE56F0C", Offset = "0xE56F0C", VA = "0xE56F0C")]
	public static void SetControllerFace(ControllerDevice.ControlScheme scheme)
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xE56F74", Offset = "0xE56F74", VA = "0xE56F74")]
	public static void Draw()
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xE57AF4", Offset = "0xE57AF4", VA = "0xE57AF4")]
	public static void Close()
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xE58A8C", Offset = "0xE58A8C", VA = "0xE58A8C")]
	public static void UpdateAndSaveCurrentProfile()
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xE58550", Offset = "0xE58550", VA = "0xE58550")]
	private static void DrawMainButtons()
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xE58228", Offset = "0xE58228", VA = "0xE58228")]
	private static void DrawTitle()
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xE57EC4", Offset = "0xE57EC4", VA = "0xE57EC4")]
	private static void DrawBacking()
	{
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xE57F54", Offset = "0xE57F54", VA = "0xE57F54")]
	private static void DrawCategoryOptions()
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xE59284", Offset = "0xE59284", VA = "0xE59284")]
	private static float SettingScale(int index)
	{
		return 0f;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xE5928C", Offset = "0xE5928C", VA = "0xE5928C")]
	private static void SettingOver(int index)
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xE59290", Offset = "0xE59290", VA = "0xE59290")]
	private static void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xE5949C", Offset = "0xE5949C", VA = "0xE5949C")]
	private static Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xE57B60", Offset = "0xE57B60", VA = "0xE57B60")]
	public static void Open(ControllerDevice device)
	{
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xE599D8", Offset = "0xE599D8", VA = "0xE599D8")]
	public GUIControllerHardwareProfile()
	{
	}

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x0")]
	private static GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x4")]
	private static Rectangle overlayRegion;

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x14")]
	public static bool Enabled;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x15")]
	private static bool performingBinding;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x18")]
	private static float TimeSinceItemChange;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x1C")]
	private static float GameplayButtonScale;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x20")]
	private static float UIButtonScale;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x24")]
	private static float SaveAndCloseButtonScale;

	// Token: 0x040006B2 RID: 1714
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x28")]
	private static float ResetSettingsButtonScale;

	// Token: 0x040006B3 RID: 1715
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x2C")]
	private static float titleScale;

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x30")]
	public static float ScrollOffset;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x34")]
	private static float ScrollMomentum;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x38")]
	private static int ScrollDragging;

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x3C")]
	private static Vector2 DragOffset;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x44")]
	public static List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x48")]
	private static bool hasFocus;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x4C")]
	private static GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x50")]
	public static ControllerDevice.ControlScheme ActiveScheme;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x54")]
	public static ControllerDevice CurrentDevice;
}
