using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
public class AlertDelayer : MonoBehaviour
{
	// Token: 0x060000E2 RID: 226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x49ED74", Offset = "0x49ED74", VA = "0x49ED74")]
	private void Update()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x49EE78", Offset = "0x49EE78", VA = "0x49EE78")]
	public AlertDelayer()
	{
	}

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0xC")]
	public string title;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x10")]
	public string message;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x14")]
	public string button1;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x18")]
	public string button2;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x1C")]
	public string buttonDefault;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x20")]
	public float delayTime;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x24")]
	public Alert.AlertShownReason reason;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x28")]
	public string hapticId;
}
