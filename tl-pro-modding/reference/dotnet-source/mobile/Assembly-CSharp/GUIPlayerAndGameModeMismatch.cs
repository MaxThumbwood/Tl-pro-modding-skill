using System;
using Il2CppDummyDll;

// Token: 0x020002AB RID: 683
[Token(Token = "0x20002AB")]
public class GUIPlayerAndGameModeMismatch
{
	// Token: 0x06001032 RID: 4146 RVA: 0x00007EC0 File Offset: 0x000060C0
	[Token(Token = "0x6001032")]
	[Address(RVA = "0xCE50EC", Offset = "0xCE50EC", VA = "0xCE50EC")]
	public bool CheckMismatch(int playerGameMode, int worldGameMode)
	{
		return default(bool);
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001033")]
	[Address(RVA = "0xCE5214", Offset = "0xCE5214", VA = "0xCE5214")]
	public void Draw()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001034")]
	[Address(RVA = "0xCE56A4", Offset = "0xCE56A4", VA = "0xCE56A4")]
	private void Back()
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001035")]
	[Address(RVA = "0xCE584C", Offset = "0xCE584C", VA = "0xCE584C")]
	public GUIPlayerAndGameModeMismatch()
	{
	}

	// Token: 0x0400206D RID: 8301
	[Token(Token = "0x400206D")]
	[FieldOffset(Offset = "0x8")]
	public bool WarningDisplayed;

	// Token: 0x0400206E RID: 8302
	[Token(Token = "0x400206E")]
	[FieldOffset(Offset = "0xC")]
	private float statusScale;

	// Token: 0x0400206F RID: 8303
	[Token(Token = "0x400206F")]
	[FieldOffset(Offset = "0x10")]
	private float backScale;

	// Token: 0x04002070 RID: 8304
	[Token(Token = "0x4002070")]
	[FieldOffset(Offset = "0x14")]
	private string messageText;

	// Token: 0x04002071 RID: 8305
	[Token(Token = "0x4002071")]
	[FieldOffset(Offset = "0x18")]
	private GUIControllerGenericPopup _inputController;
}
