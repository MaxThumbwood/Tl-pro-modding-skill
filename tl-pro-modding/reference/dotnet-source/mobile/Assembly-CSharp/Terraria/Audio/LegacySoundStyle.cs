using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x20007DB")]
	public class LegacySoundStyle : SoundStyle
	{
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x00021138 File Offset: 0x0001F338
		[Token(Token = "0x1700084E")]
		public int Style
		{
			[Token(Token = "0x600454D")]
			[Address(RVA = "0x57E640", Offset = "0x57E640", VA = "0x57E640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x00021150 File Offset: 0x0001F350
		[Token(Token = "0x1700084F")]
		public override bool IsTrackable
		{
			[Token(Token = "0x600454E")]
			[Address(RVA = "0x57E6E4", Offset = "0x57E6E4", VA = "0x57E6E4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x00021168 File Offset: 0x0001F368
		[Token(Token = "0x17000850")]
		public override int MaxTrackedInstances
		{
			[Token(Token = "0x600454F")]
			[Address(RVA = "0x57E6F8", Offset = "0x57E6F8", VA = "0x57E6F8", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x57E700", Offset = "0x57E700", VA = "0x57E700")]
		public LegacySoundStyle(int soundId, int style, SoundType type = SoundType.Sound, int maxTrackedInstances = 0)
		{
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x57E7C8", Offset = "0x57E7C8", VA = "0x57E7C8")]
		public LegacySoundStyle(int soundId, int style, int variations, SoundType type = SoundType.Sound, int maxTrackedInstances = 0)
		{
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x57E864", Offset = "0x57E864", VA = "0x57E864")]
		private LegacySoundStyle(int soundId, int style, int variations, SoundType type, float volume, float pitchVariance, int maxTrackedInstances)
		{
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x57E938", Offset = "0x57E938", VA = "0x57E938")]
		public LegacySoundStyle WithVolume(float volume)
		{
			return null;
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x57EA40", Offset = "0x57EA40", VA = "0x57EA40")]
		public LegacySoundStyle WithVolumePerceived(float volume)
		{
			return null;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x57EBB8", Offset = "0x57EBB8", VA = "0x57EBB8")]
		public LegacySoundStyle WithPitchVariance(float pitchVariance)
		{
			return null;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x57ECC0", Offset = "0x57ECC0", VA = "0x57ECC0")]
		public LegacySoundStyle AsMusic()
		{
			return null;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x57EDD4", Offset = "0x57EDD4", VA = "0x57EDD4")]
		public LegacySoundStyle AsAmbient()
		{
			return null;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x57EEE8", Offset = "0x57EEE8", VA = "0x57EEE8")]
		public LegacySoundStyle AsSound()
		{
			return null;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00021180 File Offset: 0x0001F380
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x57EFFC", Offset = "0x57EFFC", VA = "0x57EFFC")]
		public bool Includes(int soundId, int style)
		{
			return default(bool);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x57F034", Offset = "0x57F034", VA = "0x57F034", Slot = "6")]
		public override SoundEffect GetRandomSound()
		{
			return null;
		}

		// Token: 0x04008CD7 RID: 36055
		[Token(Token = "0x4008CD7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UnifiedRandom Random;

		// Token: 0x04008CD8 RID: 36056
		[Token(Token = "0x4008CD8")]
		[FieldOffset(Offset = "0x14")]
		private readonly int _style;

		// Token: 0x04008CD9 RID: 36057
		[Token(Token = "0x4008CD9")]
		[FieldOffset(Offset = "0x18")]
		public readonly int Variations;

		// Token: 0x04008CDA RID: 36058
		[Token(Token = "0x4008CDA")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int SoundId;

		// Token: 0x04008CDB RID: 36059
		[Token(Token = "0x4008CDB")]
		[FieldOffset(Offset = "0x20")]
		public readonly int _maxTrackedInstances;
	}
}
