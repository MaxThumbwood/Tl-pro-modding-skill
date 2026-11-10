using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	internal class ClassTypeInfo
	{
		// Token: 0x06003CA9 RID: 15529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x1E5E3A0", Offset = "0x1E5E3A0", VA = "0x1E5E3A0")]
		public ClassTypeInfo(Type type, ClassTypeConfig config, ref ClassTypeInfo _out)
		{
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x1E5CA6C", Offset = "0x1E5CA6C", VA = "0x1E5CA6C")]
		public MethodInfo GetHelperMethod(string name)
		{
			return null;
		}

		// Token: 0x040047C9 RID: 18377
		[Token(Token = "0x40047C9")]
		[FieldOffset(Offset = "0x8")]
		public readonly Type Type;

		// Token: 0x040047CA RID: 18378
		[Token(Token = "0x40047CA")]
		[FieldOffset(Offset = "0xC")]
		public readonly bool CloneByReference;

		// Token: 0x040047CB RID: 18379
		[Token(Token = "0x40047CB")]
		[FieldOffset(Offset = "0xD")]
		public readonly bool PrivateFieldsUnique;

		// Token: 0x040047CC RID: 18380
		[Token(Token = "0x40047CC")]
		[FieldOffset(Offset = "0xE")]
		public readonly bool NeedsPolymorphicClone;

		// Token: 0x040047CD RID: 18381
		[Token(Token = "0x40047CD")]
		[FieldOffset(Offset = "0xF")]
		public readonly bool CloneByValue;

		// Token: 0x020005FC RID: 1532
		[Token(Token = "0x20005FC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003CAC RID: 15532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x1E5EBD4", Offset = "0x1E5EBD4", VA = "0x1E5EBD4")]
			public <>c()
			{
			}

			// Token: 0x06003CAD RID: 15533 RVA: 0x0001E750 File Offset: 0x0001C950
			[Token(Token = "0x6003CAD")]
			[Address(RVA = "0x1E5EBDC", Offset = "0x1E5EBDC", VA = "0x1E5EBDC")]
			internal bool <.ctor>b__5_0(ClassTypeInfo c)
			{
				return default(bool);
			}

			// Token: 0x06003CAE RID: 15534 RVA: 0x0001E768 File Offset: 0x0001C968
			[Token(Token = "0x6003CAE")]
			[Address(RVA = "0x1E5EC00", Offset = "0x1E5EC00", VA = "0x1E5EC00")]
			internal bool <.ctor>b__5_1(ClassTypeInfo c)
			{
				return default(bool);
			}

			// Token: 0x040047CE RID: 18382
			[Token(Token = "0x40047CE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ClassTypeInfo.<>c <>9;

			// Token: 0x040047CF RID: 18383
			[Token(Token = "0x40047CF")]
			[FieldOffset(Offset = "0x4")]
			public static Func<ClassTypeInfo, bool> <>9__5_0;

			// Token: 0x040047D0 RID: 18384
			[Token(Token = "0x40047D0")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ClassTypeInfo, bool> <>9__5_1;
		}
	}
}
