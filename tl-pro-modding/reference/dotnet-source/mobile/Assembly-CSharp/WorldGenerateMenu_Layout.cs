using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000248 RID: 584
[Token(Token = "0x2000248")]
public class WorldGenerateMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0xC93328", Offset = "0xC93328", VA = "0xC93328")]
	private void Awake()
	{
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0xC9337C", Offset = "0xC9337C", VA = "0xC9337C")]
	public WorldGenerateMenu_Layout()
	{
	}

	// Token: 0x04001A87 RID: 6791
	[Token(Token = "0x4001A87")]
	[FieldOffset(Offset = "0x0")]
	public static WorldGenerateMenu_Layout Instance;

	// Token: 0x04001A88 RID: 6792
	[Token(Token = "0x4001A88")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout Status;

	// Token: 0x04001A89 RID: 6793
	[Token(Token = "0x4001A89")]
	[FieldOffset(Offset = "0x10")]
	public ProgressBar_Layout Progress;

	// Token: 0x04001A8A RID: 6794
	[Token(Token = "0x4001A8A")]
	[FieldOffset(Offset = "0x14")]
	public ProgressBar_Layout StageProgress;

	// Token: 0x04001A8B RID: 6795
	[Token(Token = "0x4001A8B")]
	[FieldOffset(Offset = "0x18")]
	public Texture_Layout BackingCorrupt;

	// Token: 0x04001A8C RID: 6796
	[Token(Token = "0x4001A8C")]
	[FieldOffset(Offset = "0x1C")]
	public Texture_Layout BackingCrimson;

	// Token: 0x04001A8D RID: 6797
	[Token(Token = "0x4001A8D")]
	[FieldOffset(Offset = "0x20")]
	public Texture_Layout BackingRandom;

	// Token: 0x04001A8E RID: 6798
	[Token(Token = "0x4001A8E")]
	[FieldOffset(Offset = "0x24")]
	public Color FillingColorCorrupt;

	// Token: 0x04001A8F RID: 6799
	[Token(Token = "0x4001A8F")]
	[FieldOffset(Offset = "0x28")]
	public Color FillingColorCrimson;

	// Token: 0x04001A90 RID: 6800
	[Token(Token = "0x4001A90")]
	[FieldOffset(Offset = "0x2C")]
	public Color FillingColorRandom;

	// Token: 0x04001A91 RID: 6801
	[Token(Token = "0x4001A91")]
	[FieldOffset(Offset = "0x30")]
	public String_Layout GameTip;
}
