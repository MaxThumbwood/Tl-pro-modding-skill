using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	public abstract class DungeonEntranceSettings
	{
		// Token: 0x06005A3F RID: 23103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x8F33A8", Offset = "0x8F33A8", VA = "0x8F33A8")]
		protected DungeonEntranceSettings()
		{
		}

		// Token: 0x04009B93 RID: 39827
		[Token(Token = "0x4009B93")]
		[FieldOffset(Offset = "0x8")]
		public DungeonEntranceType EntranceType;

		// Token: 0x04009B94 RID: 39828
		[Token(Token = "0x4009B94")]
		[FieldOffset(Offset = "0xC")]
		public int RandomSeed;

		// Token: 0x04009B95 RID: 39829
		[Token(Token = "0x4009B95")]
		[FieldOffset(Offset = "0x10")]
		public DungeonGenerationStyleData StyleData;

		// Token: 0x04009B96 RID: 39830
		[Token(Token = "0x4009B96")]
		[FieldOffset(Offset = "0x14")]
		public bool PrecalculateEntrancePosition;
	}
}
