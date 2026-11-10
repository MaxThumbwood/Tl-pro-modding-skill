using System;
using Il2CppDummyDll;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x20001F5")]
public class HousingMenu_Layout : PageControllerLayoutDefinition<HousingMenu_Layout>
{
	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000164")]
	public DraggableItemGrid_Layout DisplayNPCGrid
	{
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0xC7D4F4", Offset = "0xC7D4F4", VA = "0xC7D4F4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0xC7D5EC", Offset = "0xC7D5EC", VA = "0xC7D5EC")]
	public HousingMenu_Layout()
	{
	}

	// Token: 0x04001536 RID: 5430
	[Token(Token = "0x4001536")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001537 RID: 5431
	[Token(Token = "0x4001537")]
	[FieldOffset(Offset = "0x14")]
	public float NPCScale;

	// Token: 0x04001538 RID: 5432
	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x18")]
	public float NPCHighlightScale;

	// Token: 0x04001539 RID: 5433
	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout NPCGrid;

	// Token: 0x0400153A RID: 5434
	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout NPCGridCollapsed;

	// Token: 0x0400153B RID: 5435
	[Token(Token = "0x400153B")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout HousingQuery;

	// Token: 0x0400153C RID: 5436
	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout HousingClose;

	// Token: 0x0400153D RID: 5437
	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x2C")]
	public EmptyHousingSlot EmptySlot;
}
