using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	public class Framing
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x189F870", Offset = "0x189F870", VA = "0x189F870")]
		public static void Initialize()
		{
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000172C8 File Offset: 0x000154C8
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x18A0B54", Offset = "0x18A0B54", VA = "0x18A0B54")]
		private static Framing.BlockStyle FindBlockStyle(Tile blockTile)
		{
			return default(Framing.BlockStyle);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x18A064C", Offset = "0x18A064C", VA = "0x18A064C")]
		public static void Add8WayLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y)
		{
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x18A07E0", Offset = "0x18A07E0", VA = "0x18A07E0")]
		public static void Add8WayLookup(int lookup, short x, short y)
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x18A097C", Offset = "0x18A097C", VA = "0x18A097C")]
		public static void AddWallFrameLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y, short point4X, short point4Y)
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000172E0 File Offset: 0x000154E0
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x18A0C04", Offset = "0x18A0C04", VA = "0x18A0C04")]
		private static bool WillItBlend(ushort myType, ushort otherType)
		{
			return default(bool);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x18A0D9C", Offset = "0x18A0D9C", VA = "0x18A0D9C")]
		public static void SelfFrame8Way(int i, int j, Tile centerTile, bool resetFrame)
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x18A281C", Offset = "0x18A281C", VA = "0x18A281C")]
		public static void WallFrame(int i, int j, bool resetFrame = false)
		{
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x000172F8 File Offset: 0x000154F8
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x18A32D4", Offset = "0x18A32D4", VA = "0x18A32D4")]
		public static Tile GetTileSafely(Vector2 position)
		{
			return default(Tile);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00017310 File Offset: 0x00015510
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x18A3398", Offset = "0x18A3398", VA = "0x18A3398")]
		public static Tile GetTileSafely(Point pt)
		{
			return default(Tile);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00017328 File Offset: 0x00015528
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x18A339C", Offset = "0x18A339C", VA = "0x18A339C")]
		public static Tile GetTileSafely(Point16 pt)
		{
			return default(Tile);
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00017340 File Offset: 0x00015540
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x18A26F8", Offset = "0x18A26F8", VA = "0x18A26F8")]
		public static Tile GetTileSafely(int i, int j)
		{
			return default(Tile);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x18A33AC", Offset = "0x18A33AC", VA = "0x18A33AC")]
		public Framing()
		{
		}

		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x0")]
		private static Point16[][] selfFrame8WayLookup;

		// Token: 0x04003F51 RID: 16209
		[Token(Token = "0x4003F51")]
		[FieldOffset(Offset = "0x4")]
		private static Point16[][] wallFrameLookup;

		// Token: 0x04003F52 RID: 16210
		[Token(Token = "0x4003F52")]
		[FieldOffset(Offset = "0x8")]
		private static Point16 frameSize8Way;

		// Token: 0x04003F53 RID: 16211
		[Token(Token = "0x4003F53")]
		[FieldOffset(Offset = "0xC")]
		private static Point16 wallFrameSize;

		// Token: 0x04003F54 RID: 16212
		[Token(Token = "0x4003F54")]
		[FieldOffset(Offset = "0x10")]
		private static Framing.BlockStyle[] blockStyleLookup;

		// Token: 0x04003F55 RID: 16213
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x14")]
		private static int[][] phlebasTileFrameNumberLookup;

		// Token: 0x04003F56 RID: 16214
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x18")]
		private static int[][] lazureTileFrameNumberLookup;

		// Token: 0x04003F57 RID: 16215
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x1C")]
		private static int[][] centerWallFrameLookup;

		// Token: 0x020004C3 RID: 1219
		[Token(Token = "0x20004C3")]
		private struct BlockStyle
		{
			// Token: 0x06002FC5 RID: 12229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002FC5")]
			[Address(RVA = "0x18A0964", Offset = "0x18A0964", VA = "0x18A0964")]
			public BlockStyle(bool up, bool down, bool left, bool right)
			{
			}

			// Token: 0x06002FC6 RID: 12230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002FC6")]
			[Address(RVA = "0x18A2810", Offset = "0x18A2810", VA = "0x18A2810")]
			public void Clear()
			{
			}

			// Token: 0x04003F58 RID: 16216
			[Token(Token = "0x4003F58")]
			[FieldOffset(Offset = "0x0")]
			public bool top;

			// Token: 0x04003F59 RID: 16217
			[Token(Token = "0x4003F59")]
			[FieldOffset(Offset = "0x1")]
			public bool bottom;

			// Token: 0x04003F5A RID: 16218
			[Token(Token = "0x4003F5A")]
			[FieldOffset(Offset = "0x2")]
			public bool left;

			// Token: 0x04003F5B RID: 16219
			[Token(Token = "0x4003F5B")]
			[FieldOffset(Offset = "0x3")]
			public bool right;
		}
	}
}
