using System;
using Il2CppDummyDll;

// Token: 0x02000321 RID: 801
[Token(Token = "0x2000321")]
public class ProfileRequest_XBO : ProfileRequest_UrlImage
{
	// Token: 0x060013CB RID: 5067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0xDAB724", Offset = "0xDAB724", VA = "0xDAB724")]
	public ProfileRequest_XBO(PlatformUser account, ProfileEntry entry)
	{
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00008F40 File Offset: 0x00007140
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0xDAB750", Offset = "0xDAB750", VA = "0xDAB750", Slot = "5")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0xDAB754", Offset = "0xDAB754", VA = "0xDAB754")]
	private void CheckProfileLoaded()
	{
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0xDAB758", Offset = "0xDAB758", VA = "0xDAB758", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x04002793 RID: 10131
	[Token(Token = "0x4002793")]
	[FieldOffset(Offset = "0x1C")]
	private bool hasStartedLoadingImage;
}
