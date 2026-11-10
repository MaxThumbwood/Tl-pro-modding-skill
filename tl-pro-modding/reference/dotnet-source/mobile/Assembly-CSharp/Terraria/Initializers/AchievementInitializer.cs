using System;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.Initializers
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	public class AchievementInitializer
	{
		// Token: 0x06004090 RID: 16528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x1EBFFA8", Offset = "0x1EBFFA8", VA = "0x1EBFFA8")]
		public static void Load()
		{
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x1EC99BC", Offset = "0x1EC99BC", VA = "0x1EC99BC")]
		public static void HandleBootConflict(bool goingIntoAchievements = false)
		{
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004092")]
		[Address(RVA = "0x1EC99C0", Offset = "0x1EC99C0", VA = "0x1EC99C0")]
		private static void OnAchievementCompleted(Achievement achievement)
		{
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x1EC9B2C", Offset = "0x1EC9B2C", VA = "0x1EC9B2C")]
		public AchievementInitializer()
		{
		}

		// Token: 0x04004E7C RID: 20092
		[Token(Token = "0x4004E7C")]
		[FieldOffset(Offset = "0x0")]
		public static bool HandlingBootConflict;
	}
}
