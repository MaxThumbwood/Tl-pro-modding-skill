using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2000B60")]
	public class StairwellDungeonHall : DungeonHall
	{
		// Token: 0x060059C7 RID: 22983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x8B7730", Offset = "0x8B7730", VA = "0x8B7730")]
		public StairwellDungeonHall(StairwellDungeonHallSettings settings)
		{
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x8B77B4", Offset = "0x8B77B4", VA = "0x8B77B4", Slot = "5")]
		public override void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x8B7904", Offset = "0x8B7904", VA = "0x8B7904", Slot = "4")]
		public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
		{
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x8B840C", Offset = "0x8B840C", VA = "0x8B840C", Slot = "6")]
		public override void GenerateHall(DungeonData data)
		{
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CB")]
		[Address(RVA = "0x8B7958", Offset = "0x8B7958", VA = "0x8B7958")]
		public void Stairwell(DungeonData data, Vector2D startPoint, Vector2D endPoint, bool generating = false)
		{
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x0002A060 File Offset: 0x00028260
		[Token(Token = "0x60059CC")]
		[Address(RVA = "0x8B8454", Offset = "0x8B8454", VA = "0x8B8454")]
		private Vector2D CalculateZigZagSlope(Vector2D startPoint, Vector2D endPoint, double gradient)
		{
			return default(Vector2D);
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CD")]
		[Address(RVA = "0x8B8738", Offset = "0x8B8738", VA = "0x8B8738")]
		private void GenerateHallway(DungeonData data, Vector2D startPoint, Vector2D endPoint, List<DungeonRoom> roomsInArea, bool crackedBricks, bool generating)
		{
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x0002A078 File Offset: 0x00028278
		[Token(Token = "0x60059CE")]
		[Address(RVA = "0x8B8B30", Offset = "0x8B8B30", VA = "0x8B8B30", Slot = "8")]
		public override bool CanPlaceTileAt(DungeonData data, Tile tile, int tileType, int tileCrackedType)
		{
			return default(bool);
		}
	}
}
