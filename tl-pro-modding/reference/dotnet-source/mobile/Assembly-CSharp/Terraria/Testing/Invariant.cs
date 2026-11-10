using System;
using Il2CppDummyDll;

namespace Terraria.Testing
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public static class Invariant
	{
		// Token: 0x06003C45 RID: 15429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C45")]
		[Address(RVA = "0x1E57AC4", Offset = "0x1E57AC4", VA = "0x1E57AC4")]
		public static void Assert(bool condition, string message)
		{
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C46")]
		public static void Assert<T>(bool condition, string format, T arg1)
		{
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C47")]
		public static void Assert<T1, T2>(bool condition, string format, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C48")]
		public static void Assert<T1, T2, T3>(bool condition, string format, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x0400479C RID: 18332
		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x0")]
		public static bool assertionsEnabled;
	}
}
