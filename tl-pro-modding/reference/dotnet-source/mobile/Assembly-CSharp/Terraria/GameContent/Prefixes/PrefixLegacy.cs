using System;
using Il2CppDummyDll;
using Terraria.ID;

namespace Terraria.GameContent.Prefixes
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	public class PrefixLegacy
	{
		// Token: 0x060053CE RID: 21454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0x80946C", Offset = "0x80946C", VA = "0x80946C")]
		public PrefixLegacy()
		{
		}

		// Token: 0x02000A15 RID: 2581
		[Token(Token = "0x2000A15")]
		public class Prefixes
		{
			// Token: 0x060053CF RID: 21455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053CF")]
			[Address(RVA = "0x809474", Offset = "0x809474", VA = "0x809474")]
			public Prefixes()
			{
			}

			// Token: 0x04009792 RID: 38802
			[Token(Token = "0x4009792")]
			[FieldOffset(Offset = "0x0")]
			public static int[] PrefixesForSwords;

			// Token: 0x04009793 RID: 38803
			[Token(Token = "0x4009793")]
			[FieldOffset(Offset = "0x4")]
			public static int[] PrefixesForSpears;

			// Token: 0x04009794 RID: 38804
			[Token(Token = "0x4009794")]
			[FieldOffset(Offset = "0x8")]
			public static int[] PrefixesForGunsBows;

			// Token: 0x04009795 RID: 38805
			[Token(Token = "0x4009795")]
			[FieldOffset(Offset = "0xC")]
			public static int[] PrefixesForMagic;

			// Token: 0x04009796 RID: 38806
			[Token(Token = "0x4009796")]
			[FieldOffset(Offset = "0x10")]
			public static int[] PrefixesForSummons;

			// Token: 0x04009797 RID: 38807
			[Token(Token = "0x4009797")]
			[FieldOffset(Offset = "0x14")]
			public static int[] PrefixesForBoomeransAndChakrums;

			// Token: 0x04009798 RID: 38808
			[Token(Token = "0x4009798")]
			[FieldOffset(Offset = "0x18")]
			public static int[] PrefixesForBoomeransAndChakrums_TerrarianYoyo;

			// Token: 0x04009799 RID: 38809
			[Token(Token = "0x4009799")]
			[FieldOffset(Offset = "0x1C")]
			public static int[] PrefixesForAccessories;
		}

		// Token: 0x02000A16 RID: 2582
		[Token(Token = "0x2000A16")]
		public class ItemSets
		{
			// Token: 0x060053D1 RID: 21457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053D1")]
			[Address(RVA = "0x8096F8", Offset = "0x8096F8", VA = "0x8096F8")]
			public ItemSets()
			{
			}

			// Token: 0x0400979A RID: 38810
			[Token(Token = "0x400979A")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x0400979B RID: 38811
			[Token(Token = "0x400979B")]
			[FieldOffset(Offset = "0x4")]
			public static bool[] BoomerangsChakrams;

			// Token: 0x0400979C RID: 38812
			[Token(Token = "0x400979C")]
			[FieldOffset(Offset = "0x8")]
			public static bool[] ItemsThatCanHaveLegendary2;

			// Token: 0x0400979D RID: 38813
			[Token(Token = "0x400979D")]
			[FieldOffset(Offset = "0xC")]
			public static bool[] Magic;

			// Token: 0x0400979E RID: 38814
			[Token(Token = "0x400979E")]
			[FieldOffset(Offset = "0x10")]
			public static bool[] Summon;

			// Token: 0x0400979F RID: 38815
			[Token(Token = "0x400979F")]
			[FieldOffset(Offset = "0x14")]
			public static bool[] GunsBows;

			// Token: 0x040097A0 RID: 38816
			[Token(Token = "0x40097A0")]
			[FieldOffset(Offset = "0x18")]
			public static bool[] SpearsMacesChainsawsDrillsPunchCannon;

			// Token: 0x040097A1 RID: 38817
			[Token(Token = "0x40097A1")]
			[FieldOffset(Offset = "0x1C")]
			public static bool[] SwordsHammersAxesPicks;
		}
	}
}
