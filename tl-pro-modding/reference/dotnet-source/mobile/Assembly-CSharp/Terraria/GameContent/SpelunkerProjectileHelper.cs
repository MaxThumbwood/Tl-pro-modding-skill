using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009D3 RID: 2515
	[Token(Token = "0x20009D3")]
	public class SpelunkerProjectileHelper
	{
		// Token: 0x06005243 RID: 21059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x7D58DC", Offset = "0x7D58DC", VA = "0x7D58DC")]
		public void OnPreUpdateAllProjectiles()
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x7D5A10", Offset = "0x7D5A10", VA = "0x7D5A10")]
		public void AddSpotToCheck(Vector2 spot)
		{
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x7D5AA0", Offset = "0x7D5AA0", VA = "0x7D5AA0")]
		private void CheckSpot(Vector2 Center)
		{
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x7D605C", Offset = "0x7D605C", VA = "0x7D605C")]
		public SpelunkerProjectileHelper()
		{
		}

		// Token: 0x04009549 RID: 38217
		[Token(Token = "0x4009549")]
		[FieldOffset(Offset = "0x8")]
		private HashSet<Vector2> _positionsChecked;

		// Token: 0x0400954A RID: 38218
		[Token(Token = "0x400954A")]
		[FieldOffset(Offset = "0xC")]
		private HashSet<Point> _tilesChecked;

		// Token: 0x0400954B RID: 38219
		[Token(Token = "0x400954B")]
		[FieldOffset(Offset = "0x10")]
		private Rectangle _clampBox;

		// Token: 0x0400954C RID: 38220
		[Token(Token = "0x400954C")]
		[FieldOffset(Offset = "0x20")]
		private int _frameCounter;
	}
}
