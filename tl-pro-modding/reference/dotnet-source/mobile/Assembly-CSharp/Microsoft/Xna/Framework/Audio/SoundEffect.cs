using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	public sealed class SoundEffect
	{
		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0xF0B078", Offset = "0xF0B078", VA = "0xF0B078")]
		public SoundEffect(string id, AudioClip clip)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0xF0AA44", Offset = "0xF0AA44", VA = "0xF0AA44")]
		public SoundEffectInstance CreateInstance()
		{
			return null;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0xF0B1B4", Offset = "0xF0B1B4", VA = "0xF0B1B4")]
		public bool Play()
		{
			return default(bool);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0xF0B200", Offset = "0xF0B200", VA = "0xF0B200")]
		public bool Play(float volume, float pitch, float pan)
		{
			return default(bool);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[Token(Token = "0x170003C9")]
		public TimeSpan Duration
		{
			[Token(Token = "0x6001EC7")]
			[Address(RVA = "0xF0B258", Offset = "0xF0B258", VA = "0xF0B258")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CA")]
		public string Name
		{
			[Token(Token = "0x6001EC8")]
			[Address(RVA = "0xF0B300", Offset = "0xF0B300", VA = "0xF0B300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EC9")]
			[Address(RVA = "0xF0B308", Offset = "0xF0B308", VA = "0xF0B308")]
			set
			{
			}
		}

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x8")]
		private string _name;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0xC")]
		public readonly SoundDefinition Definition;
	}
}
