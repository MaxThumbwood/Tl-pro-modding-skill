using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000055")]
public class SoundManager : Singleton<SoundManager>
{
	// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x4A82D8", Offset = "0x4A82D8", VA = "0x4A82D8", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x4A861C", Offset = "0x4A861C", VA = "0x4A861C", Slot = "5")]
	public override void Shutdown()
	{
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000075")]
	public static AudioMixer MasterMixer
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4A7658", Offset = "0x4A7658", VA = "0x4A7658")]
		get
		{
			return null;
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x4A8374", Offset = "0x4A8374", VA = "0x4A8374")]
	public void SetupChannels(int numChannels)
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x4A6A10", Offset = "0x4A6A10", VA = "0x4A6A10")]
	public SoundChannel GetChannel(SoundDefinition soundDefinition)
	{
		return null;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x4A8624", Offset = "0x4A8624", VA = "0x4A8624")]
	public void StopAllSoundsOnChannels(string channelId)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x4A88F0", Offset = "0x4A88F0", VA = "0x4A88F0")]
	public bool IsPlaying(SoundDefinition soundDefinition)
	{
		return default(bool);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x4A8B64", Offset = "0x4A8B64", VA = "0x4A8B64")]
	public SoundManager()
	{
	}

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0xC")]
	public AnimationCurve VolumeFalloff;

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x10")]
	private GameObject _soundRoot;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x14")]
	private List<SoundChannel> _channels;

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x0")]
	private static AudioMixer _mixer;
}
