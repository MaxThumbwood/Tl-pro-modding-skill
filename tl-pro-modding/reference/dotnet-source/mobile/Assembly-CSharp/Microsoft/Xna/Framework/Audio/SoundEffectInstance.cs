using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	public class SoundEffectInstance
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CB")]
		public virtual bool IsLooped
		{
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0xF0B310", Offset = "0xF0B310", VA = "0xF0B310", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ECB")]
			[Address(RVA = "0xF0B318", Offset = "0xF0B318", VA = "0xF0B318", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0000ED30 File Offset: 0x0000CF30
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CC")]
		public float Pan
		{
			[Token(Token = "0x6001ECC")]
			[Address(RVA = "0xF0B320", Offset = "0xF0B320", VA = "0xF0B320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ECD")]
			[Address(RVA = "0xF0B328", Offset = "0xF0B328", VA = "0xF0B328")]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0000ED48 File Offset: 0x0000CF48
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CD")]
		public float Pitch
		{
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0xF0B3B8", Offset = "0xF0B3B8", VA = "0xF0B3B8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ECF")]
			[Address(RVA = "0xF0B3C0", Offset = "0xF0B3C0", VA = "0xF0B3C0")]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0000ED60 File Offset: 0x0000CF60
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CE")]
		public float Volume
		{
			[Token(Token = "0x6001ED0")]
			[Address(RVA = "0xF0B4D0", Offset = "0xF0B4D0", VA = "0xF0B4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0xF0AD58", Offset = "0xF0AD58", VA = "0xF0AD58")]
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x170003CF")]
		public virtual SoundState State
		{
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0xF0B4D8", Offset = "0xF0B4D8", VA = "0xF0B4D8", Slot = "6")]
			get
			{
				return SoundState.Playing;
			}
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0xF0B184", Offset = "0xF0B184", VA = "0xF0B184")]
		internal SoundEffectInstance(SoundEffect effect)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0xF0B5AC", Offset = "0xF0B5AC", VA = "0xF0B5AC", Slot = "7")]
		public virtual void Play()
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0xF0B7B8", Offset = "0xF0B7B8", VA = "0xF0B7B8")]
		private static void PlayOnMainThread(object data)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0xF0B86C", Offset = "0xF0B86C", VA = "0xF0B86C")]
		private static void StopOnMainThread(object data)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0xF0B928", Offset = "0xF0B928", VA = "0xF0B928")]
		public void Restart()
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0xF0B93C", Offset = "0xF0B93C", VA = "0xF0B93C", Slot = "8")]
		public virtual void Pause()
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0xF0B940", Offset = "0xF0B940", VA = "0xF0B940", Slot = "9")]
		public virtual void Resume()
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0xF0B944", Offset = "0xF0B944", VA = "0xF0B944", Slot = "10")]
		public virtual void Stop(bool immediate = false)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0000ED90 File Offset: 0x0000CF90
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D0")]
		public float CurrentPosition
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0xF0ABFC", Offset = "0xF0ABFC", VA = "0xF0ABFC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0xF0AC84", Offset = "0xF0AC84", VA = "0xF0AC84")]
			set
			{
			}
		}

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x8")]
		internal SoundEffect _effect;

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0xC")]
		private bool _loop;

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x10")]
		private float _pan;

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x14")]
		private float _volume;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x18")]
		private float _pitch;

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x1C")]
		private SoundInstance _playingInstance;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x0")]
		public static float pitchOffset;

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x4")]
		public static float pitchScale;
	}
}
