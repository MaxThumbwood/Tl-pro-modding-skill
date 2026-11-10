using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200033F")]
public class BlowFish
{
	// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001465")]
	[Address(RVA = "0xDC3748", Offset = "0xDC3748", VA = "0xDC3748")]
	public BlowFish()
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001466")]
	[Address(RVA = "0xDC37BC", Offset = "0xDC37BC", VA = "0xDC37BC")]
	private void ROUND(ref BlowFish.aword a, ref BlowFish.aword b, int n)
	{
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001467")]
	[Address(RVA = "0xDC3890", Offset = "0xDC3890", VA = "0xDC3890")]
	private unsafe void Decipher(uint* xl, uint* xr)
	{
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001468")]
	[Address(RVA = "0xDC3A48", Offset = "0xDC3A48", VA = "0xDC3A48")]
	private unsafe void Encipher(uint* xl, uint* xr)
	{
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001469")]
	[Address(RVA = "0xDC3C00", Offset = "0xDC3C00", VA = "0xDC3C00")]
	public void Initialize(byte[] key)
	{
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00009000 File Offset: 0x00007200
	[Token(Token = "0x600146A")]
	[Address(RVA = "0xDC4144", Offset = "0xDC4144", VA = "0xDC4144")]
	private uint GetOutputLength(uint lInputLong)
	{
		return 0U;
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146B")]
	[Address(RVA = "0xDC4158", Offset = "0xDC4158", VA = "0xDC4158")]
	public unsafe void Decode(byte* pInput, byte* pOutput, uint lSize)
	{
	}

	// Token: 0x0400291C RID: 10524
	[Token(Token = "0x400291C")]
	private const int NPASS = 16;

	// Token: 0x0400291D RID: 10525
	[Token(Token = "0x400291D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint[] bf_P;

	// Token: 0x0400291E RID: 10526
	[Token(Token = "0x400291E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static uint[] bf_S;

	// Token: 0x0400291F RID: 10527
	[Token(Token = "0x400291F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private uint[] PArray;

	// Token: 0x04002920 RID: 10528
	[Token(Token = "0x4002920")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private uint[] SBoxes;

	// Token: 0x04002921 RID: 10529
	[Token(Token = "0x4002921")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isInitialized;

	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	[StructLayout(2)]
	private struct aword
	{
		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint dword;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BlowFish.aword.<integer>e__FixedBuffer integer;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte byte3;

		// Token: 0x04002925 RID: 10533
		[Token(Token = "0x4002925")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte byte2;

		// Token: 0x04002926 RID: 10534
		[Token(Token = "0x4002926")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte byte1;

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte byte0;

		// Token: 0x02000341 RID: 833
		[Token(Token = "0x2000341")]
		public struct <integer>e__FixedBuffer
		{
			// Token: 0x04002928 RID: 10536
			[Token(Token = "0x4002928")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
