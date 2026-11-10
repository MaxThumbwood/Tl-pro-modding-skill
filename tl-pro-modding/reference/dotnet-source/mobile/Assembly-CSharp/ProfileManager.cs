using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000322 RID: 802
[Token(Token = "0x2000322")]
public class ProfileManager
{
	// Token: 0x060013CF RID: 5071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0xDAB75C", Offset = "0xDAB75C", VA = "0xDAB75C")]
	private ProfileManager()
	{
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0xDAB92C", Offset = "0xDAB92C", VA = "0xDAB92C")]
	private void RequestProfile(PlatformUser user, ProfileEntry entry)
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0xDABB44", Offset = "0xDABB44", VA = "0xDABB44")]
	public void ClearCache()
	{
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0xDABC7C", Offset = "0xDABC7C", VA = "0xDABC7C")]
	public ProfileEntry GetProfile(PlatformUser user)
	{
		return null;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0xDABE00", Offset = "0xDABE00", VA = "0xDABE00")]
	public void Update()
	{
	}

	// Token: 0x04002794 RID: 10132
	[Token(Token = "0x4002794")]
	[FieldOffset(Offset = "0x0")]
	public static ProfileManager Instance;

	// Token: 0x04002795 RID: 10133
	[Token(Token = "0x4002795")]
	[FieldOffset(Offset = "0x8")]
	private ConcurrentDictionary<string, ProfileEntry>[] Profiles;

	// Token: 0x04002796 RID: 10134
	[Token(Token = "0x4002796")]
	private const int MaxActiveRequests = 10;

	// Token: 0x04002797 RID: 10135
	[Token(Token = "0x4002797")]
	[FieldOffset(Offset = "0xC")]
	private List<ProfileRequest> activeRequests;

	// Token: 0x04002798 RID: 10136
	[Token(Token = "0x4002798")]
	[FieldOffset(Offset = "0x10")]
	private List<ProfileRequest> pendingRequests;
}
