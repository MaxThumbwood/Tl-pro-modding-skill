using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B78 RID: 2936
	[Token(Token = "0x2000B78")]
	public class DungeonPillar : DungeonFeature
	{
		// Token: 0x06005A15 RID: 23061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x8E6098", Offset = "0x8E6098", VA = "0x8E6098")]
		public DungeonPillar(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0002A2E8 File Offset: 0x000284E8
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x8E61AC", Offset = "0x8E61AC", VA = "0x8E61AC", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0002A300 File Offset: 0x00028500
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x8E664C", Offset = "0x8E664C", VA = "0x8E664C", Slot = "5")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x0002A318 File Offset: 0x00028518
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x8E62AC", Offset = "0x8E62AC", VA = "0x8E62AC")]
		public bool Pillar(DungeonData data, int i, int j, DungeonGenerationStyleData styleData, bool generating = false)
		{
			return default(bool);
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x8E6654", Offset = "0x8E6654", VA = "0x8E6654")]
		public static void GenerateTileStrip(DungeonPillarSettings pillarSettings, bool upwards, out int topY, out int bottomY, int placeX, int placeY, int pillarHeight, DungeonGenerationStyleData styleData, bool smoothTop, bool smoothBottom)
		{
		}
	}
}
