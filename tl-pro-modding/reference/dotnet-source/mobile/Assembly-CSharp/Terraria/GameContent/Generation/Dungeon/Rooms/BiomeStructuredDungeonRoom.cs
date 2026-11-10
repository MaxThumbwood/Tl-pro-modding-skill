using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	public class BiomeStructuredDungeonRoom : BiomeDungeonRoom
	{
		// Token: 0x06005917 RID: 22807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005917")]
		[Address(RVA = "0x896460", Offset = "0x896460", VA = "0x896460")]
		public BiomeStructuredDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005918")]
		[Address(RVA = "0x896508", Offset = "0x896508", VA = "0x896508", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00029988 File Offset: 0x00027B88
		[Token(Token = "0x6005919")]
		[Address(RVA = "0x897CC4", Offset = "0x897CC4", VA = "0x897CC4", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591A")]
		[Address(RVA = "0x897D2C", Offset = "0x897D2C", VA = "0x897D2C", Slot = "6")]
		public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591B")]
		[Address(RVA = "0x89656C", Offset = "0x89656C", VA = "0x89656C")]
		public void BiomeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x000299A0 File Offset: 0x00027BA0
		[Token(Token = "0x600591C")]
		[Address(RVA = "0x898530", Offset = "0x898530", VA = "0x898530")]
		public float BiomeRoom_GetXPercent(UnifiedRandom genRand, int variant, float percentile)
		{
			return 0f;
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x000299B8 File Offset: 0x00027BB8
		[Token(Token = "0x600591D")]
		[Address(RVA = "0x8983D8", Offset = "0x8983D8", VA = "0x8983D8")]
		public float BiomeRoom_GetYPercent(UnifiedRandom genRand, int variant, float percentile)
		{
			return 0f;
		}

		// Token: 0x04009AAC RID: 39596
		[Token(Token = "0x4009AAC")]
		public const int VARIANT_DOUBLEDIAMOND = 0;

		// Token: 0x04009AAD RID: 39597
		[Token(Token = "0x4009AAD")]
		public const int VARIANT_ROUNDED = 1;

		// Token: 0x04009AAE RID: 39598
		[Token(Token = "0x4009AAE")]
		public const int VARIANT_CANDY = 2;

		// Token: 0x04009AAF RID: 39599
		[Token(Token = "0x4009AAF")]
		public const int VARIANT_WIGGLED = 3;

		// Token: 0x04009AB0 RID: 39600
		[Token(Token = "0x4009AB0")]
		public const int MAX_VARIANTS = 4;

		// Token: 0x04009AB1 RID: 39601
		[Token(Token = "0x4009AB1")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04009AB2 RID: 39602
		[Token(Token = "0x4009AB2")]
		[FieldOffset(Offset = "0x28")]
		public int RoomInnerSize;

		// Token: 0x04009AB3 RID: 39603
		[Token(Token = "0x4009AB3")]
		[FieldOffset(Offset = "0x2C")]
		public int RoomOuterSize;

		// Token: 0x04009AB4 RID: 39604
		[Token(Token = "0x4009AB4")]
		[FieldOffset(Offset = "0x30")]
		public int WallDepth;
	}
}
