using System;
using System.Text;
using Il2CppDummyDll;

namespace BCrypt.Net
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	public sealed class BCrypt
	{
		// Token: 0x06001EDF RID: 7903 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0xF0BAD4", Offset = "0xF0BAD4", VA = "0xF0BAD4")]
		private static int Char64(char character)
		{
			return 0;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0xF0BB8C", Offset = "0xF0BB8C", VA = "0xF0BB8C")]
		private void Encipher(uint[] blockArray, int offset)
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0xF0BDE0", Offset = "0xF0BDE0", VA = "0xF0BDE0")]
		private static uint StreamToWord(byte[] data, ref int offset)
		{
			return 0U;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0xF0BE68", Offset = "0xF0BE68", VA = "0xF0BE68")]
		private void InitializeKey()
		{
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0xF0BF90", Offset = "0xF0BF90", VA = "0xF0BF90")]
		private void Key(byte[] keyBytes)
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0xF0C1FC", Offset = "0xF0C1FC", VA = "0xF0C1FC")]
		private void EKSKey(byte[] saltBytes, byte[] inputBytes)
		{
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0xF0C6B8", Offset = "0xF0C6B8", VA = "0xF0C6B8")]
		internal byte[] CryptRaw(byte[] inputBytes, byte[] saltBytes, int workFactor)
		{
			return null;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0xF0CA00", Offset = "0xF0CA00", VA = "0xF0CA00")]
		public BCrypt()
		{
		}

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		private const int DefaultRounds = 11;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		private const int BCryptSaltLen = 16;

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding SafeUTF8;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		private const int BlowfishNumRounds = 16;

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x4")]
		private static readonly uint[] POrig;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] SOrig;

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0xC")]
		private static readonly uint[] BfCryptCiphertext;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x10")]
		private static readonly char[] Base64Code;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int[] Index64;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		private const string EmptyString = "";

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		private const char DefaultHashVersion = 'a';

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		private const string Nul = "\0";

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		private const short MinRounds = 4;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		private const short MaxRounds = 31;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x8")]
		private uint[] _p;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0xC")]
		private uint[] _s;
	}
}
