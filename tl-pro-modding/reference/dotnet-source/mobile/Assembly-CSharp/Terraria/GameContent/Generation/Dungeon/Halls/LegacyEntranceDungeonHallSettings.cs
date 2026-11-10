using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	public class LegacyEntranceDungeonHallSettings : LegacyDungeonHallSettings
	{
		// Token: 0x060059B6 RID: 22966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x8B333C", Offset = "0x8B333C", VA = "0x8B333C")]
		public LegacyEntranceDungeonHallSettings()
		{
		}

		// Token: 0x04009B44 RID: 39748
		[Token(Token = "0x4009B44")]
		[FieldOffset(Offset = "0x50")]
		public bool UsePrecalculatedEntrance;
	}
}
