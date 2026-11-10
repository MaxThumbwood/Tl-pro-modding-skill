using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	public class MiscShaderData : ShaderData
	{
		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x6E5840", Offset = "0x6E5840", VA = "0x6E5840")]
		public MiscShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x6E59FC", Offset = "0x6E59FC", VA = "0x6E59FC", Slot = "4")]
		public override void Apply(Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x6E5AB8", Offset = "0x6E5AB8", VA = "0x6E5AB8", Slot = "6")]
		public virtual void Apply([Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x6E66CC", Offset = "0x6E66CC", VA = "0x6E66CC")]
		public MiscShaderData UseColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x6E671C", Offset = "0x6E671C", VA = "0x6E671C")]
		public MiscShaderData UseColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x6E6710", Offset = "0x6E6710", VA = "0x6E6710")]
		public MiscShaderData UseColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x6E67A4", Offset = "0x6E67A4", VA = "0x6E67A4")]
		public MiscShaderData UseSamplerState(SamplerState state)
		{
			return null;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x6E67AC", Offset = "0x6E67AC", VA = "0x6E67AC")]
		public MiscShaderData UseImage0(string path)
		{
			return null;
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x6E68FC", Offset = "0x6E68FC", VA = "0x6E68FC")]
		public MiscShaderData UseImage0(Asset<Texture2D> texture)
		{
			return null;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0x6E6904", Offset = "0x6E6904", VA = "0x6E6904")]
		public MiscShaderData UseImage1(string path)
		{
			return null;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDD")]
		[Address(RVA = "0x6E6A54", Offset = "0x6E6A54", VA = "0x6E6A54")]
		public MiscShaderData UseImage1(Asset<Texture2D> texture)
		{
			return null;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDE")]
		[Address(RVA = "0x6E6A5C", Offset = "0x6E6A5C", VA = "0x6E6A5C")]
		public MiscShaderData UseImage2(string path)
		{
			return null;
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x6E6BAC", Offset = "0x6E6BAC", VA = "0x6E6BAC")]
		public MiscShaderData UseImage2(Asset<Texture2D> texture)
		{
			return null;
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x6E6BB4", Offset = "0x6E6BB4", VA = "0x6E6BB4")]
		public MiscShaderData UseImage0(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x6E6C34", Offset = "0x6E6C34", VA = "0x6E6C34")]
		public MiscShaderData UseImage1(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x6E6CB4", Offset = "0x6E6CB4", VA = "0x6E6CB4")]
		public MiscShaderData UseImage2(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x00023F70 File Offset: 0x00022170
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x6E6D38", Offset = "0x6E6D38", VA = "0x6E6D38")]
		private static bool IsPowerOfTwo(int n)
		{
			return default(bool);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x6E6E24", Offset = "0x6E6E24", VA = "0x6E6E24")]
		public MiscShaderData UseOpacity(float alpha)
		{
			return null;
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x6E6E2C", Offset = "0x6E6E2C", VA = "0x6E6E2C")]
		public MiscShaderData UseSecondaryColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x6E6E7C", Offset = "0x6E6E7C", VA = "0x6E6E7C")]
		public MiscShaderData UseSecondaryColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x6E6E70", Offset = "0x6E6E70", VA = "0x6E6E70")]
		public MiscShaderData UseSecondaryColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x6E6F04", Offset = "0x6E6F04", VA = "0x6E6F04")]
		public MiscShaderData UseProjectionMatrix(bool doUse)
		{
			return null;
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x6E6F0C", Offset = "0x6E6F0C", VA = "0x6E6F0C")]
		public MiscShaderData UseSpriteTransformMatrix(Matrix? transform)
		{
			return null;
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x6E7300", Offset = "0x6E7300", VA = "0x6E7300")]
		public MiscShaderData UseSaturation(float saturation)
		{
			return null;
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x6E7308", Offset = "0x6E7308", VA = "0x6E7308", Slot = "7")]
		public virtual MiscShaderData GetSecondaryShader(Entity entity)
		{
			return null;
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x6E730C", Offset = "0x6E730C", VA = "0x6E730C")]
		public MiscShaderData UseShaderSpecificData(Vector4 specificData)
		{
			return null;
		}

		// Token: 0x040090C5 RID: 37061
		[Token(Token = "0x40090C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 _uColor;

		// Token: 0x040090C6 RID: 37062
		[Token(Token = "0x40090C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 _uSecondaryColor;

		// Token: 0x040090C7 RID: 37063
		[Token(Token = "0x40090C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _uSaturation;

		// Token: 0x040090C8 RID: 37064
		[Token(Token = "0x40090C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _uOpacity;

		// Token: 0x040090C9 RID: 37065
		[Token(Token = "0x40090C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Asset<Texture2D> _uImage0;

		// Token: 0x040090CA RID: 37066
		[Token(Token = "0x40090CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _uImage1;

		// Token: 0x040090CB RID: 37067
		[Token(Token = "0x40090CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Asset<Texture2D> _uImage2;

		// Token: 0x040090CC RID: 37068
		[Token(Token = "0x40090CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Texture2D _uImage0Tex;

		// Token: 0x040090CD RID: 37069
		[Token(Token = "0x40090CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Texture2D _uImage1Tex;

		// Token: 0x040090CE RID: 37070
		[Token(Token = "0x40090CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Texture2D _uImage2Tex;

		// Token: 0x040090CF RID: 37071
		[Token(Token = "0x40090CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _useProjectionMatrix;

		// Token: 0x040090D0 RID: 37072
		[Token(Token = "0x40090D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector4 _shaderSpecificData;

		// Token: 0x040090D1 RID: 37073
		[Token(Token = "0x40090D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SamplerState _customSamplerState;

		// Token: 0x040090D2 RID: 37074
		[Token(Token = "0x40090D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Matrix? _transformMatrix;
	}
}
