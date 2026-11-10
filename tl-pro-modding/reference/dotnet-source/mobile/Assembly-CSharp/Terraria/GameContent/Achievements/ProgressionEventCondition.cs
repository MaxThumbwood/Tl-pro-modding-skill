using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000C62")]
	public class ProgressionEventCondition : AchievementCondition
	{
		// Token: 0x06005E2D RID: 24109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0x9BA630", Offset = "0x9BA630", VA = "0x9BA630")]
		private ProgressionEventCondition(int eventID)
		{
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0x9BAAAC", Offset = "0x9BAAAC", VA = "0x9BAAAC")]
		private ProgressionEventCondition(int[] eventIDs)
		{
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0x9BAB6C", Offset = "0x9BAB6C", VA = "0x9BAB6C", Slot = "5")]
		public override void Shutdown()
		{
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0x9BA72C", Offset = "0x9BA72C", VA = "0x9BA72C")]
		private static void ListenForPickup(ProgressionEventCondition condition)
		{
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0x9BAC8C", Offset = "0x9BAC8C", VA = "0x9BAC8C")]
		private static void ProgressionEventListener(int eventID)
		{
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0x9BAF04", Offset = "0x9BAF04", VA = "0x9BAF04")]
		public static ProgressionEventCondition Create(int[] eventIDs)
		{
			return null;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0x9BAF74", Offset = "0x9BAF74", VA = "0x9BAF74")]
		public static ProgressionEventCondition Create(int eventID)
		{
			return null;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0x9BAFE4", Offset = "0x9BAFE4", VA = "0x9BAFE4")]
		public static ProgressionEventCondition[] CreateMany(int[] eventIDs)
		{
			return null;
		}

		// Token: 0x04009DD7 RID: 40407
		[Token(Token = "0x4009DD7")]
		private const string Identifier = "PROGRESSION_EVENT";

		// Token: 0x04009DD8 RID: 40408
		[Token(Token = "0x4009DD8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, List<ProgressionEventCondition>> _listeners;

		// Token: 0x04009DD9 RID: 40409
		[Token(Token = "0x4009DD9")]
		[FieldOffset(Offset = "0x4")]
		private static bool _isListenerHooked;

		// Token: 0x04009DDA RID: 40410
		[Token(Token = "0x4009DDA")]
		[FieldOffset(Offset = "0x18")]
		private int[] _eventIDs;
	}
}
