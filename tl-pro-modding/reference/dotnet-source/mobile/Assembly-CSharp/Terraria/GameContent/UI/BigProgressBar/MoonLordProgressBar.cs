using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB9 RID: 3513
	[Token(Token = "0x2000DB9")]
	public class MoonLordProgressBar : FileAPI
	{
		// Token: 0x06006762 RID: 26466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006762")]
		[Address(RVA = "0xB705AC", Offset = "0xB705AC", VA = "0xB705AC")]
		public MoonLordProgressBar()
		{
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x0002E980 File Offset: 0x0002CB80
		[Token(Token = "0x6006763")]
		[Address(RVA = "0xB742C0", Offset = "0xB742C0", VA = "0xB742C0", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x0002E998 File Offset: 0x0002CB98
		[Token(Token = "0x6006764")]
		[Address(RVA = "0xB74620", Offset = "0xB74620", VA = "0xB74620")]
		private bool IsInBadAI(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006765")]
		[Address(RVA = "0xB74834", Offset = "0xB74834", VA = "0xB74834", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		[Token(Token = "0x6006766")]
		[Address(RVA = "0xB74714", Offset = "0xB74714", VA = "0xB74714")]
		private bool TryFindingAnotherMoonLordPiece(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0400A455 RID: 42069
		[Token(Token = "0x400A455")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A456 RID: 42070
		[Token(Token = "0x400A456")]
		[FieldOffset(Offset = "0x18")]
		private NPC _referenceDummy;

		// Token: 0x0400A457 RID: 42071
		[Token(Token = "0x400A457")]
		[FieldOffset(Offset = "0x1C")]
		private HashSet<int> ValidIds;
	}
}
