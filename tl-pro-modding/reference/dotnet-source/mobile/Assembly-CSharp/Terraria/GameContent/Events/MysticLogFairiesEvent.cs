using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x2000D21")]
	public class MysticLogFairiesEvent
	{
		// Token: 0x060063CB RID: 25547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CB")]
		[Address(RVA = "0xB061E4", Offset = "0xB061E4", VA = "0xB061E4")]
		public void WorldClear()
		{
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CC")]
		[Address(RVA = "0xB0624C", Offset = "0xB0624C", VA = "0xB0624C")]
		public void StartWorld()
		{
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CD")]
		[Address(RVA = "0xB069D8", Offset = "0xB069D8", VA = "0xB069D8")]
		public void StartNight()
		{
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CE")]
		[Address(RVA = "0xB06A5C", Offset = "0xB06A5C", VA = "0xB06A5C")]
		public void UpdateTime()
		{
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0xB06B68", Offset = "0xB06B68", VA = "0xB06B68")]
		private bool IsAGoodTime()
		{
			return default(bool);
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0xB06C74", Offset = "0xB06C74", VA = "0xB06C74")]
		private void TrySpawningFairies()
		{
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0xB074CC", Offset = "0xB074CC", VA = "0xB074CC")]
		public void FallenLogDestroyed()
		{
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0xB062C0", Offset = "0xB062C0", VA = "0xB062C0")]
		private void ScanWholeOverworldForLogs()
		{
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x0002DC78 File Offset: 0x0002BE78
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0xB07540", Offset = "0xB07540", VA = "0xB07540")]
		private Point GetStumpTopLeft(Point stumpRandomPoint)
		{
			return default(Point);
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[Token(Token = "0x60063D4")]
		[Address(RVA = "0xB07408", Offset = "0xB07408", VA = "0xB07408")]
		private int GetOneOverSpawnChance()
		{
			return 0;
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0xB07708", Offset = "0xB07708", VA = "0xB07708")]
		public MysticLogFairiesEvent()
		{
		}

		// Token: 0x0400A0E5 RID: 41189
		[Token(Token = "0x400A0E5")]
		[FieldOffset(Offset = "0x8")]
		private bool _canSpawnFairies;

		// Token: 0x0400A0E6 RID: 41190
		[Token(Token = "0x400A0E6")]
		[FieldOffset(Offset = "0xC")]
		private int _delayUntilNextAttempt;

		// Token: 0x0400A0E7 RID: 41191
		[Token(Token = "0x400A0E7")]
		private const int DELAY_BETWEEN_ATTEMPTS = 60;

		// Token: 0x0400A0E8 RID: 41192
		[Token(Token = "0x400A0E8")]
		[FieldOffset(Offset = "0x10")]
		private List<Point> _stumpCoords;
	}
}
