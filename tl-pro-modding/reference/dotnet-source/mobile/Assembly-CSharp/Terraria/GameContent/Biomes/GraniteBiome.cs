using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	public class GraniteBiome : MicroBiome
	{
		// Token: 0x06005ABC RID: 23228 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x92F214", Offset = "0x92F214", VA = "0x92F214")]
		public static bool CanPlace(Point origin, StructureMap structures)
		{
			return default(bool);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x92F3D8", Offset = "0x92F3D8", VA = "0x92F3D8", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x92F6C4", Offset = "0x92F6C4", VA = "0x92F6C4")]
		private void BuildMagmaMap(Point tileOrigin)
		{
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x92F8D0", Offset = "0x92F8D0", VA = "0x92F8D0")]
		private void SimulatePressure(out Rectangle effectedMapArea)
		{
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x0002A900 File Offset: 0x00028B00
		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0x9318B4", Offset = "0x9318B4", VA = "0x9318B4")]
		private bool ShouldUseLava(Point tileOrigin)
		{
			return default(bool);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x9300B0", Offset = "0x9300B0", VA = "0x9300B0")]
		private void PlaceGranite(Point tileOrigin, Rectangle magmaMapArea)
		{
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x930870", Offset = "0x930870", VA = "0x930870")]
		private void CleanupTiles(Point tileOrigin, Rectangle magmaMapArea)
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x931040", Offset = "0x931040", VA = "0x931040")]
		private void PlaceDecorations(Point tileOrigin, Rectangle magmaMapArea)
		{
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x931C84", Offset = "0x931C84", VA = "0x931C84")]
		public GraniteBiome()
		{
		}

		// Token: 0x04009BE1 RID: 39905
		[Token(Token = "0x4009BE1")]
		private const int MAX_MAGMA_ITERATIONS = 300;

		// Token: 0x04009BE2 RID: 39906
		[Token(Token = "0x4009BE2")]
		[FieldOffset(Offset = "0x8")]
		private GraniteBiome.Magma[,] _sourceMagmaMap;

		// Token: 0x04009BE3 RID: 39907
		[Token(Token = "0x4009BE3")]
		[FieldOffset(Offset = "0xC")]
		private GraniteBiome.Magma[,] _targetMagmaMap;

		// Token: 0x04009BE4 RID: 39908
		[Token(Token = "0x4009BE4")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2D[] _normalisedVectors;

		// Token: 0x02000BA0 RID: 2976
		[Token(Token = "0x2000BA0")]
		private struct Magma
		{
			// Token: 0x06005AC6 RID: 23238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AC6")]
			[Address(RVA = "0x93214C", Offset = "0x93214C", VA = "0x93214C")]
			private Magma(double pressure, double resistance, bool active)
			{
			}

			// Token: 0x06005AC7 RID: 23239 RVA: 0x0002A918 File Offset: 0x00028B18
			[Token(Token = "0x6005AC7")]
			[Address(RVA = "0x931850", Offset = "0x931850", VA = "0x931850")]
			public GraniteBiome.Magma ToFlow()
			{
				return default(GraniteBiome.Magma);
			}

			// Token: 0x06005AC8 RID: 23240 RVA: 0x0002A930 File Offset: 0x00028B30
			[Token(Token = "0x6005AC8")]
			[Address(RVA = "0x93187C", Offset = "0x93187C", VA = "0x93187C")]
			public static GraniteBiome.Magma CreateFlow(double pressure, double resistance = 0.0)
			{
				return default(GraniteBiome.Magma);
			}

			// Token: 0x06005AC9 RID: 23241 RVA: 0x0002A948 File Offset: 0x00028B48
			[Token(Token = "0x6005AC9")]
			[Address(RVA = "0x931824", Offset = "0x931824", VA = "0x931824")]
			public static GraniteBiome.Magma CreateEmpty(double resistance = 0.0)
			{
				return default(GraniteBiome.Magma);
			}

			// Token: 0x04009BE5 RID: 39909
			[Token(Token = "0x4009BE5")]
			[FieldOffset(Offset = "0x0")]
			public readonly double Pressure;

			// Token: 0x04009BE6 RID: 39910
			[Token(Token = "0x4009BE6")]
			[FieldOffset(Offset = "0x8")]
			public readonly double Resistance;

			// Token: 0x04009BE7 RID: 39911
			[Token(Token = "0x4009BE7")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool IsActive;
		}
	}
}
