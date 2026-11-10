using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031F RID: 799
[Token(Token = "0x200031F")]
public class ProfileRequest_Steam : ProfileRequest_UrlImage
{
	// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0xDAB2CC", Offset = "0xDAB2CC", VA = "0xDAB2CC")]
	public ProfileRequest_Steam(PlatformUser user, ProfileEntry entry)
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0xDAB2F8", Offset = "0xDAB2F8", VA = "0xDAB2F8", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00008F10 File Offset: 0x00007110
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0xDAB3BC", Offset = "0xDAB3BC", VA = "0xDAB3BC", Slot = "5")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0xDAB4C4", Offset = "0xDAB4C4", VA = "0xDAB4C4")]
	private string ExtractImageURL(string xmlData)
	{
		return null;
	}

	// Token: 0x04002790 RID: 10128
	[Token(Token = "0x4002790")]
	[FieldOffset(Offset = "0x1C")]
	private WWW _xmlDownload;
}
