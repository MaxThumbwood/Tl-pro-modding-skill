using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
public class ChatMini_Layout : LayoutDefinition
{
	// Token: 0x06000C8B RID: 3211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0xC67774", Offset = "0xC67774", VA = "0xC67774")]
	private void Awake()
	{
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0xC677C8", Offset = "0xC677C8", VA = "0xC677C8")]
	public ChatMini_Layout()
	{
	}

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x0")]
	public static ChatMini_Layout Instance;

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Toggle;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout ToggleOpen;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x18")]
	public DraggableItemGrid_Layout TextGrid;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout ItemIcon;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout ItemWho;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout ItemBacking;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x2C")]
	public String_Layout ItemText;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 ItemTextInset;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout BeginChatBacking;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout BeginChatDivider;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout BeginChat;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout BeginChatBarsUI;

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Emote;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout ChatText;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x50")]
	public Color ChattingTextColor;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x54")]
	public float TextWrapSize;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x58")]
	public float TextWrapSizeBarsUI;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x5C")]
	public String_Layout PlayerNameText;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x60")]
	public float PlayerNameMaxLen;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x64")]
	public TransactionButton_Layout PrimaryChat;
}
