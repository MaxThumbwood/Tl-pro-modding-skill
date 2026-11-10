using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	public static class DungeonGenerationStyles
	{
		// Token: 0x0600589A RID: 22682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589A")]
		[Address(RVA = "0x8756CC", Offset = "0x8756CC", VA = "0x8756CC")]
		public static DungeonGenerationStyleData GetCurrentDungeonStyle()
		{
			return null;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589B")]
		[Address(RVA = "0x875A64", Offset = "0x875A64", VA = "0x875A64")]
		public static DungeonGenerationStyleData GetStyleForTile(List<DungeonGenerationStyleData> styles, int tileType)
		{
			return null;
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589C")]
		[Address(RVA = "0x875DA0", Offset = "0x875DA0", VA = "0x875DA0")]
		public static DungeonGenerationStyleData GetStyleForWall(List<DungeonGenerationStyleData> styles, int wallType)
		{
			return null;
		}

		// Token: 0x04009A61 RID: 39521
		[Token(Token = "0x4009A61")]
		[FieldOffset(Offset = "0x0")]
		public static DungeonGenerationStyleData Shimmer;

		// Token: 0x04009A62 RID: 39522
		[Token(Token = "0x4009A62")]
		[FieldOffset(Offset = "0x4")]
		public static DungeonGenerationStyleData Spider;

		// Token: 0x04009A63 RID: 39523
		[Token(Token = "0x4009A63")]
		[FieldOffset(Offset = "0x8")]
		public static DungeonGenerationStyleData LivingWood;

		// Token: 0x04009A64 RID: 39524
		[Token(Token = "0x4009A64")]
		[FieldOffset(Offset = "0xC")]
		public static DungeonGenerationStyleData Cavern;

		// Token: 0x04009A65 RID: 39525
		[Token(Token = "0x4009A65")]
		[FieldOffset(Offset = "0x10")]
		public static DungeonGenerationStyleData Snow;

		// Token: 0x04009A66 RID: 39526
		[Token(Token = "0x4009A66")]
		[FieldOffset(Offset = "0x14")]
		public static DungeonGenerationStyleData Desert;

		// Token: 0x04009A67 RID: 39527
		[Token(Token = "0x4009A67")]
		[FieldOffset(Offset = "0x18")]
		public static DungeonGenerationStyleData Corruption;

		// Token: 0x04009A68 RID: 39528
		[Token(Token = "0x4009A68")]
		[FieldOffset(Offset = "0x1C")]
		public static DungeonGenerationStyleData Crimson;

		// Token: 0x04009A69 RID: 39529
		[Token(Token = "0x4009A69")]
		[FieldOffset(Offset = "0x20")]
		public static DungeonGenerationStyleData Crystal;

		// Token: 0x04009A6A RID: 39530
		[Token(Token = "0x4009A6A")]
		[FieldOffset(Offset = "0x24")]
		public static DungeonGenerationStyleData Hallow;

		// Token: 0x04009A6B RID: 39531
		[Token(Token = "0x4009A6B")]
		[FieldOffset(Offset = "0x28")]
		public static DungeonGenerationStyleData GlowingMushroom;

		// Token: 0x04009A6C RID: 39532
		[Token(Token = "0x4009A6C")]
		[FieldOffset(Offset = "0x2C")]
		public static DungeonGenerationStyleData Beehive;

		// Token: 0x04009A6D RID: 39533
		[Token(Token = "0x4009A6D")]
		[FieldOffset(Offset = "0x30")]
		public static DungeonGenerationStyleData LivingMahogany;

		// Token: 0x04009A6E RID: 39534
		[Token(Token = "0x4009A6E")]
		[FieldOffset(Offset = "0x34")]
		public static DungeonGenerationStyleData Jungle;

		// Token: 0x04009A6F RID: 39535
		[Token(Token = "0x4009A6F")]
		[FieldOffset(Offset = "0x38")]
		public static DungeonGenerationStyleData Temple;

		// Token: 0x02000B26 RID: 2854
		[Token(Token = "0x2000B26")]
		private class ShimmerStyleData : DungeonGenerationStyleData
		{
			// Token: 0x0600589E RID: 22686 RVA: 0x000294C0 File Offset: 0x000276C0
			[Token(Token = "0x600589E")]
			[Address(RVA = "0x87B564", Offset = "0x87B564", VA = "0x87B564", Slot = "4")]
			public override bool CanGenerateFeatureAt(DungeonData data, DungeonRoom room, IDungeonFeature feature, int x, int y)
			{
				return default(bool);
			}

			// Token: 0x0600589F RID: 22687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600589F")]
			[Address(RVA = "0x87B514", Offset = "0x87B514", VA = "0x87B514")]
			public ShimmerStyleData()
			{
			}
		}

		// Token: 0x02000B27 RID: 2855
		[Token(Token = "0x2000B27")]
		private class LivingWoodStyleData : DungeonGenerationStyleData
		{
			// Token: 0x060058A0 RID: 22688 RVA: 0x000294D8 File Offset: 0x000276D8
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0x87B62C", Offset = "0x87B62C", VA = "0x87B62C", Slot = "4")]
			public override bool CanGenerateFeatureAt(DungeonData data, DungeonRoom room, IDungeonFeature feature, int x, int y)
			{
				return default(bool);
			}

			// Token: 0x060058A1 RID: 22689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0x87B6F4", Offset = "0x87B6F4", VA = "0x87B6F4", Slot = "5")]
			public override void GetBookshelfMinMaxSizes(int defaultMin, int defaultMax, out int min, out int max)
			{
			}

			// Token: 0x060058A2 RID: 22690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0x87B528", Offset = "0x87B528", VA = "0x87B528")]
			public LivingWoodStyleData()
			{
			}
		}

		// Token: 0x02000B28 RID: 2856
		[Token(Token = "0x2000B28")]
		private class BeehiveStyleData : DungeonGenerationStyleData
		{
			// Token: 0x060058A3 RID: 22691 RVA: 0x000294F0 File Offset: 0x000276F0
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0x87B70C", Offset = "0x87B70C", VA = "0x87B70C", Slot = "4")]
			public override bool CanGenerateFeatureAt(DungeonData data, DungeonRoom room, IDungeonFeature feature, int x, int y)
			{
				return default(bool);
			}

			// Token: 0x060058A4 RID: 22692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A4")]
			[Address(RVA = "0x87B53C", Offset = "0x87B53C", VA = "0x87B53C")]
			public BeehiveStyleData()
			{
			}
		}

		// Token: 0x02000B29 RID: 2857
		[Token(Token = "0x2000B29")]
		private class TempleStyleData : DungeonGenerationStyleData
		{
			// Token: 0x060058A5 RID: 22693 RVA: 0x00029508 File Offset: 0x00027708
			[Token(Token = "0x60058A5")]
			[Address(RVA = "0x87B854", Offset = "0x87B854", VA = "0x87B854", Slot = "4")]
			public override bool CanGenerateFeatureAt(DungeonData data, DungeonRoom room, IDungeonFeature feature, int x, int y)
			{
				return default(bool);
			}

			// Token: 0x060058A6 RID: 22694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A6")]
			[Address(RVA = "0x87B550", Offset = "0x87B550", VA = "0x87B550")]
			public TempleStyleData()
			{
			}
		}
	}
}
