using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace ReLogic.Reflection
{
	// Token: 0x02000DE5 RID: 3557
	[Token(Token = "0x2000DE5")]
	public class IdDictionary
	{
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06006878 RID: 26744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B23")]
		public IEnumerable<string> Names
		{
			[Token(Token = "0x6006878")]
			[Address(RVA = "0xB7FE78", Offset = "0xB7FE78", VA = "0xB7FE78")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006879")]
		[Address(RVA = "0xB7FEDC", Offset = "0xB7FEDC", VA = "0xB7FEDC")]
		private IdDictionary(int count)
		{
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x0002F808 File Offset: 0x0002DA08
		[Token(Token = "0x600687A")]
		[Address(RVA = "0xB7FF7C", Offset = "0xB7FF7C", VA = "0xB7FF7C")]
		public bool TryGetName(int id, out string name)
		{
			return default(bool);
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x0002F820 File Offset: 0x0002DA20
		[Token(Token = "0x600687B")]
		[Address(RVA = "0xB7FFF0", Offset = "0xB7FFF0", VA = "0xB7FFF0")]
		public bool TryGetId(string name, out int id)
		{
			return default(bool);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x0002F838 File Offset: 0x0002DA38
		[Token(Token = "0x600687C")]
		[Address(RVA = "0xB80064", Offset = "0xB80064", VA = "0xB80064")]
		public bool ContainsName(string name)
		{
			return default(bool);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x0002F850 File Offset: 0x0002DA50
		[Token(Token = "0x600687D")]
		[Address(RVA = "0xB800D0", Offset = "0xB800D0", VA = "0xB800D0")]
		public bool ContainsId(int id)
		{
			return default(bool);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687E")]
		[Address(RVA = "0xB8013C", Offset = "0xB8013C", VA = "0xB8013C")]
		public string GetName(int id)
		{
			return null;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x0002F868 File Offset: 0x0002DA68
		[Token(Token = "0x600687F")]
		[Address(RVA = "0xB801A8", Offset = "0xB801A8", VA = "0xB801A8")]
		public int GetId(string name)
		{
			return 0;
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006880")]
		[Address(RVA = "0xB80214", Offset = "0xB80214", VA = "0xB80214")]
		public void Add(string name, int id)
		{
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006881")]
		[Address(RVA = "0xB802C8", Offset = "0xB802C8", VA = "0xB802C8")]
		public void Remove(string name)
		{
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006882")]
		[Address(RVA = "0xB803B0", Offset = "0xB803B0", VA = "0xB803B0")]
		public void Remove(int id)
		{
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006883")]
		[Address(RVA = "0xB80498", Offset = "0xB80498", VA = "0xB80498")]
		public static IdDictionary Create(Type idClass, Type idType)
		{
			return null;
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006884")]
		public static IdDictionary Create<IdClass, IdType>()
		{
			return null;
		}

		// Token: 0x0400A4ED RID: 42221
		[Token(Token = "0x400A4ED")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, int> _nameToId;

		// Token: 0x0400A4EE RID: 42222
		[Token(Token = "0x400A4EE")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, string> _idToName;

		// Token: 0x0400A4EF RID: 42223
		[Token(Token = "0x400A4EF")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Count;

		// Token: 0x02000DE6 RID: 3558
		[Token(Token = "0x2000DE6")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06006885 RID: 26757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006885")]
			[Address(RVA = "0xB80A94", Offset = "0xB80A94", VA = "0xB80A94")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06006886 RID: 26758 RVA: 0x0002F880 File Offset: 0x0002DA80
			[Token(Token = "0x6006886")]
			[Address(RVA = "0xB80A9C", Offset = "0xB80A9C", VA = "0xB80A9C")]
			internal bool <Create>b__1(FieldInfo f)
			{
				return default(bool);
			}

			// Token: 0x06006887 RID: 26759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006887")]
			[Address(RVA = "0xB80B58", Offset = "0xB80B58", VA = "0xB80B58")]
			internal void <Create>b__2(FieldInfo field)
			{
			}

			// Token: 0x0400A4F0 RID: 42224
			[Token(Token = "0x400A4F0")]
			[FieldOffset(Offset = "0x8")]
			public Type idType;

			// Token: 0x0400A4F1 RID: 42225
			[Token(Token = "0x400A4F1")]
			[FieldOffset(Offset = "0xC")]
			public IdDictionary dictionary;
		}

		// Token: 0x02000DE7 RID: 3559
		[Token(Token = "0x2000DE7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006889 RID: 26761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006889")]
			[Address(RVA = "0xB80CEC", Offset = "0xB80CEC", VA = "0xB80CEC")]
			public <>c()
			{
			}

			// Token: 0x0600688A RID: 26762 RVA: 0x0002F898 File Offset: 0x0002DA98
			[Token(Token = "0x600688A")]
			[Address(RVA = "0xB80CF4", Offset = "0xB80CF4", VA = "0xB80CF4")]
			internal bool <Create>b__15_0(FieldInfo field)
			{
				return default(bool);
			}

			// Token: 0x0600688B RID: 26763 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
			[Token(Token = "0x600688B")]
			[Address(RVA = "0xB80D68", Offset = "0xB80D68", VA = "0xB80D68")]
			internal int <Create>b__15_3(KeyValuePair<string, int> kp)
			{
				return 0;
			}

			// Token: 0x0600688C RID: 26764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688C")]
			[Address(RVA = "0xB80DA8", Offset = "0xB80DA8", VA = "0xB80DA8")]
			internal string <Create>b__15_4(KeyValuePair<string, int> kp)
			{
				return null;
			}

			// Token: 0x0400A4F2 RID: 42226
			[Token(Token = "0x400A4F2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly IdDictionary.<>c <>9;

			// Token: 0x0400A4F3 RID: 42227
			[Token(Token = "0x400A4F3")]
			[FieldOffset(Offset = "0x4")]
			public static Func<FieldInfo, bool> <>9__15_0;

			// Token: 0x0400A4F4 RID: 42228
			[Token(Token = "0x400A4F4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, int>, int> <>9__15_3;

			// Token: 0x0400A4F5 RID: 42229
			[Token(Token = "0x400A4F5")]
			[FieldOffset(Offset = "0xC")]
			public static Func<KeyValuePair<string, int>, string> <>9__15_4;
		}
	}
}
