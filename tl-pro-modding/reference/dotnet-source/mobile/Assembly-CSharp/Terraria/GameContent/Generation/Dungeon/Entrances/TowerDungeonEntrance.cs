using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B8C RID: 2956
	[Token(Token = "0x2000B8C")]
	public class TowerDungeonEntrance : DungeonEntrance
	{
		// Token: 0x06005A4B RID: 23115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x8FED70", Offset = "0x8FED70", VA = "0x8FED70")]
		public TowerDungeonEntrance(DungeonEntranceSettings settings)
		{
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0x8FEDF4", Offset = "0x8FEDF4", VA = "0x8FEDF4", Slot = "4")]
		public override void CalculateEntrance(DungeonData data, int x, int y)
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x0002A528 File Offset: 0x00028728
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0x902634", Offset = "0x902634", VA = "0x902634", Slot = "5")]
		public override bool GenerateEntrance(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x0002A540 File Offset: 0x00028740
		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0x902668", Offset = "0x902668", VA = "0x902668", Slot = "6")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0x8FEE28", Offset = "0x8FEE28", VA = "0x8FEE28")]
		public void TowerEntrance(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A50")]
		[Address(RVA = "0x902EE4", Offset = "0x902EE4", VA = "0x902EE4")]
		public void TowerEntrance_Door(DungeonData data, int i, int entranceFloor, int outerSize, int innerSize, bool leftDungeonDoor, bool buried)
		{
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A51")]
		[Address(RVA = "0x902BCC", Offset = "0x902BCC", VA = "0x902BCC")]
		public void TowerEntrance_LineOfFence(int leftX, int rightX, int y)
		{
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x9027E0", Offset = "0x9027E0", VA = "0x9027E0")]
		public void TowerEntrance_OuterPillar(DungeonData data, int pillarX, int pillarY, ushort tileType)
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x9032B0", Offset = "0x9032B0", VA = "0x9032B0")]
		public void TowerEntrance_TreeOnPillar(UnifiedRandom genRand, int pillarX, int pillarY)
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x902CD4", Offset = "0x902CD4", VA = "0x902CD4")]
		public void TowerEntrance_AddPlatform(DungeonData data, Point position)
		{
		}
	}
}
