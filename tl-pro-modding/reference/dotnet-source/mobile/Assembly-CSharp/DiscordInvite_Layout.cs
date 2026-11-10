using System;
using Il2CppDummyDll;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class DiscordInvite_Layout : LayoutDefinition
{
	// Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D41")]
	[Address(RVA = "0xC7C058", Offset = "0xC7C058", VA = "0xC7C058")]
	private void Awake()
	{
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D42")]
	[Address(RVA = "0xC7C0AC", Offset = "0xC7C0AC", VA = "0xC7C0AC")]
	public DiscordInvite_Layout()
	{
	}

	// Token: 0x0400145B RID: 5211
	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x0")]
	public static DiscordInvite_Layout Instance;

	// Token: 0x0400145C RID: 5212
	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x0400145D RID: 5213
	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout FriendGridBacking;

	// Token: 0x0400145E RID: 5214
	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x14")]
	public DraggableItemGrid_Layout FriendGrid;

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout FriendEntryBacking;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout FriendEntry;

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout FriendName;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Invite;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Close;
}
