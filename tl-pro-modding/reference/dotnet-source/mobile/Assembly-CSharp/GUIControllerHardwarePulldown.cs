using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
public class GUIControllerHardwarePulldown : GUIControllerMappingEntryBase
{
	// Token: 0x060004D8 RID: 1240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xE595D4", Offset = "0xE595D4", VA = "0xE595D4")]
	public GUIControllerHardwarePulldown(GUISettingID id)
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xE5B7FC", Offset = "0xE5B7FC", VA = "0xE5B7FC", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xE5B828", Offset = "0xE5B828", VA = "0xE5B828", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xE5B854", Offset = "0xE5B854", VA = "0xE5B854", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xE5B880", Offset = "0xE5B880", VA = "0xE5B880")]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xE5B884", Offset = "0xE5B884", VA = "0xE5B884")]
	private void DeactivateOverlay()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xE5B888", Offset = "0xE5B888", VA = "0xE5B888")]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xE5B914", Offset = "0xE5B914", VA = "0xE5B914")]
	public int GetNumberOfOptions()
	{
		return 0;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xE57AD0", Offset = "0xE57AD0", VA = "0xE57AD0")]
	public void CloseOptions()
	{
	}

	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x1C")]
	private GUIPulldownSetting Worker;
}
