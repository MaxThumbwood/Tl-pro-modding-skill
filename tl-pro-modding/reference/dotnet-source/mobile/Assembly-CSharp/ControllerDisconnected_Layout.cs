using System;
using Il2CppDummyDll;

// Token: 0x020001B9 RID: 441
[Token(Token = "0x20001B9")]
public class ControllerDisconnected_Layout : LayoutDefinition
{
	// Token: 0x06000C9A RID: 3226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0xC68188", Offset = "0xC68188", VA = "0xC68188")]
	private void Awake()
	{
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0xC681DC", Offset = "0xC681DC", VA = "0xC681DC")]
	public ControllerDisconnected_Layout()
	{
	}

	// Token: 0x0400110E RID: 4366
	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x0")]
	public static ControllerDisconnected_Layout Instance;

	// Token: 0x0400110F RID: 4367
	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Greyout;

	// Token: 0x04001110 RID: 4368
	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Status;

	// Token: 0x04001112 RID: 4370
	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x18")]
	public Button_Layout SearchingIcon;

	// Token: 0x04001113 RID: 4371
	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout SwitchBacking;

	// Token: 0x04001114 RID: 4372
	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout SwitchStatus;

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout SwitchConfigure;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x28")]
	public Button_Layout SwitchSearchingIcon;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Close;
}
