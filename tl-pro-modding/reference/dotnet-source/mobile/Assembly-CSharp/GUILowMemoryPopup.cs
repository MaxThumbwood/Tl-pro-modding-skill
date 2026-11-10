using System;
using Il2CppDummyDll;

// Token: 0x02000296 RID: 662
[Token(Token = "0x2000296")]
public class GUILowMemoryPopup
{
	// Token: 0x06000F85 RID: 3973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0xCC1C08", Offset = "0xCC1C08", VA = "0xCC1C08")]
	public void CheckMemoryAction(GUILowMemoryPopup.MemoryAction action, Action continueAction)
	{
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00007D40 File Offset: 0x00005F40
	[Token(Token = "0x1700018F")]
	public static long DeviceMemory
	{
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0xCC1C5C", Offset = "0xCC1C5C", VA = "0xCC1C5C")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0xCC1C70", Offset = "0xCC1C70", VA = "0xCC1C70")]
	public void Draw()
	{
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0xCC251C", Offset = "0xCC251C", VA = "0xCC251C")]
	public GUILowMemoryPopup()
	{
	}

	// Token: 0x04001FBB RID: 8123
	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x8")]
	public bool WarningDisplayed;

	// Token: 0x04001FBC RID: 8124
	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x9")]
	public bool DisableWarnings;

	// Token: 0x04001FBD RID: 8125
	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0xC")]
	private GUILowMemoryPopup.MemoryAction CurrentWarning;

	// Token: 0x04001FBE RID: 8126
	[Token(Token = "0x4001FBE")]
	[FieldOffset(Offset = "0x10")]
	private Action ContinueCallback;

	// Token: 0x04001FBF RID: 8127
	[Token(Token = "0x4001FBF")]
	[FieldOffset(Offset = "0x14")]
	private GUIControllerGenericPopup _inputController;

	// Token: 0x04001FC0 RID: 8128
	[Token(Token = "0x4001FC0")]
	[FieldOffset(Offset = "0x18")]
	private float scale0;

	// Token: 0x04001FC1 RID: 8129
	[Token(Token = "0x4001FC1")]
	[FieldOffset(Offset = "0x1C")]
	private float scale1;

	// Token: 0x04001FC2 RID: 8130
	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x20")]
	private float scale2;

	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	public enum MemoryAction
	{
		// Token: 0x04001FC4 RID: 8132
		[Token(Token = "0x4001FC4")]
		Host,
		// Token: 0x04001FC5 RID: 8133
		[Token(Token = "0x4001FC5")]
		PlayLarge,
		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		GenerateLarge
	}
}
