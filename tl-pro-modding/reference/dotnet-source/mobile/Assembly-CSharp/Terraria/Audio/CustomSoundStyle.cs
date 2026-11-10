using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	public class CustomSoundStyle : SoundStyle
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[Token(Token = "0x1700084C")]
		public override bool IsTrackable
		{
			[Token(Token = "0x600451A")]
			[Address(RVA = "0x55F8C0", Offset = "0x55F8C0", VA = "0x55F8C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[Token(Token = "0x1700084D")]
		public override int MaxTrackedInstances
		{
			[Token(Token = "0x600451B")]
			[Address(RVA = "0x55F8C8", Offset = "0x55F8C8", VA = "0x55F8C8", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x55F8D0", Offset = "0x55F8D0", VA = "0x55F8D0")]
		public CustomSoundStyle(SoundEffect soundEffect, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x55F9E0", Offset = "0x55F9E0", VA = "0x55F9E0")]
		public CustomSoundStyle(SoundEffect[] soundEffects, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x55FA7C", Offset = "0x55FA7C", VA = "0x55FA7C", Slot = "6")]
		public override SoundEffect GetRandomSound()
		{
			return null;
		}

		// Token: 0x04008C7F RID: 35967
		[Token(Token = "0x4008C7F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UnifiedRandom Random;

		// Token: 0x04008C80 RID: 35968
		[Token(Token = "0x4008C80")]
		[FieldOffset(Offset = "0x14")]
		private readonly SoundEffect[] _soundEffects;
	}
}
