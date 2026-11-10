using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D17 RID: 3351
	[Token(Token = "0x2000D17")]
	public class CultistRitual
	{
		// Token: 0x0600634F RID: 25423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634F")]
		[Address(RVA = "0xAF2DD8", Offset = "0xAF2DD8", VA = "0xAF2DD8")]
		public static void UpdateTime()
		{
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006350")]
		[Address(RVA = "0xAF3190", Offset = "0xAF3190", VA = "0xAF3190")]
		public static void CultistSlain()
		{
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006351")]
		[Address(RVA = "0xAF31E8", Offset = "0xAF31E8", VA = "0xAF31E8")]
		public static void TabletDestroyed()
		{
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x0002D8A0 File Offset: 0x0002BAA0
		[Token(Token = "0x6006352")]
		[Address(RVA = "0xAF2F84", Offset = "0xAF2F84", VA = "0xAF2F84")]
		public static bool TrySpawning(int x, int y, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		[Token(Token = "0x6006353")]
		[Address(RVA = "0xAF323C", Offset = "0xAF323C", VA = "0xAF323C")]
		private static bool CheckRitual(int x, int y, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
		[Token(Token = "0x6006354")]
		[Address(RVA = "0xAF34AC", Offset = "0xAF34AC", VA = "0xAF34AC")]
		public static bool CheckFloor(Vector2 Center, out Point[] spawnPoints)
		{
			return default(bool);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x0002D8E8 File Offset: 0x0002BAE8
		[Token(Token = "0x6006355")]
		[Address(RVA = "0xAF38C4", Offset = "0xAF38C4", VA = "0xAF38C4")]
		public static bool CheckFloor2(Vector2 Center, out Point[] spawnPoints)
		{
			return default(bool);
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006356")]
		[Address(RVA = "0xAF3CDC", Offset = "0xAF3CDC", VA = "0xAF3CDC")]
		public CultistRitual()
		{
		}

		// Token: 0x0400A0AF RID: 41135
		[Token(Token = "0x400A0AF")]
		[FieldOffset(Offset = "0x0")]
		public static int delay;

		// Token: 0x0400A0B0 RID: 41136
		[Token(Token = "0x400A0B0")]
		[FieldOffset(Offset = "0x4")]
		public static int recheck;

		// Token: 0x0400A0B1 RID: 41137
		[Token(Token = "0x400A0B1")]
		public const int delayStart = 86400;

		// Token: 0x0400A0B2 RID: 41138
		[Token(Token = "0x400A0B2")]
		public const int respawnDelay = 43200;

		// Token: 0x0400A0B3 RID: 41139
		[Token(Token = "0x400A0B3")]
		private const int timePerCultist = 3600;

		// Token: 0x0400A0B4 RID: 41140
		[Token(Token = "0x400A0B4")]
		private const int recheckStart = 600;
	}
}
