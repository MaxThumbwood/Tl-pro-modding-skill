using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D18 RID: 3352
	[Token(Token = "0x2000D18")]
	public class DD2Event
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x0002D900 File Offset: 0x0002BB00
		[Token(Token = "0x17000AB5")]
		public static bool ReadyToFindBartender
		{
			[Token(Token = "0x6006357")]
			[Address(RVA = "0xAF3CE4", Offset = "0xAF3CE4", VA = "0xAF3CE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x0002D918 File Offset: 0x0002BB18
		[Token(Token = "0x17000AB6")]
		public static bool DownedInvasionAnyDifficulty
		{
			[Token(Token = "0x6006358")]
			[Address(RVA = "0xAF3D48", Offset = "0xAF3D48", VA = "0xAF3D48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x0002D930 File Offset: 0x0002BB30
		// (set) Token: 0x0600635A RID: 25434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB7")]
		public static int TimeLeftBetweenWaves
		{
			[Token(Token = "0x6006359")]
			[Address(RVA = "0xAF3E0C", Offset = "0xAF3E0C", VA = "0xAF3E0C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600635A")]
			[Address(RVA = "0xAF3E70", Offset = "0xAF3E70", VA = "0xAF3E70")]
			set
			{
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600635B RID: 25435 RVA: 0x0002D948 File Offset: 0x0002BB48
		[Token(Token = "0x17000AB8")]
		public static bool EnemySpawningIsOnHold
		{
			[Token(Token = "0x600635B")]
			[Address(RVA = "0xAF3ED8", Offset = "0xAF3ED8", VA = "0xAF3ED8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x0002D960 File Offset: 0x0002BB60
		[Token(Token = "0x17000AB9")]
		public static bool EnemiesShouldChasePlayers
		{
			[Token(Token = "0x600635C")]
			[Address(RVA = "0xAF3F44", Offset = "0xAF3F44", VA = "0xAF3F44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635D")]
		[Address(RVA = "0xAF3FA8", Offset = "0xAF3FA8", VA = "0xAF3FA8")]
		public static void Save(BinaryWriter writer)
		{
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635E")]
		[Address(RVA = "0xAF40AC", Offset = "0xAF40AC", VA = "0xAF40AC")]
		public static void Load(BinaryReader reader, int gameVersionNumber)
		{
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635F")]
		[Address(RVA = "0xAF42AC", Offset = "0xAF42AC", VA = "0xAF42AC")]
		public static void ResetProgressEntirely()
		{
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006360")]
		[Address(RVA = "0xAF4338", Offset = "0xAF4338", VA = "0xAF4338")]
		public static void ReportEventProgress()
		{
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006361")]
		[Address(RVA = "0xAF4578", Offset = "0xAF4578", VA = "0xAF4578")]
		public static void SyncInvasionProgress(int toWho)
		{
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006362")]
		[Address(RVA = "0xAF468C", Offset = "0xAF468C", VA = "0xAF468C")]
		public static void UpdateTime()
		{
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006363")]
		[Address(RVA = "0xAF552C", Offset = "0xAF552C", VA = "0xAF552C")]
		public static void StartInvasion(int difficultyOverride = -1)
		{
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006364")]
		[Address(RVA = "0xAF4E9C", Offset = "0xAF4E9C", VA = "0xAF4E9C")]
		public static void StopInvasion(bool win = false)
		{
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006365")]
		[Address(RVA = "0xAF5F9C", Offset = "0xAF5F9C", VA = "0xAF5F9C")]
		private static void WinInvasionInternal()
		{
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006366")]
		[Address(RVA = "0xAF53B8", Offset = "0xAF53B8", VA = "0xAF53B8")]
		public static void LoseInvasionMessage()
		{
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06006367 RID: 25447 RVA: 0x0002D978 File Offset: 0x0002BB78
		[Token(Token = "0x17000ABA")]
		public static bool ReadyForTier2
		{
			[Token(Token = "0x6006367")]
			[Address(RVA = "0xAF65BC", Offset = "0xAF65BC", VA = "0xAF65BC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x0002D990 File Offset: 0x0002BB90
		[Token(Token = "0x17000ABB")]
		public static bool ReadyForTier3
		{
			[Token(Token = "0x6006368")]
			[Address(RVA = "0xAF6674", Offset = "0xAF6674", VA = "0xAF6674")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006369")]
		[Address(RVA = "0xAF59C0", Offset = "0xAF59C0", VA = "0xAF59C0")]
		private static void FindProperDifficulty()
		{
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636A")]
		[Address(RVA = "0xAF672C", Offset = "0xAF672C", VA = "0xAF672C")]
		public static void CheckProgress(int slainMonsterID)
		{
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636B")]
		[Address(RVA = "0xAF70A4", Offset = "0xAF70A4", VA = "0xAF70A4")]
		public static void StartVictoryScene()
		{
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636C")]
		[Address(RVA = "0xAF742C", Offset = "0xAF742C", VA = "0xAF742C")]
		public static void ReportLoss()
		{
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636D")]
		[Address(RVA = "0xAF4414", Offset = "0xAF4414", VA = "0xAF4414")]
		private static void GetInvasionStatus(out int currentWave, out int requiredKillCount, out int currentKillCount, bool currentlyInCheckProgress = false)
		{
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636E")]
		[Address(RVA = "0xAF508C", Offset = "0xAF508C", VA = "0xAF508C")]
		private static short[] GetEnemiesForWave(int wave)
		{
			return null;
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
		[Token(Token = "0x600636F")]
		[Address(RVA = "0xAF6FDC", Offset = "0xAF6FDC", VA = "0xAF6FDC")]
		private static int GetMonsterPointsWorth(int slainMonsterID)
		{
			return 0;
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006370")]
		[Address(RVA = "0xAF8824", Offset = "0xAF8824", VA = "0xAF8824")]
		public static void SpawnMonsterFromGate(Vector2 gateBottom, bool leftGate)
		{
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006371")]
		[Address(RVA = "0xAFE6E8", Offset = "0xAFE6E8", VA = "0xAFE6E8")]
		public static void SummonCrystal(int x, int y, int whoAsks)
		{
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006372")]
		[Address(RVA = "0xAFE81C", Offset = "0xAFE81C", VA = "0xAFE81C")]
		public static void SummonCrystalDirect(int x, int y, int whoAsks)
		{
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[Token(Token = "0x6006373")]
		[Address(RVA = "0xAFEE68", Offset = "0xAFEE68", VA = "0xAFEE68")]
		public static bool WouldFailSpawningHere(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006374")]
		[Address(RVA = "0xAFEF68", Offset = "0xAFEF68", VA = "0xAFEF68")]
		public static void FailureMessage(int client)
		{
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006375")]
		[Address(RVA = "0xAF5E88", Offset = "0xAF5E88", VA = "0xAF5E88")]
		public static void WipeEntities()
		{
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006376")]
		[Address(RVA = "0xAF5BC4", Offset = "0xAF5BC4", VA = "0xAF5BC4")]
		public static void ClearAllTowersInGame()
		{
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006377")]
		[Address(RVA = "0xAFF1EC", Offset = "0xAFF1EC", VA = "0xAFF1EC")]
		public static void ClearAllDD2HostilesInGame()
		{
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006378")]
		[Address(RVA = "0xAFF3EC", Offset = "0xAFF3EC", VA = "0xAFF3EC")]
		public static void ClearAllDD2EnergyCrystalsInChests()
		{
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006379")]
		[Address(RVA = "0xAFF608", Offset = "0xAFF608", VA = "0xAFF608")]
		public static void AnnounceGoblinDeath(NPC n)
		{
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[Token(Token = "0x600637A")]
		[Address(RVA = "0xAFF728", Offset = "0xAFF728", VA = "0xAFF728")]
		public static bool CanRaiseGoblinsHere(Vector2 spot)
		{
			return default(bool);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637B")]
		[Address(RVA = "0xAFFA8C", Offset = "0xAFFA8C", VA = "0xAFFA8C")]
		public static void RaiseGoblins(NPC caller, Vector2 spot)
		{
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637C")]
		[Address(RVA = "0xB00400", Offset = "0xB00400", VA = "0xB00400")]
		public static void FindArenaHitbox()
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[Token(Token = "0x600637D")]
		[Address(RVA = "0xB0075C", Offset = "0xB0075C", VA = "0xB0075C")]
		public static bool ShouldBlockBuilding(Vector2 worldPosition)
		{
			return default(bool);
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637E")]
		[Address(RVA = "0xAF62AC", Offset = "0xAF62AC", VA = "0xAF62AC")]
		public static void DropMedals(int numberOfMedals)
		{
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0002DA08 File Offset: 0x0002BC08
		[Token(Token = "0x600637F")]
		[Address(RVA = "0xB00858", Offset = "0xB00858", VA = "0xB00858")]
		public static bool ShouldDropCrystals()
		{
			return default(bool);
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006380")]
		[Address(RVA = "0xAF5154", Offset = "0xAF5154", VA = "0xAF5154")]
		private static void SummonBetsy()
		{
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006381")]
		[Address(RVA = "0xAFEC60", Offset = "0xAFEC60", VA = "0xAFEC60")]
		private static void DropStarterCrystals()
		{
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006382")]
		[Address(RVA = "0xAF5D4C", Offset = "0xAF5D4C", VA = "0xAF5D4C")]
		private static void SetEnemySpawningOnHold(int forHowLong)
		{
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006383")]
		[Address(RVA = "0xAF815C", Offset = "0xAF815C", VA = "0xAF815C")]
		private static short[] Difficulty_1_GetEnemiesForWave(int wave)
		{
			return null;
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[Token(Token = "0x6006384")]
		[Address(RVA = "0xAF78BC", Offset = "0xAF78BC", VA = "0xAF78BC")]
		private static int Difficulty_1_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			return 0;
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006385")]
		[Address(RVA = "0xAFD828", Offset = "0xAFD828", VA = "0xAFD828")]
		private static void Difficulty_1_SpawnMonsterFromGate(Vector2 gateBottom, bool leftGate)
		{
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0002DA38 File Offset: 0x0002BC38
		[Token(Token = "0x6006386")]
		[Address(RVA = "0xAF8670", Offset = "0xAF8670", VA = "0xAF8670")]
		private static int Difficulty_1_GetMonsterPointsWorth(int slainMonsterID)
		{
			return 0;
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006387")]
		[Address(RVA = "0xAF7DE8", Offset = "0xAF7DE8", VA = "0xAF7DE8")]
		private static short[] Difficulty_2_GetEnemiesForWave(int wave)
		{
			return null;
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0002DA50 File Offset: 0x0002BC50
		[Token(Token = "0x6006388")]
		[Address(RVA = "0xAF7748", Offset = "0xAF7748", VA = "0xAF7748")]
		private static int Difficulty_2_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			return 0;
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x0002DA68 File Offset: 0x0002BC68
		[Token(Token = "0x6006389")]
		[Address(RVA = "0xAF84BC", Offset = "0xAF84BC", VA = "0xAF84BC")]
		private static int Difficulty_2_GetMonsterPointsWorth(int slainMonsterID)
		{
			return 0;
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638A")]
		[Address(RVA = "0xAFAF38", Offset = "0xAFAF38", VA = "0xAFAF38")]
		private static void Difficulty_2_SpawnMonsterFromGate(Vector2 gateBottom, bool leftGate)
		{
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600638B")]
		[Address(RVA = "0xAF7A6C", Offset = "0xAF7A6C", VA = "0xAF7A6C")]
		private static short[] Difficulty_3_GetEnemiesForWave(int wave)
		{
			return null;
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x0002DA80 File Offset: 0x0002BC80
		[Token(Token = "0x600638C")]
		[Address(RVA = "0xAF7500", Offset = "0xAF7500", VA = "0xAF7500")]
		private static int Difficulty_3_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			return 0;
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[Token(Token = "0x600638D")]
		[Address(RVA = "0xAF83D4", Offset = "0xAF83D4", VA = "0xAF83D4")]
		private static int Difficulty_3_GetMonsterPointsWorth(int slainMonsterID)
		{
			return 0;
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638E")]
		[Address(RVA = "0xAF8910", Offset = "0xAF8910", VA = "0xAF8910")]
		private static void Difficulty_3_SpawnMonsterFromGate(Vector2 gateBottom, bool leftGate)
		{
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		[Token(Token = "0x600638F")]
		[Address(RVA = "0xB00CA4", Offset = "0xB00CA4", VA = "0xB00CA4")]
		public static bool IsStandActive(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006390")]
		[Address(RVA = "0xB00E4C", Offset = "0xB00E4C", VA = "0xB00E4C")]
		public static void RequestToSkipWaitTime(int x, int y)
		{
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006391")]
		[Address(RVA = "0xB0107C", Offset = "0xB0107C", VA = "0xB0107C")]
		public static void AttemptToSkipWaitTime()
		{
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006392")]
		[Address(RVA = "0xB00C38", Offset = "0xB00C38", VA = "0xB00C38")]
		private static IEntitySource GetSpawnSource_OldOnesArmy()
		{
			return null;
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006393")]
		[Address(RVA = "0xB0118C", Offset = "0xB0118C", VA = "0xB0118C")]
		public DD2Event()
		{
		}

		// Token: 0x0400A0B5 RID: 41141
		[Token(Token = "0x400A0B5")]
		[FieldOffset(Offset = "0x0")]
		public static bool DownedInvasionT1;

		// Token: 0x0400A0B6 RID: 41142
		[Token(Token = "0x400A0B6")]
		[FieldOffset(Offset = "0x1")]
		public static bool DownedInvasionT2;

		// Token: 0x0400A0B7 RID: 41143
		[Token(Token = "0x400A0B7")]
		[FieldOffset(Offset = "0x2")]
		public static bool DownedInvasionT3;

		// Token: 0x0400A0B8 RID: 41144
		[Token(Token = "0x400A0B8")]
		[FieldOffset(Offset = "0x3")]
		public static bool LostThisRun;

		// Token: 0x0400A0B9 RID: 41145
		[Token(Token = "0x400A0B9")]
		[FieldOffset(Offset = "0x4")]
		public static bool WonThisRun;

		// Token: 0x0400A0BA RID: 41146
		[Token(Token = "0x400A0BA")]
		[FieldOffset(Offset = "0x8")]
		public static int LaneSpawnRate;

		// Token: 0x0400A0BB RID: 41147
		[Token(Token = "0x400A0BB")]
		[FieldOffset(Offset = "0xC")]
		private static bool _downedDarkMageT1;

		// Token: 0x0400A0BC RID: 41148
		[Token(Token = "0x400A0BC")]
		[FieldOffset(Offset = "0xD")]
		private static bool _downedOgreT2;

		// Token: 0x0400A0BD RID: 41149
		[Token(Token = "0x400A0BD")]
		[FieldOffset(Offset = "0xE")]
		private static bool _spawnedBetsyT3;

		// Token: 0x0400A0BE RID: 41150
		[Token(Token = "0x400A0BE")]
		[FieldOffset(Offset = "0xF")]
		public static bool Ongoing;

		// Token: 0x0400A0BF RID: 41151
		[Token(Token = "0x400A0BF")]
		[FieldOffset(Offset = "0x10")]
		private static DD2Event.DamageTracker _damageTracker;

		// Token: 0x0400A0C0 RID: 41152
		[Token(Token = "0x400A0C0")]
		[FieldOffset(Offset = "0x14")]
		public static Rectangle ArenaHitbox;

		// Token: 0x0400A0C1 RID: 41153
		[Token(Token = "0x400A0C1")]
		[FieldOffset(Offset = "0x24")]
		private static int _arenaHitboxingCooldown;

		// Token: 0x0400A0C2 RID: 41154
		[Token(Token = "0x400A0C2")]
		[FieldOffset(Offset = "0x28")]
		public static int OngoingDifficulty;

		// Token: 0x0400A0C3 RID: 41155
		[Token(Token = "0x400A0C3")]
		[FieldOffset(Offset = "0x2C")]
		private static List<Vector2> _deadGoblinSpots;

		// Token: 0x0400A0C4 RID: 41156
		[Token(Token = "0x400A0C4")]
		[FieldOffset(Offset = "0x30")]
		private static int _crystalsDropping_lastWave;

		// Token: 0x0400A0C5 RID: 41157
		[Token(Token = "0x400A0C5")]
		[FieldOffset(Offset = "0x34")]
		private static int _crystalsDropping_toDrop;

		// Token: 0x0400A0C6 RID: 41158
		[Token(Token = "0x400A0C6")]
		[FieldOffset(Offset = "0x38")]
		private static int _crystalsDropping_alreadyDropped;

		// Token: 0x0400A0C7 RID: 41159
		[Token(Token = "0x400A0C7")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly Color INFO_NEW_WAVE_COLOR;

		// Token: 0x0400A0C8 RID: 41160
		[Token(Token = "0x400A0C8")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Color INFO_START_INVASION_COLOR;

		// Token: 0x0400A0C9 RID: 41161
		[Token(Token = "0x400A0C9")]
		[FieldOffset(Offset = "0x44")]
		private static readonly Color INFO_FAILURE_INVASION_COLOR;

		// Token: 0x0400A0CA RID: 41162
		[Token(Token = "0x400A0CA")]
		private const int INVASION_ID = 3;

		// Token: 0x0400A0CB RID: 41163
		[Token(Token = "0x400A0CB")]
		[FieldOffset(Offset = "0x48")]
		private static int _timeLeftUntilSpawningBegins;

		// Token: 0x02000D19 RID: 3353
		[Token(Token = "0x2000D19")]
		public class DamageTracker : NPCDamageTracker
		{
			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x06006395 RID: 25493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ABC")]
			public override LocalizedText Name
			{
				[Token(Token = "0x6006395")]
				[Address(RVA = "0xB01300", Offset = "0xB01300", VA = "0xB01300", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x06006396 RID: 25494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ABD")]
			public override LocalizedText KillTimeMessage
			{
				[Token(Token = "0x6006396")]
				[Address(RVA = "0xB01380", Offset = "0xB01380", VA = "0xB01380", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006397 RID: 25495 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
			[Token(Token = "0x6006397")]
			[Address(RVA = "0xB01430", Offset = "0xB01430", VA = "0xB01430", Slot = "6")]
			protected override bool IncludeDamageFor(NPC npc)
			{
				return default(bool);
			}

			// Token: 0x06006398 RID: 25496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006398")]
			[Address(RVA = "0xB014D8", Offset = "0xB014D8", VA = "0xB014D8")]
			public void Stop(bool won)
			{
			}

			// Token: 0x06006399 RID: 25497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006399")]
			[Address(RVA = "0xB014E4", Offset = "0xB014E4", VA = "0xB014E4")]
			public DamageTracker()
			{
			}

			// Token: 0x0400A0CC RID: 41164
			[Token(Token = "0x400A0CC")]
			[FieldOffset(Offset = "0x1C")]
			private bool _won;
		}

		// Token: 0x02000D1A RID: 3354
		[Token(Token = "0x2000D1A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600639B RID: 25499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600639B")]
			[Address(RVA = "0xB015C0", Offset = "0xB015C0", VA = "0xB015C0")]
			public <>c()
			{
			}

			// Token: 0x0600639C RID: 25500 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
			[Token(Token = "0x600639C")]
			[Address(RVA = "0xB015C8", Offset = "0xB015C8", VA = "0xB015C8")]
			internal bool <DropMedals>b__69_0(Player p)
			{
				return default(bool);
			}

			// Token: 0x0400A0CD RID: 41165
			[Token(Token = "0x400A0CD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DD2Event.<>c <>9;

			// Token: 0x0400A0CE RID: 41166
			[Token(Token = "0x400A0CE")]
			[FieldOffset(Offset = "0x4")]
			public static Predicate<Player> <>9__69_0;
		}
	}
}
