using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	public class DungeonPitTrap : DungeonFeature
	{
		// Token: 0x06005A1B RID: 23067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0x8E789C", Offset = "0x8E789C", VA = "0x8E789C")]
		public DungeonPitTrap(DungeonFeatureSettings settings, bool addToFeatures = true)
		{
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x0002A330 File Offset: 0x00028530
		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0x8E79BC", Offset = "0x8E79BC", VA = "0x8E79BC", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x0002A348 File Offset: 0x00028548
		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0x8EB9FC", Offset = "0x8EB9FC", VA = "0x8EB9FC", Slot = "5")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x0002A360 File Offset: 0x00028560
		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0x8E7ACC", Offset = "0x8E7ACC", VA = "0x8E7ACC")]
		public bool PitTrap(DungeonData data, int i, int j, DungeonGenerationStyleData styleData, bool generating = false)
		{
			return default(bool);
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x0002A378 File Offset: 0x00028578
		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0x8EBAC8", Offset = "0x8EBAC8", VA = "0x8EBAC8")]
		public int GetHeight(int[] heights, int baseX, int x, int innerWidth, int outerWidth, bool inner)
		{
			return 0;
		}

		// Token: 0x04009B7A RID: 39802
		[Token(Token = "0x4009B7A")]
		[FieldOffset(Offset = "0x11")]
		public bool Flooded;
	}
}
