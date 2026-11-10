using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	public struct FlameLashDrawer
	{
		// Token: 0x06004B7B RID: 19323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x655F24", Offset = "0x655F24", VA = "0x655F24")]
		public void Draw(Projectile proj)
		{
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x656690", Offset = "0x656690", VA = "0x656690")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00023E38 File Offset: 0x00022038
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x65680C", Offset = "0x65680C", VA = "0x65680C")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x0400907A RID: 36986
		[Token(Token = "0x400907A")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;

		// Token: 0x0400907B RID: 36987
		[Token(Token = "0x400907B")]
		[FieldOffset(Offset = "0x0")]
		private float transitToDark;
	}
}
