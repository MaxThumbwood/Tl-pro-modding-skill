using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	public static class PitEntrance
	{
		// Token: 0x06005B2D RID: 23341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0x97B474", Offset = "0x97B474", VA = "0x97B474")]
		public static void Place(DesertDescription description, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0x97B628", Offset = "0x97B628", VA = "0x97B628")]
		private static void PlaceAt(DesertDescription description, Point position, int holeRadius, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x97BEB0", Offset = "0x97BEB0", VA = "0x97BEB0")]
		private static double GetHoleRadiusScaleAt(double yProgress)
		{
			return 0.0;
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x97BF20", Offset = "0x97BF20", VA = "0x97BF20")]
		private static double SmootherStep(double delta)
		{
			return 0.0;
		}
	}
}
