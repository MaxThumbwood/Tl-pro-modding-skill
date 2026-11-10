using System;
using Il2CppDummyDll;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000356")]
public class TutorialStep_04_CraftDoorAndChair : TutorialStep
{
	// Token: 0x06001516 RID: 5398 RVA: 0x000094F8 File Offset: 0x000076F8
	[Token(Token = "0x6001516")]
	[Address(RVA = "0xDF4204", Offset = "0xDF4204", VA = "0xDF4204", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001517")]
	[Address(RVA = "0xDF420C", Offset = "0xDF420C", VA = "0xDF420C", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001518")]
	[Address(RVA = "0xDF437C", Offset = "0xDF437C", VA = "0xDF437C", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001519")]
	[Address(RVA = "0xDF438C", Offset = "0xDF438C", VA = "0xDF438C", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151A")]
	[Address(RVA = "0xDF43AC", Offset = "0xDF43AC", VA = "0xDF43AC", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00009510 File Offset: 0x00007710
	[Token(Token = "0x600151B")]
	[Address(RVA = "0xDF43E8", Offset = "0xDF43E8", VA = "0xDF43E8", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151C")]
	[Address(RVA = "0xDF2768", Offset = "0xDF2768", VA = "0xDF2768")]
	public TutorialStep_04_CraftDoorAndChair()
	{
	}

	// Token: 0x040029A7 RID: 10663
	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x8")]
	private bool doorPlaced;

	// Token: 0x040029A8 RID: 10664
	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x9")]
	private bool chairPlaced;

	// Token: 0x040029A9 RID: 10665
	[Token(Token = "0x40029A9")]
	[FieldOffset(Offset = "0xA")]
	private bool tablePlaced;

	// Token: 0x040029AA RID: 10666
	[Token(Token = "0x40029AA")]
	[FieldOffset(Offset = "0xB")]
	private bool complete;
}
