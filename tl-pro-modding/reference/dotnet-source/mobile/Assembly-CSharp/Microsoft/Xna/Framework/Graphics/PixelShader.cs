using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class PixelShader : Effect
	{
		// Token: 0x06001B06 RID: 6918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0xE47640", Offset = "0xE47640", VA = "0xE47640")]
		public PixelShader(GraphicsDevice device)
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FC")]
		public static PixelShader Effect
		{
			[Token(Token = "0x6001B07")]
			[Address(RVA = "0xE48534", Offset = "0xE48534", VA = "0xE48534")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0xE49208", Offset = "0xE49208", VA = "0xE49208")]
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0xE49528", Offset = "0xE49528", VA = "0xE49528")]
		private void ApplyAffineTransform(Material material)
		{
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0xE49748", Offset = "0xE49748", VA = "0xE49748", Slot = "5")]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
		}

		// Token: 0x04002E3B RID: 11835
		[Token(Token = "0x4002E3B")]
		[FieldOffset(Offset = "0x24")]
		public EffectParameter _uColor;

		// Token: 0x04002E3C RID: 11836
		[Token(Token = "0x4002E3C")]
		[FieldOffset(Offset = "0x28")]
		private EffectParameter _uSaturation;

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x2C")]
		private EffectParameter _uSecondaryColor;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x30")]
		private EffectParameter _uTime;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x34")]
		private EffectParameter _uOpacity;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x38")]
		private EffectParameter _uLightSource;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x3C")]
		private EffectParameter _uSourceRect;

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x40")]
		private EffectParameter _uLegacyArmorSourceRect;

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x44")]
		private EffectParameter _uLegacyArmorSheetSize;

		// Token: 0x04002E44 RID: 11844
		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0x48")]
		private EffectParameter _uWorldPosition;

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x4C")]
		private EffectParameter _uImageSize0;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x50")]
		private EffectParameter _uImageSize1;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x54")]
		private EffectParameter _uImageSize2;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x58")]
		private EffectParameter _uRotation;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0x5C")]
		private EffectParameter _uDirection;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0x60")]
		private EffectParameter _uDrawPosition;

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x64")]
		private EffectParameter _uTargetPosition;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x68")]
		public EffectParameter _uShaderSpecificData;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x6C")]
		private EffectParameter _uMatrixTransform0;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x70")]
		public EffectParameter _backgroundScale;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0x74")]
		private short[] TileOffsetData;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x78")]
		private GraphicsDevice device;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x0")]
		private static PixelShader _effect;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x4")]
		private static int _colorId;

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x8")]
		private static int _secondaryColorId;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0xC")]
		private static int _saturationId;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x10")]
		private static int _imageSize0Id;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x14")]
		private static int _imageSize1Id;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x18")]
		private static int _sourceRectId;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x1C")]
		private static int _timeId;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x20")]
		private static int _opacityId;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x24")]
		private static int _directionId;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x28")]
		private static int _rotationId;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x2C")]
		private static int _lightSourceId;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x30")]
		private static int _targetPositionId;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x34")]
		private static int _textureRectId;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x38")]
		private static int _shaderSpecificDataId;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x3C")]
		private static int _backgroundScaleId;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x40")]
		private static int _AffineOffsetId;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x44")]
		private static int _AffineScaleId;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x7C")]
		private Vector4 AffineOffsetValue;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x8C")]
		private Vector4 AffineScaleValue;

		// Token: 0x020003E1 RID: 993
		[Token(Token = "0x20003E1")]
		public enum PassIds
		{
			// Token: 0x04002E66 RID: 11878
			[Token(Token = "0x4002E66")]
			Default,
			// Token: 0x04002E67 RID: 11879
			[Token(Token = "0x4002E67")]
			ColorOnly,
			// Token: 0x04002E68 RID: 11880
			[Token(Token = "0x4002E68")]
			ArmorMartian,
			// Token: 0x04002E69 RID: 11881
			[Token(Token = "0x4002E69")]
			ArmorColored,
			// Token: 0x04002E6A RID: 11882
			[Token(Token = "0x4002E6A")]
			ArmorColoredAndBlack,
			// Token: 0x04002E6B RID: 11883
			[Token(Token = "0x4002E6B")]
			ArmorColoredAndSilverTrim,
			// Token: 0x04002E6C RID: 11884
			[Token(Token = "0x4002E6C")]
			ArmorSilverTrim,
			// Token: 0x04002E6D RID: 11885
			[Token(Token = "0x4002E6D")]
			ArmorBrightnessColored,
			// Token: 0x04002E6E RID: 11886
			[Token(Token = "0x4002E6E")]
			ArmorColoredGradient,
			// Token: 0x04002E6F RID: 11887
			[Token(Token = "0x4002E6F")]
			ArmorColoredAndBlackGradient,
			// Token: 0x04002E70 RID: 11888
			[Token(Token = "0x4002E70")]
			ArmorBrightnessGradient,
			// Token: 0x04002E71 RID: 11889
			[Token(Token = "0x4002E71")]
			ArmorColoredRainbow,
			// Token: 0x04002E72 RID: 11890
			[Token(Token = "0x4002E72")]
			ArmorBrightnessRainbow,
			// Token: 0x04002E73 RID: 11891
			[Token(Token = "0x4002E73")]
			ArmorLivingRainbow,
			// Token: 0x04002E74 RID: 11892
			[Token(Token = "0x4002E74")]
			ArmorInvert,
			// Token: 0x04002E75 RID: 11893
			[Token(Token = "0x4002E75")]
			ArmorLivingOcean,
			// Token: 0x04002E76 RID: 11894
			[Token(Token = "0x4002E76")]
			ArmorLivingFlame,
			// Token: 0x04002E77 RID: 11895
			[Token(Token = "0x4002E77")]
			ArmorWisp,
			// Token: 0x04002E78 RID: 11896
			[Token(Token = "0x4002E78")]
			ArmorHighContrastGlow,
			// Token: 0x04002E79 RID: 11897
			[Token(Token = "0x4002E79")]
			ArmorPlaid,
			// Token: 0x04002E7A RID: 11898
			[Token(Token = "0x4002E7A")]
			ArmorDev,
			// Token: 0x04002E7B RID: 11899
			[Token(Token = "0x4002E7B")]
			ArmorPlaid2,
			// Token: 0x04002E7C RID: 11900
			[Token(Token = "0x4002E7C")]
			ArmorReflectiveColor,
			// Token: 0x04002E7D RID: 11901
			[Token(Token = "0x4002E7D")]
			ArmorBasicColor,
			// Token: 0x04002E7E RID: 11902
			[Token(Token = "0x4002E7E")]
			ArmorHades,
			// Token: 0x04002E7F RID: 11903
			[Token(Token = "0x4002E7F")]
			ArmorTwilight,
			// Token: 0x04002E80 RID: 11904
			[Token(Token = "0x4002E80")]
			ArmorAcid,
			// Token: 0x04002E81 RID: 11905
			[Token(Token = "0x4002E81")]
			ArmorMushroom,
			// Token: 0x04002E82 RID: 11906
			[Token(Token = "0x4002E82")]
			ArmorPhase,
			// Token: 0x04002E83 RID: 11907
			[Token(Token = "0x4002E83")]
			ArmorReflective,
			// Token: 0x04002E84 RID: 11908
			[Token(Token = "0x4002E84")]
			ArmorSolar,
			// Token: 0x04002E85 RID: 11909
			[Token(Token = "0x4002E85")]
			ArmorNebula,
			// Token: 0x04002E86 RID: 11910
			[Token(Token = "0x4002E86")]
			ArmorVortex,
			// Token: 0x04002E87 RID: 11911
			[Token(Token = "0x4002E87")]
			ArmorStardust,
			// Token: 0x04002E88 RID: 11912
			[Token(Token = "0x4002E88")]
			ArmorVoid,
			// Token: 0x04002E89 RID: 11913
			[Token(Token = "0x4002E89")]
			ArmorShiftingSands,
			// Token: 0x04002E8A RID: 11914
			[Token(Token = "0x4002E8A")]
			ArmorShiftingPearlsands,
			// Token: 0x04002E8B RID: 11915
			[Token(Token = "0x4002E8B")]
			ArmorFog,
			// Token: 0x04002E8C RID: 11916
			[Token(Token = "0x4002E8C")]
			ArmorHallowBoss,
			// Token: 0x04002E8D RID: 11917
			[Token(Token = "0x4002E8D")]
			ArmorMirage,
			// Token: 0x04002E8E RID: 11918
			[Token(Token = "0x4002E8E")]
			ArmorMidnightRainbow,
			// Token: 0x04002E8F RID: 11919
			[Token(Token = "0x4002E8F")]
			ArmorColoredAndSilverTrimGradient,
			// Token: 0x04002E90 RID: 11920
			[Token(Token = "0x4002E90")]
			ArmorPolarized,
			// Token: 0x04002E91 RID: 11921
			[Token(Token = "0x4002E91")]
			ArmorGel,
			// Token: 0x04002E92 RID: 11922
			[Token(Token = "0x4002E92")]
			ArmorFlow,
			// Token: 0x04002E93 RID: 11923
			[Token(Token = "0x4002E93")]
			ArmorForceField,
			// Token: 0x04002E94 RID: 11924
			[Token(Token = "0x4002E94")]
			ArmorLoki,
			// Token: 0x04002E95 RID: 11925
			[Token(Token = "0x4002E95")]
			ForceField,
			// Token: 0x04002E96 RID: 11926
			[Token(Token = "0x4002E96")]
			WaterProcessor,
			// Token: 0x04002E97 RID: 11927
			[Token(Token = "0x4002E97")]
			WaterDistortionObject,
			// Token: 0x04002E98 RID: 11928
			[Token(Token = "0x4002E98")]
			HallowBoss,
			// Token: 0x04002E99 RID: 11929
			[Token(Token = "0x4002E99")]
			TitaniumStorm,
			// Token: 0x04002E9A RID: 11930
			[Token(Token = "0x4002E9A")]
			QueenSlime,
			// Token: 0x04002E9B RID: 11931
			[Token(Token = "0x4002E9B")]
			MagicMissile,
			// Token: 0x04002E9C RID: 11932
			[Token(Token = "0x4002E9C")]
			FinalFractal,
			// Token: 0x04002E9D RID: 11933
			[Token(Token = "0x4002E9D")]
			FinalFractalVertex,
			// Token: 0x04002E9E RID: 11934
			[Token(Token = "0x4002E9E")]
			MaskedFade,
			// Token: 0x04002E9F RID: 11935
			[Token(Token = "0x4002E9F")]
			RainbowTownSlime,
			// Token: 0x04002EA0 RID: 11936
			[Token(Token = "0x4002EA0")]
			HorizonClouds,
			// Token: 0x04002EA1 RID: 11937
			[Token(Token = "0x4002EA1")]
			LitNature,
			// Token: 0x04002EA2 RID: 11938
			[Token(Token = "0x4002EA2")]
			Aurora,
			// Token: 0x04002EA3 RID: 11939
			[Token(Token = "0x4002EA3")]
			StormLightning,
			// Token: 0x04002EA4 RID: 11940
			[Token(Token = "0x4002EA4")]
			LensFlare,
			// Token: 0x04002EA5 RID: 11941
			[Token(Token = "0x4002EA5")]
			MouseItem,
			// Token: 0x04002EA6 RID: 11942
			[Token(Token = "0x4002EA6")]
			RainbowTownSlimeOutline,
			// Token: 0x04002EA7 RID: 11943
			[Token(Token = "0x4002EA7")]
			Outline,
			// Token: 0x04002EA8 RID: 11944
			[Token(Token = "0x4002EA8")]
			RevSub,
			// Token: 0x04002EA9 RID: 11945
			[Token(Token = "0x4002EA9")]
			FontWithShadow,
			// Token: 0x04002EAA RID: 11946
			[Token(Token = "0x4002EAA")]
			TileOutline
		}
	}
}
