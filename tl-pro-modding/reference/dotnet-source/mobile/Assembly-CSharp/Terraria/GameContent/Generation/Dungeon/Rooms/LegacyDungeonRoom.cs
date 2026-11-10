using System;
using Il2CppDummyDll;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	public class LegacyDungeonRoom : DungeonRoom
	{
		// Token: 0x0600594A RID: 22858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594A")]
		[Address(RVA = "0x89CD48", Offset = "0x89CD48", VA = "0x89CD48")]
		public LegacyDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594B")]
		[Address(RVA = "0x89CDF0", Offset = "0x89CDF0", VA = "0x89CDF0", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00029C10 File Offset: 0x00027E10
		[Token(Token = "0x600594C")]
		[Address(RVA = "0x89E538", Offset = "0x89E538", VA = "0x89E538", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00029C28 File Offset: 0x00027E28
		[Token(Token = "0x600594D")]
		[Address(RVA = "0x89E5A0", Offset = "0x89E5A0", VA = "0x89E5A0", Slot = "18")]
		public override int GetFloodedRoomTileCount()
		{
			return 0;
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594E")]
		[Address(RVA = "0x89E5A8", Offset = "0x89E5A8", VA = "0x89E5A8", Slot = "19")]
		public override void FloodRoom(byte liquidType)
		{
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00029C40 File Offset: 0x00027E40
		[Token(Token = "0x600594F")]
		[Address(RVA = "0x89E8A8", Offset = "0x89E8A8", VA = "0x89E8A8", Slot = "16")]
		public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00029C58 File Offset: 0x00027E58
		[Token(Token = "0x6005950")]
		[Address(RVA = "0x89E9B0", Offset = "0x89E9B0", VA = "0x89E9B0", Slot = "17")]
		public override bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00029C70 File Offset: 0x00027E70
		[Token(Token = "0x6005951")]
		[Address(RVA = "0x89EA68", Offset = "0x89EA68", VA = "0x89EA68", Slot = "14")]
		public override bool TryGenerateChestInRoom(DungeonData data, DungeonGlobalBasicChests feature)
		{
			return default(bool);
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00029C88 File Offset: 0x00027E88
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x89EB30", Offset = "0x89EB30", VA = "0x89EB30", Slot = "15")]
		public override bool DualDungeons_TryGenerateBiomeChestInRoom(DungeonData data, DungeonGlobalBiomeChests feature)
		{
			return default(bool);
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005953")]
		[Address(RVA = "0x89CE58", Offset = "0x89CE58", VA = "0x89CE58")]
		public void LegacyRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AEE RID: 39662
		[Token(Token = "0x4009AEE")]
		[FieldOffset(Offset = "0x18")]
		private ShapeData _innerShapeData;

		// Token: 0x04009AEF RID: 39663
		[Token(Token = "0x4009AEF")]
		[FieldOffset(Offset = "0x1C")]
		private ShapeData _outerShapeData;

		// Token: 0x04009AF0 RID: 39664
		[Token(Token = "0x4009AF0")]
		[FieldOffset(Offset = "0x20")]
		private int _floodedTileCount;

		// Token: 0x04009AF1 RID: 39665
		[Token(Token = "0x4009AF1")]
		[FieldOffset(Offset = "0x28")]
		public Vector2D StartPosition;

		// Token: 0x04009AF2 RID: 39666
		[Token(Token = "0x4009AF2")]
		[FieldOffset(Offset = "0x38")]
		public Vector2D EndPosition;

		// Token: 0x04009AF3 RID: 39667
		[Token(Token = "0x4009AF3")]
		[FieldOffset(Offset = "0x48")]
		public int Strength;
	}
}
