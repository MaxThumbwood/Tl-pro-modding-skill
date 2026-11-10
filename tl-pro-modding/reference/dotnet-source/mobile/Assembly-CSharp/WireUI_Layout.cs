using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200027C RID: 636
[Token(Token = "0x200027C")]
public class WireUI_Layout : LayoutDefinition
{
	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018A")]
	public static WireUI_Layout Instance
	{
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0xC9E6E0", Offset = "0xC9E6E0", VA = "0xC9E6E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0xC9E794", Offset = "0xC9E794", VA = "0xC9E794")]
	private void Awake()
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0xC9E81C", Offset = "0xC9E81C", VA = "0xC9E81C")]
	public WireUI_Layout()
	{
	}

	// Token: 0x04001EB0 RID: 7856
	[Token(Token = "0x4001EB0")]
	[FieldOffset(Offset = "0x0")]
	public static WireUI_Layout InstanceNormal;

	// Token: 0x04001EB1 RID: 7857
	[Token(Token = "0x4001EB1")]
	[FieldOffset(Offset = "0x4")]
	public static WireUI_Layout Instance4Page;

	// Token: 0x04001EB2 RID: 7858
	[Token(Token = "0x4001EB2")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 BackingTLOffset;

	// Token: 0x04001EB3 RID: 7859
	[Token(Token = "0x4001EB3")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 BackingBROffset;

	// Token: 0x04001EB4 RID: 7860
	[Token(Token = "0x4001EB4")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout Backing;

	// Token: 0x04001EB5 RID: 7861
	[Token(Token = "0x4001EB5")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout CutterBacking;

	// Token: 0x04001EB6 RID: 7862
	[Token(Token = "0x4001EB6")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout ToolOptions;

	// Token: 0x04001EB7 RID: 7863
	[Token(Token = "0x4001EB7")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 CursorPanelOffset;

	// Token: 0x04001EB8 RID: 7864
	[Token(Token = "0x4001EB8")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 TouchPanelOffset;

	// Token: 0x04001EB9 RID: 7865
	[Token(Token = "0x4001EB9")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout PlacementBacking;

	// Token: 0x04001EBA RID: 7866
	[Token(Token = "0x4001EBA")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout RemovalBacking;

	// Token: 0x04001EBB RID: 7867
	[Token(Token = "0x4001EBB")]
	[FieldOffset(Offset = "0x40")]
	public FadeString_Layout TooltipDisplay;
}
