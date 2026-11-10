using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	public sealed class OldAttribute : Attribute
	{
		// Token: 0x06003C0B RID: 15371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x1E55404", Offset = "0x1E55404", VA = "0x1E55404")]
		public OldAttribute()
		{
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x1E55460", Offset = "0x1E55460", VA = "0x1E55460")]
		public OldAttribute(string message)
		{
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079E")]
		public string Message
		{
			[Token(Token = "0x6003C0D")]
			[Address(RVA = "0x1E5547C", Offset = "0x1E5547C", VA = "0x1E5547C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400477C RID: 18300
		[Token(Token = "0x400477C")]
		[FieldOffset(Offset = "0x8")]
		private string message;
	}
}
