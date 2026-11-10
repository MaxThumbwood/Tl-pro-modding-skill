using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.Generation.Dungeon;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B3 RID: 1459
	[Token(Token = "0x20005B3")]
	public static class GenVars
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0001DB50 File Offset: 0x0001BD50
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000767")]
		public static int CurrentDungeon
		{
			[Token(Token = "0x6003AF8")]
			[Address(RVA = "0x1E08F24", Offset = "0x1E08F24", VA = "0x1E08F24")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003AF7")]
			[Address(RVA = "0x1E08E78", Offset = "0x1E08E78", VA = "0x1E08E78")]
			set
			{
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000768")]
		public static DungeonGenVars CurrentDungeonGenVars
		{
			[Token(Token = "0x6003AF9")]
			[Address(RVA = "0x1E08F88", Offset = "0x1E08F88", VA = "0x1E08F88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x0001DB68 File Offset: 0x0001BD68
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000769")]
		public static double DualDungeon_NormalizedDistanceSafeFromDither
		{
			[Token(Token = "0x6003AFA")]
			[Address(RVA = "0x1E0906C", Offset = "0x1E0906C", VA = "0x1E0906C")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6003AFB")]
			[Address(RVA = "0x1E090C0", Offset = "0x1E090C0", VA = "0x1E090C0")]
			set
			{
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x0001DB80 File Offset: 0x0001BD80
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076A")]
		public static bool hardMode
		{
			[Token(Token = "0x6003AFC")]
			[Address(RVA = "0x1E0911C", Offset = "0x1E0911C", VA = "0x1E0911C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AFD")]
			[Address(RVA = "0x1E09180", Offset = "0x1E09180", VA = "0x1E09180")]
			set
			{
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0001DB98 File Offset: 0x0001BD98
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076B")]
		public static int spawnTileX
		{
			[Token(Token = "0x6003AFE")]
			[Address(RVA = "0x1E091E8", Offset = "0x1E091E8", VA = "0x1E091E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003AFF")]
			[Address(RVA = "0x1E09248", Offset = "0x1E09248", VA = "0x1E09248")]
			set
			{
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076C")]
		public static int spawnTileY
		{
			[Token(Token = "0x6003B00")]
			[Address(RVA = "0x1E092B0", Offset = "0x1E092B0", VA = "0x1E092B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003B01")]
			[Address(RVA = "0x1E09310", Offset = "0x1E09310", VA = "0x1E09310")]
			set
			{
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076D")]
		public static bool[] townNPCCanSpawn
		{
			[Token(Token = "0x6003B02")]
			[Address(RVA = "0x1E09378", Offset = "0x1E09378", VA = "0x1E09378")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B03")]
			[Address(RVA = "0x1E093DC", Offset = "0x1E093DC", VA = "0x1E093DC")]
			set
			{
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B05 RID: 15109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076E")]
		public static bool[] tileSolid
		{
			[Token(Token = "0x6003B04")]
			[Address(RVA = "0x1E09444", Offset = "0x1E09444", VA = "0x1E09444")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B05")]
			[Address(RVA = "0x1E094A8", Offset = "0x1E094A8", VA = "0x1E094A8")]
			set
			{
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076F")]
		public static double mainWorldSurface
		{
			[Token(Token = "0x6003B06")]
			[Address(RVA = "0x1E09510", Offset = "0x1E09510", VA = "0x1E09510")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6003B07")]
			[Address(RVA = "0x1E09578", Offset = "0x1E09578", VA = "0x1E09578")]
			set
			{
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000770")]
		public static double mainRockLayer
		{
			[Token(Token = "0x6003B08")]
			[Address(RVA = "0x1E095F0", Offset = "0x1E095F0", VA = "0x1E095F0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6003B09")]
			[Address(RVA = "0x1E09658", Offset = "0x1E09658", VA = "0x1E09658")]
			set
			{
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000771")]
		public static int mainDungeonX
		{
			[Token(Token = "0x6003B0A")]
			[Address(RVA = "0x1E096D0", Offset = "0x1E096D0", VA = "0x1E096D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003B0B")]
			[Address(RVA = "0x1E09734", Offset = "0x1E09734", VA = "0x1E09734")]
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0001DC10 File Offset: 0x0001BE10
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000772")]
		public static int mainDungeonY
		{
			[Token(Token = "0x6003B0C")]
			[Address(RVA = "0x1E0979C", Offset = "0x1E0979C", VA = "0x1E0979C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003B0D")]
			[Address(RVA = "0x1E09800", Offset = "0x1E09800", VA = "0x1E09800")]
			set
			{
			}
		}

		// Token: 0x04004667 RID: 18023
		[Token(Token = "0x4004667")]
		[FieldOffset(Offset = "0x0")]
		public static WorldGenConfiguration configuration;

		// Token: 0x04004668 RID: 18024
		[Token(Token = "0x4004668")]
		[FieldOffset(Offset = "0x4")]
		public static StructureMap structures;

		// Token: 0x04004669 RID: 18025
		[Token(Token = "0x4004669")]
		[FieldOffset(Offset = "0x8")]
		public static int copper;

		// Token: 0x0400466A RID: 18026
		[Token(Token = "0x400466A")]
		[FieldOffset(Offset = "0xC")]
		public static int iron;

		// Token: 0x0400466B RID: 18027
		[Token(Token = "0x400466B")]
		[FieldOffset(Offset = "0x10")]
		public static int silver;

		// Token: 0x0400466C RID: 18028
		[Token(Token = "0x400466C")]
		[FieldOffset(Offset = "0x14")]
		public static int gold;

		// Token: 0x0400466D RID: 18029
		[Token(Token = "0x400466D")]
		[FieldOffset(Offset = "0x18")]
		public static int copperBar;

		// Token: 0x0400466E RID: 18030
		[Token(Token = "0x400466E")]
		[FieldOffset(Offset = "0x1C")]
		public static int ironBar;

		// Token: 0x0400466F RID: 18031
		[Token(Token = "0x400466F")]
		[FieldOffset(Offset = "0x20")]
		public static int silverBar;

		// Token: 0x04004670 RID: 18032
		[Token(Token = "0x4004670")]
		[FieldOffset(Offset = "0x24")]
		public static int goldBar;

		// Token: 0x04004671 RID: 18033
		[Token(Token = "0x4004671")]
		[FieldOffset(Offset = "0x28")]
		public static bool worldSpawnHasBeenRandomized;

		// Token: 0x04004672 RID: 18034
		[Token(Token = "0x4004672")]
		[FieldOffset(Offset = "0x2C")]
		public static List<LandmassData> landmassData;

		// Token: 0x04004673 RID: 18035
		[Token(Token = "0x4004673")]
		[FieldOffset(Offset = "0x30")]
		public static int remixSurfaceLayerLow;

		// Token: 0x04004674 RID: 18036
		[Token(Token = "0x4004674")]
		[FieldOffset(Offset = "0x34")]
		public static int remixSurfaceLayerHigh;

		// Token: 0x04004675 RID: 18037
		[Token(Token = "0x4004675")]
		[FieldOffset(Offset = "0x38")]
		public static int remixMushroomLayerLow;

		// Token: 0x04004676 RID: 18038
		[Token(Token = "0x4004676")]
		[FieldOffset(Offset = "0x3C")]
		public static int remixMushroomLayerHigh;

		// Token: 0x04004677 RID: 18039
		[Token(Token = "0x4004677")]
		[FieldOffset(Offset = "0x40")]
		public static int lowestCloud;

		// Token: 0x04004678 RID: 18040
		[Token(Token = "0x4004678")]
		[FieldOffset(Offset = "0x44")]
		public static int boulderPetsPlaced;

		// Token: 0x04004679 RID: 18041
		[Token(Token = "0x4004679")]
		[FieldOffset(Offset = "0x48")]
		public static ushort crimStoneWall;

		// Token: 0x0400467A RID: 18042
		[Token(Token = "0x400467A")]
		[FieldOffset(Offset = "0x4A")]
		public static ushort crimStone;

		// Token: 0x0400467B RID: 18043
		[Token(Token = "0x400467B")]
		[FieldOffset(Offset = "0x4C")]
		public static ushort ebonStoneWall;

		// Token: 0x0400467C RID: 18044
		[Token(Token = "0x400467C")]
		[FieldOffset(Offset = "0x4E")]
		public static ushort ebonStone;

		// Token: 0x0400467D RID: 18045
		[Token(Token = "0x400467D")]
		[FieldOffset(Offset = "0x50")]
		public static ushort mossTile;

		// Token: 0x0400467E RID: 18046
		[Token(Token = "0x400467E")]
		[FieldOffset(Offset = "0x52")]
		public static ushort mossWall;

		// Token: 0x0400467F RID: 18047
		[Token(Token = "0x400467F")]
		[FieldOffset(Offset = "0x54")]
		public static int lavaLine;

		// Token: 0x04004680 RID: 18048
		[Token(Token = "0x4004680")]
		[FieldOffset(Offset = "0x58")]
		public static int waterLine;

		// Token: 0x04004681 RID: 18049
		[Token(Token = "0x4004681")]
		[FieldOffset(Offset = "0x60")]
		public static double worldSurfaceLow;

		// Token: 0x04004682 RID: 18050
		[Token(Token = "0x4004682")]
		[FieldOffset(Offset = "0x68")]
		public static double worldSurface;

		// Token: 0x04004683 RID: 18051
		[Token(Token = "0x4004683")]
		[FieldOffset(Offset = "0x70")]
		public static double worldSurfaceHigh;

		// Token: 0x04004684 RID: 18052
		[Token(Token = "0x4004684")]
		[FieldOffset(Offset = "0x78")]
		public static double rockLayerLow;

		// Token: 0x04004685 RID: 18053
		[Token(Token = "0x4004685")]
		[FieldOffset(Offset = "0x80")]
		public static double rockLayer;

		// Token: 0x04004686 RID: 18054
		[Token(Token = "0x4004686")]
		[FieldOffset(Offset = "0x88")]
		public static double rockLayerHigh;

		// Token: 0x04004687 RID: 18055
		[Token(Token = "0x4004687")]
		[FieldOffset(Offset = "0x90")]
		public static int snowTop;

		// Token: 0x04004688 RID: 18056
		[Token(Token = "0x4004688")]
		[FieldOffset(Offset = "0x94")]
		public static int snowBottom;

		// Token: 0x04004689 RID: 18057
		[Token(Token = "0x4004689")]
		[FieldOffset(Offset = "0x98")]
		public static int snowOriginLeft;

		// Token: 0x0400468A RID: 18058
		[Token(Token = "0x400468A")]
		[FieldOffset(Offset = "0x9C")]
		public static int snowOriginRight;

		// Token: 0x0400468B RID: 18059
		[Token(Token = "0x400468B")]
		[FieldOffset(Offset = "0xA0")]
		public static int[] snowMinX;

		// Token: 0x0400468C RID: 18060
		[Token(Token = "0x400468C")]
		[FieldOffset(Offset = "0xA4")]
		public static int[] snowMaxX;

		// Token: 0x0400468D RID: 18061
		[Token(Token = "0x400468D")]
		[FieldOffset(Offset = "0xA8")]
		public static int leftBeachEnd;

		// Token: 0x0400468E RID: 18062
		[Token(Token = "0x400468E")]
		[FieldOffset(Offset = "0xAC")]
		public static int rightBeachStart;

		// Token: 0x0400468F RID: 18063
		[Token(Token = "0x400468F")]
		[FieldOffset(Offset = "0xB0")]
		public static int beachBordersWidth;

		// Token: 0x04004690 RID: 18064
		[Token(Token = "0x4004690")]
		[FieldOffset(Offset = "0xB4")]
		public static int beachSandRandomCenter;

		// Token: 0x04004691 RID: 18065
		[Token(Token = "0x4004691")]
		[FieldOffset(Offset = "0xB8")]
		public static int beachSandRandomWidthRange;

		// Token: 0x04004692 RID: 18066
		[Token(Token = "0x4004692")]
		[FieldOffset(Offset = "0xBC")]
		public static int beachSandDungeonExtraWidth;

		// Token: 0x04004693 RID: 18067
		[Token(Token = "0x4004693")]
		[FieldOffset(Offset = "0xC0")]
		public static int beachSandJungleExtraWidth;

		// Token: 0x04004694 RID: 18068
		[Token(Token = "0x4004694")]
		[FieldOffset(Offset = "0xC4")]
		public static int shellStartXLeft;

		// Token: 0x04004695 RID: 18069
		[Token(Token = "0x4004695")]
		[FieldOffset(Offset = "0xC8")]
		public static int shellStartYLeft;

		// Token: 0x04004696 RID: 18070
		[Token(Token = "0x4004696")]
		[FieldOffset(Offset = "0xCC")]
		public static int shellStartXRight;

		// Token: 0x04004697 RID: 18071
		[Token(Token = "0x4004697")]
		[FieldOffset(Offset = "0xD0")]
		public static int shellStartYRight;

		// Token: 0x04004698 RID: 18072
		[Token(Token = "0x4004698")]
		[FieldOffset(Offset = "0xD4")]
		public static int oceanWaterStartRandomMin;

		// Token: 0x04004699 RID: 18073
		[Token(Token = "0x4004699")]
		[FieldOffset(Offset = "0xD8")]
		public static int oceanWaterStartRandomMax;

		// Token: 0x0400469A RID: 18074
		[Token(Token = "0x400469A")]
		[FieldOffset(Offset = "0xDC")]
		public static int oceanWaterForcedJungleLength;

		// Token: 0x0400469B RID: 18075
		[Token(Token = "0x400469B")]
		[FieldOffset(Offset = "0xE0")]
		public static int evilBiomeBeachAvoidance;

		// Token: 0x0400469C RID: 18076
		[Token(Token = "0x400469C")]
		[FieldOffset(Offset = "0xE4")]
		public static int evilBiomeAvoidanceMidFixer;

		// Token: 0x0400469D RID: 18077
		[Token(Token = "0x400469D")]
		[FieldOffset(Offset = "0xE8")]
		public static int lakesBeachAvoidance;

		// Token: 0x0400469E RID: 18078
		[Token(Token = "0x400469E")]
		[FieldOffset(Offset = "0xEC")]
		public static int smallHolesBeachAvoidance;

		// Token: 0x0400469F RID: 18079
		[Token(Token = "0x400469F")]
		[FieldOffset(Offset = "0xF0")]
		public static int surfaceCavesBeachAvoidance;

		// Token: 0x040046A0 RID: 18080
		[Token(Token = "0x40046A0")]
		[FieldOffset(Offset = "0xF4")]
		public static int surfaceCavesBeachAvoidance2;

		// Token: 0x040046A1 RID: 18081
		[Token(Token = "0x40046A1")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly int maxOceanCaveTreasure;

		// Token: 0x040046A2 RID: 18082
		[Token(Token = "0x40046A2")]
		[FieldOffset(Offset = "0xFC")]
		public static int numOceanCaveTreasure;

		// Token: 0x040046A3 RID: 18083
		[Token(Token = "0x40046A3")]
		[FieldOffset(Offset = "0x100")]
		public static Point[] oceanCaveTreasure;

		// Token: 0x040046A4 RID: 18084
		[Token(Token = "0x40046A4")]
		[FieldOffset(Offset = "0x104")]
		public static bool skipDesertTileCheck;

		// Token: 0x040046A5 RID: 18085
		[Token(Token = "0x40046A5")]
		[FieldOffset(Offset = "0x108")]
		public static Rectangle UndergroundDesertLocation;

		// Token: 0x040046A6 RID: 18086
		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x118")]
		public static Rectangle UndergroundDesertHiveLocation;

		// Token: 0x040046A7 RID: 18087
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x128")]
		public static int desertHiveHigh;

		// Token: 0x040046A8 RID: 18088
		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x12C")]
		public static int desertHiveLow;

		// Token: 0x040046A9 RID: 18089
		[Token(Token = "0x40046A9")]
		[FieldOffset(Offset = "0x130")]
		public static int desertHiveLeft;

		// Token: 0x040046AA RID: 18090
		[Token(Token = "0x40046AA")]
		[FieldOffset(Offset = "0x134")]
		public static int desertHiveRight;

		// Token: 0x040046AB RID: 18091
		[Token(Token = "0x40046AB")]
		[FieldOffset(Offset = "0x138")]
		public static int numLarva;

		// Token: 0x040046AC RID: 18092
		[Token(Token = "0x40046AC")]
		[FieldOffset(Offset = "0x13C")]
		public static int[] larvaY;

		// Token: 0x040046AD RID: 18093
		[Token(Token = "0x40046AD")]
		[FieldOffset(Offset = "0x140")]
		public static int[] larvaX;

		// Token: 0x040046AE RID: 18094
		[Token(Token = "0x40046AE")]
		[FieldOffset(Offset = "0x144")]
		public static int numPyr;

		// Token: 0x040046AF RID: 18095
		[Token(Token = "0x40046AF")]
		[FieldOffset(Offset = "0x148")]
		public static int[] PyrX;

		// Token: 0x040046B0 RID: 18096
		[Token(Token = "0x40046B0")]
		[FieldOffset(Offset = "0x14C")]
		public static int[] PyrY;

		// Token: 0x040046B1 RID: 18097
		[Token(Token = "0x40046B1")]
		[FieldOffset(Offset = "0x150")]
		public static int extraBastStatueCount;

		// Token: 0x040046B2 RID: 18098
		[Token(Token = "0x40046B2")]
		[FieldOffset(Offset = "0x154")]
		public static int extraBastStatueCountMax;

		// Token: 0x040046B3 RID: 18099
		[Token(Token = "0x40046B3")]
		[FieldOffset(Offset = "0x158")]
		public static int jungleOriginX;

		// Token: 0x040046B4 RID: 18100
		[Token(Token = "0x40046B4")]
		[FieldOffset(Offset = "0x15C")]
		public static int jungleMinX;

		// Token: 0x040046B5 RID: 18101
		[Token(Token = "0x40046B5")]
		[FieldOffset(Offset = "0x160")]
		public static int jungleMaxX;

		// Token: 0x040046B6 RID: 18102
		[Token(Token = "0x40046B6")]
		[FieldOffset(Offset = "0x164")]
		public static int JungleX;

		// Token: 0x040046B7 RID: 18103
		[Token(Token = "0x40046B7")]
		[FieldOffset(Offset = "0x168")]
		public static ushort jungleHut;

		// Token: 0x040046B8 RID: 18104
		[Token(Token = "0x40046B8")]
		[FieldOffset(Offset = "0x16A")]
		public static bool mudWall;

		// Token: 0x040046B9 RID: 18105
		[Token(Token = "0x40046B9")]
		[FieldOffset(Offset = "0x16C")]
		public static int JungleItemCount;

		// Token: 0x040046BA RID: 18106
		[Token(Token = "0x40046BA")]
		[FieldOffset(Offset = "0x170")]
		public static bool gennedLivingMahoganyWands;

		// Token: 0x040046BB RID: 18107
		[Token(Token = "0x40046BB")]
		[FieldOffset(Offset = "0x174")]
		public static int[] JChestX;

		// Token: 0x040046BC RID: 18108
		[Token(Token = "0x40046BC")]
		[FieldOffset(Offset = "0x178")]
		public static int[] JChestY;

		// Token: 0x040046BD RID: 18109
		[Token(Token = "0x40046BD")]
		[FieldOffset(Offset = "0x17C")]
		public static int numJChests;

		// Token: 0x040046BE RID: 18110
		[Token(Token = "0x40046BE")]
		[FieldOffset(Offset = "0x180")]
		public static int tLeft;

		// Token: 0x040046BF RID: 18111
		[Token(Token = "0x40046BF")]
		[FieldOffset(Offset = "0x184")]
		public static int tRight;

		// Token: 0x040046C0 RID: 18112
		[Token(Token = "0x40046C0")]
		[FieldOffset(Offset = "0x188")]
		public static int tTop;

		// Token: 0x040046C1 RID: 18113
		[Token(Token = "0x40046C1")]
		[FieldOffset(Offset = "0x18C")]
		public static int tBottom;

		// Token: 0x040046C2 RID: 18114
		[Token(Token = "0x40046C2")]
		[FieldOffset(Offset = "0x190")]
		public static int tRooms;

		// Token: 0x040046C3 RID: 18115
		[Token(Token = "0x40046C3")]
		[FieldOffset(Offset = "0x194")]
		public static int lAltarX;

		// Token: 0x040046C4 RID: 18116
		[Token(Token = "0x40046C4")]
		[FieldOffset(Offset = "0x198")]
		public static int lAltarY;

		// Token: 0x040046C5 RID: 18117
		[Token(Token = "0x40046C5")]
		[FieldOffset(Offset = "0x19C")]
		public static List<DungeonGenVars> dungeonGenVars;

		// Token: 0x040046C6 RID: 18118
		[Token(Token = "0x40046C6")]
		[FieldOffset(Offset = "0x1A0")]
		private static int _currentDungeon;

		// Token: 0x040046C7 RID: 18119
		[Token(Token = "0x40046C7")]
		[FieldOffset(Offset = "0x1A4")]
		public static bool DualDungeon_AllowTrapGenerationInDungeon;

		// Token: 0x040046C8 RID: 18120
		[Token(Token = "0x40046C8")]
		[FieldOffset(Offset = "0x1A8")]
		public static readonly int dungeonBeachPadding;

		// Token: 0x040046C9 RID: 18121
		[Token(Token = "0x40046C9")]
		[FieldOffset(Offset = "0x1AC")]
		public static int skyLakes;

		// Token: 0x040046CA RID: 18122
		[Token(Token = "0x40046CA")]
		[FieldOffset(Offset = "0x1B0")]
		public static bool generatedShadowKey;

		// Token: 0x040046CB RID: 18123
		[Token(Token = "0x40046CB")]
		[FieldOffset(Offset = "0x1B1")]
		public static bool generatedRamRune;

		// Token: 0x040046CC RID: 18124
		[Token(Token = "0x40046CC")]
		[FieldOffset(Offset = "0x1B4")]
		public static int numIslandHouses;

		// Token: 0x040046CD RID: 18125
		[Token(Token = "0x40046CD")]
		[FieldOffset(Offset = "0x1B8")]
		public static int skyIslandHouseCount;

		// Token: 0x040046CE RID: 18126
		[Token(Token = "0x40046CE")]
		[FieldOffset(Offset = "0x1BC")]
		public static bool[] skyLake;

		// Token: 0x040046CF RID: 18127
		[Token(Token = "0x40046CF")]
		[FieldOffset(Offset = "0x1C0")]
		public static int[] floatingIslandHouseX;

		// Token: 0x040046D0 RID: 18128
		[Token(Token = "0x40046D0")]
		[FieldOffset(Offset = "0x1C4")]
		public static int[] floatingIslandHouseY;

		// Token: 0x040046D1 RID: 18129
		[Token(Token = "0x40046D1")]
		[FieldOffset(Offset = "0x1C8")]
		public static int[] floatingIslandStyle;

		// Token: 0x040046D2 RID: 18130
		[Token(Token = "0x40046D2")]
		[FieldOffset(Offset = "0x1CC")]
		public static int numMCaves;

		// Token: 0x040046D3 RID: 18131
		[Token(Token = "0x40046D3")]
		[FieldOffset(Offset = "0x1D0")]
		public static int[] mCaveX;

		// Token: 0x040046D4 RID: 18132
		[Token(Token = "0x40046D4")]
		[FieldOffset(Offset = "0x1D4")]
		public static int[] mCaveY;

		// Token: 0x040046D5 RID: 18133
		[Token(Token = "0x40046D5")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly int maxTunnels;

		// Token: 0x040046D6 RID: 18134
		[Token(Token = "0x40046D6")]
		[FieldOffset(Offset = "0x1DC")]
		public static int numTunnels;

		// Token: 0x040046D7 RID: 18135
		[Token(Token = "0x40046D7")]
		[FieldOffset(Offset = "0x1E0")]
		public static int[] tunnelX;

		// Token: 0x040046D8 RID: 18136
		[Token(Token = "0x40046D8")]
		[FieldOffset(Offset = "0x1E4")]
		public static readonly int maxOrePatch;

		// Token: 0x040046D9 RID: 18137
		[Token(Token = "0x40046D9")]
		[FieldOffset(Offset = "0x1E8")]
		public static int numOrePatch;

		// Token: 0x040046DA RID: 18138
		[Token(Token = "0x40046DA")]
		[FieldOffset(Offset = "0x1EC")]
		public static int[] orePatchX;

		// Token: 0x040046DB RID: 18139
		[Token(Token = "0x40046DB")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly int maxMushroomBiomes;

		// Token: 0x040046DC RID: 18140
		[Token(Token = "0x40046DC")]
		[FieldOffset(Offset = "0x1F4")]
		public static int numMushroomBiomes;

		// Token: 0x040046DD RID: 18141
		[Token(Token = "0x40046DD")]
		[FieldOffset(Offset = "0x1F8")]
		public static Point[] mushroomBiomesPosition;

		// Token: 0x040046DE RID: 18142
		[Token(Token = "0x40046DE")]
		[FieldOffset(Offset = "0x1FC")]
		public static int logX;

		// Token: 0x040046DF RID: 18143
		[Token(Token = "0x40046DF")]
		[FieldOffset(Offset = "0x200")]
		public static int logY;

		// Token: 0x040046E0 RID: 18144
		[Token(Token = "0x40046E0")]
		[FieldOffset(Offset = "0x204")]
		public static readonly int maxLakes;

		// Token: 0x040046E1 RID: 18145
		[Token(Token = "0x40046E1")]
		[FieldOffset(Offset = "0x208")]
		public static int numLakes;

		// Token: 0x040046E2 RID: 18146
		[Token(Token = "0x40046E2")]
		[FieldOffset(Offset = "0x20C")]
		public static int[] LakeX;

		// Token: 0x040046E3 RID: 18147
		[Token(Token = "0x40046E3")]
		[FieldOffset(Offset = "0x210")]
		public static readonly int maxOasis;

		// Token: 0x040046E4 RID: 18148
		[Token(Token = "0x40046E4")]
		[FieldOffset(Offset = "0x214")]
		public static int numOasis;

		// Token: 0x040046E5 RID: 18149
		[Token(Token = "0x40046E5")]
		[FieldOffset(Offset = "0x218")]
		public static Point[] oasisPosition;

		// Token: 0x040046E6 RID: 18150
		[Token(Token = "0x40046E6")]
		[FieldOffset(Offset = "0x21C")]
		public static int[] oasisWidth;

		// Token: 0x040046E7 RID: 18151
		[Token(Token = "0x40046E7")]
		[FieldOffset(Offset = "0x220")]
		public static readonly int oasisHeight;

		// Token: 0x040046E8 RID: 18152
		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0x224")]
		public static int hellChest;

		// Token: 0x040046E9 RID: 18153
		[Token(Token = "0x40046E9")]
		[FieldOffset(Offset = "0x228")]
		public static int[] hellChestItem;

		// Token: 0x040046EA RID: 18154
		[Token(Token = "0x40046EA")]
		[FieldOffset(Offset = "0x22C")]
		public static Point16[] statueList;

		// Token: 0x040046EB RID: 18155
		[Token(Token = "0x40046EB")]
		[FieldOffset(Offset = "0x230")]
		public static List<int> StatuesWithTraps;

		// Token: 0x040046EC RID: 18156
		[Token(Token = "0x40046EC")]
		[FieldOffset(Offset = "0x234")]
		public static bool crimsonLeft;

		// Token: 0x040046ED RID: 18157
		[Token(Token = "0x40046ED")]
		[FieldOffset(Offset = "0x238")]
		public static Vector2D shimmerPosition;

		// Token: 0x040046EE RID: 18158
		[Token(Token = "0x40046EE")]
		[FieldOffset(Offset = "0x248")]
		public static bool notTheBeesAndForTheWorthyNoCelebration;

		// Token: 0x040046EF RID: 18159
		[Token(Token = "0x40046EF")]
		[FieldOffset(Offset = "0x249")]
		public static bool noTrapsAndForTheWorthyNoCelebration;

		// Token: 0x040046F0 RID: 18160
		[Token(Token = "0x40046F0")]
		[FieldOffset(Offset = "0x24A")]
		public static bool flipInfections;
	}
}
