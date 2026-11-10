using System;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class ManagedThread
{
	// Token: 0x06000223 RID: 547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x4AFD24", Offset = "0x4AFD24", VA = "0x4AFD24")]
	public ManagedThread(ParameterizedThreadStart callBack, object state, string threadId)
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x4AFE20", Offset = "0x4AFE20", VA = "0x4AFE20")]
	public ManagedThread(ThreadStart callBack, string threadId)
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x4AFF14", Offset = "0x4AFF14", VA = "0x4AFF14")]
	public void Run()
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x4AFF68", Offset = "0x4AFF68", VA = "0x4AFF68")]
	public void RunCritical()
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x4AFFBC", Offset = "0x4AFFBC", VA = "0x4AFFBC")]
	private void ThreadExecute()
	{
	}

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x8")]
	private ParameterizedThreadStart ParameterizedThreadStartCallBack;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0xC")]
	private object ParameterizedThreadStartCallbackState;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x10")]
	private ThreadStart ThreadStartCallBack;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x14")]
	public readonly string Id;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x18")]
	public LocalUser User;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x1C")]
	public Thread ActiveThread;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x20")]
	public bool IsAlive;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x21")]
	public bool KillThread;
}
