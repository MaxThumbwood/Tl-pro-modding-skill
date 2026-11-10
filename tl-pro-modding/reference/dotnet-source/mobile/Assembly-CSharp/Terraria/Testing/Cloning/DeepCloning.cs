using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	public static class DeepCloning
	{
		// Token: 0x06003CB1 RID: 15537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB1")]
		public static T Clone<T>(T source, [Optional] DeepCloneContext ctx) where T : class
		{
			return null;
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB2")]
		public static T Restore<T>(T backup, T current, [Optional] DeepCloneContext ctx) where T : class
		{
			return null;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB3")]
		public static T CloneStruct<T>(T source, [Optional] DeepCloneContext ctx) where T : struct
		{
			return null;
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB4")]
		public static T RestoreStruct<T>(T backup, T current, [Optional] DeepCloneContext ctx) where T : struct
		{
			return null;
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB5")]
		public static void CloneChildren<T>(T clone, [Optional] DeepCloneContext ctx) where T : class
		{
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB6")]
		public static void CloneChildren<T>(ref T clone, [Optional] DeepCloneContext ctx) where T : struct
		{
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB7")]
		public static void RestoreChildren<T>(T clone, T current, [Optional] DeepCloneContext ctx) where T : class
		{
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB8")]
		public static void RestoreChildren<T>(ref T clone, ref T current, [Optional] DeepCloneContext ctx) where T : struct
		{
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB9")]
		public static void AddImmutableType<T>()
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x1E5F1D0", Offset = "0x1E5F1D0", VA = "0x1E5F1D0")]
		public static void AddImmutableType(Type type)
		{
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBB")]
		public static void AddPrivateFieldsUniqueType<T>()
		{
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x1E5F328", Offset = "0x1E5F328", VA = "0x1E5F328")]
		public static void AddPrivateFieldsUniqueType(Type type)
		{
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x1E5C890", Offset = "0x1E5C890", VA = "0x1E5C890")]
		internal static ClassTypeInfo FreezeClassInfo(Type t)
		{
			return null;
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x1E5F480", Offset = "0x1E5F480", VA = "0x1E5F480")]
		internal static ClassTypeConfig GetClassConfig(Type t, bool unfrozenOnly = true)
		{
			return null;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x0001E780 File Offset: 0x0001C980
		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x1E5C1AC", Offset = "0x1E5C1AC", VA = "0x1E5C1AC")]
		internal static bool NeedsFieldClone(FieldInfo field)
		{
			return default(bool);
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0001E798 File Offset: 0x0001C998
		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x1E5EA34", Offset = "0x1E5EA34", VA = "0x1E5EA34")]
		internal static bool NeedsDynamicClone(Type type)
		{
			return default(bool);
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x1E5F7CC", Offset = "0x1E5F7CC", VA = "0x1E5F7CC")]
		internal static StructTypeInfo FreezeStructInfo(Type t)
		{
			return null;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x1E5FA0C", Offset = "0x1E5FA0C", VA = "0x1E5FA0C")]
		private static IEnumerable<Type> DirectAncestors(Type type)
		{
			return null;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x1E5E97C", Offset = "0x1E5E97C", VA = "0x1E5E97C")]
		internal static IEnumerable<Type> AncestorConfigTypes(Type type)
		{
			return null;
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x1E5C0F4", Offset = "0x1E5C0F4", VA = "0x1E5C0F4")]
		internal static IEnumerable<FieldInfo> GetAllInstanceFields(Type type)
		{
			return null;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x1E5D720", Offset = "0x1E5D720", VA = "0x1E5D720")]
		public static string DebugTypeName(Type type)
		{
			return null;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC6")]
		public static T ShallowClone<T>(T obj) where T : class
		{
			return null;
		}

		// Token: 0x040047D2 RID: 18386
		[Token(Token = "0x40047D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DiagnosticsEnabled;

		// Token: 0x040047D3 RID: 18387
		[Token(Token = "0x40047D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly object _lock;

		// Token: 0x040047D4 RID: 18388
		[Token(Token = "0x40047D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, ClassTypeConfig> _classConfig;

		// Token: 0x040047D5 RID: 18389
		[Token(Token = "0x40047D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly Dictionary<Type, StructTypeInfo> _structInfo;

		// Token: 0x040047D6 RID: 18390
		[Token(Token = "0x40047D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Func<object, object> _memberwiseClone;

		// Token: 0x020005FF RID: 1535
		[Token(Token = "0x20005FF")]
		private sealed class <DirectAncestors>d__22 : FileAPI, GUIControllerItem, GUIControllerItem, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x06003CC7 RID: 15559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CC7")]
			[Address(RVA = "0x1E5FAC4", Offset = "0x1E5FAC4", VA = "0x1E5FAC4")]
			public <DirectAncestors>d__22(int <>1__state)
			{
			}

			// Token: 0x06003CC8 RID: 15560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CC8")]
			[Address(RVA = "0x1E5FB3C", Offset = "0x1E5FB3C", VA = "0x1E5FB3C", Slot = "7")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x06003CC9 RID: 15561 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0x1E5FB40", Offset = "0x1E5FB40", VA = "0x1E5FB40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A2")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x6003CCA")]
				[Address(RVA = "0x1E5FCE0", Offset = "0x1E5FCE0", VA = "0x1E5FCE0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CCB RID: 15563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CCB")]
			[Address(RVA = "0x1E5FCE8", Offset = "0x1E5FCE8", VA = "0x1E5FCE8", Slot = "10")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06003CCC RID: 15564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6003CCC")]
				[Address(RVA = "0x1E5FD34", Offset = "0x1E5FD34", VA = "0x1E5FD34", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CCD RID: 15565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CCD")]
			[Address(RVA = "0x1E5FD3C", Offset = "0x1E5FD3C", VA = "0x1E5FD3C", Slot = "4")]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06003CCE RID: 15566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CCE")]
			[Address(RVA = "0x1E5FDF8", Offset = "0x1E5FDF8", VA = "0x1E5FDF8", Slot = "5")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x040047D7 RID: 18391
			[Token(Token = "0x40047D7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040047D8 RID: 18392
			[Token(Token = "0x40047D8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private Type <>2__current;

			// Token: 0x040047D9 RID: 18393
			[Token(Token = "0x40047D9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			// Token: 0x040047DA RID: 18394
			[Token(Token = "0x40047DA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Type type;

			// Token: 0x040047DB RID: 18395
			[Token(Token = "0x40047DB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type <>3__type;

			// Token: 0x040047DC RID: 18396
			[Token(Token = "0x40047DC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Type[] <>7__wrap1;

			// Token: 0x040047DD RID: 18397
			[Token(Token = "0x40047DD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>7__wrap2;
		}

		// Token: 0x02000600 RID: 1536
		[Token(Token = "0x2000600")]
		private sealed class <AncestorConfigTypes>d__23 : FileAPI, GUIControllerItem, GUIControllerItem, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x06003CCF RID: 15567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CCF")]
			[Address(RVA = "0x1E5FAEC", Offset = "0x1E5FAEC", VA = "0x1E5FAEC")]
			public <AncestorConfigTypes>d__23(int <>1__state)
			{
			}

			// Token: 0x06003CD0 RID: 15568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD0")]
			[Address(RVA = "0x1E5FDFC", Offset = "0x1E5FDFC", VA = "0x1E5FDFC", Slot = "7")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x06003CD1 RID: 15569 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
			[Token(Token = "0x6003CD1")]
			[Address(RVA = "0x1E5FECC", Offset = "0x1E5FECC", VA = "0x1E5FECC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06003CD2 RID: 15570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD2")]
			[Address(RVA = "0x1E604E4", Offset = "0x1E604E4", VA = "0x1E604E4")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A4")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x6003CD3")]
				[Address(RVA = "0x1E605A4", Offset = "0x1E605A4", VA = "0x1E605A4", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CD4 RID: 15572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD4")]
			[Address(RVA = "0x1E605AC", Offset = "0x1E605AC", VA = "0x1E605AC", Slot = "10")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6003CD5")]
				[Address(RVA = "0x1E605F8", Offset = "0x1E605F8", VA = "0x1E605F8", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CD6 RID: 15574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CD6")]
			[Address(RVA = "0x1E60600", Offset = "0x1E60600", VA = "0x1E60600", Slot = "4")]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06003CD7 RID: 15575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CD7")]
			[Address(RVA = "0x1E606BC", Offset = "0x1E606BC", VA = "0x1E606BC", Slot = "5")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x040047DE RID: 18398
			[Token(Token = "0x40047DE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040047DF RID: 18399
			[Token(Token = "0x40047DF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private Type <>2__current;

			// Token: 0x040047E0 RID: 18400
			[Token(Token = "0x40047E0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			// Token: 0x040047E1 RID: 18401
			[Token(Token = "0x40047E1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Type type;

			// Token: 0x040047E2 RID: 18402
			[Token(Token = "0x40047E2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type <>3__type;

			// Token: 0x040047E3 RID: 18403
			[Token(Token = "0x40047E3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private IEnumerator<Type> <>7__wrap1;
		}

		// Token: 0x02000601 RID: 1537
		[Token(Token = "0x2000601")]
		private sealed class <GetAllInstanceFields>d__24 : FileAPI, GUIControllerItem, GUIControllerItem, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x06003CD8 RID: 15576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD8")]
			[Address(RVA = "0x1E5FB14", Offset = "0x1E5FB14", VA = "0x1E5FB14")]
			public <GetAllInstanceFields>d__24(int <>1__state)
			{
			}

			// Token: 0x06003CD9 RID: 15577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x1E606C0", Offset = "0x1E606C0", VA = "0x1E606C0", Slot = "7")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x06003CDA RID: 15578 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x1E606C4", Offset = "0x1E606C4", VA = "0x1E606C4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A6")]
			private FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current
			{
				[Token(Token = "0x6003CDB")]
				[Address(RVA = "0x1E608A4", Offset = "0x1E608A4", VA = "0x1E608A4", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CDC RID: 15580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CDC")]
			[Address(RVA = "0x1E608AC", Offset = "0x1E608AC", VA = "0x1E608AC", Slot = "10")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6003CDD")]
				[Address(RVA = "0x1E608F8", Offset = "0x1E608F8", VA = "0x1E608F8", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003CDE RID: 15582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CDE")]
			[Address(RVA = "0x1E60900", Offset = "0x1E60900", VA = "0x1E60900", Slot = "4")]
			private IEnumerator<FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06003CDF RID: 15583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CDF")]
			[Address(RVA = "0x1E609BC", Offset = "0x1E609BC", VA = "0x1E609BC", Slot = "5")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x040047E4 RID: 18404
			[Token(Token = "0x40047E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040047E5 RID: 18405
			[Token(Token = "0x40047E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private FieldInfo <>2__current;

			// Token: 0x040047E6 RID: 18406
			[Token(Token = "0x40047E6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			// Token: 0x040047E7 RID: 18407
			[Token(Token = "0x40047E7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Type type;

			// Token: 0x040047E8 RID: 18408
			[Token(Token = "0x40047E8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type <>3__type;

			// Token: 0x040047E9 RID: 18409
			[Token(Token = "0x40047E9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private BindingFlags <flags>5__2;

			// Token: 0x040047EA RID: 18410
			[Token(Token = "0x40047EA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Type <t>5__3;

			// Token: 0x040047EB RID: 18411
			[Token(Token = "0x40047EB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private FieldInfo[] <>7__wrap3;

			// Token: 0x040047EC RID: 18412
			[Token(Token = "0x40047EC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <>7__wrap4;
		}

		// Token: 0x02000602 RID: 1538
		[Token(Token = "0x2000602")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003CE1 RID: 15585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CE1")]
			[Address(RVA = "0x1E60A34", Offset = "0x1E60A34", VA = "0x1E60A34")]
			public <>c()
			{
			}

			// Token: 0x06003CE2 RID: 15586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CE2")]
			[Address(RVA = "0x1E60A3C", Offset = "0x1E60A3C", VA = "0x1E60A3C")]
			internal string <DebugTypeName>b__25_0(Type t)
			{
				return null;
			}

			// Token: 0x040047ED RID: 18413
			[Token(Token = "0x40047ED")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DeepCloning.<>c <>9;

			// Token: 0x040047EE RID: 18414
			[Token(Token = "0x40047EE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<Type, string> <>9__25_0;
		}
	}
}
