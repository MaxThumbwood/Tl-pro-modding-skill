using System;
using Il2CppDummyDll;

// Token: 0x02000212 RID: 530
[Token(Token = "0x2000212")]
public class DeleteDedicatedServer_Layout : LayoutDefinition
{
	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0xC8FE2C", Offset = "0xC8FE2C", VA = "0xC8FE2C")]
	private void Awake()
	{
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0xC8FE80", Offset = "0xC8FE80", VA = "0xC8FE80")]
	public DeleteDedicatedServer_Layout()
	{
	}

	// Token: 0x0400169E RID: 5790
	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0x0")]
	public static DeleteDedicatedServer_Layout Instance;

	// Token: 0x0400169F RID: 5791
	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x040016A0 RID: 5792
	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x040016A1 RID: 5793
	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x040016A2 RID: 5794
	[Token(Token = "0x40016A2")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout DeletePrompt;

	// Token: 0x040016A3 RID: 5795
	[Token(Token = "0x40016A3")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Yes;

	// Token: 0x040016A4 RID: 5796
	[Token(Token = "0x40016A4")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout No;
}
