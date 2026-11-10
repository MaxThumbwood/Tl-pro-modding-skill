using System;
using Il2CppDummyDll;

// Token: 0x0200035C RID: 860
[Token(Token = "0x200035C")]
public class TutorialStep_10_Settings : TutorialStep
{
	// Token: 0x06001540 RID: 5440 RVA: 0x00009618 File Offset: 0x00007818
	[Token(Token = "0x6001540")]
	[Address(RVA = "0xDF6330", Offset = "0xDF6330", VA = "0xDF6330", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001541")]
	[Address(RVA = "0xDF6338", Offset = "0xDF6338", VA = "0xDF6338", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001542")]
	[Address(RVA = "0xDF64A8", Offset = "0xDF64A8", VA = "0xDF64A8", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001543")]
	[Address(RVA = "0xDF64B4", Offset = "0xDF64B4", VA = "0xDF64B4", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001544")]
	[Address(RVA = "0xDF64B8", Offset = "0xDF64B8", VA = "0xDF64B8", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00009630 File Offset: 0x00007830
	[Token(Token = "0x6001545")]
	[Address(RVA = "0xDF64C4", Offset = "0xDF64C4", VA = "0xDF64C4", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001546")]
	[Address(RVA = "0xDF2798", Offset = "0xDF2798", VA = "0xDF2798")]
	public TutorialStep_10_Settings()
	{
	}

	// Token: 0x040029C1 RID: 10689
	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x8")]
	private bool complete;
}
