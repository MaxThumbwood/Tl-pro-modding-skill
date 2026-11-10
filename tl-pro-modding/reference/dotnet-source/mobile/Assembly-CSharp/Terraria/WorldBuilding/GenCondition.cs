using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	public abstract class GenCondition : GenBase
	{
		// Token: 0x06003A45 RID: 14917 RVA: 0x0001D568 File Offset: 0x0001B768
		[Token(Token = "0x6003A45")]
		[Address(RVA = "0x1E007B8", Offset = "0x1E007B8", VA = "0x1E007B8")]
		public bool IsValid(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A46")]
		[Address(RVA = "0x1E00928", Offset = "0x1E00928", VA = "0x1E00928")]
		public GenCondition Not()
		{
			return null;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A47")]
		[Address(RVA = "0x1E00938", Offset = "0x1E00938", VA = "0x1E00938")]
		public GenCondition AreaOr(int width, int height)
		{
			return null;
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A48")]
		[Address(RVA = "0x1E00948", Offset = "0x1E00948", VA = "0x1E00948")]
		public GenCondition AreaAnd(int width, int height)
		{
			return null;
		}

		// Token: 0x06003A49 RID: 14921
		[Token(Token = "0x6003A49")]
		protected abstract bool CheckValidity(int x, int y);

		// Token: 0x06003A4A RID: 14922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x1E00958", Offset = "0x1E00958", VA = "0x1E00958")]
		protected GenCondition()
		{
		}

		// Token: 0x040045F5 RID: 17909
		[Token(Token = "0x40045F5")]
		[FieldOffset(Offset = "0x8")]
		private bool InvertResults;

		// Token: 0x040045F6 RID: 17910
		[Token(Token = "0x40045F6")]
		[FieldOffset(Offset = "0xC")]
		private int _width;

		// Token: 0x040045F7 RID: 17911
		[Token(Token = "0x40045F7")]
		[FieldOffset(Offset = "0x10")]
		private int _height;

		// Token: 0x040045F8 RID: 17912
		[Token(Token = "0x40045F8")]
		[FieldOffset(Offset = "0x14")]
		private GenCondition.AreaType _areaType;

		// Token: 0x0200056D RID: 1389
		[Token(Token = "0x200056D")]
		private enum AreaType
		{
			// Token: 0x040045FA RID: 17914
			[Token(Token = "0x40045FA")]
			And,
			// Token: 0x040045FB RID: 17915
			[Token(Token = "0x40045FB")]
			Or,
			// Token: 0x040045FC RID: 17916
			[Token(Token = "0x40045FC")]
			None
		}
	}
}
