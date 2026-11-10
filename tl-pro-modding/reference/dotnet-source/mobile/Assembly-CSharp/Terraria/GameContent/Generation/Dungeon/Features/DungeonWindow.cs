using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	public abstract class DungeonWindow : DungeonFeature
	{
		// Token: 0x06005A25 RID: 23077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x8EC9BC", Offset = "0x8EC9BC", VA = "0x8EC9BC")]
		public DungeonWindow(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0002A3C0 File Offset: 0x000285C0
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x8ECAD0", Offset = "0x8ECAD0", VA = "0x8ECAD0", Slot = "5")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}
	}
}
