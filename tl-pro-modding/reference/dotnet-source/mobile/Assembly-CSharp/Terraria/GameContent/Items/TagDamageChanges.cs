using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public struct TagDamageChanges
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x000275B8 File Offset: 0x000257B8
		[Token(Token = "0x170009D4")]
		public static TagDamageChanges None
		{
			[Token(Token = "0x6005533")]
			[Address(RVA = "0x8269B8", Offset = "0x8269B8", VA = "0x8269B8")]
			get
			{
				return default(TagDamageChanges);
			}
		}

		// Token: 0x04009883 RID: 39043
		[Token(Token = "0x4009883")]
		[FieldOffset(Offset = "0x0")]
		public bool AddProjectileTagDamage;

		// Token: 0x04009884 RID: 39044
		[Token(Token = "0x4009884")]
		[FieldOffset(Offset = "0x4")]
		public int AddedBaseDamage;

		// Token: 0x04009885 RID: 39045
		[Token(Token = "0x4009885")]
		[FieldOffset(Offset = "0x8")]
		public int AddedFlatDamage;

		// Token: 0x04009886 RID: 39046
		[Token(Token = "0x4009886")]
		[FieldOffset(Offset = "0xC")]
		public float TotalDamageMultiplier;

		// Token: 0x04009887 RID: 39047
		[Token(Token = "0x4009887")]
		[FieldOffset(Offset = "0x10")]
		public bool? Crit;

		// Token: 0x04009888 RID: 39048
		[Token(Token = "0x4009888")]
		[FieldOffset(Offset = "0x14")]
		public int HighestAddedBaseDamage;
	}
}
