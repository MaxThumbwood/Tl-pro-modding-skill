using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public class ItemDropDatabase
	{
		// Token: 0x06005750 RID: 22352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x8380D0", Offset = "0x8380D0", VA = "0x8380D0")]
		public void PrepareNPCNetIDsByTypeDictionary()
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005751")]
		[Address(RVA = "0x838780", Offset = "0x838780", VA = "0x838780")]
		public void TrimDuplicateRulesForNegativeIDs()
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005752")]
		[Address(RVA = "0x8388AC", Offset = "0x8388AC", VA = "0x8388AC")]
		public List<IItemDropRule> GetRulesForNPCID(int npcNetId, bool includeGlobalDrops = true)
		{
			return null;
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005753")]
		[Address(RVA = "0x838A08", Offset = "0x838A08", VA = "0x838A08")]
		public IItemDropRule RegisterToGlobal(IItemDropRule entry)
		{
			return null;
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005754")]
		[Address(RVA = "0x838ACC", Offset = "0x838ACC", VA = "0x838ACC")]
		public IItemDropRule RegisterToNPC(int type, IItemDropRule entry)
		{
			return null;
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005755")]
		[Address(RVA = "0x838BFC", Offset = "0x838BFC", VA = "0x838BFC")]
		private void RegisterToNPCNetId(int npcNetId, IItemDropRule entry)
		{
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005756")]
		[Address(RVA = "0x838DD8", Offset = "0x838DD8", VA = "0x838DD8")]
		public IItemDropRule RegisterToMultipleNPCs(IItemDropRule entry, int[] npcNetIds)
		{
			return null;
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005757")]
		[Address(RVA = "0x838E30", Offset = "0x838E30", VA = "0x838E30")]
		public IItemDropRule RegisterToMultipleNPCsNotRemixSeed(IItemDropRule entry, int[] npcNetIds)
		{
			return null;
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005758")]
		[Address(RVA = "0x838FD8", Offset = "0x838FD8", VA = "0x838FD8")]
		public IItemDropRule RegisterToMultipleNPCsRemixSeed(IItemDropRule entry, int[] npcNetIds)
		{
			return null;
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005759")]
		[Address(RVA = "0x839180", Offset = "0x839180", VA = "0x839180")]
		private void RemoveFromNPCNetId(int npcNetId, IItemDropRule entry)
		{
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x839274", Offset = "0x839274", VA = "0x839274")]
		public IItemDropRule RemoveFromNPC(int type, IItemDropRule entry)
		{
			return null;
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x8393A4", Offset = "0x8393A4", VA = "0x8393A4")]
		public IItemDropRule RemoveFromMultipleNPCs(IItemDropRule entry, int[] npcNetIds)
		{
			return null;
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x8393FC", Offset = "0x8393FC", VA = "0x8393FC")]
		public void Populate()
		{
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575D")]
		[Address(RVA = "0x8480F4", Offset = "0x8480F4", VA = "0x8480F4")]
		private void RegisterBloodMoonFishing()
		{
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575E")]
		[Address(RVA = "0x84742C", Offset = "0x84742C", VA = "0x84742C")]
		private void RegisterEclipse()
		{
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575F")]
		[Address(RVA = "0x846DF4", Offset = "0x846DF4", VA = "0x846DF4")]
		private void RegisterMimic()
		{
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005760")]
		[Address(RVA = "0x848828", Offset = "0x848828", VA = "0x848828")]
		private void RegisterIceMimic()
		{
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005761")]
		[Address(RVA = "0x848F78", Offset = "0x848F78", VA = "0x848F78")]
		private int[] RegisterIceMimic_GetEasyModeItemPool(bool isRemix)
		{
			return null;
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005762")]
		[Address(RVA = "0x846900", Offset = "0x846900", VA = "0x846900")]
		private void RegisterHardmodeDungeonDrops()
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005763")]
		[Address(RVA = "0x846848", Offset = "0x846848", VA = "0x846848")]
		private void RegisterBosses()
		{
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005764")]
		[Address(RVA = "0x84F498", Offset = "0x84F498", VA = "0x84F498")]
		private void RegisterBoss_QueenSlime()
		{
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005765")]
		[Address(RVA = "0x84F0A0", Offset = "0x84F0A0", VA = "0x84F0A0")]
		private void RegisterBoss_HallowBoss()
		{
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005766")]
		[Address(RVA = "0x84DCC0", Offset = "0x84DCC0", VA = "0x84DCC0")]
		private void RegisterBoss_PumpkinMoon()
		{
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005767")]
		[Address(RVA = "0x84D510", Offset = "0x84D510", VA = "0x84D510")]
		private void RegisterBoss_FrostMoon()
		{
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005768")]
		[Address(RVA = "0x84D200", Offset = "0x84D200", VA = "0x84D200")]
		private void RegisterBoss_KingSlime()
		{
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005769")]
		[Address(RVA = "0x84CA34", Offset = "0x84CA34", VA = "0x84CA34")]
		private void RegisterBoss_Plantera()
		{
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576A")]
		[Address(RVA = "0x84C240", Offset = "0x84C240", VA = "0x84C240")]
		private void RegisterBoss_SkeletronPrime()
		{
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576B")]
		[Address(RVA = "0x84C414", Offset = "0x84C414", VA = "0x84C414")]
		private void RegisterBoss_TheDestroyer()
		{
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576C")]
		[Address(RVA = "0x84C5E8", Offset = "0x84C5E8", VA = "0x84C5E8")]
		private void RegisterBoss_Twins()
		{
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576D")]
		[Address(RVA = "0x84901C", Offset = "0x84901C", VA = "0x84901C")]
		private void RegisterBoss_EOC()
		{
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576E")]
		[Address(RVA = "0x8492D0", Offset = "0x8492D0", VA = "0x8492D0")]
		private void RegisterBoss_BOC()
		{
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576F")]
		[Address(RVA = "0x8499FC", Offset = "0x8499FC", VA = "0x8499FC")]
		private void RegisterBoss_EOW()
		{
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005770")]
		[Address(RVA = "0x84F77C", Offset = "0x84F77C", VA = "0x84F77C")]
		private void RegisterBoss_Deerclops()
		{
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005771")]
		[Address(RVA = "0x84A068", Offset = "0x84A068", VA = "0x84A068")]
		private void RegisterBoss_QueenBee()
		{
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005772")]
		[Address(RVA = "0x84A458", Offset = "0x84A458", VA = "0x84A458")]
		private void RegisterBoss_Skeletron()
		{
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005773")]
		[Address(RVA = "0x84A6F4", Offset = "0x84A6F4", VA = "0x84A6F4")]
		private void RegisterBoss_WOF()
		{
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005774")]
		[Address(RVA = "0x84AA78", Offset = "0x84AA78", VA = "0x84AA78")]
		private void RegisterBoss_AncientCultist()
		{
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x84AB1C", Offset = "0x84AB1C", VA = "0x84AB1C")]
		private void RegisterBoss_MoonLord()
		{
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x84AE34", Offset = "0x84AE34", VA = "0x84AE34")]
		private void RegisterBoss_LunarTowers()
		{
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005777")]
		[Address(RVA = "0x84B3F0", Offset = "0x84B3F0", VA = "0x84B3F0")]
		private void RegisterBoss_Betsy()
		{
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005778")]
		[Address(RVA = "0x84B674", Offset = "0x84B674", VA = "0x84B674")]
		private void RegisterBoss_Golem()
		{
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005779")]
		[Address(RVA = "0x84BCE8", Offset = "0x84BCE8", VA = "0x84BCE8")]
		private void RegisterBoss_DukeFishron()
		{
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577A")]
		[Address(RVA = "0x83B7E0", Offset = "0x83B7E0", VA = "0x83B7E0")]
		private void RegisterWeirdRules()
		{
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577B")]
		[Address(RVA = "0x8394A0", Offset = "0x8394A0", VA = "0x8394A0")]
		private void RegisterGlobalRules()
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577C")]
		[Address(RVA = "0x83AC24", Offset = "0x83AC24", VA = "0x83AC24")]
		private void RegisterFoodDrops()
		{
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577D")]
		[Address(RVA = "0x83BA40", Offset = "0x83BA40", VA = "0x83BA40")]
		private void RegisterTownNPCDrops()
		{
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577E")]
		[Address(RVA = "0x83BFF0", Offset = "0x83BFF0", VA = "0x83BFF0")]
		private void RegisterDD2EventDrops()
		{
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577F")]
		[Address(RVA = "0x843EE0", Offset = "0x843EE0", VA = "0x843EE0")]
		private void RegisterHardmodeFeathers()
		{
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005780")]
		[Address(RVA = "0x844310", Offset = "0x844310", VA = "0x844310")]
		private void RegisterYoyos()
		{
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005781")]
		[Address(RVA = "0x844A40", Offset = "0x844A40", VA = "0x844A40")]
		private void RegisterStatusImmunityItems()
		{
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005782")]
		[Address(RVA = "0x844F90", Offset = "0x844F90", VA = "0x844F90")]
		private void RegisterPirateDrops()
		{
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005783")]
		[Address(RVA = "0x845D7C", Offset = "0x845D7C", VA = "0x845D7C")]
		private void RegisterBloodMoonFishingEnemies()
		{
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005784")]
		[Address(RVA = "0x8462CC", Offset = "0x8462CC", VA = "0x8462CC")]
		private void RegisterBossTrophies()
		{
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005785")]
		[Address(RVA = "0x845D80", Offset = "0x845D80", VA = "0x845D80")]
		private void RegisterMartianDrops()
		{
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005786")]
		[Address(RVA = "0x83CE20", Offset = "0x83CE20", VA = "0x83CE20")]
		private void RegisterMiscDrops()
		{
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005787")]
		[Address(RVA = "0x84FBBC", Offset = "0x84FBBC", VA = "0x84FBBC")]
		public ItemDropDatabase()
		{
		}

		// Token: 0x040098F2 RID: 39154
		[Token(Token = "0x40098F2")]
		[FieldOffset(Offset = "0x8")]
		private List<IItemDropRule> _globalEntries;

		// Token: 0x040098F3 RID: 39155
		[Token(Token = "0x40098F3")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, List<IItemDropRule>> _entriesByNpcNetId;

		// Token: 0x040098F4 RID: 39156
		[Token(Token = "0x40098F4")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, List<int>> _npcNetIdsByType;

		// Token: 0x040098F5 RID: 39157
		[Token(Token = "0x40098F5")]
		[FieldOffset(Offset = "0x14")]
		private int _masterModeDropRng;

		// Token: 0x02000AEC RID: 2796
		[Token(Token = "0x2000AEC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005789 RID: 22409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005789")]
			[Address(RVA = "0x84FD94", Offset = "0x84FD94", VA = "0x84FD94")]
			public <>c()
			{
			}

			// Token: 0x0600578A RID: 22410 RVA: 0x00028950 File Offset: 0x00026B50
			[Token(Token = "0x600578A")]
			[Address(RVA = "0x84FD9C", Offset = "0x84FD9C", VA = "0x84FD9C")]
			internal bool <PrepareNPCNetIDsByTypeDictionary>b__3_0(KeyValuePair<int, NPC> x)
			{
				return default(bool);
			}

			// Token: 0x040098F6 RID: 39158
			[Token(Token = "0x40098F6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ItemDropDatabase.<>c <>9;

			// Token: 0x040098F7 RID: 39159
			[Token(Token = "0x40098F7")]
			[FieldOffset(Offset = "0x4")]
			public static Func<KeyValuePair<int, NPC>, bool> <>9__3_0;
		}
	}
}
