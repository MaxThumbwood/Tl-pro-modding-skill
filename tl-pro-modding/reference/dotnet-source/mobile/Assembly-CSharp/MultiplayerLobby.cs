using System;
using Il2CppDummyDll;

// Token: 0x02000227 RID: 551
[Token(Token = "0x2000227")]
[Serializable]
public class MultiplayerLobby
{
	// Token: 0x06000E0E RID: 3598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0xC90ED8", Offset = "0xC90ED8", VA = "0xC90ED8")]
	public MultiplayerLobby()
	{
	}

	// Token: 0x040017E4 RID: 6116
	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0x0")]
	public static FavoriteIcons Instance;

	// Token: 0x040017E5 RID: 6117
	[Token(Token = "0x40017E5")]
	[FieldOffset(Offset = "0x8")]
	public Texture_Layout Normal;

	// Token: 0x040017E6 RID: 6118
	[Token(Token = "0x40017E6")]
	[FieldOffset(Offset = "0xC")]
	public Texture_Layout Disabled;
}
