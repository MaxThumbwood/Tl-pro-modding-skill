using System;
using Il2CppDummyDll;

// Token: 0x0200031E RID: 798
[Token(Token = "0x200031E")]
public class ProfileRequest_PSN : ProfileRequest_UrlImage
{
	// Token: 0x060013C0 RID: 5056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0xDAB294", Offset = "0xDAB294", VA = "0xDAB294")]
	public ProfileRequest_PSN(PlatformUser user, ProfileEntry entry)
	{
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0xDAB2C0", Offset = "0xDAB2C0", VA = "0xDAB2C0", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0xDAB2C4", Offset = "0xDAB2C4", VA = "0xDAB2C4")]
	private void TryFindProfile()
	{
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00008EF8 File Offset: 0x000070F8
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0xDAB2C8", Offset = "0xDAB2C8", VA = "0xDAB2C8", Slot = "5")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0400278F RID: 10127
	[Token(Token = "0x400278F")]
	[FieldOffset(Offset = "0x1C")]
	private bool profileFound;
}
