using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public class MainThreadExecution
{
	// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x4AC65C", Offset = "0x4AC65C", VA = "0x4AC65C")]
	public static void ExcludeThread(ManagedThread thread)
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x4A3D98", Offset = "0x4A3D98", VA = "0x4A3D98")]
	public static void ExecuteOnMainThread(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x4AC8C8", Offset = "0x4AC8C8", VA = "0x4AC8C8")]
	public static void ExecuteSnippetsOnly()
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x4A1304", Offset = "0x4A1304", VA = "0x4A1304")]
	public static void ExecuteSnippets()
	{
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x4AC74C", Offset = "0x4AC74C", VA = "0x4AC74C")]
	public MainThreadExecution(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x4ACAA0", Offset = "0x4ACAA0", VA = "0x4ACAA0")]
	public void Execute()
	{
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x4AC7D8", Offset = "0x4AC7D8", VA = "0x4AC7D8")]
	public void WaitOnMainThreadComplete()
	{
	}

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x0")]
	private static List<ManagedThread> ExcludedThreads;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x4")]
	private static ConcurrentQueue<MainThreadExecution> _pendingRequests;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x8")]
	private object _lockObject;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0xC")]
	private MainThreadExecution.ExecutionSnippet _snippet;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x10")]
	private object _data;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x14")]
	private bool _completed;

	// Token: 0x0200005E RID: 94
	// (Invoke) Token: 0x060001F0 RID: 496
	[Token(Token = "0x200005E")]
	public delegate void ExecutionSnippet(object data);
}
