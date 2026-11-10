using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x20008B6")]
	public struct RainbowRodDrawer
	{
		// Token: 0x06004B84 RID: 19332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B84")]
		[Address(RVA = "0x657A24", Offset = "0x657A24", VA = "0x657A24")]
		public void Draw(Projectile proj)
		{
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B85")]
		[Address(RVA = "0x658118", Offset = "0x658118", VA = "0x658118")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x00023E80 File Offset: 0x00022080
		[Token(Token = "0x6004B86")]
		[Address(RVA = "0x6582B4", Offset = "0x6582B4", VA = "0x6582B4")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x0400908E RID: 37006
		[Token(Token = "0x400908E")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;
	}
}
