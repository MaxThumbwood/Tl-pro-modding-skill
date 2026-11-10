using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
public class GUIProfileSwitch
{
	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0xBD4CD8", Offset = "0xBD4CD8", VA = "0xBD4CD8")]
	public void Show(VirtualControlsHardwareConfigurationMapping_Layout origin)
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0xBD4CE8", Offset = "0xBD4CE8", VA = "0xBD4CE8")]
	public void CycleNextProfile()
	{
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0xBD51AC", Offset = "0xBD51AC", VA = "0xBD51AC")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0xBD5430", Offset = "0xBD5430", VA = "0xBD5430")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0xBD56BC", Offset = "0xBD56BC", VA = "0xBD56BC")]
	public void Draw()
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0xBD601C", Offset = "0xBD601C", VA = "0xBD601C")]
	public GUIProfileSwitch()
	{
	}

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x8")]
	public bool Visible;

	// Token: 0x04000CE4 RID: 3300
	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0xC")]
	private VirtualControlsHardwareConfigurationMapping_Layout buttonOrigin;

	// Token: 0x04000CE5 RID: 3301
	[Token(Token = "0x4000CE5")]
	[FieldOffset(Offset = "0x10")]
	private List<VirtualControlsProfile_Layout> profiles;

	// Token: 0x04000CE6 RID: 3302
	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0x14")]
	private float Profile1Scale;

	// Token: 0x04000CE7 RID: 3303
	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x18")]
	private float Profile2Scale;

	// Token: 0x04000CE8 RID: 3304
	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x1C")]
	private float Profile3Scale;

	// Token: 0x04000CE9 RID: 3305
	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x20")]
	private float Profile4Scale;
}
