using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BCB RID: 3019
	[Token(Token = "0x2000BCB")]
	public struct BestiaryUnlockProgressReport
	{
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[Token(Token = "0x17000A35")]
		public float CompletionPercent
		{
			[Token(Token = "0x6005BA4")]
			[Address(RVA = "0x991E40", Offset = "0x991E40", VA = "0x991E40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04009C42 RID: 40002
		[Token(Token = "0x4009C42")]
		[FieldOffset(Offset = "0x0")]
		public int EntriesTotal;

		// Token: 0x04009C43 RID: 40003
		[Token(Token = "0x4009C43")]
		[FieldOffset(Offset = "0x4")]
		public float CompletionAmountTotal;
	}
}
