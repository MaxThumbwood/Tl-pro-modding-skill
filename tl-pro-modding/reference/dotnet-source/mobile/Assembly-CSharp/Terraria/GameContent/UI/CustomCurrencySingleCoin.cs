using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D27 RID: 3367
	[Token(Token = "0x2000D27")]
	public class CustomCurrencySingleCoin : CustomCurrencySystem
	{
		// Token: 0x06006415 RID: 25621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006415")]
		[Address(RVA = "0xB19DAC", Offset = "0xB19DAC", VA = "0xB19DAC")]
		public CustomCurrencySingleCoin(int coinItemID, long currencyCap)
		{
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[Token(Token = "0x6006416")]
		[Address(RVA = "0xB19F48", Offset = "0xB19F48", VA = "0xB19F48", Slot = "6")]
		public override bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			return default(bool);
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006417")]
		[Address(RVA = "0xB1A4F8", Offset = "0xB1A4F8", VA = "0xB1A4F8", Slot = "8")]
		public override void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
		{
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006418")]
		[Address(RVA = "0xB1AC70", Offset = "0xB1AC70", VA = "0xB1AC70", Slot = "9")]
		public override void GetPriceText(string[] lines, ref int currentLine, long price)
		{
		}

		// Token: 0x0400A106 RID: 41222
		[Token(Token = "0x400A106")]
		[FieldOffset(Offset = "0x18")]
		public float CurrencyDrawScale;

		// Token: 0x0400A107 RID: 41223
		[Token(Token = "0x400A107")]
		[FieldOffset(Offset = "0x1C")]
		public string CurrencyTextKey;

		// Token: 0x0400A108 RID: 41224
		[Token(Token = "0x400A108")]
		[FieldOffset(Offset = "0x20")]
		public Color CurrencyTextColor;
	}
}
