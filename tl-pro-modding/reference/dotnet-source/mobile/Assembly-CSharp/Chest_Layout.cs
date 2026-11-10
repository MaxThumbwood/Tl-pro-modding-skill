using System;
using Il2CppDummyDll;

// Token: 0x020001B6 RID: 438
[Token(Token = "0x20001B6")]
public class Chest_Layout : PageControllerLayoutDefinition<Chest_Layout>
{
	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012E")]
	public ItemGrid_Layout DisplayChestGrid
	{
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0xC67E1C", Offset = "0xC67E1C", VA = "0xC67E1C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0xC67EBC", Offset = "0xC67EBC", VA = "0xC67EBC")]
	public Chest_Layout()
	{
	}

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout TitleController;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout TitleTouch;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x1C")]
	public float ItemScale;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x20")]
	public float ItemHighlightScale;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout ChestGrid;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout HorizontalChestGrid;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x2C")]
	public PopoutMenu_Layout Menu;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ChestRename;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout ChestRename_Horizontal;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ChestRestock;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout ChestRestock_Horizontal;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ChestQuickStack;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout ChestDepositAll;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout ChestDepositAll_Horizontal;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x4C")]
	public TransactionButton_Layout ChestLootAll;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ChestLootAll_Horizontal;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout LootButton;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Favorite;
}
