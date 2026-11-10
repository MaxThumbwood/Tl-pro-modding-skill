using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	public static class DesertHive
	{
		// Token: 0x06005B21 RID: 23329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B21")]
		[Address(RVA = "0x97585C", Offset = "0x97585C", VA = "0x97585C")]
		public static void Place(DesertDescription description, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B22")]
		[Address(RVA = "0x975944", Offset = "0x975944", VA = "0x975944")]
		private static void PlaceClusters(DesertDescription description, DesertHive.ClusterGroup clusters, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B23")]
		[Address(RVA = "0x976BB0", Offset = "0x976BB0", VA = "0x976BB0")]
		private static void PlaceClustersArea(DesertDescription description, DesertHive.ClusterGroup clusters, Rectangle area, DesertHive.PostPlacementEffect[,] postEffectMap, Point postEffectMapOffset, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B24")]
		[Address(RVA = "0x975C34", Offset = "0x975C34", VA = "0x975C34")]
		private static void AddTileVariance(DesertDescription description)
		{
		}

		// Token: 0x02000BB4 RID: 2996
		[Token(Token = "0x2000BB4")]
		private struct Block
		{
			// Token: 0x06005B25 RID: 23333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B25")]
			[Address(RVA = "0x97886C", Offset = "0x97886C", VA = "0x97886C")]
			public Block(double x, double y)
			{
			}

			// Token: 0x04009C05 RID: 39941
			[Token(Token = "0x4009C05")]
			[FieldOffset(Offset = "0x0")]
			public Vector2D Position;
		}

		// Token: 0x02000BB5 RID: 2997
		[Token(Token = "0x2000BB5")]
		private struct Cluster
		{
			// Token: 0x04009C06 RID: 39942
			[Token(Token = "0x4009C06")]
			[FieldOffset(Offset = "0x0")]
			public int Offset;

			// Token: 0x04009C07 RID: 39943
			[Token(Token = "0x4009C07")]
			[FieldOffset(Offset = "0x4")]
			public int Count;
		}

		// Token: 0x02000BB6 RID: 2998
		[Token(Token = "0x2000BB6")]
		private class ClusterGroup
		{
			// Token: 0x06005B26 RID: 23334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B26")]
			[Address(RVA = "0x9788AC", Offset = "0x9788AC", VA = "0x9788AC")]
			private ClusterGroup(int width, int height)
			{
			}

			// Token: 0x06005B27 RID: 23335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B27")]
			[Address(RVA = "0x9758A0", Offset = "0x9758A0", VA = "0x9758A0")]
			public static DesertHive.ClusterGroup FromDescription(DesertDescription description)
			{
				return null;
			}

			// Token: 0x06005B28 RID: 23336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B28")]
			[Address(RVA = "0x979EFC", Offset = "0x979EFC", VA = "0x979EFC")]
			private static void SearchForCluster(bool[,] blockMap, List<Point> pointCluster, int x, int y, int level = 2)
			{
			}

			// Token: 0x06005B29 RID: 23337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B29")]
			[Address(RVA = "0x97A13C", Offset = "0x97A13C", VA = "0x97A13C")]
			private static void AttemptClaim(int x, int y, int[,] clusterIndexMap, List<List<Point>> pointClusters, int index)
			{
			}

			// Token: 0x06005B2A RID: 23338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B2A")]
			[Address(RVA = "0x9788D8", Offset = "0x9788D8", VA = "0x9788D8")]
			private void Generate()
			{
			}

			// Token: 0x04009C08 RID: 39944
			[Token(Token = "0x4009C08")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Width;

			// Token: 0x04009C09 RID: 39945
			[Token(Token = "0x4009C09")]
			[FieldOffset(Offset = "0xC")]
			public readonly int Height;

			// Token: 0x04009C0A RID: 39946
			[Token(Token = "0x4009C0A")]
			[FieldOffset(Offset = "0x10")]
			public Vector2D[] Points;

			// Token: 0x04009C0B RID: 39947
			[Token(Token = "0x4009C0B")]
			[FieldOffset(Offset = "0x14")]
			public DesertHive.Cluster[] Clusters;
		}

		// Token: 0x02000BB7 RID: 2999
		[Token(Token = "0x2000BB7")]
		private enum PostPlacementEffect : byte
		{
			// Token: 0x04009C0D RID: 39949
			[Token(Token = "0x4009C0D")]
			None,
			// Token: 0x04009C0E RID: 39950
			[Token(Token = "0x4009C0E")]
			Smooth
		}
	}
}
