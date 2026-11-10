using System;
using Il2CppDummyDll;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class XBOPlatformEvent
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006F")]
	public static string UserId
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4A5DB4", Offset = "0x4A5DB4", VA = "0x4A5DB4")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x4A5E04", Offset = "0x4A5E04", VA = "0x4A5E04")]
	public static void SendAchievementProgress(string identifier, float progress)
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x4A5E08", Offset = "0x4A5E08", VA = "0x4A5E08")]
	public static void SendGameProgress(float progress)
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x4A5E0C", Offset = "0x4A5E0C", VA = "0x4A5E0C")]
	public static void SendMedalsUpdated(int Medals)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x4A5E10", Offset = "0x4A5E10", VA = "0x4A5E10")]
	public static void SendRankedMatchesUpdated(int RankedMatches)
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x4A5E14", Offset = "0x4A5E14", VA = "0x4A5E14")]
	public static void SendRankedVicotriesUpdated(int RankedVictories)
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x4A5E18", Offset = "0x4A5E18", VA = "0x4A5E18")]
	public static void SendThreeStarVictoriesUpdated(int ThreeStarVictories)
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x4A5E1C", Offset = "0x4A5E1C", VA = "0x4A5E1C")]
	public static void SendUnitsDonatedUpdated(int UnitsDonated)
	{
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x4A5E20", Offset = "0x4A5E20", VA = "0x4A5E20")]
	public static void SendUnitsUnlockedUpdated(int UnitsUnlocked)
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x4A5E24", Offset = "0x4A5E24", VA = "0x4A5E24")]
	public static void SendMultiplayerRoundStart(ref Guid sessionGUID, string correlationId)
	{
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x4A5E28", Offset = "0x4A5E28", VA = "0x4A5E28")]
	public static void SendMultiplayerRoundEnd(ref Guid sessionGUID, string correlationId, float gameTime)
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x4A5E2C", Offset = "0x4A5E2C", VA = "0x4A5E2C")]
	public XBOPlatformEvent()
	{
	}
}
