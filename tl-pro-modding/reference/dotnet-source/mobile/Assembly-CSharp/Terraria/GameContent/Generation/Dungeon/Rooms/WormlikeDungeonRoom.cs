using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	public class WormlikeDungeonRoom : DungeonRoom
	{
		// Token: 0x06005968 RID: 22888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005968")]
		[Address(RVA = "0x8A1504", Offset = "0x8A1504", VA = "0x8A1504")]
		public WormlikeDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005969")]
		[Address(RVA = "0x8A15AC", Offset = "0x8A15AC", VA = "0x8A15AC", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00029D60 File Offset: 0x00027F60
		[Token(Token = "0x600596A")]
		[Address(RVA = "0x8A24E4", Offset = "0x8A24E4", VA = "0x8A24E4", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00029D78 File Offset: 0x00027F78
		[Token(Token = "0x600596B")]
		[Address(RVA = "0x8A254C", Offset = "0x8A254C", VA = "0x8A254C", Slot = "18")]
		public override int GetFloodedRoomTileCount()
		{
			return 0;
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596C")]
		[Address(RVA = "0x8A2554", Offset = "0x8A2554", VA = "0x8A2554", Slot = "19")]
		public override void FloodRoom(byte liquidType)
		{
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00029D90 File Offset: 0x00027F90
		[Token(Token = "0x600596D")]
		[Address(RVA = "0x8A285C", Offset = "0x8A285C", VA = "0x8A285C", Slot = "16")]
		public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
		{
			return ProtectionType.None;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[Token(Token = "0x600596E")]
		[Address(RVA = "0x8A29A4", Offset = "0x8A29A4", VA = "0x8A29A4", Slot = "17")]
		public override bool IsInsideRoom(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596F")]
		[Address(RVA = "0x8A1610", Offset = "0x8A1610", VA = "0x8A1610")]
		public void WormlikeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009B01 RID: 39681
		[Token(Token = "0x4009B01")]
		[FieldOffset(Offset = "0x18")]
		private ShapeData _innerShapeData;

		// Token: 0x04009B02 RID: 39682
		[Token(Token = "0x4009B02")]
		[FieldOffset(Offset = "0x1C")]
		private ShapeData _outerShapeData;

		// Token: 0x04009B03 RID: 39683
		[Token(Token = "0x4009B03")]
		[FieldOffset(Offset = "0x20")]
		private int _floodedTileCount;

		// Token: 0x04009B04 RID: 39684
		[Token(Token = "0x4009B04")]
		[FieldOffset(Offset = "0x24")]
		public int InnerBoundsSizeMin;

		// Token: 0x04009B05 RID: 39685
		[Token(Token = "0x4009B05")]
		[FieldOffset(Offset = "0x28")]
		public int InnerBoundsSizeMax;

		// Token: 0x04009B06 RID: 39686
		[Token(Token = "0x4009B06")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2[] Positions;
	}
}
