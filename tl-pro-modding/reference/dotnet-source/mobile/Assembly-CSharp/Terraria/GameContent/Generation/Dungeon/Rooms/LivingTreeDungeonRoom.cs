using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x2000B44")]
	public class LivingTreeDungeonRoom : DungeonRoom
	{
		// Token: 0x06005956 RID: 22870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005956")]
		[Address(RVA = "0x89EC24", Offset = "0x89EC24", VA = "0x89EC24")]
		public LivingTreeDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005957")]
		[Address(RVA = "0x89ECCC", Offset = "0x89ECCC", VA = "0x89ECCC", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x00029CB8 File Offset: 0x00027EB8
		[Token(Token = "0x6005958")]
		[Address(RVA = "0x89F584", Offset = "0x89F584", VA = "0x89F584", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x00029CD0 File Offset: 0x00027ED0
		[Token(Token = "0x6005959")]
		[Address(RVA = "0x89F5EC", Offset = "0x89F5EC", VA = "0x89F5EC", Slot = "18")]
		public override int GetFloodedRoomTileCount()
		{
			return 0;
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595A")]
		[Address(RVA = "0x89F5F4", Offset = "0x89F5F4", VA = "0x89F5F4", Slot = "19")]
		public override void FloodRoom(byte liquidType)
		{
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x00029CE8 File Offset: 0x00027EE8
		[Token(Token = "0x600595B")]
		[Address(RVA = "0x89F8AC", Offset = "0x89F8AC", VA = "0x89F8AC", Slot = "16")]
		public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x00029D00 File Offset: 0x00027F00
		[Token(Token = "0x600595C")]
		[Address(RVA = "0x89F984", Offset = "0x89F984", VA = "0x89F984", Slot = "17")]
		public override bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595D")]
		[Address(RVA = "0x89FA28", Offset = "0x89FA28", VA = "0x89FA28", Slot = "5")]
		public override void GeneratePreHallwaysDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595E")]
		[Address(RVA = "0x8A0320", Offset = "0x8A0320", VA = "0x8A0320", Slot = "7")]
		public override void GenerateLateDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595F")]
		[Address(RVA = "0x89ED30", Offset = "0x89ED30", VA = "0x89ED30")]
		public void LivingTreeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AF8 RID: 39672
		[Token(Token = "0x4009AF8")]
		[FieldOffset(Offset = "0x18")]
		private ShapeData _innerShapeData;

		// Token: 0x04009AF9 RID: 39673
		[Token(Token = "0x4009AF9")]
		[FieldOffset(Offset = "0x1C")]
		private ShapeData _outerShapeData;

		// Token: 0x04009AFA RID: 39674
		[Token(Token = "0x4009AFA")]
		[FieldOffset(Offset = "0x20")]
		private int _floodedTileCount;

		// Token: 0x04009AFB RID: 39675
		[Token(Token = "0x4009AFB")]
		[FieldOffset(Offset = "0x24")]
		public Point[] Positions;
	}
}
