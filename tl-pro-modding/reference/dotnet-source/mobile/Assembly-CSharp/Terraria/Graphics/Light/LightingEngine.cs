using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	// Token: 0x020008F9 RID: 2297
	[Token(Token = "0x20008F9")]
	public class LightingEngine : FileAPI
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094F")]
		private ThreadedRenderManager ThreadManager
		{
			[Token(Token = "0x6004D31")]
			[Address(RVA = "0x720454", Offset = "0x720454", VA = "0x720454")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x7204C8", Offset = "0x7204C8", VA = "0x7204C8")]
		public LightingEngine()
		{
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x7205D4", Offset = "0x7205D4", VA = "0x7205D4", Slot = "5")]
		public void AddLight(int x, int y, float r, float g, float b)
		{
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x7206BC", Offset = "0x7206BC", VA = "0x7206BC", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x720740", Offset = "0x720740", VA = "0x720740", Slot = "9")]
		public LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			return null;
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00024378 File Offset: 0x00022578
		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x720754", Offset = "0x720754", VA = "0x720754", Slot = "7")]
		public Vector3 GetColor(int x, int y)
		{
			return default(Vector3);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x72082C", Offset = "0x72082C", VA = "0x72082C", Slot = "6")]
		public void ProcessArea(Rectangle area)
		{
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x720AB8", Offset = "0x720AB8", VA = "0x720AB8")]
		private void SetState()
		{
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x720E50", Offset = "0x720E50", VA = "0x720E50")]
		private void ProcessScan(Rectangle area)
		{
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0x72101C", Offset = "0x72101C", VA = "0x72101C")]
		private void ProcessBlur()
		{
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3B")]
		[Address(RVA = "0x72104C", Offset = "0x72104C", VA = "0x72104C")]
		private void ProcessBlur2()
		{
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3C")]
		[Address(RVA = "0x721078", Offset = "0x721078", VA = "0x721078")]
		private void Present()
		{
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3D")]
		[Address(RVA = "0x721134", Offset = "0x721134", VA = "0x721134")]
		private void UpdateLightDecay()
		{
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x721A04", Offset = "0x721A04", VA = "0x721A04")]
		private void ApplyPerFrameLights()
		{
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x721B80", Offset = "0x721B80", VA = "0x721B80", Slot = "4")]
		public void Rebuild()
		{
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D40")]
		[Address(RVA = "0x721CF8", Offset = "0x721CF8", VA = "0x721CF8")]
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06004D41 RID: 19777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000950")]
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			[Token(Token = "0x6004D41")]
			[Address(RVA = "0x721CFC", Offset = "0x721CFC", VA = "0x721CFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x721DA8", Offset = "0x721DA8", VA = "0x721DA8")]
		private void ExportToMiniMapThreaded(int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00024390 File Offset: 0x00022590
		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x722C1C", Offset = "0x722C1C", VA = "0x722C1C", Slot = "10")]
		public Rectangle GetScanRegion()
		{
			return default(Rectangle);
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x722140", Offset = "0x722140", VA = "0x722140")]
		public void ExportToMiniMap(int left, int top, int right, int bottom)
		{
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x720B20", Offset = "0x720B20", VA = "0x720B20")]
		private void ExportToMiniMap()
		{
		}

		// Token: 0x0400921E RID: 37406
		[Token(Token = "0x400921E")]
		public const int AREA_PADDING = 20;

		// Token: 0x0400921F RID: 37407
		[Token(Token = "0x400921F")]
		private const int NON_VISIBLE_PADDING = 10;

		// Token: 0x04009220 RID: 37408
		[Token(Token = "0x4009220")]
		private const int MAX_TEMP_LIGHTS = 6000;

		// Token: 0x04009221 RID: 37409
		[Token(Token = "0x4009221")]
		[FieldOffset(Offset = "0x8")]
		private int tempLightCount;

		// Token: 0x04009222 RID: 37410
		[Token(Token = "0x4009222")]
		[FieldOffset(Offset = "0xC")]
		private LightingEngine.PerFrameLight[] _perFrameLights;

		// Token: 0x04009223 RID: 37411
		[Token(Token = "0x4009223")]
		[FieldOffset(Offset = "0x10")]
		private TileLightScanner _tileScanner;

		// Token: 0x04009224 RID: 37412
		[Token(Token = "0x4009224")]
		[FieldOffset(Offset = "0x14")]
		private LightMap _activeLightMap;

		// Token: 0x04009225 RID: 37413
		[Token(Token = "0x4009225")]
		[FieldOffset(Offset = "0x18")]
		private Rectangle _activeProcessedArea;

		// Token: 0x04009226 RID: 37414
		[Token(Token = "0x4009226")]
		[FieldOffset(Offset = "0x28")]
		private LightMap _workingLightMap;

		// Token: 0x04009227 RID: 37415
		[Token(Token = "0x4009227")]
		[FieldOffset(Offset = "0x2C")]
		private Rectangle _workingProcessedArea;

		// Token: 0x04009228 RID: 37416
		[Token(Token = "0x4009228")]
		[FieldOffset(Offset = "0x3C")]
		private LightingEngine.EngineState _state;

		// Token: 0x04009229 RID: 37417
		[Token(Token = "0x4009229")]
		[FieldOffset(Offset = "0x40")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x0400922A RID: 37418
		[Token(Token = "0x400922A")]
		[FieldOffset(Offset = "0x44")]
		private Rectangle screenRegionScan;

		// Token: 0x0400922B RID: 37419
		[Token(Token = "0x400922B")]
		[FieldOffset(Offset = "0x54")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		private enum EngineState
		{
			// Token: 0x0400922D RID: 37421
			[Token(Token = "0x400922D")]
			MinimapUpdate,
			// Token: 0x0400922E RID: 37422
			[Token(Token = "0x400922E")]
			ExportMetrics,
			// Token: 0x0400922F RID: 37423
			[Token(Token = "0x400922F")]
			Scan,
			// Token: 0x04009230 RID: 37424
			[Token(Token = "0x4009230")]
			Blur,
			// Token: 0x04009231 RID: 37425
			[Token(Token = "0x4009231")]
			Blur2
		}

		// Token: 0x020008FB RID: 2299
		[Token(Token = "0x20008FB")]
		private struct PerFrameLight
		{
			// Token: 0x06004D46 RID: 19782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D46")]
			[Address(RVA = "0x722C2C", Offset = "0x722C2C", VA = "0x722C2C")]
			public PerFrameLight(Point position, Vector3 color)
			{
			}

			// Token: 0x04009232 RID: 37426
			[Token(Token = "0x4009232")]
			[FieldOffset(Offset = "0x0")]
			public Point Position;

			// Token: 0x04009233 RID: 37427
			[Token(Token = "0x4009233")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 Color;
		}
	}
}
