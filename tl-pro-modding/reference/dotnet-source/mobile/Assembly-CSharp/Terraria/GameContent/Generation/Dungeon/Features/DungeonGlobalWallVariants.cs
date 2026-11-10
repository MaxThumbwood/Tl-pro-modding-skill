using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	public class DungeonGlobalWallVariants : GlobalDungeonFeature
	{
		// Token: 0x06005A10 RID: 23056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x8E4AD4", Offset = "0x8E4AD4", VA = "0x8E4AD4")]
		public DungeonGlobalWallVariants(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x0002A2D0 File Offset: 0x000284D0
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x8E4BE8", Offset = "0x8E4BE8", VA = "0x8E4BE8", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x8E4C10", Offset = "0x8E4C10", VA = "0x8E4C10")]
		public void WallVariants(DungeonData data)
		{
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x8E513C", Offset = "0x8E513C", VA = "0x8E513C")]
		public void SpreadWallDungeon(DungeonData data, int x, int y, ushort wallType, bool dungeonWallOnly = true)
		{
		}
	}
}
