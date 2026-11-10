using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	internal sealed class ClassTypeConfig
	{
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003CA6 RID: 15526 RVA: 0x0001E738 File Offset: 0x0001C938
		[Token(Token = "0x170007A1")]
		public bool IsFrozen
		{
			[Token(Token = "0x6003CA6")]
			[Address(RVA = "0x1E5E2DC", Offset = "0x1E5E2DC", VA = "0x1E5E2DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x1E5E2EC", Offset = "0x1E5E2EC", VA = "0x1E5E2EC")]
		public ClassTypeConfig(Type type)
		{
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x1E5E308", Offset = "0x1E5E308", VA = "0x1E5E308")]
		public ClassTypeInfo Freeze()
		{
			return null;
		}

		// Token: 0x040047C5 RID: 18373
		[Token(Token = "0x40047C5")]
		[FieldOffset(Offset = "0x8")]
		public readonly Type Type;

		// Token: 0x040047C6 RID: 18374
		[Token(Token = "0x40047C6")]
		[FieldOffset(Offset = "0xC")]
		public bool CloneByReference;

		// Token: 0x040047C7 RID: 18375
		[Token(Token = "0x40047C7")]
		[FieldOffset(Offset = "0xD")]
		public bool PrivateFieldsUnique;

		// Token: 0x040047C8 RID: 18376
		[Token(Token = "0x40047C8")]
		[FieldOffset(Offset = "0x10")]
		private ClassTypeInfo _frozen;
	}
}
