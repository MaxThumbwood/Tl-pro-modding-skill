using System;
using Il2CppDummyDll;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class DrKeyboard_IME : DrKeyboard_Base
{
	// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x49D49C", Offset = "0x49D49C", VA = "0x49D49C")]
	public DrKeyboard_IME(string initialText, int maxChars, string title, string prompt)
	{
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x000026A0 File Offset: 0x000008A0
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003A")]
	public override bool active
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x49D914", Offset = "0x49D914", VA = "0x49D914", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x49D930", Offset = "0x49D930", VA = "0x49D930", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x1700003B")]
	public override bool done
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x49D944", Offset = "0x49D944", VA = "0x49D944", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003C")]
	public override string text
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x49D94C", Offset = "0x49D94C", VA = "0x49D94C", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x49D954", Offset = "0x49D954", VA = "0x49D954", Slot = "9")]
		set
		{
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x1700003D")]
	public override bool wasCanceled
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x49D95C", Offset = "0x49D95C", VA = "0x49D95C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x49D964", Offset = "0x49D964", VA = "0x49D964", Slot = "10")]
	public override void Update()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x49DF04", Offset = "0x49DF04", VA = "0x49DF04")]
	private void Append(string input)
	{
	}

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x8")]
	private int _lastFrame;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0xC")]
	private string _lastIME;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x10")]
	private string _text;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x14")]
	private bool _wasCanceled;
}
