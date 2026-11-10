using System;
using Il2CppDummyDll;

// Token: 0x020001FD RID: 509
[Token(Token = "0x20001FD")]
[Serializable]
public class FavoriteIcons
{
	// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0xC8A1DC", Offset = "0xC8A1DC", VA = "0xC8A1DC")]
	public FavoriteIcons()
	{
	}

	// Token: 0x04001585 RID: 5509
	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x0")]
	public static FavoriteIcons Instance;

	// Token: 0x04001586 RID: 5510
	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x8")]
	public Texture_Layout Normal;

	// Token: 0x04001587 RID: 5511
	[Token(Token = "0x4001587")]
	[FieldOffset(Offset = "0xC")]
	public Texture_Layout NormalSelected;

	// Token: 0x04001588 RID: 5512
	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x10")]
	public Texture_Layout Favorite;

	// Token: 0x04001589 RID: 5513
	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x14")]
	public Texture_Layout FavoriteSelected;

	// Token: 0x0400158A RID: 5514
	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
