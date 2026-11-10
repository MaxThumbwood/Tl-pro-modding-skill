using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200059E RID: 1438
	[Token(Token = "0x200059E")]
	public abstract class GenSearch : GenBase
	{
		// Token: 0x06003AC6 RID: 15046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x1E06D98", Offset = "0x1E06D98", VA = "0x1E06D98")]
		public GenSearch Conditions(GenCondition[] conditions)
		{
			return null;
		}

		// Token: 0x06003AC7 RID: 15047
		[Token(Token = "0x6003AC7")]
		public abstract Point Find(Point origin);

		// Token: 0x06003AC8 RID: 15048 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x1E06DA0", Offset = "0x1E06DA0", VA = "0x1E06DA0")]
		protected bool Check(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x1E06E40", Offset = "0x1E06E40", VA = "0x1E06E40")]
		public GenSearch RequireAll(bool mode)
		{
			return null;
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x1E06E48", Offset = "0x1E06E48", VA = "0x1E06E48")]
		protected GenSearch()
		{
		}

		// Token: 0x0400463F RID: 17983
		[Token(Token = "0x400463F")]
		[FieldOffset(Offset = "0x0")]
		public static Point NOT_FOUND;

		// Token: 0x04004640 RID: 17984
		[Token(Token = "0x4004640")]
		[FieldOffset(Offset = "0x8")]
		private bool _requireAll;

		// Token: 0x04004641 RID: 17985
		[Token(Token = "0x4004641")]
		[FieldOffset(Offset = "0xC")]
		private GenCondition[] _conditions;
	}
}
