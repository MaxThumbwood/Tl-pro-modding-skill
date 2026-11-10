using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x20005C3")]
	public static class WorldUtils
	{
		// Token: 0x06003B6E RID: 15214 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x1E109E0", Offset = "0x1E109E0", VA = "0x1E109E0")]
		public static Rectangle ClampToWorld(Rectangle tileRectangle, int fluff = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x1E10BC0", Offset = "0x1E10BC0", VA = "0x1E10BC0")]
		public static Rectangle GetWorldPlayArea()
		{
			return default(Rectangle);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x1E10D54", Offset = "0x1E10D54", VA = "0x1E10D54")]
		public static Rectangle ClampToWorldBorders(Rectangle worldRect)
		{
			return default(Rectangle);
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x0001DF10 File Offset: 0x0001C110
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x1E10E10", Offset = "0x1E10E10", VA = "0x1E10E10")]
		public static bool Gen(Point origin, GenShape shape, GenAction action)
		{
			return default(bool);
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x0001DF28 File Offset: 0x0001C128
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x1E10E60", Offset = "0x1E10E60", VA = "0x1E10E60")]
		public static bool Gen(Point origin, GenShapeActionPair pair)
		{
			return default(bool);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0001DF40 File Offset: 0x0001C140
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x1E10EB0", Offset = "0x1E10EB0", VA = "0x1E10EB0")]
		public static bool Find(Point origin, GenSearch search, out Point result)
		{
			return default(bool);
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x1DFCAD4", Offset = "0x1DFCAD4", VA = "0x1DFCAD4")]
		public static void ClearTile(int x, int y, bool frameNeighbors = false)
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x1DFCD70", Offset = "0x1DFCD70", VA = "0x1DFCD70")]
		public static void ClearWall(int x, int y, bool frameNeighbors = false)
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x1DFD40C", Offset = "0x1DFD40C", VA = "0x1DFD40C")]
		public static void TileFrame(int x, int y, bool frameNeighbors = false)
		{
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x1DFD768", Offset = "0x1DFD768", VA = "0x1DFD768")]
		public static void WallFrame(int x, int y, bool frameNeighbors = false)
		{
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x1E10FBC", Offset = "0x1E10FBC", VA = "0x1E10FBC")]
		public static void ClearChestLocation(int x, int y)
		{
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x1E1100C", Offset = "0x1E1100C", VA = "0x1E1100C")]
		public static void WireLine(Point start, Point end)
		{
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x1E111DC", Offset = "0x1E111DC", VA = "0x1E111DC")]
		public static void DebugRegen()
		{
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x1E112B8", Offset = "0x1E112B8", VA = "0x1E112B8")]
		public static void DebugRotate()
		{
		}
	}
}
