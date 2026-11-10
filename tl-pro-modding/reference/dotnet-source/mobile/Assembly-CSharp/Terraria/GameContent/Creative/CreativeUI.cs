using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class CreativeUI
	{
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		// (set) Token: 0x060061A8 RID: 25000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A95")]
		public bool Enabled
		{
			[Token(Token = "0x60061A7")]
			[Address(RVA = "0xAB8654", Offset = "0xAB8654", VA = "0xAB8654")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061A8")]
			[Address(RVA = "0xAB865C", Offset = "0xAB865C", VA = "0xAB865C")]
			private set
			{
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060061A9 RID: 25001 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		[Token(Token = "0x17000A96")]
		public bool Blocked
		{
			[Token(Token = "0x60061A9")]
			[Address(RVA = "0xAB8664", Offset = "0xAB8664", VA = "0xAB8664")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0xAB8758", Offset = "0xAB8758", VA = "0xAB8758")]
		public CreativeUI()
		{
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0xAB8878", Offset = "0xAB8878", VA = "0xAB8878")]
		public void Initialize()
		{
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0xAB8A78", Offset = "0xAB8A78", VA = "0xAB8A78")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0xAB8A7C", Offset = "0xAB8A7C", VA = "0xAB8A7C")]
		public UIElement ProvideItemSlotElement(int itemSlotContext)
		{
			return null;
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AE")]
		[Address(RVA = "0xAB8B18", Offset = "0xAB8B18", VA = "0xAB8B18")]
		public Item GetItemByIndex(int itemSlotContext)
		{
			return null;
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AF")]
		[Address(RVA = "0xAB8B48", Offset = "0xAB8B48", VA = "0xAB8B48")]
		public void SetItembyIndex(Item item, int itemSlotContext)
		{
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0xAB8BAC", Offset = "0xAB8BAC", VA = "0xAB8BAC")]
		public void SwapItem(ref Item item)
		{
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B1")]
		[Address(RVA = "0xAB8C48", Offset = "0xAB8C48", VA = "0xAB8C48")]
		public void CloseMenu()
		{
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0xAB8C60", Offset = "0xAB8C60", VA = "0xAB8C60")]
		public bool IsShowingResearchMenu()
		{
			return default(bool);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0xAB8C68", Offset = "0xAB8C68", VA = "0xAB8C68")]
		public void SacrificeItemInSacrificeSlot()
		{
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B4")]
		[Address(RVA = "0xAB8C5C", Offset = "0xAB8C5C", VA = "0xAB8C5C")]
		public void StopPlayingSacrificeAnimations()
		{
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x0002D108 File Offset: 0x0002B308
		[Token(Token = "0x60061B5")]
		[Address(RVA = "0xAB8C6C", Offset = "0xAB8C6C", VA = "0xAB8C6C")]
		public bool ShouldDrawSacrificeArea()
		{
			return default(bool);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x0002D120 File Offset: 0x0002B320
		[Token(Token = "0x60061B6")]
		[Address(RVA = "0xAB8E14", Offset = "0xAB8E14", VA = "0xAB8E14")]
		public bool GetSacrificeNumbers(out int itemIdChecked, out int amountWeHave, out int amountNeededTotal)
		{
			return default(bool);
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0002D138 File Offset: 0x0002B338
		[Token(Token = "0x60061B7")]
		[Address(RVA = "0xAB8F30", Offset = "0xAB8F30", VA = "0xAB8F30")]
		public CreativeUI.ItemSacrificeResult SacrificeItem(out int amountWeSacrificed)
		{
			return CreativeUI.ItemSacrificeResult.CannotSacrifice;
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x0002D150 File Offset: 0x0002B350
		[Token(Token = "0x60061B8")]
		[Address(RVA = "0xAB8F6C", Offset = "0xAB8F6C", VA = "0xAB8F6C")]
		public CreativeUI.ItemSacrificeResult SacrificeItem(ref Item item, out int amountWeSacrificed, bool spawnExcessItem = true, bool onlySacrificeIfItWouldFinishResearch = false)
		{
			return CreativeUI.ItemSacrificeResult.CannotSacrifice;
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B9")]
		[Address(RVA = "0xAB93C4", Offset = "0xAB93C4", VA = "0xAB93C4")]
		public void Reset()
		{
		}

		// Token: 0x0400A046 RID: 41030
		[Token(Token = "0x400A046")]
		public const int ItemSlotIndexes_SacrificeItem = 0;

		// Token: 0x0400A047 RID: 41031
		[Token(Token = "0x400A047")]
		public const int ItemSlotIndexes_Count = 1;

		// Token: 0x0400A048 RID: 41032
		[Token(Token = "0x400A048")]
		[FieldOffset(Offset = "0x8")]
		private bool <Enabled>k__BackingField;

		// Token: 0x0400A049 RID: 41033
		[Token(Token = "0x400A049")]
		[FieldOffset(Offset = "0x9")]
		private bool _initialized;

		// Token: 0x0400A04A RID: 41034
		[Token(Token = "0x400A04A")]
		[FieldOffset(Offset = "0xC")]
		private Asset<Texture2D> _buttonTexture;

		// Token: 0x0400A04B RID: 41035
		[Token(Token = "0x400A04B")]
		[FieldOffset(Offset = "0x10")]
		private Asset<Texture2D> _buttonBorderTexture;

		// Token: 0x0400A04C RID: 41036
		[Token(Token = "0x400A04C")]
		[FieldOffset(Offset = "0x14")]
		private Item[] _itemSlotsForUI;

		// Token: 0x02000CDA RID: 3290
		[Token(Token = "0x2000CDA")]
		public enum ItemSacrificeResult
		{
			// Token: 0x0400A04E RID: 41038
			[Token(Token = "0x400A04E")]
			CannotSacrifice,
			// Token: 0x0400A04F RID: 41039
			[Token(Token = "0x400A04F")]
			SacrificedButNotDone,
			// Token: 0x0400A050 RID: 41040
			[Token(Token = "0x400A050")]
			SacrificedAndDone
		}
	}
}
