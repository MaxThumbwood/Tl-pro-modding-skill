using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class UIBestiaryEntryInfoPage : UIPanel
	{
		// Token: 0x060065BF RID: 26047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0xB53228", Offset = "0xB53228", VA = "0xB53228")]
		public UIBestiaryEntryInfoPage()
		{
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0xB53854", Offset = "0xB53854", VA = "0xB53854")]
		public void UpdateScrollbar(int scrollWheelValue)
		{
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xB536B8", Offset = "0xB536B8", VA = "0xB536B8")]
		private void AppendBorderOverEverything()
		{
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xB5387C", Offset = "0xB5387C", VA = "0xB5387C")]
		private void ManualIfnoSortingMethod(List<UIElement> list)
		{
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xB53880", Offset = "0xB53880", VA = "0xB53880", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xB535F4", Offset = "0xB535F4", VA = "0xB535F4")]
		private void CheckScrollBar()
		{
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xB5389C", Offset = "0xB5389C", VA = "0xB5389C")]
		public void FillInfoForEntry(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xB54604", Offset = "0xB54604", VA = "0xB54604")]
		private BestiaryUICollectionInfo GetUICollectionInfo(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0xB53918", Offset = "0xB53918", VA = "0xB53918")]
		private void AddInfoToList(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0xB546E8", Offset = "0xB546E8", VA = "0xB546E8")]
		private float GetIndividualElementPriority(IBestiaryInfoElement element)
		{
			return 0f;
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0xB547B0", Offset = "0xB547B0", VA = "0xB547B0")]
		private UIBestiaryEntryInfoPage.BestiaryInfoCategory GetBestiaryInfoCategory(IBestiaryInfoElement element)
		{
			return UIBestiaryEntryInfoPage.BestiaryInfoCategory.Nameplate;
		}

		// Token: 0x0400A311 RID: 41745
		[Token(Token = "0x400A311")]
		[FieldOffset(Offset = "0x10C")]
		private UIList _list;

		// Token: 0x0400A312 RID: 41746
		[Token(Token = "0x400A312")]
		[FieldOffset(Offset = "0x110")]
		private UIScrollbar _scrollbar;

		// Token: 0x0400A313 RID: 41747
		[Token(Token = "0x400A313")]
		[FieldOffset(Offset = "0x114")]
		private bool _isScrollbarAttached;

		// Token: 0x02000D6D RID: 3437
		[Token(Token = "0x2000D6D")]
		private enum BestiaryInfoCategory
		{
			// Token: 0x0400A315 RID: 41749
			[Token(Token = "0x400A315")]
			Nameplate,
			// Token: 0x0400A316 RID: 41750
			[Token(Token = "0x400A316")]
			Portrait,
			// Token: 0x0400A317 RID: 41751
			[Token(Token = "0x400A317")]
			FlavorText,
			// Token: 0x0400A318 RID: 41752
			[Token(Token = "0x400A318")]
			Stats,
			// Token: 0x0400A319 RID: 41753
			[Token(Token = "0x400A319")]
			ItemsFromCatchingNPC,
			// Token: 0x0400A31A RID: 41754
			[Token(Token = "0x400A31A")]
			ItemsFromDrops,
			// Token: 0x0400A31B RID: 41755
			[Token(Token = "0x400A31B")]
			Misc
		}

		// Token: 0x02000D6E RID: 3438
		[Token(Token = "0x2000D6E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060065CB RID: 26059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065CB")]
			[Address(RVA = "0xB54A58", Offset = "0xB54A58", VA = "0xB54A58")]
			public <>c()
			{
			}

			// Token: 0x060065CC RID: 26060 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
			[Token(Token = "0x60065CC")]
			[Address(RVA = "0xB54A60", Offset = "0xB54A60", VA = "0xB54A60")]
			internal UIBestiaryEntryInfoPage.BestiaryInfoCategory <AddInfoToList>b__11_0(IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement> x)
			{
				return UIBestiaryEntryInfoPage.BestiaryInfoCategory.Nameplate;
			}

			// Token: 0x0400A31C RID: 41756
			[Token(Token = "0x400A31C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBestiaryEntryInfoPage.<>c <>9;

			// Token: 0x0400A31D RID: 41757
			[Token(Token = "0x400A31D")]
			[FieldOffset(Offset = "0x4")]
			public static Func<IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement>, UIBestiaryEntryInfoPage.BestiaryInfoCategory> <>9__11_0;
		}
	}
}
