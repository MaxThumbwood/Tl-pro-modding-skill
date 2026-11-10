using System;
using Il2CppDummyDll;

// Token: 0x0200019B RID: 411
[Token(Token = "0x200019B")]
public class GUIJourneyButtonSetting : GUIOpenUIButtonSetting
{
	// Token: 0x06000C26 RID: 3110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0xC5A42C", Offset = "0xC5A42C", VA = "0xC5A42C")]
	public GUIJourneyButtonSetting(GUISettingID id)
	{
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0xC5A434", Offset = "0xC5A434", VA = "0xC5A434", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0xC5A580", Offset = "0xC5A580", VA = "0xC5A580", Slot = "7")]
	protected override SettingsOverlayListOption_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x04000F11 RID: 3857
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x18")]
	private float iconScale;
}
