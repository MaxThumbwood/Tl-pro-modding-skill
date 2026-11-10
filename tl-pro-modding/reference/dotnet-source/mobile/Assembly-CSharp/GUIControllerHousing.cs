using System;
using Il2CppDummyDll;

// Token: 0x020000DD RID: 221
[Token(Token = "0x20000DD")]
public class GUIControllerHousing : GUIPageContentController
{
	// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000590")]
	[Address(RVA = "0xE659B8", Offset = "0xE659B8", VA = "0xE659B8")]
	public GUIControllerHousing()
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x6000591")]
	[Address(RVA = "0xE659CC", Offset = "0xE659CC", VA = "0xE659CC", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000592")]
	[Address(RVA = "0xE659D4", Offset = "0xE659D4", VA = "0xE659D4", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000593")]
	[Address(RVA = "0xE659D8", Offset = "0xE659D8", VA = "0xE659D8", Slot = "15")]
	public virtual void NextItem()
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000594")]
	[Address(RVA = "0xE659DC", Offset = "0xE659DC", VA = "0xE659DC", Slot = "16")]
	public virtual void PreviousItem()
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000595")]
	[Address(RVA = "0xE659E0", Offset = "0xE659E0", VA = "0xE659E0", Slot = "17")]
	protected virtual void ClampPosition()
	{
	}

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;
}
