using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C19 RID: 3097
	[Token(Token = "0x2000C19")]
	public interface IProvideSearchFilterString
	{
		// Token: 0x06005CDD RID: 23773
		[Token(Token = "0x6005CDD")]
		string GetSearchString(ref BestiaryUICollectionInfo info);
	}
}
