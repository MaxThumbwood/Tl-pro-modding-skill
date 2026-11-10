using System;
using Il2CppDummyDll;

// Token: 0x0200035B RID: 859
[Token(Token = "0x200035B")]
public class TutorialStep_09_Bestiary : TutorialStep
{
	// Token: 0x06001539 RID: 5433 RVA: 0x000095E8 File Offset: 0x000077E8
	[Token(Token = "0x6001539")]
	[Address(RVA = "0xDF6038", Offset = "0xDF6038", VA = "0xDF6038", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153A")]
	[Address(RVA = "0xDF6040", Offset = "0xDF6040", VA = "0xDF6040", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153B")]
	[Address(RVA = "0xDF6200", Offset = "0xDF6200", VA = "0xDF6200", Slot = "5")]
	public override void Begin()
	{
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153C")]
	[Address(RVA = "0xDF6278", Offset = "0xDF6278", VA = "0xDF6278", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153D")]
	[Address(RVA = "0xDF6284", Offset = "0xDF6284", VA = "0xDF6284", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00009600 File Offset: 0x00007800
	[Token(Token = "0x600153E")]
	[Address(RVA = "0xDF6288", Offset = "0xDF6288", VA = "0xDF6288", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153F")]
	[Address(RVA = "0xDF2790", Offset = "0xDF2790", VA = "0xDF2790")]
	public TutorialStep_09_Bestiary()
	{
	}

	// Token: 0x040029C0 RID: 10688
	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x8")]
	private bool openedBestiary;
}
