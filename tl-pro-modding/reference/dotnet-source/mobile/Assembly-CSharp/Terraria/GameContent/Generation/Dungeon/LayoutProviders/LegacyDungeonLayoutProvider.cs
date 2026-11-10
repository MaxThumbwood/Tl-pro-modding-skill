using System;
using Il2CppDummyDll;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.LayoutProviders
{
	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2000B52")]
	public class LegacyDungeonLayoutProvider : DungeonLayoutProvider
	{
		// Token: 0x0600599F RID: 22943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599F")]
		[Address(RVA = "0x8ACCB8", Offset = "0x8ACCB8", VA = "0x8ACCB8")]
		public LegacyDungeonLayoutProvider(DungeonLayoutProviderSettings settings)
		{
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x8ACCC0", Offset = "0x8ACCC0", VA = "0x8ACCC0", Slot = "4")]
		public override void ProvideLayout(DungeonData data, GenerationProgress progress, UnifiedRandom genRand, ref int roomDelay)
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0x8ACDF0", Offset = "0x8ACDF0", VA = "0x8ACDF0")]
		public void LegacyDungeonLayout(DungeonData data, GenerationProgress progress, UnifiedRandom genRand, ushort tileType, ushort crackedTileType, ushort wallType, int steps, int maxSteps, ref int roomDelay)
		{
		}
	}
}
