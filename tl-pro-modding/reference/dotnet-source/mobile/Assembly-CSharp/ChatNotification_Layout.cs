using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
public class ChatNotification_Layout : LayoutDefinition
{
	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012D")]
	public static ChatNotification_Layout Instance
	{
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0xC67918", Offset = "0xC67918", VA = "0xC67918")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0xC679D4", Offset = "0xC679D4", VA = "0xC679D4")]
	private void Awake()
	{
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0xC67A6C", Offset = "0xC67A6C", VA = "0xC67A6C")]
	public ChatNotification_Layout()
	{
	}

	// Token: 0x04001091 RID: 4241
	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x0")]
	public static ChatNotification_Layout _instanceTouch;

	// Token: 0x04001092 RID: 4242
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x4")]
	public static ChatNotification_Layout _instance;

	// Token: 0x04001093 RID: 4243
	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 BackingNotificationTLOffset;

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 BackingNotificationBROffset;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout BackingNotification;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Toggle;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout ToggleOpen;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout NotificationGrid;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout ItemBacking;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x30")]
	public String_Layout ItemText;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 ItemTextInset;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x3C")]
	public float TextWrapSize;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x40")]
	public float TextWrapSizeBarsUI;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x44")]
	public String_Layout PlayerNameText;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x48")]
	public float PlayerNameMaxLen;
}
