using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
public class GUIItemDuplication
{
	// Token: 0x060009EA RID: 2538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EA")]
	[Address(RVA = "0xABA7A8", Offset = "0xABA7A8", VA = "0xABA7A8")]
	public void Reset()
	{
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060009EB RID: 2539 RVA: 0x00006060 File Offset: 0x00004260
	[Token(Token = "0x170000DB")]
	public bool HasFocus
	{
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xABA870", Offset = "0xABA870", VA = "0xABA870")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x00006078 File Offset: 0x00004278
	[Token(Token = "0x170000DC")]
	public bool Collapsed
	{
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xABAA18", Offset = "0xABAA18", VA = "0xABAA18")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009ED")]
	[Address(RVA = "0xABAA98", Offset = "0xABAA98", VA = "0xABAA98")]
	public void DrawCraftButton()
	{
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0xABBDE0", Offset = "0xABBDE0", VA = "0xABBDE0")]
	public void ResetFilters()
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0xABBE18", Offset = "0xABBE18", VA = "0xABBE18")]
	private void UpdateFilter(bool force = false)
	{
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00006090 File Offset: 0x00004290
	[Token(Token = "0x60009F0")]
	[Address(RVA = "0xABC61C", Offset = "0xABC61C", VA = "0xABC61C")]
	private int CompareItemOrder(int x, int y)
	{
		return 0;
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F1")]
	[Address(RVA = "0xABCAEC", Offset = "0xABCAEC", VA = "0xABCAEC")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F2")]
	[Address(RVA = "0xABCC60", Offset = "0xABCC60", VA = "0xABCC60")]
	public void Draw()
	{
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x000060A8 File Offset: 0x000042A8
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0xABD464", Offset = "0xABD464", VA = "0xABD464")]
	public float CraftItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0xABD4CC", Offset = "0xABD4CC", VA = "0xABD4CC")]
	public void CraftItemOver(int index)
	{
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0xABDCC8", Offset = "0xABDCC8", VA = "0xABDCC8")]
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0xABE508", Offset = "0xABE508", VA = "0xABE508")]
	public GUIItemDuplication()
	{
	}

	// Token: 0x04000BBA RID: 3002
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x8")]
	private float CraftButtonScale;

	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0xC")]
	private int Offset;

	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x10")]
	public int FocusItem;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x14")]
	private int LastId;

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x18")]
	private GUIItemFilter.CategoryFilter LastCategory;

	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x1C")]
	private string LastSearch;

	// Token: 0x04000BC0 RID: 3008
	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x20")]
	private bool rightClickHeld;

	// Token: 0x04000BC1 RID: 3009
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x24")]
	public GUIItemFilter Filter;

	// Token: 0x04000BC2 RID: 3010
	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x28")]
	private List<int> AvailableItems;

	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x2C")]
	public List<int> FilteredItems;

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x30")]
	public float craftScrollOffset;

	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x34")]
	private float craftScrollMomentum;

	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x38")]
	private int craftScrollDragging;

	// Token: 0x04000BC7 RID: 3015
	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 craftDragOffset;

	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x44")]
	private bool pendingCraft;

	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x48")]
	public float hoverCraftDelay;

	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x4C")]
	public GUITransactionButton.InputState lastState;

	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x50")]
	private bool wasOverItem;

	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x54")]
	private int multiCraftDelay;

	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x58")]
	private int slowRampUp;

	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x5C")]
	private int multiCraftRecipe;

	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x60")]
	private int HoverDuplicateEntry;

	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x64")]
	private int cursorOver;

	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x68")]
	private bool lastRightDown;

	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x6C")]
	private Item blankItem;

	// Token: 0x04000BD3 RID: 3027
	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x70")]
	private string materialHoverItemName;

	// Token: 0x04000BD4 RID: 3028
	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x74")]
	private Item materialToolTip;
}
