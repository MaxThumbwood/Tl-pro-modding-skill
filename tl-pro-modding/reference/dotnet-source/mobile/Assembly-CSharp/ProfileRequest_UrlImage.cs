using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000320 RID: 800
[Token(Token = "0x2000320")]
public class ProfileRequest_UrlImage : ProfileRequest
{
	// Token: 0x060013C8 RID: 5064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0xDAB0E0", Offset = "0xDAB0E0", VA = "0xDAB0E0")]
	protected ProfileRequest_UrlImage(PlatformUser user, ProfileEntry result)
	{
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0xDAB6AC", Offset = "0xDAB6AC", VA = "0xDAB6AC")]
	protected void BeginURL(string url)
	{
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00008F28 File Offset: 0x00007128
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0xDAB114", Offset = "0xDAB114", VA = "0xDAB114", Slot = "5")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x04002791 RID: 10129
	[Token(Token = "0x4002791")]
	[FieldOffset(Offset = "0x14")]
	protected bool isDone;

	// Token: 0x04002792 RID: 10130
	[Token(Token = "0x4002792")]
	[FieldOffset(Offset = "0x18")]
	private WWW _www;
}
