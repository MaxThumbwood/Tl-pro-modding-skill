using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class SoundPlaySet
	{
		// Token: 0x06004486 RID: 17542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004486")]
		[Address(RVA = "0x559F40", Offset = "0x559F40", VA = "0x559F40")]
		public SoundPlaySet()
		{
		}

		// Token: 0x04008BF9 RID: 35833
		[Token(Token = "0x4008BF9")]
		[FieldOffset(Offset = "0x8")]
		public int IntendedCooldown;

		// Token: 0x04008BFA RID: 35834
		[Token(Token = "0x4008BFA")]
		[FieldOffset(Offset = "0xC")]
		public int SoundType;

		// Token: 0x04008BFB RID: 35835
		[Token(Token = "0x4008BFB")]
		[FieldOffset(Offset = "0x10")]
		public int SoundStyle;
	}
}
