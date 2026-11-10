using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200031B RID: 795
[Token(Token = "0x200031B")]
public class ProfileEntry
{
	// Token: 0x060013B9 RID: 5049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0xDAB018", Offset = "0xDAB018", VA = "0xDAB018")]
	public ProfileEntry()
	{
	}

	// Token: 0x0400278B RID: 10123
	[Token(Token = "0x400278B")]
	[FieldOffset(Offset = "0x8")]
	public string Name;

	// Token: 0x0400278C RID: 10124
	[Token(Token = "0x400278C")]
	[FieldOffset(Offset = "0xC")]
	public Texture2D Image;
}
