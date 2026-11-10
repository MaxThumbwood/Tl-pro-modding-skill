using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B5 RID: 1461
	[Token(Token = "0x20005B5")]
	public class ShapeData
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[Token(Token = "0x17000773")]
		public int Count
		{
			[Token(Token = "0x6003B10")]
			[Address(RVA = "0x1E09DD0", Offset = "0x1E09DD0", VA = "0x1E09DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x1E09E28", Offset = "0x1E09E28", VA = "0x1E09E28")]
		public ShapeData()
		{
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x1E09EC0", Offset = "0x1E09EC0", VA = "0x1E09EC0")]
		public ShapeData(ShapeData original)
		{
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x1DFBA18", Offset = "0x1DFBA18", VA = "0x1DFBA18")]
		public void Add(int x, int y)
		{
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x1E09F70", Offset = "0x1E09F70", VA = "0x1E09F70")]
		public void AddBounds(int minX, int minY, int maxX, int maxY)
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x1E09FD0", Offset = "0x1E09FD0", VA = "0x1E09FD0")]
		public void Remove(int x, int y)
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x1E0A0E0", Offset = "0x1E0A0E0", VA = "0x1E0A0E0")]
		public void RemoveBounds(int minX, int minY, int maxX, int maxY)
		{
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x1E0A140", Offset = "0x1E0A140", VA = "0x1E0A140")]
		public HashSet<Point16> GetData()
		{
			return null;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x1E0A148", Offset = "0x1E0A148", VA = "0x1E0A148")]
		public void Clear()
		{
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x1E025C0", Offset = "0x1E025C0", VA = "0x1E025C0")]
		public bool Contains(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x1E0A1AC", Offset = "0x1E0A1AC", VA = "0x1E0A1AC")]
		public void Add(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x1E0A36C", Offset = "0x1E0A36C", VA = "0x1E0A36C")]
		public void Subtract(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
		{
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x0001DC58 File Offset: 0x0001BE58
		[Token(Token = "0x6003B1C")]
		[Address(RVA = "0x1E0A52C", Offset = "0x1E0A52C", VA = "0x1E0A52C")]
		public static Rectangle GetBounds(Point origin, ShapeData[] shapes)
		{
			return default(Rectangle);
		}

		// Token: 0x040046F1 RID: 18161
		[Token(Token = "0x40046F1")]
		[FieldOffset(Offset = "0x8")]
		private HashSet<Point16> _points;
	}
}
