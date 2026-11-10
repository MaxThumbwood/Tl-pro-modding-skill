using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200028D RID: 653
[Token(Token = "0x200028D")]
public class GUIGenericPopup
{
	// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0xCA591C", Offset = "0xCA591C", VA = "0xCA591C")]
	public void PrepareLayout(string title, string message, int defaultButton, int escapeButton, GUIGenericPopup.IconType?[] buttonIcons, bool searchingIconActive = false, float ySizeIncTop = 0f, [Optional] float? minHeightOverride)
	{
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00007B78 File Offset: 0x00005D78
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0xCB13AC", Offset = "0xCB13AC", VA = "0xCB13AC")]
	public Guid Open(string title, string message, int defaultButton, int escapeButton, [Optional] string buttonLeftText, GUIGenericPopup.IconType buttonLeftIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonLeftAction, [Optional] string buttonMiddleText, GUIGenericPopup.IconType buttonMiddleIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonMiddleAction, [Optional] string buttonRightText, GUIGenericPopup.IconType buttonRightIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonRightAction, bool searchingIconActive = false, float ySizeIncTop = 0f, [Optional] float? minHeightOverride)
	{
		return default(Guid);
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0xCB147C", Offset = "0xCB147C", VA = "0xCB147C")]
	private string GetIconTexture(GUIGenericPopup.IconType type)
	{
		return null;
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0xCB0714", Offset = "0xCB0714", VA = "0xCB0714")]
	private void Setup(string title, string message, int defaultButton, int escapeButton, [Optional] string buttonLeftText, GUIGenericPopup.IconType buttonLeftIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonLeftAction, [Optional] string buttonMiddleText, GUIGenericPopup.IconType buttonMiddleIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonMiddleAction, [Optional] string buttonRightText, GUIGenericPopup.IconType buttonRightIcon = GUIGenericPopup.IconType.None, [Optional] Action buttonRightAction, bool searchingIconActive = false, float ySizeIncTop = 0f, [Optional] float? minHeightOverride)
	{
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0xCB15C4", Offset = "0xCB15C4", VA = "0xCB15C4")]
	public void Close()
	{
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00007B90 File Offset: 0x00005D90
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0xCB1584", Offset = "0xCB1584", VA = "0xCB1584")]
	public bool ButtonActive(int buttonIndex)
	{
		return default(bool);
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00007BA8 File Offset: 0x00005DA8
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0xCB1604", Offset = "0xCB1604", VA = "0xCB1604")]
	public bool AnyButtonActive()
	{
		return default(bool);
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00007BC0 File Offset: 0x00005DC0
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0xCB1674", Offset = "0xCB1674", VA = "0xCB1674")]
	public int GetDefaultButtonIndex()
	{
		return 0;
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0xCB167C", Offset = "0xCB167C", VA = "0xCB167C")]
	public TransactionButton_Layout GetButtonLayout(int buttonIndex)
	{
		return null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0xCB0CD8", Offset = "0xCB0CD8", VA = "0xCB0CD8")]
	private void ResizeBackingToText()
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0xCB16B4", Offset = "0xCB16B4", VA = "0xCB16B4")]
	public void Draw()
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0xCB1D40", Offset = "0xCB1D40", VA = "0xCB1D40")]
	public GUIGenericPopup()
	{
	}

	// Token: 0x04001F30 RID: 7984
	[Token(Token = "0x4001F30")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool IsOpen;

	// Token: 0x04001F31 RID: 7985
	[Token(Token = "0x4001F31")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Guid GUID;

	// Token: 0x04001F32 RID: 7986
	[Token(Token = "0x4001F32")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private string Title;

	// Token: 0x04001F33 RID: 7987
	[Token(Token = "0x4001F33")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string Message;

	// Token: 0x04001F34 RID: 7988
	[Token(Token = "0x4001F34")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private GUIGenericPopup.ButtonData[] Buttons;

	// Token: 0x04001F35 RID: 7989
	[Token(Token = "0x4001F35")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool StorePads;

	// Token: 0x04001F36 RID: 7990
	[Token(Token = "0x4001F36")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int DefaultButton;

	// Token: 0x04001F37 RID: 7991
	[Token(Token = "0x4001F37")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int EscapeButton;

	// Token: 0x04001F38 RID: 7992
	[Token(Token = "0x4001F38")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool SearchingIconActive;

	// Token: 0x04001F39 RID: 7993
	[Token(Token = "0x4001F39")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float YSizeIncTop;

	// Token: 0x04001F3A RID: 7994
	[Token(Token = "0x4001F3A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float MinTitleWidth;

	// Token: 0x04001F3B RID: 7995
	[Token(Token = "0x4001F3B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float MinHeight;

	// Token: 0x04001F3C RID: 7996
	[Token(Token = "0x4001F3C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float? MinHeightOverride;

	// Token: 0x04001F3D RID: 7997
	[Token(Token = "0x4001F3D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float scale;

	// Token: 0x04001F3E RID: 7998
	[Token(Token = "0x4001F3E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GUIControllerGenericPopup _controller;

	// Token: 0x04001F3F RID: 7999
	[Token(Token = "0x4001F3F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private string CachedTitleValue;

	// Token: 0x04001F40 RID: 8000
	[Token(Token = "0x4001F40")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float CachedTitleScale;

	// Token: 0x04001F41 RID: 8001
	[Token(Token = "0x4001F41")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private string CachedTextValue;

	// Token: 0x04001F42 RID: 8002
	[Token(Token = "0x4001F42")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float CachedTextScale;

	// Token: 0x04001F43 RID: 8003
	[Token(Token = "0x4001F43")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool CachedButtonsActive;

	// Token: 0x04001F44 RID: 8004
	[Token(Token = "0x4001F44")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool CachedSearchingIconActive;

	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public enum IconType
	{
		// Token: 0x04001F46 RID: 8006
		[Token(Token = "0x4001F46")]
		None,
		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		Tick,
		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		Cross,
		// Token: 0x04001F49 RID: 8009
		[Token(Token = "0x4001F49")]
		Trash,
		// Token: 0x04001F4A RID: 8010
		[Token(Token = "0x4001F4A")]
		Back,
		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		Play,
		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		New,
		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		Reset,
		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		Settings,
		// Token: 0x04001F4F RID: 8015
		[Token(Token = "0x4001F4F")]
		Touch
	}

	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	private struct ButtonData
	{
		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public GUIGenericPopup.IconType Icon;

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action Action;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public TransactionButton_Layout Layout;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float OrigLeftPad;
	}
}
