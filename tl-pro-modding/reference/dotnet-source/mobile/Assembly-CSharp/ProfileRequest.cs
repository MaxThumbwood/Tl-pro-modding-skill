using System;
using Il2CppDummyDll;

// Token: 0x0200031C RID: 796
[Token(Token = "0x200031C")]
public class ProfileRequest
{
	// Token: 0x060013BA RID: 5050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0xDAB07C", Offset = "0xDAB07C", VA = "0xDAB07C")]
	protected ProfileRequest(PlatformUser user, ProfileEntry entry)
	{
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0xDAB0A8", Offset = "0xDAB0A8", VA = "0xDAB0A8", Slot = "4")]
	public virtual void Begin()
	{
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00008EC8 File Offset: 0x000070C8
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0xDAB0AC", Offset = "0xDAB0AC", VA = "0xDAB0AC", Slot = "5")]
	public virtual bool Update()
	{
		return default(bool);
	}

	// Token: 0x0400278D RID: 10125
	[Token(Token = "0x400278D")]
	[FieldOffset(Offset = "0x8")]
	public readonly PlatformUser User;

	// Token: 0x0400278E RID: 10126
	[Token(Token = "0x400278E")]
	[FieldOffset(Offset = "0x10")]
	public readonly ProfileEntry Result;
}
