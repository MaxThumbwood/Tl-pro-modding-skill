using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Utilities
{
	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x20005C6")]
	public class BitSet2D
	{
		// Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x1E11768", Offset = "0x1E11768", VA = "0x1E11768")]
		public void Reset(Point center, int maxDist)
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x1E11854", Offset = "0x1E11854", VA = "0x1E11854")]
		private int Coord(Point p)
		{
			return 0;
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x1E11870", Offset = "0x1E11870", VA = "0x1E11870")]
		public bool InBounds(Point p)
		{
			return default(bool);
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x0001E000 File Offset: 0x0001C200
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000788")]
		public bool Item
		{
			[Token(Token = "0x6003B8A")]
			[Address(RVA = "0x1E118B8", Offset = "0x1E118B8", VA = "0x1E118B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B8B")]
			[Address(RVA = "0x1E11928", Offset = "0x1E11928", VA = "0x1E11928")]
			set
			{
			}
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x0001E018 File Offset: 0x0001C218
		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x1E119A8", Offset = "0x1E119A8", VA = "0x1E119A8")]
		public bool Add(Point p)
		{
			return default(bool);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x0001E030 File Offset: 0x0001C230
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x1E11A4C", Offset = "0x1E11A4C", VA = "0x1E11A4C")]
		public bool Remove(Point p)
		{
			return default(bool);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x1E11AF0", Offset = "0x1E11AF0", VA = "0x1E11AF0")]
		public BitSet2D()
		{
		}

		// Token: 0x04004730 RID: 18224
		[Token(Token = "0x4004730")]
		[FieldOffset(Offset = "0x8")]
		private Point offset;

		// Token: 0x04004731 RID: 18225
		[Token(Token = "0x4004731")]
		[FieldOffset(Offset = "0x10")]
		private int size;

		// Token: 0x04004732 RID: 18226
		[Token(Token = "0x4004732")]
		[FieldOffset(Offset = "0x14")]
		private Bits64[] bits;
	}
}
