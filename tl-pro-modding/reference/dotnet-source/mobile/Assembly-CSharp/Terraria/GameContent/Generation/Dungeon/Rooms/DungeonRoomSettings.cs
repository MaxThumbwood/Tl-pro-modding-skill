using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	public abstract class DungeonRoomSettings
	{
		// Token: 0x0600591E RID: 22814
		[Token(Token = "0x600591E")]
		public abstract int GetBoundingRadius();

		// Token: 0x0600591F RID: 22815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591F")]
		[Address(RVA = "0x890F7C", Offset = "0x890F7C", VA = "0x890F7C")]
		protected DungeonRoomSettings()
		{
		}

		// Token: 0x04009AC7 RID: 39623
		[Token(Token = "0x4009AC7")]
		[FieldOffset(Offset = "0x8")]
		public DungeonControlLine ControlLine;

		// Token: 0x04009AC8 RID: 39624
		[Token(Token = "0x4009AC8")]
		[FieldOffset(Offset = "0xC")]
		public Point RoomPosition;

		// Token: 0x04009AC9 RID: 39625
		[Token(Token = "0x4009AC9")]
		[FieldOffset(Offset = "0x14")]
		public DungeonRoomType RoomType;

		// Token: 0x04009ACA RID: 39626
		[Token(Token = "0x4009ACA")]
		[FieldOffset(Offset = "0x18")]
		public int RandomSeed;

		// Token: 0x04009ACB RID: 39627
		[Token(Token = "0x4009ACB")]
		[FieldOffset(Offset = "0x1C")]
		public DungeonGenerationStyleData StyleData;

		// Token: 0x04009ACC RID: 39628
		[Token(Token = "0x4009ACC")]
		[FieldOffset(Offset = "0x20")]
		public int ProgressionStage;

		// Token: 0x04009ACD RID: 39629
		[Token(Token = "0x4009ACD")]
		[FieldOffset(Offset = "0x24")]
		public bool StartingRoom;

		// Token: 0x04009ACE RID: 39630
		[Token(Token = "0x4009ACE")]
		[FieldOffset(Offset = "0x28")]
		public int OverridePaintTile;

		// Token: 0x04009ACF RID: 39631
		[Token(Token = "0x4009ACF")]
		[FieldOffset(Offset = "0x2C")]
		public int OverridePaintWall;

		// Token: 0x04009AD0 RID: 39632
		[Token(Token = "0x4009AD0")]
		[FieldOffset(Offset = "0x30")]
		public bool ForceStyleForDoorsAndPlatforms;

		// Token: 0x04009AD1 RID: 39633
		[Token(Token = "0x4009AD1")]
		[FieldOffset(Offset = "0x31")]
		public bool OnCurvedLine;

		// Token: 0x04009AD2 RID: 39634
		[Token(Token = "0x4009AD2")]
		[FieldOffset(Offset = "0x34")]
		public SnakeOrientation Orientation;

		// Token: 0x04009AD3 RID: 39635
		[Token(Token = "0x4009AD3")]
		[FieldOffset(Offset = "0x38")]
		public DungeonUtils.GetHallwayConnectionPoint HallwayConnectionPointOverride;

		// Token: 0x04009AD4 RID: 39636
		[Token(Token = "0x4009AD4")]
		[FieldOffset(Offset = "0x3C")]
		public int? HallwayPointAdjuster;
	}
}
