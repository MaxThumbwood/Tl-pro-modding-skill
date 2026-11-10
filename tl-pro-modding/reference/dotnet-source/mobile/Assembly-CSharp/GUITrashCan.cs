using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
public class GUITrashCan
{
	// Token: 0x06000B88 RID: 2952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0xC2F9EC", Offset = "0xC2F9EC", VA = "0xC2F9EC")]
	public GUITrashCan()
	{
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x00006AE0 File Offset: 0x00004CE0
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0xC2FB5C", Offset = "0xC2FB5C", VA = "0xC2FB5C")]
	public float ItemScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0xC2FBC4", Offset = "0xC2FBC4", VA = "0xC2FBC4")]
	public void ItemOverImp(int index)
	{
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0xC2FFD8", Offset = "0xC2FFD8", VA = "0xC2FFD8")]
	public void ItemDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0xC30388", Offset = "0xC30388", VA = "0xC30388")]
	public void Draw()
	{
	}

	// Token: 0x04000DBD RID: 3517
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x8")]
	private bool itemDragStart;

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x9")]
	private bool overTrashCan;

	// Token: 0x04000DBF RID: 3519
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0xA")]
	private bool cursorOverTrashCan;

	// Token: 0x04000DC0 RID: 3520
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0xC")]
	private GUIItemGrid.GetItemScaleHandler ItemScale;

	// Token: 0x04000DC1 RID: 3521
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x10")]
	private GUIItemGrid.CursorOver ItemOver;

	// Token: 0x04000DC2 RID: 3522
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x14")]
	private GUIItemGrid.DrawItemHandler ItemDraw;
}
