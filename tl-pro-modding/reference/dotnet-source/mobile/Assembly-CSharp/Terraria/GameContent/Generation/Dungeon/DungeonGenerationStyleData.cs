using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	public class DungeonGenerationStyleData
	{
		// Token: 0x06005893 RID: 22675 RVA: 0x00029448 File Offset: 0x00027648
		[Token(Token = "0x6005893")]
		[Address(RVA = "0x87531C", Offset = "0x87531C", VA = "0x87531C", Slot = "4")]
		public virtual bool CanGenerateFeatureAt(DungeonData data, DungeonRoom room, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005894")]
		[Address(RVA = "0x875324", Offset = "0x875324", VA = "0x875324", Slot = "5")]
		public virtual void GetBookshelfMinMaxSizes(int defaultMin, int defaultMax, out int min, out int max)
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00029460 File Offset: 0x00027660
		[Token(Token = "0x6005895")]
		[Address(RVA = "0x875334", Offset = "0x875334", VA = "0x875334")]
		public bool TileIsInStyle(int tileType, bool includeCracked = true, bool includeExtras = false)
		{
			return default(bool);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00029478 File Offset: 0x00027678
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x875458", Offset = "0x875458", VA = "0x875458")]
		public bool WallIsInStyle(int wallType, bool includeWindows = false, bool includeExtras = false)
		{
			return default(bool);
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x00029490 File Offset: 0x00027690
		[Token(Token = "0x6005897")]
		[Address(RVA = "0x875518", Offset = "0x875518", VA = "0x875518")]
		public int GetPlatformStyle(UnifiedRandom genRand)
		{
			return 0;
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x000294A8 File Offset: 0x000276A8
		[Token(Token = "0x6005898")]
		[Address(RVA = "0x8755E8", Offset = "0x8755E8", VA = "0x8755E8")]
		public int GetWindowPlatformStyle(UnifiedRandom genRand)
		{
			return 0;
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005899")]
		[Address(RVA = "0x8756B8", Offset = "0x8756B8", VA = "0x8756B8")]
		public DungeonGenerationStyleData()
		{
		}

		// Token: 0x04009A36 RID: 39478
		[Token(Token = "0x4009A36")]
		[FieldOffset(Offset = "0x8")]
		public byte Style;

		// Token: 0x04009A37 RID: 39479
		[Token(Token = "0x4009A37")]
		[FieldOffset(Offset = "0xC")]
		public int UnbreakableWallProgressionTier;

		// Token: 0x04009A38 RID: 39480
		[Token(Token = "0x4009A38")]
		[FieldOffset(Offset = "0x10")]
		public ushort BrickTileType;

		// Token: 0x04009A39 RID: 39481
		[Token(Token = "0x4009A39")]
		[FieldOffset(Offset = "0x12")]
		public ushort? BrickGrassTileType;

		// Token: 0x04009A3A RID: 39482
		[Token(Token = "0x4009A3A")]
		[FieldOffset(Offset = "0x16")]
		public ushort BrickCrackedTileType;

		// Token: 0x04009A3B RID: 39483
		[Token(Token = "0x4009A3B")]
		[FieldOffset(Offset = "0x18")]
		public ushort BrickWallType;

		// Token: 0x04009A3C RID: 39484
		[Token(Token = "0x4009A3C")]
		[FieldOffset(Offset = "0x1C")]
		public ushort[] ExtraTileTypes;

		// Token: 0x04009A3D RID: 39485
		[Token(Token = "0x4009A3D")]
		[FieldOffset(Offset = "0x20")]
		public byte? TilePaintColor;

		// Token: 0x04009A3E RID: 39486
		[Token(Token = "0x4009A3E")]
		[FieldOffset(Offset = "0x22")]
		public byte? WallPaintColor;

		// Token: 0x04009A3F RID: 39487
		[Token(Token = "0x4009A3F")]
		[FieldOffset(Offset = "0x24")]
		public ushort WindowGlassWallType;

		// Token: 0x04009A40 RID: 39488
		[Token(Token = "0x4009A40")]
		[FieldOffset(Offset = "0x26")]
		public ushort WindowClosedGlassWallType;

		// Token: 0x04009A41 RID: 39489
		[Token(Token = "0x4009A41")]
		[FieldOffset(Offset = "0x28")]
		public ushort WindowEdgeWallType;

		// Token: 0x04009A42 RID: 39490
		[Token(Token = "0x4009A42")]
		[FieldOffset(Offset = "0x2C")]
		public int[] WindowPlatformItemTypes;

		// Token: 0x04009A43 RID: 39491
		[Token(Token = "0x4009A43")]
		[FieldOffset(Offset = "0x30")]
		public ushort[] ExtraWallTypes;

		// Token: 0x04009A44 RID: 39492
		[Token(Token = "0x4009A44")]
		[FieldOffset(Offset = "0x34")]
		public ushort PitTrapTileType;

		// Token: 0x04009A45 RID: 39493
		[Token(Token = "0x4009A45")]
		[FieldOffset(Offset = "0x38")]
		public int LiquidType;

		// Token: 0x04009A46 RID: 39494
		[Token(Token = "0x4009A46")]
		[FieldOffset(Offset = "0x3C")]
		public int LockedBiomeChestType;

		// Token: 0x04009A47 RID: 39495
		[Token(Token = "0x4009A47")]
		[FieldOffset(Offset = "0x40")]
		public int LockedBiomeChestStyle;

		// Token: 0x04009A48 RID: 39496
		[Token(Token = "0x4009A48")]
		[FieldOffset(Offset = "0x44")]
		public int BiomeChestItemType;

		// Token: 0x04009A49 RID: 39497
		[Token(Token = "0x4009A49")]
		[FieldOffset(Offset = "0x48")]
		public int BiomeChestLootItemType;

		// Token: 0x04009A4A RID: 39498
		[Token(Token = "0x4009A4A")]
		[FieldOffset(Offset = "0x4C")]
		public int[] ChestItemTypes;

		// Token: 0x04009A4B RID: 39499
		[Token(Token = "0x4009A4B")]
		[FieldOffset(Offset = "0x50")]
		public int[] DoorItemTypes;

		// Token: 0x04009A4C RID: 39500
		[Token(Token = "0x4009A4C")]
		[FieldOffset(Offset = "0x54")]
		public int[] PlatformItemTypes;

		// Token: 0x04009A4D RID: 39501
		[Token(Token = "0x4009A4D")]
		[FieldOffset(Offset = "0x58")]
		public int[] ChandelierItemTypes;

		// Token: 0x04009A4E RID: 39502
		[Token(Token = "0x4009A4E")]
		[FieldOffset(Offset = "0x5C")]
		public int[] LanternItemTypes;

		// Token: 0x04009A4F RID: 39503
		[Token(Token = "0x4009A4F")]
		[FieldOffset(Offset = "0x60")]
		public int[] TableItemTypes;

		// Token: 0x04009A50 RID: 39504
		[Token(Token = "0x4009A50")]
		[FieldOffset(Offset = "0x64")]
		public int[] WorkbenchItemTypes;

		// Token: 0x04009A51 RID: 39505
		[Token(Token = "0x4009A51")]
		[FieldOffset(Offset = "0x68")]
		public int[] CandleItemTypes;

		// Token: 0x04009A52 RID: 39506
		[Token(Token = "0x4009A52")]
		[FieldOffset(Offset = "0x6C")]
		public int[] VaseOrStatueItemTypes;

		// Token: 0x04009A53 RID: 39507
		[Token(Token = "0x4009A53")]
		[FieldOffset(Offset = "0x70")]
		public int[] BookcaseItemTypes;

		// Token: 0x04009A54 RID: 39508
		[Token(Token = "0x4009A54")]
		[FieldOffset(Offset = "0x74")]
		public int[] ChairItemTypes;

		// Token: 0x04009A55 RID: 39509
		[Token(Token = "0x4009A55")]
		[FieldOffset(Offset = "0x78")]
		public int[] BedItemTypes;

		// Token: 0x04009A56 RID: 39510
		[Token(Token = "0x4009A56")]
		[FieldOffset(Offset = "0x7C")]
		public int[] PianoItemTypes;

		// Token: 0x04009A57 RID: 39511
		[Token(Token = "0x4009A57")]
		[FieldOffset(Offset = "0x80")]
		public int[] DresserItemTypes;

		// Token: 0x04009A58 RID: 39512
		[Token(Token = "0x4009A58")]
		[FieldOffset(Offset = "0x84")]
		public int[] SofaItemTypes;

		// Token: 0x04009A59 RID: 39513
		[Token(Token = "0x4009A59")]
		[FieldOffset(Offset = "0x88")]
		public int[] BathtubItemTypes;

		// Token: 0x04009A5A RID: 39514
		[Token(Token = "0x4009A5A")]
		[FieldOffset(Offset = "0x8C")]
		public int[] LampItemTypes;

		// Token: 0x04009A5B RID: 39515
		[Token(Token = "0x4009A5B")]
		[FieldOffset(Offset = "0x90")]
		public int[] CandelabraItemTypes;

		// Token: 0x04009A5C RID: 39516
		[Token(Token = "0x4009A5C")]
		[FieldOffset(Offset = "0x94")]
		public int[] ClockItemTypes;

		// Token: 0x04009A5D RID: 39517
		[Token(Token = "0x4009A5D")]
		[FieldOffset(Offset = "0x98")]
		public int[] BannerItemTypes;

		// Token: 0x04009A5E RID: 39518
		[Token(Token = "0x4009A5E")]
		[FieldOffset(Offset = "0x9C")]
		public bool EdgeDither;

		// Token: 0x04009A5F RID: 39519
		[Token(Token = "0x4009A5F")]
		[FieldOffset(Offset = "0xA0")]
		public DungeonRoomType BiomeRoomType;

		// Token: 0x04009A60 RID: 39520
		[Token(Token = "0x4009A60")]
		[FieldOffset(Offset = "0xA4")]
		public List<DungeonGenerationStyleData> SubStyles;
	}
}
