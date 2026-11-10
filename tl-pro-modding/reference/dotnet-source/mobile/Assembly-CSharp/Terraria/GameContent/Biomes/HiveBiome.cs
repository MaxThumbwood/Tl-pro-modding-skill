using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2000BA1")]
	public class HiveBiome : MicroBiome
	{
		// Token: 0x06005ACA RID: 23242 RVA: 0x0002A960 File Offset: 0x00028B60
		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x932170", Offset = "0x932170", VA = "0x932170", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x934F04", Offset = "0x934F04", VA = "0x934F04")]
		private static void FrameOutAllHiveContents(Point origin, int squareHalfWidth)
		{
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x0002A978 File Offset: 0x00028B78
		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0x9338A8", Offset = "0x9338A8", VA = "0x9338A8")]
		private static Vector2D CreateHiveTunnel(int i, int j, UnifiedRandom random)
		{
			return default(Vector2D);
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x0002A990 File Offset: 0x00028B90
		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0x933374", Offset = "0x933374", VA = "0x933374")]
		private static bool TooCloseToImportantLocations(Point origin)
		{
			return default(bool);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0x935D40", Offset = "0x935D40", VA = "0x935D40")]
		private static void CreateDentForHoneyFall(int x, int y, int dir)
		{
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0x93591C", Offset = "0x93591C", VA = "0x93591C")]
		private static void CreateBlockedHoneyCube(int x, int y)
		{
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0x935668", Offset = "0x935668", VA = "0x935668")]
		private static bool SpotActuallyNotInHive(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x9352B0", Offset = "0x9352B0", VA = "0x9352B0")]
		private static bool BadSpotForHoneyFall(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x9360D0", Offset = "0x9360D0", VA = "0x9360D0")]
		public static void CreateStandForLarva(Vector2D position)
		{
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x9366F8", Offset = "0x9366F8", VA = "0x9366F8")]
		public HiveBiome()
		{
		}
	}
}
