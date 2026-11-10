using System;
using Il2CppDummyDll;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
internal class SingletonCleanup
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000005")]
	public static event SingletonCleanup.CleanupSingletonCallback CleanUpEvent
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4AE7A4", Offset = "0x4AE7A4", VA = "0x4AE7A4")]
		add
		{
		}
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4AE870", Offset = "0x4AE870", VA = "0x4AE870")]
		remove
		{
		}
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x4AE93C", Offset = "0x4AE93C", VA = "0x4AE93C")]
	public static void Cleanup()
	{
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000207")]
	[Address(RVA = "0x4AE9B4", Offset = "0x4AE9B4", VA = "0x4AE9B4")]
	public SingletonCleanup()
	{
	}

	// Token: 0x02000064 RID: 100
	// (Invoke) Token: 0x06000209 RID: 521
	[Token(Token = "0x2000064")]
	public delegate void CleanupSingletonCallback();
}
