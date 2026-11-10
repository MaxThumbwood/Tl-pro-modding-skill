using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class Logo_Layout : LayoutDefinition
{
	// Token: 0x06000DFC RID: 3580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0xC90800", Offset = "0xC90800", VA = "0xC90800")]
	private void Awake()
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0xC90854", Offset = "0xC90854", VA = "0xC90854")]
	public Logo_Layout()
	{
	}

	// Token: 0x0400173B RID: 5947
	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x0")]
	public static Logo_Layout Instance;

	// Token: 0x0400173C RID: 5948
	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0xC")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x0400173D RID: 5949
	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0x10")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x0400173E RID: 5950
	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 Location;

	// Token: 0x0400173F RID: 5951
	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x1C")]
	public float Scale;
}
