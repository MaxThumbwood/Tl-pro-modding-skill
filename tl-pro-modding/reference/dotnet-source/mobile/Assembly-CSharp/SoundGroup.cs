using System;
using Il2CppDummyDll;
using UnityEngine.Audio;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class SoundGroup
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000072")]
	public AudioMixerGroup MixerGroup
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4A7594", Offset = "0x4A7594", VA = "0x4A7594")]
		get
		{
			return null;
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x4A7788", Offset = "0x4A7788", VA = "0x4A7788")]
	public SoundGroup()
	{
	}

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0xC")]
	public string MixerGroupPath;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x10")]
	private AudioMixerGroup _group;
}
