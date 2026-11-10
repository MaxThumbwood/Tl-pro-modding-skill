using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	public class ItemDropRule
	{
		// Token: 0x06005581 RID: 21889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x829C8C", Offset = "0x829C8C", VA = "0x829C8C")]
		public static IItemDropRule Common(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x829D2C", Offset = "0x829D2C", VA = "0x829D2C")]
		public static IItemDropRule BossBag(int itemId)
		{
			return null;
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x829ED0", Offset = "0x829ED0", VA = "0x829ED0")]
		public static IItemDropRule BossBagByCondition(IItemDropRuleCondition condition, int itemId)
		{
			return null;
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005584")]
		[Address(RVA = "0x82A00C", Offset = "0x82A00C", VA = "0x82A00C")]
		public static IItemDropRule ExpertGetsRerolls(int itemId, int chanceDenominator, int expertRerolls)
		{
			return null;
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005585")]
		[Address(RVA = "0x82A20C", Offset = "0x82A20C", VA = "0x82A20C")]
		public static IItemDropRule MasterModeCommonDrop(int itemId)
		{
			return null;
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x82A3A4", Offset = "0x82A3A4", VA = "0x82A3A4")]
		public static IItemDropRule MasterModeDropOnAllPlayers(int itemId, int chanceDenominator = 1)
		{
			return null;
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x82A16C", Offset = "0x82A16C", VA = "0x82A16C")]
		public static IItemDropRule WithRerolls(int itemId, int rerolls, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x82A300", Offset = "0x82A300", VA = "0x82A300")]
		public static IItemDropRule ByCondition(IItemDropRuleCondition condition, int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1, int chanceNumerator = 1)
		{
			return null;
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x82A51C", Offset = "0x82A51C", VA = "0x82A51C")]
		public static IItemDropRule ScalingWithOnlyBadLuck(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x82A5B4", Offset = "0x82A5B4", VA = "0x82A5B4")]
		public static IItemDropRule NotScalingWithLuck(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x82A64C", Offset = "0x82A64C", VA = "0x82A64C")]
		public static IItemDropRule OneFromOptionsNotScalingWithLuck(int chanceDenominator, int[] options)
		{
			return null;
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x82A6D8", Offset = "0x82A6D8", VA = "0x82A6D8")]
		public static IItemDropRule OneFromOptionsNotScalingWithLuckWithX(int chanceDenominator, int chanceNumerator, int[] options)
		{
			return null;
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x82A768", Offset = "0x82A768", VA = "0x82A768")]
		public static IItemDropRule OneFromOptions(int chanceDenominator, int[] options)
		{
			return null;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558E")]
		[Address(RVA = "0x82A7F4", Offset = "0x82A7F4", VA = "0x82A7F4")]
		public static IItemDropRule OneFromOptionsWithNumerator(int chanceDenominator, int chanceNumerator, int[] options)
		{
			return null;
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x829E64", Offset = "0x829E64", VA = "0x829E64")]
		public static IItemDropRule DropNothing()
		{
			return null;
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x82A884", Offset = "0x82A884", VA = "0x82A884")]
		public static IItemDropRule Gel(int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x82A9F0", Offset = "0x82A9F0", VA = "0x82A9F0")]
		public static IItemDropRule NormalvsExpert(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
		{
			return null;
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x82AB54", Offset = "0x82AB54", VA = "0x82AB54")]
		public static IItemDropRule NormalvsExpertNotScalingWithLuck(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
		{
			return null;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005593")]
		[Address(RVA = "0x82ACB0", Offset = "0x82ACB0", VA = "0x82ACB0")]
		public static IItemDropRule NormalvsExpertOneFromOptionsNotScalingWithLuck(int chanceDenominatorInNormal, int chanceDenominatorInExpert, int[] options)
		{
			return null;
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005594")]
		[Address(RVA = "0x82AE00", Offset = "0x82AE00", VA = "0x82AE00")]
		public static IItemDropRule NormalvsExpertOneFromOptions(int chanceDenominatorInNormal, int chanceDenominatorInExpert, int[] options)
		{
			return null;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005595")]
		[Address(RVA = "0x82AF50", Offset = "0x82AF50", VA = "0x82AF50")]
		public static IItemDropRule Food(int itemId, int chanceDenominator, int minimumDropped = 1, int maximumDropped = 1)
		{
			return null;
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x82B034", Offset = "0x82B034", VA = "0x82B034")]
		public static IItemDropRule StatusImmunityItem(int itemId, int dropsOutOfX)
		{
			return null;
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x82B03C", Offset = "0x82B03C", VA = "0x82B03C")]
		public ItemDropRule()
		{
		}
	}
}
