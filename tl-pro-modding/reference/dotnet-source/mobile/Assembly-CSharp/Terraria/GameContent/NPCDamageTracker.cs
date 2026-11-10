using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public abstract class NPCDamageTracker
	{
		// Token: 0x06004F1F RID: 20255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x748054", Offset = "0x748054", VA = "0x748054")]
		public static NPCDamageTracker.CustomDefinition RegisterCompositeTypeBoss(int[] types)
		{
			return null;
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x7481C8", Offset = "0x7481C8", VA = "0x7481C8")]
		public static void RegisterMobsForBoss(int bossType, int[] mobTypes)
		{
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00024D98 File Offset: 0x00022F98
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x748F08", Offset = "0x748F08", VA = "0x748F08")]
		private static bool GetRealActiveNPC(ref NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00024DB0 File Offset: 0x00022FB0
		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x748FDC", Offset = "0x748FDC", VA = "0x748FDC")]
		private static bool TryGetTrackerFor(NPC npc, out NPCDamageTracker tracker)
		{
			return default(bool);
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00024DC8 File Offset: 0x00022FC8
		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x749224", Offset = "0x749224", VA = "0x749224")]
		private static bool CreateTrackerFor(NPC npc, out NPCDamageTracker tracker)
		{
			return default(bool);
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F25")]
		[Address(RVA = "0x74945C", Offset = "0x74945C", VA = "0x74945C")]
		public static void AddDamage(NPC npc, int owner, int damage)
		{
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F26")]
		[Address(RVA = "0x7497B4", Offset = "0x7497B4", VA = "0x7497B4")]
		public static void AddDamageToLastAttack(NPC npc, int damage)
		{
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x749934", Offset = "0x749934", VA = "0x749934")]
		public static void SetSourceForNextHit(NPC npc, PlayerNPCHitSource source)
		{
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x7499AC", Offset = "0x7499AC", VA = "0x7499AC")]
		public static void BossKilled(NPC npc)
		{
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F29")]
		[Address(RVA = "0x749640", Offset = "0x749640", VA = "0x749640")]
		public static void Start(NPCDamageTracker tracker)
		{
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2A")]
		[Address(RVA = "0x749A54", Offset = "0x749A54", VA = "0x749A54")]
		public static void Reset()
		{
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2B")]
		[Address(RVA = "0x749B50", Offset = "0x749B50", VA = "0x749B50")]
		public static IEnumerable<NPCDamageTracker> RecentAttempts()
		{
			return null;
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2C")]
		[Address(RVA = "0x749BB4", Offset = "0x749BB4", VA = "0x749BB4")]
		public static void Update()
		{
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x74A0A0", Offset = "0x74A0A0", VA = "0x74A0A0")]
		private static void StopTracking(NPCDamageTracker tracker)
		{
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06004F2E RID: 20270 RVA: 0x00024DE0 File Offset: 0x00022FE0
		[Token(Token = "0x17000976")]
		public bool IsEmpty
		{
			[Token(Token = "0x6004F2E")]
			[Address(RVA = "0x74A2E0", Offset = "0x74A2E0", VA = "0x74A2E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x00024DF8 File Offset: 0x00022FF8
		[Token(Token = "0x17000977")]
		public int Duration
		{
			[Token(Token = "0x6004F2F")]
			[Address(RVA = "0x74A338", Offset = "0x74A338", VA = "0x74A338")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00024E10 File Offset: 0x00023010
		[Token(Token = "0x17000978")]
		public int TimeSinceLastHit
		{
			[Token(Token = "0x6004F30")]
			[Address(RVA = "0x74A090", Offset = "0x74A090", VA = "0x74A090")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06004F31 RID: 20273
		[Token(Token = "0x17000979")]
		public abstract LocalizedText Name
		{
			[Token(Token = "0x6004F31")]
			get;
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06004F32 RID: 20274
		[Token(Token = "0x1700097A")]
		public abstract LocalizedText KillTimeMessage
		{
			[Token(Token = "0x6004F32")]
			get;
		}

		// Token: 0x06004F33 RID: 20275
		[Token(Token = "0x6004F33")]
		protected abstract bool IncludeDamageFor(NPC npc);

		// Token: 0x06004F34 RID: 20276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x74A340", Offset = "0x74A340", VA = "0x74A340", Slot = "7")]
		protected virtual void CheckActive()
		{
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x74A344", Offset = "0x74A344", VA = "0x74A344", Slot = "8")]
		protected virtual void OnBossKilled(NPC npc)
		{
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x74A080", Offset = "0x74A080", VA = "0x74A080")]
		private void Tick()
		{
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x74A348", Offset = "0x74A348", VA = "0x74A348")]
		protected void Stop()
		{
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x749730", Offset = "0x749730", VA = "0x749730")]
		public void AddDamage(int owner, int damage)
		{
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x7498FC", Offset = "0x7498FC", VA = "0x7498FC")]
		public void AddDamageToLastAttack(int damage)
		{
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x74A3AC", Offset = "0x74A3AC", VA = "0x74A3AC", Slot = "9")]
		protected virtual NPCDamageTracker.CreditEntry GetOrAddEntry(int owner)
		{
			return null;
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3B")]
		[Address(RVA = "0x74A890", Offset = "0x74A890", VA = "0x74A890")]
		public NetworkText GetReport([Optional] Player forPlayer)
		{
			return null;
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x74B4D0", Offset = "0x74B4D0", VA = "0x74B4D0")]
		public static int[] CalculatePercentages(int[] damages)
		{
			return null;
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3D")]
		[Address(RVA = "0x74B6E4", Offset = "0x74B6E4", VA = "0x74B6E4")]
		protected NPCDamageTracker()
		{
		}

		// Token: 0x04009365 RID: 37733
		[Token(Token = "0x4009365")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static NPCDamageTracker.CustomDefinition[] CustomBossDefinitions;

		// Token: 0x04009366 RID: 37734
		[Token(Token = "0x4009366")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int[] BossTypeForMob;

		// Token: 0x04009367 RID: 37735
		[Token(Token = "0x4009367")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<NPCDamageTracker> _activeTrackers;

		// Token: 0x04009368 RID: 37736
		[Token(Token = "0x4009368")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static List<NPCDamageTracker> _recentFinishedTrackers;

		// Token: 0x04009369 RID: 37737
		[Token(Token = "0x4009369")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int MAX_RECENT_TRACKERS;

		// Token: 0x0400936A RID: 37738
		[Token(Token = "0x400936A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int EXTRA_RECENT_TRACKER_EXPIRY_TIME;

		// Token: 0x0400936B RID: 37739
		[Token(Token = "0x400936B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static PlayerNPCHitSource _nextHitSource;

		// Token: 0x0400936C RID: 37740
		[Token(Token = "0x400936C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static bool UseExpandedSources;

		// Token: 0x0400936D RID: 37741
		[Token(Token = "0x400936D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<NPCDamageTracker.CreditEntry> _list;

		// Token: 0x0400936E RID: 37742
		[Token(Token = "0x400936E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private NPCDamageTracker.WorldCreditEntry _worldCredit;

		// Token: 0x0400936F RID: 37743
		[Token(Token = "0x400936F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NPCDamageTracker.CreditEntry _lastAttacker;

		// Token: 0x04009370 RID: 37744
		[Token(Token = "0x4009370")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _ticks;

		// Token: 0x04009371 RID: 37745
		[Token(Token = "0x4009371")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _lastHitTime;

		// Token: 0x02000941 RID: 2369
		[Token(Token = "0x2000941")]
		public class CustomDefinition
		{
			// Token: 0x06004F3E RID: 20286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F3E")]
			[Address(RVA = "0x7481C0", Offset = "0x7481C0", VA = "0x7481C0")]
			public CustomDefinition()
			{
			}

			// Token: 0x04009372 RID: 37746
			[Token(Token = "0x4009372")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<int> NPCTypes;

			// Token: 0x04009373 RID: 37747
			[Token(Token = "0x4009373")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public LocalizedText Name;
		}

		// Token: 0x02000942 RID: 2370
		[Token(Token = "0x2000942")]
		protected abstract class CreditEntry : FileAPI
		{
			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06004F3F RID: 20287 RVA: 0x00024E28 File Offset: 0x00023028
			// (set) Token: 0x06004F40 RID: 20288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700097B")]
			public int Damage
			{
				[Token(Token = "0x6004F3F")]
				[Address(RVA = "0x74B780", Offset = "0x74B780", VA = "0x74B780")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004F40")]
				[Address(RVA = "0x74B788", Offset = "0x74B788", VA = "0x74B788")]
				set
				{
				}
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06004F41 RID: 20289 RVA: 0x00024E40 File Offset: 0x00023040
			// (set) Token: 0x06004F42 RID: 20290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700097C")]
			public int HitCount
			{
				[Token(Token = "0x6004F41")]
				[Address(RVA = "0x74B790", Offset = "0x74B790", VA = "0x74B790")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004F42")]
				[Address(RVA = "0x74B798", Offset = "0x74B798", VA = "0x74B798")]
				set
				{
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x06004F43 RID: 20291
			[Token(Token = "0x1700097D")]
			public abstract NetworkText Name
			{
				[Token(Token = "0x6004F43")]
				get;
			}

			// Token: 0x06004F44 RID: 20292 RVA: 0x00024E58 File Offset: 0x00023058
			[Token(Token = "0x6004F44")]
			[Address(RVA = "0x74B7A0", Offset = "0x74B7A0", VA = "0x74B7A0", Slot = "4")]
			public int CompareTo(NPCDamageTracker.CreditEntry other)
			{
				return 0;
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F45")]
			[Address(RVA = "0x74B800", Offset = "0x74B800", VA = "0x74B800")]
			protected CreditEntry()
			{
			}

			// Token: 0x04009374 RID: 37748
			[Token(Token = "0x4009374")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <Damage>k__BackingField;

			// Token: 0x04009375 RID: 37749
			[Token(Token = "0x4009375")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int <HitCount>k__BackingField;
		}

		// Token: 0x02000943 RID: 2371
		[Token(Token = "0x2000943")]
		private class PlayerCreditEntry : NPCDamageTracker.CreditEntry
		{
			// Token: 0x06004F46 RID: 20294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F46")]
			[Address(RVA = "0x74A85C", Offset = "0x74A85C", VA = "0x74A85C")]
			public PlayerCreditEntry(string name, PlayerNPCHitSource source)
			{
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06004F47 RID: 20295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097E")]
			public override NetworkText Name
			{
				[Token(Token = "0x6004F47")]
				[Address(RVA = "0x74B808", Offset = "0x74B808", VA = "0x74B808", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x04009376 RID: 37750
			[Token(Token = "0x4009376")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string PlayerName;

			// Token: 0x04009377 RID: 37751
			[Token(Token = "0x4009377")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly PlayerNPCHitSource Source;
		}

		// Token: 0x02000944 RID: 2372
		[Token(Token = "0x2000944")]
		private class WorldCreditEntry : NPCDamageTracker.CreditEntry
		{
			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06004F48 RID: 20296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097F")]
			public override NetworkText Name
			{
				[Token(Token = "0x6004F48")]
				[Address(RVA = "0x74B900", Offset = "0x74B900", VA = "0x74B900", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F49 RID: 20297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F49")]
			[Address(RVA = "0x74A854", Offset = "0x74A854", VA = "0x74A854")]
			public WorldCreditEntry()
			{
			}
		}

		// Token: 0x02000945 RID: 2373
		[Token(Token = "0x2000945")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F4B RID: 20299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4B")]
			[Address(RVA = "0x74BA64", Offset = "0x74BA64", VA = "0x74BA64")]
			public <>c()
			{
			}

			// Token: 0x06004F4C RID: 20300 RVA: 0x00024E70 File Offset: 0x00023070
			[Token(Token = "0x6004F4C")]
			[Address(RVA = "0x74BA6C", Offset = "0x74BA6C", VA = "0x74BA6C")]
			internal int <GetReport>b__50_0(NPCDamageTracker.CreditEntry x)
			{
				return 0;
			}

			// Token: 0x04009378 RID: 37752
			[Token(Token = "0x4009378")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NPCDamageTracker.<>c <>9;

			// Token: 0x04009379 RID: 37753
			[Token(Token = "0x4009379")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<NPCDamageTracker.CreditEntry, int> <>9__50_0;
		}
	}
}
