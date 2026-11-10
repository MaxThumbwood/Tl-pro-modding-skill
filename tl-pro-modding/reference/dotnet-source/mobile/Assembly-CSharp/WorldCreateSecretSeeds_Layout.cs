using System;
using Il2CppDummyDll;

// Token: 0x02000247 RID: 583
[Token(Token = "0x2000247")]
public class WorldCreateSecretSeeds_Layout : LayoutDefinition
{
	// Token: 0x06000E41 RID: 3649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0xC9326C", Offset = "0xC9326C", VA = "0xC9326C")]
	private void Awake()
	{
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0xC932C0", Offset = "0xC932C0", VA = "0xC932C0")]
	public WorldCreateSecretSeeds_Layout()
	{
	}

	// Token: 0x04001A7F RID: 6783
	[Token(Token = "0x4001A7F")]
	[FieldOffset(Offset = "0x0")]
	public static WorldCreateSecretSeeds_Layout Instance;

	// Token: 0x04001A80 RID: 6784
	[Token(Token = "0x4001A80")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001A81 RID: 6785
	[Token(Token = "0x4001A81")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout Title;

	// Token: 0x04001A82 RID: 6786
	[Token(Token = "0x4001A82")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Back;

	// Token: 0x04001A83 RID: 6787
	[Token(Token = "0x4001A83")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001A84 RID: 6788
	[Token(Token = "0x4001A84")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout SeedGrid;

	// Token: 0x04001A85 RID: 6789
	[Token(Token = "0x4001A85")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SeedEntry;

	// Token: 0x04001A86 RID: 6790
	[Token(Token = "0x4001A86")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Description;
}
