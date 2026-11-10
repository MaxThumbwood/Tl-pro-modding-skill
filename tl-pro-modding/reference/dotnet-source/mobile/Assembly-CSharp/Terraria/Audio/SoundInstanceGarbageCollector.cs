using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public static class SoundInstanceGarbageCollector
	{
		// Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x582314", Offset = "0x582314", VA = "0x582314")]
		public static void Track(SoundEffectInstance sound)
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x57F720", Offset = "0x57F720", VA = "0x57F720")]
		public static void Update()
		{
		}

		// Token: 0x04008CE1 RID: 36065
		[Token(Token = "0x4008CE1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<SoundEffectInstance> _activeSounds;
	}
}
