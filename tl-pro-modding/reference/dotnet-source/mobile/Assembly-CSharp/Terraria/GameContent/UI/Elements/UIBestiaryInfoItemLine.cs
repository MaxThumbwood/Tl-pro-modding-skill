using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D70 RID: 3440
	[Token(Token = "0x2000D70")]
	public class UIBestiaryInfoItemLine : UIPanel, FileAPI
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x0002E308 File Offset: 0x0002C508
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE5")]
		public int OrderInUIList
		{
			[Token(Token = "0x60065CD")]
			[Address(RVA = "0xB54B14", Offset = "0xB54B14", VA = "0xB54B14", Slot = "30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60065CE")]
			[Address(RVA = "0xB54B1C", Offset = "0xB54B1C", VA = "0xB54B1C", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0xB54B24", Offset = "0xB54B24", VA = "0xB54B24")]
		public UIBestiaryInfoItemLine(DropRateInfo info, BestiaryUICollectionInfo uiinfo, float textScale = 1f)
		{
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0xB55698", Offset = "0xB55698", VA = "0xB55698")]
		public static void GetDropInfo(DropRateInfo dropRateInfo, BestiaryUICollectionInfo uiinfo, out string stackRange, out string droprate)
		{
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0xB55920", Offset = "0xB55920", VA = "0xB55920", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xB55958", Offset = "0xB55958", VA = "0xB55958")]
		private void DrawMouseOver()
		{
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x0002E320 File Offset: 0x0002C520
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xB55A3C", Offset = "0xB55A3C", VA = "0xB55A3C", Slot = "29")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xB55348", Offset = "0xB55348", VA = "0xB55348")]
		private void SetBestiaryNotesOnItemCache(DropRateInfo info)
		{
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0xB55B40", Offset = "0xB55B40", VA = "0xB55B40")]
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0xB55BDC", Offset = "0xB55BDC", VA = "0xB55BDC")]
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0400A31F RID: 41759
		[Token(Token = "0x400A31F")]
		[FieldOffset(Offset = "0x10C")]
		private int <OrderInUIList>k__BackingField;

		// Token: 0x0400A320 RID: 41760
		[Token(Token = "0x400A320")]
		[FieldOffset(Offset = "0x110")]
		private Item _infoDisplayItem;

		// Token: 0x0400A321 RID: 41761
		[Token(Token = "0x400A321")]
		[FieldOffset(Offset = "0x114")]
		private bool _hideMouseOver;
	}
}
