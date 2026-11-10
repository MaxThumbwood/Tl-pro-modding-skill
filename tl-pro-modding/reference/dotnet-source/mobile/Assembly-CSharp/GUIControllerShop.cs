using System;
using Il2CppDummyDll;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000ED")]
public class GUIControllerShop : GUIPageContentController
{
	// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000623")]
	[Address(RVA = "0xF23874", Offset = "0xF23874", VA = "0xF23874")]
	public GUIControllerShop()
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x6000624")]
	[Address(RVA = "0xF23898", Offset = "0xF23898", VA = "0xF23898", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;
}
