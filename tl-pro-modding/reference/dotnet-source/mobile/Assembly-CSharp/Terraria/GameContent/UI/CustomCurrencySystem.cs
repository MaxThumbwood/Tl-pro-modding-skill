using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D26 RID: 3366
	[Token(Token = "0x2000D26")]
	public class CustomCurrencySystem
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[Token(Token = "0x17000AC4")]
		public long CurrencyCap
		{
			[Token(Token = "0x6006407")]
			[Address(RVA = "0xB17644", Offset = "0xB17644", VA = "0xB17644")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006408")]
		[Address(RVA = "0xB1764C", Offset = "0xB1764C", VA = "0xB1764C")]
		public void Include(int coin, int howMuchIsItWorth)
		{
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006409")]
		[Address(RVA = "0xB176C0", Offset = "0xB176C0", VA = "0xB176C0")]
		public void SetCurrencyCap(long cap)
		{
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x0002DD80 File Offset: 0x0002BF80
		[Token(Token = "0x600640A")]
		[Address(RVA = "0xB176D0", Offset = "0xB176D0", VA = "0xB176D0", Slot = "4")]
		public virtual long CountCurrency(out bool overFlowing, Item[] inv, int[] ignoreSlots)
		{
			return 0L;
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Token(Token = "0x600640B")]
		[Address(RVA = "0xB178CC", Offset = "0xB178CC", VA = "0xB178CC", Slot = "5")]
		public virtual long CombineStacks(out bool overFlowing, long[] coinCounts)
		{
			return 0L;
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[Token(Token = "0x600640C")]
		[Address(RVA = "0xB17950", Offset = "0xB17950", VA = "0xB17950", Slot = "6")]
		public virtual bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			return default(bool);
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		[Token(Token = "0x600640D")]
		[Address(RVA = "0xB196D8", Offset = "0xB196D8", VA = "0xB196D8", Slot = "7")]
		public virtual bool Accepts(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640E")]
		[Address(RVA = "0xB19754", Offset = "0xB19754", VA = "0xB19754", Slot = "8")]
		public virtual void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
		{
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640F")]
		[Address(RVA = "0xB19758", Offset = "0xB19758", VA = "0xB19758", Slot = "9")]
		public virtual void GetPriceText(string[] lines, ref int currentLine, long price)
		{
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[Token(Token = "0x6006410")]
		[Address(RVA = "0xB1975C", Offset = "0xB1975C", VA = "0xB1975C")]
		protected int SortByHighest(Tuple<int, int> valueA, Tuple<int, int> valueB)
		{
			return 0;
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006411")]
		[Address(RVA = "0xB197D8", Offset = "0xB197D8", VA = "0xB197D8")]
		protected List<Tuple<Point, Item>> ItemCacheCreate(List<Item[]> inventories)
		{
			return null;
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006412")]
		[Address(RVA = "0xB19A7C", Offset = "0xB19A7C", VA = "0xB19A7C")]
		protected void ItemCacheRestore(List<Tuple<Point, Item>> cache, List<Item[]> inventories)
		{
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006413")]
		[Address(RVA = "0xB19CCC", Offset = "0xB19CCC", VA = "0xB19CCC", Slot = "10")]
		public virtual void GetItemExpectedPrice(Item item, out long calcForSelling, out long calcForBuying)
		{
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006414")]
		[Address(RVA = "0xB19D04", Offset = "0xB19D04", VA = "0xB19D04")]
		public CustomCurrencySystem()
		{
		}

		// Token: 0x0400A104 RID: 41220
		[Token(Token = "0x400A104")]
		[FieldOffset(Offset = "0x8")]
		protected Dictionary<int, int> _valuePerUnit;

		// Token: 0x0400A105 RID: 41221
		[Token(Token = "0x400A105")]
		[FieldOffset(Offset = "0x10")]
		private long _currencyCap;
	}
}
