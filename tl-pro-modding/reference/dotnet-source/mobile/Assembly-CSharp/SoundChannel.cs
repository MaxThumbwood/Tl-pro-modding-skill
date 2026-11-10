using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public class SoundChannel
{
	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000070")]
	public SoundInstance CurrentSound
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4A6880", Offset = "0x4A6880", VA = "0x4A6880")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4A6888", Offset = "0x4A6888", VA = "0x4A6888")]
		set
		{
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x4A68A0", Offset = "0x4A68A0", VA = "0x4A68A0")]
	public SoundChannel()
	{
	}

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x8")]
	public AudioSource AudioSource;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0xC")]
	private SoundInstance _currentSound;
}
