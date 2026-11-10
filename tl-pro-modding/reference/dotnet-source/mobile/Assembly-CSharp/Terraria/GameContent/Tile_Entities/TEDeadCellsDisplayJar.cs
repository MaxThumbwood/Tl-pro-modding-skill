using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	public class TEDeadCellsDisplayJar : TileEntityType<TEDeadCellsDisplayJar>, FileAPI
	{
		// Token: 0x060052CE RID: 21198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x7E7330", Offset = "0x7E7330", VA = "0x7E7330")]
		public TEDeadCellsDisplayJar()
		{
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x000268C8 File Offset: 0x00024AC8
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x7E73C8", Offset = "0x7E73C8", VA = "0x7E73C8", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x000268E0 File Offset: 0x00024AE0
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x7E7788", Offset = "0x7E7788", VA = "0x7E7788")]
		public static int Hook_AfterPlacement(int x, int y, int type = 698, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x000268F8 File Offset: 0x00024AF8
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x7E73D4", Offset = "0x7E73D4", VA = "0x7E73D4")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x7E7918", Offset = "0x7E7918", VA = "0x7E7918", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x7E79B0", Offset = "0x7E79B0", VA = "0x7E79B0", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x7E7AD0", Offset = "0x7E7AD0", VA = "0x7E7AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x7E7CDC", Offset = "0x7E7CDC", VA = "0x7E7CDC")]
		public void DropItem()
		{
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x7E7E84", Offset = "0x7E7E84", VA = "0x7E7E84")]
		public static void TryPlacing(int x, int y, int type, int prefix, int stack)
		{
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x7E8224", Offset = "0x7E8224", VA = "0x7E8224")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x00026910 File Offset: 0x00024B10
		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x7E86FC", Offset = "0x7E86FC", VA = "0x7E86FC")]
		public static bool FitsJar(Item i)
		{
			return default(bool);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x7E8724", Offset = "0x7E8724", VA = "0x7E8724")]
		public static void PlaceItemInJar(Player player, int x, int y)
		{
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x7E8F78", Offset = "0x7E8F78", VA = "0x7E8F78", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x0400970B RID: 38667
		[Token(Token = "0x400970B")]
		[FieldOffset(Offset = "0x14")]
		public Item item;
	}
}
