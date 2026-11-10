using System;
using Il2CppDummyDll;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
public class Mana_Layout : LayoutDefinition
{
	// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0xC8F360", Offset = "0xC8F360", VA = "0xC8F360")]
	private void Awake()
	{
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0xC8F3B4", Offset = "0xC8F3B4", VA = "0xC8F3B4")]
	public Mana_Layout()
	{
	}

	// Token: 0x0400165B RID: 5723
	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x0")]
	public static Mana_Layout Instance;

	// Token: 0x0400165C RID: 5724
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0xC")]
	public bool HideWhenInventoryOpen;

	// Token: 0x0400165D RID: 5725
	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Mana;

	// Token: 0x0400165E RID: 5726
	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout ManaHorizontal;

	// Token: 0x0400165F RID: 5727
	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout ManaValue;

	// Token: 0x04001660 RID: 5728
	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0x1C")]
	public String_Layout ManaValueHorizontal;

	// Token: 0x04001661 RID: 5729
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x20")]
	public float StarScale;

	// Token: 0x04001662 RID: 5730
	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout ManaGrid;

	// Token: 0x04001663 RID: 5731
	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x28")]
	public String_Layout ManaController;

	// Token: 0x04001664 RID: 5732
	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x2C")]
	public String_Layout ManaControllerHorizontal;

	// Token: 0x04001665 RID: 5733
	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x30")]
	public String_Layout ManaValueController;

	// Token: 0x04001666 RID: 5734
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x34")]
	public String_Layout ManaValueControllerHorizontal;

	// Token: 0x04001667 RID: 5735
	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ManaGridController;

	// Token: 0x04001668 RID: 5736
	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0x3C")]
	public ItemGrid_Layout ManaGridHorizontal;

	// Token: 0x04001669 RID: 5737
	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout ManaGridControllerHorizontal;
}
