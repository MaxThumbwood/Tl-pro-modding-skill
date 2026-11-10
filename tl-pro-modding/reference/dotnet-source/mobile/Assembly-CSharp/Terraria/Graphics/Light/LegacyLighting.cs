using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	public class LegacyLighting : FileAPI
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x00024318 File Offset: 0x00022518
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094D")]
		public int Mode
		{
			[Token(Token = "0x6004D16")]
			[Address(RVA = "0x71CB88", Offset = "0x71CB88", VA = "0x71CB88")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D17")]
			[Address(RVA = "0x71CB90", Offset = "0x71CB90", VA = "0x71CB90")]
			set
			{
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x00024330 File Offset: 0x00022530
		[Token(Token = "0x1700094E")]
		public bool IsColorOrWhiteMode
		{
			[Token(Token = "0x6004D18")]
			[Address(RVA = "0x71CB98", Offset = "0x71CB98", VA = "0x71CB98")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x71CBAC", Offset = "0x71CBAC", VA = "0x71CBAC")]
		public LegacyLighting(Camera camera)
		{
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x71CFCC", Offset = "0x71CFCC", VA = "0x71CFCC", Slot = "9")]
		public LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			return null;
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00024348 File Offset: 0x00022548
		[Token(Token = "0x6004D1B")]
		[Address(RVA = "0x71CFE0", Offset = "0x71CFE0", VA = "0x71CFE0", Slot = "7")]
		public Vector3 GetColor(int x, int y)
		{
			return default(Vector3);
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x71D0F4", Offset = "0x71D0F4", VA = "0x71D0F4", Slot = "4")]
		public void Rebuild()
		{
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x71D5F0", Offset = "0x71D5F0", VA = "0x71D5F0", Slot = "5")]
		public void AddLight(int x, int y, float r, float g, float b)
		{
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0x71D7FC", Offset = "0x71D7FC", VA = "0x71D7FC", Slot = "6")]
		public void ProcessArea(Rectangle area)
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00024360 File Offset: 0x00022560
		[Token(Token = "0x6004D1F")]
		[Address(RVA = "0x71F708", Offset = "0x71F708", VA = "0x71F708", Slot = "10")]
		public Rectangle GetScanRegion()
		{
			return default(Rectangle);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D20")]
		[Address(RVA = "0x71DDA8", Offset = "0x71DDA8", VA = "0x71DDA8")]
		private void ExportToMiniMap()
		{
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x71EC70", Offset = "0x71EC70", VA = "0x71EC70")]
		private void UpdateLightToSkyColor(float tileR, float tileG, float tileB)
		{
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D22")]
		[Address(RVA = "0x71DCEC", Offset = "0x71DCEC", VA = "0x71DCEC")]
		private void Present()
		{
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x71F718", Offset = "0x71F718", VA = "0x71F718", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D24")]
		[Address(RVA = "0x71F148", Offset = "0x71F148", VA = "0x71F148")]
		private void PreRenderPhase(Rectangle area)
		{
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D25")]
		[Address(RVA = "0x71F7B0", Offset = "0x71F7B0", VA = "0x71F7B0")]
		private void UpdateLightDecay()
		{
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0x71DC28", Offset = "0x71DC28", VA = "0x71DC28")]
		private void DoColors()
		{
		}

		// Token: 0x0400920A RID: 37386
		[Token(Token = "0x400920A")]
		[FieldOffset(Offset = "0x0")]
		public static int RenderPhases;

		// Token: 0x0400920B RID: 37387
		[Token(Token = "0x400920B")]
		private const int AREA_PADDING = 20;

		// Token: 0x0400920C RID: 37388
		[Token(Token = "0x400920C")]
		private const int NON_VISIBLE_PADDING = 0;

		// Token: 0x0400920D RID: 37389
		[Token(Token = "0x400920D")]
		[FieldOffset(Offset = "0x8")]
		private float _oldSkyColor;

		// Token: 0x0400920E RID: 37390
		[Token(Token = "0x400920E")]
		[FieldOffset(Offset = "0xC")]
		private float _skyColor;

		// Token: 0x0400920F RID: 37391
		[Token(Token = "0x400920F")]
		[FieldOffset(Offset = "0x10")]
		private LightMap _activeLightMap;

		// Token: 0x04009210 RID: 37392
		[Token(Token = "0x4009210")]
		[FieldOffset(Offset = "0x14")]
		private Rectangle _activeProcessedArea;

		// Token: 0x04009211 RID: 37393
		[Token(Token = "0x4009211")]
		[FieldOffset(Offset = "0x24")]
		private LightMap _workingLightMap;

		// Token: 0x04009212 RID: 37394
		[Token(Token = "0x4009212")]
		[FieldOffset(Offset = "0x28")]
		private Rectangle _workingProcessedArea;

		// Token: 0x04009213 RID: 37395
		[Token(Token = "0x4009213")]
		private const int MAX_TEMP_LIGHTS = 2000;

		// Token: 0x04009214 RID: 37396
		[Token(Token = "0x4009214")]
		[FieldOffset(Offset = "0x38")]
		private TileLightScanner _tileScanner;

		// Token: 0x04009215 RID: 37397
		[Token(Token = "0x4009215")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Camera _camera;

		// Token: 0x04009216 RID: 37398
		[Token(Token = "0x4009216")]
		[FieldOffset(Offset = "0x40")]
		private short tempLightOffset;

		// Token: 0x04009217 RID: 37399
		[Token(Token = "0x4009217")]
		[FieldOffset(Offset = "0x44")]
		private List<LegacyLighting.ColorTriplet> tempLightData;

		// Token: 0x04009218 RID: 37400
		[Token(Token = "0x4009218")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, short> tempLights;

		// Token: 0x04009219 RID: 37401
		[Token(Token = "0x4009219")]
		[FieldOffset(Offset = "0x4C")]
		private int <Mode>k__BackingField;

		// Token: 0x0400921A RID: 37402
		[Token(Token = "0x400921A")]
		[FieldOffset(Offset = "0x50")]
		private Rectangle screenRegionScan;

		// Token: 0x020008F7 RID: 2295
		[Token(Token = "0x20008F7")]
		private class ColorTriplet
		{
			// Token: 0x06004D28 RID: 19752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D28")]
			[Address(RVA = "0x720428", Offset = "0x720428", VA = "0x720428")]
			public ColorTriplet(float R, float G, float B)
			{
			}

			// Token: 0x06004D29 RID: 19753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D29")]
			[Address(RVA = "0x71D518", Offset = "0x71D518", VA = "0x71D518")]
			public ColorTriplet(float averageColor)
			{
			}

			// Token: 0x0400921B RID: 37403
			[Token(Token = "0x400921B")]
			[FieldOffset(Offset = "0x8")]
			public float R;

			// Token: 0x0400921C RID: 37404
			[Token(Token = "0x400921C")]
			[FieldOffset(Offset = "0xC")]
			public float G;

			// Token: 0x0400921D RID: 37405
			[Token(Token = "0x400921D")]
			[FieldOffset(Offset = "0x10")]
			public float B;
		}
	}
}
