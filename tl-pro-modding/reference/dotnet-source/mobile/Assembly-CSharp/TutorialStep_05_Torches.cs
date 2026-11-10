using System;
using Il2CppDummyDll;

// Token: 0x02000357 RID: 855
[Token(Token = "0x2000357")]
public class TutorialStep_05_Torches : TutorialStep
{
	// Token: 0x0600151D RID: 5405 RVA: 0x00009528 File Offset: 0x00007728
	[Token(Token = "0x600151D")]
	[Address(RVA = "0xDF4418", Offset = "0xDF4418", VA = "0xDF4418", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600151E")]
	[Address(RVA = "0xDF4420", Offset = "0xDF4420", VA = "0xDF4420", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151F")]
	[Address(RVA = "0xDF48B4", Offset = "0xDF48B4", VA = "0xDF48B4", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001520")]
	[Address(RVA = "0xDF48C0", Offset = "0xDF48C0", VA = "0xDF48C0", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001521")]
	[Address(RVA = "0xDF494C", Offset = "0xDF494C", VA = "0xDF494C", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00009540 File Offset: 0x00007740
	[Token(Token = "0x6001522")]
	[Address(RVA = "0xDF49D0", Offset = "0xDF49D0", VA = "0xDF49D0", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001523")]
	[Address(RVA = "0xDF2770", Offset = "0xDF2770", VA = "0xDF2770")]
	public TutorialStep_05_Torches()
	{
	}

	// Token: 0x040029AB RID: 10667
	[Token(Token = "0x40029AB")]
	[FieldOffset(Offset = "0x8")]
	private bool givenSword;

	// Token: 0x040029AC RID: 10668
	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x9")]
	private bool collectedGels;

	// Token: 0x040029AD RID: 10669
	[Token(Token = "0x40029AD")]
	[FieldOffset(Offset = "0xA")]
	private bool craftedTorches;

	// Token: 0x040029AE RID: 10670
	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0xB")]
	private bool torchesPlaced;
}
