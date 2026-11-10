using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000134 RID: 308
[Token(Token = "0x2000134")]
public class GUIAmmo
{
	// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x19E80A8", Offset = "0x19E80A8", VA = "0x19E80A8")]
	public GUIAmmo()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00005430 File Offset: 0x00003630
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x19E822C", Offset = "0x19E822C", VA = "0x19E822C")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x19E8314", Offset = "0x19E8314", VA = "0x19E8314")]
	private bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x19E8368", Offset = "0x19E8368", VA = "0x19E8368")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x19E83E0", Offset = "0x19E83E0", VA = "0x19E83E0")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x19E9920", Offset = "0x19E9920", VA = "0x19E9920")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x19EA7C8", Offset = "0x19EA7C8", VA = "0x19EA7C8")]
	public void Draw()
	{
	}

	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x8")]
	private int itemOver;

	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0xC")]
	private int cursorOver;

	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStart;

	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x14")]
	private int lastItemClicked;

	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x18")]
	private float doubleClickTimer;

	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x1C")]
	private bool rightClickHeld;

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x20")]
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x24")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x28")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;
}
