using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B6E RID: 2926
	[Token(Token = "0x2000B6E")]
	public class DungeonGlobalGroundFurniture : GlobalDungeonFeature
	{
		// Token: 0x060059ED RID: 23021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059ED")]
		[Address(RVA = "0x8CD880", Offset = "0x8CD880", VA = "0x8CD880")]
		public DungeonGlobalGroundFurniture(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x0002A180 File Offset: 0x00028380
		[Token(Token = "0x60059EE")]
		[Address(RVA = "0x8CD994", Offset = "0x8CD994", VA = "0x8CD994", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059EF")]
		[Address(RVA = "0x8CD9F0", Offset = "0x8CD9F0", VA = "0x8CD9F0")]
		public void GroundFurniture_DualDungeons(DungeonData data)
		{
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F0")]
		[Address(RVA = "0x8CE8C8", Offset = "0x8CE8C8", VA = "0x8CE8C8")]
		public void GroundFurniture(DungeonData data)
		{
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x0002A198 File Offset: 0x00028398
		[Token(Token = "0x60059F1")]
		[Address(RVA = "0x8CF2FC", Offset = "0x8CF2FC", VA = "0x8CF2FC")]
		private bool GroundFurniture_ActuallyGenerateFurniture(DungeonData data, UnifiedRandom genRand, int i, int j, ushort wallType, ref int alchTableCount, ref int bewitchTableCount, ref int minimumWaterCandles, bool stricterSpecialCheck = true, bool noRegularFurnitureAreaChecks = false)
		{
			return default(bool);
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x0002A1B0 File Offset: 0x000283B0
		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x8D45E8", Offset = "0x8D45E8", VA = "0x8D45E8")]
		private int GroundFurniture_GetFurnitureItem(DungeonGenerationStyleData styleData, UnifiedRandom genRand, int defaultItem, int[] items)
		{
			return 0;
		}
	}
}
