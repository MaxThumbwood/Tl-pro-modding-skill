using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
public class GUITalkerList
{
	// Token: 0x06000B82 RID: 2946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0xC2ECD8", Offset = "0xC2ECD8", VA = "0xC2ECD8")]
	public GUITalkerList()
	{
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0xC2EEA8", Offset = "0xC2EEA8", VA = "0xC2EEA8")]
	public void Draw()
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00006AC8 File Offset: 0x00004CC8
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0xC2F54C", Offset = "0xC2F54C", VA = "0xC2F54C")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0xC2F5B4", Offset = "0xC2F5B4", VA = "0xC2F5B4")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0xC2F5B8", Offset = "0xC2F5B8", VA = "0xC2F5B8")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0xC2F4C8", Offset = "0xC2F4C8", VA = "0xC2F4C8")]
	public void RefreshTalkersList()
	{
	}

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x8")]
	private List<string> ActiveTalkers;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0xC")]
	private Rectangle lastDrawRegion;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x1C")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x20")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x24")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x04000DBC RID: 3516
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x28")]
	private int itemOffset;
}
