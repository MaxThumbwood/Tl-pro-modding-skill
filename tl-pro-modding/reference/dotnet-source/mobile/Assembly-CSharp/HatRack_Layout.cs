using System;
using Il2CppDummyDll;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
public class HatRack_Layout : PageControllerLayoutDefinition<HatRack_Layout>
{
	// Token: 0x06000D54 RID: 3412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D54")]
	[Address(RVA = "0xC7D200", Offset = "0xC7D200", VA = "0xC7D200")]
	public HatRack_Layout()
	{
	}

	// Token: 0x0400151C RID: 5404
	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x0400151D RID: 5405
	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x14")]
	public float HatScale;

	// Token: 0x0400151E RID: 5406
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x18")]
	public float HatHighlightScale;

	// Token: 0x0400151F RID: 5407
	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout HatDye;

	// Token: 0x04001520 RID: 5408
	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Hat;

	// Token: 0x04001521 RID: 5409
	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout RemoveButton;
}
