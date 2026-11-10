using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics
{
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	public struct FinalFractalHelper
	{
		// Token: 0x06004B61 RID: 19297 RVA: 0x00023D78 File Offset: 0x00021F78
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x6514FC", Offset = "0x6514FC", VA = "0x6514FC")]
		public static int GetRandomProfileIndex()
		{
			return 0;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x651744", Offset = "0x651744", VA = "0x651744")]
		public void Draw(Projectile proj)
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00023D90 File Offset: 0x00021F90
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x6520C8", Offset = "0x6520C8", VA = "0x6520C8")]
		public static FinalFractalHelper.FinalFractalProfile GetFinalFractalProfile(int usedSwordId)
		{
			return default(FinalFractalHelper.FinalFractalProfile);
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x652678", Offset = "0x652678", VA = "0x652678")]
		private Color StripColors(float progressOnStrip)
		{
			return default(Color);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00023DC0 File Offset: 0x00021FC0
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x65279C", Offset = "0x65279C", VA = "0x65279C")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x04009066 RID: 36966
		[Token(Token = "0x4009066")]
		public const int TotalIllusions = 4;

		// Token: 0x04009067 RID: 36967
		[Token(Token = "0x4009067")]
		public const int FramesPerImportantTrail = 15;

		// Token: 0x04009068 RID: 36968
		[Token(Token = "0x4009068")]
		[FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;

		// Token: 0x04009069 RID: 36969
		[Token(Token = "0x4009069")]
		[FieldOffset(Offset = "0x4")]
		private static List<int> _fractalProfilesKeys;

		// Token: 0x0400906A RID: 36970
		[Token(Token = "0x400906A")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, FinalFractalHelper.FinalFractalProfile> _fractalProfiles;

		// Token: 0x0400906B RID: 36971
		[Token(Token = "0x400906B")]
		[FieldOffset(Offset = "0xC")]
		private static FinalFractalHelper.FinalFractalProfile _defaultProfile;

		// Token: 0x0400906C RID: 36972
		[Token(Token = "0x400906C")]
		[FieldOffset(Offset = "0x0")]
		private Asset<Texture2D> FinalFractalAsset;

		// Token: 0x0400906D RID: 36973
		[Token(Token = "0x400906D")]
		[FieldOffset(Offset = "0x4")]
		private Asset<Texture2D> MagicMissileTrailErosionAsset;

		// Token: 0x020008AE RID: 2222
		// (Invoke) Token: 0x06004B68 RID: 19304
		[Token(Token = "0x20008AE")]
		public delegate void SpawnDustMethod(Vector2 centerPosition, float rotation, Vector2 velocity);

		// Token: 0x020008AF RID: 2223
		[Token(Token = "0x20008AF")]
		public struct FinalFractalProfile
		{
			// Token: 0x06004B6B RID: 19307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B6B")]
			[Address(RVA = "0x653440", Offset = "0x653440", VA = "0x653440")]
			public FinalFractalProfile(float fullBladeLength, Color color)
			{
			}

			// Token: 0x06004B6C RID: 19308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B6C")]
			[Address(RVA = "0x65385C", Offset = "0x65385C", VA = "0x65385C")]
			private void StripDust(Vector2 centerPosition, float rotation, Vector2 velocity)
			{
			}

			// Token: 0x06004B6D RID: 19309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B6D")]
			[Address(RVA = "0x653C04", Offset = "0x653C04", VA = "0x653C04")]
			private void StripColors(float progressOnStrip, out Color col)
			{
			}

			// Token: 0x06004B6E RID: 19310 RVA: 0x00023DD8 File Offset: 0x00021FD8
			[Token(Token = "0x6004B6E")]
			[Address(RVA = "0x653CFC", Offset = "0x653CFC", VA = "0x653CFC")]
			private float StripWidth(float progressOnStrip)
			{
				return 0f;
			}

			// Token: 0x0400906E RID: 36974
			[Token(Token = "0x400906E")]
			[FieldOffset(Offset = "0x0")]
			public float trailWidth;

			// Token: 0x0400906F RID: 36975
			[Token(Token = "0x400906F")]
			[FieldOffset(Offset = "0x4")]
			public Color trailColor;

			// Token: 0x04009070 RID: 36976
			[Token(Token = "0x4009070")]
			[FieldOffset(Offset = "0x8")]
			public FinalFractalHelper.SpawnDustMethod dustMethod;

			// Token: 0x04009071 RID: 36977
			[Token(Token = "0x4009071")]
			[FieldOffset(Offset = "0xC")]
			public VertexStrip.StripColorFunction colorMethod;

			// Token: 0x04009072 RID: 36978
			[Token(Token = "0x4009072")]
			[FieldOffset(Offset = "0x10")]
			public VertexStrip.StripHalfWidthFunction widthMethod;
		}
	}
}
