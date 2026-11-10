using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	public struct GemStaffShotDrawer
	{
		// Token: 0x06004B88 RID: 19336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0x6583E8", Offset = "0x6583E8", VA = "0x6583E8")]
		public void Draw(Projectile proj, string gameShaderName, Color trailColor1, Color trailColor2, Color trailColor3, float intensity = 2f)
		{
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x658968", Offset = "0x658968", VA = "0x658968")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x00023E98 File Offset: 0x00022098
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x658A9C", Offset = "0x658A9C", VA = "0x658A9C")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x0400908F RID: 37007
		[Token(Token = "0x400908F")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;

		// Token: 0x04009090 RID: 37008
		[Token(Token = "0x4009090")]
		[FieldOffset(Offset = "0x0")]
		private Color _trailColor1;

		// Token: 0x04009091 RID: 37009
		[Token(Token = "0x4009091")]
		[FieldOffset(Offset = "0x4")]
		private Color _trailColor2;

		// Token: 0x04009092 RID: 37010
		[Token(Token = "0x4009092")]
		[FieldOffset(Offset = "0x8")]
		private Color _trailColor3;
	}
}
