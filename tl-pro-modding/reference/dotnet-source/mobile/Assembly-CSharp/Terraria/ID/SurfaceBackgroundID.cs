using System;
using Il2CppDummyDll;
using ReLogic.Reflection;

namespace Terraria.ID
{
	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	public class SurfaceBackgroundID
	{
		// Token: 0x060041F9 RID: 16889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x4E4E10", Offset = "0x4E4E10", VA = "0x4E4E10")]
		public SurfaceBackgroundID()
		{
		}

		// Token: 0x040083D5 RID: 33749
		[Token(Token = "0x40083D5")]
		public const int Forest1 = 0;

		// Token: 0x040083D6 RID: 33750
		[Token(Token = "0x40083D6")]
		public const int Corruption = 1;

		// Token: 0x040083D7 RID: 33751
		[Token(Token = "0x40083D7")]
		public const int Desert = 2;

		// Token: 0x040083D8 RID: 33752
		[Token(Token = "0x40083D8")]
		public const int Jungle = 3;

		// Token: 0x040083D9 RID: 33753
		[Token(Token = "0x40083D9")]
		public const int Ocean = 4;

		// Token: 0x040083DA RID: 33754
		[Token(Token = "0x40083DA")]
		public const int CorruptDesert = 5;

		// Token: 0x040083DB RID: 33755
		[Token(Token = "0x40083DB")]
		public const int Hallow = 6;

		// Token: 0x040083DC RID: 33756
		[Token(Token = "0x40083DC")]
		public const int Snow = 7;

		// Token: 0x040083DD RID: 33757
		[Token(Token = "0x40083DD")]
		public const int Crimson = 8;

		// Token: 0x040083DE RID: 33758
		[Token(Token = "0x40083DE")]
		public const int Mushroom = 9;

		// Token: 0x040083DF RID: 33759
		[Token(Token = "0x40083DF")]
		public const int Forest2 = 10;

		// Token: 0x040083E0 RID: 33760
		[Token(Token = "0x40083E0")]
		public const int Forest3 = 11;

		// Token: 0x040083E1 RID: 33761
		[Token(Token = "0x40083E1")]
		public const int Forest4 = 12;

		// Token: 0x040083E2 RID: 33762
		[Token(Token = "0x40083E2")]
		public const int HallowDesert = 13;

		// Token: 0x040083E3 RID: 33763
		[Token(Token = "0x40083E3")]
		public const int CrimsonDesert = 14;

		// Token: 0x040083E4 RID: 33764
		[Token(Token = "0x40083E4")]
		public const int Empty = 15;

		// Token: 0x040083E5 RID: 33765
		[Token(Token = "0x40083E5")]
		public const int Count = 16;

		// Token: 0x040083E6 RID: 33766
		[Token(Token = "0x40083E6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IdDictionary Search;

		// Token: 0x02000718 RID: 1816
		[Token(Token = "0x2000718")]
		public static class Sets
		{
			// Token: 0x040083E7 RID: 33767
			[Token(Token = "0x40083E7")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x040083E8 RID: 33768
			[Token(Token = "0x40083E8")]
			[FieldOffset(Offset = "0x4")]
			public static bool[] IsDesertVariant;

			// Token: 0x040083E9 RID: 33769
			[Token(Token = "0x40083E9")]
			[FieldOffset(Offset = "0x8")]
			public static bool[] IsForest;
		}
	}
}
