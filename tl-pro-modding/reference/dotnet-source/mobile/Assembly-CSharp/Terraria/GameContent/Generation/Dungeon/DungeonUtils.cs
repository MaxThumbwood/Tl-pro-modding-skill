using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	public class DungeonUtils
	{
		// Token: 0x060058B6 RID: 22710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x87C540", Offset = "0x87C540", VA = "0x87C540")]
		public static void CalculatePlatformsAndDoorsOnEdgesOfRoom(DungeonData dungeonData, DungeonBounds innerBounds, DungeonGenerationStyleData styleData, [Optional] int? doorFluff, [Optional] int? platformFluff)
		{
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x87DE10", Offset = "0x87DE10", VA = "0x87DE10")]
		public static void CalculatePlatformAndDoorsOnHallway(DungeonData dungeonData, Vector2D hallwayPoint, double hallwayDirectionY, DungeonGenerationStyleData styleData, double doorVariance = 0.1)
		{
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x87EA18", Offset = "0x87EA18", VA = "0x87EA18")]
		public static void GenerateShimmerPool(int x, int y, int outerShapeSize = 15)
		{
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x000295C8 File Offset: 0x000277C8
		[Token(Token = "0x60058B9")]
		[Address(RVA = "0x87EDC0", Offset = "0x87EDC0", VA = "0x87EDC0")]
		public static bool GenerateDungeonBiomeChest(DungeonData data, DungeonGlobalBiomeChests feature, DungeonGenerationStyleData styleData, DungeonBounds innerBounds, bool locked = true)
		{
			return default(bool);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x000295E0 File Offset: 0x000277E0
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x87EE98", Offset = "0x87EE98", VA = "0x87EE98")]
		public static bool GenerateDungeonBiomeChest(DungeonData data, DungeonGlobalBiomeChests feature, DungeonGenerationStyleData styleData, int minX, int minY, int maxX, int maxY, bool locked = true)
		{
			return default(bool);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x000295F8 File Offset: 0x000277F8
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x87F25C", Offset = "0x87F25C", VA = "0x87F25C")]
		public static bool GenerateDungeonRegularChest(DungeonData data, DungeonGlobalBasicChests feature, DungeonGenerationStyleData styleData, DungeonBounds innerBounds)
		{
			return default(bool);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00029610 File Offset: 0x00027810
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x87F328", Offset = "0x87F328", VA = "0x87F328")]
		public static bool GenerateDungeonRegularChest(DungeonData data, DungeonGlobalBasicChests feature, DungeonGenerationStyleData styleData, int minX, int minY, int maxX, int maxY)
		{
			return default(bool);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x87F844", Offset = "0x87F844", VA = "0x87F844")]
		public static void GenerateDungeonWaterCandle(int placeX, int placeY)
		{
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x87F8D4", Offset = "0x87F8D4", VA = "0x87F8D4")]
		public static void GenerateDungeonPotionBottle(int placeX, int placeY)
		{
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x87FBD8", Offset = "0x87FBD8", VA = "0x87FBD8")]
		public static void GenerateDungeonPot(int placeX, int placeY)
		{
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x87FCEC", Offset = "0x87FCEC", VA = "0x87FCEC")]
		public static void GenerateDungeonBook(int placeX, int placeY)
		{
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x87FDD8", Offset = "0x87FDD8", VA = "0x87FDD8")]
		public static void GenerateDungeonBook(int placeX, int placeY, bool waterbolt)
		{
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x88006C", Offset = "0x88006C", VA = "0x88006C")]
		public static void GenerateBottomWedge(int placeX, int placeY, int pillarWidth, ushort pillarType, bool left = true, bool wall = false, bool actuated = false, bool crowningBottom = false, [MetadataOffset(Offset = "0x4F0007")] [Optional] int? paint)
		{
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x8801F0", Offset = "0x8801F0", VA = "0x8801F0")]
		private static void GenerateTileStrip(bool upwards, out int topY, out int bottomY, int placeX, int placeY, int pillarHeight, ushort pillarType, bool wall = false, bool actuated = false, [MetadataOffset(Offset = "0x4F000A")] [Optional] int? paint, bool smoothTop = false, bool smoothBottom = false, bool solidTop = false)
		{
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00029628 File Offset: 0x00027828
		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x880BB4", Offset = "0x880BB4", VA = "0x880BB4")]
		public static Point FirstSolid(bool ceiling, Point currentPoint, DungeonBounds bounds)
		{
			return default(Point);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x880D38", Offset = "0x880D38", VA = "0x880D38")]
		public static void GenerateHangingLeafCluster(DungeonData data, UnifiedRandom genRand, DungeonBounds bounds, Point startPoint, int growthLength, int branchDensity, int leafDensity, ushort leafType, ushort woodType, [MetadataOffset(Offset = "0x4F000E")] [Optional] int? leafPaintColor, [MetadataOffset(Offset = "0x4F000F")] [Optional] int? woodPaintColor, bool goDown = true, bool includeVines = true)
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x88164C", Offset = "0x88164C", VA = "0x88164C")]
		public static void GenerateDungeonTree(DungeonData data, int x, int y, int attachmentY, bool generateRoots = true)
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00029640 File Offset: 0x00027840
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x881ED8", Offset = "0x881ED8", VA = "0x881ED8")]
		private static bool GrowDungeonTree(DungeonData data, int i, int j, int attachmentY, bool patch = false, bool generateRoots = true)
		{
			return default(bool);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x88618C", Offset = "0x88618C", VA = "0x88618C")]
		private static void GrowDungeonTree_MakePassage(DungeonData data, int j, int attachmentY, int width, ref int minimumLeft, ref int minimumRight, bool noSecretRoom = false)
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x888DF8", Offset = "0x888DF8", VA = "0x888DF8")]
		public static void GenerateDungeonStairs(DungeonData data, int i, int j, int direction, DungeonGenerationStyleData styleData, int depth = 100)
		{
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00029658 File Offset: 0x00027858
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x889FD8", Offset = "0x889FD8", VA = "0x889FD8")]
		private static bool GenerateDungeonStairs_CanPlaceTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x88A390", Offset = "0x88A390", VA = "0x88A390")]
		public static void GenerateFloatingRocksInArea(DungeonData data, DungeonGenerationStyleData styleData, DungeonBounds bounds, ushort tileType, bool includePlatform = true, [MetadataOffset(Offset = "0x4F0019")] [Optional] int? paint)
		{
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x88A448", Offset = "0x88A448", VA = "0x88A448")]
		public static void GenerateFloatingRocksInArea(DungeonData data, DungeonGenerationStyleData styleData, int x, int y, int width, int height, ushort tileType, bool includePlatform = true, [MetadataOffset(Offset = "0x4F001B")] [Optional] int? paint)
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x88ADA0", Offset = "0x88ADA0", VA = "0x88ADA0")]
		public static void GenerateFloatingRocksInArea(DungeonData data, DungeonBounds bounds, ushort tileType, bool includePlatform = true, int platformStyle = -1, [MetadataOffset(Offset = "0x4F001E")] [Optional] int? paint, int platformDistance = 7)
		{
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x88A588", Offset = "0x88A588", VA = "0x88A588")]
		public static void GenerateFloatingRocksInArea(DungeonData data, int x, int y, int width, int height, ushort tileType, bool includePlatform = true, int platformStyle = -1, [MetadataOffset(Offset = "0x4F0022")] [Optional] int? paint, int platformDistance = 7)
		{
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x88AE74", Offset = "0x88AE74", VA = "0x88AE74")]
		public static void GenerateRockPlatform(UnifiedRandom genRand, int x, int y, int width, ushort tileType, [MetadataOffset(Offset = "0x4F0024")] [Optional] int? paint)
		{
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D0")]
		[Address(RVA = "0x88B0CC", Offset = "0x88B0CC", VA = "0x88B0CC")]
		public static void GenerateSpeleothemsInArea(DungeonData data, DungeonGenerationStyleData styleData, DungeonBounds bounds, int maxSpeleothems, ushort tileType, [MetadataOffset(Offset = "0x4F0025")] [Optional] int? paint, int speleothemWidth = -1, int speleothemHeight = -1)
		{
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x88B188", Offset = "0x88B188", VA = "0x88B188")]
		public static void GenerateSpeleothemsInArea(DungeonData data, DungeonGenerationStyleData styleData, int x, int y, int width, int height, int maxSpeleothems, ushort tileType, [MetadataOffset(Offset = "0x4F0028")] [Optional] int? paint, int speleothemWidth = -1, int speleothemHeight = -1)
		{
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x88B1D8", Offset = "0x88B1D8", VA = "0x88B1D8")]
		public static void GenerateSpeleothemsInArea(DungeonData data, int x, int y, int width, int height, int maxSpeleothems, ushort tileType, [MetadataOffset(Offset = "0x4F002B")] [Optional] int? paint, int speleothemWidth = -1, int speleothemHeight = -1)
		{
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x88BBB8", Offset = "0x88BBB8", VA = "0x88BBB8")]
		public static void GenerateSpeleothem(DungeonData data, UnifiedRandom genRand, int x, int y, int width, int height = -1, ushort tileType = 1, [MetadataOffset(Offset = "0x4F0031")] [Optional] int? paint)
		{
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x881344", Offset = "0x881344", VA = "0x881344")]
		public static void ChangeTileType(Tile tile, ushort tileType, bool resetTile, [MetadataOffset(Offset = "0x4F0032")] [Optional] int? paint)
		{
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0x88C058", Offset = "0x88C058", VA = "0x88C058")]
		public static void ChangeWallType(Tile tile, ushort wallType, bool resetTile, [MetadataOffset(Offset = "0x4F0033")] [Optional] int? paint)
		{
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00029670 File Offset: 0x00027870
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0x88C2A4", Offset = "0x88C2A4", VA = "0x88C2A4")]
		public static int GetDualDungeonBrickSupportCutoffY(DungeonData data)
		{
			return 0;
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D7")]
		[Address(RVA = "0x88C394", Offset = "0x88C394", VA = "0x88C394")]
		public static void UpdateDungeonProgress(GenerationProgress progress, float percentile, string debugString, bool noFormatting = false)
		{
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00029688 File Offset: 0x00027888
		[Token(Token = "0x60058D8")]
		[Address(RVA = "0x88C45C", Offset = "0x88C45C", VA = "0x88C45C")]
		public static Point SetOldManSpawnAndSpawnOldManIfDefaultDungeon(int x, int y, bool generating = false)
		{
			return default(Point);
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x000296A0 File Offset: 0x000278A0
		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x88C7D0", Offset = "0x88C7D0", VA = "0x88C7D0")]
		public static bool IsPointOfProtectionType(int i2, int j2, List<DungeonRoom> roomsInArea, ProtectionType protectionToCheck)
		{
			return default(bool);
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x000296B8 File Offset: 0x000278B8
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x88C848", Offset = "0x88C848", VA = "0x88C848")]
		public static ProtectionType GetHighestProtectionTypeFromPoint(int i2, int j2, List<DungeonRoom> roomsInArea)
		{
			return ProtectionType.None;
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x88C960", Offset = "0x88C960", VA = "0x88C960")]
		public static DungeonRoom GetClosestRoomTo(List<DungeonRoom> roomsToCheck, Point point, DungeonRoomSearchSettings settings)
		{
			return null;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x88C9AC", Offset = "0x88C9AC", VA = "0x88C9AC")]
		public static DungeonRoom GetClosestRoomTo(List<DungeonRoom> roomsToCheck, int x, int y, DungeonRoomSearchSettings settings)
		{
			return null;
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0x88CC40", Offset = "0x88CC40", VA = "0x88CC40")]
		public static List<DungeonRoom> GetAllRoomsNearSpot(List<DungeonRoom> roomsToCheck, int x, int y, DungeonRoomSearchSettings settings)
		{
			return null;
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DE")]
		[Address(RVA = "0x88CE60", Offset = "0x88CE60", VA = "0x88CE60")]
		public static List<DungeonRoom> GetAllRoomsInSpots(List<DungeonRoom> roomsToCheck, Vector2D startPos, Vector2D endPos, DungeonRoomSearchSettings settings)
		{
			return null;
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x000296D0 File Offset: 0x000278D0
		[Token(Token = "0x60058DF")]
		[Address(RVA = "0x8749EC", Offset = "0x8749EC", VA = "0x8749EC")]
		public static bool RoomCanBeChosen(DungeonRoom room, DungeonRoomSearchSettings settings)
		{
			return default(bool);
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x000296E8 File Offset: 0x000278E8
		[Token(Token = "0x60058E0")]
		[Address(RVA = "0x88D288", Offset = "0x88D288", VA = "0x88D288")]
		public static bool IsConsideredDungeonTile(int tileType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00029700 File Offset: 0x00027900
		[Token(Token = "0x60058E1")]
		[Address(RVA = "0x88D490", Offset = "0x88D490", VA = "0x88D490")]
		public static bool IsConsideredCrackedDungeonTile(int tileType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00029718 File Offset: 0x00027918
		[Token(Token = "0x60058E2")]
		[Address(RVA = "0x88D638", Offset = "0x88D638", VA = "0x88D638")]
		public static bool IsConsideredPitTrapTile(int tileType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00029730 File Offset: 0x00027930
		[Token(Token = "0x60058E3")]
		[Address(RVA = "0x88D7E0", Offset = "0x88D7E0", VA = "0x88D7E0")]
		public static bool IsConsideredAnyDungeonWall(int wallType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00029748 File Offset: 0x00027948
		[Token(Token = "0x60058E4")]
		[Address(RVA = "0x888A48", Offset = "0x888A48", VA = "0x888A48")]
		public static bool IsConsideredDungeonWall(int wallType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00029760 File Offset: 0x00027960
		[Token(Token = "0x60058E5")]
		[Address(RVA = "0x88DAC8", Offset = "0x88DAC8", VA = "0x88DAC8")]
		public static bool IsConsideredDungeonWallEdge(int wallType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00029778 File Offset: 0x00027978
		[Token(Token = "0x60058E6")]
		[Address(RVA = "0x888C50", Offset = "0x888C50", VA = "0x888C50")]
		public static bool IsConsideredDungeonWallGlass(int wallType, bool allDungeons = false)
		{
			return default(bool);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x00029790 File Offset: 0x00027990
		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x88DCD0", Offset = "0x88DCD0", VA = "0x88DCD0")]
		public static bool IsHigherOrEqualTieredDungeonTile(DungeonData data, int currentTileType, int newTileType, int currentStyleID, int newStyleID, bool includeCracked = false, bool includeExtras = false)
		{
			return default(bool);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x000297A8 File Offset: 0x000279A8
		[Token(Token = "0x60058E8")]
		[Address(RVA = "0x88E404", Offset = "0x88E404", VA = "0x88E404")]
		public static bool IsHigherOrEqualTieredDungeonWall(DungeonData data, int currentWallType, int newWallType, int currentStyleID, int newStyleID, bool includeWindows = false, bool includeExtras = false)
		{
			return default(bool);
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x000297C0 File Offset: 0x000279C0
		[Token(Token = "0x60058E9")]
		[Address(RVA = "0x88DEA0", Offset = "0x88DEA0", VA = "0x88DEA0")]
		public static double GetTierForDungeonTile(DungeonGenVars genVars, int tileType, int genStyleID, bool includeCracked = false, bool includeExtras = false)
		{
			return 0.0;
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x000297D8 File Offset: 0x000279D8
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0x88E5D8", Offset = "0x88E5D8", VA = "0x88E5D8")]
		public static double GetTierForDungeonWall(DungeonGenVars genVars, int wallType, int genStyleID, bool includeWindows = false, bool includeExtras = false)
		{
			return 0.0;
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0x88EEE0", Offset = "0x88EEE0", VA = "0x88EEE0")]
		public static void CreatePotentialDungeonBounds(out DungeonBounds innerBounds, out DungeonBounds outerBounds, bool leftDungeon, double percentInMiddle = 0.02, double percentOnEdges = 0.02, double percentOnTop = -1.0, double percentOnBottom = -1.0, int innerBuffer = 10)
		{
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x000297F0 File Offset: 0x000279F0
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x88F284", Offset = "0x88F284", VA = "0x88F284")]
		public static bool InAnyPotentialDungeonBounds(int x, int y, int fluff = 0, bool inner = false)
		{
			return default(bool);
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00029808 File Offset: 0x00027A08
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x88F2B8", Offset = "0x88F2B8", VA = "0x88F2B8")]
		public static bool InAnyPotentialDungeonBounds(out int iteration, int x, int y, int fluff = 0, bool inner = false)
		{
			return default(bool);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00029820 File Offset: 0x00027A20
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x88F448", Offset = "0x88F448", VA = "0x88F448")]
		public static bool IntersectsAnyPotentialDungeonBounds(Rectangle rect, bool inner = false)
		{
			return default(bool);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00029838 File Offset: 0x00027A38
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x88F480", Offset = "0x88F480", VA = "0x88F480")]
		public static bool IntersectsAnyPotentialDungeonBounds(out int iteration, Rectangle rect, bool inner = false)
		{
			return default(bool);
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00029850 File Offset: 0x00027A50
		[Token(Token = "0x60058F0")]
		[Address(RVA = "0x88F618", Offset = "0x88F618", VA = "0x88F618")]
		public static Rectangle GetExpandedDungeonAreaFromPoint(int x, int y)
		{
			return default(Rectangle);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00029868 File Offset: 0x00027A68
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x8909B4", Offset = "0x8909B4", VA = "0x8909B4")]
		public static int CalculateFloodedTileCountFromShapeData(DungeonBounds innerBounds, ShapeData data)
		{
			return 0;
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x890AB8", Offset = "0x890AB8", VA = "0x890AB8")]
		public DungeonUtils()
		{
		}

		// Token: 0x04009A79 RID: 39545
		[Token(Token = "0x4009A79")]
		public const int DOORSTYLE_WOODEN = 13;

		// Token: 0x04009A7A RID: 39546
		[Token(Token = "0x4009A7A")]
		public const int DOORSTYLE_BLUEBRICK = 16;

		// Token: 0x04009A7B RID: 39547
		[Token(Token = "0x4009A7B")]
		public const int DOORSTYLE_GREENBRICK = 17;

		// Token: 0x04009A7C RID: 39548
		[Token(Token = "0x4009A7C")]
		public const int DOORSTYLE_PINKBRICK = 18;

		// Token: 0x04009A7D RID: 39549
		[Token(Token = "0x4009A7D")]
		public const int DOORSTYLE_GOTHIC = 53;

		// Token: 0x04009A7E RID: 39550
		[Token(Token = "0x4009A7E")]
		public const int POTSTYLE_NORMAL_1 = 0;

		// Token: 0x04009A7F RID: 39551
		[Token(Token = "0x4009A7F")]
		public const int POTSTYLE_NORMAL_2 = 1;

		// Token: 0x04009A80 RID: 39552
		[Token(Token = "0x4009A80")]
		public const int POTSTYLE_NORMAL_3 = 2;

		// Token: 0x04009A81 RID: 39553
		[Token(Token = "0x4009A81")]
		public const int POTSTYLE_NORMAL_4 = 3;

		// Token: 0x04009A82 RID: 39554
		[Token(Token = "0x4009A82")]
		public const int POTSTYLE_SKULL_1 = 10;

		// Token: 0x04009A83 RID: 39555
		[Token(Token = "0x4009A83")]
		public const int POTSTYLE_SKULL_2 = 11;

		// Token: 0x04009A84 RID: 39556
		[Token(Token = "0x4009A84")]
		public const int POTSTYLE_SKULL_3 = 12;

		// Token: 0x04009A85 RID: 39557
		[Token(Token = "0x4009A85")]
		public const int PLATFORMSTYLE_BLUEBRICK = 6;

		// Token: 0x04009A86 RID: 39558
		[Token(Token = "0x4009A86")]
		public const int PLATFORMSTYLE_GREENBRICK = 8;

		// Token: 0x04009A87 RID: 39559
		[Token(Token = "0x4009A87")]
		public const int PLATFORMSTYLE_PINKBRICK = 7;

		// Token: 0x04009A88 RID: 39560
		[Token(Token = "0x4009A88")]
		public const int PLATFORMSTYLE_METALSHELF = 9;

		// Token: 0x04009A89 RID: 39561
		[Token(Token = "0x4009A89")]
		public const int PLATFORMSTYLE_BRASSSHELF = 10;

		// Token: 0x04009A8A RID: 39562
		[Token(Token = "0x4009A8A")]
		public const int PLATFORMSTYLE_WOODSHELF = 11;

		// Token: 0x04009A8B RID: 39563
		[Token(Token = "0x4009A8B")]
		public const int PLATFORMSTYLE_DUNGEONSHELF = 12;

		// Token: 0x04009A8C RID: 39564
		[Token(Token = "0x4009A8C")]
		public const int PLATFORMSTYLE_GOTHIC = 54;

		// Token: 0x04009A8D RID: 39565
		[Token(Token = "0x4009A8D")]
		public const int BANNERSTYLE_BRICK_MARCHINGBONES = 10;

		// Token: 0x04009A8E RID: 39566
		[Token(Token = "0x4009A8E")]
		public const int BANNERSTYLE_BRICK_NECROMANTICSIGN = 11;

		// Token: 0x04009A8F RID: 39567
		[Token(Token = "0x4009A8F")]
		public const int BANNERSTYLE_SLAB_RUGGEDCOMPANY = 12;

		// Token: 0x04009A90 RID: 39568
		[Token(Token = "0x4009A90")]
		public const int BANNERSTYLE_SLAB_RAGGEDBROTHERHOOD = 13;

		// Token: 0x04009A91 RID: 39569
		[Token(Token = "0x4009A91")]
		public const int BANNERSTYLE_TILES_MOLTENLEGION = 14;

		// Token: 0x04009A92 RID: 39570
		[Token(Token = "0x4009A92")]
		public const int BANNERSTYLE_TILES_DIABOLICSIGIL = 15;

		// Token: 0x04009A93 RID: 39571
		[Token(Token = "0x4009A93")]
		public const int TRAPTYPE_DART = 0;

		// Token: 0x04009A94 RID: 39572
		[Token(Token = "0x4009A94")]
		public const int DUNGEONHALL_DEFAULT_INNER_AREA_DEPTH = 3;

		// Token: 0x04009A95 RID: 39573
		[Token(Token = "0x4009A95")]
		public const int DUNGEONHALL_DEFAULT_OUTER_WALL_DEPTH = 8;

		// Token: 0x04009A96 RID: 39574
		[Token(Token = "0x4009A96")]
		public const int DUNGEONROOM_DEFAULT_INNER_AREA_DEPTH = 6;

		// Token: 0x04009A97 RID: 39575
		[Token(Token = "0x4009A97")]
		public const int DUNGEONROOM_DEFAULT_OUTER_WALL_DEPTH = 8;

		// Token: 0x02000B30 RID: 2864
		// (Invoke) Token: 0x060058F4 RID: 22772
		[Token(Token = "0x2000B30")]
		public delegate ConnectionPointQuality GetHallwayConnectionPoint(DungeonRoom room, Vector2D otherRoomPos, out Vector2D connectionPoint);

		// Token: 0x02000B31 RID: 2865
		[Token(Token = "0x2000B31")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x060058F7 RID: 22775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058F7")]
			[Address(RVA = "0x890D50", Offset = "0x890D50", VA = "0x890D50")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x060058F8 RID: 22776 RVA: 0x00029880 File Offset: 0x00027A80
			[Token(Token = "0x60058F8")]
			[Address(RVA = "0x890D58", Offset = "0x890D58", VA = "0x890D58")]
			internal bool <GenerateFloatingRocksInArea>b__0(DungeonData dungeonData, int platformX, int platformY)
			{
				return default(bool);
			}

			// Token: 0x04009A98 RID: 39576
			[Token(Token = "0x4009A98")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int x;

			// Token: 0x04009A99 RID: 39577
			[Token(Token = "0x4009A99")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int width;

			// Token: 0x04009A9A RID: 39578
			[Token(Token = "0x4009A9A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int y;

			// Token: 0x04009A9B RID: 39579
			[Token(Token = "0x4009A9B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int height;

			// Token: 0x04009A9C RID: 39580
			[Token(Token = "0x4009A9C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<DungeonData, int, int, bool> <>9__0;
		}
	}
}
