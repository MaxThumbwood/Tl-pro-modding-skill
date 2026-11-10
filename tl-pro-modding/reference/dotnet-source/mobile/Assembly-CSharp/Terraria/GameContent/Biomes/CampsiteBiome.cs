using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B8D RID: 2957
	[Token(Token = "0x2000B8D")]
	public class CampsiteBiome : MicroBiome
	{
		// Token: 0x06005A55 RID: 23125 RVA: 0x0002A558 File Offset: 0x00028758
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x9035A0", Offset = "0x9035A0", VA = "0x9035A0", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x905688", Offset = "0x905688", VA = "0x905688")]
		public CampsiteBiome()
		{
		}
	}
}
