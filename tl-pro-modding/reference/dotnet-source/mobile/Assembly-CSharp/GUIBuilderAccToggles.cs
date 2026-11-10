using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
public class GUIBuilderAccToggles
{
	// Token: 0x06000836 RID: 2102 RVA: 0x00005628 File Offset: 0x00003828
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x1E49BA4", Offset = "0x1E49BA4", VA = "0x1E49BA4")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x1E49EB0", Offset = "0x1E49EB0", VA = "0x1E49EB0")]
	public TransactionButton_Layout SetupLayout()
	{
		return null;
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x1E49F9C", Offset = "0x1E49F9C", VA = "0x1E49F9C")]
	public void FinaliseLayout(TransactionButton_Layout layout)
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x1E49FD8", Offset = "0x1E49FD8", VA = "0x1E49FD8")]
	public void Draw()
	{
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x00005640 File Offset: 0x00003840
	[Token(Token = "0x170000BF")]
	public int ItemCount
	{
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1E4BA5C", Offset = "0x1E4BA5C", VA = "0x1E4BA5C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x1E4B580", Offset = "0x1E4B580", VA = "0x1E4B580")]
	private void RefreshList(Player plr)
	{
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x1E4BAC8", Offset = "0x1E4BAC8", VA = "0x1E4BAC8")]
	private float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x1E4BAF4", Offset = "0x1E4BAF4", VA = "0x1E4BAF4")]
	private void ItemOver(int index)
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x1E4BB68", Offset = "0x1E4BB68", VA = "0x1E4BB68")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int z, Vector2 position, float scale)
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x1E4B4E8", Offset = "0x1E4B4E8", VA = "0x1E4B4E8")]
	public void Close()
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x1E4D808", Offset = "0x1E4D808", VA = "0x1E4D808")]
	private bool IsOverBuilderTools(Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x1E4DB90", Offset = "0x1E4DB90", VA = "0x1E4DB90")]
	public GUIBuilderAccToggles()
	{
	}

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x8")]
	public bool Enabled;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0xC")]
	private float toggleButtonScale;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x10")]
	private int blockReplaceIcons;

	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x14")]
	private int torchGodIcons;

	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x18")]
	private int totalDrawnIcons;

	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x1C")]
	private int hoverItem;

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x20")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 toggleSize;

	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x2C")]
	private List<int> items;

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x30")]
	private float TimeSinceChanged;

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x34")]
	private string TooltipString;
}
