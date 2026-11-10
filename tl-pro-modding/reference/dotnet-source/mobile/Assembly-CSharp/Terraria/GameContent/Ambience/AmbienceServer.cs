using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Ambience
{
	// Token: 0x02000DC7 RID: 3527
	[Token(Token = "0x2000DC7")]
	public class AmbienceServer
	{
		// Token: 0x06006791 RID: 26513 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[Token(Token = "0x6006791")]
		[Address(RVA = "0xB76840", Offset = "0xB76840", VA = "0xB76840")]
		private static bool IsSunnyDay()
		{
			return default(bool);
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		[Token(Token = "0x6006792")]
		[Address(RVA = "0xB76900", Offset = "0xB76900", VA = "0xB76900")]
		private static bool IsSunset()
		{
			return default(bool);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		[Token(Token = "0x6006793")]
		[Address(RVA = "0xB769AC", Offset = "0xB769AC", VA = "0xB769AC")]
		private static bool IsCalmNight()
		{
			return default(bool);
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006794")]
		[Address(RVA = "0xB76AB0", Offset = "0xB76AB0", VA = "0xB76AB0")]
		public AmbienceServer()
		{
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
		[Token(Token = "0x6006795")]
		[Address(RVA = "0xB780C8", Offset = "0xB780C8", VA = "0xB780C8")]
		private bool IsPlayerAtRightHeightForType(SkyEntityType type, Player plr)
		{
			return default(bool);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006796")]
		[Address(RVA = "0xB7835C", Offset = "0xB7835C", VA = "0xB7835C")]
		public void Update()
		{
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006797")]
		[Address(RVA = "0xB7801C", Offset = "0xB7801C", VA = "0xB7801C")]
		public void ResetSpawnTime()
		{
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006798")]
		[Address(RVA = "0xB78FDC", Offset = "0xB78FDC", VA = "0xB78FDC")]
		public void ForceEntitySpawn(AmbienceServer.AmbienceSpawnInfo info)
		{
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006799")]
		[Address(RVA = "0xB78A7C", Offset = "0xB78A7C", VA = "0xB78A7C")]
		private void SpawnForcedEntities()
		{
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679A")]
		[Address(RVA = "0xB78C48", Offset = "0xB78C48", VA = "0xB78C48")]
		private static void FindPlayerThatCanSeeBackgroundAmbience(out Player player)
		{
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		[Token(Token = "0x600679B")]
		[Address(RVA = "0xB790A0", Offset = "0xB790A0", VA = "0xB790A0")]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbience(Player plr)
		{
			return default(bool);
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x0002EC08 File Offset: 0x0002CE08
		[Token(Token = "0x600679C")]
		[Address(RVA = "0xB782B0", Offset = "0xB782B0", VA = "0xB782B0")]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(Player plr)
		{
			return default(bool);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x0002EC20 File Offset: 0x0002CE20
		[Token(Token = "0x600679D")]
		[Address(RVA = "0xB78208", Offset = "0xB78208", VA = "0xB78208")]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(Player plr)
		{
			return default(bool);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679E")]
		[Address(RVA = "0xB78F28", Offset = "0xB78F28", VA = "0xB78F28")]
		private void SpawnForPlayer(Player player, SkyEntityType type)
		{
		}

		// Token: 0x0400A46D RID: 42093
		[Token(Token = "0x400A46D")]
		private const int MINIMUM_SECONDS_BETWEEN_SPAWNS = 10;

		// Token: 0x0400A46E RID: 42094
		[Token(Token = "0x400A46E")]
		private const int MAXIMUM_SECONDS_BETWEEN_SPAWNS = 120;

		// Token: 0x0400A46F RID: 42095
		[Token(Token = "0x400A46F")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<SkyEntityType, Func<bool>> _spawnConditions;

		// Token: 0x0400A470 RID: 42096
		[Token(Token = "0x400A470")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<SkyEntityType, Func<Player, bool>> _secondarySpawnConditionsPerPlayer;

		// Token: 0x0400A471 RID: 42097
		[Token(Token = "0x400A471")]
		[FieldOffset(Offset = "0x10")]
		private int _updatesUntilNextAttempt;

		// Token: 0x0400A472 RID: 42098
		[Token(Token = "0x400A472")]
		[FieldOffset(Offset = "0x14")]
		private List<AmbienceServer.AmbienceSpawnInfo> _forcedSpawns;

		// Token: 0x02000DC8 RID: 3528
		[Token(Token = "0x2000DC8")]
		public struct AmbienceSpawnInfo
		{
			// Token: 0x0400A473 RID: 42099
			[Token(Token = "0x400A473")]
			[FieldOffset(Offset = "0x0")]
			public SkyEntityType skyEntityType;

			// Token: 0x0400A474 RID: 42100
			[Token(Token = "0x400A474")]
			[FieldOffset(Offset = "0x4")]
			public int targetPlayer;
		}

		// Token: 0x02000DC9 RID: 3529
		[Token(Token = "0x2000DC9")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060067A0 RID: 26528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067A0")]
			[Address(RVA = "0xB7922C", Offset = "0xB7922C", VA = "0xB7922C")]
			public <>c()
			{
			}

			// Token: 0x060067A1 RID: 26529 RVA: 0x0002EC38 File Offset: 0x0002CE38
			[Token(Token = "0x60067A1")]
			[Address(RVA = "0xB79234", Offset = "0xB79234", VA = "0xB79234")]
			internal bool <.ctor>b__10_0()
			{
				return default(bool);
			}

			// Token: 0x060067A2 RID: 26530 RVA: 0x0002EC50 File Offset: 0x0002CE50
			[Token(Token = "0x60067A2")]
			[Address(RVA = "0xB792B4", Offset = "0xB792B4", VA = "0xB792B4")]
			internal bool <.ctor>b__10_1()
			{
				return default(bool);
			}

			// Token: 0x060067A3 RID: 26531 RVA: 0x0002EC68 File Offset: 0x0002CE68
			[Token(Token = "0x60067A3")]
			[Address(RVA = "0xB79378", Offset = "0xB79378", VA = "0xB79378")]
			internal bool <.ctor>b__10_2()
			{
				return default(bool);
			}

			// Token: 0x060067A4 RID: 26532 RVA: 0x0002EC80 File Offset: 0x0002CE80
			[Token(Token = "0x60067A4")]
			[Address(RVA = "0xB7943C", Offset = "0xB7943C", VA = "0xB7943C")]
			internal bool <.ctor>b__10_3()
			{
				return default(bool);
			}

			// Token: 0x060067A5 RID: 26533 RVA: 0x0002EC98 File Offset: 0x0002CE98
			[Token(Token = "0x60067A5")]
			[Address(RVA = "0xB794A8", Offset = "0xB794A8", VA = "0xB794A8")]
			internal bool <.ctor>b__10_4()
			{
				return default(bool);
			}

			// Token: 0x060067A6 RID: 26534 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
			[Token(Token = "0x60067A6")]
			[Address(RVA = "0xB795DC", Offset = "0xB795DC", VA = "0xB795DC")]
			internal bool <.ctor>b__10_5()
			{
				return default(bool);
			}

			// Token: 0x060067A7 RID: 26535 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
			[Token(Token = "0x60067A7")]
			[Address(RVA = "0xB796E4", Offset = "0xB796E4", VA = "0xB796E4")]
			internal bool <.ctor>b__10_6()
			{
				return default(bool);
			}

			// Token: 0x060067A8 RID: 26536 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
			[Token(Token = "0x60067A8")]
			[Address(RVA = "0xB796E8", Offset = "0xB796E8", VA = "0xB796E8")]
			internal bool <.ctor>b__10_7()
			{
				return default(bool);
			}

			// Token: 0x060067A9 RID: 26537 RVA: 0x0002ECF8 File Offset: 0x0002CEF8
			[Token(Token = "0x60067A9")]
			[Address(RVA = "0xB7979C", Offset = "0xB7979C", VA = "0xB7979C")]
			internal bool <.ctor>b__10_8()
			{
				return default(bool);
			}

			// Token: 0x060067AA RID: 26538 RVA: 0x0002ED10 File Offset: 0x0002CF10
			[Token(Token = "0x60067AA")]
			[Address(RVA = "0xB797B8", Offset = "0xB797B8", VA = "0xB797B8")]
			internal bool <.ctor>b__10_9()
			{
				return default(bool);
			}

			// Token: 0x060067AB RID: 26539 RVA: 0x0002ED28 File Offset: 0x0002CF28
			[Token(Token = "0x60067AB")]
			[Address(RVA = "0xB797BC", Offset = "0xB797BC", VA = "0xB797BC")]
			internal bool <.ctor>b__10_10()
			{
				return default(bool);
			}

			// Token: 0x060067AC RID: 26540 RVA: 0x0002ED40 File Offset: 0x0002CF40
			[Token(Token = "0x60067AC")]
			[Address(RVA = "0xB79880", Offset = "0xB79880", VA = "0xB79880")]
			internal bool <.ctor>b__10_11()
			{
				return default(bool);
			}

			// Token: 0x060067AD RID: 26541 RVA: 0x0002ED58 File Offset: 0x0002CF58
			[Token(Token = "0x60067AD")]
			[Address(RVA = "0xB79884", Offset = "0xB79884", VA = "0xB79884")]
			internal bool <.ctor>b__10_12()
			{
				return default(bool);
			}

			// Token: 0x060067AE RID: 26542 RVA: 0x0002ED70 File Offset: 0x0002CF70
			[Token(Token = "0x60067AE")]
			[Address(RVA = "0xB79888", Offset = "0xB79888", VA = "0xB79888")]
			internal bool <.ctor>b__10_13()
			{
				return default(bool);
			}

			// Token: 0x060067AF RID: 26543 RVA: 0x0002ED88 File Offset: 0x0002CF88
			[Token(Token = "0x60067AF")]
			[Address(RVA = "0xB798A4", Offset = "0xB798A4", VA = "0xB798A4")]
			internal bool <.ctor>b__10_14()
			{
				return default(bool);
			}

			// Token: 0x060067B0 RID: 26544 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
			[Token(Token = "0x60067B0")]
			[Address(RVA = "0xB798C0", Offset = "0xB798C0", VA = "0xB798C0")]
			internal bool <.ctor>b__10_15()
			{
				return default(bool);
			}

			// Token: 0x060067B1 RID: 26545 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
			[Token(Token = "0x60067B1")]
			[Address(RVA = "0xB798C8", Offset = "0xB798C8", VA = "0xB798C8")]
			internal bool <.ctor>b__10_16(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B2 RID: 26546 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
			[Token(Token = "0x60067B2")]
			[Address(RVA = "0xB798EC", Offset = "0xB798EC", VA = "0xB798EC")]
			internal bool <.ctor>b__10_17(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B3 RID: 26547 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
			[Token(Token = "0x60067B3")]
			[Address(RVA = "0xB79910", Offset = "0xB79910", VA = "0xB79910")]
			internal bool <.ctor>b__10_18(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B4 RID: 26548 RVA: 0x0002EE00 File Offset: 0x0002D000
			[Token(Token = "0x60067B4")]
			[Address(RVA = "0xB79934", Offset = "0xB79934", VA = "0xB79934")]
			internal bool <.ctor>b__10_19(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B5 RID: 26549 RVA: 0x0002EE18 File Offset: 0x0002D018
			[Token(Token = "0x60067B5")]
			[Address(RVA = "0xB79958", Offset = "0xB79958", VA = "0xB79958")]
			internal bool <.ctor>b__10_20(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B6 RID: 26550 RVA: 0x0002EE30 File Offset: 0x0002D030
			[Token(Token = "0x60067B6")]
			[Address(RVA = "0xB7997C", Offset = "0xB7997C", VA = "0xB7997C")]
			internal bool <.ctor>b__10_21(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B7 RID: 26551 RVA: 0x0002EE48 File Offset: 0x0002D048
			[Token(Token = "0x60067B7")]
			[Address(RVA = "0xB799A0", Offset = "0xB799A0", VA = "0xB799A0")]
			internal bool <.ctor>b__10_22(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B8 RID: 26552 RVA: 0x0002EE60 File Offset: 0x0002D060
			[Token(Token = "0x60067B8")]
			[Address(RVA = "0xB799C4", Offset = "0xB799C4", VA = "0xB799C4")]
			internal bool <.ctor>b__10_23(Player player)
			{
				return default(bool);
			}

			// Token: 0x060067B9 RID: 26553 RVA: 0x0002EE78 File Offset: 0x0002D078
			[Token(Token = "0x60067B9")]
			[Address(RVA = "0xB799E8", Offset = "0xB799E8", VA = "0xB799E8")]
			internal bool <Update>b__12_0(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				return default(bool);
			}

			// Token: 0x060067BA RID: 26554 RVA: 0x0002EE90 File Offset: 0x0002D090
			[Token(Token = "0x60067BA")]
			[Address(RVA = "0xB79A40", Offset = "0xB79A40", VA = "0xB79A40")]
			internal SkyEntityType <Update>b__12_1(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				return SkyEntityType.BirdsV;
			}

			// Token: 0x060067BB RID: 26555 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
			[Token(Token = "0x60067BB")]
			[Address(RVA = "0xB79A80", Offset = "0xB79A80", VA = "0xB79A80")]
			internal bool <Update>b__12_2(SkyEntityType type)
			{
				return default(bool);
			}

			// Token: 0x060067BC RID: 26556 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
			[Token(Token = "0x60067BC")]
			[Address(RVA = "0xB79A88", Offset = "0xB79A88", VA = "0xB79A88")]
			internal bool <Update>b__12_4(SkyEntityType type)
			{
				return default(bool);
			}

			// Token: 0x060067BD RID: 26557 RVA: 0x0002EED8 File Offset: 0x0002D0D8
			[Token(Token = "0x60067BD")]
			[Address(RVA = "0xB79A90", Offset = "0xB79A90", VA = "0xB79A90")]
			internal bool <Update>b__12_6(SkyEntityType type)
			{
				return default(bool);
			}

			// Token: 0x060067BE RID: 26558 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
			[Token(Token = "0x60067BE")]
			[Address(RVA = "0xB79A98", Offset = "0xB79A98", VA = "0xB79A98")]
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_0(Player plr)
			{
				return default(bool);
			}

			// Token: 0x060067BF RID: 26559 RVA: 0x0002EF08 File Offset: 0x0002D108
			[Token(Token = "0x60067BF")]
			[Address(RVA = "0xB79AB8", Offset = "0xB79AB8", VA = "0xB79AB8")]
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_1(Player plr)
			{
				return default(bool);
			}

			// Token: 0x0400A475 RID: 42101
			[Token(Token = "0x400A475")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AmbienceServer.<>c <>9;

			// Token: 0x0400A476 RID: 42102
			[Token(Token = "0x400A476")]
			[FieldOffset(Offset = "0x4")]
			public static Func<bool> <>9__10_0;

			// Token: 0x0400A477 RID: 42103
			[Token(Token = "0x400A477")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool> <>9__10_1;

			// Token: 0x0400A478 RID: 42104
			[Token(Token = "0x400A478")]
			[FieldOffset(Offset = "0xC")]
			public static Func<bool> <>9__10_2;

			// Token: 0x0400A479 RID: 42105
			[Token(Token = "0x400A479")]
			[FieldOffset(Offset = "0x10")]
			public static Func<bool> <>9__10_3;

			// Token: 0x0400A47A RID: 42106
			[Token(Token = "0x400A47A")]
			[FieldOffset(Offset = "0x14")]
			public static Func<bool> <>9__10_4;

			// Token: 0x0400A47B RID: 42107
			[Token(Token = "0x400A47B")]
			[FieldOffset(Offset = "0x18")]
			public static Func<bool> <>9__10_5;

			// Token: 0x0400A47C RID: 42108
			[Token(Token = "0x400A47C")]
			[FieldOffset(Offset = "0x1C")]
			public static Func<bool> <>9__10_6;

			// Token: 0x0400A47D RID: 42109
			[Token(Token = "0x400A47D")]
			[FieldOffset(Offset = "0x20")]
			public static Func<bool> <>9__10_7;

			// Token: 0x0400A47E RID: 42110
			[Token(Token = "0x400A47E")]
			[FieldOffset(Offset = "0x24")]
			public static Func<bool> <>9__10_8;

			// Token: 0x0400A47F RID: 42111
			[Token(Token = "0x400A47F")]
			[FieldOffset(Offset = "0x28")]
			public static Func<bool> <>9__10_9;

			// Token: 0x0400A480 RID: 42112
			[Token(Token = "0x400A480")]
			[FieldOffset(Offset = "0x2C")]
			public static Func<bool> <>9__10_10;

			// Token: 0x0400A481 RID: 42113
			[Token(Token = "0x400A481")]
			[FieldOffset(Offset = "0x30")]
			public static Func<bool> <>9__10_11;

			// Token: 0x0400A482 RID: 42114
			[Token(Token = "0x400A482")]
			[FieldOffset(Offset = "0x34")]
			public static Func<bool> <>9__10_12;

			// Token: 0x0400A483 RID: 42115
			[Token(Token = "0x400A483")]
			[FieldOffset(Offset = "0x38")]
			public static Func<bool> <>9__10_13;

			// Token: 0x0400A484 RID: 42116
			[Token(Token = "0x400A484")]
			[FieldOffset(Offset = "0x3C")]
			public static Func<bool> <>9__10_14;

			// Token: 0x0400A485 RID: 42117
			[Token(Token = "0x400A485")]
			[FieldOffset(Offset = "0x40")]
			public static Func<bool> <>9__10_15;

			// Token: 0x0400A486 RID: 42118
			[Token(Token = "0x400A486")]
			[FieldOffset(Offset = "0x44")]
			public static Func<Player, bool> <>9__10_16;

			// Token: 0x0400A487 RID: 42119
			[Token(Token = "0x400A487")]
			[FieldOffset(Offset = "0x48")]
			public static Func<Player, bool> <>9__10_17;

			// Token: 0x0400A488 RID: 42120
			[Token(Token = "0x400A488")]
			[FieldOffset(Offset = "0x4C")]
			public static Func<Player, bool> <>9__10_18;

			// Token: 0x0400A489 RID: 42121
			[Token(Token = "0x400A489")]
			[FieldOffset(Offset = "0x50")]
			public static Func<Player, bool> <>9__10_19;

			// Token: 0x0400A48A RID: 42122
			[Token(Token = "0x400A48A")]
			[FieldOffset(Offset = "0x54")]
			public static Func<Player, bool> <>9__10_20;

			// Token: 0x0400A48B RID: 42123
			[Token(Token = "0x400A48B")]
			[FieldOffset(Offset = "0x58")]
			public static Func<Player, bool> <>9__10_21;

			// Token: 0x0400A48C RID: 42124
			[Token(Token = "0x400A48C")]
			[FieldOffset(Offset = "0x5C")]
			public static Func<Player, bool> <>9__10_22;

			// Token: 0x0400A48D RID: 42125
			[Token(Token = "0x400A48D")]
			[FieldOffset(Offset = "0x60")]
			public static Func<Player, bool> <>9__10_23;

			// Token: 0x0400A48E RID: 42126
			[Token(Token = "0x400A48E")]
			[FieldOffset(Offset = "0x64")]
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, bool> <>9__12_0;

			// Token: 0x0400A48F RID: 42127
			[Token(Token = "0x400A48F")]
			[FieldOffset(Offset = "0x68")]
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, SkyEntityType> <>9__12_1;

			// Token: 0x0400A490 RID: 42128
			[Token(Token = "0x400A490")]
			[FieldOffset(Offset = "0x6C")]
			public static Func<SkyEntityType, bool> <>9__12_2;

			// Token: 0x0400A491 RID: 42129
			[Token(Token = "0x400A491")]
			[FieldOffset(Offset = "0x70")]
			public static Func<SkyEntityType, bool> <>9__12_4;

			// Token: 0x0400A492 RID: 42130
			[Token(Token = "0x400A492")]
			[FieldOffset(Offset = "0x74")]
			public static Func<SkyEntityType, bool> <>9__12_6;

			// Token: 0x0400A493 RID: 42131
			[Token(Token = "0x400A493")]
			[FieldOffset(Offset = "0x78")]
			public static Func<Player, bool> <>9__16_0;

			// Token: 0x0400A494 RID: 42132
			[Token(Token = "0x400A494")]
			[FieldOffset(Offset = "0x7C")]
			public static Func<Player, bool> <>9__16_1;
		}

		// Token: 0x02000DCA RID: 3530
		[Token(Token = "0x2000DCA")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060067C0 RID: 26560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C0")]
			[Address(RVA = "0xB78A74", Offset = "0xB78A74", VA = "0xB78A74")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x060067C1 RID: 26561 RVA: 0x0002EF20 File Offset: 0x0002D120
			[Token(Token = "0x60067C1")]
			[Address(RVA = "0xB79AD8", Offset = "0xB79AD8", VA = "0xB79AD8")]
			internal bool <Update>b__3(SkyEntityType type)
			{
				return default(bool);
			}

			// Token: 0x060067C2 RID: 26562 RVA: 0x0002EF38 File Offset: 0x0002D138
			[Token(Token = "0x60067C2")]
			[Address(RVA = "0xB79C00", Offset = "0xB79C00", VA = "0xB79C00")]
			internal bool <Update>b__5(SkyEntityType type)
			{
				return default(bool);
			}

			// Token: 0x0400A495 RID: 42133
			[Token(Token = "0x400A495")]
			[FieldOffset(Offset = "0x8")]
			public AmbienceServer <>4__this;

			// Token: 0x0400A496 RID: 42134
			[Token(Token = "0x400A496")]
			[FieldOffset(Offset = "0xC")]
			public Player player;
		}
	}
}
