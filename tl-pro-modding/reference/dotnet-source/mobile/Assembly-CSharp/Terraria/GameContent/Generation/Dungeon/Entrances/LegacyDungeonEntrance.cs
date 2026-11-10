using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B8A RID: 2954
	[Token(Token = "0x2000B8A")]
	public class LegacyDungeonEntrance : DungeonEntrance
	{
		// Token: 0x06005A46 RID: 23110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x8F8088", Offset = "0x8F8088", VA = "0x8F8088")]
		public LegacyDungeonEntrance(DungeonEntranceSettings settings)
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x8F810C", Offset = "0x8F810C", VA = "0x8F810C", Slot = "4")]
		public override void CalculateEntrance(DungeonData data, int x, int y)
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x0002A510 File Offset: 0x00028710
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x8FED34", Offset = "0x8FED34", VA = "0x8FED34", Slot = "5")]
		public override bool GenerateEntrance(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A49")]
		[Address(RVA = "0x8F8140", Offset = "0x8F8140", VA = "0x8F8140")]
		public void LegacyEntrance(DungeonData data, int i, int j, bool generating)
		{
		}
	}
}
