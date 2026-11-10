using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	public class DesertBiome : MicroBiome
	{
		// Token: 0x06005A82 RID: 23170 RVA: 0x0002A6C0 File Offset: 0x000288C0
		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x925FE4", Offset = "0x925FE4", VA = "0x925FE4", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x92637C", Offset = "0x92637C", VA = "0x92637C")]
		private static void ExportDescriptionToEngine(DesertDescription description)
		{
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x926480", Offset = "0x926480", VA = "0x926480")]
		private static void CleanupArea(Rectangle area, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A85")]
		[Address(RVA = "0x9266DC", Offset = "0x9266DC", VA = "0x9266DC")]
		public DesertBiome()
		{
		}

		// Token: 0x04009BBB RID: 39867
		[Token(Token = "0x4009BBB")]
		[FieldOffset(Offset = "0x8")]
		public double ChanceOfEntrance;
	}
}
