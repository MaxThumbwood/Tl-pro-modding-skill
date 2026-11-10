using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	public class Collision
	{
		// Token: 0x06002EF5 RID: 12021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF5")]
		[Address(RVA = "0x185E028", Offset = "0x185E028", VA = "0x185E028")]
		public static Vector2[] CheckLinevLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			return null;
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000167D0 File Offset: 0x000149D0
		[Token(Token = "0x6002EF6")]
		[Address(RVA = "0x185EA04", Offset = "0x185EA04", VA = "0x185EA04")]
		private static double DistFromSeg(Vector2 p, Vector2 q0, Vector2 q1, double radius, ref float u)
		{
			return 0.0;
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000167E8 File Offset: 0x000149E8
		[Token(Token = "0x6002EF7")]
		[Address(RVA = "0x185E67C", Offset = "0x185E67C", VA = "0x185E67C")]
		private static bool PointOnLine(Vector2 p, Vector2 a1, Vector2 a2)
		{
			return default(bool);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF8")]
		[Address(RVA = "0x185E734", Offset = "0x185E734", VA = "0x185E734")]
		private static Vector2[] OneDimensionalIntersection(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			return null;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF9")]
		[Address(RVA = "0x185EB98", Offset = "0x185EB98", VA = "0x185EB98")]
		private static float[] FindOverlapPoints(float relativePoint1, float relativePoint2)
		{
			return null;
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00016800 File Offset: 0x00014A00
		[Token(Token = "0x6002EFA")]
		[Address(RVA = "0x185ECF0", Offset = "0x185ECF0", VA = "0x185ECF0")]
		public static bool CheckAABBvAABBCollision(Vector2 position1, Vector2 dimensions1, Vector2 position2, Vector2 dimensions2)
		{
			return default(bool);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00016818 File Offset: 0x00014A18
		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x185ED70", Offset = "0x185ED70", VA = "0x185ED70")]
		private static int collisionOutcode(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 point)
		{
			return 0;
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00016830 File Offset: 0x00014A30
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x185EE0C", Offset = "0x185EE0C", VA = "0x185EE0C")]
		public static bool CheckAABBvLineCollision(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00016848 File Offset: 0x00014A48
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x185F058", Offset = "0x185F058", VA = "0x185F058")]
		public static bool CheckAABBvLineCollision2(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00016860 File Offset: 0x00014A60
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x185F1E8", Offset = "0x185F1E8", VA = "0x185F1E8")]
		public static bool CheckAABBvLineCollision(Vector2 objectPosition, Vector2 objectDimensions, Vector2 lineStart, Vector2 lineEnd, float lineWidth, ref float collisionPoint)
		{
			return default(bool);
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00016878 File Offset: 0x00014A78
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x185FA80", Offset = "0x185FA80", VA = "0x185FA80")]
		public static bool CanHit(Entity source, Entity target)
		{
			return default(bool);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00016890 File Offset: 0x00014A90
		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x185FC94", Offset = "0x185FC94", VA = "0x185FC94")]
		public static bool CanHit(Entity source, NPCAimedTarget target)
		{
			return default(bool);
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x185FB8C", Offset = "0x185FB8C", VA = "0x185FB8C")]
		public static bool CanHit(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2)
		{
			return default(bool);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x185FD68", Offset = "0x185FD68", VA = "0x185FD68")]
		public static bool CanHit(Point Position1, int Width1, int Height1, Point Position2, int Width2, int Height2)
		{
			return default(bool);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000168D8 File Offset: 0x00014AD8
		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x18603CC", Offset = "0x18603CC", VA = "0x18603CC")]
		public static bool CanHitWithCheck(Entity source, Entity target, Utils.TileActionAttempt check)
		{
			return default(bool);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x186303C", Offset = "0x186303C", VA = "0x186303C")]
		public static bool CanHit(Entity source, NPCAimedTarget target, Utils.TileActionAttempt check)
		{
			return default(bool);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x18604DC", Offset = "0x18604DC", VA = "0x18604DC")]
		public static bool CanHitWithCheck(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2, Utils.TileActionAttempt check)
		{
			return default(bool);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00016920 File Offset: 0x00014B20
		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x1863114", Offset = "0x1863114", VA = "0x1863114")]
		public static bool CanHitLine(ref Vector2 Position1, int Width1, int Height1, ref Vector2 Position2, int Width2, int Height2)
		{
			return default(bool);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00016938 File Offset: 0x00014B38
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x1863B94", Offset = "0x1863B94", VA = "0x1863B94")]
		public static bool CanHitLine(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2)
		{
			return default(bool);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00016950 File Offset: 0x00014B50
		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x186461C", Offset = "0x186461C", VA = "0x186461C")]
		public static bool HitLine(int x1, int y1, int x2, int y2, int ignoreX, int ignoreY, List<Point> ignoreTargets, out int colX, out int colY)
		{
			return default(bool);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00016968 File Offset: 0x00014B68
		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x1865350", Offset = "0x1865350", VA = "0x1865350")]
		public static bool AnyWallOfTypeOnLine(int x1, int y1, int x2, int y2, ushort wallId)
		{
			return default(bool);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00016980 File Offset: 0x00014B80
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x1865A08", Offset = "0x1865A08", VA = "0x1865A08")]
		public static bool HitSpecificWallSubstep(int x, int y, ushort wallId)
		{
			return default(bool);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x1865B3C", Offset = "0x1865B3C", VA = "0x1865B3C")]
		public static void TupleHitLineWall(int x1, int y1, int x2, int y2, out int resX, out int resY)
		{
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x6002F0C")]
		[Address(RVA = "0x1866314", Offset = "0x1866314", VA = "0x1866314")]
		public static bool HitWallSubstep(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000169B0 File Offset: 0x00014BB0
		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x1866A1C", Offset = "0x1866A1C", VA = "0x1866A1C")]
		public static bool EmptyTile(int i, int j, bool ignoreTiles = false)
		{
			return default(bool);
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000169C8 File Offset: 0x00014BC8
		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x1867048", Offset = "0x1867048", VA = "0x1867048")]
		public static bool DrownCollision(Vector2 Position, int Width, int Height, float gravDir = -1f, bool includeSlopes = false)
		{
			return default(bool);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000169E0 File Offset: 0x00014BE0
		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x1867758", Offset = "0x1867758", VA = "0x1867758")]
		public static bool IsWorldPointSolid(Vector2 pos, bool treatPlatformsAsNonSolid = false)
		{
			return default(bool);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000169F8 File Offset: 0x00014BF8
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x1868018", Offset = "0x1868018", VA = "0x1868018")]
		public static bool GetWaterLine(Point pt, out float waterLineHeight)
		{
			return default(bool);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00016A10 File Offset: 0x00014C10
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x186808C", Offset = "0x186808C", VA = "0x186808C")]
		public static bool GetWaterLine(int X, int Y, out float waterLineHeight)
		{
			return default(bool);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00016A28 File Offset: 0x00014C28
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x1868580", Offset = "0x1868580", VA = "0x1868580")]
		public static bool GetWaterLineIterate(Point pt, out float waterLineHeight)
		{
			return default(bool);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x18685F4", Offset = "0x18685F4", VA = "0x18685F4")]
		public static bool GetWaterLineIterate(int X, int Y, out float waterLineHeight)
		{
			return default(bool);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00016A58 File Offset: 0x00014C58
		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x18688D4", Offset = "0x18688D4", VA = "0x18688D4")]
		public static bool WetCollision(Vector2 Position, int Width, int Height)
		{
			return default(bool);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x18690D8", Offset = "0x18690D8", VA = "0x18690D8")]
		public static bool LavaCollision(Vector2 Position, int Width, int Height)
		{
			return default(bool);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00016A88 File Offset: 0x00014C88
		[Token(Token = "0x6002F16")]
		[Address(RVA = "0x18694F4", Offset = "0x18694F4", VA = "0x18694F4")]
		public static Vector4 WalkDownSlope(Vector2 Position, Vector2 Velocity, int Width, int Height, float gravity = 0f)
		{
			return default(Vector4);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00016AA0 File Offset: 0x00014CA0
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x1869B14", Offset = "0x1869B14", VA = "0x1869B14")]
		public static Vector4 SlopeCollision(Vector2 oldPosition, Vector2 oldVelocity, int Width, int Height, float gravity = 0f, bool fall = false, bool ignoreAetheriumPlatforms = false)
		{
			return default(Vector4);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x186B690", Offset = "0x186B690", VA = "0x186B690")]
		public static Vector2 noSlopeCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false)
		{
			return default(Vector2);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x186C414", Offset = "0x186C414", VA = "0x186C414")]
		public static void BuildTileContacts(Vector2 Position, int Width, int Height, List<Collision.TileContact> contactTiles)
		{
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00016AD0 File Offset: 0x00014CD0
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x186AA20", Offset = "0x186AA20", VA = "0x186AA20")]
		public static Vector2 TileCollision(Vector2 oldPosition, Vector2 oldVelocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1, bool ignoreDoors = false, bool ignoreAetheriumPlatforms = false, bool hoik = true)
		{
			return default(Vector2);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x186D97C", Offset = "0x186D97C", VA = "0x186D97C")]
		public static float TileCollisionInStepsOf16(Vector2 Position, Vector2 normalizedDirection, float amount, int Width, int Height)
		{
			return 0f;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00016B00 File Offset: 0x00014D00
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x186E110", Offset = "0x186E110", VA = "0x186E110")]
		public static bool TryChangingSizeFromBottomCenter(Rectangle hitbox, int targetWidth, int targetHeight, out Rectangle changedHitbox)
		{
			return default(bool);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00016B18 File Offset: 0x00014D18
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x186E7E8", Offset = "0x186E7E8", VA = "0x186E7E8")]
		public static bool IsClearSpotTest(Vector2 position, float testMagnitude, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1, bool checkCardinals = true, bool checkSlopes = false)
		{
			return default(bool);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x186F30C", Offset = "0x186F30C", VA = "0x186F30C")]
		public static List<Point> FindCollisionTile(int Direction, Vector2 position, float testMagnitude, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1, bool checkCardinals = true, bool checkSlopes = false)
		{
			return null;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00016B30 File Offset: 0x00014D30
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x1870F44", Offset = "0x1870F44", VA = "0x1870F44")]
		public static bool FindCollisionDirection(out int Direction, Vector2 position, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
		{
			return default(bool);
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00016B48 File Offset: 0x00014D48
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x187150C", Offset = "0x187150C", VA = "0x187150C")]
		public static bool SolidCollision(Vector2 Position, int Width, int Height)
		{
			return default(bool);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00016B60 File Offset: 0x00014D60
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x187197C", Offset = "0x187197C", VA = "0x187197C")]
		public static bool SolidCollision2(Vector2 Position, int Width, int Height, bool acceptTopSurfaces)
		{
			return default(bool);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00016B78 File Offset: 0x00014D78
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x1871E80", Offset = "0x1871E80", VA = "0x1871E80")]
		public static bool SolidCollision(Vector2 Position, int Width, int Height, bool acceptTopSurfaces)
		{
			return default(bool);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00016B90 File Offset: 0x00014D90
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x18723F8", Offset = "0x18723F8", VA = "0x18723F8")]
		public static Vector2 WaterCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, bool lavaWalk = true)
		{
			return default(Vector2);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00016BA8 File Offset: 0x00014DA8
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x1872A34", Offset = "0x1872A34", VA = "0x1872A34")]
		public static Vector2 AnyCollisionWithSpecificTiles(Vector2 Position, Vector2 Velocity, int Width, int Height, bool[] tilesWeCanCollideWithByType, bool evenActuated = false)
		{
			return default(Vector2);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x1873390", Offset = "0x1873390", VA = "0x1873390")]
		public static Vector2 AnyCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool evenActuated = false)
		{
			return default(Vector2);
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x1873D14", Offset = "0x1873D14", VA = "0x1873D14")]
		public static void HitTilesInACircle(Vector2 Position, Vector2 Velocity, int Width, int Height)
		{
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x18746C4", Offset = "0x18746C4", VA = "0x18746C4")]
		public static void HitTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00016BD8 File Offset: 0x00014DD8
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x1874F78", Offset = "0x1874F78", VA = "0x1874F78")]
		public static bool AnyHurtingTiles(Vector2 Position, int Width, int Height)
		{
			return default(bool);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00016BF0 File Offset: 0x00014DF0
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x1875014", Offset = "0x1875014", VA = "0x1875014")]
		public static Collision.HurtTile HurtTiles(Vector2 Position, int Width, int Height, Player player)
		{
			return default(Collision.HurtTile);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00016C08 File Offset: 0x00014E08
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x1875910", Offset = "0x1875910", VA = "0x1875910")]
		public static bool CanTileHurt(ushort type, int i, int j, Player player)
		{
			return default(bool);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00016C20 File Offset: 0x00014E20
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x1875AF8", Offset = "0x1875AF8", VA = "0x1875AF8")]
		public static bool SwitchTiles(Entity entity, Vector2 Position, int Width, int Height, Vector2 oldPosition, int objType)
		{
			return default(bool);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00016C38 File Offset: 0x00014E38
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x1876580", Offset = "0x1876580", VA = "0x1876580")]
		public static Vector2 StickyTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
		{
			return default(Vector2);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00016C50 File Offset: 0x00014E50
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x1876FB8", Offset = "0x1876FB8", VA = "0x1876FB8")]
		public static bool SolidTilesVersatile(int startX, int endX, int startY, int endY)
		{
			return default(bool);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00016C68 File Offset: 0x00014E68
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x18776CC", Offset = "0x18776CC", VA = "0x18776CC")]
		public static bool SolidTiles(Vector2 position, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00016C80 File Offset: 0x00014E80
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x1877120", Offset = "0x1877120", VA = "0x1877120")]
		public static bool SolidTiles(int startX, int endX, int startY, int endY)
		{
			return default(bool);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00016C98 File Offset: 0x00014E98
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x18777D8", Offset = "0x18777D8", VA = "0x18777D8")]
		public static bool SolidTiles(Vector2 position, int width, int height, bool allowTopSurfaces)
		{
			return default(bool);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x18778EC", Offset = "0x18778EC", VA = "0x18778EC")]
		public static bool SolidTiles(int startX, int endX, int startY, int endY, bool allowTopSurfaces)
		{
			return default(bool);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x1877E34", Offset = "0x1877E34", VA = "0x1877E34")]
		public static bool SolidFullTiles(Vector2 pos, Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x18782AC", Offset = "0x18782AC", VA = "0x18782AC")]
		public static void StepDown(ref Vector2 position, ref Vector2 velocity, int width, int height, ref float stepSpeed, ref float gfxOffY, int gravDir = 1, bool waterWalk = false)
		{
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x1878830", Offset = "0x1878830", VA = "0x1878830")]
		public static void StepUp(ref Vector2 position, ref Vector2 velocity, int width, int height, ref float stepSpeed, ref float gfxOffY, int gravDir = 1, bool holdsMatching = false, int specialChecksMode = 0)
		{
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x1879764", Offset = "0x1879764", VA = "0x1879764")]
		public static bool InTileBounds(int x, int y, int lx, int ly, int hx, int hy)
		{
			return default(bool);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x1879798", Offset = "0x1879798", VA = "0x1879798")]
		public static float GetTileRotation(Vector2 position)
		{
			return 0f;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x1879E70", Offset = "0x1879E70", VA = "0x1879E70")]
		public static void GetEntityEdgeTopBottom(Entity entity, out int sx, out int ex, out int sy, out int ey)
		{
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x1879FE0", Offset = "0x1879FE0", VA = "0x1879FE0")]
		public static void GetEntityEdgeTilesExtents(Entity entity, out int minX, out int minY, out int maxX, out int maxY)
		{
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x187A138", Offset = "0x187A138", VA = "0x187A138")]
		public static void GetEntityEdgeTiles(List<Point> p, Entity entity, bool left = true, bool right = true, bool up = true, bool down = true)
		{
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00016D10 File Offset: 0x00014F10
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x187A5D0", Offset = "0x187A5D0", VA = "0x187A5D0")]
		public static bool ApplyConveyorBeltMovementToVelocity(WorldItem item, ref Vector2 velocity)
		{
			return default(bool);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x187C0CC", Offset = "0x187C0CC", VA = "0x187C0CC")]
		public static void StepConveyorBelt(Entity entity, float gravDir, bool artificialRising = false)
		{
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00016D28 File Offset: 0x00014F28
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x187CA04", Offset = "0x187CA04", VA = "0x187CA04")]
		public static bool TryFindingConveyorBeltRising(Entity entity, float gravDir)
		{
			return default(bool);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x187D208", Offset = "0x187D208", VA = "0x187D208")]
		public static void GetTilesIn(Vector2 TopLeft, Vector2 BottomRight, List<Point> p)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x187D508", Offset = "0x187D508", VA = "0x187D508")]
		public static void ExpandVertically(int startX, int startY, out int topY, out int bottomY, int maxExpandUp = 100, int maxExpandDown = 100)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00016D40 File Offset: 0x00014F40
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x187D8FC", Offset = "0x187D8FC", VA = "0x187D8FC")]
		public static Vector2 AdvancedTileCollision(bool[] forcedIgnoredTiles, Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
		{
			return default(Vector2);
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x187EEEC", Offset = "0x187EEEC", VA = "0x187EEEC")]
		public static void LaserScan(Vector2 samplingPoint, Vector2 directionUnit, float samplingWidth, float maxDistance, float[] samples)
		{
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x187F398", Offset = "0x187F398", VA = "0x187F398")]
		public static void AimingLaserScan(Vector2 startPoint, Vector2 endPoint, float samplingWidth, int samplesToTake, out Vector2 vectorTowardsTarget, out float[] samples)
		{
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x187F598", Offset = "0x187F598", VA = "0x187F598")]
		public Collision()
		{
		}

		// Token: 0x04003EE8 RID: 16104
		[Token(Token = "0x4003EE8")]
		[FieldOffset(Offset = "0x0")]
		public static bool stair;

		// Token: 0x04003EE9 RID: 16105
		[Token(Token = "0x4003EE9")]
		[FieldOffset(Offset = "0x1")]
		public static bool stairFall;

		// Token: 0x04003EEA RID: 16106
		[Token(Token = "0x4003EEA")]
		[FieldOffset(Offset = "0x2")]
		public static bool honey;

		// Token: 0x04003EEB RID: 16107
		[Token(Token = "0x4003EEB")]
		[FieldOffset(Offset = "0x3")]
		public static bool shimmer;

		// Token: 0x04003EEC RID: 16108
		[Token(Token = "0x4003EEC")]
		[FieldOffset(Offset = "0x4")]
		public static bool sloping;

		// Token: 0x04003EED RID: 16109
		[Token(Token = "0x4003EED")]
		[FieldOffset(Offset = "0x5")]
		public static bool landMine;

		// Token: 0x04003EEE RID: 16110
		[Token(Token = "0x4003EEE")]
		[FieldOffset(Offset = "0x6")]
		public static bool up;

		// Token: 0x04003EEF RID: 16111
		[Token(Token = "0x4003EEF")]
		[FieldOffset(Offset = "0x7")]
		public static bool down;

		// Token: 0x04003EF0 RID: 16112
		[Token(Token = "0x4003EF0")]
		[FieldOffset(Offset = "0x8")]
		public static float Epsilon;

		// Token: 0x04003EF1 RID: 16113
		[Token(Token = "0x4003EF1")]
		private const int bottomFluff = 40;

		// Token: 0x04003EF2 RID: 16114
		[Token(Token = "0x4003EF2")]
		[FieldOffset(Offset = "0xC")]
		private static bool[] cSlopes;

		// Token: 0x04003EF3 RID: 16115
		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0x10")]
		private static List<Point> EntityEdgeTiles;

		// Token: 0x04003EF4 RID: 16116
		[Token(Token = "0x4003EF4")]
		[FieldOffset(Offset = "0x14")]
		private static List<Collision.TileContact> contacts;

		// Token: 0x04003EF5 RID: 16117
		[Token(Token = "0x4003EF5")]
		[FieldOffset(Offset = "0x18")]
		private static List<Point> _cacheForConveyorBelts;

		// Token: 0x04003EF6 RID: 16118
		[Token(Token = "0x4003EF6")]
		[FieldOffset(Offset = "0x1C")]
		private static List<int> dummyLaserScanList;

		// Token: 0x020004B4 RID: 1204
		[Token(Token = "0x20004B4")]
		public enum TileContactSide
		{
			// Token: 0x04003EF8 RID: 16120
			[Token(Token = "0x4003EF8")]
			Left,
			// Token: 0x04003EF9 RID: 16121
			[Token(Token = "0x4003EF9")]
			Right,
			// Token: 0x04003EFA RID: 16122
			[Token(Token = "0x4003EFA")]
			Top,
			// Token: 0x04003EFB RID: 16123
			[Token(Token = "0x4003EFB")]
			Bottom,
			// Token: 0x04003EFC RID: 16124
			[Token(Token = "0x4003EFC")]
			BottomLeft,
			// Token: 0x04003EFD RID: 16125
			[Token(Token = "0x4003EFD")]
			BottomRight
		}

		// Token: 0x020004B5 RID: 1205
		[Token(Token = "0x20004B5")]
		public struct TileContact
		{
			// Token: 0x06002F44 RID: 12100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F44")]
			[Address(RVA = "0x188EDA8", Offset = "0x188EDA8", VA = "0x188EDA8")]
			public TileContact(Collision.TileContactSide side, int x, int y, int type, int slope, int overlap)
			{
			}

			// Token: 0x04003EFE RID: 16126
			[Token(Token = "0x4003EFE")]
			[FieldOffset(Offset = "0x0")]
			public Collision.TileContactSide Side;

			// Token: 0x04003EFF RID: 16127
			[Token(Token = "0x4003EFF")]
			[FieldOffset(Offset = "0x4")]
			public int Overlap;

			// Token: 0x04003F00 RID: 16128
			[Token(Token = "0x4003F00")]
			[FieldOffset(Offset = "0x8")]
			public int X;

			// Token: 0x04003F01 RID: 16129
			[Token(Token = "0x4003F01")]
			[FieldOffset(Offset = "0xC")]
			public int Y;

			// Token: 0x04003F02 RID: 16130
			[Token(Token = "0x4003F02")]
			[FieldOffset(Offset = "0x10")]
			public int Slope;

			// Token: 0x04003F03 RID: 16131
			[Token(Token = "0x4003F03")]
			[FieldOffset(Offset = "0x14")]
			public int Type;
		}

		// Token: 0x020004B6 RID: 1206
		[Token(Token = "0x20004B6")]
		public struct HurtTile
		{
			// Token: 0x04003F04 RID: 16132
			[Token(Token = "0x4003F04")]
			[FieldOffset(Offset = "0x0")]
			public int type;

			// Token: 0x04003F05 RID: 16133
			[Token(Token = "0x4003F05")]
			[FieldOffset(Offset = "0x4")]
			public int x;

			// Token: 0x04003F06 RID: 16134
			[Token(Token = "0x4003F06")]
			[FieldOffset(Offset = "0x8")]
			public int y;
		}
	}
}
