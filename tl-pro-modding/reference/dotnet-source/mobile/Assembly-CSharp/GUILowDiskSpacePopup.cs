using System;
using Il2CppDummyDll;

// Token: 0x02000295 RID: 661
[Token(Token = "0x2000295")]
public class GUILowDiskSpacePopup
{
	// Token: 0x06000F81 RID: 3969 RVA: 0x00007D28 File Offset: 0x00005F28
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0xCC1064", Offset = "0xCC1064", VA = "0xCC1064")]
	private long DiskSpace()
	{
		return 0L;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0xCC1430", Offset = "0xCC1430", VA = "0xCC1430")]
	public void CheckDiskSpace(Action continueAction)
	{
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0xCC1484", Offset = "0xCC1484", VA = "0xCC1484")]
	public void Draw()
	{
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0xCC1B8C", Offset = "0xCC1B8C", VA = "0xCC1B8C")]
	public GUILowDiskSpacePopup()
	{
	}

	// Token: 0x04001FB4 RID: 8116
	[Token(Token = "0x4001FB4")]
	[FieldOffset(Offset = "0x8")]
	public bool DisableWarnings;

	// Token: 0x04001FB5 RID: 8117
	[Token(Token = "0x4001FB5")]
	[FieldOffset(Offset = "0x9")]
	public bool WarningDisplayed;

	// Token: 0x04001FB6 RID: 8118
	[Token(Token = "0x4001FB6")]
	[FieldOffset(Offset = "0xC")]
	private Action ContinueCallback;

	// Token: 0x04001FB7 RID: 8119
	[Token(Token = "0x4001FB7")]
	[FieldOffset(Offset = "0x10")]
	private GUIControllerGenericPopup _inputController;

	// Token: 0x04001FB8 RID: 8120
	[Token(Token = "0x4001FB8")]
	[FieldOffset(Offset = "0x14")]
	private float scale0;

	// Token: 0x04001FB9 RID: 8121
	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x18")]
	private float scale1;

	// Token: 0x04001FBA RID: 8122
	[Token(Token = "0x4001FBA")]
	[FieldOffset(Offset = "0x1C")]
	private float scale2;
}
