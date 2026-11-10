using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.UI.Chat;

// Token: 0x0200013A RID: 314
[Token(Token = "0x200013A")]
public class GUIChat_Core
{
	// Token: 0x06000842 RID: 2114 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x1E4DC34", Offset = "0x1E4DC34", VA = "0x1E4DC34")]
	private Vector2 CalulateSnippetSize(TextSnippet[] parsedText, String_Layout itemText, float maxWidth)
	{
		return default(Vector2);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x1E4DDF0", Offset = "0x1E4DDF0", VA = "0x1E4DDF0")]
	public void FormatMessage(ChatLine line)
	{
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x1E4E0B4", Offset = "0x1E4E0B4", VA = "0x1E4E0B4")]
	public GUIChat_Core()
	{
	}

	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x8")]
	public GUIChat_Notification Notification;

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0xC")]
	public GUIChat_Overlay Overlay;

	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x10")]
	public GUIChat_Mini Mini;

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x14")]
	public float ScrollOffset;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x18")]
	private float ScrollMomentum;

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x1C")]
	private int ScrollDragging;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 DragOffset;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x28")]
	private float ToggleScale;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x2C")]
	private float BeginChatScale;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x30")]
	private float PrimaryChatScale;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x34")]
	private float EmotesScale;

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x38")]
	private float EmotesCloseScale;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 oneLineSize;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x44")]
	private int notificationCount;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x48")]
	private bool miniMapWasEnabled;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x49")]
	private bool beginChatClicked;

	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public enum ChatMode
	{
		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		Hidden,
		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		DisplayNotification,
		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		Shown
	}
}
