using System;
using Il2CppDummyDll;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000074")]
public static class FileCompressor
{
	// Token: 0x06000280 RID: 640 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x4B67A4", Offset = "0x4B67A4", VA = "0x4B67A4")]
	private static bool CanCompress(string filename)
	{
		return default(bool);
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x4B6894", Offset = "0x4B6894", VA = "0x4B6894")]
	private static bool HasCompressionHeader(byte[] inputData, out int decompressedLength)
	{
		return default(bool);
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x4B6988", Offset = "0x4B6988", VA = "0x4B6988")]
	private static byte[] Decompress(byte[] inputData, int outputSize)
	{
		return null;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x4B6BD0", Offset = "0x4B6BD0", VA = "0x4B6BD0")]
	private static byte[] Compress(byte[] inputData, int fileLength)
	{
		return null;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x4B6E74", Offset = "0x4B6E74", VA = "0x4B6E74")]
	public static byte[] CompressFile(string filename, byte[] inputFile, ref int fileLength)
	{
		return null;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x4B6F50", Offset = "0x4B6F50", VA = "0x4B6F50")]
	public static byte[] DecompressFile(string filename, byte[] inputFile)
	{
		return null;
	}

	// Token: 0x04000492 RID: 1170
	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x0")]
	public static bool Disable;
}
