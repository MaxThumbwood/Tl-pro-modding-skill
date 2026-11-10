using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
public class AccessoryInfo_Layout : LayoutDefinition
{
	// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0xC66198", Offset = "0xC66198", VA = "0xC66198")]
	private void Awake()
	{
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0xC661EC", Offset = "0xC661EC", VA = "0xC661EC")]
	public AccessoryInfo_Layout()
	{
	}

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x0")]
	public static AccessoryInfo_Layout Instance;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout IconGrid;

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x10")]
	public ItemGrid_Layout IconGridSecondary;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout ItemText;

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout DisabledItemText;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x1C")]
	public String_Layout CritterItemText;

	// Token: 0x04000F7A RID: 3962
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x20")]
	public float ItemScale;

	// Token: 0x04000F7B RID: 3963
	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x24")]
	public Color IconColour;

	// Token: 0x04000F7C RID: 3964
	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x28")]
	public Color DisabledIconColour;

	// Token: 0x04000F7D RID: 3965
	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout Backing;

	// Token: 0x04000F7E RID: 3966
	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 BackingTLOffset;

	// Token: 0x04000F7F RID: 3967
	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 BackingBROffset;
}
