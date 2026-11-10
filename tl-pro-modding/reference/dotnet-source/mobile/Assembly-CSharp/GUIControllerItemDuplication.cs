using System;
using Il2CppDummyDll;

// Token: 0x020000E1 RID: 225
[Token(Token = "0x20000E1")]
public class GUIControllerItemDuplication : GUIPageContentController
{
	// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0xE682E0", Offset = "0xE682E0", VA = "0xE682E0")]
	public GUIControllerItemDuplication()
	{
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0xE682EC", Offset = "0xE682EC", VA = "0xE682EC", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0xE682F4", Offset = "0xE682F4", VA = "0xE682F4", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0xE682F8", Offset = "0xE682F8", VA = "0xE682F8", Slot = "15")]
	public virtual void RefreshScrollOffset()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0xE682FC", Offset = "0xE682FC", VA = "0xE682FC", Slot = "16")]
	protected virtual void UpdateScroll()
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0xE68300", Offset = "0xE68300", VA = "0xE68300", Slot = "17")]
	protected virtual void ClampPosition()
	{
	}

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x1C")]
	public int scrollOffset;
}
