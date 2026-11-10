using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Entrances;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	public class DungeonGenVars
	{
		// Token: 0x06005886 RID: 22662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005886")]
		[Address(RVA = "0x873E3C", Offset = "0x873E3C", VA = "0x873E3C")]
		public DungeonGenVars()
		{
		}

		// Token: 0x040099DE RID: 39390
		[Token(Token = "0x40099DE")]
		[FieldOffset(Offset = "0x8")]
		public int dungeonSide;

		// Token: 0x040099DF RID: 39391
		[Token(Token = "0x40099DF")]
		[FieldOffset(Offset = "0xC")]
		public int dungeonLocation;

		// Token: 0x040099E0 RID: 39392
		[Token(Token = "0x40099E0")]
		[FieldOffset(Offset = "0x10")]
		public DungeonColor dungeonColor;

		// Token: 0x040099E1 RID: 39393
		[Token(Token = "0x40099E1")]
		[FieldOffset(Offset = "0x14")]
		public ushort brickTileType;

		// Token: 0x040099E2 RID: 39394
		[Token(Token = "0x40099E2")]
		[FieldOffset(Offset = "0x16")]
		public ushort brickWallType;

		// Token: 0x040099E3 RID: 39395
		[Token(Token = "0x40099E3")]
		[FieldOffset(Offset = "0x18")]
		public ushort brickCrackedTileType;

		// Token: 0x040099E4 RID: 39396
		[Token(Token = "0x40099E4")]
		[FieldOffset(Offset = "0x1A")]
		public ushort windowGlassWallType;

		// Token: 0x040099E5 RID: 39397
		[Token(Token = "0x40099E5")]
		[FieldOffset(Offset = "0x1C")]
		public ushort windowClosedGlassWallType;

		// Token: 0x040099E6 RID: 39398
		[Token(Token = "0x40099E6")]
		[FieldOffset(Offset = "0x1E")]
		public ushort windowEdgeWallType;

		// Token: 0x040099E7 RID: 39399
		[Token(Token = "0x40099E7")]
		[FieldOffset(Offset = "0x20")]
		public int[] windowPlatformItemTypes;

		// Token: 0x040099E8 RID: 39400
		[Token(Token = "0x40099E8")]
		[FieldOffset(Offset = "0x24")]
		public int generatingDungeonPositionX;

		// Token: 0x040099E9 RID: 39401
		[Token(Token = "0x40099E9")]
		[FieldOffset(Offset = "0x28")]
		public int generatingDungeonPositionY;

		// Token: 0x040099EA RID: 39402
		[Token(Token = "0x40099EA")]
		[FieldOffset(Offset = "0x2C")]
		public int generatingDungeonTopX;

		// Token: 0x040099EB RID: 39403
		[Token(Token = "0x40099EB")]
		[FieldOffset(Offset = "0x30")]
		public int dungeonLootStyle;

		// Token: 0x040099EC RID: 39404
		[Token(Token = "0x40099EC")]
		[FieldOffset(Offset = "0x34")]
		public DungeonBounds outerPotentialDungeonBounds;

		// Token: 0x040099ED RID: 39405
		[Token(Token = "0x40099ED")]
		[FieldOffset(Offset = "0x38")]
		public DungeonBounds innerPotentialDungeonBounds;

		// Token: 0x040099EE RID: 39406
		[Token(Token = "0x40099EE")]
		[FieldOffset(Offset = "0x3C")]
		public DungeonGenerationStyleData dungeonStyle;

		// Token: 0x040099EF RID: 39407
		[Token(Token = "0x40099EF")]
		[FieldOffset(Offset = "0x40")]
		public List<DungeonGenerationStyleData> dungeonGenerationStyles;

		// Token: 0x040099F0 RID: 39408
		[Token(Token = "0x40099F0")]
		[FieldOffset(Offset = "0x44")]
		public DitherSnake dungeonDitherSnake;

		// Token: 0x040099F1 RID: 39409
		[Token(Token = "0x40099F1")]
		[FieldOffset(Offset = "0x48")]
		public bool[] isCrackedBrick;

		// Token: 0x040099F2 RID: 39410
		[Token(Token = "0x40099F2")]
		[FieldOffset(Offset = "0x4C")]
		public bool[] isPitTrapTile;

		// Token: 0x040099F3 RID: 39411
		[Token(Token = "0x40099F3")]
		[FieldOffset(Offset = "0x50")]
		public bool[] isDungeonTile;

		// Token: 0x040099F4 RID: 39412
		[Token(Token = "0x40099F4")]
		[FieldOffset(Offset = "0x54")]
		public bool[] isDungeonWall;

		// Token: 0x040099F5 RID: 39413
		[Token(Token = "0x40099F5")]
		[FieldOffset(Offset = "0x58")]
		public bool[] isDungeonWallEdge;

		// Token: 0x040099F6 RID: 39414
		[Token(Token = "0x40099F6")]
		[FieldOffset(Offset = "0x5C")]
		public bool[] isDungeonWallGlass;

		// Token: 0x040099F7 RID: 39415
		[Token(Token = "0x40099F7")]
		[FieldOffset(Offset = "0x60")]
		public bool GeneratingDungeon;

		// Token: 0x040099F8 RID: 39416
		[Token(Token = "0x40099F8")]
		[FieldOffset(Offset = "0x64")]
		public PreGenDungeonEntranceSettings preGenDungeonEntranceSettings;

		// Token: 0x040099F9 RID: 39417
		[Token(Token = "0x40099F9")]
		[FieldOffset(Offset = "0x68")]
		public Vector2D dungeonEntrancePosition;

		// Token: 0x040099FA RID: 39418
		[Token(Token = "0x40099FA")]
		[FieldOffset(Offset = "0x78")]
		public bool desertChestLootState;
	}
}
