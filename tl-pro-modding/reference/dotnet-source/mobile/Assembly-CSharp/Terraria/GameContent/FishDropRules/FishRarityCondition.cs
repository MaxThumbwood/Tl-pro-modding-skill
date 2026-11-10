using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	public abstract class FishRarityCondition
	{
		// Token: 0x06005802 RID: 22530
		[Token(Token = "0x6005802")]
		public abstract bool Matches(FishingContext context);

		// Token: 0x06005803 RID: 22531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005803")]
		[Address(RVA = "0x853BB8", Offset = "0x853BB8", VA = "0x853BB8")]
		protected FishRarityCondition()
		{
		}

		// Token: 0x04009965 RID: 39269
		[Token(Token = "0x4009965")]
		[FieldOffset(Offset = "0x8")]
		public float FrequencyOfAppearanceForVisuals;

		// Token: 0x04009966 RID: 39270
		[Token(Token = "0x4009966")]
		[FieldOffset(Offset = "0xC")]
		public bool HackedIsAny;
	}
}
