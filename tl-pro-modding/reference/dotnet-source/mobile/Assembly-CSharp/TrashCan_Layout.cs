using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200026A RID: 618
[Token(Token = "0x200026A")]
public class TrashCan_Layout : PageControllerLayoutDefinition<TrashCan_Layout>
{
	// Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0xC99CBC", Offset = "0xC99CBC", VA = "0xC99CBC")]
	public TrashCan_Layout()
	{
	}

	// Token: 0x04001DC5 RID: 7621
	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0x10")]
	public float ItemScale;

	// Token: 0x04001DC6 RID: 7622
	[Token(Token = "0x4001DC6")]
	[FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout TrashGrid;

	// Token: 0x04001DC7 RID: 7623
	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0x18")]
	public float ItemHighlightScale;

	// Token: 0x04001DC8 RID: 7624
	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0x1C")]
	public Color BackingColour;
}
