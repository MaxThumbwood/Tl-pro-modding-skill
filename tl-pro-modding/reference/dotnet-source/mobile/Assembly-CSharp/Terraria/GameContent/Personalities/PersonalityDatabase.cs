using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	public class PersonalityDatabase
	{
		// Token: 0x060053DD RID: 21469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x80A138", Offset = "0x80A138", VA = "0x80A138")]
		public PersonalityDatabase()
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DE")]
		[Address(RVA = "0x80A32C", Offset = "0x80A32C", VA = "0x80A32C")]
		public void Register(int npcId, IShopPersonalityTrait trait)
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DF")]
		[Address(RVA = "0x80A57C", Offset = "0x80A57C", VA = "0x80A57C")]
		public void Register(IShopPersonalityTrait trait, int[] npcIds)
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x80A63C", Offset = "0x80A63C", VA = "0x80A63C")]
		public PersonalityProfile GetByNPCID(int npcId)
		{
			return null;
		}

		// Token: 0x040097A7 RID: 38823
		[Token(Token = "0x40097A7")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, PersonalityProfile> _personalityProfiles;

		// Token: 0x040097A8 RID: 38824
		[Token(Token = "0x40097A8")]
		[FieldOffset(Offset = "0xC")]
		private PersonalityProfile _trashEntry;
	}
}
