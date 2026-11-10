using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000BBF RID: 3007
	[Token(Token = "0x2000BBF")]
	public class HouseBuilder
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06005B3B RID: 23355 RVA: 0x0002AD08 File Offset: 0x00028F08
		// (set) Token: 0x06005B3C RID: 23356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1E")]
		public double ChestChance
		{
			[Token(Token = "0x6005B3B")]
			[Address(RVA = "0x97F85C", Offset = "0x97F85C", VA = "0x97F85C")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6005B3C")]
			[Address(RVA = "0x97F868", Offset = "0x97F868", VA = "0x97F868")]
			set
			{
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06005B3D RID: 23357 RVA: 0x0002AD20 File Offset: 0x00028F20
		// (set) Token: 0x06005B3E RID: 23358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1F")]
		public ushort TileType
		{
			[Token(Token = "0x6005B3D")]
			[Address(RVA = "0x97F878", Offset = "0x97F878", VA = "0x97F878")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B3E")]
			[Address(RVA = "0x97F880", Offset = "0x97F880", VA = "0x97F880")]
			protected set
			{
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x0002AD38 File Offset: 0x00028F38
		// (set) Token: 0x06005B40 RID: 23360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A20")]
		public ushort WallType
		{
			[Token(Token = "0x6005B3F")]
			[Address(RVA = "0x97F888", Offset = "0x97F888", VA = "0x97F888")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B40")]
			[Address(RVA = "0x97F890", Offset = "0x97F890", VA = "0x97F890")]
			protected set
			{
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x0002AD50 File Offset: 0x00028F50
		// (set) Token: 0x06005B42 RID: 23362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A21")]
		public ushort BeamType
		{
			[Token(Token = "0x6005B41")]
			[Address(RVA = "0x97F898", Offset = "0x97F898", VA = "0x97F898")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B42")]
			[Address(RVA = "0x97F8A0", Offset = "0x97F8A0", VA = "0x97F8A0")]
			protected set
			{
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06005B43 RID: 23363 RVA: 0x0002AD68 File Offset: 0x00028F68
		// (set) Token: 0x06005B44 RID: 23364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A22")]
		public byte BeamPaint
		{
			[Token(Token = "0x6005B43")]
			[Address(RVA = "0x97F8A8", Offset = "0x97F8A8", VA = "0x97F8A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B44")]
			[Address(RVA = "0x97F8B0", Offset = "0x97F8B0", VA = "0x97F8B0")]
			protected set
			{
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x0002AD80 File Offset: 0x00028F80
		// (set) Token: 0x06005B46 RID: 23366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A23")]
		public int PlatformStyle
		{
			[Token(Token = "0x6005B45")]
			[Address(RVA = "0x97F8B8", Offset = "0x97F8B8", VA = "0x97F8B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B46")]
			[Address(RVA = "0x97F8C0", Offset = "0x97F8C0", VA = "0x97F8C0")]
			protected set
			{
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x0002AD98 File Offset: 0x00028F98
		// (set) Token: 0x06005B48 RID: 23368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A24")]
		public int DoorStyle
		{
			[Token(Token = "0x6005B47")]
			[Address(RVA = "0x97F8C8", Offset = "0x97F8C8", VA = "0x97F8C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B48")]
			[Address(RVA = "0x97F8D0", Offset = "0x97F8D0", VA = "0x97F8D0")]
			protected set
			{
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06005B49 RID: 23369 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		// (set) Token: 0x06005B4A RID: 23370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A25")]
		public int TableStyle
		{
			[Token(Token = "0x6005B49")]
			[Address(RVA = "0x97F8D8", Offset = "0x97F8D8", VA = "0x97F8D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B4A")]
			[Address(RVA = "0x97F8E0", Offset = "0x97F8E0", VA = "0x97F8E0")]
			protected set
			{
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06005B4B RID: 23371 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		// (set) Token: 0x06005B4C RID: 23372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A26")]
		public bool UsesTables2
		{
			[Token(Token = "0x6005B4B")]
			[Address(RVA = "0x97F8E8", Offset = "0x97F8E8", VA = "0x97F8E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B4C")]
			[Address(RVA = "0x97F8F0", Offset = "0x97F8F0", VA = "0x97F8F0")]
			protected set
			{
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06005B4D RID: 23373 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		// (set) Token: 0x06005B4E RID: 23374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A27")]
		public int WorkbenchStyle
		{
			[Token(Token = "0x6005B4D")]
			[Address(RVA = "0x97F8F8", Offset = "0x97F8F8", VA = "0x97F8F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B4E")]
			[Address(RVA = "0x97F900", Offset = "0x97F900", VA = "0x97F900")]
			protected set
			{
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x0002ADF8 File Offset: 0x00028FF8
		// (set) Token: 0x06005B50 RID: 23376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A28")]
		public int PianoStyle
		{
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x97F908", Offset = "0x97F908", VA = "0x97F908")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B50")]
			[Address(RVA = "0x97F910", Offset = "0x97F910", VA = "0x97F910")]
			protected set
			{
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x0002AE10 File Offset: 0x00029010
		// (set) Token: 0x06005B52 RID: 23378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A29")]
		public int BookcaseStyle
		{
			[Token(Token = "0x6005B51")]
			[Address(RVA = "0x97F918", Offset = "0x97F918", VA = "0x97F918")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B52")]
			[Address(RVA = "0x97F920", Offset = "0x97F920", VA = "0x97F920")]
			protected set
			{
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06005B53 RID: 23379 RVA: 0x0002AE28 File Offset: 0x00029028
		// (set) Token: 0x06005B54 RID: 23380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2A")]
		public int ChairStyle
		{
			[Token(Token = "0x6005B53")]
			[Address(RVA = "0x97F928", Offset = "0x97F928", VA = "0x97F928")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B54")]
			[Address(RVA = "0x97F930", Offset = "0x97F930", VA = "0x97F930")]
			protected set
			{
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x0002AE40 File Offset: 0x00029040
		// (set) Token: 0x06005B56 RID: 23382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2B")]
		public int ChestStyle
		{
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0x97F938", Offset = "0x97F938", VA = "0x97F938")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B56")]
			[Address(RVA = "0x97F940", Offset = "0x97F940", VA = "0x97F940")]
			protected set
			{
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06005B57 RID: 23383 RVA: 0x0002AE58 File Offset: 0x00029058
		// (set) Token: 0x06005B58 RID: 23384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2C")]
		public bool UsesContainers2
		{
			[Token(Token = "0x6005B57")]
			[Address(RVA = "0x97F948", Offset = "0x97F948", VA = "0x97F948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B58")]
			[Address(RVA = "0x97F950", Offset = "0x97F950", VA = "0x97F950")]
			protected set
			{
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06005B59 RID: 23385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B5A RID: 23386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2D")]
		public ReadOnlyCollection<Rectangle> Rooms
		{
			[Token(Token = "0x6005B59")]
			[Address(RVA = "0x97F958", Offset = "0x97F958", VA = "0x97F958")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B5A")]
			[Address(RVA = "0x97F960", Offset = "0x97F960", VA = "0x97F960")]
			private set
			{
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06005B5B RID: 23387 RVA: 0x0002AE70 File Offset: 0x00029070
		[Token(Token = "0x17000A2E")]
		public Rectangle TopRoom
		{
			[Token(Token = "0x6005B5B")]
			[Address(RVA = "0x97F968", Offset = "0x97F968", VA = "0x97F968")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x0002AE88 File Offset: 0x00029088
		[Token(Token = "0x17000A2F")]
		public Rectangle BottomRoom
		{
			[Token(Token = "0x6005B5C")]
			[Address(RVA = "0x97F9D8", Offset = "0x97F9D8", VA = "0x97F9D8")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06005B5D RID: 23389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		private UnifiedRandom _random
		{
			[Token(Token = "0x6005B5D")]
			[Address(RVA = "0x97FA48", Offset = "0x97FA48", VA = "0x97FA48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A31")]
		private TileData _tiles
		{
			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x97FAFC", Offset = "0x97FAFC", VA = "0x97FAFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0x97FB60", Offset = "0x97FB60", VA = "0x97FB60")]
		private HouseBuilder()
		{
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x97CD6C", Offset = "0x97CD6C", VA = "0x97CD6C")]
		protected HouseBuilder(HouseType type, IEnumerable<Rectangle> rooms)
		{
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x97FBFC", Offset = "0x97FBFC", VA = "0x97FBFC", Slot = "4")]
		protected virtual void AgeRoom(Rectangle room)
		{
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x97FC00", Offset = "0x97FC00", VA = "0x97FC00")]
		public void PotentiallyConvertToRainbowMossBlock()
		{
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x97FD48", Offset = "0x97FD48", VA = "0x97FD48")]
		public void PotentiallyConvertToRainbowBrick()
		{
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x97FE88", Offset = "0x97FE88", VA = "0x97FE88")]
		public void RainbowifyOnTenthAnniversaryWorlds()
		{
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x97CFA0", Offset = "0x97CFA0", VA = "0x97CFA0")]
		public void PotentiallyConvertToSeedHouse()
		{
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x980344", Offset = "0x980344", VA = "0x980344")]
		public void PaintSeedHouses()
		{
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x980AF4", Offset = "0x980AF4", VA = "0x980AF4", Slot = "5")]
		public virtual void Place(HouseBuilderContext context, StructureMap structures)
		{
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B68")]
		[Address(RVA = "0x981140", Offset = "0x981140", VA = "0x981140")]
		private void PlaceEmptyRooms()
		{
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x983E20", Offset = "0x983E20", VA = "0x983E20")]
		private void FillRooms()
		{
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x981800", Offset = "0x981800", VA = "0x981800")]
		private void PlaceStairs()
		{
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x98724C", Offset = "0x98724C", VA = "0x98724C")]
		private List<Tuple<Point, Point>> CreateStairsList()
		{
			return null;
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x981F84", Offset = "0x981F84", VA = "0x981F84")]
		private void PlaceDoors()
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0x98756C", Offset = "0x98756C", VA = "0x98756C")]
		private List<Point> CreateDoorList()
		{
			return null;
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x982244", Offset = "0x982244", VA = "0x982244")]
		private void PlacePlatforms()
		{
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x987D50", Offset = "0x987D50", VA = "0x987D50")]
		private List<Point> CreatePlatformsList()
		{
			return null;
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x982614", Offset = "0x982614", VA = "0x982614")]
		private void PlaceSupportBeams()
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x9882EC", Offset = "0x9882EC", VA = "0x9882EC")]
		private List<Rectangle> CreateSupportBeamList()
		{
			return null;
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x0002AEA0 File Offset: 0x000290A0
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x98810C", Offset = "0x98810C", VA = "0x98810C")]
		private static bool FindVerticalExit(Rectangle wall, bool isUp, out int exitX)
		{
			return default(bool);
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x0002AEB8 File Offset: 0x000290B8
		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x987B70", Offset = "0x987B70", VA = "0x987B70")]
		private static bool FindSideExit(Rectangle wall, bool isLeft, out int exitY)
		{
			return default(bool);
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x9850E8", Offset = "0x9850E8", VA = "0x9850E8")]
		private void PlaceChests()
		{
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x982D54", Offset = "0x982D54", VA = "0x982D54")]
		private void PlaceBiomeSpecificPriorityTool(HouseBuilderContext context)
		{
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x986044", Offset = "0x986044", VA = "0x986044")]
		private void PlaceBiomeSpecificTool(HouseBuilderContext context)
		{
		}

		// Token: 0x04009C18 RID: 39960
		[Token(Token = "0x4009C18")]
		private const int VERTICAL_EXIT_WIDTH = 3;

		// Token: 0x04009C19 RID: 39961
		[Token(Token = "0x4009C19")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HouseBuilder Invalid;

		// Token: 0x04009C1A RID: 39962
		[Token(Token = "0x4009C1A")]
		[FieldOffset(Offset = "0x8")]
		public readonly HouseType Type;

		// Token: 0x04009C1B RID: 39963
		[Token(Token = "0x4009C1B")]
		[FieldOffset(Offset = "0xC")]
		public readonly bool IsValid;

		// Token: 0x04009C1C RID: 39964
		[Token(Token = "0x4009C1C")]
		[FieldOffset(Offset = "0x10")]
		private double <ChestChance>k__BackingField;

		// Token: 0x04009C1D RID: 39965
		[Token(Token = "0x4009C1D")]
		[FieldOffset(Offset = "0x18")]
		private ushort <TileType>k__BackingField;

		// Token: 0x04009C1E RID: 39966
		[Token(Token = "0x4009C1E")]
		[FieldOffset(Offset = "0x1A")]
		private ushort <WallType>k__BackingField;

		// Token: 0x04009C1F RID: 39967
		[Token(Token = "0x4009C1F")]
		[FieldOffset(Offset = "0x1C")]
		private ushort <BeamType>k__BackingField;

		// Token: 0x04009C20 RID: 39968
		[Token(Token = "0x4009C20")]
		[FieldOffset(Offset = "0x1E")]
		private byte <BeamPaint>k__BackingField;

		// Token: 0x04009C21 RID: 39969
		[Token(Token = "0x4009C21")]
		[FieldOffset(Offset = "0x20")]
		private int <PlatformStyle>k__BackingField;

		// Token: 0x04009C22 RID: 39970
		[Token(Token = "0x4009C22")]
		[FieldOffset(Offset = "0x24")]
		private int <DoorStyle>k__BackingField;

		// Token: 0x04009C23 RID: 39971
		[Token(Token = "0x4009C23")]
		[FieldOffset(Offset = "0x28")]
		private int <TableStyle>k__BackingField;

		// Token: 0x04009C24 RID: 39972
		[Token(Token = "0x4009C24")]
		[FieldOffset(Offset = "0x2C")]
		private bool <UsesTables2>k__BackingField;

		// Token: 0x04009C25 RID: 39973
		[Token(Token = "0x4009C25")]
		[FieldOffset(Offset = "0x30")]
		private int <WorkbenchStyle>k__BackingField;

		// Token: 0x04009C26 RID: 39974
		[Token(Token = "0x4009C26")]
		[FieldOffset(Offset = "0x34")]
		private int <PianoStyle>k__BackingField;

		// Token: 0x04009C27 RID: 39975
		[Token(Token = "0x4009C27")]
		[FieldOffset(Offset = "0x38")]
		private int <BookcaseStyle>k__BackingField;

		// Token: 0x04009C28 RID: 39976
		[Token(Token = "0x4009C28")]
		[FieldOffset(Offset = "0x3C")]
		private int <ChairStyle>k__BackingField;

		// Token: 0x04009C29 RID: 39977
		[Token(Token = "0x4009C29")]
		[FieldOffset(Offset = "0x40")]
		private int <ChestStyle>k__BackingField;

		// Token: 0x04009C2A RID: 39978
		[Token(Token = "0x4009C2A")]
		[FieldOffset(Offset = "0x44")]
		private bool <UsesContainers2>k__BackingField;

		// Token: 0x04009C2B RID: 39979
		[Token(Token = "0x4009C2B")]
		[FieldOffset(Offset = "0x48")]
		private ReadOnlyCollection<Rectangle> <Rooms>k__BackingField;

		// Token: 0x04009C2C RID: 39980
		[Token(Token = "0x4009C2C")]
		[FieldOffset(Offset = "0x4C")]
		protected ushort[] SkipTilesDuringWallAging;

		// Token: 0x02000BC0 RID: 3008
		[Token(Token = "0x2000BC0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005B79 RID: 23417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B79")]
			[Address(RVA = "0x988C68", Offset = "0x988C68", VA = "0x988C68")]
			public <>c()
			{
			}

			// Token: 0x06005B7A RID: 23418 RVA: 0x0002AED0 File Offset: 0x000290D0
			[Token(Token = "0x6005B7A")]
			[Address(RVA = "0x988C70", Offset = "0x988C70", VA = "0x988C70")]
			internal int <.ctor>b__78_0(Rectangle lhs, Rectangle rhs)
			{
				return 0;
			}

			// Token: 0x06005B7B RID: 23419 RVA: 0x0002AEE8 File Offset: 0x000290E8
			[Token(Token = "0x6005B7B")]
			[Address(RVA = "0x988CF4", Offset = "0x988CF4", VA = "0x988CF4")]
			internal int <CreateSupportBeamList>b__95_0(Rectangle room)
			{
				return 0;
			}

			// Token: 0x06005B7C RID: 23420 RVA: 0x0002AF00 File Offset: 0x00029100
			[Token(Token = "0x6005B7C")]
			[Address(RVA = "0x988D5C", Offset = "0x988D5C", VA = "0x988D5C")]
			internal int <CreateSupportBeamList>b__95_1(Rectangle room)
			{
				return 0;
			}

			// Token: 0x04009C2D RID: 39981
			[Token(Token = "0x4009C2D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HouseBuilder.<>c <>9;

			// Token: 0x04009C2E RID: 39982
			[Token(Token = "0x4009C2E")]
			[FieldOffset(Offset = "0x4")]
			public static Comparison<Rectangle> <>9__78_0;

			// Token: 0x04009C2F RID: 39983
			[Token(Token = "0x4009C2F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Rectangle, int> <>9__95_0;

			// Token: 0x04009C30 RID: 39984
			[Token(Token = "0x4009C30")]
			[FieldOffset(Offset = "0xC")]
			public static Func<Rectangle, int> <>9__95_1;
		}
	}
}
