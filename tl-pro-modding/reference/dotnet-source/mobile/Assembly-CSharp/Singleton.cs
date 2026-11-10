using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public abstract class Singleton<T> : ScriptableObject where T : Singleton<T>, new()
{
	// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020D")]
	public Singleton()
	{
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000077")]
	public static T Instance
	{
		[Token(Token = "0x600020E")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020F")]
	public static void Create()
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000210")]
	private static void CreateOnMainThread(object resourceId)
	{
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000211")]
	public static void Create(string resourceId)
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000212")]
	public static void Destroy()
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000213")]
	private void OnEnable()
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000214")]
	private void OnDisable()
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000215")]
	private static void Cleanup()
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000216")]
	public virtual void Init()
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000217")]
	public virtual void Shutdown()
	{
	}

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x0")]
	private static bool _initialised;
}
