using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public class GUIControllerPulldownEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xC3D078", Offset = "0xC3D078", VA = "0xC3D078")]
	public GUIControllerPulldownEntry(GUISettingID id)
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xC3D2A8", Offset = "0xC3D2A8", VA = "0xC3D2A8", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xC3D2D4", Offset = "0xC3D2D4", VA = "0xC3D2D4", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xC3D300", Offset = "0xC3D300", VA = "0xC3D300", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xC3D32C", Offset = "0xC3D32C", VA = "0xC3D32C")]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xC3D410", Offset = "0xC3D410", VA = "0xC3D410")]
	private void DeactivateOverlay()
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xC3D4AC", Offset = "0xC3D4AC", VA = "0xC3D4AC")]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xC3D56C", Offset = "0xC3D56C", VA = "0xC3D56C")]
	public int GetNumberOfOptions()
	{
		return 0;
	}

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x1C")]
	private GUIPulldownSetting Worker;
}
