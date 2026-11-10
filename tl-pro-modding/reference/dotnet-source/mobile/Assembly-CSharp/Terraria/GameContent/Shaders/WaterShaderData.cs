using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000A11 RID: 2577
	[Token(Token = "0x2000A11")]
	public class WaterShaderData : ScreenShaderData
	{
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060053B4 RID: 21428 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060053B5 RID: 21429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000056")]
		public event Action<TileBatch> OnWaveDraw
		{
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0x804930", Offset = "0x804930", VA = "0x804930")]
			add
			{
			}
			[Token(Token = "0x60053B5")]
			[Address(RVA = "0x8049F8", Offset = "0x8049F8", VA = "0x8049F8")]
			remove
			{
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x804AC0", Offset = "0x804AC0", VA = "0x804AC0")]
		public WaterShaderData(string passName)
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x804DF8", Offset = "0x804DF8", VA = "0x804DF8", Slot = "6")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x8051A8", Offset = "0x8051A8", VA = "0x8051A8")]
		private void StepLiquids()
		{
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x805908", Offset = "0x805908", VA = "0x805908")]
		private void DrawWaves()
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x807DD8", Offset = "0x807DD8", VA = "0x807DD8")]
		private void PreDraw(GameTime gameTime)
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x807F28", Offset = "0x807F28", VA = "0x807F28", Slot = "5")]
		public override void Apply()
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x808494", Offset = "0x808494", VA = "0x808494")]
		private void ValidateRenderTargets()
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0x8085DC", Offset = "0x8085DC", VA = "0x8085DC")]
		private void InitRenderTargets(int width, int height)
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x8085D0", Offset = "0x8085D0", VA = "0x8085D0")]
		private void ReleaseRenderTargets()
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x8085F4", Offset = "0x8085F4", VA = "0x8085F4")]
		public void QueueRipple(Vector2 position, float strength = 1f, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x807BB4", Offset = "0x807BB4", VA = "0x807BB4")]
		public void QueueRipple(Vector2 position, float strength, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x807B00", Offset = "0x807B00", VA = "0x807B00")]
		public void QueueRipple(Vector2 position, Color waveData, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
		}

		// Token: 0x0400976F RID: 38767
		[Token(Token = "0x400976F")]
		public const float DISTORTION_BUFFER_SCALE = 0.25f;

		// Token: 0x04009770 RID: 38768
		[Token(Token = "0x4009770")]
		private const float WAVE_FRAMERATE = 0.016666668f;

		// Token: 0x04009771 RID: 38769
		[Token(Token = "0x4009771")]
		private const int MAX_RIPPLES_QUEUED = 200;

		// Token: 0x04009773 RID: 38771
		[Token(Token = "0x4009773")]
		[FieldOffset(Offset = "0x68")]
		public bool _useViscosityFilter;

		// Token: 0x04009774 RID: 38772
		[Token(Token = "0x4009774")]
		[FieldOffset(Offset = "0x69")]
		private bool _usingRenderTargets;

		// Token: 0x04009775 RID: 38773
		[Token(Token = "0x4009775")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 _lastDistortionDrawOffset;

		// Token: 0x04009776 RID: 38774
		[Token(Token = "0x4009776")]
		[FieldOffset(Offset = "0x74")]
		private float _progress;

		// Token: 0x04009777 RID: 38775
		[Token(Token = "0x4009777")]
		[FieldOffset(Offset = "0x78")]
		private WaterShaderData.Ripple[] _rippleQueue;

		// Token: 0x04009778 RID: 38776
		[Token(Token = "0x4009778")]
		[FieldOffset(Offset = "0x7C")]
		private int _rippleQueueCount;

		// Token: 0x04009779 RID: 38777
		[Token(Token = "0x4009779")]
		[FieldOffset(Offset = "0x80")]
		private int _lastScreenWidth;

		// Token: 0x0400977A RID: 38778
		[Token(Token = "0x400977A")]
		[FieldOffset(Offset = "0x84")]
		private int _lastScreenHeight;

		// Token: 0x0400977B RID: 38779
		[Token(Token = "0x400977B")]
		[FieldOffset(Offset = "0x88")]
		public bool _useProjectileWaves;

		// Token: 0x0400977C RID: 38780
		[Token(Token = "0x400977C")]
		[FieldOffset(Offset = "0x89")]
		private bool _useNPCWaves;

		// Token: 0x0400977D RID: 38781
		[Token(Token = "0x400977D")]
		[FieldOffset(Offset = "0x8A")]
		private bool _usePlayerWaves;

		// Token: 0x0400977E RID: 38782
		[Token(Token = "0x400977E")]
		[FieldOffset(Offset = "0x8B")]
		private bool _useRippleWaves;

		// Token: 0x0400977F RID: 38783
		[Token(Token = "0x400977F")]
		[FieldOffset(Offset = "0x8C")]
		private bool _useCustomWaves;

		// Token: 0x04009780 RID: 38784
		[Token(Token = "0x4009780")]
		[FieldOffset(Offset = "0x8D")]
		private bool _clearNextFrame;

		// Token: 0x04009781 RID: 38785
		[Token(Token = "0x4009781")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D[] _viscosityMaskChain;

		// Token: 0x04009782 RID: 38786
		[Token(Token = "0x4009782")]
		[FieldOffset(Offset = "0x94")]
		private int _activeViscosityMask;

		// Token: 0x04009783 RID: 38787
		[Token(Token = "0x4009783")]
		[FieldOffset(Offset = "0x98")]
		private Asset<Texture2D> _rippleShapeTexture;

		// Token: 0x04009784 RID: 38788
		[Token(Token = "0x4009784")]
		[FieldOffset(Offset = "0x9C")]
		private bool _isWaveBufferDirty;

		// Token: 0x04009785 RID: 38789
		[Token(Token = "0x4009785")]
		[FieldOffset(Offset = "0xA0")]
		private int _queuedSteps;

		// Token: 0x04009786 RID: 38790
		[Token(Token = "0x4009786")]
		private const int MAX_QUEUED_STEPS = 1;

		// Token: 0x02000A12 RID: 2578
		[Token(Token = "0x2000A12")]
		private struct Ripple
		{
			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x060053C2 RID: 21442 RVA: 0x00026EB0 File Offset: 0x000250B0
			[Token(Token = "0x170009C3")]
			public Rectangle SourceRectangle
			{
				[Token(Token = "0x60053C2")]
				[Address(RVA = "0x807D4C", Offset = "0x807D4C", VA = "0x807D4C")]
				get
				{
					return default(Rectangle);
				}
			}

			// Token: 0x060053C3 RID: 21443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053C3")]
			[Address(RVA = "0x8087C8", Offset = "0x8087C8", VA = "0x8087C8")]
			public Ripple(Vector2 position, Color waveData, Vector2 size, RippleShape shape, float rotation)
			{
			}

			// Token: 0x04009787 RID: 38791
			[Token(Token = "0x4009787")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Rectangle[] RIPPLE_SHAPE_SOURCE_RECTS;

			// Token: 0x04009788 RID: 38792
			[Token(Token = "0x4009788")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector2 Position;

			// Token: 0x04009789 RID: 38793
			[Token(Token = "0x4009789")]
			[FieldOffset(Offset = "0x8")]
			public readonly Color WaveData;

			// Token: 0x0400978A RID: 38794
			[Token(Token = "0x400978A")]
			[FieldOffset(Offset = "0xC")]
			public readonly Vector2 Size;

			// Token: 0x0400978B RID: 38795
			[Token(Token = "0x400978B")]
			[FieldOffset(Offset = "0x14")]
			public readonly RippleShape Shape;

			// Token: 0x0400978C RID: 38796
			[Token(Token = "0x400978C")]
			[FieldOffset(Offset = "0x18")]
			public readonly float Rotation;
		}
	}
}
