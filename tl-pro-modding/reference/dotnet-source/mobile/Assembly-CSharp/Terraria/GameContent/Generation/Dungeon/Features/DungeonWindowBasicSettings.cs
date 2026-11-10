using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	public class DungeonWindowBasicSettings : DungeonWindowSettings
	{
		// Token: 0x06005A27 RID: 23079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x8ECB54", Offset = "0x8ECB54", VA = "0x8ECB54")]
		public DungeonWindowBasicSettings()
		{
		}

		// Token: 0x04009B87 RID: 39815
		[Token(Token = "0x4009B87")]
		[FieldOffset(Offset = "0x18")]
		public int Width;

		// Token: 0x04009B88 RID: 39816
		[Token(Token = "0x4009B88")]
		[FieldOffset(Offset = "0x1C")]
		public int Height;

		// Token: 0x04009B89 RID: 39817
		[Token(Token = "0x4009B89")]
		[FieldOffset(Offset = "0x20")]
		public int OverridePlatformStyle;
	}
}
