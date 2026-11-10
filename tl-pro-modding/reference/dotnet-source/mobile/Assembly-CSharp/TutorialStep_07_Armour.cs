using System;
using Il2CppDummyDll;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000359")]
public class TutorialStep_07_Armour : TutorialStep
{
	// Token: 0x0600152B RID: 5419 RVA: 0x00009588 File Offset: 0x00007788
	[Token(Token = "0x600152B")]
	[Address(RVA = "0xDF4FBC", Offset = "0xDF4FBC", VA = "0xDF4FBC", Slot = "7")]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.None;
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600152C")]
	[Address(RVA = "0xDF4FC4", Offset = "0xDF4FC4", VA = "0xDF4FC4", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152D")]
	[Address(RVA = "0xDF5500", Offset = "0xDF5500", VA = "0xDF5500", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152E")]
	[Address(RVA = "0xDF5510", Offset = "0xDF5510", VA = "0xDF5510", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152F")]
	[Address(RVA = "0xDF5538", Offset = "0xDF5538", VA = "0xDF5538", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000095A0 File Offset: 0x000077A0
	[Token(Token = "0x6001530")]
	[Address(RVA = "0xDF55C8", Offset = "0xDF55C8", VA = "0xDF55C8", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001531")]
	[Address(RVA = "0xDF2780", Offset = "0xDF2780", VA = "0xDF2780")]
	public TutorialStep_07_Armour()
	{
	}

	// Token: 0x040029B2 RID: 10674
	[Token(Token = "0x40029B2")]
	[FieldOffset(Offset = "0x8")]
	private bool furnacePlaced;

	// Token: 0x040029B3 RID: 10675
	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x9")]
	private bool collectedBars;

	// Token: 0x040029B4 RID: 10676
	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0xA")]
	private bool anvilPlaced;

	// Token: 0x040029B5 RID: 10677
	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0xB")]
	private bool copperGiven;

	// Token: 0x040029B6 RID: 10678
	[Token(Token = "0x40029B6")]
	[FieldOffset(Offset = "0xC")]
	private bool armourHead;

	// Token: 0x040029B7 RID: 10679
	[Token(Token = "0x40029B7")]
	[FieldOffset(Offset = "0xD")]
	private bool armourBody;

	// Token: 0x040029B8 RID: 10680
	[Token(Token = "0x40029B8")]
	[FieldOffset(Offset = "0xE")]
	private bool armourLegs;

	// Token: 0x040029B9 RID: 10681
	[Token(Token = "0x40029B9")]
	[FieldOffset(Offset = "0xF")]
	private bool complete;
}
