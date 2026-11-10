using System;
using Il2CppDummyDll;

namespace Terraria.Graphics.Capture
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	public class CaptureBiome
	{
		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x70ECAC", Offset = "0x70ECAC", VA = "0x70ECAC")]
		public CaptureBiome(int backgroundIndex, int waterStyle, CaptureBiome.TileColorStyle tileColorStyle = CaptureBiome.TileColorStyle.Normal)
		{
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x70ECD8", Offset = "0x70ECD8", VA = "0x70ECD8")]
		public static CaptureBiome GetCaptureBiome(int biomeChoice)
		{
			return null;
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x70F4F0", Offset = "0x70F4F0", VA = "0x70F4F0")]
		private static CaptureBiome GetBiomeByWater()
		{
			return null;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0x70F1EC", Offset = "0x70F1EC", VA = "0x70F1EC")]
		private static CaptureBiome GetBiomeByLocation()
		{
			return null;
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAD")]
		[Address(RVA = "0x70F008", Offset = "0x70F008", VA = "0x70F008")]
		private static CaptureBiome GetPurityForPlayer()
		{
			return null;
		}

		// Token: 0x0400919F RID: 37279
		[Token(Token = "0x400919F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CaptureBiome DefaultPurity;

		// Token: 0x040091A0 RID: 37280
		[Token(Token = "0x40091A0")]
		[FieldOffset(Offset = "0x4")]
		public static CaptureBiome[] BiomesByWaterStyle;

		// Token: 0x040091A1 RID: 37281
		[Token(Token = "0x40091A1")]
		[FieldOffset(Offset = "0x8")]
		public readonly int WaterStyle;

		// Token: 0x040091A2 RID: 37282
		[Token(Token = "0x40091A2")]
		[FieldOffset(Offset = "0xC")]
		public readonly int BackgroundIndex;

		// Token: 0x040091A3 RID: 37283
		[Token(Token = "0x40091A3")]
		[FieldOffset(Offset = "0x10")]
		public readonly CaptureBiome.TileColorStyle TileColor;

		// Token: 0x020008E3 RID: 2275
		[Token(Token = "0x20008E3")]
		public enum TileColorStyle
		{
			// Token: 0x040091A5 RID: 37285
			[Token(Token = "0x40091A5")]
			Normal,
			// Token: 0x040091A6 RID: 37286
			[Token(Token = "0x40091A6")]
			Jungle,
			// Token: 0x040091A7 RID: 37287
			[Token(Token = "0x40091A7")]
			Crimson,
			// Token: 0x040091A8 RID: 37288
			[Token(Token = "0x40091A8")]
			Corrupt,
			// Token: 0x040091A9 RID: 37289
			[Token(Token = "0x40091A9")]
			Mushroom
		}

		// Token: 0x020008E4 RID: 2276
		[Token(Token = "0x20008E4")]
		public class Sets
		{
			// Token: 0x06004CAF RID: 19631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CAF")]
			[Address(RVA = "0x70FAE4", Offset = "0x70FAE4", VA = "0x70FAE4")]
			public Sets()
			{
			}

			// Token: 0x020008E5 RID: 2277
			[Token(Token = "0x20008E5")]
			public class WaterStyles
			{
				// Token: 0x06004CB0 RID: 19632 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004CB0")]
				[Address(RVA = "0x70FAEC", Offset = "0x70FAEC", VA = "0x70FAEC")]
				public WaterStyles()
				{
				}

				// Token: 0x040091AA RID: 37290
				[Token(Token = "0x40091AA")]
				public const int BloodMoon = 9;
			}
		}

		// Token: 0x020008E6 RID: 2278
		[Token(Token = "0x20008E6")]
		public class Styles
		{
			// Token: 0x06004CB1 RID: 19633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB1")]
			[Address(RVA = "0x70FAF4", Offset = "0x70FAF4", VA = "0x70FAF4")]
			public Styles()
			{
			}

			// Token: 0x040091AB RID: 37291
			[Token(Token = "0x40091AB")]
			[FieldOffset(Offset = "0x0")]
			public static CaptureBiome Purity;

			// Token: 0x040091AC RID: 37292
			[Token(Token = "0x40091AC")]
			[FieldOffset(Offset = "0x4")]
			public static CaptureBiome Purity2;

			// Token: 0x040091AD RID: 37293
			[Token(Token = "0x40091AD")]
			[FieldOffset(Offset = "0x8")]
			public static CaptureBiome Purity3;

			// Token: 0x040091AE RID: 37294
			[Token(Token = "0x40091AE")]
			[FieldOffset(Offset = "0xC")]
			public static CaptureBiome Purity4;

			// Token: 0x040091AF RID: 37295
			[Token(Token = "0x40091AF")]
			[FieldOffset(Offset = "0x10")]
			public static CaptureBiome Corruption;

			// Token: 0x040091B0 RID: 37296
			[Token(Token = "0x40091B0")]
			[FieldOffset(Offset = "0x14")]
			public static CaptureBiome Jungle;

			// Token: 0x040091B1 RID: 37297
			[Token(Token = "0x40091B1")]
			[FieldOffset(Offset = "0x18")]
			public static CaptureBiome Hallow;

			// Token: 0x040091B2 RID: 37298
			[Token(Token = "0x40091B2")]
			[FieldOffset(Offset = "0x1C")]
			public static CaptureBiome Snow;

			// Token: 0x040091B3 RID: 37299
			[Token(Token = "0x40091B3")]
			[FieldOffset(Offset = "0x20")]
			public static CaptureBiome Desert;

			// Token: 0x040091B4 RID: 37300
			[Token(Token = "0x40091B4")]
			[FieldOffset(Offset = "0x24")]
			public static CaptureBiome DirtLayer;

			// Token: 0x040091B5 RID: 37301
			[Token(Token = "0x40091B5")]
			[FieldOffset(Offset = "0x28")]
			public static CaptureBiome RockLayer;

			// Token: 0x040091B6 RID: 37302
			[Token(Token = "0x40091B6")]
			[FieldOffset(Offset = "0x2C")]
			public static CaptureBiome BloodMoon;

			// Token: 0x040091B7 RID: 37303
			[Token(Token = "0x40091B7")]
			[FieldOffset(Offset = "0x30")]
			public static CaptureBiome Crimson;

			// Token: 0x040091B8 RID: 37304
			[Token(Token = "0x40091B8")]
			[FieldOffset(Offset = "0x34")]
			public static CaptureBiome UndergroundDesert;

			// Token: 0x040091B9 RID: 37305
			[Token(Token = "0x40091B9")]
			[FieldOffset(Offset = "0x38")]
			public static CaptureBiome Ocean;

			// Token: 0x040091BA RID: 37306
			[Token(Token = "0x40091BA")]
			[FieldOffset(Offset = "0x3C")]
			public static CaptureBiome Mushroom;
		}

		// Token: 0x020008E7 RID: 2279
		[Token(Token = "0x20008E7")]
		private enum BiomeChoiceIndex
		{
			// Token: 0x040091BC RID: 37308
			[Token(Token = "0x40091BC")]
			AutomatedForPlayer = -1,
			// Token: 0x040091BD RID: 37309
			[Token(Token = "0x40091BD")]
			Purity = 1,
			// Token: 0x040091BE RID: 37310
			[Token(Token = "0x40091BE")]
			Corruption,
			// Token: 0x040091BF RID: 37311
			[Token(Token = "0x40091BF")]
			Jungle,
			// Token: 0x040091C0 RID: 37312
			[Token(Token = "0x40091C0")]
			Hallow,
			// Token: 0x040091C1 RID: 37313
			[Token(Token = "0x40091C1")]
			Snow,
			// Token: 0x040091C2 RID: 37314
			[Token(Token = "0x40091C2")]
			Desert,
			// Token: 0x040091C3 RID: 37315
			[Token(Token = "0x40091C3")]
			DirtLayer,
			// Token: 0x040091C4 RID: 37316
			[Token(Token = "0x40091C4")]
			RockLayer,
			// Token: 0x040091C5 RID: 37317
			[Token(Token = "0x40091C5")]
			Crimson,
			// Token: 0x040091C6 RID: 37318
			[Token(Token = "0x40091C6")]
			UndergroundDesert,
			// Token: 0x040091C7 RID: 37319
			[Token(Token = "0x40091C7")]
			Ocean,
			// Token: 0x040091C8 RID: 37320
			[Token(Token = "0x40091C8")]
			Mushroom
		}
	}
}
