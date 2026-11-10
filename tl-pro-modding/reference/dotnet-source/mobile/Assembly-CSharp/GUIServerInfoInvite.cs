using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class GUIServerInfoInvite
{
	// Token: 0x06000B4D RID: 2893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0xBFA8F8", Offset = "0xBFA8F8", VA = "0xBFA8F8")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00006960 File Offset: 0x00004B60
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0xBFAA90", Offset = "0xBFAA90", VA = "0xBFAA90")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00006978 File Offset: 0x00004B78
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0xBFADD0", Offset = "0xBFADD0", VA = "0xBFADD0")]
	private Vector2 MeasureStringCharByChar(String_Layout messageLayout, string text)
	{
		return default(Vector2);
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00006990 File Offset: 0x00004B90
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0xBFAF30", Offset = "0xBFAF30", VA = "0xBFAF30")]
	private Vector2 CalculateTextSize(string textValue)
	{
		return default(Vector2);
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0xBFB7F8", Offset = "0xBFB7F8", VA = "0xBFB7F8")]
	public void RefreshServerText()
	{
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0xBFC9E4", Offset = "0xBFC9E4", VA = "0xBFC9E4")]
	public string GetServerAddress()
	{
		return null;
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x000069A8 File Offset: 0x00004BA8
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0xBFCB38", Offset = "0xBFCB38", VA = "0xBFCB38")]
	public int GetServerPort()
	{
		return 0;
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0xBFCE9C", Offset = "0xBFCE9C", VA = "0xBFCE9C")]
	public static bool IsLocalIp(string serverAddress)
	{
		return default(bool);
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x000069D8 File Offset: 0x00004BD8
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0xBFC89C", Offset = "0xBFC89C", VA = "0xBFC89C")]
	public bool NetClient_DisplayPortMapping()
	{
		return default(bool);
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0xBFCC70", Offset = "0xBFCC70", VA = "0xBFCC70")]
	private void GetButtonAvailability(out bool showHideButton, out bool inviteButton)
	{
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0xBFD124", Offset = "0xBFD124", VA = "0xBFD124")]
	public void Draw()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0xBFDA48", Offset = "0xBFDA48", VA = "0xBFDA48")]
	private void WorldDraw()
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0xBFE63C", Offset = "0xBFE63C", VA = "0xBFE63C")]
	private void DrawWorld()
	{
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0xBFE848", Offset = "0xBFE848", VA = "0xBFE848")]
	private Texture2D GetIcon()
	{
		return null;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0xBFE938", Offset = "0xBFE938", VA = "0xBFE938")]
	public GUIServerInfoInvite()
	{
	}

	// Token: 0x04000D75 RID: 3445
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x8")]
	public bool Display;

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0xC")]
	private float InviteScale;

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x10")]
	private float CloseScale;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x14")]
	public GUIContollerTransactionButtonList _controllerHideShowInvite;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x18")]
	public GUIContollerTransactionButtonList _controllerInvite;

	// Token: 0x04000D7A RID: 3450
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x1C")]
	public GUIContollerTransactionButtonList _controllerHideShow;

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x20")]
	public GUIContollerTransactionButtonList _controllerEmpty;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x24")]
	public GUIContollerTransactionButtonList _controller;

	// Token: 0x04000D7D RID: 3453
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x28")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000D7E RID: 3454
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x2C")]
	private string CachedServerInfo;

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x30")]
	private string CachedString;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 CachedTextSize;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x3C")]
	public bool ShowIPs;

	// Token: 0x04000D82 RID: 3458
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x3D")]
	public bool DisplayInvite;

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x3E")]
	public bool DisplayHideShow;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x0")]
	private static string lastRequest;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x4")]
	private static bool lastRequestResult;
}
