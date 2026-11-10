using System;
using Il2CppDummyDll;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class InventoryTransactions_Layout : PageControllerLayoutDefinition<InventoryTransactions_Layout>
{
	// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0xC8A0D8", Offset = "0xC8A0D8", VA = "0xC8A0D8")]
	public InventoryTransactions_Layout()
	{
	}

	// Token: 0x04001563 RID: 5475
	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout SellButton;

	// Token: 0x04001564 RID: 5476
	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout SellValue;

	// Token: 0x04001565 RID: 5477
	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout ControllerSellValue;

	// Token: 0x04001566 RID: 5478
	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout OpenButton;

	// Token: 0x04001567 RID: 5479
	[Token(Token = "0x4001567")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout UseButton;

	// Token: 0x04001568 RID: 5480
	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout EquipButton;

	// Token: 0x04001569 RID: 5481
	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout DepositButton;

	// Token: 0x0400156A RID: 5482
	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout PlaceHatButton;

	// Token: 0x0400156B RID: 5483
	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout PlaceDollButton;
}
