using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BFA RID: 3066
	[Token(Token = "0x2000BFA")]
	public struct BestiaryUICollectionInfo
	{
		// Token: 0x04009D03 RID: 40195
		[Token(Token = "0x4009D03")]
		[FieldOffset(Offset = "0x0")]
		public BestiaryEntry OwnerEntry;

		// Token: 0x04009D04 RID: 40196
		[Token(Token = "0x4009D04")]
		[FieldOffset(Offset = "0x4")]
		public BestiaryEntryUnlockState UnlockState;
	}
}
