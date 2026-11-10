using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D68 RID: 3432
	[Token(Token = "0x2000D68")]
	public class UICreativeItemsInfiniteFilteringOptions : UIElement
	{
		// Token: 0x14000061 RID: 97
		// (add) Token: 0x060065B0 RID: 26032 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060065B1 RID: 26033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000061")]
		public event Action OnClickingOption
		{
			[Token(Token = "0x60065B0")]
			[Address(RVA = "0xB518A8", Offset = "0xB518A8", VA = "0xB518A8")]
			add
			{
			}
			[Token(Token = "0x60065B1")]
			[Address(RVA = "0xB51958", Offset = "0xB51958", VA = "0xB51958")]
			remove
			{
			}
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0xB51A08", Offset = "0xB51A08", VA = "0xB51A08")]
		public UICreativeItemsInfiniteFilteringOptions(EntryFilterer<Item, IItemEntryFilter> filterer, string snapPointsName, UICreativeItemsInfiniteFilteringOptions.ColorTheme theme = UICreativeItemsInfiniteFilteringOptions.ColorTheme.Blue)
		{
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0xB52728", Offset = "0xB52728", VA = "0xB52728")]
		private void button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0xB52760", Offset = "0xB52760", VA = "0xB52760")]
		private void singleFilterButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0xB524DC", Offset = "0xB524DC", VA = "0xB524DC")]
		private void UpdateVisuals(UIImageFramed button, int indexOfFilter)
		{
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0xB52314", Offset = "0xB52314", VA = "0xB52314")]
		private void AddOnHover(IItemEntryFilter filter, UIElement button, int indexOfFilter)
		{
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B7")]
		[Address(RVA = "0xB529D0", Offset = "0xB529D0", VA = "0xB529D0")]
		private void ShowButtonName(UIElement element, IItemEntryFilter number, int indexOfFilter)
		{
		}

		// Token: 0x0400A2FE RID: 41726
		[Token(Token = "0x400A2FE")]
		[FieldOffset(Offset = "0xF4")]
		private EntryFilterer<Item, IItemEntryFilter> _filterer;

		// Token: 0x0400A2FF RID: 41727
		[Token(Token = "0x400A2FF")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<UIImageFramed, IItemEntryFilter> _filtersByButtons;

		// Token: 0x0400A300 RID: 41728
		[Token(Token = "0x400A300")]
		[FieldOffset(Offset = "0xFC")]
		private Dictionary<UIImageFramed, UIElement> _iconsByButtons;

		// Token: 0x0400A302 RID: 41730
		[Token(Token = "0x400A302")]
		private const int barFramesX = 2;

		// Token: 0x0400A303 RID: 41731
		[Token(Token = "0x400A303")]
		private const int barFramesY = 4;

		// Token: 0x0400A304 RID: 41732
		[Token(Token = "0x400A304")]
		[FieldOffset(Offset = "0x104")]
		private UICreativeItemsInfiniteFilteringOptions.ColorTheme _theme;

		// Token: 0x02000D69 RID: 3433
		[Token(Token = "0x2000D69")]
		public enum ColorTheme
		{
			// Token: 0x0400A306 RID: 41734
			[Token(Token = "0x400A306")]
			Blue,
			// Token: 0x0400A307 RID: 41735
			[Token(Token = "0x400A307")]
			Cyan
		}

		// Token: 0x02000D6A RID: 3434
		[Token(Token = "0x2000D6A")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060065B8 RID: 26040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065B8")]
			[Address(RVA = "0xB529C8", Offset = "0xB529C8", VA = "0xB529C8")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x060065B9 RID: 26041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065B9")]
			[Address(RVA = "0xB52B68", Offset = "0xB52B68", VA = "0xB52B68")]
			internal void <AddOnHover>b__0(UIElement element)
			{
			}

			// Token: 0x060065BA RID: 26042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065BA")]
			[Address(RVA = "0xB52B9C", Offset = "0xB52B9C", VA = "0xB52B9C")]
			internal void <AddOnHover>b__1(UIElement element)
			{
			}

			// Token: 0x0400A308 RID: 41736
			[Token(Token = "0x400A308")]
			[FieldOffset(Offset = "0x8")]
			public UICreativeItemsInfiniteFilteringOptions <>4__this;

			// Token: 0x0400A309 RID: 41737
			[Token(Token = "0x400A309")]
			[FieldOffset(Offset = "0xC")]
			public IItemEntryFilter filter;

			// Token: 0x0400A30A RID: 41738
			[Token(Token = "0x400A30A")]
			[FieldOffset(Offset = "0x10")]
			public int indexOfFilter;

			// Token: 0x0400A30B RID: 41739
			[Token(Token = "0x400A30B")]
			[FieldOffset(Offset = "0x14")]
			public UIElement button;
		}
	}
}
