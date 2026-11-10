using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	public class GenBase
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000757")]
		protected static UnifiedRandom _random
		{
			[Token(Token = "0x6003A3C")]
			[Address(RVA = "0x1E00404", Offset = "0x1E00404", VA = "0x1E00404")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000758")]
		protected static TileData _tiles
		{
			[Token(Token = "0x6003A3D")]
			[Address(RVA = "0x1E004B8", Offset = "0x1E004B8", VA = "0x1E004B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x0001D538 File Offset: 0x0001B738
		[Token(Token = "0x17000759")]
		protected static int _worldWidth
		{
			[Token(Token = "0x6003A3E")]
			[Address(RVA = "0x1E0051C", Offset = "0x1E0051C", VA = "0x1E0051C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x0001D550 File Offset: 0x0001B750
		[Token(Token = "0x1700075A")]
		protected static int _worldHeight
		{
			[Token(Token = "0x6003A3F")]
			[Address(RVA = "0x1E00580", Offset = "0x1E00580", VA = "0x1E00580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x1DFBB5C", Offset = "0x1DFBB5C", VA = "0x1DFBB5C")]
		public GenBase()
		{
		}

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x06003A42 RID: 14914
		[Token(Token = "0x200056B")]
		public delegate bool CustomPerUnitAction(int x, int y, object[] args);
	}
}
