using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public class ArmorShaderData : ShaderData
	{
		// Token: 0x06004BA6 RID: 19366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x6E2614", Offset = "0x6E2614", VA = "0x6E2614")]
		public ArmorShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x6E2CE4", Offset = "0x6E2CE4", VA = "0x6E2CE4")]
		public EffectPass GetDustEffect()
		{
			return null;
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x6E2DD4", Offset = "0x6E2DD4", VA = "0x6E2DD4")]
		public void ApplyDust()
		{
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x6E2EC4", Offset = "0x6E2EC4", VA = "0x6E2EC4", Slot = "4")]
		public override void Apply(Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAA")]
		[Address(RVA = "0x6E3498", Offset = "0x6E3498", VA = "0x6E3498")]
		public ArmorShaderData UseColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAB")]
		[Address(RVA = "0x6E34E8", Offset = "0x6E34E8", VA = "0x6E34E8")]
		public ArmorShaderData UseColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x6E34DC", Offset = "0x6E34DC", VA = "0x6E34DC")]
		public ArmorShaderData UseColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x6E3570", Offset = "0x6E3570", VA = "0x6E3570")]
		public ArmorShaderData UseImage(string path)
		{
			return null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x6E36B8", Offset = "0x6E36B8", VA = "0x6E36B8")]
		public ArmorShaderData UseOpacity(float alpha)
		{
			return null;
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0x6E36C0", Offset = "0x6E36C0", VA = "0x6E36C0")]
		public ArmorShaderData UseTargetPosition(Vector2 position)
		{
			return null;
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0x6E36CC", Offset = "0x6E36CC", VA = "0x6E36CC")]
		public ArmorShaderData UseSecondaryColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x6E371C", Offset = "0x6E371C", VA = "0x6E371C")]
		public ArmorShaderData UseSecondaryColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x6E3710", Offset = "0x6E3710", VA = "0x6E3710")]
		public ArmorShaderData UseSecondaryColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x6E37A4", Offset = "0x6E37A4", VA = "0x6E37A4")]
		public ArmorShaderData UseSaturation(float saturation)
		{
			return null;
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x6E37AC", Offset = "0x6E37AC", VA = "0x6E37AC", Slot = "6")]
		public virtual ArmorShaderData GetSecondaryShader(Entity entity)
		{
			return null;
		}

		// Token: 0x0400909E RID: 37022
		[Token(Token = "0x400909E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 _uColor;

		// Token: 0x0400909F RID: 37023
		[Token(Token = "0x400909F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 _uSecondaryColor;

		// Token: 0x040090A0 RID: 37024
		[Token(Token = "0x40090A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _uSaturation;

		// Token: 0x040090A1 RID: 37025
		[Token(Token = "0x40090A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _uOpacity;

		// Token: 0x040090A2 RID: 37026
		[Token(Token = "0x40090A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Asset<Texture2D> _uImage;

		// Token: 0x040090A3 RID: 37027
		[Token(Token = "0x40090A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 _uTargetPosition;

		// Token: 0x040090A4 RID: 37028
		[Token(Token = "0x40090A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int dustFrame;

		// Token: 0x040090A5 RID: 37029
		[Token(Token = "0x40090A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private EffectPass dustEffect;

		// Token: 0x040090A6 RID: 37030
		[Token(Token = "0x40090A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectParameter _uColorParam;

		// Token: 0x040090A7 RID: 37031
		[Token(Token = "0x40090A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private EffectParameter _uSaturationParam;

		// Token: 0x040090A8 RID: 37032
		[Token(Token = "0x40090A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private EffectParameter _uSecondaryColorParam;

		// Token: 0x040090A9 RID: 37033
		[Token(Token = "0x40090A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private EffectParameter _uTimeParam;

		// Token: 0x040090AA RID: 37034
		[Token(Token = "0x40090AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EffectParameter _uOpacityParam;

		// Token: 0x040090AB RID: 37035
		[Token(Token = "0x40090AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private EffectParameter _uTargetPositionParam;

		// Token: 0x040090AC RID: 37036
		[Token(Token = "0x40090AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private EffectParameter _uSourceRectParam;

		// Token: 0x040090AD RID: 37037
		[Token(Token = "0x40090AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private EffectParameter _uLegacyArmorSourceRectParam;

		// Token: 0x040090AE RID: 37038
		[Token(Token = "0x40090AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EffectParameter _uWorldPositionParam;

		// Token: 0x040090AF RID: 37039
		[Token(Token = "0x40090AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private EffectParameter _uImageSize0Param;

		// Token: 0x040090B0 RID: 37040
		[Token(Token = "0x40090B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EffectParameter _uLegacyArmorSheetSizeParam;

		// Token: 0x040090B1 RID: 37041
		[Token(Token = "0x40090B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private EffectParameter _uRotationParam;

		// Token: 0x040090B2 RID: 37042
		[Token(Token = "0x40090B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private EffectParameter _uImageSize1Param;

		// Token: 0x040090B3 RID: 37043
		[Token(Token = "0x40090B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private EffectParameter _uDirectionParam;

		// Token: 0x040090B4 RID: 37044
		[Token(Token = "0x40090B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool applyingDust;
	}
}
