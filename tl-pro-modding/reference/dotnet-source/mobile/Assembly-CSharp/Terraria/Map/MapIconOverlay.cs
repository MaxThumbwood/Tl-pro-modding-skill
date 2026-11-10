using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Map
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	public class MapIconOverlay
	{
		// Token: 0x060046A0 RID: 18080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x59E5EC", Offset = "0x59E5EC", VA = "0x59E5EC")]
		public MapIconOverlay AddLayer(IMapLayer layer)
		{
			return null;
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x59E6B0", Offset = "0x59E6B0", VA = "0x59E6B0")]
		public void Draw(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale, int alpha, ref string text)
		{
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x59E9B4", Offset = "0x59E9B4", VA = "0x59E9B4")]
		public MapIconOverlay()
		{
		}

		// Token: 0x04008D95 RID: 36245
		[Token(Token = "0x4008D95")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<IMapLayer> _layers;
	}
}
