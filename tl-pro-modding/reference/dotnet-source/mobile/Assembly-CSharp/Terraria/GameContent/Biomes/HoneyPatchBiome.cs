using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000BA2 RID: 2978
	[Token(Token = "0x2000BA2")]
	public class HoneyPatchBiome : MicroBiome
	{
		// Token: 0x06005AD4 RID: 23252 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x936700", Offset = "0x936700", VA = "0x936700", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x0002A9F0 File Offset: 0x00028BF0
		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0x937CCC", Offset = "0x937CCC", VA = "0x937CCC")]
		private static bool TooCloseToImportantLocations(Point origin)
		{
			return default(bool);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0x938228", Offset = "0x938228", VA = "0x938228")]
		public HoneyPatchBiome()
		{
		}
	}
}
