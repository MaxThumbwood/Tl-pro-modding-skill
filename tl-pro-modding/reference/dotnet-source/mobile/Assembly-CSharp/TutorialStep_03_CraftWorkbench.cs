using System;
using Il2CppDummyDll;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000355")]
public class TutorialStep_03_CraftWorkbench : TutorialStep
{
	// Token: 0x0600150F RID: 5391 RVA: 0x000094C8 File Offset: 0x000076C8
	[Token(Token = "0x600150F")]
	[Address(RVA = "0xDF37F0", Offset = "0xDF37F0", VA = "0xDF37F0", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001510")]
	[Address(RVA = "0xDF37F8", Offset = "0xDF37F8", VA = "0xDF37F8", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001511")]
	[Address(RVA = "0xDF3F08", Offset = "0xDF3F08", VA = "0xDF3F08", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001512")]
	[Address(RVA = "0xDF3F18", Offset = "0xDF3F18", VA = "0xDF3F18", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001513")]
	[Address(RVA = "0xDF3F54", Offset = "0xDF3F54", VA = "0xDF3F54", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileType)
	{
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x000094E0 File Offset: 0x000076E0
	[Token(Token = "0x6001514")]
	[Address(RVA = "0xDF3FF4", Offset = "0xDF3FF4", VA = "0xDF3FF4", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001515")]
	[Address(RVA = "0xDF2760", Offset = "0xDF2760", VA = "0xDF2760")]
	public TutorialStep_03_CraftWorkbench()
	{
	}

	// Token: 0x040029A4 RID: 10660
	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x8")]
	private bool got10Wood;

	// Token: 0x040029A5 RID: 10661
	[Token(Token = "0x40029A5")]
	[FieldOffset(Offset = "0x9")]
	private bool craftedWorkbench;

	// Token: 0x040029A6 RID: 10662
	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0xA")]
	private bool placedWorkbench;
}
