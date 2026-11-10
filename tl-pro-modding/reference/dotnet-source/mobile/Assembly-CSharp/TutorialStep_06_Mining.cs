using System;
using Il2CppDummyDll;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000358")]
public class TutorialStep_06_Mining : TutorialStep
{
	// Token: 0x06001524 RID: 5412 RVA: 0x00009558 File Offset: 0x00007758
	[Token(Token = "0x6001524")]
	[Address(RVA = "0xDF4CE4", Offset = "0xDF4CE4", VA = "0xDF4CE4", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001525")]
	[Address(RVA = "0xDF4CEC", Offset = "0xDF4CEC", VA = "0xDF4CEC", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001526")]
	[Address(RVA = "0xDF4E0C", Offset = "0xDF4E0C", VA = "0xDF4E0C", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001527")]
	[Address(RVA = "0xDF4E1C", Offset = "0xDF4E1C", VA = "0xDF4E1C", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001528")]
	[Address(RVA = "0xDF4E20", Offset = "0xDF4E20", VA = "0xDF4E20", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00009570 File Offset: 0x00007770
	[Token(Token = "0x6001529")]
	[Address(RVA = "0xDF4E88", Offset = "0xDF4E88", VA = "0xDF4E88", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152A")]
	[Address(RVA = "0xDF2778", Offset = "0xDF2778", VA = "0xDF2778")]
	public TutorialStep_06_Mining()
	{
	}

	// Token: 0x040029AF RID: 10671
	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x8")]
	private bool givenPickaxe;

	// Token: 0x040029B0 RID: 10672
	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x9")]
	private bool collectedOres;

	// Token: 0x040029B1 RID: 10673
	[Token(Token = "0x40029B1")]
	[FieldOffset(Offset = "0xA")]
	private bool givenFurnace;
}
