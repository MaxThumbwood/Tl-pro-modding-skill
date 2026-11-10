using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B74 RID: 2932
	[Token(Token = "0x2000B74")]
	public class DungeonGlobalTraps : GlobalDungeonFeature
	{
		// Token: 0x06005A0D RID: 23053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x8E3724", Offset = "0x8E3724", VA = "0x8E3724")]
		public DungeonGlobalTraps(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0002A2B8 File Offset: 0x000284B8
		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x8E3838", Offset = "0x8E3838", VA = "0x8E3838", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x8E3860", Offset = "0x8E3860", VA = "0x8E3860")]
		public void Traps(DungeonData data)
		{
		}
	}
}
