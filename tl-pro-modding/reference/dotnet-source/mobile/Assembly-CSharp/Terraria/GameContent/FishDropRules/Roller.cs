using System;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	public class Roller
	{
		// Token: 0x060057FE RID: 22526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x85C188", Offset = "0x85C188", VA = "0x85C188")]
		public void Roll(Projectile projectile, FishingAttempt fisher)
		{
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0x85C294", Offset = "0x85C294", VA = "0x85C294")]
		public Roller()
		{
		}

		// Token: 0x04009962 RID: 39266
		[Token(Token = "0x4009962")]
		[FieldOffset(Offset = "0x8")]
		private FishingContext _context;

		// Token: 0x04009963 RID: 39267
		[Token(Token = "0x4009963")]
		[FieldOffset(Offset = "0xC")]
		private FishDropRuleList _ruleList;
	}
}
