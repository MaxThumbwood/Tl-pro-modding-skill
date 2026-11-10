using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	public class ScreenShader : Effect
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0xE4CF34", Offset = "0xE4CF34", VA = "0xE4CF34")]
		public ScreenShader(GraphicsDevice device)
		{
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public static ScreenShader Effect
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0xE4DA78", Offset = "0xE4DA78", VA = "0xE4DA78")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0xE4E0D8", Offset = "0xE4E0D8", VA = "0xE4E0D8")]
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0xE4E3F8", Offset = "0xE4E3F8", VA = "0xE4E3F8", Slot = "5")]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
		}

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x24")]
		private EffectParameter _uColor;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x28")]
		private EffectParameter _uOpacity;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0x2C")]
		private EffectParameter _uSecondaryColor;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0x30")]
		private EffectParameter _uTime;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x34")]
		private EffectParameter _uScreenResolution;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x38")]
		private EffectParameter _uScreenPosition;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x3C")]
		private EffectParameter _uTargetPosition;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x40")]
		private EffectParameter _uIntensity;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x44")]
		private EffectParameter _uImageOffset;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0x48")]
		private EffectParameter _uProgress;

		// Token: 0x04002EB5 RID: 11957
		[Token(Token = "0x4002EB5")]
		[FieldOffset(Offset = "0x4C")]
		private EffectParameter _uDirection;

		// Token: 0x04002EB6 RID: 11958
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0x50")]
		private EffectParameter _uZoom;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x54")]
		private EffectParameter _uImageSize1;

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x58")]
		private EffectParameter _uImageSize2;

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x5C")]
		private EffectParameter _uImageSize3;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x0")]
		private static ScreenShader _effect;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0x4")]
		private static int _colorId;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x8")]
		private static int _opacityId;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0xC")]
		private static int _secondaryColorId;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x10")]
		private static int _timeId;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x14")]
		private static int _screenResolutionId;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x18")]
		private static int _screenPositionId;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x1C")]
		private static int _targetPositionId;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x20")]
		private static int _intensityId;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x24")]
		private static int _progressId;

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x28")]
		private static int _directionId;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x2C")]
		private static int _ImageOffset;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x30")]
		private static int _ImageSize1;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0x34")]
		private static int _ImageSize2;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x38")]
		private static int _ImageSize3;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x3C")]
		private static int _vppiid;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x40")]
		private static int _Zoom;
	}
}
