using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B8F RID: 2959
	[Token(Token = "0x2000B8F")]
	public class CorruptionPitBiome : MicroBiome
	{
		// Token: 0x06005A68 RID: 23144 RVA: 0x0002A630 File Offset: 0x00028830
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x905C98", Offset = "0x905C98", VA = "0x905C98", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x906FD8", Offset = "0x906FD8", VA = "0x906FD8")]
		public CorruptionPitBiome()
		{
		}

		// Token: 0x04009BA4 RID: 39844
		[Token(Token = "0x4009BA4")]
		[FieldOffset(Offset = "0x0")]
		public static bool[] ValidTiles;
	}
}
