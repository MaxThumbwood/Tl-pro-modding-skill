using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class iOS_Mouse
{
	// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x4A3304", Offset = "0x4A3304", VA = "0x4A3304")]
	public void Setup()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x4A331C", Offset = "0x4A331C", VA = "0x4A331C")]
	public void Update()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x4A32F4", Offset = "0x4A32F4", VA = "0x4A32F4")]
	public iOS_Mouse()
	{
	}

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x8")]
	private bool wasMouseConnected;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 lastUnityMousePosition;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 MousePosition;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x24")]
	public bool MouseLeft;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x25")]
	public bool MouseRight;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x26")]
	public bool MouseMiddle;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x27")]
	public bool MouseLeftPrev;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x28")]
	public bool MouseRightPrev;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x29")]
	public bool MouseMiddlePrev;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x2C")]
	public float MouseScroll;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x30")]
	public bool UseSWCursor;
}
