using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x2000DB6")]
	public class EaterOfWorldsProgressBar : FileAPI
	{
		// Token: 0x06006757 RID: 26455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006757")]
		[Address(RVA = "0xB70350", Offset = "0xB70350", VA = "0xB70350")]
		public EaterOfWorldsProgressBar()
		{
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x0002E908 File Offset: 0x0002CB08
		[Token(Token = "0x6006758")]
		[Address(RVA = "0xB73350", Offset = "0xB73350", VA = "0xB73350", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006759")]
		[Address(RVA = "0xB736E0", Offset = "0xB736E0", VA = "0xB736E0", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x0002E920 File Offset: 0x0002CB20
		[Token(Token = "0x600675A")]
		[Address(RVA = "0xB73618", Offset = "0xB73618", VA = "0xB73618")]
		private bool TryFindingAnotherEOWPiece(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0400A44E RID: 42062
		[Token(Token = "0x400A44E")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A44F RID: 42063
		[Token(Token = "0x400A44F")]
		[FieldOffset(Offset = "0x18")]
		private NPC _segmentForReference;
	}
}
