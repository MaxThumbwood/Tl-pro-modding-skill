using System;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A68 RID: 2664
	[Token(Token = "0x2000A68")]
	public class ItemVariantCondition
	{
		// Token: 0x06005518 RID: 21784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005518")]
		[Address(RVA = "0x824508", Offset = "0x824508", VA = "0x824508")]
		public ItemVariantCondition(NetworkText description, ItemVariantCondition.Condition condition)
		{
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x82452C", Offset = "0x82452C", VA = "0x82452C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04009871 RID: 39025
		[Token(Token = "0x4009871")]
		[FieldOffset(Offset = "0x8")]
		public readonly NetworkText Description;

		// Token: 0x04009872 RID: 39026
		[Token(Token = "0x4009872")]
		[FieldOffset(Offset = "0xC")]
		public readonly ItemVariantCondition.Condition IsMet;

		// Token: 0x02000A69 RID: 2665
		// (Invoke) Token: 0x0600551B RID: 21787
		[Token(Token = "0x2000A69")]
		public delegate bool Condition();
	}
}
