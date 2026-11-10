using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x2000D3F")]
	public class UIAchievementsMenu : UIState
	{
		// Token: 0x0600647A RID: 25722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647A")]
		[Address(RVA = "0xB2C1E4", Offset = "0xB2C1E4", VA = "0xB2C1E4")]
		public void InitializePage()
		{
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647B")]
		[Address(RVA = "0xB2D2A8", Offset = "0xB2D2A8", VA = "0xB2D2A8", Slot = "8")]
		public override void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647C")]
		[Address(RVA = "0xB2D888", Offset = "0xB2D888", VA = "0xB2D888")]
		public void GotoAchievement(Achievement achievement)
		{
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647D")]
		[Address(RVA = "0xB2D99C", Offset = "0xB2D99C", VA = "0xB2D99C")]
		private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647E")]
		[Address(RVA = "0xB2DA0C", Offset = "0xB2DA0C", VA = "0xB2DA0C")]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647F")]
		[Address(RVA = "0xB2DBDC", Offset = "0xB2DBDC", VA = "0xB2DBDC")]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006480")]
		[Address(RVA = "0xB2DD9C", Offset = "0xB2DD9C", VA = "0xB2DD9C")]
		private void FilterList(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006481")]
		[Address(RVA = "0xB2E038", Offset = "0xB2E038", VA = "0xB2E038", Slot = "26")]
		public override void OnActivate()
		{
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006482")]
		[Address(RVA = "0xB2E178", Offset = "0xB2E178", VA = "0xB2E178")]
		public UIAchievementsMenu()
		{
		}

		// Token: 0x0400A201 RID: 41473
		[Token(Token = "0x400A201")]
		[FieldOffset(Offset = "0xF4")]
		private UIList _achievementsList;

		// Token: 0x0400A202 RID: 41474
		[Token(Token = "0x400A202")]
		[FieldOffset(Offset = "0xF8")]
		private List<UIAchievementListItem> _achievementElements;

		// Token: 0x0400A203 RID: 41475
		[Token(Token = "0x400A203")]
		[FieldOffset(Offset = "0xFC")]
		private List<UIToggleImage> _categoryButtons;

		// Token: 0x0400A204 RID: 41476
		[Token(Token = "0x400A204")]
		[FieldOffset(Offset = "0x100")]
		private UIElement _backpanel;

		// Token: 0x0400A205 RID: 41477
		[Token(Token = "0x400A205")]
		[FieldOffset(Offset = "0x104")]
		private UIElement _outerContainer;

		// Token: 0x02000D40 RID: 3392
		[Token(Token = "0x2000D40")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06006483 RID: 25731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006483")]
			[Address(RVA = "0xB2D994", Offset = "0xB2D994", VA = "0xB2D994")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06006484 RID: 25732 RVA: 0x0002E008 File Offset: 0x0002C208
			[Token(Token = "0x6006484")]
			[Address(RVA = "0xB2E270", Offset = "0xB2E270", VA = "0xB2E270")]
			internal bool <GotoAchievement>b__0(UIElement element)
			{
				return default(bool);
			}

			// Token: 0x0400A206 RID: 41478
			[Token(Token = "0x400A206")]
			[FieldOffset(Offset = "0x8")]
			public Achievement achievement;
		}
	}
}
