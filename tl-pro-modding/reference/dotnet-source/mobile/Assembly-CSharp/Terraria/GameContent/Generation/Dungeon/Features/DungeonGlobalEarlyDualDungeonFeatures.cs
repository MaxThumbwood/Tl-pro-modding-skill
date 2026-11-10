using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	public class DungeonGlobalEarlyDualDungeonFeatures : GlobalDungeonFeature
	{
		// Token: 0x060059EA RID: 23018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059EA")]
		[Address(RVA = "0x8C7F50", Offset = "0x8C7F50", VA = "0x8C7F50")]
		public DungeonGlobalEarlyDualDungeonFeatures(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0002A168 File Offset: 0x00028368
		[Token(Token = "0x60059EB")]
		[Address(RVA = "0x8C8064", Offset = "0x8C8064", VA = "0x8C8064", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059EC")]
		[Address(RVA = "0x8C8088", Offset = "0x8C8088", VA = "0x8C8088")]
		public void EarlyDungeonFeatures(DungeonData data)
		{
		}
	}
}
