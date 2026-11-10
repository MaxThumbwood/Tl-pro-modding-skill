using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public abstract class GenAction : GenBase
	{
		// Token: 0x060039EF RID: 14831
		[Token(Token = "0x60039EF")]
		public abstract bool Apply(Point origin, int x, int y, object[] args);

		// Token: 0x060039F0 RID: 14832 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x1DFB9A0", Offset = "0x1DFB9A0", VA = "0x1DFB9A0")]
		protected bool UnitApply(Point origin, int x, int y, object[] args)
		{
			return default(bool);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F1")]
		[Address(RVA = "0x1DFBB28", Offset = "0x1DFBB28", VA = "0x1DFBB28")]
		public GenAction IgnoreFailures()
		{
			return null;
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0001D208 File Offset: 0x0001B408
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x1DFBB34", Offset = "0x1DFBB34", VA = "0x1DFBB34")]
		protected bool Fail()
		{
			return default(bool);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x1DFBB44", Offset = "0x1DFBB44", VA = "0x1DFBB44")]
		public GenAction Output(ShapeData data)
		{
			return null;
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F4")]
		[Address(RVA = "0x1DFBB4C", Offset = "0x1DFBB4C", VA = "0x1DFBB4C")]
		protected GenAction()
		{
		}

		// Token: 0x040045CD RID: 17869
		[Token(Token = "0x40045CD")]
		[FieldOffset(Offset = "0x8")]
		public GenAction NextAction;

		// Token: 0x040045CE RID: 17870
		[Token(Token = "0x40045CE")]
		[FieldOffset(Offset = "0xC")]
		public ShapeData OutputData;

		// Token: 0x040045CF RID: 17871
		[Token(Token = "0x40045CF")]
		[FieldOffset(Offset = "0x10")]
		private bool _returnFalseOnFailure;
	}
}
