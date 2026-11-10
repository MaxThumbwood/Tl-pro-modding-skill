using System;
using Il2CppDummyDll;

// Token: 0x02000319 RID: 793
[Token(Token = "0x2000319")]
public struct PlatformUser
{
	// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0xDAAE24", Offset = "0xDAAE24", VA = "0xDAAE24")]
	public PlatformUser(string id, PlatformUser.Platform platform)
	{
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00008EB0 File Offset: 0x000070B0
	[Token(Token = "0x170001DB")]
	public static PlatformUser CurrentUser
	{
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0xDAAE2C", Offset = "0xDAAE2C", VA = "0xDAAE2C")]
		get
		{
			return default(PlatformUser);
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0xDAAED8", Offset = "0xDAAED8", VA = "0xDAAED8")]
	public static PlatformUser[] GetFriends(bool ignoreCache)
	{
		return null;
	}

	// Token: 0x0400277E RID: 10110
	[Token(Token = "0x400277E")]
	[FieldOffset(Offset = "0x0")]
	public string PlayerId;

	// Token: 0x0400277F RID: 10111
	[Token(Token = "0x400277F")]
	[FieldOffset(Offset = "0x4")]
	public PlatformUser.Platform PlatformId;

	// Token: 0x04002780 RID: 10112
	[Token(Token = "0x4002780")]
	[FieldOffset(Offset = "0x0")]
	public static bool ForceFriendRefresh;

	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public enum Platform
	{
		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		None,
		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		Stadia,
		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		XBO,
		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		PSN,
		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		Editor,
		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		Nintendo,
		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		Steam,
		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		GameCenter,
		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		Count
	}
}
