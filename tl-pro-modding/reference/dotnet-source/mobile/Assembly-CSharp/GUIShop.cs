using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class GUIShop
{
	// Token: 0x06000B64 RID: 2916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0xC2742C", Offset = "0xC2742C", VA = "0xC2742C")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000106")]
	public Item SelectedItem
	{
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0xC275D0", Offset = "0xC275D0", VA = "0xC275D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0xC2769C", Offset = "0xC2769C", VA = "0xC2769C")]
	private void PurchasePressedAndHeld(bool delayedPurchase = false)
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0xC27FE4", Offset = "0xC27FE4", VA = "0xC27FE4")]
	public void DrawPurchaseButton()
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0xC295F4", Offset = "0xC295F4", VA = "0xC295F4")]
	public void Draw()
	{
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00006A20 File Offset: 0x00004C20
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0xC2A024", Offset = "0xC2A024", VA = "0xC2A024")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0xC2A08C", Offset = "0xC2A08C", VA = "0xC2A08C")]
	public void PurchasePendingItems()
	{
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0xC2A160", Offset = "0xC2A160", VA = "0xC2A160")]
	public void CancelPendingItems()
	{
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0xC2A224", Offset = "0xC2A224", VA = "0xC2A224")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00006A38 File Offset: 0x00004C38
	[Token(Token = "0x17000107")]
	public bool HasFocus
	{
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0xC2ABF0", Offset = "0xC2ABF0", VA = "0xC2ABF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0xC2AD20", Offset = "0xC2AD20", VA = "0xC2AD20")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0xC29CA4", Offset = "0xC29CA4", VA = "0xC29CA4")]
	private void DrawSlots(SpriteBatch spriteBatch)
	{
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0xC2B18C", Offset = "0xC2B18C", VA = "0xC2B18C")]
	public GUIShop()
	{
	}

	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0xC")]
	private int itemOver;

	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStart;

	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x18")]
	private DateTime itemPurchaseDelayStart;

	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x20")]
	private int _selectedItem;

	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x24")]
	private float buyButtonScale;

	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x28")]
	private bool _pendingPurchase;

	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x2C")]
	private int _pendingCost;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x30")]
	private int multibuyDelay;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x34")]
	public float hoverCraftDelay;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x38")]
	public GUITransactionButton.InputState lastState;

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x3C")]
	private float happinessButtonScale;
}
