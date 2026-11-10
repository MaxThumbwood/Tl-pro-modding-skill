using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	public abstract class DungeonHallSettings
	{
		// Token: 0x060059A2 RID: 22946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x8ADD44", Offset = "0x8ADD44", VA = "0x8ADD44")]
		protected DungeonHallSettings()
		{
		}

		// Token: 0x04009B28 RID: 39720
		[Token(Token = "0x4009B28")]
		[FieldOffset(Offset = "0x8")]
		public DungeonHallType HallType;

		// Token: 0x04009B29 RID: 39721
		[Token(Token = "0x4009B29")]
		[FieldOffset(Offset = "0xC")]
		public int RandomSeed;

		// Token: 0x04009B2A RID: 39722
		[Token(Token = "0x4009B2A")]
		[FieldOffset(Offset = "0x10")]
		public DungeonGenerationStyleData StyleData;

		// Token: 0x04009B2B RID: 39723
		[Token(Token = "0x4009B2B")]
		[FieldOffset(Offset = "0x14")]
		public int OverridePaintTile;

		// Token: 0x04009B2C RID: 39724
		[Token(Token = "0x4009B2C")]
		[FieldOffset(Offset = "0x18")]
		public int OverridePaintWall;

		// Token: 0x04009B2D RID: 39725
		[Token(Token = "0x4009B2D")]
		[FieldOffset(Offset = "0x20")]
		public double CrackedBrickChance;

		// Token: 0x04009B2E RID: 39726
		[Token(Token = "0x4009B2E")]
		[FieldOffset(Offset = "0x28")]
		public bool PlaceOverProtectedBricks;

		// Token: 0x04009B2F RID: 39727
		[Token(Token = "0x4009B2F")]
		[FieldOffset(Offset = "0x30")]
		public double ZigzagChance;

		// Token: 0x04009B30 RID: 39728
		[Token(Token = "0x4009B30")]
		[FieldOffset(Offset = "0x38")]
		public bool ForceStyleForDoorsAndPlatforms;

		// Token: 0x04009B31 RID: 39729
		[Token(Token = "0x4009B31")]
		[FieldOffset(Offset = "0x39")]
		public bool CarveOnly;
	}
}
