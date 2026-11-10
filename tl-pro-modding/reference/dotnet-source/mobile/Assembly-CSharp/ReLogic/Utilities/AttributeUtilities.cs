using System;
using System.Reflection;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DCC RID: 3532
	[Token(Token = "0x2000DCC")]
	public static class AttributeUtilities
	{
		// Token: 0x060067C3 RID: 26563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C3")]
		public static T GetAttribute<T>(MethodBase method) where T : Attribute
		{
			return null;
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C4")]
		public static T GetAttribute<T>(Enum value) where T : Attribute
		{
			return null;
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C5")]
		public static A GetCacheableAttribute<T, A>() where A : Attribute
		{
			return null;
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C6")]
		public static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x02000DCD RID: 3533
		[Token(Token = "0x2000DCD")]
		private static class TypeAttributeCache<T, A> where A : Attribute
		{
			// Token: 0x0400A4AB RID: 42155
			[Token(Token = "0x400A4AB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly A Value;
		}
	}
}
