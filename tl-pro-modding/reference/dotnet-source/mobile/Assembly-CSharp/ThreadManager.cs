using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
public static class ThreadManager
{
	// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x4B016C", Offset = "0x4B016C", VA = "0x4B016C")]
	public static ManagedThread Run(ParameterizedThreadStart callBack, object state, string threadId)
	{
		return null;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x4A298C", Offset = "0x4A298C", VA = "0x4A298C")]
	public static ManagedThread Run(ThreadStart callBack, string threadId)
	{
		return null;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x4B0314", Offset = "0x4B0314", VA = "0x4B0314")]
	public static ManagedThread RunForUser(ParameterizedThreadStart callBack, object state, LocalUser user, string threadId)
	{
		return null;
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x4B0514", Offset = "0x4B0514", VA = "0x4B0514")]
	public static ManagedThread RunForUser(ThreadStart callBack, LocalUser user, string threadId)
	{
		return null;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x4B0700", Offset = "0x4B0700", VA = "0x4B0700")]
	public static ManagedThread RunForUserCritical(ParameterizedThreadStart callBack, object state, LocalUser user, string threadId)
	{
		return null;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x4B0900", Offset = "0x4B0900", VA = "0x4B0900")]
	public static ManagedThread RunCritical(ThreadStart callBack, string threadId)
	{
		return null;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x4B0A98", Offset = "0x4B0A98", VA = "0x4B0A98")]
	public static void Update()
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x4B0DEC", Offset = "0x4B0DEC", VA = "0x4B0DEC")]
	public static void TerminateUserThreads(LocalUser user)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x4B1258", Offset = "0x4B1258", VA = "0x4B1258")]
	public static void TerminateThread(ManagedThread thread)
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x4B152C", Offset = "0x4B152C", VA = "0x4B152C")]
	public static void TerminateThreadAndWait(ManagedThread thread, bool dontAbort = false)
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x4B1858", Offset = "0x4B1858", VA = "0x4B1858")]
	public static void TerminateAll()
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x4B1D50", Offset = "0x4B1D50", VA = "0x4B1D50")]
	public static bool IsThreadRunning(ManagedThread thread)
	{
		return default(bool);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x4B1D74", Offset = "0x4B1D74", VA = "0x4B1D74")]
	public static void CheckThreadTerminiate()
	{
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000079")]
	public static ManagedThread CurrentManagedThread
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4B1E40", Offset = "0x4B1E40", VA = "0x4B1E40")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	private static ManagedThread _currentManagedThread;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x0")]
	private static object LockObject;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<ManagedThread, LocalUser> ThreadUser;

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x8")]
	private static List<ManagedThread> ActiveThreads;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0xC")]
	private static List<ManagedThread> ThreadsToShutdown;
}
