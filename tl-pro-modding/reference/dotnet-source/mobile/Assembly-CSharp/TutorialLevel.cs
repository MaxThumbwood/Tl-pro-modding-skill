using System;
using Il2CppDummyDll;

// Token: 0x02000350 RID: 848
[Token(Token = "0x2000350")]
public class TutorialLevel
{
	// Token: 0x060014F1 RID: 5361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F1")]
	[Address(RVA = "0xDF1E20", Offset = "0xDF1E20", VA = "0xDF1E20")]
	public void Begin()
	{
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F2")]
	[Address(RVA = "0xDF1EA0", Offset = "0xDF1EA0", VA = "0xDF1EA0")]
	public void Update()
	{
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00009420 File Offset: 0x00007620
	[Token(Token = "0x60014F3")]
	[Address(RVA = "0xDF1F7C", Offset = "0xDF1F7C", VA = "0xDF1F7C")]
	public TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014F4")]
	[Address(RVA = "0xDF1FEC", Offset = "0xDF1FEC", VA = "0xDF1FEC")]
	public string GetGuideString()
	{
		return null;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00009438 File Offset: 0x00007638
	[Token(Token = "0x60014F5")]
	[Address(RVA = "0xDF20A0", Offset = "0xDF20A0", VA = "0xDF20A0")]
	public bool IsComplete()
	{
		return default(bool);
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F6")]
	[Address(RVA = "0xDF20CC", Offset = "0xDF20CC", VA = "0xDF20CC")]
	public void OnGuideDialogueOpen()
	{
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0xDF2134", Offset = "0xDF2134", VA = "0xDF2134")]
	public void OnItemPlaced(int itemId, int tileType)
	{
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0xDF21B0", Offset = "0xDF21B0", VA = "0xDF21B0")]
	public TutorialLevel()
	{
	}

	// Token: 0x04002998 RID: 10648
	[Token(Token = "0x4002998")]
	[FieldOffset(Offset = "0x0")]
	public static TutorialLevel Instance;

	// Token: 0x04002999 RID: 10649
	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x8")]
	public readonly TutorialStep[] Steps;

	// Token: 0x0400299A RID: 10650
	[Token(Token = "0x400299A")]
	[FieldOffset(Offset = "0xC")]
	public bool JMSettingsDisabled;

	// Token: 0x0400299B RID: 10651
	[Token(Token = "0x400299B")]
	[FieldOffset(Offset = "0xD")]
	public bool Enabled;

	// Token: 0x0400299C RID: 10652
	[Token(Token = "0x400299C")]
	[FieldOffset(Offset = "0x10")]
	private int activeStep;

	// Token: 0x0400299D RID: 10653
	[Token(Token = "0x400299D")]
	[FieldOffset(Offset = "0x14")]
	public string TutorialPopupText;
}
