using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B56 RID: 2902
	[Token(Token = "0x2000B56")]
	public abstract class DungeonHall
	{
		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x00029FD0 File Offset: 0x000281D0
		[Token(Token = "0x17000A01")]
		public bool Processed
		{
			[Token(Token = "0x60059A4")]
			[Address(RVA = "0x8ADDCC", Offset = "0x8ADDCC", VA = "0x8ADDCC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060059A5 RID: 22949 RVA: 0x00029FE8 File Offset: 0x000281E8
		[Token(Token = "0x17000A02")]
		public Vector2D CenterPosition
		{
			[Token(Token = "0x60059A5")]
			[Address(RVA = "0x8ADDF0", Offset = "0x8ADDF0", VA = "0x8ADDF0")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x8ADED4", Offset = "0x8ADED4", VA = "0x8ADED4")]
		public DungeonHall(DungeonHallSettings settings)
		{
		}

		// Token: 0x060059A7 RID: 22951
		[Token(Token = "0x60059A7")]
		public abstract void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint);

		// Token: 0x060059A8 RID: 22952
		[Token(Token = "0x60059A8")]
		public abstract void CalculatePlatformsAndDoors(DungeonData data);

		// Token: 0x060059A9 RID: 22953
		[Token(Token = "0x60059A9")]
		public abstract void GenerateHall(DungeonData data);

		// Token: 0x060059AA RID: 22954 RVA: 0x0002A000 File Offset: 0x00028200
		[Token(Token = "0x60059AA")]
		[Address(RVA = "0x8ADF58", Offset = "0x8ADF58", VA = "0x8ADF58", Slot = "7")]
		public virtual int GetFurnitureCount(int defaultCount)
		{
			return 0;
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0x8ADF60", Offset = "0x8ADF60", VA = "0x8ADF60")]
		public void AddExtraPlatformsIfNeeded(DungeonData data)
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0x8AE310", Offset = "0x8AE310", VA = "0x8AE310")]
		public void GenerateDungeonSquareHall(DungeonData data, List<DungeonRoom> roomsInArea, Vector2D currentPoint, DungeonGenerationStyleData styleData, int innerBoundsSize, int outerBoundsSize, bool placeOverProtectedBricks = false, bool crackedBricks = false, bool clearPaintFirst = false)
		{
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x0002A018 File Offset: 0x00028218
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0x8AF1CC", Offset = "0x8AF1CC", VA = "0x8AF1CC", Slot = "8")]
		public virtual bool CanPlaceTileAt(DungeonData data, Tile tile, int tileType, int tileCrackedType)
		{
			return default(bool);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x0002A030 File Offset: 0x00028230
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0x8AF49C", Offset = "0x8AF49C", VA = "0x8AF49C", Slot = "9")]
		public virtual bool CanRemoveTileAt(DungeonData data, Tile tile, int tileCrackedType)
		{
			return default(bool);
		}

		// Token: 0x04009B36 RID: 39734
		[Token(Token = "0x4009B36")]
		[FieldOffset(Offset = "0x8")]
		public DungeonHallSettings settings;

		// Token: 0x04009B37 RID: 39735
		[Token(Token = "0x4009B37")]
		[FieldOffset(Offset = "0xC")]
		public bool calculated;

		// Token: 0x04009B38 RID: 39736
		[Token(Token = "0x4009B38")]
		[FieldOffset(Offset = "0xD")]
		public bool generated;

		// Token: 0x04009B39 RID: 39737
		[Token(Token = "0x4009B39")]
		[FieldOffset(Offset = "0x10")]
		public DungeonBounds Bounds;

		// Token: 0x04009B3A RID: 39738
		[Token(Token = "0x4009B3A")]
		[FieldOffset(Offset = "0x18")]
		public Vector2D StartPosition;

		// Token: 0x04009B3B RID: 39739
		[Token(Token = "0x4009B3B")]
		[FieldOffset(Offset = "0x28")]
		public Vector2D EndPosition;

		// Token: 0x04009B3C RID: 39740
		[Token(Token = "0x4009B3C")]
		[FieldOffset(Offset = "0x38")]
		public Vector2D StartDirection;

		// Token: 0x04009B3D RID: 39741
		[Token(Token = "0x4009B3D")]
		[FieldOffset(Offset = "0x48")]
		public Vector2D EndDirection;

		// Token: 0x04009B3E RID: 39742
		[Token(Token = "0x4009B3E")]
		[FieldOffset(Offset = "0x58")]
		public bool CrackedBrick;
	}
}
