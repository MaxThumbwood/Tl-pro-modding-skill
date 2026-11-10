using System;
using Il2CppDummyDll;

// Token: 0x020000C9 RID: 201
[Token(Token = "0x20000C9")]
public class GUIControllerChest : GUIPageContentController
{
	// Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xE5CE38", Offset = "0xE5CE38", VA = "0xE5CE38")]
	public GUIControllerChest()
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xE5CE54", Offset = "0xE5CE54", VA = "0xE5CE54", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00003978 File Offset: 0x00001B78
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xE5CE58", Offset = "0xE5CE58", VA = "0xE5CE58", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x040006E8 RID: 1768
	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;
}
