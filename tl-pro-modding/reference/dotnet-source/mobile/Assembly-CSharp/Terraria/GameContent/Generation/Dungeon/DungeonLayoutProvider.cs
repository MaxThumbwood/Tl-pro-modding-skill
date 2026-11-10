using System;
using Il2CppDummyDll;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B33 RID: 2867
	[Token(Token = "0x2000B33")]
	public abstract class DungeonLayoutProvider
	{
		// Token: 0x060058FA RID: 22778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x890DAC", Offset = "0x890DAC", VA = "0x890DAC")]
		public DungeonLayoutProvider(DungeonLayoutProviderSettings settings)
		{
		}

		// Token: 0x060058FB RID: 22779
		[Token(Token = "0x60058FB")]
		public abstract void ProvideLayout(DungeonData data, GenerationProgress progress, UnifiedRandom genRand, ref int roomDelay);

		// Token: 0x04009A9E RID: 39582
		[Token(Token = "0x4009A9E")]
		[FieldOffset(Offset = "0x8")]
		public DungeonLayoutProviderSettings settings;
	}
}
