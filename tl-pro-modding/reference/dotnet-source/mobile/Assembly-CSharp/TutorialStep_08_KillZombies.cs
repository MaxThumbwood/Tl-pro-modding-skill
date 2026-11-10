using System;
using Il2CppDummyDll;

// Token: 0x0200035A RID: 858
[Token(Token = "0x200035A")]
public class TutorialStep_08_KillZombies : TutorialStep
{
	// Token: 0x06001532 RID: 5426 RVA: 0x000095B8 File Offset: 0x000077B8
	[Token(Token = "0x6001532")]
	[Address(RVA = "0xDF57F8", Offset = "0xDF57F8", VA = "0xDF57F8", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001533")]
	[Address(RVA = "0xDF5800", Offset = "0xDF5800", VA = "0xDF5800", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001534")]
	[Address(RVA = "0xDF5CAC", Offset = "0xDF5CAC", VA = "0xDF5CAC", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001535")]
	[Address(RVA = "0xDF5CBC", Offset = "0xDF5CBC", VA = "0xDF5CBC", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001536")]
	[Address(RVA = "0xDF5CC0", Offset = "0xDF5CC0", VA = "0xDF5CC0", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x000095D0 File Offset: 0x000077D0
	[Token(Token = "0x6001537")]
	[Address(RVA = "0xDF5DB8", Offset = "0xDF5DB8", VA = "0xDF5DB8", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001538")]
	[Address(RVA = "0xDF2788", Offset = "0xDF2788", VA = "0xDF2788")]
	public TutorialStep_08_KillZombies()
	{
	}

	// Token: 0x040029BA RID: 10682
	[Token(Token = "0x40029BA")]
	[FieldOffset(Offset = "0x8")]
	private bool armourHead;

	// Token: 0x040029BB RID: 10683
	[Token(Token = "0x40029BB")]
	[FieldOffset(Offset = "0x9")]
	private bool armourBody;

	// Token: 0x040029BC RID: 10684
	[Token(Token = "0x40029BC")]
	[FieldOffset(Offset = "0xA")]
	private bool armourLegs;

	// Token: 0x040029BD RID: 10685
	[Token(Token = "0x40029BD")]
	[FieldOffset(Offset = "0xB")]
	private bool complete;

	// Token: 0x040029BE RID: 10686
	[Token(Token = "0x40029BE")]
	[FieldOffset(Offset = "0xC")]
	private bool killing;

	// Token: 0x040029BF RID: 10687
	[Token(Token = "0x40029BF")]
	[FieldOffset(Offset = "0x10")]
	private DateTime killStart;
}
