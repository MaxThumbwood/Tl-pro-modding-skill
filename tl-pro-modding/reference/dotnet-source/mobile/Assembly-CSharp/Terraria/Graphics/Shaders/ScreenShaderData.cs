using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public class ScreenShaderData : ShaderData
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x00023F88 File Offset: 0x00022188
		[Token(Token = "0x17000930")]
		public float Intensity
		{
			[Token(Token = "0x6004BED")]
			[Address(RVA = "0x6E7324", Offset = "0x6E7324", VA = "0x6E7324")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x00023FA0 File Offset: 0x000221A0
		[Token(Token = "0x17000931")]
		public float CombinedOpacity
		{
			[Token(Token = "0x6004BEE")]
			[Address(RVA = "0x6E732C", Offset = "0x6E732C", VA = "0x6E732C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x6E7340", Offset = "0x6E7340", VA = "0x6E7340")]
		public ScreenShaderData(string passName)
		{
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF0")]
		[Address(RVA = "0x6E7788", Offset = "0x6E7788", VA = "0x6E7788")]
		public ScreenShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0x6E7B98", Offset = "0x6E7B98", VA = "0x6E7B98", Slot = "6")]
		public virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x00023FB8 File Offset: 0x000221B8
		[Token(Token = "0x17000932")]
		public static Vector2 UnscaledScreenPosition
		{
			[Token(Token = "0x6004BF2")]
			[Address(RVA = "0x6E7B9C", Offset = "0x6E7B9C", VA = "0x6E7B9C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x00023FD0 File Offset: 0x000221D0
		[Token(Token = "0x17000933")]
		public static Vector2 UnscaledScreenSize
		{
			[Token(Token = "0x6004BF3")]
			[Address(RVA = "0x6E7D3C", Offset = "0x6E7D3C", VA = "0x6E7D3C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x6E7E70", Offset = "0x6E7E70", VA = "0x6E7E70", Slot = "5")]
		public override void Apply()
		{
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x6E8B54", Offset = "0x6E8B54", VA = "0x6E8B54")]
		public ScreenShaderData UseImageOffset(Vector2 offset)
		{
			return null;
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x6E8B60", Offset = "0x6E8B60", VA = "0x6E8B60")]
		public ScreenShaderData UseIntensity(float intensity)
		{
			return null;
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x6E8B68", Offset = "0x6E8B68", VA = "0x6E8B68")]
		public ScreenShaderData UseColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x6E8BB8", Offset = "0x6E8BB8", VA = "0x6E8BB8")]
		public ScreenShaderData UseProgress(float progress)
		{
			return null;
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x6E8BC0", Offset = "0x6E8BC0", VA = "0x6E8BC0")]
		public ScreenShaderData UseImage(Texture2D image, int index = 0, [Optional] SamplerState samplerState)
		{
			return null;
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x6E8C98", Offset = "0x6E8C98", VA = "0x6E8C98")]
		public ScreenShaderData UseImage(string path, int index = 0, [Optional] SamplerState samplerState)
		{
			return null;
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x6E8E90", Offset = "0x6E8E90", VA = "0x6E8E90")]
		public ScreenShaderData UseColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x6E8BAC", Offset = "0x6E8BAC", VA = "0x6E8BAC")]
		public ScreenShaderData UseColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x6E8F18", Offset = "0x6E8F18", VA = "0x6E8F18")]
		public ScreenShaderData UseDirection(Vector2 direction)
		{
			return null;
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x6E8F24", Offset = "0x6E8F24", VA = "0x6E8F24")]
		public ScreenShaderData UseGlobalOpacity(float opacity)
		{
			return null;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x6E8F2C", Offset = "0x6E8F2C", VA = "0x6E8F2C")]
		public ScreenShaderData UseTargetPosition(Vector2 position)
		{
			return null;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x6E8F38", Offset = "0x6E8F38", VA = "0x6E8F38")]
		public ScreenShaderData UseSecondaryColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x6E8F88", Offset = "0x6E8F88", VA = "0x6E8F88")]
		public ScreenShaderData UseSecondaryColor(Color color)
		{
			return null;
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x6E8F7C", Offset = "0x6E8F7C", VA = "0x6E8F7C")]
		public ScreenShaderData UseSecondaryColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x6E9010", Offset = "0x6E9010", VA = "0x6E9010")]
		public ScreenShaderData UseOpacity(float opacity)
		{
			return null;
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x6E9018", Offset = "0x6E9018", VA = "0x6E9018")]
		public ScreenShaderData UseImageScale(Vector2 scale, int index = 0)
		{
			return null;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x6E904C", Offset = "0x6E904C", VA = "0x6E904C", Slot = "7")]
		public virtual ScreenShaderData GetSecondaryShader(Player player)
		{
			return null;
		}

		// Token: 0x040090D3 RID: 37075
		[Token(Token = "0x40090D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 _uColor;

		// Token: 0x040090D4 RID: 37076
		[Token(Token = "0x40090D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 _uSecondaryColor;

		// Token: 0x040090D5 RID: 37077
		[Token(Token = "0x40090D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _uOpacity;

		// Token: 0x040090D6 RID: 37078
		[Token(Token = "0x40090D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _globalOpacity;

		// Token: 0x040090D7 RID: 37079
		[Token(Token = "0x40090D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _uIntensity;

		// Token: 0x040090D8 RID: 37080
		[Token(Token = "0x40090D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 _uTargetPosition;

		// Token: 0x040090D9 RID: 37081
		[Token(Token = "0x40090D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 _uDirection;

		// Token: 0x040090DA RID: 37082
		[Token(Token = "0x40090DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _uProgress;

		// Token: 0x040090DB RID: 37083
		[Token(Token = "0x40090DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector2 _uImageOffset;

		// Token: 0x040090DC RID: 37084
		[Token(Token = "0x40090DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Asset<Texture2D>[] _uAssetImages;

		// Token: 0x040090DD RID: 37085
		[Token(Token = "0x40090DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Texture2D[] _uCustomImages;

		// Token: 0x040090DE RID: 37086
		[Token(Token = "0x40090DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private SamplerState[] _samplerStates;

		// Token: 0x040090DF RID: 37087
		[Token(Token = "0x40090DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector2[] _imageScales;
	}
}
