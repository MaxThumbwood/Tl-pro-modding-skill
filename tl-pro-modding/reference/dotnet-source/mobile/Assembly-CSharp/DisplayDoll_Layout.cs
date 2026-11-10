using System;
using Il2CppDummyDll;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class DisplayDoll_Layout : PageControllerLayoutDefinition<DisplayDoll_Layout>
{
	// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0xC7C114", Offset = "0xC7C114", VA = "0xC7C114")]
	public DisplayDoll_Layout()
	{
	}

	// Token: 0x04001464 RID: 5220
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001465 RID: 5221
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x14")]
	public float AmourScale;

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x18")]
	public float ArmourHighlightScale;

	// Token: 0x04001467 RID: 5223
	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout ArmourDye;

	// Token: 0x04001468 RID: 5224
	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Armor;

	// Token: 0x04001469 RID: 5225
	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x24")]
	public float AccessoryScale;

	// Token: 0x0400146A RID: 5226
	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x28")]
	public float AccessoryHighlightScale;

	// Token: 0x0400146B RID: 5227
	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x2C")]
	public ItemGrid_Layout AccessoryDye;

	// Token: 0x0400146C RID: 5228
	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout Accessory;

	// Token: 0x0400146D RID: 5229
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x34")]
	public float MountScale;

	// Token: 0x0400146E RID: 5230
	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x38")]
	public float MountHighlightScale;

	// Token: 0x0400146F RID: 5231
	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x3C")]
	public ItemGrid_Layout MountDye;

	// Token: 0x04001470 RID: 5232
	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout Mount;

	// Token: 0x04001471 RID: 5233
	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x44")]
	public ItemGrid_Layout Misc;

	// Token: 0x04001472 RID: 5234
	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout RemoveButton;
}
