using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x2000794")]
	public struct Point16
	{
		// Token: 0x06004414 RID: 17428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x55855C", Offset = "0x55855C", VA = "0x55855C")]
		public Point16(Point point)
		{
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x558568", Offset = "0x558568", VA = "0x558568")]
		public Point16(int X, int Y)
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x558574", Offset = "0x558574", VA = "0x558574")]
		public Point16(short X, short Y)
		{
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00020A00 File Offset: 0x0001EC00
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x558580", Offset = "0x558580", VA = "0x558580")]
		public static Point16 Max(int firstX, int firstY, int secondX, int secondY)
		{
			return default(Point16);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00020A18 File Offset: 0x0001EC18
		[Token(Token = "0x6004418")]
		[Address(RVA = "0x558598", Offset = "0x558598", VA = "0x558598")]
		public Point16 Max(int compareX, int compareY)
		{
			return default(Point16);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x6004419")]
		[Address(RVA = "0x5585B8", Offset = "0x5585B8", VA = "0x5585B8")]
		public Point16 Max(Point16 compareTo)
		{
			return default(Point16);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x600441A")]
		[Address(RVA = "0x5585DC", Offset = "0x5585DC", VA = "0x5585DC")]
		public static bool operator ==(Point16 first, Point16 second)
		{
			return default(bool);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00020A60 File Offset: 0x0001EC60
		[Token(Token = "0x600441B")]
		[Address(RVA = "0x5585EC", Offset = "0x5585EC", VA = "0x5585EC")]
		public static bool operator !=(Point16 first, Point16 second)
		{
			return default(bool);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00020A78 File Offset: 0x0001EC78
		[Token(Token = "0x600441C")]
		[Address(RVA = "0x5585F8", Offset = "0x5585F8", VA = "0x5585F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00020A90 File Offset: 0x0001EC90
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x5586A8", Offset = "0x5586A8", VA = "0x5586A8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441E")]
		[Address(RVA = "0x5586B8", Offset = "0x5586B8", VA = "0x5586B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x558764", Offset = "0x558764", VA = "0x558764")]
		public static implicit operator Point(Point16 p)
		{
			return default(Point);
		}

		// Token: 0x04008BBC RID: 35772
		[Token(Token = "0x4008BBC")]
		[FieldOffset(Offset = "0x0")]
		public short X;

		// Token: 0x04008BBD RID: 35773
		[Token(Token = "0x4008BBD")]
		[FieldOffset(Offset = "0x2")]
		public short Y;

		// Token: 0x04008BBE RID: 35774
		[Token(Token = "0x4008BBE")]
		[FieldOffset(Offset = "0x0")]
		public static Point16 Zero;

		// Token: 0x04008BBF RID: 35775
		[Token(Token = "0x4008BBF")]
		[FieldOffset(Offset = "0x4")]
		public static Point16 NegativeOne;
	}
}
