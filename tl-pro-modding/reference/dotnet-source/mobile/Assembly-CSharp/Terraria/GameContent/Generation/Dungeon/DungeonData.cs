using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Entrances;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B21 RID: 2849
	[Token(Token = "0x2000B21")]
	public class DungeonData
	{
		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F8")]
		public DungeonGenVars genVars
		{
			[Token(Token = "0x6005887")]
			[Address(RVA = "0x873FA8", Offset = "0x873FA8", VA = "0x873FA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06005888 RID: 22664 RVA: 0x00029388 File Offset: 0x00027588
		[Token(Token = "0x170009F9")]
		public double HallSizeScalar
		{
			[Token(Token = "0x6005888")]
			[Address(RVA = "0x87404C", Offset = "0x87404C", VA = "0x87404C")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x000293A0 File Offset: 0x000275A0
		[Token(Token = "0x170009FA")]
		public double RoomSizeScalar
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0x874068", Offset = "0x874068", VA = "0x874068")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x000293B8 File Offset: 0x000275B8
		[Token(Token = "0x600588A")]
		[Address(RVA = "0x874084", Offset = "0x874084", VA = "0x874084")]
		public bool CanGenerateFeatureInArea(IDungeonFeature feature, int x, int y, int fluff)
		{
			return default(bool);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x000293D0 File Offset: 0x000275D0
		[Token(Token = "0x600588B")]
		[Address(RVA = "0x8741D8", Offset = "0x8741D8", VA = "0x8741D8")]
		public bool CanGenerateFeatureInArea(IDungeonFeature feature, DungeonBounds bounds)
		{
			return default(bool);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x000293E8 File Offset: 0x000275E8
		[Token(Token = "0x600588C")]
		[Address(RVA = "0x874274", Offset = "0x874274", VA = "0x874274")]
		public bool CanGenerateFeatureInArea(IDungeonFeature feature, Rectangle hitbox)
		{
			return default(bool);
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00029400 File Offset: 0x00027600
		[Token(Token = "0x600588D")]
		[Address(RVA = "0x87439C", Offset = "0x87439C", VA = "0x87439C")]
		public bool CanGenerateFeatureAt(IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00029418 File Offset: 0x00027618
		[Token(Token = "0x600588E")]
		[Address(RVA = "0x874878", Offset = "0x874878", VA = "0x874878")]
		public bool IsAnyRoomInSpot(out DungeonRoom roomFound, int x, int y, DungeonRoomSearchSettings settings)
		{
			return default(bool);
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00029430 File Offset: 0x00027630
		[Token(Token = "0x600588F")]
		[Address(RVA = "0x874BF0", Offset = "0x874BF0", VA = "0x874BF0")]
		public bool IsAnyRoomInBounds(out DungeonRoom roomFound, DungeonBounds bounds, DungeonRoomSearchSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005890")]
		[Address(RVA = "0x874E64", Offset = "0x874E64", VA = "0x874E64")]
		public DungeonData()
		{
		}

		// Token: 0x040099FB RID: 39419
		[Token(Token = "0x40099FB")]
		[FieldOffset(Offset = "0x8")]
		public DungeonType Type;

		// Token: 0x040099FC RID: 39420
		[Token(Token = "0x40099FC")]
		[FieldOffset(Offset = "0xC")]
		public int Iteration;

		// Token: 0x040099FD RID: 39421
		[Token(Token = "0x40099FD")]
		[FieldOffset(Offset = "0x10")]
		public DungeonEntrance dungeonEntrance;

		// Token: 0x040099FE RID: 39422
		[Token(Token = "0x40099FE")]
		[FieldOffset(Offset = "0x14")]
		public List<DungeonRoom> dungeonRooms;

		// Token: 0x040099FF RID: 39423
		[Token(Token = "0x40099FF")]
		[FieldOffset(Offset = "0x18")]
		public List<DungeonHall> dungeonHalls;

		// Token: 0x04009A00 RID: 39424
		[Token(Token = "0x4009A00")]
		[FieldOffset(Offset = "0x1C")]
		public List<IDungeonFeature> dungeonFeatures;

		// Token: 0x04009A01 RID: 39425
		[Token(Token = "0x4009A01")]
		[FieldOffset(Offset = "0x20")]
		public List<DungeonDoorData> dungeonDoorData;

		// Token: 0x04009A02 RID: 39426
		[Token(Token = "0x4009A02")]
		[FieldOffset(Offset = "0x24")]
		public List<DungeonPlatformData> dungeonPlatformData;

		// Token: 0x04009A03 RID: 39427
		[Token(Token = "0x4009A03")]
		[FieldOffset(Offset = "0x28")]
		public List<DungeonBounds> protectedDungeonBounds;

		// Token: 0x04009A04 RID: 39428
		[Token(Token = "0x4009A04")]
		[FieldOffset(Offset = "0x2C")]
		public bool makeNextPitTrapFlooded;

		// Token: 0x04009A05 RID: 39429
		[Token(Token = "0x4009A05")]
		[FieldOffset(Offset = "0x2D")]
		public bool useSkewedDungeonEntranceHalls;

		// Token: 0x04009A06 RID: 39430
		[Token(Token = "0x4009A06")]
		[FieldOffset(Offset = "0x2E")]
		public bool createdDungeonEntranceOnSurface;

		// Token: 0x04009A07 RID: 39431
		[Token(Token = "0x4009A07")]
		[FieldOffset(Offset = "0x30")]
		public double dungeonEntranceStrengthX;

		// Token: 0x04009A08 RID: 39432
		[Token(Token = "0x4009A08")]
		[FieldOffset(Offset = "0x38")]
		public double dungeonEntranceStrengthY;

		// Token: 0x04009A09 RID: 39433
		[Token(Token = "0x4009A09")]
		[FieldOffset(Offset = "0x40")]
		public double dungeonEntranceStrengthX2;

		// Token: 0x04009A0A RID: 39434
		[Token(Token = "0x4009A0A")]
		[FieldOffset(Offset = "0x48")]
		public double dungeonEntranceStrengthY2;

		// Token: 0x04009A0B RID: 39435
		[Token(Token = "0x4009A0B")]
		[FieldOffset(Offset = "0x50")]
		public Vector2D lastDungeonHall;

		// Token: 0x04009A0C RID: 39436
		[Token(Token = "0x4009A0C")]
		[FieldOffset(Offset = "0x60")]
		public DungeonBounds dungeonBounds;

		// Token: 0x04009A0D RID: 39437
		[Token(Token = "0x4009A0D")]
		[FieldOffset(Offset = "0x64")]
		public DungeonBounds[] outerProgressionBounds;

		// Token: 0x04009A0E RID: 39438
		[Token(Token = "0x4009A0E")]
		[FieldOffset(Offset = "0x68")]
		public int[] wallVariants;

		// Token: 0x04009A0F RID: 39439
		[Token(Token = "0x4009A0F")]
		[FieldOffset(Offset = "0x6C")]
		public int chandelierItemType;

		// Token: 0x04009A10 RID: 39440
		[Token(Token = "0x4009A10")]
		[FieldOffset(Offset = "0x70")]
		public int platformItemType;

		// Token: 0x04009A11 RID: 39441
		[Token(Token = "0x4009A11")]
		[FieldOffset(Offset = "0x74")]
		public int doorItemType;

		// Token: 0x04009A12 RID: 39442
		[Token(Token = "0x4009A12")]
		[FieldOffset(Offset = "0x78")]
		public int[] lanternStyles;

		// Token: 0x04009A13 RID: 39443
		[Token(Token = "0x4009A13")]
		[FieldOffset(Offset = "0x7C")]
		public int[] shelfStyles;

		// Token: 0x04009A14 RID: 39444
		[Token(Token = "0x4009A14")]
		[FieldOffset(Offset = "0x80")]
		public int[] bannerStyles;

		// Token: 0x04009A15 RID: 39445
		[Token(Token = "0x4009A15")]
		[FieldOffset(Offset = "0x88")]
		public double globalFeatureScalar;

		// Token: 0x04009A16 RID: 39446
		[Token(Token = "0x4009A16")]
		[FieldOffset(Offset = "0x90")]
		public double dungeonStepScalar;

		// Token: 0x04009A17 RID: 39447
		[Token(Token = "0x4009A17")]
		[FieldOffset(Offset = "0x98")]
		public double hallStrengthScalar;

		// Token: 0x04009A18 RID: 39448
		[Token(Token = "0x4009A18")]
		[FieldOffset(Offset = "0xA0")]
		public double hallStepScalar;

		// Token: 0x04009A19 RID: 39449
		[Token(Token = "0x4009A19")]
		[FieldOffset(Offset = "0xA8")]
		public double hallInteriorToExteriorRatio;

		// Token: 0x04009A1A RID: 39450
		[Token(Token = "0x4009A1A")]
		[FieldOffset(Offset = "0xB0")]
		public double hallSlantVariantScalar;

		// Token: 0x04009A1B RID: 39451
		[Token(Token = "0x4009A1B")]
		[FieldOffset(Offset = "0xB8")]
		public double roomStrengthScalar;

		// Token: 0x04009A1C RID: 39452
		[Token(Token = "0x4009A1C")]
		[FieldOffset(Offset = "0xC0")]
		public double roomStepScalar;

		// Token: 0x04009A1D RID: 39453
		[Token(Token = "0x4009A1D")]
		[FieldOffset(Offset = "0xC8")]
		public double roomInteriorToExteriorRatio;

		// Token: 0x04009A1E RID: 39454
		[Token(Token = "0x4009A1E")]
		[FieldOffset(Offset = "0xD0")]
		public double roomSlantVariantScalar;
	}
}
