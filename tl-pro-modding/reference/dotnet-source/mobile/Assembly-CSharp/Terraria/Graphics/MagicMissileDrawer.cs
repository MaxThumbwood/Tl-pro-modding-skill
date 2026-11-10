using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	public struct MagicMissileDrawer
	{
		// Token: 0x06004B73 RID: 19315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x65464C", Offset = "0x65464C", VA = "0x65464C")]
		public void Draw(Projectile proj)
		{
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x655610", Offset = "0x655610", VA = "0x655610")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00023E08 File Offset: 0x00022008
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x65573C", Offset = "0x65573C", VA = "0x65573C")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x04009078 RID: 36984
		[Token(Token = "0x4009078")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;
	}
}
