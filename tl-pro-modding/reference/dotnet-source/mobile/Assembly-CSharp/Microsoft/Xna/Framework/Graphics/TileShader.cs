using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public class TileShader : Effect
	{
		// Token: 0x06001B13 RID: 6931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0xE4EF74", Offset = "0xE4EF74", VA = "0xE4EF74")]
		public TileShader(GraphicsDevice device)
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0xE4F488", Offset = "0xE4F488", VA = "0xE4F488", Slot = "5")]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0xE4F9AC", Offset = "0xE4F9AC", VA = "0xE4F9AC")]
		public static TileShader CreateNew(bool isNature = false)
		{
			return null;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public static TileShader Effect
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0xE50658", Offset = "0xE50658", VA = "0xE50658")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0xE50350", Offset = "0xE50350", VA = "0xE50350")]
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
		}

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x24")]
		private EffectParameter _leafMinHueOffset;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x28")]
		private EffectParameter _leafMinHue;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x2C")]
		private EffectParameter _leafMaxHue;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x30")]
		private EffectParameter _leafMinSat;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x34")]
		private EffectParameter _leafMaxSat;

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x38")]
		private EffectParameter _invertSpecialGroupResult;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x3C")]
		private bool _isNatureShader;

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x0")]
		private static int _leafHueTestOffsetId;

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x4")]
		private static int _leafMinHueId;

		// Token: 0x04002ED5 RID: 11989
		[Token(Token = "0x4002ED5")]
		[FieldOffset(Offset = "0x8")]
		private static int _leafMaxHueId;

		// Token: 0x04002ED6 RID: 11990
		[Token(Token = "0x4002ED6")]
		[FieldOffset(Offset = "0xC")]
		private static int _leafMinSatId;

		// Token: 0x04002ED7 RID: 11991
		[Token(Token = "0x4002ED7")]
		[FieldOffset(Offset = "0x10")]
		private static int _leafMaxSatId;

		// Token: 0x04002ED8 RID: 11992
		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x14")]
		private static int _invertSpecialGroupResultId;

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x18")]
		private static int _shaderSpecificDataId;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x1C")]
		private static int _backgroundScaleId;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x20")]
		private static int _colorId;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x24")]
		private static TileShader _effect;

		// Token: 0x020003E5 RID: 997
		[Token(Token = "0x20003E5")]
		public enum PassIds
		{
			// Token: 0x04002EDE RID: 11998
			[Token(Token = "0x4002EDE")]
			OldColor,
			// Token: 0x04002EDF RID: 11999
			[Token(Token = "0x4002EDF")]
			TileRed,
			// Token: 0x04002EE0 RID: 12000
			[Token(Token = "0x4002EE0")]
			TileOrange,
			// Token: 0x04002EE1 RID: 12001
			[Token(Token = "0x4002EE1")]
			TileYellow,
			// Token: 0x04002EE2 RID: 12002
			[Token(Token = "0x4002EE2")]
			TileLime,
			// Token: 0x04002EE3 RID: 12003
			[Token(Token = "0x4002EE3")]
			TileGreen,
			// Token: 0x04002EE4 RID: 12004
			[Token(Token = "0x4002EE4")]
			TileTeal,
			// Token: 0x04002EE5 RID: 12005
			[Token(Token = "0x4002EE5")]
			TileCyan,
			// Token: 0x04002EE6 RID: 12006
			[Token(Token = "0x4002EE6")]
			TileSkyBlue,
			// Token: 0x04002EE7 RID: 12007
			[Token(Token = "0x4002EE7")]
			TileBlue,
			// Token: 0x04002EE8 RID: 12008
			[Token(Token = "0x4002EE8")]
			TilePurple,
			// Token: 0x04002EE9 RID: 12009
			[Token(Token = "0x4002EE9")]
			TileViolet,
			// Token: 0x04002EEA RID: 12010
			[Token(Token = "0x4002EEA")]
			TilePink,
			// Token: 0x04002EEB RID: 12011
			[Token(Token = "0x4002EEB")]
			TileDeepRed,
			// Token: 0x04002EEC RID: 12012
			[Token(Token = "0x4002EEC")]
			TileDeepOrange,
			// Token: 0x04002EED RID: 12013
			[Token(Token = "0x4002EED")]
			TileDeepYellow,
			// Token: 0x04002EEE RID: 12014
			[Token(Token = "0x4002EEE")]
			TileDeepLime,
			// Token: 0x04002EEF RID: 12015
			[Token(Token = "0x4002EEF")]
			TileDeepGreen,
			// Token: 0x04002EF0 RID: 12016
			[Token(Token = "0x4002EF0")]
			TileDeepTeal,
			// Token: 0x04002EF1 RID: 12017
			[Token(Token = "0x4002EF1")]
			TileDeepCyan,
			// Token: 0x04002EF2 RID: 12018
			[Token(Token = "0x4002EF2")]
			TileDeepSkyBlue,
			// Token: 0x04002EF3 RID: 12019
			[Token(Token = "0x4002EF3")]
			TileDeepBlue,
			// Token: 0x04002EF4 RID: 12020
			[Token(Token = "0x4002EF4")]
			TileDeepPurple,
			// Token: 0x04002EF5 RID: 12021
			[Token(Token = "0x4002EF5")]
			TileDeepViolet,
			// Token: 0x04002EF6 RID: 12022
			[Token(Token = "0x4002EF6")]
			TileDeepPink,
			// Token: 0x04002EF7 RID: 12023
			[Token(Token = "0x4002EF7")]
			TileBlack,
			// Token: 0x04002EF8 RID: 12024
			[Token(Token = "0x4002EF8")]
			TileSilver,
			// Token: 0x04002EF9 RID: 12025
			[Token(Token = "0x4002EF9")]
			TileGray,
			// Token: 0x04002EFA RID: 12026
			[Token(Token = "0x4002EFA")]
			TileGrassRed,
			// Token: 0x04002EFB RID: 12027
			[Token(Token = "0x4002EFB")]
			TileGrassOrange,
			// Token: 0x04002EFC RID: 12028
			[Token(Token = "0x4002EFC")]
			TileGrassYellow,
			// Token: 0x04002EFD RID: 12029
			[Token(Token = "0x4002EFD")]
			TileGrassLime,
			// Token: 0x04002EFE RID: 12030
			[Token(Token = "0x4002EFE")]
			TileGrassGreen,
			// Token: 0x04002EFF RID: 12031
			[Token(Token = "0x4002EFF")]
			TileGrassTeal,
			// Token: 0x04002F00 RID: 12032
			[Token(Token = "0x4002F00")]
			TileGrassCyan,
			// Token: 0x04002F01 RID: 12033
			[Token(Token = "0x4002F01")]
			TileGrassSkyBlue,
			// Token: 0x04002F02 RID: 12034
			[Token(Token = "0x4002F02")]
			TileGrassBlue,
			// Token: 0x04002F03 RID: 12035
			[Token(Token = "0x4002F03")]
			TileGrassPurple,
			// Token: 0x04002F04 RID: 12036
			[Token(Token = "0x4002F04")]
			TileGrassViolet,
			// Token: 0x04002F05 RID: 12037
			[Token(Token = "0x4002F05")]
			TileGrassPink,
			// Token: 0x04002F06 RID: 12038
			[Token(Token = "0x4002F06")]
			TileBrown,
			// Token: 0x04002F07 RID: 12039
			[Token(Token = "0x4002F07")]
			TileShadow,
			// Token: 0x04002F08 RID: 12040
			[Token(Token = "0x4002F08")]
			TileNegative,
			// Token: 0x04002F09 RID: 12041
			[Token(Token = "0x4002F09")]
			WallNegative,
			// Token: 0x04002F0A RID: 12042
			[Token(Token = "0x4002F0A")]
			DebugHSL
		}
	}
}
