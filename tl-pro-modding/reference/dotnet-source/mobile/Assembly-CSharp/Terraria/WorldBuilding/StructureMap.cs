using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	public class StructureMap
	{
		// Token: 0x06003B25 RID: 15141 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x1E0ADB8", Offset = "0x1E0ADB8", VA = "0x1E0ADB8")]
		public bool CanPlace(Rectangle area, int padding = 0)
		{
			return default(bool);
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x1E0B10C", Offset = "0x1E0B10C", VA = "0x1E0B10C")]
		public bool CanPlace(Rectangle area, bool[] validTiles, int padding = 0)
		{
			return default(bool);
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x1E0B690", Offset = "0x1E0B690", VA = "0x1E0B690")]
		public Rectangle GetBoundingBox()
		{
			return default(Rectangle);
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x1E0BCC0", Offset = "0x1E0BCC0", VA = "0x1E0BCC0")]
		public void AddStructure(Rectangle area, int padding = 0)
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x1E0AE58", Offset = "0x1E0AE58", VA = "0x1E0AE58")]
		public void AddProtectedStructure(Rectangle area, int padding = 0)
		{
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x1E0BEB8", Offset = "0x1E0BEB8", VA = "0x1E0BEB8")]
		public void Reset()
		{
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x1E0BFC8", Offset = "0x1E0BFC8", VA = "0x1E0BFC8")]
		public StructureMap()
		{
		}

		// Token: 0x040046F8 RID: 18168
		[Token(Token = "0x40046F8")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<Rectangle> _structures;

		// Token: 0x040046F9 RID: 18169
		[Token(Token = "0x40046F9")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<Rectangle> _protectedStructures;

		// Token: 0x040046FA RID: 18170
		[Token(Token = "0x40046FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _lock;

		// Token: 0x020005B8 RID: 1464
		[Token(Token = "0x20005B8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B2D RID: 15149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B2D")]
			[Address(RVA = "0x1E0C148", Offset = "0x1E0C148", VA = "0x1E0C148")]
			public <>c()
			{
			}

			// Token: 0x06003B2E RID: 15150 RVA: 0x0001DD00 File Offset: 0x0001BF00
			[Token(Token = "0x6003B2E")]
			[Address(RVA = "0x1E0C150", Offset = "0x1E0C150", VA = "0x1E0C150")]
			internal int <GetBoundingBox>b__5_0(Rectangle rect)
			{
				return 0;
			}

			// Token: 0x06003B2F RID: 15151 RVA: 0x0001DD18 File Offset: 0x0001BF18
			[Token(Token = "0x6003B2F")]
			[Address(RVA = "0x1E0C1B8", Offset = "0x1E0C1B8", VA = "0x1E0C1B8")]
			internal int <GetBoundingBox>b__5_1(Rectangle rect)
			{
				return 0;
			}

			// Token: 0x06003B30 RID: 15152 RVA: 0x0001DD30 File Offset: 0x0001BF30
			[Token(Token = "0x6003B30")]
			[Address(RVA = "0x1E0C220", Offset = "0x1E0C220", VA = "0x1E0C220")]
			internal int <GetBoundingBox>b__5_2(Rectangle rect)
			{
				return 0;
			}

			// Token: 0x06003B31 RID: 15153 RVA: 0x0001DD48 File Offset: 0x0001BF48
			[Token(Token = "0x6003B31")]
			[Address(RVA = "0x1E0C29C", Offset = "0x1E0C29C", VA = "0x1E0C29C")]
			internal int <GetBoundingBox>b__5_3(Rectangle rect)
			{
				return 0;
			}

			// Token: 0x040046FB RID: 18171
			[Token(Token = "0x40046FB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly StructureMap.<>c <>9;

			// Token: 0x040046FC RID: 18172
			[Token(Token = "0x40046FC")]
			[FieldOffset(Offset = "0x4")]
			public static Func<Rectangle, int> <>9__5_0;

			// Token: 0x040046FD RID: 18173
			[Token(Token = "0x40046FD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Rectangle, int> <>9__5_1;

			// Token: 0x040046FE RID: 18174
			[Token(Token = "0x40046FE")]
			[FieldOffset(Offset = "0xC")]
			public static Func<Rectangle, int> <>9__5_2;

			// Token: 0x040046FF RID: 18175
			[Token(Token = "0x40046FF")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Rectangle, int> <>9__5_3;
		}
	}
}
