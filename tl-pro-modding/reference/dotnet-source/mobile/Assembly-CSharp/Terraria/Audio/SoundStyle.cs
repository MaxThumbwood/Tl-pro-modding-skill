using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	public abstract class SoundStyle
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x00021270 File Offset: 0x0001F470
		[Token(Token = "0x17000852")]
		public float Volume
		{
			[Token(Token = "0x600457E")]
			[Address(RVA = "0x5824F8", Offset = "0x5824F8", VA = "0x5824F8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x00021288 File Offset: 0x0001F488
		[Token(Token = "0x17000853")]
		public float PitchVariance
		{
			[Token(Token = "0x600457F")]
			[Address(RVA = "0x582500", Offset = "0x582500", VA = "0x582500")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x000212A0 File Offset: 0x0001F4A0
		[Token(Token = "0x17000854")]
		public SoundType Type
		{
			[Token(Token = "0x6004580")]
			[Address(RVA = "0x582508", Offset = "0x582508", VA = "0x582508")]
			get
			{
				return SoundType.Sound;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06004581 RID: 17793
		[Token(Token = "0x17000855")]
		public abstract bool IsTrackable
		{
			[Token(Token = "0x6004581")]
			get;
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06004582 RID: 17794
		[Token(Token = "0x17000856")]
		public abstract int MaxTrackedInstances
		{
			[Token(Token = "0x6004582")]
			get;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x57E90C", Offset = "0x57E90C", VA = "0x57E90C")]
		public SoundStyle(float volume, float pitchVariance, SoundType type = SoundType.Sound)
		{
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x57E79C", Offset = "0x57E79C", VA = "0x57E79C")]
		public SoundStyle(SoundType type = SoundType.Sound)
		{
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x580840", Offset = "0x580840", VA = "0x580840")]
		public float GetRandomPitch()
		{
			return 0f;
		}

		// Token: 0x06004586 RID: 17798
		[Token(Token = "0x6004586")]
		public abstract SoundEffect GetRandomSound();

		// Token: 0x04008CE3 RID: 36067
		[Token(Token = "0x4008CE3")]
		[FieldOffset(Offset = "0x0")]
		private static UnifiedRandom _random;

		// Token: 0x04008CE4 RID: 36068
		[Token(Token = "0x4008CE4")]
		[FieldOffset(Offset = "0x8")]
		private float _volume;

		// Token: 0x04008CE5 RID: 36069
		[Token(Token = "0x4008CE5")]
		[FieldOffset(Offset = "0xC")]
		private float _pitchVariance;

		// Token: 0x04008CE6 RID: 36070
		[Token(Token = "0x4008CE6")]
		[FieldOffset(Offset = "0x10")]
		private SoundType _type;
	}
}
