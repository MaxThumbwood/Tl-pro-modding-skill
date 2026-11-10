using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	public class ActiveSound
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000849")]
		public SoundEffectInstance Sound
		{
			[Token(Token = "0x6004502")]
			[Address(RVA = "0x55EAF0", Offset = "0x55EAF0", VA = "0x55EAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004503")]
			[Address(RVA = "0x55EAF8", Offset = "0x55EAF8", VA = "0x55EAF8")]
			private set
			{
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084A")]
		public SoundStyle Style
		{
			[Token(Token = "0x6004504")]
			[Address(RVA = "0x55EB00", Offset = "0x55EB00", VA = "0x55EB00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004505")]
			[Address(RVA = "0x55EB08", Offset = "0x55EB08", VA = "0x55EB08")]
			private set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x00021078 File Offset: 0x0001F278
		[Token(Token = "0x1700084B")]
		public bool IsPlaying
		{
			[Token(Token = "0x6004506")]
			[Address(RVA = "0x55EB10", Offset = "0x55EB10", VA = "0x55EB10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x55EB44", Offset = "0x55EB44", VA = "0x55EB44")]
		private void UseOverrides(SoundPlayOverrides overrides)
		{
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x55EBC8", Offset = "0x55EBC8", VA = "0x55EBC8")]
		public ActiveSound(SoundStyle style, Vector2 position, SoundPlayOverrides overrides)
		{
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x55EDD0", Offset = "0x55EDD0", VA = "0x55EDD0")]
		public ActiveSound(SoundStyle style)
		{
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x55EEC8", Offset = "0x55EEC8", VA = "0x55EEC8")]
		public ActiveSound(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition condition, SoundPlayOverrides overrides)
		{
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x55EC98", Offset = "0x55EC98", VA = "0x55EC98")]
		private void Play()
		{
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x55EFA0", Offset = "0x55EFA0", VA = "0x55EFA0")]
		private void PlayLooped(ActiveSound.LoopedPlayCondition condition)
		{
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x55F488", Offset = "0x55F488", VA = "0x55F488")]
		public void Stop()
		{
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x55F4A8", Offset = "0x55F4A8", VA = "0x55F4A8")]
		public void Pause()
		{
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x55F500", Offset = "0x55F500", VA = "0x55F500")]
		public void Resume()
		{
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x55F3BC", Offset = "0x55F3BC", VA = "0x55F3BC")]
		public void Update()
		{
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00021090 File Offset: 0x0001F290
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x55F0E0", Offset = "0x55F0E0", VA = "0x55F0E0")]
		private float DetermineIntendedVolume()
		{
			return 0f;
		}

		// Token: 0x04008C75 RID: 35957
		[Token(Token = "0x4008C75")]
		[FieldOffset(Offset = "0x8")]
		private SoundEffectInstance <Sound>k__BackingField;

		// Token: 0x04008C76 RID: 35958
		[Token(Token = "0x4008C76")]
		[FieldOffset(Offset = "0xC")]
		public readonly bool IsGlobal;

		// Token: 0x04008C77 RID: 35959
		[Token(Token = "0x4008C77")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Position;

		// Token: 0x04008C78 RID: 35960
		[Token(Token = "0x4008C78")]
		[FieldOffset(Offset = "0x18")]
		public float Volume;

		// Token: 0x04008C79 RID: 35961
		[Token(Token = "0x4008C79")]
		[FieldOffset(Offset = "0x1C")]
		public float Pitch;

		// Token: 0x04008C7A RID: 35962
		[Token(Token = "0x4008C7A")]
		[FieldOffset(Offset = "0x20")]
		private SoundStyle <Style>k__BackingField;

		// Token: 0x04008C7B RID: 35963
		[Token(Token = "0x4008C7B")]
		[FieldOffset(Offset = "0x24")]
		public ActiveSound.LoopedPlayCondition Condition;

		// Token: 0x020007D3 RID: 2003
		// (Invoke) Token: 0x06004513 RID: 17683
		[Token(Token = "0x20007D3")]
		public delegate bool LoopedPlayCondition();
	}
}
