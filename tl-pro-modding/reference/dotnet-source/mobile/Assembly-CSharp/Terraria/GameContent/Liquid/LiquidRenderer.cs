using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent.Liquid
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000CC6")]
	public class LiquidRenderer
	{
		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06006125 RID: 24869 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006126 RID: 24870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005D")]
		public event Action<Color[], Rectangle> WaveFilters
		{
			[Token(Token = "0x6006125")]
			[Address(RVA = "0xAA5E08", Offset = "0xAA5E08", VA = "0xAA5E08")]
			add
			{
			}
			[Token(Token = "0x6006126")]
			[Address(RVA = "0xAA5ED0", Offset = "0xAA5ED0", VA = "0xAA5ED0")]
			remove
			{
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8F")]
		private static TileData Tiles
		{
			[Token(Token = "0x6006127")]
			[Address(RVA = "0xAA5F98", Offset = "0xAA5F98", VA = "0xAA5F98")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006128")]
		[Address(RVA = "0xAA5FFC", Offset = "0xAA5FFC", VA = "0xAA5FFC")]
		public static void LoadContent()
		{
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006129")]
		[Address(RVA = "0xAA60A4", Offset = "0xAA60A4", VA = "0xAA60A4")]
		public LiquidRenderer()
		{
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612A")]
		[Address(RVA = "0xAA6214", Offset = "0xAA6214", VA = "0xAA6214")]
		public void PrepareAssets()
		{
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612B")]
		[Address(RVA = "0xAA6478", Offset = "0xAA6478", VA = "0xAA6478")]
		private void InternalPrepareDraw(Rectangle drawArea)
		{
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612C")]
		[Address(RVA = "0xAA8B58", Offset = "0xAA8B58", VA = "0xAA8B58")]
		public void DrawNormalLiquids(SpriteBatch spriteBatch, Vector2 drawOffset, int waterStyle, float globalAlpha, bool isBackgroundDraw, bool waterOnly)
		{
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612D")]
		[Address(RVA = "0xAA9C48", Offset = "0xAA9C48", VA = "0xAA9C48")]
		public void DrawShimmer(SpriteBatch spriteBatch, Vector2 drawOffset, bool isBackgroundDraw)
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612E")]
		[Address(RVA = "0xAAA754", Offset = "0xAAA754", VA = "0xAAA754")]
		public static void SetShimmerVertexColors_Sparkle(ref VertexColors colors, float opacity, int x, int y, bool top)
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612F")]
		[Address(RVA = "0xAAA548", Offset = "0xAAA548", VA = "0xAAA548")]
		public static void SetShimmerVertexColors(ref VertexColors colors, float opacity, int x, int y)
		{
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[Token(Token = "0x6006130")]
		[Address(RVA = "0xAAAF28", Offset = "0xAAAF28", VA = "0xAAAF28")]
		public static float GetShimmerWave(ref float worldPositionX, ref float worldPositionY)
		{
			return 0f;
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[Token(Token = "0x6006131")]
		[Address(RVA = "0xAAB02C", Offset = "0xAAB02C", VA = "0xAAB02C")]
		public static Color GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY)
		{
			return default(Color);
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006132")]
		[Address(RVA = "0xAAA870", Offset = "0xAAA870", VA = "0xAAA870")]
		public static void GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY, ref Color color, float opacity)
		{
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		[Token(Token = "0x6006133")]
		[Address(RVA = "0xAAB220", Offset = "0xAAB220", VA = "0xAAB220")]
		public static float GetShimmerGlitterOpacity(bool top, float worldPositionX, float worldPositionY)
		{
			return 0f;
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[Token(Token = "0x6006134")]
		[Address(RVA = "0xAAB3F4", Offset = "0xAAB3F4", VA = "0xAAB3F4")]
		private static uint SimpleWhiteNoise(uint x, uint y)
		{
			return 0U;
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		[Token(Token = "0x6006135")]
		[Address(RVA = "0xAAA648", Offset = "0xAAA648", VA = "0xAAA648")]
		public int GetShimmerFrame(bool top, float worldPositionX, float worldPositionY)
		{
			return 0;
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x0002CE08 File Offset: 0x0002B008
		[Token(Token = "0x6006136")]
		[Address(RVA = "0xAAB420", Offset = "0xAAB420", VA = "0xAAB420")]
		public static Vector4 GetShimmerBaseColor(float worldPositionX, float worldPositionY)
		{
			return default(Vector4);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006137")]
		[Address(RVA = "0xAAACE8", Offset = "0xAAACE8", VA = "0xAAACE8")]
		public static void GetShimmerColor(float worldPositionX, float worldPositionY, ref Color baseColor, float opcacity)
		{
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x0002CE20 File Offset: 0x0002B020
		[Token(Token = "0x6006138")]
		[Address(RVA = "0xAAB660", Offset = "0xAAB660", VA = "0xAAB660")]
		public bool HasFullWater(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x0002CE38 File Offset: 0x0002B038
		[Token(Token = "0x6006139")]
		[Address(RVA = "0xAAB700", Offset = "0xAAB700", VA = "0xAAB700")]
		public float GetVisibleLiquid(int x, int y)
		{
			return 0f;
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613A")]
		[Address(RVA = "0xAAB798", Offset = "0xAAB798", VA = "0xAAB798")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613B")]
		[Address(RVA = "0xAAB974", Offset = "0xAAB974", VA = "0xAAB974")]
		public void PrepareDraw(Rectangle drawArea)
		{
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613C")]
		[Address(RVA = "0xAAB990", Offset = "0xAAB990", VA = "0xAAB990")]
		public void SetWaveMaskData(ref Texture2D texture)
		{
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x0002CE50 File Offset: 0x0002B050
		[Token(Token = "0x600613D")]
		[Address(RVA = "0xAABDA8", Offset = "0xAABDA8", VA = "0xAABDA8")]
		public Rectangle GetCachedDrawArea()
		{
			return default(Rectangle);
		}

		// Token: 0x04009FC6 RID: 40902
		[Token(Token = "0x4009FC6")]
		[FieldOffset(Offset = "0x0")]
		public static LiquidRenderer Instance;

		// Token: 0x04009FC7 RID: 40903
		[Token(Token = "0x4009FC7")]
		private const int ANIMATION_FRAME_COUNT = 16;

		// Token: 0x04009FC8 RID: 40904
		[Token(Token = "0x4009FC8")]
		private const int CACHE_PADDING = 2;

		// Token: 0x04009FC9 RID: 40905
		[Token(Token = "0x4009FC9")]
		private const int CACHE_PADDING_2 = 4;

		// Token: 0x04009FCA RID: 40906
		[Token(Token = "0x4009FCA")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int[] WATERFALL_LENGTH;

		// Token: 0x04009FCB RID: 40907
		[Token(Token = "0x4009FCB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float[] DEFAULT_OPACITY;

		// Token: 0x04009FCC RID: 40908
		[Token(Token = "0x4009FCC")]
		[FieldOffset(Offset = "0xC")]
		private static readonly byte[] WAVE_MASK_STRENGTH;

		// Token: 0x04009FCD RID: 40909
		[Token(Token = "0x4009FCD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] VISCOSITY_MASK;

		// Token: 0x04009FCF RID: 40911
		[Token(Token = "0x4009FCF")]
		public const float MIN_LIQUID_SIZE = 0.25f;

		// Token: 0x04009FD0 RID: 40912
		[Token(Token = "0x4009FD0")]
		[FieldOffset(Offset = "0x14")]
		private static readonly Asset<Texture2D>[] _liquidTextures;

		// Token: 0x04009FD1 RID: 40913
		[Token(Token = "0x4009FD1")]
		[FieldOffset(Offset = "0xC")]
		private LiquidRenderer.LiquidCache[] _cache;

		// Token: 0x04009FD2 RID: 40914
		[Token(Token = "0x4009FD2")]
		[FieldOffset(Offset = "0x10")]
		private LiquidRenderer.LiquidDrawCache[] _drawCache;

		// Token: 0x04009FD3 RID: 40915
		[Token(Token = "0x4009FD3")]
		[FieldOffset(Offset = "0x14")]
		private LiquidRenderer.SpecialLiquidDrawCache[] _drawCacheForShimmer;

		// Token: 0x04009FD4 RID: 40916
		[Token(Token = "0x4009FD4")]
		[FieldOffset(Offset = "0x18")]
		private int _animationFrame;

		// Token: 0x04009FD5 RID: 40917
		[Token(Token = "0x4009FD5")]
		[FieldOffset(Offset = "0x1C")]
		private int _waterfallAnimationFrame;

		// Token: 0x04009FD6 RID: 40918
		[Token(Token = "0x4009FD6")]
		[FieldOffset(Offset = "0x20")]
		private Rectangle _drawArea;

		// Token: 0x04009FD7 RID: 40919
		[Token(Token = "0x4009FD7")]
		[FieldOffset(Offset = "0x30")]
		private readonly UnifiedRandom _random;

		// Token: 0x04009FD8 RID: 40920
		[Token(Token = "0x4009FD8")]
		[FieldOffset(Offset = "0x34")]
		private Color[] _waveMask;

		// Token: 0x04009FD9 RID: 40921
		[Token(Token = "0x4009FD9")]
		[FieldOffset(Offset = "0x38")]
		private float _frameState;

		// Token: 0x04009FDA RID: 40922
		[Token(Token = "0x4009FDA")]
		[FieldOffset(Offset = "0x3C")]
		private float _waterfallFrameState;

		// Token: 0x02000CC7 RID: 3271
		[Token(Token = "0x2000CC7")]
		private struct LiquidCache
		{
			// Token: 0x04009FDB RID: 40923
			[Token(Token = "0x4009FDB")]
			[FieldOffset(Offset = "0x0")]
			public float LiquidLevel;

			// Token: 0x04009FDC RID: 40924
			[Token(Token = "0x4009FDC")]
			[FieldOffset(Offset = "0x4")]
			public float VisibleLiquidLevel;

			// Token: 0x04009FDD RID: 40925
			[Token(Token = "0x4009FDD")]
			[FieldOffset(Offset = "0x8")]
			public float Opacity;

			// Token: 0x04009FDE RID: 40926
			[Token(Token = "0x4009FDE")]
			[FieldOffset(Offset = "0xC")]
			public bool IsSolid;

			// Token: 0x04009FDF RID: 40927
			[Token(Token = "0x4009FDF")]
			[FieldOffset(Offset = "0xD")]
			public bool IsHalfBrick;

			// Token: 0x04009FE0 RID: 40928
			[Token(Token = "0x4009FE0")]
			[FieldOffset(Offset = "0xE")]
			public bool HasLiquid;

			// Token: 0x04009FE1 RID: 40929
			[Token(Token = "0x4009FE1")]
			[FieldOffset(Offset = "0xF")]
			public bool HasVisibleLiquid;

			// Token: 0x04009FE2 RID: 40930
			[Token(Token = "0x4009FE2")]
			[FieldOffset(Offset = "0x10")]
			public bool HasWall;

			// Token: 0x04009FE3 RID: 40931
			[Token(Token = "0x4009FE3")]
			[FieldOffset(Offset = "0x14")]
			public Point FrameOffset;

			// Token: 0x04009FE4 RID: 40932
			[Token(Token = "0x4009FE4")]
			[FieldOffset(Offset = "0x1C")]
			public bool HasLeftEdge;

			// Token: 0x04009FE5 RID: 40933
			[Token(Token = "0x4009FE5")]
			[FieldOffset(Offset = "0x1D")]
			public bool HasRightEdge;

			// Token: 0x04009FE6 RID: 40934
			[Token(Token = "0x4009FE6")]
			[FieldOffset(Offset = "0x1E")]
			public bool HasTopEdge;

			// Token: 0x04009FE7 RID: 40935
			[Token(Token = "0x4009FE7")]
			[FieldOffset(Offset = "0x1F")]
			public bool HasBottomEdge;

			// Token: 0x04009FE8 RID: 40936
			[Token(Token = "0x4009FE8")]
			[FieldOffset(Offset = "0x20")]
			public float LeftWall;

			// Token: 0x04009FE9 RID: 40937
			[Token(Token = "0x4009FE9")]
			[FieldOffset(Offset = "0x24")]
			public float RightWall;

			// Token: 0x04009FEA RID: 40938
			[Token(Token = "0x4009FEA")]
			[FieldOffset(Offset = "0x28")]
			public float BottomWall;

			// Token: 0x04009FEB RID: 40939
			[Token(Token = "0x4009FEB")]
			[FieldOffset(Offset = "0x2C")]
			public float TopWall;

			// Token: 0x04009FEC RID: 40940
			[Token(Token = "0x4009FEC")]
			[FieldOffset(Offset = "0x30")]
			public float VisibleLeftWall;

			// Token: 0x04009FED RID: 40941
			[Token(Token = "0x4009FED")]
			[FieldOffset(Offset = "0x34")]
			public float VisibleRightWall;

			// Token: 0x04009FEE RID: 40942
			[Token(Token = "0x4009FEE")]
			[FieldOffset(Offset = "0x38")]
			public float VisibleBottomWall;

			// Token: 0x04009FEF RID: 40943
			[Token(Token = "0x4009FEF")]
			[FieldOffset(Offset = "0x3C")]
			public float VisibleTopWall;

			// Token: 0x04009FF0 RID: 40944
			[Token(Token = "0x4009FF0")]
			[FieldOffset(Offset = "0x40")]
			public byte Type;

			// Token: 0x04009FF1 RID: 40945
			[Token(Token = "0x4009FF1")]
			[FieldOffset(Offset = "0x41")]
			public byte VisibleType;
		}

		// Token: 0x02000CC8 RID: 3272
		[Token(Token = "0x2000CC8")]
		private struct LiquidDrawCache
		{
			// Token: 0x04009FF2 RID: 40946
			[Token(Token = "0x4009FF2")]
			[FieldOffset(Offset = "0x0")]
			public Rectangle SourceRectangle;

			// Token: 0x04009FF3 RID: 40947
			[Token(Token = "0x4009FF3")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 LiquidOffset;

			// Token: 0x04009FF4 RID: 40948
			[Token(Token = "0x4009FF4")]
			[FieldOffset(Offset = "0x18")]
			public bool IsVisible;

			// Token: 0x04009FF5 RID: 40949
			[Token(Token = "0x4009FF5")]
			[FieldOffset(Offset = "0x1C")]
			public float Opacity;

			// Token: 0x04009FF6 RID: 40950
			[Token(Token = "0x4009FF6")]
			[FieldOffset(Offset = "0x20")]
			public byte Type;

			// Token: 0x04009FF7 RID: 40951
			[Token(Token = "0x4009FF7")]
			[FieldOffset(Offset = "0x21")]
			public bool IsSurfaceLiquid;

			// Token: 0x04009FF8 RID: 40952
			[Token(Token = "0x4009FF8")]
			[FieldOffset(Offset = "0x22")]
			public bool HasWall;
		}

		// Token: 0x02000CC9 RID: 3273
		[Token(Token = "0x2000CC9")]
		private struct SpecialLiquidDrawCache
		{
			// Token: 0x04009FF9 RID: 40953
			[Token(Token = "0x4009FF9")]
			[FieldOffset(Offset = "0x0")]
			public int X;

			// Token: 0x04009FFA RID: 40954
			[Token(Token = "0x4009FFA")]
			[FieldOffset(Offset = "0x4")]
			public int Y;

			// Token: 0x04009FFB RID: 40955
			[Token(Token = "0x4009FFB")]
			[FieldOffset(Offset = "0x8")]
			public Rectangle SourceRectangle;

			// Token: 0x04009FFC RID: 40956
			[Token(Token = "0x4009FFC")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 LiquidOffset;

			// Token: 0x04009FFD RID: 40957
			[Token(Token = "0x4009FFD")]
			[FieldOffset(Offset = "0x20")]
			public bool IsVisible;

			// Token: 0x04009FFE RID: 40958
			[Token(Token = "0x4009FFE")]
			[FieldOffset(Offset = "0x24")]
			public float Opacity;

			// Token: 0x04009FFF RID: 40959
			[Token(Token = "0x4009FFF")]
			[FieldOffset(Offset = "0x28")]
			public byte Type;

			// Token: 0x0400A000 RID: 40960
			[Token(Token = "0x400A000")]
			[FieldOffset(Offset = "0x29")]
			public bool IsSurfaceLiquid;

			// Token: 0x0400A001 RID: 40961
			[Token(Token = "0x400A001")]
			[FieldOffset(Offset = "0x2A")]
			public bool HasWall;
		}
	}
}
