using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	internal static class DeepCloneCodegen
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7C")]
		internal static void GenerateClassDelegates<T>(ClassTypeInfo selfInfo, out CloneClassChildren<T> cloneChildren, out RestoreClassChildren<T> restoreChildren) where T : class
		{
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7D")]
		internal static void GenerateStructDelegates<T>(out CloneStructChildren<T> cloneChildren, out RestoreStructChildren<T> restoreChildren) where T : struct
		{
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7E")]
		internal static void GetArrayDelegates<T>(Type elemType, out CloneClassChildren<T> cloneChildren, out RestoreClassChildren<T> restoreChildren) where T : class
		{
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x1E5B1DC", Offset = "0x1E5B1DC", VA = "0x1E5B1DC")]
		private static DynamicMethod BuildCloneChildrenDynamicMethod(Type type, Type[] paramTypes, bool uniqueRef)
		{
			return null;
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x1E5B448", Offset = "0x1E5B448", VA = "0x1E5B448")]
		private static void EmitCloneChildrenForType(LoggingILGenerator il, Type type, bool uniqueRef, [Optional] List<FieldInfo> path)
		{
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x1E5C2AC", Offset = "0x1E5C2AC", VA = "0x1E5C2AC")]
		private static void EmitFieldCloneChildren(LoggingILGenerator il, FieldInfo leaf, bool uniqueRef, List<FieldInfo> path)
		{
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x1E5C5EC", Offset = "0x1E5C5EC", VA = "0x1E5C5EC")]
		private static void EmitCloneCall(LoggingILGenerator il, Type ft, bool uniqueRef)
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x1E5CBBC", Offset = "0x1E5CBBC", VA = "0x1E5CBBC")]
		private static DynamicMethod BuildRestoreChildrenDynamicMethod(Type type, Type[] paramTypes, bool uniqueRef)
		{
			return null;
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x1E5CE28", Offset = "0x1E5CE28", VA = "0x1E5CE28")]
		private static void EmitRestoreChildrenForType(LoggingILGenerator il, Type type, bool uniqueRef, [Optional] List<FieldInfo> path)
		{
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C85")]
		[Address(RVA = "0x1E5D94C", Offset = "0x1E5D94C", VA = "0x1E5D94C")]
		private static void EmitFieldRestoreChildren(LoggingILGenerator il, FieldInfo leaf, bool uniqueRef, List<FieldInfo> path)
		{
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x1E5DE38", Offset = "0x1E5DE38", VA = "0x1E5DE38")]
		private static void EmitRestoreCall(LoggingILGenerator il, Type ft, bool uniqueRef)
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C87")]
		private static void CloneClassElements<E>(E[] clone, DeepCloneContext ctx) where E : class
		{
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C88")]
		private static void CloneStructElements<E>(E[] clone, DeepCloneContext ctx) where E : struct
		{
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C89")]
		private static void RestoreClassElements<E>(E[] clone, E[] current, DeepCloneContext ctx) where E : class
		{
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8A")]
		private static void RestoreStructElements<E>(E[] clone, E[] current, DeepCloneContext ctx) where E : struct
		{
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8B")]
		private static void CloneClassElements2D<E>(E[,] clone, DeepCloneContext ctx) where E : class
		{
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8C")]
		private static void CloneStructElements2D<E>(E[,] clone, DeepCloneContext ctx) where E : struct
		{
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8D")]
		private static void RestoreClassElements2D<E>(E[,] clone, E[,] current, DeepCloneContext ctx) where E : class
		{
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8E")]
		private static void RestoreStructElements2D<E>(E[,] clone, E[,] current, DeepCloneContext ctx) where E : struct
		{
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x1E5BE38", Offset = "0x1E5BE38", VA = "0x1E5BE38")]
		private static void WriteILLog(Type type, string variant, string log)
		{
		}

		// Token: 0x040047C1 RID: 18369
		[Token(Token = "0x40047C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MethodInfo _memberwiseCloneMethod;

		// Token: 0x020005F4 RID: 1524
		[Token(Token = "0x20005F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C92 RID: 15506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C92")]
			[Address(RVA = "0x1E5E274", Offset = "0x1E5E274", VA = "0x1E5E274")]
			public <>c()
			{
			}

			// Token: 0x06003C93 RID: 15507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C93")]
			[Address(RVA = "0x1E5E27C", Offset = "0x1E5E27C", VA = "0x1E5E27C")]
			internal string <EmitCloneChildrenForType>b__5_0(FieldInfo f)
			{
				return null;
			}

			// Token: 0x06003C94 RID: 15508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C94")]
			[Address(RVA = "0x1E5E2A8", Offset = "0x1E5E2A8", VA = "0x1E5E2A8")]
			internal string <EmitRestoreChildrenForType>b__9_0(FieldInfo f)
			{
				return null;
			}

			// Token: 0x040047C2 RID: 18370
			[Token(Token = "0x40047C2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DeepCloneCodegen.<>c <>9;

			// Token: 0x040047C3 RID: 18371
			[Token(Token = "0x40047C3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<FieldInfo, string> <>9__5_0;

			// Token: 0x040047C4 RID: 18372
			[Token(Token = "0x40047C4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<FieldInfo, string> <>9__9_0;
		}
	}
}
