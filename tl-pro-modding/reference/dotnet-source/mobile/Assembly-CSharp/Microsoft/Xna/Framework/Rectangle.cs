using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	public struct Rectangle
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x1700022F")]
		public Point Center
		{
			[Token(Token = "0x6001724")]
			[Address(RVA = "0xE1750C", Offset = "0xE1750C", VA = "0xE1750C")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0000A980 File Offset: 0x00008B80
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000230")]
		public Point Location
		{
			[Token(Token = "0x6001725")]
			[Address(RVA = "0xE17538", Offset = "0xE17538", VA = "0xE17538")]
			get
			{
				return default(Point);
			}
			[Token(Token = "0x6001726")]
			[Address(RVA = "0xE1754C", Offset = "0xE1754C", VA = "0xE1754C")]
			set
			{
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x17000231")]
		public bool IsEmpty
		{
			[Token(Token = "0x6001727")]
			[Address(RVA = "0xE17554", Offset = "0xE17554", VA = "0xE17554")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x17000232")]
		public static Rectangle Empty
		{
			[Token(Token = "0x6001728")]
			[Address(RVA = "0xE1758C", Offset = "0xE1758C", VA = "0xE1758C")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x17000233")]
		public int Left
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0xE175F8", Offset = "0xE175F8", VA = "0xE175F8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x17000234")]
		public int Right
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0xE17600", Offset = "0xE17600", VA = "0xE17600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x17000235")]
		public int Top
		{
			[Token(Token = "0x600172B")]
			[Address(RVA = "0xE17610", Offset = "0xE17610", VA = "0xE17610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x17000236")]
		public int Bottom
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0xE17618", Offset = "0xE17618", VA = "0xE17618")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172D")]
		[Address(RVA = "0xE17628", Offset = "0xE17628", VA = "0xE17628")]
		public Rectangle(int x, int y, int width, int height)
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x600172E")]
		[Address(RVA = "0xE17634", Offset = "0xE17634", VA = "0xE17634")]
		public static Rectangle Union(Rectangle value1, Rectangle value2)
		{
			return default(Rectangle);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172F")]
		[Address(RVA = "0xE1774C", Offset = "0xE1774C", VA = "0xE1774C")]
		public static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x6001730")]
		[Address(RVA = "0xE17868", Offset = "0xE17868", VA = "0xE17868")]
		public static Rectangle Intersect(Rectangle value1, Rectangle value2)
		{
			return default(Rectangle);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001731")]
		[Address(RVA = "0xE17AAC", Offset = "0xE17AAC", VA = "0xE17AAC")]
		public void Intersects(ref Rectangle value, out bool result)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001732")]
		[Address(RVA = "0xE17B10", Offset = "0xE17B10", VA = "0xE17B10")]
		public void RoundedIntersectsCircle(int centreX, int centreY, int radius, int roundedRadius, out bool result)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x6001733")]
		[Address(RVA = "0xE17C0C", Offset = "0xE17C0C", VA = "0xE17C0C")]
		public bool Contains(Point value)
		{
			return default(bool);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x6001734")]
		[Address(RVA = "0xE17C58", Offset = "0xE17C58", VA = "0xE17C58")]
		public bool Contains(Rectangle value)
		{
			return default(bool);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001735")]
		[Address(RVA = "0xE17CB0", Offset = "0xE17CB0", VA = "0xE17CB0")]
		public void Contains(ref Rectangle value, out bool result)
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x6001736")]
		[Address(RVA = "0xE17D14", Offset = "0xE17D14", VA = "0xE17D14")]
		public bool Contains(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001737")]
		[Address(RVA = "0xE17D60", Offset = "0xE17D60", VA = "0xE17D60")]
		public void Contains(ref Point value, out bool result)
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001738")]
		[Address(RVA = "0xE17920", Offset = "0xE17920", VA = "0xE17920")]
		public static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x6001739")]
		[Address(RVA = "0xE17E24", Offset = "0xE17E24", VA = "0xE17E24")]
		public static bool operator ==(Rectangle a, Rectangle b)
		{
			return default(bool);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x600173A")]
		[Address(RVA = "0xE17E60", Offset = "0xE17E60", VA = "0xE17E60")]
		public static bool operator !=(Rectangle a, Rectangle b)
		{
			return default(bool);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173B")]
		[Address(RVA = "0xE17EFC", Offset = "0xE17EFC", VA = "0xE17EFC")]
		public void Offset(Point offset)
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173C")]
		[Address(RVA = "0xE17F10", Offset = "0xE17F10", VA = "0xE17F10")]
		public void Offset(int offsetX, int offsetY)
		{
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173D")]
		[Address(RVA = "0xE17F24", Offset = "0xE17F24", VA = "0xE17F24")]
		public void Inflate(int horizontalValue, int verticalValue)
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x600173E")]
		[Address(RVA = "0xE17DB4", Offset = "0xE17DB4", VA = "0xE17DB4")]
		public bool Intersects(Rectangle rect)
		{
			return default(bool);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x600173F")]
		[Address(RVA = "0xE17F50", Offset = "0xE17F50", VA = "0xE17F50")]
		public bool Equals(Rectangle other)
		{
			return default(bool);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x6001740")]
		[Address(RVA = "0xE17FE4", Offset = "0xE17FE4", VA = "0xE17FE4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001741")]
		[Address(RVA = "0xE180D8", Offset = "0xE180D8", VA = "0xE180D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x6001742")]
		[Address(RVA = "0xE18300", Offset = "0xE18300", VA = "0xE18300", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		[FieldOffset(Offset = "0x0")]
		private static Rectangle emptyRectangle;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		[FieldOffset(Offset = "0x0")]
		public int X;

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x4")]
		public int Y;

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x8")]
		public int Width;

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0xC")]
		public int Height;
	}
}
