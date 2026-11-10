using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E33 RID: 3635
	[Token(Token = "0x2000E33")]
	[Serializable]
	public class MappingException : Exception
	{
		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06006A12 RID: 27154 RVA: 0x00030030 File Offset: 0x0002E230
		// (set) Token: 0x06006A13 RID: 27155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B69")]
		public int ErrorCode
		{
			[Token(Token = "0x6006A12")]
			[Address(RVA = "0xB9461C", Offset = "0xB9461C", VA = "0xB9461C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006A13")]
			[Address(RVA = "0xB94624", Offset = "0xB94624", VA = "0xB94624")]
			private set
			{
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06006A14 RID: 27156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A15 RID: 27157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6A")]
		public string ErrorText
		{
			[Token(Token = "0x6006A14")]
			[Address(RVA = "0xB9462C", Offset = "0xB9462C", VA = "0xB9462C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A15")]
			[Address(RVA = "0xB94634", Offset = "0xB94634", VA = "0xB94634")]
			private set
			{
			}
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A16")]
		[Address(RVA = "0xB9463C", Offset = "0xB9463C", VA = "0xB9463C")]
		internal MappingException()
		{
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A17")]
		[Address(RVA = "0xB946A4", Offset = "0xB946A4", VA = "0xB946A4")]
		internal MappingException(string message)
		{
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A18")]
		[Address(RVA = "0xB94714", Offset = "0xB94714", VA = "0xB94714")]
		internal MappingException(int errorCode, string errorText)
		{
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A19")]
		[Address(RVA = "0xB947F8", Offset = "0xB947F8", VA = "0xB947F8")]
		internal MappingException(string message, Exception innerException)
		{
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0xB94870", Offset = "0xB94870", VA = "0xB94870")]
		protected MappingException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0xB948FC", Offset = "0xB948FC", VA = "0xB948FC", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0400A7A0 RID: 42912
		[Token(Token = "0x400A7A0")]
		[FieldOffset(Offset = "0x48")]
		private int <ErrorCode>k__BackingField;

		// Token: 0x0400A7A1 RID: 42913
		[Token(Token = "0x400A7A1")]
		[FieldOffset(Offset = "0x4C")]
		private string <ErrorText>k__BackingField;
	}
}
