using System;
using Il2CppDummyDll;
using Terraria;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
public class GUIInventoryTransactions
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DA")]
	public Item SelectedItem
	{
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xAB9440", Offset = "0xAB9440", VA = "0xAB9440")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0xAB9530", Offset = "0xAB9530", VA = "0xAB9530")]
	public void SellItem()
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0xAB98E4", Offset = "0xAB98E4", VA = "0xAB98E4")]
	public void EquipItem()
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0xAB9EE4", Offset = "0xAB9EE4", VA = "0xAB9EE4")]
	public void PlaceItemDoll()
	{
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0xABA328", Offset = "0xABA328", VA = "0xABA328")]
	public void PlaceItemHat()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0xABA660", Offset = "0xABA660", VA = "0xABA660")]
	public void DepositItem()
	{
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E9")]
	[Address(RVA = "0xABA790", Offset = "0xABA790", VA = "0xABA790")]
	public GUIInventoryTransactions()
	{
	}

	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x8")]
	private float sellButtonScale;

	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0xC")]
	private float equipButtonScale;

	// Token: 0x04000BB8 RID: 3000
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x10")]
	private float depositButtonScale;

	// Token: 0x04000BB9 RID: 3001
	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x14")]
	public bool canBeDeposited;
}
