using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x2000DB8")]
	public class GolemHeadProgressBar : FileAPI
	{
		// Token: 0x0600675E RID: 26462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675E")]
		[Address(RVA = "0xB70448", Offset = "0xB70448", VA = "0xB70448")]
		public GolemHeadProgressBar()
		{
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x0002E950 File Offset: 0x0002CB50
		[Token(Token = "0x600675F")]
		[Address(RVA = "0xB73D24", Offset = "0xB73D24", VA = "0xB73D24", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006760")]
		[Address(RVA = "0xB740D0", Offset = "0xB740D0", VA = "0xB740D0", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x0002E968 File Offset: 0x0002CB68
		[Token(Token = "0x6006761")]
		[Address(RVA = "0xB73FC8", Offset = "0xB73FC8", VA = "0xB73FC8")]
		private bool TryFindingAnotherGolemPiece(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0400A452 RID: 42066
		[Token(Token = "0x400A452")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A453 RID: 42067
		[Token(Token = "0x400A453")]
		[FieldOffset(Offset = "0x18")]
		private NPC _referenceDummy;

		// Token: 0x0400A454 RID: 42068
		[Token(Token = "0x400A454")]
		[FieldOffset(Offset = "0x1C")]
		private HashSet<int> ValidIds;
	}
}
