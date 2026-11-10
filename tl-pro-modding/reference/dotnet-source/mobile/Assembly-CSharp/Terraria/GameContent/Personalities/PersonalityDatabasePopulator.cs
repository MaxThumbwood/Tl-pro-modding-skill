using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A1B RID: 2587
	[Token(Token = "0x2000A1B")]
	public class PersonalityDatabasePopulator
	{
		// Token: 0x060053E1 RID: 21473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x80A6CC", Offset = "0x80A6CC", VA = "0x80A6CC")]
		public void Populate(PersonalityDatabase database)
		{
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x80A6D4", Offset = "0x80A6D4", VA = "0x80A6D4")]
		private void Populate_BiomePreferences(PersonalityDatabase database)
		{
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x80C690", Offset = "0x80C690", VA = "0x80C690")]
		public PersonalityDatabasePopulator()
		{
		}

		// Token: 0x040097A9 RID: 38825
		[Token(Token = "0x40097A9")]
		[FieldOffset(Offset = "0x8")]
		private PersonalityDatabase _currentDatabase;
	}
}
