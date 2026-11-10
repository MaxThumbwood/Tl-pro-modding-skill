using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x2000D15")]
	public class BirthdayParty
	{
		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06006341 RID: 25409 RVA: 0x0002D858 File Offset: 0x0002BA58
		[Token(Token = "0x17000AB4")]
		public static bool PartyIsUp
		{
			[Token(Token = "0x6006341")]
			[Address(RVA = "0xAF0C54", Offset = "0xAF0C54", VA = "0xAF0C54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006342")]
		[Address(RVA = "0xAF0CF4", Offset = "0xAF0CF4", VA = "0xAF0CF4")]
		public static void CheckMorning()
		{
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006343")]
		[Address(RVA = "0xAF1C98", Offset = "0xAF1C98", VA = "0xAF1C98")]
		public static void CheckNight()
		{
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x0002D870 File Offset: 0x0002BA70
		[Token(Token = "0x6006344")]
		[Address(RVA = "0xAF1F58", Offset = "0xAF1F58", VA = "0xAF1F58")]
		private static bool CanNPCParty(NPC n)
		{
			return default(bool);
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006345")]
		[Address(RVA = "0xAF0D58", Offset = "0xAF0D58", VA = "0xAF0D58")]
		private static void NaturalAttempt()
		{
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006346")]
		[Address(RVA = "0xAF2114", Offset = "0xAF2114", VA = "0xAF2114")]
		public static void ToggleManualParty()
		{
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006347")]
		[Address(RVA = "0xAF2030", Offset = "0xAF2030", VA = "0xAF2030")]
		private static void CheckForAchievement()
		{
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006348")]
		[Address(RVA = "0xAF23FC", Offset = "0xAF23FC", VA = "0xAF23FC")]
		public static void WorldClear()
		{
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006349")]
		[Address(RVA = "0xAF24A4", Offset = "0xAF24A4", VA = "0xAF24A4")]
		public static void UpdateTime()
		{
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634A")]
		[Address(RVA = "0xAF2C2C", Offset = "0xAF2C2C", VA = "0xAF2C2C")]
		public BirthdayParty()
		{
		}

		// Token: 0x0400A0A8 RID: 41128
		[Token(Token = "0x400A0A8")]
		[FieldOffset(Offset = "0x0")]
		public static bool ManualParty;

		// Token: 0x0400A0A9 RID: 41129
		[Token(Token = "0x400A0A9")]
		[FieldOffset(Offset = "0x1")]
		public static bool GenuineParty;

		// Token: 0x0400A0AA RID: 41130
		[Token(Token = "0x400A0AA")]
		[FieldOffset(Offset = "0x4")]
		public static int PartyDaysOnCooldown;

		// Token: 0x0400A0AB RID: 41131
		[Token(Token = "0x400A0AB")]
		[FieldOffset(Offset = "0x8")]
		public static List<int> CelebratingNPCs;

		// Token: 0x0400A0AC RID: 41132
		[Token(Token = "0x400A0AC")]
		[FieldOffset(Offset = "0xC")]
		private static bool _wasCelebrating;

		// Token: 0x02000D16 RID: 3350
		[Token(Token = "0x2000D16")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600634D RID: 25421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634D")]
			[Address(RVA = "0xAF2D54", Offset = "0xAF2D54", VA = "0xAF2D54")]
			public <>c()
			{
			}

			// Token: 0x0600634E RID: 25422 RVA: 0x0002D888 File Offset: 0x0002BA88
			[Token(Token = "0x600634E")]
			[Address(RVA = "0xAF2D5C", Offset = "0xAF2D5C", VA = "0xAF2D5C")]
			internal int <NaturalAttempt>b__10_0(NPC i)
			{
				return 0;
			}

			// Token: 0x0400A0AD RID: 41133
			[Token(Token = "0x400A0AD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BirthdayParty.<>c <>9;

			// Token: 0x0400A0AE RID: 41134
			[Token(Token = "0x400A0AE")]
			[FieldOffset(Offset = "0x4")]
			public static Func<NPC, int> <>9__10_0;
		}
	}
}
