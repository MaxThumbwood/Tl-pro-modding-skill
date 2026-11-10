using System;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	public static class ImmunityCooldownID
	{
		// Token: 0x04005D18 RID: 23832
		[Token(Token = "0x4005D18")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int General;

		// Token: 0x04005D19 RID: 23833
		[Token(Token = "0x4005D19")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int TileContactDamage;

		// Token: 0x04005D1A RID: 23834
		[Token(Token = "0x4005D1A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int BossNoCheese;

		// Token: 0x04005D1B RID: 23835
		[Token(Token = "0x4005D1B")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int LegacyUnused2;

		// Token: 0x04005D1C RID: 23836
		[Token(Token = "0x4005D1C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int WrongBugNet;

		// Token: 0x04005D1D RID: 23837
		[Token(Token = "0x4005D1D")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int Lava;

		// Token: 0x04005D1E RID: 23838
		[Token(Token = "0x4005D1E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int PaladinsShield;

		// Token: 0x04005D1F RID: 23839
		[Token(Token = "0x4005D1F")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int Count;

		// Token: 0x020006E0 RID: 1760
		[Token(Token = "0x20006E0")]
		public static class Sets
		{
			// Token: 0x0600417F RID: 16767 RVA: 0x000200B8 File Offset: 0x0001E2B8
			[Token(Token = "0x600417F")]
			[Address(RVA = "0x1F0707C", Offset = "0x1F0707C", VA = "0x1F0707C")]
			public static ImmunityCooldownID.Sets.BoolSet CreateBoolSet(int[] types)
			{
				return default(ImmunityCooldownID.Sets.BoolSet);
			}

			// Token: 0x04005D20 RID: 23840
			[Token(Token = "0x4005D20")]
			[FieldOffset(Offset = "0x0")]
			public static ImmunityCooldownID.Sets.BoolSet Retaliate;

			// Token: 0x04005D21 RID: 23841
			[Token(Token = "0x4005D21")]
			[FieldOffset(Offset = "0x4")]
			public static ImmunityCooldownID.Sets.BoolSet Counter;

			// Token: 0x04005D22 RID: 23842
			[Token(Token = "0x4005D22")]
			[FieldOffset(Offset = "0x8")]
			public static ImmunityCooldownID.Sets.BoolSet TeamDamageShare;

			// Token: 0x04005D23 RID: 23843
			[Token(Token = "0x4005D23")]
			[FieldOffset(Offset = "0xC")]
			public static ImmunityCooldownID.Sets.BoolSet ImmuneTimerOnlyLimitsEffects;

			// Token: 0x020006E1 RID: 1761
			[Token(Token = "0x20006E1")]
			public struct BoolSet
			{
				// Token: 0x17000814 RID: 2068
				// (get) Token: 0x06004181 RID: 16769 RVA: 0x000200D0 File Offset: 0x0001E2D0
				// (set) Token: 0x06004182 RID: 16770 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000814")]
				public bool Item
				{
					[Token(Token = "0x6004181")]
					[Address(RVA = "0x1F07414", Offset = "0x1F07414", VA = "0x1F07414")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6004182")]
					[Address(RVA = "0x1F071E0", Offset = "0x1F071E0", VA = "0x1F071E0")]
					set
					{
					}
				}

				// Token: 0x06004183 RID: 16771 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004183")]
				[Address(RVA = "0x1F07184", Offset = "0x1F07184", VA = "0x1F07184")]
				public BoolSet(int count)
				{
				}

				// Token: 0x04005D24 RID: 23844
				[Token(Token = "0x4005D24")]
				[FieldOffset(Offset = "0x0")]
				private readonly bool[] _arr;
			}
		}
	}
}
