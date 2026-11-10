using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Testing;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D7C RID: 3452
	[Token(Token = "0x2000D7C")]
	public class UIDebugLoadoutItem : UIPanel
	{
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600660D RID: 26125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600660E RID: 26126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AED")]
		public ScenarioTestLoadout Loadout
		{
			[Token(Token = "0x600660D")]
			[Address(RVA = "0xB59C48", Offset = "0xB59C48", VA = "0xB59C48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600660E")]
			[Address(RVA = "0xB59C50", Offset = "0xB59C50", VA = "0xB59C50")]
			set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEE")]
		public string Name
		{
			[Token(Token = "0x600660F")]
			[Address(RVA = "0xB59C58", Offset = "0xB59C58", VA = "0xB59C58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006610")]
			[Address(RVA = "0xB59C60", Offset = "0xB59C60", VA = "0xB59C60")]
			set
			{
			}
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x0002E428 File Offset: 0x0002C628
		[Token(Token = "0x6006611")]
		[Address(RVA = "0xB59C68", Offset = "0xB59C68", VA = "0xB59C68", Slot = "29")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006612")]
		[Address(RVA = "0xB59D4C", Offset = "0xB59D4C", VA = "0xB59D4C")]
		public UIDebugLoadoutItem(ScenarioTestLoadout loadout, string friendlyName)
		{
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006613")]
		[Address(RVA = "0xB5A7D4", Offset = "0xB5A7D4", VA = "0xB5A7D4")]
		private void PositionItems(List<UIElement> items, float horizontalStart, float horizontalEnd, float vertical)
		{
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006614")]
		[Address(RVA = "0xB5AA20", Offset = "0xB5AA20", VA = "0xB5AA20", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006615")]
		[Address(RVA = "0xB5AC98", Offset = "0xB5AC98", VA = "0xB5AC98", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006616")]
		[Address(RVA = "0xB5AFD8", Offset = "0xB5AFD8", VA = "0xB5AFD8", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006617")]
		[Address(RVA = "0xB5B0BC", Offset = "0xB5B0BC", VA = "0xB5B0BC", Slot = "17")]
		public override void LeftClick(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A357 RID: 41815
		[Token(Token = "0x400A357")]
		[FieldOffset(Offset = "0x10C")]
		private ScenarioTestLoadout <Loadout>k__BackingField;

		// Token: 0x0400A358 RID: 41816
		[Token(Token = "0x400A358")]
		[FieldOffset(Offset = "0x110")]
		private string <Name>k__BackingField;

		// Token: 0x0400A359 RID: 41817
		[Token(Token = "0x400A359")]
		[FieldOffset(Offset = "0x114")]
		private readonly Asset<Texture2D> _dividerTexture;

		// Token: 0x0400A35A RID: 41818
		[Token(Token = "0x400A35A")]
		[FieldOffset(Offset = "0x118")]
		private readonly Asset<Texture2D> _innerPanelTexture;

		// Token: 0x0400A35B RID: 41819
		[Token(Token = "0x400A35B")]
		[FieldOffset(Offset = "0x11C")]
		private readonly UIText _hoverInfoLabel;

		// Token: 0x0400A35C RID: 41820
		[Token(Token = "0x400A35C")]
		[FieldOffset(Offset = "0x120")]
		private ItemTooltip _preparedTooltip;
	}
}
