using System;
using Il2CppDummyDll;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class GUIProfileToggleSetting : GUIToggleSetting
{
	// Token: 0x0600123C RID: 4668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123C")]
	[Address(RVA = "0xD83B18", Offset = "0xD83B18", VA = "0xD83B18")]
	public GUIProfileToggleSetting(GUISettingID id)
	{
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123D")]
	[Address(RVA = "0xD83B20", Offset = "0xD83B20", VA = "0xD83B20", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123E")]
	[Address(RVA = "0xD83CB0", Offset = "0xD83CB0", VA = "0xD83CB0", Slot = "7")]
	protected override SettingsOverlayToggle_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123F")]
	[Address(RVA = "0xD83D18", Offset = "0xD83D18", VA = "0xD83D18", Slot = "8")]
	protected override SettingsOverlayToggle_Layout GetDisabledLayout()
	{
		return null;
	}

	// Token: 0x0400239B RID: 9115
	[Token(Token = "0x400239B")]
	[FieldOffset(Offset = "0x18")]
	private float iconScale;
}
