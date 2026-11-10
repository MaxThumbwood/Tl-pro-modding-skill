using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	public class SoundBank
	{
		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0xF0ADD8", Offset = "0xF0ADD8", VA = "0xF0ADD8")]
		public SoundBank(AudioEngine engine, string contentPath)
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0xF0AE70", Offset = "0xF0AE70", VA = "0xF0AE70")]
		public void LoadMusicId(int musicIndex)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0xF0B00C", Offset = "0xF0B00C", VA = "0xF0B00C")]
		public Cue GetCue(string cueId)
		{
			return null;
		}

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, Cue> _cues;
	}
}
