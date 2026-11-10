using System;
using Il2CppDummyDll;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
public class GUIPS4MultiplayerChecks
{
	// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001086")]
	[Address(RVA = "0xCFD628", Offset = "0xCFD628", VA = "0xCFD628")]
	public void DisplayGenericError(string error)
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0xCFD638", Offset = "0xCFD638", VA = "0xCFD638")]
	private void EditorCheckPermissions()
	{
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001088")]
	[Address(RVA = "0xCFD6B8", Offset = "0xCFD6B8", VA = "0xCFD6B8")]
	private void EditorCheckPermissionsUpdate()
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001089")]
	[Address(RVA = "0xCFDB0C", Offset = "0xCFDB0C", VA = "0xCFDB0C")]
	public void Begin()
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108A")]
	[Address(RVA = "0xCFDA6C", Offset = "0xCFDA6C", VA = "0xCFDA6C")]
	public void Complete(bool passed)
	{
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108B")]
	[Address(RVA = "0xCFDCC8", Offset = "0xCFDCC8", VA = "0xCFDCC8")]
	public void Draw()
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108C")]
	[Address(RVA = "0xCFE524", Offset = "0xCFE524", VA = "0xCFE524")]
	public GUIPS4MultiplayerChecks()
	{
	}

	// Token: 0x040020F0 RID: 8432
	[Token(Token = "0x40020F0")]
	[FieldOffset(Offset = "0x8")]
	public bool CheckingPS4Permisions;

	// Token: 0x040020F1 RID: 8433
	[Token(Token = "0x40020F1")]
	[FieldOffset(Offset = "0x9")]
	public bool parentalFailed;

	// Token: 0x040020F2 RID: 8434
	[Token(Token = "0x40020F2")]
	[FieldOffset(Offset = "0xC")]
	private int userId;

	// Token: 0x040020F3 RID: 8435
	[Token(Token = "0x40020F3")]
	[FieldOffset(Offset = "0x10")]
	private GUIPS4MultiplayerChecks.StateCheck state;

	// Token: 0x040020F4 RID: 8436
	[Token(Token = "0x40020F4")]
	[FieldOffset(Offset = "0x14")]
	private bool stepPassed;

	// Token: 0x040020F5 RID: 8437
	[Token(Token = "0x40020F5")]
	[FieldOffset(Offset = "0x15")]
	private bool displayingPS4Error;

	// Token: 0x040020F6 RID: 8438
	[Token(Token = "0x40020F6")]
	[FieldOffset(Offset = "0x16")]
	private bool displayingGenericError;

	// Token: 0x040020F7 RID: 8439
	[Token(Token = "0x40020F7")]
	[FieldOffset(Offset = "0x17")]
	private bool displayedPlusSignup;

	// Token: 0x040020F8 RID: 8440
	[Token(Token = "0x40020F8")]
	[FieldOffset(Offset = "0x18")]
	private string genericError;

	// Token: 0x040020F9 RID: 8441
	[Token(Token = "0x40020F9")]
	[FieldOffset(Offset = "0x1C")]
	private bool XBOError;

	// Token: 0x040020FA RID: 8442
	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x1D")]
	private bool stepFailed;

	// Token: 0x040020FB RID: 8443
	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x20")]
	private uint stepErrorCode;

	// Token: 0x040020FC RID: 8444
	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x24")]
	private bool EditorCheckingPermissions;

	// Token: 0x040020FD RID: 8445
	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x28")]
	private DateTime EditorCheckStart;

	// Token: 0x040020FE RID: 8446
	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0x30")]
	private GUIControllerGenericPopup _controller;

	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	public enum StateCheck
	{
		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		Availability,
		// Token: 0x04002101 RID: 8449
		[Token(Token = "0x4002101")]
		ParentalCheck,
		// Token: 0x04002102 RID: 8450
		[Token(Token = "0x4002102")]
		CheckPlus
	}
}
