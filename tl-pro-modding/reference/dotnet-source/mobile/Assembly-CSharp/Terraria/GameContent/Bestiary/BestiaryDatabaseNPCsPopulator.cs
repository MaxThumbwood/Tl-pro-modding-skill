using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x2000BCC")]
	public class BestiaryDatabaseNPCsPopulator
	{
		// Token: 0x06005BA5 RID: 23461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x944B9C", Offset = "0x944B9C", VA = "0x944B9C")]
		public BestiaryDatabaseNPCsPopulator()
		{
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x944BA4", Offset = "0x944BA4", VA = "0x944BA4")]
		private BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			return null;
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x944BD0", Offset = "0x944BD0", VA = "0x944BD0")]
		private BestiaryEntry Register(BestiaryEntry entry)
		{
			return null;
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x944BFC", Offset = "0x944BFC", VA = "0x944BFC")]
		private IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			return null;
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x944C28", Offset = "0x944C28", VA = "0x944C28")]
		public void Populate(BestiaryDatabase database)
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x96FD48", Offset = "0x96FD48", VA = "0x96FD48")]
		private void RegisterTestEntries()
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x96F58C", Offset = "0x96F58C", VA = "0x96F58C")]
		private void RegisterSortSteps()
		{
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x96F360", Offset = "0x96F360", VA = "0x96F360")]
		private void RegisterFilters()
		{
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x96FE48", Offset = "0x96FE48", VA = "0x96FE48")]
		private void ModifyEntriesThatNeedIt_NameOverride(int npcID, string newNameKey)
		{
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x9694F0", Offset = "0x9694F0", VA = "0x9694F0")]
		private void ModifyEntriesThatNeedIt()
		{
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x9700FC", Offset = "0x9700FC", VA = "0x9700FC")]
		private void HideStats(NPCStatsReportInfoElement element)
		{
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x97011C", Offset = "0x97011C", VA = "0x97011C")]
		private void AdjustEaterOfWorldStats(NPCStatsReportInfoElement element)
		{
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x970198", Offset = "0x970198", VA = "0x970198")]
		private void AdjustPirateShipStats(NPCStatsReportInfoElement element)
		{
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0x9702C0", Offset = "0x9702C0", VA = "0x9702C0")]
		private void TryGivingEntryFlavorTextIfItIsMissing(BestiaryEntry entry)
		{
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x944F90", Offset = "0x944F90", VA = "0x944F90")]
		private void AddTownNPCs_Manual()
		{
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x970844", Offset = "0x970844", VA = "0x970844")]
		private void AddMultiEntryNPCS_Manual()
		{
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x944C74", Offset = "0x944C74", VA = "0x944C74")]
		private void AddEmptyEntries_CrittersAndEnemies_Automated()
		{
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x97091C", Offset = "0x97091C", VA = "0x97091C")]
		private static HashSet<int> GetExclusions()
		{
			return null;
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x94571C", Offset = "0x94571C", VA = "0x94571C")]
		private void AddNPCBiomeRelationships_Automated()
		{
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x9614D8", Offset = "0x9614D8", VA = "0x9614D8")]
		private void AddNPCBiomeRelationships_Manual()
		{
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x968A40", Offset = "0x968A40", VA = "0x968A40")]
		private void AddNPCBiomeRelationships_AddDecorations_Automated()
		{
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0x970E00", Offset = "0x970E00", VA = "0x970E00")]
		public void AddDropOverrides(BestiaryDatabase bestiaryDatabase)
		{
		}

		// Token: 0x04009C44 RID: 40004
		[Token(Token = "0x4009C44")]
		[FieldOffset(Offset = "0x8")]
		private BestiaryDatabase _currentDatabase;

		// Token: 0x02000BCD RID: 3021
		[Token(Token = "0x2000BCD")]
		public static class CommonTags
		{
			// Token: 0x06005BBB RID: 23483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BBB")]
			[Address(RVA = "0x991E6C", Offset = "0x991E6C", VA = "0x991E6C")]
			public static List<IBestiaryInfoElement> GetCommonInfoElementsForFilters()
			{
				return null;
			}

			// Token: 0x02000BCE RID: 3022
			[Token(Token = "0x2000BCE")]
			public static class SpawnConditions
			{
				// Token: 0x02000BCF RID: 3023
				[Token(Token = "0x2000BCF")]
				public static class Invasions
				{
					// Token: 0x04009C45 RID: 40005
					[Token(Token = "0x4009C45")]
					[FieldOffset(Offset = "0x0")]
					public static SpawnConditionBestiaryInfoElement Goblins;

					// Token: 0x04009C46 RID: 40006
					[Token(Token = "0x4009C46")]
					[FieldOffset(Offset = "0x4")]
					public static SpawnConditionBestiaryInfoElement Pirates;

					// Token: 0x04009C47 RID: 40007
					[Token(Token = "0x4009C47")]
					[FieldOffset(Offset = "0x8")]
					public static SpawnConditionBestiaryInfoElement Martian;

					// Token: 0x04009C48 RID: 40008
					[Token(Token = "0x4009C48")]
					[FieldOffset(Offset = "0xC")]
					public static SpawnConditionBestiaryInfoElement OldOnesArmy;

					// Token: 0x04009C49 RID: 40009
					[Token(Token = "0x4009C49")]
					[FieldOffset(Offset = "0x10")]
					public static SpawnConditionBestiaryInfoElement PumpkinMoon;

					// Token: 0x04009C4A RID: 40010
					[Token(Token = "0x4009C4A")]
					[FieldOffset(Offset = "0x14")]
					public static SpawnConditionBestiaryInfoElement FrostMoon;

					// Token: 0x04009C4B RID: 40011
					[Token(Token = "0x4009C4B")]
					[FieldOffset(Offset = "0x18")]
					public static SpawnConditionBestiaryInfoElement FrostLegion;
				}

				// Token: 0x02000BD0 RID: 3024
				[Token(Token = "0x2000BD0")]
				public static class Events
				{
					// Token: 0x04009C4C RID: 40012
					[Token(Token = "0x4009C4C")]
					[FieldOffset(Offset = "0x0")]
					public static SpawnConditionBestiaryInfoElement SlimeRain;

					// Token: 0x04009C4D RID: 40013
					[Token(Token = "0x4009C4D")]
					[FieldOffset(Offset = "0x4")]
					public static SpawnConditionBestiaryInfoElement WindyDay;

					// Token: 0x04009C4E RID: 40014
					[Token(Token = "0x4009C4E")]
					[FieldOffset(Offset = "0x8")]
					public static SpawnConditionBestiaryInfoElement BloodMoon;

					// Token: 0x04009C4F RID: 40015
					[Token(Token = "0x4009C4F")]
					[FieldOffset(Offset = "0xC")]
					public static SpawnConditionBestiaryInfoElement Halloween;

					// Token: 0x04009C50 RID: 40016
					[Token(Token = "0x4009C50")]
					[FieldOffset(Offset = "0x10")]
					public static SpawnConditionBestiaryOverlayInfoElement Rain;

					// Token: 0x04009C51 RID: 40017
					[Token(Token = "0x4009C51")]
					[FieldOffset(Offset = "0x14")]
					public static SpawnConditionBestiaryInfoElement Christmas;

					// Token: 0x04009C52 RID: 40018
					[Token(Token = "0x4009C52")]
					[FieldOffset(Offset = "0x18")]
					public static SpawnConditionBestiaryInfoElement Eclipse;

					// Token: 0x04009C53 RID: 40019
					[Token(Token = "0x4009C53")]
					[FieldOffset(Offset = "0x1C")]
					public static SpawnConditionBestiaryInfoElement Party;

					// Token: 0x04009C54 RID: 40020
					[Token(Token = "0x4009C54")]
					[FieldOffset(Offset = "0x20")]
					public static SpawnConditionBestiaryOverlayInfoElement Blizzard;

					// Token: 0x04009C55 RID: 40021
					[Token(Token = "0x4009C55")]
					[FieldOffset(Offset = "0x24")]
					public static SpawnConditionBestiaryOverlayInfoElement Sandstorm;
				}

				// Token: 0x02000BD1 RID: 3025
				[Token(Token = "0x2000BD1")]
				public static class Biomes
				{
					// Token: 0x04009C56 RID: 40022
					[Token(Token = "0x4009C56")]
					[FieldOffset(Offset = "0x0")]
					public static SpawnConditionBestiaryInfoElement TheCorruption;

					// Token: 0x04009C57 RID: 40023
					[Token(Token = "0x4009C57")]
					[FieldOffset(Offset = "0x4")]
					public static SpawnConditionBestiaryInfoElement TheCrimson;

					// Token: 0x04009C58 RID: 40024
					[Token(Token = "0x4009C58")]
					[FieldOffset(Offset = "0x8")]
					public static SpawnConditionBestiaryInfoElement Surface;

					// Token: 0x04009C59 RID: 40025
					[Token(Token = "0x4009C59")]
					[FieldOffset(Offset = "0xC")]
					public static SpawnConditionBestiaryInfoElement Graveyard;

					// Token: 0x04009C5A RID: 40026
					[Token(Token = "0x4009C5A")]
					[FieldOffset(Offset = "0x10")]
					public static SpawnConditionBestiaryInfoElement UndergroundJungle;

					// Token: 0x04009C5B RID: 40027
					[Token(Token = "0x4009C5B")]
					[FieldOffset(Offset = "0x14")]
					public static SpawnConditionBestiaryInfoElement TheUnderworld;

					// Token: 0x04009C5C RID: 40028
					[Token(Token = "0x4009C5C")]
					[FieldOffset(Offset = "0x18")]
					public static SpawnConditionBestiaryInfoElement TheDungeon;

					// Token: 0x04009C5D RID: 40029
					[Token(Token = "0x4009C5D")]
					[FieldOffset(Offset = "0x1C")]
					public static SpawnConditionBestiaryInfoElement Underground;

					// Token: 0x04009C5E RID: 40030
					[Token(Token = "0x4009C5E")]
					[FieldOffset(Offset = "0x20")]
					public static SpawnConditionBestiaryInfoElement TheHallow;

					// Token: 0x04009C5F RID: 40031
					[Token(Token = "0x4009C5F")]
					[FieldOffset(Offset = "0x24")]
					public static SpawnConditionBestiaryInfoElement UndergroundMushroom;

					// Token: 0x04009C60 RID: 40032
					[Token(Token = "0x4009C60")]
					[FieldOffset(Offset = "0x28")]
					public static SpawnConditionBestiaryInfoElement Jungle;

					// Token: 0x04009C61 RID: 40033
					[Token(Token = "0x4009C61")]
					[FieldOffset(Offset = "0x2C")]
					public static SpawnConditionBestiaryInfoElement Caverns;

					// Token: 0x04009C62 RID: 40034
					[Token(Token = "0x4009C62")]
					[FieldOffset(Offset = "0x30")]
					public static SpawnConditionBestiaryInfoElement UndergroundSnow;

					// Token: 0x04009C63 RID: 40035
					[Token(Token = "0x4009C63")]
					[FieldOffset(Offset = "0x34")]
					public static SpawnConditionBestiaryInfoElement Ocean;

					// Token: 0x04009C64 RID: 40036
					[Token(Token = "0x4009C64")]
					[FieldOffset(Offset = "0x38")]
					public static SpawnConditionBestiaryInfoElement SurfaceMushroom;

					// Token: 0x04009C65 RID: 40037
					[Token(Token = "0x4009C65")]
					[FieldOffset(Offset = "0x3C")]
					public static SpawnConditionBestiaryInfoElement UndergroundDesert;

					// Token: 0x04009C66 RID: 40038
					[Token(Token = "0x4009C66")]
					[FieldOffset(Offset = "0x40")]
					public static SpawnConditionBestiaryInfoElement Snow;

					// Token: 0x04009C67 RID: 40039
					[Token(Token = "0x4009C67")]
					[FieldOffset(Offset = "0x44")]
					public static SpawnConditionBestiaryInfoElement Desert;

					// Token: 0x04009C68 RID: 40040
					[Token(Token = "0x4009C68")]
					[FieldOffset(Offset = "0x48")]
					public static SpawnConditionBestiaryInfoElement Meteor;

					// Token: 0x04009C69 RID: 40041
					[Token(Token = "0x4009C69")]
					[FieldOffset(Offset = "0x4C")]
					public static SpawnConditionBestiaryInfoElement Oasis;

					// Token: 0x04009C6A RID: 40042
					[Token(Token = "0x4009C6A")]
					[FieldOffset(Offset = "0x50")]
					public static SpawnConditionBestiaryInfoElement SpiderNest;

					// Token: 0x04009C6B RID: 40043
					[Token(Token = "0x4009C6B")]
					[FieldOffset(Offset = "0x54")]
					public static SpawnConditionBestiaryInfoElement TheTemple;

					// Token: 0x04009C6C RID: 40044
					[Token(Token = "0x4009C6C")]
					[FieldOffset(Offset = "0x58")]
					public static SpawnConditionBestiaryInfoElement CorruptUndergroundDesert;

					// Token: 0x04009C6D RID: 40045
					[Token(Token = "0x4009C6D")]
					[FieldOffset(Offset = "0x5C")]
					public static SpawnConditionBestiaryInfoElement CrimsonUndergroundDesert;

					// Token: 0x04009C6E RID: 40046
					[Token(Token = "0x4009C6E")]
					[FieldOffset(Offset = "0x60")]
					public static SpawnConditionBestiaryInfoElement HallowUndergroundDesert;

					// Token: 0x04009C6F RID: 40047
					[Token(Token = "0x4009C6F")]
					[FieldOffset(Offset = "0x64")]
					public static SpawnConditionBestiaryInfoElement CorruptDesert;

					// Token: 0x04009C70 RID: 40048
					[Token(Token = "0x4009C70")]
					[FieldOffset(Offset = "0x68")]
					public static SpawnConditionBestiaryInfoElement CrimsonDesert;

					// Token: 0x04009C71 RID: 40049
					[Token(Token = "0x4009C71")]
					[FieldOffset(Offset = "0x6C")]
					public static SpawnConditionBestiaryInfoElement HallowDesert;

					// Token: 0x04009C72 RID: 40050
					[Token(Token = "0x4009C72")]
					[FieldOffset(Offset = "0x70")]
					public static SpawnConditionBestiaryInfoElement Granite;

					// Token: 0x04009C73 RID: 40051
					[Token(Token = "0x4009C73")]
					[FieldOffset(Offset = "0x74")]
					public static SpawnConditionBestiaryInfoElement UndergroundCorruption;

					// Token: 0x04009C74 RID: 40052
					[Token(Token = "0x4009C74")]
					[FieldOffset(Offset = "0x78")]
					public static SpawnConditionBestiaryInfoElement UndergroundCrimson;

					// Token: 0x04009C75 RID: 40053
					[Token(Token = "0x4009C75")]
					[FieldOffset(Offset = "0x7C")]
					public static SpawnConditionBestiaryInfoElement UndergroundHallow;

					// Token: 0x04009C76 RID: 40054
					[Token(Token = "0x4009C76")]
					[FieldOffset(Offset = "0x80")]
					public static SpawnConditionBestiaryInfoElement Marble;

					// Token: 0x04009C77 RID: 40055
					[Token(Token = "0x4009C77")]
					[FieldOffset(Offset = "0x84")]
					public static SpawnConditionBestiaryInfoElement CorruptIce;

					// Token: 0x04009C78 RID: 40056
					[Token(Token = "0x4009C78")]
					[FieldOffset(Offset = "0x88")]
					public static SpawnConditionBestiaryInfoElement HallowIce;

					// Token: 0x04009C79 RID: 40057
					[Token(Token = "0x4009C79")]
					[FieldOffset(Offset = "0x8C")]
					public static SpawnConditionBestiaryInfoElement CrimsonIce;

					// Token: 0x04009C7A RID: 40058
					[Token(Token = "0x4009C7A")]
					[FieldOffset(Offset = "0x90")]
					public static SpawnConditionBestiaryInfoElement Sky;

					// Token: 0x04009C7B RID: 40059
					[Token(Token = "0x4009C7B")]
					[FieldOffset(Offset = "0x94")]
					public static SpawnConditionBestiaryInfoElement NebulaPillar;

					// Token: 0x04009C7C RID: 40060
					[Token(Token = "0x4009C7C")]
					[FieldOffset(Offset = "0x98")]
					public static SpawnConditionBestiaryInfoElement SolarPillar;

					// Token: 0x04009C7D RID: 40061
					[Token(Token = "0x4009C7D")]
					[FieldOffset(Offset = "0x9C")]
					public static SpawnConditionBestiaryInfoElement VortexPillar;

					// Token: 0x04009C7E RID: 40062
					[Token(Token = "0x4009C7E")]
					[FieldOffset(Offset = "0xA0")]
					public static SpawnConditionBestiaryInfoElement StardustPillar;
				}

				// Token: 0x02000BD2 RID: 3026
				[Token(Token = "0x2000BD2")]
				public static class Times
				{
					// Token: 0x04009C7F RID: 40063
					[Token(Token = "0x4009C7F")]
					[FieldOffset(Offset = "0x0")]
					public static SpawnConditionBestiaryInfoElement DayTime;

					// Token: 0x04009C80 RID: 40064
					[Token(Token = "0x4009C80")]
					[FieldOffset(Offset = "0x4")]
					public static SpawnConditionBestiaryInfoElement NightTime;
				}

				// Token: 0x02000BD3 RID: 3027
				[Token(Token = "0x2000BD3")]
				public static class Visuals
				{
					// Token: 0x04009C81 RID: 40065
					[Token(Token = "0x4009C81")]
					[FieldOffset(Offset = "0x0")]
					public static SpawnConditionDecorativeOverlayInfoElement Sun;

					// Token: 0x04009C82 RID: 40066
					[Token(Token = "0x4009C82")]
					[FieldOffset(Offset = "0x4")]
					public static SpawnConditionDecorativeOverlayInfoElement Moon;

					// Token: 0x04009C83 RID: 40067
					[Token(Token = "0x4009C83")]
					[FieldOffset(Offset = "0x8")]
					public static SpawnConditionDecorativeOverlayInfoElement EclipseSun;

					// Token: 0x04009C84 RID: 40068
					[Token(Token = "0x4009C84")]
					[FieldOffset(Offset = "0xC")]
					public static SpawnConditionDecorativeOverlayInfoElement PumpkinMoon;

					// Token: 0x04009C85 RID: 40069
					[Token(Token = "0x4009C85")]
					[FieldOffset(Offset = "0x10")]
					public static SpawnConditionDecorativeOverlayInfoElement FrostMoon;

					// Token: 0x04009C86 RID: 40070
					[Token(Token = "0x4009C86")]
					[FieldOffset(Offset = "0x14")]
					public static SpawnConditionDecorativeOverlayInfoElement Meteor;

					// Token: 0x04009C87 RID: 40071
					[Token(Token = "0x4009C87")]
					[FieldOffset(Offset = "0x18")]
					public static SpawnConditionDecorativeOverlayInfoElement Rain;

					// Token: 0x04009C88 RID: 40072
					[Token(Token = "0x4009C88")]
					[FieldOffset(Offset = "0x1C")]
					public static SpawnConditionDecorativeOverlayInfoElement Blizzard;
				}
			}
		}

		// Token: 0x02000BD4 RID: 3028
		[Token(Token = "0x2000BD4")]
		public static class Conditions
		{
			// Token: 0x06005BC1 RID: 23489 RVA: 0x0002AFF0 File Offset: 0x000291F0
			[Token(Token = "0x6005BC1")]
			[Address(RVA = "0x996B34", Offset = "0x996B34", VA = "0x996B34")]
			public static bool ReachHardMode()
			{
				return default(bool);
			}
		}

		// Token: 0x02000BD5 RID: 3029
		[Token(Token = "0x2000BD5")]
		public static class CrownosIconIndexes
		{
			// Token: 0x04009C89 RID: 40073
			[Token(Token = "0x4009C89")]
			public const int Surface = 0;

			// Token: 0x04009C8A RID: 40074
			[Token(Token = "0x4009C8A")]
			public const int Underground = 1;

			// Token: 0x04009C8B RID: 40075
			[Token(Token = "0x4009C8B")]
			public const int Cave = 2;

			// Token: 0x04009C8C RID: 40076
			[Token(Token = "0x4009C8C")]
			public const int Desert = 3;

			// Token: 0x04009C8D RID: 40077
			[Token(Token = "0x4009C8D")]
			public const int UndergroundDesert = 4;

			// Token: 0x04009C8E RID: 40078
			[Token(Token = "0x4009C8E")]
			public const int Snow = 5;

			// Token: 0x04009C8F RID: 40079
			[Token(Token = "0x4009C8F")]
			public const int UndergroundIce = 6;

			// Token: 0x04009C90 RID: 40080
			[Token(Token = "0x4009C90")]
			public const int Corruption = 7;

			// Token: 0x04009C91 RID: 40081
			[Token(Token = "0x4009C91")]
			public const int CorruptionUnderground = 8;

			// Token: 0x04009C92 RID: 40082
			[Token(Token = "0x4009C92")]
			public const int CorruptionDesert = 9;

			// Token: 0x04009C93 RID: 40083
			[Token(Token = "0x4009C93")]
			public const int CorruptionUndergroundDesert = 10;

			// Token: 0x04009C94 RID: 40084
			[Token(Token = "0x4009C94")]
			public const int CorruptionIce = 11;

			// Token: 0x04009C95 RID: 40085
			[Token(Token = "0x4009C95")]
			public const int Crimson = 12;

			// Token: 0x04009C96 RID: 40086
			[Token(Token = "0x4009C96")]
			public const int CrimsonUnderground = 13;

			// Token: 0x04009C97 RID: 40087
			[Token(Token = "0x4009C97")]
			public const int CrimsonDesert = 14;

			// Token: 0x04009C98 RID: 40088
			[Token(Token = "0x4009C98")]
			public const int CrimsonUndergroundDesert = 15;

			// Token: 0x04009C99 RID: 40089
			[Token(Token = "0x4009C99")]
			public const int CrimsonIce = 16;

			// Token: 0x04009C9A RID: 40090
			[Token(Token = "0x4009C9A")]
			public const int Hallow = 17;

			// Token: 0x04009C9B RID: 40091
			[Token(Token = "0x4009C9B")]
			public const int HallowUnderground = 18;

			// Token: 0x04009C9C RID: 40092
			[Token(Token = "0x4009C9C")]
			public const int HallowDesert = 19;

			// Token: 0x04009C9D RID: 40093
			[Token(Token = "0x4009C9D")]
			public const int HallowUndergroundDesert = 20;

			// Token: 0x04009C9E RID: 40094
			[Token(Token = "0x4009C9E")]
			public const int HallowIce = 21;

			// Token: 0x04009C9F RID: 40095
			[Token(Token = "0x4009C9F")]
			public const int Jungle = 22;

			// Token: 0x04009CA0 RID: 40096
			[Token(Token = "0x4009CA0")]
			public const int UndergroundJungle = 23;

			// Token: 0x04009CA1 RID: 40097
			[Token(Token = "0x4009CA1")]
			public const int SurfaceMushroom = 24;

			// Token: 0x04009CA2 RID: 40098
			[Token(Token = "0x4009CA2")]
			public const int UndergroundMushroom = 25;

			// Token: 0x04009CA3 RID: 40099
			[Token(Token = "0x4009CA3")]
			public const int Sky = 26;

			// Token: 0x04009CA4 RID: 40100
			[Token(Token = "0x4009CA4")]
			public const int Oasis = 27;

			// Token: 0x04009CA5 RID: 40101
			[Token(Token = "0x4009CA5")]
			public const int Ocean = 28;

			// Token: 0x04009CA6 RID: 40102
			[Token(Token = "0x4009CA6")]
			public const int Marble = 29;

			// Token: 0x04009CA7 RID: 40103
			[Token(Token = "0x4009CA7")]
			public const int Granite = 30;

			// Token: 0x04009CA8 RID: 40104
			[Token(Token = "0x4009CA8")]
			public const int JungleTemple = 31;

			// Token: 0x04009CA9 RID: 40105
			[Token(Token = "0x4009CA9")]
			public const int Dungeon = 32;

			// Token: 0x04009CAA RID: 40106
			[Token(Token = "0x4009CAA")]
			public const int Underworld = 33;

			// Token: 0x04009CAB RID: 40107
			[Token(Token = "0x4009CAB")]
			public const int SpiderNest = 34;

			// Token: 0x04009CAC RID: 40108
			[Token(Token = "0x4009CAC")]
			public const int Graveyard = 35;

			// Token: 0x04009CAD RID: 40109
			[Token(Token = "0x4009CAD")]
			public const int Day = 36;

			// Token: 0x04009CAE RID: 40110
			[Token(Token = "0x4009CAE")]
			public const int Night = 37;

			// Token: 0x04009CAF RID: 40111
			[Token(Token = "0x4009CAF")]
			public const int BloodMoon = 38;

			// Token: 0x04009CB0 RID: 40112
			[Token(Token = "0x4009CB0")]
			public const int Eclipse = 39;

			// Token: 0x04009CB1 RID: 40113
			[Token(Token = "0x4009CB1")]
			public const int Rain = 40;

			// Token: 0x04009CB2 RID: 40114
			[Token(Token = "0x4009CB2")]
			public const int WindyDay = 41;

			// Token: 0x04009CB3 RID: 40115
			[Token(Token = "0x4009CB3")]
			public const int Blizzard = 42;

			// Token: 0x04009CB4 RID: 40116
			[Token(Token = "0x4009CB4")]
			public const int Sandstorm = 43;

			// Token: 0x04009CB5 RID: 40117
			[Token(Token = "0x4009CB5")]
			public const int Meteor = 44;

			// Token: 0x04009CB6 RID: 40118
			[Token(Token = "0x4009CB6")]
			public const int Halloween = 45;

			// Token: 0x04009CB7 RID: 40119
			[Token(Token = "0x4009CB7")]
			public const int Christmas = 46;

			// Token: 0x04009CB8 RID: 40120
			[Token(Token = "0x4009CB8")]
			public const int SlimeRain = 47;

			// Token: 0x04009CB9 RID: 40121
			[Token(Token = "0x4009CB9")]
			public const int Party = 48;

			// Token: 0x04009CBA RID: 40122
			[Token(Token = "0x4009CBA")]
			public const int GoblinInvasion = 49;

			// Token: 0x04009CBB RID: 40123
			[Token(Token = "0x4009CBB")]
			public const int PirateInvasion = 50;

			// Token: 0x04009CBC RID: 40124
			[Token(Token = "0x4009CBC")]
			public const int PumpkinMoon = 51;

			// Token: 0x04009CBD RID: 40125
			[Token(Token = "0x4009CBD")]
			public const int FrostMoon = 52;

			// Token: 0x04009CBE RID: 40126
			[Token(Token = "0x4009CBE")]
			public const int AlienInvasion = 53;

			// Token: 0x04009CBF RID: 40127
			[Token(Token = "0x4009CBF")]
			public const int FrostLegion = 54;

			// Token: 0x04009CC0 RID: 40128
			[Token(Token = "0x4009CC0")]
			public const int OldOnesArmy = 55;

			// Token: 0x04009CC1 RID: 40129
			[Token(Token = "0x4009CC1")]
			public const int SolarTower = 56;

			// Token: 0x04009CC2 RID: 40130
			[Token(Token = "0x4009CC2")]
			public const int VortexTower = 57;

			// Token: 0x04009CC3 RID: 40131
			[Token(Token = "0x4009CC3")]
			public const int NebulaTower = 58;

			// Token: 0x04009CC4 RID: 40132
			[Token(Token = "0x4009CC4")]
			public const int StardustTower = 59;

			// Token: 0x04009CC5 RID: 40133
			[Token(Token = "0x4009CC5")]
			public const int Hardmode = 60;

			// Token: 0x04009CC6 RID: 40134
			[Token(Token = "0x4009CC6")]
			public const int ItemSpawn = 61;
		}

		// Token: 0x02000BD6 RID: 3030
		[Token(Token = "0x2000BD6")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005BC3 RID: 23491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BC3")]
			[Address(RVA = "0x996C0C", Offset = "0x996C0C", VA = "0x996C0C")]
			public <>c()
			{
			}

			// Token: 0x06005BC4 RID: 23492 RVA: 0x0002B008 File Offset: 0x00029208
			[Token(Token = "0x6005BC4")]
			[Address(RVA = "0x996C14", Offset = "0x996C14", VA = "0x996C14")]
			internal bool <ModifyEntriesThatNeedIt_NameOverride>b__12_0(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BC5 RID: 23493 RVA: 0x0002B020 File Offset: 0x00029220
			[Token(Token = "0x6005BC5")]
			[Address(RVA = "0x996C98", Offset = "0x996C98", VA = "0x996C98")]
			internal bool <ModifyEntriesThatNeedIt>b__13_0(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BC6 RID: 23494 RVA: 0x0002B038 File Offset: 0x00029238
			[Token(Token = "0x6005BC6")]
			[Address(RVA = "0x996D1C", Offset = "0x996D1C", VA = "0x996D1C")]
			internal bool <ModifyEntriesThatNeedIt>b__13_1(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BC7 RID: 23495 RVA: 0x0002B050 File Offset: 0x00029250
			[Token(Token = "0x6005BC7")]
			[Address(RVA = "0x996DA0", Offset = "0x996DA0", VA = "0x996DA0")]
			internal bool <ModifyEntriesThatNeedIt>b__13_2(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BC8 RID: 23496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BC8")]
			[Address(RVA = "0x996E24", Offset = "0x996E24", VA = "0x996E24")]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_3(IBestiaryInfoElement x)
			{
				return null;
			}

			// Token: 0x06005BC9 RID: 23497 RVA: 0x0002B068 File Offset: 0x00029268
			[Token(Token = "0x6005BC9")]
			[Address(RVA = "0x996EA8", Offset = "0x996EA8", VA = "0x996EA8")]
			internal bool <ModifyEntriesThatNeedIt>b__13_4(NPCStatsReportInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BCA RID: 23498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BCA")]
			[Address(RVA = "0x996EB8", Offset = "0x996EB8", VA = "0x996EB8")]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_5(IBestiaryInfoElement x)
			{
				return null;
			}

			// Token: 0x06005BCB RID: 23499 RVA: 0x0002B080 File Offset: 0x00029280
			[Token(Token = "0x6005BCB")]
			[Address(RVA = "0x996F3C", Offset = "0x996F3C", VA = "0x996F3C")]
			internal bool <ModifyEntriesThatNeedIt>b__13_6(NPCStatsReportInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BCC RID: 23500 RVA: 0x0002B098 File Offset: 0x00029298
			[Token(Token = "0x6005BCC")]
			[Address(RVA = "0x996F4C", Offset = "0x996F4C", VA = "0x996F4C")]
			internal bool <ModifyEntriesThatNeedIt>b__13_7(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BCD RID: 23501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BCD")]
			[Address(RVA = "0x996FD0", Offset = "0x996FD0", VA = "0x996FD0")]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_8(IBestiaryInfoElement x)
			{
				return null;
			}

			// Token: 0x06005BCE RID: 23502 RVA: 0x0002B0B0 File Offset: 0x000292B0
			[Token(Token = "0x6005BCE")]
			[Address(RVA = "0x997054", Offset = "0x997054", VA = "0x997054")]
			internal bool <ModifyEntriesThatNeedIt>b__13_9(NPCStatsReportInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x06005BCF RID: 23503 RVA: 0x0002B0C8 File Offset: 0x000292C8
			[Token(Token = "0x6005BCF")]
			[Address(RVA = "0x997064", Offset = "0x997064", VA = "0x997064")]
			internal bool <TryGivingEntryFlavorTextIfItIsMissing>b__17_0(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x04009CC7 RID: 40135
			[Token(Token = "0x4009CC7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BestiaryDatabaseNPCsPopulator.<>c <>9;

			// Token: 0x04009CC8 RID: 40136
			[Token(Token = "0x4009CC8")]
			[FieldOffset(Offset = "0x4")]
			public static Predicate<IBestiaryInfoElement> <>9__12_0;

			// Token: 0x04009CC9 RID: 40137
			[Token(Token = "0x4009CC9")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<IBestiaryInfoElement> <>9__13_0;

			// Token: 0x04009CCA RID: 40138
			[Token(Token = "0x4009CCA")]
			[FieldOffset(Offset = "0xC")]
			public static Predicate<IBestiaryInfoElement> <>9__13_1;

			// Token: 0x04009CCB RID: 40139
			[Token(Token = "0x4009CCB")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<IBestiaryInfoElement> <>9__13_2;

			// Token: 0x04009CCC RID: 40140
			[Token(Token = "0x4009CCC")]
			[FieldOffset(Offset = "0x14")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_3;

			// Token: 0x04009CCD RID: 40141
			[Token(Token = "0x4009CCD")]
			[FieldOffset(Offset = "0x18")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_4;

			// Token: 0x04009CCE RID: 40142
			[Token(Token = "0x4009CCE")]
			[FieldOffset(Offset = "0x1C")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_5;

			// Token: 0x04009CCF RID: 40143
			[Token(Token = "0x4009CCF")]
			[FieldOffset(Offset = "0x20")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_6;

			// Token: 0x04009CD0 RID: 40144
			[Token(Token = "0x4009CD0")]
			[FieldOffset(Offset = "0x24")]
			public static Predicate<IBestiaryInfoElement> <>9__13_7;

			// Token: 0x04009CD1 RID: 40145
			[Token(Token = "0x4009CD1")]
			[FieldOffset(Offset = "0x28")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_8;

			// Token: 0x04009CD2 RID: 40146
			[Token(Token = "0x4009CD2")]
			[FieldOffset(Offset = "0x2C")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_9;

			// Token: 0x04009CD3 RID: 40147
			[Token(Token = "0x4009CD3")]
			[FieldOffset(Offset = "0x30")]
			public static Func<IBestiaryInfoElement, bool> <>9__17_0;
		}
	}
}
