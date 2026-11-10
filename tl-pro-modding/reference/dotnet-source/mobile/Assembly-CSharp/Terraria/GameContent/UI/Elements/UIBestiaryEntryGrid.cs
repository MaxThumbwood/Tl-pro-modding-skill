using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D63 RID: 3427
	[Token(Token = "0x2000D63")]
	public class UIBestiaryEntryGrid : UIElement
	{
		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600658D RID: 25997 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600658E RID: 25998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005E")]
		public event Action OnGridContentsChanged
		{
			[Token(Token = "0x600658D")]
			[Address(RVA = "0xB4D360", Offset = "0xB4D360", VA = "0xB4D360")]
			add
			{
			}
			[Token(Token = "0x600658E")]
			[Address(RVA = "0xB4D410", Offset = "0xB4D410", VA = "0xB4D410")]
			remove
			{
			}
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658F")]
		[Address(RVA = "0xB4D4C0", Offset = "0xB4D4C0", VA = "0xB4D4C0")]
		public UIBestiaryEntryGrid(List<BestiaryEntry> workingSet, UIElement.MouseEvent clickOnEntryEvent)
		{
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006590")]
		[Address(RVA = "0xB4D5F8", Offset = "0xB4D5F8", VA = "0xB4D5F8")]
		public void UpdateEntries()
		{
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006591")]
		[Address(RVA = "0xB4D64C", Offset = "0xB4D64C", VA = "0xB4D64C")]
		public void FillBestiarySpaceWithEntries()
		{
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006592")]
		[Address(RVA = "0xB4DD30", Offset = "0xB4DD30", VA = "0xB4DD30", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006593")]
		[Address(RVA = "0xB4DBB8", Offset = "0xB4DBB8", VA = "0xB4DBB8")]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006594")]
		[Address(RVA = "0xB4DD4C", Offset = "0xB4DD4C", VA = "0xB4DD4C")]
		public string GetRangeText()
		{
			return null;
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006595")]
		[Address(RVA = "0xB4DEB8", Offset = "0xB4DEB8", VA = "0xB4DEB8")]
		public void MakeButtonGoByOffset(UIElement element, int howManyPages)
		{
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006596")]
		[Address(RVA = "0xB4DFDC", Offset = "0xB4DFDC", VA = "0xB4DFDC")]
		public void OffsetLibraryByPages(int howManyPages)
		{
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006597")]
		[Address(RVA = "0xB4E090", Offset = "0xB4E090", VA = "0xB4E090")]
		public void OffsetLibrary(int offset)
		{
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006598")]
		[Address(RVA = "0xB4DC2C", Offset = "0xB4DC2C", VA = "0xB4DC2C")]
		private void FixBestiaryRange(int offset, int maxEntriesToHave)
		{
		}

		// Token: 0x0400A2EA RID: 41706
		[Token(Token = "0x400A2EA")]
		[FieldOffset(Offset = "0xF4")]
		private List<BestiaryEntry> _workingSetEntries;

		// Token: 0x0400A2EB RID: 41707
		[Token(Token = "0x400A2EB")]
		[FieldOffset(Offset = "0xF8")]
		private UIElement.MouseEvent _clickOnEntryEvent;

		// Token: 0x0400A2EC RID: 41708
		[Token(Token = "0x400A2EC")]
		[FieldOffset(Offset = "0xFC")]
		private int _atEntryIndex;

		// Token: 0x0400A2ED RID: 41709
		[Token(Token = "0x400A2ED")]
		[FieldOffset(Offset = "0x100")]
		private int _lastEntry;

		// Token: 0x02000D64 RID: 3428
		[Token(Token = "0x2000D64")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06006599 RID: 26009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006599")]
			[Address(RVA = "0xB4DFD4", Offset = "0xB4DFD4", VA = "0xB4DFD4")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0600659A RID: 26010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600659A")]
			[Address(RVA = "0xB4E104", Offset = "0xB4E104", VA = "0xB4E104")]
			internal void <MakeButtonGoByOffset>b__0(UIMouseEvent e, UIElement v)
			{
			}

			// Token: 0x0400A2EF RID: 41711
			[Token(Token = "0x400A2EF")]
			[FieldOffset(Offset = "0x8")]
			public UIBestiaryEntryGrid <>4__this;

			// Token: 0x0400A2F0 RID: 41712
			[Token(Token = "0x400A2F0")]
			[FieldOffset(Offset = "0xC")]
			public int howManyPages;
		}
	}
}
