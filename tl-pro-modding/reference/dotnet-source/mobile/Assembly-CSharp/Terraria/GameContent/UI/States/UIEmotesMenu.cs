using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000D41 RID: 3393
	[Token(Token = "0x2000D41")]
	public class UIEmotesMenu : UIState
	{
		// Token: 0x06006485 RID: 25733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006485")]
		[Address(RVA = "0xB2E31C", Offset = "0xB2E31C", VA = "0xB2E31C", Slot = "26")]
		public override void OnActivate()
		{
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006486")]
		[Address(RVA = "0xB2E440", Offset = "0xB2E440", VA = "0xB2E440")]
		public void InitializePage()
		{
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006487")]
		[Address(RVA = "0xB2FAEC", Offset = "0xB2FAEC", VA = "0xB2FAEC")]
		private void TryAddingList(LocalizedText title, ref int currentGroupIndex, int maxEmotesPerRow, List<int> emoteIds)
		{
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006488")]
		[Address(RVA = "0xB2EEC0", Offset = "0xB2EEC0", VA = "0xB2EEC0")]
		private List<int> GetEmotesGeneral()
		{
			return null;
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006489")]
		[Address(RVA = "0xB2FC0C", Offset = "0xB2FC0C", VA = "0xB2FC0C")]
		private List<int> GetEmotesRPS()
		{
			return null;
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648A")]
		[Address(RVA = "0xB2FF2C", Offset = "0xB2FF2C", VA = "0xB2FF2C")]
		private List<int> GetEmotesItems()
		{
			return null;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648B")]
		[Address(RVA = "0xB30900", Offset = "0xB30900", VA = "0xB30900")]
		private List<int> GetEmotesBiomesAndEvents()
		{
			return null;
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648C")]
		[Address(RVA = "0xB312D4", Offset = "0xB312D4", VA = "0xB312D4")]
		private List<int> GetEmotesTownNPCs()
		{
			return null;
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648D")]
		[Address(RVA = "0xB31F64", Offset = "0xB31F64", VA = "0xB31F64")]
		private List<int> GetEmotesCritters()
		{
			return null;
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648E")]
		[Address(RVA = "0xB323BC", Offset = "0xB323BC", VA = "0xB323BC")]
		private List<int> GetEmotesBosses()
		{
			return null;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648F")]
		[Address(RVA = "0xB33510", Offset = "0xB33510", VA = "0xB33510", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006490")]
		[Address(RVA = "0xB33694", Offset = "0xB33694", VA = "0xB33694")]
		private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006491")]
		[Address(RVA = "0xB33704", Offset = "0xB33704", VA = "0xB33704")]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006492")]
		[Address(RVA = "0xB338D4", Offset = "0xB338D4", VA = "0xB338D4")]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006493")]
		[Address(RVA = "0xB33A94", Offset = "0xB33A94", VA = "0xB33A94", Slot = "8")]
		public override void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006494")]
		[Address(RVA = "0xB33A9C", Offset = "0xB33A9C", VA = "0xB33A9C")]
		public UIEmotesMenu()
		{
		}

		// Token: 0x0400A207 RID: 41479
		[Token(Token = "0x400A207")]
		[FieldOffset(Offset = "0xF4")]
		private UIElement _outerContainer;

		// Token: 0x0400A208 RID: 41480
		[Token(Token = "0x400A208")]
		[FieldOffset(Offset = "0xF8")]
		private UIElement _backPanel;

		// Token: 0x0400A209 RID: 41481
		[Token(Token = "0x400A209")]
		[FieldOffset(Offset = "0xFC")]
		private UIElement _container;

		// Token: 0x0400A20A RID: 41482
		[Token(Token = "0x400A20A")]
		[FieldOffset(Offset = "0x100")]
		private UIList _list;

		// Token: 0x0400A20B RID: 41483
		[Token(Token = "0x400A20B")]
		[FieldOffset(Offset = "0x104")]
		private UIScrollbar _scrollBar;

		// Token: 0x0400A20C RID: 41484
		[Token(Token = "0x400A20C")]
		[FieldOffset(Offset = "0x108")]
		private bool _isScrollbarAttached;
	}
}
