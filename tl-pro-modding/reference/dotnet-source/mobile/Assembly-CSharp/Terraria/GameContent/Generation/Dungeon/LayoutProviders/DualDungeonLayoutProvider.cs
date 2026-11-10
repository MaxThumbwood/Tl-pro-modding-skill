using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.LayoutProviders
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	public class DualDungeonLayoutProvider : DungeonLayoutProvider
	{
		// Token: 0x06005971 RID: 22897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005971")]
		[Address(RVA = "0x8A2ACC", Offset = "0x8A2ACC", VA = "0x8A2ACC")]
		public DualDungeonLayoutProvider(DungeonLayoutProviderSettings settings)
		{
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005972")]
		[Address(RVA = "0x8A2AE8", Offset = "0x8A2AE8", VA = "0x8A2AE8", Slot = "4")]
		public override void ProvideLayout(DungeonData data, GenerationProgress progress, UnifiedRandom genRand, ref int roomDelay)
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00029DC0 File Offset: 0x00027FC0
		[Token(Token = "0x6005973")]
		[Address(RVA = "0x8A89E4", Offset = "0x8A89E4", VA = "0x8A89E4")]
		private static bool HallwayCheck_IsSpiderHall(DungeonHall hall)
		{
			return default(bool);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00029DD8 File Offset: 0x00027FD8
		[Token(Token = "0x6005974")]
		[Address(RVA = "0x8A8A2C", Offset = "0x8A8A2C", VA = "0x8A8A2C")]
		private static bool HallwayCheck_IsCrackedBrickHall(DungeonHall hall)
		{
			return default(bool);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005975")]
		[Address(RVA = "0x8A3EC8", Offset = "0x8A3EC8", VA = "0x8A3EC8")]
		private DungeonRoom CalculateStartingRoom(DungeonData data)
		{
			return null;
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005976")]
		[Address(RVA = "0x8A41C0", Offset = "0x8A41C0", VA = "0x8A41C0")]
		private DungeonHall CalculateEntranceHall(DungeonData data, DungeonRoom entranceRoom, DungeonRoom startingRoom)
		{
			return null;
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005977")]
		[Address(RVA = "0x8A4448", Offset = "0x8A4448", VA = "0x8A4448")]
		private List<DungeonRoom> CalculateBiomeRooms(DungeonData data)
		{
			return null;
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005978")]
		[Address(RVA = "0x8A4850", Offset = "0x8A4850", VA = "0x8A4850")]
		private List<DungeonRoom> CalculateRooms(DungeonData data)
		{
			return null;
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00029DF0 File Offset: 0x00027FF0
		[Token(Token = "0x6005979")]
		[Address(RVA = "0x8A8BFC", Offset = "0x8A8BFC", VA = "0x8A8BFC")]
		private bool TryMakeRegularRoomOnLine(DungeonData data, DungeonControlLine line, double normalizedDistanceAlong, double normalizedDistanceFrom, out DungeonRoom room)
		{
			return default(bool);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597A")]
		[Address(RVA = "0x8A8108", Offset = "0x8A8108", VA = "0x8A8108")]
		private static void CalculateDungeonBounds(DungeonData data, IEnumerable<DungeonRoom> rooms, IEnumerable<DungeonHall> halls)
		{
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597B")]
		[Address(RVA = "0x8A3950", Offset = "0x8A3950", VA = "0x8A3950")]
		private static DungeonRoom CalculateEntranceRoom(DungeonData data)
		{
			return null;
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00029E08 File Offset: 0x00028008
		[Token(Token = "0x600597C")]
		[Address(RVA = "0x8A8EE4", Offset = "0x8A8EE4", VA = "0x8A8EE4")]
		public static DungeonRoomType DualDungeonLayout_GetGeneralRoomType(UnifiedRandom genRand)
		{
			return DungeonRoomType.Legacy;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00029E20 File Offset: 0x00028020
		[Token(Token = "0x600597D")]
		[Address(RVA = "0x8A8F2C", Offset = "0x8A8F2C", VA = "0x8A8F2C")]
		public static DungeonHallType DualDungeonLayout_GetGeneralHallType(UnifiedRandom genRand)
		{
			return DungeonHallType.Legacy;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00029E38 File Offset: 0x00028038
		[Token(Token = "0x600597E")]
		[Address(RVA = "0x8A8F70", Offset = "0x8A8F70", VA = "0x8A8F70")]
		public static int DualDungeonLayout_GetHallRadius(DungeonHallType hallType)
		{
			return 0;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597F")]
		[Address(RVA = "0x8A4FE4", Offset = "0x8A4FE4", VA = "0x8A4FE4")]
		public void ConvertSpecializedRooms(DungeonData data, List<DungeonRoom> rooms)
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x8A7BF0", Offset = "0x8A7BF0", VA = "0x8A7BF0")]
		public void ConvertSpecializedHalls(List<DungeonHall> halls)
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00029E50 File Offset: 0x00028050
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x8A8F90", Offset = "0x8A8F90", VA = "0x8A8F90")]
		public static ConnectionPointQuality ConnectToTopOfRoomOnly(DungeonRoom room, Vector2D otherRoomPos, out Vector2D connectionPoint)
		{
			return ConnectionPointQuality.Good;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00029E68 File Offset: 0x00028068
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x8A9230", Offset = "0x8A9230", VA = "0x8A9230")]
		public static ConnectionPointQuality ConnectToBottomOfRoomOnly(DungeonRoom room, Vector2D otherRoomPos, out Vector2D connectionPoint)
		{
			return ConnectionPointQuality.Good;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00029E80 File Offset: 0x00028080
		[Token(Token = "0x6005983")]
		[Address(RVA = "0x8A8A50", Offset = "0x8A8A50", VA = "0x8A8A50")]
		public static ConnectionPointQuality GetHallwayConnectionPoints(DungeonRoom room1, DungeonRoom room2, out Vector2D point1, out Vector2D point2)
		{
			return ConnectionPointQuality.Good;
		}

		// Token: 0x02000B4B RID: 2891
		[Token(Token = "0x2000B4B")]
		private class HallwayCalculator
		{
			// Token: 0x06005984 RID: 22916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005984")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A6B40", VA = "0x8A6B40")]
			public HallwayCalculator(DungeonData data, List<DungeonRoom> rooms)
			{
			}

			// Token: 0x06005985 RID: 22917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005985")]
			[Address(RVA = "0x8A6FA4", Offset = "0x8A6FA4", VA = "0x8A6FA4")]
			public List<DungeonHall> Generate()
			{
				return null;
			}

			// Token: 0x06005986 RID: 22918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005986")]
			[Address(RVA = "0x8AABB8", Offset = "0x8AABB8", VA = "0x8AABB8")]
			private void MakeHall(DualDungeonLayoutProvider.HallwayCalculator.HallLine line, DungeonHallType hallType)
			{
			}

			// Token: 0x06005987 RID: 22919 RVA: 0x00029E98 File Offset: 0x00028098
			[Token(Token = "0x6005987")]
			[Address(RVA = "0x8AB170", Offset = "0x8AB170", VA = "0x8AB170")]
			private double ScoreHallway(DualDungeonLayoutProvider.HallwayCalculator.HallLine line)
			{
				return 0.0;
			}

			// Token: 0x06005988 RID: 22920 RVA: 0x00029EB0 File Offset: 0x000280B0
			[Token(Token = "0x6005988")]
			[Address(RVA = "0x8AC100", Offset = "0x8AC100", VA = "0x8AC100")]
			private double ScoreStairwell(DualDungeonLayoutProvider.HallwayCalculator.HallLine line)
			{
				return 0.0;
			}

			// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005989")]
			[Address(RVA = "0x8A94D0", Offset = "0x8A94D0", VA = "0x8A94D0")]
			private DualDungeonLayoutProvider.HallwayCalculator.HallLine SelectGoodRoomForHallway(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source, out double bestScore, Func<DualDungeonLayoutProvider.HallwayCalculator.HallLine, double> scoreFunc, int hallRadius)
			{
				return null;
			}

			// Token: 0x0600598A RID: 22922 RVA: 0x00029EC8 File Offset: 0x000280C8
			[Token(Token = "0x600598A")]
			[Address(RVA = "0x8AB820", Offset = "0x8AB820", VA = "0x8AB820")]
			private int DistanceFromCommonAncestor(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry a, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry b)
			{
				return 0;
			}

			// Token: 0x0600598B RID: 22923 RVA: 0x00029EE0 File Offset: 0x000280E0
			[Token(Token = "0x600598B")]
			[Address(RVA = "0x8AC4C8", Offset = "0x8AC4C8", VA = "0x8AC4C8")]
			private bool CanConnect(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry a, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry b)
			{
				return default(bool);
			}

			// Token: 0x0600598C RID: 22924 RVA: 0x00029EF8 File Offset: 0x000280F8
			[Token(Token = "0x600598C")]
			[Address(RVA = "0x8AC0B0", Offset = "0x8AC0B0", VA = "0x8AC0B0")]
			private static bool IsBiomeRoom(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry entry)
			{
				return default(bool);
			}

			// Token: 0x0600598D RID: 22925 RVA: 0x00029F10 File Offset: 0x00028110
			[Token(Token = "0x600598D")]
			[Address(RVA = "0x8AC63C", Offset = "0x8AC63C", VA = "0x8AC63C")]
			private static bool IsBiomeRoom(DungeonRoomType roomType)
			{
				return default(bool);
			}

			// Token: 0x04009B07 RID: 39687
			[Token(Token = "0x4009B07")]
			[FieldOffset(Offset = "0x8")]
			private readonly DungeonData data;

			// Token: 0x04009B08 RID: 39688
			[Token(Token = "0x4009B08")]
			[FieldOffset(Offset = "0xC")]
			private readonly List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> rooms;

			// Token: 0x04009B09 RID: 39689
			[Token(Token = "0x4009B09")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<DungeonHall> halls;

			// Token: 0x04009B0A RID: 39690
			[Token(Token = "0x4009B0A")]
			[FieldOffset(Offset = "0x14")]
			private readonly List<DualDungeonLayoutProvider.HallwayCalculator.HallLine> stairwells;

			// Token: 0x04009B0B RID: 39691
			[Token(Token = "0x4009B0B")]
			[FieldOffset(Offset = "0x18")]
			private readonly DitherSnake controlLines;

			// Token: 0x04009B0C RID: 39692
			[Token(Token = "0x4009B0C")]
			[FieldOffset(Offset = "0x20")]
			private readonly double maxProgressDelta;

			// Token: 0x04009B0D RID: 39693
			[Token(Token = "0x4009B0D")]
			[FieldOffset(Offset = "0x28")]
			private readonly double avgLineLength;

			// Token: 0x04009B0E RID: 39694
			[Token(Token = "0x4009B0E")]
			[FieldOffset(Offset = "0x30")]
			private readonly double extraNearbyRoomSearchRadius;

			// Token: 0x02000B4C RID: 2892
			[Token(Token = "0x2000B4C")]
			private class RoomEntry
			{
				// Token: 0x17000A00 RID: 2560
				// (get) Token: 0x0600598E RID: 22926 RVA: 0x00029F28 File Offset: 0x00028128
				[Token(Token = "0x17000A00")]
				public Point Center
				{
					[Token(Token = "0x600598E")]
					[Address(RVA = "0x8AC650", Offset = "0x8AC650", VA = "0x8AC650")]
					get
					{
						return default(Point);
					}
				}

				// Token: 0x0600598F RID: 22927 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600598F")]
				[Address(RVA = "0x8AC68C", Offset = "0x8AC68C", VA = "0x8AC68C")]
				public RoomEntry()
				{
				}

				// Token: 0x04009B0F RID: 39695
				[Token(Token = "0x4009B0F")]
				[FieldOffset(Offset = "0x8")]
				public DungeonRoom room;

				// Token: 0x04009B10 RID: 39696
				[Token(Token = "0x4009B10")]
				[FieldOffset(Offset = "0x10")]
				public double progressAlongSnake;

				// Token: 0x04009B11 RID: 39697
				[Token(Token = "0x4009B11")]
				[FieldOffset(Offset = "0x18")]
				public List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> backLinks;

				// Token: 0x04009B12 RID: 39698
				[Token(Token = "0x4009B12")]
				[FieldOffset(Offset = "0x1C")]
				public List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> forwardLinks;
			}

			// Token: 0x02000B4D RID: 2893
			[Token(Token = "0x2000B4D")]
			private class HallLine
			{
				// Token: 0x06005990 RID: 22928 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005990")]
				[Address(RVA = "0x8AC74C", Offset = "0x8AC74C", VA = "0x8AC74C")]
				public HallLine()
				{
				}

				// Token: 0x04009B13 RID: 39699
				[Token(Token = "0x4009B13")]
				[FieldOffset(Offset = "0x8")]
				public DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source;

				// Token: 0x04009B14 RID: 39700
				[Token(Token = "0x4009B14")]
				[FieldOffset(Offset = "0xC")]
				public DualDungeonLayoutProvider.HallwayCalculator.RoomEntry target;

				// Token: 0x04009B15 RID: 39701
				[Token(Token = "0x4009B15")]
				[FieldOffset(Offset = "0x10")]
				public Vector2D sourcePoint;

				// Token: 0x04009B16 RID: 39702
				[Token(Token = "0x4009B16")]
				[FieldOffset(Offset = "0x20")]
				public Vector2D targetPoint;
			}

			// Token: 0x02000B4E RID: 2894
			[Token(Token = "0x2000B4E")]
			private sealed class <>c__DisplayClass10_0
			{
				// Token: 0x06005991 RID: 22929 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005991")]
				[Address(RVA = "0x8AC754", Offset = "0x8AC754", VA = "0x8AC754")]
				public <>c__DisplayClass10_0()
				{
				}

				// Token: 0x06005992 RID: 22930 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005992")]
				[Address(RVA = "0x8AC75C", Offset = "0x8AC75C", VA = "0x8AC75C")]
				internal DualDungeonLayoutProvider.HallwayCalculator.RoomEntry <.ctor>b__0(DungeonRoom r)
				{
					return null;
				}

				// Token: 0x04009B17 RID: 39703
				[Token(Token = "0x4009B17")]
				[FieldOffset(Offset = "0x8")]
				public DungeonData data;
			}

			// Token: 0x02000B4F RID: 2895
			[Token(Token = "0x2000B4F")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005994 RID: 22932 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005994")]
				[Address(RVA = "0x8AC930", Offset = "0x8AC930", VA = "0x8AC930")]
				public <>c()
				{
				}

				// Token: 0x06005995 RID: 22933 RVA: 0x00029F40 File Offset: 0x00028140
				[Token(Token = "0x6005995")]
				[Address(RVA = "0x8AC938", Offset = "0x8AC938", VA = "0x8AC938")]
				internal double <.ctor>b__10_1(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry r)
				{
					return 0.0;
				}

				// Token: 0x06005996 RID: 22934 RVA: 0x00029F58 File Offset: 0x00028158
				[Token(Token = "0x6005996")]
				[Address(RVA = "0x8AC958", Offset = "0x8AC958", VA = "0x8AC958")]
				internal double <.ctor>b__10_2(DungeonControlLine l)
				{
					return 0.0;
				}

				// Token: 0x06005997 RID: 22935 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005997")]
				[Address(RVA = "0x8AC978", Offset = "0x8AC978", VA = "0x8AC978")]
				internal IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> <DistanceFromCommonAncestor>b__16_0(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry e)
				{
					return null;
				}

				// Token: 0x06005998 RID: 22936 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005998")]
				[Address(RVA = "0x8AC99C", Offset = "0x8AC99C", VA = "0x8AC99C")]
				internal IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> <DistanceFromCommonAncestor>b__16_1(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry e)
				{
					return null;
				}

				// Token: 0x04009B18 RID: 39704
				[Token(Token = "0x4009B18")]
				[FieldOffset(Offset = "0x0")]
				public static readonly DualDungeonLayoutProvider.HallwayCalculator.<>c <>9;

				// Token: 0x04009B19 RID: 39705
				[Token(Token = "0x4009B19")]
				[FieldOffset(Offset = "0x4")]
				public static Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, double> <>9__10_1;

				// Token: 0x04009B1A RID: 39706
				[Token(Token = "0x4009B1A")]
				[FieldOffset(Offset = "0x8")]
				public static Func<DungeonControlLine, double> <>9__10_2;

				// Token: 0x04009B1B RID: 39707
				[Token(Token = "0x4009B1B")]
				[FieldOffset(Offset = "0xC")]
				public static Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>> <>9__16_0;

				// Token: 0x04009B1C RID: 39708
				[Token(Token = "0x4009B1C")]
				[FieldOffset(Offset = "0x10")]
				public static Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>> <>9__16_1;
			}

			// Token: 0x02000B50 RID: 2896
			[Token(Token = "0x2000B50")]
			private sealed class <>c__DisplayClass15_0
			{
				// Token: 0x06005999 RID: 22937 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005999")]
				[Address(RVA = "0x8AC9C0", Offset = "0x8AC9C0", VA = "0x8AC9C0")]
				public <>c__DisplayClass15_0()
				{
				}

				// Token: 0x0600599A RID: 22938 RVA: 0x00029F70 File Offset: 0x00028170
				[Token(Token = "0x600599A")]
				[Address(RVA = "0x8AC9C8", Offset = "0x8AC9C8", VA = "0x8AC9C8")]
				internal bool <SelectGoodRoomForHallway>b__0(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry r)
				{
					return default(bool);
				}

				// Token: 0x0600599B RID: 22939 RVA: 0x00029F88 File Offset: 0x00028188
				[Token(Token = "0x600599B")]
				[Address(RVA = "0x8ACA2C", Offset = "0x8ACA2C", VA = "0x8ACA2C")]
				internal bool <SelectGoodRoomForHallway>b__1(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry r)
				{
					return default(bool);
				}

				// Token: 0x0600599C RID: 22940 RVA: 0x00029FA0 File Offset: 0x000281A0
				[Token(Token = "0x600599C")]
				[Address(RVA = "0x8ACA3C", Offset = "0x8ACA3C", VA = "0x8ACA3C")]
				internal double <SelectGoodRoomForHallway>b__2(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry r)
				{
					return 0.0;
				}

				// Token: 0x0600599D RID: 22941 RVA: 0x00029FB8 File Offset: 0x000281B8
				[Token(Token = "0x600599D")]
				[Address(RVA = "0x8ACB5C", Offset = "0x8ACB5C", VA = "0x8ACB5C")]
				internal bool <SelectGoodRoomForHallway>b__3(DualDungeonLayoutProvider.HallwayCalculator.RoomEntry r)
				{
					return default(bool);
				}

				// Token: 0x04009B1D RID: 39709
				[Token(Token = "0x4009B1D")]
				[FieldOffset(Offset = "0x8")]
				public DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source;

				// Token: 0x04009B1E RID: 39710
				[Token(Token = "0x4009B1E")]
				[FieldOffset(Offset = "0xC")]
				public DualDungeonLayoutProvider.HallwayCalculator <>4__this;

				// Token: 0x04009B1F RID: 39711
				[Token(Token = "0x4009B1F")]
				[FieldOffset(Offset = "0x10")]
				public double nearbyRoomSearchRadius;
			}
		}
	}
}
