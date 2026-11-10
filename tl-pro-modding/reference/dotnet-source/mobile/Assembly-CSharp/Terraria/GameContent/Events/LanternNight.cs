using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x2000D1B")]
	public class LanternNight
	{
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600639D RID: 25501 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[Token(Token = "0x17000ABE")]
		public static bool LanternsUp
		{
			[Token(Token = "0x600639D")]
			[Address(RVA = "0xB015D0", Offset = "0xB015D0", VA = "0xB015D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639E")]
		[Address(RVA = "0xB01638", Offset = "0xB01638", VA = "0xB01638")]
		public static void CheckMorning()
		{
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639F")]
		[Address(RVA = "0xB016A4", Offset = "0xB016A4", VA = "0xB016A4")]
		public static void CheckNight()
		{
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Token(Token = "0x60063A0")]
		[Address(RVA = "0xB0185C", Offset = "0xB0185C", VA = "0xB0185C")]
		public static bool LanternsCanPersist()
		{
			return default(bool);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[Token(Token = "0x60063A1")]
		[Address(RVA = "0xB018D0", Offset = "0xB018D0", VA = "0xB018D0")]
		public static bool LanternsCanStart()
		{
			return default(bool);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x0002DB40 File Offset: 0x0002BD40
		[Token(Token = "0x60063A2")]
		[Address(RVA = "0xB01A40", Offset = "0xB01A40", VA = "0xB01A40")]
		private static bool BossIsActive()
		{
			return default(bool);
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A3")]
		[Address(RVA = "0xB016A8", Offset = "0xB016A8", VA = "0xB016A8")]
		private static void NaturalAttempt()
		{
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A4")]
		[Address(RVA = "0xB01B08", Offset = "0xB01B08", VA = "0xB01B08")]
		public static void ToggleManualLanterns()
		{
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A5")]
		[Address(RVA = "0xB01CE4", Offset = "0xB01CE4", VA = "0xB01CE4")]
		public static void WorldClear()
		{
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A6")]
		[Address(RVA = "0xB01D40", Offset = "0xB01D40", VA = "0xB01D40")]
		public static void UpdateTime()
		{
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A7")]
		[Address(RVA = "0xB020B0", Offset = "0xB020B0", VA = "0xB020B0")]
		public LanternNight()
		{
		}

		// Token: 0x0400A0CF RID: 41167
		[Token(Token = "0x400A0CF")]
		[FieldOffset(Offset = "0x0")]
		public static bool ManualLanterns;

		// Token: 0x0400A0D0 RID: 41168
		[Token(Token = "0x400A0D0")]
		[FieldOffset(Offset = "0x1")]
		public static bool GenuineLanterns;

		// Token: 0x0400A0D1 RID: 41169
		[Token(Token = "0x400A0D1")]
		[FieldOffset(Offset = "0x2")]
		public static bool NextNightIsLanternNight;

		// Token: 0x0400A0D2 RID: 41170
		[Token(Token = "0x400A0D2")]
		[FieldOffset(Offset = "0x4")]
		public static int LanternNightsOnCooldown;

		// Token: 0x0400A0D3 RID: 41171
		[Token(Token = "0x400A0D3")]
		[FieldOffset(Offset = "0x8")]
		private static bool _wasLanternNight;
	}
}
