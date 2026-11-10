using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	public class GenShapeDungeonRoom : DungeonRoom
	{
		// Token: 0x0600593D RID: 22845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593D")]
		[Address(RVA = "0x89ABD0", Offset = "0x89ABD0", VA = "0x89ABD0")]
		public GenShapeDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593E")]
		[Address(RVA = "0x89AC88", Offset = "0x89AC88", VA = "0x89AC88", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00029B68 File Offset: 0x00027D68
		[Token(Token = "0x600593F")]
		[Address(RVA = "0x89BC54", Offset = "0x89BC54", VA = "0x89BC54", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00029B80 File Offset: 0x00027D80
		[Token(Token = "0x6005940")]
		[Address(RVA = "0x89BCBC", Offset = "0x89BCBC", VA = "0x89BCBC", Slot = "4")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005941")]
		[Address(RVA = "0x89BE18", Offset = "0x89BE18", VA = "0x89BE18", Slot = "6")]
		public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00029B98 File Offset: 0x00027D98
		[Token(Token = "0x6005942")]
		[Address(RVA = "0x89C284", Offset = "0x89C284", VA = "0x89C284", Slot = "8")]
		public override Point GetRoomCenterForDungeonFeature(DungeonData data, DungeonFeature feature)
		{
			return default(Point);
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00029BB0 File Offset: 0x00027DB0
		[Token(Token = "0x6005943")]
		[Address(RVA = "0x89C3F0", Offset = "0x89C3F0", VA = "0x89C3F0", Slot = "9")]
		public override Point GetRoomCenterForHallway(Vector2D otherRoomPos)
		{
			return default(Point);
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x89C898", Offset = "0x89C898", VA = "0x89C898", Slot = "18")]
		public override int GetFloodedRoomTileCount()
		{
			return 0;
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005945")]
		[Address(RVA = "0x89C8A0", Offset = "0x89C8A0", VA = "0x89C8A0", Slot = "19")]
		public override void FloodRoom(byte liquidType)
		{
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[Token(Token = "0x6005946")]
		[Address(RVA = "0x89CB70", Offset = "0x89CB70", VA = "0x89CB70", Slot = "16")]
		public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00029BF8 File Offset: 0x00027DF8
		[Token(Token = "0x6005947")]
		[Address(RVA = "0x89CC74", Offset = "0x89CC74", VA = "0x89CC74", Slot = "17")]
		public override bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005948")]
		[Address(RVA = "0x89ACF0", Offset = "0x89ACF0", VA = "0x89ACF0")]
		public void GenShapeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AEA RID: 39658
		[Token(Token = "0x4009AEA")]
		[FieldOffset(Offset = "0x18")]
		private ShapeData _innerShapeData;

		// Token: 0x04009AEB RID: 39659
		[Token(Token = "0x4009AEB")]
		[FieldOffset(Offset = "0x1C")]
		private ShapeData _outerShapeData;

		// Token: 0x04009AEC RID: 39660
		[Token(Token = "0x4009AEC")]
		[FieldOffset(Offset = "0x20")]
		private int _floodedTileCount;
	}
}
