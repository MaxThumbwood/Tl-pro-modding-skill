using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Physics
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	public static class BallCollision
	{
		// Token: 0x06003E47 RID: 15943 RVA: 0x0001EB28 File Offset: 0x0001CD28
		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x1E69F10", Offset = "0x1E69F10", VA = "0x1E69F10")]
		public static BallStepResult Step(PhysicsProperties physicsProperties, Entity entity, ref float entityAngularVelocity, IBallContactListener listener)
		{
			return default(BallStepResult);
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x0001EB40 File Offset: 0x0001CD40
		[Token(Token = "0x6003E48")]
		[Address(RVA = "0x1E6AAA8", Offset = "0x1E6AAA8", VA = "0x1E6AAA8")]
		private static bool CheckForPassThrough(Vector2 center, out BallPassThroughType type, out Tile contactTile)
		{
			return default(bool);
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0001EB58 File Offset: 0x0001CD58
		[Token(Token = "0x6003E49")]
		[Address(RVA = "0x1E6B380", Offset = "0x1E6B380", VA = "0x1E6B380")]
		private static bool IsPositionInsideTile(Vector2 position, Point tileCoordinates, Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0001EB70 File Offset: 0x0001CD70
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x1E6ADD4", Offset = "0x1E6ADD4", VA = "0x1E6ADD4")]
		private static bool IsBallInWorld(Vector2 position, Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0001EB88 File Offset: 0x0001CD88
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x1E6AEF0", Offset = "0x1E6AEF0", VA = "0x1E6AEF0")]
		private static bool GetClosestEdgeToCircle(Vector2 position, Vector2 size, Vector2 velocity, out Vector2 collisionPoint, out Tile collisionTile)
		{
			return default(bool);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x1E6B810", Offset = "0x1E6B810", VA = "0x1E6B810")]
		private static bool GetCollisionPointForTile(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 center, ref Vector2 closestPointOut, ref float distanceSquaredOut)
		{
			return default(bool);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x1E6BFFC", Offset = "0x1E6BFFC", VA = "0x1E6BFFC")]
		private static bool GetSlopeEdge(ref BallCollision.TileEdges edgesToTest, Tile tile, Vector2 tilePosition, ref LineSegment edge)
		{
			return default(bool);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0x1E6C3CC", Offset = "0x1E6C3CC", VA = "0x1E6C3CC")]
		private static bool GetTopOrBottomEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
		{
			return default(bool);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x1E6CA48", Offset = "0x1E6CA48", VA = "0x1E6CA48")]
		private static bool GetLeftOrRightEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
		{
			return default(bool);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0001EC00 File Offset: 0x0001CE00
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x1E6B6A4", Offset = "0x1E6B6A4", VA = "0x1E6B6A4")]
		private static Rectangle GetTileBounds(Vector2 position, Vector2 size)
		{
			return default(Rectangle);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0001EC18 File Offset: 0x0001CE18
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x1E6D144", Offset = "0x1E6D144", VA = "0x1E6D144")]
		private static bool IsNeighborSolid(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x1E6C224", Offset = "0x1E6C224", VA = "0x1E6C224")]
		private static Vector2 ClosestPointOnLineSegment(Vector2 point, LineSegment lineSegment)
		{
			return default(Vector2);
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x1E6D358", Offset = "0x1E6D358", VA = "0x1E6D358")]
		private static void DrawEdge(LineSegment edge)
		{
		}

		// Token: 0x02000645 RID: 1605
		[Token(Token = "0x2000645")]
		private enum TileEdges : uint
		{
			// Token: 0x04004899 RID: 18585
			[Token(Token = "0x4004899")]
			None,
			// Token: 0x0400489A RID: 18586
			[Token(Token = "0x400489A")]
			Top,
			// Token: 0x0400489B RID: 18587
			[Token(Token = "0x400489B")]
			Bottom,
			// Token: 0x0400489C RID: 18588
			[Token(Token = "0x400489C")]
			Left = 4U,
			// Token: 0x0400489D RID: 18589
			[Token(Token = "0x400489D")]
			Right = 8U,
			// Token: 0x0400489E RID: 18590
			[Token(Token = "0x400489E")]
			TopLeftSlope = 16U,
			// Token: 0x0400489F RID: 18591
			[Token(Token = "0x400489F")]
			TopRightSlope = 32U,
			// Token: 0x040048A0 RID: 18592
			[Token(Token = "0x40048A0")]
			BottomLeftSlope = 64U,
			// Token: 0x040048A1 RID: 18593
			[Token(Token = "0x40048A1")]
			BottomRightSlope = 128U
		}
	}
}
