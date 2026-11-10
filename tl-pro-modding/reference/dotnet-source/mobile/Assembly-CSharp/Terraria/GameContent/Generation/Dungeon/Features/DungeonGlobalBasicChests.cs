using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	public class DungeonGlobalBasicChests : GlobalDungeonFeature
	{
		// Token: 0x060059DD RID: 23005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x8BF00C", Offset = "0x8BF00C", VA = "0x8BF00C")]
		public DungeonGlobalBasicChests(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x0002A108 File Offset: 0x00028308
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x8BF120", Offset = "0x8BF120", VA = "0x8BF120", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x8BF148", Offset = "0x8BF148", VA = "0x8BF148")]
		private void BasicChests(DungeonData data)
		{
		}
	}
}
