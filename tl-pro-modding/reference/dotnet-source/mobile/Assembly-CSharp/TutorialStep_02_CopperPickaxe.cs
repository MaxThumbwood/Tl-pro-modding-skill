using System;
using Il2CppDummyDll;

// Token: 0x02000354 RID: 852
[Token(Token = "0x2000354")]
public class TutorialStep_02_CopperPickaxe : TutorialStep
{
	// Token: 0x06001509 RID: 5385 RVA: 0x00009498 File Offset: 0x00007698
	[Token(Token = "0x6001509")]
	[Address(RVA = "0xDF32C8", Offset = "0xDF32C8", VA = "0xDF32C8", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600150A")]
	[Address(RVA = "0xDF32D0", Offset = "0xDF32D0", VA = "0xDF32D0", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150B")]
	[Address(RVA = "0xDF3620", Offset = "0xDF3620", VA = "0xDF3620", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150C")]
	[Address(RVA = "0xDF362C", Offset = "0xDF362C", VA = "0xDF362C", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x000094B0 File Offset: 0x000076B0
	[Token(Token = "0x600150D")]
	[Address(RVA = "0xDF3738", Offset = "0xDF3738", VA = "0xDF3738", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150E")]
	[Address(RVA = "0xDF2758", Offset = "0xDF2758", VA = "0xDF2758")]
	public TutorialStep_02_CopperPickaxe()
	{
	}

	// Token: 0x040029A3 RID: 10659
	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x8")]
	private bool givenAxe;
}
