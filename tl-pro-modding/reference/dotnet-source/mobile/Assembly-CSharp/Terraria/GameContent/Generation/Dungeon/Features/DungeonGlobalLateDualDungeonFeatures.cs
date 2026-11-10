using System;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	public class DungeonGlobalLateDualDungeonFeatures : GlobalDungeonFeature
	{
		// Token: 0x060059F3 RID: 23027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x8D4660", Offset = "0x8D4660", VA = "0x8D4660")]
		public DungeonGlobalLateDualDungeonFeatures(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x0002A1C8 File Offset: 0x000283C8
		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x8D4774", Offset = "0x8D4774", VA = "0x8D4774", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x8D479C", Offset = "0x8D479C", VA = "0x8D479C")]
		public void LateDualDungeonFeatures(DungeonData data)
		{
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x8D54B8", Offset = "0x8D54B8", VA = "0x8D54B8")]
		private void LateDualDungeonFeatures_CleanOutEntrancesOfLiquids(BiomeDungeonRoom room)
		{
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x8D5A04", Offset = "0x8D5A04", VA = "0x8D5A04")]
		private void LateDualDungeonFeatures_CleanOutEntrancesOfLiquids_ActuallyClearArea(int x, int y)
		{
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x8D5910", Offset = "0x8D5910", VA = "0x8D5910")]
		private void LateDualDungeonFeatures_GrowGrass(DungeonRoom room)
		{
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x8D5BFC", Offset = "0x8D5BFC", VA = "0x8D5BFC")]
		private void LateDualDungeonFeatures_GrowGrass(DungeonRoom room, ushort dirtType, ushort grassType)
		{
		}
	}
}
