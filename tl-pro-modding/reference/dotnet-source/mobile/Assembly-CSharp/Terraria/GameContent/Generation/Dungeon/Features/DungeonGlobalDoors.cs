using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B6C RID: 2924
	[Token(Token = "0x2000B6C")]
	public class DungeonGlobalDoors : GlobalDungeonFeature
	{
		// Token: 0x060059E7 RID: 23015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x8C2758", Offset = "0x8C2758", VA = "0x8C2758")]
		public DungeonGlobalDoors(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0002A150 File Offset: 0x00028350
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x8C286C", Offset = "0x8C286C", VA = "0x8C286C", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x8C2890", Offset = "0x8C2890", VA = "0x8C2890")]
		public void Doors(DungeonData data)
		{
		}
	}
}
