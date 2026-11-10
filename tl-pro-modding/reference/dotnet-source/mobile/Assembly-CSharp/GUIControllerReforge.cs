using System;
using Il2CppDummyDll;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
public class GUIControllerReforge : GUIPageContentController
{
	// Token: 0x060005FC RID: 1532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0xE6B9C0", Offset = "0xE6B9C0", VA = "0xE6B9C0")]
	public GUIControllerReforge()
	{
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x000042C0 File Offset: 0x000024C0
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0xE6B9CC", Offset = "0xE6B9CC", VA = "0xE6B9CC", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;
}
