using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	public class DungeonDropTrapSettings : DungeonFeatureSettings
	{
		// Token: 0x060059CF RID: 22991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CF")]
		[Address(RVA = "0x8B8E84", Offset = "0x8B8E84", VA = "0x8B8E84")]
		public DungeonDropTrapSettings()
		{
		}

		// Token: 0x04009B57 RID: 39767
		[Token(Token = "0x4009B57")]
		[FieldOffset(Offset = "0x8")]
		public DungeonGenerationStyleData StyleData;

		// Token: 0x04009B58 RID: 39768
		[Token(Token = "0x4009B58")]
		[FieldOffset(Offset = "0xC")]
		public DungeonDropTrapType DropTrapType;
	}
}
