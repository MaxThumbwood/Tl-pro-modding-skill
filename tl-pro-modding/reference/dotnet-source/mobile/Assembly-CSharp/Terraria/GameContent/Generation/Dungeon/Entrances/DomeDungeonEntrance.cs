using System;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	public class DomeDungeonEntrance : DungeonEntrance
	{
		// Token: 0x06005A37 RID: 23095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x8F33B0", Offset = "0x8F33B0", VA = "0x8F33B0")]
		public DomeDungeonEntrance(DungeonEntranceSettings settings)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x8F34B8", Offset = "0x8F34B8", VA = "0x8F34B8", Slot = "4")]
		public override void CalculateEntrance(DungeonData data, int x, int y)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x0002A4B0 File Offset: 0x000286B0
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0x8F7460", Offset = "0x8F7460", VA = "0x8F7460", Slot = "5")]
		public override bool GenerateEntrance(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x0002A4C8 File Offset: 0x000286C8
		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0x8F7494", Offset = "0x8F7494", VA = "0x8F7494", Slot = "6")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x8F34E8", Offset = "0x8F34E8", VA = "0x8F34E8")]
		public void DomeEntrance(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x8F768C", Offset = "0x8F768C", VA = "0x8F768C")]
		public void DomeEntrance_Door(DungeonData data, int i, int entranceFloor, int outerSize, int innerSize, bool leftDungeonDoor, bool buried)
		{
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x8F7A58", Offset = "0x8F7A58", VA = "0x8F7A58")]
		public void DomeEntrance_TreeOnPillar(UnifiedRandom genRand, int pillarX, int pillarY)
		{
		}
	}
}
