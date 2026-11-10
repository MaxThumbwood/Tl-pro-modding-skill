using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	public class TEFoodPlatter : TileEntityType<TEFoodPlatter>, FileAPI
	{
		// Token: 0x060052FF RID: 21247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FF")]
		[Address(RVA = "0x7EFBE0", Offset = "0x7EFBE0", VA = "0x7EFBE0")]
		public TEFoodPlatter()
		{
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00026A60 File Offset: 0x00024C60
		[Token(Token = "0x6005300")]
		[Address(RVA = "0x7EFC78", Offset = "0x7EFC78", VA = "0x7EFC78", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00026A78 File Offset: 0x00024C78
		[Token(Token = "0x6005301")]
		[Address(RVA = "0x7EFF4C", Offset = "0x7EFF4C", VA = "0x7EFF4C")]
		public static int Hook_AfterPlacement(int x, int y, int type = 520, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00026A90 File Offset: 0x00024C90
		[Token(Token = "0x6005302")]
		[Address(RVA = "0x7EFC84", Offset = "0x7EFC84", VA = "0x7EFC84")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005303")]
		[Address(RVA = "0x7F00D4", Offset = "0x7F00D4", VA = "0x7F00D4", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005304")]
		[Address(RVA = "0x7F016C", Offset = "0x7F016C", VA = "0x7F016C", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005305")]
		[Address(RVA = "0x7F028C", Offset = "0x7F028C", VA = "0x7F028C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005306")]
		[Address(RVA = "0x7F0498", Offset = "0x7F0498", VA = "0x7F0498")]
		public void DropItem()
		{
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005307")]
		[Address(RVA = "0x7F063C", Offset = "0x7F063C", VA = "0x7F063C")]
		public static void TryPlacing(int x, int y, int type, int prefix, int stack)
		{
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005308")]
		[Address(RVA = "0x7F0998", Offset = "0x7F0998", VA = "0x7F0998")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00026AA8 File Offset: 0x00024CA8
		[Token(Token = "0x6005309")]
		[Address(RVA = "0x7F0CF8", Offset = "0x7F0CF8", VA = "0x7F0CF8")]
		public static bool FitsFoodPlatter(Item i)
		{
			return default(bool);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530A")]
		[Address(RVA = "0x7F0DA0", Offset = "0x7F0DA0", VA = "0x7F0DA0")]
		public static void PlaceItemInFrame(Player player, int x, int y)
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530B")]
		[Address(RVA = "0x7F13EC", Offset = "0x7F13EC", VA = "0x7F13EC", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x04009733 RID: 38707
		[Token(Token = "0x4009733")]
		[FieldOffset(Offset = "0x14")]
		public Item item;
	}
}
