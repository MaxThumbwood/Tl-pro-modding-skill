using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public class DungeonGlobalSpikes : GlobalDungeonFeature
	{
		// Token: 0x06005A09 RID: 23049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A09")]
		[Address(RVA = "0x8DF53C", Offset = "0x8DF53C", VA = "0x8DF53C")]
		public DungeonGlobalSpikes(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x0002A288 File Offset: 0x00028488
		[Token(Token = "0x6005A0A")]
		[Address(RVA = "0x8DF650", Offset = "0x8DF650", VA = "0x8DF650", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0x8DF678", Offset = "0x8DF678", VA = "0x8DF678")]
		public void Spikes(DungeonData data)
		{
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x0002A2A0 File Offset: 0x000284A0
		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0x8E33B8", Offset = "0x8E33B8", VA = "0x8E33B8")]
		private bool Spikes_CanSupportSpike(int x, int y)
		{
			return default(bool);
		}
	}
}
