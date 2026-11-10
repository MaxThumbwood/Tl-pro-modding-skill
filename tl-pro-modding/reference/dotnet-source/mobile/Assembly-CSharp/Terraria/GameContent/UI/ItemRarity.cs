using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D2D RID: 3373
	[Token(Token = "0x2000D2D")]
	public class ItemRarity
	{
		// Token: 0x06006433 RID: 25651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006433")]
		[Address(RVA = "0xB1F5D4", Offset = "0xB1F5D4", VA = "0xB1F5D4")]
		public static void Initialize()
		{
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[Token(Token = "0x6006434")]
		[Address(RVA = "0xB1F920", Offset = "0xB1F920", VA = "0xB1F920")]
		public static Color GetColor(int rarity)
		{
			return default(Color);
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006435")]
		[Address(RVA = "0xB1FACC", Offset = "0xB1FACC", VA = "0xB1FACC")]
		public ItemRarity()
		{
		}

		// Token: 0x0400A1B8 RID: 41400
		[Token(Token = "0x400A1B8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Color> _rarities;
	}
}
