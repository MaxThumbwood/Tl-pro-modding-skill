using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B72 RID: 2930
	[Token(Token = "0x2000B72")]
	public class DungeonGlobalPlatforms : GlobalDungeonFeature
	{
		// Token: 0x06005A06 RID: 23046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x8DD994", Offset = "0x8DD994", VA = "0x8DD994")]
		public DungeonGlobalPlatforms(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0002A270 File Offset: 0x00028470
		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x8DDAA8", Offset = "0x8DDAA8", VA = "0x8DDAA8", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A08")]
		[Address(RVA = "0x8DDAD0", Offset = "0x8DDAD0", VA = "0x8DDAD0")]
		public void Platforms(DungeonData data)
		{
		}
	}
}
