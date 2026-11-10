using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	public class LegacyEntranceDungeonHall : LegacyDungeonHall
	{
		// Token: 0x060059B7 RID: 22967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x8B3380", Offset = "0x8B3380", VA = "0x8B3380")]
		public LegacyEntranceDungeonHall(DungeonHallSettings settings)
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x8B3404", Offset = "0x8B3404", VA = "0x8B3404", Slot = "5")]
		public override void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x8B3408", Offset = "0x8B3408", VA = "0x8B3408", Slot = "10")]
		public override void LegacyHall(DungeonData dungeonData, int i, int j, bool generating = false)
		{
		}

		// Token: 0x04009B45 RID: 39749
		[Token(Token = "0x4009B45")]
		[FieldOffset(Offset = "0x98")]
		public int Direction;
	}
}
