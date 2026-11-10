using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7C RID: 2940
	[Token(Token = "0x2000B7C")]
	public class DungeonTileClump : DungeonFeature
	{
		// Token: 0x06005A21 RID: 23073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A21")]
		[Address(RVA = "0x8EBB08", Offset = "0x8EBB08", VA = "0x8EBB08")]
		public DungeonTileClump(DungeonFeatureSettings settings, bool addToFeatures = false)
		{
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x0002A390 File Offset: 0x00028590
		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x8EBC28", Offset = "0x8EBC28", VA = "0x8EBC28", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x0002A3A8 File Offset: 0x000285A8
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x8EBD18", Offset = "0x8EBD18", VA = "0x8EBD18")]
		public bool TileClump(DungeonData data, int i, int j, double strength, int steps, int tileType = -1, int wallType = -1, bool generating = false)
		{
			return default(bool);
		}
	}
}
