using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	public class DungeonGlobalPaintings : GlobalDungeonFeature
	{
		// Token: 0x060059FE RID: 23038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x8D8D6C", Offset = "0x8D8D6C", VA = "0x8D8D6C")]
		public DungeonGlobalPaintings(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0002A210 File Offset: 0x00028410
		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x8D8E80", Offset = "0x8D8E80", VA = "0x8D8E80", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A00")]
		[Address(RVA = "0x8D8EA8", Offset = "0x8D8EA8", VA = "0x8D8EA8")]
		public void Paintings(DungeonData data)
		{
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A01")]
		[Address(RVA = "0x8DD470", Offset = "0x8DD470", VA = "0x8DD470")]
		private static void Paintings_PlacePainting(int x, int y, PaintingEntry entry)
		{
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x0002A228 File Offset: 0x00028428
		[Token(Token = "0x6005A02")]
		[Address(RVA = "0x8DD21C", Offset = "0x8DD21C", VA = "0x8DD21C")]
		private static PaintingEntry Paintings_GetPaintingEntry(DungeonData data, int currentWall)
		{
			return default(PaintingEntry);
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x0002A240 File Offset: 0x00028440
		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x8DD79C", Offset = "0x8DD79C", VA = "0x8DD79C")]
		private static PaintingEntry Paintings_RandomDungeonPainting()
		{
			return default(PaintingEntry);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x0002A258 File Offset: 0x00028458
		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x8DD644", Offset = "0x8DD644", VA = "0x8DD644")]
		private static PaintingEntry Paintings_RandomBonePainting()
		{
			return default(PaintingEntry);
		}

		// Token: 0x04009B5E RID: 39774
		[Token(Token = "0x4009B5E")]
		[FieldOffset(Offset = "0x0")]
		public static int lihzahrdPaintingsPlaced;

		// Token: 0x04009B5F RID: 39775
		[Token(Token = "0x4009B5F")]
		[FieldOffset(Offset = "0x4")]
		public static int lihzahrdPaintingsMax;
	}
}
