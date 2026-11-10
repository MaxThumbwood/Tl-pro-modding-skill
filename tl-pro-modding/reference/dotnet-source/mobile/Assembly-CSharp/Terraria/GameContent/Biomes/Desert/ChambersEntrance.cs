using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	public static class ChambersEntrance
	{
		// Token: 0x06005B09 RID: 23305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B09")]
		[Address(RVA = "0x973098", Offset = "0x973098", VA = "0x973098")]
		public static void Place(DesertDescription description, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0A")]
		[Address(RVA = "0x9732A8", Offset = "0x9732A8", VA = "0x9732A8")]
		private static void PlaceAt(DesertDescription description, Point position, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x02000BB1 RID: 2993
		[Token(Token = "0x2000BB1")]
		private struct PathConnection
		{
			// Token: 0x06005B0B RID: 23307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B0B")]
			[Address(RVA = "0x974AC4", Offset = "0x974AC4", VA = "0x974AC4")]
			public PathConnection(Point position, int direction)
			{
			}

			// Token: 0x04009BF8 RID: 39928
			[Token(Token = "0x4009BF8")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector2D Position;

			// Token: 0x04009BF9 RID: 39929
			[Token(Token = "0x4009BF9")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Direction;
		}
	}
}
