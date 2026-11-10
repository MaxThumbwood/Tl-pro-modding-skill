using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D28 RID: 3368
	[Token(Token = "0x2000D28")]
	public class CustomCurrencyManager
	{
		// Token: 0x06006419 RID: 25625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006419")]
		[Address(RVA = "0xB1B004", Offset = "0xB1B004", VA = "0xB1B004")]
		public static void Initialize()
		{
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x0002DE10 File Offset: 0x0002C010
		[Token(Token = "0x600641A")]
		[Address(RVA = "0xB1B104", Offset = "0xB1B104", VA = "0xB1B104")]
		public static int RegisterCurrency(CustomCurrencySystem collection)
		{
			return 0;
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x0002DE28 File Offset: 0x0002C028
		[Token(Token = "0x600641B")]
		[Address(RVA = "0xB1B1B4", Offset = "0xB1B1B4", VA = "0xB1B1B4")]
		public static long GetCurrencyCount(int currencyIndex)
		{
			return 0L;
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641C")]
		[Address(RVA = "0xB1B5FC", Offset = "0xB1B5FC", VA = "0xB1B5FC")]
		public static void DrawSavings(SpriteBatch sb, int currencyIndex, float shopx, float shopy, bool horizontal = false)
		{
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641D")]
		[Address(RVA = "0xB1BF1C", Offset = "0xB1BF1C", VA = "0xB1BF1C")]
		public static void GetPriceText(int currencyIndex, string[] lines, ref int currentLine, long price)
		{
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Token(Token = "0x600641E")]
		[Address(RVA = "0xB1C008", Offset = "0xB1C008", VA = "0xB1C008")]
		public static bool CanAffordItem(Player player, long price, int currencyIndex)
		{
			return default(bool);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Token(Token = "0x600641F")]
		[Address(RVA = "0xB1C544", Offset = "0xB1C544", VA = "0xB1C544")]
		public static bool BuyItem(Player player, long price, int currencyIndex)
		{
			return default(bool);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006420")]
		[Address(RVA = "0xB1D4A8", Offset = "0xB1D4A8", VA = "0xB1D4A8")]
		private static void FindEmptySlots(List<Item[]> inventories, Dictionary<int, List<int>> slotsToIgnore, List<Point> emptySlots, int currentInventoryIndex)
		{
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x0002DE70 File Offset: 0x0002C070
		[Token(Token = "0x6006421")]
		[Address(RVA = "0xB1D758", Offset = "0xB1D758", VA = "0xB1D758")]
		public static bool IsCustomCurrency(Item item)
		{
			return default(bool);
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006422")]
		[Address(RVA = "0xB1D988", Offset = "0xB1D988", VA = "0xB1D988")]
		public static void GetPrices(Item item, out long calcForSelling, out long calcForBuying)
		{
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006423")]
		[Address(RVA = "0xB1DA7C", Offset = "0xB1DA7C", VA = "0xB1DA7C")]
		public CustomCurrencyManager()
		{
		}

		// Token: 0x0400A109 RID: 41225
		[Token(Token = "0x400A109")]
		[FieldOffset(Offset = "0x0")]
		private static int _nextCurrencyIndex;

		// Token: 0x0400A10A RID: 41226
		[Token(Token = "0x400A10A")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<int, CustomCurrencySystem> _currencies;
	}
}
