using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class GameServiceContainer : FileAPI
	{
		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0xE1E528", Offset = "0xE1E528", VA = "0xE1E528")]
		public GameServiceContainer()
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001858")]
		[Address(RVA = "0xE1FF5C", Offset = "0xE1FF5C", VA = "0xE1FF5C")]
		public void AddService(Type type, object provider)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001859")]
		[Address(RVA = "0xE1FFD0", Offset = "0xE1FFD0", VA = "0xE1FFD0", Slot = "4")]
		public object GetService(Type type)
		{
			return null;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0xE2005C", Offset = "0xE2005C", VA = "0xE2005C")]
		public void RemoveService(Type type)
		{
		}

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<Type, object> services;
	}
}
