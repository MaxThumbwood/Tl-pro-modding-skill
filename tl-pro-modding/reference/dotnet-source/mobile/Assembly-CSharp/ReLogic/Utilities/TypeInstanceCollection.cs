using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DD8 RID: 3544
	[Token(Token = "0x2000DD8")]
	internal class TypeInstanceCollection<BaseType> : FileAPI where BaseType : class
	{
		// Token: 0x06006803 RID: 26627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006803")]
		public void Register<T>(T instance) where T : BaseType
		{
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006804")]
		public T Get<T>() where T : BaseType
		{
			return null;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006805")]
		public void Remove<T>() where T : BaseType
		{
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x0002F268 File Offset: 0x0002D468
		[Token(Token = "0x6006806")]
		public bool Has<T>() where T : BaseType
		{
			return default(bool);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x0002F280 File Offset: 0x0002D480
		[Token(Token = "0x6006807")]
		public bool Has(Type type)
		{
			return default(bool);
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006808")]
		public void IfHas<T>(Action<T> callback) where T : BaseType
		{
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006809")]
		public U IfHas<T, U>(Func<T, U> callback) where T : BaseType
		{
			return null;
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680A")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680B")]
		public void Dispose()
		{
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680C")]
		public TypeInstanceCollection()
		{
		}

		// Token: 0x0400A4C8 RID: 42184
		[Token(Token = "0x400A4C8")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Type, BaseType> _services;

		// Token: 0x0400A4C9 RID: 42185
		[Token(Token = "0x400A4C9")]
		[FieldOffset(Offset = "0x0")]
		private bool _disposedValue;
	}
}
