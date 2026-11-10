using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	public class TEWeaponsRack : TileEntityType<TEWeaponsRack>, FileAPI
	{
		// Token: 0x06005385 RID: 21381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x7FEDBC", Offset = "0x7FEDBC", VA = "0x7FEDBC")]
		public TEWeaponsRack()
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x7FEE54", Offset = "0x7FEE54", VA = "0x7FEE54", Slot = "14")]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x7FEE60", Offset = "0x7FEE60", VA = "0x7FEE60")]
		public static void NetPlaceEntity(int x, int y)
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00026E38 File Offset: 0x00025038
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x7FEF40", Offset = "0x7FEF40", VA = "0x7FEF40", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00026E50 File Offset: 0x00025050
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x7FEF4C", Offset = "0x7FEF4C", VA = "0x7FEF4C")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00026E68 File Offset: 0x00025068
		[Token(Token = "0x600538A")]
		[Address(RVA = "0x7FF300", Offset = "0x7FF300", VA = "0x7FF300")]
		public static int Hook_AfterPlacement(int x, int y, int type = 471, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538B")]
		[Address(RVA = "0x7FF490", Offset = "0x7FF490", VA = "0x7FF490", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538C")]
		[Address(RVA = "0x7FF528", Offset = "0x7FF528", VA = "0x7FF528", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538D")]
		[Address(RVA = "0x7FF648", Offset = "0x7FF648", VA = "0x7FF648", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538E")]
		[Address(RVA = "0x7FF854", Offset = "0x7FF854", VA = "0x7FF854")]
		public static void Framing_CheckTile(int callX, int callY)
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538F")]
		[Address(RVA = "0x800138", Offset = "0x800138", VA = "0x800138")]
		public void DropItem()
		{
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005390")]
		[Address(RVA = "0x8002DC", Offset = "0x8002DC", VA = "0x8002DC")]
		public static void TryPlacing(int x, int y, int type, int prefix, int stack)
		{
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005391")]
		[Address(RVA = "0x800638", Offset = "0x800638", VA = "0x800638")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00026E80 File Offset: 0x00025080
		[Token(Token = "0x6005392")]
		[Address(RVA = "0x800AE4", Offset = "0x800AE4", VA = "0x800AE4")]
		public static bool FitsWeaponFrame(Item i)
		{
			return default(bool);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005393")]
		[Address(RVA = "0x800BEC", Offset = "0x800BEC", VA = "0x800BEC")]
		private static void PlaceItemInFrame(Player player, int x, int y)
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005394")]
		[Address(RVA = "0x801424", Offset = "0x801424", VA = "0x801424", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x0400975D RID: 38749
		[Token(Token = "0x400975D")]
		[FieldOffset(Offset = "0x14")]
		public Item item;

		// Token: 0x0400975E RID: 38750
		[Token(Token = "0x400975E")]
		private const int MyTileID = 471;
	}
}
