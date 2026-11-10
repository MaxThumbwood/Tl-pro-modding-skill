using System;
using Il2CppDummyDll;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class GUIControllerToggleEntry : GUIControllerMappingEntryBase
{
	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000300")]
	[Address(RVA = "0xC3D714", Offset = "0xC3D714", VA = "0xC3D714")]
	public GUIControllerToggleEntry(GUISettingID id)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000301")]
	[Address(RVA = "0xC3D80C", Offset = "0xC3D80C", VA = "0xC3D80C", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x6000302")]
	[Address(RVA = "0xC3D838", Offset = "0xC3D838", VA = "0xC3D838", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000303")]
	[Address(RVA = "0xC3D864", Offset = "0xC3D864", VA = "0xC3D864", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x1C")]
	private GUIToggleSetting Worker;
}
