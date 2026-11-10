using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class DropOneByOne : FileAPI
	{
		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E2")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x6005602")]
			[Address(RVA = "0x83098C", Offset = "0x83098C", VA = "0x83098C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005603")]
			[Address(RVA = "0x830994", Offset = "0x830994", VA = "0x830994")]
			private set
			{
			}
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005604")]
		[Address(RVA = "0x83099C", Offset = "0x83099C", VA = "0x83099C")]
		public DropOneByOne(int itemId, DropOneByOne.Parameters parameters)
		{
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00027AB0 File Offset: 0x00025CB0
		[Token(Token = "0x6005605")]
		[Address(RVA = "0x830A80", Offset = "0x830A80", VA = "0x830A80", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005606")]
		[Address(RVA = "0x830BB0", Offset = "0x830BB0", VA = "0x830BB0", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00027AC8 File Offset: 0x00025CC8
		[Token(Token = "0x6005607")]
		[Address(RVA = "0x830DF4", Offset = "0x830DF4", VA = "0x830DF4", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x040098CD RID: 39117
		[Token(Token = "0x40098CD")]
		[FieldOffset(Offset = "0x8")]
		public int itemId;

		// Token: 0x040098CE RID: 39118
		[Token(Token = "0x40098CE")]
		[FieldOffset(Offset = "0xC")]
		public DropOneByOne.Parameters parameters;

		// Token: 0x040098CF RID: 39119
		[Token(Token = "0x40098CF")]
		[FieldOffset(Offset = "0x2C")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x02000A9B RID: 2715
		[Token(Token = "0x2000A9B")]
		public struct Parameters
		{
			// Token: 0x06005608 RID: 22024 RVA: 0x00027AE0 File Offset: 0x00025CE0
			[Token(Token = "0x6005608")]
			[Address(RVA = "0x830DD8", Offset = "0x830DD8", VA = "0x830DD8")]
			public float GetPersonalDropRate()
			{
				return 0f;
			}

			// Token: 0x040098D0 RID: 39120
			[Token(Token = "0x40098D0")]
			[FieldOffset(Offset = "0x0")]
			public int ChanceNumerator;

			// Token: 0x040098D1 RID: 39121
			[Token(Token = "0x40098D1")]
			[FieldOffset(Offset = "0x4")]
			public int ChanceDenominator;

			// Token: 0x040098D2 RID: 39122
			[Token(Token = "0x40098D2")]
			[FieldOffset(Offset = "0x8")]
			public int MinimumItemDropsCount;

			// Token: 0x040098D3 RID: 39123
			[Token(Token = "0x40098D3")]
			[FieldOffset(Offset = "0xC")]
			public int MaximumItemDropsCount;

			// Token: 0x040098D4 RID: 39124
			[Token(Token = "0x40098D4")]
			[FieldOffset(Offset = "0x10")]
			public int MinimumStackPerChunkBase;

			// Token: 0x040098D5 RID: 39125
			[Token(Token = "0x40098D5")]
			[FieldOffset(Offset = "0x14")]
			public int MaximumStackPerChunkBase;

			// Token: 0x040098D6 RID: 39126
			[Token(Token = "0x40098D6")]
			[FieldOffset(Offset = "0x18")]
			public int BonusMinDropsPerChunkPerPlayer;

			// Token: 0x040098D7 RID: 39127
			[Token(Token = "0x40098D7")]
			[FieldOffset(Offset = "0x1C")]
			public int BonusMaxDropsPerChunkPerPlayer;
		}
	}
}
