using System;
using Il2CppDummyDll;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
public class GUIJourneyToggleSetting : GUIToggleSetting
{
	// Token: 0x06000C37 RID: 3127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0xC5E568", Offset = "0xC5E568", VA = "0xC5E568")]
	public GUIJourneyToggleSetting(GUISettingID id)
	{
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0xC5E570", Offset = "0xC5E570", VA = "0xC5E570", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0xC5E6BC", Offset = "0xC5E6BC", VA = "0xC5E6BC", Slot = "7")]
	protected override SettingsOverlayToggle_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x04000F1A RID: 3866
	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0x18")]
	private float iconScale;
}
