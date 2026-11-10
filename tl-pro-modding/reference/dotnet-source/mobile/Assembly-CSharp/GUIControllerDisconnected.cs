using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public class GUIControllerDisconnected
{
	// Token: 0x06000898 RID: 2200 RVA: 0x00005880 File Offset: 0x00003A80
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x4DF714", Offset = "0x4DF714", VA = "0x4DF714")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x4DF71C", Offset = "0x4DF71C", VA = "0x4DF71C")]
	public void Draw()
	{
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x4E0B10", Offset = "0x4E0B10", VA = "0x4E0B10")]
	private void DisplayNpadConnectionPromptAndReassignNpads()
	{
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x4E0B90", Offset = "0x4E0B90", VA = "0x4E0B90")]
	public GUIControllerDisconnected()
	{
	}

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x8")]
	private float statusScale;

	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0xC")]
	private float loadScale;

	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x10")]
	private float backScale;

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x14")]
	private float titleScale;

	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x18")]
	private float buttonScale;

	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x1C")]
	private bool wasDown;

	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x1D")]
	private bool nonRequiredControllerWasConnected;

	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x20")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x0")]
	private static bool showingReassign;
}
