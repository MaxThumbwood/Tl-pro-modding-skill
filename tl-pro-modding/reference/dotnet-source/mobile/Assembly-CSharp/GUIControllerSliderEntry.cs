using System;
using Il2CppDummyDll;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
public class GUIControllerSliderEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xC3D598", Offset = "0xC3D598", VA = "0xC3D598")]
	public GUIControllerSliderEntry(GUISettingID id)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xC3D690", Offset = "0xC3D690", VA = "0xC3D690", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xC3D6BC", Offset = "0xC3D6BC", VA = "0xC3D6BC", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xC3D6E8", Offset = "0xC3D6E8", VA = "0xC3D6E8", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x1C")]
	private GUISliderSetting Worker;
}
