using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	public struct VertexColors
	{
		// Token: 0x06004B5E RID: 19294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x6514CC", Offset = "0x6514CC", VA = "0x6514CC")]
		public VertexColors(Color color)
		{
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x6514D8", Offset = "0x6514D8", VA = "0x6514D8")]
		public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00023D60 File Offset: 0x00021F60
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x6514F0", Offset = "0x6514F0", VA = "0x6514F0")]
		public static implicit operator VertexColors(Color color)
		{
			return default(VertexColors);
		}

		// Token: 0x04009062 RID: 36962
		[Token(Token = "0x4009062")]
		[FieldOffset(Offset = "0x0")]
		public Color TopLeftColor;

		// Token: 0x04009063 RID: 36963
		[Token(Token = "0x4009063")]
		[FieldOffset(Offset = "0x4")]
		public Color TopRightColor;

		// Token: 0x04009064 RID: 36964
		[Token(Token = "0x4009064")]
		[FieldOffset(Offset = "0x8")]
		public Color BottomLeftColor;

		// Token: 0x04009065 RID: 36965
		[Token(Token = "0x4009065")]
		[FieldOffset(Offset = "0xC")]
		public Color BottomRightColor;
	}
}
