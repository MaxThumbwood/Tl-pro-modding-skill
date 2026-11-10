using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x2000B86")]
	public class PreGenDungeonEntranceSettings : DungeonEntranceSettings
	{
		// Token: 0x06005A3E RID: 23102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x8F8054", Offset = "0x8F8054", VA = "0x8F8054")]
		public PreGenDungeonEntranceSettings()
		{
		}

		// Token: 0x04009B8F RID: 39823
		[Token(Token = "0x4009B8F")]
		[FieldOffset(Offset = "0x18")]
		public int BuriedEntranceYOffset;

		// Token: 0x04009B90 RID: 39824
		[Token(Token = "0x4009B90")]
		[FieldOffset(Offset = "0x1C")]
		public int BuriedEntranceSandDugoutYOffset;

		// Token: 0x04009B91 RID: 39825
		[Token(Token = "0x4009B91")]
		[FieldOffset(Offset = "0x20")]
		public int RoughHeight;

		// Token: 0x04009B92 RID: 39826
		[Token(Token = "0x4009B92")]
		[FieldOffset(Offset = "0x24")]
		public bool BuryEntrance;
	}
}
