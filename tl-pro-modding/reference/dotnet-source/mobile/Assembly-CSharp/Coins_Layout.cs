using System;
using Il2CppDummyDll;

// Token: 0x020001B8 RID: 440
[Token(Token = "0x20001B8")]
public class Coins_Layout : PageControllerLayoutDefinition<Coins_Layout>
{
	// Token: 0x06000C99 RID: 3225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0xC68110", Offset = "0xC68110", VA = "0xC68110")]
	public Coins_Layout()
	{
	}

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4001107")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001108 RID: 4360
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x04001109 RID: 4361
	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x18")]
	public float ItemHighlightScale;

	// Token: 0x0400110A RID: 4362
	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout CoinGrid;

	// Token: 0x0400110B RID: 4363
	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x20")]
	public float ItemScale_Collapsed;

	// Token: 0x0400110C RID: 4364
	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x24")]
	public float ItemHighlightScale_Collapsed;

	// Token: 0x0400110D RID: 4365
	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout CoinGrid_Collapsed;
}
