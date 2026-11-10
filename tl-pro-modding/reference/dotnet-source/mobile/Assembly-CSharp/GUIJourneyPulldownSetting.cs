using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
public class GUIJourneyPulldownSetting : GUIPulldownSetting
{
	// Token: 0x06000C29 RID: 3113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0xC5A5E8", Offset = "0xC5A5E8", VA = "0xC5A5E8")]
	public GUIJourneyPulldownSetting(GUISettingID id)
	{
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0xC5A798", Offset = "0xC5A798", VA = "0xC5A798", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0xC5AA18", Offset = "0xC5AA18", VA = "0xC5AA18")]
	private static void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0xC5AAFC", Offset = "0xC5AAFC", VA = "0xC5AAFC")]
	private static void DeactivateOverlay()
	{
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0xC5AB98", Offset = "0xC5AB98", VA = "0xC5AB98")]
	private static void RegisterOverlayJM(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x04000F12 RID: 3858
	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x3C")]
	private float iconScale;
}
