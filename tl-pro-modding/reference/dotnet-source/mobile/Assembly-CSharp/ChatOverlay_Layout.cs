using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
public class ChatOverlay_Layout : LayoutDefinition
{
	// Token: 0x06000C90 RID: 3216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0xC67B7C", Offset = "0xC67B7C", VA = "0xC67B7C")]
	private void Awake()
	{
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0xC67BD0", Offset = "0xC67BD0", VA = "0xC67BD0")]
	public ChatOverlay_Layout()
	{
	}

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x0")]
	public static ChatOverlay_Layout Instance;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Toggle;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout ToggleOpen;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x18")]
	public DraggableItemGrid_Layout TextGrid;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout ItemIcon;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout ItemWho;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout ItemBacking;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x2C")]
	public String_Layout ItemText;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 ItemTextInset;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout BeginChatBacking;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout BeginChatDivider;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout BeginChat;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0x44")]
	public String_Layout ChatText;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x48")]
	public Color ChattingTextColor;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x4C")]
	public float TextWrapSize;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x50")]
	public float TextWrapSizeBarsUI;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x54")]
	public String_Layout PlayerNameText;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x58")]
	public float PlayerNameMaxLen;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x5C")]
	public TransactionButton_Layout PrimaryChat;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Close;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x64")]
	public TransactionButton_Layout Emote;

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x68")]
	public StringButton_Layout Title;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x6C")]
	public Panel_Layout Greyout;
}
