using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	public class TEHatRack : TileEntityType<TEHatRack>, FileAPI
	{
		// Token: 0x0600530C RID: 21260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530C")]
		[Address(RVA = "0x7F1410", Offset = "0x7F1410", VA = "0x7F1410")]
		public TEHatRack()
		{
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[Token(Token = "0x600530D")]
		[Address(RVA = "0x7F16E4", Offset = "0x7F16E4", VA = "0x7F16E4")]
		public static int Hook_AfterPlacement(int x, int y, int type = 475, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530E")]
		[Address(RVA = "0x7F191C", Offset = "0x7F191C", VA = "0x7F191C", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530F")]
		[Address(RVA = "0x7F1C8C", Offset = "0x7F1C8C", VA = "0x7F1C8C", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005310")]
		[Address(RVA = "0x7F1FC0", Offset = "0x7F1FC0", VA = "0x7F1FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005311")]
		[Address(RVA = "0x7F2294", Offset = "0x7F2294", VA = "0x7F2294")]
		public static void Framing_CheckTile(int callX, int callY)
		{
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005312")]
		[Address(RVA = "0x7F2AD0", Offset = "0x7F2AD0", VA = "0x7F2AD0")]
		public void Draw(int tileLeftX, int tileTopY)
		{
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005313")]
		[Address(RVA = "0x7F31C8", Offset = "0x7F31C8", VA = "0x7F31C8", Slot = "9")]
		public override void OnPlayerUpdate(Player player)
		{
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005314")]
		[Address(RVA = "0x7F330C", Offset = "0x7F330C", VA = "0x7F330C")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005315")]
		[Address(RVA = "0x7F35D0", Offset = "0x7F35D0", VA = "0x7F35D0")]
		private void DrawInner(Player player, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005316")]
		[Address(RVA = "0x7F3684", Offset = "0x7F3684", VA = "0x7F3684")]
		private void DrawSlotPairSet(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
		{
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00026AD8 File Offset: 0x00024CD8
		[Token(Token = "0x6005317")]
		[Address(RVA = "0x7F3A88", Offset = "0x7F3A88", VA = "0x7F3A88", Slot = "11")]
		public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00026AF0 File Offset: 0x00024CF0
		[Token(Token = "0x6005318")]
		[Address(RVA = "0x7F3C1C", Offset = "0x7F3C1C", VA = "0x7F3C1C", Slot = "12")]
		public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00026B08 File Offset: 0x00024D08
		[Token(Token = "0x6005319")]
		[Address(RVA = "0x7F3BF4", Offset = "0x7F3BF4", VA = "0x7F3BF4")]
		public static bool CanQuickSwapIntoHatRack(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00026B20 File Offset: 0x00024D20
		[Token(Token = "0x600531A")]
		[Address(RVA = "0x7F3F60", Offset = "0x7F3F60", VA = "0x7F3F60")]
		private bool TryFitting(Item[] inv, int slot)
		{
			return default(bool);
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600531B")]
		[Address(RVA = "0x7F4324", Offset = "0x7F4324", VA = "0x7F4324")]
		public void WriteItem(int itemIndex, BinaryWriter writer, bool dye)
		{
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600531C")]
		[Address(RVA = "0x7F43FC", Offset = "0x7F43FC", VA = "0x7F43FC")]
		public void ReadItem(int itemIndex, BinaryReader reader, bool dye)
		{
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00026B38 File Offset: 0x00024D38
		[Token(Token = "0x600531D")]
		[Address(RVA = "0x7F4518", Offset = "0x7F4518", VA = "0x7F4518", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x00026B50 File Offset: 0x00024D50
		[Token(Token = "0x600531E")]
		[Address(RVA = "0x7F48CC", Offset = "0x7F48CC", VA = "0x7F48CC")]
		public static bool IsBreakable(int clickX, int clickY)
		{
			return default(bool);
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00026B68 File Offset: 0x00024D68
		[Token(Token = "0x600531F")]
		[Address(RVA = "0x7F4B6C", Offset = "0x7F4B6C", VA = "0x7F4B6C")]
		public bool ContainsItems()
		{
			return default(bool);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005320")]
		[Address(RVA = "0x7F4C4C", Offset = "0x7F4C4C", VA = "0x7F4C4C", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x04009734 RID: 38708
		[Token(Token = "0x4009734")]
		private const int MyTileID = 475;

		// Token: 0x04009735 RID: 38709
		[Token(Token = "0x4009735")]
		public const int entityTileWidth = 3;

		// Token: 0x04009736 RID: 38710
		[Token(Token = "0x4009736")]
		public const int entityTileHeight = 4;

		// Token: 0x04009737 RID: 38711
		[Token(Token = "0x4009737")]
		[FieldOffset(Offset = "0x14")]
		private Player _dollPlayer;

		// Token: 0x04009738 RID: 38712
		[Token(Token = "0x4009738")]
		[FieldOffset(Offset = "0x18")]
		public Item[] _items;

		// Token: 0x04009739 RID: 38713
		[Token(Token = "0x4009739")]
		[FieldOffset(Offset = "0x1C")]
		public Item[] _dyes;

		// Token: 0x0400973A RID: 38714
		[Token(Token = "0x400973A")]
		[FieldOffset(Offset = "0x0")]
		private static int hatTargetSlot;
	}
}
