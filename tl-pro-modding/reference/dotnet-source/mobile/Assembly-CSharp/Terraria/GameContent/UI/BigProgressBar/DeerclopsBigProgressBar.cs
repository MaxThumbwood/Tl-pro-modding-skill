using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB5 RID: 3509
	[Token(Token = "0x2000DB5")]
	public class DeerclopsBigProgressBar : FileAPI
	{
		// Token: 0x06006754 RID: 26452 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		[Token(Token = "0x6006754")]
		[Address(RVA = "0xB73078", Offset = "0xB73078", VA = "0xB73078", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006755")]
		[Address(RVA = "0xB731A8", Offset = "0xB731A8", VA = "0xB731A8", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006756")]
		[Address(RVA = "0xB7074C", Offset = "0xB7074C", VA = "0xB7074C")]
		public DeerclopsBigProgressBar()
		{
		}

		// Token: 0x0400A44C RID: 42060
		[Token(Token = "0x400A44C")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A44D RID: 42061
		[Token(Token = "0x400A44D")]
		[FieldOffset(Offset = "0x18")]
		private int _headIndex;
	}
}
