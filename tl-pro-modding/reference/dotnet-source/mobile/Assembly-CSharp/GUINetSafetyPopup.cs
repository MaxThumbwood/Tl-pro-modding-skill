using System;
using Il2CppDummyDll;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class GUINetSafetyPopup
{
	// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101C")]
	[Address(RVA = "0xCE0794", Offset = "0xCE0794", VA = "0xCE0794")]
	public void CheckSafety(Action continueAction)
	{
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101D")]
	[Address(RVA = "0xCE07D8", Offset = "0xCE07D8", VA = "0xCE07D8")]
	public void CheckInformationSharing(Action continueAction)
	{
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019D")]
	private TransactionButton_Layout CancelLayout
	{
		[Token(Token = "0x600101E")]
		[Address(RVA = "0xCE081C", Offset = "0xCE081C", VA = "0xCE081C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019E")]
	private TransactionButton_Layout AlwaysLayout
	{
		[Token(Token = "0x600101F")]
		[Address(RVA = "0xCE0884", Offset = "0xCE0884", VA = "0xCE0884")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019F")]
	private TransactionButton_Layout ContinueLayout
	{
		[Token(Token = "0x6001020")]
		[Address(RVA = "0xCE08EC", Offset = "0xCE08EC", VA = "0xCE08EC")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A0")]
	private Panel_Layout BackingLayout
	{
		[Token(Token = "0x6001021")]
		[Address(RVA = "0xCE0954", Offset = "0xCE0954", VA = "0xCE0954")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A1")]
	private Panel_Layout MenuDividerLayout
	{
		[Token(Token = "0x6001022")]
		[Address(RVA = "0xCE09BC", Offset = "0xCE09BC", VA = "0xCE09BC")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A2")]
	private StringButton_Layout StatusLayout
	{
		[Token(Token = "0x6001023")]
		[Address(RVA = "0xCE0A24", Offset = "0xCE0A24", VA = "0xCE0A24")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001024")]
	[Address(RVA = "0xCE0A8C", Offset = "0xCE0A8C", VA = "0xCE0A8C")]
	public void Draw()
	{
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001025")]
	[Address(RVA = "0xCE1BDC", Offset = "0xCE1BDC", VA = "0xCE1BDC")]
	public GUINetSafetyPopup()
	{
	}

	// Token: 0x0400205A RID: 8282
	[Token(Token = "0x400205A")]
	[FieldOffset(Offset = "0x8")]
	public bool DisableWarnings;

	// Token: 0x0400205B RID: 8283
	[Token(Token = "0x400205B")]
	[FieldOffset(Offset = "0x9")]
	public bool DisableSharingWarnings;

	// Token: 0x0400205C RID: 8284
	[Token(Token = "0x400205C")]
	[FieldOffset(Offset = "0xA")]
	public bool WarningDisplayed;

	// Token: 0x0400205D RID: 8285
	[Token(Token = "0x400205D")]
	[FieldOffset(Offset = "0xB")]
	public bool ShareWarningDisplayed;

	// Token: 0x0400205E RID: 8286
	[Token(Token = "0x400205E")]
	[FieldOffset(Offset = "0xC")]
	public bool AgeWarningDisplayed;

	// Token: 0x0400205F RID: 8287
	[Token(Token = "0x400205F")]
	[FieldOffset(Offset = "0x10")]
	private Action ContinueCallback;

	// Token: 0x04002060 RID: 8288
	[Token(Token = "0x4002060")]
	[FieldOffset(Offset = "0x14")]
	private GUIContollerTransactionButtonList _controllerList;

	// Token: 0x04002061 RID: 8289
	[Token(Token = "0x4002061")]
	[FieldOffset(Offset = "0x18")]
	private float scale0;

	// Token: 0x04002062 RID: 8290
	[Token(Token = "0x4002062")]
	[FieldOffset(Offset = "0x1C")]
	private float scale1;

	// Token: 0x04002063 RID: 8291
	[Token(Token = "0x4002063")]
	[FieldOffset(Offset = "0x20")]
	private float scale2;
}
