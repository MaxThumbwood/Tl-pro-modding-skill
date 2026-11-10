using System;
using Il2CppDummyDll;

namespace Telepathy
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public struct Message
	{
		// Token: 0x0600162C RID: 5676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162C")]
		[Address(RVA = "0xE09CB8", Offset = "0xE09CB8", VA = "0xE09CB8")]
		public Message(int connectionId, EventType eventType, byte[] data)
		{
		}

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x0")]
		public readonly int connectionId;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x4")]
		public readonly EventType eventType;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x8")]
		public readonly byte[] data;
	}
}
