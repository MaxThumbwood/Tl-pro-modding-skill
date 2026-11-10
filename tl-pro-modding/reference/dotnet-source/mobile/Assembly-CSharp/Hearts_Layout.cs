using System;
using Il2CppDummyDll;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
public class Hearts_Layout : LayoutDefinition
{
	// Token: 0x06000D55 RID: 3413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0xC7D268", Offset = "0xC7D268", VA = "0xC7D268")]
	private void Awake()
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0xC7D2BC", Offset = "0xC7D2BC", VA = "0xC7D2BC")]
	public Hearts_Layout()
	{
	}

	// Token: 0x04001522 RID: 5410
	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x0")]
	public static Hearts_Layout Instance;

	// Token: 0x04001523 RID: 5411
	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0xC")]
	public bool HideWhenInventoryOpen;

	// Token: 0x04001524 RID: 5412
	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout HealthTitle;

	// Token: 0x04001525 RID: 5413
	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout HealthValue;

	// Token: 0x04001526 RID: 5414
	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0x18")]
	public float HeartsScale;

	// Token: 0x04001527 RID: 5415
	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout HeartsGrid;

	// Token: 0x04001528 RID: 5416
	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout HeartsGridController;

	// Token: 0x04001529 RID: 5417
	[Token(Token = "0x4001529")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout HealthTitleController;

	// Token: 0x0400152A RID: 5418
	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x28")]
	public String_Layout HealthValueController;

	// Token: 0x0400152B RID: 5419
	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x2C")]
	public ItemGrid_Layout HorizontalHeartsGrid;

	// Token: 0x0400152C RID: 5420
	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout HorizontalHeartsGridController;
}
