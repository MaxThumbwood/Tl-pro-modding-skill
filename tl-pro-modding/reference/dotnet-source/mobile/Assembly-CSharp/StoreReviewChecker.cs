using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
public static class StoreReviewChecker
{
	// Token: 0x06001227 RID: 4647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001227")]
	[Address(RVA = "0xD81E0C", Offset = "0xD81E0C", VA = "0xD81E0C")]
	private static void DisplayReview()
	{
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001228")]
	[Address(RVA = "0xD81EB8", Offset = "0xD81EB8", VA = "0xD81EB8")]
	public static void CheckMenuIdle()
	{
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001229")]
	[Address(RVA = "0xD8238C", Offset = "0xD8238C", VA = "0xD8238C")]
	public static void StartPlaying(TimeSpan playerPlayTime)
	{
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122A")]
	[Address(RVA = "0xD82480", Offset = "0xD82480", VA = "0xD82480")]
	public static void StopPlaying(TimeSpan playerPlayTime)
	{
	}

	// Token: 0x0400238A RID: 9098
	[Token(Token = "0x400238A")]
	[FieldOffset(Offset = "0x0")]
	private static bool madeRequest;

	// Token: 0x0400238B RID: 9099
	[Token(Token = "0x400238B")]
	[FieldOffset(Offset = "0x4")]
	private static int lastFrameCheck;

	// Token: 0x0400238C RID: 9100
	[Token(Token = "0x400238C")]
	[FieldOffset(Offset = "0x8")]
	private static DateTime idleTimeStart;

	// Token: 0x0400238D RID: 9101
	[Token(Token = "0x400238D")]
	[FieldOffset(Offset = "0x10")]
	private static bool canMakeRequest;

	// Token: 0x0400238E RID: 9102
	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x18")]
	private static TimeSpan initialPlayTime;

	// Token: 0x0400238F RID: 9103
	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 lastMousePosition;
}
