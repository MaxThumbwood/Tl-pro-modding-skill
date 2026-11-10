using System;
using Il2CppDummyDll;

// Token: 0x020002D2 RID: 722
[Token(Token = "0x20002D2")]
public class GUIOpenUIButtonSetting : GUISettingEntry
{
	// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0xD58C3C", Offset = "0xD58C3C", VA = "0xD58C3C")]
	public GUIOpenUIButtonSetting(GUISettingID id)
	{
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0xD58C44", Offset = "0xD58C44", VA = "0xD58C44", Slot = "7")]
	protected virtual SettingsOverlayListOption_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0xD58CAC", Offset = "0xD58CAC", VA = "0xD58CAC", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00008610 File Offset: 0x00006810
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0xD59164", Offset = "0xD59164", VA = "0xD59164", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0xD59198", Offset = "0xD59198", VA = "0xD59198", Slot = "8")]
	protected virtual string GetButtonCaption()
	{
		return null;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0xD59508", Offset = "0xD59508", VA = "0xD59508", Slot = "9")]
	protected virtual string GetOption()
	{
		return null;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0xD59D24", Offset = "0xD59D24", VA = "0xD59D24")]
	public static void OpenVCEditor()
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0xD5A064", Offset = "0xD5A064", VA = "0xD5A064")]
	public static void OpenKeyboardMappings()
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0xD5A188", Offset = "0xD5A188", VA = "0xD5A188")]
	public static void OpenControllerMappings()
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E7")]
	[Address(RVA = "0xD5A274", Offset = "0xD5A274", VA = "0xD5A274", Slot = "10")]
	protected virtual void OpenUI()
	{
	}

	// Token: 0x040022B0 RID: 8880
	[Token(Token = "0x40022B0")]
	[FieldOffset(Offset = "0x14")]
	private float scale;
}
