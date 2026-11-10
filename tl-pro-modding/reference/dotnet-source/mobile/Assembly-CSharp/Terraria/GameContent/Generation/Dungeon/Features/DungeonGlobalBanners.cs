using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	public class DungeonGlobalBanners : GlobalDungeonFeature
	{
		// Token: 0x060059DA RID: 23002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0x8BDA10", Offset = "0x8BDA10", VA = "0x8BDA10")]
		public DungeonGlobalBanners(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x8BDB24", Offset = "0x8BDB24", VA = "0x8BDB24", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x8BDB50", Offset = "0x8BDB50", VA = "0x8BDB50")]
		public void Banners(DungeonData data)
		{
		}
	}
}
