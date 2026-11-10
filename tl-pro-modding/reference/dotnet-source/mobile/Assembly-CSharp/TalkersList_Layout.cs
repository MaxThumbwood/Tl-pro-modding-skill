using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
public class TalkersList_Layout : LayoutDefinition
{
	// Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0xC99AFC", Offset = "0xC99AFC", VA = "0xC99AFC")]
	private void Awake()
	{
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0xC99B50", Offset = "0xC99B50", VA = "0xC99B50")]
	public TalkersList_Layout()
	{
	}

	// Token: 0x04001DB9 RID: 7609
	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x0")]
	public static TalkersList_Layout Instance;

	// Token: 0x04001DBA RID: 7610
	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout IconGrid;

	// Token: 0x04001DBB RID: 7611
	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout ItemText;

	// Token: 0x04001DBC RID: 7612
	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x04001DBD RID: 7613
	[Token(Token = "0x4001DBD")]
	[FieldOffset(Offset = "0x18")]
	public Color IconColour;

	// Token: 0x04001DBE RID: 7614
	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x1C")]
	public Texture_Layout Icon;

	// Token: 0x04001DBF RID: 7615
	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04001DC0 RID: 7616
	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 BackingTLOffset;

	// Token: 0x04001DC1 RID: 7617
	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 BackingBROffset;
}
