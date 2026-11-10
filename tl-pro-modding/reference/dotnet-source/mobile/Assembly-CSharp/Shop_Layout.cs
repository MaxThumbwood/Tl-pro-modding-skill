using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000266 RID: 614
[Token(Token = "0x2000266")]
public class Shop_Layout : PageControllerLayoutDefinition<Shop_Layout>
{
	// Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0xC9988C", Offset = "0xC9988C", VA = "0xC9988C")]
	public Shop_Layout()
	{
	}

	// Token: 0x04001D8D RID: 7565
	[Token(Token = "0x4001D8D")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001D8E RID: 7566
	[Token(Token = "0x4001D8E")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x04001D8F RID: 7567
	[Token(Token = "0x4001D8F")]
	[FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout ShopGrid;

	// Token: 0x04001D90 RID: 7568
	[Token(Token = "0x4001D90")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout ShopGridHorizontal;

	// Token: 0x04001D91 RID: 7569
	[Token(Token = "0x4001D91")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04001D92 RID: 7570
	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout Savings;

	// Token: 0x04001D93 RID: 7571
	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001D94 RID: 7572
	[Token(Token = "0x4001D94")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001D95 RID: 7573
	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001D96 RID: 7574
	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001D97 RID: 7575
	[Token(Token = "0x4001D97")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout SavingsTitle;

	// Token: 0x04001D98 RID: 7576
	[Token(Token = "0x4001D98")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout Cost;

	// Token: 0x04001D99 RID: 7577
	[Token(Token = "0x4001D99")]
	[FieldOffset(Offset = "0x50")]
	public String_Layout ControllerCost;

	// Token: 0x04001D9A RID: 7578
	[Token(Token = "0x4001D9A")]
	[FieldOffset(Offset = "0x54")]
	public String_Layout OtherCurrencyCost;

	// Token: 0x04001D9B RID: 7579
	[Token(Token = "0x4001D9B")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout BuyButton;

	// Token: 0x04001D9C RID: 7580
	[Token(Token = "0x4001D9C")]
	[FieldOffset(Offset = "0x5C")]
	public float SlotMultiPurchaseDelay;

	// Token: 0x04001D9D RID: 7581
	[Token(Token = "0x4001D9D")]
	[FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout HappinessLevel;

	// Token: 0x04001D9E RID: 7582
	[Token(Token = "0x4001D9E")]
	[FieldOffset(Offset = "0x64")]
	public int[] BartenderShopOrder;

	// Token: 0x04001D9F RID: 7583
	[Token(Token = "0x4001D9F")]
	[FieldOffset(Offset = "0x68")]
	public int[] BartenderShopOrderHorizontal;
}
