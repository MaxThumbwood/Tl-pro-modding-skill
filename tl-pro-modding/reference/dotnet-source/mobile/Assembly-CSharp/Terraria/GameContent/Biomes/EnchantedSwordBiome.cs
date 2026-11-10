using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	public class EnchantedSwordBiome : MicroBiome
	{
		// Token: 0x06005ABA RID: 23226 RVA: 0x0002A8B8 File Offset: 0x00028AB8
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x92D340", Offset = "0x92D340", VA = "0x92D340", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x92F20C", Offset = "0x92F20C", VA = "0x92F20C")]
		public EnchantedSwordBiome()
		{
		}

		// Token: 0x04009BDF RID: 39903
		[Token(Token = "0x4009BDF")]
		[FieldOffset(Offset = "0x8")]
		private double _chanceOfEntrance;

		// Token: 0x04009BE0 RID: 39904
		[Token(Token = "0x4009BE0")]
		[FieldOffset(Offset = "0x10")]
		private double _chanceOfRealSword;
	}
}
