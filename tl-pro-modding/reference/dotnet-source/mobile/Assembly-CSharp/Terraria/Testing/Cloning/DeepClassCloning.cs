using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	internal static class DeepClassCloning<T> where T : class
	{
		// Token: 0x06003CF5 RID: 15605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF5")]
		public static T CloneRef(T src, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF6")]
		public static T CloneUniqueRef(T src, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF7")]
		private static T CloneRef(T src, DeepCloneContext ctx, bool unique)
		{
			return null;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF8")]
		public static T RestoreRef(T backup, T current, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF9")]
		public static T RestoreUniqueRef(T backup, T current, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFA")]
		private static T RestoreRef(T backup, T current, DeepCloneContext ctx, bool unique = false)
		{
			return null;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFB")]
		public static void CloneChildren(T clone, DeepCloneContext ctx)
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFC")]
		public static void RestoreChildren(T clone, T current, DeepCloneContext ctx)
		{
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFD")]
		private static F GetPolymorphicDispatch<F>(ref ConditionalWeakTable<Type, F> table, string methodName, Type u) where F : class
		{
			return null;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFE")]
		private static Func<T, DeepCloneContext, bool, T> PolymorphicClone<U>() where U : class, T
		{
			return null;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFF")]
		private static Func<T, DeepCloneContext, bool, T> PolymorphicCloneBoxed<U>() where U : struct, T
		{
			return null;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D00")]
		private static Func<T, T, DeepCloneContext, bool, T> PolymorphicRestore<U>() where U : class, T
		{
			return null;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D01")]
		private static Func<T, T, DeepCloneContext, bool, T> PolymorphicRestoreBoxed<U>() where U : struct, T
		{
			return null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D02")]
		private static Action<T, DeepCloneContext> PolymorphicCloneChildren<U>() where U : class, T
		{
			return null;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D03")]
		private static Action<T, T, DeepCloneContext> PolymorphicRestoreChildren<U>() where U : class, T
		{
			return null;
		}

		// Token: 0x040047F7 RID: 18423
		[Token(Token = "0x40047F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ClassTypeInfo Info;

		// Token: 0x040047F8 RID: 18424
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CloneClassChildren<T> _CloneChildren;

		// Token: 0x040047F9 RID: 18425
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RestoreClassChildren<T> _RestoreChildren;

		// Token: 0x040047FA RID: 18426
		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0x0")]
		private static ConditionalWeakTable<Type, Func<T, DeepCloneContext, bool, T>> _polymorphicClone;

		// Token: 0x040047FB RID: 18427
		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0x0")]
		private static ConditionalWeakTable<Type, Func<T, T, DeepCloneContext, bool, T>> _polymorphicRestore;

		// Token: 0x040047FC RID: 18428
		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0x0")]
		private static ConditionalWeakTable<Type, Action<T, DeepCloneContext>> _polymorphicCloneChildren;

		// Token: 0x040047FD RID: 18429
		[Token(Token = "0x40047FD")]
		[FieldOffset(Offset = "0x0")]
		private static ConditionalWeakTable<Type, Action<T, T, DeepCloneContext>> _polymorphicRestoreChildren;

		// Token: 0x02000607 RID: 1543
		[Token(Token = "0x2000607")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003D05 RID: 15621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D05")]
			public <>c()
			{
			}

			// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D06")]
			internal void <.cctor>b__3_0(T clone, DeepCloneContext ctx)
			{
			}

			// Token: 0x06003D07 RID: 15623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D07")]
			internal void <.cctor>b__3_1(T clone, T current, DeepCloneContext ctx)
			{
			}

			// Token: 0x040047FE RID: 18430
			[Token(Token = "0x40047FE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c <>9;
		}

		// Token: 0x02000608 RID: 1544
		[Token(Token = "0x2000608")]
		private sealed class <>c__DisplayClass12_0<F> where F : class
		{
			// Token: 0x06003D08 RID: 15624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D08")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06003D09 RID: 15625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D09")]
			internal F <GetPolymorphicDispatch>b__0(Type key)
			{
				return null;
			}

			// Token: 0x040047FF RID: 18431
			[Token(Token = "0x40047FF")]
			[FieldOffset(Offset = "0x0")]
			public string methodName;
		}

		// Token: 0x02000609 RID: 1545
		[Token(Token = "0x2000609")]
		[Serializable]
		private sealed class <>c__14<U> where U : class, T
		{
			// Token: 0x06003D0B RID: 15627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0B")]
			public <>c__14()
			{
			}

			// Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D0C")]
			internal T <PolymorphicClone>b__14_0(T src, DeepCloneContext ctx, bool unique)
			{
				return null;
			}

			// Token: 0x04004800 RID: 18432
			[Token(Token = "0x4004800")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__14<U> <>9;

			// Token: 0x04004801 RID: 18433
			[Token(Token = "0x4004801")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, DeepCloneContext, bool, T> <>9__14_0;
		}

		// Token: 0x0200060A RID: 1546
		[Token(Token = "0x200060A")]
		[Serializable]
		private sealed class <>c__15<U> where U : struct, T
		{
			// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0E")]
			public <>c__15()
			{
			}

			// Token: 0x06003D0F RID: 15631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D0F")]
			internal T <PolymorphicCloneBoxed>b__15_0(T src, DeepCloneContext ctx, bool unique)
			{
				return null;
			}

			// Token: 0x04004802 RID: 18434
			[Token(Token = "0x4004802")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__15<U> <>9;

			// Token: 0x04004803 RID: 18435
			[Token(Token = "0x4004803")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, DeepCloneContext, bool, T> <>9__15_0;
		}

		// Token: 0x0200060B RID: 1547
		[Token(Token = "0x200060B")]
		[Serializable]
		private sealed class <>c__17<U> where U : class, T
		{
			// Token: 0x06003D11 RID: 15633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D11")]
			public <>c__17()
			{
			}

			// Token: 0x06003D12 RID: 15634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D12")]
			internal T <PolymorphicRestore>b__17_0(T backup, T current, DeepCloneContext ctx, bool unique)
			{
				return null;
			}

			// Token: 0x04004804 RID: 18436
			[Token(Token = "0x4004804")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__17<U> <>9;

			// Token: 0x04004805 RID: 18437
			[Token(Token = "0x4004805")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, T, DeepCloneContext, bool, T> <>9__17_0;
		}

		// Token: 0x0200060C RID: 1548
		[Token(Token = "0x200060C")]
		[Serializable]
		private sealed class <>c__18<U> where U : struct, T
		{
			// Token: 0x06003D14 RID: 15636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D14")]
			public <>c__18()
			{
			}

			// Token: 0x06003D15 RID: 15637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D15")]
			internal T <PolymorphicRestoreBoxed>b__18_0(T backup, T current, DeepCloneContext ctx, bool unique)
			{
				return null;
			}

			// Token: 0x04004806 RID: 18438
			[Token(Token = "0x4004806")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__18<U> <>9;

			// Token: 0x04004807 RID: 18439
			[Token(Token = "0x4004807")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, T, DeepCloneContext, bool, T> <>9__18_0;
		}

		// Token: 0x0200060D RID: 1549
		[Token(Token = "0x200060D")]
		[Serializable]
		private sealed class <>c__20<U> where U : class, T
		{
			// Token: 0x06003D17 RID: 15639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D17")]
			public <>c__20()
			{
			}

			// Token: 0x06003D18 RID: 15640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D18")]
			internal void <PolymorphicCloneChildren>b__20_0(T clone, DeepCloneContext ctx)
			{
			}

			// Token: 0x04004808 RID: 18440
			[Token(Token = "0x4004808")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__20<U> <>9;

			// Token: 0x04004809 RID: 18441
			[Token(Token = "0x4004809")]
			[FieldOffset(Offset = "0x0")]
			public static Action<T, DeepCloneContext> <>9__20_0;
		}

		// Token: 0x0200060E RID: 1550
		[Token(Token = "0x200060E")]
		[Serializable]
		private sealed class <>c__22<U> where U : class, T
		{
			// Token: 0x06003D1A RID: 15642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D1A")]
			public <>c__22()
			{
			}

			// Token: 0x06003D1B RID: 15643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D1B")]
			internal void <PolymorphicRestoreChildren>b__22_0(T clone, T current, DeepCloneContext ctx)
			{
			}

			// Token: 0x0400480A RID: 18442
			[Token(Token = "0x400480A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepClassCloning<T>.<>c__22<U> <>9;

			// Token: 0x0400480B RID: 18443
			[Token(Token = "0x400480B")]
			[FieldOffset(Offset = "0x0")]
			public static Action<T, T, DeepCloneContext> <>9__22_0;
		}
	}
}
