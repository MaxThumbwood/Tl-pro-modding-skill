using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	public abstract class AFishingCondition
	{
		// Token: 0x06005800 RID: 22528
		[Token(Token = "0x6005800")]
		public abstract bool Matches(FishingContext context);

		// Token: 0x06005801 RID: 22529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005801")]
		[Address(RVA = "0x853B04", Offset = "0x853B04", VA = "0x853B04")]
		protected AFishingCondition()
		{
		}

		// Token: 0x04009964 RID: 39268
		[Token(Token = "0x4009964")]
		[FieldOffset(Offset = "0x8")]
		public bool CanBeSkippedForDisplay;
	}
}
