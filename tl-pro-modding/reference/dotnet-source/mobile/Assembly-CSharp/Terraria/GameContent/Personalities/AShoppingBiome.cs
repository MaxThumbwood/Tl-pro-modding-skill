using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000A1C")]
	public abstract class AShoppingBiome
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C4")]
		public string NameKey
		{
			[Token(Token = "0x60053E4")]
			[Address(RVA = "0x80C698", Offset = "0x80C698", VA = "0x80C698")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E5")]
			[Address(RVA = "0x80C6A0", Offset = "0x80C6A0", VA = "0x80C6A0")]
			protected set
			{
			}
		}

		// Token: 0x060053E6 RID: 21478
		[Token(Token = "0x60053E6")]
		public abstract bool IsInBiome(Player player);

		// Token: 0x060053E7 RID: 21479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x80C6A8", Offset = "0x80C6A8", VA = "0x80C6A8")]
		protected AShoppingBiome()
		{
		}

		// Token: 0x040097AA RID: 38826
		[Token(Token = "0x40097AA")]
		[FieldOffset(Offset = "0x8")]
		private string <NameKey>k__BackingField;
	}
}
