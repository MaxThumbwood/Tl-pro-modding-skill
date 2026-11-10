using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB4 RID: 3508
	[Token(Token = "0x2000DB4")]
	public class CommonBossBigProgressBar : FileAPI
	{
		// Token: 0x06006751 RID: 26449 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		[Token(Token = "0x6006751")]
		[Address(RVA = "0xB72DE0", Offset = "0xB72DE0", VA = "0xB72DE0", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006752")]
		[Address(RVA = "0xB72ED0", Offset = "0xB72ED0", VA = "0xB72ED0", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006753")]
		[Address(RVA = "0xB6FE64", Offset = "0xB6FE64", VA = "0xB6FE64")]
		public CommonBossBigProgressBar()
		{
		}

		// Token: 0x0400A44A RID: 42058
		[Token(Token = "0x400A44A")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A44B RID: 42059
		[Token(Token = "0x400A44B")]
		[FieldOffset(Offset = "0x18")]
		private int _headIndex;
	}
}
