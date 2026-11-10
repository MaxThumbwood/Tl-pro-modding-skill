using System;
using Il2CppDummyDll;

// Token: 0x0200026E RID: 622
[Token(Token = "0x200026E")]
[Serializable]
public class VirtualControlsButtonConfiguration_Layout
{
	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0xC99EC4", Offset = "0xC99EC4", VA = "0xC99EC4")]
	public void Validate()
	{
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0xC99EC8", Offset = "0xC99EC8", VA = "0xC99EC8")]
	public QuickActionButton_Layout GetStyle(VirtualControlsButtonConfiguration_Layout.Style stlyeIndex)
	{
		return null;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0xC99EFC", Offset = "0xC99EFC", VA = "0xC99EFC")]
	public VirtualControlsButtonConfiguration_Layout()
	{
	}

	// Token: 0x04001DD8 RID: 7640
	[Token(Token = "0x4001DD8")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualControlsButtonConfiguration_Layout.Style[] ButtonStyles;

	// Token: 0x04001DD9 RID: 7641
	[Token(Token = "0x4001DD9")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04001DDA RID: 7642
	[Token(Token = "0x4001DDA")]
	[FieldOffset(Offset = "0xC")]
	public QuickActionButton_Layout BlueLayout;

	// Token: 0x04001DDB RID: 7643
	[Token(Token = "0x4001DDB")]
	[FieldOffset(Offset = "0x10")]
	public QuickActionButton_Layout GreenLayout;

	// Token: 0x04001DDC RID: 7644
	[Token(Token = "0x4001DDC")]
	[FieldOffset(Offset = "0x14")]
	public QuickActionButton_Layout TealLayout;

	// Token: 0x04001DDD RID: 7645
	[Token(Token = "0x4001DDD")]
	[FieldOffset(Offset = "0x18")]
	public QuickActionButton_Layout BadPositionLayout;

	// Token: 0x04001DDE RID: 7646
	[Token(Token = "0x4001DDE")]
	[FieldOffset(Offset = "0x1C")]
	public QuickActionButton_Layout ControlLayout;

	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public enum Style
	{
		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		Blue,
		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		Green,
		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		Teal,
		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		Bad
	}
}
