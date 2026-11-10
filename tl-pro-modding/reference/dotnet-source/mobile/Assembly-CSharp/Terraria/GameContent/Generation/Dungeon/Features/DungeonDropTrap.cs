using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	public class DungeonDropTrap : DungeonFeature
	{
		// Token: 0x060059D0 RID: 22992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x8B8E94", Offset = "0x8B8E94", VA = "0x8B8E94")]
		public DungeonDropTrap(DungeonFeatureSettings settings, bool addToFeatures = true)
		{
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x0002A090 File Offset: 0x00028290
		[Token(Token = "0x60059D1")]
		[Address(RVA = "0x8B909C", Offset = "0x8B909C", VA = "0x8B909C", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x0002A0A8 File Offset: 0x000282A8
		[Token(Token = "0x60059D2")]
		[Address(RVA = "0x8BD9E4", Offset = "0x8BD9E4", VA = "0x8BD9E4", Slot = "5")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x0002A0C0 File Offset: 0x000282C0
		[Token(Token = "0x60059D3")]
		[Address(RVA = "0x8B90D0", Offset = "0x8B90D0", VA = "0x8B90D0")]
		public bool DropTrap(DungeonData data, int i, int j)
		{
			return default(bool);
		}
	}
}
