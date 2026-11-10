using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public abstract class DrKeyboard_Base
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x49D1CC", Offset = "0x49D1CC", VA = "0x49D1CC")]
	public static DrKeyboard_Base Create(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false, bool filterText = true)
	{
		return null;
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x17000035")]
	public static bool isSupported
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x49D8E4", Offset = "0x49D8E4", VA = "0x49D8E4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000B8 RID: 184
	// (set) Token: 0x060000B9 RID: 185
	[Token(Token = "0x17000036")]
	public abstract bool active
	{
		[Token(Token = "0x60000B8")]
		get;
		[Token(Token = "0x60000B9")]
		set;
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000BA RID: 186
	[Token(Token = "0x17000037")]
	public abstract bool wasCanceled
	{
		[Token(Token = "0x60000BA")]
		get;
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000BB RID: 187
	[Token(Token = "0x17000038")]
	public abstract bool done
	{
		[Token(Token = "0x60000BB")]
		get;
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000BC RID: 188
	// (set) Token: 0x060000BD RID: 189
	[Token(Token = "0x17000039")]
	public abstract string text
	{
		[Token(Token = "0x60000BC")]
		get;
		[Token(Token = "0x60000BD")]
		set;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x49D908", Offset = "0x49D908", VA = "0x49D908", Slot = "10")]
	public virtual void Update()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x49D90C", Offset = "0x49D90C", VA = "0x49D90C")]
	protected DrKeyboard_Base()
	{
	}
}
