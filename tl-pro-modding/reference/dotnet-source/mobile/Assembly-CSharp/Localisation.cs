using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
public class Localisation
{
	// Token: 0x060001E3 RID: 483 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x4AC454", Offset = "0x4AC454", VA = "0x4AC454")]
	private static SystemLanguage GetPS4SystemLanguage()
	{
		return SystemLanguage.Afrikaans;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x4AC45C", Offset = "0x4AC45C", VA = "0x4AC45C")]
	private static SystemLanguage GetSwitchSystemLanguage()
	{
		return SystemLanguage.Afrikaans;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x4AC464", Offset = "0x4AC464", VA = "0x4AC464")]
	public static int GetLanguage()
	{
		return 0;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x4AC654", Offset = "0x4AC654", VA = "0x4AC654")]
	public Localisation()
	{
	}

	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public enum SupportedLanguages
	{
		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		English = 1,
		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		German,
		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		Italian,
		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		French,
		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		Spanish,
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		Russian,
		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		Portuguese = 8,
		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		Japanese = 10
	}
}
