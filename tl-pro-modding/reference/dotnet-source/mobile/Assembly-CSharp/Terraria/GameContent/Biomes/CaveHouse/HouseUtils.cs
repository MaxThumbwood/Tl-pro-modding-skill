using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000BC3 RID: 3011
	[Token(Token = "0x2000BC3")]
	public static class HouseUtils
	{
		// Token: 0x06005B7E RID: 23422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0x988DE0", Offset = "0x988DE0", VA = "0x988DE0")]
		public static HouseBuilder CreateBuilder(Point origin, StructureMap structures)
		{
			return null;
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x0002AF18 File Offset: 0x00029118
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0x98B7BC", Offset = "0x98B7BC", VA = "0x98B7BC")]
		public static int GetMaxPossibleRoomsInABigAbandonedHouse()
		{
			return 0;
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x0002AF30 File Offset: 0x00029130
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0x98B83C", Offset = "0x98B83C", VA = "0x98B83C")]
		public static int GetRandomizedRoomCountInABigAbandonedHouse()
		{
			return 0;
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x98BA40", Offset = "0x98BA40", VA = "0x98BA40")]
		private static List<Rectangle> CreateRooms_BigAbandonedHouses(Point origin)
		{
			return null;
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x989508", Offset = "0x989508", VA = "0x989508")]
		private static List<Rectangle> CreateRooms(Point origin)
		{
			return null;
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x0002AF48 File Offset: 0x00029148
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x98BF0C", Offset = "0x98BF0C", VA = "0x98BF0C")]
		private static Rectangle FindRoom(Point origin)
		{
			return default(Rectangle);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x0002AF60 File Offset: 0x00029160
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x98C670", Offset = "0x98C670", VA = "0x98C670")]
		private static Rectangle FindRoom_BigAbandonedHouses(Point origin, Rectangle lastRoom)
		{
			return default(Rectangle);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x0002AF78 File Offset: 0x00029178
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x98CD94", Offset = "0x98CD94", VA = "0x98CD94")]
		private static double GetRoomSolidPrecentage(Rectangle room)
		{
			return 0.0;
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x0002AF90 File Offset: 0x00029190
		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x989D0C", Offset = "0x989D0C", VA = "0x989D0C")]
		private static bool AreRoomLocationsValid(IEnumerable<Rectangle> rooms)
		{
			return default(bool);
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x0002AFA8 File Offset: 0x000291A8
		[Token(Token = "0x6005B87")]
		[Address(RVA = "0x98A12C", Offset = "0x98A12C", VA = "0x98A12C")]
		private static HouseType GetHouseType(IEnumerable<Rectangle> rooms)
		{
			return HouseType.Wood;
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x0002AFC0 File Offset: 0x000291C0
		[Token(Token = "0x6005B88")]
		[Address(RVA = "0x98AD1C", Offset = "0x98AD1C", VA = "0x98AD1C")]
		private static bool AreRoomsValid(IEnumerable<Rectangle> rooms, StructureMap structures, HouseType style)
		{
			return default(bool);
		}

		// Token: 0x04009C3B RID: 39995
		[Token(Token = "0x4009C3B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool[] BlacklistedTiles;

		// Token: 0x04009C3C RID: 39996
		[Token(Token = "0x4009C3C")]
		[FieldOffset(Offset = "0x4")]
		private static readonly bool[] BeelistedTiles;
	}
}
