using System;
using System.Collections;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	public class WorldSections
	{
		// Token: 0x06003991 RID: 14737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x1DF6E4C", Offset = "0x1DF6E4C", VA = "0x1DF6E4C")]
		public WorldSections(int numSectionsX, int numSectionsY)
		{
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		[Token(Token = "0x17000736")]
		public bool AnyUnfinishedSections
		{
			[Token(Token = "0x6003992")]
			[Address(RVA = "0x1DF6FB4", Offset = "0x1DF6FB4", VA = "0x1DF6FB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		[Token(Token = "0x17000737")]
		public bool AnyNeedRefresh
		{
			[Token(Token = "0x6003993")]
			[Address(RVA = "0x1DF6FC8", Offset = "0x1DF6FC8", VA = "0x1DF6FC8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		[Token(Token = "0x17000738")]
		public int TotalMapSections
		{
			[Token(Token = "0x6003994")]
			[Address(RVA = "0x1DF6FDC", Offset = "0x1DF6FDC", VA = "0x1DF6FDC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x1DF6FEC", Offset = "0x1DF6FEC", VA = "0x1DF6FEC")]
		public void SetSectionAsRefreshed(int x, int y)
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x1DF7090", Offset = "0x1DF7090", VA = "0x1DF7090")]
		public bool SectionNeedsRefresh(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x1DF70F0", Offset = "0x1DF70F0", VA = "0x1DF70F0")]
		public void SetAllFramedSectionsAsNeedingRefresh()
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0001D100 File Offset: 0x0001B300
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x1DF7184", Offset = "0x1DF7184", VA = "0x1DF7184")]
		public bool TileLoaded(int tileX, int tileY)
		{
			return default(bool);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0001D118 File Offset: 0x0001B318
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x1DF7258", Offset = "0x1DF7258", VA = "0x1DF7258")]
		public bool SectionLoaded(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0001D130 File Offset: 0x0001B330
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x1DF72B8", Offset = "0x1DF72B8", VA = "0x1DF72B8")]
		public bool SectionFramed(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0001D148 File Offset: 0x0001B348
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x1DF7318", Offset = "0x1DF7318", VA = "0x1DF7318")]
		public bool MapSectionDrawn(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x1DF7378", Offset = "0x1DF7378", VA = "0x1DF7378")]
		public void ClearMapDraw()
		{
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x1DF743C", Offset = "0x1DF743C", VA = "0x1DF743C")]
		public void SetSectionFramed(int x, int y)
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x1DF751C", Offset = "0x1DF751C", VA = "0x1DF751C")]
		public void SetSectionLoaded(int x, int y)
		{
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x1DF75D0", Offset = "0x1DF75D0", VA = "0x1DF75D0")]
		private void SetSectionLoaded(ref BitsByte section)
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x1DF7640", Offset = "0x1DF7640", VA = "0x1DF7640")]
		public void SetAllSectionsLoaded()
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x1DF76EC", Offset = "0x1DF76EC", VA = "0x1DF76EC")]
		public void SetTilesLoaded(int startX, int startY, int endXInclusive, int endYInclusive)
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0001D160 File Offset: 0x0001B360
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x1DF77DC", Offset = "0x1DF77DC", VA = "0x1DF77DC")]
		public bool GetNextMapDraw(Vector2 playerPos, out int x, out int y)
		{
			return default(bool);
		}

		// Token: 0x040045A5 RID: 17829
		[Token(Token = "0x40045A5")]
		public const int BitIndex_SectionLoaded = 0;

		// Token: 0x040045A6 RID: 17830
		[Token(Token = "0x40045A6")]
		public const int BitIndex_SectionFramed = 1;

		// Token: 0x040045A7 RID: 17831
		[Token(Token = "0x40045A7")]
		public const int BitIndex_SectionMapDrawn = 2;

		// Token: 0x040045A8 RID: 17832
		[Token(Token = "0x40045A8")]
		public const int BitIndex_SectionNeedsRefresh = 3;

		// Token: 0x040045A9 RID: 17833
		[Token(Token = "0x40045A9")]
		[FieldOffset(Offset = "0x8")]
		private int width;

		// Token: 0x040045AA RID: 17834
		[Token(Token = "0x40045AA")]
		[FieldOffset(Offset = "0xC")]
		private int height;

		// Token: 0x040045AB RID: 17835
		[Token(Token = "0x40045AB")]
		[FieldOffset(Offset = "0x10")]
		private BitsByte[] data;

		// Token: 0x040045AC RID: 17836
		[Token(Token = "0x40045AC")]
		[FieldOffset(Offset = "0x14")]
		public int mapSectionsLeft;

		// Token: 0x040045AD RID: 17837
		[Token(Token = "0x40045AD")]
		[FieldOffset(Offset = "0x18")]
		public int frameSectionsLeft;

		// Token: 0x040045AE RID: 17838
		[Token(Token = "0x40045AE")]
		[FieldOffset(Offset = "0x1C")]
		private int _sectionsNeedingRefresh;

		// Token: 0x040045AF RID: 17839
		[Token(Token = "0x40045AF")]
		[FieldOffset(Offset = "0x20")]
		public IEnumerator CurrentMapSection;

		// Token: 0x040045B0 RID: 17840
		[Token(Token = "0x40045B0")]
		[FieldOffset(Offset = "0x24")]
		private WorldSections.IterationState prevFrame;

		// Token: 0x040045B1 RID: 17841
		[Token(Token = "0x40045B1")]
		[FieldOffset(Offset = "0x40")]
		private WorldSections.IterationState prevMap;

		// Token: 0x02000537 RID: 1335
		[Token(Token = "0x2000537")]
		private struct IterationState
		{
			// Token: 0x060039A3 RID: 14755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A3")]
			[Address(RVA = "0x1DF6F60", Offset = "0x1DF6F60", VA = "0x1DF6F60")]
			public void Reset()
			{
			}

			// Token: 0x040045B2 RID: 17842
			[Token(Token = "0x40045B2")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 centerPos;

			// Token: 0x040045B3 RID: 17843
			[Token(Token = "0x40045B3")]
			[FieldOffset(Offset = "0x8")]
			public int X;

			// Token: 0x040045B4 RID: 17844
			[Token(Token = "0x40045B4")]
			[FieldOffset(Offset = "0xC")]
			public int Y;

			// Token: 0x040045B5 RID: 17845
			[Token(Token = "0x40045B5")]
			[FieldOffset(Offset = "0x10")]
			public int leg;

			// Token: 0x040045B6 RID: 17846
			[Token(Token = "0x40045B6")]
			[FieldOffset(Offset = "0x14")]
			public int xDir;

			// Token: 0x040045B7 RID: 17847
			[Token(Token = "0x40045B7")]
			[FieldOffset(Offset = "0x18")]
			public int yDir;
		}
	}
}
