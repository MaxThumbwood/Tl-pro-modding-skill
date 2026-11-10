using System;
using Il2CppDummyDll;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
public class GUISaveVersionPopup
{
	// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001099")]
	[Address(RVA = "0xCF8814", Offset = "0xCF8814", VA = "0xCF8814")]
	public void CheckVersion(int fileVersion, Action continueAction)
	{
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109A")]
	[Address(RVA = "0xD012B8", Offset = "0xD012B8", VA = "0xD012B8")]
	public void CheckUpgradeOldSave(Action continueAction)
	{
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109B")]
	[Address(RVA = "0xD012A4", Offset = "0xD012A4", VA = "0xD012A4")]
	public void DisplayAppNeedsUpdate()
	{
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109C")]
	[Address(RVA = "0xD012C8", Offset = "0xD012C8", VA = "0xD012C8")]
	public void Draw()
	{
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109D")]
	[Address(RVA = "0xD01AF0", Offset = "0xD01AF0", VA = "0xD01AF0")]
	public GUISaveVersionPopup()
	{
	}

	// Token: 0x0400211C RID: 8476
	[Token(Token = "0x400211C")]
	[FieldOffset(Offset = "0x8")]
	public bool WarningDisplayed;

	// Token: 0x0400211D RID: 8477
	[Token(Token = "0x400211D")]
	[FieldOffset(Offset = "0xC")]
	private Action ContinueCallback;

	// Token: 0x0400211E RID: 8478
	[Token(Token = "0x400211E")]
	[FieldOffset(Offset = "0x10")]
	private GUIControllerGenericPopup _inputController;

	// Token: 0x0400211F RID: 8479
	[Token(Token = "0x400211F")]
	[FieldOffset(Offset = "0x14")]
	private float scale0;

	// Token: 0x04002120 RID: 8480
	[Token(Token = "0x4002120")]
	[FieldOffset(Offset = "0x18")]
	private float scale1;

	// Token: 0x04002121 RID: 8481
	[Token(Token = "0x4002121")]
	[FieldOffset(Offset = "0x1C")]
	private float scale2;
}
