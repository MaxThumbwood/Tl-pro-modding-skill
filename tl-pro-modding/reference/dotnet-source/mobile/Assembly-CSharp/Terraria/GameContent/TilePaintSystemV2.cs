using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x02000985 RID: 2437
	[Token(Token = "0x2000985")]
	public class TilePaintSystemV2
	{
		// Token: 0x06005064 RID: 20580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005064")]
		[Address(RVA = "0x76B554", Offset = "0x76B554", VA = "0x76B554")]
		public EffectPass GetTileEffect(int tileType, int tileStyle, int paintColor, bool nature = false)
		{
			return null;
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005065")]
		[Address(RVA = "0x76B678", Offset = "0x76B678", VA = "0x76B678")]
		public EffectPass GetWallEffect(int wallType, int paintColor)
		{
			return null;
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005066")]
		[Address(RVA = "0x76B894", Offset = "0x76B894", VA = "0x76B894")]
		public EffectPass GetTreeBranchEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			return null;
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005067")]
		[Address(RVA = "0x76BA40", Offset = "0x76BA40", VA = "0x76BA40")]
		public EffectPass GetTreeTopEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			return null;
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005068")]
		[Address(RVA = "0x76BBEC", Offset = "0x76BBEC", VA = "0x76BBEC")]
		private Effect InitShader(TreePaintingSettings settings)
		{
			return null;
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005069")]
		[Address(RVA = "0x76C2E4", Offset = "0x76C2E4", VA = "0x76C2E4")]
		public void CreateTileShaders()
		{
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506A")]
		[Address(RVA = "0x76B6B4", Offset = "0x76B6B4", VA = "0x76B6B4")]
		public EffectPass GetRealShader(int paintColor, TreePaintingSettings settings, bool nature = false)
		{
			return null;
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506B")]
		[Address(RVA = "0x76B5AC", Offset = "0x76B5AC", VA = "0x76B5AC")]
		public EffectPass GetShader(int paintColor, TreePaintingSettings settings, bool nature = false)
		{
			return null;
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506C")]
		[Address(RVA = "0x76C590", Offset = "0x76C590", VA = "0x76C590")]
		public TilePaintSystemV2()
		{
		}

		// Token: 0x0400946D RID: 37997
		[Token(Token = "0x400946D")]
		[FieldOffset(Offset = "0x8")]
		private Effect TileShader;

		// Token: 0x0400946E RID: 37998
		[Token(Token = "0x400946E")]
		[FieldOffset(Offset = "0xC")]
		private Effect TileNatureShader;

		// Token: 0x0400946F RID: 37999
		[Token(Token = "0x400946F")]
		[FieldOffset(Offset = "0x10")]
		public TreePaintSystemData PaintSystemData;

		// Token: 0x04009470 RID: 38000
		[Token(Token = "0x4009470")]
		[FieldOffset(Offset = "0x14")]
		private TileShader[] specialShaders;

		// Token: 0x04009471 RID: 38001
		[Token(Token = "0x4009471")]
		[FieldOffset(Offset = "0x18")]
		private TileShader[] natureSpecialShaders;

		// Token: 0x04009472 RID: 38002
		[Token(Token = "0x4009472")]
		[FieldOffset(Offset = "0x1C")]
		public EffectPass[] TileShaders;

		// Token: 0x04009473 RID: 38003
		[Token(Token = "0x4009473")]
		[FieldOffset(Offset = "0x20")]
		private EffectPass[] TileNatureShaders;

		// Token: 0x02000986 RID: 2438
		[Token(Token = "0x2000986")]
		public struct TileVariationkey
		{
			// Token: 0x0600506D RID: 20589 RVA: 0x00025638 File Offset: 0x00023838
			[Token(Token = "0x600506D")]
			[Address(RVA = "0x76C680", Offset = "0x76C680", VA = "0x76C680")]
			public bool Equals(TilePaintSystemV2.TileVariationkey other)
			{
				return default(bool);
			}

			// Token: 0x0600506E RID: 20590 RVA: 0x00025650 File Offset: 0x00023850
			[Token(Token = "0x600506E")]
			[Address(RVA = "0x76C6B0", Offset = "0x76C6B0", VA = "0x76C6B0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x00025668 File Offset: 0x00023868
			[Token(Token = "0x600506F")]
			[Address(RVA = "0x76C758", Offset = "0x76C758", VA = "0x76C758", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06005070 RID: 20592 RVA: 0x00025680 File Offset: 0x00023880
			[Token(Token = "0x6005070")]
			[Address(RVA = "0x76C778", Offset = "0x76C778", VA = "0x76C778")]
			public static bool operator ==(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				return default(bool);
			}

			// Token: 0x06005071 RID: 20593 RVA: 0x00025698 File Offset: 0x00023898
			[Token(Token = "0x6005071")]
			[Address(RVA = "0x76C7A0", Offset = "0x76C7A0", VA = "0x76C7A0")]
			public static bool operator !=(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				return default(bool);
			}

			// Token: 0x04009474 RID: 38004
			[Token(Token = "0x4009474")]
			[FieldOffset(Offset = "0x0")]
			public int TileType;

			// Token: 0x04009475 RID: 38005
			[Token(Token = "0x4009475")]
			[FieldOffset(Offset = "0x4")]
			public int TileStyle;

			// Token: 0x04009476 RID: 38006
			[Token(Token = "0x4009476")]
			[FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}

		// Token: 0x02000987 RID: 2439
		[Token(Token = "0x2000987")]
		public struct WallVariationKey
		{
			// Token: 0x06005072 RID: 20594 RVA: 0x000256B0 File Offset: 0x000238B0
			[Token(Token = "0x6005072")]
			[Address(RVA = "0x76C7CC", Offset = "0x76C7CC", VA = "0x76C7CC")]
			public bool Equals(TilePaintSystemV2.WallVariationKey other)
			{
				return default(bool);
			}

			// Token: 0x06005073 RID: 20595 RVA: 0x000256C8 File Offset: 0x000238C8
			[Token(Token = "0x6005073")]
			[Address(RVA = "0x76C7F0", Offset = "0x76C7F0", VA = "0x76C7F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06005074 RID: 20596 RVA: 0x000256E0 File Offset: 0x000238E0
			[Token(Token = "0x6005074")]
			[Address(RVA = "0x76C888", Offset = "0x76C888", VA = "0x76C888", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06005075 RID: 20597 RVA: 0x000256F8 File Offset: 0x000238F8
			[Token(Token = "0x6005075")]
			[Address(RVA = "0x76C8A0", Offset = "0x76C8A0", VA = "0x76C8A0")]
			public static bool operator ==(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				return default(bool);
			}

			// Token: 0x06005076 RID: 20598 RVA: 0x00025710 File Offset: 0x00023910
			[Token(Token = "0x6005076")]
			[Address(RVA = "0x76C8B8", Offset = "0x76C8B8", VA = "0x76C8B8")]
			public static bool operator !=(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				return default(bool);
			}

			// Token: 0x04009477 RID: 38007
			[Token(Token = "0x4009477")]
			[FieldOffset(Offset = "0x0")]
			public int WallType;

			// Token: 0x04009478 RID: 38008
			[Token(Token = "0x4009478")]
			[FieldOffset(Offset = "0x4")]
			public int PaintColor;
		}

		// Token: 0x02000988 RID: 2440
		[Token(Token = "0x2000988")]
		public struct TreeFoliageVariantKey
		{
			// Token: 0x06005077 RID: 20599 RVA: 0x00025728 File Offset: 0x00023928
			[Token(Token = "0x6005077")]
			[Address(RVA = "0x76C8CC", Offset = "0x76C8CC", VA = "0x76C8CC")]
			public bool Equals(TilePaintSystemV2.TreeFoliageVariantKey other)
			{
				return default(bool);
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x00025740 File Offset: 0x00023940
			[Token(Token = "0x6005078")]
			[Address(RVA = "0x76C8FC", Offset = "0x76C8FC", VA = "0x76C8FC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x00025758 File Offset: 0x00023958
			[Token(Token = "0x6005079")]
			[Address(RVA = "0x76C9A4", Offset = "0x76C9A4", VA = "0x76C9A4", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600507A RID: 20602 RVA: 0x00025770 File Offset: 0x00023970
			[Token(Token = "0x600507A")]
			[Address(RVA = "0x76C9C4", Offset = "0x76C9C4", VA = "0x76C9C4")]
			public static bool operator ==(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				return default(bool);
			}

			// Token: 0x0600507B RID: 20603 RVA: 0x00025788 File Offset: 0x00023988
			[Token(Token = "0x600507B")]
			[Address(RVA = "0x76C9EC", Offset = "0x76C9EC", VA = "0x76C9EC")]
			public static bool operator !=(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				return default(bool);
			}

			// Token: 0x04009479 RID: 38009
			[Token(Token = "0x4009479")]
			[FieldOffset(Offset = "0x0")]
			public int TextureIndex;

			// Token: 0x0400947A RID: 38010
			[Token(Token = "0x400947A")]
			[FieldOffset(Offset = "0x4")]
			public int TextureStyle;

			// Token: 0x0400947B RID: 38011
			[Token(Token = "0x400947B")]
			[FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}
	}
}
