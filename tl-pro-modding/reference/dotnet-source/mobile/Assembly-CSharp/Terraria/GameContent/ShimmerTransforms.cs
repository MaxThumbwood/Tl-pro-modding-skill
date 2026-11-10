using System;
using Il2CppDummyDll;
using Terraria.Enums;

namespace Terraria.GameContent
{
	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20009CC")]
	public static class ShimmerTransforms
	{
		// Token: 0x060051DC RID: 20956 RVA: 0x000260E8 File Offset: 0x000242E8
		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x7D1DC8", Offset = "0x7D1DC8", VA = "0x7D1DC8")]
		public static int GetDecraftingRecipeIndex(int type)
		{
			return 0;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00026100 File Offset: 0x00024300
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x7D1FA8", Offset = "0x7D1FA8", VA = "0x7D1FA8")]
		public static bool IsItemTransformLocked(int type)
		{
			return default(bool);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00026118 File Offset: 0x00024318
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x7D207C", Offset = "0x7D207C", VA = "0x7D207C")]
		public static bool IsItemDecraftLocked(int type)
		{
			return default(bool);
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00026130 File Offset: 0x00024330
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x7D208C", Offset = "0x7D208C", VA = "0x7D208C")]
		public static bool IsRecipeIndexDecraftLocked(int recipeIndex)
		{
			return default(bool);
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00026148 File Offset: 0x00024348
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x7D21B8", Offset = "0x7D21B8", VA = "0x7D21B8")]
		public static bool IsItemDecraftableAndIsDecraftUnlocked(Item item)
		{
			return default(bool);
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x7D22A8", Offset = "0x7D22A8", VA = "0x7D22A8")]
		public static void UpdateRecipeSets()
		{
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00026160 File Offset: 0x00024360
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x7D2564", Offset = "0x7D2564", VA = "0x7D2564")]
		public static int GetTransformToItem(int type)
		{
			return 0;
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x00026178 File Offset: 0x00024378
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x7D27B8", Offset = "0x7D27B8", VA = "0x7D27B8")]
		private static int GetLunarBrickTransformFromMoonPhase(MoonPhase moonPhase)
		{
			return 0;
		}

		// Token: 0x020009CD RID: 2509
		[Token(Token = "0x20009CD")]
		public static class RecipeSets
		{
			// Token: 0x04009520 RID: 38176
			[Token(Token = "0x4009520")]
			[FieldOffset(Offset = "0x0")]
			public static bool[] PostSkeletron;

			// Token: 0x04009521 RID: 38177
			[Token(Token = "0x4009521")]
			[FieldOffset(Offset = "0x4")]
			public static bool[] PostGolem;
		}

		// Token: 0x020009CE RID: 2510
		[Token(Token = "0x20009CE")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060051E5 RID: 20965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051E5")]
			[Address(RVA = "0x7D284C", Offset = "0x7D284C", VA = "0x7D284C")]
			public <>c()
			{
			}

			// Token: 0x060051E6 RID: 20966 RVA: 0x00026190 File Offset: 0x00024390
			[Token(Token = "0x60051E6")]
			[Address(RVA = "0x7D2854", Offset = "0x7D2854", VA = "0x7D2854")]
			internal bool <UpdateRecipeSets>b__6_0(Recipe r)
			{
				return default(bool);
			}

			// Token: 0x060051E7 RID: 20967 RVA: 0x000261A8 File Offset: 0x000243A8
			[Token(Token = "0x60051E7")]
			[Address(RVA = "0x7D287C", Offset = "0x7D287C", VA = "0x7D287C")]
			internal bool <UpdateRecipeSets>b__6_1(Recipe r)
			{
				return default(bool);
			}

			// Token: 0x04009522 RID: 38178
			[Token(Token = "0x4009522")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ShimmerTransforms.<>c <>9;

			// Token: 0x04009523 RID: 38179
			[Token(Token = "0x4009523")]
			[FieldOffset(Offset = "0x4")]
			public static Func<Recipe, bool> <>9__6_0;

			// Token: 0x04009524 RID: 38180
			[Token(Token = "0x4009524")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Recipe, bool> <>9__6_1;
		}
	}
}
