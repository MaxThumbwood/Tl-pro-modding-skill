using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB7 RID: 3511
	[Token(Token = "0x2000DB7")]
	public class BrainOfCthuluBigProgressBar : FileAPI
	{
		// Token: 0x0600675B RID: 26459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675B")]
		[Address(RVA = "0xB703CC", Offset = "0xB703CC", VA = "0xB703CC")]
		public BrainOfCthuluBigProgressBar()
		{
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x0002E938 File Offset: 0x0002CB38
		[Token(Token = "0x600675C")]
		[Address(RVA = "0xB738D0", Offset = "0xB738D0", VA = "0xB738D0", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675D")]
		[Address(RVA = "0xB73B34", Offset = "0xB73B34", VA = "0xB73B34", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A450 RID: 42064
		[Token(Token = "0x400A450")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A451 RID: 42065
		[Token(Token = "0x400A451")]
		[FieldOffset(Offset = "0x18")]
		private NPC _creeperForReference;
	}
}
