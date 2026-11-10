using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	public static class SoundEngine
	{
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x00021198 File Offset: 0x0001F398
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000851")]
		public static bool IsAudioSupported
		{
			[Token(Token = "0x600455C")]
			[Address(RVA = "0x57F28C", Offset = "0x57F28C", VA = "0x57F28C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600455D")]
			[Address(RVA = "0x57F2DC", Offset = "0x57F2DC", VA = "0x57F2DC")]
			private set
			{
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455E")]
		[Address(RVA = "0x57F330", Offset = "0x57F330", VA = "0x57F330")]
		public static void Initialize()
		{
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455F")]
		[Address(RVA = "0x57F38C", Offset = "0x57F38C", VA = "0x57F38C")]
		public static void Load(IServiceProvider services)
		{
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x57F5D4", Offset = "0x57F5D4", VA = "0x57F5D4")]
		public static void Update()
		{
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x580480", Offset = "0x580480", VA = "0x580480")]
		public static void Reload()
		{
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x58053C", Offset = "0x58053C", VA = "0x58053C")]
		public static void PlaySound(int type, Vector2 position, int style = 1, float pitchOffset = 0f)
		{
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x5806DC", Offset = "0x5806DC", VA = "0x5806DC")]
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position, float pitchOffset = 0f, float volumeScale = 1f)
		{
			return null;
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x580730", Offset = "0x580730", VA = "0x580730")]
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, int x = -1, int y = -1, float pitchOffset = 0f, float volumeScale = 1f)
		{
			return null;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x580598", Offset = "0x580598", VA = "0x580598")]
		public static SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			return null;
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x580900", Offset = "0x580900", VA = "0x580900")]
		public static ActiveSound GetActiveSound(SlotId id)
		{
			return null;
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000211B0 File Offset: 0x0001F3B0
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x580AAC", Offset = "0x580AAC", VA = "0x580AAC")]
		public static SlotId PlayTrackedSound(SoundStyle style, Vector2 position, [Optional] SoundPlayOverrides overrides)
		{
			return default(SlotId);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x58129C", Offset = "0x58129C", VA = "0x58129C")]
		public static SlotId PlayTrackedLoopedSound(SoundStyle style, Vector2 position, [Optional] ActiveSound.LoopedPlayCondition loopingCondition, [Optional] SoundPlayOverrides overrides)
		{
			return default(SlotId);
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x000211E0 File Offset: 0x0001F3E0
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x581680", Offset = "0x581680", VA = "0x581680")]
		public static SlotId PlayTrackedSound(SoundStyle style)
		{
			return default(SlotId);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x581910", Offset = "0x581910", VA = "0x581910")]
		public static void StopTrackedSounds()
		{
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x57F104", Offset = "0x57F104", VA = "0x57F104")]
		public static SoundEffect GetTrackableSoundByStyleId(int id)
		{
			return null;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x581DA0", Offset = "0x581DA0", VA = "0x581DA0")]
		public static void StopAmbientSounds()
		{
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x581E80", Offset = "0x581E80", VA = "0x581E80")]
		public static ActiveSound FindActiveSound(SoundStyle style)
		{
			return null;
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x000211F8 File Offset: 0x0001F3F8
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x57F384", Offset = "0x57F384", VA = "0x57F384")]
		private static bool TestAudioSupport()
		{
			return default(bool);
		}

		// Token: 0x04008CDC RID: 36060
		[Token(Token = "0x4008CDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LegacySoundPlayer LegacySoundPlayer;

		// Token: 0x04008CDD RID: 36061
		[Token(Token = "0x4008CDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static SoundPlayer SoundPlayer;

		// Token: 0x04008CDE RID: 36062
		[Token(Token = "0x4008CDE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool AreSoundsPaused;

		// Token: 0x04008CDF RID: 36063
		[Token(Token = "0x4008CDF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool <IsAudioSupported>k__BackingField;

		// Token: 0x04008CE0 RID: 36064
		[Token(Token = "0x4008CE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public static bool ForceFromUI;
	}
}
