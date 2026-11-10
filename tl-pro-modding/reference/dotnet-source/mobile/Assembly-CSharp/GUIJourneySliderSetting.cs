using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200019D RID: 413
[Token(Token = "0x200019D")]
public class GUIJourneySliderSetting : GUISliderSetting
{
	// Token: 0x06000C2E RID: 3118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0xC5AC58", Offset = "0xC5AC58", VA = "0xC5AC58")]
	public GUIJourneySliderSetting(GUISettingID id)
	{
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0xC5AD9C", Offset = "0xC5AD9C", VA = "0xC5AD9C")]
	public void WindBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0xC5BF2C", Offset = "0xC5BF2C", VA = "0xC5BF2C")]
	public void RainBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0xC5CF20", Offset = "0xC5CF20", VA = "0xC5CF20")]
	public void DifficultyBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0xC5E3B0", Offset = "0xC5E3B0", VA = "0xC5E3B0", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0xC5E4FC", Offset = "0xC5E4FC", VA = "0xC5E4FC", Slot = "7")]
	protected override SettingsOverlaySlider_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x28")]
	private DateTime lastShown;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x0")]
	private static GUIJourneySliderSetting.ColorFadeBackup fadeSettings;

	// Token: 0x04000F15 RID: 3861
	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x30")]
	private float iconScale;

	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	public struct ColorFadeBackup
	{
		// Token: 0x06000C35 RID: 3125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0xC5BD84", Offset = "0xC5BD84", VA = "0xC5BD84")]
		public void ApplyFade(TransactionButton_Layout layout, float fadeAmount)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0xC5BEC0", Offset = "0xC5BEC0", VA = "0xC5BEC0")]
		public void RestoreFade(TransactionButton_Layout layout)
		{
		}

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x0")]
		private Color IconColour;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x4")]
		private Color PressedIconColour;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x8")]
		private Color LabelColor;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0xC")]
		private Color PressedLabelColor;
	}
}
