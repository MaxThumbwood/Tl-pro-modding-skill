using System;
using Il2CppDummyDll;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000920 RID: 2336
	[Token(Token = "0x2000920")]
	public sealed class ChatCommandAttribute : Attribute
	{
		// Token: 0x06004E59 RID: 20057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x731964", Offset = "0x731964", VA = "0x731964")]
		public ChatCommandAttribute(string name)
		{
		}

		// Token: 0x04009304 RID: 37636
		[Token(Token = "0x4009304")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;
	}
}
