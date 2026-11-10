using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x0200095B RID: 2395
	[Token(Token = "0x200095B")]
	public class DontStarveDarknessDamageDealer
	{
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x000251D0 File Offset: 0x000233D0
		// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000989")]
		public static int darknessTimer
		{
			[Token(Token = "0x6004FB5")]
			[Address(RVA = "0x753E9C", Offset = "0x753E9C", VA = "0x753E9C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004FB6")]
			[Address(RVA = "0x753F04", Offset = "0x753F04", VA = "0x753F04")]
			set
			{
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x000251E8 File Offset: 0x000233E8
		// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098A")]
		public static int darknessHitTimer
		{
			[Token(Token = "0x6004FB7")]
			[Address(RVA = "0x753F70", Offset = "0x753F70", VA = "0x753F70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004FB8")]
			[Address(RVA = "0x753FD8", Offset = "0x753FD8", VA = "0x753FD8")]
			set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x00025200 File Offset: 0x00023400
		// (set) Token: 0x06004FBA RID: 20410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098B")]
		public static bool saidMessage
		{
			[Token(Token = "0x6004FB9")]
			[Address(RVA = "0x754044", Offset = "0x754044", VA = "0x754044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FBA")]
			[Address(RVA = "0x7540AC", Offset = "0x7540AC", VA = "0x7540AC")]
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x00025218 File Offset: 0x00023418
		// (set) Token: 0x06004FBC RID: 20412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098C")]
		public static bool lastFrameWasTooBright
		{
			[Token(Token = "0x6004FBB")]
			[Address(RVA = "0x754118", Offset = "0x754118", VA = "0x754118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FBC")]
			[Address(RVA = "0x754180", Offset = "0x754180", VA = "0x754180")]
			set
			{
			}
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x7541EC", Offset = "0x7541EC", VA = "0x7541EC")]
		public static void Reset()
		{
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x7542A4", Offset = "0x7542A4", VA = "0x7542A4")]
		private static void ResetTimer()
		{
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00025230 File Offset: 0x00023430
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x754358", Offset = "0x754358", VA = "0x754358")]
		private static int GetDarknessDamagePerHit()
		{
			return 0;
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00025248 File Offset: 0x00023448
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x754360", Offset = "0x754360", VA = "0x754360")]
		private static int GetDarknessTimeBeforeStartingHits()
		{
			return 0;
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00025260 File Offset: 0x00023460
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x754368", Offset = "0x754368", VA = "0x754368")]
		private static int GetDarknessTimeForMessage()
		{
			return 0;
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x754370", Offset = "0x754370", VA = "0x754370")]
		public static void Update(Player player)
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x7546F8", Offset = "0x7546F8", VA = "0x7546F8")]
		private static void UpdateDarknessState(Player player)
		{
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00025278 File Offset: 0x00023478
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x754B14", Offset = "0x754B14", VA = "0x754B14")]
		private static bool IsPlayerSafe(Player player)
		{
			return default(bool);
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x754CD8", Offset = "0x754CD8", VA = "0x754CD8")]
		public DontStarveDarknessDamageDealer()
		{
		}

		// Token: 0x040093AE RID: 37806
		[Token(Token = "0x40093AE")]
		public const int DARKNESS_HIT_TIMER_MAX_BEFORE_HIT = 60;
	}
}
