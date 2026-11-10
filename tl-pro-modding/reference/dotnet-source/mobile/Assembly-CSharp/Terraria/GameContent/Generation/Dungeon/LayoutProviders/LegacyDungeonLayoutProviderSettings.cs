using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.LayoutProviders
{
	// Token: 0x02000B51 RID: 2897
	[Token(Token = "0x2000B51")]
	public class LegacyDungeonLayoutProviderSettings : DungeonLayoutProviderSettings
	{
		// Token: 0x0600599E RID: 22942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599E")]
		[Address(RVA = "0x8ACCB0", Offset = "0x8ACCB0", VA = "0x8ACCB0")]
		public LegacyDungeonLayoutProviderSettings()
		{
		}

		// Token: 0x04009B20 RID: 39712
		[Token(Token = "0x4009B20")]
		[FieldOffset(Offset = "0xC")]
		public int Steps;

		// Token: 0x04009B21 RID: 39713
		[Token(Token = "0x4009B21")]
		[FieldOffset(Offset = "0x10")]
		public int MaxSteps;
	}
}
