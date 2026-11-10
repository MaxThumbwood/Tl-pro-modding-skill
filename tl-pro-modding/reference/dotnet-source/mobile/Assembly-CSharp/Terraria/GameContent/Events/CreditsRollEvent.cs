using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class CreditsRollEvent
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060063C1 RID: 25537 RVA: 0x0002DC18 File Offset: 0x0002BE18
		[Token(Token = "0x17000AC3")]
		public static bool IsEventOngoing
		{
			[Token(Token = "0x60063C1")]
			[Address(RVA = "0xB05794", Offset = "0xB05794", VA = "0xB05794")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0xB057F0", Offset = "0xB057F0", VA = "0xB057F0")]
		public static void TryStartingCreditsRoll()
		{
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C3")]
		[Address(RVA = "0xB059F8", Offset = "0xB059F8", VA = "0xB059F8")]
		public static void SendCreditsRollRemainingTimeToPlayer(int playerIndex)
		{
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C4")]
		[Address(RVA = "0xB05B18", Offset = "0xB05B18", VA = "0xB05B18")]
		public static void UpdateTime()
		{
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0xB05BD4", Offset = "0xB05BD4", VA = "0xB05BD4")]
		public static void Reset()
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0xB05C28", Offset = "0xB05C28", VA = "0xB05C28")]
		public static void SetRemainingTimeDirect(int time)
		{
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C7")]
		[Address(RVA = "0xB05CDC", Offset = "0xB05CDC", VA = "0xB05CDC")]
		public CreditsRollEvent()
		{
		}

		// Token: 0x0400A0E3 RID: 41187
		[Token(Token = "0x400A0E3")]
		private const int MAX_TIME_FOR_CREDITS_ROLL_IN_FRAMES = 28800;

		// Token: 0x0400A0E4 RID: 41188
		[Token(Token = "0x400A0E4")]
		[FieldOffset(Offset = "0x0")]
		private static int _creditsRollRemainingTime;
	}
}
