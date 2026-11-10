using System;
using Il2CppDummyDll;
using Ionic.Zlib;

namespace Terraria.Map
{
	// Token: 0x0200081C RID: 2076
	[Token(Token = "0x200081C")]
	public class WorldMapChunk
	{
		// Token: 0x060046E4 RID: 18148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x5A5C40", Offset = "0x5A5C40", VA = "0x5A5C40")]
		public unsafe WorldMapChunk(WorldMap map, byte* compressedData)
		{
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x00021930 File Offset: 0x0001FB30
		[Token(Token = "0x17000875")]
		public bool Loaded
		{
			[Token(Token = "0x60046E5")]
			[Address(RVA = "0x5A7534", Offset = "0x5A7534", VA = "0x5A7534")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x5A4870", Offset = "0x5A4870", VA = "0x5A4870")]
		public void SaveCompressed()
		{
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x5A3EC8", Offset = "0x5A3EC8", VA = "0x5A3EC8")]
		public void LoadTiles(bool utilLoad = false)
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x5A72A8", Offset = "0x5A72A8", VA = "0x5A72A8")]
		public void Reset()
		{
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x5A7544", Offset = "0x5A7544", VA = "0x5A7544")]
		public unsafe void Compress(byte* srcData, long srcLength, out long resultLength)
		{
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x5A7940", Offset = "0x5A7940", VA = "0x5A7940")]
		public unsafe void Decompress(byte[] srcData, long srcLength, byte* dstData, long dstLength, out long resultLength)
		{
		}

		// Token: 0x04008DB9 RID: 36281
		[Token(Token = "0x4008DB9")]
		public const int InitialChunkCompressedSize = 2048;

		// Token: 0x04008DBA RID: 36282
		[Token(Token = "0x4008DBA")]
		public const int MapChunkSize = 64;

		// Token: 0x04008DBB RID: 36283
		[Token(Token = "0x4008DBB")]
		[FieldOffset(Offset = "0x0")]
		public static int MapChunkTileSize;

		// Token: 0x04008DBC RID: 36284
		[Token(Token = "0x4008DBC")]
		[FieldOffset(Offset = "0x8")]
		private readonly WorldMap Map;

		// Token: 0x04008DBD RID: 36285
		[Token(Token = "0x4008DBD")]
		[FieldOffset(Offset = "0xC")]
		public unsafe MapTile* TileData;

		// Token: 0x04008DBE RID: 36286
		[Token(Token = "0x4008DBE")]
		[FieldOffset(Offset = "0x10")]
		public byte[] CompressedData;

		// Token: 0x04008DBF RID: 36287
		[Token(Token = "0x4008DBF")]
		[FieldOffset(Offset = "0x18")]
		public long CompressedDataLength;

		// Token: 0x04008DC0 RID: 36288
		[Token(Token = "0x4008DC0")]
		[FieldOffset(Offset = "0x20")]
		public DateTime LastUsed;

		// Token: 0x04008DC1 RID: 36289
		[Token(Token = "0x4008DC1")]
		[FieldOffset(Offset = "0x28")]
		public int X;

		// Token: 0x04008DC2 RID: 36290
		[Token(Token = "0x4008DC2")]
		[FieldOffset(Offset = "0x2C")]
		public int Y;

		// Token: 0x04008DC3 RID: 36291
		[Token(Token = "0x4008DC3")]
		[FieldOffset(Offset = "0x30")]
		public bool dirty;

		// Token: 0x04008DC4 RID: 36292
		[Token(Token = "0x4008DC4")]
		[FieldOffset(Offset = "0x34")]
		public int frameAge;

		// Token: 0x04008DC5 RID: 36293
		[Token(Token = "0x4008DC5")]
		[FieldOffset(Offset = "0x38")]
		public int referenceCount;

		// Token: 0x04008DC6 RID: 36294
		[Token(Token = "0x4008DC6")]
		[FieldOffset(Offset = "0x4")]
		private static byte[] ClearData;

		// Token: 0x04008DC7 RID: 36295
		[Token(Token = "0x4008DC7")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] resetData;

		// Token: 0x04008DC8 RID: 36296
		[Token(Token = "0x4008DC8")]
		[FieldOffset(Offset = "0xC")]
		private static byte[] CopyBuffer;

		// Token: 0x04008DC9 RID: 36297
		[Token(Token = "0x4008DC9")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] CompressBuffer;

		// Token: 0x04008DCA RID: 36298
		[Token(Token = "0x4008DCA")]
		[FieldOffset(Offset = "0x14")]
		private static byte[] BlockBuffer;

		// Token: 0x04008DCB RID: 36299
		[Token(Token = "0x4008DCB")]
		[FieldOffset(Offset = "0x18")]
		private static ZlibCodec zlibCompress;

		// Token: 0x04008DCC RID: 36300
		[Token(Token = "0x4008DCC")]
		[FieldOffset(Offset = "0x1C")]
		private static ZlibCodec zlibDecompress;

		// Token: 0x04008DCD RID: 36301
		[Token(Token = "0x4008DCD")]
		[FieldOffset(Offset = "0x20")]
		private static long biggestChunk;
	}
}
