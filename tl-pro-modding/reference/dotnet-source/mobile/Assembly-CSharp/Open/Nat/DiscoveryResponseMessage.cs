using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E4E RID: 3662
	[Token(Token = "0x2000E4E")]
	internal class DiscoveryResponseMessage
	{
		// Token: 0x06006A93 RID: 27283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0xB9E320", Offset = "0xB9E320", VA = "0xB9E320")]
		public DiscoveryResponseMessage(string message)
		{
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B79")]
		public string Item
		{
			[Token(Token = "0x6006A94")]
			[Address(RVA = "0xB9E97C", Offset = "0xB9E97C", VA = "0xB9E97C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A819 RID: 43033
		[Token(Token = "0x400A819")]
		[FieldOffset(Offset = "0x8")]
		private readonly IDictionary<string, string> _headers;

		// Token: 0x02000E4F RID: 3663
		[Token(Token = "0x2000E4F")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A96 RID: 27286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A96")]
			[Address(RVA = "0xB9EACC", Offset = "0xB9EACC", VA = "0xB9EACC")]
			public <>c()
			{
			}

			// Token: 0x06006A97 RID: 27287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A97")]
			[Address(RVA = "0xB9EAD4", Offset = "0xB9EAD4", VA = "0xB9EAD4")]
			internal <>f__AnonymousType0<string, string[]> <.ctor>b__1_0(string h)
			{
				return null;
			}

			// Token: 0x06006A98 RID: 27288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A98")]
			[Address(RVA = "0xB9EB8C", Offset = "0xB9EB8C", VA = "0xB9EB8C")]
			internal <>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string> <.ctor>b__1_1(<>f__AnonymousType0<string, string[]> <>h__TransparentIdentifier0)
			{
				return null;
			}

			// Token: 0x06006A99 RID: 27289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A99")]
			[Address(RVA = "0xB9EC50", Offset = "0xB9EC50", VA = "0xB9EC50")]
			internal <>f__AnonymousType2<<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>, string> <.ctor>b__1_2(<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string> <>h__TransparentIdentifier1)
			{
				return null;
			}

			// Token: 0x06006A9A RID: 27290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A9A")]
			[Address(RVA = "0xB9EDF8", Offset = "0xB9EDF8", VA = "0xB9EDF8")]
			internal <>f__AnonymousType3<string, string> <.ctor>b__1_3(<>f__AnonymousType2<<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>, string> <>h__TransparentIdentifier2)
			{
				return null;
			}

			// Token: 0x06006A9B RID: 27291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A9B")]
			[Address(RVA = "0xB9EEFC", Offset = "0xB9EEFC", VA = "0xB9EEFC")]
			internal string <.ctor>b__1_4(<>f__AnonymousType3<string, string> x)
			{
				return null;
			}

			// Token: 0x06006A9C RID: 27292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A9C")]
			[Address(RVA = "0xB9EF60", Offset = "0xB9EF60", VA = "0xB9EF60")]
			internal string <.ctor>b__1_5(<>f__AnonymousType3<string, string> x)
			{
				return null;
			}

			// Token: 0x0400A81A RID: 43034
			[Token(Token = "0x400A81A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DiscoveryResponseMessage.<>c <>9;

			// Token: 0x0400A81B RID: 43035
			[Token(Token = "0x400A81B")]
			[FieldOffset(Offset = "0x4")]
			public static Func<string, <>f__AnonymousType0<string, string[]>> <>9__1_0;

			// Token: 0x0400A81C RID: 43036
			[Token(Token = "0x400A81C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<<>f__AnonymousType0<string, string[]>, <>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>> <>9__1_1;

			// Token: 0x0400A81D RID: 43037
			[Token(Token = "0x400A81D")]
			[FieldOffset(Offset = "0xC")]
			public static Func<<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>, <>f__AnonymousType2<<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>, string>> <>9__1_2;

			// Token: 0x0400A81E RID: 43038
			[Token(Token = "0x400A81E")]
			[FieldOffset(Offset = "0x10")]
			public static Func<<>f__AnonymousType2<<>f__AnonymousType1<<>f__AnonymousType0<string, string[]>, string>, string>, <>f__AnonymousType3<string, string>> <>9__1_3;

			// Token: 0x0400A81F RID: 43039
			[Token(Token = "0x400A81F")]
			[FieldOffset(Offset = "0x14")]
			public static Func<<>f__AnonymousType3<string, string>, string> <>9__1_4;

			// Token: 0x0400A820 RID: 43040
			[Token(Token = "0x400A820")]
			[FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType3<string, string>, string> <>9__1_5;
		}
	}
}
