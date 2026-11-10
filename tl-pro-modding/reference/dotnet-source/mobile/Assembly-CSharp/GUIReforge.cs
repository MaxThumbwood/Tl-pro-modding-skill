using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
public class GUIReforge
{
	// Token: 0x06000AE5 RID: 2789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0xBE1D3C", Offset = "0xBE1D3C", VA = "0xBE1D3C")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x170000FB")]
	public bool Collapsed
	{
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xBE1E78", Offset = "0xBE1E78", VA = "0xBE1E78")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0xBE1EF8", Offset = "0xBE1EF8", VA = "0xBE1EF8")]
	public int ItemReforgeCost(Item item)
	{
		return 0;
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00006678 File Offset: 0x00004878
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0xBE2098", Offset = "0xBE2098", VA = "0xBE2098")]
	public int ReforgeCost()
	{
		return 0;
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0xBE21EC", Offset = "0xBE21EC", VA = "0xBE21EC")]
	public void Reset()
	{
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0xBE22B0", Offset = "0xBE22B0", VA = "0xBE22B0")]
	private void RefreshItems()
	{
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00006690 File Offset: 0x00004890
	[Token(Token = "0x170000FC")]
	public bool HasFocus
	{
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0xBE2754", Offset = "0xBE2754", VA = "0xBE2754")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0xBE2884", Offset = "0xBE2884", VA = "0xBE2884")]
	public void DrawReforge()
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0xBE30B4", Offset = "0xBE30B4", VA = "0xBE30B4")]
	public void Draw()
	{
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000FD")]
	public Item ReforgeItem
	{
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xBE2148", Offset = "0xBE2148", VA = "0xBE2148")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x000066A8 File Offset: 0x000048A8
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0xBE3EC4", Offset = "0xBE3EC4", VA = "0xBE3EC4")]
	public float ReforgeItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0xBE3F2C", Offset = "0xBE3F2C", VA = "0xBE3F2C")]
	public void ReforgeItemOver(int index)
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0xBE4138", Offset = "0xBE4138", VA = "0xBE4138")]
	public void ReforgeItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0xBE480C", Offset = "0xBE480C", VA = "0xBE480C")]
	public GUIReforge()
	{
	}

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x8")]
	public List<Item> _reforgeItems;

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0xC")]
	private Item _defaultItem;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x10")]
	private int _selectedItem;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x14")]
	public float reforgeScrollOffset;

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x18")]
	private float reforgeScrollMomentum;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x1C")]
	private int reforgeScrollDragging;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 reforgeDragOffset;

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x28")]
	private int cursorOver;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x2C")]
	private float reforgeActionScale;
}
