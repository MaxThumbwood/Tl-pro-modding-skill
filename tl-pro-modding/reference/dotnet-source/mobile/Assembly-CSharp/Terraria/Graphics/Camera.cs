using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public class Camera
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x00023B80 File Offset: 0x00021D80
		[Token(Token = "0x17000919")]
		public Vector2 UnscaledPosition
		{
			[Token(Token = "0x6004B31")]
			[Address(RVA = "0x64D234", Offset = "0x64D234", VA = "0x64D234")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06004B32 RID: 19250 RVA: 0x00023B98 File Offset: 0x00021D98
		[Token(Token = "0x1700091A")]
		public Vector2 UnscaledSize
		{
			[Token(Token = "0x6004B32")]
			[Address(RVA = "0x64D2AC", Offset = "0x64D2AC", VA = "0x64D2AC")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x00023BB0 File Offset: 0x00021DB0
		[Token(Token = "0x1700091B")]
		public Vector2 ScaledPosition
		{
			[Token(Token = "0x6004B33")]
			[Address(RVA = "0x64D34C", Offset = "0x64D34C", VA = "0x64D34C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x00023BC8 File Offset: 0x00021DC8
		[Token(Token = "0x1700091C")]
		public Vector2 ScaledSize
		{
			[Token(Token = "0x6004B34")]
			[Address(RVA = "0x64D3C4", Offset = "0x64D3C4", VA = "0x64D3C4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x00023BE0 File Offset: 0x00021DE0
		[Token(Token = "0x1700091D")]
		public float BiggerScaledAxis
		{
			[Token(Token = "0x6004B35")]
			[Address(RVA = "0x64D464", Offset = "0x64D464", VA = "0x64D464")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x00023BF8 File Offset: 0x00021DF8
		[Token(Token = "0x1700091E")]
		public float SmallerScaledAxis
		{
			[Token(Token = "0x6004B36")]
			[Address(RVA = "0x64D520", Offset = "0x64D520", VA = "0x64D520")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091F")]
		public RasterizerState Rasterizer
		{
			[Token(Token = "0x6004B37")]
			[Address(RVA = "0x64D5DC", Offset = "0x64D5DC", VA = "0x64D5DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000920")]
		public SamplerState Sampler
		{
			[Token(Token = "0x6004B38")]
			[Address(RVA = "0x64D640", Offset = "0x64D640", VA = "0x64D640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000921")]
		public SpriteViewMatrix GameViewMatrix
		{
			[Token(Token = "0x6004B39")]
			[Address(RVA = "0x64D6A0", Offset = "0x64D6A0", VA = "0x64D6A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000922")]
		public SpriteBatch SpriteBatch
		{
			[Token(Token = "0x6004B3A")]
			[Address(RVA = "0x64D704", Offset = "0x64D704", VA = "0x64D704")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06004B3B RID: 19259 RVA: 0x00023C10 File Offset: 0x00021E10
		[Token(Token = "0x17000923")]
		public Vector2 Center
		{
			[Token(Token = "0x6004B3B")]
			[Address(RVA = "0x64D768", Offset = "0x64D768", VA = "0x64D768")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x64D900", Offset = "0x64D900", VA = "0x64D900")]
		public Camera()
		{
		}
	}
}
