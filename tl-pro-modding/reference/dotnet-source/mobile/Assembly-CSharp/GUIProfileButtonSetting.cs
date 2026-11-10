using System;
using Il2CppDummyDll;

// Token: 0x020002DE RID: 734
[Token(Token = "0x20002DE")]
public class GUIProfileButtonSetting : GUIOpenUIButtonSetting
{
	// Token: 0x06001239 RID: 4665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001239")]
	[Address(RVA = "0xD83868", Offset = "0xD83868", VA = "0xD83868")]
	public GUIProfileButtonSetting(GUISettingID id)
	{
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123A")]
	[Address(RVA = "0xD83870", Offset = "0xD83870", VA = "0xD83870", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123B")]
	[Address(RVA = "0xD83AA4", Offset = "0xD83AA4", VA = "0xD83AA4", Slot = "7")]
	protected override SettingsOverlayListOption_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x0400239A RID: 9114
	[Token(Token = "0x400239A")]
	[FieldOffset(Offset = "0x18")]
	private float iconScale;
}
