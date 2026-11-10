using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBC RID: 3516
	[Token(Token = "0x2000DBC")]
	public class TwinsBigProgressBar : FileAPI
	{
		// Token: 0x0600676C RID: 26476 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		[Token(Token = "0x600676C")]
		[Address(RVA = "0xB74A3C", Offset = "0xB74A3C", VA = "0xB74A3C", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676D")]
		[Address(RVA = "0xB74BC0", Offset = "0xB74BC0", VA = "0xB74BC0", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676E")]
		[Address(RVA = "0xB70348", Offset = "0xB70348", VA = "0xB70348")]
		public TwinsBigProgressBar()
		{
		}

		// Token: 0x0400A45C RID: 42076
		[Token(Token = "0x400A45C")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A45D RID: 42077
		[Token(Token = "0x400A45D")]
		[FieldOffset(Offset = "0x18")]
		private int _headIndex;
	}
}
