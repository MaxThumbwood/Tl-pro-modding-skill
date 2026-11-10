using System;
using Il2CppDummyDll;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
public class GUIScrollControl
{
	// Token: 0x06000B4A RID: 2890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0xBFA284", Offset = "0xBFA284", VA = "0xBFA284")]
	public void SetScrollWindow(DraggableItemGrid_Layout item)
	{
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00006948 File Offset: 0x00004B48
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0xBFA86C", Offset = "0xBFA86C", VA = "0xBFA86C")]
	public bool IsGlobalScrollValid()
	{
		return default(bool);
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0xBFA8E8", Offset = "0xBFA8E8", VA = "0xBFA8E8")]
	public GUIScrollControl()
	{
	}

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x8")]
	private DraggableItemGrid_Layout currentScrollGrid;

	// Token: 0x04000D74 RID: 3444
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0xC")]
	private int currentItemFrame;
}
