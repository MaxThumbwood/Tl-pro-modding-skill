using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	public sealed class DeepCloneContext
	{
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
		[Token(Token = "0x170007A8")]
		public bool IsBackup
		{
			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x1E60AA0", Offset = "0x1E60AA0", VA = "0x1E60AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x1E60AA8", Offset = "0x1E60AA8", VA = "0x1E60AA8")]
		public DeepCloneContext(bool isBackup = false)
		{
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE5")]
		internal void AddClone<T>(T src, T clone) where T : class
		{
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0001E810 File Offset: 0x0001CA10
		[Token(Token = "0x6003CE6")]
		internal bool TryGetClone<T>(T src, out T clone) where T : class
		{
			return default(bool);
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x1E60B88", Offset = "0x1E60B88", VA = "0x1E60B88")]
		public void DumpMap()
		{
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x0001E828 File Offset: 0x0001CA28
		[Token(Token = "0x6003CE8")]
		internal bool TryQuickClone<T>(T src, out T clone) where T : class
		{
			return default(bool);
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0001E840 File Offset: 0x0001CA40
		[Token(Token = "0x6003CE9")]
		internal bool TryQuickRestore<T>(T backup, T current, out T clone) where T : class
		{
			return default(bool);
		}

		// Token: 0x040047EF RID: 18415
		[Token(Token = "0x40047EF")]
		[FieldOffset(Offset = "0x8")]
		private readonly bool _isBackup;

		// Token: 0x040047F0 RID: 18416
		[Token(Token = "0x40047F0")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<object, object> Map;

		// Token: 0x02000604 RID: 1540
		[Token(Token = "0x2000604")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CEB")]
			[Address(RVA = "0x1E61150", Offset = "0x1E61150", VA = "0x1E61150")]
			public <>c()
			{
			}

			// Token: 0x06003CEC RID: 15596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CEC")]
			[Address(RVA = "0x1E61158", Offset = "0x1E61158", VA = "0x1E61158")]
			internal Type <DumpMap>b__7_0(object k)
			{
				return null;
			}

			// Token: 0x06003CED RID: 15597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CED")]
			[Address(RVA = "0x1E6117C", Offset = "0x1E6117C", VA = "0x1E6117C")]
			internal Type <DumpMap>b__7_1(Type t)
			{
				return null;
			}

			// Token: 0x06003CEE RID: 15598 RVA: 0x0001E858 File Offset: 0x0001CA58
			[Token(Token = "0x6003CEE")]
			[Address(RVA = "0x1E61184", Offset = "0x1E61184", VA = "0x1E61184")]
			internal int <DumpMap>b__7_2(IGrouping<Type, Type> g)
			{
				return 0;
			}

			// Token: 0x06003CEF RID: 15599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CEF")]
			[Address(RVA = "0x1E611D8", Offset = "0x1E611D8", VA = "0x1E611D8")]
			internal string <DumpMap>b__7_3(IGrouping<Type, Type> g)
			{
				return null;
			}

			// Token: 0x040047F1 RID: 18417
			[Token(Token = "0x40047F1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepCloneContext.<>c <>9;

			// Token: 0x040047F2 RID: 18418
			[Token(Token = "0x40047F2")]
			[FieldOffset(Offset = "0x4")]
			public static Func<object, Type> <>9__7_0;

			// Token: 0x040047F3 RID: 18419
			[Token(Token = "0x40047F3")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Type, Type> <>9__7_1;

			// Token: 0x040047F4 RID: 18420
			[Token(Token = "0x40047F4")]
			[FieldOffset(Offset = "0xC")]
			public static Func<IGrouping<Type, Type>, int> <>9__7_2;

			// Token: 0x040047F5 RID: 18421
			[Token(Token = "0x40047F5")]
			[FieldOffset(Offset = "0x10")]
			public static Func<IGrouping<Type, Type>, string> <>9__7_3;
		}
	}
}
