using System;
using Il2CppDummyDll;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public class ControllerHardwareProfile_Layout : LayoutDefinition
{
	// Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0xC68244", Offset = "0xC68244", VA = "0xC68244")]
	private void Awake()
	{
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0xC68298", Offset = "0xC68298", VA = "0xC68298")]
	public ControllerHardwareProfile_Layout()
	{
	}

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x0")]
	public static ControllerHardwareProfile_Layout Instance;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x14")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x0400111C RID: 4380
	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Close;

	// Token: 0x0400111D RID: 4381
	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x0400111E RID: 4382
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Clear;

	// Token: 0x0400111F RID: 4383
	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x04001120 RID: 4384
	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x28")]
	public ControllerProfileMappingEntry_Layout PulldownTemplate;
}
