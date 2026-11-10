using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D22 RID: 3362
	[Token(Token = "0x2000D22")]
	public class Sandstorm
	{
		// Token: 0x060063D6 RID: 25558 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		[Token(Token = "0x60063D6")]
		[Address(RVA = "0xB077A0", Offset = "0xB077A0", VA = "0xB077A0")]
		private static bool HasSufficientWind()
		{
			return default(bool);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0xB07864", Offset = "0xB07864", VA = "0xB07864")]
		public static void WorldClear()
		{
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0xB078B8", Offset = "0xB078B8", VA = "0xB078B8")]
		public static void UpdateTime()
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0xB07DB8", Offset = "0xB07DB8", VA = "0xB07DB8")]
		private static void ChangeSeverityIntentions()
		{
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0xB07FCC", Offset = "0xB07FCC", VA = "0xB07FCC")]
		private static void UpdateSeverity()
		{
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DB")]
		[Address(RVA = "0xB07CF4", Offset = "0xB07CF4", VA = "0xB07CF4")]
		private static void StartSandstorm()
		{
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0xB07C98", Offset = "0xB07C98", VA = "0xB07C98")]
		private static void StopSandstorm()
		{
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[Token(Token = "0x60063DD")]
		[Address(RVA = "0xB081B4", Offset = "0xB081B4", VA = "0xB081B4")]
		public static bool ShowSandstormVisuals()
		{
			return default(bool);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0xB0831C", Offset = "0xB0831C", VA = "0xB0831C")]
		public static void EmitDust()
		{
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xB09644", Offset = "0xB09644", VA = "0xB09644")]
		public Sandstorm()
		{
		}

		// Token: 0x0400A0E9 RID: 41193
		[Token(Token = "0x400A0E9")]
		private const int SANDSTORM_DURATION_MINIMUM = 28800;

		// Token: 0x0400A0EA RID: 41194
		[Token(Token = "0x400A0EA")]
		private const int SANDSTORM_DURATION_MAXIMUM = 86400;

		// Token: 0x0400A0EB RID: 41195
		[Token(Token = "0x400A0EB")]
		[FieldOffset(Offset = "0x0")]
		public static bool Happening;

		// Token: 0x0400A0EC RID: 41196
		[Token(Token = "0x400A0EC")]
		[FieldOffset(Offset = "0x4")]
		public static int TimeLeft;

		// Token: 0x0400A0ED RID: 41197
		[Token(Token = "0x400A0ED")]
		[FieldOffset(Offset = "0x8")]
		public static float Severity;

		// Token: 0x0400A0EE RID: 41198
		[Token(Token = "0x400A0EE")]
		[FieldOffset(Offset = "0xC")]
		public static float IntendedSeverity;
	}
}
