using System;
using Il2CppDummyDll;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class Ammo_Layout : PageControllerLayoutDefinition<Ammo_Layout>
{
	// Token: 0x06000C75 RID: 3189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0xC66578", Offset = "0xC66578", VA = "0xC66578")]
	public Ammo_Layout()
	{
	}

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x18")]
	public float ItemHighlightScale;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout AmmoGrid;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x20")]
	public float ItemScale_Collapsed;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x24")]
	public float ItemHighlightScale_Collapsed;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout AmmoGrid_Collapsed;
}
