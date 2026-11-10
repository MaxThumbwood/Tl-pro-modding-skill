using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics
{
	// Token: 0x020008A7 RID: 2215
	[Token(Token = "0x20008A7")]
	public struct SpriteRenderTargetHelper
	{
		// Token: 0x06004B40 RID: 19264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x64DFE0", Offset = "0x64DFE0", VA = "0x64DFE0")]
		public static void GetDrawBoundary(int playerDrawDataCount, DrawData[] playerDrawData, out Vector2 lowest, out Vector2 highest)
		{
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x64E1F4", Offset = "0x64E1F4", VA = "0x64E1F4")]
		public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd)
		{
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B42")]
		[Address(RVA = "0x64E364", Offset = "0x64E364", VA = "0x64E364")]
		public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
		{
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x00023C70 File Offset: 0x00021E70
		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x64E450", Offset = "0x64E450", VA = "0x64E450")]
		public static Vector2 GetCorner(ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
		{
			return default(Vector2);
		}
	}
}
