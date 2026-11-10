using System;
using Il2CppDummyDll;

// Token: 0x0200024B RID: 587
[Token(Token = "0x200024B")]
[Serializable]
public class SelectWorldFavoriteIcons
{
	// Token: 0x06000E4B RID: 3659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0xC9370C", Offset = "0xC9370C", VA = "0xC9370C")]
	public SelectWorldFavoriteIcons()
	{
	}

	// Token: 0x04001AC9 RID: 6857
	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0x0")]
	public static FavoriteIcons Instance;

	// Token: 0x04001ACA RID: 6858
	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x8")]
	public Texture_Layout Normal;

	// Token: 0x04001ACB RID: 6859
	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0xC")]
	public Texture_Layout Disabled;
}
