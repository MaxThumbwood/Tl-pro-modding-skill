using System;
using Il2CppDummyDll;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
public class GUIControllerPVP : GUIPageContentController
{
	// Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xE6A2B4", Offset = "0xE6A2B4", VA = "0xE6A2B4")]
	public GUIControllerPVP()
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xE6A2C0", Offset = "0xE6A2C0", VA = "0xE6A2C0", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xE6A2C8", Offset = "0xE6A2C8", VA = "0xE6A2C8", Slot = "15")]
	protected virtual void ClampPosition()
	{
	}

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x14")]
	public bool insideSideIcons;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x18")]
	public int itemRow;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x1C")]
	public int itemColumn;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x20")]
	public int sideRow;
}
