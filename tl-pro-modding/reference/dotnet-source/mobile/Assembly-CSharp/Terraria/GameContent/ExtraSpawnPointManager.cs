using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	public class ExtraSpawnPointManager
	{
		// Token: 0x06005016 RID: 20502 RVA: 0x00025548 File Offset: 0x00023748
		[Token(Token = "0x6005016")]
		[Address(RVA = "0x75CED4", Offset = "0x75CED4", VA = "0x75CED4")]
		public static bool TryGetExtraSpawnPointForTeam(int team, out Point spawnPoint)
		{
			return default(bool);
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005017")]
		[Address(RVA = "0x75D0F8", Offset = "0x75D0F8", VA = "0x75D0F8")]
		public static void GenerateExtraSpawns_Setup()
		{
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005018")]
		[Address(RVA = "0x75D9F0", Offset = "0x75D9F0", VA = "0x75D9F0")]
		public static void ResetExtraSpawns()
		{
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005019")]
		[Address(RVA = "0x75DACC", Offset = "0x75DACC", VA = "0x75DACC")]
		public static void GenerateExtraSpawns()
		{
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00025560 File Offset: 0x00023760
		[Token(Token = "0x600501A")]
		[Address(RVA = "0x75E8E8", Offset = "0x75E8E8", VA = "0x75E8E8")]
		private static bool GenerateExtraSpawns_TryFindSpawnRandomly(List<Point> spawnPoints, Point fallbackSpawn)
		{
			return default(bool);
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00025578 File Offset: 0x00023778
		[Token(Token = "0x600501B")]
		[Address(RVA = "0x75F840", Offset = "0x75F840", VA = "0x75F840")]
		private static bool GenerateExtraSpawns_TryFindSpawnAt(List<Point> spawnPoints, ref int spawnX, ref int spawnY, int maxY)
		{
			return default(bool);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00025590 File Offset: 0x00023790
		[Token(Token = "0x600501C")]
		[Address(RVA = "0x75DF20", Offset = "0x75DF20", VA = "0x75DF20")]
		private static Point GenerateExtraSpawns_GetFallbackSpawn(int iteration, int iterationMax)
		{
			return default(Point);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x000255A8 File Offset: 0x000237A8
		[Token(Token = "0x600501D")]
		[Address(RVA = "0x7602C0", Offset = "0x7602C0", VA = "0x7602C0")]
		private static float GenerateExtraSpawns_WorldPercentileAvoidWorldSpawnIfNeeded(float currentPercentile)
		{
			return 0f;
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x000255C0 File Offset: 0x000237C0
		[Token(Token = "0x600501E")]
		[Address(RVA = "0x75FD90", Offset = "0x75FD90", VA = "0x75FD90")]
		private static int GenerateExtraSpawns_IterateDownToFloor(int spawnX, int spawnY, int maxY)
		{
			return 0;
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501F")]
		[Address(RVA = "0x76040C", Offset = "0x76040C", VA = "0x76040C")]
		public static void PrepareExtraSpawns()
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005020")]
		[Address(RVA = "0x76059C", Offset = "0x76059C", VA = "0x76059C")]
		public static void Clear()
		{
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x76067C", Offset = "0x76067C", VA = "0x76067C")]
		public static void Read(BinaryReader reader, bool networking = false)
		{
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x7607E4", Offset = "0x7607E4", VA = "0x7607E4")]
		public static void Write(BinaryWriter writer, bool networking = false)
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x76094C", Offset = "0x76094C", VA = "0x76094C")]
		public ExtraSpawnPointManager()
		{
		}

		// Token: 0x040093F1 RID: 37873
		[Token(Token = "0x40093F1")]
		[FieldOffset(Offset = "0x0")]
		public static Point[] extraSpawnPoints;

		// Token: 0x040093F2 RID: 37874
		[Token(Token = "0x40093F2")]
		[FieldOffset(Offset = "0x4")]
		public static ExtraSpawnSettings settings;

		// Token: 0x040093F3 RID: 37875
		[Token(Token = "0x40093F3")]
		[FieldOffset(Offset = "0x10")]
		private static List<LandmassData> _listOfLandmasses;

		// Token: 0x02000975 RID: 2421
		[Token(Token = "0x2000975")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06005025 RID: 20517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005025")]
			[Address(RVA = "0x75FD88", Offset = "0x75FD88", VA = "0x75FD88")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06005026 RID: 20518 RVA: 0x000255D8 File Offset: 0x000237D8
			[Token(Token = "0x6005026")]
			[Address(RVA = "0x760A4C", Offset = "0x760A4C", VA = "0x760A4C")]
			internal bool <GenerateExtraSpawns_TryFindSpawnAt>b__0(int x, int y, Tile tile, Tile leftTile, Tile rightTile)
			{
				return default(bool);
			}

			// Token: 0x040093F4 RID: 37876
			[Token(Token = "0x40093F4")]
			[FieldOffset(Offset = "0x8")]
			public List<Point> spawnPoints;
		}
	}
}
