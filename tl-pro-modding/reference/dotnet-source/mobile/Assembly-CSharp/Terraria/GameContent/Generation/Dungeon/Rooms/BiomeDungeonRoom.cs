using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	public abstract class BiomeDungeonRoom : DungeonRoom
	{
		// Token: 0x060058FE RID: 22782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x890F90", Offset = "0x890F90", VA = "0x890F90")]
		public BiomeDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x000298B0 File Offset: 0x00027AB0
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0x891040", Offset = "0x891040", VA = "0x891040", Slot = "4")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005900")]
		[Address(RVA = "0x8913E4", Offset = "0x8913E4", VA = "0x8913E4", Slot = "5")]
		public override void GeneratePreHallwaysDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005901")]
		[Address(RVA = "0x8913E8", Offset = "0x8913E8", VA = "0x8913E8", Slot = "6")]
		public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005902")]
		[Address(RVA = "0x8913EC", Offset = "0x8913EC", VA = "0x8913EC", Slot = "11")]
		public override void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x000298C8 File Offset: 0x00027AC8
		[Token(Token = "0x6005903")]
		[Address(RVA = "0x8914CC", Offset = "0x8914CC", VA = "0x8914CC", Slot = "12")]
		public override ConnectionPointQuality GetHallwayConnectionPoint(Vector2D otherRoomPos, out Vector2D connectionPoint)
		{
			return ConnectionPointQuality.Good;
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x000298E0 File Offset: 0x00027AE0
		[Token(Token = "0x6005904")]
		[Address(RVA = "0x8917B4", Offset = "0x8917B4", VA = "0x8917B4", Slot = "16")]
		public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x000298F8 File Offset: 0x00027AF8
		[Token(Token = "0x6005905")]
		[Address(RVA = "0x891960", Offset = "0x891960", VA = "0x891960", Slot = "17")]
		public override bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00029910 File Offset: 0x00027B10
		[Token(Token = "0x6005906")]
		[Address(RVA = "0x891A58", Offset = "0x891A58", VA = "0x891A58")]
		public static int GetBiomeRoomInnerSize(DungeonGenerationStyleData styleData)
		{
			return 0;
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00029928 File Offset: 0x00027B28
		[Token(Token = "0x6005907")]
		[Address(RVA = "0x890E98", Offset = "0x890E98", VA = "0x890E98")]
		public static int GetBiomeRoomOuterSize(DungeonGenerationStyleData styleData)
		{
			return 0;
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005908")]
		[Address(RVA = "0x891B24", Offset = "0x891B24", VA = "0x891B24")]
		public void BiomeRoom_AddHallwaySpace(Vector2 position, int edgeLeft, int edgeRight, int edgeTop, int edgeBottom, int shapeOffset, ushort wallType, byte? wallPaint, bool generating)
		{
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005909")]
		[Address(RVA = "0x891EBC", Offset = "0x891EBC", VA = "0x891EBC")]
		public void BiomeRoom_FinishRoom(UnifiedRandom genRand, int outerRoomLeft, int outerRoomRight, int outerRoomTop, int outerRoomBottom, bool treatAsSurface = false)
		{
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590A")]
		[Address(RVA = "0x8923DC", Offset = "0x8923DC", VA = "0x8923DC")]
		public void BiomeRoom_GrassySurface(UnifiedRandom genRand, ref List<int> heightsToSkip, int tileX, int tileY, Tile tile, ushort tileTypeToReplace, ushort grassTileType)
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590B")]
		[Address(RVA = "0x893194", Offset = "0x893194", VA = "0x893194")]
		public void BiomeRoom_SandySurface(UnifiedRandom genRand, ref List<int> heightsToSkip, int tileX, int tileY, Tile tile)
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590C")]
		[Address(RVA = "0x892B10", Offset = "0x892B10", VA = "0x892B10")]
		public void BiomeRoom_SnowySurface(UnifiedRandom genRand, ref List<int> heightsToSkip, int tileX, int tileY, Tile tile)
		{
		}

		// Token: 0x04009A9F RID: 39583
		[Token(Token = "0x4009A9F")]
		protected const int BIOMEROOM_INNER_SIZE_BASE = 32;

		// Token: 0x04009AA0 RID: 39584
		[Token(Token = "0x4009AA0")]
		protected const int BIOMEROOM_INNER_SIZE_BASE_TEMPLE = 50;

		// Token: 0x04009AA1 RID: 39585
		[Token(Token = "0x4009AA1")]
		protected const int BIOMEROOM_WALL_DEPTH = 8;

		// Token: 0x04009AA2 RID: 39586
		[Token(Token = "0x4009AA2")]
		[FieldOffset(Offset = "0x18")]
		protected ShapeData _innerShapeData;

		// Token: 0x04009AA3 RID: 39587
		[Token(Token = "0x4009AA3")]
		[FieldOffset(Offset = "0x1C")]
		protected ShapeData _outerShapeData;
	}
}
