using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D66 RID: 3430
	[Token(Token = "0x2000D66")]
	public class UIBestiaryFilteringOptionsGrid : UIPanel
	{
		// Token: 0x14000060 RID: 96
		// (add) Token: 0x060065A1 RID: 26017 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060065A2 RID: 26018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000060")]
		public event Action OnClickingOption
		{
			[Token(Token = "0x60065A1")]
			[Address(RVA = "0xB4F398", Offset = "0xB4F398", VA = "0xB4F398")]
			add
			{
			}
			[Token(Token = "0x60065A2")]
			[Address(RVA = "0xB4F448", Offset = "0xB4F448", VA = "0xB4F448")]
			remove
			{
			}
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A3")]
		[Address(RVA = "0xB4F4F8", Offset = "0xB4F4F8", VA = "0xB4F4F8")]
		public UIBestiaryFilteringOptionsGrid(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer)
		{
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A4")]
		[Address(RVA = "0xB4F768", Offset = "0xB4F768", VA = "0xB4F768")]
		private void BuildContainer()
		{
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A5")]
		[Address(RVA = "0xB4FB9C", Offset = "0xB4FB9C", VA = "0xB4FB9C")]
		public void SetupAvailabilityTest(List<BestiaryEntry> allAvailableEntries)
		{
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A6")]
		[Address(RVA = "0xB4FF8C", Offset = "0xB4FF8C", VA = "0xB4FF8C")]
		public void UpdateAvailability()
		{
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A7")]
		[Address(RVA = "0xB514BC", Offset = "0xB514BC", VA = "0xB514BC")]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0xB4FA54", Offset = "0xB4FA54", VA = "0xB4FA54")]
		private void GetDisplaySettings(out int widthPerButton, out int heightPerButton, out int widthWithSpacing, out int heightWithSpacing, out int perRow, out float offsetLeft, out float offsetTop, out int howManyRows)
		{
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0xB511E8", Offset = "0xB511E8", VA = "0xB511E8")]
		private void UpdateButtonSelections()
		{
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x0002E290 File Offset: 0x0002C490
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0xB50DD8", Offset = "0xB50DD8", VA = "0xB50DD8")]
		private bool GetIsFilterAvailableForEntries(IBestiaryEntryFilter filter, List<BestiaryEntry> entries)
		{
			return default(bool);
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0xB510CC", Offset = "0xB510CC", VA = "0xB510CC")]
		private void AddOnHover(IBestiaryEntryFilter filter, UIElement button)
		{
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AC")]
		[Address(RVA = "0xB515AC", Offset = "0xB515AC", VA = "0xB515AC")]
		private void ShowButtonName(UIElement element, IBestiaryEntryFilter number)
		{
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AD")]
		[Address(RVA = "0xB51744", Offset = "0xB51744", VA = "0xB51744")]
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0400A2F6 RID: 41718
		[Token(Token = "0x400A2F6")]
		[FieldOffset(Offset = "0x10C")]
		private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

		// Token: 0x0400A2F7 RID: 41719
		[Token(Token = "0x400A2F7")]
		[FieldOffset(Offset = "0x110")]
		private List<GroupOptionButton<int>> _filterButtons;

		// Token: 0x0400A2F8 RID: 41720
		[Token(Token = "0x400A2F8")]
		[FieldOffset(Offset = "0x114")]
		private List<bool> _areFiltersAvailable;

		// Token: 0x0400A2F9 RID: 41721
		[Token(Token = "0x400A2F9")]
		[FieldOffset(Offset = "0x118")]
		private List<List<BestiaryEntry>> _filterAvailabilityTests;

		// Token: 0x0400A2FB RID: 41723
		[Token(Token = "0x400A2FB")]
		[FieldOffset(Offset = "0x120")]
		private UIElement _container;

		// Token: 0x02000D67 RID: 3431
		[Token(Token = "0x2000D67")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x060065AE RID: 26030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065AE")]
			[Address(RVA = "0xB515A4", Offset = "0xB515A4", VA = "0xB515A4")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x060065AF RID: 26031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065AF")]
			[Address(RVA = "0xB5187C", Offset = "0xB5187C", VA = "0xB5187C")]
			internal void <AddOnHover>b__0(UIElement element)
			{
			}

			// Token: 0x0400A2FC RID: 41724
			[Token(Token = "0x400A2FC")]
			[FieldOffset(Offset = "0x8")]
			public UIBestiaryFilteringOptionsGrid <>4__this;

			// Token: 0x0400A2FD RID: 41725
			[Token(Token = "0x400A2FD")]
			[FieldOffset(Offset = "0xC")]
			public IBestiaryEntryFilter filter;
		}
	}
}
