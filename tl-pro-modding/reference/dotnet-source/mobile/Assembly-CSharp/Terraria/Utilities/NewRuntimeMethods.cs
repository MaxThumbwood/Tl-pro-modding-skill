using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x20005D4")]
	public static class NewRuntimeMethods
	{
		// Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x1E16070", Offset = "0x1E16070", VA = "0x1E16070")]
		public static void GC_Collect(int generation, GCCollectionMode mode, bool blocking)
		{
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x0001E360 File Offset: 0x0001C560
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x1E164D8", Offset = "0x1E164D8", VA = "0x1E164D8")]
		public static long GC_GetTotalAllocatedBytes()
		{
			return 0L;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0001E378 File Offset: 0x0001C578
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x1E164E4", Offset = "0x1E164E4", VA = "0x1E164E4")]
		public static TimeSpan GC_GetTotalPauseDuration()
		{
			return default(TimeSpan);
		}

		// Token: 0x04004765 RID: 18277
		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0x0")]
		private static bool IsNet45OrNewer;

		// Token: 0x04004766 RID: 18278
		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0x4")]
		private static MethodInfo _collect;
	}
}
