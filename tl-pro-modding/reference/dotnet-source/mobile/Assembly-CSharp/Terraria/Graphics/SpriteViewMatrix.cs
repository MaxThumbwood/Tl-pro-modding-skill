using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	public class SpriteViewMatrix
	{
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x00023C88 File Offset: 0x00021E88
		// (set) Token: 0x06004B45 RID: 19269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000924")]
		public Vector2 Zoom
		{
			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x64E5A8", Offset = "0x64E5A8", VA = "0x64E5A8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x64E5BC", Offset = "0x64E5BC", VA = "0x64E5BC")]
			set
			{
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[Token(Token = "0x17000925")]
		public Vector2 Translation
		{
			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x64E660", Offset = "0x64E660", VA = "0x64E660")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00023CB8 File Offset: 0x00021EB8
		[Token(Token = "0x17000926")]
		public Matrix ZoomMatrix
		{
			[Token(Token = "0x6004B47")]
			[Address(RVA = "0x64FF68", Offset = "0x64FF68", VA = "0x64FF68")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x00023CD0 File Offset: 0x00021ED0
		[Token(Token = "0x17000927")]
		public Matrix TransformationMatrix
		{
			[Token(Token = "0x6004B48")]
			[Address(RVA = "0x650044", Offset = "0x650044", VA = "0x650044")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x00023CE8 File Offset: 0x00021EE8
		[Token(Token = "0x17000928")]
		public Matrix NormalizedTransformationMatrix
		{
			[Token(Token = "0x6004B49")]
			[Address(RVA = "0x650120", Offset = "0x650120", VA = "0x650120")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x00023D00 File Offset: 0x00021F00
		[Token(Token = "0x17000929")]
		public Vector2 RenderZoom
		{
			[Token(Token = "0x6004B4A")]
			[Address(RVA = "0x6501FC", Offset = "0x6501FC", VA = "0x6501FC")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x00023D18 File Offset: 0x00021F18
		// (set) Token: 0x06004B4C RID: 19276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092A")]
		public SpriteEffects Effects
		{
			[Token(Token = "0x6004B4B")]
			[Address(RVA = "0x65024C", Offset = "0x65024C", VA = "0x65024C")]
			get
			{
				return SpriteEffects.None;
			}
			[Token(Token = "0x6004B4C")]
			[Address(RVA = "0x650254", Offset = "0x650254", VA = "0x650254")]
			set
			{
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x00023D30 File Offset: 0x00021F30
		[Token(Token = "0x1700092B")]
		public Matrix EffectMatrix
		{
			[Token(Token = "0x6004B4D")]
			[Address(RVA = "0x65026C", Offset = "0x65026C", VA = "0x65026C")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x650348", Offset = "0x650348", VA = "0x650348")]
		public SpriteViewMatrix(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x64E7A4", Offset = "0x64E7A4", VA = "0x64E7A4")]
		private void Rebuild()
		{
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x6506B4", Offset = "0x6506B4", VA = "0x6506B4")]
		public void SetViewportOverride(Viewport viewport)
		{
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x6506DC", Offset = "0x6506DC", VA = "0x6506DC")]
		public void ClearViewportOverride()
		{
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00023D48 File Offset: 0x00021F48
		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x64E70C", Offset = "0x64E70C", VA = "0x64E70C")]
		private bool ShouldRebuild()
		{
			return default(bool);
		}

		// Token: 0x0400904E RID: 36942
		[Token(Token = "0x400904E")]
		[FieldOffset(Offset = "0x8")]
		private Vector2 _zoom;

		// Token: 0x0400904F RID: 36943
		[Token(Token = "0x400904F")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 _translation;

		// Token: 0x04009050 RID: 36944
		[Token(Token = "0x4009050")]
		[FieldOffset(Offset = "0x18")]
		private Matrix _zoomMatrix;

		// Token: 0x04009051 RID: 36945
		[Token(Token = "0x4009051")]
		[FieldOffset(Offset = "0x58")]
		private Matrix _transformationMatrix;

		// Token: 0x04009052 RID: 36946
		[Token(Token = "0x4009052")]
		[FieldOffset(Offset = "0x98")]
		private Matrix _normalizedTransformationMatrix;

		// Token: 0x04009053 RID: 36947
		[Token(Token = "0x4009053")]
		[FieldOffset(Offset = "0xD8")]
		private SpriteEffects _effects;

		// Token: 0x04009054 RID: 36948
		[Token(Token = "0x4009054")]
		[FieldOffset(Offset = "0xDC")]
		private Matrix _effectMatrix;

		// Token: 0x04009055 RID: 36949
		[Token(Token = "0x4009055")]
		[FieldOffset(Offset = "0x11C")]
		private GraphicsDevice _graphicsDevice;

		// Token: 0x04009056 RID: 36950
		[Token(Token = "0x4009056")]
		[FieldOffset(Offset = "0x120")]
		private Viewport _viewport;

		// Token: 0x04009057 RID: 36951
		[Token(Token = "0x4009057")]
		[FieldOffset(Offset = "0x138")]
		private bool _overrideSystemViewport;

		// Token: 0x04009058 RID: 36952
		[Token(Token = "0x4009058")]
		[FieldOffset(Offset = "0x139")]
		private bool _needsRebuild;

		// Token: 0x04009059 RID: 36953
		[Token(Token = "0x4009059")]
		private const float PixelPerfectOffset = 0.00390625f;

		// Token: 0x0400905A RID: 36954
		[Token(Token = "0x400905A")]
		private const float PixelPerfectSafeZoomLevelStep = 0.0078125f;
	}
}
