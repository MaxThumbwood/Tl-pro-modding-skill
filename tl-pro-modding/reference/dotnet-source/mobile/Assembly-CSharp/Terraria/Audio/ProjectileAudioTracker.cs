using System;
using Il2CppDummyDll;

namespace Terraria.Audio
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	public class ProjectileAudioTracker
	{
		// Token: 0x06004516 RID: 17686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x55F69C", Offset = "0x55F69C", VA = "0x55F69C")]
		public ProjectileAudioTracker(Projectile proj)
		{
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x000210A8 File Offset: 0x0001F2A8
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x55F6E4", Offset = "0x55F6E4", VA = "0x55F6E4")]
		public bool IsActiveAndInGame()
		{
			return default(bool);
		}

		// Token: 0x04008C7C RID: 35964
		[Token(Token = "0x4008C7C")]
		[FieldOffset(Offset = "0x8")]
		private int _expectedType;

		// Token: 0x04008C7D RID: 35965
		[Token(Token = "0x4008C7D")]
		[FieldOffset(Offset = "0xC")]
		private int _expectedIndex;
	}
}
