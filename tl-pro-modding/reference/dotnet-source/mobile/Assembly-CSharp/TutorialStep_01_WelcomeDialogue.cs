using System;
using Il2CppDummyDll;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class TutorialStep_01_WelcomeDialogue : TutorialStep
{
	// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001505")]
	[Address(RVA = "0xDF2D40", Offset = "0xDF2D40", VA = "0xDF2D40", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001506")]
	[Address(RVA = "0xDF2D4C", Offset = "0xDF2D4C", VA = "0xDF2D4C", Slot = "5")]
	public override void Begin()
	{
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00009480 File Offset: 0x00007680
	[Token(Token = "0x6001507")]
	[Address(RVA = "0xDF2DC4", Offset = "0xDF2DC4", VA = "0xDF2DC4", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001508")]
	[Address(RVA = "0xDF2750", Offset = "0xDF2750", VA = "0xDF2750")]
	public TutorialStep_01_WelcomeDialogue()
	{
	}

	// Token: 0x040029A2 RID: 10658
	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x8")]
	private bool displayed;
}
