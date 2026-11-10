using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class DrKeyboard_Touch : DrKeyboard_Base
{
	// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x49E044", Offset = "0x49E044", VA = "0x49E044")]
	public static void AppFocusGained()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x49D810", Offset = "0x49D810", VA = "0x49D810")]
	public DrKeyboard_Touch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false)
	{
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000CE RID: 206 RVA: 0x000026E8 File Offset: 0x000008E8
	// (set) Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003E")]
	public override bool active
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x49E098", Offset = "0x49E098", VA = "0x49E098", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x49E128", Offset = "0x49E128", VA = "0x49E128", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x1700003F")]
	public override bool done
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x49E150", Offset = "0x49E150", VA = "0x49E150", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000040")]
	public override string text
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x49E180", Offset = "0x49E180", VA = "0x49E180", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x49E1A4", Offset = "0x49E1A4", VA = "0x49E1A4", Slot = "9")]
		set
		{
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x17000041")]
	public override bool wasCanceled
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x49E1D0", Offset = "0x49E1D0", VA = "0x49E1D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x0")]
	private static bool appGainedFocus;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x8")]
	private TouchScreenKeyboard _keyboard;
}
