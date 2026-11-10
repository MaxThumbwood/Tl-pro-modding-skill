using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x02000977 RID: 2423
	[Token(Token = "0x2000977")]
	public class FlexibleTileWand
	{
		// Token: 0x0600502D RID: 20525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x762048", Offset = "0x762048", VA = "0x762048")]
		public static FlexibleTileWand ExposedGem(int itemId, int style)
		{
			return null;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502E")]
		[Address(RVA = "0x76222C", Offset = "0x76222C", VA = "0x76222C")]
		public FlexibleTileWand WithoutAmmoIcon()
		{
			return null;
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x762238", Offset = "0x762238", VA = "0x762238")]
		public FlexibleTileWand WithoutAmmoConsumption()
		{
			return null;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005030")]
		[Address(RVA = "0x762244", Offset = "0x762244", VA = "0x762244")]
		public FlexibleTileWand WithConsumingFavorites()
		{
			return null;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005031")]
		[Address(RVA = "0x762250", Offset = "0x762250", VA = "0x762250")]
		public void AddVariation(int itemType, int tileIdToPlace, int tileStyleToPlace)
		{
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005032")]
		[Address(RVA = "0x762530", Offset = "0x762530", VA = "0x762530")]
		public void AddVariations(int itemType, int tileIdToPlace, int[] stylesToPlace)
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005033")]
		[Address(RVA = "0x762594", Offset = "0x762594", VA = "0x762594")]
		public void AddVariationsWithOffset(int itemType, int tileIdToPlace, int offset, int[] stylesToPlace)
		{
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005034")]
		[Address(RVA = "0x762600", Offset = "0x762600", VA = "0x762600")]
		public void AddVariations_ByRow(int itemType, int tileIdToPlace, int variationsPerRow, int[] rows)
		{
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x000255F0 File Offset: 0x000237F0
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x76268C", Offset = "0x76268C", VA = "0x76268C")]
		public bool TryGetPlacementOption(Player player, int randomSeed, int selectCycleOffset, out FlexibleTileWand.PlacementOption option, out Item itemToConsume)
		{
			return default(bool);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x762878", Offset = "0x762878", VA = "0x762878")]
		private static void EnsureAllMaterialOptions(FlexibleTileWand wand)
		{
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x762F64", Offset = "0x762F64", VA = "0x762F64")]
		public static FlexibleTileWand CreateRubblePlacerLarge()
		{
			return null;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x7640F8", Offset = "0x7640F8", VA = "0x7640F8")]
		public static FlexibleTileWand CreateRubblePlacerMedium()
		{
			return null;
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x764EC0", Offset = "0x764EC0", VA = "0x764EC0")]
		public static FlexibleTileWand CreateRubblePlacerSmall()
		{
			return null;
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x76215C", Offset = "0x76215C", VA = "0x76215C")]
		public static FlexibleTileWand CreateSingleTileWand(int itemIdToConsume, int TileTypeToplace, int[] stylesToPlace)
		{
			return null;
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x765934", Offset = "0x765934", VA = "0x765934")]
		public static FlexibleTileWand CreateMiteyTitey()
		{
			return null;
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x766D28", Offset = "0x766D28", VA = "0x766D28")]
		public static FlexibleTileWand CreatePortableKiln()
		{
			return null;
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x76400C", Offset = "0x76400C", VA = "0x76400C")]
		public FlexibleTileWand()
		{
		}

		// Token: 0x040093F9 RID: 37881
		[Token(Token = "0x40093F9")]
		[FieldOffset(Offset = "0x0")]
		public static FlexibleTileWand RubblePlacementSmall;

		// Token: 0x040093FA RID: 37882
		[Token(Token = "0x40093FA")]
		[FieldOffset(Offset = "0x4")]
		public static FlexibleTileWand RubblePlacementMedium;

		// Token: 0x040093FB RID: 37883
		[Token(Token = "0x40093FB")]
		[FieldOffset(Offset = "0x8")]
		public static FlexibleTileWand RubblePlacementLarge;

		// Token: 0x040093FC RID: 37884
		[Token(Token = "0x40093FC")]
		[FieldOffset(Offset = "0xC")]
		public static FlexibleTileWand MiteyTitey;

		// Token: 0x040093FD RID: 37885
		[Token(Token = "0x40093FD")]
		[FieldOffset(Offset = "0x10")]
		public static FlexibleTileWand SandCastleBucket;

		// Token: 0x040093FE RID: 37886
		[Token(Token = "0x40093FE")]
		[FieldOffset(Offset = "0x14")]
		public static FlexibleTileWand GardenGnome;

		// Token: 0x040093FF RID: 37887
		[Token(Token = "0x40093FF")]
		[FieldOffset(Offset = "0x18")]
		public static FlexibleTileWand Coral;

		// Token: 0x04009400 RID: 37888
		[Token(Token = "0x4009400")]
		[FieldOffset(Offset = "0x1C")]
		public static FlexibleTileWand Seashell;

		// Token: 0x04009401 RID: 37889
		[Token(Token = "0x4009401")]
		[FieldOffset(Offset = "0x20")]
		public static FlexibleTileWand Starfish;

		// Token: 0x04009402 RID: 37890
		[Token(Token = "0x4009402")]
		[FieldOffset(Offset = "0x24")]
		public static FlexibleTileWand LightningWhelkShell;

		// Token: 0x04009403 RID: 37891
		[Token(Token = "0x4009403")]
		[FieldOffset(Offset = "0x28")]
		public static FlexibleTileWand TulipShell;

		// Token: 0x04009404 RID: 37892
		[Token(Token = "0x4009404")]
		[FieldOffset(Offset = "0x2C")]
		public static FlexibleTileWand JunoniaShell;

		// Token: 0x04009405 RID: 37893
		[Token(Token = "0x4009405")]
		[FieldOffset(Offset = "0x30")]
		public static FlexibleTileWand JackoLantern;

		// Token: 0x04009406 RID: 37894
		[Token(Token = "0x4009406")]
		[FieldOffset(Offset = "0x34")]
		public static FlexibleTileWand Catacomb;

		// Token: 0x04009407 RID: 37895
		[Token(Token = "0x4009407")]
		[FieldOffset(Offset = "0x38")]
		public static FlexibleTileWand Present;

		// Token: 0x04009408 RID: 37896
		[Token(Token = "0x4009408")]
		[FieldOffset(Offset = "0x3C")]
		public static FlexibleTileWand PartyPresent;

		// Token: 0x04009409 RID: 37897
		[Token(Token = "0x4009409")]
		[FieldOffset(Offset = "0x40")]
		public static FlexibleTileWand Book;

		// Token: 0x0400940A RID: 37898
		[Token(Token = "0x400940A")]
		[FieldOffset(Offset = "0x44")]
		public static FlexibleTileWand LawnFlamingo;

		// Token: 0x0400940B RID: 37899
		[Token(Token = "0x400940B")]
		[FieldOffset(Offset = "0x48")]
		public static FlexibleTileWand PortableKiln;

		// Token: 0x0400940C RID: 37900
		[Token(Token = "0x400940C")]
		[FieldOffset(Offset = "0x4C")]
		public static FlexibleTileWand DeadCellsDisplayJar;

		// Token: 0x0400940D RID: 37901
		[Token(Token = "0x400940D")]
		[FieldOffset(Offset = "0x50")]
		public static FlexibleTileWand Amethyst;

		// Token: 0x0400940E RID: 37902
		[Token(Token = "0x400940E")]
		[FieldOffset(Offset = "0x54")]
		public static FlexibleTileWand Topaz;

		// Token: 0x0400940F RID: 37903
		[Token(Token = "0x400940F")]
		[FieldOffset(Offset = "0x58")]
		public static FlexibleTileWand Sapphire;

		// Token: 0x04009410 RID: 37904
		[Token(Token = "0x4009410")]
		[FieldOffset(Offset = "0x5C")]
		public static FlexibleTileWand Emerald;

		// Token: 0x04009411 RID: 37905
		[Token(Token = "0x4009411")]
		[FieldOffset(Offset = "0x60")]
		public static FlexibleTileWand Ruby;

		// Token: 0x04009412 RID: 37906
		[Token(Token = "0x4009412")]
		[FieldOffset(Offset = "0x64")]
		public static FlexibleTileWand Diamond;

		// Token: 0x04009413 RID: 37907
		[Token(Token = "0x4009413")]
		[FieldOffset(Offset = "0x68")]
		public static FlexibleTileWand Amber;

		// Token: 0x04009414 RID: 37908
		[Token(Token = "0x4009414")]
		[FieldOffset(Offset = "0x6C")]
		public static FlexibleTileWand Explosives;

		// Token: 0x04009415 RID: 37909
		[Token(Token = "0x4009415")]
		[FieldOffset(Offset = "0x70")]
		public static FlexibleTileWand CrystalShard;

		// Token: 0x04009416 RID: 37910
		[Token(Token = "0x4009416")]
		[FieldOffset(Offset = "0x74")]
		public static FlexibleTileWand GiantTiki;

		// Token: 0x04009417 RID: 37911
		[Token(Token = "0x4009417")]
		[FieldOffset(Offset = "0x8")]
		private UnifiedRandom _random;

		// Token: 0x04009418 RID: 37912
		[Token(Token = "0x4009418")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<int, FlexibleTileWand.OptionBucket> _options;

		// Token: 0x04009419 RID: 37913
		[Token(Token = "0x4009419")]
		[FieldOffset(Offset = "0x78")]
		private static int maxVariations;

		// Token: 0x0400941A RID: 37914
		[Token(Token = "0x400941A")]
		[FieldOffset(Offset = "0x10")]
		public bool ConsumesAmmoItem;

		// Token: 0x0400941B RID: 37915
		[Token(Token = "0x400941B")]
		[FieldOffset(Offset = "0x11")]
		public bool ShowsHoverAmmoIcon;

		// Token: 0x0400941C RID: 37916
		[Token(Token = "0x400941C")]
		[FieldOffset(Offset = "0x12")]
		public bool CanConsumeFavorites;

		// Token: 0x02000978 RID: 2424
		[Token(Token = "0x2000978")]
		public class OptionBucket
		{
			// Token: 0x0600503F RID: 20543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600503F")]
			[Address(RVA = "0x768150", Offset = "0x768150", VA = "0x768150")]
			public OptionBucket(int itemTypeToConsume)
			{
			}

			// Token: 0x06005040 RID: 20544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005040")]
			[Address(RVA = "0x7681F0", Offset = "0x7681F0", VA = "0x7681F0")]
			public FlexibleTileWand.PlacementOption GetRandomOption(UnifiedRandom random)
			{
				return null;
			}

			// Token: 0x06005041 RID: 20545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005041")]
			[Address(RVA = "0x76828C", Offset = "0x76828C", VA = "0x76828C")]
			public FlexibleTileWand.PlacementOption GetOptionWithCycling(int cycleOffset)
			{
				return null;
			}

			// Token: 0x0400941D RID: 37917
			[Token(Token = "0x400941D")]
			[FieldOffset(Offset = "0x8")]
			public int ItemTypeToConsume;

			// Token: 0x0400941E RID: 37918
			[Token(Token = "0x400941E")]
			[FieldOffset(Offset = "0xC")]
			public List<FlexibleTileWand.PlacementOption> Options;
		}

		// Token: 0x02000979 RID: 2425
		[Token(Token = "0x2000979")]
		public class PlacementOption
		{
			// Token: 0x06005042 RID: 20546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005042")]
			[Address(RVA = "0x768360", Offset = "0x768360", VA = "0x768360")]
			public PlacementOption()
			{
			}

			// Token: 0x0400941F RID: 37919
			[Token(Token = "0x400941F")]
			[FieldOffset(Offset = "0x8")]
			public int TileIdToPlace;

			// Token: 0x04009420 RID: 37920
			[Token(Token = "0x4009420")]
			[FieldOffset(Offset = "0xC")]
			public int TileStyleToPlace;
		}
	}
}
