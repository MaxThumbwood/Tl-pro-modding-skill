using System;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	public class WallDrawing
	{
		// Token: 0x060060D8 RID: 24792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D8")]
		[Address(RVA = "0xA9C500", Offset = "0xA9C500", VA = "0xA9C500")]
		public WallDrawing(TilePaintSystemV2 paintSystem)
		{
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D9")]
		[Address(RVA = "0xA9C8CC", Offset = "0xA9C8CC", VA = "0xA9C8CC")]
		public void Update()
		{
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DA")]
		[Address(RVA = "0xA9C958", Offset = "0xA9C958", VA = "0xA9C958")]
		public void DrawWalls(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DB")]
		[Address(RVA = "0xA9E2A8", Offset = "0xA9E2A8", VA = "0xA9E2A8")]
		public void DrawWalls()
		{
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x0002CA78 File Offset: 0x0002AC78
		[Token(Token = "0x60060DC")]
		[Address(RVA = "0xA9E700", Offset = "0xA9E700", VA = "0xA9E700")]
		private int DrawWallsThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			return 0;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DD")]
		[Address(RVA = "0xA9F6B8", Offset = "0xA9F6B8", VA = "0xA9F6B8")]
		private void ProcessBatchFinished(int index)
		{
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060060DE RID: 24798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8E")]
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			[Token(Token = "0x60060DE")]
			[Address(RVA = "0xA9F7F8", Offset = "0xA9F7F8", VA = "0xA9F7F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0xA9F008", Offset = "0xA9F008", VA = "0xA9F008")]
		private void WaitDrawThreads(int numThreads)
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E0")]
		[Address(RVA = "0xA9F8A4", Offset = "0xA9F8A4", VA = "0xA9F8A4")]
		private void GetWallDrawTexture(ushort wallType, byte wallColor, out Texture2D drawTexture, out EffectPass pass)
		{
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0002CA90 File Offset: 0x0002AC90
		[Token(Token = "0x60060E1")]
		[Address(RVA = "0xA9F960", Offset = "0xA9F960", VA = "0xA9F960")]
		protected bool FullTile(Tile tileCache, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x04009F96 RID: 40854
		[Token(Token = "0x4009F96")]
		[FieldOffset(Offset = "0x8")]
		private TileData _tileArray;

		// Token: 0x04009F97 RID: 40855
		[Token(Token = "0x4009F97")]
		[FieldOffset(Offset = "0xC")]
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04009F98 RID: 40856
		[Token(Token = "0x4009F98")]
		[FieldOffset(Offset = "0x10")]
		private VertexColors _glowPaintColors;

		// Token: 0x04009F99 RID: 40857
		[Token(Token = "0x4009F99")]
		[FieldOffset(Offset = "0x20")]
		private Rectangle outlineLeftRect;

		// Token: 0x04009F9A RID: 40858
		[Token(Token = "0x4009F9A")]
		[FieldOffset(Offset = "0x30")]
		private Rectangle outlineRightRect;

		// Token: 0x04009F9B RID: 40859
		[Token(Token = "0x4009F9B")]
		[FieldOffset(Offset = "0x40")]
		private Rectangle outlineUpRect;

		// Token: 0x04009F9C RID: 40860
		[Token(Token = "0x4009F9C")]
		[FieldOffset(Offset = "0x50")]
		private Rectangle outlineDownRect;

		// Token: 0x04009F9D RID: 40861
		[Token(Token = "0x4009F9D")]
		[FieldOffset(Offset = "0x60")]
		private bool _shouldShowInvisibleWalls;

		// Token: 0x04009F9E RID: 40862
		[Token(Token = "0x4009F9E")]
		[FieldOffset(Offset = "0x64")]
		private int[] FrameOffsetX;

		// Token: 0x04009F9F RID: 40863
		[Token(Token = "0x4009F9F")]
		[FieldOffset(Offset = "0x68")]
		private int[] FrameSizeX;

		// Token: 0x04009FA0 RID: 40864
		[Token(Token = "0x4009FA0")]
		[FieldOffset(Offset = "0x6C")]
		private int[] FrameOffsetY;

		// Token: 0x04009FA1 RID: 40865
		[Token(Token = "0x4009FA1")]
		[FieldOffset(Offset = "0x70")]
		private int[] FrameSizeY;

		// Token: 0x04009FA2 RID: 40866
		[Token(Token = "0x4009FA2")]
		[FieldOffset(Offset = "0x74")]
		private EffectPass[] WallEffects;

		// Token: 0x04009FA3 RID: 40867
		[Token(Token = "0x4009FA3")]
		[FieldOffset(Offset = "0x78")]
		public ThreadLocal<WallDrawing.WallDrawInfo> _currentWallDrawInfo;

		// Token: 0x04009FA4 RID: 40868
		[Token(Token = "0x4009FA4")]
		[FieldOffset(Offset = "0x7C")]
		private int drawThreadTest;

		// Token: 0x04009FA5 RID: 40869
		[Token(Token = "0x4009FA5")]
		[FieldOffset(Offset = "0x80")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x02000CB3 RID: 3251
		[Token(Token = "0x2000CB3")]
		public class WallDrawInfo
		{
			// Token: 0x060060E2 RID: 24802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060E2")]
			[Address(RVA = "0xAA00F8", Offset = "0xAA00F8", VA = "0xAA00F8")]
			public WallDrawInfo()
			{
			}

			// Token: 0x04009FA6 RID: 40870
			[Token(Token = "0x4009FA6")]
			[FieldOffset(Offset = "0x8")]
			public SpriteBatch wallSpriteBatch;

			// Token: 0x04009FA7 RID: 40871
			[Token(Token = "0x4009FA7")]
			[FieldOffset(Offset = "0xC")]
			public SpriteBatch wallSpriteBatch2;

			// Token: 0x04009FA8 RID: 40872
			[Token(Token = "0x4009FA8")]
			[FieldOffset(Offset = "0x10")]
			public TileBatch wallTileBatch;
		}

		// Token: 0x02000CB4 RID: 3252
		[Token(Token = "0x2000CB4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060060E4 RID: 24804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060E4")]
			[Address(RVA = "0xAA0174", Offset = "0xAA0174", VA = "0xAA0174")]
			public <>c()
			{
			}

			// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060E5")]
			[Address(RVA = "0xAA017C", Offset = "0xAA017C", VA = "0xAA017C")]
			internal WallDrawing.WallDrawInfo <.ctor>b__0_0()
			{
				return null;
			}

			// Token: 0x04009FA9 RID: 40873
			[Token(Token = "0x4009FA9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WallDrawing.<>c <>9;

			// Token: 0x04009FAA RID: 40874
			[Token(Token = "0x4009FAA")]
			[FieldOffset(Offset = "0x4")]
			public static Func<WallDrawing.WallDrawInfo> <>9__0_0;
		}
	}
}
