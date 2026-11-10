using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public class TEItemFrame : TileEntityType<TEItemFrame>, FileAPI
	{
		// Token: 0x06005321 RID: 21281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005321")]
		[Address(RVA = "0x7F4D00", Offset = "0x7F4D00", VA = "0x7F4D00")]
		public TEItemFrame()
		{
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00026B80 File Offset: 0x00024D80
		[Token(Token = "0x6005322")]
		[Address(RVA = "0x7F4D98", Offset = "0x7F4D98", VA = "0x7F4D98", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x00026B98 File Offset: 0x00024D98
		[Token(Token = "0x6005323")]
		[Address(RVA = "0x7F5158", Offset = "0x7F5158", VA = "0x7F5158")]
		public static int Hook_AfterPlacement(int x, int y, int type = 395, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x00026BB0 File Offset: 0x00024DB0
		[Token(Token = "0x6005324")]
		[Address(RVA = "0x7F4DA4", Offset = "0x7F4DA4", VA = "0x7F4DA4")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005325")]
		[Address(RVA = "0x7F52E8", Offset = "0x7F52E8", VA = "0x7F52E8", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005326")]
		[Address(RVA = "0x7F5380", Offset = "0x7F5380", VA = "0x7F5380", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005327")]
		[Address(RVA = "0x7F54A0", Offset = "0x7F54A0", VA = "0x7F54A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005328")]
		[Address(RVA = "0x7F56AC", Offset = "0x7F56AC", VA = "0x7F56AC")]
		public void DropItem()
		{
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005329")]
		[Address(RVA = "0x7F5850", Offset = "0x7F5850", VA = "0x7F5850")]
		public static void TryPlacing(int x, int y, int type, int prefix, int stack)
		{
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532A")]
		[Address(RVA = "0x7F5BAC", Offset = "0x7F5BAC", VA = "0x7F5BAC")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[Token(Token = "0x600532B")]
		[Address(RVA = "0x7F6080", Offset = "0x7F6080", VA = "0x7F6080")]
		public static bool FitsItemFrame(Item i)
		{
			return default(bool);
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532C")]
		[Address(RVA = "0x7F60A8", Offset = "0x7F60A8", VA = "0x7F60A8")]
		public static void PlaceItemInFrame(Player player, int x, int y)
		{
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532D")]
		[Address(RVA = "0x7F68E4", Offset = "0x7F68E4", VA = "0x7F68E4", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x0400973E RID: 38718
		[Token(Token = "0x400973E")]
		[FieldOffset(Offset = "0x14")]
		public Item item;
	}
}
