using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	public struct EmpressBladeDrawer
	{
		// Token: 0x06004B6F RID: 19311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x653D04", Offset = "0x653D04", VA = "0x653D04")]
		public void Draw(Projectile proj)
		{
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x65448C", Offset = "0x65448C", VA = "0x65448C")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00023DF0 File Offset: 0x00021FF0
		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x6545B4", Offset = "0x6545B4", VA = "0x6545B4")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x04009073 RID: 36979
		[Token(Token = "0x4009073")]
		public const int TotalIllusions = 1;

		// Token: 0x04009074 RID: 36980
		[Token(Token = "0x4009074")]
		public const int FramesPerImportantTrail = 60;

		// Token: 0x04009075 RID: 36981
		[Token(Token = "0x4009075")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;

		// Token: 0x04009076 RID: 36982
		[Token(Token = "0x4009076")]
		[FieldOffset(Offset = "0x0")]
		public Color ColorStart;

		// Token: 0x04009077 RID: 36983
		[Token(Token = "0x4009077")]
		[FieldOffset(Offset = "0x4")]
		public Color ColorEnd;
	}
}
