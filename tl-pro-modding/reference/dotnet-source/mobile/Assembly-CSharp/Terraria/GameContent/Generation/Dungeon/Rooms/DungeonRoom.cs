using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Features;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	public abstract class DungeonRoom
	{
		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x000299E8 File Offset: 0x00027BE8
		[Token(Token = "0x170009FE")]
		public bool Processed
		{
			[Token(Token = "0x6005922")]
			[Address(RVA = "0x898724", Offset = "0x898724", VA = "0x898724")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x00029A00 File Offset: 0x00027C00
		[Token(Token = "0x170009FF")]
		public Point Center
		{
			[Token(Token = "0x6005923")]
			[Address(RVA = "0x891768", Offset = "0x891768", VA = "0x891768")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005924")]
		[Address(RVA = "0x890F94", Offset = "0x890F94", VA = "0x890F94")]
		public DungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00029A18 File Offset: 0x00027C18
		[Token(Token = "0x6005925")]
		[Address(RVA = "0x8911F8", Offset = "0x8911F8", VA = "0x8911F8", Slot = "4")]
		public virtual bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005926")]
		[Address(RVA = "0x898748", Offset = "0x898748", VA = "0x898748", Slot = "5")]
		public virtual void GeneratePreHallwaysDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005927")]
		[Address(RVA = "0x898A88", Offset = "0x898A88", VA = "0x898A88", Slot = "6")]
		public virtual void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005928")]
		[Address(RVA = "0x8991D8", Offset = "0x8991D8", VA = "0x8991D8", Slot = "7")]
		public virtual void GenerateLateDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00029A30 File Offset: 0x00027C30
		[Token(Token = "0x6005929")]
		[Address(RVA = "0x8991DC", Offset = "0x8991DC", VA = "0x8991DC", Slot = "8")]
		public virtual Point GetRoomCenterForDungeonFeature(DungeonData data, DungeonFeature feature)
		{
			return default(Point);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00029A48 File Offset: 0x00027C48
		[Token(Token = "0x600592A")]
		[Address(RVA = "0x899218", Offset = "0x899218", VA = "0x899218", Slot = "9")]
		public virtual Point GetRoomCenterForHallway(Vector2D otherRoomPos)
		{
			return default(Point);
		}

		// Token: 0x0600592B RID: 22827
		[Token(Token = "0x600592B")]
		public abstract void CalculateRoom(DungeonData data);

		// Token: 0x0600592C RID: 22828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592C")]
		[Address(RVA = "0x899254", Offset = "0x899254", VA = "0x899254", Slot = "11")]
		public virtual void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00029A60 File Offset: 0x00027C60
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x899338", Offset = "0x899338", VA = "0x899338", Slot = "12")]
		public virtual ConnectionPointQuality GetHallwayConnectionPoint(Vector2D otherRoomPos, out Vector2D connectionPoint)
		{
			return ConnectionPointQuality.Good;
		}

		// Token: 0x0600592E RID: 22830
		[Token(Token = "0x600592E")]
		public abstract bool GenerateRoom(DungeonData data);

		// Token: 0x0600592F RID: 22831 RVA: 0x00029A78 File Offset: 0x00027C78
		[Token(Token = "0x600592F")]
		[Address(RVA = "0x899F20", Offset = "0x899F20", VA = "0x899F20", Slot = "14")]
		public virtual bool TryGenerateChestInRoom(DungeonData data, DungeonGlobalBasicChests feature)
		{
			return default(bool);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00029A90 File Offset: 0x00027C90
		[Token(Token = "0x6005930")]
		[Address(RVA = "0x899F68", Offset = "0x899F68", VA = "0x899F68", Slot = "15")]
		public virtual bool DualDungeons_TryGenerateBiomeChestInRoom(DungeonData data, DungeonGlobalBiomeChests feature)
		{
			return default(bool);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x00029AA8 File Offset: 0x00027CA8
		[Token(Token = "0x6005931")]
		[Address(RVA = "0x899FB8", Offset = "0x899FB8", VA = "0x899FB8", Slot = "16")]
		public virtual ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00029AC0 File Offset: 0x00027CC0
		[Token(Token = "0x6005932")]
		[Address(RVA = "0x8917A4", Offset = "0x8917A4", VA = "0x8917A4")]
		public bool IsInsideRoom(Point point)
		{
			return default(bool);
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x00029AD8 File Offset: 0x00027CD8
		[Token(Token = "0x6005933")]
		[Address(RVA = "0x891A24", Offset = "0x891A24", VA = "0x891A24", Slot = "17")]
		public virtual bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00029AF0 File Offset: 0x00027CF0
		[Token(Token = "0x6005934")]
		[Address(RVA = "0x899FF4", Offset = "0x899FF4", VA = "0x899FF4", Slot = "18")]
		public virtual int GetFloodedRoomTileCount()
		{
			return 0;
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005935")]
		[Address(RVA = "0x89A040", Offset = "0x89A040", VA = "0x89A040", Slot = "19")]
		public virtual void FloodRoom(byte liquidType)
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00029B08 File Offset: 0x00027D08
		[Token(Token = "0x6005936")]
		[Address(RVA = "0x89A298", Offset = "0x89A298", VA = "0x89A298", Slot = "20")]
		public virtual int GetFurnitureCount(int defaultCount)
		{
			return 0;
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005937")]
		[Address(RVA = "0x89A2A0", Offset = "0x89A2A0", VA = "0x89A2A0")]
		public void GenerateDungeonSquareRoom(DungeonData data, DungeonBounds innerBounds, DungeonBounds outerBounds, Vector2D currentPoint, DungeonGenerationStyleData styleData, int innerBoundsSize, int totalBoundsSize, bool genTiles = true, bool genWalls = true)
		{
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x89A550", Offset = "0x89A550", VA = "0x89A550")]
		public void GenerateDungeonSquareRoom(DungeonData data, DungeonBounds innerBounds, DungeonBounds outerBounds, Vector2D currentPoint, ushort tileType, ushort wallType, int newStyleID, int? tilePaint, int? wallPaint, int innerBoundsSize, int totalBoundsSize, bool genTiles = true, bool genWalls = true)
		{
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00029B20 File Offset: 0x00027D20
		[Token(Token = "0x6005939")]
		[Address(RVA = "0x89A978", Offset = "0x89A978", VA = "0x89A978", Slot = "21")]
		public virtual bool CanPlaceTileAt(DungeonData data, Tile tile, int tileType, int wallType, int newStyleID)
		{
			return default(bool);
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x00029B38 File Offset: 0x00027D38
		[Token(Token = "0x600593A")]
		[Address(RVA = "0x89AAE8", Offset = "0x89AAE8", VA = "0x89AAE8", Slot = "22")]
		public virtual bool CanRemoveTileAt(DungeonData data, Tile tile)
		{
			return default(bool);
		}

		// Token: 0x04009ADB RID: 39643
		[Token(Token = "0x4009ADB")]
		[FieldOffset(Offset = "0x8")]
		public DungeonRoomSettings settings;

		// Token: 0x04009ADC RID: 39644
		[Token(Token = "0x4009ADC")]
		[FieldOffset(Offset = "0xC")]
		public bool calculated;

		// Token: 0x04009ADD RID: 39645
		[Token(Token = "0x4009ADD")]
		[FieldOffset(Offset = "0xD")]
		public bool generated;

		// Token: 0x04009ADE RID: 39646
		[Token(Token = "0x4009ADE")]
		[FieldOffset(Offset = "0x10")]
		public DungeonBounds InnerBounds;

		// Token: 0x04009ADF RID: 39647
		[Token(Token = "0x4009ADF")]
		[FieldOffset(Offset = "0x14")]
		public DungeonBounds OuterBounds;
	}
}
