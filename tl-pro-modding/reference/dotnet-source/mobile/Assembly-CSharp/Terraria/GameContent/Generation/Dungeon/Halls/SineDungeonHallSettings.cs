using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class SineDungeonHallSettings : DungeonHallSettings
	{
		// Token: 0x060059C0 RID: 22976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x8B64B0", Offset = "0x8B64B0", VA = "0x8B64B0")]
		public SineDungeonHallSettings()
		{
		}

		// Token: 0x04009B48 RID: 39752
		[Token(Token = "0x4009B48")]
		[FieldOffset(Offset = "0x3C")]
		public float Magnitude;

		// Token: 0x04009B49 RID: 39753
		[Token(Token = "0x4009B49")]
		[FieldOffset(Offset = "0x40")]
		public int Iterations;

		// Token: 0x04009B4A RID: 39754
		[Token(Token = "0x4009B4A")]
		[FieldOffset(Offset = "0x44")]
		public bool FlipSine;
	}
}
