using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DC2 RID: 3522
	[Token(Token = "0x2000DC2")]
	public class PirateShipBigProgressBar : FileAPI
	{
		// Token: 0x06006785 RID: 26501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006785")]
		[Address(RVA = "0xB75698", Offset = "0xB75698", VA = "0xB75698")]
		public PirateShipBigProgressBar()
		{
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x0002EB30 File Offset: 0x0002CD30
		[Token(Token = "0x6006786")]
		[Address(RVA = "0xB757C0", Offset = "0xB757C0", VA = "0xB757C0", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006787")]
		[Address(RVA = "0xB75C20", Offset = "0xB75C20", VA = "0xB75C20", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x0002EB48 File Offset: 0x0002CD48
		[Token(Token = "0x6006788")]
		[Address(RVA = "0xB75B18", Offset = "0xB75B18", VA = "0xB75B18")]
		private bool TryFindingAnotherPirateShipPiece(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0400A460 RID: 42080
		[Token(Token = "0x400A460")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A461 RID: 42081
		[Token(Token = "0x400A461")]
		[FieldOffset(Offset = "0x18")]
		private NPC _referenceDummy;

		// Token: 0x0400A462 RID: 42082
		[Token(Token = "0x400A462")]
		[FieldOffset(Offset = "0x1C")]
		private HashSet<int> ValidIds;
	}
}
