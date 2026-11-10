using System;
using Il2CppDummyDll;

// Token: 0x02000351 RID: 849
[Token(Token = "0x2000351")]
public class TutorialStep
{
	// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0xDF2818", Offset = "0xDF2818", VA = "0xDF2818", Slot = "4")]
	public virtual void Reset()
	{
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0xDF281C", Offset = "0xDF281C", VA = "0xDF281C", Slot = "5")]
	public virtual void Begin()
	{
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00009450 File Offset: 0x00007650
	[Token(Token = "0x60014FC")]
	[Address(RVA = "0xDF2820", Offset = "0xDF2820", VA = "0xDF2820", Slot = "6")]
	public virtual bool Update()
	{
		return default(bool);
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00009468 File Offset: 0x00007668
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0xDF2828", Offset = "0xDF2828", VA = "0xDF2828", Slot = "7")]
	public virtual TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0xDF2830", Offset = "0xDF2830", VA = "0xDF2830", Slot = "8")]
	public virtual string GetGuideString()
	{
		return null;
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0xDF2880", Offset = "0xDF2880", VA = "0xDF2880", Slot = "9")]
	public virtual void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001500")]
	[Address(RVA = "0xDF2884", Offset = "0xDF2884", VA = "0xDF2884", Slot = "10")]
	public virtual void OnItemPlaced(int itemId, int tileType)
	{
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001501")]
	[Address(RVA = "0xDF2888", Offset = "0xDF2888", VA = "0xDF2888")]
	protected void SetTime(int hour, int min, bool freeze)
	{
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001502")]
	[Address(RVA = "0xDF2A58", Offset = "0xDF2A58", VA = "0xDF2A58")]
	protected void SetSpawnRate(float spawnRate)
	{
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001503")]
	[Address(RVA = "0xDF2B24", Offset = "0xDF2B24", VA = "0xDF2B24")]
	protected void GiveItem(short item, int stackCount)
	{
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001504")]
	[Address(RVA = "0xDF2D38", Offset = "0xDF2D38", VA = "0xDF2D38")]
	public TutorialStep()
	{
	}

	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public enum GuideOverLoadState
	{
		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		None,
		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		StepInProgessDialogue,
		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		StepCompleteDialogue
	}
}
