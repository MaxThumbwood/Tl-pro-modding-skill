using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	internal static class DeepStructCloning<T> where T : struct
	{
		// Token: 0x06003D1D RID: 15645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1D")]
		public static T CloneStruct(T source, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1E")]
		public static T RestoreStruct(T backup, T current, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x0400480C RID: 18444
		[Token(Token = "0x400480C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly StructTypeInfo Info;

		// Token: 0x0400480D RID: 18445
		[Token(Token = "0x400480D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CloneStructChildren<T> CloneChildren;

		// Token: 0x0400480E RID: 18446
		[Token(Token = "0x400480E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RestoreStructChildren<T> RestoreChildren;

		// Token: 0x02000610 RID: 1552
		[Token(Token = "0x2000610")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003D20 RID: 15648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D20")]
			public <>c()
			{
			}

			// Token: 0x06003D21 RID: 15649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D21")]
			internal void <.cctor>b__3_0(ref T clone, DeepCloneContext ctx)
			{
			}

			// Token: 0x06003D22 RID: 15650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D22")]
			internal void <.cctor>b__3_1(ref T clone, ref T current, DeepCloneContext ctx)
			{
			}

			// Token: 0x0400480F RID: 18447
			[Token(Token = "0x400480F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepStructCloning<T>.<>c <>9;
		}
	}
}
