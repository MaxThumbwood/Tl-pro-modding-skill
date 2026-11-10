using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DC3 RID: 3523
	[Token(Token = "0x2000DC3")]
	public class MartianSaucerBigProgressBar : FileAPI
	{
		// Token: 0x06006789 RID: 26505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006789")]
		[Address(RVA = "0xB75E10", Offset = "0xB75E10", VA = "0xB75E10")]
		public MartianSaucerBigProgressBar()
		{
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x0002EB60 File Offset: 0x0002CD60
		[Token(Token = "0x600678A")]
		[Address(RVA = "0xB75FE4", Offset = "0xB75FE4", VA = "0xB75FE4", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678B")]
		[Address(RVA = "0xB764F0", Offset = "0xB764F0", VA = "0xB764F0", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x0002EB78 File Offset: 0x0002CD78
		[Token(Token = "0x600678C")]
		[Address(RVA = "0xB763E8", Offset = "0xB763E8", VA = "0xB763E8")]
		private bool TryFindingAnotherMartianSaucerPiece(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0400A463 RID: 42083
		[Token(Token = "0x400A463")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A464 RID: 42084
		[Token(Token = "0x400A464")]
		[FieldOffset(Offset = "0x18")]
		private NPC _referenceDummy;

		// Token: 0x0400A465 RID: 42085
		[Token(Token = "0x400A465")]
		[FieldOffset(Offset = "0x1C")]
		private HashSet<int> ValidIds;

		// Token: 0x0400A466 RID: 42086
		[Token(Token = "0x400A466")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> ValidIdsToScanHp;
	}
}
