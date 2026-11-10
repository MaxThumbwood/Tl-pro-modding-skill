using System;
using Il2CppDummyDll;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
public class Hotbar_Layout : LayoutDefinition
{
	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000163")]
	public static Hotbar_Layout Instance
	{
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0xC7D334", Offset = "0xC7D334", VA = "0xC7D334")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0xC7D3E8", Offset = "0xC7D3E8", VA = "0xC7D3E8")]
	private void Awake()
	{
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0xC7D470", Offset = "0xC7D470", VA = "0xC7D470")]
	public Hotbar_Layout()
	{
	}

	// Token: 0x0400152D RID: 5421
	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x0")]
	public static Hotbar_Layout InstanceNormal;

	// Token: 0x0400152E RID: 5422
	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x4")]
	public static Hotbar_Layout Instance4Page;

	// Token: 0x0400152F RID: 5423
	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0xC")]
	public float SelectedScale;

	// Token: 0x04001530 RID: 5424
	[Token(Token = "0x4001530")]
	[FieldOffset(Offset = "0x10")]
	public float NormalScale;

	// Token: 0x04001531 RID: 5425
	[Token(Token = "0x4001531")]
	[FieldOffset(Offset = "0x14")]
	public float ScaleSpeed;

	// Token: 0x04001532 RID: 5426
	[Token(Token = "0x4001532")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout Title;

	// Token: 0x04001533 RID: 5427
	[Token(Token = "0x4001533")]
	[FieldOffset(Offset = "0x1C")]
	public String_Layout HorizontalTitle;

	// Token: 0x04001534 RID: 5428
	[Token(Token = "0x4001534")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x04001535 RID: 5429
	[Token(Token = "0x4001535")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout HorizontalHotbarGrid;
}
