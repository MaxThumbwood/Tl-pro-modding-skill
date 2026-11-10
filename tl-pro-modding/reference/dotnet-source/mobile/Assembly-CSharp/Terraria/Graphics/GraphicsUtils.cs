using System;
using System.Reflection;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public static class GraphicsUtils
	{
		// Token: 0x06004B3D RID: 19261 RVA: 0x00023C28 File Offset: 0x00021E28
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x64D908", Offset = "0x64D908", VA = "0x64D908")]
		public static int PendingDrawCallCount(SpriteBatch spriteBatch)
		{
			return 0;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00023C40 File Offset: 0x00021E40
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x64DCA0", Offset = "0x64DCA0", VA = "0x64DCA0")]
		private static int DrawCallCount(Texture[] textures, int n)
		{
			return 0;
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00023C58 File Offset: 0x00021E58
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x64DF80", Offset = "0x64DF80", VA = "0x64DF80")]
		private static int DrawCallCountXNA(int count, ref int vbPos)
		{
			return 0;
		}

		// Token: 0x0400904C RID: 36940
		[Token(Token = "0x400904C")]
		[FieldOffset(Offset = "0x0")]
		private static FieldInfo SpriteBatch_spriteQueueCount;

		// Token: 0x0400904D RID: 36941
		[Token(Token = "0x400904D")]
		[FieldOffset(Offset = "0x4")]
		private static FieldInfo SpriteBatch_spriteTextures;
	}
}
