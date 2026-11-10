using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Light;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class ThreadedRenderManager
{
	// Token: 0x170001DE RID: 478
	// (get) Token: 0x0600144B RID: 5195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001DE")]
	public static ThreadedRenderManager Instance
	{
		[Token(Token = "0x600144B")]
		[Address(RVA = "0xDBFE88", Offset = "0xDBFE88", VA = "0xDBFE88")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144C")]
	[Address(RVA = "0xDC03B0", Offset = "0xDC03B0", VA = "0xDC03B0")]
	private static string GetStackTrace(Thread t)
	{
		return null;
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144D")]
	[Address(RVA = "0xDC0AFC", Offset = "0xDC0AFC", VA = "0xDC0AFC")]
	public static void GetTilePartition(int partitionIndex, int partitionCount, int firstTileX, int firstTileY, int lastTileX, int lastTileY, out int resultFirstTileX, out int resultFirstTileY, out int resultLastTileX, out int resultLastTileY)
	{
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144E")]
	[Address(RVA = "0xDBFF4C", Offset = "0xDBFF4C", VA = "0xDBFF4C")]
	public ThreadedRenderManager()
	{
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144F")]
	[Address(RVA = "0xDC0FD0", Offset = "0xDC0FD0", VA = "0xDC0FD0")]
	public void ThreadMonitor()
	{
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001450")]
	[Address(RVA = "0xDC126C", Offset = "0xDC126C", VA = "0xDC126C")]
	public void WaitAndProcessInOrder(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001451")]
	[Address(RVA = "0xDC1618", Offset = "0xDC1618", VA = "0xDC1618")]
	public void WaitAndProcess(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
	}

	// Token: 0x040028E4 RID: 10468
	[Token(Token = "0x40028E4")]
	[FieldOffset(Offset = "0x0")]
	public static int PrefferedThreadCount;

	// Token: 0x040028E5 RID: 10469
	[Token(Token = "0x40028E5")]
	private const int MaxThreadCount = 3;

	// Token: 0x040028E6 RID: 10470
	[Token(Token = "0x40028E6")]
	[FieldOffset(Offset = "0x4")]
	public static ThreadedRenderManager _instance;

	// Token: 0x040028E7 RID: 10471
	[Token(Token = "0x40028E7")]
	[FieldOffset(Offset = "0x8")]
	public ThreadedRenderManager.RenderThreadInstance[] DrawThreads;

	// Token: 0x040028E8 RID: 10472
	[Token(Token = "0x40028E8")]
	[FieldOffset(Offset = "0xC")]
	private AutoResetEvent[][] WaitHandles;

	// Token: 0x040028E9 RID: 10473
	[Token(Token = "0x40028E9")]
	[FieldOffset(Offset = "0x10")]
	private int[][] WaitThreads;

	// Token: 0x040028EA RID: 10474
	[Token(Token = "0x40028EA")]
	[FieldOffset(Offset = "0x14")]
	private Thread monitor;

	// Token: 0x0200033B RID: 827
	// (Invoke) Token: 0x06001454 RID: 5204
	[Token(Token = "0x200033B")]
	public delegate void BatchProcessCallback(int index);

	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public class RenderThreadInstance
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001457")]
		[Address(RVA = "0xDC0B58", Offset = "0xDC0B58", VA = "0xDC0B58")]
		public RenderThreadInstance(int index)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001458")]
		[Address(RVA = "0xDC1144", Offset = "0xDC1144", VA = "0xDC1144")]
		public void RestartThread()
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001459")]
		[Address(RVA = "0xDC1D14", Offset = "0xDC1D14", VA = "0xDC1D14")]
		public void DrawRockLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0xDC1DF0", Offset = "0xDC1DF0", VA = "0xDC1DF0")]
		public void DrawMagmaLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145B")]
		[Address(RVA = "0xDC1ECC", Offset = "0xDC1ECC", VA = "0xDC1ECC")]
		public void DrawCurrentBackground(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145C")]
		[Address(RVA = "0xDC1FA8", Offset = "0xDC1FA8", VA = "0xDC1FA8")]
		public void DrawTiles(TileDrawing parent, Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145D")]
		[Address(RVA = "0xDC20D8", Offset = "0xDC20D8", VA = "0xDC20D8")]
		public void DrawWalls(WallDrawing parent, Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145E")]
		[Address(RVA = "0xDC21D0", Offset = "0xDC21D0", VA = "0xDC21D0")]
		public void ExportToMinimap(LightingEngine parent, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145F")]
		[Address(RVA = "0xDC2290", Offset = "0xDC2290", VA = "0xDC2290")]
		public void BlurPass1(LightMap parent, int start, int end)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001460")]
		[Address(RVA = "0xDC2340", Offset = "0xDC2340", VA = "0xDC2340")]
		public void BlurPass2(LightMap parent, int start, int end)
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001461")]
		[Address(RVA = "0xDC23F0", Offset = "0xDC23F0", VA = "0xDC23F0")]
		public void ExportTo(TileLightScanner scanner, int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001462")]
		[Address(RVA = "0xDC24DC", Offset = "0xDC24DC", VA = "0xDC24DC")]
		public void DrawThread()
		{
		}

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		[FieldOffset(Offset = "0x8")]
		private ThreadedRenderManager.RenderThreadInstance.DrawTask _task;

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		[FieldOffset(Offset = "0xC")]
		public LiquidRenderer waterRenderer;

		// Token: 0x040028ED RID: 10477
		[Token(Token = "0x40028ED")]
		[FieldOffset(Offset = "0x10")]
		public TileDrawing tileDrawing;

		// Token: 0x040028EE RID: 10478
		[Token(Token = "0x40028EE")]
		[FieldOffset(Offset = "0x14")]
		public WallDrawing wallDrawing;

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x18")]
		public LightingEngine lightingEngine;

		// Token: 0x040028F0 RID: 10480
		[Token(Token = "0x40028F0")]
		[FieldOffset(Offset = "0x1C")]
		public LightMap lightingMap;

		// Token: 0x040028F1 RID: 10481
		[Token(Token = "0x40028F1")]
		[FieldOffset(Offset = "0x20")]
		public TileLightScanner tileScanner;

		// Token: 0x040028F2 RID: 10482
		[Token(Token = "0x40028F2")]
		[FieldOffset(Offset = "0x24")]
		public SpriteBatch spriteBatch;

		// Token: 0x040028F3 RID: 10483
		[Token(Token = "0x40028F3")]
		[FieldOffset(Offset = "0x28")]
		public SpriteBatch spriteBatch2;

		// Token: 0x040028F4 RID: 10484
		[Token(Token = "0x40028F4")]
		[FieldOffset(Offset = "0x2C")]
		public TileBatch tileBatch;

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x30")]
		private AutoResetEvent startEvent;

		// Token: 0x040028F6 RID: 10486
		[Token(Token = "0x40028F6")]
		[FieldOffset(Offset = "0x34")]
		public AutoResetEvent completeEvent;

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x38")]
		public bool Active;

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x39")]
		public bool Complete;

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x3C")]
		public ManagedThread ThreadHandle;

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 _screenPosition;

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 _offSet;

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x50")]
		private int _firstTileX;

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x54")]
		private int _firstTileY;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x58")]
		private int _lastTileX;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0x5C")]
		private int _lastTileY;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0x60")]
		private bool _solidLayer;

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x61")]
		private bool _forRenderTargets;

		// Token: 0x04002902 RID: 10498
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x62")]
		private bool _intoRenderTargets;

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x64")]
		private int _waterStyleOverride;

		// Token: 0x04002904 RID: 10500
		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x68")]
		private int _scannerTileX;

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x6C")]
		private int _scannerTileY;

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x70")]
		private LocalUserGameState state;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x74")]
		private int _index;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x78")]
		private int _diff;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x7C")]
		public bool Running;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x84")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x8C")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x94")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x0200033D RID: 829
		[Token(Token = "0x200033D")]
		private enum DrawTask
		{
			// Token: 0x04002912 RID: 10514
			[Token(Token = "0x4002912")]
			None,
			// Token: 0x04002913 RID: 10515
			[Token(Token = "0x4002913")]
			DrawTask_DrawTiles,
			// Token: 0x04002914 RID: 10516
			[Token(Token = "0x4002914")]
			DrawTask_DrawWalls,
			// Token: 0x04002915 RID: 10517
			[Token(Token = "0x4002915")]
			LightingNew_ExportToMiniMap,
			// Token: 0x04002916 RID: 10518
			[Token(Token = "0x4002916")]
			LightMap_BlurPass1,
			// Token: 0x04002917 RID: 10519
			[Token(Token = "0x4002917")]
			LightMap_BlurPass2,
			// Token: 0x04002918 RID: 10520
			[Token(Token = "0x4002918")]
			Background_RockLayer,
			// Token: 0x04002919 RID: 10521
			[Token(Token = "0x4002919")]
			Background_MagmaLayer,
			// Token: 0x0400291A RID: 10522
			[Token(Token = "0x400291A")]
			Background_CurrentLayer,
			// Token: 0x0400291B RID: 10523
			[Token(Token = "0x400291B")]
			TileScanner_ExportTo
		}
	}
}
