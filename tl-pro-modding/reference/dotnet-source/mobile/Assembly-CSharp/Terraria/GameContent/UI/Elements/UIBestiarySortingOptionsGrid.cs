using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D65 RID: 3429
	[Token(Token = "0x2000D65")]
	public class UIBestiarySortingOptionsGrid : UIPanel
	{
		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600659B RID: 26011 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600659C RID: 26012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005F")]
		public event Action OnClickingOption
		{
			[Token(Token = "0x600659B")]
			[Address(RVA = "0xB4E1C4", Offset = "0xB4E1C4", VA = "0xB4E1C4")]
			add
			{
			}
			[Token(Token = "0x600659C")]
			[Address(RVA = "0xB4E274", Offset = "0xB4E274", VA = "0xB4E274")]
			remove
			{
			}
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659D")]
		[Address(RVA = "0xB4E324", Offset = "0xB4E324", VA = "0xB4E324")]
		public UIBestiarySortingOptionsGrid(EntrySorter<BestiaryEntry, IBestiarySortStep> sorter)
		{
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659E")]
		[Address(RVA = "0xB4E4E0", Offset = "0xB4E4E0", VA = "0xB4E4E0")]
		private void BuildGrid()
		{
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659F")]
		[Address(RVA = "0xB4EF88", Offset = "0xB4EF88", VA = "0xB4EF88")]
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A0")]
		[Address(RVA = "0xB4F308", Offset = "0xB4F308", VA = "0xB4F308")]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
		}

		// Token: 0x0400A2F1 RID: 41713
		[Token(Token = "0x400A2F1")]
		[FieldOffset(Offset = "0x10C")]
		private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

		// Token: 0x0400A2F2 RID: 41714
		[Token(Token = "0x400A2F2")]
		[FieldOffset(Offset = "0x110")]
		private List<GroupOptionButton<int>> _buttonsBySorting;

		// Token: 0x0400A2F3 RID: 41715
		[Token(Token = "0x400A2F3")]
		[FieldOffset(Offset = "0x114")]
		private int _currentSelected;

		// Token: 0x0400A2F4 RID: 41716
		[Token(Token = "0x400A2F4")]
		[FieldOffset(Offset = "0x118")]
		private int _defaultStepIndex;
	}
}
