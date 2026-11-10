using System;
using Il2CppDummyDll;

// Token: 0x0200035D RID: 861
[Token(Token = "0x200035D")]
public class TutorialStep_11_Complete : TutorialStep
{
	// Token: 0x06001547 RID: 5447 RVA: 0x00009648 File Offset: 0x00007848
	[Token(Token = "0x6001547")]
	[Address(RVA = "0xDF64CC", Offset = "0xDF64CC", VA = "0xDF64CC", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001548")]
	[Address(RVA = "0xDF64D4", Offset = "0xDF64D4", VA = "0xDF64D4", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001549")]
	[Address(RVA = "0xDF6644", Offset = "0xDF6644", VA = "0xDF6644", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154A")]
	[Address(RVA = "0xDF6650", Offset = "0xDF6650", VA = "0xDF6650", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154B")]
	[Address(RVA = "0xDF6654", Offset = "0xDF6654", VA = "0xDF6654", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00009660 File Offset: 0x00007860
	[Token(Token = "0x600154C")]
	[Address(RVA = "0xDF6724", Offset = "0xDF6724", VA = "0xDF6724", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154D")]
	[Address(RVA = "0xDF27A0", Offset = "0xDF27A0", VA = "0xDF27A0")]
	public TutorialStep_11_Complete()
	{
	}

	// Token: 0x040029C2 RID: 10690
	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x8")]
	private bool complete;
}
