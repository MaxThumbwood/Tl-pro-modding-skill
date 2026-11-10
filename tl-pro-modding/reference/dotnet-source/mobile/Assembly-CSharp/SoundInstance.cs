using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class SoundInstance
{
	// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x4A6F80", Offset = "0x4A6F80", VA = "0x4A6F80")]
	public SoundInstance(SoundChannel channel, SoundDefinition definition, float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x4A7790", Offset = "0x4A7790", VA = "0x4A7790")]
	public void Restart()
	{
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000073")]
	public float CurrentPosition
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4A792C", Offset = "0x4A792C", VA = "0x4A792C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4A79E4", Offset = "0x4A79E4", VA = "0x4A79E4")]
		set
		{
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x4A7B8C", Offset = "0x4A7B8C", VA = "0x4A7B8C")]
	public void SetVolume(float volume)
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x4A7C48", Offset = "0x4A7C48", VA = "0x4A7C48")]
	public void SetPan(float pan)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x4A7D04", Offset = "0x4A7D04", VA = "0x4A7D04")]
	public void SetPitch(float pitch)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x4A7DC0", Offset = "0x4A7DC0", VA = "0x4A7DC0")]
	public void Stop()
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x4A7EC8", Offset = "0x4A7EC8", VA = "0x4A7EC8")]
	public void StartFade(float fadeTarget, DateTime fadeStart, DateTime targetTime)
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x4A8034", Offset = "0x4A8034", VA = "0x4A8034")]
	public bool UpdateFade()
	{
		return default(bool);
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000074")]
	public SoundChannel Channel
	{
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4A82C8", Offset = "0x4A82C8", VA = "0x4A82C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4A82D0", Offset = "0x4A82D0", VA = "0x4A82D0")]
		set
		{
		}
	}

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x8")]
	public readonly AudioClip Clip;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0xC")]
	public readonly SoundDefinition Definition;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x10")]
	public DateTime FinishTime;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x18")]
	private bool _fading;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x20")]
	private DateTime _fadeStart;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x28")]
	private DateTime _fadeEnd;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x30")]
	private float _fadeStartVol;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x34")]
	private float _fadeEndVol;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x38")]
	private SoundChannel _channel;
}
