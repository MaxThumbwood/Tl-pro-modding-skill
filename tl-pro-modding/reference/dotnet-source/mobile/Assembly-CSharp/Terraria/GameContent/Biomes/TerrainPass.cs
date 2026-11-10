using System;
using Il2CppDummyDll;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	public class TerrainPass : GenPass
	{
		// Token: 0x06005AFA RID: 23290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0x9426A0", Offset = "0x9426A0", VA = "0x9426A0")]
		public TerrainPass()
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x942738", Offset = "0x942738", VA = "0x942738", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0x944190", Offset = "0x944190", VA = "0x944190")]
		private void FillColumn(int x, double worldSurface, double rockLayer)
		{
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x9445E0", Offset = "0x9445E0", VA = "0x9445E0")]
		private static void RetargetColumn(int x, double worldSurface)
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x0002AB88 File Offset: 0x00028D88
		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0x943AD4", Offset = "0x943AD4", VA = "0x943AD4")]
		private static double GenerateWorldSurfaceOffset(TerrainPass.TerrainFeatureType featureType)
		{
			return 0.0;
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x9443A4", Offset = "0x9443A4", VA = "0x9443A4")]
		private static void RetargetSurfaceHistory(TerrainPass.SurfaceHistory history, int targetX, double targetHeight)
		{
		}

		// Token: 0x04009BED RID: 39917
		[Token(Token = "0x4009BED")]
		[FieldOffset(Offset = "0x18")]
		private uint skyDefinition;

		// Token: 0x04009BEE RID: 39918
		[Token(Token = "0x4009BEE")]
		[FieldOffset(Offset = "0x1C")]
		private uint dirtDefinition;

		// Token: 0x04009BEF RID: 39919
		[Token(Token = "0x4009BEF")]
		[FieldOffset(Offset = "0x20")]
		private uint rockDefinition;

		// Token: 0x02000BAC RID: 2988
		[Token(Token = "0x2000BAC")]
		private enum TerrainFeatureType
		{
			// Token: 0x04009BF1 RID: 39921
			[Token(Token = "0x4009BF1")]
			Plateau,
			// Token: 0x04009BF2 RID: 39922
			[Token(Token = "0x4009BF2")]
			Hill,
			// Token: 0x04009BF3 RID: 39923
			[Token(Token = "0x4009BF3")]
			Dale,
			// Token: 0x04009BF4 RID: 39924
			[Token(Token = "0x4009BF4")]
			Mountain,
			// Token: 0x04009BF5 RID: 39925
			[Token(Token = "0x4009BF5")]
			Valley
		}

		// Token: 0x02000BAD RID: 2989
		[Token(Token = "0x2000BAD")]
		private class SurfaceHistory
		{
			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06005B00 RID: 23296 RVA: 0x0002ABA0 File Offset: 0x00028DA0
			// (set) Token: 0x06005B01 RID: 23297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A12")]
			public double Item
			{
				[Token(Token = "0x6005B00")]
				[Address(RVA = "0x970F00", Offset = "0x970F00", VA = "0x970F00")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6005B01")]
				[Address(RVA = "0x970F3C", Offset = "0x970F3C", VA = "0x970F3C")]
				set
				{
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06005B02 RID: 23298 RVA: 0x0002ABB8 File Offset: 0x00028DB8
			[Token(Token = "0x17000A13")]
			public int Length
			{
				[Token(Token = "0x6005B02")]
				[Address(RVA = "0x970F80", Offset = "0x970F80", VA = "0x970F80")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06005B03 RID: 23299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B03")]
			[Address(RVA = "0x970FA4", Offset = "0x970FA4", VA = "0x970FA4")]
			public SurfaceHistory(int size)
			{
			}

			// Token: 0x06005B04 RID: 23300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B04")]
			[Address(RVA = "0x97100C", Offset = "0x97100C", VA = "0x97100C")]
			public void Record(double height)
			{
			}

			// Token: 0x04009BF6 RID: 39926
			[Token(Token = "0x4009BF6")]
			[FieldOffset(Offset = "0x8")]
			private readonly double[] _heights;

			// Token: 0x04009BF7 RID: 39927
			[Token(Token = "0x4009BF7")]
			[FieldOffset(Offset = "0xC")]
			private int _index;
		}
	}
}
