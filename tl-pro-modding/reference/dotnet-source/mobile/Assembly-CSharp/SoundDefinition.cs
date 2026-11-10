using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class SoundDefinition
{
	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x17000071")]
	public float MaxLength
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4A68A8", Offset = "0x4A68A8", VA = "0x4A68A8")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x4A68B0", Offset = "0x4A68B0", VA = "0x4A68B0")]
	public SoundInstance Play(float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		return null;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x4A72F4", Offset = "0x4A72F4", VA = "0x4A72F4")]
	public AudioClip GetRandomClip()
	{
		return null;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x4A73A0", Offset = "0x4A73A0", VA = "0x4A73A0")]
	public void AddVariation(AudioClip clip)
	{
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x4A74F4", Offset = "0x4A74F4", VA = "0x4A74F4")]
	public SoundDefinition()
	{
	}

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0xC")]
	public SoundGroup Group;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x10")]
	public int Priority;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x14")]
	public float VolumeScale;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x18")]
	private float _maxLength;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x1C")]
	private List<AudioClip> _variations;
}
