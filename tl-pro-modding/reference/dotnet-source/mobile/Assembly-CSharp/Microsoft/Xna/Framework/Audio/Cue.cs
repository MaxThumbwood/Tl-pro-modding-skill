using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	public class Cue
	{
		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0xF0A98C", Offset = "0xF0A98C", VA = "0xF0A98C")]
		public Cue(SoundEffect musicSource)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x170003C6")]
		public bool IsPaused
		{
			[Token(Token = "0x6001EB8")]
			[Address(RVA = "0xF0AACC", Offset = "0xF0AACC", VA = "0xF0AACC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x170003C7")]
		public bool IsPlaying
		{
			[Token(Token = "0x6001EB9")]
			[Address(RVA = "0xF0AAD4", Offset = "0xF0AAD4", VA = "0xF0AAD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x170003C8")]
		public bool IsStopped
		{
			[Token(Token = "0x6001EBA")]
			[Address(RVA = "0xF0AB1C", Offset = "0xF0AB1C", VA = "0xF0AB1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0xF0AB54", Offset = "0xF0AB54", VA = "0xF0AB54")]
		public void Play()
		{
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0xF0AB88", Offset = "0xF0AB88", VA = "0xF0AB88")]
		public void Pause()
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0xF0AC14", Offset = "0xF0AC14", VA = "0xF0AC14")]
		public void Resume()
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0xF0AC98", Offset = "0xF0AC98", VA = "0xF0AC98")]
		public void Stop(AudioStopOptions option)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0xF0ACC8", Offset = "0xF0ACC8", VA = "0xF0ACC8")]
		public void SetVariable(string id, float value)
		{
		}

		// Token: 0x04003179 RID: 12665
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x8")]
		private bool _paused;

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0xC")]
		private float _pausedTime;

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x10")]
		private SoundEffectInstance _audioInstance;

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x14")]
		private SoundEffect _effect;
	}
}
