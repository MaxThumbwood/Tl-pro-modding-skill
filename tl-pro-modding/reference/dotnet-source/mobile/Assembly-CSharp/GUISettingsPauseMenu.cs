using System;
using Il2CppDummyDll;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
public class GUISettingsPauseMenu
{
	// Token: 0x06000B60 RID: 2912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0xC24668", Offset = "0xC24668", VA = "0xC24668")]
	private void SetupOffsets(bool setup)
	{
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x17000105")]
	private bool IncludeMPInvite
	{
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0xC24864", Offset = "0xC24864", VA = "0xC24864")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0xC2494C", Offset = "0xC2494C", VA = "0xC2494C")]
	public void Draw()
	{
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0xC27424", Offset = "0xC27424", VA = "0xC27424")]
	public GUISettingsPauseMenu()
	{
	}

	// Token: 0x04000D8C RID: 3468
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x8")]
	public bool Enabled;

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0xC")]
	public GUIContollerTransactionButtonList _controllerList;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x10")]
	private float settingsScale;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x14")]
	private float HomeButtonScale;

	// Token: 0x04000D90 RID: 3472
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x18")]
	private float AchievementsButtonScale;

	// Token: 0x04000D91 RID: 3473
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x1C")]
	private float BestiaryButtonScale;

	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x20")]
	private float ControlsButtonScale;

	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x24")]
	private float JourneySettingsButtonScale;

	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x28")]
	private float CloseButtonScale;

	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x2C")]
	private float InviteButtonScale;

	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x30")]
	private bool creativeModeActive;

	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0x31")]
	private bool includeMPInviteActive;
}
