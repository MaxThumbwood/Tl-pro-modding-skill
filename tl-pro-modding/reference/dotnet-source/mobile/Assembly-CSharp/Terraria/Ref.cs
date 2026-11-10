using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004F7 RID: 1271
	[Token(Token = "0x20004F7")]
	public class Ref<T>
	{
		// Token: 0x06003209 RID: 12809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003209")]
		public Ref()
		{
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600320A")]
		public Ref(T value)
		{
		}

		// Token: 0x04004268 RID: 17000
		[Token(Token = "0x4004268")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
